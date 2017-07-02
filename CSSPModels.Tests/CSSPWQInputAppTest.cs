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
    public partial class CSSPWQInputAppTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private CSSPWebToolsDBContext db { get; set; }
        private CSSPWQInputApp cSSPWQInputApp { get; set; }
        #endregion Properties

        #region Constructors
        public CSSPWQInputAppTest()
        {
            db = new CSSPWebToolsDBContext(DatabaseTypeEnum.MemoryNoDBShape);
            cSSPWQInputApp = new CSSPWQInputApp();
        }
        #endregion Constructors

        #region Tests
        // most of the tests are located under CSSPWQInputAppTestGenerated.cs
        #endregion Tests
    }
}
