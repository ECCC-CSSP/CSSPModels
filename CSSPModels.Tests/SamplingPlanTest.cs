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
    public partial class SamplingPlanTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private CSSPWebToolsDBContext db { get; set; }
        private SamplingPlan samplingPlan { get; set; }
        #endregion Properties

        #region Constructors
        public SamplingPlanTest()
        {
            db = new CSSPWebToolsDBContext(DatabaseTypeEnum.MemoryNoDBShape);
            samplingPlan = new SamplingPlan();
        }
        #endregion Constructors

        #region Tests
        // most of the tests are located under SamplingPlanTestGenerated.cs
        #endregion Tests
    }
}
