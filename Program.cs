using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Lab8;
using Newtonsoft.Json;

namespace Lab9
{
    interface IView
    {
        string FirstDirectory();
        string SecondDirectory();
        string LogDirectory();

        void ShowFilesOfFirstDirectory(List<string> list);
        void ShowFilesOfSecondDirectory(List<string> list);
        void TrySynchronize(List<string> message);

        event EventHandler<EventArgs> SyncronizeDirectoriesEvent;
        event EventHandler<EventArgs> ShowFilesOfFirstDirectoryEvent;
        event EventHandler<EventArgs> ShowFilesOfSecondDirectoryEvent;
        event EventHandler<EventArgs> SaveChangesInXMLFile;
        event EventHandler<EventArgs> SaveChangesInJSONFile;

    }

    class Model
    {
        private XmlLogger newLog;
        private JsonLogger newJsonLog;

        public void SetLogPaths(string path)
        {
            newLog = new XmlLogger(path + "\\log.xml");
            newJsonLog = new JsonLogger(path + "\\log.json");
        }

        //Проверка для "рекомендации"
        public string CheckForRecommendation()
        {
            string resultOfCheck = newLog.GetLastString();
            return resultOfCheck;
        }

        public List<string> ListOfFilesInDirectory(string directory)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(directory);

            List<string> resultOfList = new List<string>();
            foreach (FileInfo directoryFile in directoryInfo.GetFiles())
            {
                resultOfList.Add($"{directoryFile.Name}");
            }

            return resultOfList;
        }

        public List<string> SynchronizeDirectories(string firstDirectory, string secondDirectory)
        {
            DirectoryInfo mainDirectoryInfo = new DirectoryInfo(firstDirectory);
            DirectoryInfo targetDirectoryInfo = new DirectoryInfo(secondDirectory);
            List<string> resultOfSynchronize;

            if (!mainDirectoryInfo.Exists || !targetDirectoryInfo.Exists)
            {
                newLog.CreateLog("Accessing a non-existent directory");
                newJsonLog.CreateLog("Accessing a non-existent directory");

                throw new DirectoryNotFoundException("Accessing a non-existent directory");
            }

            resultOfSynchronize = InnerSynchronizeDirectories(targetDirectoryInfo, mainDirectoryInfo);
            return resultOfSynchronize;

        }

        private List<string> InnerSynchronizeDirectories(DirectoryInfo mainDirectoryInfo, DirectoryInfo targetDirectoryInfo)
        {
            List<string> innerResultOfSynchronize = new List<string>();
            bool isNeedToSynchronize = false;

            foreach (FileInfo directoryFile in mainDirectoryInfo.GetFiles())
            {
                FileInfo targetFileInOtherDirectory = new FileInfo(Path.Combine(targetDirectoryInfo.FullName, directoryFile.Name));

                if (!targetFileInOtherDirectory.Exists || targetFileInOtherDirectory.LastWriteTime != directoryFile.LastWriteTime) // Не существует или записан ранее - заменяем
                {
                    newLog.CreateLog($"File {directoryFile.Name} was changed");
                    newJsonLog.CreateLog($"File {directoryFile.Name} was changed");

                    //Можно ли скопировать файл?
                    try
                    {
                        File.Copy(directoryFile.FullName, targetFileInOtherDirectory.FullName, true);
                    }
                    catch (Exception fileException)
                    {

                        newLog.CreateLog("Error copying the file." + fileException.ToString());
                        newJsonLog.CreateLog("Error copying the file." + fileException.ToString());

                        throw new Exception("Error copying the file.", fileException);
                    }

                    innerResultOfSynchronize.Add($"File {directoryFile.Name} was changed");
                    isNeedToSynchronize = true;
                }
            }

            foreach (FileInfo directoryFile in targetDirectoryInfo.GetFiles())
            {
                FileInfo fileInMainDirectory = new FileInfo(Path.Combine(mainDirectoryInfo.FullName, directoryFile.Name));

                if (!fileInMainDirectory.Exists)
                {
                    newLog.CreateLog($"File {directoryFile.Name} was deleted");
                    newJsonLog.CreateLog($"File {directoryFile.Name} was changed");

                    //Можно ли удалить файл?
                    try
                    {
                        directoryFile.Delete();
                    }
                    catch (Exception fileException)
                    {
                        newLog.CreateLog("Error copying the file." + fileException.ToString());
                        newJsonLog.CreateLog("Error copying the file." + fileException.ToString());

                        throw new Exception("Error copying the file.", fileException);
                    }

                    innerResultOfSynchronize.Add($"File {directoryFile.Name} was deleted");
                    isNeedToSynchronize = true;
                }
            }

            if (!isNeedToSynchronize)
            {
                newLog.CreateLog("No changes");
                newJsonLog.CreateLog("No changes");

                innerResultOfSynchronize.Add("No changes");
            }

            return innerResultOfSynchronize;
        }
    }

    class Presenter
    {
        private IView mainView;
        private Model model;

        public Presenter(IView inputView)
        {
            mainView = inputView;
            model = new Model();

            mainView.SyncronizeDirectoriesEvent += new EventHandler<EventArgs>(Synchronize);
            mainView.ShowFilesOfFirstDirectoryEvent += new EventHandler<EventArgs>(ShowFilesInFirstDirectory);
            mainView.ShowFilesOfSecondDirectoryEvent += new EventHandler<EventArgs>(ShowFilesInSecondDirectory);

        }

        private void Synchronize(object sender, EventArgs inputEvent)
        {
            List<string> resultOfSynchronization = model.SynchronizeDirectories(mainView.FirstDirectory(), mainView.SecondDirectory());

            mainView.TrySynchronize(resultOfSynchronization);
        }

        private void ShowFilesInFirstDirectory(object sender, EventArgs inputEvent)
        {
            List<string> listOfFilesInFirstDirectory = model.ListOfFilesInDirectory(mainView.FirstDirectory());

            mainView.ShowFilesOfFirstDirectory(listOfFilesInFirstDirectory);
        }

        private void ShowFilesInSecondDirectory(object sender, EventArgs inputEvent)
        {
            List<string> listOfFilesInFirstDirectory = model.ListOfFilesInDirectory(mainView.SecondDirectory());

            mainView.ShowFilesOfSecondDirectory(listOfFilesInFirstDirectory);
        }

        private void ShowChangesInXmlFile(object sender, EventArgs inputEvent)
        {

        }
    }

    internal static class Program
    {

        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
