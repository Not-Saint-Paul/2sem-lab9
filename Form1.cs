using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Lab9
{
    public partial class Form1 : Form, IView
    {
        public Form1()
        {
            InitializeComponent();
            Presenter programPresenter = new Presenter(this);
        }
        public event EventHandler<EventArgs> SyncronizeDirectoriesEvent;
        public event EventHandler<EventArgs> ShowFilesOfFirstDirectoryEvent;
        public event EventHandler<EventArgs> ShowFilesOfSecondDirectoryEvent;
        public event EventHandler<EventArgs> SaveChangesInXMLFile;
        public event EventHandler<EventArgs> SaveChangesInJSONFile;

        string IView.FirstDirectory() { return FirstDirTextBox.Text; }
        string IView.SecondDirectory() { return SecondDirTextBox.Text; }
        string IView.LogDirectory() { return changesSaveDirectoryTextBox.Text; }

        void IView.ShowFilesOfFirstDirectory(List<string> list)
        {
            List<string> outputList = list;
            foreach (string output in outputList)
            {
                FirstDirListBox.Items.Add(output);
            }
        }

        void IView.ShowFilesOfSecondDirectory(List<string> list)
        {
            List<string> outputList = list;
            foreach (string output in outputList)
            {
                SecondDirListBox.Items.Add(output);
            }
        }

        void IView.TrySynchronize(List<string> message)
        {

            List<string> outputList = message;

            foreach (string output in outputList)
            {
                ChangesListBox.Items.Add(output);
            }

        }

        private void CheckOutButton_Click(object sender, EventArgs inputEvent)
        {
            SyncronizeDirectoriesEvent(sender, inputEvent);
            ShowFilesOfFirstDirectoryEvent(sender, inputEvent);
            ShowFilesOfSecondDirectoryEvent(sender, inputEvent);
        }

        private void changesSaveButton_Click(object sender, EventArgs inputEvent)
        {
            SaveChangesInXMLFile(sender, inputEvent);
        }

        private void saveAsJsonFileButton_Click(object sender, EventArgs inputEvent)
        {
            SaveChangesInJSONFile(sender, inputEvent);
        }
    }
}
