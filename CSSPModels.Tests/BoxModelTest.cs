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
    public partial class BoxModelTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private CSSPWebToolsDBContext db { get; set; }
        private BoxModel boxModel { get; set; }
        #endregion Properties

        #region Constructors
        public BoxModelTest()
        {
            db = new CSSPWebToolsDBContext(DatabaseTypeEnum.MemoryTestDB);
            boxModel = new BoxModel();
        }
        #endregion Constructors

        #region Tests
        // most of the tests are located under BoxModelTestGenerated.cs
        #endregion Tests
    }
}
