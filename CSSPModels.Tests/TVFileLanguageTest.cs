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
    public partial class TVFileLanguageTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private CSSPWebToolsDBContext db { get; set; }
        private TVFileLanguage tVFileLanguage { get; set; }
        #endregion Properties

        #region Constructors
        public TVFileLanguageTest()
        {
            db = new CSSPWebToolsDBContext(DatabaseTypeEnum.MemoryNoDBShape);
            tVFileLanguage = new TVFileLanguage();
        }
        #endregion Constructors

        #region Tests
        // most of the tests are located under TVFileLanguageTestGenerated.cs
        #endregion Tests
    }
}
