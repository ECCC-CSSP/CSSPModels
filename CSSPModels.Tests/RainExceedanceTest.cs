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
    public partial class RainExceedanceTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private CSSPWebToolsDBContext db { get; set; }
        private RainExceedance rainExceedance { get; set; }
        #endregion Properties

        #region Constructors
        public RainExceedanceTest()
        {
            db = new CSSPWebToolsDBContext(DatabaseTypeEnum.MemoryTestDB);
            rainExceedance = new RainExceedance();
        }
        #endregion Constructors

        #region Tests
        // most of the tests are located under RainExceedanceTestGenerated.cs
        #endregion Tests
    }
}