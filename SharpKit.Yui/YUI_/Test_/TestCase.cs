//***************************************************
//* This file was generated by tool
//* SharpKit
//***************************************************
using System;
using System.Collections.Generic;
using SharpKit.JavaScript;
namespace YUI_.Test_
{
    /// <summary>
    /// Test case containing various tests to run.
    /// </summary>
    public partial class TestCase
    {
        /// <summary>
        /// Asserts that a given condition is true. If not, then a YUITest.AssertionError object is thrown
        /// and the test fails.
        /// </summary>
        public void assert(object condition, object message){}
        /// <summary>
        /// Method to call from an async init method to
        /// restart the test case. When called, returns a function
        /// that should be called when tests are ready to continue.
        /// </summary>
        public JsAction callback(){return null;}
        /// <summary>
        /// Forces an assertion error to occur. Shortcut for YUITest.Assert.fail().
        /// </summary>
        public void fail(object message){}
        /// <summary>
        /// Resumes a paused test and runs the given function.
        /// </summary>
        public object resume(JsAction segment){return null;}
        /// <summary>
        /// Function to run before each test is executed.
        /// </summary>
        public object setUp(){return null;}
        /// <summary>
        /// Function to run after each test is executed.
        /// </summary>
        public object tearDown(){return null;}
        /// <summary>
        /// Causes the test case to wait a specified amount of time and then
        /// continue executing the given code.
        /// </summary>
        public object wait(JsAction segment, object delay){return null;}
    }
}