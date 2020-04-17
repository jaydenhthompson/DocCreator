using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;

using Microsoft.Office.Interop.Word;

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
            //word.Visible = true; // enable for debugging

            // Calculate maximum picture width / height
            var widthMargins = document.PageSetup.LeftMargin + document.PageSetup.RightMargin;
            var heightMargins = document.PageSetup.TopMargin + document.PageSetup.BottomMargin;
            var imageWidth = document.PageSetup.PageWidth - widthMargins;
            var imageHeight = document.PageSetup.PageHeight - heightMargins;

            foreach (var file in files)
            {
                var newParagraph = document.Paragraphs.Add();
                newParagraph.PageBreakBefore = -1;
                InlineShape map = document.InlineShapes.AddPicture(file, Range: newParagraph.Range);
                if (map.Width > map.Height)
                {
                    var ratio = map.Height / map.Width;
                    map.Width = imageWidth;
                    map.Height = map.Width * ratio;
                }
                else
                {
                    var ratio = map.Width / map.Height;
                    map.Height = imageHeight;
                    map.Width = map.Height * ratio;
                }
            }

            //document.Saved = true; // Enable for debugging 
            document.Save();
            word.Quit();

            return true;
        }

        private void AddNewElement(string filePath)
        {
        }
    }
}
