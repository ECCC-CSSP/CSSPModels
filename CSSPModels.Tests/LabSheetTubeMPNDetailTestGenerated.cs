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
    public partial class LabSheetTubeMPNDetailTest
    {
        [TestMethod]
        public void LabSheetTubeMPNDetail_Properties_OK()
        {
            List<string> propNameList = new List<string>() { "LabSheetTubeMPNDetailID", "LabSheetDetailID", "Ordinal", "MWQMSiteTVItemID", "SampleDateTime", "MPN", "Tube10", "Tube1_0", "Tube0_1", "Salinity", "Temperature", "ProcessedBy", "SampleType", "SiteComment", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (IProperty propertyType in entityType.GetProperties().OrderBy(c => c.Name))
            {
                Assert.AreEqual(propNameList[index], propertyType.Name);
                index += 1;
            }

            Assert.AreEqual(propNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(LabSheetTubeMPNDetail).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void LabSheetTubeMPNDetail_Navigation_OK()
        {
            List<string> foreignNameList = new List<string>() { "LabSheetDetail", "MWQMSiteTVItem",  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (string foreignName in (from c in entityType.GetForeignKeys() orderby c.DependentToPrincipal.Name select c.DependentToPrincipal.Name))
            {
                Assert.AreEqual(foreignNameList[index], foreignName);
                index += 1;
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(LabSheetTubeMPNDetail).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void LabSheetTubeMPNDetail_Has_ValidationResults_OK()
        {
             Assert.IsTrue(typeof(LabSheetTubeMPNDetail).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void LabSheetTubeMPNDetail_Every_Property_Has_A_Resource_OK()
        {
               Assert.IsNotNull(ModelsRes.LabSheetTubeMPNDetailLabSheetTubeMPNDetailID);
               Assert.IsNotNull(ModelsRes.LabSheetTubeMPNDetailLabSheetDetailID);
               Assert.IsNotNull(ModelsRes.LabSheetTubeMPNDetailOrdinal);
               Assert.IsNotNull(ModelsRes.LabSheetTubeMPNDetailMWQMSiteTVItemID);
               Assert.IsNotNull(ModelsRes.LabSheetTubeMPNDetailSampleDateTime);
               Assert.IsNotNull(ModelsRes.LabSheetTubeMPNDetailMPN);
               Assert.IsNotNull(ModelsRes.LabSheetTubeMPNDetailTube10);
               Assert.IsNotNull(ModelsRes.LabSheetTubeMPNDetailTube1_0);
               Assert.IsNotNull(ModelsRes.LabSheetTubeMPNDetailTube0_1);
               Assert.IsNotNull(ModelsRes.LabSheetTubeMPNDetailSalinity);
               Assert.IsNotNull(ModelsRes.LabSheetTubeMPNDetailTemperature);
               Assert.IsNotNull(ModelsRes.LabSheetTubeMPNDetailProcessedBy);
               Assert.IsNotNull(ModelsRes.LabSheetTubeMPNDetailSampleType);
               Assert.IsNotNull(ModelsRes.LabSheetTubeMPNDetailSiteComment);
               Assert.IsNotNull(ModelsRes.LabSheetTubeMPNDetailLastUpdateDate_UTC);
               Assert.IsNotNull(ModelsRes.LabSheetTubeMPNDetailLastUpdateContactTVItemID);
               Assert.IsNotNull(ModelsRes.LabSheetTubeMPNDetailLabSheetDetail);
               Assert.IsNotNull(ModelsRes.LabSheetTubeMPNDetailMWQMSiteTVItem);
        }
    }
}
