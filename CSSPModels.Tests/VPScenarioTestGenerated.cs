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
    public partial class VPScenarioTest : SetupData
    {
        [TestMethod]
        public void VPScenario_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "VPScenarioID", "InfrastructureTVItemID", "VPScenarioStatus", "UseAsBestEstimate", "EffluentFlow_m3_s", "EffluentConcentration_MPN_100ml", "FroudeNumber", "PortDiameter_m", "PortDepth_m", "PortElevation_m", "VerticalAngle_deg", "HorizontalAngle_deg", "NumberOfPorts", "PortSpacing_m", "AcuteMixZone_m", "ChronicMixZone_m", "EffluentSalinity_PSU", "EffluentTemperature_C", "EffluentVelocity_m_s", "RawResults", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "SubsectorTVText", "LastUpdateContactTVText", "VPScenarioStatusText", "HasErrors",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(CSSPModels.VPScenario).GetProperties().OrderBy(c => c.Name))
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
        public void VPScenario_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(VPScenario).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
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
        public void VPScenario_Has_ValidationResults_Test()
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
               Assert.IsNotNull(ModelsRes.VPScenarioSubsectorTVText);
               Assert.IsNotNull(ModelsRes.VPScenarioLastUpdateContactTVText);
               Assert.IsNotNull(ModelsRes.VPScenarioVPScenarioStatusText);
               Assert.IsNotNull(ModelsRes.VPScenarioHasErrors);
        }
        [TestMethod]
        public void VPScenario_Every_Property_Has_Get_Set_Test()
        {
               int val1 = 45;
               vPScenario.VPScenarioID = val1;
               Assert.AreEqual(val1, vPScenario.VPScenarioID);
               int val2 = 45;
               vPScenario.InfrastructureTVItemID = val2;
               Assert.AreEqual(val2, vPScenario.InfrastructureTVItemID);
               ScenarioStatusEnum val3 = (ScenarioStatusEnum)3;
               vPScenario.VPScenarioStatus = val3;
               Assert.AreEqual(val3, vPScenario.VPScenarioStatus);
               bool val4 = true;
               vPScenario.UseAsBestEstimate = val4;
               Assert.AreEqual(val4, vPScenario.UseAsBestEstimate);
               double val5 = 87.9D;
               vPScenario.EffluentFlow_m3_s = val5;
               Assert.AreEqual(val5, vPScenario.EffluentFlow_m3_s);
               int val6 = 45;
               vPScenario.EffluentConcentration_MPN_100ml = val6;
               Assert.AreEqual(val6, vPScenario.EffluentConcentration_MPN_100ml);
               double val7 = 87.9D;
               vPScenario.FroudeNumber = val7;
               Assert.AreEqual(val7, vPScenario.FroudeNumber);
               double val8 = 87.9D;
               vPScenario.PortDiameter_m = val8;
               Assert.AreEqual(val8, vPScenario.PortDiameter_m);
               double val9 = 87.9D;
               vPScenario.PortDepth_m = val9;
               Assert.AreEqual(val9, vPScenario.PortDepth_m);
               double val10 = 87.9D;
               vPScenario.PortElevation_m = val10;
               Assert.AreEqual(val10, vPScenario.PortElevation_m);
               double val11 = 87.9D;
               vPScenario.VerticalAngle_deg = val11;
               Assert.AreEqual(val11, vPScenario.VerticalAngle_deg);
               double val12 = 87.9D;
               vPScenario.HorizontalAngle_deg = val12;
               Assert.AreEqual(val12, vPScenario.HorizontalAngle_deg);
               int val13 = 45;
               vPScenario.NumberOfPorts = val13;
               Assert.AreEqual(val13, vPScenario.NumberOfPorts);
               double val14 = 87.9D;
               vPScenario.PortSpacing_m = val14;
               Assert.AreEqual(val14, vPScenario.PortSpacing_m);
               double val15 = 87.9D;
               vPScenario.AcuteMixZone_m = val15;
               Assert.AreEqual(val15, vPScenario.AcuteMixZone_m);
               double val16 = 87.9D;
               vPScenario.ChronicMixZone_m = val16;
               Assert.AreEqual(val16, vPScenario.ChronicMixZone_m);
               double val17 = 87.9D;
               vPScenario.EffluentSalinity_PSU = val17;
               Assert.AreEqual(val17, vPScenario.EffluentSalinity_PSU);
               double val18 = 87.9D;
               vPScenario.EffluentTemperature_C = val18;
               Assert.AreEqual(val18, vPScenario.EffluentTemperature_C);
               double val19 = 87.9D;
               vPScenario.EffluentVelocity_m_s = val19;
               Assert.AreEqual(val19, vPScenario.EffluentVelocity_m_s);
               string val20 = "Some text";
               vPScenario.RawResults = val20;
               Assert.AreEqual(val20, vPScenario.RawResults);
               DateTime val21 = new DateTime(2010, 3, 4);
               vPScenario.LastUpdateDate_UTC = val21;
               Assert.AreEqual(val21, vPScenario.LastUpdateDate_UTC);
               int val22 = 45;
               vPScenario.LastUpdateContactTVItemID = val22;
               Assert.AreEqual(val22, vPScenario.LastUpdateContactTVItemID);
               string val23 = "Some text";
               vPScenario.SubsectorTVText = val23;
               Assert.AreEqual(val23, vPScenario.SubsectorTVText);
               string val24 = "Some text";
               vPScenario.LastUpdateContactTVText = val24;
               Assert.AreEqual(val24, vPScenario.LastUpdateContactTVText);
               string val25 = "Some text";
               vPScenario.VPScenarioStatusText = val25;
               Assert.AreEqual(val25, vPScenario.VPScenarioStatusText);
               bool val26 = true;
               vPScenario.HasErrors = val26;
               Assert.AreEqual(val26, vPScenario.HasErrors);
               IEnumerable<ValidationResult> val81 = new List<ValidationResult>().AsEnumerable();
               vPScenario.ValidationResults = val81;
               Assert.AreEqual(val81, vPScenario.ValidationResults);
        }
    }
}
