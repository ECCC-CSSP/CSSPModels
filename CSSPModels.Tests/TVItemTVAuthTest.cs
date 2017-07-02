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
    public partial class TVItemTVAuthTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private CSSPWebToolsDBContext db { get; set; }
        private TVItemTVAuth tVItemTVAuth { get; set; }
        #endregion Properties

        #region Constructors
        public TVItemTVAuthTest()
        {
            db = new CSSPWebToolsDBContext(DatabaseTypeEnum.MemoryNoDBShape);
            tVItemTVAuth = new TVItemTVAuth();
        }
        #endregion Constructors

        #region Tests
        // most of the tests are located under TVItemTVAuthTestGenerated.cs
        #endregion Tests
    }
}
