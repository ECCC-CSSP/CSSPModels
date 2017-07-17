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
    public partial class UseOfSiteTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private CSSPWebToolsDBContext db { get; set; }
        private UseOfSite useOfSite { get; set; }
        #endregion Properties

        #region Constructors
        public UseOfSiteTest()
        {
            db = new CSSPWebToolsDBContext(DatabaseTypeEnum.MemoryNoDBShape);
            useOfSite = new UseOfSite();
        }
        #endregion Constructors

        #region Tests
        // most of the tests are located under UseOfSiteTestGenerated.cs
        #endregion Tests
    }
}
