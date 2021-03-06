﻿using GroupDocs.Viewer;
using GroupDocs.Viewer.Config;
using GroupDocs.Viewer.Converter.Options;
using GroupDocs.Viewer.Domain.Html;
using GroupDocs.Viewer.Domain.Image;
using GroupDocs.Viewer.Handler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ViewerModernWebPart.Helpers
{
    public class Utils
    {
      
        private static string _storagePath = HttpContext.Current.Server.MapPath("~/_layouts/15/ViewerModernWebPart/Storage/");
        private static string _tempPath = HttpContext.Current.Server.MapPath("~/_layouts/15/ViewerModernWebPart/Storage/") + "\\temp";
        private static string _cachePath = HttpContext.Current.Server.MapPath("~/_layouts/15/ViewerModernWebPart/Storage/") + "\\cache";
        public static ViewerHtmlHandler CreateViewerHtmlHandler()
        {
            ViewerHtmlHandler handler = new ViewerHtmlHandler(CreateViewerConfig());
            return handler;
        }
        public static ViewerImageHandler CreateViewerImageHandler()
        {
            ViewerImageHandler handler = new ViewerImageHandler(CreateViewerConfig());
            return handler;
        }

        public static ViewerConfig CreateViewerConfig()
        {
            ViewerConfig cfg = new ViewerConfig
            {
                StoragePath = _storagePath,
                CachePath = _cachePath,
                UseCache = false
            };
            return cfg;
        }
        public static List<PageHtml> LoadPageHtmlList(ViewerHtmlHandler handler, String filename, HtmlOptions options)
        {
            try
            {
                return handler.GetPages(filename, options);
            }
            catch (Exception x)
            {
                throw x;
            }
        }
        public static List<PageImage> LoadPageImageList(ViewerImageHandler handler, String filename, ImageOptions options)
        {
            try
            {
                return handler.GetPages(filename, options);
            }
            catch (Exception x)
            {
                throw x;
            }
        }
    }
       
    
}