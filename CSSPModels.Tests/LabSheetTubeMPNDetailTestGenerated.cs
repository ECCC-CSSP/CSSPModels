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
    public partial class LabSheetTubeMPNDetailTest : SetupData
    {
        [TestMethod]
        public void LabSheetTubeMPNDetail_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "LabSheetTubeMPNDetailID", "LabSheetDetailID", "Ordinal", "MWQMSiteTVItemID", "SampleDateTime", "MPN", "Tube10", "Tube1_0", "Tube0_1", "Salinity", "Temperature", "ProcessedBy", "SampleType", "SiteComment", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "SampleTypeText",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(CSSPModels.LabSheetTubeMPNDetail).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(LabSheetTubeMPNDetail).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void LabSheetTubeMPNDetail_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(LabSheetTubeMPNDetail).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(LabSheetTubeMPNDetail).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void LabSheetTubeMPNDetail_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(LabSheetTubeMPNDetail).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void LabSheetTubeMPNDetail_Every_Property_Has_A_Resource_OK()
        {
               Assert.IsNotNull(ModelsRes.LabSheetTubeMPNDetailLabSheetTubeMPNDetailID);
               Assert.IsNotNull(ModelsRes.LabSheetTubeMPNDetailLabSheetDetailID);
               Assert.IsNotNull(ModelsRes.LabSheetTubeMPNDetailOrdinal);
               Assert.IsNotNull(ModelsRes.LabSheetTubeMPNDetailMWQMSiteTVItemID);
               Assert.IsNotNull(ModelsRes.LabSheetTubeMPNDetailSampleDateTime);
               Assert.IsNotNull(ModelsRes.LabSheetTubeMPNDetailMPN);
               Assert.IsNotNull(ModelsRes.LabSheetTubeMPNDetailTube10);
               Assert.IsNotNull(ModelsRes.LabSheetTubeMPNDetailTube1_0);
               Assert.IsNotNull(ModelsRes.LabSheetTubeMPNDetailTube0_1);
               Assert.IsNotNull(ModelsRes.LabSheetTubeMPNDetailSalinity);
               Assert.IsNotNull(ModelsRes.LabSheetTubeMPNDetailTemperature);
               Assert.IsNotNull(ModelsRes.LabSheetTubeMPNDetailProcessedBy);
               Assert.IsNotNull(ModelsRes.LabSheetTubeMPNDetailSampleType);
               Assert.IsNotNull(ModelsRes.LabSheetTubeMPNDetailSiteComment);
               Assert.IsNotNull(ModelsRes.LabSheetTubeMPNDetailLastUpdateDate_UTC);
               Assert.IsNotNull(ModelsRes.LabSheetTubeMPNDetailLastUpdateContactTVItemID);
               Assert.IsNotNull(ModelsRes.LabSheetTubeMPNDetailSampleTypeText);
        }
        [TestMethod]
        public void LabSheetTubeMPNDetail_Every_Property_Has_Get_Set_Test()
        {
               int val1 = 45;
               labSheetTubeMPNDetail.LabSheetTubeMPNDetailID = val1;
               Assert.AreEqual(val1, labSheetTubeMPNDetail.LabSheetTubeMPNDetailID);
               int val2 = 45;
               labSheetTubeMPNDetail.LabSheetDetailID = val2;
               Assert.AreEqual(val2, labSheetTubeMPNDetail.LabSheetDetailID);
               int val3 = 45;
               labSheetTubeMPNDetail.Ordinal = val3;
               Assert.AreEqual(val3, labSheetTubeMPNDetail.Ordinal);
               int val4 = 45;
               labSheetTubeMPNDetail.MWQMSiteTVItemID = val4;
               Assert.AreEqual(val4, labSheetTubeMPNDetail.MWQMSiteTVItemID);
               DateTime val5 = new DateTime(2010, 3, 4);
               labSheetTubeMPNDetail.SampleDateTime = val5;
               Assert.AreEqual(val5, labSheetTubeMPNDetail.SampleDateTime);
               int val6 = 45;
               labSheetTubeMPNDetail.MPN = val6;
               Assert.AreEqual(val6, labSheetTubeMPNDetail.MPN);
               int val7 = 45;
               labSheetTubeMPNDetail.Tube10 = val7;
               Assert.AreEqual(val7, labSheetTubeMPNDetail.Tube10);
               int val8 = 45;
               labSheetTubeMPNDetail.Tube1_0 = val8;
               Assert.AreEqual(val8, labSheetTubeMPNDetail.Tube1_0);
               int val9 = 45;
               labSheetTubeMPNDetail.Tube0_1 = val9;
               Assert.AreEqual(val9, labSheetTubeMPNDetail.Tube0_1);
               double val10 = 87.9D;
               labSheetTubeMPNDetail.Salinity = val10;
               Assert.AreEqual(val10, labSheetTubeMPNDetail.Salinity);
               double val11 = 87.9D;
               labSheetTubeMPNDetail.Temperature = val11;
               Assert.AreEqual(val11, labSheetTubeMPNDetail.Temperature);
               string val12 = "Some text";
               labSheetTubeMPNDetail.ProcessedBy = val12;
               Assert.AreEqual(val12, labSheetTubeMPNDetail.ProcessedBy);
               SampleTypeEnum val13 = (SampleTypeEnum)3;
               labSheetTubeMPNDetail.SampleType = val13;
               Assert.AreEqual(val13, labSheetTubeMPNDetail.SampleType);
               string val14 = "Some text";
               labSheetTubeMPNDetail.SiteComment = val14;
               Assert.AreEqual(val14, labSheetTubeMPNDetail.SiteComment);
               DateTime val15 = new DateTime(2010, 3, 4);
               labSheetTubeMPNDetail.LastUpdateDate_UTC = val15;
               Assert.AreEqual(val15, labSheetTubeMPNDetail.LastUpdateDate_UTC);
               int val16 = 45;
               labSheetTubeMPNDetail.LastUpdateContactTVItemID = val16;
               Assert.AreEqual(val16, labSheetTubeMPNDetail.LastUpdateContactTVItemID);
               string val17 = "Some text";
               labSheetTubeMPNDetail.SampleTypeText = val17;
               Assert.AreEqual(val17, labSheetTubeMPNDetail.SampleTypeText);
               IEnumerable<ValidationResult> val54 = new List<ValidationResult>().AsEnumerable();
               labSheetTubeMPNDetail.ValidationResults = val54;
               Assert.AreEqual(val54, labSheetTubeMPNDetail.ValidationResults);
        }
    }
}
