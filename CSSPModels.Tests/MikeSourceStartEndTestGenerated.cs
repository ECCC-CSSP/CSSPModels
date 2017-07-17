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
    public partial class MikeSourceStartEndTest
    {
        [TestMethod]
        public void MikeSourceStartEnd_Properties_OK()
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
        public void MikeSourceStartEnd_Navigation_OK()
        {
            List<string> foreignNameList = new List<string>() { "MikeSource",  }.OrderBy(c => c).ToList();
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
        public void MikeSourceStartEnd_Has_ValidationResults_OK()
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
               Assert.IsNotNull(ModelsRes.MikeSourceStartEndMikeSource);
        }
    }
}
