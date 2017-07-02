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
    public partial class TVFullTextTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private CSSPWebToolsDBContext db { get; set; }
        private TVFullText tVFullText { get; set; }
        #endregion Properties

        #region Constructors
        public TVFullTextTest()
        {
            db = new CSSPWebToolsDBContext(DatabaseTypeEnum.MemoryNoDBShape);
            tVFullText = new TVFullText();
        }
        #endregion Constructors

        #region Tests
        // most of the tests are located under TVFullTextTestGenerated.cs
        #endregion Tests
    }
}
