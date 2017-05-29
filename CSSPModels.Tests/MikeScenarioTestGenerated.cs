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
    public partial class MikeScenarioTest
    {
        [TestMethod]
        public void MikeScenario_Properties_OK()
        {
            List<string> propNameList = new List<string>() { "MikeScenarioID", "MikeScenarioTVItemID", "ParentMikeScenarioID", "ScenarioStatus", "ErrorInfo", "MikeScenarioStartDateTime_Local", "MikeScenarioEndDateTime_Local", "MikeScenarioStartExecutionDateTime_Local", "MikeScenarioExecutionTime_min", "WindSpeed_km_h", "WindDirection_deg", "DecayFactor_per_day", "DecayIsConstant", "DecayFactorAmplitude", "ResultFrequency_min", "AmbientTemperature_C", "AmbientSalinity_PSU", "ManningNumber", "UseWebTide", "NumberOfElements", "NumberOfTimeSteps", "NumberOfSigmaLayers", "NumberOfZlayers", "NumberOfHydroOutputParameters", "NumberOfTransOutputParameters", "EstimatedHydroFileSize", "EstimatedTransFileSize", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (IProperty propertyType in entityType.GetProperties().OrderBy(c => c.Name))
            {
                Assert.AreEqual(propNameList[index], propertyType.Name);
                index += 1;
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
        public void MikeScenario_Navigation_OK()
        {
            List<string> foreignNameList = new List<string>() { "MikeScenarioTVItem",  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (string foreignName in (from c in entityType.GetForeignKeys() orderby c.DependentToPrincipal.Name select c.DependentToPrincipal.Name))
            {
                Assert.AreEqual(foreignNameList[index], foreignName);
                index += 1;
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
        public void MikeScenario_Has_ValidationResults_OK()
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
               Assert.IsNotNull(ModelsRes.MikeScenarioUseWebTide);
               Assert.IsNotNull(ModelsRes.MikeScenarioNumberOfElements);
               Assert.IsNotNull(ModelsRes.MikeScenarioNumberOfTimeSteps);
               Assert.IsNotNull(ModelsRes.MikeScenarioNumberOfSigmaLayers);
               Assert.IsNotNull(ModelsRes.MikeScenarioNumberOfZlayers);
               Assert.IsNotNull(ModelsRes.MikeScenarioNumberOfHydroOutputParameters);
               Assert.IsNotNull(ModelsRes.MikeScenarioNumberOfTransOutputParameters);
               Assert.IsNotNull(ModelsRes.MikeScenarioEstimatedHydroFileSize);
               Assert.IsNotNull(ModelsRes.MikeScenarioEstimatedTransFileSize);
               Assert.IsNotNull(ModelsRes.MikeScenarioLastUpdateDate_UTC);
               Assert.IsNotNull(ModelsRes.MikeScenarioLastUpdateContactTVItemID);
               Assert.IsNotNull(ModelsRes.MikeScenarioMikeScenarioTVItem);
        }
    }
}
