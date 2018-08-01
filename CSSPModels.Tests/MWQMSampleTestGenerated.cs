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
    public partial class MWQMSampleTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private MWQMSample mWQMSample { get; set; }
        #endregion Properties

        #region Constructors
        public MWQMSampleTest()
        {
            mWQMSample = new MWQMSample();
        }
        #endregion Constructors

        #region Tests Functions public
        [TestMethod]
        public void MWQMSample_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "MWQMSampleID", "MWQMSiteTVItemID", "MWQMRunTVItemID", "SampleDateTime_Local", "Depth_m", "FecCol_MPN_100ml", "Salinity_PPT", "WaterTemp_C", "PH", "SampleTypesText", "SampleType_old", "Tube_10", "Tube_1_0", "Tube_0_1", "ProcessedBy", "UseForOpenData", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "MWQMSampleWeb", "MWQMSampleReport", "HasErrors",  }.OrderBy(c => c).ToList();

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
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

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
               Assert.IsNotNull(CSSPModelsRes.MWQMSampleMWQMSampleID);
               Assert.IsNotNull(CSSPModelsRes.MWQMSampleMWQMSiteTVItemID);
               Assert.IsNotNull(CSSPModelsRes.MWQMSampleMWQMRunTVItemID);
               Assert.IsNotNull(CSSPModelsRes.MWQMSampleSampleDateTime_Local);
               Assert.IsNotNull(CSSPModelsRes.MWQMSampleDepth_m);
               Assert.IsNotNull(CSSPModelsRes.MWQMSampleFecCol_MPN_100ml);
               Assert.IsNotNull(CSSPModelsRes.MWQMSampleSalinity_PPT);
               Assert.IsNotNull(CSSPModelsRes.MWQMSampleWaterTemp_C);
               Assert.IsNotNull(CSSPModelsRes.MWQMSamplePH);
               Assert.IsNotNull(CSSPModelsRes.MWQMSampleSampleTypesText);
               Assert.IsNotNull(CSSPModelsRes.MWQMSampleSampleType_old);
               Assert.IsNotNull(CSSPModelsRes.MWQMSampleTube_10);
               Assert.IsNotNull(CSSPModelsRes.MWQMSampleTube_1_0);
               Assert.IsNotNull(CSSPModelsRes.MWQMSampleTube_0_1);
               Assert.IsNotNull(CSSPModelsRes.MWQMSampleProcessedBy);
               Assert.IsNotNull(CSSPModelsRes.MWQMSampleUseForOpenData);
               Assert.IsNotNull(CSSPModelsRes.MWQMSampleLastUpdateDate_UTC);
               Assert.IsNotNull(CSSPModelsRes.MWQMSampleLastUpdateContactTVItemID);
               Assert.IsNotNull(CSSPModelsRes.MWQMSampleHasErrors);
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
               bool val16 = true;
               mWQMSample.UseForOpenData = val16;
               Assert.AreEqual(val16, mWQMSample.UseForOpenData);
               DateTime val17 = new DateTime(2010, 3, 4);
               mWQMSample.LastUpdateDate_UTC = val17;
               Assert.AreEqual(val17, mWQMSample.LastUpdateDate_UTC);
               int val18 = 45;
               mWQMSample.LastUpdateContactTVItemID = val18;
               Assert.AreEqual(val18, mWQMSample.LastUpdateContactTVItemID);
               bool val19 = true;
               mWQMSample.HasErrors = val19;
               Assert.AreEqual(val19, mWQMSample.HasErrors);
               IEnumerable<ValidationResult> val64 = new List<ValidationResult>().AsEnumerable();
               mWQMSample.ValidationResults = val64;
               Assert.AreEqual(val64, mWQMSample.ValidationResults);
        }
        #endregion Tests Functions public
    }
}
