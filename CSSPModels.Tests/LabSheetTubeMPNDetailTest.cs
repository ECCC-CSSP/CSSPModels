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
    public partial class LabSheetTubeMPNDetailTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private CSSPWebToolsDBContext db { get; set; }
        private LabSheetTubeMPNDetail labSheetTubeMPNDetail { get; set; }
        #endregion Properties

        #region Constructors
        public LabSheetTubeMPNDetailTest()
        {
            db = new CSSPWebToolsDBContext(DatabaseTypeEnum.MemoryTestDB);
            labSheetTubeMPNDetail = new LabSheetTubeMPNDetail();
        }
        #endregion Constructors

        #region Tests
        // most of the tests are located under LabSheetTubeMPNDetailTestGenerated.cs
        #endregion Tests
    }
}
