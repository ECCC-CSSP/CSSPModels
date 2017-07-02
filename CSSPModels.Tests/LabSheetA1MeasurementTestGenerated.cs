using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Globalization;
using System.Transactions;
using System.Collections.Generic;
using CSSPModels.Resources;
using Microsoft.EntityFrameworkCore.Metadata;
using System.Reflection;

namespace CSSPModels.Tests
{
    public partial class LabSheetA1MeasurementTest
    {
        [TestMethod]
        public void LabSheetA1Measurement_Properties_OK()
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
        public void LabSheetA1Measurement_Has_ValidationResults_OK()
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
    }
}
