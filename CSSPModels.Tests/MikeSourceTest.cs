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
    public partial class MikeSourceTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private CSSPWebToolsDBContext db { get; set; }
        private MikeSource mikeSource { get; set; }
        #endregion Properties

        #region Constructors
        public MikeSourceTest()
        {
            db = new CSSPWebToolsDBContext(DatabaseTypeEnum.MemoryNoDBShape);
            mikeSource = new MikeSource();
        }
        #endregion Constructors

        #region Tests
        // most of the tests are located under MikeSourceTestGenerated.cs
        #endregion Tests
    }
}
