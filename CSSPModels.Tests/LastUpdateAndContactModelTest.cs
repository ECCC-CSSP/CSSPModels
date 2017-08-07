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
    public partial class LastUpdateAndContactModelTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private CSSPWebToolsDBContext db { get; set; }
        private LastUpdateAndContactModel lastUpdateAndContactModel { get; set; }
        #endregion Properties

        #region Constructors
        public LastUpdateAndContactModelTest()
        {
            db = new CSSPWebToolsDBContext(DatabaseTypeEnum.MemoryTestDB);
            lastUpdateAndContactModel = new LastUpdateAndContactModel();
        }
        #endregion Constructors

        #region Tests
        // most of the tests are located under LastUpdateAndContactModelTestGenerated.cs
        #endregion Tests
    }
}
