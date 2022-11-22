using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevitoCity
{
    [TransactionAttribute(TransactionMode.ReadOnly)]
    public class Export : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            try
            {

                TaskDialog.Show("Export window", "Hello from Export window");
                return Result.Succeeded;

            }
            catch (Exception e)
            {
                return Result.Failed;
            }
        }
    }
}
