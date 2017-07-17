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
    public partial class LabSheetTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private CSSPWebToolsDBContext db { get; set; }
        private LabSheet labSheet { get; set; }
        #endregion Properties

        #region Constructors
        public LabSheetTest()
        {
            db = new CSSPWebToolsDBContext(DatabaseTypeEnum.MemoryNoDBShape);
            labSheet = new LabSheet();
        }
        #endregion Constructors

        #region Tests
        // most of the tests are located under LabSheetTestGenerated.cs
        #endregion Tests
    }
}
