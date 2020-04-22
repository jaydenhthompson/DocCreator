using Microsoft.Office.Interop.Word;
using System.Collections.Generic;
using System.IO;

namespace DocCreator
{
    public partial class WordDocument
    {
        //////////////////////
        // Member Variables //
        //////////////////////

        /// Private
        private Application wordApplication;
        private Document wordDocument;

        private string documentPath;

        private float maxContentWidth;
        private float maxContentHeight;

        private bool newFile;

        //////////////////////
        // Public Functions //
        //////////////////////

        /// <summary>
        /// If the filePath exists, then we open
        /// it, if it does not, then we create a 
        /// new file, if iForce is set to true, then 
        /// we overwrite the existing file
        /// </summary>
        /// <param name="iFilePath"></param>
        /// <param name="iForce"></param>
        public WordDocument(string iFilePath, bool iForce = false)
        {
            // Set the file path for future saving
            this.documentPath = iFilePath;

            // Open the word document in the correct manner
            this.wordApplication = new Application();
            if (!File.Exists(iFilePath) || iForce)
            {
                this.wordDocument = wordApplication.Documents.Add();
                this.newFile = true;
            }
            else
            {
                this.wordDocument = wordApplication.Documents.Open(iFilePath);
                this.newFile = false;
            }

            // Calculate margins / max stuff
            var sideMargins = this.wordDocument.PageSetup.LeftMargin;
            sideMargins += this.wordDocument.PageSetup.RightMargin;
            var topBottomMargins = this.wordDocument.PageSetup.TopMargin;
            topBottomMargins += this.wordDocument.PageSetup.BottomMargin;

            this.maxContentWidth = this.wordDocument.PageSetup.PageWidth - sideMargins;
            this.maxContentHeight = this.wordDocument.PageSetup.PageHeight - topBottomMargins;
        }

        public void AddTableOfContentsToDocument(string iMainTitle,
                                                 string iSubTitle,
                                                 List<string> iBulletPoints)
        {
            this.AddPageHeaders(iMainTitle, iSubTitle);
            this.AddPageBullets(iBulletPoints);
        }

        public void AppendPageToDocument(string iMainTitle,
                                         string iSubTitle,
                                         string iLeftImagePath,
                                         string iRightImagePath,
                                         List<string> iBulletPoints)
        {
            this.AddPageHeaders(iMainTitle, iSubTitle);

            // Add Images
            var imageParagraph = this.wordDocument.Paragraphs.Add();
            InlineShape leftImage = this.wordDocument.InlineShapes.AddPicture(iLeftImagePath,
                                                                              Range: imageParagraph.Range);
            this.SetImageParameters(ref leftImage, 2);

            InlineShape rightImage = this.wordDocument.InlineShapes.AddPicture(iRightImagePath,
                                                                               Range: imageParagraph.Range);
            this.SetImageParameters(ref rightImage, 2);

            this.AddPageBullets(iBulletPoints);
        }

        public void CloseDocument()
        {
            if (this.newFile)
            {
                this.wordDocument.SaveAs2(this.documentPath);
            }
            else
            {
                this.wordDocument.Save();
            }
            this.wordApplication.Quit();

        }

        ///////////////////////
        // Private Functions //
        ///////////////////////

        private void AddPageHeaders(string iMain,
                                    string iSub)
        {
            var mainTitleParagraph = this.wordDocument.Paragraphs.Add();
            mainTitleParagraph.PageBreakBefore = -1;
            mainTitleParagraph.Range.Text = iMain;
            mainTitleParagraph.Range.Font.Size = 28;
            mainTitleParagraph.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;

            var subTitleParagraph = this.wordDocument.Paragraphs.Add();
            subTitleParagraph.Range.Text = iSub;
            subTitleParagraph.Range.Font.Size = 22;
            subTitleParagraph.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;

            return;
        }

        private void AddPageBullets(List<string> iBulletPoints)
        {
            var bulletParagraph = this.wordDocument.Paragraphs.Add();
            bulletParagraph.Range.ListFormat.ApplyBulletDefault();

            for (var i = 0; i < iBulletPoints.Count; ++i)
            {
                if (i < iBulletPoints.Count - 1)
                    bulletParagraph.Range.InsertBefore(iBulletPoints[i] + '\n');
                else
                    bulletParagraph.Range.InsertBefore(iBulletPoints[i]);

            }
        }

        private void SetImageParameters(ref InlineShape image, int numberOfSideBySideImages)
        {
            var ratio = image.Height / image.Width;
            image.Width = this.maxContentWidth / numberOfSideBySideImages;
            image.Height = image.Width * ratio;
        }
    }
}
