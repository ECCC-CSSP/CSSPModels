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
    public partial class PolSourceInactiveReasonEnumTextAndIDTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private CSSPWebToolsDBContext db { get; set; }
        private PolSourceInactiveReasonEnumTextAndID polSourceInactiveReasonEnumTextAndID { get; set; }
        #endregion Properties

        #region Constructors
        public PolSourceInactiveReasonEnumTextAndIDTest()
        {
            db = new CSSPWebToolsDBContext(DatabaseTypeEnum.MemoryTestDB);
            polSourceInactiveReasonEnumTextAndID = new PolSourceInactiveReasonEnumTextAndID();
        }
        #endregion Constructors

        #region Tests
        // most of the tests are located under PolSourceInactiveReasonEnumTextAndIDTestGenerated.cs
        #endregion Tests
    }
}
