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
    public partial class MikeSourceTest : SetupData
    {
        [TestMethod]
        public void MikeSource_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "MikeSourceID", "MikeSourceTVItemID", "IsContinuous", "Include", "IsRiver", "SourceNumberString", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(CSSPModels.MikeSource).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(MikeSource).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void MikeSource_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(MikeSource).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(MikeSource).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void MikeSource_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(MikeSource).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void MikeSource_Every_Property_Has_A_Resource_OK()
        {
               Assert.IsNotNull(ModelsRes.MikeSourceMikeSourceID);
               Assert.IsNotNull(ModelsRes.MikeSourceMikeSourceTVItemID);
               Assert.IsNotNull(ModelsRes.MikeSourceIsContinuous);
               Assert.IsNotNull(ModelsRes.MikeSourceInclude);
               Assert.IsNotNull(ModelsRes.MikeSourceIsRiver);
               Assert.IsNotNull(ModelsRes.MikeSourceSourceNumberString);
               Assert.IsNotNull(ModelsRes.MikeSourceLastUpdateDate_UTC);
               Assert.IsNotNull(ModelsRes.MikeSourceLastUpdateContactTVItemID);
        }
        [TestMethod]
        public void MikeSource_Every_Property_Has_Get_Set_Test()
        {
               int val1 = 45;
               mikeSource.MikeSourceID = val1;
               Assert.AreEqual(val1, mikeSource.MikeSourceID);
               int val2 = 45;
               mikeSource.MikeSourceTVItemID = val2;
               Assert.AreEqual(val2, mikeSource.MikeSourceTVItemID);
               bool val3 = true;
               mikeSource.IsContinuous = val3;
               Assert.AreEqual(val3, mikeSource.IsContinuous);
               bool val4 = true;
               mikeSource.Include = val4;
               Assert.AreEqual(val4, mikeSource.Include);
               bool val5 = true;
               mikeSource.IsRiver = val5;
               Assert.AreEqual(val5, mikeSource.IsRiver);
               string val6 = "Some text";
               mikeSource.SourceNumberString = val6;
               Assert.AreEqual(val6, mikeSource.SourceNumberString);
               DateTime val7 = new DateTime(2010, 3, 4);
               mikeSource.LastUpdateDate_UTC = val7;
               Assert.AreEqual(val7, mikeSource.LastUpdateDate_UTC);
               int val8 = 45;
               mikeSource.LastUpdateContactTVItemID = val8;
               Assert.AreEqual(val8, mikeSource.LastUpdateContactTVItemID);
               IEnumerable<ValidationResult> val27 = new List<ValidationResult>().AsEnumerable();
               mikeSource.ValidationResults = val27;
               Assert.AreEqual(val27, mikeSource.ValidationResults);
        }
    }
}
