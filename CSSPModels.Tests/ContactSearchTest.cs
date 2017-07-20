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
    public partial class ContactSearchTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private CSSPWebToolsDBContext db { get; set; }
        private ContactSearch contactSearch { get; set; }
        #endregion Properties

        #region Constructors
        public ContactSearchTest()
        {
            db = new CSSPWebToolsDBContext(DatabaseTypeEnum.MemoryTestDB);
            contactSearch = new ContactSearch();
        }
        #endregion Constructors

        #region Tests
        // most of the tests are located under ContactSearchTestGenerated.cs
        #endregion Tests
    }
}
