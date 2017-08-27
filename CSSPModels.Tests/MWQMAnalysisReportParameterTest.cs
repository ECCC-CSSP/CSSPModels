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
    public partial class MWQMAnalysisReportParameterTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private CSSPWebToolsDBContext db { get; set; }
        private MWQMAnalysisReportParameter mWQMAnalysisReportParameter { get; set; }
        #endregion Properties

        #region Constructors
        public MWQMAnalysisReportParameterTest()
        {
            db = new CSSPWebToolsDBContext(DatabaseTypeEnum.MemoryTestDB);
            mWQMAnalysisReportParameter = new MWQMAnalysisReportParameter();
        }
        #endregion Constructors

        #region Tests
        // most of the tests are located under MWQMAnalysisReportParameterTestGenerated.cs
        #endregion Tests
    }
}
