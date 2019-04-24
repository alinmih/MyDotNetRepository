using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.IsolatedStorage;

namespace BackUp
{
    class Program
    {
        private const string OPTIONSFOLDER = "BackUpOptionsFolder";
        private const string OPTIONSFILE = "BackUpOptions";

        static void Main(string[] args)
        {
            if (IsReplay(args))
            {
                PopulateFieldsFromIsolatedStorage(out args);
            }
            else
            {
                StoreOptionsInIsolatedStorage(args);
            }

            if (args.Length != 3)
            {
                Console.WriteLine("Usage: BackUp <source_folder> <destination_folder> <age>");
                throw new ArgumentException();
            }
            string sourceFolder = args[0];
            string destinationFolder = args[1];
            //parse int argument
            string age = args[2];
            int parsedInt = 0;
            int.TryParse(age, out parsedInt);

            //Console.WriteLine("{0}, {1}, {2}", sourceFolder, destinationFolder, parsedInt);

            CheckDirectories(sourceFolder, destinationFolder);
            if (BackUpFiles(sourceFolder, destinationFolder, parsedInt) == false)
            {
                throw new Exception("Backup not succesfull");
            }

            StoreOptionsInIsolatedStorage(args);

            //Console.ReadLine();
        }

        private static bool IsReplay(string[] args)
        {
            return args.Length == 1 & args[0] == "replay";
        }

        private static void CheckDirectories(string source, string dest)
        {
            if (!Directory.Exists(source))
            {
                throw new ArgumentException("Runtime error sourceFolder");
            }
            if (!Directory.Exists(dest))
            {
                Directory.CreateDirectory(dest);
            }
        }


        private static bool BackUpFiles(string source, string dest, int age)
        {

            try
            {
                DirectoryInfo sourceInfo = new DirectoryInfo(source);
                DirectoryInfo destInfo = new DirectoryInfo(dest);

                FileInfo[] fileList = sourceInfo.GetFiles();

                foreach (var file in fileList)
                {
                    if ((file.CreationTimeUtc - DateTime.Now).TotalDays <= age)
                    {
                        string filePath = Path.Combine(destInfo.FullName, file.Name);
                        file.CopyTo(filePath, overwrite: true);

                    }

                }

                DirectoryInfo[] childFolderList = sourceInfo.GetDirectories();

                foreach (var folder in childFolderList)
                {
                    string folderPath = Path.Combine(destInfo.FullName, folder.Name);

                    DirectoryInfo dir = Directory.CreateDirectory(folderPath);
                    fileList = folder.GetFiles();
                    foreach (var file in fileList)
                    {
                        if ((file.CreationTimeUtc - DateTime.Now).TotalDays <= age)
                        {
                            string filePath = Path.Combine(dir.FullName, file.Name);
                            file.CopyTo(filePath, overwrite: true);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
                return false;
            }
            return true;
        }

        private static void StoreOptionsInIsolatedStorage(string[] args)
        {
            IsolatedStorageFile store = IsolatedStorageFile.GetUserStoreForDomain();

            store.CreateDirectory(OPTIONSFOLDER);

            string storeFilePath = Path.Combine(OPTIONSFOLDER, OPTIONSFILE);

            IsolatedStorageFileStream storeStream = new IsolatedStorageFileStream(storeFilePath, FileMode.Create, FileAccess.ReadWrite);

            StreamWriter storeWriter = new StreamWriter(storeStream);

            storeWriter.WriteLine(args[0]);
            storeWriter.WriteLine(args[1]);
            storeWriter.WriteLine(args[2]);

            storeWriter.Close();
            storeStream.Close();
            store.Close();

        }

        private static void PopulateFieldsFromIsolatedStorage(out string[] args)
        {
            args = new string[3];
            IsolatedStorageFile store = IsolatedStorageFile.GetUserStoreForDomain();

            if (!store.DirectoryExists(OPTIONSFOLDER))
            {
                throw new ArgumentException("Folder does not exists");
            }

            string filePath = Path.Combine(OPTIONSFOLDER, OPTIONSFILE);
            IsolatedStorageFileStream storeStream = new IsolatedStorageFileStream(filePath, FileMode.Open, FileAccess.Read);

            StreamReader storeReader = new StreamReader(storeStream);

            args[0] = storeReader.ReadLine();
            args[1] = storeReader.ReadLine();
            args[2] = storeReader.ReadLine();

            storeReader.Close();
            storeStream.Close();
            store.Close();
        }
    }
}

