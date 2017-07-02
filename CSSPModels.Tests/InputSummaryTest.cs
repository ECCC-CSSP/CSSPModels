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
    public partial class InputSummaryTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private CSSPWebToolsDBContext db { get; set; }
        private InputSummary inputSummary { get; set; }
        #endregion Properties

        #region Constructors
        public InputSummaryTest()
        {
            db = new CSSPWebToolsDBContext(DatabaseTypeEnum.MemoryNoDBShape);
            inputSummary = new InputSummary();
        }
        #endregion Constructors

        #region Tests
        // most of the tests are located under InputSummaryTestGenerated.cs
        #endregion Tests
    }
}
