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
    public partial class VPScenarioTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private CSSPWebToolsDBContext db { get; set; }
        private VPScenario vPScenario { get; set; }
        #endregion Properties

        #region Constructors
        public VPScenarioTest()
        {
            db = new CSSPWebToolsDBContext(DatabaseTypeEnum.MemoryTestDB);
            vPScenario = new VPScenario();
        }
        #endregion Constructors

        #region Tests
        // most of the tests are located under VPScenarioTestGenerated.cs
        #endregion Tests
    }
}
