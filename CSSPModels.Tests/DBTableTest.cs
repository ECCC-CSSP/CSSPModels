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
    public partial class DBTableTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private CSSPWebToolsDBContext db { get; set; }
        private DBTable dBTable { get; set; }
        #endregion Properties

        #region Constructors
        public DBTableTest()
        {
            db = new CSSPWebToolsDBContext(DatabaseTypeEnum.MemoryNoDBShape);
            dBTable = new DBTable();
        }
        #endregion Constructors

        #region Tests
        // most of the tests are located under DBTableTestGenerated.cs
        #endregion Tests
    }
}
