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
    public partial class TVItemStatTest : SetupData
    {
        [TestMethod]
        public void TVItemStat_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "TVItemStatID", "TVItemID", "TVType", "ChildCount", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "TVText", "LastUpdateContactTVText", "TVTypeText", "HasErrors",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(CSSPModels.TVItemStat).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(TVItemStat).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void TVItemStat_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(TVItemStat).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(TVItemStat).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void TVItemStat_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(TVItemStat).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void TVItemStat_Every_Property_Has_A_Resource_OK()
        {
               Assert.IsNotNull(ModelsRes.TVItemStatTVItemStatID);
               Assert.IsNotNull(ModelsRes.TVItemStatTVItemID);
               Assert.IsNotNull(ModelsRes.TVItemStatTVType);
               Assert.IsNotNull(ModelsRes.TVItemStatChildCount);
               Assert.IsNotNull(ModelsRes.TVItemStatLastUpdateDate_UTC);
               Assert.IsNotNull(ModelsRes.TVItemStatLastUpdateContactTVItemID);
               Assert.IsNotNull(ModelsRes.TVItemStatTVText);
               Assert.IsNotNull(ModelsRes.TVItemStatLastUpdateContactTVText);
               Assert.IsNotNull(ModelsRes.TVItemStatTVTypeText);
               Assert.IsNotNull(ModelsRes.TVItemStatHasErrors);
        }
        [TestMethod]
        public void TVItemStat_Every_Property_Has_Get_Set_Test()
        {
               int val1 = 45;
               tVItemStat.TVItemStatID = val1;
               Assert.AreEqual(val1, tVItemStat.TVItemStatID);
               int val2 = 45;
               tVItemStat.TVItemID = val2;
               Assert.AreEqual(val2, tVItemStat.TVItemID);
               TVTypeEnum val3 = (TVTypeEnum)3;
               tVItemStat.TVType = val3;
               Assert.AreEqual(val3, tVItemStat.TVType);
               int val4 = 45;
               tVItemStat.ChildCount = val4;
               Assert.AreEqual(val4, tVItemStat.ChildCount);
               DateTime val5 = new DateTime(2010, 3, 4);
               tVItemStat.LastUpdateDate_UTC = val5;
               Assert.AreEqual(val5, tVItemStat.LastUpdateDate_UTC);
               int val6 = 45;
               tVItemStat.LastUpdateContactTVItemID = val6;
               Assert.AreEqual(val6, tVItemStat.LastUpdateContactTVItemID);
               string val7 = "Some text";
               tVItemStat.TVText = val7;
               Assert.AreEqual(val7, tVItemStat.TVText);
               string val8 = "Some text";
               tVItemStat.LastUpdateContactTVText = val8;
               Assert.AreEqual(val8, tVItemStat.LastUpdateContactTVText);
               string val9 = "Some text";
               tVItemStat.TVTypeText = val9;
               Assert.AreEqual(val9, tVItemStat.TVTypeText);
               bool val10 = true;
               tVItemStat.HasErrors = val10;
               Assert.AreEqual(val10, tVItemStat.HasErrors);
               IEnumerable<ValidationResult> val33 = new List<ValidationResult>().AsEnumerable();
               tVItemStat.ValidationResults = val33;
               Assert.AreEqual(val33, tVItemStat.ValidationResults);
        }
    }
}
