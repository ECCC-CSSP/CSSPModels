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
    public partial class SamplingPlanAndFilesLabSheetCountTest : SetupData
    {
        [TestMethod]
        public void SamplingPlanAndFilesLabSheetCount_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "LabSheetHistoryCount", "LabSheetTransferredCount", "SamplingPlan", "TVFileSamplingPlanFileTXT", "HasErrors",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(SamplingPlanAndFilesLabSheetCount).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
            {
                Assert.AreEqual(propertyInfo.Name, propNameList[index]);
                index += 1;
            }

            Assert.AreEqual(propNameList.Count, index);
        }
        [TestMethod]
        public void SamplingPlanAndFilesLabSheetCount_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(SamplingPlanAndFilesLabSheetCount).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void SamplingPlanAndFilesLabSheetCount_Every_Property_Has_A_Resource_OK()
        {
               Assert.IsNotNull(ModelsRes.SamplingPlanAndFilesLabSheetCountLabSheetHistoryCount);
               Assert.IsNotNull(ModelsRes.SamplingPlanAndFilesLabSheetCountLabSheetTransferredCount);
               Assert.IsNotNull(ModelsRes.SamplingPlanAndFilesLabSheetCountSamplingPlan);
               Assert.IsNotNull(ModelsRes.SamplingPlanAndFilesLabSheetCountTVFileSamplingPlanFileTXT);
               Assert.IsNotNull(ModelsRes.SamplingPlanAndFilesLabSheetCountHasErrors);
        }
        [TestMethod]
        public void SamplingPlanAndFilesLabSheetCount_Every_Property_Has_Get_Set_Test()
        {
               int val1 = 45;
               samplingPlanAndFilesLabSheetCount.LabSheetHistoryCount = val1;
               Assert.AreEqual(val1, samplingPlanAndFilesLabSheetCount.LabSheetHistoryCount);
               int val2 = 45;
               samplingPlanAndFilesLabSheetCount.LabSheetTransferredCount = val2;
               Assert.AreEqual(val2, samplingPlanAndFilesLabSheetCount.LabSheetTransferredCount);
               bool val5 = true;
               samplingPlanAndFilesLabSheetCount.HasErrors = val5;
               Assert.AreEqual(val5, samplingPlanAndFilesLabSheetCount.HasErrors);
               SamplingPlan val9 = new SamplingPlan();
               samplingPlanAndFilesLabSheetCount.SamplingPlan = val9;
               Assert.AreEqual(val9, samplingPlanAndFilesLabSheetCount.SamplingPlan);
               TVFile val10 = new TVFile();
               samplingPlanAndFilesLabSheetCount.TVFileSamplingPlanFileTXT = val10;
               Assert.AreEqual(val10, samplingPlanAndFilesLabSheetCount.TVFileSamplingPlanFileTXT);
               IEnumerable<ValidationResult> val18 = new List<ValidationResult>().AsEnumerable();
               samplingPlanAndFilesLabSheetCount.ValidationResults = val18;
               Assert.AreEqual(val18, samplingPlanAndFilesLabSheetCount.ValidationResults);
        }
    }
}
