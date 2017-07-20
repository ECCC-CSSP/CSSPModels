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
    public partial class InfrastructureLanguageTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private CSSPWebToolsDBContext db { get; set; }
        private InfrastructureLanguage infrastructureLanguage { get; set; }
        #endregion Properties

        #region Constructors
        public InfrastructureLanguageTest()
        {
            db = new CSSPWebToolsDBContext(DatabaseTypeEnum.MemoryTestDB);
            infrastructureLanguage = new InfrastructureLanguage();
        }
        #endregion Constructors

        #region Tests
        // most of the tests are located under InfrastructureLanguageTestGenerated.cs
        #endregion Tests
    }
}
