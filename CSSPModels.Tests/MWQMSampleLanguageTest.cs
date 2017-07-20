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
    public partial class MWQMSampleLanguageTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private CSSPWebToolsDBContext db { get; set; }
        private MWQMSampleLanguage mWQMSampleLanguage { get; set; }
        #endregion Properties

        #region Constructors
        public MWQMSampleLanguageTest()
        {
            db = new CSSPWebToolsDBContext(DatabaseTypeEnum.MemoryTestDB);
            mWQMSampleLanguage = new MWQMSampleLanguage();
        }
        #endregion Constructors

        #region Tests
        // most of the tests are located under MWQMSampleLanguageTestGenerated.cs
        #endregion Tests
    }
}
