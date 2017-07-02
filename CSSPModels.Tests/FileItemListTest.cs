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
    public partial class FileItemListTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private CSSPWebToolsDBContext db { get; set; }
        private FileItemList fileItemList { get; set; }
        #endregion Properties

        #region Constructors
        public FileItemListTest()
        {
            db = new CSSPWebToolsDBContext(DatabaseTypeEnum.MemoryNoDBShape);
            fileItemList = new FileItemList();
        }
        #endregion Constructors

        #region Tests
        // most of the tests are located under FileItemListTestGenerated.cs
        #endregion Tests
    }
}
