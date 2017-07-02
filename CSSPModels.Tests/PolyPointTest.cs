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
    public partial class PolyPointTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private CSSPWebToolsDBContext db { get; set; }
        private PolyPoint polyPoint { get; set; }
        #endregion Properties

        #region Constructors
        public PolyPointTest()
        {
            db = new CSSPWebToolsDBContext(DatabaseTypeEnum.MemoryNoDBShape);
            polyPoint = new PolyPoint();
        }
        #endregion Constructors

        #region Tests
        // most of the tests are located under PolyPointTestGenerated.cs
        #endregion Tests
    }
}
