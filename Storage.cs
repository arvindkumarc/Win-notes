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
        

        public void Save(String ContentToBeSaved)
        {
            
            using (IsolatedStorageFile storage = IsolatedStorageFile.GetUserStoreForApplication())
            {
                using (IsolatedStorageFileStream stream = new IsolatedStorageFileStream(String.Concat(storage.GetFileNames().Length + 1), FileMode.CreateNew, storage))
                {
                    using (StreamWriter writeFile = new StreamWriter(stream))
                    {
                        writeFile.WriteLine(ContentToBeSaved);
                    }
                }
            }
            
        }
    }
}
