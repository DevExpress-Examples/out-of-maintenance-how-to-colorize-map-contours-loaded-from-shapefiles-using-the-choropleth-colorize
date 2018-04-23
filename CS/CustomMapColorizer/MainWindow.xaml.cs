using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Media;
using DevExpress.Xpf.Map;

namespace CustomMapColorizer
{
    public partial class MainWindow : Window
    {
        List<MapItem> loadedShapes;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ShapefileLoader_ShapesLoaded(object sender, ShapesLoadedEventArgs e)
        {
            loadedShapes = e.Shapes;
            PrepareShapesByPopulation();
        }
        void PrepareShapesByPopulation()
        {
            if (loadedShapes != null)
                foreach (MapItem item in loadedShapes)
                {
                    MapShape shape = item as MapShape;
                    shape.Fill =
                        new SolidColorBrush(ColorGenerator.GetColorByPopulation(Convert.ToInt32((double)item.Attributes["POP_EST"].Value)));
                }
        }
    }
}
