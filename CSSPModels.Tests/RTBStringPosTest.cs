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
    public partial class RTBStringPosTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private CSSPWebToolsDBContext db { get; set; }
        private RTBStringPos rTBStringPos { get; set; }
        #endregion Properties

        #region Constructors
        public RTBStringPosTest()
        {
            db = new CSSPWebToolsDBContext(DatabaseTypeEnum.MemoryTestDB);
            rTBStringPos = new RTBStringPos();
        }
        #endregion Constructors

        #region Tests
        // most of the tests are located under RTBStringPosTestGenerated.cs
        #endregion Tests
    }
}
