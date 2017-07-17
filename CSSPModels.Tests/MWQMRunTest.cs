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
    public partial class MWQMRunTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private CSSPWebToolsDBContext db { get; set; }
        private MWQMRun mWQMRun { get; set; }
        #endregion Properties

        #region Constructors
        public MWQMRunTest()
        {
            db = new CSSPWebToolsDBContext(DatabaseTypeEnum.MemoryNoDBShape);
            mWQMRun = new MWQMRun();
        }
        #endregion Constructors

        #region Tests
        // most of the tests are located under MWQMRunTestGenerated.cs
        #endregion Tests
    }
}
