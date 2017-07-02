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
    public partial class TVItemSubsectorAndMWQMSiteTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private CSSPWebToolsDBContext db { get; set; }
        private TVItemSubsectorAndMWQMSite tVItemSubsectorAndMWQMSite { get; set; }
        #endregion Properties

        #region Constructors
        public TVItemSubsectorAndMWQMSiteTest()
        {
            db = new CSSPWebToolsDBContext(DatabaseTypeEnum.MemoryNoDBShape);
            tVItemSubsectorAndMWQMSite = new TVItemSubsectorAndMWQMSite();
        }
        #endregion Constructors

        #region Tests
        // most of the tests are located under TVItemSubsectorAndMWQMSiteTestGenerated.cs
        #endregion Tests
    }
}
