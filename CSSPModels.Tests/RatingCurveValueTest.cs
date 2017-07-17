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
    public partial class RatingCurveValueTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private CSSPWebToolsDBContext db { get; set; }
        private RatingCurveValue ratingCurveValue { get; set; }
        #endregion Properties

        #region Constructors
        public RatingCurveValueTest()
        {
            db = new CSSPWebToolsDBContext(DatabaseTypeEnum.MemoryNoDBShape);
            ratingCurveValue = new RatingCurveValue();
        }
        #endregion Constructors

        #region Tests
        // most of the tests are located under RatingCurveValueTestGenerated.cs
        #endregion Tests
    }
}
