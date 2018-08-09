/*
 * Auto generated from the CSSPCodeWriter.proj by clicking on the [[ModelClassName]TestGenerated.cs] button
 *
 * Do not edit this file.
 *
 * Last generated by leblancc on WMON01DTCHLEBL2 machine
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
    public partial class MikeScenarioTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private MikeScenario mikeScenario { get; set; }
        private MikeScenario_A mikeScenario_A { get; set; }
        private MikeScenario_B mikeScenario_B { get; set; }
        #endregion Properties

        #region Constructors
        public MikeScenarioTest()
        {
            mikeScenario = new MikeScenario();
            mikeScenario_A = new MikeScenario_A();
            mikeScenario_B = new MikeScenario_B();
        }
        #endregion Constructors

        #region Tests Functions public
        [TestMethod]
        public void MikeScenario_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "MikeScenarioID", "MikeScenarioTVItemID", "ParentMikeScenarioID", "ScenarioStatus", "ErrorInfo", "MikeScenarioStartDateTime_Local", "MikeScenarioEndDateTime_Local", "MikeScenarioStartExecutionDateTime_Local", "MikeScenarioExecutionTime_min", "WindSpeed_km_h", "WindDirection_deg", "DecayFactor_per_day", "DecayIsConstant", "DecayFactorAmplitude", "ResultFrequency_min", "AmbientTemperature_C", "AmbientSalinity_PSU", "ManningNumber", "NumberOfElements", "NumberOfTimeSteps", "NumberOfSigmaLayers", "NumberOfZLayers", "NumberOfHydroOutputParameters", "NumberOfTransOutputParameters", "EstimatedHydroFileSize", "EstimatedTransFileSize", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "HasErrors",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(MikeScenario).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(MikeScenario).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void MikeScenario_A_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "MikeScenarioTVItemLanguage", "LastUpdateContactTVItemLanguage", "ScenarioStatusText", "MikeScenarioID", "MikeScenarioTVItemID", "ParentMikeScenarioID", "ScenarioStatus", "ErrorInfo", "MikeScenarioStartDateTime_Local", "MikeScenarioEndDateTime_Local", "MikeScenarioStartExecutionDateTime_Local", "MikeScenarioExecutionTime_min", "WindSpeed_km_h", "WindDirection_deg", "DecayFactor_per_day", "DecayIsConstant", "DecayFactorAmplitude", "ResultFrequency_min", "AmbientTemperature_C", "AmbientSalinity_PSU", "ManningNumber", "NumberOfElements", "NumberOfTimeSteps", "NumberOfSigmaLayers", "NumberOfZLayers", "NumberOfHydroOutputParameters", "NumberOfTransOutputParameters", "EstimatedHydroFileSize", "EstimatedTransFileSize", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "HasErrors",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(MikeScenario_A).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(MikeScenario_A).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void MikeScenario_B_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "MikeScenarioReportTest", "MikeScenarioTVItemLanguage", "LastUpdateContactTVItemLanguage", "ScenarioStatusText", "MikeScenarioID", "MikeScenarioTVItemID", "ParentMikeScenarioID", "ScenarioStatus", "ErrorInfo", "MikeScenarioStartDateTime_Local", "MikeScenarioEndDateTime_Local", "MikeScenarioStartExecutionDateTime_Local", "MikeScenarioExecutionTime_min", "WindSpeed_km_h", "WindDirection_deg", "DecayFactor_per_day", "DecayIsConstant", "DecayFactorAmplitude", "ResultFrequency_min", "AmbientTemperature_C", "AmbientSalinity_PSU", "ManningNumber", "NumberOfElements", "NumberOfTimeSteps", "NumberOfSigmaLayers", "NumberOfZLayers", "NumberOfHydroOutputParameters", "NumberOfTransOutputParameters", "EstimatedHydroFileSize", "EstimatedTransFileSize", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "HasErrors",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(MikeScenario_B).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(MikeScenario_B).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void MikeScenario_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(MikeScenario).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(MikeScenario).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void MikeScenario_A_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(MikeScenario_A).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(MikeScenario_A).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void MikeScenario_B_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(MikeScenario_B).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(MikeScenario_B).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void MikeScenario_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(MikeScenario).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void MikeScenario_A_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(MikeScenario_A).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void MikeScenario_B_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(MikeScenario_B).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void MikeScenario_Every_Property_Has_Get_Set_Test()
        {
               int val1 = 45;
               mikeScenario.MikeScenarioID = val1;
               Assert.AreEqual(val1, mikeScenario.MikeScenarioID);
               int val2 = 45;
               mikeScenario.MikeScenarioTVItemID = val2;
               Assert.AreEqual(val2, mikeScenario.MikeScenarioTVItemID);
               int val3 = 45;
               mikeScenario.ParentMikeScenarioID = val3;
               Assert.AreEqual(val3, mikeScenario.ParentMikeScenarioID);
               ScenarioStatusEnum val4 = (ScenarioStatusEnum)3;
               mikeScenario.ScenarioStatus = val4;
               Assert.AreEqual(val4, mikeScenario.ScenarioStatus);
               string val5 = "Some text";
               mikeScenario.ErrorInfo = val5;
               Assert.AreEqual(val5, mikeScenario.ErrorInfo);
               DateTime val6 = new DateTime(2010, 3, 4);
               mikeScenario.MikeScenarioStartDateTime_Local = val6;
               Assert.AreEqual(val6, mikeScenario.MikeScenarioStartDateTime_Local);
               DateTime val7 = new DateTime(2010, 3, 4);
               mikeScenario.MikeScenarioEndDateTime_Local = val7;
               Assert.AreEqual(val7, mikeScenario.MikeScenarioEndDateTime_Local);
               DateTime val8 = new DateTime(2010, 3, 4);
               mikeScenario.MikeScenarioStartExecutionDateTime_Local = val8;
               Assert.AreEqual(val8, mikeScenario.MikeScenarioStartExecutionDateTime_Local);
               double val9 = 87.9D;
               mikeScenario.MikeScenarioExecutionTime_min = val9;
               Assert.AreEqual(val9, mikeScenario.MikeScenarioExecutionTime_min);
               double val10 = 87.9D;
               mikeScenario.WindSpeed_km_h = val10;
               Assert.AreEqual(val10, mikeScenario.WindSpeed_km_h);
               double val11 = 87.9D;
               mikeScenario.WindDirection_deg = val11;
               Assert.AreEqual(val11, mikeScenario.WindDirection_deg);
               double val12 = 87.9D;
               mikeScenario.DecayFactor_per_day = val12;
               Assert.AreEqual(val12, mikeScenario.DecayFactor_per_day);
               bool val13 = true;
               mikeScenario.DecayIsConstant = val13;
               Assert.AreEqual(val13, mikeScenario.DecayIsConstant);
               double val14 = 87.9D;
               mikeScenario.DecayFactorAmplitude = val14;
               Assert.AreEqual(val14, mikeScenario.DecayFactorAmplitude);
               int val15 = 45;
               mikeScenario.ResultFrequency_min = val15;
               Assert.AreEqual(val15, mikeScenario.ResultFrequency_min);
               double val16 = 87.9D;
               mikeScenario.AmbientTemperature_C = val16;
               Assert.AreEqual(val16, mikeScenario.AmbientTemperature_C);
               double val17 = 87.9D;
               mikeScenario.AmbientSalinity_PSU = val17;
               Assert.AreEqual(val17, mikeScenario.AmbientSalinity_PSU);
               double val18 = 87.9D;
               mikeScenario.ManningNumber = val18;
               Assert.AreEqual(val18, mikeScenario.ManningNumber);
               int val19 = 45;
               mikeScenario.NumberOfElements = val19;
               Assert.AreEqual(val19, mikeScenario.NumberOfElements);
               int val20 = 45;
               mikeScenario.NumberOfTimeSteps = val20;
               Assert.AreEqual(val20, mikeScenario.NumberOfTimeSteps);
               int val21 = 45;
               mikeScenario.NumberOfSigmaLayers = val21;
               Assert.AreEqual(val21, mikeScenario.NumberOfSigmaLayers);
               int val22 = 45;
               mikeScenario.NumberOfZLayers = val22;
               Assert.AreEqual(val22, mikeScenario.NumberOfZLayers);
               int val23 = 45;
               mikeScenario.NumberOfHydroOutputParameters = val23;
               Assert.AreEqual(val23, mikeScenario.NumberOfHydroOutputParameters);
               int val24 = 45;
               mikeScenario.NumberOfTransOutputParameters = val24;
               Assert.AreEqual(val24, mikeScenario.NumberOfTransOutputParameters);
               int val25 = 45;
               mikeScenario.EstimatedHydroFileSize = val25;
               Assert.AreEqual(val25, mikeScenario.EstimatedHydroFileSize);
               int val26 = 45;
               mikeScenario.EstimatedTransFileSize = val26;
               Assert.AreEqual(val26, mikeScenario.EstimatedTransFileSize);
               DateTime val27 = new DateTime(2010, 3, 4);
               mikeScenario.LastUpdateDate_UTC = val27;
               Assert.AreEqual(val27, mikeScenario.LastUpdateDate_UTC);
               int val28 = 45;
               mikeScenario.LastUpdateContactTVItemID = val28;
               Assert.AreEqual(val28, mikeScenario.LastUpdateContactTVItemID);
               bool val29 = true;
               mikeScenario.HasErrors = val29;
               Assert.AreEqual(val29, mikeScenario.HasErrors);
               IEnumerable<ValidationResult> val90 = new List<ValidationResult>() { new ValidationResult("First Error Message") }.AsEnumerable();
               mikeScenario.ValidationResults = val90;
               Assert.AreEqual(val90, mikeScenario.ValidationResults);
        }
        [TestMethod]
        public void MikeScenario_A_Every_Property_Has_Get_Set_Test()
        {
               TVItemLanguage val1 = new TVItemLanguage();
               mikeScenario_A.MikeScenarioTVItemLanguage = val1;
               Assert.AreEqual(val1, mikeScenario_A.MikeScenarioTVItemLanguage);
               TVItemLanguage val2 = new TVItemLanguage();
               mikeScenario_A.LastUpdateContactTVItemLanguage = val2;
               Assert.AreEqual(val2, mikeScenario_A.LastUpdateContactTVItemLanguage);
               string val3 = "Some text";
               mikeScenario_A.ScenarioStatusText = val3;
               Assert.AreEqual(val3, mikeScenario_A.ScenarioStatusText);
               int val4 = 45;
               mikeScenario_A.MikeScenarioID = val4;
               Assert.AreEqual(val4, mikeScenario_A.MikeScenarioID);
               int val5 = 45;
               mikeScenario_A.MikeScenarioTVItemID = val5;
               Assert.AreEqual(val5, mikeScenario_A.MikeScenarioTVItemID);
               int val6 = 45;
               mikeScenario_A.ParentMikeScenarioID = val6;
               Assert.AreEqual(val6, mikeScenario_A.ParentMikeScenarioID);
               ScenarioStatusEnum val7 = (ScenarioStatusEnum)3;
               mikeScenario_A.ScenarioStatus = val7;
               Assert.AreEqual(val7, mikeScenario_A.ScenarioStatus);
               string val8 = "Some text";
               mikeScenario_A.ErrorInfo = val8;
               Assert.AreEqual(val8, mikeScenario_A.ErrorInfo);
               DateTime val9 = new DateTime(2010, 3, 4);
               mikeScenario_A.MikeScenarioStartDateTime_Local = val9;
               Assert.AreEqual(val9, mikeScenario_A.MikeScenarioStartDateTime_Local);
               DateTime val10 = new DateTime(2010, 3, 4);
               mikeScenario_A.MikeScenarioEndDateTime_Local = val10;
               Assert.AreEqual(val10, mikeScenario_A.MikeScenarioEndDateTime_Local);
               DateTime val11 = new DateTime(2010, 3, 4);
               mikeScenario_A.MikeScenarioStartExecutionDateTime_Local = val11;
               Assert.AreEqual(val11, mikeScenario_A.MikeScenarioStartExecutionDateTime_Local);
               double val12 = 87.9D;
               mikeScenario_A.MikeScenarioExecutionTime_min = val12;
               Assert.AreEqual(val12, mikeScenario_A.MikeScenarioExecutionTime_min);
               double val13 = 87.9D;
               mikeScenario_A.WindSpeed_km_h = val13;
               Assert.AreEqual(val13, mikeScenario_A.WindSpeed_km_h);
               double val14 = 87.9D;
               mikeScenario_A.WindDirection_deg = val14;
               Assert.AreEqual(val14, mikeScenario_A.WindDirection_deg);
               double val15 = 87.9D;
               mikeScenario_A.DecayFactor_per_day = val15;
               Assert.AreEqual(val15, mikeScenario_A.DecayFactor_per_day);
               bool val16 = true;
               mikeScenario_A.DecayIsConstant = val16;
               Assert.AreEqual(val16, mikeScenario_A.DecayIsConstant);
               double val17 = 87.9D;
               mikeScenario_A.DecayFactorAmplitude = val17;
               Assert.AreEqual(val17, mikeScenario_A.DecayFactorAmplitude);
               int val18 = 45;
               mikeScenario_A.ResultFrequency_min = val18;
               Assert.AreEqual(val18, mikeScenario_A.ResultFrequency_min);
               double val19 = 87.9D;
               mikeScenario_A.AmbientTemperature_C = val19;
               Assert.AreEqual(val19, mikeScenario_A.AmbientTemperature_C);
               double val20 = 87.9D;
               mikeScenario_A.AmbientSalinity_PSU = val20;
               Assert.AreEqual(val20, mikeScenario_A.AmbientSalinity_PSU);
               double val21 = 87.9D;
               mikeScenario_A.ManningNumber = val21;
               Assert.AreEqual(val21, mikeScenario_A.ManningNumber);
               int val22 = 45;
               mikeScenario_A.NumberOfElements = val22;
               Assert.AreEqual(val22, mikeScenario_A.NumberOfElements);
               int val23 = 45;
               mikeScenario_A.NumberOfTimeSteps = val23;
               Assert.AreEqual(val23, mikeScenario_A.NumberOfTimeSteps);
               int val24 = 45;
               mikeScenario_A.NumberOfSigmaLayers = val24;
               Assert.AreEqual(val24, mikeScenario_A.NumberOfSigmaLayers);
               int val25 = 45;
               mikeScenario_A.NumberOfZLayers = val25;
               Assert.AreEqual(val25, mikeScenario_A.NumberOfZLayers);
               int val26 = 45;
               mikeScenario_A.NumberOfHydroOutputParameters = val26;
               Assert.AreEqual(val26, mikeScenario_A.NumberOfHydroOutputParameters);
               int val27 = 45;
               mikeScenario_A.NumberOfTransOutputParameters = val27;
               Assert.AreEqual(val27, mikeScenario_A.NumberOfTransOutputParameters);
               int val28 = 45;
               mikeScenario_A.EstimatedHydroFileSize = val28;
               Assert.AreEqual(val28, mikeScenario_A.EstimatedHydroFileSize);
               int val29 = 45;
               mikeScenario_A.EstimatedTransFileSize = val29;
               Assert.AreEqual(val29, mikeScenario_A.EstimatedTransFileSize);
               DateTime val30 = new DateTime(2010, 3, 4);
               mikeScenario_A.LastUpdateDate_UTC = val30;
               Assert.AreEqual(val30, mikeScenario_A.LastUpdateDate_UTC);
               int val31 = 45;
               mikeScenario_A.LastUpdateContactTVItemID = val31;
               Assert.AreEqual(val31, mikeScenario_A.LastUpdateContactTVItemID);
               bool val32 = true;
               mikeScenario_A.HasErrors = val32;
               Assert.AreEqual(val32, mikeScenario_A.HasErrors);
               IEnumerable<ValidationResult> val99 = new List<ValidationResult>() { new ValidationResult("First Error Message") }.AsEnumerable();
               mikeScenario_A.ValidationResults = val99;
               Assert.AreEqual(val99, mikeScenario_A.ValidationResults);
        }
        [TestMethod]
        public void MikeScenario_B_Every_Property_Has_Get_Set_Test()
        {
               string val1 = "Some text";
               mikeScenario_B.MikeScenarioReportTest = val1;
               Assert.AreEqual(val1, mikeScenario_B.MikeScenarioReportTest);
               TVItemLanguage val2 = new TVItemLanguage();
               mikeScenario_B.MikeScenarioTVItemLanguage = val2;
               Assert.AreEqual(val2, mikeScenario_B.MikeScenarioTVItemLanguage);
               TVItemLanguage val3 = new TVItemLanguage();
               mikeScenario_B.LastUpdateContactTVItemLanguage = val3;
               Assert.AreEqual(val3, mikeScenario_B.LastUpdateContactTVItemLanguage);
               string val4 = "Some text";
               mikeScenario_B.ScenarioStatusText = val4;
               Assert.AreEqual(val4, mikeScenario_B.ScenarioStatusText);
               int val5 = 45;
               mikeScenario_B.MikeScenarioID = val5;
               Assert.AreEqual(val5, mikeScenario_B.MikeScenarioID);
               int val6 = 45;
               mikeScenario_B.MikeScenarioTVItemID = val6;
               Assert.AreEqual(val6, mikeScenario_B.MikeScenarioTVItemID);
               int val7 = 45;
               mikeScenario_B.ParentMikeScenarioID = val7;
               Assert.AreEqual(val7, mikeScenario_B.ParentMikeScenarioID);
               ScenarioStatusEnum val8 = (ScenarioStatusEnum)3;
               mikeScenario_B.ScenarioStatus = val8;
               Assert.AreEqual(val8, mikeScenario_B.ScenarioStatus);
               string val9 = "Some text";
               mikeScenario_B.ErrorInfo = val9;
               Assert.AreEqual(val9, mikeScenario_B.ErrorInfo);
               DateTime val10 = new DateTime(2010, 3, 4);
               mikeScenario_B.MikeScenarioStartDateTime_Local = val10;
               Assert.AreEqual(val10, mikeScenario_B.MikeScenarioStartDateTime_Local);
               DateTime val11 = new DateTime(2010, 3, 4);
               mikeScenario_B.MikeScenarioEndDateTime_Local = val11;
               Assert.AreEqual(val11, mikeScenario_B.MikeScenarioEndDateTime_Local);
               DateTime val12 = new DateTime(2010, 3, 4);
               mikeScenario_B.MikeScenarioStartExecutionDateTime_Local = val12;
               Assert.AreEqual(val12, mikeScenario_B.MikeScenarioStartExecutionDateTime_Local);
               double val13 = 87.9D;
               mikeScenario_B.MikeScenarioExecutionTime_min = val13;
               Assert.AreEqual(val13, mikeScenario_B.MikeScenarioExecutionTime_min);
               double val14 = 87.9D;
               mikeScenario_B.WindSpeed_km_h = val14;
               Assert.AreEqual(val14, mikeScenario_B.WindSpeed_km_h);
               double val15 = 87.9D;
               mikeScenario_B.WindDirection_deg = val15;
               Assert.AreEqual(val15, mikeScenario_B.WindDirection_deg);
               double val16 = 87.9D;
               mikeScenario_B.DecayFactor_per_day = val16;
               Assert.AreEqual(val16, mikeScenario_B.DecayFactor_per_day);
               bool val17 = true;
               mikeScenario_B.DecayIsConstant = val17;
               Assert.AreEqual(val17, mikeScenario_B.DecayIsConstant);
               double val18 = 87.9D;
               mikeScenario_B.DecayFactorAmplitude = val18;
               Assert.AreEqual(val18, mikeScenario_B.DecayFactorAmplitude);
               int val19 = 45;
               mikeScenario_B.ResultFrequency_min = val19;
               Assert.AreEqual(val19, mikeScenario_B.ResultFrequency_min);
               double val20 = 87.9D;
               mikeScenario_B.AmbientTemperature_C = val20;
               Assert.AreEqual(val20, mikeScenario_B.AmbientTemperature_C);
               double val21 = 87.9D;
               mikeScenario_B.AmbientSalinity_PSU = val21;
               Assert.AreEqual(val21, mikeScenario_B.AmbientSalinity_PSU);
               double val22 = 87.9D;
               mikeScenario_B.ManningNumber = val22;
               Assert.AreEqual(val22, mikeScenario_B.ManningNumber);
               int val23 = 45;
               mikeScenario_B.NumberOfElements = val23;
               Assert.AreEqual(val23, mikeScenario_B.NumberOfElements);
               int val24 = 45;
               mikeScenario_B.NumberOfTimeSteps = val24;
               Assert.AreEqual(val24, mikeScenario_B.NumberOfTimeSteps);
               int val25 = 45;
               mikeScenario_B.NumberOfSigmaLayers = val25;
               Assert.AreEqual(val25, mikeScenario_B.NumberOfSigmaLayers);
               int val26 = 45;
               mikeScenario_B.NumberOfZLayers = val26;
               Assert.AreEqual(val26, mikeScenario_B.NumberOfZLayers);
               int val27 = 45;
               mikeScenario_B.NumberOfHydroOutputParameters = val27;
               Assert.AreEqual(val27, mikeScenario_B.NumberOfHydroOutputParameters);
               int val28 = 45;
               mikeScenario_B.NumberOfTransOutputParameters = val28;
               Assert.AreEqual(val28, mikeScenario_B.NumberOfTransOutputParameters);
               int val29 = 45;
               mikeScenario_B.EstimatedHydroFileSize = val29;
               Assert.AreEqual(val29, mikeScenario_B.EstimatedHydroFileSize);
               int val30 = 45;
               mikeScenario_B.EstimatedTransFileSize = val30;
               Assert.AreEqual(val30, mikeScenario_B.EstimatedTransFileSize);
               DateTime val31 = new DateTime(2010, 3, 4);
               mikeScenario_B.LastUpdateDate_UTC = val31;
               Assert.AreEqual(val31, mikeScenario_B.LastUpdateDate_UTC);
               int val32 = 45;
               mikeScenario_B.LastUpdateContactTVItemID = val32;
               Assert.AreEqual(val32, mikeScenario_B.LastUpdateContactTVItemID);
               bool val33 = true;
               mikeScenario_B.HasErrors = val33;
               Assert.AreEqual(val33, mikeScenario_B.HasErrors);
               IEnumerable<ValidationResult> val102 = new List<ValidationResult>() { new ValidationResult("First Error Message") }.AsEnumerable();
               mikeScenario_B.ValidationResults = val102;
               Assert.AreEqual(val102, mikeScenario_B.ValidationResults);
        }
        #endregion Tests Functions public
    }
}
