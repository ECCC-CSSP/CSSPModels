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
    public partial class CalDecayTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private CSSPWebToolsDBContext db { get; set; }
        private CalDecay calDecay { get; set; }
        #endregion Properties

        #region Constructors
        public CalDecayTest()
        {
            db = new CSSPWebToolsDBContext(DatabaseTypeEnum.MemoryTestDB);
            calDecay = new CalDecay();
        }
        #endregion Constructors

        #region Tests
        // most of the tests are located under CalDecayTestGenerated.cs
        #endregion Tests
    }
}
