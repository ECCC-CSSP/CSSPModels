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
    public partial class MWQMLookupMPNTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private CSSPWebToolsDBContext db { get; set; }
        private MWQMLookupMPN mWQMLookupMPN { get; set; }
        #endregion Properties

        #region Constructors
        public MWQMLookupMPNTest()
        {
            db = new CSSPWebToolsDBContext(DatabaseTypeEnum.MemoryNoDBShape);
            mWQMLookupMPN = new MWQMLookupMPN();
        }
        #endregion Constructors

        #region Tests
        // most of the tests are located under MWQMLookupMPNTestGenerated.cs
        #endregion Tests
    }
}
