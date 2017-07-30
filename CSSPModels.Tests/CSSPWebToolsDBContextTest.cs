using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Collections.Generic;
using CSSPModels;
using Microsoft.EntityFrameworkCore.Metadata;
using System.Reflection;
using CSSPEnums;
using CSSPModels.Resources;

namespace CSSPModels.Tests
{
    [TestClass]
    public partial class CSSPWebToolsDBContextTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        #endregion Properties

        #region Constructors
        public CSSPWebToolsDBContextTest()
        {
        }
        #endregion Constructors

        #region Tests
        [TestMethod]
        public void CSSPWebToolsDBContext_Test()
        {
            CSSPWebToolsDBContext csspWebToolsDBContext = new CSSPWebToolsDBContext();
            Assert.AreEqual(DatabaseTypeEnum.Error, csspWebToolsDBContext.DatabaseType);
            Assert.AreEqual(string.Format(ModelsRes._IsRequired, "DataType"), csspWebToolsDBContext.Error);

            csspWebToolsDBContext = new CSSPWebToolsDBContext(DatabaseTypeEnum.MemoryTestDB);
            Assert.AreEqual(DatabaseTypeEnum.MemoryTestDB, csspWebToolsDBContext.DatabaseType);
            Assert.AreEqual("", csspWebToolsDBContext.Error);

            csspWebToolsDBContext = new CSSPWebToolsDBContext(DatabaseTypeEnum.MemoryCSSPWebToolsDB);
            Assert.AreEqual(DatabaseTypeEnum.MemoryCSSPWebToolsDB, csspWebToolsDBContext.DatabaseType);
            Assert.AreEqual("", csspWebToolsDBContext.Error);

            csspWebToolsDBContext = new CSSPWebToolsDBContext(DatabaseTypeEnum.SqlServerTestDB);
            Assert.AreEqual(DatabaseTypeEnum.SqlServerTestDB, csspWebToolsDBContext.DatabaseType);
            Assert.AreEqual("", csspWebToolsDBContext.Error);

            csspWebToolsDBContext = new CSSPWebToolsDBContext(DatabaseTypeEnum.SqlServerCSSPWebToolsDB);
            Assert.AreEqual(DatabaseTypeEnum.SqlServerCSSPWebToolsDB, csspWebToolsDBContext.DatabaseType);
            Assert.AreEqual("", csspWebToolsDBContext.Error);

            csspWebToolsDBContext = new CSSPWebToolsDBContext((DatabaseTypeEnum)1000000);
            Assert.AreEqual(DatabaseTypeEnum.Error, csspWebToolsDBContext.DatabaseType);
            Assert.AreEqual(string.Format(ModelsRes._IsRequired, "DataType"), csspWebToolsDBContext.Error);
        }
        #endregion Tests
    }
}
