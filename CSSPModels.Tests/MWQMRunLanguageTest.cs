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
    public partial class MWQMRunLanguageTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private CSSPWebToolsDBContext db { get; set; }
        private MWQMRunLanguage mWQMRunLanguage { get; set; }
        #endregion Properties

        #region Constructors
        public MWQMRunLanguageTest()
        {
            db = new CSSPWebToolsDBContext(DatabaseTypeEnum.MemoryTestDB);
            mWQMRunLanguage = new MWQMRunLanguage();
        }
        #endregion Constructors

        #region Tests
        // most of the tests are located under MWQMRunLanguageTestGenerated.cs
        #endregion Tests
    }
}
