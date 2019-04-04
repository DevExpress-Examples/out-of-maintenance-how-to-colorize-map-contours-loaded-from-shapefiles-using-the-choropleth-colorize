<!-- default file list -->
*Files to look at*:

* [ColorGenerator.cs](./CS/CustomMapColorizer/ColorGenerator.cs) (VB: [ColorGenerator.vb](./VB/CustomMapColorizer/ColorGenerator.vb))
* [MainWindow.xaml](./CS/CustomMapColorizer/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/CustomMapColorizer/MainWindow.xaml))
* [MainWindow.xaml.cs](./CS/CustomMapColorizer/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/CustomMapColorizer/MainWindow.xaml.vb))
* [RangeColor.cs](./CS/CustomMapColorizer/RangeColor.cs) (VB: [RangeColor.vb](./VB/CustomMapColorizer/RangeColor.vb))
<!-- default file list end -->
# How to colorize map contours loaded from Shapefiles using the Choropleth colorizer


<p>This example demonstrates how to paint each map contour in a specific color depending on GDP data from Shapefiles (<strong>Countries.dbf</strong>,<strong> Countries.shp</strong>).<br />
</p>


<h3>Description</h3>

<p>For this, handle the  <a href="http://documentation.devexpress.com/#WPF/DevExpressXpfMapShapeLoaderBase_ShapesLoadedtopic"><u>ShapeLoaderBase.ShapesLoaded</u></a> event and color each map shape in the <strong>PrepareShapesByPopulation</strong> method using information from Shapefiles (a country name, population, country shapes). </p><p>This information is accessed from Shapefiles by attributes using the <a href="http://documentation.devexpress.com/#WPF/DevExpressXpfMapMapItemAttribute_Nametopic"><u>MapItemAttribute.Name</u></a>, <a href="http://documentation.devexpress.com/#WPF/DevExpressXpfMapMapItemAttribute_Typetopic"><u>MapItemAttribute.Type</u></a> and <a href="http://documentation.devexpress.com/#WPF/DevExpressXpfMapMapItemAttribute_Valuetopic"><u>MapItemAttribute.Value</u></a> properties. </p><br />


<br/>


