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
    public partial class DocTemplateTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private CSSPWebToolsDBContext db { get; set; }
        private DocTemplate docTemplate { get; set; }
        #endregion Properties

        #region Constructors
        public DocTemplateTest()
        {
            db = new CSSPWebToolsDBContext(DatabaseTypeEnum.MemoryTestDB);
            docTemplate = new DocTemplate();
        }
        #endregion Constructors

        #region Tests
        // most of the tests are located under DocTemplateTestGenerated.cs
        #endregion Tests
    }
}
