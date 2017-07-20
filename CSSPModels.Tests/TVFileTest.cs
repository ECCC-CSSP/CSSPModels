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
    public partial class TVFileTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private CSSPWebToolsDBContext db { get; set; }
        private TVFile tVFile { get; set; }
        #endregion Properties

        #region Constructors
        public TVFileTest()
        {
            db = new CSSPWebToolsDBContext(DatabaseTypeEnum.MemoryTestDB);
            tVFile = new TVFile();
        }
        #endregion Constructors

        #region Tests
        // most of the tests are located under TVFileTestGenerated.cs
        #endregion Tests
    }
}
