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
    public partial class VPAmbientTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private CSSPWebToolsDBContext db { get; set; }
        private VPAmbient vPAmbient { get; set; }
        #endregion Properties

        #region Constructors
        public VPAmbientTest()
        {
            db = new CSSPWebToolsDBContext(DatabaseTypeEnum.MemoryTestDB);
            vPAmbient = new VPAmbient();
        }
        #endregion Constructors

        #region Tests
        // most of the tests are located under VPAmbientTestGenerated.cs
        #endregion Tests
    }
}
