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
    public partial class TVItemInfrastructureTypeTVItemLinkTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private CSSPWebToolsDBContext db { get; set; }
        private TVItemInfrastructureTypeTVItemLink tVItemInfrastructureTypeTVItemLink { get; set; }
        #endregion Properties

        #region Constructors
        public TVItemInfrastructureTypeTVItemLinkTest()
        {
            db = new CSSPWebToolsDBContext(DatabaseTypeEnum.MemoryNoDBShape);
            tVItemInfrastructureTypeTVItemLink = new TVItemInfrastructureTypeTVItemLink();
        }
        #endregion Constructors

        #region Tests
        // most of the tests are located under TVItemInfrastructureTypeTVItemLinkTestGenerated.cs
        #endregion Tests
    }
}
