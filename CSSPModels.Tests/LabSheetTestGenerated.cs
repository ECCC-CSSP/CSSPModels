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
    public partial class LabSheetTest : SetupData
    {
        [TestMethod]
        public void LabSheet_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "LabSheetID", "OtherServerLabSheetID", "SamplingPlanID", "SamplingPlanName", "Year", "Month", "Day", "RunNumber", "SubsectorTVItemID", "MWQMRunTVItemID", "SamplingPlanType", "SampleType", "LabSheetType", "LabSheetStatus", "FileName", "FileLastModifiedDate_Local", "FileContent", "AcceptedOrRejectedByContactTVItemID", "AcceptedOrRejectedDateTime", "RejectReason", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(CSSPModels.LabSheet).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(LabSheet).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void LabSheet_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() { "AcceptedOrRejectedByContactTVItem", "MWQMRunTVItem", "SamplingPlan", "SubsectorTVItem",  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() { "LabSheetDetails",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(LabSheet).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(LabSheet).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void LabSheet_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(LabSheet).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void LabSheet_Every_Property_Has_A_Resource_OK()
        {
               Assert.IsNotNull(ModelsRes.LabSheetLabSheetID);
               Assert.IsNotNull(ModelsRes.LabSheetOtherServerLabSheetID);
               Assert.IsNotNull(ModelsRes.LabSheetSamplingPlanID);
               Assert.IsNotNull(ModelsRes.LabSheetSamplingPlanName);
               Assert.IsNotNull(ModelsRes.LabSheetYear);
               Assert.IsNotNull(ModelsRes.LabSheetMonth);
               Assert.IsNotNull(ModelsRes.LabSheetDay);
               Assert.IsNotNull(ModelsRes.LabSheetRunNumber);
               Assert.IsNotNull(ModelsRes.LabSheetSubsectorTVItemID);
               Assert.IsNotNull(ModelsRes.LabSheetMWQMRunTVItemID);
               Assert.IsNotNull(ModelsRes.LabSheetSamplingPlanType);
               Assert.IsNotNull(ModelsRes.LabSheetSampleType);
               Assert.IsNotNull(ModelsRes.LabSheetLabSheetType);
               Assert.IsNotNull(ModelsRes.LabSheetLabSheetStatus);
               Assert.IsNotNull(ModelsRes.LabSheetFileName);
               Assert.IsNotNull(ModelsRes.LabSheetFileLastModifiedDate_Local);
               Assert.IsNotNull(ModelsRes.LabSheetFileContent);
               Assert.IsNotNull(ModelsRes.LabSheetAcceptedOrRejectedByContactTVItemID);
               Assert.IsNotNull(ModelsRes.LabSheetAcceptedOrRejectedDateTime);
               Assert.IsNotNull(ModelsRes.LabSheetRejectReason);
               Assert.IsNotNull(ModelsRes.LabSheetLastUpdateDate_UTC);
               Assert.IsNotNull(ModelsRes.LabSheetLastUpdateContactTVItemID);
               Assert.IsNotNull(ModelsRes.LabSheetLabSheetDetails);
               Assert.IsNotNull(ModelsRes.LabSheetAcceptedOrRejectedByContactTVItem);
               Assert.IsNotNull(ModelsRes.LabSheetMWQMRunTVItem);
               Assert.IsNotNull(ModelsRes.LabSheetSamplingPlan);
               Assert.IsNotNull(ModelsRes.LabSheetSubsectorTVItem);
        }
        [TestMethod]
        public void LabSheet_Every_Property_Has_Get_Set_Test()
        {
               int val1 = 45;
               labSheet.LabSheetID = val1;
               Assert.AreEqual(val1, labSheet.LabSheetID);
               int val2 = 45;
               labSheet.OtherServerLabSheetID = val2;
               Assert.AreEqual(val2, labSheet.OtherServerLabSheetID);
               int val3 = 45;
               labSheet.SamplingPlanID = val3;
               Assert.AreEqual(val3, labSheet.SamplingPlanID);
               string val4 = "Some text";
               labSheet.SamplingPlanName = val4;
               Assert.AreEqual(val4, labSheet.SamplingPlanName);
               int val5 = 45;
               labSheet.Year = val5;
               Assert.AreEqual(val5, labSheet.Year);
               int val6 = 45;
               labSheet.Month = val6;
               Assert.AreEqual(val6, labSheet.Month);
               int val7 = 45;
               labSheet.Day = val7;
               Assert.AreEqual(val7, labSheet.Day);
               int val8 = 45;
               labSheet.RunNumber = val8;
               Assert.AreEqual(val8, labSheet.RunNumber);
               int val9 = 45;
               labSheet.SubsectorTVItemID = val9;
               Assert.AreEqual(val9, labSheet.SubsectorTVItemID);
               int val10 = 45;
               labSheet.MWQMRunTVItemID = val10;
               Assert.AreEqual(val10, labSheet.MWQMRunTVItemID);
               SamplingPlanTypeEnum val11 = (SamplingPlanTypeEnum)3;
               labSheet.SamplingPlanType = val11;
               Assert.AreEqual(val11, labSheet.SamplingPlanType);
               SampleTypeEnum val12 = (SampleTypeEnum)3;
               labSheet.SampleType = val12;
               Assert.AreEqual(val12, labSheet.SampleType);
               LabSheetTypeEnum val13 = (LabSheetTypeEnum)3;
               labSheet.LabSheetType = val13;
               Assert.AreEqual(val13, labSheet.LabSheetType);
               LabSheetStatusEnum val14 = (LabSheetStatusEnum)3;
               labSheet.LabSheetStatus = val14;
               Assert.AreEqual(val14, labSheet.LabSheetStatus);
               string val15 = "Some text";
               labSheet.FileName = val15;
               Assert.AreEqual(val15, labSheet.FileName);
               DateTime val16 = new DateTime(2010, 3, 4);
               labSheet.FileLastModifiedDate_Local = val16;
               Assert.AreEqual(val16, labSheet.FileLastModifiedDate_Local);
               string val17 = "Some text";
               labSheet.FileContent = val17;
               Assert.AreEqual(val17, labSheet.FileContent);
               int val18 = 45;
               labSheet.AcceptedOrRejectedByContactTVItemID = val18;
               Assert.AreEqual(val18, labSheet.AcceptedOrRejectedByContactTVItemID);
               DateTime val19 = new DateTime(2010, 3, 4);
               labSheet.AcceptedOrRejectedDateTime = val19;
               Assert.AreEqual(val19, labSheet.AcceptedOrRejectedDateTime);
               string val20 = "Some text";
               labSheet.RejectReason = val20;
               Assert.AreEqual(val20, labSheet.RejectReason);
               DateTime val21 = new DateTime(2010, 3, 4);
               labSheet.LastUpdateDate_UTC = val21;
               Assert.AreEqual(val21, labSheet.LastUpdateDate_UTC);
               int val22 = 45;
               labSheet.LastUpdateContactTVItemID = val22;
               Assert.AreEqual(val22, labSheet.LastUpdateContactTVItemID);
               ICollection<LabSheetDetail> val51 = new List<LabSheetDetail>();
               labSheet.LabSheetDetails = val51;
               Assert.AreEqual(val51, labSheet.LabSheetDetails);
               TVItem val52 = new TVItem();
               labSheet.AcceptedOrRejectedByContactTVItem = val52;
               Assert.AreEqual(val52, labSheet.AcceptedOrRejectedByContactTVItem);
               TVItem val53 = new TVItem();
               labSheet.MWQMRunTVItem = val53;
               Assert.AreEqual(val53, labSheet.MWQMRunTVItem);
               SamplingPlan val54 = new SamplingPlan();
               labSheet.SamplingPlan = val54;
               Assert.AreEqual(val54, labSheet.SamplingPlan);
               TVItem val55 = new TVItem();
               labSheet.SubsectorTVItem = val55;
               Assert.AreEqual(val55, labSheet.SubsectorTVItem);
               IEnumerable<ValidationResult> val84 = new List<ValidationResult>().AsEnumerable();
               labSheet.ValidationResults = val84;
               Assert.AreEqual(val84, labSheet.ValidationResults);
        }
    }
}
