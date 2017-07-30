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
    public partial class SubsectorMWQMSampleYearTest : SetupData
    {
        [TestMethod]
        public void SubsectorMWQMSampleYear_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "SubsectorTVItemID", "Year", "EarliestDate", "LatestDate",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(SubsectorMWQMSampleYear).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
            {
                Assert.AreEqual(propertyInfo.Name, propNameList[index]);
                index += 1;
            }

            Assert.AreEqual(propNameList.Count, index);
        }
        [TestMethod]
        public void SubsectorMWQMSampleYear_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(SubsectorMWQMSampleYear).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void SubsectorMWQMSampleYear_Every_Property_Has_A_Resource_OK()
        {
               Assert.IsNotNull(ModelsRes.SubsectorMWQMSampleYearSubsectorTVItemID);
               Assert.IsNotNull(ModelsRes.SubsectorMWQMSampleYearYear);
               Assert.IsNotNull(ModelsRes.SubsectorMWQMSampleYearEarliestDate);
               Assert.IsNotNull(ModelsRes.SubsectorMWQMSampleYearLatestDate);
        }
        [TestMethod]
        public void SubsectorMWQMSampleYear_Every_Property_Has_Get_Set_Test()
        {
               int val1 = 45;
               subsectorMWQMSampleYear.SubsectorTVItemID = val1;
               Assert.AreEqual(val1, subsectorMWQMSampleYear.SubsectorTVItemID);
               int val2 = 45;
               subsectorMWQMSampleYear.Year = val2;
               Assert.AreEqual(val2, subsectorMWQMSampleYear.Year);
               DateTime val3 = new DateTime(2010, 3, 4);
               subsectorMWQMSampleYear.EarliestDate = val3;
               Assert.AreEqual(val3, subsectorMWQMSampleYear.EarliestDate);
               DateTime val4 = new DateTime(2010, 3, 4);
               subsectorMWQMSampleYear.LatestDate = val4;
               Assert.AreEqual(val4, subsectorMWQMSampleYear.LatestDate);
               IEnumerable<ValidationResult> val15 = new List<ValidationResult>().AsEnumerable();
               subsectorMWQMSampleYear.ValidationResults = val15;
               Assert.AreEqual(val15, subsectorMWQMSampleYear.ValidationResults);
        }
    }
}
