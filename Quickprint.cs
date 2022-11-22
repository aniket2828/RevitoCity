
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Autodesk.Revit.Attributes;
using System;


namespace RevitoCity
{
    [TransactionAttribute(TransactionMode.ReadOnly)]
    public class Quickprint : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            try
            {

                TaskDialog.Show("Hello there", "Hello");
                return Result.Succeeded;

            }
            catch (Exception e)
            {
                return Result.Failed;
            }
        }
    }
}
