//***************************************************
//* This file was generated by tool
//* SharpKit
//***************************************************
using System;
using System.Collections.Generic;
using SharpKit.JavaScript;
namespace Y_.Test_
{
    /// <summary>
    /// Convenience type for storing and aggregating
    /// test result information.
    /// </summary>
    public partial class Results
    {
        /// <summary>
        /// Includes results from another results object into this one.
        /// </summary>
        public object include(Results result){return null;}
        /// <summary>
        /// Amount of time (ms) it took to complete testing.
        /// </summary>
        public int duration{get;set;}
        /// <summary>
        /// Number of errors that occur in non-test methods.
        /// </summary>
        public int errors{get;set;}
        /// <summary>
        /// Number of failed tests.
        /// </summary>
        public int failed{get;set;}
        /// <summary>
        /// Number of ignored tests.
        /// </summary>
        public int ignored{get;set;}
        /// <summary>
        /// Number of passed tests.
        /// </summary>
        public int passed{get;set;}
        /// <summary>
        /// Number of total tests.
        /// </summary>
        public int total{get;set;}
    }
}
