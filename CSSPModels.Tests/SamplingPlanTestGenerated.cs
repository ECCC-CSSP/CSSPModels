/*
 * Auto generated from the CSSPCodeWriter.proj by clicking on the [[ModelClassName]TestGenerated.cs] button
 *
 * Do not edit this file.
 *
 * Last generated on 2018 August 01 05:00
 * by leblancc on WMON01DTCHLEBL2 machine
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
    public partial class SamplingPlanTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private SamplingPlan samplingPlan { get; set; }
        #endregion Properties

        #region Constructors
        public SamplingPlanTest()
        {
            samplingPlan = new SamplingPlan();
        }
        #endregion Constructors

        #region Tests Functions public
        [TestMethod]
        public void SamplingPlan_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "SamplingPlanID", "IsActive", "SamplingPlanName", "ForGroupName", "SampleType", "SamplingPlanType", "LabSheetType", "ProvinceTVItemID", "CreatorTVItemID", "Year", "AccessCode", "DailyDuplicatePrecisionCriteria", "IntertechDuplicatePrecisionCriteria", "IncludeLaboratoryQAQC", "ApprovalCode", "SamplingPlanFileTVItemID", "AnalyzeMethodDefault", "SampleMatrixDefault", "LaboratoryDefault", "BackupDirectory", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "SamplingPlanWeb", "SamplingPlanReport", "HasErrors",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(CSSPModels.SamplingPlan).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(SamplingPlan).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void SamplingPlan_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(SamplingPlan).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(SamplingPlan).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void SamplingPlan_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(SamplingPlan).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void SamplingPlan_Every_Property_Has_A_Resource_OK()
        {
               Assert.IsNotNull(CSSPModelsRes.SamplingPlanSamplingPlanID);
               Assert.IsNotNull(CSSPModelsRes.SamplingPlanIsActive);
               Assert.IsNotNull(CSSPModelsRes.SamplingPlanSamplingPlanName);
               Assert.IsNotNull(CSSPModelsRes.SamplingPlanForGroupName);
               Assert.IsNotNull(CSSPModelsRes.SamplingPlanSampleType);
               Assert.IsNotNull(CSSPModelsRes.SamplingPlanSamplingPlanType);
               Assert.IsNotNull(CSSPModelsRes.SamplingPlanLabSheetType);
               Assert.IsNotNull(CSSPModelsRes.SamplingPlanProvinceTVItemID);
               Assert.IsNotNull(CSSPModelsRes.SamplingPlanCreatorTVItemID);
               Assert.IsNotNull(CSSPModelsRes.SamplingPlanYear);
               Assert.IsNotNull(CSSPModelsRes.SamplingPlanAccessCode);
               Assert.IsNotNull(CSSPModelsRes.SamplingPlanDailyDuplicatePrecisionCriteria);
               Assert.IsNotNull(CSSPModelsRes.SamplingPlanIntertechDuplicatePrecisionCriteria);
               Assert.IsNotNull(CSSPModelsRes.SamplingPlanIncludeLaboratoryQAQC);
               Assert.IsNotNull(CSSPModelsRes.SamplingPlanApprovalCode);
               Assert.IsNotNull(CSSPModelsRes.SamplingPlanSamplingPlanFileTVItemID);
               Assert.IsNotNull(CSSPModelsRes.SamplingPlanAnalyzeMethodDefault);
               Assert.IsNotNull(CSSPModelsRes.SamplingPlanSampleMatrixDefault);
               Assert.IsNotNull(CSSPModelsRes.SamplingPlanLaboratoryDefault);
               Assert.IsNotNull(CSSPModelsRes.SamplingPlanBackupDirectory);
               Assert.IsNotNull(CSSPModelsRes.SamplingPlanLastUpdateDate_UTC);
               Assert.IsNotNull(CSSPModelsRes.SamplingPlanLastUpdateContactTVItemID);
               Assert.IsNotNull(CSSPModelsRes.SamplingPlanHasErrors);
        }
        [TestMethod]
        public void SamplingPlan_Every_Property_Has_Get_Set_Test()
        {
               int val1 = 45;
               samplingPlan.SamplingPlanID = val1;
               Assert.AreEqual(val1, samplingPlan.SamplingPlanID);
               bool val2 = true;
               samplingPlan.IsActive = val2;
               Assert.AreEqual(val2, samplingPlan.IsActive);
               string val3 = "Some text";
               samplingPlan.SamplingPlanName = val3;
               Assert.AreEqual(val3, samplingPlan.SamplingPlanName);
               string val4 = "Some text";
               samplingPlan.ForGroupName = val4;
               Assert.AreEqual(val4, samplingPlan.ForGroupName);
               SampleTypeEnum val5 = (SampleTypeEnum)3;
               samplingPlan.SampleType = val5;
               Assert.AreEqual(val5, samplingPlan.SampleType);
               SamplingPlanTypeEnum val6 = (SamplingPlanTypeEnum)3;
               samplingPlan.SamplingPlanType = val6;
               Assert.AreEqual(val6, samplingPlan.SamplingPlanType);
               LabSheetTypeEnum val7 = (LabSheetTypeEnum)3;
               samplingPlan.LabSheetType = val7;
               Assert.AreEqual(val7, samplingPlan.LabSheetType);
               int val8 = 45;
               samplingPlan.ProvinceTVItemID = val8;
               Assert.AreEqual(val8, samplingPlan.ProvinceTVItemID);
               int val9 = 45;
               samplingPlan.CreatorTVItemID = val9;
               Assert.AreEqual(val9, samplingPlan.CreatorTVItemID);
               int val10 = 45;
               samplingPlan.Year = val10;
               Assert.AreEqual(val10, samplingPlan.Year);
               string val11 = "Some text";
               samplingPlan.AccessCode = val11;
               Assert.AreEqual(val11, samplingPlan.AccessCode);
               double val12 = 87.9D;
               samplingPlan.DailyDuplicatePrecisionCriteria = val12;
               Assert.AreEqual(val12, samplingPlan.DailyDuplicatePrecisionCriteria);
               double val13 = 87.9D;
               samplingPlan.IntertechDuplicatePrecisionCriteria = val13;
               Assert.AreEqual(val13, samplingPlan.IntertechDuplicatePrecisionCriteria);
               bool val14 = true;
               samplingPlan.IncludeLaboratoryQAQC = val14;
               Assert.AreEqual(val14, samplingPlan.IncludeLaboratoryQAQC);
               string val15 = "Some text";
               samplingPlan.ApprovalCode = val15;
               Assert.AreEqual(val15, samplingPlan.ApprovalCode);
               int val16 = 45;
               samplingPlan.SamplingPlanFileTVItemID = val16;
               Assert.AreEqual(val16, samplingPlan.SamplingPlanFileTVItemID);
               AnalyzeMethodEnum val17 = (AnalyzeMethodEnum)3;
               samplingPlan.AnalyzeMethodDefault = val17;
               Assert.AreEqual(val17, samplingPlan.AnalyzeMethodDefault);
               SampleMatrixEnum val18 = (SampleMatrixEnum)3;
               samplingPlan.SampleMatrixDefault = val18;
               Assert.AreEqual(val18, samplingPlan.SampleMatrixDefault);
               LaboratoryEnum val19 = (LaboratoryEnum)3;
               samplingPlan.LaboratoryDefault = val19;
               Assert.AreEqual(val19, samplingPlan.LaboratoryDefault);
               string val20 = "Some text";
               samplingPlan.BackupDirectory = val20;
               Assert.AreEqual(val20, samplingPlan.BackupDirectory);
               DateTime val21 = new DateTime(2010, 3, 4);
               samplingPlan.LastUpdateDate_UTC = val21;
               Assert.AreEqual(val21, samplingPlan.LastUpdateDate_UTC);
               int val22 = 45;
               samplingPlan.LastUpdateContactTVItemID = val22;
               Assert.AreEqual(val22, samplingPlan.LastUpdateContactTVItemID);
               bool val23 = true;
               samplingPlan.HasErrors = val23;
               Assert.AreEqual(val23, samplingPlan.HasErrors);
               IEnumerable<ValidationResult> val76 = new List<ValidationResult>().AsEnumerable();
               samplingPlan.ValidationResults = val76;
               Assert.AreEqual(val76, samplingPlan.ValidationResults);
        }
        #endregion Tests Functions public
    }
}
