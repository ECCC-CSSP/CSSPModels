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
    public partial class TVItemTest : SetupData
    {
        [TestMethod]
        public void TVItem_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "TVItemID", "TVLevel", "TVPath", "TVType", "ParentID", "IsActive", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(CSSPModels.TVItem).GetProperties().OrderBy(c => c.Name))
            {
                if (!propertyInfo.GetGetMethod().IsVirtual
                    && propertyInfo.Name != "ValidationResults"
                    && !propertyInfo.CustomAttributes.Where(c => c.AttributeType.Name.Contains("NotMappedAttribute")).Any())
                {
                    Assert.AreEqual(propNameList[index], propertyInfo.Name);
                    index += 1;
                }
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
        public void TVItem_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() { "Parent",  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() { "AddressesAddressTVItem", "AddressesCountryTVItem", "AddressesMunicipalityTVItem", "AddressesProvinceTVItem", "AppTasks", "BoxModels", "ClimateSites", "Contacts", "DocTemplates", "Emails", "EmailDistributionLists", "HydrometricSites", "Infrastructures", "LabSheetDetails", "LabSheetsAcceptedOrRejectedByContactTVItem", "LabSheetsMWQMRunTVItem", "LabSheetsSubsectorTVItem", "LabSheetTubeMPNDetails", "MapInfos", "MikeBoundaryConditions", "MikeScenarios", "MikeSources", "MWQMRunsLabSampleApprovalContactTVItem", "MWQMRunsMWQMRunTVItem", "MWQMRunsSubsectorTVItem", "MWQMSampleMWQMRunTVItem", "MWQMSampleMWQMSiteTVItem", "MWQMSites", "MWQMSiteStartEndDates", "MWQMSubsectors", "PolSourceObservationsContactTVItem", "PolSourceSites", "SamplingPlansCreatorTVItem", "SamplingPlansProvinceTVItem", "SamplingPlansSamplingPlanFileTVItem", "SamplingPlanSubsectors", "SamplingPlanSubsectorSites", "SpillsInfrastructureTVItem", "SpillsMunicipalityTVItem", "Tels", "TideDataValues", "TideSites", "TVFiles", "TVItemLanguages", "TVItemLinksFromTVItem", "TVItemLinksToTVItem", "TVItemStats", "TVItemUserAuthorizationsContactTVItem", "TVTypeUserAuthorizations", "UseOfSitesSiteTVItem", "UseOfSitesSubsectorTVItem", "VPScenarios", "InverseParent",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(TVItem).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
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
        public void TVItem_Has_ValidationResults_Test()
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
               Assert.IsNotNull(ModelsRes.TVItemAppTasks);
               Assert.IsNotNull(ModelsRes.TVItemBoxModels);
               Assert.IsNotNull(ModelsRes.TVItemClimateSites);
               Assert.IsNotNull(ModelsRes.TVItemContacts);
               Assert.IsNotNull(ModelsRes.TVItemDocTemplates);
               Assert.IsNotNull(ModelsRes.TVItemEmails);
               Assert.IsNotNull(ModelsRes.TVItemEmailDistributionLists);
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
               Assert.IsNotNull(ModelsRes.TVItemTVTypeUserAuthorizations);
               Assert.IsNotNull(ModelsRes.TVItemUseOfSitesSiteTVItem);
               Assert.IsNotNull(ModelsRes.TVItemUseOfSitesSubsectorTVItem);
               Assert.IsNotNull(ModelsRes.TVItemVPScenarios);
               Assert.IsNotNull(ModelsRes.TVItemParent);
               Assert.IsNotNull(ModelsRes.TVItemInverseParent);
        }
        [TestMethod]
        public void TVItem_Every_Property_Has_Get_Set_Test()
        {
               int val1 = 45;
               tVItem.TVItemID = val1;
               Assert.AreEqual(val1, tVItem.TVItemID);
               int val2 = 45;
               tVItem.TVLevel = val2;
               Assert.AreEqual(val2, tVItem.TVLevel);
               string val3 = "Some text";
               tVItem.TVPath = val3;
               Assert.AreEqual(val3, tVItem.TVPath);
               TVTypeEnum val4 = (TVTypeEnum)3;
               tVItem.TVType = val4;
               Assert.AreEqual(val4, tVItem.TVType);
               int val5 = 45;
               tVItem.ParentID = val5;
               Assert.AreEqual(val5, tVItem.ParentID);
               bool val6 = true;
               tVItem.IsActive = val6;
               Assert.AreEqual(val6, tVItem.IsActive);
               DateTime val7 = new DateTime(2010, 3, 4);
               tVItem.LastUpdateDate_UTC = val7;
               Assert.AreEqual(val7, tVItem.LastUpdateDate_UTC);
               int val8 = 45;
               tVItem.LastUpdateContactTVItemID = val8;
               Assert.AreEqual(val8, tVItem.LastUpdateContactTVItemID);
               ICollection<Address> val72 = new List<Address>();
               tVItem.AddressesAddressTVItem = val72;
               Assert.AreEqual(val72, tVItem.AddressesAddressTVItem);
               ICollection<Address> val73 = new List<Address>();
               tVItem.AddressesCountryTVItem = val73;
               Assert.AreEqual(val73, tVItem.AddressesCountryTVItem);
               ICollection<Address> val74 = new List<Address>();
               tVItem.AddressesMunicipalityTVItem = val74;
               Assert.AreEqual(val74, tVItem.AddressesMunicipalityTVItem);
               ICollection<Address> val75 = new List<Address>();
               tVItem.AddressesProvinceTVItem = val75;
               Assert.AreEqual(val75, tVItem.AddressesProvinceTVItem);
               ICollection<AppTask> val76 = new List<AppTask>();
               tVItem.AppTasks = val76;
               Assert.AreEqual(val76, tVItem.AppTasks);
               ICollection<BoxModel> val77 = new List<BoxModel>();
               tVItem.BoxModels = val77;
               Assert.AreEqual(val77, tVItem.BoxModels);
               ICollection<ClimateSite> val78 = new List<ClimateSite>();
               tVItem.ClimateSites = val78;
               Assert.AreEqual(val78, tVItem.ClimateSites);
               ICollection<Contact> val79 = new List<Contact>();
               tVItem.Contacts = val79;
               Assert.AreEqual(val79, tVItem.Contacts);
               ICollection<DocTemplate> val80 = new List<DocTemplate>();
               tVItem.DocTemplates = val80;
               Assert.AreEqual(val80, tVItem.DocTemplates);
               ICollection<Email> val81 = new List<Email>();
               tVItem.Emails = val81;
               Assert.AreEqual(val81, tVItem.Emails);
               ICollection<EmailDistributionList> val82 = new List<EmailDistributionList>();
               tVItem.EmailDistributionLists = val82;
               Assert.AreEqual(val82, tVItem.EmailDistributionLists);
               ICollection<HydrometricSite> val83 = new List<HydrometricSite>();
               tVItem.HydrometricSites = val83;
               Assert.AreEqual(val83, tVItem.HydrometricSites);
               ICollection<Infrastructure> val84 = new List<Infrastructure>();
               tVItem.Infrastructures = val84;
               Assert.AreEqual(val84, tVItem.Infrastructures);
               ICollection<LabSheetDetail> val85 = new List<LabSheetDetail>();
               tVItem.LabSheetDetails = val85;
               Assert.AreEqual(val85, tVItem.LabSheetDetails);
               ICollection<LabSheet> val86 = new List<LabSheet>();
               tVItem.LabSheetsAcceptedOrRejectedByContactTVItem = val86;
               Assert.AreEqual(val86, tVItem.LabSheetsAcceptedOrRejectedByContactTVItem);
               ICollection<LabSheet> val87 = new List<LabSheet>();
               tVItem.LabSheetsMWQMRunTVItem = val87;
               Assert.AreEqual(val87, tVItem.LabSheetsMWQMRunTVItem);
               ICollection<LabSheet> val88 = new List<LabSheet>();
               tVItem.LabSheetsSubsectorTVItem = val88;
               Assert.AreEqual(val88, tVItem.LabSheetsSubsectorTVItem);
               ICollection<LabSheetTubeMPNDetail> val89 = new List<LabSheetTubeMPNDetail>();
               tVItem.LabSheetTubeMPNDetails = val89;
               Assert.AreEqual(val89, tVItem.LabSheetTubeMPNDetails);
               ICollection<MapInfo> val90 = new List<MapInfo>();
               tVItem.MapInfos = val90;
               Assert.AreEqual(val90, tVItem.MapInfos);
               ICollection<MikeBoundaryCondition> val91 = new List<MikeBoundaryCondition>();
               tVItem.MikeBoundaryConditions = val91;
               Assert.AreEqual(val91, tVItem.MikeBoundaryConditions);
               ICollection<MikeScenario> val92 = new List<MikeScenario>();
               tVItem.MikeScenarios = val92;
               Assert.AreEqual(val92, tVItem.MikeScenarios);
               ICollection<MikeSource> val93 = new List<MikeSource>();
               tVItem.MikeSources = val93;
               Assert.AreEqual(val93, tVItem.MikeSources);
               ICollection<MWQMRun> val94 = new List<MWQMRun>();
               tVItem.MWQMRunsLabSampleApprovalContactTVItem = val94;
               Assert.AreEqual(val94, tVItem.MWQMRunsLabSampleApprovalContactTVItem);
               ICollection<MWQMRun> val95 = new List<MWQMRun>();
               tVItem.MWQMRunsMWQMRunTVItem = val95;
               Assert.AreEqual(val95, tVItem.MWQMRunsMWQMRunTVItem);
               ICollection<MWQMRun> val96 = new List<MWQMRun>();
               tVItem.MWQMRunsSubsectorTVItem = val96;
               Assert.AreEqual(val96, tVItem.MWQMRunsSubsectorTVItem);
               ICollection<MWQMSample> val97 = new List<MWQMSample>();
               tVItem.MWQMSampleMWQMRunTVItem = val97;
               Assert.AreEqual(val97, tVItem.MWQMSampleMWQMRunTVItem);
               ICollection<MWQMSample> val98 = new List<MWQMSample>();
               tVItem.MWQMSampleMWQMSiteTVItem = val98;
               Assert.AreEqual(val98, tVItem.MWQMSampleMWQMSiteTVItem);
               ICollection<MWQMSite> val99 = new List<MWQMSite>();
               tVItem.MWQMSites = val99;
               Assert.AreEqual(val99, tVItem.MWQMSites);
               ICollection<MWQMSiteStartEndDate> val100 = new List<MWQMSiteStartEndDate>();
               tVItem.MWQMSiteStartEndDates = val100;
               Assert.AreEqual(val100, tVItem.MWQMSiteStartEndDates);
               ICollection<MWQMSubsector> val101 = new List<MWQMSubsector>();
               tVItem.MWQMSubsectors = val101;
               Assert.AreEqual(val101, tVItem.MWQMSubsectors);
               ICollection<PolSourceObservation> val102 = new List<PolSourceObservation>();
               tVItem.PolSourceObservationsContactTVItem = val102;
               Assert.AreEqual(val102, tVItem.PolSourceObservationsContactTVItem);
               ICollection<PolSourceSite> val103 = new List<PolSourceSite>();
               tVItem.PolSourceSites = val103;
               Assert.AreEqual(val103, tVItem.PolSourceSites);
               ICollection<SamplingPlan> val104 = new List<SamplingPlan>();
               tVItem.SamplingPlansCreatorTVItem = val104;
               Assert.AreEqual(val104, tVItem.SamplingPlansCreatorTVItem);
               ICollection<SamplingPlan> val105 = new List<SamplingPlan>();
               tVItem.SamplingPlansProvinceTVItem = val105;
               Assert.AreEqual(val105, tVItem.SamplingPlansProvinceTVItem);
               ICollection<SamplingPlan> val106 = new List<SamplingPlan>();
               tVItem.SamplingPlansSamplingPlanFileTVItem = val106;
               Assert.AreEqual(val106, tVItem.SamplingPlansSamplingPlanFileTVItem);
               ICollection<SamplingPlanSubsector> val107 = new List<SamplingPlanSubsector>();
               tVItem.SamplingPlanSubsectors = val107;
               Assert.AreEqual(val107, tVItem.SamplingPlanSubsectors);
               ICollection<SamplingPlanSubsectorSite> val108 = new List<SamplingPlanSubsectorSite>();
               tVItem.SamplingPlanSubsectorSites = val108;
               Assert.AreEqual(val108, tVItem.SamplingPlanSubsectorSites);
               ICollection<Spill> val109 = new List<Spill>();
               tVItem.SpillsInfrastructureTVItem = val109;
               Assert.AreEqual(val109, tVItem.SpillsInfrastructureTVItem);
               ICollection<Spill> val110 = new List<Spill>();
               tVItem.SpillsMunicipalityTVItem = val110;
               Assert.AreEqual(val110, tVItem.SpillsMunicipalityTVItem);
               ICollection<Tel> val111 = new List<Tel>();
               tVItem.Tels = val111;
               Assert.AreEqual(val111, tVItem.Tels);
               ICollection<TideDataValue> val112 = new List<TideDataValue>();
               tVItem.TideDataValues = val112;
               Assert.AreEqual(val112, tVItem.TideDataValues);
               ICollection<TideSite> val113 = new List<TideSite>();
               tVItem.TideSites = val113;
               Assert.AreEqual(val113, tVItem.TideSites);
               ICollection<TVFile> val114 = new List<TVFile>();
               tVItem.TVFiles = val114;
               Assert.AreEqual(val114, tVItem.TVFiles);
               ICollection<TVItemLanguage> val115 = new List<TVItemLanguage>();
               tVItem.TVItemLanguages = val115;
               Assert.AreEqual(val115, tVItem.TVItemLanguages);
               ICollection<TVItemLink> val116 = new List<TVItemLink>();
               tVItem.TVItemLinksFromTVItem = val116;
               Assert.AreEqual(val116, tVItem.TVItemLinksFromTVItem);
               ICollection<TVItemLink> val117 = new List<TVItemLink>();
               tVItem.TVItemLinksToTVItem = val117;
               Assert.AreEqual(val117, tVItem.TVItemLinksToTVItem);
               ICollection<TVItemStat> val118 = new List<TVItemStat>();
               tVItem.TVItemStats = val118;
               Assert.AreEqual(val118, tVItem.TVItemStats);
               ICollection<TVItemUserAuthorization> val119 = new List<TVItemUserAuthorization>();
               tVItem.TVItemUserAuthorizationsContactTVItem = val119;
               Assert.AreEqual(val119, tVItem.TVItemUserAuthorizationsContactTVItem);
               ICollection<TVTypeUserAuthorization> val120 = new List<TVTypeUserAuthorization>();
               tVItem.TVTypeUserAuthorizations = val120;
               Assert.AreEqual(val120, tVItem.TVTypeUserAuthorizations);
               ICollection<UseOfSite> val121 = new List<UseOfSite>();
               tVItem.UseOfSitesSiteTVItem = val121;
               Assert.AreEqual(val121, tVItem.UseOfSitesSiteTVItem);
               ICollection<UseOfSite> val122 = new List<UseOfSite>();
               tVItem.UseOfSitesSubsectorTVItem = val122;
               Assert.AreEqual(val122, tVItem.UseOfSitesSubsectorTVItem);
               ICollection<VPScenario> val123 = new List<VPScenario>();
               tVItem.VPScenarios = val123;
               Assert.AreEqual(val123, tVItem.VPScenarios);
               TVItem val124 = new TVItem();
               tVItem.Parent = val124;
               Assert.AreEqual(val124, tVItem.Parent);
               ICollection<TVItem> val125 = new List<TVItem>();
               tVItem.InverseParent = val125;
               Assert.AreEqual(val125, tVItem.InverseParent);
               IEnumerable<ValidationResult> val189 = new List<ValidationResult>().AsEnumerable();
               tVItem.ValidationResults = val189;
               Assert.AreEqual(val189, tVItem.ValidationResults);
        }
    }
}
