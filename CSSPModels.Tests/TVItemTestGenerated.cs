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
    public partial class TVItemTest
    {
        [TestMethod]
        public void TVItem_Properties_OK()
        {
            List<string> propNameList = new List<string>() { "TVItemID", "TVLevel", "TVPath", "TVType", "ParentID", "IsActive", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (IProperty propertyType in entityType.GetProperties().OrderBy(c => c.Name))
            {
                Assert.AreEqual(propNameList[index], propertyType.Name);
                index += 1;
            }

            Assert.AreEqual(propNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(TVItem).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void TVItem_Navigation_OK()
        {
            List<string> foreignNameList = new List<string>() { "Parent",  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() { "AddressesAddressTVItem", "AddressesCountryTVItem", "AddressesMunicipalityTVItem", "AddressesProvinceTVItem", "AppTasksTVItem", "AppTasksTVItemID2Navigation", "BoxModels", "ClimateSites", "Contacts", "DocTemplates", "Emails", "HydrometricSites", "Infrastructures", "LabSheetDetails", "LabSheetsAcceptedOrRejectedByContactTVItem", "LabSheetsMWQMRunTVItem", "LabSheetsSubsectorTVItem", "LabSheetTubeMPNDetails", "MapInfos", "MikeBoundaryConditions", "MikeScenarios", "MikeSources", "MWQMRunsLabSampleApprovalContactTVItem", "MWQMRunsMWQMRunTVItem", "MWQMRunsSubsectorTVItem", "MWQMSampleMWQMRunTVItem", "MWQMSampleMWQMSiteTVItem", "MWQMSites", "MWQMSiteStartEndDates", "MWQMSubsectors", "PolSourceObservationsContactTVItem", "PolSourceObservationsPolSourceSiteTVItem", "PolSourceSites", "SamplingPlansCreatorTVItem", "SamplingPlansProvinceTVItem", "SamplingPlansSamplingPlanFileTVItem", "SamplingPlanSubsectors", "SamplingPlanSubsectorSites", "SpillsInfrastructureTVItem", "SpillsMunicipalityTVItem", "Tels", "TideDataValues", "TideSites", "TVFiles", "TVItemLanguages", "TVItemLinksFromTVItem", "TVItemLinksToTVItem", "TVItemStats", "TVItemUserAuthorizationsContactTVItem", "TVItemUserAuthorizationsTVItemID1Navigation", "TVTypeUserAuthorizations", "UseOfSitesSiteTVItem", "UseOfSitesSubsectorTVItem", "VPScenarios", "InverseParent",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (string foreignName in (from c in entityType.GetForeignKeys() orderby c.DependentToPrincipal.Name select c.DependentToPrincipal.Name))
            {
                Assert.AreEqual(foreignNameList[index], foreignName);
                index += 1;
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(TVItem).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void TVItem_Has_ValidationResults_OK()
        {
             Assert.IsTrue(typeof(TVItem).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void TVItem_Every_Property_Has_A_Resource_OK()
        {
               Assert.IsNotNull(ModelsRes.TVItemTVItemID);
               Assert.IsNotNull(ModelsRes.TVItemTVLevel);
               Assert.IsNotNull(ModelsRes.TVItemTVPath);
               Assert.IsNotNull(ModelsRes.TVItemTVType);
               Assert.IsNotNull(ModelsRes.TVItemParentID);
               Assert.IsNotNull(ModelsRes.TVItemIsActive);
               Assert.IsNotNull(ModelsRes.TVItemLastUpdateDate_UTC);
               Assert.IsNotNull(ModelsRes.TVItemLastUpdateContactTVItemID);
               Assert.IsNotNull(ModelsRes.TVItemAddressesAddressTVItem);
               Assert.IsNotNull(ModelsRes.TVItemAddressesCountryTVItem);
               Assert.IsNotNull(ModelsRes.TVItemAddressesMunicipalityTVItem);
               Assert.IsNotNull(ModelsRes.TVItemAddressesProvinceTVItem);
               Assert.IsNotNull(ModelsRes.TVItemAppTasksTVItem);
               Assert.IsNotNull(ModelsRes.TVItemAppTasksTVItemID2Navigation);
               Assert.IsNotNull(ModelsRes.TVItemBoxModels);
               Assert.IsNotNull(ModelsRes.TVItemClimateSites);
               Assert.IsNotNull(ModelsRes.TVItemContacts);
               Assert.IsNotNull(ModelsRes.TVItemDocTemplates);
               Assert.IsNotNull(ModelsRes.TVItemEmails);
               Assert.IsNotNull(ModelsRes.TVItemHydrometricSites);
               Assert.IsNotNull(ModelsRes.TVItemInfrastructures);
               Assert.IsNotNull(ModelsRes.TVItemLabSheetDetails);
               Assert.IsNotNull(ModelsRes.TVItemLabSheetsAcceptedOrRejectedByContactTVItem);
               Assert.IsNotNull(ModelsRes.TVItemLabSheetsMWQMRunTVItem);
               Assert.IsNotNull(ModelsRes.TVItemLabSheetsSubsectorTVItem);
               Assert.IsNotNull(ModelsRes.TVItemLabSheetTubeMPNDetails);
               Assert.IsNotNull(ModelsRes.TVItemMapInfos);
               Assert.IsNotNull(ModelsRes.TVItemMikeBoundaryConditions);
               Assert.IsNotNull(ModelsRes.TVItemMikeScenarios);
               Assert.IsNotNull(ModelsRes.TVItemMikeSources);
               Assert.IsNotNull(ModelsRes.TVItemMWQMRunsLabSampleApprovalContactTVItem);
               Assert.IsNotNull(ModelsRes.TVItemMWQMRunsMWQMRunTVItem);
               Assert.IsNotNull(ModelsRes.TVItemMWQMRunsSubsectorTVItem);
               Assert.IsNotNull(ModelsRes.TVItemMWQMSampleMWQMRunTVItem);
               Assert.IsNotNull(ModelsRes.TVItemMWQMSampleMWQMSiteTVItem);
               Assert.IsNotNull(ModelsRes.TVItemMWQMSites);
               Assert.IsNotNull(ModelsRes.TVItemMWQMSiteStartEndDates);
               Assert.IsNotNull(ModelsRes.TVItemMWQMSubsectors);
               Assert.IsNotNull(ModelsRes.TVItemPolSourceObservationsContactTVItem);
               Assert.IsNotNull(ModelsRes.TVItemPolSourceObservationsPolSourceSiteTVItem);
               Assert.IsNotNull(ModelsRes.TVItemPolSourceSites);
               Assert.IsNotNull(ModelsRes.TVItemSamplingPlansCreatorTVItem);
               Assert.IsNotNull(ModelsRes.TVItemSamplingPlansProvinceTVItem);
               Assert.IsNotNull(ModelsRes.TVItemSamplingPlansSamplingPlanFileTVItem);
               Assert.IsNotNull(ModelsRes.TVItemSamplingPlanSubsectors);
               Assert.IsNotNull(ModelsRes.TVItemSamplingPlanSubsectorSites);
               Assert.IsNotNull(ModelsRes.TVItemSpillsInfrastructureTVItem);
               Assert.IsNotNull(ModelsRes.TVItemSpillsMunicipalityTVItem);
               Assert.IsNotNull(ModelsRes.TVItemTels);
               Assert.IsNotNull(ModelsRes.TVItemTideDataValues);
               Assert.IsNotNull(ModelsRes.TVItemTideSites);
               Assert.IsNotNull(ModelsRes.TVItemTVFiles);
               Assert.IsNotNull(ModelsRes.TVItemTVItemLanguages);
               Assert.IsNotNull(ModelsRes.TVItemTVItemLinksFromTVItem);
               Assert.IsNotNull(ModelsRes.TVItemTVItemLinksToTVItem);
               Assert.IsNotNull(ModelsRes.TVItemTVItemStats);
               Assert.IsNotNull(ModelsRes.TVItemTVItemUserAuthorizationsContactTVItem);
               Assert.IsNotNull(ModelsRes.TVItemTVItemUserAuthorizationsTVItemID1Navigation);
               Assert.IsNotNull(ModelsRes.TVItemTVTypeUserAuthorizations);
               Assert.IsNotNull(ModelsRes.TVItemUseOfSitesSiteTVItem);
               Assert.IsNotNull(ModelsRes.TVItemUseOfSitesSubsectorTVItem);
               Assert.IsNotNull(ModelsRes.TVItemVPScenarios);
               Assert.IsNotNull(ModelsRes.TVItemParent);
               Assert.IsNotNull(ModelsRes.TVItemInverseParent);
        }
    }
}
