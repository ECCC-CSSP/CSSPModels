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
    public partial class MWQMSubsectorLanguageTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private CSSPWebToolsDBContext db { get; set; }
        private MWQMSubsectorLanguage mWQMSubsectorLanguage { get; set; }
        #endregion Properties

        #region Constructors
        public MWQMSubsectorLanguageTest()
        {
            db = new CSSPWebToolsDBContext(DatabaseTypeEnum.MemoryNoDBShape);
            mWQMSubsectorLanguage = new MWQMSubsectorLanguage();
        }
        #endregion Constructors

        #region Tests
        // most of the tests are located under MWQMSubsectorLanguageTestGenerated.cs
        #endregion Tests
    }
}
