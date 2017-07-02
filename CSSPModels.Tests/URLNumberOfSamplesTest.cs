using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Collections.Generic;
using CSSPModels;
using Microsoft.EntityFrameworkCore.Metadata;
using System.Reflection;
using CSSPEnums;

namespace CSSPModels.Tests
{
    [TestClass]
    public partial class URLNumberOfSamplesTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private CSSPWebToolsDBContext db { get; set; }
        private URLNumberOfSamples uRLNumberOfSamples { get; set; }
        #endregion Properties

        #region Constructors
        public URLNumberOfSamplesTest()
        {
            db = new CSSPWebToolsDBContext(DatabaseTypeEnum.MemoryNoDBShape);
            uRLNumberOfSamples = new URLNumberOfSamples();
        }
        #endregion Constructors

        #region Tests
        // most of the tests are located under URLNumberOfSamplesTestGenerated.cs
        #endregion Tests
    }
}
