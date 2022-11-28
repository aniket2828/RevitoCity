
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Autodesk.Revit.Attributes;
using System;


namespace RevitoCity
{
    [TransactionAttribute(TransactionMode.Manual)]
    public class QuickPrintui : IExternalCommand


    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)


        {
            UIDocument uidoc = commandData.Application.ActiveUIDocument;
            Document doc = uidoc.Document;

           
            try
            {
                var V = doc.ActiveView;
                var vName = V.Name;
                var vId = V.Id;
                var vTemplateId = V.ViewTemplateId;
                var vTemplate = vTemplateId.ToString() == "-1" ? "None" : doc.GetElement(vTemplateId).Name;



                QuickPrint window = new QuickPrint(uidoc);
                window.lable_Name.Content = $"Name: {vName}";
                window.lable_Id.Content = $"View Id: {vId}";
                window.lable_Template.Content = $"View Template : {vTemplate}";
                window.ShowDialog();


              

                return Result.Succeeded;

            }
            catch (Exception e)
            {
                return Result.Failed;
            }
        }
    }

   
}
