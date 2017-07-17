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
    public partial class MikeBoundaryConditionTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private CSSPWebToolsDBContext db { get; set; }
        private MikeBoundaryCondition mikeBoundaryCondition { get; set; }
        #endregion Properties

        #region Constructors
        public MikeBoundaryConditionTest()
        {
            db = new CSSPWebToolsDBContext(DatabaseTypeEnum.MemoryNoDBShape);
            mikeBoundaryCondition = new MikeBoundaryCondition();
        }
        #endregion Constructors

        #region Tests
        // most of the tests are located under MikeBoundaryConditionTestGenerated.cs
        #endregion Tests
    }
}
