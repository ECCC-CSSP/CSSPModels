using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Globalization;
using System.Transactions;
using System.Collections.Generic;
using CSSPModels.Resources;
using Microsoft.EntityFrameworkCore.Metadata;
using System.Reflection;

namespace CSSPModels.Tests
{
    public partial class SpillTest
    {
        [TestMethod]
        public void Spill_Properties_OK()
        {
            List<string> propNameList = new List<string>() { "SpillID", "MunicipalityTVItemID", "InfrastructureTVItemID", "StartDateTime_Local", "EndDateTime_Local", "AverageFlow_m3_day", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(CSSPModels.Spill).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(Spill).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void Spill_Navigation_OK()
        {
            List<string> foreignNameList = new List<string>() { "InfrastructureTVItem", "MunicipalityTVItem",  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() { "SpillLanguages",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(Spill).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(Spill).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void Spill_Has_ValidationResults_OK()
        {
             Assert.IsTrue(typeof(Spill).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void Spill_Every_Property_Has_A_Resource_OK()
        {
               Assert.IsNotNull(ModelsRes.SpillSpillID);
               Assert.IsNotNull(ModelsRes.SpillMunicipalityTVItemID);
               Assert.IsNotNull(ModelsRes.SpillInfrastructureTVItemID);
               Assert.IsNotNull(ModelsRes.SpillStartDateTime_Local);
               Assert.IsNotNull(ModelsRes.SpillEndDateTime_Local);
               Assert.IsNotNull(ModelsRes.SpillAverageFlow_m3_day);
               Assert.IsNotNull(ModelsRes.SpillLastUpdateDate_UTC);
               Assert.IsNotNull(ModelsRes.SpillLastUpdateContactTVItemID);
               Assert.IsNotNull(ModelsRes.SpillSpillLanguages);
               Assert.IsNotNull(ModelsRes.SpillInfrastructureTVItem);
               Assert.IsNotNull(ModelsRes.SpillMunicipalityTVItem);
        }
    }
}
