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
    public partial class MWQMSiteSampleFCTest
    {
        [TestMethod]
        public void MWQMSiteSampleFC_Properties_OK()
        {
            List<string> propNameList = new List<string>() { "Error", "SampleDate", "FC", "Sal", "Temp", "PH", "DO", "Depth", "SampCount", "MinFC", "MaxFC", "GeoMean", "Median", "P90", "PercOver43", "PercOver260",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(MWQMSiteSampleFC).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
            {
                Assert.AreEqual(propertyInfo.Name, propNameList[index]);
                index += 1;
            }

            Assert.AreEqual(propNameList.Count, index);
        }
        [TestMethod]
        public void MWQMSiteSampleFC_Has_ValidationResults_OK()
        {
             Assert.IsTrue(typeof(MWQMSiteSampleFC).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void MWQMSiteSampleFC_Every_Property_Has_A_Resource_OK()
        {
               Assert.IsNotNull(ModelsRes.MWQMSiteSampleFCError);
               Assert.IsNotNull(ModelsRes.MWQMSiteSampleFCSampleDate);
               Assert.IsNotNull(ModelsRes.MWQMSiteSampleFCFC);
               Assert.IsNotNull(ModelsRes.MWQMSiteSampleFCSal);
               Assert.IsNotNull(ModelsRes.MWQMSiteSampleFCTemp);
               Assert.IsNotNull(ModelsRes.MWQMSiteSampleFCPH);
               Assert.IsNotNull(ModelsRes.MWQMSiteSampleFCDO);
               Assert.IsNotNull(ModelsRes.MWQMSiteSampleFCDepth);
               Assert.IsNotNull(ModelsRes.MWQMSiteSampleFCSampCount);
               Assert.IsNotNull(ModelsRes.MWQMSiteSampleFCMinFC);
               Assert.IsNotNull(ModelsRes.MWQMSiteSampleFCMaxFC);
               Assert.IsNotNull(ModelsRes.MWQMSiteSampleFCGeoMean);
               Assert.IsNotNull(ModelsRes.MWQMSiteSampleFCMedian);
               Assert.IsNotNull(ModelsRes.MWQMSiteSampleFCP90);
               Assert.IsNotNull(ModelsRes.MWQMSiteSampleFCPercOver43);
               Assert.IsNotNull(ModelsRes.MWQMSiteSampleFCPercOver260);
        }
    }
}
