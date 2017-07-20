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
    public partial class MWQMSampleTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private CSSPWebToolsDBContext db { get; set; }
        private MWQMSample mWQMSample { get; set; }
        #endregion Properties

        #region Constructors
        public MWQMSampleTest()
        {
            db = new CSSPWebToolsDBContext(DatabaseTypeEnum.MemoryTestDB);
            mWQMSample = new MWQMSample();
        }
        #endregion Constructors

        #region Tests
        // most of the tests are located under MWQMSampleTestGenerated.cs
        #endregion Tests
    }
}
