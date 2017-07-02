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
    public partial class PolSourceObsInfoEnumTextAndIDTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private CSSPWebToolsDBContext db { get; set; }
        private PolSourceObsInfoEnumTextAndID polSourceObsInfoEnumTextAndID { get; set; }
        #endregion Properties

        #region Constructors
        public PolSourceObsInfoEnumTextAndIDTest()
        {
            db = new CSSPWebToolsDBContext(DatabaseTypeEnum.MemoryNoDBShape);
            polSourceObsInfoEnumTextAndID = new PolSourceObsInfoEnumTextAndID();
        }
        #endregion Constructors

        #region Tests
        // most of the tests are located under PolSourceObsInfoEnumTextAndIDTestGenerated.cs
        #endregion Tests
    }
}
