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
    public partial class AppTaskParameterTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private CSSPWebToolsDBContext db { get; set; }
        private AppTaskParameter appTaskParameter { get; set; }
        #endregion Properties

        #region Constructors
        public AppTaskParameterTest()
        {
            db = new CSSPWebToolsDBContext(DatabaseTypeEnum.MemoryTestDB);
            appTaskParameter = new AppTaskParameter();
        }
        #endregion Constructors

        #region Tests
        // most of the tests are located under AppTaskParameterTestGenerated.cs
        #endregion Tests
    }
}
