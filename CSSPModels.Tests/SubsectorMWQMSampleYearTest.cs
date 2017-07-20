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
    public partial class SubsectorMWQMSampleYearTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private CSSPWebToolsDBContext db { get; set; }
        private SubsectorMWQMSampleYear subsectorMWQMSampleYear { get; set; }
        #endregion Properties

        #region Constructors
        public SubsectorMWQMSampleYearTest()
        {
            db = new CSSPWebToolsDBContext(DatabaseTypeEnum.MemoryTestDB);
            subsectorMWQMSampleYear = new SubsectorMWQMSampleYear();
        }
        #endregion Constructors

        #region Tests
        // most of the tests are located under SubsectorMWQMSampleYearTestGenerated.cs
        #endregion Tests
    }
}
