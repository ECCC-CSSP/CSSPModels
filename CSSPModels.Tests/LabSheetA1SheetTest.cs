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
    public partial class LabSheetA1SheetTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private CSSPWebToolsDBContext db { get; set; }
        private LabSheetA1Sheet labSheetA1Sheet { get; set; }
        #endregion Properties

        #region Constructors
        public LabSheetA1SheetTest()
        {
            db = new CSSPWebToolsDBContext(DatabaseTypeEnum.MemoryNoDBShape);
            labSheetA1Sheet = new LabSheetA1Sheet();
        }
        #endregion Constructors

        #region Tests
        // most of the tests are located under LabSheetA1SheetTestGenerated.cs
        #endregion Tests
    }
}
