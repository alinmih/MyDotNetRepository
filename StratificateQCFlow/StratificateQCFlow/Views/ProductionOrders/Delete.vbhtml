@ModelType StratificateQCFlow.Models.ProductionOrder
@Code
    ViewData("Title") = "Delete"
End Code

<h2>Delete</h2>

<h3>Are you sure you want to delete this?</h3>
<div>
    <h4>ProductionOrder</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.Order)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Order)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.ReleaseDate)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.ReleaseDate)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.QuantityOK)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.QuantityOK)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.QuantityNOK)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.QuantityNOK)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Batch)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Batch)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.User)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.User)
        </dd>

    </dl>
    @Using (Html.BeginForm())
        @Html.AntiForgeryToken()

        @<div class="form-actions no-color">
            <input type="submit" value="Delete" class="btn btn-default" /> |
            @Html.ActionLink("Back to List", "Index")
        </div>
    End Using
</div>
