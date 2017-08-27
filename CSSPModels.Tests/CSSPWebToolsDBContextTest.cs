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
        public void CSSPWebToolsDBContext_DataType_Test()
        {
            using (CSSPWebToolsDBContext db = new CSSPWebToolsDBContext())
            {
                Assert.AreEqual(DatabaseTypeEnum.Error, db.DatabaseType);
                Assert.AreEqual(string.Format(ModelsRes._IsRequired, "DataType"), db.Error);
                db.Error = "";

                try
                {
                    var values = db.TVItems.FirstOrDefault();
                }
                catch (Exception)
                {
                    // nothing
                }

                Assert.AreEqual(string.Format(ModelsRes._IsRequired, "DataType"), db.Error);
            }
        }
        [TestMethod]
        public void CSSPWebToolsDBContext_DataType_Error_Test()
        {
            using (CSSPWebToolsDBContext db = new CSSPWebToolsDBContext(DatabaseTypeEnum.Error))
            {
                Assert.AreEqual(DatabaseTypeEnum.Error, db.DatabaseType);
                Assert.AreEqual(string.Format(ModelsRes._IsRequired, "DataType"), db.Error);
            }
        }
        [TestMethod]
        public void CSSPWebToolsDBContext_DataType_MemoryTestDB_Test()
        {
            using (CSSPWebToolsDBContext db = new CSSPWebToolsDBContext(DatabaseTypeEnum.MemoryTestDB))
            {
                Assert.AreEqual(DatabaseTypeEnum.MemoryTestDB, db.DatabaseType);
                Assert.AreEqual("", db.Error);
            }
        }
        [TestMethod]
        public void CSSPWebToolsDBContext_DataType_MemoryCSSPWebToolsDB_Test()
        {
            using (CSSPWebToolsDBContext db = new CSSPWebToolsDBContext(DatabaseTypeEnum.MemoryCSSPWebToolsDB))
            {
                Assert.AreEqual(DatabaseTypeEnum.MemoryCSSPWebToolsDB, db.DatabaseType);
                Assert.AreEqual("", db.Error);
            }
        }
        [TestMethod]
        public void CSSPWebToolsDBContext_DataType_SqlServerTestDB_Test()
        {
            using (CSSPWebToolsDBContext db = new CSSPWebToolsDBContext(DatabaseTypeEnum.SqlServerTestDB))
            {
                Assert.AreEqual(DatabaseTypeEnum.SqlServerTestDB, db.DatabaseType);
                Assert.AreEqual("", db.Error);
            }
        }
        [TestMethod]
        public void CSSPWebToolsDBContext_DataType_SqlServerCSSPWebToolsDB_Test()
        {
            using (CSSPWebToolsDBContext db = new CSSPWebToolsDBContext(DatabaseTypeEnum.SqlServerCSSPWebToolsDB))
            {
                Assert.AreEqual(DatabaseTypeEnum.SqlServerCSSPWebToolsDB, db.DatabaseType);
                Assert.AreEqual("", db.Error);
            }
        }
        [TestMethod]
        public void CSSPWebToolsDBContext_DataType_1000000_Test()
        {
            using (CSSPWebToolsDBContext db = new CSSPWebToolsDBContext((DatabaseTypeEnum)1000000))
            {
                Assert.AreEqual(DatabaseTypeEnum.Error, db.DatabaseType);
                Assert.AreEqual(string.Format(ModelsRes._IsRequired, "DataType"), db.Error);
                db.Error = "";

                try
                {
                    var values = db.TVItems.FirstOrDefault();
                }
                catch (Exception)
                {
                    // nothing
                }

                Assert.AreEqual(string.Format(ModelsRes._IsRequired, "DataType"), db.Error);
            }
        }
        #endregion Tests
    }
}
