/*
 * Auto generated from the CSSPModelsGenerateCode.proj
 *
 * Do not edit this file.
 *
 * Last generated by Charles LeBlanc
 *
 */ 
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Globalization;
using System.Transactions;
using System.Collections.Generic;
using CSSPModels.Resources;
using Microsoft.EntityFrameworkCore.Metadata;
using System.Reflection;
using CSSPEnums;
using System.ComponentModel.DataAnnotations;

namespace CSSPModels.Tests
{
    [TestClass]
    public partial class CSSPDisplayENAttributeTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private CSSPDisplayENAttribute cSSPDisplayENAttribute { get; set; }
        #endregion Properties

        #region Constructors
        public CSSPDisplayENAttributeTest()
        {
            cSSPDisplayENAttribute = new CSSPDisplayENAttribute();
        }
        #endregion Constructors

        #region Tests
        [TestMethod]
        public void CSSPDisplayENAttribute_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "DisplayENText", "ErrorMessage", "ErrorMessageResourceName", "ErrorMessageResourceType",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(CSSPModels.CSSPDisplayENAttribute).GetProperties().OrderBy(c => c.Name))
            {
                if (!propertyInfo.GetGetMethod().IsVirtual
                    && propertyInfo.Name != "ValidationResults"
                    && !propertyInfo.CustomAttributes.Where(c => c.AttributeType.Name.Contains("NotMappedAttribute")).Any())
                {
                    Assert.AreEqual(propNameList[index], propertyInfo.Name);
                    index += 1;
                }
            }

            Assert.AreEqual(propNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(CSSPDisplayENAttribute).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
            {
                foreach (CustomAttributeData customAttributeData in propertyInfo.CustomAttributes)
                {
                    if (customAttributeData.AttributeType.Name == "NotMappedAttribute")
                    {
                        Assert.AreEqual(propertyInfo.Name, propNameNotMappedList[index]);
                        index += 1;
                    }
                }
            }

            Assert.AreEqual(propNameNotMappedList.Count, index);

        }
        [TestMethod]
        public void CSSPDisplayENAttribute_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() { "RequiresValidationContext", "TypeId",  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(CSSPDisplayENAttribute).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(CSSPDisplayENAttribute).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
            {
                if (propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameCollectionList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameCollectionList.Count, index);

        }
        [TestMethod]
        public void CSSPDisplayENAttribute_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(CSSPDisplayENAttribute).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void CSSPDisplayENAttribute_Every_Property_Has_A_Resource_OK()
        {
               Assert.IsNotNull(CSSPModelsRes.CSSPDisplayENAttributeDisplayENText);
               Assert.IsNotNull(CSSPModelsRes.CSSPDisplayENAttributeRequiresValidationContext);
               Assert.IsNotNull(CSSPModelsRes.CSSPDisplayENAttributeErrorMessage);
               Assert.IsNotNull(CSSPModelsRes.CSSPDisplayENAttributeErrorMessageResourceName);
               Assert.IsNotNull(CSSPModelsRes.CSSPDisplayENAttributeErrorMessageResourceType);
               Assert.IsNotNull(CSSPModelsRes.CSSPDisplayENAttributeTypeId);
        }
        [TestMethod]
        public void CSSPDisplayENAttribute_Every_Property_Has_Get_Set_Test()
        {
               string val1 = "Some text";
               cSSPDisplayENAttribute.DisplayENText = val1;
               Assert.AreEqual(val1, cSSPDisplayENAttribute.DisplayENText);
               string val3 = "Some text";
               cSSPDisplayENAttribute.ErrorMessage = val3;
               Assert.AreEqual(val3, cSSPDisplayENAttribute.ErrorMessage);
               string val4 = "Some text";
               cSSPDisplayENAttribute.ErrorMessageResourceName = val4;
               Assert.AreEqual(val4, cSSPDisplayENAttribute.ErrorMessageResourceName);
                TypeNotImplemented___CSSPModels.CSSPDisplayENAttribute____ErrorMessageResourceType___Type
               cSSPDisplayENAttribute.ErrorMessageResourceType = val5;
               Assert.AreEqual(val5, cSSPDisplayENAttribute.ErrorMessageResourceType);
               Boolean val8 = new Boolean();
               cSSPDisplayENAttribute.RequiresValidationContext = val8;
               Assert.AreEqual(val8, cSSPDisplayENAttribute.RequiresValidationContext);
               Object val12 = new Object();
               cSSPDisplayENAttribute.TypeId = val12;
               Assert.AreEqual(val12, cSSPDisplayENAttribute.TypeId);
        }
        #endregion Tests
    }
}