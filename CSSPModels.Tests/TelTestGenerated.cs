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
    public partial class TelTest : SetupData
    {
        [TestMethod]
        public void Tel_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "TelID", "TelTVItemID", "TelNumber", "TelType", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "TelTVText", "LastUpdateContactTVText", "TelTypeText", "HasErrors",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(CSSPModels.Tel).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(Tel).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void Tel_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(Tel).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(Tel).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void Tel_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(Tel).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void Tel_Every_Property_Has_A_Resource_OK()
        {
               Assert.IsNotNull(ModelsRes.TelTelID);
               Assert.IsNotNull(ModelsRes.TelTelTVItemID);
               Assert.IsNotNull(ModelsRes.TelTelNumber);
               Assert.IsNotNull(ModelsRes.TelTelType);
               Assert.IsNotNull(ModelsRes.TelLastUpdateDate_UTC);
               Assert.IsNotNull(ModelsRes.TelLastUpdateContactTVItemID);
               Assert.IsNotNull(ModelsRes.TelTelTVText);
               Assert.IsNotNull(ModelsRes.TelLastUpdateContactTVText);
               Assert.IsNotNull(ModelsRes.TelTelTypeText);
               Assert.IsNotNull(ModelsRes.TelHasErrors);
        }
        [TestMethod]
        public void Tel_Every_Property_Has_Get_Set_Test()
        {
               int val1 = 45;
               tel.TelID = val1;
               Assert.AreEqual(val1, tel.TelID);
               int val2 = 45;
               tel.TelTVItemID = val2;
               Assert.AreEqual(val2, tel.TelTVItemID);
               string val3 = "Some text";
               tel.TelNumber = val3;
               Assert.AreEqual(val3, tel.TelNumber);
               TelTypeEnum val4 = (TelTypeEnum)3;
               tel.TelType = val4;
               Assert.AreEqual(val4, tel.TelType);
               DateTime val5 = new DateTime(2010, 3, 4);
               tel.LastUpdateDate_UTC = val5;
               Assert.AreEqual(val5, tel.LastUpdateDate_UTC);
               int val6 = 45;
               tel.LastUpdateContactTVItemID = val6;
               Assert.AreEqual(val6, tel.LastUpdateContactTVItemID);
               string val7 = "Some text";
               tel.TelTVText = val7;
               Assert.AreEqual(val7, tel.TelTVText);
               string val8 = "Some text";
               tel.LastUpdateContactTVText = val8;
               Assert.AreEqual(val8, tel.LastUpdateContactTVText);
               string val9 = "Some text";
               tel.TelTypeText = val9;
               Assert.AreEqual(val9, tel.TelTypeText);
               bool val10 = true;
               tel.HasErrors = val10;
               Assert.AreEqual(val10, tel.HasErrors);
               IEnumerable<ValidationResult> val33 = new List<ValidationResult>().AsEnumerable();
               tel.ValidationResults = val33;
               Assert.AreEqual(val33, tel.ValidationResults);
        }
    }
}
