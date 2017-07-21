using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System.Configuration;
using CSSPEnums;

namespace CSSPModels
{
    public partial class CSSPWebToolsDBContext : DbContext
    {

        #region Variables
        private DatabaseTypeEnum DatabaseType;
        #endregion Variables

        #region Properties
        public virtual DbSet<Address> Addresses { get; set; }
        public virtual DbSet<AppErrLog> AppErrLogs { get; set; }
        public virtual DbSet<AppTask> AppTasks { get; set; }
        public virtual DbSet<AppTaskLanguage> AppTaskLanguages { get; set; }
        public virtual DbSet<BoxModel> BoxModels { get; set; }
        public virtual DbSet<BoxModelLanguage> BoxModelLanguages { get; set; }
        public virtual DbSet<BoxModelResult> BoxModelResults { get; set; }
        public virtual DbSet<ClimateDataValue> ClimateDataValues { get; set; }
        public virtual DbSet<ClimateSite> ClimateSites { get; set; }
        public virtual DbSet<Contact> Contacts { get; set; }
        public virtual DbSet<ContactLogin> ContactLogins { get; set; }
        public virtual DbSet<ContactPreference> ContactPreferences { get; set; }
        public virtual DbSet<ContactShortcut> ContactShortcuts { get; set; }
        public virtual DbSet<DocTemplate> DocTemplates { get; set; }
        public virtual DbSet<Email> Emails { get; set; }
        public virtual DbSet<EmailDistributionList> EmailDistributionLists { get; set; }
        public virtual DbSet<EmailDistributionListContact> EmailDistributionListContacts { get; set; }
        public virtual DbSet<HydrometricDataValue> HydrometricDataValues { get; set; }
        public virtual DbSet<HydrometricSite> HydrometricSites { get; set; }
        public virtual DbSet<Infrastructure> Infrastructures { get; set; }
        public virtual DbSet<InfrastructureLanguage> InfrastructureLanguages { get; set; }
        public virtual DbSet<LabSheetDetail> LabSheetDetails { get; set; }
        public virtual DbSet<LabSheetTubeMPNDetail> LabSheetTubeMPNDetails { get; set; }
        public virtual DbSet<LabSheet> LabSheets { get; set; }
        public virtual DbSet<Log> Logs { get; set; }
        public virtual DbSet<MapInfoPoint> MapInfoPoints { get; set; }
        public virtual DbSet<MapInfo> MapInfos { get; set; }
        public virtual DbSet<MikeBoundaryCondition> MikeBoundaryConditions { get; set; }
        public virtual DbSet<MikeScenario> MikeScenarios { get; set; }
        public virtual DbSet<MikeSourceStartEnd> MikeSourceStartEnds { get; set; }
        public virtual DbSet<MikeSource> MikeSources { get; set; }
        public virtual DbSet<MWQMLookupMPN> MWQMLookupMPNs { get; set; }
        public virtual DbSet<MWQMRunLanguage> MWQMRunLanguages { get; set; }
        public virtual DbSet<MWQMRun> MWQMRuns { get; set; }
        public virtual DbSet<MWQMSampleLanguage> MWQMSampleLanguages { get; set; }
        public virtual DbSet<MWQMSample> MWQMSamples { get; set; }
        public virtual DbSet<MWQMSiteStartEndDate> MWQMSiteStartEndDates { get; set; }
        public virtual DbSet<MWQMSite> MWQMSites { get; set; }
        public virtual DbSet<MWQMSubsectorLanguage> MWQMSubsectorLanguages { get; set; }
        public virtual DbSet<MWQMSubsector> MWQMSubsectors { get; set; }
        public virtual DbSet<PolSourceObservationIssue> PolSourceObservationIssues { get; set; }
        public virtual DbSet<PolSourceObservation> PolSourceObservations { get; set; }
        public virtual DbSet<PolSourceSite> PolSourceSites { get; set; }
        public virtual DbSet<RatingCurveValue> RatingCurveValues { get; set; }
        public virtual DbSet<RatingCurve> RatingCurves { get; set; }
        public virtual DbSet<ResetPassword> ResetPasswords { get; set; }
        public virtual DbSet<SamplingPlanSubsectorSite> SamplingPlanSubsectorSites { get; set; }
        public virtual DbSet<SamplingPlanSubsector> SamplingPlanSubsectors { get; set; }
        public virtual DbSet<SamplingPlan> SamplingPlans { get; set; }
        public virtual DbSet<SpillLanguage> SpillLanguages { get; set; }
        public virtual DbSet<Spill> Spills { get; set; }
        public virtual DbSet<Tel> Tels { get; set; }
        public virtual DbSet<TideDataValue> TideDataValues { get; set; }
        public virtual DbSet<TideLocation> TideLocations { get; set; }
        public virtual DbSet<TideSite> TideSites { get; set; }
        public virtual DbSet<TVFileLanguage> TVFileLanguages { get; set; }
        public virtual DbSet<TVFile> TVFiles { get; set; }
        public virtual DbSet<TVItemLanguage> TVItemLanguages { get; set; }
        public virtual DbSet<TVItemLink> TVItemLinks { get; set; }
        public virtual DbSet<TVItemStat> TVItemStats { get; set; }
        public virtual DbSet<TVItemUserAuthorization> TVItemUserAuthorizations { get; set; }
        public virtual DbSet<TVItem> TVItems { get; set; }
        public virtual DbSet<TVTypeUserAuthorization> TVTypeUserAuthorizations { get; set; }
        public virtual DbSet<UseOfSite> UseOfSites { get; set; }
        public virtual DbSet<VPAmbient> VPAmbients { get; set; }
        public virtual DbSet<VPResult> VPResults { get; set; }
        public virtual DbSet<VPScenarioLanguage> VPScenarioLanguages { get; set; }
        public virtual DbSet<VPScenario> VPScenarios { get; set; }
        #endregion Properties

