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
    public partial class TVItemLinkTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private CSSPWebToolsDBContext db { get; set; }
        private TVItemLink tVItemLink { get; set; }
        #endregion Properties

        #region Constructors
        public TVItemLinkTest()
        {
            db = new CSSPWebToolsDBContext(DatabaseTypeEnum.MemoryNoDBShape);
            tVItemLink = new TVItemLink();
        }
        #endregion Constructors

        #region Tests
        // most of the tests are located under TVItemLinkTestGenerated.cs
        #endregion Tests
    }
}
