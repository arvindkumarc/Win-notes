using System;
using System.IO;
using System.IO.IsolatedStorage;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace Note_a_rious
{
    public class Storage
    {
        IsolatedStorageFile storage = IsolatedStorageFile.GetUserStoreForApplication();

        public void Save(String ContentToBeSaved)
        {
            if (!storage.DirectoryExists("Text"))
                storage.CreateDirectory("Text");
            StreamWriter writeFile = new StreamWriter(new IsolatedStorageFileStream("Text/" + DateTime.Now, FileMode.CreateNew, storage)));
            {
                writeFile.Write(ContentToBeSaved);
            };
        }
    }
}
