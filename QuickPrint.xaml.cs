
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System.Windows;


namespace RevitoCity
{
    /// <summary>
    /// Interaction logic for Quickprint.xaml
    /// </summary>
    public partial class QuickPrint : Window
    {
        public UIDocument uidoc { get; }
        public Document doc { get; }

        public QuickPrint(UIDocument UiDoc)
        {
            uidoc = UiDoc;
            doc = UiDoc.Document;
            InitializeComponent();
            Title = "Quick print active view";
        }

        private void SetViewName(object sender, RoutedEventArgs e)
        {
            using(Transaction t = new Transaction(doc, "set view name"))
            {
                t.Start();
                doc.ActiveView.Name = text.Text;
                t.Commit();
            }

        }

        private void PrintView(object sender, RoutedEventArgs e)
        {
            using (Transaction t = new Transaction(doc, "Print view"))
            {
                t.Start();
                doc.ActiveView.Print(); 
                t.Commit();
            }
        }

    }
}
