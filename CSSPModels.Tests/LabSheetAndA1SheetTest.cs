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
    public partial class LabSheetAndA1SheetTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private CSSPWebToolsDBContext db { get; set; }
        private LabSheetAndA1Sheet labSheetAndA1Sheet { get; set; }
        #endregion Properties

        #region Constructors
        public LabSheetAndA1SheetTest()
        {
            db = new CSSPWebToolsDBContext(DatabaseTypeEnum.MemoryNoDBShape);
            labSheetAndA1Sheet = new LabSheetAndA1Sheet();
        }
        #endregion Constructors

        #region Tests
        // most of the tests are located under LabSheetAndA1SheetTestGenerated.cs
        #endregion Tests
    }
}
