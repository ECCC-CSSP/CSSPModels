/*
 * Auto generated from the CSSPModelsGenerateCode.proj
 *
 * Do not edit this file.
 *
 * Last generated by Charles LeBlanc
 *
 */ 
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
    [TestClass]
    public partial class MWQMAnalysisReportParameterTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private MWQMAnalysisReportParameter mWQMAnalysisReportParameter { get; set; }
        #endregion Properties

        #region Constructors
        public MWQMAnalysisReportParameterTest()
        {
            mWQMAnalysisReportParameter = new MWQMAnalysisReportParameter();
        }
        #endregion Constructors

        #region Tests Functions public
        [TestMethod]
        public void MWQMAnalysisReportParameter_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "MWQMAnalysisReportParameterID", "SubsectorTVItemID", "AnalysisName", "AnalysisReportYear", "StartDate", "EndDate", "AnalysisCalculationType", "NumberOfRuns", "FullYear", "SalinityHighlightDeviationFromAverage", "ShortRangeNumberOfDays", "MidRangeNumberOfDays", "DryLimit24h", "DryLimit48h", "DryLimit72h", "DryLimit96h", "WetLimit24h", "WetLimit48h", "WetLimit72h", "WetLimit96h", "RunsToOmit", "ShowDataTypes", "ExcelTVFileTVItemID", "Command", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "MWQMAnalysisReportParameterWeb", "MWQMAnalysisReportParameterReport", "HasErrors",  }.OrderBy(c => c).ToList();

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
               Assert.IsNotNull(CSSPModelsRes.MWQMAnalysisReportParameterMWQMAnalysisReportParameterID);
               Assert.IsNotNull(CSSPModelsRes.MWQMAnalysisReportParameterSubsectorTVItemID);
               Assert.IsNotNull(CSSPModelsRes.MWQMAnalysisReportParameterAnalysisName);
               Assert.IsNotNull(CSSPModelsRes.MWQMAnalysisReportParameterAnalysisReportYear);
               Assert.IsNotNull(CSSPModelsRes.MWQMAnalysisReportParameterStartDate);
               Assert.IsNotNull(CSSPModelsRes.MWQMAnalysisReportParameterEndDate);
               Assert.IsNotNull(CSSPModelsRes.MWQMAnalysisReportParameterAnalysisCalculationType);
               Assert.IsNotNull(CSSPModelsRes.MWQMAnalysisReportParameterNumberOfRuns);
               Assert.IsNotNull(CSSPModelsRes.MWQMAnalysisReportParameterFullYear);
               Assert.IsNotNull(CSSPModelsRes.MWQMAnalysisReportParameterSalinityHighlightDeviationFromAverage);
               Assert.IsNotNull(CSSPModelsRes.MWQMAnalysisReportParameterShortRangeNumberOfDays);
               Assert.IsNotNull(CSSPModelsRes.MWQMAnalysisReportParameterMidRangeNumberOfDays);
               Assert.IsNotNull(CSSPModelsRes.MWQMAnalysisReportParameterDryLimit24h);
               Assert.IsNotNull(CSSPModelsRes.MWQMAnalysisReportParameterDryLimit48h);
               Assert.IsNotNull(CSSPModelsRes.MWQMAnalysisReportParameterDryLimit72h);
               Assert.IsNotNull(CSSPModelsRes.MWQMAnalysisReportParameterDryLimit96h);
               Assert.IsNotNull(CSSPModelsRes.MWQMAnalysisReportParameterWetLimit24h);
               Assert.IsNotNull(CSSPModelsRes.MWQMAnalysisReportParameterWetLimit48h);
               Assert.IsNotNull(CSSPModelsRes.MWQMAnalysisReportParameterWetLimit72h);
               Assert.IsNotNull(CSSPModelsRes.MWQMAnalysisReportParameterWetLimit96h);
               Assert.IsNotNull(CSSPModelsRes.MWQMAnalysisReportParameterRunsToOmit);
               Assert.IsNotNull(CSSPModelsRes.MWQMAnalysisReportParameterShowDataTypes);
               Assert.IsNotNull(CSSPModelsRes.MWQMAnalysisReportParameterExcelTVFileTVItemID);
               Assert.IsNotNull(CSSPModelsRes.MWQMAnalysisReportParameterCommand);
               Assert.IsNotNull(CSSPModelsRes.MWQMAnalysisReportParameterLastUpdateDate_UTC);
               Assert.IsNotNull(CSSPModelsRes.MWQMAnalysisReportParameterLastUpdateContactTVItemID);
               Assert.IsNotNull(CSSPModelsRes.MWQMAnalysisReportParameterHasErrors);
        }
        [TestMethod]
        public void MWQMAnalysisReportParameter_Every_Property_Has_Get_Set_Test()
        {
               int val1 = 45;
               mWQMAnalysisReportParameter.MWQMAnalysisReportParameterID = val1;
               Assert.AreEqual(val1, mWQMAnalysisReportParameter.MWQMAnalysisReportParameterID);
               int val2 = 45;
               mWQMAnalysisReportParameter.SubsectorTVItemID = val2;
               Assert.AreEqual(val2, mWQMAnalysisReportParameter.SubsectorTVItemID);
               string val3 = "Some text";
               mWQMAnalysisReportParameter.AnalysisName = val3;
               Assert.AreEqual(val3, mWQMAnalysisReportParameter.AnalysisName);
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
               string val21 = "Some text";
               mWQMAnalysisReportParameter.RunsToOmit = val21;
               Assert.AreEqual(val21, mWQMAnalysisReportParameter.RunsToOmit);
               string val22 = "Some text";
               mWQMAnalysisReportParameter.ShowDataTypes = val22;
               Assert.AreEqual(val22, mWQMAnalysisReportParameter.ShowDataTypes);
               int val23 = 45;
               mWQMAnalysisReportParameter.ExcelTVFileTVItemID = val23;
               Assert.AreEqual(val23, mWQMAnalysisReportParameter.ExcelTVFileTVItemID);
               AnalysisReportExportCommandEnum val24 = (AnalysisReportExportCommandEnum)3;
               mWQMAnalysisReportParameter.Command = val24;
               Assert.AreEqual(val24, mWQMAnalysisReportParameter.Command);
               DateTime val25 = new DateTime(2010, 3, 4);
               mWQMAnalysisReportParameter.LastUpdateDate_UTC = val25;
               Assert.AreEqual(val25, mWQMAnalysisReportParameter.LastUpdateDate_UTC);
               int val26 = 45;
               mWQMAnalysisReportParameter.LastUpdateContactTVItemID = val26;
               Assert.AreEqual(val26, mWQMAnalysisReportParameter.LastUpdateContactTVItemID);
               bool val27 = true;
               mWQMAnalysisReportParameter.HasErrors = val27;
               Assert.AreEqual(val27, mWQMAnalysisReportParameter.HasErrors);
               IEnumerable<ValidationResult> val88 = new List<ValidationResult>().AsEnumerable();
               mWQMAnalysisReportParameter.ValidationResults = val88;
               Assert.AreEqual(val88, mWQMAnalysisReportParameter.ValidationResults);
        }
        #endregion Tests Functions public
    }
}
