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
    public partial class TideDataValueTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private CSSPWebToolsDBContext db { get; set; }
        private TideDataValue tideDataValue { get; set; }
        #endregion Properties

        #region Constructors
        public TideDataValueTest()
        {
            db = new CSSPWebToolsDBContext(DatabaseTypeEnum.MemoryNoDBShape);
            tideDataValue = new TideDataValue();
        }
        #endregion Constructors

        #region Tests
        // most of the tests are located under TideDataValueTestGenerated.cs
        #endregion Tests
    }
}
