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
    public partial class MWQMSampleTest : SetupData
    {
        [TestMethod]
        public void MWQMSample_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "MWQMSampleID", "MWQMSiteTVItemID", "MWQMRunTVItemID", "SampleDateTime_Local", "Depth_m", "FecCol_MPN_100ml", "Salinity_PPT", "WaterTemp_C", "PH", "SampleTypesText", "SampleType_old", "Tube_10", "Tube_1_0", "Tube_0_1", "ProcessedBy", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(CSSPModels.MWQMSample).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(MWQMSample).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void MWQMSample_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() { "MWQMRunTVItem", "MWQMSiteTVItem",  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() { "MWQMSampleLanguages",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(MWQMSample).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(MWQMSample).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void MWQMSample_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(MWQMSample).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void MWQMSample_Every_Property_Has_A_Resource_OK()
        {
               Assert.IsNotNull(ModelsRes.MWQMSampleMWQMSampleID);
               Assert.IsNotNull(ModelsRes.MWQMSampleMWQMSiteTVItemID);
               Assert.IsNotNull(ModelsRes.MWQMSampleMWQMRunTVItemID);
               Assert.IsNotNull(ModelsRes.MWQMSampleSampleDateTime_Local);
               Assert.IsNotNull(ModelsRes.MWQMSampleDepth_m);
               Assert.IsNotNull(ModelsRes.MWQMSampleFecCol_MPN_100ml);
               Assert.IsNotNull(ModelsRes.MWQMSampleSalinity_PPT);
               Assert.IsNotNull(ModelsRes.MWQMSampleWaterTemp_C);
               Assert.IsNotNull(ModelsRes.MWQMSamplePH);
               Assert.IsNotNull(ModelsRes.MWQMSampleSampleTypesText);
               Assert.IsNotNull(ModelsRes.MWQMSampleSampleType_old);
               Assert.IsNotNull(ModelsRes.MWQMSampleTube_10);
               Assert.IsNotNull(ModelsRes.MWQMSampleTube_1_0);
               Assert.IsNotNull(ModelsRes.MWQMSampleTube_0_1);
               Assert.IsNotNull(ModelsRes.MWQMSampleProcessedBy);
               Assert.IsNotNull(ModelsRes.MWQMSampleLastUpdateDate_UTC);
               Assert.IsNotNull(ModelsRes.MWQMSampleLastUpdateContactTVItemID);
               Assert.IsNotNull(ModelsRes.MWQMSampleMWQMSampleLanguages);
               Assert.IsNotNull(ModelsRes.MWQMSampleMWQMRunTVItem);
               Assert.IsNotNull(ModelsRes.MWQMSampleMWQMSiteTVItem);
        }
        [TestMethod]
        public void MWQMSample_Every_Property_Has_Get_Set_Test()
        {
               int val1 = 45;
               mWQMSample.MWQMSampleID = val1;
               Assert.AreEqual(val1, mWQMSample.MWQMSampleID);
               int val2 = 45;
               mWQMSample.MWQMSiteTVItemID = val2;
               Assert.AreEqual(val2, mWQMSample.MWQMSiteTVItemID);
               int val3 = 45;
               mWQMSample.MWQMRunTVItemID = val3;
               Assert.AreEqual(val3, mWQMSample.MWQMRunTVItemID);
               DateTime val4 = new DateTime(2010, 3, 4);
               mWQMSample.SampleDateTime_Local = val4;
               Assert.AreEqual(val4, mWQMSample.SampleDateTime_Local);
               double val5 = 87.9D;
               mWQMSample.Depth_m = val5;
               Assert.AreEqual(val5, mWQMSample.Depth_m);
               int val6 = 45;
               mWQMSample.FecCol_MPN_100ml = val6;
               Assert.AreEqual(val6, mWQMSample.FecCol_MPN_100ml);
               double val7 = 87.9D;
               mWQMSample.Salinity_PPT = val7;
               Assert.AreEqual(val7, mWQMSample.Salinity_PPT);
               double val8 = 87.9D;
               mWQMSample.WaterTemp_C = val8;
               Assert.AreEqual(val8, mWQMSample.WaterTemp_C);
               double val9 = 87.9D;
               mWQMSample.PH = val9;
               Assert.AreEqual(val9, mWQMSample.PH);
               string val10 = "Some text";
               mWQMSample.SampleTypesText = val10;
               Assert.AreEqual(val10, mWQMSample.SampleTypesText);
               SampleTypeEnum val11 = (SampleTypeEnum)3;
               mWQMSample.SampleType_old = val11;
               Assert.AreEqual(val11, mWQMSample.SampleType_old);
               int val12 = 45;
               mWQMSample.Tube_10 = val12;
               Assert.AreEqual(val12, mWQMSample.Tube_10);
               int val13 = 45;
               mWQMSample.Tube_1_0 = val13;
               Assert.AreEqual(val13, mWQMSample.Tube_1_0);
               int val14 = 45;
               mWQMSample.Tube_0_1 = val14;
               Assert.AreEqual(val14, mWQMSample.Tube_0_1);
               string val15 = "Some text";
               mWQMSample.ProcessedBy = val15;
               Assert.AreEqual(val15, mWQMSample.ProcessedBy);
               DateTime val16 = new DateTime(2010, 3, 4);
               mWQMSample.LastUpdateDate_UTC = val16;
               Assert.AreEqual(val16, mWQMSample.LastUpdateDate_UTC);
               int val17 = 45;
               mWQMSample.LastUpdateContactTVItemID = val17;
               Assert.AreEqual(val17, mWQMSample.LastUpdateContactTVItemID);
               ICollection<MWQMSampleLanguage> val39 = new List<MWQMSampleLanguage>();
               mWQMSample.MWQMSampleLanguages = val39;
               Assert.AreEqual(val39, mWQMSample.MWQMSampleLanguages);
               TVItem val40 = new TVItem();
               mWQMSample.MWQMRunTVItem = val40;
               Assert.AreEqual(val40, mWQMSample.MWQMRunTVItem);
               TVItem val41 = new TVItem();
               mWQMSample.MWQMSiteTVItem = val41;
               Assert.AreEqual(val41, mWQMSample.MWQMSiteTVItem);
               IEnumerable<ValidationResult> val63 = new List<ValidationResult>().AsEnumerable();
               mWQMSample.ValidationResults = val63;
               Assert.AreEqual(val63, mWQMSample.ValidationResults);
        }
    }
}
