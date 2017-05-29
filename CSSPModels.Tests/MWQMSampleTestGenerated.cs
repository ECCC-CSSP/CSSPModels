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
    public partial class MWQMSampleTest
    {
        [TestMethod]
        public void MWQMSample_Properties_OK()
        {
            List<string> propNameList = new List<string>() { "MWQMSampleID", "MWQMSiteTVItemID", "MWQMRunTVItemID", "SampleDateTime_Local", "Depth_m", "FecCol_MPN_100ml", "Salinity_PPT", "WaterTemp_C", "PH", "SampleTypesText", "SampleType_old", "Tube_10", "Tube_1_0", "Tube_0_1", "ProcessedBy", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (IProperty propertyType in entityType.GetProperties().OrderBy(c => c.Name))
            {
                Assert.AreEqual(propNameList[index], propertyType.Name);
                index += 1;
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
        public void MWQMSample_Navigation_OK()
        {
            List<string> foreignNameList = new List<string>() { "MWQMRunTVItem", "MWQMSiteTVItem",  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() { "MWQMSampleLanguages",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (string foreignName in (from c in entityType.GetForeignKeys() orderby c.DependentToPrincipal.Name select c.DependentToPrincipal.Name))
            {
                Assert.AreEqual(foreignNameList[index], foreignName);
                index += 1;
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
        public void MWQMSample_Has_ValidationResults_OK()
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
    }
}
