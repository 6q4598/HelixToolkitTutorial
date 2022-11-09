using HelixToolkit.Wpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Linq;



namespace HelixToolkitTutorial {
    
    public partial class MainWindow : Window {

        // Figure objects (default null).
        Model3DGroup imageGroup;
        Model3D figure;

        /*
         * Property for the binding with the figure.
         * It needs to be public so it is accessible by the GUI and
         * needs to have a setter and getter in order to be bindable.
         */
        public Model3D OurModel { get; set; }

        public MainWindow () {
            
            InitializeComponent();

            // The importe to load <<.obj>> files.
            ModelImporter importer = new ModelImporter();

            // The color of the figure.
            Material material = new DiffuseMaterial(new SolidColorBrush(Colors.Yellow));
            importer.DefaultMaterial = material;

            // Load the image.
            imageGroup = new Model3DGroup();
            figure = importer.Load(@"C:\Users\farrufi\Documents\HelixToolkit\HelixToolkitTutorial\HelixToolkitTutorial\Sources\testObj.obj");
            imageGroup.Children.Add(figure);

            this.OurModel= imageGroup;

            // Rotate to correctly position the image.
            //RotateTransform3D myRotateTransform = new RotateTransform3D(new AxisAngleRotation3D(new Vector3D(1, 0, 0), 90));
            //myRotateTransform.CenterX = 0;
            //myRotateTransform.CenterY = 0;
            //myRotateTransform.CenterZ = 0;
            //imageGroup.Transform = myRotateTransform;

            //set datacontext for the sliders and helper
            overall_grid.DataContext = this;

        }

    }

}
