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
    public partial class MWQMRunTest : SetupData
    {
        [TestMethod]
        public void MWQMRun_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "MWQMRunID", "SubsectorTVItemID", "MWQMRunTVItemID", "RunSampleType", "DateTime_Local", "RunNumber", "StartDateTime_Local", "EndDateTime_Local", "LabReceivedDateTime_Local", "TemperatureControl1_C", "TemperatureControl2_C", "SeaStateAtStart_BeaufortScale", "SeaStateAtEnd_BeaufortScale", "WaterLevelAtBrook_m", "WaveHightAtStart_m", "WaveHightAtEnd_m", "SampleCrewInitials", "AnalyzeMethod", "SampleMatrix", "Laboratory", "SampleStatus", "LabSampleApprovalContactTVItemID", "LabAnalyzeBath1IncubationStartDateTime_Local", "LabAnalyzeBath2IncubationStartDateTime_Local", "LabAnalyzeBath3IncubationStartDateTime_Local", "LabRunSampleApprovalDateTime_Local", "Tide_Start", "Tide_End", "RainDay0_mm", "RainDay1_mm", "RainDay2_mm", "RainDay3_mm", "RainDay4_mm", "RainDay5_mm", "RainDay6_mm", "RainDay7_mm", "RainDay8_mm", "RainDay9_mm", "RainDay10_mm", "RemoveFromStat", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "SubsectorTVText", "MWQMRunTVText", "LabSampleApprovalContactTVText", "LastUpdateContactTVText", "RunSampleTypeText", "SeaStateAtStart_BeaufortScaleText", "SeaStateAtEnd_BeaufortScaleText", "AnalyzeMethodText", "SampleMatrixText", "LaboratoryText", "SampleStatusText", "Tide_StartText", "Tide_EndText", "HasErrors",  }.OrderBy(c => c).ToList();

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
               Assert.IsNotNull(ModelsRes.MWQMRunMWQMRunID);
               Assert.IsNotNull(ModelsRes.MWQMRunSubsectorTVItemID);
               Assert.IsNotNull(ModelsRes.MWQMRunMWQMRunTVItemID);
               Assert.IsNotNull(ModelsRes.MWQMRunRunSampleType);
               Assert.IsNotNull(ModelsRes.MWQMRunDateTime_Local);
               Assert.IsNotNull(ModelsRes.MWQMRunRunNumber);
               Assert.IsNotNull(ModelsRes.MWQMRunStartDateTime_Local);
               Assert.IsNotNull(ModelsRes.MWQMRunEndDateTime_Local);
               Assert.IsNotNull(ModelsRes.MWQMRunLabReceivedDateTime_Local);
               Assert.IsNotNull(ModelsRes.MWQMRunTemperatureControl1_C);
               Assert.IsNotNull(ModelsRes.MWQMRunTemperatureControl2_C);
               Assert.IsNotNull(ModelsRes.MWQMRunSeaStateAtStart_BeaufortScale);
               Assert.IsNotNull(ModelsRes.MWQMRunSeaStateAtEnd_BeaufortScale);
               Assert.IsNotNull(ModelsRes.MWQMRunWaterLevelAtBrook_m);
               Assert.IsNotNull(ModelsRes.MWQMRunWaveHightAtStart_m);
               Assert.IsNotNull(ModelsRes.MWQMRunWaveHightAtEnd_m);
               Assert.IsNotNull(ModelsRes.MWQMRunSampleCrewInitials);
               Assert.IsNotNull(ModelsRes.MWQMRunAnalyzeMethod);
               Assert.IsNotNull(ModelsRes.MWQMRunSampleMatrix);
               Assert.IsNotNull(ModelsRes.MWQMRunLaboratory);
               Assert.IsNotNull(ModelsRes.MWQMRunSampleStatus);
               Assert.IsNotNull(ModelsRes.MWQMRunLabSampleApprovalContactTVItemID);
               Assert.IsNotNull(ModelsRes.MWQMRunLabAnalyzeBath1IncubationStartDateTime_Local);
               Assert.IsNotNull(ModelsRes.MWQMRunLabAnalyzeBath2IncubationStartDateTime_Local);
               Assert.IsNotNull(ModelsRes.MWQMRunLabAnalyzeBath3IncubationStartDateTime_Local);
               Assert.IsNotNull(ModelsRes.MWQMRunLabRunSampleApprovalDateTime_Local);
               Assert.IsNotNull(ModelsRes.MWQMRunTide_Start);
               Assert.IsNotNull(ModelsRes.MWQMRunTide_End);
               Assert.IsNotNull(ModelsRes.MWQMRunRainDay0_mm);
               Assert.IsNotNull(ModelsRes.MWQMRunRainDay1_mm);
               Assert.IsNotNull(ModelsRes.MWQMRunRainDay2_mm);
               Assert.IsNotNull(ModelsRes.MWQMRunRainDay3_mm);
               Assert.IsNotNull(ModelsRes.MWQMRunRainDay4_mm);
               Assert.IsNotNull(ModelsRes.MWQMRunRainDay5_mm);
               Assert.IsNotNull(ModelsRes.MWQMRunRainDay6_mm);
               Assert.IsNotNull(ModelsRes.MWQMRunRainDay7_mm);
               Assert.IsNotNull(ModelsRes.MWQMRunRainDay8_mm);
               Assert.IsNotNull(ModelsRes.MWQMRunRainDay9_mm);
               Assert.IsNotNull(ModelsRes.MWQMRunRainDay10_mm);
               Assert.IsNotNull(ModelsRes.MWQMRunRemoveFromStat);
               Assert.IsNotNull(ModelsRes.MWQMRunLastUpdateDate_UTC);
               Assert.IsNotNull(ModelsRes.MWQMRunLastUpdateContactTVItemID);
               Assert.IsNotNull(ModelsRes.MWQMRunSubsectorTVText);
               Assert.IsNotNull(ModelsRes.MWQMRunMWQMRunTVText);
               Assert.IsNotNull(ModelsRes.MWQMRunLabSampleApprovalContactTVText);
               Assert.IsNotNull(ModelsRes.MWQMRunLastUpdateContactTVText);
               Assert.IsNotNull(ModelsRes.MWQMRunRunSampleTypeText);
               Assert.IsNotNull(ModelsRes.MWQMRunSeaStateAtStart_BeaufortScaleText);
               Assert.IsNotNull(ModelsRes.MWQMRunSeaStateAtEnd_BeaufortScaleText);
               Assert.IsNotNull(ModelsRes.MWQMRunAnalyzeMethodText);
               Assert.IsNotNull(ModelsRes.MWQMRunSampleMatrixText);
               Assert.IsNotNull(ModelsRes.MWQMRunLaboratoryText);
               Assert.IsNotNull(ModelsRes.MWQMRunSampleStatusText);
               Assert.IsNotNull(ModelsRes.MWQMRunTide_StartText);
               Assert.IsNotNull(ModelsRes.MWQMRunTide_EndText);
               Assert.IsNotNull(ModelsRes.MWQMRunHasErrors);
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
               string val43 = "Some text";
               mWQMRun.SubsectorTVText = val43;
               Assert.AreEqual(val43, mWQMRun.SubsectorTVText);
               string val44 = "Some text";
               mWQMRun.MWQMRunTVText = val44;
               Assert.AreEqual(val44, mWQMRun.MWQMRunTVText);
               string val45 = "Some text";
               mWQMRun.LabSampleApprovalContactTVText = val45;
               Assert.AreEqual(val45, mWQMRun.LabSampleApprovalContactTVText);
               string val46 = "Some text";
               mWQMRun.LastUpdateContactTVText = val46;
               Assert.AreEqual(val46, mWQMRun.LastUpdateContactTVText);
               string val47 = "Some text";
               mWQMRun.RunSampleTypeText = val47;
               Assert.AreEqual(val47, mWQMRun.RunSampleTypeText);
               string val48 = "Some text";
               mWQMRun.SeaStateAtStart_BeaufortScaleText = val48;
               Assert.AreEqual(val48, mWQMRun.SeaStateAtStart_BeaufortScaleText);
               string val49 = "Some text";
               mWQMRun.SeaStateAtEnd_BeaufortScaleText = val49;
               Assert.AreEqual(val49, mWQMRun.SeaStateAtEnd_BeaufortScaleText);
               string val50 = "Some text";
               mWQMRun.AnalyzeMethodText = val50;
               Assert.AreEqual(val50, mWQMRun.AnalyzeMethodText);
               string val51 = "Some text";
               mWQMRun.SampleMatrixText = val51;
               Assert.AreEqual(val51, mWQMRun.SampleMatrixText);
               string val52 = "Some text";
               mWQMRun.LaboratoryText = val52;
               Assert.AreEqual(val52, mWQMRun.LaboratoryText);
               string val53 = "Some text";
               mWQMRun.SampleStatusText = val53;
               Assert.AreEqual(val53, mWQMRun.SampleStatusText);
               string val54 = "Some text";
               mWQMRun.Tide_StartText = val54;
               Assert.AreEqual(val54, mWQMRun.Tide_StartText);
               string val55 = "Some text";
               mWQMRun.Tide_EndText = val55;
               Assert.AreEqual(val55, mWQMRun.Tide_EndText);
               bool val56 = true;
               mWQMRun.HasErrors = val56;
               Assert.AreEqual(val56, mWQMRun.HasErrors);
               IEnumerable<ValidationResult> val171 = new List<ValidationResult>().AsEnumerable();
               mWQMRun.ValidationResults = val171;
               Assert.AreEqual(val171, mWQMRun.ValidationResults);
        }
    }
}
