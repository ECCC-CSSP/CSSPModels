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
    public partial class MWQMAnalysisReportParameterTest : SetupData
    {
        [TestMethod]
        public void MWQMAnalysisReportParameter_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "MWQMAnalysisReportParameterID", "MWQMSubsectorTVItemID", "Name", "AnalysisReportYear", "StartDate", "EndDate", "AnalysisCalculationType", "NumberOfRuns", "FullYear", "SalinityHighlightDeviationFromAverage", "ShortRangeNumberOfDays", "MidRangeNumberOfDays", "DryLimit24h", "DryLimit48h", "DryLimit72h", "DryLimit96h", "WetLimit24h", "WetLimit48h", "WetLimit72h", "WetLimit96h", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "LastUpdateContactTVText", "HasErrors",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(CSSPModels.MWQMAnalysisReportParameter).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(MWQMAnalysisReportParameter).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void MWQMAnalysisReportParameter_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(MWQMAnalysisReportParameter).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(MWQMAnalysisReportParameter).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void MWQMAnalysisReportParameter_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(MWQMAnalysisReportParameter).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void MWQMAnalysisReportParameter_Every_Property_Has_A_Resource_OK()
        {
               Assert.IsNotNull(ModelsRes.MWQMAnalysisReportParameterMWQMAnalysisReportParameterID);
               Assert.IsNotNull(ModelsRes.MWQMAnalysisReportParameterMWQMSubsectorTVItemID);
               Assert.IsNotNull(ModelsRes.MWQMAnalysisReportParameterName);
               Assert.IsNotNull(ModelsRes.MWQMAnalysisReportParameterAnalysisReportYear);
               Assert.IsNotNull(ModelsRes.MWQMAnalysisReportParameterStartDate);
               Assert.IsNotNull(ModelsRes.MWQMAnalysisReportParameterEndDate);
               Assert.IsNotNull(ModelsRes.MWQMAnalysisReportParameterAnalysisCalculationType);
               Assert.IsNotNull(ModelsRes.MWQMAnalysisReportParameterNumberOfRuns);
               Assert.IsNotNull(ModelsRes.MWQMAnalysisReportParameterFullYear);
               Assert.IsNotNull(ModelsRes.MWQMAnalysisReportParameterSalinityHighlightDeviationFromAverage);
               Assert.IsNotNull(ModelsRes.MWQMAnalysisReportParameterShortRangeNumberOfDays);
               Assert.IsNotNull(ModelsRes.MWQMAnalysisReportParameterMidRangeNumberOfDays);
               Assert.IsNotNull(ModelsRes.MWQMAnalysisReportParameterDryLimit24h);
               Assert.IsNotNull(ModelsRes.MWQMAnalysisReportParameterDryLimit48h);
               Assert.IsNotNull(ModelsRes.MWQMAnalysisReportParameterDryLimit72h);
               Assert.IsNotNull(ModelsRes.MWQMAnalysisReportParameterDryLimit96h);
               Assert.IsNotNull(ModelsRes.MWQMAnalysisReportParameterWetLimit24h);
               Assert.IsNotNull(ModelsRes.MWQMAnalysisReportParameterWetLimit48h);
               Assert.IsNotNull(ModelsRes.MWQMAnalysisReportParameterWetLimit72h);
               Assert.IsNotNull(ModelsRes.MWQMAnalysisReportParameterWetLimit96h);
               Assert.IsNotNull(ModelsRes.MWQMAnalysisReportParameterLastUpdateDate_UTC);
               Assert.IsNotNull(ModelsRes.MWQMAnalysisReportParameterLastUpdateContactTVItemID);
               Assert.IsNotNull(ModelsRes.MWQMAnalysisReportParameterLastUpdateContactTVText);
               Assert.IsNotNull(ModelsRes.MWQMAnalysisReportParameterHasErrors);
        }
        [TestMethod]
        public void MWQMAnalysisReportParameter_Every_Property_Has_Get_Set_Test()
        {
               int val1 = 45;
               mWQMAnalysisReportParameter.MWQMAnalysisReportParameterID = val1;
               Assert.AreEqual(val1, mWQMAnalysisReportParameter.MWQMAnalysisReportParameterID);
               int val2 = 45;
               mWQMAnalysisReportParameter.MWQMSubsectorTVItemID = val2;
               Assert.AreEqual(val2, mWQMAnalysisReportParameter.MWQMSubsectorTVItemID);
               string val3 = "Some text";
               mWQMAnalysisReportParameter.Name = val3;
               Assert.AreEqual(val3, mWQMAnalysisReportParameter.Name);
               int val4 = 45;
               mWQMAnalysisReportParameter.AnalysisReportYear = val4;
               Assert.AreEqual(val4, mWQMAnalysisReportParameter.AnalysisReportYear);
               DateTime val5 = new DateTime(2010, 3, 4);
               mWQMAnalysisReportParameter.StartDate = val5;
               Assert.AreEqual(val5, mWQMAnalysisReportParameter.StartDate);
               DateTime val6 = new DateTime(2010, 3, 4);
               mWQMAnalysisReportParameter.EndDate = val6;
               Assert.AreEqual(val6, mWQMAnalysisReportParameter.EndDate);
               AnalysisCalculationTypeEnum val7 = (AnalysisCalculationTypeEnum)3;
               mWQMAnalysisReportParameter.AnalysisCalculationType = val7;
               Assert.AreEqual(val7, mWQMAnalysisReportParameter.AnalysisCalculationType);
               int val8 = 45;
               mWQMAnalysisReportParameter.NumberOfRuns = val8;
               Assert.AreEqual(val8, mWQMAnalysisReportParameter.NumberOfRuns);
               bool val9 = true;
               mWQMAnalysisReportParameter.FullYear = val9;
               Assert.AreEqual(val9, mWQMAnalysisReportParameter.FullYear);
               double val10 = 87.9D;
               mWQMAnalysisReportParameter.SalinityHighlightDeviationFromAverage = val10;
               Assert.AreEqual(val10, mWQMAnalysisReportParameter.SalinityHighlightDeviationFromAverage);
               int val11 = 45;
               mWQMAnalysisReportParameter.ShortRangeNumberOfDays = val11;
               Assert.AreEqual(val11, mWQMAnalysisReportParameter.ShortRangeNumberOfDays);
               int val12 = 45;
               mWQMAnalysisReportParameter.MidRangeNumberOfDays = val12;
               Assert.AreEqual(val12, mWQMAnalysisReportParameter.MidRangeNumberOfDays);
               int val13 = 45;
               mWQMAnalysisReportParameter.DryLimit24h = val13;
               Assert.AreEqual(val13, mWQMAnalysisReportParameter.DryLimit24h);
               int val14 = 45;
               mWQMAnalysisReportParameter.DryLimit48h = val14;
               Assert.AreEqual(val14, mWQMAnalysisReportParameter.DryLimit48h);
               int val15 = 45;
               mWQMAnalysisReportParameter.DryLimit72h = val15;
               Assert.AreEqual(val15, mWQMAnalysisReportParameter.DryLimit72h);
               int val16 = 45;
               mWQMAnalysisReportParameter.DryLimit96h = val16;
               Assert.AreEqual(val16, mWQMAnalysisReportParameter.DryLimit96h);
               int val17 = 45;
               mWQMAnalysisReportParameter.WetLimit24h = val17;
               Assert.AreEqual(val17, mWQMAnalysisReportParameter.WetLimit24h);
               int val18 = 45;
               mWQMAnalysisReportParameter.WetLimit48h = val18;
               Assert.AreEqual(val18, mWQMAnalysisReportParameter.WetLimit48h);
               int val19 = 45;
               mWQMAnalysisReportParameter.WetLimit72h = val19;
               Assert.AreEqual(val19, mWQMAnalysisReportParameter.WetLimit72h);
               int val20 = 45;
               mWQMAnalysisReportParameter.WetLimit96h = val20;
               Assert.AreEqual(val20, mWQMAnalysisReportParameter.WetLimit96h);
               DateTime val21 = new DateTime(2010, 3, 4);
               mWQMAnalysisReportParameter.LastUpdateDate_UTC = val21;
               Assert.AreEqual(val21, mWQMAnalysisReportParameter.LastUpdateDate_UTC);
               int val22 = 45;
               mWQMAnalysisReportParameter.LastUpdateContactTVItemID = val22;
               Assert.AreEqual(val22, mWQMAnalysisReportParameter.LastUpdateContactTVItemID);
               string val23 = "Some text";
               mWQMAnalysisReportParameter.LastUpdateContactTVText = val23;
               Assert.AreEqual(val23, mWQMAnalysisReportParameter.LastUpdateContactTVText);
               bool val24 = true;
               mWQMAnalysisReportParameter.HasErrors = val24;
               Assert.AreEqual(val24, mWQMAnalysisReportParameter.HasErrors);
               IEnumerable<ValidationResult> val75 = new List<ValidationResult>().AsEnumerable();
               mWQMAnalysisReportParameter.ValidationResults = val75;
               Assert.AreEqual(val75, mWQMAnalysisReportParameter.ValidationResults);
        }
    }
}
