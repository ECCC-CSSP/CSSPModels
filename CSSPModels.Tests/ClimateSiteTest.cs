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
    public partial class ClimateSiteTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private CSSPWebToolsDBContext db { get; set; }
        private ClimateSite climateSite { get; set; }
        #endregion Properties

        #region Constructors
        public ClimateSiteTest()
        {
            db = new CSSPWebToolsDBContext(DatabaseTypeEnum.MemoryNoDBShape);
            climateSite = new ClimateSite();
        }
        #endregion Constructors

        #region Tests
        // most of the tests are located under ClimateSiteTestGenerated.cs
        #endregion Tests
    }
}
