using System.Collections.Generic;
using System.IO;
using System.Linq;

using Microsoft.Office.Interop.Word;

namespace DocCreator
{
    partial class DocCore
    {
        private readonly string folderPath;
        private string startFilePath;

        public DocCore()
        {
        }

        public DocCore(string path)
        {
            this.folderPath = path;
        }

        public bool Docufy(string startFile)
        {
            // Load Files into list
            var files = new List<string>(Directory.GetFiles(this.folderPath));

            // Remove all non jpg files from the list and verify there are files left
            files.RemoveAll(file => Path.GetExtension(file).ToLower() != ".jpg");
            if(files.Count() < 1)
            {
                return false;
            }

            Application word = new Application();
            Document document = word.Documents.Open(startFile);
            word.Visible = true;

            foreach(var file in files)
            {
                var newParagraph = document.Paragraphs.Add();
                newParagraph.Range.InsertBreak(WdBreakType.wdPageBreak);
                document.InlineShapes.AddPicture(file, Range: newParagraph.Range);
            }

            //wordDoc.Save();
            document.Saved = true;
            word.Quit();

            return true;
        }

        private void AddNewElement(string filePath)
        {
        }
    }
}
