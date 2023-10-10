using Sts.Product.Common.Interfaces;

namespace Sts.Product.Common.Utilities
{
    public class WriteInFile : IWriter
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
            File.AppendAllText(path, text + "\n");
        }
    }
}
