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
    public partial class BoxModelLanguageTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private CSSPWebToolsDBContext db { get; set; }
        private BoxModelLanguage boxModelLanguage { get; set; }
        #endregion Properties

        #region Constructors
        public BoxModelLanguageTest()
        {
            db = new CSSPWebToolsDBContext(DatabaseTypeEnum.MemoryTestDB);
            boxModelLanguage = new BoxModelLanguage();
        }
        #endregion Constructors

        #region Tests
        // most of the tests are located under BoxModelLanguageTestGenerated.cs
        #endregion Tests
    }
}
