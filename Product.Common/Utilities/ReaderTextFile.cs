using Sts.Product.Common.Interfaces;

namespace Sts.Product.Common.Utilities
{
    public class ReaderTextFile : IReader
    {
        private string path;
        private string text;
        public string Text { get 
            {
                return text;
            }
        }
        public string Path { get 
            {
                return path;
            }
        }

        public ReaderTextFile(string path) 
        {
            this.path = path;
            text = "";
        }
        public string Read() 
        {
            text = File.ReadAllText(path);
            return text;
        }
    }
}
