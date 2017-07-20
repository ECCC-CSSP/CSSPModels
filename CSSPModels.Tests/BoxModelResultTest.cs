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
    public partial class BoxModelResultTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private CSSPWebToolsDBContext db { get; set; }
        private BoxModelResult boxModelResult { get; set; }
        #endregion Properties

        #region Constructors
        public BoxModelResultTest()
        {
            db = new CSSPWebToolsDBContext(DatabaseTypeEnum.MemoryTestDB);
            boxModelResult = new BoxModelResult();
        }
        #endregion Constructors

        #region Tests
        // most of the tests are located under BoxModelResultTestGenerated.cs
        #endregion Tests
    }
}
