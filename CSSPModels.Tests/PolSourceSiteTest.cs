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
    public partial class PolSourceSiteTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private CSSPWebToolsDBContext db { get; set; }
        private PolSourceSite polSourceSite { get; set; }
        #endregion Properties

        #region Constructors
        public PolSourceSiteTest()
        {
            db = new CSSPWebToolsDBContext(DatabaseTypeEnum.MemoryTestDB);
            polSourceSite = new PolSourceSite();
        }
        #endregion Constructors

        #region Tests
        // most of the tests are located under PolSourceSiteTestGenerated.cs
        #endregion Tests
    }
}
