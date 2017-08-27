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
    public partial class EmailDistributionListContactLanguageTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private CSSPWebToolsDBContext db { get; set; }
        private EmailDistributionListContactLanguage emailDistributionListContactLanguage { get; set; }
        #endregion Properties

        #region Constructors
        public EmailDistributionListContactLanguageTest()
        {
            db = new CSSPWebToolsDBContext(DatabaseTypeEnum.MemoryTestDB);
            emailDistributionListContactLanguage = new EmailDistributionListContactLanguage();
        }
        #endregion Constructors

        #region Tests
        // most of the tests are located under EmailDistributionListContactLanguageTestGenerated.cs
        #endregion Tests
    }
}
