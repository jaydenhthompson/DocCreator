using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace DocCreator
{
    partial class DocCore
    {
        private readonly string folderPath;

        public DocCore()
        {
        }

        public DocCore(string path)
        {
            this.folderPath = path;
        }

        public bool Docufy(string startFile)
        {
            var files = new List<string>(Directory.GetFiles(this.folderPath));
            files.RemoveAll(file => Path.GetExtension(file).ToLower() != "jpg");
            if(files.Count() < 1)
            {
                return false;
            }

            Microsoft.Office.interop

            return true;
        }

        private void CreateDoc(string fileName)
        {
        }

        private void AddNewElement(string filePath)
        {
        }
    }
}
