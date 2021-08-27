<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128571207/13.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E4587)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [MainWindow.xaml](./CS/MapColorizer/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/MapColorizer/MainWindow.xaml))
<!-- default file list end -->
# How to colorize map contours loaded from Shapefiles using the Choropleth colorizer


<p>This example demonstrates how to paint each map contour in a specific color depending on GDP data from Shapefiles (<strong>Countries.dbf</strong>,<strong> Countries.shp</strong>).<br />
</p>


<h3>Description</h3>

<p>For this, create a colorizer (choropleth colorizer) and assign it to the <strong>MapControl.Colorizer</strong> property. </p><p>In this example a choropleth colorizer (the <strong>ChoroplethColorizer</strong> object) is defined in the Window&#39;s Resources.</p><p>To access GDP information from Shapefiles, assign a <strong>ShapeAttributeValueProvider</strong> object with the specified attribute name (<strong>ShapeAttributeValueProvider.AttributeName</strong>) to the <strong>ChoroplethColorizer.ValueProvider</strong> property.</p><p>Then, specify range stops (data splits in ranges) for the colorizer using the <strong>ChoroplethColorizer.RangeStops</strong> property.</p><p><br />
Finally, specify the desired set of colors in the <strong>ColorCollection</strong> object that is accessed via the <strong>MapColorizer.Colors</strong> property. The colorizer automatically associates each color with the specified data range to colorize map shapes. </p><p><br />
If you wish to see the information on what each color means when map shapes are colored by the colorizer, create a color scale legend. For this, assign a <strong>ColorScaleLegend</strong> object to the <strong>ChoroplethColorizer.Legend</strong> property. After that specify the legend description, header and range stop format using the legend&#39;s corresponding properties. </p><p><br />
</p>

<br/>


