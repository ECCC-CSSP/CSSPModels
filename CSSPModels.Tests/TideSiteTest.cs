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
    public partial class TideSiteTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private CSSPWebToolsDBContext db { get; set; }
        private TideSite tideSite { get; set; }
        #endregion Properties

        #region Constructors
        public TideSiteTest()
        {
            db = new CSSPWebToolsDBContext(DatabaseTypeEnum.MemoryNoDBShape);
            tideSite = new TideSite();
        }
        #endregion Constructors

        #region Tests
        // most of the tests are located under TideSiteTestGenerated.cs
        #endregion Tests
    }
}
