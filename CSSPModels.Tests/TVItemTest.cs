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
    public partial class TVItemTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private CSSPWebToolsDBContext db { get; set; }
        private TVItem tVItem { get; set; }
        #endregion Properties

        #region Constructors
        public TVItemTest()
        {
            db = new CSSPWebToolsDBContext(DatabaseTypeEnum.MemoryTestDB);
            tVItem = new TVItem();
        }
        #endregion Constructors

        #region Tests
        // most of the tests are located under TVItemTestGenerated.cs
        #endregion Tests
    }
}
