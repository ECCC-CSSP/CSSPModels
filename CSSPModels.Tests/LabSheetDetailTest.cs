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
    public partial class LabSheetDetailTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private CSSPWebToolsDBContext db { get; set; }
        private LabSheetDetail labSheetDetail { get; set; }
        #endregion Properties

        #region Constructors
        public LabSheetDetailTest()
        {
            db = new CSSPWebToolsDBContext(DatabaseTypeEnum.MemoryNoDBShape);
            labSheetDetail = new LabSheetDetail();
        }
        #endregion Constructors

        #region Tests
        // most of the tests are located under LabSheetDetailTestGenerated.cs
        #endregion Tests
    }
}
