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
    public partial class MWQMSubsectorTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private CSSPWebToolsDBContext db { get; set; }
        private MWQMSubsector mWQMSubsector { get; set; }
        #endregion Properties

        #region Constructors
        public MWQMSubsectorTest()
        {
            db = new CSSPWebToolsDBContext(DatabaseTypeEnum.MemoryNoDBShape);
            mWQMSubsector = new MWQMSubsector();
        }
        #endregion Constructors

        #region Tests
        // most of the tests are located under MWQMSubsectorTestGenerated.cs
        #endregion Tests
    }
}
