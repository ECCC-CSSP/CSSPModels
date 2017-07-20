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
    public partial class MWQMSiteTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private CSSPWebToolsDBContext db { get; set; }
        private MWQMSite mWQMSite { get; set; }
        #endregion Properties

        #region Constructors
        public MWQMSiteTest()
        {
            db = new CSSPWebToolsDBContext(DatabaseTypeEnum.MemoryTestDB);
            mWQMSite = new MWQMSite();
        }
        #endregion Constructors

        #region Tests
        // most of the tests are located under MWQMSiteTestGenerated.cs
        #endregion Tests
    }
}
