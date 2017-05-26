﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace GroupDocs.Viewer.Examples.CSharp
{
    class Program
    {
        static void Main(string[] args)
        {

            //ExStart:ApplyingLicense
            /**
             *  Applying product license
             *  Please uncomment the statement if you do have license.
             */
            //Utilities.ApplyLicense();
            //ExEnd:ApplyingLicense


            #region ViewerHtmlPresentation

            //Render a power point presentation in html form
            //ViewGenerator.RenderDocumentAsHtml("word.doc");

            //Render a spreadsheet in html form
            //ViewGenerator.RenderDocumentAsHtml("spreadsheet.xlsx");

            //Render a MS word document by replacing its 1st page order with 2nd page 
            //ViewGenerator.RenderDocumentAsHtml("large_will_not_getting_processed.docx");

            //Render a word document in html form and also apply a text as watermark on each page
            //ViewGenerator.RenderDocumentAsHtml("word.doc", "Show me as watermark", Color.Purple);

            //Render a document located at a web location
            // ViewGenerator.RenderDocumentAsHtml(new Uri("http://www.example.com/sample.doc"));

            //Render a document in html form with resource prefix
            //ViewGenerator.RenderDocumentAsHtmlWithResourcePrefix("word.doc");
            
            //Render hidden pages in Visio file in html form 
            //ViewGenerator.RenderHiddenPagesOfVisioAsHtml("sample.vdx");

            //Render Excel document in html form with internal hyperlink prefix
            //ViewGenerator.RenderExcelAsHtmlWithInternalHyperlinkPrefix("sample.xlsx");

            //Render simple document into html with PreventGlyphsGrouping settings
            //ViewGenerator.RenderDocumentAsHtmlWithEnablePreciseRendering("sample.pdf");

            //Render Excel file as Html specifying number of rows per page
            //ViewGenerator.RenderExcelAsHtmlWithCountRowsPerPage("sample.xlsx");

            //Render Excel file as Html specifying text overflow mode
            //ViewGenerator.RenderExcelAsHtmlWithTextOverflowMode("sample.xlsx");

            //Render CAD document including the layouts 
            //ViewGenerator.RenderLayoutsOfCADDocument("sample.dwg");

            //Render Excel file as Html specifying text overflow mode
            //ViewGenerator.RenderSpecificLayoutOfCADDocument("sample.dwg");

            //Gets list of all Layouts from CAD document
            //ViewGenerator.GetListOfLayoutsOfCADDocument("sample.dwg");

            //Gets list of all Layouts from CAD document
            //ViewGenerator.RenderDocumentAsHtmlWithEnablePreciseRendering("sample.pdf");

            //Render document with comments as HTML
            //ViewGenerator.RenderDocumentAsHtmlWithComments("sample.doc");

            #endregion

            #region ViewerImagePresentation

            //Render a power point presentation in images form.
            //ViewGenerator.RenderDocumentAsImages("sample.pptx");

            //Render a spreadsheet in images form.
            //ViewGenerator.RenderDocumentAsImages("spreadsheet.xlsx");

            //Render a MS word document by replacing its 1st page order with 2nd page. 
            // ViewGenerator.RenderDocumentAsImages("word.doc",1,2);

            //Render a word document in images form and also apply a text as watermark on each page.
            // ViewGenerator.RenderDocumentAsImages("f1.pdf", "Show me as watermark", Color.Purple);

            //Render a word document in images form and set the rotation angle to display the rotated page.
            // ViewGenerator.RenderDocumentAsImages("word.doc", 180);

            //Render a document located at a web location
            // ViewGenerator.RenderDocumentAsImages(new Uri("http://www.example.com/sample.doc"));

            //Render hidden pages in Visio file in image form 
            //ViewGenerator.RenderHiddenPagesOfVisioAsImage("sample.vdx");

            #endregion

            #region GeneralRepresentation
            //Render the word document in the form of pdf markup
            //ViewGenerator.RenderDocumentAsPDF("test.pdf");

            //Render the document as it is (Original form)
            //ViewGenerator.RenderDocumentAsOriginal("factsheet.pdf");

            //Render document as PDF with JpegQuality settings
            //ViewGenerator.RenderDocumentAsPDFWithJpegQualitySettings("sample.doc");

            //Render document as PDF with comments
            //ViewGenerator.RenderDocumentWithCommentsAsPDF("sample.doc");
            #endregion

            #region InputDataHandlers
            //Render a document from Azure Storage 
            //ViewGenerator.RenderDocFromAzure("word.doc");
            //Render a document from ftp location 
            //ViewGenerator.RenderDocFromAzure("word.doc");
            #endregion

            #region OtherImprovements
            //Show grid lines for Excel files in html representation 
            //ViewGenerator.RenderWithGridLinesInExcel("spreadsheet.xlsx");
            //Multiple pages per sheet 
            // ViewGenerator.RenderMultiExcelSheetsInOnePage("testcc1.xlsx");
            //Show hidden sheets for Excel files in image representation 
            // ViewGenerator.RenderWithHiddenSheetsInExcel("spreadsheet.xlsx");
            //Render a document from ftp location 
            //ViewGenerator.RenderWithLocales("word.doc");
            //Get all supported document formats 
            //ViewGenerator.ShowAllSupportedFormats();

            #endregion

            #region DocumentCache
            //Removes cache files
            //ViewGenerator.RemoveCacheFiles();

            //Removes cache files older than 2 days
            //ViewGenerator.RemoveCacheFiles(TimeSpan.FromDays(2));
            #endregion

            #region DocumentInfo
            //Get document info by guid
            //ViewGenerator.GetDocumentInfoByGuid("word.doc");

            //Get document info by uri
            //ViewGenerator.GetDocumentInfoByUri("http://www.example.com/sample.doc");

            //Get document info by stream
            //ViewGenerator.GetDocumentInfoByStream("word.doc"); 
            #endregion
            
            #region EmailAttachments
            //Get email attachment files
            //ViewGenerator.GetEmailAttachments("sample.msg");

            //Get email attachment html representation
            //ViewGenerator.GetEmailAttachmentHTMLRepresentation("sample.msg");

            //Get email attachment image representation
            //ViewGenerator.GetEmailAttachmentImageRepresentation("sample.msg");
             
            #endregion

            #region CustomFonts
            //Set custom font directories
            //ViewGenerator.SetCustomFontDirectory("word.doc");
               
            #endregion
        }
    }
}
