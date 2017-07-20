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
    public partial class TVItemStatTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private CSSPWebToolsDBContext db { get; set; }
        private TVItemStat tVItemStat { get; set; }
        #endregion Properties

        #region Constructors
        public TVItemStatTest()
        {
            db = new CSSPWebToolsDBContext(DatabaseTypeEnum.MemoryTestDB);
            tVItemStat = new TVItemStat();
        }
        #endregion Constructors

        #region Tests
        // most of the tests are located under TVItemStatTestGenerated.cs
        #endregion Tests
    }
}
