//***************************************************
//* This file was generated by tool
//* SharpKit
//***************************************************
using System;
using System.Collections.Generic;
using SharpKit.JavaScript;
namespace YUI_
{
    /// <summary>
    /// Contains methods for displaying items vertically in a legend.
    /// </summary>
    public partial class VerticalLegendLayout
    {
        /// <summary>
        /// Positions the legend in a chart and returns the properties of the legend to be used in the
        /// chart's layout algorithm.
        /// </summary>
        protected object _getLayoutDimensions(){return null;}
        /// <summary>
        /// Displays items vertically in a legend.
        /// </summary>
        protected void _positionLegendItems(YUI_.Array items, YUI_.DataType_.Number maxWidth, YUI_.DataType_.Number maxHeight, YUI_.DataType_.Number totalWidth, YUI_.DataType_.Number totalHeight, YUI_.DataType_.Number padding, YUI_.DataType_.Number horizontalGap, YUI_.DataType_.Number verticalGap, object hAlign, object vAlign){}
        /// <summary>
        /// Creates column and total height arrays used for displaying multiple columns of
        /// legend items based on the items, available height and verticalGap for the legend.
        /// </summary>
        protected void _setColumnArrays(YUI_.Array items, YUI_.DataType_.Number limit, YUI_.DataType_.Number verticalGap){}
        /// <summary>
        /// Destructor implementation for the CartesianChart class. Calls destroy on all axes, series, legend (if available) and the Graph instance.
        /// Removes the tooltip and overlay HTML elements.
        /// </summary>
        protected void destructor(){}
        /// <summary>
        /// Returns the starting y-coordinate for a column of legend items.
        /// </summary>
        protected YUI_.DataType_.Number getStartPoint(YUI_.DataType_.Number h, YUI_.DataType_.Number totalHeight, object align, object padding){return null;}
    }
}