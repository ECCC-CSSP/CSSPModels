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
    public partial class VPScenarioIDAndRawResultsTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private CSSPWebToolsDBContext db { get; set; }
        private VPScenarioIDAndRawResults vPScenarioIDAndRawResults { get; set; }
        #endregion Properties

        #region Constructors
        public VPScenarioIDAndRawResultsTest()
        {
            db = new CSSPWebToolsDBContext(DatabaseTypeEnum.MemoryNoDBShape);
            vPScenarioIDAndRawResults = new VPScenarioIDAndRawResults();
        }
        #endregion Constructors

        #region Tests
        // most of the tests are located under VPScenarioIDAndRawResultsTestGenerated.cs
        #endregion Tests
    }
}
