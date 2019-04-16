Imports System.Text

Public Class Form1

    Dim i As Integer

    Private Sub Start_Click(sender As Object, e As EventArgs) Handles Start.Click

        Dim session As Object
        'Dim order As String
        Dim counter As Integer = 0

        Try
            'connect to session
            session = SessionConnect()

            'go to migo confirmation
            GoToMigoConfirmation(session)
            'read items from list 1
            For i = 0 To ListBox1.Items.Count - 1
                If MigoConfirm(ListBox1.Items(i - counter).ToString, session) = True Then
                    ListBox1.GetSelected(i - counter)
                    ListBox4.Items.Add(ListBox1.Items(i - counter))
                    ListBox1.Items.RemoveAt(i - counter)
                    counter = counter + 1
                End If
            Next

            If ListBox4.Items.Count > 0 Then
                'go to time confirmation transaction
                counter = 0
                GoToTimeConfirmation(session)

                ' step to confirm times from list 4
                ' reading from list 4
                For i = 0 To ListBox4.Items.Count - 1

                    'Try to confirm item
                    'move to TimeConfirm function, if the result of confirmation is true move the order to next list
                    If TimeConfirm(ListBox4.Items(i - counter).ToString, session) = True Then
                        ListBox4.GetSelected(i - counter)
                        ListBox2.Items.Add(ListBox4.Items(i - counter))
                        ListBox4.Items.RemoveAt(i - counter)
                        counter = counter + 1
                    End If
                Next i
            End If

            'step to close order from list2
            'reading list2 items
            'if items on list go further, else stop
            If ListBox2.Items.Count > 0 Then
                'use counter to update the number of items in the list
                counter = 0

                'go to order confirmation transaction
                GoToOrderConfirmation(session)
                ' Going from list 2 to list 3
                For i = 0 To ListBox2.Items.Count - 1
                    'Try To confirm item
                    'move to OrderConfirm function, if the result of confirmation is true move the order to next list
                    If OrderConfirm(ListBox2.Items(i - counter), session) = True Then
                        ListBox2.GetSelected(i - counter)
                        ListBox3.Items.Add(ListBox2.Items(i - counter))
                        ListBox2.Items.RemoveAt(i - counter)
                        counter = counter + 1
                    End If
                Next i

            End If
        Catch ex As Exception
            MsgBox("Eroare din Main")

        End Try

    End Sub

    Function GoToTimeConfirmation(ByVal session As Object)

        'go to transaction CO11n
        Try
            session.findById("wnd[0]").resizeWorkingPane(247, 39, False)
            session.findById("wnd[0]/tbar[0]/okcd").text = "/nco11n"
            session.findById("wnd[0]").sendVKey(0)
        Catch ex As Exception
            MsgBox("Conecteaza-te!")
            Return 0
        End Try

    End Function

    Function GoToOrderConfirmation(ByVal session As Object)

        'go to transaction CO02
        Try
            session.findById("wnd[0]").resizeWorkingPane(247, 39, False)
            session.findById("wnd[0]/tbar[0]/okcd").text = "/nco02"
            session.findById("wnd[0]").sendVKey(0)
        Catch ex As Exception
            MsgBox("Conecteaza-te!")
            Return 0
        End Try
    End Function

    Function GoToMigoConfirmation(ByVal session As Object) As Boolean

        'go to transaction MIGO GOODS RECEIVED
        Try
            session.findById("wnd[0]").resizeWorkingPane(247, 39, False)
            session.findById("wnd[0]/tbar[0]/okcd").text = "/nMIGO"
            session.findById("wnd[0]").sendVKey(0)
            'session.findById("wnd[0]/usr/ssubSUB_MAIN_CARRIER:SAPLMIGO:0003/subSUB_FIRSTLINE:SAPLMIGO:0010/subSUB_FIRSTLINE_REFDOC:SAPLMIGO:2010/txtGODYNPRO-MAT_DOC").text = ""
            'session.findById("wnd[0]/usr/ssubSUB_MAIN_CARRIER:SAPLMIGO:0003/subSUB_FIRSTLINE:SAPLMIGO:0010/cmbGODYNPRO-ACTION").setFocus
            session.findById("wnd[0]/usr/ssubSUB_MAIN_CARRIER:SAPLMIGO:0003/subSUB_FIRSTLINE:SAPLMIGO:0010/cmbGODYNPRO-ACTION").key = "A01"
            'session.findById("wnd[0]/usr/ssubSUB_MAIN_CARRIER:SAPLMIGO:0003/subSUB_FIRSTLINE:SAPLMIGO:0010/cmbGODYNPRO-REFDOC").setFocus
            session.findById("wnd[0]/usr/ssubSUB_MAIN_CARRIER:SAPLMIGO:0003/subSUB_FIRSTLINE:SAPLMIGO:0010/cmbGODYNPRO-REFDOC").key = "R08"
            session.findById("wnd[0]/usr/ssubSUB_MAIN_CARRIER:SAPLMIGO:0003/subSUB_FIRSTLINE:SAPLMIGO:0010/ctxtGODEFAULT_TV-BWART").text = "101"
            session.findById("wnd[0]").sendVKey(0)
        Catch ex As Exception
            MsgBox("Conecteaza-te!")
            Return 0
        End Try

    End Function

    Function MigoConfirm(ByVal order As String, session As Object) As Boolean
        Dim MigoStatus As Boolean = False

        If order <> "" Then
            session.findById("wnd[0]/usr/ssubSUB_MAIN_CARRIER:SAPLMIGO:0003/subSUB_FIRSTLINE:SAPLMIGO:0010/subSUB_FIRSTLINE_REFDOC:SAPLMIGO:2070/ctxtGODYNPRO-ORDER_NUMBER").text = order
            session.findById("wnd[0]/usr/ssubSUB_MAIN_CARRIER:SAPLMIGO:0003/subSUB_FIRSTLINE:SAPLMIGO:0010/subSUB_FIRSTLINE_REFDOC:SAPLMIGO:2070/ctxtGODYNPRO-ORDER_NUMBER").caretPosition = 9
            session.findById("wnd[0]").sendVKey(0)
            Try
                session.findById("wnd[0]/usr/ssubSUB_MAIN_CARRIER:SAPLMIGO:0003/subSUB_ITEMDETAIL:SAPLMIGO:0301/subSUB_DETAIL:SAPLMIGO:0300/subSUB_DETAIL_TAKE:SAPLMIGO:0304/chkGODYNPRO-DETAIL_TAKE").selected = True
                session.findById("wnd[0]/usr/ssubSUB_MAIN_CARRIER:SAPLMIGO:0003/subSUB_ITEMDETAIL:SAPLMIGO:0301/subSUB_DETAIL:SAPLMIGO:0300/subSUB_DETAIL_TAKE:SAPLMIGO:0304/chkGODYNPRO-DETAIL_TAKE").setFocus
                session.findById("wnd[0]/tbar[0]/btn[11]").press
                MigoStatus = True
                Threading.Thread.Sleep(1000)
            Catch ex As Exception
                MigoStatus = False
                Threading.Thread.Sleep(1000)
            End Try

        End If

        Return MigoStatus

    End Function

    'time confirm function
    'receives session and order params
    'returns true or false depending of the result of the confirmation
    Function TimeConfirm(ByVal order As String, session As Object) As Boolean
        'TimeStatus param to evaluate the result of the confirmation
        Dim TimeStatus As Boolean = False
        'OperationExist to evaluate if other operation exist
        Dim OperationExist As Boolean = True

        Dim SaveSucces As String = ""

        'params to check number of operated cycles
        Dim CheckNumberOfOperations As Integer = 0
        Dim NumberOfOperations As Integer = 0

        'make at least one try to evaluate the order
        Do
            NumberOfOperations = NumberOfOperations + 1
            session.findById("wnd[0]/usr/ssubSUB01:SAPLCORU_S:0010/subSLOT_HDR:SAPLCORU_S:0117/ctxtAFRUD-AUFNR").text = order
            session.findById("wnd[0]/usr/ssubSUB01:SAPLCORU_S:0010/subSLOT_HDR:SAPLCORU_S:0117/ctxtAFRUD-VORNR").setFocus
            session.findById("wnd[0]/usr/ssubSUB01:SAPLCORU_S:0010/subSLOT_HDR:SAPLCORU_S:0117/ctxtAFRUD-VORNR").caretPosition = 0
            session.findById("wnd[0]").sendVKey(4)

            'if window apeared evaluate the type of
            If session.ActiveWindow.Name = "wnd[1]" Then
                'OperationExist sau comanda nu exista
                session.findById("wnd[1]/tbar[0]/btn[0]").press
                session.findById("wnd[0]").sendVKey(0)
                session.findById("wnd[0]/tbar[0]/btn[11]").press

                'construct the status bar message for succes 
                SaveSucces = "Confirmare c-dă " + order + " salvată"
                If session.FindById("wnd[0]/sbar").Text = SaveSucces Then
                    OperationExist = True
                    CheckNumberOfOperations = CheckNumberOfOperations + 1
                Else
                    OperationExist = False
                End If
                ' if there are nu values the order has been confirmated before running program
            ElseIf session.FindById("wnd[0]/sbar").Text = "Nu au fost găsite valori" Then
                OperationExist = False
                CheckNumberOfOperations = CheckNumberOfOperations + 1

                'any other error make exit the lood
            Else
                OperationExist = False
            End If
        Loop While OperationExist

        'evaluate if there are more than one operation confimed
        If CheckNumberOfOperations = 0 Then
            TimeStatus = False
        ElseIf CheckNumberOfOperations = NumberOfOperations - 1 Then
            TimeStatus = True
        ElseIf CheckNumberOfOperations = NumberOfOperations Then
            TimeStatus = True
        Else
            TimeStatus = False
        End If

        Return TimeStatus

    End Function

    Function OrderConfirm(ByVal order As String, session As Object) As Boolean
        'OrderStatus param to evaluate the result of the confirmation
        Dim OrderStatus As Boolean = False

        'if there is an order go to confirmation
        If order <> "" Then
            session.findById("wnd[0]/usr/ctxtCAUFVD-AUFNR").text = order
            session.findById("wnd[0]/usr/ctxtCAUFVD-AUFNR").caretPosition = 9
            session.findById("wnd[0]").sendVKey(0)
            'if wnd[1] appears order allready confirmed
            If session.ActiveWindow.Name = "wnd[1]" Then
                session.findById("wnd[1]/tbar[0]/btn[0]").press
                session.findById("wnd[0]/tbar[0]/btn[11]").press
                OrderStatus = False
            Else
                'confirm the order
                session.findById("wnd[0]/mbar/menu[1]/menu[9]/menu[3]").select
                session.findById("wnd[0]/tbar[0]/btn[11]").press
                session.findById("wnd[0]/usr/ctxtCAUFVD-AUFNR").text = ""
                session.findById("wnd[0]/usr/ctxtCAUFVD-AUFNR").caretPosition = 0
                OrderStatus = True
            End If
        End If
        Return OrderStatus
    End Function

    'connect to SAP Object
    Function SessionConnect() As Object

        Dim SapGuiAuto As Object
        Dim Application As Object
        Dim connection As Object
        Dim session As Object
        Try
            SapGuiAuto = GetObject("SAPGUI")
            Application = SapGuiAuto.GetScriptingEngine
            connection = Application.Children(0)
            session = connection.Children(0)
            session.findById("wnd[0]").resizeWorkingPane(247, 39, False)
            Return session
        Catch ex As Exception
            MsgBox("Conecteaza-te!")
            Return 0
        End Try
        Return session
    End Function



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles PasteButton.Click
        Try
            Dim s As String = Clipboard.GetText()
            Dim lines() As String = s.Split
            For Each line In lines
                If line.Length > 0 Then
                    ListBox1.Items.Add(line.Trim)
                End If

            Next

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles CopyButtonList1.Click

        Try
            Dim sb As New StringBuilder
            For Each row In ListBox1.SelectedItem
                sb.Append(row.ToString)
                'sb.AppendLine()
            Next
            Clipboard.SetData(DataFormats.Text, sb.ToString)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles CopyButtonList2.Click
        Try
            Dim sb As New StringBuilder
            For Each row In ListBox2.SelectedItem
                sb.Append(row.ToString)
                'sb.AppendLine()
            Next
            Clipboard.SetData(DataFormats.Text, sb.ToString)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles CopyButtonList3.Click
        Try
            Dim sb As New StringBuilder
            For Each row In ListBox3.SelectedItem
                sb.Append(row.ToString)
                'sb.AppendLine()
            Next
            Clipboard.SetData(DataFormats.Text, sb.ToString)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub CopyButtonList4_Click(sender As Object, e As EventArgs) Handles CopyButtonList4.Click
        Try
            Dim sb As New StringBuilder
            For Each row In ListBox4.SelectedItem
                sb.Append(row.ToString)
                'sb.AppendLine()
            Next
            Clipboard.SetData(DataFormats.Text, sb.ToString)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles ClearButtonList1.Click
        ListBox1.Items.Clear()
    End Sub

    Private Sub ClearButtonList2_Click(sender As Object, e As EventArgs) Handles ClearButtonList2.Click
        ListBox2.Items.Clear()
    End Sub

    Private Sub ClearButtonList3_Click(sender As Object, e As EventArgs) Handles ClearButtonList3.Click
        ListBox3.Items.Clear()
    End Sub

    Private Sub ClearButtonList4_Click(sender As Object, e As EventArgs) Handles ClearButtonList4.Click
        ListBox4.Items.Clear()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Me.Close()
    End Sub

End Class
