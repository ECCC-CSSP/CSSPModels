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
    public partial class PolSourceObservationIssueTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private CSSPWebToolsDBContext db { get; set; }
        private PolSourceObservationIssue polSourceObservationIssue { get; set; }
        #endregion Properties

        #region Constructors
        public PolSourceObservationIssueTest()
        {
            db = new CSSPWebToolsDBContext(DatabaseTypeEnum.MemoryNoDBShape);
            polSourceObservationIssue = new PolSourceObservationIssue();
        }
        #endregion Constructors

        #region Tests
        // most of the tests are located under PolSourceObservationIssueTestGenerated.cs
        #endregion Tests
    }
}
