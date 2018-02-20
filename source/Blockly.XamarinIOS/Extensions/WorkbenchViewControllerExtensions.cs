﻿using System;
using System.IO;
using Blockly.Bindings.XamarinIOS;
using Foundation;

namespace Blockly.Extensions
{
    public static class WorkbenchViewControllerExtensions
    {
        public static void SetupToolBox(this BKYWorkbenchViewController bench, string toolboxXml, string[] blocksJsons)
        {
            try
            {
                ExtractBlocks(bench, blocksJsons);
                UpdateToolbox(bench, toolboxXml);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw ex;
            }
        }

        private static void UpdateToolbox(BKYWorkbenchViewController bench, string toolboxXml)
        {
            var resurcePath = NSBundle.MainBundle.PathForResource(toolboxXml, null);
            if (string.IsNullOrEmpty(resurcePath))
                throw new Exception("Path is empty!");
            var xmlData = File.ReadAllText(resurcePath);
            if (string.IsNullOrEmpty(xmlData))
                throw new Exception("Xml is empty!"); 
            var box = new BKYToolbox();
            var toolBox = box.MakeToolboxWithXmlString(xmlData, bench.BlockFactory, out var error2);
            if (error2 != null)
                throw new NSErrorException(error2);
            if (toolBox == null)
                throw new ArgumentNullException(nameof(toolBox));

            bench.LoadToolbox(toolBox, out var error3);
            if (error3 != null)
                throw new NSErrorException(error3);
        }

        private static void ExtractBlocks(BKYWorkbenchViewController bench, string[] blocksJsons)
        {
            bench.BlockFactory.LoadFromDefaultFiles(BKYBlockJSONFile.AllDefault);
            bench.BlockFactory.LoadFromJSONPaths(blocksJsons, bench.NibBundle, out var error);
            if (error != null)
                throw new NSErrorException(error);
        }
    }
}
