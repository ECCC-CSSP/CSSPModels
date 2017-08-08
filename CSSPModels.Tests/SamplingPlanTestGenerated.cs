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
    public partial class SamplingPlanTest : SetupData
    {
        [TestMethod]
        public void SamplingPlan_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "SamplingPlanID", "SamplingPlanName", "ForGroupName", "SampleType", "SamplingPlanType", "LabSheetType", "ProvinceTVItemID", "CreatorTVItemID", "Year", "AccessCode", "DailyDuplicatePrecisionCriteria", "IntertechDuplicatePrecisionCriteria", "IncludeLaboratoryQAQC", "ApprovalCode", "SamplingPlanFileTVItemID", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "ProvinceTVText", "CreatorTVText", "SamplingPlanFileTVText", "LastUpdateContactTVText", "SampleTypeText", "SamplingPlanTypeText", "LabSheetTypeText",  }.OrderBy(c => c).ToList();

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
               Assert.IsNotNull(ModelsRes.SamplingPlanSamplingPlanID);
               Assert.IsNotNull(ModelsRes.SamplingPlanSamplingPlanName);
               Assert.IsNotNull(ModelsRes.SamplingPlanForGroupName);
               Assert.IsNotNull(ModelsRes.SamplingPlanSampleType);
               Assert.IsNotNull(ModelsRes.SamplingPlanSamplingPlanType);
               Assert.IsNotNull(ModelsRes.SamplingPlanLabSheetType);
               Assert.IsNotNull(ModelsRes.SamplingPlanProvinceTVItemID);
               Assert.IsNotNull(ModelsRes.SamplingPlanCreatorTVItemID);
               Assert.IsNotNull(ModelsRes.SamplingPlanYear);
               Assert.IsNotNull(ModelsRes.SamplingPlanAccessCode);
               Assert.IsNotNull(ModelsRes.SamplingPlanDailyDuplicatePrecisionCriteria);
               Assert.IsNotNull(ModelsRes.SamplingPlanIntertechDuplicatePrecisionCriteria);
               Assert.IsNotNull(ModelsRes.SamplingPlanIncludeLaboratoryQAQC);
               Assert.IsNotNull(ModelsRes.SamplingPlanApprovalCode);
               Assert.IsNotNull(ModelsRes.SamplingPlanSamplingPlanFileTVItemID);
               Assert.IsNotNull(ModelsRes.SamplingPlanLastUpdateDate_UTC);
               Assert.IsNotNull(ModelsRes.SamplingPlanLastUpdateContactTVItemID);
               Assert.IsNotNull(ModelsRes.SamplingPlanProvinceTVText);
               Assert.IsNotNull(ModelsRes.SamplingPlanCreatorTVText);
               Assert.IsNotNull(ModelsRes.SamplingPlanSamplingPlanFileTVText);
               Assert.IsNotNull(ModelsRes.SamplingPlanLastUpdateContactTVText);
               Assert.IsNotNull(ModelsRes.SamplingPlanSampleTypeText);
               Assert.IsNotNull(ModelsRes.SamplingPlanSamplingPlanTypeText);
               Assert.IsNotNull(ModelsRes.SamplingPlanLabSheetTypeText);
        }
        [TestMethod]
        public void SamplingPlan_Every_Property_Has_Get_Set_Test()
        {
               int val1 = 45;
               samplingPlan.SamplingPlanID = val1;
               Assert.AreEqual(val1, samplingPlan.SamplingPlanID);
               string val2 = "Some text";
               samplingPlan.SamplingPlanName = val2;
               Assert.AreEqual(val2, samplingPlan.SamplingPlanName);
               string val3 = "Some text";
               samplingPlan.ForGroupName = val3;
               Assert.AreEqual(val3, samplingPlan.ForGroupName);
               SampleTypeEnum val4 = (SampleTypeEnum)3;
               samplingPlan.SampleType = val4;
               Assert.AreEqual(val4, samplingPlan.SampleType);
               SamplingPlanTypeEnum val5 = (SamplingPlanTypeEnum)3;
               samplingPlan.SamplingPlanType = val5;
               Assert.AreEqual(val5, samplingPlan.SamplingPlanType);
               LabSheetTypeEnum val6 = (LabSheetTypeEnum)3;
               samplingPlan.LabSheetType = val6;
               Assert.AreEqual(val6, samplingPlan.LabSheetType);
               int val7 = 45;
               samplingPlan.ProvinceTVItemID = val7;
               Assert.AreEqual(val7, samplingPlan.ProvinceTVItemID);
               int val8 = 45;
               samplingPlan.CreatorTVItemID = val8;
               Assert.AreEqual(val8, samplingPlan.CreatorTVItemID);
               int val9 = 45;
               samplingPlan.Year = val9;
               Assert.AreEqual(val9, samplingPlan.Year);
               string val10 = "Some text";
               samplingPlan.AccessCode = val10;
               Assert.AreEqual(val10, samplingPlan.AccessCode);
               double val11 = 87.9D;
               samplingPlan.DailyDuplicatePrecisionCriteria = val11;
               Assert.AreEqual(val11, samplingPlan.DailyDuplicatePrecisionCriteria);
               double val12 = 87.9D;
               samplingPlan.IntertechDuplicatePrecisionCriteria = val12;
               Assert.AreEqual(val12, samplingPlan.IntertechDuplicatePrecisionCriteria);
               bool val13 = true;
               samplingPlan.IncludeLaboratoryQAQC = val13;
               Assert.AreEqual(val13, samplingPlan.IncludeLaboratoryQAQC);
               string val14 = "Some text";
               samplingPlan.ApprovalCode = val14;
               Assert.AreEqual(val14, samplingPlan.ApprovalCode);
               int val15 = 45;
               samplingPlan.SamplingPlanFileTVItemID = val15;
               Assert.AreEqual(val15, samplingPlan.SamplingPlanFileTVItemID);
               DateTime val16 = new DateTime(2010, 3, 4);
               samplingPlan.LastUpdateDate_UTC = val16;
               Assert.AreEqual(val16, samplingPlan.LastUpdateDate_UTC);
               int val17 = 45;
               samplingPlan.LastUpdateContactTVItemID = val17;
               Assert.AreEqual(val17, samplingPlan.LastUpdateContactTVItemID);
               string val18 = "Some text";
               samplingPlan.ProvinceTVText = val18;
               Assert.AreEqual(val18, samplingPlan.ProvinceTVText);
               string val19 = "Some text";
               samplingPlan.CreatorTVText = val19;
               Assert.AreEqual(val19, samplingPlan.CreatorTVText);
               string val20 = "Some text";
               samplingPlan.SamplingPlanFileTVText = val20;
               Assert.AreEqual(val20, samplingPlan.SamplingPlanFileTVText);
               string val21 = "Some text";
               samplingPlan.LastUpdateContactTVText = val21;
               Assert.AreEqual(val21, samplingPlan.LastUpdateContactTVText);
               string val22 = "Some text";
               samplingPlan.SampleTypeText = val22;
               Assert.AreEqual(val22, samplingPlan.SampleTypeText);
               string val23 = "Some text";
               samplingPlan.SamplingPlanTypeText = val23;
               Assert.AreEqual(val23, samplingPlan.SamplingPlanTypeText);
               string val24 = "Some text";
               samplingPlan.LabSheetTypeText = val24;
               Assert.AreEqual(val24, samplingPlan.LabSheetTypeText);
               IEnumerable<ValidationResult> val75 = new List<ValidationResult>().AsEnumerable();
               samplingPlan.ValidationResults = val75;
               Assert.AreEqual(val75, samplingPlan.ValidationResults);
        }
    }
}
