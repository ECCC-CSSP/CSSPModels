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
    public partial class RatingCurveTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private CSSPWebToolsDBContext db { get; set; }
        private RatingCurve ratingCurve { get; set; }
        #endregion Properties

        #region Constructors
        public RatingCurveTest()
        {
            db = new CSSPWebToolsDBContext(DatabaseTypeEnum.MemoryTestDB);
            ratingCurve = new RatingCurve();
        }
        #endregion Constructors

        #region Tests
        // most of the tests are located under RatingCurveTestGenerated.cs
        #endregion Tests
    }
}
