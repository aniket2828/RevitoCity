using Autodesk.Revit.UI;
using System;
using System.Diagnostics;
using System.Reflection;
using System.Windows.Media.Imaging;

namespace RevitoCity
{


    public class App : IExternalApplication
    {

        public Result OnStartup(UIControlledApplication application)
        {

            try
            {
                String assemblyName = Assembly.GetExecutingAssembly().Location;
                String path = System.IO.Path.GetDirectoryName(assemblyName);

                String tabName = "Revitocity"; 
                application.CreateRibbonTab(tabName);

               

                RibbonPanel demoPanel = application.CreateRibbonPanel(tabName, "Revitocity tools");
               


                // Button 1 code start
                PushButtonData btnData1 = new PushButtonData("AJToolsbtn1", "Quick print", assemblyName, "RevitoCity.Quickprint");
                btnData1.LargeImage = new BitmapImage(new Uri(path + @"\print.png"));
                btnData1.ToolTip = "Quick print active view";
                demoPanel.AddItem(btnData1);

                // Button 2 code start
                PushButtonData btnData2 = new PushButtonData("AJToolsbtn2", "Parameters", assemblyName, "RevitoCity.Setparameter");
                btnData2.LargeImage = new BitmapImage(new Uri(path + @"\getparameter.png"));
                btnData2.ToolTip = "Set Schedules Parameters";

                PushButtonData importButton = new PushButtonData("AJToolsbtn3", "Import", assemblyName, "RevitoCity.Import");
                importButton.LargeImage = new BitmapImage(new Uri(path + @"\export-32.png"));
                importButton.ToolTip = "Import Excel Data";

                PushButtonData btnData4 = new PushButtonData("AJToolsbtn4", "Export", assemblyName, "RevitoCity.Export");
                btnData4.LargeImage = new BitmapImage(new Uri(path + @"\import-32.png"));
                btnData4.ToolTip = "Export Excel Data";

              
                demoPanel.AddSeparator();
                demoPanel.AddItem(btnData2);
                demoPanel.AddSeparator();
                demoPanel.AddItem(importButton);
                demoPanel.AddSeparator();
                demoPanel.AddItem(btnData4);


            } catch (Exception e)
            {
                Debug.WriteLine(e.ToString());
                return Result.Failed;
            }

            return Result.Succeeded;
        }

        public Result OnShutdown(UIControlledApplication application)
        {
            return Result.Failed;
        }



    }
}
