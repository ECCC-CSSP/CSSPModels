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
    public partial class MWQMSampleDuplicateItemTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private CSSPWebToolsDBContext db { get; set; }
        private MWQMSampleDuplicateItem mWQMSampleDuplicateItem { get; set; }
        #endregion Properties

        #region Constructors
        public MWQMSampleDuplicateItemTest()
        {
            db = new CSSPWebToolsDBContext(DatabaseTypeEnum.MemoryTestDB);
            mWQMSampleDuplicateItem = new MWQMSampleDuplicateItem();
        }
        #endregion Constructors

        #region Tests
        // most of the tests are located under MWQMSampleDuplicateItemTestGenerated.cs
        #endregion Tests
    }
}
