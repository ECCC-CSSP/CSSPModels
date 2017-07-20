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
    public partial class AppTaskLanguageTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private CSSPWebToolsDBContext db { get; set; }
        private AppTaskLanguage appTaskLanguage { get; set; }
        #endregion Properties

        #region Constructors
        public AppTaskLanguageTest()
        {
            db = new CSSPWebToolsDBContext(DatabaseTypeEnum.MemoryTestDB);
            appTaskLanguage = new AppTaskLanguage();
        }
        #endregion Constructors

        #region Tests
        // most of the tests are located under AppTaskLanguageTestGenerated.cs
        #endregion Tests
    }
}
