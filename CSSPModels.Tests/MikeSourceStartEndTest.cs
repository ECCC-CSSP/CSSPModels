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
    public partial class MikeSourceStartEndTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private CSSPWebToolsDBContext db { get; set; }
        private MikeSourceStartEnd mikeSourceStartEnd { get; set; }
        #endregion Properties

        #region Constructors
        public MikeSourceStartEndTest()
        {
            db = new CSSPWebToolsDBContext(DatabaseTypeEnum.MemoryTestDB);
            mikeSourceStartEnd = new MikeSourceStartEnd();
        }
        #endregion Constructors

        #region Tests
        // most of the tests are located under MikeSourceStartEndTestGenerated.cs
        #endregion Tests
    }
}
