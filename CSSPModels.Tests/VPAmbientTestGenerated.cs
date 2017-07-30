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
    public partial class VPAmbientTest : SetupData
    {
        [TestMethod]
        public void VPAmbient_Properties_Test()
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
        public void VPAmbient_Navigation_Test()
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
        public void VPAmbient_Has_ValidationResults_Test()
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
        [TestMethod]
        public void VPAmbient_Every_Property_Has_Get_Set_Test()
        {
               int val1 = 45;
               vPAmbient.VPAmbientID = val1;
               Assert.AreEqual(val1, vPAmbient.VPAmbientID);
               int val2 = 45;
               vPAmbient.VPScenarioID = val2;
               Assert.AreEqual(val2, vPAmbient.VPScenarioID);
               int val3 = 45;
               vPAmbient.Row = val3;
               Assert.AreEqual(val3, vPAmbient.Row);
               double val4 = 87.9D;
               vPAmbient.MeasurementDepth_m = val4;
               Assert.AreEqual(val4, vPAmbient.MeasurementDepth_m);
               double val5 = 87.9D;
               vPAmbient.CurrentSpeed_m_s = val5;
               Assert.AreEqual(val5, vPAmbient.CurrentSpeed_m_s);
               double val6 = 87.9D;
               vPAmbient.CurrentDirection_deg = val6;
               Assert.AreEqual(val6, vPAmbient.CurrentDirection_deg);
               double val7 = 87.9D;
               vPAmbient.AmbientSalinity_PSU = val7;
               Assert.AreEqual(val7, vPAmbient.AmbientSalinity_PSU);
               double val8 = 87.9D;
               vPAmbient.AmbientTemperature_C = val8;
               Assert.AreEqual(val8, vPAmbient.AmbientTemperature_C);
               int val9 = 45;
               vPAmbient.BackgroundConcentration_MPN_100ml = val9;
               Assert.AreEqual(val9, vPAmbient.BackgroundConcentration_MPN_100ml);
               double val10 = 87.9D;
               vPAmbient.PollutantDecayRate_per_day = val10;
               Assert.AreEqual(val10, vPAmbient.PollutantDecayRate_per_day);
               double val11 = 87.9D;
               vPAmbient.FarFieldCurrentSpeed_m_s = val11;
               Assert.AreEqual(val11, vPAmbient.FarFieldCurrentSpeed_m_s);
               double val12 = 87.9D;
               vPAmbient.FarFieldCurrentDirection_deg = val12;
               Assert.AreEqual(val12, vPAmbient.FarFieldCurrentDirection_deg);
               double val13 = 87.9D;
               vPAmbient.FarFieldDiffusionCoefficient = val13;
               Assert.AreEqual(val13, vPAmbient.FarFieldDiffusionCoefficient);
               DateTime val14 = new DateTime(2010, 3, 4);
               vPAmbient.LastUpdateDate_UTC = val14;
               Assert.AreEqual(val14, vPAmbient.LastUpdateDate_UTC);
               int val15 = 45;
               vPAmbient.LastUpdateContactTVItemID = val15;
               Assert.AreEqual(val15, vPAmbient.LastUpdateContactTVItemID);
               VPScenario val33 = new VPScenario();
               vPAmbient.VPScenario = val33;
               Assert.AreEqual(val33, vPAmbient.VPScenario);
               IEnumerable<ValidationResult> val51 = new List<ValidationResult>().AsEnumerable();
               vPAmbient.ValidationResults = val51;
               Assert.AreEqual(val51, vPAmbient.ValidationResults);
        }
    }
}
