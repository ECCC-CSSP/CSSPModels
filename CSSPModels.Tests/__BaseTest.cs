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
    public partial class __BaseTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        #endregion Properties

        #region Constructors
        public __BaseTest()
        {
        }
        #endregion Constructors

        #region Tests
        [TestMethod]
        public void __Base_Test()
        {
            CSSPAfterAttribute csspAfterAttribute = new CSSPAfterAttribute();
            csspAfterAttribute.Year = 34;
            Assert.AreEqual(34, csspAfterAttribute.Year);
            bool retBool = csspAfterAttribute.IsValid(new object());
            Assert.AreEqual(true, retBool);

            CSSPAllowNullAttribute csspAllowNullAttribute = new CSSPAllowNullAttribute();
            retBool = csspAllowNullAttribute.IsValid(new object());
            Assert.AreEqual(true, retBool);

            CSSPBiggerAttribute csspBiggerAttribute = new CSSPBiggerAttribute();
            csspBiggerAttribute.OtherField = "Something";
            Assert.AreEqual("Something", csspBiggerAttribute.OtherField);
            retBool = csspBiggerAttribute.IsValid(new object());
            Assert.AreEqual(true, retBool);

            CSSPEnumTypeAttribute csspEnumTypeAttribute = new CSSPEnumTypeAttribute();
            retBool = csspEnumTypeAttribute.IsValid(new object());
            Assert.AreEqual(true, retBool);

            CSSPExistAttribute csspExistAttribute = new CSSPExistAttribute();
            csspExistAttribute.TypeName = "Something";
            Assert.AreEqual("Something", csspExistAttribute.TypeName);
            csspExistAttribute.Plurial = "s";
            Assert.AreEqual("s", csspExistAttribute.Plurial);
            csspExistAttribute.FieldID = "Something";
            Assert.AreEqual("Something", csspExistAttribute.FieldID);
            csspExistAttribute.TVType = TVTypeEnum.Address;
            Assert.AreEqual(TVTypeEnum.Address, csspExistAttribute.TVType);
            csspExistAttribute.OrTVType = TVTypeEnum.Area;
            Assert.AreEqual(TVTypeEnum.Area, csspExistAttribute.OrTVType);
            retBool = csspExistAttribute.IsValid(new object());
            Assert.AreEqual(true, retBool);

        }
        #endregion Tests
    }
}
