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
    public partial class MWQMRunTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private MWQMRun mWQMRun { get; set; }
        #endregion Properties

        #region Constructors
        public MWQMRunTest()
        {
            mWQMRun = new MWQMRun();
        }
        #endregion Constructors

        #region Tests Functions public
        [TestMethod]
        public void MWQMRun_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "MWQMRunID", "SubsectorTVItemID", "MWQMRunTVItemID", "RunSampleType", "DateTime_Local", "RunNumber", "StartDateTime_Local", "EndDateTime_Local", "LabReceivedDateTime_Local", "TemperatureControl1_C", "TemperatureControl2_C", "SeaStateAtStart_BeaufortScale", "SeaStateAtEnd_BeaufortScale", "WaterLevelAtBrook_m", "WaveHightAtStart_m", "WaveHightAtEnd_m", "SampleCrewInitials", "AnalyzeMethod", "SampleMatrix", "Laboratory", "SampleStatus", "LabSampleApprovalContactTVItemID", "LabAnalyzeBath1IncubationStartDateTime_Local", "LabAnalyzeBath2IncubationStartDateTime_Local", "LabAnalyzeBath3IncubationStartDateTime_Local", "LabRunSampleApprovalDateTime_Local", "Tide_Start", "Tide_End", "RainDay0_mm", "RainDay1_mm", "RainDay2_mm", "RainDay3_mm", "RainDay4_mm", "RainDay5_mm", "RainDay6_mm", "RainDay7_mm", "RainDay8_mm", "RainDay9_mm", "RainDay10_mm", "RemoveFromStat", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "MWQMRunWeb", "MWQMRunReport", "HasErrors",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(CSSPModels.MWQMRun).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(MWQMRun).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void MWQMRun_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(MWQMRun).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(MWQMRun).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void MWQMRun_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(MWQMRun).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void MWQMRun_Every_Property_Has_A_Resource_OK()
        {
               Assert.IsNotNull(CSSPModelsRes.MWQMRunMWQMRunID);
               Assert.IsNotNull(CSSPModelsRes.MWQMRunSubsectorTVItemID);
               Assert.IsNotNull(CSSPModelsRes.MWQMRunMWQMRunTVItemID);
               Assert.IsNotNull(CSSPModelsRes.MWQMRunRunSampleType);
               Assert.IsNotNull(CSSPModelsRes.MWQMRunDateTime_Local);
               Assert.IsNotNull(CSSPModelsRes.MWQMRunRunNumber);
               Assert.IsNotNull(CSSPModelsRes.MWQMRunStartDateTime_Local);
               Assert.IsNotNull(CSSPModelsRes.MWQMRunEndDateTime_Local);
               Assert.IsNotNull(CSSPModelsRes.MWQMRunLabReceivedDateTime_Local);
               Assert.IsNotNull(CSSPModelsRes.MWQMRunTemperatureControl1_C);
               Assert.IsNotNull(CSSPModelsRes.MWQMRunTemperatureControl2_C);
               Assert.IsNotNull(CSSPModelsRes.MWQMRunSeaStateAtStart_BeaufortScale);
               Assert.IsNotNull(CSSPModelsRes.MWQMRunSeaStateAtEnd_BeaufortScale);
               Assert.IsNotNull(CSSPModelsRes.MWQMRunWaterLevelAtBrook_m);
               Assert.IsNotNull(CSSPModelsRes.MWQMRunWaveHightAtStart_m);
               Assert.IsNotNull(CSSPModelsRes.MWQMRunWaveHightAtEnd_m);
               Assert.IsNotNull(CSSPModelsRes.MWQMRunSampleCrewInitials);
               Assert.IsNotNull(CSSPModelsRes.MWQMRunAnalyzeMethod);
               Assert.IsNotNull(CSSPModelsRes.MWQMRunSampleMatrix);
               Assert.IsNotNull(CSSPModelsRes.MWQMRunLaboratory);
               Assert.IsNotNull(CSSPModelsRes.MWQMRunSampleStatus);
               Assert.IsNotNull(CSSPModelsRes.MWQMRunLabSampleApprovalContactTVItemID);
               Assert.IsNotNull(CSSPModelsRes.MWQMRunLabAnalyzeBath1IncubationStartDateTime_Local);
               Assert.IsNotNull(CSSPModelsRes.MWQMRunLabAnalyzeBath2IncubationStartDateTime_Local);
               Assert.IsNotNull(CSSPModelsRes.MWQMRunLabAnalyzeBath3IncubationStartDateTime_Local);
               Assert.IsNotNull(CSSPModelsRes.MWQMRunLabRunSampleApprovalDateTime_Local);
               Assert.IsNotNull(CSSPModelsRes.MWQMRunTide_Start);
               Assert.IsNotNull(CSSPModelsRes.MWQMRunTide_End);
               Assert.IsNotNull(CSSPModelsRes.MWQMRunRainDay0_mm);
               Assert.IsNotNull(CSSPModelsRes.MWQMRunRainDay1_mm);
               Assert.IsNotNull(CSSPModelsRes.MWQMRunRainDay2_mm);
               Assert.IsNotNull(CSSPModelsRes.MWQMRunRainDay3_mm);
               Assert.IsNotNull(CSSPModelsRes.MWQMRunRainDay4_mm);
               Assert.IsNotNull(CSSPModelsRes.MWQMRunRainDay5_mm);
               Assert.IsNotNull(CSSPModelsRes.MWQMRunRainDay6_mm);
               Assert.IsNotNull(CSSPModelsRes.MWQMRunRainDay7_mm);
               Assert.IsNotNull(CSSPModelsRes.MWQMRunRainDay8_mm);
               Assert.IsNotNull(CSSPModelsRes.MWQMRunRainDay9_mm);
               Assert.IsNotNull(CSSPModelsRes.MWQMRunRainDay10_mm);
               Assert.IsNotNull(CSSPModelsRes.MWQMRunRemoveFromStat);
               Assert.IsNotNull(CSSPModelsRes.MWQMRunLastUpdateDate_UTC);
               Assert.IsNotNull(CSSPModelsRes.MWQMRunLastUpdateContactTVItemID);
               Assert.IsNotNull(CSSPModelsRes.MWQMRunHasErrors);
        }
        [TestMethod]
        public void MWQMRun_Every_Property_Has_Get_Set_Test()
        {
               int val1 = 45;
               mWQMRun.MWQMRunID = val1;
               Assert.AreEqual(val1, mWQMRun.MWQMRunID);
               int val2 = 45;
               mWQMRun.SubsectorTVItemID = val2;
               Assert.AreEqual(val2, mWQMRun.SubsectorTVItemID);
               int val3 = 45;
               mWQMRun.MWQMRunTVItemID = val3;
               Assert.AreEqual(val3, mWQMRun.MWQMRunTVItemID);
               SampleTypeEnum val4 = (SampleTypeEnum)3;
               mWQMRun.RunSampleType = val4;
               Assert.AreEqual(val4, mWQMRun.RunSampleType);
               DateTime val5 = new DateTime(2010, 3, 4);
               mWQMRun.DateTime_Local = val5;
               Assert.AreEqual(val5, mWQMRun.DateTime_Local);
               int val6 = 45;
               mWQMRun.RunNumber = val6;
               Assert.AreEqual(val6, mWQMRun.RunNumber);
               DateTime val7 = new DateTime(2010, 3, 4);
               mWQMRun.StartDateTime_Local = val7;
               Assert.AreEqual(val7, mWQMRun.StartDateTime_Local);
               DateTime val8 = new DateTime(2010, 3, 4);
               mWQMRun.EndDateTime_Local = val8;
               Assert.AreEqual(val8, mWQMRun.EndDateTime_Local);
               DateTime val9 = new DateTime(2010, 3, 4);
               mWQMRun.LabReceivedDateTime_Local = val9;
               Assert.AreEqual(val9, mWQMRun.LabReceivedDateTime_Local);
               double val10 = 87.9D;
               mWQMRun.TemperatureControl1_C = val10;
               Assert.AreEqual(val10, mWQMRun.TemperatureControl1_C);
               double val11 = 87.9D;
               mWQMRun.TemperatureControl2_C = val11;
               Assert.AreEqual(val11, mWQMRun.TemperatureControl2_C);
               BeaufortScaleEnum val12 = (BeaufortScaleEnum)3;
               mWQMRun.SeaStateAtStart_BeaufortScale = val12;
               Assert.AreEqual(val12, mWQMRun.SeaStateAtStart_BeaufortScale);
               BeaufortScaleEnum val13 = (BeaufortScaleEnum)3;
               mWQMRun.SeaStateAtEnd_BeaufortScale = val13;
               Assert.AreEqual(val13, mWQMRun.SeaStateAtEnd_BeaufortScale);
               double val14 = 87.9D;
               mWQMRun.WaterLevelAtBrook_m = val14;
               Assert.AreEqual(val14, mWQMRun.WaterLevelAtBrook_m);
               double val15 = 87.9D;
               mWQMRun.WaveHightAtStart_m = val15;
               Assert.AreEqual(val15, mWQMRun.WaveHightAtStart_m);
               double val16 = 87.9D;
               mWQMRun.WaveHightAtEnd_m = val16;
               Assert.AreEqual(val16, mWQMRun.WaveHightAtEnd_m);
               string val17 = "Some text";
               mWQMRun.SampleCrewInitials = val17;
               Assert.AreEqual(val17, mWQMRun.SampleCrewInitials);
               AnalyzeMethodEnum val18 = (AnalyzeMethodEnum)3;
               mWQMRun.AnalyzeMethod = val18;
               Assert.AreEqual(val18, mWQMRun.AnalyzeMethod);
               SampleMatrixEnum val19 = (SampleMatrixEnum)3;
               mWQMRun.SampleMatrix = val19;
               Assert.AreEqual(val19, mWQMRun.SampleMatrix);
               LaboratoryEnum val20 = (LaboratoryEnum)3;
               mWQMRun.Laboratory = val20;
               Assert.AreEqual(val20, mWQMRun.Laboratory);
               SampleStatusEnum val21 = (SampleStatusEnum)3;
               mWQMRun.SampleStatus = val21;
               Assert.AreEqual(val21, mWQMRun.SampleStatus);
               int val22 = 45;
               mWQMRun.LabSampleApprovalContactTVItemID = val22;
               Assert.AreEqual(val22, mWQMRun.LabSampleApprovalContactTVItemID);
               DateTime val23 = new DateTime(2010, 3, 4);
               mWQMRun.LabAnalyzeBath1IncubationStartDateTime_Local = val23;
               Assert.AreEqual(val23, mWQMRun.LabAnalyzeBath1IncubationStartDateTime_Local);
               DateTime val24 = new DateTime(2010, 3, 4);
               mWQMRun.LabAnalyzeBath2IncubationStartDateTime_Local = val24;
               Assert.AreEqual(val24, mWQMRun.LabAnalyzeBath2IncubationStartDateTime_Local);
               DateTime val25 = new DateTime(2010, 3, 4);
               mWQMRun.LabAnalyzeBath3IncubationStartDateTime_Local = val25;
               Assert.AreEqual(val25, mWQMRun.LabAnalyzeBath3IncubationStartDateTime_Local);
               DateTime val26 = new DateTime(2010, 3, 4);
               mWQMRun.LabRunSampleApprovalDateTime_Local = val26;
               Assert.AreEqual(val26, mWQMRun.LabRunSampleApprovalDateTime_Local);
               TideTextEnum val27 = (TideTextEnum)3;
               mWQMRun.Tide_Start = val27;
               Assert.AreEqual(val27, mWQMRun.Tide_Start);
               TideTextEnum val28 = (TideTextEnum)3;
               mWQMRun.Tide_End = val28;
               Assert.AreEqual(val28, mWQMRun.Tide_End);
               double val29 = 87.9D;
               mWQMRun.RainDay0_mm = val29;
               Assert.AreEqual(val29, mWQMRun.RainDay0_mm);
               double val30 = 87.9D;
               mWQMRun.RainDay1_mm = val30;
               Assert.AreEqual(val30, mWQMRun.RainDay1_mm);
               double val31 = 87.9D;
               mWQMRun.RainDay2_mm = val31;
               Assert.AreEqual(val31, mWQMRun.RainDay2_mm);
               double val32 = 87.9D;
               mWQMRun.RainDay3_mm = val32;
               Assert.AreEqual(val32, mWQMRun.RainDay3_mm);
               double val33 = 87.9D;
               mWQMRun.RainDay4_mm = val33;
               Assert.AreEqual(val33, mWQMRun.RainDay4_mm);
               double val34 = 87.9D;
               mWQMRun.RainDay5_mm = val34;
               Assert.AreEqual(val34, mWQMRun.RainDay5_mm);
               double val35 = 87.9D;
               mWQMRun.RainDay6_mm = val35;
               Assert.AreEqual(val35, mWQMRun.RainDay6_mm);
               double val36 = 87.9D;
               mWQMRun.RainDay7_mm = val36;
               Assert.AreEqual(val36, mWQMRun.RainDay7_mm);
               double val37 = 87.9D;
               mWQMRun.RainDay8_mm = val37;
               Assert.AreEqual(val37, mWQMRun.RainDay8_mm);
               double val38 = 87.9D;
               mWQMRun.RainDay9_mm = val38;
               Assert.AreEqual(val38, mWQMRun.RainDay9_mm);
               double val39 = 87.9D;
               mWQMRun.RainDay10_mm = val39;
               Assert.AreEqual(val39, mWQMRun.RainDay10_mm);
               bool val40 = true;
               mWQMRun.RemoveFromStat = val40;
               Assert.AreEqual(val40, mWQMRun.RemoveFromStat);
               DateTime val41 = new DateTime(2010, 3, 4);
               mWQMRun.LastUpdateDate_UTC = val41;
               Assert.AreEqual(val41, mWQMRun.LastUpdateDate_UTC);
               int val42 = 45;
               mWQMRun.LastUpdateContactTVItemID = val42;
               Assert.AreEqual(val42, mWQMRun.LastUpdateContactTVItemID);
               bool val43 = true;
               mWQMRun.HasErrors = val43;
               Assert.AreEqual(val43, mWQMRun.HasErrors);
               IEnumerable<ValidationResult> val136 = new List<ValidationResult>().AsEnumerable();
               mWQMRun.ValidationResults = val136;
               Assert.AreEqual(val136, mWQMRun.ValidationResults);
        }
        #endregion Tests Functions public
    }
}
