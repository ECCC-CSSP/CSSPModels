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
    public partial class AppErrLogTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private CSSPWebToolsDBContext db { get; set; }
        private AppErrLog appErrLog { get; set; }
        #endregion Properties

        #region Constructors
        public AppErrLogTest()
        {
            db = new CSSPWebToolsDBContext(DatabaseTypeEnum.MemoryNoDBShape);
            appErrLog = new AppErrLog();
        }
        #endregion Constructors

        #region Tests
        // most of the tests are located under AppErrLogTestGenerated.cs
        #endregion Tests
    }
}
