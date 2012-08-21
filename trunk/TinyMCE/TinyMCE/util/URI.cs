//***************************************************
//* This file was generated by tool
//* SharpKit
//***************************************************
using System;
using System.Collections.Generic;
using SharpKit.JavaScript;
namespace SharpKit.TinyMCE.util
{
    /// <summary>
    /// This class handles parsing, modification and serialization of URI/URL strings.
    /// </summary>
    [JsType(JsMode.Prototype, Name="tinymce.util.URI", Export=false)]
    public  partial class URI
    {
        /// <summary>
        /// Returns the full URI of the internal structure.
        /// </summary>
        /// <param name="nh">Optional no host and protocol part. Defaults to false.</param>
        public object getURI(bool nh){return null;}
        /// <summary>
        /// Sets the internal path part of the URI.
        /// </summary>
        /// <param name="p">Path string to set.</param>
        public object setPath(string p){return null;}
        /// <summary>
        /// Converts the specified URI into a absolute URI based on the current URI instance location.
        /// </summary>
        /// <param name="u">URI to convert into a relative path/URI.</param>
        /// <param name="nh">No host and protocol prefix.</param>
        public string toAbsolute(string u, bool nh){return null;}
        /// <summary>
        /// Converts a relative path into a absolute path.
        /// </summary>
        /// <param name="base">Base point to convert the path from.</param>
        /// <param name="path">Relative path to convert into an absolute path.</param>
        public object toAbsPath(string @base, string path){return null;}
        /// <summary>
        /// Converts the specified URI into a relative URI based on the current URI instance location.
        /// </summary>
        /// <param name="u">URI to convert into a relative path/URI.</param>
        public string toRelative(string u){return null;}
        /// <summary>
        /// Converts a absolute path into a relative path.
        /// </summary>
        /// <param name="base">Base point to convert the path from.</param>
        /// <param name="path">Absolute path to convert into a relative path.</param>
        public object toRelPath(string @base, string path){return null;}
        /// <summary>
        /// Constucts a new URI instance.
        /// </summary>
        /// <param name="u">URI string to parse.</param>
        /// <param name="s">Optional settings object.</param>
        public URI(string u, object s){}
    }
}
