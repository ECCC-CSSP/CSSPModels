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
    public partial class MWQMSiteSampleFCTest : SetupData
    {
        [TestMethod]
        public void MWQMSiteSampleFC_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "Error", "SampleDate", "FC", "Sal", "Temp", "PH", "DO", "Depth", "SampCount", "MinFC", "MaxFC", "GeoMean", "Median", "P90", "PercOver43", "PercOver260", "HasErrors",  }.OrderBy(c => c).ToList();
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
        public void MWQMSiteSampleFC_Has_ValidationResults_Test()
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
               Assert.IsNotNull(ModelsRes.MWQMSiteSampleFCHasErrors);
        }
        [TestMethod]
        public void MWQMSiteSampleFC_Every_Property_Has_Get_Set_Test()
        {
               string val1 = "Some text";
               mWQMSiteSampleFC.Error = val1;
               Assert.AreEqual(val1, mWQMSiteSampleFC.Error);
               DateTime val2 = new DateTime(2010, 3, 4);
               mWQMSiteSampleFC.SampleDate = val2;
               Assert.AreEqual(val2, mWQMSiteSampleFC.SampleDate);
               int val3 = 45;
               mWQMSiteSampleFC.FC = val3;
               Assert.AreEqual(val3, mWQMSiteSampleFC.FC);
               double val4 = 87.9D;
               mWQMSiteSampleFC.Sal = val4;
               Assert.AreEqual(val4, mWQMSiteSampleFC.Sal);
               double val5 = 87.9D;
               mWQMSiteSampleFC.Temp = val5;
               Assert.AreEqual(val5, mWQMSiteSampleFC.Temp);
               double val6 = 87.9D;
               mWQMSiteSampleFC.PH = val6;
               Assert.AreEqual(val6, mWQMSiteSampleFC.PH);
               double val7 = 87.9D;
               mWQMSiteSampleFC.DO = val7;
               Assert.AreEqual(val7, mWQMSiteSampleFC.DO);
               double val8 = 87.9D;
               mWQMSiteSampleFC.Depth = val8;
               Assert.AreEqual(val8, mWQMSiteSampleFC.Depth);
               int val9 = 45;
               mWQMSiteSampleFC.SampCount = val9;
               Assert.AreEqual(val9, mWQMSiteSampleFC.SampCount);
               int val10 = 45;
               mWQMSiteSampleFC.MinFC = val10;
               Assert.AreEqual(val10, mWQMSiteSampleFC.MinFC);
               int val11 = 45;
               mWQMSiteSampleFC.MaxFC = val11;
               Assert.AreEqual(val11, mWQMSiteSampleFC.MaxFC);
               double val12 = 87.9D;
               mWQMSiteSampleFC.GeoMean = val12;
               Assert.AreEqual(val12, mWQMSiteSampleFC.GeoMean);
               double val13 = 87.9D;
               mWQMSiteSampleFC.Median = val13;
               Assert.AreEqual(val13, mWQMSiteSampleFC.Median);
               double val14 = 87.9D;
               mWQMSiteSampleFC.P90 = val14;
               Assert.AreEqual(val14, mWQMSiteSampleFC.P90);
               double val15 = 87.9D;
               mWQMSiteSampleFC.PercOver43 = val15;
               Assert.AreEqual(val15, mWQMSiteSampleFC.PercOver43);
               double val16 = 87.9D;
               mWQMSiteSampleFC.PercOver260 = val16;
               Assert.AreEqual(val16, mWQMSiteSampleFC.PercOver260);
               bool val17 = true;
               mWQMSiteSampleFC.HasErrors = val17;
               Assert.AreEqual(val17, mWQMSiteSampleFC.HasErrors);
               IEnumerable<ValidationResult> val54 = new List<ValidationResult>().AsEnumerable();
               mWQMSiteSampleFC.ValidationResults = val54;
               Assert.AreEqual(val54, mWQMSiteSampleFC.ValidationResults);
        }
    }
}
