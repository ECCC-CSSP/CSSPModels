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
    public partial class DataPathOfTideTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private CSSPWebToolsDBContext db { get; set; }
        private DataPathOfTide dataPathOfTide { get; set; }
        #endregion Properties

        #region Constructors
        public DataPathOfTideTest()
        {
            db = new CSSPWebToolsDBContext(DatabaseTypeEnum.MemoryTestDB);
            dataPathOfTide = new DataPathOfTide();
        }
        #endregion Constructors

        #region Tests
        // most of the tests are located under DataPathOfTideTestGenerated.cs
        #endregion Tests
    }
}
