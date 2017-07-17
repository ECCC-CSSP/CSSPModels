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
    public partial class HydrometricSiteTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private CSSPWebToolsDBContext db { get; set; }
        private HydrometricSite hydrometricSite { get; set; }
        #endregion Properties

        #region Constructors
        public HydrometricSiteTest()
        {
            db = new CSSPWebToolsDBContext(DatabaseTypeEnum.MemoryNoDBShape);
            hydrometricSite = new HydrometricSite();
        }
        #endregion Constructors

        #region Tests
        // most of the tests are located under HydrometricSiteTestGenerated.cs
        #endregion Tests
    }
}
