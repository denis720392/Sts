using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkingWithProducts.Interfaces;

namespace WorkingWithProducts
{
    internal class ReaderFile : IReader
    {
        private string path = Directory.GetCurrentDirectory() + "\\";
        public string Path {
            get 
            {
                if (path == null) { return Directory.GetCurrentDirectory() + "\\"; }
                else { return path; }
            }
            set 
            {
                path = value;
            } 
        }
        public ReaderFile(string nameFile) 
        {
           path += nameFile;
        }

        public string ReadAllText() 
        {
            return File.ReadAllText(path);
        }
    }
}
