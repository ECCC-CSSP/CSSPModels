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
    public partial class TVTextLanguageTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private CSSPWebToolsDBContext db { get; set; }
        private TVTextLanguage tVTextLanguage { get; set; }
        #endregion Properties

        #region Constructors
        public TVTextLanguageTest()
        {
            db = new CSSPWebToolsDBContext(DatabaseTypeEnum.MemoryTestDB);
            tVTextLanguage = new TVTextLanguage();
        }
        #endregion Constructors

        #region Tests
        // most of the tests are located under TVTextLanguageTestGenerated.cs
        #endregion Tests
    }
}
