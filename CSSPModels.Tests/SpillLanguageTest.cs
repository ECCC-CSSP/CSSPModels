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
    public partial class SpillLanguageTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private CSSPWebToolsDBContext db { get; set; }
        private SpillLanguage spillLanguage { get; set; }
        #endregion Properties

        #region Constructors
        public SpillLanguageTest()
        {
            db = new CSSPWebToolsDBContext(DatabaseTypeEnum.MemoryTestDB);
            spillLanguage = new SpillLanguage();
        }
        #endregion Constructors

        #region Tests
        // most of the tests are located under SpillLanguageTestGenerated.cs
        #endregion Tests
    }
}
