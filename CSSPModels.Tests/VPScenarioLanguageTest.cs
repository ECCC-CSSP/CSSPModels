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
    public partial class VPScenarioLanguageTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private CSSPWebToolsDBContext db { get; set; }
        private VPScenarioLanguage vPScenarioLanguage { get; set; }
        #endregion Properties

        #region Constructors
        public VPScenarioLanguageTest()
        {
            db = new CSSPWebToolsDBContext(DatabaseTypeEnum.MemoryTestDB);
            vPScenarioLanguage = new VPScenarioLanguage();
        }
        #endregion Constructors

        #region Tests
        // most of the tests are located under VPScenarioLanguageTestGenerated.cs
        #endregion Tests
    }
}
