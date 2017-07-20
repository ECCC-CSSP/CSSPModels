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
    public partial class LastUpdateAndTVTextTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private CSSPWebToolsDBContext db { get; set; }
        private LastUpdateAndTVText lastUpdateAndTVText { get; set; }
        #endregion Properties

        #region Constructors
        public LastUpdateAndTVTextTest()
        {
            db = new CSSPWebToolsDBContext(DatabaseTypeEnum.MemoryTestDB);
            lastUpdateAndTVText = new LastUpdateAndTVText();
        }
        #endregion Constructors

        #region Tests
        // most of the tests are located under LastUpdateAndTVTextTestGenerated.cs
        #endregion Tests
    }
}
