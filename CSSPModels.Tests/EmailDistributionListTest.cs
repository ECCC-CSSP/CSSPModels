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
    public partial class EmailDistributionListTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private CSSPWebToolsDBContext db { get; set; }
        private EmailDistributionList emailDistributionList { get; set; }
        #endregion Properties

        #region Constructors
        public EmailDistributionListTest()
        {
            db = new CSSPWebToolsDBContext(DatabaseTypeEnum.MemoryNoDBShape);
            emailDistributionList = new EmailDistributionList();
        }
        #endregion Constructors

        #region Tests
        // most of the tests are located under EmailDistributionListTestGenerated.cs
        #endregion Tests
    }
}
