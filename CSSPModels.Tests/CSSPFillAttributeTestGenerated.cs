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
    public partial class CSSPFillAttributeTest : SetupData
    {
        [TestMethod]
        public void CSSPFillAttribute_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "FillTypeName", "FillPlurial", "FillFieldID", "FillEqualField", "FillReturnField", "ErrorMessage", "ErrorMessageResourceName", "ErrorMessageResourceType",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(CSSPModels.CSSPFillAttribute).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(CSSPFillAttribute).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void CSSPFillAttribute_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() { "RequiresValidationContext", "TypeId",  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(CSSPFillAttribute).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(CSSPFillAttribute).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void CSSPFillAttribute_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(CSSPFillAttribute).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void CSSPFillAttribute_Every_Property_Has_A_Resource_OK()
        {
               Assert.IsNotNull(ModelsRes.CSSPFillAttributeFillTypeName);
               Assert.IsNotNull(ModelsRes.CSSPFillAttributeFillPlurial);
               Assert.IsNotNull(ModelsRes.CSSPFillAttributeFillFieldID);
               Assert.IsNotNull(ModelsRes.CSSPFillAttributeFillEqualField);
               Assert.IsNotNull(ModelsRes.CSSPFillAttributeFillReturnField);
               Assert.IsNotNull(ModelsRes.CSSPFillAttributeRequiresValidationContext);
               Assert.IsNotNull(ModelsRes.CSSPFillAttributeErrorMessage);
               Assert.IsNotNull(ModelsRes.CSSPFillAttributeErrorMessageResourceName);
               Assert.IsNotNull(ModelsRes.CSSPFillAttributeErrorMessageResourceType);
               Assert.IsNotNull(ModelsRes.CSSPFillAttributeTypeId);
        }
        [TestMethod]
        public void CSSPFillAttribute_Every_Property_Has_Get_Set_Test()
        {
               string val1 = "Some text";
               cSSPFillAttribute.FillTypeName = val1;
               Assert.AreEqual(val1, cSSPFillAttribute.FillTypeName);
               string val2 = "Some text";
               cSSPFillAttribute.FillPlurial = val2;
               Assert.AreEqual(val2, cSSPFillAttribute.FillPlurial);
               string val3 = "Some text";
               cSSPFillAttribute.FillFieldID = val3;
               Assert.AreEqual(val3, cSSPFillAttribute.FillFieldID);
               string val4 = "Some text";
               cSSPFillAttribute.FillEqualField = val4;
               Assert.AreEqual(val4, cSSPFillAttribute.FillEqualField);
               string val5 = "Some text";
               cSSPFillAttribute.FillReturnField = val5;
               Assert.AreEqual(val5, cSSPFillAttribute.FillReturnField);
               string val7 = "Some text";
               cSSPFillAttribute.ErrorMessage = val7;
               Assert.AreEqual(val7, cSSPFillAttribute.ErrorMessage);
               string val8 = "Some text";
               cSSPFillAttribute.ErrorMessageResourceName = val8;
               Assert.AreEqual(val8, cSSPFillAttribute.ErrorMessageResourceName);
                TypeNotImplemented___CSSPModels.CSSPFillAttribute____ErrorMessageResourceType___Type
               cSSPFillAttribute.ErrorMessageResourceType = val9;
               Assert.AreEqual(val9, cSSPFillAttribute.ErrorMessageResourceType);
               Boolean val16 = new Boolean();
               cSSPFillAttribute.RequiresValidationContext = val16;
               Assert.AreEqual(val16, cSSPFillAttribute.RequiresValidationContext);
               Object val20 = new Object();
               cSSPFillAttribute.TypeId = val20;
               Assert.AreEqual(val20, cSSPFillAttribute.TypeId);
        }
    }
}
