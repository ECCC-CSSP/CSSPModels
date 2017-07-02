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
    public partial class MWQMSiteSampleFCTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private CSSPWebToolsDBContext db { get; set; }
        private MWQMSiteSampleFC mWQMSiteSampleFC { get; set; }
        #endregion Properties

        #region Constructors
        public MWQMSiteSampleFCTest()
        {
            db = new CSSPWebToolsDBContext(DatabaseTypeEnum.MemoryNoDBShape);
            mWQMSiteSampleFC = new MWQMSiteSampleFC();
        }
        #endregion Constructors

        #region Tests
        // most of the tests are located under MWQMSiteSampleFCTestGenerated.cs
        #endregion Tests
    }
}
