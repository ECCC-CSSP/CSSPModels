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
    public partial class CSSPFillAttributeTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private CSSPWebToolsDBContext db { get; set; }
        private CSSPFillAttribute cSSPFillAttribute { get; set; }
        #endregion Properties

        #region Constructors
        public CSSPFillAttributeTest()
        {
            db = new CSSPWebToolsDBContext(DatabaseTypeEnum.MemoryTestDB);
            cSSPFillAttribute = new CSSPFillAttribute();
        }
        #endregion Constructors

        #region Tests
        // most of the tests are located under CSSPFillAttributeTestGenerated.cs
        #endregion Tests
    }
}
