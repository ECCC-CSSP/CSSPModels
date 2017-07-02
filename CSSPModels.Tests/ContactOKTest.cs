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
    public partial class ContactOKTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private CSSPWebToolsDBContext db { get; set; }
        private ContactOK contactOK { get; set; }
        #endregion Properties

        #region Constructors
        public ContactOKTest()
        {
            db = new CSSPWebToolsDBContext(DatabaseTypeEnum.MemoryNoDBShape);
            contactOK = new ContactOK();
        }
        #endregion Constructors

        #region Tests
        // most of the tests are located under ContactOKTestGenerated.cs
        #endregion Tests
    }
}
