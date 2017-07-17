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
        /*
         * There is another constructor in the CSSPWebToolsDBContextExtras.cs document which is used for in memory testing
         * Once all the test are done the user can exclude the document from the project and recompile.
         * You will also have to unload the CSSPWebToolsDB.Tests project from the solution before recompiling
         */
        #endregion Constructors

        #region Overrides
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (DatabaseType == DatabaseTypeEnum.MemoryNoDBShape)
            {
                optionsBuilder.UseInMemoryDatabase(ConfigurationManager.ConnectionStrings["CSSPWebToolsDB"].ConnectionString);
                //optionsBuilder.UseSqlServer(@"Data Source=wmon01dtchlebl2\sqlexpress;Initial Catalog=CSSPWebToolsDBTest;Integrated Security=True");
            }
            else if (DatabaseType == DatabaseTypeEnum.MemoryWithDBShape)
            {
                optionsBuilder.UseInMemoryDatabase(ConfigurationManager.ConnectionStrings["CSSPWebToolsDB"].ConnectionString);
                //optionsBuilder.UseSqlServer(@"Data Source=wmon01dtchlebl2\sqlexpress;Initial Catalog=CSSPWebToolsDBTest;Integrated Security=True");
            }
            else if (DatabaseType == DatabaseTypeEnum.SQLite)
            {
                optionsBuilder.UseSqlite("Data Source=TestingCSSPWebToolsDB.db");
            }
            else if (DatabaseType == DatabaseTypeEnum.SqlServer)
            {
                //optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["CSSPWebToolsDB"].ConnectionString);
                optionsBuilder.UseSqlServer(@"Data Source=wmon01dtchlebl2\sqlexpress;Initial Catalog=CSSPWebToolsDBTest;Integrated Security=True");
            }
            else
            {
                throw new Exception("Please select a DatabaseType");
            }
        }
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    OnModelCreating_Address(modelBuilder);
        //    OnModelCreating_AppErrLog(modelBuilder);
        //    OnModelCreating_AppTask(modelBuilder);
        //    OnModelCreating_AppTaskLanguage(modelBuilder);
        //    OnModelCreating_BoxModel(modelBuilder);
        //    OnModelCreating_BoxModelLanguage(modelBuilder);
        //    OnModelCreating_BoxModelResult(modelBuilder);
        //    OnModelCreating_ClimateDataValue(modelBuilder);
        //    OnModelCreating_ClimateSite(modelBuilder);
        //    OnModelCreating_Contact(modelBuilder);
        //    OnModelCreating_ContactLogin(modelBuilder);
        //    OnModelCreating_ContactPreference(modelBuilder);
        //    OnModelCreating_ContactShortcut(modelBuilder);
        //    OnModelCreating_DocTemplate(modelBuilder);
        //    OnModelCreating_Email(modelBuilder);
        //    OnModelCreating_EmailDistributionList(modelBuilder);
        //    OnModelCreating_EmailDistributionListContact(modelBuilder);
        //    OnModelCreating_HydrometricDataValue(modelBuilder);
        //    OnModelCreating_HydrometricSite(modelBuilder);
        //    OnModelCreating_Infrastructure(modelBuilder);
        //    OnModelCreating_InfrastructureLanguage(modelBuilder);
        //    OnModelCreating_LabSheet(modelBuilder);
        //    OnModelCreating_LabSheetDetail(modelBuilder);
        //    OnModelCreating_LabSheetTubeMPNDetail(modelBuilder);
        //    OnModelCreating_Log(modelBuilder);
        //    OnModelCreating_MapInfo(modelBuilder);
        //    OnModelCreating_MapInfoPoint(modelBuilder);
        //    OnModelCreating_MikeBoundaryCondition(modelBuilder);
        //    OnModelCreating_MikeScenario(modelBuilder);
        //    OnModelCreating_MikeSource(modelBuilder);
        //    OnModelCreating_MikeSourceStartEnd(modelBuilder);
        //    OnModelCreating_MWQMLookupMPN(modelBuilder);
        //    OnModelCreating_MWQMRun(modelBuilder);
        //    OnModelCreating_MWQMRunLanguage(modelBuilder);
        //    OnModelCreating_MWQMSample(modelBuilder);
        //    OnModelCreating_MWQMSampleLanguage(modelBuilder);
        //    OnModelCreating_MWQMSite(modelBuilder);
        //    OnModelCreating_MWQMSiteStartEndDate(modelBuilder);
        //    OnModelCreating_MWQMSubsector(modelBuilder);
        //    OnModelCreating_MWQMSubsectorLanguage(modelBuilder);
        //    OnModelCreating_PolSourceObservation(modelBuilder);
        //    OnModelCreating_PolSourceObservationIssue(modelBuilder);
        //    OnModelCreating_PolSourceSite(modelBuilder);
        //    OnModelCreating_RatingCurve(modelBuilder);
        //    OnModelCreating_RatingCurveValue(modelBuilder);
        //    OnModelCreating_ResetPassword(modelBuilder);
        //    OnModelCreating_SamplingPlan(modelBuilder);
        //    OnModelCreating_SamplingPlanSubsector(modelBuilder);
        //    OnModelCreating_SamplingPlanSubsectorSite(modelBuilder);
        //    OnModelCreating_Spill(modelBuilder);
        //    OnModelCreating_SpillLanguage(modelBuilder);
        //    OnModelCreating_Tel(modelBuilder);
        //    OnModelCreating_TideDataValue(modelBuilder);
        //    OnModelCreating_TideLocation(modelBuilder);
        //    OnModelCreating_TideSite(modelBuilder);
        //    OnModelCreating_TVFile(modelBuilder);
        //    OnModelCreating_TVFileLanguage(modelBuilder);
        //    OnModelCreating_TVItem(modelBuilder);
        //    OnModelCreating_TVItemLanguage(modelBuilder);
        //    OnModelCreating_TVItemLink(modelBuilder);
        //    OnModelCreating_TVItemStat(modelBuilder);
        //    OnModelCreating_TVItemUserAuthorization(modelBuilder);
        //    OnModelCreating_TVTypeUserAuthorization(modelBuilder);
        //    OnModelCreating_UseOfSite(modelBuilder);
        //    OnModelCreating_VPAmbient(modelBuilder);
        //    OnModelCreating_VPResult(modelBuilder);
        //    OnModelCreating_VPScenario(modelBuilder);
        //    OnModelCreating_VPScenarioLanguage(modelBuilder);
        //}
        #endregion Overrides

        //#region Functions private
        //private void OnModelCreating_Address(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Address>(entity =>
        //    {
        //        entity.HasOne(d => d.AddressTVItem)
        //            .WithMany(p => p.AddressesAddressTVItem)
        //            .HasForeignKey(d => d.AddressTVItemID)
        //            .OnDelete(DeleteBehavior.Restrict)
        //            .HasConstraintName("FK_Addresses_AddressTVItemID");

        //        entity.HasOne(d => d.CountryTVItem)
        //            .WithMany(p => p.AddressesCountryTVItem)
        //            .HasForeignKey(d => d.CountryTVItemID)
        //            .OnDelete(DeleteBehavior.Restrict)
        //            .HasConstraintName("FK_Addresses_CountryTVItemID");

        //        entity.HasOne(d => d.ProvinceTVItem)
        //            .WithMany(p => p.AddressesProvinceTVItem)
        //            .HasForeignKey(d => d.ProvinceTVItemID)
        //            .OnDelete(DeleteBehavior.Restrict)
        //            .HasConstraintName("FK_Addresses_ProvinceTVItemID");

        //        entity.HasOne(d => d.MunicipalityTVItem)
        //            .WithMany(p => p.AddressesMunicipalityTVItem)
        //            .HasForeignKey(d => d.MunicipalityTVItemID)
        //            .OnDelete(DeleteBehavior.Restrict)
        //            .HasConstraintName("FK_Addresses_MunicipalityTVItemID");

        //    });
        //}
        //private void OnModelCreating_AppErrLog(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<AppErrLog>(entity =>
        //    {
        //        // empty for now
        //    });
        //}
        //private void OnModelCreating_AppTaskLanguage(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<AppTaskLanguage>(entity =>
        //    {
        //        entity.HasOne(d => d.AppTask)
        //            .WithMany(p => p.AppTaskLanguages)
        //            .HasForeignKey(d => d.AppTaskID)
        //            .HasConstraintName("FK_AppTaskLanguages_AppTasks");
        //    });
        //}
        //private void OnModelCreating_AppTask(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<AppTask>(entity =>
        //    {
        //        entity.HasOne(d => d.TVItemIDNavigation)
        //            .WithMany(p => p.AppTasksTVItem)
        //            .HasForeignKey(d => d.TVItemID)
        //            .HasConstraintName("FK_AppTasks_TVItems");

        //        entity.HasOne(d => d.TVItemID2Navigation)
        //            .WithMany(p => p.AppTasksTVItemID2Navigation)
        //            .HasForeignKey(d => d.TVItemID2)
        //            .OnDelete(DeleteBehavior.Restrict)
        //            .HasConstraintName("FK_AppTasks_TVItems2");
        //    });
        //}
        //private void OnModelCreating_BoxModelLanguage(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<BoxModelLanguage>(entity =>
        //    {
        //        entity.HasOne(d => d.BoxModel)
        //            .WithMany(p => p.BoxModelLanguages)
        //            .HasForeignKey(d => d.BoxModelID)
        //            .HasConstraintName("FK_BoxModelLanguages_BoxModels");
        //    });
        //}
        //private void OnModelCreating_BoxModelResult(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<BoxModelResult>(entity =>
        //    {
        //        entity.HasOne(d => d.BoxModel)
        //            .WithMany(p => p.BoxModelResults)
        //            .HasForeignKey(d => d.BoxModelID)
        //            .HasConstraintName("FK_BoxModelResults_BoxModels");
        //    });
        //}
        //private void OnModelCreating_BoxModel(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<BoxModel>(entity =>
        //    {
        //        entity.HasOne(d => d.InfrastructureTVItem)
        //            .WithMany(p => p.BoxModels)
        //            .HasForeignKey(d => d.InfrastructureTVItemID)
        //            .HasConstraintName("FK_BoxModels_InfrastructureTVItemID");
        //    });
        //}
        //private void OnModelCreating_ClimateDataValue(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<ClimateDataValue>(entity =>
        //    {
        //        entity.HasOne(d => d.ClimateSite)
        //            .WithMany(p => p.ClimateDataValues)
        //            .HasForeignKey(d => d.ClimateSiteID)
        //            .OnDelete(DeleteBehavior.Restrict)
        //            .HasConstraintName("FK_ClimateDataValues_ClimateSites");
        //    });
        //}
        //private void OnModelCreating_ClimateSite(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<ClimateSite>(entity =>
        //    {
        //        entity.HasOne(d => d.ClimateSiteTVItem)
        //            .WithMany(p => p.ClimateSites)
        //            .HasForeignKey(d => d.ClimateSiteTVItemID)
        //            .OnDelete(DeleteBehavior.Restrict)
        //            .HasConstraintName("FK_ClimateSites_TVItems");
        //    });
        //}
        //private void OnModelCreating_Contact(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Contact>(entity =>
        //    {
        //        entity.HasOne(d => d.ContactTVItem)
        //            .WithMany(p => p.Contacts)
        //            .HasForeignKey(d => d.ContactTVItemID)
        //            .OnDelete(DeleteBehavior.Restrict)
        //            .HasConstraintName("FK_Contacts_TVItems");
        //    });

        //    modelBuilder.Entity<Contact>().Ignore(c => c.ParentTVItemID);

        //}
        //private void OnModelCreating_ContactLogin(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<ContactLogin>(entity =>
        //    {
        //        entity.HasOne(d => d.Contact)
        //          .WithMany(p => p.ContactLogins)
        //          .HasForeignKey(d => d.ContactID)
        //          .OnDelete(DeleteBehavior.Restrict)
        //          .HasConstraintName("FK_ContactShortcuts_Contacts");
        //    });
        //}
        //private void OnModelCreating_ContactPreference(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<ContactPreference>(entity =>
        //    {
        //        entity.HasOne(d => d.Contact)
        //            .WithMany(p => p.ContactPreferences)
        //            .HasForeignKey(d => d.ContactID)
        //            .OnDelete(DeleteBehavior.Restrict)
        //            .HasConstraintName("FK_ContactPreferences_Contacts");
        //    });
        //}
        //private void OnModelCreating_ContactShortcut(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<ContactShortcut>(entity =>
        //    {
        //        entity.HasOne(d => d.Contact)
        //            .WithMany(p => p.ContactShortcuts)
        //            .HasForeignKey(d => d.ContactID)
        //            .HasConstraintName("FK_ContactShortcuts_Contacts");
        //    });
        //}
        //private void OnModelCreating_DocTemplate(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<DocTemplate>(entity =>
        //    {
        //        entity.HasOne(d => d.TVFileTVItem)
        //            .WithMany(p => p.DocTemplates)
        //            .HasForeignKey(d => d.TVFileTVItemID)
        //            .OnDelete(DeleteBehavior.Restrict)
        //            .HasConstraintName("FK_DocTemplates_TVItems");
        //    });
        //}
        //private void OnModelCreating_Email(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Email>(entity =>
        //    {
        //        entity.HasOne(d => d.EmailTVItem)
        //            .WithMany(p => p.Emails)
        //            .HasForeignKey(d => d.EmailTVItemID)
        //            .OnDelete(DeleteBehavior.Restrict)
        //            .HasConstraintName("FK_EmailTVItemID_TVItems");
        //    });
        //}
        //private void OnModelCreating_EmailDistributionList(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<EmailDistributionList>(entity =>
        //    {
        //        entity.HasOne(d => d.CountryTVItem)
        //            .WithMany(p => p.EmailDistributionLists)
        //            .HasForeignKey(d => d.CountryTVItemID)
        //            .OnDelete(DeleteBehavior.Restrict)
        //            .HasConstraintName("FK_EmailDistributionLists_TVItems");
        //    });
        //}
        //private void OnModelCreating_EmailDistributionListContact(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<EmailDistributionListContact>(entity =>
        //    {
        //        entity.HasOne(d => d.EmailDistributionList)
        //            .WithMany(p => p.EmailDistributionListContacts)
        //            .HasForeignKey(d => d.EmailDistributionListID)
        //            .OnDelete(DeleteBehavior.Restrict)
        //            .HasConstraintName("FK_EmailDistributionListContacts_EmailDistributionLists");

        //    });
        //}
        //private void OnModelCreating_HydrometricDataValue(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<HydrometricDataValue>(entity =>
        //    {
        //        entity.HasOne(d => d.HydrometricSite)
        //            .WithMany(p => p.HydrometricDataValues)
        //            .HasForeignKey(d => d.HydrometricSiteID)
        //            .OnDelete(DeleteBehavior.Restrict)
        //            .HasConstraintName("FK_HydrometricDataValues_HydrometricSites");
        //    });
        //}
        //private void OnModelCreating_HydrometricSite(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<HydrometricSite>(entity =>
        //    {
        //        entity.HasOne(d => d.HydrometricSiteTVItem)
        //            .WithMany(p => p.HydrometricSites)
        //            .HasForeignKey(d => d.HydrometricSiteTVItemID)
        //            .OnDelete(DeleteBehavior.Restrict)
        //            .HasConstraintName("FK_HydrometricSites_TVItems");
        //    });
        //}
        //private void OnModelCreating_InfrastructureLanguage(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<InfrastructureLanguage>(entity =>
        //    {
        //        entity.HasOne(d => d.Infrastructure)
        //            .WithMany(p => p.InfrastructureLanguages)
        //            .HasForeignKey(d => d.InfrastructureID)
        //            .HasConstraintName("FK_InfrastructureLanguages_Infrastructures");
        //    });
        //}
        //private void OnModelCreating_Infrastructure(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Infrastructure>(entity =>
        //    {
        //        entity.HasOne(d => d.InfrastructureTVItem)
        //            .WithMany(p => p.Infrastructures)
        //            .HasForeignKey(d => d.InfrastructureTVItemID)
        //            .OnDelete(DeleteBehavior.Restrict)
        //            .HasConstraintName("FK_Infrastructures_TVItems");
        //    });
        //}
        //private void OnModelCreating_LabSheetDetail(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<LabSheetDetail>(entity =>
        //    {
        //        entity.HasOne(d => d.LabSheet)
        //            .WithMany(p => p.LabSheetDetails)
        //            .HasForeignKey(d => d.LabSheetID)
        //            .HasConstraintName("FK_LabSheetDetails_LabSheets");

        //        entity.HasOne(d => d.SamplingPlan)
        //            .WithMany(p => p.LabSheetDetails)
        //            .HasForeignKey(d => d.SamplingPlanID)
        //            .OnDelete(DeleteBehavior.Restrict)
        //            .HasConstraintName("FK_LabSheetDetails_SamplingPlans");

        //        entity.HasOne(d => d.SubsectorTVItem)
        //            .WithMany(p => p.LabSheetDetails)
        //            .HasForeignKey(d => d.SubsectorTVItemID)
        //            .OnDelete(DeleteBehavior.Restrict)
        //            .HasConstraintName("FK_LabSheetDetails_SubsectorTVItemID");
        //    });
        //}
        //private void OnModelCreating_LabSheet(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<LabSheet>(entity =>
        //    {
        //        entity.HasOne(d => d.AcceptedOrRejectedByContactTVItem)
        //            .WithMany(p => p.LabSheetsAcceptedOrRejectedByContactTVItem)
        //            .HasForeignKey(d => d.AcceptedOrRejectedByContactTVItemID)
        //            .HasConstraintName("FK_LabSheets_AcceptedByContactTVItemID");

        //        entity.HasOne(d => d.MWQMRunTVItem)
        //            .WithMany(p => p.LabSheetsMWQMRunTVItem)
        //            .HasForeignKey(d => d.MWQMRunTVItemID)
        //            .HasConstraintName("FK_LabSheets_MWQMRunTVItemID");

        //        entity.HasOne(d => d.SamplingPlan)
        //            .WithMany(p => p.LabSheets)
        //            .HasForeignKey(d => d.SamplingPlanID)
        //            .OnDelete(DeleteBehavior.Restrict)
        //            .HasConstraintName("FK_LabSheets_SamplingPlans");

        //        entity.HasOne(d => d.SubsectorTVItem)
        //            .WithMany(p => p.LabSheetsSubsectorTVItem)
        //            .HasForeignKey(d => d.SubsectorTVItemID)
        //            .OnDelete(DeleteBehavior.Restrict)
        //            .HasConstraintName("FK_LabSheets_SubsectorTVItemID");
        //    });
        //}
        //private void OnModelCreating_LabSheetTubeMPNDetail(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<LabSheetTubeMPNDetail>(entity =>
        //    {
        //        entity.HasOne(d => d.LabSheetDetail)
        //            .WithMany(p => p.LabSheetTubeMPNDetails)
        //            .HasForeignKey(d => d.LabSheetDetailID)
        //            .HasConstraintName("FK_LabSheetTubeMPNDetails_LabSheetDetails");

        //        entity.HasOne(d => d.MWQMSiteTVItem)
        //            .WithMany(p => p.LabSheetTubeMPNDetails)
        //            .HasForeignKey(d => d.MWQMSiteTVItemID)
        //            .OnDelete(DeleteBehavior.Restrict)
        //            .HasConstraintName("FK_LabSheetTubeMPNDetails_TVItems");
        //    });
        //}
        //private void OnModelCreating_Log(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Log>(entity =>
        //    {
        //    });
        //}
        //private void OnModelCreating_MapInfoPoint(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<MapInfoPoint>(entity =>
        //    {
        //        entity.HasOne(d => d.MapInfo)
        //            .WithMany(p => p.MapInfoPoints)
        //            .HasForeignKey(d => d.MapInfoID)
        //            .HasConstraintName("FK_MapInfoPoints_MapInfos");
        //    });
        //}
        //private void OnModelCreating_MapInfo(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<MapInfo>(entity =>
        //    {
        //        entity.HasOne(d => d.TVItem)
        //            .WithMany(p => p.MapInfos)
        //            .HasForeignKey(d => d.TVItemID)
        //            .OnDelete(DeleteBehavior.Restrict)
        //            .HasConstraintName("FK_MapInfos_TVItems");
        //    });
        //}
        //private void OnModelCreating_MikeBoundaryCondition(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<MikeBoundaryCondition>(entity =>
        //    {
        //        entity.HasOne(d => d.MikeBoundaryConditionTVItem)
        //            .WithMany(p => p.MikeBoundaryConditions)
        //            .HasForeignKey(d => d.MikeBoundaryConditionTVItemID)
        //            .OnDelete(DeleteBehavior.Restrict)
        //            .HasConstraintName("FK_MikeBoundaryConditions_TVItems");
        //    });
        //}
        //private void OnModelCreating_MikeScenario(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<MikeScenario>(entity =>
        //    {
        //        entity.HasOne(d => d.MikeScenarioTVItem)
        //            .WithMany(p => p.MikeScenarios)
        //            .HasForeignKey(d => d.MikeScenarioTVItemID)
        //            .OnDelete(DeleteBehavior.Restrict)
        //            .HasConstraintName("FK_MikeScenarios_TVItems");
        //    });
        //}
        //private void OnModelCreating_MikeSource(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<MikeSource>(entity =>
        //    {
        //        entity.HasOne(d => d.MikeSourceTVItem)
        //            .WithMany(p => p.MikeSources)
        //            .HasForeignKey(d => d.MikeSourceTVItemID)
        //            .HasConstraintName("FK_MikeSources_TVItems");
        //    });
        //}
        //private void OnModelCreating_MikeSourceStartEnd(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<MikeSourceStartEnd>(entity =>
        //    {
        //        entity.HasOne(d => d.MikeSource)
        //            .WithMany(p => p.MikeSourceStartEnds)
        //            .HasForeignKey(d => d.MikeSourceID)
        //            .HasConstraintName("FK_MikeSourceStartEnds_MikeSources");
        //    });
        //}
        //private void OnModelCreating_MWQMLookupMPN(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<MWQMLookupMPN>(entity =>
        //    {
        //    });
        //}
        //private void OnModelCreating_MWQMRunLanguage(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<MWQMRunLanguage>(entity =>
        //    {
        //        entity.HasOne(d => d.MWQMRun)
        //            .WithMany(p => p.MWQMRunLanguages)
        //            .HasForeignKey(d => d.MWQMRunID)
        //            .HasConstraintName("FK_MWQMRunLanguages_MWQMRuns");
        //    });
        //}
        //private void OnModelCreating_MWQMRun(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<MWQMRun>(entity =>
        //    {
        //        entity.HasOne(d => d.LabSampleApprovalContactTVItem)
        //            .WithMany(p => p.MWQMRunsLabSampleApprovalContactTVItem)
        //            .HasForeignKey(d => d.LabSampleApprovalContactTVItemID)
        //            .HasConstraintName("FK_MWQMRuns_ValidatorTVItemContacts");

        //        entity.HasOne(d => d.MWQMRunTVItem)
        //            .WithMany(p => p.MWQMRunsMWQMRunTVItem)
        //            .HasForeignKey(d => d.MWQMRunTVItemID)
        //            .OnDelete(DeleteBehavior.Restrict)
        //            .HasConstraintName("FK_MWQMRuns_TVItems");

        //        entity.HasOne(d => d.SubsectorTVItem)
        //            .WithMany(p => p.MWQMRunsSubsectorTVItem)
        //            .HasForeignKey(d => d.SubsectorTVItemID)
        //            .OnDelete(DeleteBehavior.Restrict)
        //            .HasConstraintName("FK_MWQMRuns_MWQMSiteTVItems");
        //    });
        //}
        //private void OnModelCreating_MWQMSampleLanguage(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<MWQMSampleLanguage>(entity =>
        //    {
        //        entity.HasOne(d => d.MWQMSample)
        //            .WithMany(p => p.MWQMSampleLanguages)
        //            .HasForeignKey(d => d.MWQMSampleID)
        //            .HasConstraintName("FK_MWQMSampleLanguages_MWQMSamples");
        //    });
        //}
        //private void OnModelCreating_MWQMSample(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<MWQMSample>(entity =>
        //    {
        //        entity.HasOne(d => d.MWQMRunTVItem)
        //            .WithMany(p => p.MWQMSampleMWQMRunTVItem)
        //            .HasForeignKey(d => d.MWQMRunTVItemID)
        //            .OnDelete(DeleteBehavior.Restrict)
        //            .HasConstraintName("FK_MWQMSamples_MWQMRunTVItemID");

        //        entity.HasOne(d => d.MWQMSiteTVItem)
        //            .WithMany(p => p.MWQMSampleMWQMSiteTVItem)
        //            .HasForeignKey(d => d.MWQMSiteTVItemID)
        //            .OnDelete(DeleteBehavior.Restrict)
        //            .HasConstraintName("FK_MWQMSamples_MWQMSites");
        //    });
        //}
        //private void OnModelCreating_MWQMSite(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<MWQMSite>(entity =>
        //    {
        //        entity.HasOne(d => d.MWQMSiteTVItem)
        //            .WithMany(p => p.MWQMSites)
        //            .HasForeignKey(d => d.MWQMSiteTVItemID)
        //            .OnDelete(DeleteBehavior.Restrict)
        //            .HasConstraintName("FK_MWQMSites_TVItems");
        //    });
        //}
        //private void OnModelCreating_MWQMSiteStartEndDate(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<MWQMSiteStartEndDate>(entity =>
        //    {
        //        entity.HasOne(d => d.MWQMSiteTVItem)
        //            .WithMany(p => p.MWQMSiteStartEndDates)
        //            .HasForeignKey(d => d.MWQMSiteTVItemID)
        //            .OnDelete(DeleteBehavior.Restrict)
        //            .HasConstraintName("FK_MWQMSiteStartEndDates_TVItems");
        //    });
        //}
        //private void OnModelCreating_MWQMSubsectorLanguage(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<MWQMSubsectorLanguage>(entity =>
        //    {
        //        entity.HasOne(d => d.MWQMSubsector)
        //            .WithMany(p => p.MWQMSubsectorLanguages)
        //            .HasForeignKey(d => d.MWQMSubsectorID)
        //            .HasConstraintName("FK_MWQMSubsectorLanguages_MWQMSubsectors");
        //    });
        //}
        //private void OnModelCreating_MWQMSubsector(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<MWQMSubsector>(entity =>
        //    {
        //        entity.HasOne(d => d.MWQMSubsectorTVItem)
        //            .WithMany(p => p.MWQMSubsectors)
        //            .HasForeignKey(d => d.MWQMSubsectorTVItemID)
        //            .OnDelete(DeleteBehavior.Restrict)
        //            .HasConstraintName("FK_MWQMSubsectors_TVItems");
        //    });
        //}
        //private void OnModelCreating_PolSourceObservationIssue(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<PolSourceObservationIssue>(entity =>
        //    {
        //        entity.HasOne(d => d.PolSourceObservation)
        //            .WithMany(p => p.PolSourceObservationIssues)
        //            .HasForeignKey(d => d.PolSourceObservationID)
        //            .HasConstraintName("FK_PolSourceObservationIssues_PolSourceObservations");
        //    });
        //}
        //private void OnModelCreating_PolSourceObservation(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<PolSourceObservation>(entity =>
        //    {
        //        entity.HasOne(d => d.ContactTVItem)
        //            .WithMany(p => p.PolSourceObservationsContactTVItem)
        //            .HasForeignKey(d => d.ContactTVItemID)
        //            .OnDelete(DeleteBehavior.Restrict)
        //            .HasConstraintName("FK_PolSourceObservations_TVItemContact");

        //        entity.HasOne(d => d.PolSourceSiteTVItem)
        //            .WithMany(p => p.PolSourceObservationsPolSourceSiteTVItem)
        //            .HasForeignKey(d => d.PolSourceSiteTVItemID)
        //            .HasConstraintName("FK_PolSourceObservations_PolSourceSites");
        //    });
        //}
        //private void OnModelCreating_PolSourceSite(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<PolSourceSite>(entity =>
        //    {
        //        entity.HasOne(d => d.PolSourceSiteTVItem)
        //            .WithMany(p => p.PolSourceSites)
        //            .HasForeignKey(d => d.PolSourceSiteTVItemID)
        //            .OnDelete(DeleteBehavior.Restrict)
        //            .HasConstraintName("FK_PolSourceSites_TVItems");
        //    });
        //}
        //private void OnModelCreating_RatingCurve(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<RatingCurve>(entity =>
        //    {
        //        entity.HasOne(d => d.HydrometricSite)
        //            .WithMany(p => p.RatingCurves)
        //            .HasForeignKey(d => d.HydrometricSiteID)
        //            .OnDelete(DeleteBehavior.Restrict)
        //            .HasConstraintName("FK_RatingCurves_HydrometricSites");
        //    });
        //}
        //private void OnModelCreating_RatingCurveValue(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<RatingCurveValue>(entity =>
        //    {
        //        entity.HasOne(d => d.RatingCurve)
        //            .WithMany(p => p.RatingCurveValues)
        //            .HasForeignKey(d => d.RatingCurveID)
        //            .HasConstraintName("FK_RatingCurveValues_RatingCurves");
        //    });
        //}
        //private void OnModelCreating_ResetPassword(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<ResetPassword>(entity =>
        //    {
        //    });
        //}
        //private void OnModelCreating_SamplingPlan(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<SamplingPlan>(entity =>
        //    {
        //        entity.HasOne(d => d.CreatorTVItem)
        //            .WithMany(p => p.SamplingPlansCreatorTVItem)
        //            .HasForeignKey(d => d.CreatorTVItemID)
        //            .OnDelete(DeleteBehavior.Restrict)
        //            .HasConstraintName("FK_SamplingPlans_CreatorTVItemID");

        //        entity.HasOne(d => d.ProvinceTVItem)
        //            .WithMany(p => p.SamplingPlansProvinceTVItem)
        //            .HasForeignKey(d => d.ProvinceTVItemID)
        //            .OnDelete(DeleteBehavior.Restrict)
        //            .HasConstraintName("FK_SamplingPlans_ProvinceTVItemID");

        //        entity.HasOne(d => d.SamplingPlanFileTVItem)
        //            .WithMany(p => p.SamplingPlansSamplingPlanFileTVItem)
        //            .HasForeignKey(d => d.SamplingPlanFileTVItemID)
        //            .HasConstraintName("FK_SamplingPlans_SamplingPlanFileTVItemID");
        //    });
        //}
        //private void OnModelCreating_SamplingPlanSubsector(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<SamplingPlanSubsector>(entity =>
        //    {
        //        entity.HasOne(d => d.SamplingPlan)
        //            .WithMany(p => p.SamplingPlanSubsectors)
        //            .HasForeignKey(d => d.SamplingPlanID)
        //            .HasConstraintName("FK_SamplingPlanSubsectors_SamplingPlans");

        //        entity.HasOne(d => d.SubsectorTVItem)
        //            .WithMany(p => p.SamplingPlanSubsectors)
        //            .HasForeignKey(d => d.SubsectorTVItemID)
        //            .OnDelete(DeleteBehavior.Restrict)
        //            .HasConstraintName("FK_SamplingPlanSubsectors_SubsectorTVItemID");
        //    });
        //}
        //private void OnModelCreating_SamplingPlanSubsectorSite(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<SamplingPlanSubsectorSite>(entity =>
        //    {
        //        entity.HasOne(d => d.MWQMSiteTVItem)
        //            .WithMany(p => p.SamplingPlanSubsectorSites)
        //            .HasForeignKey(d => d.MWQMSiteTVItemID)
        //            .OnDelete(DeleteBehavior.Restrict)
        //            .HasConstraintName("FK_SamplingPlanSubsectorSites_MWQMSiteTVItemID");

        //        entity.HasOne(d => d.SamplingPlanSubsector)
        //            .WithMany(p => p.SamplingPlanSubsectorSites)
        //            .HasForeignKey(d => d.SamplingPlanSubsectorID)
        //            .HasConstraintName("FK_SamplingPlanSubsectorSites_SamplingPlanSubsectors");
        //    });
        //}
        //private void OnModelCreating_SpillLanguage(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<SpillLanguage>(entity =>
        //    {
        //        entity.HasOne(d => d.Spill)
        //            .WithMany(p => p.SpillLanguages)
        //            .HasForeignKey(d => d.SpillID)
        //            .HasConstraintName("FK_SpillLanguages_Spills");
        //    });
        //}
        //private void OnModelCreating_Spill(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Spill>(entity =>
        //    {
        //        entity.HasOne(d => d.InfrastructureTVItem)
        //            .WithMany(p => p.SpillsInfrastructureTVItem)
        //            .HasForeignKey(d => d.InfrastructureTVItemID)
        //            .HasConstraintName("FK_Spills_InfrastructureTVItemID");

        //        entity.HasOne(d => d.MunicipalityTVItem)
        //            .WithMany(p => p.SpillsMunicipalityTVItem)
        //            .HasForeignKey(d => d.MunicipalityTVItemID)
        //            .OnDelete(DeleteBehavior.Restrict)
        //            .HasConstraintName("FK_Spills_MunicipalityTVIteID");
        //    });
        //}
        //private void OnModelCreating_Tel(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Tel>(entity =>
        //    {
        //        entity.HasOne(d => d.TelTVItem)
        //            .WithMany(p => p.Tels)
        //            .HasForeignKey(d => d.TelTVItemID)
        //            .OnDelete(DeleteBehavior.Restrict)
        //            .HasConstraintName("FK_TelTVItemID_TVItems");
        //    });
        //}
        //private void OnModelCreating_TideDataValue(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<TideDataValue>(entity =>
        //    {
        //        entity.HasOne(d => d.TideSiteTVItem)
        //            .WithMany(p => p.TideDataValues)
        //            .HasForeignKey(d => d.TideSiteTVItemID)
        //            .OnDelete(DeleteBehavior.Restrict)
        //            .HasConstraintName("FK_TideDataValues_TVItems");
        //    });
        //}
        //private void OnModelCreating_TideLocation(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<TideLocation>(entity =>
        //    {
        //    });
        //}
        //private void OnModelCreating_TideSite(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<TideSite>(entity =>
        //    {
        //        entity.HasOne(d => d.TideSiteTVItem)
        //            .WithMany(p => p.TideSites)
        //            .HasForeignKey(d => d.TideSiteTVItemID)
        //            .OnDelete(DeleteBehavior.Restrict)
        //            .HasConstraintName("FK_TideSites_TVItems");
        //    });
        //}
        //private void OnModelCreating_TVFileLanguage(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<TVFileLanguage>(entity =>
        //    {
        //        entity.HasOne(d => d.TVFile)
        //            .WithMany(p => p.TVFileLanguages)
        //            .HasForeignKey(d => d.TVFileID)
        //            .HasConstraintName("FK_TVFileLanguages_TVFiles");
        //    });
        //}
        //private void OnModelCreating_TVFile(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<TVFile>(entity =>
        //    {
        //        entity.HasOne(d => d.TVFileTVItem)
        //            .WithMany(p => p.TVFiles)
        //            .HasForeignKey(d => d.TVFileTVItemID)
        //            .OnDelete(DeleteBehavior.Restrict)
        //            .HasConstraintName("FK_TVFiles_TVItems");
        //    });
        //}
        //private void OnModelCreating_TVItemLanguage(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<TVItemLanguage>(entity =>
        //    {
        //        entity.HasOne(d => d.TVItem)
        //            .WithMany(p => p.TVItemLanguages)
        //            .HasForeignKey(d => d.TVItemID)
        //            .HasConstraintName("FK_TVItemLanguages_TVItems");
        //    });
        //}
        //private void OnModelCreating_TVItemLink(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<TVItemLink>(entity =>
        //    {
        //        entity.HasOne(d => d.FromTVItem)
        //            .WithMany(p => p.TVItemLinksFromTVItem)
        //            .HasForeignKey(d => d.FromTVItemID)
        //            .OnDelete(DeleteBehavior.Restrict)
        //            .HasConstraintName("FK_TVItemLinks_FromTVItems");

        //        entity.HasOne(d => d.ParentTVItemLink)
        //            .WithMany(p => p.InverseParentTVItemLink)
        //            .HasForeignKey(d => d.ParentTVItemLinkID)
        //            .HasConstraintName("FK_TVItemLinks_ParentTVItemLinks");

        //        entity.HasOne(d => d.ToTVItem)
        //            .WithMany(p => p.TVItemLinksToTVItem)
        //            .HasForeignKey(d => d.ToTVItemID)
        //            .OnDelete(DeleteBehavior.Restrict)
        //            .HasConstraintName("FK_TVItemLinks_ToTVItems");
        //    });
        //}
        //private void OnModelCreating_TVItem(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<TVItem>(entity =>
        //    {
        //        entity.HasOne(d => d.Parent)
        //            .WithMany(p => p.InverseParent)
        //            .HasForeignKey(d => d.ParentID)
        //            .OnDelete(DeleteBehavior.Restrict)
        //            .HasConstraintName("FK_TVItems_ParentID");
        //    });
        //}
        //private void OnModelCreating_TVItemStat(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<TVItemStat>(entity =>
        //    {
        //        entity.HasOne(d => d.TVItem)
        //            .WithMany(p => p.TVItemStats)
        //            .HasForeignKey(d => d.TVItemID)
        //            .HasConstraintName("FK_TVItemStats_TVItems");
        //    });
        //}
        //private void OnModelCreating_TVItemUserAuthorization(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<TVItemUserAuthorization>(entity =>
        //    {
        //        entity.HasOne(d => d.ContactTVItem)
        //            .WithMany(p => p.TVItemUserAuthorizationsContactTVItem)
        //            .HasForeignKey(d => d.ContactTVItemID)
        //            .HasConstraintName("FK_TVItemUserAuthorizations_Contacts");

        //        entity.HasOne(d => d.TVItemID1Navigation)
        //            .WithMany(p => p.TVItemUserAuthorizationsTVItemID1Navigation)
        //            .HasForeignKey(d => d.TVItemID1)
        //            .OnDelete(DeleteBehavior.Restrict)
        //            .HasConstraintName("FK_TVItemsUserAuthorizations_TVItems");
        //    });
        //}
        //private void OnModelCreating_TVTypeUserAuthorization(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<TVTypeUserAuthorization>(entity =>
        //    {
        //        entity.HasOne(d => d.ContactTVItem)
        //            .WithMany(p => p.TVTypeUserAuthorizations)
        //            .HasForeignKey(d => d.ContactTVItemID)
        //            .HasConstraintName("FK_TVTypeUserAuthorizations_Contacts");
        //    });
        //}
        //private void OnModelCreating_UseOfSite(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<UseOfSite>(entity =>
        //    {
        //        entity.HasOne(d => d.SiteTVItem)
        //            .WithMany(p => p.UseOfSitesSiteTVItem)
        //            .HasForeignKey(d => d.SiteTVItemID)
        //            .OnDelete(DeleteBehavior.Restrict)
        //            .HasConstraintName("FK_UseOfSites_SiteTVItems");

        //        entity.HasOne(d => d.SubsectorTVItem)
        //            .WithMany(p => p.UseOfSitesSubsectorTVItem)
        //            .HasForeignKey(d => d.SubsectorTVItemID)
        //            .OnDelete(DeleteBehavior.Restrict)
        //            .HasConstraintName("FK_UseOfSites_SubsectorTVItems");
        //    });
        //}
        //private void OnModelCreating_VPAmbient(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<VPAmbient>(entity =>
        //    {
        //        entity.HasOne(d => d.VPScenario)
        //            .WithMany(p => p.VPAmbients)
        //            .HasForeignKey(d => d.VPScenarioID)
        //            .HasConstraintName("FK_VPAmbients_VPScenarios");
        //    });
        //}
        //private void OnModelCreating_VPResult(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<VPResult>(entity =>
        //    {
        //        entity.HasOne(d => d.VPScenario)
        //            .WithMany(p => p.VPResults)
        //            .HasForeignKey(d => d.VPScenarioID)
        //            .HasConstraintName("FK_VPResults_VPScenarios");
        //    });
        //}
        //private void OnModelCreating_VPScenarioLanguage(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<VPScenarioLanguage>(entity =>
        //    {
        //        entity.HasOne(d => d.VPScenario)
        //            .WithMany(p => p.VPScenarioLanguages)
        //            .HasForeignKey(d => d.VPScenarioID)
        //            .HasConstraintName("FK_VPScenarioLanguages_VPScenarios");
        //    });
        //}
        //private void OnModelCreating_VPScenario(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<VPScenario>(entity =>
        //    {
        //        entity.HasOne(d => d.InfrastructureTVItem)
        //            .WithMany(p => p.VPScenarios)
        //            .HasForeignKey(d => d.InfrastructureTVItemID)
        //            .OnDelete(DeleteBehavior.Restrict)
        //            .HasConstraintName("FK_VPScenarios_InfrastructureTVItems");
        //    });
        //}
        //#endregion Functions private


    }
}