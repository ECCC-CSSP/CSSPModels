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
    public partial class AppTaskTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private CSSPWebToolsDBContext db { get; set; }
        private AppTask appTask { get; set; }
        #endregion Properties

        #region Constructors
        public AppTaskTest()
        {
            db = new CSSPWebToolsDBContext(DatabaseTypeEnum.MemoryTestDB);
            appTask = new AppTask();
        }
        #endregion Constructors

        #region Tests
        // most of the tests are located under AppTaskTestGenerated.cs
        #endregion Tests
    }
}
