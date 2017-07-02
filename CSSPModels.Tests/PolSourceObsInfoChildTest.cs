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
    public partial class PolSourceObsInfoChildTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private CSSPWebToolsDBContext db { get; set; }
        private PolSourceObsInfoChild polSourceObsInfoChild { get; set; }
        #endregion Properties

        #region Constructors
        public PolSourceObsInfoChildTest()
        {
            db = new CSSPWebToolsDBContext(DatabaseTypeEnum.MemoryNoDBShape);
            polSourceObsInfoChild = new PolSourceObsInfoChild();
        }
        #endregion Constructors

        #region Tests
        // most of the tests are located under PolSourceObsInfoChildTestGenerated.cs
        #endregion Tests
    }
}
