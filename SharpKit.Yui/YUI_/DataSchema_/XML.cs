//***************************************************
//* This file was generated by tool
//* SharpKit
//***************************************************
using System;
using System.Collections.Generic;
using SharpKit.JavaScript;
namespace YUI_.DataSchema_
{
    /// <summary>
    /// Provides a DataSchema implementation which can be used to work with XML data.
    /// See the `apply` method for usage.
    /// </summary>
    public partial class XML : YUI_.DataSchema_.Base
    {
        /// <summary>
        /// Get an XPath-specified value for a given field from an XML node or document.
        /// </summary>
        protected object _getLocationValue(object field, object context){return null;}
        /// <summary>
        /// Fetches the XPath-specified result for a given location in an XML node
        /// or document.
        /// </summary>
        protected object _getXPathResult(object locator, object context, object xmldoc){return null;}
        /// <summary>
        /// Schema-parsed result field.
        /// </summary>
        protected void _parseField(object field, object result, object context){}
        /// <summary>
        /// Parses results data according to schema
        /// </summary>
        protected object _parseMeta(object xmldoc_in, object data_out){return null;}
        /// <summary>
        /// Schema-parsed result to add to results list.
        /// </summary>
        protected object _parseResult(YUI_.Array fields, object context){return null;}
        /// <summary>
        /// Schema-parsed list of results from full data
        /// </summary>
        protected object _parseResults(object schema, object context, object data_out){return null;}
        /// <summary>
        /// Applies a schema to an XML data tree, returning a normalized object with
        /// results in the `results` property. Additional information can be parsed out
        /// of the XML for inclusion in the `meta` property of the response object.  If
        /// an error is encountered during processing, an `error` property will be
        /// added.
        /// Field data in the nodes captured by the XPath in _schema.resultListLocator_
        /// is extracted with the field identifiers described in _schema.resultFields_.
        /// Field identifiers are objects with the following properties:
        /// * `key`    : <strong>(required)</strong> The desired property name to use
        /// store the retrieved value in the result object.  If `locator` is
        /// not specified, `key` is also used as the XPath locator (String)
        /// * `locator`: The XPath locator to the node or attribute within each
        /// result node found by _schema.resultListLocator_ containing the
        /// desired field data (String)
        /// * `parser` : A function or the name of a function on `Y.Parsers` used
        /// to convert the input value into a normalized type.  Parser
        /// functions are passed the value as input and are expected to
        /// return a value.
        /// * `schema` : Used to retrieve nested field data into an array for
        /// assignment as the result field value.  This object follows the same
        /// conventions as _schema_.
        /// If no value parsing or nested parsing is needed, you can use XPath locators
        /// (strings) instead of field identifiers (objects) -- see example below.
        /// `response.results` will contain an array of objects with key:value pairs.
        /// The keys are the field identifier `key`s, and the values are the data
        /// values extracted from the nodes or attributes found by the field `locator`
        /// (or `key` fallback).
        /// To extract additional information from the XML, include an array of
        /// XPath locators in _schema.metaFields_.  The collected values will be
        /// stored in `response.meta` with the XPath locator as keys.
        /// </summary>
        public object apply(object schema, object data){return null;}
    }
}