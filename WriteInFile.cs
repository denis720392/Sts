using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkingWithProducts.Interfaces;
using static System.Net.Mime.MediaTypeNames;

namespace WorkingWithProducts
{
    internal class WriteInFile : IWriter
    {
        private string path;
        private string text;
        public string Text
        {
            get
            {
                return text;
            }
        }
        public string Path
        {
            get
            {
                return path;
            }
        }

        public WriteInFile(string path, string text) 
        {
            this.path = path;
            this.text = text;
        }

        public void Write() 
        {
            File.AppendAllText(path, "\n" + text);
        }
    }
}
