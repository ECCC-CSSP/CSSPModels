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
    public partial class InfrastructureTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private CSSPWebToolsDBContext db { get; set; }
        private Infrastructure infrastructure { get; set; }
        #endregion Properties

        #region Constructors
        public InfrastructureTest()
        {
            db = new CSSPWebToolsDBContext(DatabaseTypeEnum.MemoryNoDBShape);
            infrastructure = new Infrastructure();
        }
        #endregion Constructors

        #region Tests
        // most of the tests are located under InfrastructureTestGenerated.cs
        #endregion Tests
    }
}
