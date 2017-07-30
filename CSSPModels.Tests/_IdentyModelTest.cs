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
    public partial class IdentityModelTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        #endregion Properties

        #region Constructors
        public IdentityModelTest()
        {
        }
        #endregion Constructors

        #region Tests
        [TestMethod]
        public void Address_Properties_Test()
        {
            ApplicationDbContext ApplicationDbContext = new ApplicationDbContext();

            Assert.AreEqual(propNameNotMappedList.Count, index);
        }
        #endregion Tests
    }
}
