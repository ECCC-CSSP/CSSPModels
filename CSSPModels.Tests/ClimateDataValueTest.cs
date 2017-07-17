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
    public partial class ClimateDataValueTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private CSSPWebToolsDBContext db { get; set; }
        private ClimateDataValue climateDataValue { get; set; }
        #endregion Properties

        #region Constructors
        public ClimateDataValueTest()
        {
            db = new CSSPWebToolsDBContext(DatabaseTypeEnum.MemoryNoDBShape);
            climateDataValue = new ClimateDataValue();
        }
        #endregion Constructors

        #region Tests
        // most of the tests are located under ClimateDataValueTestGenerated.cs
        #endregion Tests
    }
}
