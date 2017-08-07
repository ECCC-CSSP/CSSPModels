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
    public partial class MikeSourceStartEndTest : SetupData
    {
        [TestMethod]
        public void MikeSourceStartEnd_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "MikeSourceStartEndID", "MikeSourceID", "StartDateAndTime_Local", "EndDateAndTime_Local", "SourceFlowStart_m3_day", "SourceFlowEnd_m3_day", "SourcePollutionStart_MPN_100ml", "SourcePollutionEnd_MPN_100ml", "SourceTemperatureStart_C", "SourceTemperatureEnd_C", "SourceSalinityStart_PSU", "SourceSalinityEnd_PSU", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(CSSPModels.MikeSourceStartEnd).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(MikeSourceStartEnd).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void MikeSourceStartEnd_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(MikeSourceStartEnd).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(MikeSourceStartEnd).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void MikeSourceStartEnd_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(MikeSourceStartEnd).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void MikeSourceStartEnd_Every_Property_Has_A_Resource_OK()
        {
               Assert.IsNotNull(ModelsRes.MikeSourceStartEndMikeSourceStartEndID);
               Assert.IsNotNull(ModelsRes.MikeSourceStartEndMikeSourceID);
               Assert.IsNotNull(ModelsRes.MikeSourceStartEndStartDateAndTime_Local);
               Assert.IsNotNull(ModelsRes.MikeSourceStartEndEndDateAndTime_Local);
               Assert.IsNotNull(ModelsRes.MikeSourceStartEndSourceFlowStart_m3_day);
               Assert.IsNotNull(ModelsRes.MikeSourceStartEndSourceFlowEnd_m3_day);
               Assert.IsNotNull(ModelsRes.MikeSourceStartEndSourcePollutionStart_MPN_100ml);
               Assert.IsNotNull(ModelsRes.MikeSourceStartEndSourcePollutionEnd_MPN_100ml);
               Assert.IsNotNull(ModelsRes.MikeSourceStartEndSourceTemperatureStart_C);
               Assert.IsNotNull(ModelsRes.MikeSourceStartEndSourceTemperatureEnd_C);
               Assert.IsNotNull(ModelsRes.MikeSourceStartEndSourceSalinityStart_PSU);
               Assert.IsNotNull(ModelsRes.MikeSourceStartEndSourceSalinityEnd_PSU);
               Assert.IsNotNull(ModelsRes.MikeSourceStartEndLastUpdateDate_UTC);
               Assert.IsNotNull(ModelsRes.MikeSourceStartEndLastUpdateContactTVItemID);
        }
        [TestMethod]
        public void MikeSourceStartEnd_Every_Property_Has_Get_Set_Test()
        {
               int val1 = 45;
               mikeSourceStartEnd.MikeSourceStartEndID = val1;
               Assert.AreEqual(val1, mikeSourceStartEnd.MikeSourceStartEndID);
               int val2 = 45;
               mikeSourceStartEnd.MikeSourceID = val2;
               Assert.AreEqual(val2, mikeSourceStartEnd.MikeSourceID);
               DateTime val3 = new DateTime(2010, 3, 4);
               mikeSourceStartEnd.StartDateAndTime_Local = val3;
               Assert.AreEqual(val3, mikeSourceStartEnd.StartDateAndTime_Local);
               DateTime val4 = new DateTime(2010, 3, 4);
               mikeSourceStartEnd.EndDateAndTime_Local = val4;
               Assert.AreEqual(val4, mikeSourceStartEnd.EndDateAndTime_Local);
               double val5 = 87.9D;
               mikeSourceStartEnd.SourceFlowStart_m3_day = val5;
               Assert.AreEqual(val5, mikeSourceStartEnd.SourceFlowStart_m3_day);
               double val6 = 87.9D;
               mikeSourceStartEnd.SourceFlowEnd_m3_day = val6;
               Assert.AreEqual(val6, mikeSourceStartEnd.SourceFlowEnd_m3_day);
               int val7 = 45;
               mikeSourceStartEnd.SourcePollutionStart_MPN_100ml = val7;
               Assert.AreEqual(val7, mikeSourceStartEnd.SourcePollutionStart_MPN_100ml);
               int val8 = 45;
               mikeSourceStartEnd.SourcePollutionEnd_MPN_100ml = val8;
               Assert.AreEqual(val8, mikeSourceStartEnd.SourcePollutionEnd_MPN_100ml);
               double val9 = 87.9D;
               mikeSourceStartEnd.SourceTemperatureStart_C = val9;
               Assert.AreEqual(val9, mikeSourceStartEnd.SourceTemperatureStart_C);
               double val10 = 87.9D;
               mikeSourceStartEnd.SourceTemperatureEnd_C = val10;
               Assert.AreEqual(val10, mikeSourceStartEnd.SourceTemperatureEnd_C);
               double val11 = 87.9D;
               mikeSourceStartEnd.SourceSalinityStart_PSU = val11;
               Assert.AreEqual(val11, mikeSourceStartEnd.SourceSalinityStart_PSU);
               double val12 = 87.9D;
               mikeSourceStartEnd.SourceSalinityEnd_PSU = val12;
               Assert.AreEqual(val12, mikeSourceStartEnd.SourceSalinityEnd_PSU);
               DateTime val13 = new DateTime(2010, 3, 4);
               mikeSourceStartEnd.LastUpdateDate_UTC = val13;
               Assert.AreEqual(val13, mikeSourceStartEnd.LastUpdateDate_UTC);
               int val14 = 45;
               mikeSourceStartEnd.LastUpdateContactTVItemID = val14;
               Assert.AreEqual(val14, mikeSourceStartEnd.LastUpdateContactTVItemID);
               IEnumerable<ValidationResult> val45 = new List<ValidationResult>().AsEnumerable();
               mikeSourceStartEnd.ValidationResults = val45;
               Assert.AreEqual(val45, mikeSourceStartEnd.ValidationResults);
        }
    }
}
