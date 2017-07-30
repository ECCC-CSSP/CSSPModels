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
    public partial class LabSheetA1MeasurementTest : SetupData
    {
        [TestMethod]
        public void LabSheetA1Measurement_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "Site", "TVItemID", "Time", "MPN", "Tube10", "Tube1_0", "Tube0_1", "Salinity", "Temperature", "ProcessedBy", "SampleType", "SiteComment",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(LabSheetA1Measurement).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
            {
                Assert.AreEqual(propertyInfo.Name, propNameList[index]);
                index += 1;
            }

            Assert.AreEqual(propNameList.Count, index);
        }
        [TestMethod]
        public void LabSheetA1Measurement_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(LabSheetA1Measurement).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void LabSheetA1Measurement_Every_Property_Has_A_Resource_OK()
        {
               Assert.IsNotNull(ModelsRes.LabSheetA1MeasurementSite);
               Assert.IsNotNull(ModelsRes.LabSheetA1MeasurementTVItemID);
               Assert.IsNotNull(ModelsRes.LabSheetA1MeasurementTime);
               Assert.IsNotNull(ModelsRes.LabSheetA1MeasurementMPN);
               Assert.IsNotNull(ModelsRes.LabSheetA1MeasurementTube10);
               Assert.IsNotNull(ModelsRes.LabSheetA1MeasurementTube1_0);
               Assert.IsNotNull(ModelsRes.LabSheetA1MeasurementTube0_1);
               Assert.IsNotNull(ModelsRes.LabSheetA1MeasurementSalinity);
               Assert.IsNotNull(ModelsRes.LabSheetA1MeasurementTemperature);
               Assert.IsNotNull(ModelsRes.LabSheetA1MeasurementProcessedBy);
               Assert.IsNotNull(ModelsRes.LabSheetA1MeasurementSampleType);
               Assert.IsNotNull(ModelsRes.LabSheetA1MeasurementSiteComment);
        }
        [TestMethod]
        public void LabSheetA1Measurement_Every_Property_Has_Get_Set_Test()
        {
               string val1 = "Some text";
               labSheetA1Measurement.Site = val1;
               Assert.AreEqual(val1, labSheetA1Measurement.Site);
               int val2 = 45;
               labSheetA1Measurement.TVItemID = val2;
               Assert.AreEqual(val2, labSheetA1Measurement.TVItemID);
               DateTime val3 = new DateTime(2010, 3, 4);
               labSheetA1Measurement.Time = val3;
               Assert.AreEqual(val3, labSheetA1Measurement.Time);
               int val4 = 45;
               labSheetA1Measurement.MPN = val4;
               Assert.AreEqual(val4, labSheetA1Measurement.MPN);
               int val5 = 45;
               labSheetA1Measurement.Tube10 = val5;
               Assert.AreEqual(val5, labSheetA1Measurement.Tube10);
               int val6 = 45;
               labSheetA1Measurement.Tube1_0 = val6;
               Assert.AreEqual(val6, labSheetA1Measurement.Tube1_0);
               int val7 = 45;
               labSheetA1Measurement.Tube0_1 = val7;
               Assert.AreEqual(val7, labSheetA1Measurement.Tube0_1);
               double val8 = 87.9D;
               labSheetA1Measurement.Salinity = val8;
               Assert.AreEqual(val8, labSheetA1Measurement.Salinity);
               double val9 = 87.9D;
               labSheetA1Measurement.Temperature = val9;
               Assert.AreEqual(val9, labSheetA1Measurement.Temperature);
               string val10 = "Some text";
               labSheetA1Measurement.ProcessedBy = val10;
               Assert.AreEqual(val10, labSheetA1Measurement.ProcessedBy);
               SampleTypeEnum val11 = (SampleTypeEnum)3;
               labSheetA1Measurement.SampleType = val11;
               Assert.AreEqual(val11, labSheetA1Measurement.SampleType);
               string val12 = "Some text";
               labSheetA1Measurement.SiteComment = val12;
               Assert.AreEqual(val12, labSheetA1Measurement.SiteComment);
               IEnumerable<ValidationResult> val39 = new List<ValidationResult>().AsEnumerable();
               labSheetA1Measurement.ValidationResults = val39;
               Assert.AreEqual(val39, labSheetA1Measurement.ValidationResults);
        }
    }
}
