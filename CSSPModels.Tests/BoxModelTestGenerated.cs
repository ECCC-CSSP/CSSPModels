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
    public partial class BoxModelTest : SetupData
    {
        [TestMethod]
        public void BoxModel_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "BoxModelID", "InfrastructureTVItemID", "Flow_m3_day", "Depth_m", "Temperature_C", "Dilution", "DecayRate_per_day", "FCUntreated_MPN_100ml", "FCPreDisinfection_MPN_100ml", "Concentration_MPN_100ml", "T90_hour", "FlowDuration_hour", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "InfrastructureTVText", "LastUpdateContactTVText", "HasErrors",  }.OrderBy(c => c).ToList();

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
        public void BoxModel_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

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
        public void BoxModel_Has_ValidationResults_Test()
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
               Assert.IsNotNull(ModelsRes.BoxModelInfrastructureTVText);
               Assert.IsNotNull(ModelsRes.BoxModelLastUpdateContactTVText);
               Assert.IsNotNull(ModelsRes.BoxModelHasErrors);
        }
        [TestMethod]
        public void BoxModel_Every_Property_Has_Get_Set_Test()
        {
               int val1 = 45;
               boxModel.BoxModelID = val1;
               Assert.AreEqual(val1, boxModel.BoxModelID);
               int val2 = 45;
               boxModel.InfrastructureTVItemID = val2;
               Assert.AreEqual(val2, boxModel.InfrastructureTVItemID);
               double val3 = 87.9D;
               boxModel.Flow_m3_day = val3;
               Assert.AreEqual(val3, boxModel.Flow_m3_day);
               double val4 = 87.9D;
               boxModel.Depth_m = val4;
               Assert.AreEqual(val4, boxModel.Depth_m);
               double val5 = 87.9D;
               boxModel.Temperature_C = val5;
               Assert.AreEqual(val5, boxModel.Temperature_C);
               int val6 = 45;
               boxModel.Dilution = val6;
               Assert.AreEqual(val6, boxModel.Dilution);
               double val7 = 87.9D;
               boxModel.DecayRate_per_day = val7;
               Assert.AreEqual(val7, boxModel.DecayRate_per_day);
               int val8 = 45;
               boxModel.FCUntreated_MPN_100ml = val8;
               Assert.AreEqual(val8, boxModel.FCUntreated_MPN_100ml);
               int val9 = 45;
               boxModel.FCPreDisinfection_MPN_100ml = val9;
               Assert.AreEqual(val9, boxModel.FCPreDisinfection_MPN_100ml);
               int val10 = 45;
               boxModel.Concentration_MPN_100ml = val10;
               Assert.AreEqual(val10, boxModel.Concentration_MPN_100ml);
               double val11 = 87.9D;
               boxModel.T90_hour = val11;
               Assert.AreEqual(val11, boxModel.T90_hour);
               double val12 = 87.9D;
               boxModel.FlowDuration_hour = val12;
               Assert.AreEqual(val12, boxModel.FlowDuration_hour);
               DateTime val13 = new DateTime(2010, 3, 4);
               boxModel.LastUpdateDate_UTC = val13;
               Assert.AreEqual(val13, boxModel.LastUpdateDate_UTC);
               int val14 = 45;
               boxModel.LastUpdateContactTVItemID = val14;
               Assert.AreEqual(val14, boxModel.LastUpdateContactTVItemID);
               string val15 = "Some text";
               boxModel.InfrastructureTVText = val15;
               Assert.AreEqual(val15, boxModel.InfrastructureTVText);
               string val16 = "Some text";
               boxModel.LastUpdateContactTVText = val16;
               Assert.AreEqual(val16, boxModel.LastUpdateContactTVText);
               bool val17 = true;
               boxModel.HasErrors = val17;
               Assert.AreEqual(val17, boxModel.HasErrors);
               IEnumerable<ValidationResult> val54 = new List<ValidationResult>().AsEnumerable();
               boxModel.ValidationResults = val54;
               Assert.AreEqual(val54, boxModel.ValidationResults);
        }
    }
}
