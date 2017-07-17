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
    public partial class BoxModelTest
    {
        [TestMethod]
        public void BoxModel_Properties_OK()
        {
            List<string> propNameList = new List<string>() { "BoxModelID", "InfrastructureTVItemID", "Flow_m3_day", "Depth_m", "Temperature_C", "Dilution", "DecayRate_per_day", "FCUntreated_MPN_100ml", "FCPreDisinfection_MPN_100ml", "Concentration_MPN_100ml", "T90_hour", "FlowDuration_hour", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(CSSPModels.BoxModel).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(BoxModel).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void BoxModel_Navigation_OK()
        {
            List<string> foreignNameList = new List<string>() { "InfrastructureTVItem",  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() { "BoxModelLanguages", "BoxModelResults",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(BoxModel).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(BoxModel).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void BoxModel_Has_ValidationResults_OK()
        {
             Assert.IsTrue(typeof(BoxModel).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void BoxModel_Every_Property_Has_A_Resource_OK()
        {
               Assert.IsNotNull(ModelsRes.BoxModelBoxModelID);
               Assert.IsNotNull(ModelsRes.BoxModelInfrastructureTVItemID);
               Assert.IsNotNull(ModelsRes.BoxModelFlow_m3_day);
               Assert.IsNotNull(ModelsRes.BoxModelDepth_m);
               Assert.IsNotNull(ModelsRes.BoxModelTemperature_C);
               Assert.IsNotNull(ModelsRes.BoxModelDilution);
               Assert.IsNotNull(ModelsRes.BoxModelDecayRate_per_day);
               Assert.IsNotNull(ModelsRes.BoxModelFCUntreated_MPN_100ml);
               Assert.IsNotNull(ModelsRes.BoxModelFCPreDisinfection_MPN_100ml);
               Assert.IsNotNull(ModelsRes.BoxModelConcentration_MPN_100ml);
               Assert.IsNotNull(ModelsRes.BoxModelT90_hour);
               Assert.IsNotNull(ModelsRes.BoxModelFlowDuration_hour);
               Assert.IsNotNull(ModelsRes.BoxModelLastUpdateDate_UTC);
               Assert.IsNotNull(ModelsRes.BoxModelLastUpdateContactTVItemID);
               Assert.IsNotNull(ModelsRes.BoxModelBoxModelLanguages);
               Assert.IsNotNull(ModelsRes.BoxModelBoxModelResults);
               Assert.IsNotNull(ModelsRes.BoxModelInfrastructureTVItem);
        }
    }
}
