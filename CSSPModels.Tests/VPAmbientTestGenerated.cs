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
    public partial class VPAmbientTest
    {
        [TestMethod]
        public void VPAmbient_Properties_OK()
        {
            List<string> propNameList = new List<string>() { "VPAmbientID", "VPScenarioID", "Row", "MeasurementDepth_m", "CurrentSpeed_m_s", "CurrentDirection_deg", "AmbientSalinity_PSU", "AmbientTemperature_C", "BackgroundConcentration_MPN_100ml", "PollutantDecayRate_per_day", "FarFieldCurrentSpeed_m_s", "FarFieldCurrentDirection_deg", "FarFieldDiffusionCoefficient", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(CSSPModels.VPAmbient).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(VPAmbient).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void VPAmbient_Navigation_OK()
        {
            List<string> foreignNameList = new List<string>() { "VPScenario",  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(VPAmbient).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(VPAmbient).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void VPAmbient_Has_ValidationResults_OK()
        {
             Assert.IsTrue(typeof(VPAmbient).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void VPAmbient_Every_Property_Has_A_Resource_OK()
        {
               Assert.IsNotNull(ModelsRes.VPAmbientVPAmbientID);
               Assert.IsNotNull(ModelsRes.VPAmbientVPScenarioID);
               Assert.IsNotNull(ModelsRes.VPAmbientRow);
               Assert.IsNotNull(ModelsRes.VPAmbientMeasurementDepth_m);
               Assert.IsNotNull(ModelsRes.VPAmbientCurrentSpeed_m_s);
               Assert.IsNotNull(ModelsRes.VPAmbientCurrentDirection_deg);
               Assert.IsNotNull(ModelsRes.VPAmbientAmbientSalinity_PSU);
               Assert.IsNotNull(ModelsRes.VPAmbientAmbientTemperature_C);
               Assert.IsNotNull(ModelsRes.VPAmbientBackgroundConcentration_MPN_100ml);
               Assert.IsNotNull(ModelsRes.VPAmbientPollutantDecayRate_per_day);
               Assert.IsNotNull(ModelsRes.VPAmbientFarFieldCurrentSpeed_m_s);
               Assert.IsNotNull(ModelsRes.VPAmbientFarFieldCurrentDirection_deg);
               Assert.IsNotNull(ModelsRes.VPAmbientFarFieldDiffusionCoefficient);
               Assert.IsNotNull(ModelsRes.VPAmbientLastUpdateDate_UTC);
               Assert.IsNotNull(ModelsRes.VPAmbientLastUpdateContactTVItemID);
               Assert.IsNotNull(ModelsRes.VPAmbientVPScenario);
        }
    }
}
