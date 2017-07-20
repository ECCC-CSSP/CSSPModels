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
    public partial class MikeScenarioTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private CSSPWebToolsDBContext db { get; set; }
        private MikeScenario mikeScenario { get; set; }
        #endregion Properties

        #region Constructors
        public MikeScenarioTest()
        {
            db = new CSSPWebToolsDBContext(DatabaseTypeEnum.MemoryTestDB);
            mikeScenario = new MikeScenario();
        }
        #endregion Constructors

        #region Tests
        // most of the tests are located under MikeScenarioTestGenerated.cs
        #endregion Tests
    }
}
