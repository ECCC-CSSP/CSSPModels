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
    public partial class LabSheetA1MeasurementTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private CSSPWebToolsDBContext db { get; set; }
        private LabSheetA1Measurement labSheetA1Measurement { get; set; }
        #endregion Properties

        #region Constructors
        public LabSheetA1MeasurementTest()
        {
            db = new CSSPWebToolsDBContext(DatabaseTypeEnum.MemoryNoDBShape);
            labSheetA1Measurement = new LabSheetA1Measurement();
        }
        #endregion Constructors

        #region Tests
        // most of the tests are located under LabSheetA1MeasurementTestGenerated.cs
        #endregion Tests
    }
}
