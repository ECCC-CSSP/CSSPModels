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
    public partial class ContactPreferenceTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private CSSPWebToolsDBContext db { get; set; }
        private ContactPreference contactPreference { get; set; }
        #endregion Properties

        #region Constructors
        public ContactPreferenceTest()
        {
            db = new CSSPWebToolsDBContext(DatabaseTypeEnum.MemoryTestDB);
            contactPreference = new ContactPreference();
        }
        #endregion Constructors

        #region Tests
        // most of the tests are located under ContactPreferenceTestGenerated.cs
        #endregion Tests
    }
}
