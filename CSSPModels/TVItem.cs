using CSSPEnums;
using CSSPModels.Resources;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace CSSPModels
{
    public partial class TVItem
    {
        #region Properties in DB
        public int TVItemID { get; set; }
        public int TVLevel { get; set; }
        public string TVPath { get; set; }
        public TVTypeEnum TVType { get; set; }
        public int ParentID { get; set; }
        public bool IsActive { get; set; }
        public DateTime LastUpdateDate_UTC { get; set; }
        public int LastUpdateContactTVItemID { get; set; }

        public virtual ICollection<Address> AddressesAddressTVItem { get; set; }
        public virtual ICollection<Address> AddressesCountryTVItem { get; set; }
        public virtual ICollection<Address> AddressesMunicipalityTVItem { get; set; }
        public virtual ICollection<Address> AddressesProvinceTVItem { get; set; }
        public virtual ICollection<AppTask> AppTasksTVItem { get; set; }
        public virtual ICollection<AppTask> AppTasksTVItemID2Navigation { get; set; }
        public virtual ICollection<BoxModel> BoxModels { get; set; }
        public virtual ICollection<ClimateSite> ClimateSites { get; set; }
        public virtual ICollection<Contact> Contacts { get; set; }
        public virtual ICollection<DocTemplate> DocTemplates { get; set; }
        public virtual ICollection<Email> Emails { get; set; }
        public virtual ICollection<HydrometricSite> HydrometricSites { get; set; }
        public virtual ICollection<Infrastructure> Infrastructures { get; set; }
        public virtual ICollection<LabSheetDetail> LabSheetDetails { get; set; }
        public virtual ICollection<LabSheet> LabSheetsAcceptedOrRejectedByContactTVItem { get; set; }
        public virtual ICollection<LabSheet> LabSheetsMWQMRunTVItem { get; set; }
        public virtual ICollection<LabSheet> LabSheetsSubsectorTVItem { get; set; }
        public virtual ICollection<LabSheetTubeMPNDetail> LabSheetTubeMPNDetails { get; set; }
        public virtual ICollection<MapInfo> MapInfos { get; set; }
        public virtual ICollection<MikeBoundaryCondition> MikeBoundaryConditions { get; set; }
        public virtual ICollection<MikeScenario> MikeScenarios { get; set; }
        public virtual ICollection<MikeSource> MikeSources { get; set; }
        public virtual ICollection<MWQMRun> MWQMRunsLabSampleApprovalContactTVItem { get; set; }
        public virtual ICollection<MWQMRun> MWQMRunsMWQMRunTVItem { get; set; }
        public virtual ICollection<MWQMRun> MWQMRunsSubsectorTVItem { get; set; }
        public virtual ICollection<MWQMSample> MWQMSampleMWQMRunTVItem { get; set; }
        public virtual ICollection<MWQMSample> MWQMSampleMWQMSiteTVItem { get; set; }
        public virtual ICollection<MWQMSite> MWQMSites { get; set; }
        public virtual ICollection<MWQMSiteStartEndDate> MWQMSiteStartEndDates { get; set; }
        public virtual ICollection<MWQMSubsector> MWQMSubsectors { get; set; }
        public virtual ICollection<PolSourceObservation> PolSourceObservationsContactTVItem { get; set; }
        public virtual ICollection<PolSourceObservation> PolSourceObservationsPolSourceSiteTVItem { get; set; }
        public virtual ICollection<PolSourceSite> PolSourceSites { get; set; }
        public virtual ICollection<SamplingPlan> SamplingPlansCreatorTVItem { get; set; }
        public virtual ICollection<SamplingPlan> SamplingPlansProvinceTVItem { get; set; }
        public virtual ICollection<SamplingPlan> SamplingPlansSamplingPlanFileTVItem { get; set; }
        public virtual ICollection<SamplingPlanSubsector> SamplingPlanSubsectors { get; set; }
        public virtual ICollection<SamplingPlanSubsectorSite> SamplingPlanSubsectorSites { get; set; }
        public virtual ICollection<Spill> SpillsInfrastructureTVItem { get; set; }
        public virtual ICollection<Spill> SpillsMunicipalityTVItem { get; set; }
        public virtual ICollection<Tel> Tels { get; set; }
        public virtual ICollection<TideDataValue> TideDataValues { get; set; }
        public virtual ICollection<TideSite> TideSites { get; set; }
        public virtual ICollection<TVFile> TVFiles { get; set; }
        public virtual ICollection<TVItemLanguage> TVItemLanguages { get; set; }
        public virtual ICollection<TVItemLink> TVItemLinksFromTVItem { get; set; }
        public virtual ICollection<TVItemLink> TVItemLinksToTVItem { get; set; }
        public virtual ICollection<TVItemStat> TVItemStats { get; set; }
        public virtual ICollection<TVItemUserAuthorization> TVItemUserAuthorizationsContactTVItem { get; set; }
        public virtual ICollection<TVItemUserAuthorization> TVItemUserAuthorizationsTVItemID1Navigation { get; set; }
        public virtual ICollection<TVTypeUserAuthorization> TVTypeUserAuthorizations { get; set; }
        public virtual ICollection<UseOfSite> UseOfSitesSiteTVItem { get; set; }
        public virtual ICollection<UseOfSite> UseOfSitesSubsectorTVItem { get; set; }
        public virtual ICollection<VPScenario> VPScenarios { get; set; }
        public virtual TVItem Parent { get; set; }
        public virtual ICollection<TVItem> InverseParent { get; set; }
        #endregion Properties in Db

        #region Properties not in DB
        [NotMapped]
        public IEnumerable<ValidationResult> ValidationResults { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public TVItem()
        {
            AddressesAddressTVItem = new HashSet<Address>();
            AddressesCountryTVItem = new HashSet<Address>();
            AddressesMunicipalityTVItem = new HashSet<Address>();
            AddressesProvinceTVItem = new HashSet<Address>();
            AppTasksTVItem = new HashSet<AppTask>();
            AppTasksTVItemID2Navigation = new HashSet<AppTask>();
            BoxModels = new HashSet<BoxModel>();
            ClimateSites = new HashSet<ClimateSite>();
            Contacts = new HashSet<Contact>();
            DocTemplates = new HashSet<DocTemplate>();
            Emails = new HashSet<Email>();
            HydrometricSites = new HashSet<HydrometricSite>();
            Infrastructures = new HashSet<Infrastructure>();
            LabSheetDetails = new HashSet<LabSheetDetail>();
            LabSheetsAcceptedOrRejectedByContactTVItem = new HashSet<LabSheet>();
            LabSheetsMWQMRunTVItem = new HashSet<LabSheet>();
            LabSheetsSubsectorTVItem = new HashSet<LabSheet>();
            LabSheetTubeMPNDetails = new HashSet<LabSheetTubeMPNDetail>();
            MapInfos = new HashSet<MapInfo>();
            MikeBoundaryConditions = new HashSet<MikeBoundaryCondition>();
            MikeScenarios = new HashSet<MikeScenario>();
            MikeSources = new HashSet<MikeSource>();
            MWQMRunsLabSampleApprovalContactTVItem = new HashSet<MWQMRun>();
            MWQMRunsMWQMRunTVItem = new HashSet<MWQMRun>();
            MWQMRunsSubsectorTVItem = new HashSet<MWQMRun>();
            MWQMSampleMWQMRunTVItem = new HashSet<MWQMSample>();
            MWQMSampleMWQMSiteTVItem = new HashSet<MWQMSample>();
            MWQMSites = new HashSet<MWQMSite>();
            MWQMSiteStartEndDates = new HashSet<MWQMSiteStartEndDate>();
            MWQMSubsectors = new HashSet<MWQMSubsector>();
            PolSourceObservationsContactTVItem = new HashSet<PolSourceObservation>();
            PolSourceObservationsPolSourceSiteTVItem = new HashSet<PolSourceObservation>();
            PolSourceSites = new HashSet<PolSourceSite>();
            SamplingPlansCreatorTVItem = new HashSet<SamplingPlan>();
            SamplingPlansProvinceTVItem = new HashSet<SamplingPlan>();
            SamplingPlansSamplingPlanFileTVItem = new HashSet<SamplingPlan>();
            SamplingPlanSubsectors = new HashSet<SamplingPlanSubsector>();
            SamplingPlanSubsectorSites = new HashSet<SamplingPlanSubsectorSite>();
            SpillsInfrastructureTVItem = new HashSet<Spill>();
            SpillsMunicipalityTVItem = new HashSet<Spill>();
            Tels = new HashSet<Tel>();
            TideDataValues = new HashSet<TideDataValue>();
            TideSites = new HashSet<TideSite>();
            TVFiles = new HashSet<TVFile>();
            TVItemLanguages = new HashSet<TVItemLanguage>();
            TVItemLinksFromTVItem = new HashSet<TVItemLink>();
            TVItemLinksToTVItem = new HashSet<TVItemLink>();
            TVItemStats = new HashSet<TVItemStat>();
            TVItemUserAuthorizationsContactTVItem = new HashSet<TVItemUserAuthorization>();
            TVItemUserAuthorizationsTVItemID1Navigation = new HashSet<TVItemUserAuthorization>();
            TVTypeUserAuthorizations = new HashSet<TVTypeUserAuthorization>();
            UseOfSitesSiteTVItem = new HashSet<UseOfSite>();
            UseOfSitesSubsectorTVItem = new HashSet<UseOfSite>();
            VPScenarios = new HashSet<VPScenario>();
        }
        #endregion Constructors
    }
}
