// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.ui.table.model
{
    /// <summary>
	/// <para>A simple table model that provides an API for changing the model data.</para>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.ui.table.model.Simple", OmitOptionalParameters = true, Export = false)]
    public partial class Simple : qx.ui.table.model.Abstract
    {
		#region Properties

		/// <summary>
		/// <para>Whether sorting should be case sensitive</para>
		/// </summary>
		[JsProperty(Name = "caseSensitiveSorting", NativeField = true)]
		public bool CaseSensitiveSorting { get; set; }

		#endregion Properties

		#region Methods

		public Simple() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Adds some rows to the model.</para>
		/// <para>Warning: The given array will be altered!</para>
		/// </summary>
		/// <param name="rowArr">An array containing an array for each row. Each row-array contains the values in that row in the order of the columns in this model.</param>
		/// <param name="startIndex">The index where to insert the new rows. If null, the rows are appended to the end.</param>
		/// <param name="clearSorting">Whether to clear the sort state.</param>
		[JsMethod(Name = "addRows")]
		public void AddRows(object rowArr, double? startIndex = null, bool clearSorting = true) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Adds some rows to the model.</para>
		/// <para>Warning: The given array (mapArr) will be altered!</para>
		/// </summary>
		/// <param name="mapArr">An array containing a map for each row. Each row-map contains the column IDs as key and the cell values as value.</param>
		/// <param name="startIndex">The index where to insert the new rows. If null, the rows are appended to the end.</param>
		/// <param name="rememberMaps">Whether to remember the original maps. If true #getRowData will return the original map.</param>
		/// <param name="clearSorting">Whether to clear the sort state.</param>
		[JsMethod(Name = "addRowsAsMapArray")]
		public void AddRowsAsMapArray(object mapArr, double? startIndex = null, bool rememberMaps = false, bool clearSorting = true) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Clears the sorting.</para>
		/// </summary>
		[JsMethod(Name = "clearSorting")]
		public void ClearSorting() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property caseSensitiveSorting.</para>
		/// </summary>
		[JsMethod(Name = "getCaseSensitiveSorting")]
		public bool GetCaseSensitiveSorting() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the data of this model.</para>
		/// <para>Warning: Do not alter this array! If you want to change the data use
		/// <see cref="SetData"/>, <see cref="SetDataAsMapArray"/> or <see cref="SetValue"/> instead.</para>
		/// </summary>
		/// <returns>An array containing an array for each row. Each row-array contains the values in that row in the order of the columns in this model.</returns>
		[JsMethod(Name = "getData")]
		public object GetData() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Gets the whole data as an array of maps.</para>
		/// <para>Note: Individual items are retrieved by <see cref="GetRowDataAsMap"/>.</para>
		/// </summary>
		/// <returns>Array of row data maps</returns>
		[JsMethod(Name = "getDataAsMapArray")]
		public object GetDataAsMapArray() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the number of rows in the model.</para>
		/// </summary>
		/// <returns>the number of rows.</returns>
		[JsMethod(Name = "getRowCount")]
		public double GetRowCount() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the data of one row. This function may be overridden by models which hold
		/// all data of a row in one object. By using this function, clients have a way of
		/// quickly retrieving the entire row data.</para>
		/// Important:Models which do not have their row data accessible in one object
		/// may return null.
		/// </summary>
		/// <param name="rowIndex">the model index of the row.</param>
		/// <returns>the row data as an object or null if the model does not support row data objects. The details on the object returned are determined by the model implementation only.</returns>
		[JsMethod(Name = "getRowData")]
		public object GetRowData(double rowIndex) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the data of one row as map containing the column IDs as key and
		/// the cell values as value. Also the meta data is included.</para>
		/// </summary>
		/// <param name="rowIndex">the model index of the row.</param>
		/// <returns>a Map containing the column values.</returns>
		[JsMethod(Name = "getRowDataAsMap")]
		public object GetRowDataAsMap(double rowIndex) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the column index the model is sorted by. If the model is not sorted
		/// -1 is returned.</para>
		/// </summary>
		/// <returns>the column index the model is sorted by.</returns>
		[JsMethod(Name = "getSortColumnIndex")]
		public double GetSortColumnIndex() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the sortMethod(s) for a table column.</para>
		/// </summary>
		/// <param name="columnIndex">The index of the column for which the sort methods are being  provided.</param>
		/// <returns>a map with the two properties &#8220;ascending&#8221; and &#8220;descending&#8221; for the specified column. The property value of each is a comparator function, as described in #setSortMethods.</returns>
		[JsMethod(Name = "getSortMethods")]
		public object GetSortMethods(double columnIndex) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns a cell value by column index.</para>
		/// </summary>
		/// <param name="columnIndex">the index of the column.</param>
		/// <param name="rowIndex">the index of the row.</param>
		/// <returns>The value of the cell.</returns>
		[JsMethod(Name = "getValue")]
		public object GetValue(double columnIndex, double rowIndex) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property caseSensitiveSorting
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property caseSensitiveSorting.</param>
		[JsMethod(Name = "initCaseSensitiveSorting")]
		public void InitCaseSensitiveSorting(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Check whether the (computed) value of the boolean property caseSensitiveSorting equals true.</para>
		/// </summary>
		[JsMethod(Name = "isCaseSensitiveSorting")]
		public void IsCaseSensitiveSorting() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns whether a column is editable.</para>
		/// </summary>
		/// <param name="columnIndex">the column to check.</param>
		/// <returns>whether the column is editable.</returns>
		[JsMethod(Name = "isColumnEditable")]
		public bool IsColumnEditable(double columnIndex) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns whether a column is sortable.</para>
		/// </summary>
		/// <param name="columnIndex">the column to check.</param>
		/// <returns>whether the column is sortable.</returns>
		[JsMethod(Name = "isColumnSortable")]
		public bool IsColumnSortable(double columnIndex) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns whether the model is sorted ascending.</para>
		/// </summary>
		/// <returns>whether the model is sorted ascending.</returns>
		[JsMethod(Name = "isSortAscending")]
		public bool IsSortAscending() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Removes some rows from the model.</para>
		/// </summary>
		/// <param name="startIndex">the index of the first row to remove.</param>
		/// <param name="howMany">the number of rows to remove.</param>
		/// <param name="clearSorting">Whether to clear the sort state.</param>
		[JsMethod(Name = "removeRows")]
		public void RemoveRows(double startIndex, double howMany, bool clearSorting = true) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property caseSensitiveSorting.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetCaseSensitiveSorting")]
		public void ResetCaseSensitiveSorting() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property caseSensitiveSorting.</para>
		/// </summary>
		/// <param name="value">New value for property caseSensitiveSorting.</param>
		[JsMethod(Name = "setCaseSensitiveSorting")]
		public void SetCaseSensitiveSorting(bool value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets whether a column is editable.</para>
		/// </summary>
		/// <param name="columnIndex">the column of which to set the editable state.</param>
		/// <param name="editable">whether the column should be editable.</param>
		[JsMethod(Name = "setColumnEditable")]
		public void SetColumnEditable(double columnIndex, bool editable) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets whether a column is sortable.</para>
		/// </summary>
		/// <param name="columnIndex">the column of which to set the sortable state.</param>
		/// <param name="sortable">whether the column should be sortable.</param>
		[JsMethod(Name = "setColumnSortable")]
		public void SetColumnSortable(double columnIndex, bool sortable) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the whole data in a bulk.</para>
		/// </summary>
		/// <param name="rowArr">An array containing an array for each row. Each row-array contains the values in that row in the order of the columns in this model.</param>
		/// <param name="clearSorting">Whether to clear the sort state.</param>
		[JsMethod(Name = "setData")]
		public void SetData(object rowArr, bool clearSorting = true) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the whole data in a bulk.</para>
		/// </summary>
		/// <param name="mapArr">An array containing a map for each row. Each row-map contains the column IDs as key and the cell values as value.</param>
		/// <param name="rememberMaps">Whether to remember the original maps. If true #getRowData will return the original map.</param>
		/// <param name="clearSorting">Whether to clear the sort state.</param>
		[JsMethod(Name = "setDataAsMapArray")]
		public void SetDataAsMapArray(object mapArr, bool rememberMaps = false, bool clearSorting = true) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets all columns editable or not editable.</para>
		/// </summary>
		/// <param name="editable">whether all columns are editable.</param>
		[JsMethod(Name = "setEditable")]
		public void SetEditable(bool editable) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets rows in the model. The rows overwrite the old rows starting at
		/// startIndex to startIndex+rowArr.length.</para>
		/// <para>Warning: The given array will be altered!</para>
		/// </summary>
		/// <param name="rowArr">An array containing an array for each row. Each row-array contains the values in that row in the order of the columns in this model.</param>
		/// <param name="startIndex">The index where to insert the new rows. If null, the rows are set from the beginning (0).</param>
		/// <param name="clearSorting">Whether to clear the sort state.</param>
		[JsMethod(Name = "setRows")]
		public void SetRows(object rowArr, double? startIndex = null, bool clearSorting = true) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Set rows in the model. The rows overwrite the old rows starting at
		/// startIndex to startIndex+rowArr.length.</para>
		/// <para>Warning: The given array (mapArr) will be altered!</para>
		/// </summary>
		/// <param name="mapArr">An array containing a map for each row. Each row-map contains the column IDs as key and the cell values as value.</param>
		/// <param name="startIndex">The index where to insert the new rows. If null, the rows are appended to the end.</param>
		/// <param name="rememberMaps">Whether to remember the original maps. If true #getRowData will return the original map.</param>
		/// <param name="clearSorting">Whether to clear the sort state.</param>
		[JsMethod(Name = "setRowsAsMapArray")]
		public void SetRowsAsMapArray(object mapArr, double? startIndex = null, bool rememberMaps = false, bool clearSorting = true) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Specify the methods to use for ascending and descending sorts of a
		/// particular column.</para>
		/// </summary>
		/// <param name="columnIndex">The index of the column for which the sort methods are being provided.</param>
		/// <param name="compare">If provided as a Function, this is the comparator function to sort in ascending order. It takes two parameters: the two arrays of row data, row1 and row2, being compared. It may determine which column of the row data to sort on by accessing arguments.callee.columnIndex.  The comparator function must return 1, 0 or -1, when the column in row1 is greater than, equal to, or less than, respectively, the column in row2.  If this parameter is a Map, it shall have two properties: &#8220;ascending&#8221; and &#8220;descending&#8221;. The property value of each is a comparator function, as described above.  If only the &#8220;ascending&#8221; function is provided (i.e. this parameter is a Function, not a Map), then the &#8220;descending&#8221; function is built dynamically by passing the two parameters to the &#8220;ascending&#8221; function in reversed order. Use of a dynamically-built &#8220;descending&#8221; function generates at least one extra function call for each row in the table, and possibly many more. If the table is expected to have more than about 1000 rows, you will likely want to provide a map with a custom &#8220;descending&#8221; sort function as well as the &#8220;ascending&#8221; one.</param>
		[JsMethod(Name = "setSortMethods")]
		public void SetSortMethods(double columnIndex, object compare) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets a cell value by column index.</para>
		/// </summary>
		/// <param name="columnIndex">The index of the column.</param>
		/// <param name="rowIndex">the index of the row.</param>
		/// <param name="value">The new value.</param>
		[JsMethod(Name = "setValue")]
		public void SetValue(double columnIndex, double rowIndex, object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sorts the model by a column.</para>
		/// </summary>
		/// <param name="columnIndex">the column to sort by.</param>
		/// <param name="ascending">whether to sort ascending.</param>
		[JsMethod(Name = "sortByColumn")]
		public void SortByColumn(double columnIndex, bool ascending) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Toggles the (computed) value of the boolean property caseSensitiveSorting.</para>
		/// </summary>
		[JsMethod(Name = "toggleCaseSensitiveSorting")]
		public void ToggleCaseSensitiveSorting() { throw new NotImplementedException(); }

		#endregion Methods
    }
}