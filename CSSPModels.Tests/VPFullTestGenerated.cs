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
    public partial class VPFullTest
    {
        [TestMethod]
        public void VPFull_Properties_OK()
        {
            List<string> propNameList = new List<string>() { "AmbientList", "ResultList", "VPScenarioID", "InfrastructureTVItemID", "VPScenarioStatus", "UseAsBestEstimate", "EffluentFlow_m3_s", "EffluentConcentration_MPN_100ml", "FroudeNumber", "PortDiameter_m", "PortDepth_m", "PortElevation_m", "VerticalAngle_deg", "HorizontalAngle_deg", "NumberOfPorts", "PortSpacing_m", "AcuteMixZone_m", "ChronicMixZone_m", "EffluentSalinity_PSU", "EffluentTemperature_C", "EffluentVelocity_m_s", "RawResults", "LastUpdateDate_UTC", "LastUpdateContactTVItemID", "VPAmbients", "VPResults", "VPScenarioLanguages", "InfrastructureTVItem",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(VPFull).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
            {
                Assert.AreEqual(propertyInfo.Name, propNameList[index]);
                index += 1;
            }

            Assert.AreEqual(propNameList.Count, index);
        }
        [TestMethod]
        public void VPFull_Has_ValidationResults_OK()
        {
             Assert.IsTrue(typeof(VPFull).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void VPFull_Every_Property_Has_A_Resource_OK()
        {
               Assert.IsNotNull(ModelsRes.VPFullAmbientList);
               Assert.IsNotNull(ModelsRes.VPFullResultList);
               Assert.IsNotNull(ModelsRes.VPFullVPScenarioID);
               Assert.IsNotNull(ModelsRes.VPFullInfrastructureTVItemID);
               Assert.IsNotNull(ModelsRes.VPFullVPScenarioStatus);
               Assert.IsNotNull(ModelsRes.VPFullUseAsBestEstimate);
               Assert.IsNotNull(ModelsRes.VPFullEffluentFlow_m3_s);
               Assert.IsNotNull(ModelsRes.VPFullEffluentConcentration_MPN_100ml);
               Assert.IsNotNull(ModelsRes.VPFullFroudeNumber);
               Assert.IsNotNull(ModelsRes.VPFullPortDiameter_m);
               Assert.IsNotNull(ModelsRes.VPFullPortDepth_m);
               Assert.IsNotNull(ModelsRes.VPFullPortElevation_m);
               Assert.IsNotNull(ModelsRes.VPFullVerticalAngle_deg);
               Assert.IsNotNull(ModelsRes.VPFullHorizontalAngle_deg);
               Assert.IsNotNull(ModelsRes.VPFullNumberOfPorts);
               Assert.IsNotNull(ModelsRes.VPFullPortSpacing_m);
               Assert.IsNotNull(ModelsRes.VPFullAcuteMixZone_m);
               Assert.IsNotNull(ModelsRes.VPFullChronicMixZone_m);
               Assert.IsNotNull(ModelsRes.VPFullEffluentSalinity_PSU);
               Assert.IsNotNull(ModelsRes.VPFullEffluentTemperature_C);
               Assert.IsNotNull(ModelsRes.VPFullEffluentVelocity_m_s);
               Assert.IsNotNull(ModelsRes.VPFullRawResults);
               Assert.IsNotNull(ModelsRes.VPFullLastUpdateDate_UTC);
               Assert.IsNotNull(ModelsRes.VPFullLastUpdateContactTVItemID);
               Assert.IsNotNull(ModelsRes.VPFullVPAmbients);
               Assert.IsNotNull(ModelsRes.VPFullVPResults);
               Assert.IsNotNull(ModelsRes.VPFullVPScenarioLanguages);
               Assert.IsNotNull(ModelsRes.VPFullInfrastructureTVItem);
        }
    }
}
