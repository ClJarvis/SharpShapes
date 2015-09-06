using System;
using System.Collections.Generic; //Stuff like lists
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
//using System.Windows.Shapes;
using Shapes;
using System.Reflection;

namespace SharpShapes
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            SetComboBoxItems();
        }

        private void SetComboBoxItems()
        {
            List<string> stuff = new List<string>();
            //stuff.Add("Square");
            //stuff.Add("Rectangle");
            var quadType= typeof(Quadrilateral);

           // combo1.ItemsSource = stuff; //combo1 came from <ComboBox x:name=combo1.
         //   combo1.ItemsSource = Assembly.GetAssembly(typeof(Shapes.Shape)).GetTypes()
           combo1.ItemsSource = Assembly.GetAssembly(typeof(Shapes.Shape)).GetTypes().Where(shapeType => shapeType.IsSubclassOf(typeof(Quadrilateral)));
           
        }

        public int NumberOfArguments(string className)
        {
           var theClass =  Assembly.GetAssembly(typeof(Shapes.Shape)).GetTypes().Where(shapeType => shapeType.Name == className).First(); //this is a collection get the firat
           var theClassConstructor = theClass.GetConstructors().First();
            return theClassConstructor.GetParameters().Length;
        }


        private void Button_Click(Object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Button Clicked!");
        }

        private void combo1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var classType = combo1.SelectedValue as Type;
          ShapeWidth.IsEnabled = true;
            int argCount = NumberOfArguments(classType.Name);
           ShapeHeight.IsEnabled = (argCount > 1);
        }
}
}
