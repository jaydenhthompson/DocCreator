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

        private object endOfDoc = "\\endofdoc";

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

            // These will eventually be dynamic in the config
            this.maxContentWidth *= 0.85f;
            this.maxContentHeight *= 0.85f;

            // Get to a clean page if an existing document is being used
            if (!this.newFile)
            {
                object paragraphRange = this.wordDocument.Bookmarks.get_Item(ref endOfDoc).Range;
                var mainTitleParagraph = this.wordDocument.Content.Paragraphs.Add(ref paragraphRange);
                mainTitleParagraph.Format.SpaceAfter = 6;
                mainTitleParagraph.Range.InsertParagraphAfter();
            }
        }

        public void AddTableOfContentsToDocument(string iMainTitle,
                                                 string iSubTitle,
                                                 List<string> iBulletPoints)
        {
            this.AddPageHeaders(iMainTitle, iSubTitle, false);
            this.AddPageBullets(iBulletPoints);
        }

        public void AppendPageToDocument(string iMainTitle,
                                         string iSubTitle,
                                         string iLeftImagePath,
                                         string iRightImagePath,
                                         List<string> iBulletPoints)
        {
            this.AddPageHeaders(iMainTitle, iSubTitle);
            this.AddImages(iLeftImagePath, iRightImagePath);
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

        #region PrivateFunctions

        private void AddPageHeaders(string iMain,
                                    string iSub,
                                    bool addBreak = true)
        {
            if (addBreak)
            {
                this.wordDocument.Words.Last.InsertBreak(WdBreakType.wdPageBreak);
            }

            object paragraphRange = this.wordDocument.Bookmarks.get_Item(ref endOfDoc).Range;
            var mainTitleParagraph = this.wordDocument.Content.Paragraphs.Add(ref paragraphRange);
            mainTitleParagraph.Range.Text = iMain;
            mainTitleParagraph.Range.Font.Size = 28;
            mainTitleParagraph.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
            mainTitleParagraph.Format.SpaceAfter = 6;
            mainTitleParagraph.Range.InsertParagraphAfter();

            paragraphRange = this.wordDocument.Bookmarks.get_Item(ref endOfDoc).Range;
            var subTitleParagraph = this.wordDocument.Content.Paragraphs.Add(ref paragraphRange);
            subTitleParagraph.Range.Text = iSub;
            subTitleParagraph.Range.Font.Size = 22;
            subTitleParagraph.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
            subTitleParagraph.Format.SpaceAfter = 6;
            subTitleParagraph.Range.InsertParagraphAfter();

            return;
        }

        private void AddImages(string iLeftImagePath, string iRightImagePath)
        {
            object paragraphRange = this.wordDocument.Bookmarks.get_Item(ref endOfDoc).Range;
            var imageParagraph = this.wordDocument.Content.Paragraphs.Add(ref paragraphRange);

            InlineShape rightImage = this.wordDocument.InlineShapes.AddPicture(iRightImagePath, Range: imageParagraph.Range);
            this.SetImageParameters(ref rightImage, 2);

            InlineShape leftImage = this.wordDocument.InlineShapes.AddPicture(iLeftImagePath, Range: imageParagraph.Range);
            this.SetImageParameters(ref leftImage, 2);

            imageParagraph.Format.SpaceAfter = 6;
            imageParagraph.Range.InsertParagraphAfter();
        }

        private void AddPageBullets(List<string> iBulletPoints)
        {
            object paragraphRange = this.wordDocument.Bookmarks.get_Item(ref endOfDoc).Range;
            var bulletParagraph = this.wordDocument.Content.Paragraphs.Add(ref paragraphRange);
            bulletParagraph.Range.ListFormat.ApplyBulletDefault();
            bulletParagraph.Range.Font.Size = 14;
            bulletParagraph.Alignment = WdParagraphAlignment.wdAlignParagraphLeft;

            for (var i = 0; i < iBulletPoints.Count; ++i)
            {
                if (i < iBulletPoints.Count - 1)
                    bulletParagraph.Range.InsertBefore(iBulletPoints[i] + '\n');
                else
                    bulletParagraph.Range.InsertBefore(iBulletPoints[i]);

            }
            bulletParagraph.Format.SpaceAfter = 6;
            bulletParagraph.Range.InsertParagraphAfter();
        }

        private void SetImageParameters(ref InlineShape image, int numberOfSideBySideImages)
        {
            var ratio = image.Height / image.Width;
            image.Width = this.maxContentWidth / numberOfSideBySideImages;
            image.Height = image.Width * ratio;
        }

        #endregion
    }
}
