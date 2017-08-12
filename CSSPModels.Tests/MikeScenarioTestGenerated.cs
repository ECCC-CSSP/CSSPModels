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
    public partial class MikeScenarioTest : SetupData
    {
        [TestMethod]
        public void MikeScenario_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "MikeScenarioID", "MikeScenarioTVItemID", "ParentMikeScenarioID", "ScenarioStatus", "ErrorInfo", "MikeScenarioStartDateTime_Local", "MikeScenarioEndDateTime_Local", "MikeScenarioStartExecutionDateTime_Local", "MikeScenarioExecutionTime_min", "WindSpeed_km_h", "WindDirection_deg", "DecayFactor_per_day", "DecayIsConstant", "DecayFactorAmplitude", "ResultFrequency_min", "AmbientTemperature_C", "AmbientSalinity_PSU", "ManningNumber", "NumberOfElements", "NumberOfTimeSteps", "NumberOfSigmaLayers", "NumberOfZLayers", "NumberOfHydroOutputParameters", "NumberOfTransOutputParameters", "EstimatedHydroFileSize", "EstimatedTransFileSize", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "MikeScenarioTVText", "LastUpdateContactTVText", "ScenarioStatusText", "HasErrors",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(CSSPModels.MikeScenario).GetProperties().OrderBy(c => c.Name))
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
        public void MikeScenario_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(MikeScenario).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void MikeScenario_Every_Property_Has_A_Resource_OK()
        {
               Assert.IsNotNull(ModelsRes.MikeScenarioMikeScenarioID);
               Assert.IsNotNull(ModelsRes.MikeScenarioMikeScenarioTVItemID);
               Assert.IsNotNull(ModelsRes.MikeScenarioParentMikeScenarioID);
               Assert.IsNotNull(ModelsRes.MikeScenarioScenarioStatus);
               Assert.IsNotNull(ModelsRes.MikeScenarioErrorInfo);
               Assert.IsNotNull(ModelsRes.MikeScenarioMikeScenarioStartDateTime_Local);
               Assert.IsNotNull(ModelsRes.MikeScenarioMikeScenarioEndDateTime_Local);
               Assert.IsNotNull(ModelsRes.MikeScenarioMikeScenarioStartExecutionDateTime_Local);
               Assert.IsNotNull(ModelsRes.MikeScenarioMikeScenarioExecutionTime_min);
               Assert.IsNotNull(ModelsRes.MikeScenarioWindSpeed_km_h);
               Assert.IsNotNull(ModelsRes.MikeScenarioWindDirection_deg);
               Assert.IsNotNull(ModelsRes.MikeScenarioDecayFactor_per_day);
               Assert.IsNotNull(ModelsRes.MikeScenarioDecayIsConstant);
               Assert.IsNotNull(ModelsRes.MikeScenarioDecayFactorAmplitude);
               Assert.IsNotNull(ModelsRes.MikeScenarioResultFrequency_min);
               Assert.IsNotNull(ModelsRes.MikeScenarioAmbientTemperature_C);
               Assert.IsNotNull(ModelsRes.MikeScenarioAmbientSalinity_PSU);
               Assert.IsNotNull(ModelsRes.MikeScenarioManningNumber);
               Assert.IsNotNull(ModelsRes.MikeScenarioNumberOfElements);
               Assert.IsNotNull(ModelsRes.MikeScenarioNumberOfTimeSteps);
               Assert.IsNotNull(ModelsRes.MikeScenarioNumberOfSigmaLayers);
               Assert.IsNotNull(ModelsRes.MikeScenarioNumberOfZLayers);
               Assert.IsNotNull(ModelsRes.MikeScenarioNumberOfHydroOutputParameters);
               Assert.IsNotNull(ModelsRes.MikeScenarioNumberOfTransOutputParameters);
               Assert.IsNotNull(ModelsRes.MikeScenarioEstimatedHydroFileSize);
               Assert.IsNotNull(ModelsRes.MikeScenarioEstimatedTransFileSize);
               Assert.IsNotNull(ModelsRes.MikeScenarioLastUpdateDate_UTC);
               Assert.IsNotNull(ModelsRes.MikeScenarioLastUpdateContactTVItemID);
               Assert.IsNotNull(ModelsRes.MikeScenarioMikeScenarioTVText);
               Assert.IsNotNull(ModelsRes.MikeScenarioLastUpdateContactTVText);
               Assert.IsNotNull(ModelsRes.MikeScenarioScenarioStatusText);
               Assert.IsNotNull(ModelsRes.MikeScenarioHasErrors);
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
               string val29 = "Some text";
               mikeScenario.MikeScenarioTVText = val29;
               Assert.AreEqual(val29, mikeScenario.MikeScenarioTVText);
               string val30 = "Some text";
               mikeScenario.LastUpdateContactTVText = val30;
               Assert.AreEqual(val30, mikeScenario.LastUpdateContactTVText);
               string val31 = "Some text";
               mikeScenario.ScenarioStatusText = val31;
               Assert.AreEqual(val31, mikeScenario.ScenarioStatusText);
               bool val32 = true;
               mikeScenario.HasErrors = val32;
               Assert.AreEqual(val32, mikeScenario.HasErrors);
               IEnumerable<ValidationResult> val99 = new List<ValidationResult>().AsEnumerable();
               mikeScenario.ValidationResults = val99;
               Assert.AreEqual(val99, mikeScenario.ValidationResults);
        }
    }
}
