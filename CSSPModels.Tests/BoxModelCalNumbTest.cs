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
    public partial class BoxModelCalNumbTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private CSSPWebToolsDBContext db { get; set; }
        private BoxModelCalNumb boxModelCalNumb { get; set; }
        #endregion Properties

        #region Constructors
        public BoxModelCalNumbTest()
        {
            db = new CSSPWebToolsDBContext(DatabaseTypeEnum.MemoryNoDBShape);
            boxModelCalNumb = new BoxModelCalNumb();
        }
        #endregion Constructors

        #region Tests
        // most of the tests are located under BoxModelCalNumbTestGenerated.cs
        #endregion Tests
    }
}
