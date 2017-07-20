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
    public partial class ResetPasswordTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private CSSPWebToolsDBContext db { get; set; }
        private ResetPassword resetPassword { get; set; }
        #endregion Properties

        #region Constructors
        public ResetPasswordTest()
        {
            db = new CSSPWebToolsDBContext(DatabaseTypeEnum.MemoryTestDB);
            resetPassword = new ResetPassword();
        }
        #endregion Constructors

        #region Tests
        // most of the tests are located under ResetPasswordTestGenerated.cs
        #endregion Tests
    }
}
