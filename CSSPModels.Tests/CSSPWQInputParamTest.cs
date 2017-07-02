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
    public partial class CSSPWQInputParamTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private CSSPWebToolsDBContext db { get; set; }
        private CSSPWQInputParam cSSPWQInputParam { get; set; }
        #endregion Properties

        #region Constructors
        public CSSPWQInputParamTest()
        {
            db = new CSSPWebToolsDBContext(DatabaseTypeEnum.MemoryNoDBShape);
            cSSPWQInputParam = new CSSPWQInputParam();
        }
        #endregion Constructors

        #region Tests
        // most of the tests are located under CSSPWQInputParamTestGenerated.cs
        #endregion Tests
    }
}
