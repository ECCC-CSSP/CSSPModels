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
    public partial class ContactLoginTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private CSSPWebToolsDBContext db { get; set; }
        private ContactLogin contactLogin { get; set; }
        #endregion Properties

        #region Constructors
        public ContactLoginTest()
        {
            db = new CSSPWebToolsDBContext(DatabaseTypeEnum.MemoryTestDB);
            contactLogin = new ContactLogin();
        }
        #endregion Constructors

        #region Tests
        // most of the tests are located under ContactLoginTestGenerated.cs
        #endregion Tests
    }
}
