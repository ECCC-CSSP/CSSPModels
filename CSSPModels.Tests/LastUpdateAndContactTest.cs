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
    public partial class LastUpdateAndContactTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private CSSPWebToolsDBContext db { get; set; }
        private LastUpdateAndContact lastUpdateAndContact { get; set; }
        #endregion Properties

        #region Constructors
        public LastUpdateAndContactTest()
        {
            db = new CSSPWebToolsDBContext(DatabaseTypeEnum.MemoryNoDBShape);
            lastUpdateAndContact = new LastUpdateAndContact();
        }
        #endregion Constructors

        #region Tests
        // most of the tests are located under LastUpdateAndContactTestGenerated.cs
        #endregion Tests
    }
}
