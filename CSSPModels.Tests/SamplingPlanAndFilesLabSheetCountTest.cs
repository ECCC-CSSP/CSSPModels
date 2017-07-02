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
    public partial class SamplingPlanAndFilesLabSheetCountTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private CSSPWebToolsDBContext db { get; set; }
        private SamplingPlanAndFilesLabSheetCount samplingPlanAndFilesLabSheetCount { get; set; }
        #endregion Properties

        #region Constructors
        public SamplingPlanAndFilesLabSheetCountTest()
        {
            db = new CSSPWebToolsDBContext(DatabaseTypeEnum.MemoryNoDBShape);
            samplingPlanAndFilesLabSheetCount = new SamplingPlanAndFilesLabSheetCount();
        }
        #endregion Constructors

        #region Tests
        // most of the tests are located under SamplingPlanAndFilesLabSheetCountTestGenerated.cs
        #endregion Tests
    }
}
