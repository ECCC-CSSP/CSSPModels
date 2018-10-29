/*
 * Auto generated from the CSSPCodeWriter.proj by clicking on the [[ModelClassName]TestGenerated.cs] button
 *
 * Do not edit this file.
 *
 */ 
using System;
using System.Text;
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
    [TestClass]
    public partial class VPScenarioTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private VPScenario vPScenario { get; set; }
        private VPScenarioExtraA vPScenarioExtraA { get; set; }
        private VPScenarioExtraB vPScenarioExtraB { get; set; }
        #endregion Properties

        #region Constructors
        public VPScenarioTest()
        {
            vPScenario = new VPScenario();
            vPScenarioExtraA = new VPScenarioExtraA();
            vPScenarioExtraB = new VPScenarioExtraB();
        }
        #endregion Constructors

        #region Tests Functions public
        [TestMethod]
        public void VPScenario_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "VPScenarioID", "InfrastructureTVItemID", "VPScenarioStatus", "UseAsBestEstimate", "EffluentFlow_m3_s", "EffluentConcentration_MPN_100ml", "FroudeNumber", "PortDiameter_m", "PortDepth_m", "PortElevation_m", "VerticalAngle_deg", "HorizontalAngle_deg", "NumberOfPorts", "PortSpacing_m", "AcuteMixZone_m", "ChronicMixZone_m", "EffluentSalinity_PSU", "EffluentTemperature_C", "EffluentVelocity_m_s", "RawResults", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "HasErrors",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(VPScenario).GetProperties().OrderBy(c => c.Name))
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
        public void VPScenarioExtraA_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "SubsectorText", "LastUpdateContactText", "VPScenarioStatusText", "VPScenarioID", "InfrastructureTVItemID", "VPScenarioStatus", "UseAsBestEstimate", "EffluentFlow_m3_s", "EffluentConcentration_MPN_100ml", "FroudeNumber", "PortDiameter_m", "PortDepth_m", "PortElevation_m", "VerticalAngle_deg", "HorizontalAngle_deg", "NumberOfPorts", "PortSpacing_m", "AcuteMixZone_m", "ChronicMixZone_m", "EffluentSalinity_PSU", "EffluentTemperature_C", "EffluentVelocity_m_s", "RawResults", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "HasErrors",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(VPScenarioExtraA).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(VPScenarioExtraA).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void VPScenarioExtraB_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "VPScenarioReportTest", "SubsectorText", "LastUpdateContactText", "VPScenarioStatusText", "VPScenarioID", "InfrastructureTVItemID", "VPScenarioStatus", "UseAsBestEstimate", "EffluentFlow_m3_s", "EffluentConcentration_MPN_100ml", "FroudeNumber", "PortDiameter_m", "PortDepth_m", "PortElevation_m", "VerticalAngle_deg", "HorizontalAngle_deg", "NumberOfPorts", "PortSpacing_m", "AcuteMixZone_m", "ChronicMixZone_m", "EffluentSalinity_PSU", "EffluentTemperature_C", "EffluentVelocity_m_s", "RawResults", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "HasErrors",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(VPScenarioExtraB).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(VPScenarioExtraB).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void VPScenarioExtraA_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(VPScenarioExtraA).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(VPScenarioExtraA).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void VPScenarioExtraB_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(VPScenarioExtraB).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(VPScenarioExtraB).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void VPScenarioExtraA_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(VPScenarioExtraA).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void VPScenarioExtraB_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(VPScenarioExtraB).GetProperties().Where(c => c.Name == "ValidationResults").Any());
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
               bool val23 = true;
               vPScenario.HasErrors = val23;
               Assert.AreEqual(val23, vPScenario.HasErrors);
               IEnumerable<ValidationResult> val72 = new List<ValidationResult>() { new ValidationResult("First CSSPError Message") }.AsEnumerable();
               vPScenario.ValidationResults = val72;
               Assert.AreEqual(val72, vPScenario.ValidationResults);
        }
        [TestMethod]
        public void VPScenarioExtraA_Every_Property_Has_Get_Set_Test()
        {
               string val1 = "Some text";
               vPScenarioExtraA.SubsectorText = val1;
               Assert.AreEqual(val1, vPScenarioExtraA.SubsectorText);
               string val2 = "Some text";
               vPScenarioExtraA.LastUpdateContactText = val2;
               Assert.AreEqual(val2, vPScenarioExtraA.LastUpdateContactText);
               string val3 = "Some text";
               vPScenarioExtraA.VPScenarioStatusText = val3;
               Assert.AreEqual(val3, vPScenarioExtraA.VPScenarioStatusText);
               int val4 = 45;
               vPScenarioExtraA.VPScenarioID = val4;
               Assert.AreEqual(val4, vPScenarioExtraA.VPScenarioID);
               int val5 = 45;
               vPScenarioExtraA.InfrastructureTVItemID = val5;
               Assert.AreEqual(val5, vPScenarioExtraA.InfrastructureTVItemID);
               ScenarioStatusEnum val6 = (ScenarioStatusEnum)3;
               vPScenarioExtraA.VPScenarioStatus = val6;
               Assert.AreEqual(val6, vPScenarioExtraA.VPScenarioStatus);
               bool val7 = true;
               vPScenarioExtraA.UseAsBestEstimate = val7;
               Assert.AreEqual(val7, vPScenarioExtraA.UseAsBestEstimate);
               double val8 = 87.9D;
               vPScenarioExtraA.EffluentFlow_m3_s = val8;
               Assert.AreEqual(val8, vPScenarioExtraA.EffluentFlow_m3_s);
               int val9 = 45;
               vPScenarioExtraA.EffluentConcentration_MPN_100ml = val9;
               Assert.AreEqual(val9, vPScenarioExtraA.EffluentConcentration_MPN_100ml);
               double val10 = 87.9D;
               vPScenarioExtraA.FroudeNumber = val10;
               Assert.AreEqual(val10, vPScenarioExtraA.FroudeNumber);
               double val11 = 87.9D;
               vPScenarioExtraA.PortDiameter_m = val11;
               Assert.AreEqual(val11, vPScenarioExtraA.PortDiameter_m);
               double val12 = 87.9D;
               vPScenarioExtraA.PortDepth_m = val12;
               Assert.AreEqual(val12, vPScenarioExtraA.PortDepth_m);
               double val13 = 87.9D;
               vPScenarioExtraA.PortElevation_m = val13;
               Assert.AreEqual(val13, vPScenarioExtraA.PortElevation_m);
               double val14 = 87.9D;
               vPScenarioExtraA.VerticalAngle_deg = val14;
               Assert.AreEqual(val14, vPScenarioExtraA.VerticalAngle_deg);
               double val15 = 87.9D;
               vPScenarioExtraA.HorizontalAngle_deg = val15;
               Assert.AreEqual(val15, vPScenarioExtraA.HorizontalAngle_deg);
               int val16 = 45;
               vPScenarioExtraA.NumberOfPorts = val16;
               Assert.AreEqual(val16, vPScenarioExtraA.NumberOfPorts);
               double val17 = 87.9D;
               vPScenarioExtraA.PortSpacing_m = val17;
               Assert.AreEqual(val17, vPScenarioExtraA.PortSpacing_m);
               double val18 = 87.9D;
               vPScenarioExtraA.AcuteMixZone_m = val18;
               Assert.AreEqual(val18, vPScenarioExtraA.AcuteMixZone_m);
               double val19 = 87.9D;
               vPScenarioExtraA.ChronicMixZone_m = val19;
               Assert.AreEqual(val19, vPScenarioExtraA.ChronicMixZone_m);
               double val20 = 87.9D;
               vPScenarioExtraA.EffluentSalinity_PSU = val20;
               Assert.AreEqual(val20, vPScenarioExtraA.EffluentSalinity_PSU);
               double val21 = 87.9D;
               vPScenarioExtraA.EffluentTemperature_C = val21;
               Assert.AreEqual(val21, vPScenarioExtraA.EffluentTemperature_C);
               double val22 = 87.9D;
               vPScenarioExtraA.EffluentVelocity_m_s = val22;
               Assert.AreEqual(val22, vPScenarioExtraA.EffluentVelocity_m_s);
               string val23 = "Some text";
               vPScenarioExtraA.RawResults = val23;
               Assert.AreEqual(val23, vPScenarioExtraA.RawResults);
               DateTime val24 = new DateTime(2010, 3, 4);
               vPScenarioExtraA.LastUpdateDate_UTC = val24;
               Assert.AreEqual(val24, vPScenarioExtraA.LastUpdateDate_UTC);
               int val25 = 45;
               vPScenarioExtraA.LastUpdateContactTVItemID = val25;
               Assert.AreEqual(val25, vPScenarioExtraA.LastUpdateContactTVItemID);
               bool val26 = true;
               vPScenarioExtraA.HasErrors = val26;
               Assert.AreEqual(val26, vPScenarioExtraA.HasErrors);
               IEnumerable<ValidationResult> val81 = new List<ValidationResult>() { new ValidationResult("First CSSPError Message") }.AsEnumerable();
               vPScenarioExtraA.ValidationResults = val81;
               Assert.AreEqual(val81, vPScenarioExtraA.ValidationResults);
        }
        [TestMethod]
        public void VPScenarioExtraB_Every_Property_Has_Get_Set_Test()
        {
               string val1 = "Some text";
               vPScenarioExtraB.VPScenarioReportTest = val1;
               Assert.AreEqual(val1, vPScenarioExtraB.VPScenarioReportTest);
               string val2 = "Some text";
               vPScenarioExtraB.SubsectorText = val2;
               Assert.AreEqual(val2, vPScenarioExtraB.SubsectorText);
               string val3 = "Some text";
               vPScenarioExtraB.LastUpdateContactText = val3;
               Assert.AreEqual(val3, vPScenarioExtraB.LastUpdateContactText);
               string val4 = "Some text";
               vPScenarioExtraB.VPScenarioStatusText = val4;
               Assert.AreEqual(val4, vPScenarioExtraB.VPScenarioStatusText);
               int val5 = 45;
               vPScenarioExtraB.VPScenarioID = val5;
               Assert.AreEqual(val5, vPScenarioExtraB.VPScenarioID);
               int val6 = 45;
               vPScenarioExtraB.InfrastructureTVItemID = val6;
               Assert.AreEqual(val6, vPScenarioExtraB.InfrastructureTVItemID);
               ScenarioStatusEnum val7 = (ScenarioStatusEnum)3;
               vPScenarioExtraB.VPScenarioStatus = val7;
               Assert.AreEqual(val7, vPScenarioExtraB.VPScenarioStatus);
               bool val8 = true;
               vPScenarioExtraB.UseAsBestEstimate = val8;
               Assert.AreEqual(val8, vPScenarioExtraB.UseAsBestEstimate);
               double val9 = 87.9D;
               vPScenarioExtraB.EffluentFlow_m3_s = val9;
               Assert.AreEqual(val9, vPScenarioExtraB.EffluentFlow_m3_s);
               int val10 = 45;
               vPScenarioExtraB.EffluentConcentration_MPN_100ml = val10;
               Assert.AreEqual(val10, vPScenarioExtraB.EffluentConcentration_MPN_100ml);
               double val11 = 87.9D;
               vPScenarioExtraB.FroudeNumber = val11;
               Assert.AreEqual(val11, vPScenarioExtraB.FroudeNumber);
               double val12 = 87.9D;
               vPScenarioExtraB.PortDiameter_m = val12;
               Assert.AreEqual(val12, vPScenarioExtraB.PortDiameter_m);
               double val13 = 87.9D;
               vPScenarioExtraB.PortDepth_m = val13;
               Assert.AreEqual(val13, vPScenarioExtraB.PortDepth_m);
               double val14 = 87.9D;
               vPScenarioExtraB.PortElevation_m = val14;
               Assert.AreEqual(val14, vPScenarioExtraB.PortElevation_m);
               double val15 = 87.9D;
               vPScenarioExtraB.VerticalAngle_deg = val15;
               Assert.AreEqual(val15, vPScenarioExtraB.VerticalAngle_deg);
               double val16 = 87.9D;
               vPScenarioExtraB.HorizontalAngle_deg = val16;
               Assert.AreEqual(val16, vPScenarioExtraB.HorizontalAngle_deg);
               int val17 = 45;
               vPScenarioExtraB.NumberOfPorts = val17;
               Assert.AreEqual(val17, vPScenarioExtraB.NumberOfPorts);
               double val18 = 87.9D;
               vPScenarioExtraB.PortSpacing_m = val18;
               Assert.AreEqual(val18, vPScenarioExtraB.PortSpacing_m);
               double val19 = 87.9D;
               vPScenarioExtraB.AcuteMixZone_m = val19;
               Assert.AreEqual(val19, vPScenarioExtraB.AcuteMixZone_m);
               double val20 = 87.9D;
               vPScenarioExtraB.ChronicMixZone_m = val20;
               Assert.AreEqual(val20, vPScenarioExtraB.ChronicMixZone_m);
               double val21 = 87.9D;
               vPScenarioExtraB.EffluentSalinity_PSU = val21;
               Assert.AreEqual(val21, vPScenarioExtraB.EffluentSalinity_PSU);
               double val22 = 87.9D;
               vPScenarioExtraB.EffluentTemperature_C = val22;
               Assert.AreEqual(val22, vPScenarioExtraB.EffluentTemperature_C);
               double val23 = 87.9D;
               vPScenarioExtraB.EffluentVelocity_m_s = val23;
               Assert.AreEqual(val23, vPScenarioExtraB.EffluentVelocity_m_s);
               string val24 = "Some text";
               vPScenarioExtraB.RawResults = val24;
               Assert.AreEqual(val24, vPScenarioExtraB.RawResults);
               DateTime val25 = new DateTime(2010, 3, 4);
               vPScenarioExtraB.LastUpdateDate_UTC = val25;
               Assert.AreEqual(val25, vPScenarioExtraB.LastUpdateDate_UTC);
               int val26 = 45;
               vPScenarioExtraB.LastUpdateContactTVItemID = val26;
               Assert.AreEqual(val26, vPScenarioExtraB.LastUpdateContactTVItemID);
               bool val27 = true;
               vPScenarioExtraB.HasErrors = val27;
               Assert.AreEqual(val27, vPScenarioExtraB.HasErrors);
               IEnumerable<ValidationResult> val84 = new List<ValidationResult>() { new ValidationResult("First CSSPError Message") }.AsEnumerable();
               vPScenarioExtraB.ValidationResults = val84;
               Assert.AreEqual(val84, vPScenarioExtraB.ValidationResults);
        }
        #endregion Tests Functions public
    }
}
