using Microsoft.Office.Interop.Word;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace DocCreator
{
    partial class DocCore
    {
        private readonly string folderPath;
        private readonly Config config;

        public DocCore(string path)
        {
            this.folderPath = path;
        }

        /// <summary>
        /// Turns a folder of jpgs into a word document
        /// </summary>
        /// <param name="startFilePath">
        /// Path to the existing Word Document
        /// </param>
        /// <returns>
        /// Returns a bool indicating success
        /// </returns>
        public bool Docufy(string startFilePath)
        {
            // Load Files into list
            var files = new List<string>(Directory.GetFiles(this.folderPath));

            // Remove all non jpg files from the list and verify there are files left
            files.RemoveAll(file => Path.GetExtension(file).ToLower() != ".jpg");
            if (files.Count() < 1)
            {
                return false;
            }

            Application word  = new Application();
            Document document = word.Documents.Open(startFilePath);
            //word.Visible    = true; // enable for debugging

            // Calculate maximum picture width / height
            var widthMargins  = document.PageSetup.LeftMargin + document.PageSetup.RightMargin;
            var heightMargins = document.PageSetup.TopMargin + document.PageSetup.BottomMargin;
            var imageWidth    = document.PageSetup.PageWidth - widthMargins;
            var imageHeight   = document.PageSetup.PageHeight - heightMargins;

            // Iterate through each file, give each picture a paragraph with a page break
            foreach (var file in files)
            {
                var newParagraph = document.Paragraphs.Add();
                InlineShape map  = document.InlineShapes.AddPicture(file, Range: newParagraph.Range);

                // Calculate the size of the picture
                if (map.Width > map.Height)
                {
                    var ratio  = map.Height / map.Width;
                    map.Width  = imageWidth;
                    map.Height = map.Width * ratio;
                }
                else
                {
                    var ratio  = map.Width / map.Height;
                    map.Height = imageHeight;
                    map.Width  = map.Height * ratio;
                }

                // Set page break for the new paragraph
                newParagraph.PageBreakBefore = -1;
            }

            //document.Saved = true; // Enable for debugging 
            document.Save();
            word.Quit();

            return true;
        }
    }
}
