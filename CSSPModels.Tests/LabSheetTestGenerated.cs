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
    public partial class LabSheetTest
    {
        [TestMethod]
        public void LabSheet_Properties_OK()
        {
            List<string> propNameList = new List<string>() { "LabSheetID", "OtherServerLabSheetID", "SamplingPlanID", "SamplingPlanName", "Year", "Month", "Day", "RunNumber", "SubsectorTVItemID", "MWQMRunTVItemID", "SamplingPlanType", "SampleType", "LabSheetType", "LabSheetStatus", "FileName", "FileLastModifiedDate_Local", "FileContent", "AcceptedOrRejectedByContactTVItemID", "AcceptedOrRejectedDateTime", "RejectReason", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (IProperty propertyType in entityType.GetProperties().OrderBy(c => c.Name))
            {
                Assert.AreEqual(propNameList[index], propertyType.Name);
                index += 1;
            }

            Assert.AreEqual(propNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(LabSheet).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void LabSheet_Navigation_OK()
        {
            List<string> foreignNameList = new List<string>() { "AcceptedOrRejectedByContactTVItem", "MWQMRunTVItem", "SamplingPlan", "SubsectorTVItem",  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() { "LabSheetDetails",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (string foreignName in (from c in entityType.GetForeignKeys() orderby c.DependentToPrincipal.Name select c.DependentToPrincipal.Name))
            {
                Assert.AreEqual(foreignNameList[index], foreignName);
                index += 1;
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(LabSheet).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void LabSheet_Has_ValidationResults_OK()
        {
             Assert.IsTrue(typeof(LabSheet).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void LabSheet_Every_Property_Has_A_Resource_OK()
        {
               Assert.IsNotNull(ModelsRes.LabSheetLabSheetID);
               Assert.IsNotNull(ModelsRes.LabSheetOtherServerLabSheetID);
               Assert.IsNotNull(ModelsRes.LabSheetSamplingPlanID);
               Assert.IsNotNull(ModelsRes.LabSheetSamplingPlanName);
               Assert.IsNotNull(ModelsRes.LabSheetYear);
               Assert.IsNotNull(ModelsRes.LabSheetMonth);
               Assert.IsNotNull(ModelsRes.LabSheetDay);
               Assert.IsNotNull(ModelsRes.LabSheetRunNumber);
               Assert.IsNotNull(ModelsRes.LabSheetSubsectorTVItemID);
               Assert.IsNotNull(ModelsRes.LabSheetMWQMRunTVItemID);
               Assert.IsNotNull(ModelsRes.LabSheetSamplingPlanType);
               Assert.IsNotNull(ModelsRes.LabSheetSampleType);
               Assert.IsNotNull(ModelsRes.LabSheetLabSheetType);
               Assert.IsNotNull(ModelsRes.LabSheetLabSheetStatus);
               Assert.IsNotNull(ModelsRes.LabSheetFileName);
               Assert.IsNotNull(ModelsRes.LabSheetFileLastModifiedDate_Local);
               Assert.IsNotNull(ModelsRes.LabSheetFileContent);
               Assert.IsNotNull(ModelsRes.LabSheetAcceptedOrRejectedByContactTVItemID);
               Assert.IsNotNull(ModelsRes.LabSheetAcceptedOrRejectedDateTime);
               Assert.IsNotNull(ModelsRes.LabSheetRejectReason);
               Assert.IsNotNull(ModelsRes.LabSheetLastUpdateDate_UTC);
               Assert.IsNotNull(ModelsRes.LabSheetLastUpdateContactTVItemID);
               Assert.IsNotNull(ModelsRes.LabSheetLabSheetDetails);
               Assert.IsNotNull(ModelsRes.LabSheetAcceptedOrRejectedByContactTVItem);
               Assert.IsNotNull(ModelsRes.LabSheetMWQMRunTVItem);
               Assert.IsNotNull(ModelsRes.LabSheetSamplingPlan);
               Assert.IsNotNull(ModelsRes.LabSheetSubsectorTVItem);
        }
    }
}
