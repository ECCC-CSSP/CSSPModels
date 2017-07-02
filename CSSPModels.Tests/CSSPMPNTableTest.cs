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
    public partial class CSSPMPNTableTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private CSSPWebToolsDBContext db { get; set; }
        private CSSPMPNTable cSSPMPNTable { get; set; }
        #endregion Properties

        #region Constructors
        public CSSPMPNTableTest()
        {
            db = new CSSPWebToolsDBContext(DatabaseTypeEnum.MemoryNoDBShape);
            cSSPMPNTable = new CSSPMPNTable();
        }
        #endregion Constructors

        #region Tests
        // most of the tests are located under CSSPMPNTableTestGenerated.cs
        #endregion Tests
    }
}
