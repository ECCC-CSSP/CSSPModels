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
    public partial class TVLocationTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private CSSPWebToolsDBContext db { get; set; }
        private TVLocation tVLocation { get; set; }
        #endregion Properties

        #region Constructors
        public TVLocationTest()
        {
            db = new CSSPWebToolsDBContext(DatabaseTypeEnum.MemoryTestDB);
            tVLocation = new TVLocation();
        }
        #endregion Constructors

        #region Tests
        // most of the tests are located under TVLocationTestGenerated.cs
        #endregion Tests
    }
}
