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
    public partial class LatLngTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private CSSPWebToolsDBContext db { get; set; }
        private LatLng latLng { get; set; }
        #endregion Properties

        #region Constructors
        public LatLngTest()
        {
            db = new CSSPWebToolsDBContext(DatabaseTypeEnum.MemoryNoDBShape);
            latLng = new LatLng();
        }
        #endregion Constructors

        #region Tests
        // most of the tests are located under LatLngTestGenerated.cs
        #endregion Tests
    }
}