        #region Constructors
        public CSSPWebToolsDBContext()
        {
            DatabaseType = DatabaseTypeEnum.Error;
        }
        public CSSPWebToolsDBContext(DatabaseTypeEnum DatabaseType)
        {
            this.DatabaseType = DatabaseType;
        }
        #endregion Constructors

        #region Overrides
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string CSSPWebToolsDBConnectionString = ConfigurationManager.ConnectionStrings["CSSPWebToolsDB"].ConnectionString;
            string TestDBConnectionString = ConfigurationManager.ConnectionStrings["TestDB"].ConnectionString;
            if (System.Environment.UserName == "Charles")
            {
                CSSPWebToolsDBConnectionString = CSSPWebToolsDBConnectionString.Replace("wmon01dtchlebl2", "charles-pc");
                TestDBConnectionString = TestDBConnectionString.Replace("wmon01dtchlebl2", "charles-pc");
            }

            if (DatabaseType == DatabaseTypeEnum.MemoryTestDB)
            {
                optionsBuilder.UseInMemoryDatabase(TestDBConnectionString);
            }
            else if (DatabaseType == DatabaseTypeEnum.MemoryCSSPWebToolsDB)
            {
                optionsBuilder.UseInMemoryDatabase(CSSPWebToolsDBConnectionString);
            }
            else if (DatabaseType == DatabaseTypeEnum.SqlServerTestDB)
            {
                optionsBuilder.UseSqlServer(TestDBConnectionString);
            }
            else if (DatabaseType == DatabaseTypeEnum.SqlServerCSSPWebToolsDB)
            {
                optionsBuilder.UseSqlServer(CSSPWebToolsDBConnectionString);
            }
            else
            {
                throw new Exception("Please select a DatabaseType");
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // ---------------------------------------
            //                 Address 
            // ---------------------------------------
            modelBuilder.Entity<Address>()
                .HasOne(c => c.AddressTVItem)
                .WithMany(c => c.AddressesAddressTVItem);

            modelBuilder.Entity<Address>()
                .HasOne(c => c.CountryTVItem)
                .WithMany(c => c.AddressesCountryTVItem);

            modelBuilder.Entity<Address>()
                .HasOne(c => c.MunicipalityTVItem)
                .WithMany(c => c.AddressesMunicipalityTVItem);

            modelBuilder.Entity<Address>()
                .HasOne(c => c.ProvinceTVItem)
                .WithMany(c => c.AddressesProvinceTVItem);

            // ---------------------------------------
            //                 AppErrLog 
            // ---------------------------------------

            // ---------------------------------------
            //                 AppTask 
            // ---------------------------------------

            modelBuilder.Entity<AppTask>()
                .HasMany(c => c.AppTaskLanguages)
                .WithOne(c => c.AppTask);

            modelBuilder.Entity<AppTask>()
                .HasOne(c => c.TVItem)
                .WithMany(c => c.AppTasks);

            // ---------------------------------------
            //                 AppTaskLanguage
            // ---------------------------------------

            modelBuilder.Entity<AppTaskLanguage>()
                .HasOne(c => c.AppTask)
                .WithMany(c => c.AppTaskLanguages);

            // ---------------------------------------
            //                 BoxModel
            // ---------------------------------------

            modelBuilder.Entity<BoxModel>()
                .HasMany(c => c.BoxModelLanguages)
                .WithOne(c => c.BoxModel);

            modelBuilder.Entity<BoxModel>()
                .HasMany(c => c.BoxModelResults)
                .WithOne(c => c.BoxModel);

            modelBuilder.Entity<BoxModel>()
                .HasOne(c => c.InfrastructureTVItem)
                .WithMany(c => c.BoxModels);

            // ---------------------------------------
            //                 BoxModelLanguage
            // ---------------------------------------

            modelBuilder.Entity<BoxModelLanguage>()
                .HasOne(c => c.BoxModel)
                .WithMany(c => c.BoxModelLanguages);

            // ---------------------------------------
            //                 BoxModelResult
            // ---------------------------------------

            modelBuilder.Entity<BoxModelResult>()
                .HasOne(c => c.BoxModel)
                .WithMany(c => c.BoxModelResults);

            // ---------------------------------------
            //                 ClimateDataValue
            // ---------------------------------------

            modelBuilder.Entity<ClimateDataValue>()
                .HasOne(c => c.ClimateSite)
                .WithMany(c => c.ClimateDataValues);

            // ---------------------------------------
            //                 ClimateDataValue
            // ---------------------------------------

            modelBuilder.Entity<ClimateSite>()
                .HasMany(c => c.ClimateDataValues)
                .WithOne(c => c.ClimateSite);

            modelBuilder.Entity<ClimateSite>()
                .HasOne(c => c.ClimateSiteTVItem)
                .WithMany(c => c.ClimateSites);

            // ---------------------------------------
            //                 Contact
            // ---------------------------------------

            modelBuilder.Entity<Contact>()
                .HasMany(c => c.ContactLogins)
                .WithOne(c => c.Contact);

            modelBuilder.Entity<Contact>()
                .HasMany(c => c.ContactPreferences)
                .WithOne(c => c.Contact);

            modelBuilder.Entity<Contact>()
                .HasMany(c => c.ContactShortcuts)
                .WithOne(c => c.Contact);

            modelBuilder.Entity<Contact>()
                .HasOne(c => c.ContactTVItem)
                .WithMany(c => c.Contacts);

            // ---------------------------------------
            //                 ContactLogin
            // ---------------------------------------

            modelBuilder.Entity<ContactLogin>()
                .HasOne(c => c.Contact)
                .WithMany(c => c.ContactLogins);

            // ---------------------------------------
            //                 ContactPreference
            // ---------------------------------------

            modelBuilder.Entity<ContactPreference>()
                .HasOne(c => c.Contact)
                .WithMany(c => c.ContactPreferences);

            // ---------------------------------------
            //                 ContactShortcut
            // ---------------------------------------

            modelBuilder.Entity<ContactShortcut>()
                .HasOne(c => c.Contact)
                .WithMany(c => c.ContactShortcuts);

            // ---------------------------------------
            //                 DocTemplate
            // ---------------------------------------

            modelBuilder.Entity<DocTemplate>()
                .HasOne(c => c.TVFileTVItem)
                .WithMany(c => c.DocTemplates);

            // ---------------------------------------
            //                 Email
            // ---------------------------------------

            modelBuilder.Entity<Email>()
                .HasOne(c => c.EmailTVItem)
                .WithMany(c => c.Emails);

            // ---------------------------------------
            //                 EmailDistributionList
            // ---------------------------------------

            modelBuilder.Entity<EmailDistributionList>()
                .HasOne(c => c.CountryTVItem)
                .WithMany(c => c.EmailDistributionLists);

            modelBuilder.Entity<EmailDistributionList>()
                .HasMany(c => c.EmailDistributionListContacts)
                .WithOne(c => c.EmailDistributionList);

            // ---------------------------------------
            //                 EmailDistributionListContact
            // ---------------------------------------

            modelBuilder.Entity<EmailDistributionListContact>()
                .HasOne(c => c.EmailDistributionList)
                .WithMany(c => c.EmailDistributionListContacts);

            // ---------------------------------------
            //                 HydrometricDataValue
            // ---------------------------------------

            modelBuilder.Entity<HydrometricDataValue>()
                .HasOne(c => c.HydrometricSite)
                .WithMany(c => c.HydrometricDataValues);

            // ---------------------------------------
            //                 HydrometricSite
            // ---------------------------------------

            modelBuilder.Entity<HydrometricSite>()
                .HasMany(c => c.HydrometricDataValues)
                .WithOne(c => c.HydrometricSite);

            modelBuilder.Entity<HydrometricSite>()
                .HasMany(c => c.RatingCurves)
                .WithOne(c => c.HydrometricSite);

            modelBuilder.Entity<HydrometricSite>()
                .HasOne(c => c.HydrometricSiteTVItem)
                .WithMany(c => c.HydrometricSites);

            // ---------------------------------------
            //                 Infrastructure
            // ---------------------------------------

            modelBuilder.Entity<Infrastructure>()
                .HasMany(c => c.InfrastructureLanguages)
                .WithOne(c => c.Infrastructure);

            modelBuilder.Entity<Infrastructure>()
                .HasOne(c => c.InfrastructureTVItem)
                .WithMany(c => c.Infrastructures);

            // ---------------------------------------
            //                 InfrastructureLanguage
            // ---------------------------------------

            modelBuilder.Entity<InfrastructureLanguage>()
                .HasOne(c => c.Infrastructure)
                .WithMany(c => c.InfrastructureLanguages);

            // ---------------------------------------
            //                 LabSheet
            // ---------------------------------------

            modelBuilder.Entity<LabSheet>()
                .HasMany(c => c.LabSheetDetails)
                .WithOne(c => c.LabSheet);

            modelBuilder.Entity<LabSheet>()
                .HasOne(c => c.AcceptedOrRejectedByContactTVItem)
                .WithMany(c => c.LabSheetsAcceptedOrRejectedByContactTVItem);

            modelBuilder.Entity<LabSheet>()
                .HasOne(c => c.MWQMRunTVItem)
                .WithMany(c => c.LabSheetsMWQMRunTVItem);

            modelBuilder.Entity<LabSheet>()
                .HasOne(c => c.SamplingPlan)
                .WithMany(c => c.LabSheets);

            modelBuilder.Entity<LabSheet>()
                .HasOne(c => c.SubsectorTVItem)
                .WithMany(c => c.LabSheetsSubsectorTVItem);

            // ---------------------------------------
            //                 LabSheetDetail
            // ---------------------------------------

            modelBuilder.Entity<LabSheetDetail>()
                .HasMany(c => c.LabSheetTubeMPNDetails)
                .WithOne(c => c.LabSheetDetail);

            modelBuilder.Entity<LabSheetDetail>()
                .HasOne(c => c.LabSheet)
                .WithMany(c => c.LabSheetDetails);

            modelBuilder.Entity<LabSheetDetail>()
                .HasOne(c => c.SamplingPlan)
                .WithMany(c => c.LabSheetDetails);

            modelBuilder.Entity<LabSheetDetail>()
                .HasOne(c => c.SubsectorTVItem)
                .WithMany(c => c.LabSheetDetails);

            // ---------------------------------------
            //                 LabSheetTubeMPNDetail
            // ---------------------------------------

            modelBuilder.Entity<LabSheetTubeMPNDetail>()
                .HasOne(c => c.LabSheetDetail)
                .WithMany(c => c.LabSheetTubeMPNDetails);

            modelBuilder.Entity<LabSheetTubeMPNDetail>()
                .HasOne(c => c.MWQMSiteTVItem)
                .WithMany(c => c.LabSheetTubeMPNDetails);

            // ---------------------------------------
            //                 MapInfo
            // ---------------------------------------

            modelBuilder.Entity<MapInfo>()
                .HasMany(c => c.MapInfoPoints)
                .WithOne(c => c.MapInfo);

            modelBuilder.Entity<MapInfo>()
                .HasOne(c => c.TVItem)
                .WithMany(c => c.MapInfos);

            // ---------------------------------------
            //                 MapInfoPoint
            // ---------------------------------------

            modelBuilder.Entity<MapInfoPoint>()
                .HasOne(c => c.MapInfo)
                .WithMany(c => c.MapInfoPoints);

            // ---------------------------------------
            //                 MikeBoundaryCondition
            // ---------------------------------------

            modelBuilder.Entity<MikeBoundaryCondition>()
                .HasOne(c => c.MikeBoundaryConditionTVItem)
                .WithMany(c => c.MikeBoundaryConditions);

            // ---------------------------------------
            //                 MikeScenario
            // ---------------------------------------

            modelBuilder.Entity<MikeScenario>()
                .HasOne(c => c.MikeScenarioTVItem)
                .WithMany(c => c.MikeScenarios);

            // ---------------------------------------
            //                 MikeSource
            // ---------------------------------------

            modelBuilder.Entity<MikeSource>()
                .HasMany(c => c.MikeSourceStartEnds)
                .WithOne(c => c.MikeSource);

            modelBuilder.Entity<MikeSource>()
                .HasOne(c => c.MikeSourceTVItem)
                .WithMany(c => c.MikeSources);

            // ---------------------------------------
            //                 MikeSourceStartEnd
            // ---------------------------------------

            modelBuilder.Entity<MikeSourceStartEnd>()
                .HasOne(c => c.MikeSource)
                .WithMany(c => c.MikeSourceStartEnds);

            // ---------------------------------------
            //                 MWQMRun
            // ---------------------------------------

            modelBuilder.Entity<MWQMRun>()
                .HasMany(c => c.MWQMRunLanguages)
                .WithOne(c => c.MWQMRun);

            modelBuilder.Entity<MWQMRun>()
                .HasOne(c => c.LabSampleApprovalContactTVItem)
                .WithMany(c => c.MWQMRunsLabSampleApprovalContactTVItem);

            modelBuilder.Entity<MWQMRun>()
                .HasOne(c => c.MWQMRunTVItem)
                .WithMany(c => c.MWQMRunsMWQMRunTVItem);

            modelBuilder.Entity<MWQMRun>()
                .HasOne(c => c.SubsectorTVItem)
                .WithMany(c => c.MWQMRunsSubsectorTVItem);

            // ---------------------------------------
            //                 MWQMRunLanguage
            // ---------------------------------------

            modelBuilder.Entity<MWQMRunLanguage>()
                .HasOne(c => c.MWQMRun)
                .WithMany(c => c.MWQMRunLanguages);

            // ---------------------------------------
            //                 MWQMSample
            // ---------------------------------------

            modelBuilder.Entity<MWQMSample>()
                .HasMany(c => c.MWQMSampleLanguages)
                .WithOne(c => c.MWQMSample);

            modelBuilder.Entity<MWQMSample>()
                .HasOne(c => c.MWQMRunTVItem)
                .WithMany(c => c.MWQMSampleMWQMRunTVItem);

            modelBuilder.Entity<MWQMSample>()
                .HasOne(c => c.MWQMSiteTVItem)
                .WithMany(c => c.MWQMSampleMWQMSiteTVItem);

            // ---------------------------------------
            //                 MWQMSampleLanguage
            // ---------------------------------------

            modelBuilder.Entity<MWQMSampleLanguage>()
                .HasOne(c => c.MWQMSample)
                .WithMany(c => c.MWQMSampleLanguages);

            // ---------------------------------------
            //                 MWQMSite
            // ---------------------------------------

            modelBuilder.Entity<MWQMSite>()
                .HasOne(c => c.MWQMSiteTVItem)
                .WithMany(c => c.MWQMSites);

            // ---------------------------------------
            //                 MWQMSiteStartEndDate
            // ---------------------------------------

            modelBuilder.Entity<MWQMSiteStartEndDate>()
                .HasOne(c => c.MWQMSiteTVItem)
                .WithMany(c => c.MWQMSiteStartEndDates);

            // ---------------------------------------
            //                 MWQMSubsector
            // ---------------------------------------

            modelBuilder.Entity<MWQMSubsector>()
                .HasMany(c => c.MWQMSubsectorLanguages)
                .WithOne(c => c.MWQMSubsector);

            modelBuilder.Entity<MWQMSubsector>()
                .HasOne(c => c.MWQMSubsectorTVItem)
                .WithMany(c => c.MWQMSubsectors);

            // ---------------------------------------
            //                 MWQMSubsectorLanguage
            // ---------------------------------------

            modelBuilder.Entity<MWQMSubsectorLanguage>()
                .HasOne(c => c.MWQMSubsector)
                .WithMany(c => c.MWQMSubsectorLanguages);

            // ---------------------------------------
            //                 PolSourceObservation
            // ---------------------------------------

            modelBuilder.Entity<PolSourceObservation>()
                .HasMany(c => c.PolSourceObservationIssues)
                .WithOne(c => c.PolSourceObservation);

            modelBuilder.Entity<PolSourceObservation>()
                .HasOne(c => c.ContactTVItem)
                .WithMany(c => c.PolSourceObservationsContactTVItem);

            modelBuilder.Entity<PolSourceObservation>()
                .HasOne(c => c.PolSourceSite)
                .WithMany(c => c.PolSourceObservations);

            // ---------------------------------------
            //                 PolSourceObservationIssue
            // ---------------------------------------

            modelBuilder.Entity<PolSourceObservationIssue>()
                .HasOne(c => c.PolSourceObservation)
                .WithMany(c => c.PolSourceObservationIssues);

            // ---------------------------------------
            //                 PolSourceSite
            // ---------------------------------------

            modelBuilder.Entity<PolSourceSite>()
                .HasMany(c => c.PolSourceObservations)
                .WithOne(c => c.PolSourceSite);

            modelBuilder.Entity<PolSourceSite>()
                .HasOne(c => c.PolSourceSiteTVItem)
                .WithMany(c => c.PolSourceSites);

            // ---------------------------------------
            //                 RatingCurve
            // ---------------------------------------

            modelBuilder.Entity<RatingCurve>()
                .HasMany(c => c.RatingCurveValues)
                .WithOne(c => c.RatingCurve);

            modelBuilder.Entity<RatingCurve>()
                .HasOne(c => c.HydrometricSite)
                .WithMany(c => c.RatingCurves);

            // ---------------------------------------
            //                 RatingCurveValue
            // ---------------------------------------

            modelBuilder.Entity<RatingCurveValue>()
                .HasOne(c => c.RatingCurve)
                .WithMany(c => c.RatingCurveValues);

            // ---------------------------------------
            //                 SamplingPlan
            // ---------------------------------------

            modelBuilder.Entity<SamplingPlan>()
                .HasMany(c => c.LabSheetDetails)
                .WithOne(c => c.SamplingPlan);

            modelBuilder.Entity<SamplingPlan>()
                .HasMany(c => c.LabSheets)
                .WithOne(c => c.SamplingPlan);

            modelBuilder.Entity<SamplingPlan>()
                .HasMany(c => c.SamplingPlanSubsectors)
                .WithOne(c => c.SamplingPlan);

            modelBuilder.Entity<SamplingPlan>()
                .HasOne(c => c.CreatorTVItem)
                .WithMany(c => c.SamplingPlansCreatorTVItem);

            modelBuilder.Entity<SamplingPlan>()
                .HasOne(c => c.ProvinceTVItem)
                .WithMany(c => c.SamplingPlansProvinceTVItem);

            modelBuilder.Entity<SamplingPlan>()
                .HasOne(c => c.SamplingPlanFileTVItem)
                .WithMany(c => c.SamplingPlansSamplingPlanFileTVItem);

            // ---------------------------------------
            //                 SamplingPlanSubsector
            // ---------------------------------------

            modelBuilder.Entity<SamplingPlanSubsector>()
                .HasMany(c => c.SamplingPlanSubsectorSites)
                .WithOne(c => c.SamplingPlanSubsector);

            modelBuilder.Entity<SamplingPlanSubsector>()
                .HasOne(c => c.SamplingPlan)
                .WithMany(c => c.SamplingPlanSubsectors);

            modelBuilder.Entity<SamplingPlanSubsector>()
                .HasOne(c => c.SubsectorTVItem)
                .WithMany(c => c.SamplingPlanSubsectors);

            // ---------------------------------------
            //                 SamplingPlanSubsectorSite
            // ---------------------------------------

            modelBuilder.Entity<SamplingPlanSubsectorSite>()
                .HasOne(c => c.SamplingPlanSubsector)
                .WithMany(c => c.SamplingPlanSubsectorSites);

            modelBuilder.Entity<SamplingPlanSubsectorSite>()
                .HasOne(c => c.MWQMSiteTVItem)
                .WithMany(c => c.SamplingPlanSubsectorSites);

            // ---------------------------------------
            //                 Spill
            // ---------------------------------------

            modelBuilder.Entity<Spill>()
                .HasMany(c => c.SpillLanguages)
                .WithOne(c => c.Spill);

            modelBuilder.Entity<Spill>()
                .HasOne(c => c.InfrastructureTVItem)
                .WithMany(c => c.SpillsInfrastructureTVItem);

            modelBuilder.Entity<Spill>()
                .HasOne(c => c.MunicipalityTVItem)
                .WithMany(c => c.SpillsMunicipalityTVItem);

            // ---------------------------------------
            //                 SpillLanguage
            // ---------------------------------------

            modelBuilder.Entity<SpillLanguage>()
                .HasOne(c => c.Spill)
                .WithMany(c => c.SpillLanguages);

            // ---------------------------------------
            //                 Tel
            // ---------------------------------------

            modelBuilder.Entity<Tel>()
                .HasOne(c => c.TelTVItem)
                .WithMany(c => c.Tels);

            // ---------------------------------------
            //                 TideDataValue
            // ---------------------------------------

            modelBuilder.Entity<TideDataValue>()
                .HasOne(c => c.TideSiteTVItem)
                .WithMany(c => c.TideDataValues);

            // ---------------------------------------
            //                 TideSite
            // ---------------------------------------

            modelBuilder.Entity<TideSite>()
                .HasOne(c => c.TideSiteTVItem)
                .WithMany(c => c.TideSites);

            // ---------------------------------------
            //                 TVFile
            // ---------------------------------------

            modelBuilder.Entity<TVFile>()
                .HasMany(c => c.TVFileLanguages)
                .WithOne(c => c.TVFile);

            modelBuilder.Entity<TVFile>()
                .HasOne(c => c.TVFileTVItem)
                .WithMany(c => c.TVFiles);

            // ---------------------------------------
            //                 TVFileLanguage
            // ---------------------------------------

            modelBuilder.Entity<TVFileLanguage>()
                .HasOne(c => c.TVFile)
                .WithMany(c => c.TVFileLanguages);

            // ---------------------------------------
            //                 TVItem
            // ---------------------------------------

            modelBuilder.Entity<TVItem>()
                .HasMany(c => c.AddressesAddressTVItem)
                .WithOne(c => c.AddressTVItem);

            modelBuilder.Entity<TVItem>()
                .HasMany(c => c.AddressesCountryTVItem)
                .WithOne(c => c.CountryTVItem);

            modelBuilder.Entity<TVItem>()
                .HasMany(c => c.AddressesMunicipalityTVItem)
                .WithOne(c => c.MunicipalityTVItem);

            modelBuilder.Entity<TVItem>()
                .HasMany(c => c.AddressesProvinceTVItem)
                .WithOne(c => c.ProvinceTVItem);

            modelBuilder.Entity<TVItem>()
                .HasMany(c => c.AppTasks)
                .WithOne(c => c.TVItem);

            modelBuilder.Entity<TVItem>()
                .HasMany(c => c.AppTasks)
                .WithOne(c => c.TVItem);

            modelBuilder.Entity<TVItem>()
                .HasMany(c => c.BoxModels)
                .WithOne(c => c.InfrastructureTVItem);

            modelBuilder.Entity<TVItem>()
                .HasMany(c => c.ClimateSites)
                .WithOne(c => c.ClimateSiteTVItem);

            modelBuilder.Entity<TVItem>()
                .HasMany(c => c.Contacts)
                .WithOne(c => c.ContactTVItem);

            modelBuilder.Entity<TVItem>()
                .HasMany(c => c.AddressesAddressTVItem)
                .WithOne(c => c.AddressTVItem);

            modelBuilder.Entity<TVItem>()
                .HasMany(c => c.AddressesAddressTVItem)
                .WithOne(c => c.AddressTVItem);

            modelBuilder.Entity<TVItem>()
                .HasMany(c => c.DocTemplates)
                .WithOne(c => c.TVFileTVItem);

            modelBuilder.Entity<TVItem>()
                .HasMany(c => c.Emails)
                .WithOne(c => c.EmailTVItem);

            modelBuilder.Entity<TVItem>()
                .HasMany(c => c.EmailDistributionLists)
                .WithOne(c => c.CountryTVItem);

            modelBuilder.Entity<TVItem>()
                .HasMany(c => c.HydrometricSites)
                .WithOne(c => c.HydrometricSiteTVItem);

            modelBuilder.Entity<TVItem>()
                .HasMany(c => c.Infrastructures)
                .WithOne(c => c.InfrastructureTVItem);

            modelBuilder.Entity<TVItem>()
                .HasMany(c => c.LabSheetDetails)
                .WithOne(c => c.SubsectorTVItem);

            modelBuilder.Entity<TVItem>()
                .HasMany(c => c.LabSheetsAcceptedOrRejectedByContactTVItem)
                .WithOne(c => c.AcceptedOrRejectedByContactTVItem);

            modelBuilder.Entity<TVItem>()
                .HasMany(c => c.LabSheetsMWQMRunTVItem)
                .WithOne(c => c.MWQMRunTVItem);

            modelBuilder.Entity<TVItem>()
                .HasMany(c => c.LabSheetsSubsectorTVItem)
                .WithOne(c => c.SubsectorTVItem);

            modelBuilder.Entity<TVItem>()
                .HasMany(c => c.LabSheetTubeMPNDetails)
                .WithOne(c => c.MWQMSiteTVItem);

            modelBuilder.Entity<TVItem>()
                .HasMany(c => c.MapInfos)
                .WithOne(c => c.TVItem);

            modelBuilder.Entity<TVItem>()
                .HasMany(c => c.MikeBoundaryConditions)
                .WithOne(c => c.MikeBoundaryConditionTVItem);

            modelBuilder.Entity<TVItem>()
                .HasMany(c => c.MikeScenarios)
                .WithOne(c => c.MikeScenarioTVItem);

            modelBuilder.Entity<TVItem>()
                .HasMany(c => c.MikeSources)
                .WithOne(c => c.MikeSourceTVItem);

            modelBuilder.Entity<TVItem>()
                .HasMany(c => c.MWQMRunsLabSampleApprovalContactTVItem)
                .WithOne(c => c.LabSampleApprovalContactTVItem);

            modelBuilder.Entity<TVItem>()
                .HasMany(c => c.MWQMRunsMWQMRunTVItem)
                .WithOne(c => c.MWQMRunTVItem);

            modelBuilder.Entity<TVItem>()
                .HasMany(c => c.MWQMRunsSubsectorTVItem)
                .WithOne(c => c.SubsectorTVItem);

            modelBuilder.Entity<TVItem>()
                .HasMany(c => c.MWQMSampleMWQMRunTVItem)
                .WithOne(c => c.MWQMRunTVItem);

            modelBuilder.Entity<TVItem>()
                .HasMany(c => c.MWQMSampleMWQMSiteTVItem)
                .WithOne(c => c.MWQMSiteTVItem);

            modelBuilder.Entity<TVItem>()
                .HasMany(c => c.MWQMSites)
                .WithOne(c => c.MWQMSiteTVItem);

            modelBuilder.Entity<TVItem>()
                .HasMany(c => c.MWQMSiteStartEndDates)
                .WithOne(c => c.MWQMSiteTVItem);

            modelBuilder.Entity<TVItem>()
                .HasMany(c => c.MWQMSubsectors)
                .WithOne(c => c.MWQMSubsectorTVItem);

            modelBuilder.Entity<TVItem>()
                .HasMany(c => c.PolSourceObservationsContactTVItem)
                .WithOne(c => c.ContactTVItem);

            modelBuilder.Entity<TVItem>()
                .HasMany(c => c.PolSourceSites)
                .WithOne(c => c.PolSourceSiteTVItem);

            modelBuilder.Entity<TVItem>()
                .HasMany(c => c.SamplingPlansCreatorTVItem)
                .WithOne(c => c.CreatorTVItem);

            modelBuilder.Entity<TVItem>()
                .HasMany(c => c.SamplingPlansProvinceTVItem)
                .WithOne(c => c.ProvinceTVItem);

            modelBuilder.Entity<TVItem>()
                .HasMany(c => c.SamplingPlansSamplingPlanFileTVItem)
                .WithOne(c => c.SamplingPlanFileTVItem);

            modelBuilder.Entity<TVItem>()
                .HasMany(c => c.SamplingPlanSubsectors)
                .WithOne(c => c.SubsectorTVItem);

            modelBuilder.Entity<TVItem>()
                .HasMany(c => c.SamplingPlanSubsectorSites)
                .WithOne(c => c.MWQMSiteTVItem);

            modelBuilder.Entity<TVItem>()
                .HasMany(c => c.SpillsInfrastructureTVItem)
                .WithOne(c => c.InfrastructureTVItem);

            modelBuilder.Entity<TVItem>()
                .HasMany(c => c.SpillsMunicipalityTVItem)
                .WithOne(c => c.MunicipalityTVItem);

            modelBuilder.Entity<TVItem>()
                .HasMany(c => c.Tels)
                .WithOne(c => c.TelTVItem);

            modelBuilder.Entity<TVItem>()
                .HasMany(c => c.TideDataValues)
                .WithOne(c => c.TideSiteTVItem);

            modelBuilder.Entity<TVItem>()
                .HasMany(c => c.TideSites)
                .WithOne(c => c.TideSiteTVItem);

            modelBuilder.Entity<TVItem>()
                .HasMany(c => c.TVFiles)
                .WithOne(c => c.TVFileTVItem);

            modelBuilder.Entity<TVItem>()
                .HasMany(c => c.TVItemLanguages)
                .WithOne(c => c.TVItem);

            modelBuilder.Entity<TVItem>()
                .HasMany(c => c.TVItemLinksFromTVItem)
                .WithOne(c => c.FromTVItem);

            modelBuilder.Entity<TVItem>()
                .HasMany(c => c.TVItemLinksToTVItem)
                .WithOne(c => c.ToTVItem);

            modelBuilder.Entity<TVItem>()
                .HasMany(c => c.TVItemStats)
                .WithOne(c => c.TVItem);

            modelBuilder.Entity<TVItem>()
                .HasMany(c => c.TVItemUserAuthorizationsContactTVItem)
                .WithOne(c => c.ContactTVItem);

            modelBuilder.Entity<TVItem>()
                .HasMany(c => c.TVTypeUserAuthorizations)
                .WithOne(c => c.ContactTVItem);

            modelBuilder.Entity<TVItem>()
                .HasMany(c => c.UseOfSitesSiteTVItem)
                .WithOne(c => c.SiteTVItem);

            modelBuilder.Entity<TVItem>()
                .HasMany(c => c.UseOfSitesSubsectorTVItem)
                .WithOne(c => c.SubsectorTVItem);

            modelBuilder.Entity<TVItem>()
                .HasMany(c => c.VPScenarios)
                .WithOne(c => c.InfrastructureTVItem);

            modelBuilder.Entity<TVItem>()
                .HasMany(c => c.InverseParent);

            modelBuilder.Entity<TVItem>()
                .HasOne(c => c.Parent);

            // ---------------------------------------
            //                 TVItemLanguage
            // ---------------------------------------

            modelBuilder.Entity<TVItemLanguage>()
                .HasOne(c => c.TVItem)
                .WithMany(c => c.TVItemLanguages);

            // ---------------------------------------
            //                 TVItemLink
            // ---------------------------------------

            modelBuilder.Entity<TVItemLink>()
                .HasOne(c => c.FromTVItem)
                .WithMany(c => c.TVItemLinksFromTVItem);

            modelBuilder.Entity<TVItemLink>()
                .HasOne(c => c.ParentTVItemLink)
                .WithMany(c => c.InverseParentTVItemLink);

            modelBuilder.Entity<TVItemLink>()
                .HasMany(c => c.InverseParentTVItemLink)
                .WithOne(c => c.ParentTVItemLink);

            modelBuilder.Entity<TVItemLink>()
                .HasOne(c => c.ToTVItem)
                .WithMany(c => c.TVItemLinksToTVItem);

            // ---------------------------------------
            //                 TVItemStat
            // ---------------------------------------

            modelBuilder.Entity<TVItemStat>()
                .HasOne(c => c.TVItem)
                .WithMany(c => c.TVItemStats);

            // ---------------------------------------
            //                 TVItemUserAuthorization
            // ---------------------------------------

            modelBuilder.Entity<TVItemUserAuthorization>()
                .HasOne(c => c.ContactTVItem)
                .WithMany(c => c.TVItemUserAuthorizationsContactTVItem);

            // ---------------------------------------
            //                 TVTypeUserAuthorization
            // ---------------------------------------

            modelBuilder.Entity<TVTypeUserAuthorization>()
                .HasOne(c => c.ContactTVItem)
                .WithMany(c => c.TVTypeUserAuthorizations);

            // ---------------------------------------
            //                 UseOfSite
            // ---------------------------------------

            modelBuilder.Entity<UseOfSite>()
                .HasOne(c => c.SiteTVItem)
                .WithMany(c => c.UseOfSitesSiteTVItem);

            modelBuilder.Entity<UseOfSite>()
                .HasOne(c => c.SubsectorTVItem)
                .WithMany(c => c.UseOfSitesSubsectorTVItem);

            // ---------------------------------------
            //                 VPAmbient
            // ---------------------------------------

            modelBuilder.Entity<VPAmbient>()
                .HasOne(c => c.VPScenario)
                .WithMany(c => c.VPAmbients);

            // ---------------------------------------
            //                 VPResult
            // ---------------------------------------

            modelBuilder.Entity<VPResult>()
                .HasOne(c => c.VPScenario)
                .WithMany(c => c.VPResults);

            // ---------------------------------------
            //                 VPScenario
            // ---------------------------------------

            modelBuilder.Entity<VPScenario>()
                .HasMany(c => c.VPAmbients)
                .WithOne(c => c.VPScenario);

            modelBuilder.Entity<VPScenario>()
                .HasMany(c => c.VPResults)
                .WithOne(c => c.VPScenario);

            modelBuilder.Entity<VPScenario>()
                .HasMany(c => c.VPScenarioLanguages)
                .WithOne(c => c.VPScenario);

            modelBuilder.Entity<VPScenario>()
                .HasOne(c => c.InfrastructureTVItem)
                .WithMany(c => c.VPScenarios);

            // ---------------------------------------
            //                 VPScenarioLanguage
            // ---------------------------------------

            modelBuilder.Entity<VPScenarioLanguage>()
                .HasOne(c => c.VPScenario)
                .WithMany(c => c.VPScenarioLanguages);


            base.OnModelCreating(modelBuilder);
        }
        #endregion Overrides

        #region Functions private
        #endregion Functions private
    }
}