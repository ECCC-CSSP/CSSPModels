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
    public partial class MapInfoPointTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private CSSPWebToolsDBContext db { get; set; }
        private MapInfoPoint mapInfoPoint { get; set; }
        #endregion Properties

        #region Constructors
        public MapInfoPointTest()
        {
            db = new CSSPWebToolsDBContext(DatabaseTypeEnum.MemoryTestDB);
            mapInfoPoint = new MapInfoPoint();
        }
        #endregion Constructors

        #region Tests
        // most of the tests are located under MapInfoPointTestGenerated.cs
        #endregion Tests
    }
}
