
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Autodesk.Revit.Attributes;
using System;


namespace RevitoCity
{
    [TransactionAttribute(TransactionMode.ReadOnly)]
    public class Setparameter : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            try
            {
                // test
                TaskDialog.Show("Set parameter", "Set parameter value by name");
                return Result.Succeeded;

            }
            catch (Exception e)
            {
                return Result.Failed;
            }
        }
    }
}
