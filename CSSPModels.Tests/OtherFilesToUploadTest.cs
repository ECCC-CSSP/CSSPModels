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
    public partial class OtherFilesToUploadTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private CSSPWebToolsDBContext db { get; set; }
        private OtherFilesToUpload otherFilesToUpload { get; set; }
        #endregion Properties

        #region Constructors
        public OtherFilesToUploadTest()
        {
            db = new CSSPWebToolsDBContext(DatabaseTypeEnum.MemoryTestDB);
            otherFilesToUpload = new OtherFilesToUpload();
        }
        #endregion Constructors

        #region Tests
        // most of the tests are located under OtherFilesToUploadTestGenerated.cs
        #endregion Tests
    }
}
