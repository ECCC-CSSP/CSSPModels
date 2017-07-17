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
    public partial class EmailDistributionListContactTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private CSSPWebToolsDBContext db { get; set; }
        private EmailDistributionListContact emailDistributionListContact { get; set; }
        #endregion Properties

        #region Constructors
        public EmailDistributionListContactTest()
        {
            db = new CSSPWebToolsDBContext(DatabaseTypeEnum.MemoryNoDBShape);
            emailDistributionListContact = new EmailDistributionListContact();
        }
        #endregion Constructors

        #region Tests
        // most of the tests are located under EmailDistributionListContactTestGenerated.cs
        #endregion Tests
    }
}
