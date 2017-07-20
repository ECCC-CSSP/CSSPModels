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
    public partial class TVTypeUserAuthorizationTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private CSSPWebToolsDBContext db { get; set; }
        private TVTypeUserAuthorization tVTypeUserAuthorization { get; set; }
        #endregion Properties

        #region Constructors
        public TVTypeUserAuthorizationTest()
        {
            db = new CSSPWebToolsDBContext(DatabaseTypeEnum.MemoryTestDB);
            tVTypeUserAuthorization = new TVTypeUserAuthorization();
        }
        #endregion Constructors

        #region Tests
        // most of the tests are located under TVTypeUserAuthorizationTestGenerated.cs
        #endregion Tests
    }
}
