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
    public partial class VPResultTest : SetupData
    {
        [TestMethod]
        public void VPResult_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "VPResultID", "VPScenarioID", "Ordinal", "Concentration_MPN_100ml", "Dilution", "FarFieldWidth_m", "DispersionDistance_m", "TravelTime_hour", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(CSSPModels.VPResult).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(VPResult).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void VPResult_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(VPResult).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(VPResult).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void VPResult_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(VPResult).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void VPResult_Every_Property_Has_A_Resource_OK()
        {
               Assert.IsNotNull(ModelsRes.VPResultVPResultID);
               Assert.IsNotNull(ModelsRes.VPResultVPScenarioID);
               Assert.IsNotNull(ModelsRes.VPResultOrdinal);
               Assert.IsNotNull(ModelsRes.VPResultConcentration_MPN_100ml);
               Assert.IsNotNull(ModelsRes.VPResultDilution);
               Assert.IsNotNull(ModelsRes.VPResultFarFieldWidth_m);
               Assert.IsNotNull(ModelsRes.VPResultDispersionDistance_m);
               Assert.IsNotNull(ModelsRes.VPResultTravelTime_hour);
               Assert.IsNotNull(ModelsRes.VPResultLastUpdateDate_UTC);
               Assert.IsNotNull(ModelsRes.VPResultLastUpdateContactTVItemID);
        }
        [TestMethod]
        public void VPResult_Every_Property_Has_Get_Set_Test()
        {
               int val1 = 45;
               vPResult.VPResultID = val1;
               Assert.AreEqual(val1, vPResult.VPResultID);
               int val2 = 45;
               vPResult.VPScenarioID = val2;
               Assert.AreEqual(val2, vPResult.VPScenarioID);
               int val3 = 45;
               vPResult.Ordinal = val3;
               Assert.AreEqual(val3, vPResult.Ordinal);
               int val4 = 45;
               vPResult.Concentration_MPN_100ml = val4;
               Assert.AreEqual(val4, vPResult.Concentration_MPN_100ml);
               double val5 = 87.9D;
               vPResult.Dilution = val5;
               Assert.AreEqual(val5, vPResult.Dilution);
               double val6 = 87.9D;
               vPResult.FarFieldWidth_m = val6;
               Assert.AreEqual(val6, vPResult.FarFieldWidth_m);
               double val7 = 87.9D;
               vPResult.DispersionDistance_m = val7;
               Assert.AreEqual(val7, vPResult.DispersionDistance_m);
               double val8 = 87.9D;
               vPResult.TravelTime_hour = val8;
               Assert.AreEqual(val8, vPResult.TravelTime_hour);
               DateTime val9 = new DateTime(2010, 3, 4);
               vPResult.LastUpdateDate_UTC = val9;
               Assert.AreEqual(val9, vPResult.LastUpdateDate_UTC);
               int val10 = 45;
               vPResult.LastUpdateContactTVItemID = val10;
               Assert.AreEqual(val10, vPResult.LastUpdateContactTVItemID);
               IEnumerable<ValidationResult> val33 = new List<ValidationResult>().AsEnumerable();
               vPResult.ValidationResults = val33;
               Assert.AreEqual(val33, vPResult.ValidationResults);
        }
    }
}
