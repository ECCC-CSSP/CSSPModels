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
    public partial class VPScenarioTest
    {
        [TestMethod]
        public void VPScenario_Properties_OK()
        {
            List<string> propNameList = new List<string>() { "VPScenarioID", "InfrastructureTVItemID", "VPScenarioStatus", "UseAsBestEstimate", "EffluentFlow_m3_s", "EffluentConcentration_MPN_100ml", "FroudeNumber", "PortDiameter_m", "PortDepth_m", "PortElevation_m", "VerticalAngle_deg", "HorizontalAngle_deg", "NumberOfPorts", "PortSpacing_m", "AcuteMixZone_m", "ChronicMixZone_m", "EffluentSalinity_PSU", "EffluentTemperature_C", "EffluentVelocity_m_s", "RawResults", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (IProperty propertyType in entityType.GetProperties().OrderBy(c => c.Name))
            {
                Assert.AreEqual(propNameList[index], propertyType.Name);
                index += 1;
            }

            Assert.AreEqual(propNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(VPScenario).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void VPScenario_Navigation_OK()
        {
            List<string> foreignNameList = new List<string>() { "InfrastructureTVItem",  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() { "VPAmbients", "VPResults", "VPScenarioLanguages",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (string foreignName in (from c in entityType.GetForeignKeys() orderby c.DependentToPrincipal.Name select c.DependentToPrincipal.Name))
            {
                Assert.AreEqual(foreignNameList[index], foreignName);
                index += 1;
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(VPScenario).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void VPScenario_Has_ValidationResults_OK()
        {
             Assert.IsTrue(typeof(VPScenario).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void VPScenario_Every_Property_Has_A_Resource_OK()
        {
               Assert.IsNotNull(ModelsRes.VPScenarioVPScenarioID);
               Assert.IsNotNull(ModelsRes.VPScenarioInfrastructureTVItemID);
               Assert.IsNotNull(ModelsRes.VPScenarioVPScenarioStatus);
               Assert.IsNotNull(ModelsRes.VPScenarioUseAsBestEstimate);
               Assert.IsNotNull(ModelsRes.VPScenarioEffluentFlow_m3_s);
               Assert.IsNotNull(ModelsRes.VPScenarioEffluentConcentration_MPN_100ml);
               Assert.IsNotNull(ModelsRes.VPScenarioFroudeNumber);
               Assert.IsNotNull(ModelsRes.VPScenarioPortDiameter_m);
               Assert.IsNotNull(ModelsRes.VPScenarioPortDepth_m);
               Assert.IsNotNull(ModelsRes.VPScenarioPortElevation_m);
               Assert.IsNotNull(ModelsRes.VPScenarioVerticalAngle_deg);
               Assert.IsNotNull(ModelsRes.VPScenarioHorizontalAngle_deg);
               Assert.IsNotNull(ModelsRes.VPScenarioNumberOfPorts);
               Assert.IsNotNull(ModelsRes.VPScenarioPortSpacing_m);
               Assert.IsNotNull(ModelsRes.VPScenarioAcuteMixZone_m);
               Assert.IsNotNull(ModelsRes.VPScenarioChronicMixZone_m);
               Assert.IsNotNull(ModelsRes.VPScenarioEffluentSalinity_PSU);
               Assert.IsNotNull(ModelsRes.VPScenarioEffluentTemperature_C);
               Assert.IsNotNull(ModelsRes.VPScenarioEffluentVelocity_m_s);
               Assert.IsNotNull(ModelsRes.VPScenarioRawResults);
               Assert.IsNotNull(ModelsRes.VPScenarioLastUpdateDate_UTC);
               Assert.IsNotNull(ModelsRes.VPScenarioLastUpdateContactTVItemID);
               Assert.IsNotNull(ModelsRes.VPScenarioVPAmbients);
               Assert.IsNotNull(ModelsRes.VPScenarioVPResults);
               Assert.IsNotNull(ModelsRes.VPScenarioVPScenarioLanguages);
               Assert.IsNotNull(ModelsRes.VPScenarioInfrastructureTVItem);
        }
    }
}
