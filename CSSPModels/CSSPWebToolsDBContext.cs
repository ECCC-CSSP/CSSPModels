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
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            OnModelCreating_Address(modelBuilder);
            OnModelCreating_AppErrLog(modelBuilder);
            OnModelCreating_AppTask(modelBuilder);
            OnModelCreating_AppTaskLanguage(modelBuilder);
            OnModelCreating_BoxModel(modelBuilder);
            OnModelCreating_BoxModelLanguage(modelBuilder);
            OnModelCreating_BoxModelResult(modelBuilder);
            OnModelCreating_ClimateDataValue(modelBuilder);
            OnModelCreating_ClimateSite(modelBuilder);
            OnModelCreating_Contact(modelBuilder);
            OnModelCreating_ContactLogin(modelBuilder);
            OnModelCreating_ContactPreference(modelBuilder);
            OnModelCreating_ContactShortcut(modelBuilder);
            OnModelCreating_DocTemplate(modelBuilder);
            OnModelCreating_Email(modelBuilder);
            OnModelCreating_HydrometricDataValue(modelBuilder);
            OnModelCreating_HydrometricSite(modelBuilder);
            OnModelCreating_Infrastructure(modelBuilder);
            OnModelCreating_InfrastructureLanguage(modelBuilder);
            OnModelCreating_LabSheet(modelBuilder);
            OnModelCreating_LabSheetDetail(modelBuilder);
            OnModelCreating_LabSheetTubeMPNDetail(modelBuilder);
            OnModelCreating_Log(modelBuilder);
            OnModelCreating_MapInfo(modelBuilder);
            OnModelCreating_MapInfoPoint(modelBuilder);
            OnModelCreating_MikeBoundaryCondition(modelBuilder);
            OnModelCreating_MikeScenario(modelBuilder);
            OnModelCreating_MikeSource(modelBuilder);
            OnModelCreating_MikeSourceStartEnd(modelBuilder);
            OnModelCreating_MWQMLookupMPN(modelBuilder);
            OnModelCreating_MWQMRun(modelBuilder);
            OnModelCreating_MWQMRunLanguage(modelBuilder);
            OnModelCreating_MWQMSample(modelBuilder);
            OnModelCreating_MWQMSampleLanguage(modelBuilder);
            OnModelCreating_MWQMSite(modelBuilder);
            OnModelCreating_MWQMSiteStartEndDate(modelBuilder);
            OnModelCreating_MWQMSubsector(modelBuilder);
            OnModelCreating_MWQMSubsectorLanguage(modelBuilder);
            OnModelCreating_PolSourceObservation(modelBuilder);
            OnModelCreating_PolSourceObservationIssue(modelBuilder);
            OnModelCreating_PolSourceSite(modelBuilder);
            OnModelCreating_RatingCurve(modelBuilder);
            OnModelCreating_RatingCurveValue(modelBuilder);
            OnModelCreating_ResetPassword(modelBuilder);
            OnModelCreating_SamplingPlan(modelBuilder);
            OnModelCreating_SamplingPlanSubsector(modelBuilder);
            OnModelCreating_SamplingPlanSubsectorSite(modelBuilder);
            OnModelCreating_Spill(modelBuilder);
            OnModelCreating_SpillLanguage(modelBuilder);
            OnModelCreating_Tel(modelBuilder);
            OnModelCreating_TideDataValue(modelBuilder);
            OnModelCreating_TideLocation(modelBuilder);
            OnModelCreating_TideSite(modelBuilder);
            OnModelCreating_TVFile(modelBuilder);
            OnModelCreating_TVFileLanguage(modelBuilder);
            OnModelCreating_TVItem(modelBuilder);
            OnModelCreating_TVItemLanguage(modelBuilder);
            OnModelCreating_TVItemLink(modelBuilder);
            OnModelCreating_TVItemStat(modelBuilder);
            OnModelCreating_TVItemUserAuthorization(modelBuilder);
            OnModelCreating_TVTypeUserAuthorization(modelBuilder);
            OnModelCreating_UseOfSite(modelBuilder);
            OnModelCreating_VPAmbient(modelBuilder);
            OnModelCreating_VPResult(modelBuilder);
            OnModelCreating_VPScenario(modelBuilder);
            OnModelCreating_VPScenarioLanguage(modelBuilder);
        }
        #endregion Overrides

        #region Functions private
        private void OnModelCreating_Address(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Address>(entity =>
            {
                entity.HasOne(d => d.AddressTVItem)
                    .WithMany(p => p.AddressesAddressTVItem)
                    .HasForeignKey(d => d.AddressTVItemID)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Addresses_AddressTVItemID");

                entity.HasOne(d => d.CountryTVItem)
                    .WithMany(p => p.AddressesCountryTVItem)
                    .HasForeignKey(d => d.CountryTVItemID)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Addresses_CountryTVItemID");

                entity.HasOne(d => d.ProvinceTVItem)
                    .WithMany(p => p.AddressesProvinceTVItem)
                    .HasForeignKey(d => d.ProvinceTVItemID)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Addresses_ProvinceTVItemID");

                entity.HasOne(d => d.MunicipalityTVItem)
                    .WithMany(p => p.AddressesMunicipalityTVItem)
                    .HasForeignKey(d => d.MunicipalityTVItemID)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Addresses_MunicipalityTVItemID");

            });
        }
        private void OnModelCreating_AppErrLog(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppErrLog>(entity =>
            {
                // empty for now
            });
        }
        private void OnModelCreating_AppTaskLanguage(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppTaskLanguage>(entity =>
            {
                entity.HasOne(d => d.AppTask)
                    .WithMany(p => p.AppTaskLanguages)
                    .HasForeignKey(d => d.AppTaskID)
                    .HasConstraintName("FK_AppTaskLanguages_AppTasks");
            });
        }
        private void OnModelCreating_AppTask(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppTask>(entity =>
            {
                entity.HasOne(d => d.TVItemIDNavigation)
                    .WithMany(p => p.AppTasksTVItem)
                    .HasForeignKey(d => d.TVItemID)
                    .HasConstraintName("FK_AppTasks_TVItems");

                entity.HasOne(d => d.TVItemID2Navigation)
                    .WithMany(p => p.AppTasksTVItemID2Navigation)
                    .HasForeignKey(d => d.TVItemID2)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AppTasks_TVItems2");
            });
        }
        private void OnModelCreating_BoxModelLanguage(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BoxModelLanguage>(entity =>
            {
                entity.HasOne(d => d.BoxModel)
                    .WithMany(p => p.BoxModelLanguages)
                    .HasForeignKey(d => d.BoxModelID)
                    .HasConstraintName("FK_BoxModelLanguages_BoxModels");
            });
        }
        private void OnModelCreating_BoxModelResult(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BoxModelResult>(entity =>
            {
                entity.HasOne(d => d.BoxModel)
                    .WithMany(p => p.BoxModelResults)
                    .HasForeignKey(d => d.BoxModelID)
                    .HasConstraintName("FK_BoxModelResults_BoxModels");
            });
        }
        private void OnModelCreating_BoxModel(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BoxModel>(entity =>
            {
                entity.HasOne(d => d.InfrastructureTVItem)
                    .WithMany(p => p.BoxModels)
                    .HasForeignKey(d => d.InfrastructureTVItemID)
                    .HasConstraintName("FK_BoxModels_InfrastructureTVItemID");
            });
        }
        private void OnModelCreating_ClimateDataValue(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ClimateDataValue>(entity =>
            {
                entity.HasOne(d => d.ClimateSite)
                    .WithMany(p => p.ClimateDataValues)
                    .HasForeignKey(d => d.ClimateSiteID)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ClimateDataValues_ClimateSites");
            });
        }
        private void OnModelCreating_ClimateSite(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ClimateSite>(entity =>
            {
                entity.HasOne(d => d.ClimateSiteTVItem)
                    .WithMany(p => p.ClimateSites)
                    .HasForeignKey(d => d.ClimateSiteTVItemID)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ClimateSites_TVItems");
            });
        }
        private void OnModelCreating_Contact(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Contact>(entity =>
            {
                entity.HasOne(d => d.ContactTVItem)
                    .WithMany(p => p.Contacts)
                    .HasForeignKey(d => d.ContactTVItemID)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Contacts_TVItems");
            });

            modelBuilder.Entity<Contact>().Ignore(c => c.ParentTVItemID);

        }
        private void OnModelCreating_ContactLogin(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ContactLogin>(entity =>
            {
                entity.HasOne(d => d.Contact)
                  .WithMany(p => p.ContactLogins)
                  .HasForeignKey(d => d.ContactID)
                  .HasConstraintName("FK_ContactShortcuts_Contacts");
            });
        }
        private void OnModelCreating_ContactPreference(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ContactPreference>(entity =>
            {
                entity.HasOne(d => d.Contact)
                    .WithMany(p => p.ContactPreferences)
                    .HasForeignKey(d => d.ContactID)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ContactPreferences_Contacts");
            });
        }
        private void OnModelCreating_ContactShortcut(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ContactShortcut>(entity =>
            {
                entity.HasOne(d => d.Contact)
                    .WithMany(p => p.ContactShortcuts)
                    .HasForeignKey(d => d.ContactID)
                    .HasConstraintName("FK_ContactShortcuts_Contacts");
            });
        }
        private void OnModelCreating_DocTemplate(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DocTemplate>(entity =>
            {
                entity.HasOne(d => d.TVFileTVItem)
                    .WithMany(p => p.DocTemplates)
                    .HasForeignKey(d => d.TVFileTVItemID)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_DocTemplates_TVItems");
            });
        }
        private void OnModelCreating_Email(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Email>(entity =>
            {
                entity.HasOne(d => d.EmailTVItem)
                    .WithMany(p => p.Emails)
                    .HasForeignKey(d => d.EmailTVItemID)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_EmailTVItemID_TVItems");
            });
        }
        private void OnModelCreating_HydrometricDataValue(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HydrometricDataValue>(entity =>
            {
                entity.HasOne(d => d.HydrometricSite)
                    .WithMany(p => p.HydrometricDataValues)
                    .HasForeignKey(d => d.HydrometricSiteID)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_HydrometricDataValues_HydrometricSites");
            });
        }
        private void OnModelCreating_HydrometricSite(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HydrometricSite>(entity =>
            {
                entity.HasOne(d => d.HydrometricSiteTVItem)
                    .WithMany(p => p.HydrometricSites)
                    .HasForeignKey(d => d.HydrometricSiteTVItemID)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_HydrometricSites_TVItems");
            });
        }
        private void OnModelCreating_InfrastructureLanguage(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<InfrastructureLanguage>(entity =>
            {
                entity.HasOne(d => d.Infrastructure)
                    .WithMany(p => p.InfrastructureLanguages)
                    .HasForeignKey(d => d.InfrastructureID)
                    .HasConstraintName("FK_InfrastructureLanguages_Infrastructures");
            });
        }
        private void OnModelCreating_Infrastructure(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Infrastructure>(entity =>
            {
                entity.HasOne(d => d.InfrastructureTVItem)
                    .WithMany(p => p.Infrastructures)
                    .HasForeignKey(d => d.InfrastructureTVItemID)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Infrastructures_TVItems");
            });
        }
        private void OnModelCreating_LabSheetDetail(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LabSheetDetail>(entity =>
            {
                entity.HasOne(d => d.LabSheet)
                    .WithMany(p => p.LabSheetDetails)
                    .HasForeignKey(d => d.LabSheetID)
                    .HasConstraintName("FK_LabSheetDetails_LabSheets");

                entity.HasOne(d => d.SamplingPlan)
                    .WithMany(p => p.LabSheetDetails)
                    .HasForeignKey(d => d.SamplingPlanID)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_LabSheetDetails_SamplingPlans");

                entity.HasOne(d => d.SubsectorTVItem)
                    .WithMany(p => p.LabSheetDetails)
                    .HasForeignKey(d => d.SubsectorTVItemID)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_LabSheetDetails_SubsectorTVItemID");
            });
        }
        private void OnModelCreating_LabSheet(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LabSheet>(entity =>
            {
                entity.HasOne(d => d.AcceptedOrRejectedByContactTVItem)
                    .WithMany(p => p.LabSheetsAcceptedOrRejectedByContactTVItem)
                    .HasForeignKey(d => d.AcceptedOrRejectedByContactTVItemID)
                    .HasConstraintName("FK_LabSheets_AcceptedByContactTVItemID");

                entity.HasOne(d => d.MWQMRunTVItem)
                    .WithMany(p => p.LabSheetsMWQMRunTVItem)
                    .HasForeignKey(d => d.MWQMRunTVItemID)
                    .HasConstraintName("FK_LabSheets_MWQMRunTVItemID");

                entity.HasOne(d => d.SamplingPlan)
                    .WithMany(p => p.LabSheets)
                    .HasForeignKey(d => d.SamplingPlanID)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_LabSheets_SamplingPlans");

                entity.HasOne(d => d.SubsectorTVItem)
                    .WithMany(p => p.LabSheetsSubsectorTVItem)
                    .HasForeignKey(d => d.SubsectorTVItemID)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_LabSheets_SubsectorTVItemID");
            });
        }
        private void OnModelCreating_LabSheetTubeMPNDetail(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LabSheetTubeMPNDetail>(entity =>
            {
                entity.HasOne(d => d.LabSheetDetail)
                    .WithMany(p => p.LabSheetTubeMPNDetails)
                    .HasForeignKey(d => d.LabSheetDetailID)
                    .HasConstraintName("FK_LabSheetTubeMPNDetails_LabSheetDetails");

                entity.HasOne(d => d.MWQMSiteTVItem)
                    .WithMany(p => p.LabSheetTubeMPNDetails)
                    .HasForeignKey(d => d.MWQMSiteTVItemID)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_LabSheetTubeMPNDetails_TVItems");
            });
        }
        private void OnModelCreating_Log(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Log>(entity =>
            {
            });
        }
        private void OnModelCreating_MapInfoPoint(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MapInfoPoint>(entity =>
            {
                entity.HasOne(d => d.MapInfo)
                    .WithMany(p => p.MapInfoPoints)
                    .HasForeignKey(d => d.MapInfoID)
                    .HasConstraintName("FK_MapInfoPoints_MapInfos");
            });
        }
        private void OnModelCreating_MapInfo(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MapInfo>(entity =>
            {
                entity.HasOne(d => d.TVItem)
                    .WithMany(p => p.MapInfos)
                    .HasForeignKey(d => d.TVItemID)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_MapInfos_TVItems");
            });
        }
        private void OnModelCreating_MikeBoundaryCondition(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MikeBoundaryCondition>(entity =>
            {
                entity.HasOne(d => d.MikeBoundaryConditionTVItem)
                    .WithMany(p => p.MikeBoundaryConditions)
                    .HasForeignKey(d => d.MikeBoundaryConditionTVItemID)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_MikeBoundaryConditions_TVItems");
            });
        }
        private void OnModelCreating_MikeScenario(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MikeScenario>(entity =>
            {
                entity.HasOne(d => d.MikeScenarioTVItem)
                    .WithMany(p => p.MikeScenarios)
                    .HasForeignKey(d => d.MikeScenarioTVItemID)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_MikeScenarios_TVItems");
            });
        }
        private void OnModelCreating_MikeSource(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MikeSource>(entity =>
            {
                entity.HasOne(d => d.MikeSourceTVItem)
                    .WithMany(p => p.MikeSources)
                    .HasForeignKey(d => d.MikeSourceTVItemID)
                    .HasConstraintName("FK_MikeSources_TVItems");
            });
        }
        private void OnModelCreating_MikeSourceStartEnd(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MikeSourceStartEnd>(entity =>
            {
                entity.HasOne(d => d.MikeSource)
                    .WithMany(p => p.MikeSourceStartEnds)
                    .HasForeignKey(d => d.MikeSourceID)
                    .HasConstraintName("FK_MikeSourceStartEnds_MikeSources");
            });
        }
        private void OnModelCreating_MWQMLookupMPN(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MWQMLookupMPN>(entity =>
            {
            });
        }
        private void OnModelCreating_MWQMRunLanguage(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MWQMRunLanguage>(entity =>
            {
                entity.HasOne(d => d.MWQMRun)
                    .WithMany(p => p.MWQMRunLanguages)
                    .HasForeignKey(d => d.MWQMRunID)
                    .HasConstraintName("FK_MWQMRunLanguages_MWQMRuns");
            });
        }
        private void OnModelCreating_MWQMRun(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MWQMRun>(entity =>
            {
                entity.HasOne(d => d.LabSampleApprovalContactTVItem)
                    .WithMany(p => p.MWQMRunsLabSampleApprovalContactTVItem)
                    .HasForeignKey(d => d.LabSampleApprovalContactTVItemID)
                    .HasConstraintName("FK_MWQMRuns_ValidatorTVItemContacts");

                entity.HasOne(d => d.MWQMRunTVItem)
                    .WithMany(p => p.MWQMRunsMWQMRunTVItem)
                    .HasForeignKey(d => d.MWQMRunTVItemID)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_MWQMRuns_TVItems");

                entity.HasOne(d => d.SubsectorTVItem)
                    .WithMany(p => p.MWQMRunsSubsectorTVItem)
                    .HasForeignKey(d => d.SubsectorTVItemID)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_MWQMRuns_MWQMSiteTVItems");
            });
        }
        private void OnModelCreating_MWQMSampleLanguage(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MWQMSampleLanguage>(entity =>
            {
                entity.HasOne(d => d.MWQMSample)
                    .WithMany(p => p.MWQMSampleLanguages)
                    .HasForeignKey(d => d.MWQMSampleID)
                    .HasConstraintName("FK_MWQMSampleLanguages_MWQMSamples");
            });
        }
        private void OnModelCreating_MWQMSample(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MWQMSample>(entity =>
            {
                entity.HasOne(d => d.MWQMRunTVItem)
                    .WithMany(p => p.MWQMSampleMWQMRunTVItem)
                    .HasForeignKey(d => d.MWQMRunTVItemID)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_MWQMSamples_MWQMRunTVItemID");

                entity.HasOne(d => d.MWQMSiteTVItem)
                    .WithMany(p => p.MWQMSampleMWQMSiteTVItem)
                    .HasForeignKey(d => d.MWQMSiteTVItemID)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_MWQMSamples_MWQMSites");
            });
        }
        private void OnModelCreating_MWQMSite(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MWQMSite>(entity =>
            {
                entity.HasOne(d => d.MWQMSiteTVItem)
                    .WithMany(p => p.MWQMSites)
                    .HasForeignKey(d => d.MWQMSiteTVItemID)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_MWQMSites_TVItems");
            });
        }
        private void OnModelCreating_MWQMSiteStartEndDate(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MWQMSiteStartEndDate>(entity =>
            {
                entity.HasOne(d => d.MWQMSiteTVItem)
                    .WithMany(p => p.MWQMSiteStartEndDates)
                    .HasForeignKey(d => d.MWQMSiteTVItemID)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_MWQMSiteStartEndDates_TVItems");
            });
        }
        private void OnModelCreating_MWQMSubsectorLanguage(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MWQMSubsectorLanguage>(entity =>
            {
                entity.HasOne(d => d.MWQMSubsector)
                    .WithMany(p => p.MWQMSubsectorLanguages)
                    .HasForeignKey(d => d.MWQMSubsectorID)
                    .HasConstraintName("FK_MWQMSubsectorLanguages_MWQMSubsectors");
            });
        }
        private void OnModelCreating_MWQMSubsector(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MWQMSubsector>(entity =>
            {
                entity.HasOne(d => d.MWQMSubsectorTVItem)
                    .WithMany(p => p.MWQMSubsectors)
                    .HasForeignKey(d => d.MWQMSubsectorTVItemID)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_MWQMSubsectors_TVItems");
            });
        }
        private void OnModelCreating_PolSourceObservationIssue(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PolSourceObservationIssue>(entity =>
            {
                entity.HasOne(d => d.PolSourceObservation)
                    .WithMany(p => p.PolSourceObservationIssues)
                    .HasForeignKey(d => d.PolSourceObservationID)
                    .HasConstraintName("FK_PolSourceObservationIssues_PolSourceObservations");
            });
        }
        private void OnModelCreating_PolSourceObservation(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PolSourceObservation>(entity =>
            {
                entity.HasOne(d => d.ContactTVItem)
                    .WithMany(p => p.PolSourceObservationsContactTVItem)
                    .HasForeignKey(d => d.ContactTVItemID)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PolSourceObservations_TVItemContact");

                entity.HasOne(d => d.PolSourceSiteTVItem)
                    .WithMany(p => p.PolSourceObservationsPolSourceSiteTVItem)
                    .HasForeignKey(d => d.PolSourceSiteTVItemID)
                    .HasConstraintName("FK_PolSourceObservations_PolSourceSites");
            });
        }
        private void OnModelCreating_PolSourceSite(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PolSourceSite>(entity =>
            {
                entity.HasOne(d => d.PolSourceSiteTVItem)
                    .WithMany(p => p.PolSourceSites)
                    .HasForeignKey(d => d.PolSourceSiteTVItemID)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PolSourceSites_TVItems");
            });
        }
        private void OnModelCreating_RatingCurve(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RatingCurve>(entity =>
            {
                entity.HasOne(d => d.HydrometricSite)
                    .WithMany(p => p.RatingCurves)
                    .HasForeignKey(d => d.HydrometricSiteID)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_RatingCurves_HydrometricSites");
            });
        }
        private void OnModelCreating_RatingCurveValue(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RatingCurveValue>(entity =>
            {
                entity.HasOne(d => d.RatingCurve)
                    .WithMany(p => p.RatingCurveValues)
                    .HasForeignKey(d => d.RatingCurveID)
                    .HasConstraintName("FK_RatingCurveValues_RatingCurves");
            });
        }
        private void OnModelCreating_ResetPassword(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ResetPassword>(entity =>
            {
            });
        }
        private void OnModelCreating_SamplingPlan(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SamplingPlan>(entity =>
            {
                entity.HasOne(d => d.CreatorTVItem)
                    .WithMany(p => p.SamplingPlansCreatorTVItem)
                    .HasForeignKey(d => d.CreatorTVItemID)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_SamplingPlans_CreatorTVItemID");

                entity.HasOne(d => d.ProvinceTVItem)
                    .WithMany(p => p.SamplingPlansProvinceTVItem)
                    .HasForeignKey(d => d.ProvinceTVItemID)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_SamplingPlans_ProvinceTVItemID");

                entity.HasOne(d => d.SamplingPlanFileTVItem)
                    .WithMany(p => p.SamplingPlansSamplingPlanFileTVItem)
                    .HasForeignKey(d => d.SamplingPlanFileTVItemID)
                    .HasConstraintName("FK_SamplingPlans_SamplingPlanFileTVItemID");
            });
        }
        private void OnModelCreating_SamplingPlanSubsector(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SamplingPlanSubsector>(entity =>
            {
                entity.HasOne(d => d.SamplingPlan)
                    .WithMany(p => p.SamplingPlanSubsectors)
                    .HasForeignKey(d => d.SamplingPlanID)
                    .HasConstraintName("FK_SamplingPlanSubsectors_SamplingPlans");

                entity.HasOne(d => d.SubsectorTVItem)
                    .WithMany(p => p.SamplingPlanSubsectors)
                    .HasForeignKey(d => d.SubsectorTVItemID)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_SamplingPlanSubsectors_SubsectorTVItemID");
            });
        }
        private void OnModelCreating_SamplingPlanSubsectorSite(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SamplingPlanSubsectorSite>(entity =>
            {
                entity.HasOne(d => d.MWQMSiteTVItem)
                    .WithMany(p => p.SamplingPlanSubsectorSites)
                    .HasForeignKey(d => d.MWQMSiteTVItemID)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_SamplingPlanSubsectorSites_MWQMSiteTVItemID");

                entity.HasOne(d => d.SamplingPlanSubsector)
                    .WithMany(p => p.SamplingPlanSubsectorSites)
                    .HasForeignKey(d => d.SamplingPlanSubsectorID)
                    .HasConstraintName("FK_SamplingPlanSubsectorSites_SamplingPlanSubsectors");
            });
        }
        private void OnModelCreating_SpillLanguage(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SpillLanguage>(entity =>
            {
                entity.HasOne(d => d.Spill)
                    .WithMany(p => p.SpillLanguages)
                    .HasForeignKey(d => d.SpillID)
                    .HasConstraintName("FK_SpillLanguages_Spills");
            });
        }
        private void OnModelCreating_Spill(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Spill>(entity =>
            {
                entity.HasOne(d => d.InfrastructureTVItem)
                    .WithMany(p => p.SpillsInfrastructureTVItem)
                    .HasForeignKey(d => d.InfrastructureTVItemID)
                    .HasConstraintName("FK_Spills_InfrastructureTVItemID");

                entity.HasOne(d => d.MunicipalityTVItem)
                    .WithMany(p => p.SpillsMunicipalityTVItem)
                    .HasForeignKey(d => d.MunicipalityTVItemID)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Spills_MunicipalityTVIteID");
            });
        }
        private void OnModelCreating_Tel(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Tel>(entity =>
            {
                entity.HasOne(d => d.TelTVItem)
                    .WithMany(p => p.Tels)
                    .HasForeignKey(d => d.TelTVItemID)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_TelTVItemID_TVItems");
            });
        }
        private void OnModelCreating_TideDataValue(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TideDataValue>(entity =>
            {
                entity.HasOne(d => d.TideSiteTVItem)
                    .WithMany(p => p.TideDataValues)
                    .HasForeignKey(d => d.TideSiteTVItemID)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_TideDataValues_TVItems");
            });
        }
        private void OnModelCreating_TideLocation(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TideLocation>(entity =>
            {
            });
        }
        private void OnModelCreating_TideSite(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TideSite>(entity =>
            {
                entity.HasOne(d => d.TideSiteTVItem)
                    .WithMany(p => p.TideSites)
                    .HasForeignKey(d => d.TideSiteTVItemID)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_TideSites_TVItems");
            });
        }
        private void OnModelCreating_TVFileLanguage(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TVFileLanguage>(entity =>
            {
                entity.HasKey(e => e.TVFileLanguageID)
                    .HasName("PK_TVFileLanguages");

                entity.ToTable("TVFileLanguages");

                entity.HasIndex(e => e.TVFileID)
                    .HasName("IX_TVFileID");

                entity.Property(e => e.TVFileID)
                    .IsRequired()
                    .HasAnnotation("Min", 1)
                    .HasAnnotation("ObjectExist", "TVFile");

                entity.HasIndex(e => e.Language)
                    .HasName("IX_Language");

                entity.Property(e => e.Language)
                    .IsRequired()
                    .HasAnnotation("Type", typeof(LanguageEnum));

                entity.Property(e => e.FileDescription);

                entity.HasIndex(e => e.TranslationStatus)
                    .HasName("IX_TranslationStatus");

                entity.Property(e => e.TranslationStatus)
                    .IsRequired()
                    .HasAnnotation("Type", typeof(TranslationStatusEnum));

                entity.HasIndex(e => e.LastUpdateDate_UTC)
                    .HasName("IX_LastUpdateDate_UTC");

                entity.Property(e => e.LastUpdateDate_UTC)
                    .IsRequired()
                    .HasColumnType("datetime")
                    .HasAnnotation("DateAfterYear", 1980);

                entity.HasIndex(e => e.LastUpdateContactTVItemID)
                    .HasName("IX_LastUpdateContactTVItemID");

                entity.Property(e => e.LastUpdateContactTVItemID)
                    .IsRequired()
                    .HasAnnotation("Min", 1)
                    .HasAnnotation("ObjectExist", "TVItem");

                entity.HasOne(d => d.TVFile)
                    .WithMany(p => p.TVFileLanguages)
                    .HasForeignKey(d => d.TVFileID)
                    .HasConstraintName("FK_TVFileLanguages_TVFiles");
            });
        }
        private void OnModelCreating_TVFile(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TVFile>(entity =>
            {
                entity.HasKey(e => e.TVFileID)
                    .HasName("PK_TVFileID");

                entity.ToTable("TVFiles");

                entity.HasIndex(e => e.TVFileTVItemID)
                    .HasName("IX_TVItemID");

                entity.Property(e => e.TVFileTVItemID)
                    .IsRequired()
                    .HasAnnotation("Min", 1)
                    .HasAnnotation("ObjectExist", "TVItem");

                entity.Property(e => e.TemplateTVType)
                    .IsRequired()
                    .HasAnnotation("Type", typeof(TVTypeEnum));

                entity.Property(e => e.Language)
                    .IsRequired()
                    .HasAnnotation("Type", typeof(LanguageEnum));

                entity.HasIndex(e => e.FilePurpose)
                    .HasName("IX_FilePurpose");

                entity.Property(e => e.FilePurpose)
                    .IsRequired()
                    .HasAnnotation("Type", typeof(FilePurposeEnum));

                entity.HasIndex(e => e.FileType)
                    .HasName("IX_FileType");

                entity.Property(e => e.FileType)
                    .IsRequired()
                    .HasAnnotation("Type", typeof(FileTypeEnum));

                entity.HasIndex(e => e.FileSize_kb)
                    .HasName("IX_FileSize");

                entity.Property(e => e.FileSize_kb)
                    .IsRequired()
                    .HasAnnotation("Min", 0)
                    .HasAnnotation("Max", 100000);

                entity.Property(e => e.FileInfo)
                    .HasAnnotation("Min", 0)
                    .HasAnnotation("Max", 100000);

                entity.HasIndex(e => e.FileCreatedDate_UTC)
                    .HasName("IX_FileCreatedDate_UTC");

                entity.Property(e => e.FileCreatedDate_UTC)
                    .IsRequired()
                    .HasColumnType("datetime")
                    .HasAnnotation("DateAfterYear", 1980);

                entity.HasIndex(e => e.FromWater)
                    .HasName("IX_FromWater");

                entity.Property(e => e.FromWater);

                entity.Property(e => e.ClientFilePath)
                    .HasMaxLength(250)
                    .HasAnnotation("Min", 2);

                entity.HasIndex(e => e.ServerFileName)
                    .HasName("IX_ServerFileName");

                entity.Property(e => e.ServerFileName)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasAnnotation("Min", 2);

                entity.HasIndex(e => e.ServerFilePath)
                    .HasName("IX_ServerFilePath");

                entity.Property(e => e.ServerFilePath)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasAnnotation("Min", 2);

                entity.HasIndex(e => e.LastUpdateDate_UTC)
                    .HasName("IX_LastUpdateDate_UTC");

                entity.Property(e => e.LastUpdateDate_UTC)
                    .IsRequired()
                    .HasColumnType("datetime")
                    .HasAnnotation("DateAfterYear", 1980);

                entity.HasIndex(e => e.LastUpdateContactTVItemID)
                    .HasName("IX_LastUpdateContactID");

                entity.Property(e => e.LastUpdateContactTVItemID)
                    .IsRequired()
                    .HasAnnotation("Min", 1)
                    .HasAnnotation("ObjectExist", "TVItem");

                entity.HasOne(d => d.TVFileTVItem)
                    .WithMany(p => p.TVFiles)
                    .HasForeignKey(d => d.TVFileTVItemID)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_TVFiles_TVItems");
            });
        }
        private void OnModelCreating_TVItemLanguage(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TVItemLanguage>(entity =>
            {
                entity.HasKey(e => e.TVItemLanguageID)
                    .HasName("PK_TVItemLanguages");

                entity.ToTable("TVItemLanguages");

                entity.HasIndex(e => e.TVItemID)
                    .HasName("IX_TVItemID");

                entity.Property(e => e.TVItemID)
                    .IsRequired()
                    .HasAnnotation("Min", 1)
                    .HasAnnotation("ObjectExist", "TVItem");

                entity.HasIndex(e => e.Language)
                    .HasName("IX_Language");

                entity.Property(e => e.Language)
                    .IsRequired()
                    .HasAnnotation("Type", typeof(LanguageEnum));

                entity.HasIndex(e => e.TVText)
                    .HasName("IX_TVText");

                entity.Property(e => e.TVText)
                    .IsRequired()
                    .HasAnnotation("Min", 1)
                    .HasAnnotation("Max", 200);

                entity.HasIndex(e => e.TranslationStatus)
                    .HasName("IX_TranslationStatusTVItemID");

                entity.Property(e => e.TranslationStatus)
                    .IsRequired()
                    .HasAnnotation("Type", typeof(TranslationStatusEnum));

                entity.HasIndex(e => e.LastUpdateDate_UTC)
                    .HasName("IX_LastUpdateContactID");

                entity.Property(e => e.LastUpdateDate_UTC)
                    .IsRequired()
                    .HasColumnType("datetime")
                    .HasAnnotation("DateAfterYear", 1980);

                entity.HasIndex(e => e.LastUpdateContactTVItemID)
                    .HasName("IX_LastUpdateUserInfoID");

                entity.Property(e => e.LastUpdateContactTVItemID)
                    .IsRequired()
                    .HasAnnotation("Min", 1)
                    .HasAnnotation("ObjectExist", "TVItem");

                entity.HasOne(d => d.TVItem)
                    .WithMany(p => p.TVItemLanguages)
                    .HasForeignKey(d => d.TVItemID)
                    .HasConstraintName("FK_TVItemLanguages_TVItems");
            });
        }
        private void OnModelCreating_TVItemLink(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TVItemLink>(entity =>
            {
                entity.HasKey(e => e.TVItemLinkID)
                    .HasName("PK_TVItemLinks");

                entity.ToTable("TVItemLinks");

                entity.HasIndex(e => e.FromTVItemID)
                    .HasName("IX_TVItemIDFrom");

                entity.Property(e => e.FromTVItemID)
                    .IsRequired()
                    .HasAnnotation("Min", 1)
                    .HasAnnotation("ObjectExist", "TVItem");

                entity.HasIndex(e => e.ToTVItemID)
                    .HasName("IX_TVItemIDTo");

                entity.Property(e => e.ToTVItemID)
                    .IsRequired()
                    .HasAnnotation("Min", 1)
                    .HasAnnotation("ObjectExist", "TVItem");

                entity.Property(e => e.FromTVType)
                    .IsRequired()
                    .HasAnnotation("Type", typeof(TVTypeEnum));

                entity.Property(e => e.ToTVType)
                    .IsRequired()
                    .HasAnnotation("Type", typeof(TVTypeEnum));

                entity.HasIndex(e => e.StartDateTime_Local)
                    .HasName("IX_StartDateTime_UTC");

                entity.Property(e => e.StartDateTime_Local)
                    .HasColumnType("datetime")
                    .HasAnnotation("DateAfterYear", 1980);

                entity.HasIndex(e => e.EndDateTime_Local)
                    .HasName("IX_EndDateTime_UTC");

                entity.Property(e => e.EndDateTime_Local)
                    .HasColumnType("datetime")
                    .HasAnnotation("DateAfterYear", 1980);

                entity.Property(e => e.Ordinal)
                    .HasAnnotation("Min", 0)
                    .HasAnnotation("Max", 1000);

                entity.Property(e => e.TVLevel)
                    .HasAnnotation("Min", 0)
                    .HasAnnotation("Max", 12);

                entity.Property(e => e.TVPath)
                    .HasMaxLength(250)
                    .HasAnnotation("Min", 2);

                entity.HasIndex(e => e.ParentTVItemLinkID)
                    .HasName("IX_ParentTVItemLinkID");

                entity.Property(e => e.ParentTVItemLinkID)
                    .HasAnnotation("Min", 1)
                    .HasAnnotation("ObjectExist", "TVItem");

                entity.HasIndex(e => e.LastUpdateDate_UTC)
                    .HasName("IX_LastUpdateDate_UTC");

                entity.Property(e => e.LastUpdateDate_UTC)
                    .IsRequired()
                    .HasColumnType("datetime")
                    .HasAnnotation("DateAfterYear", 1980);

                entity.HasIndex(e => e.LastUpdateContactTVItemID)
                    .HasName("IX_LastUpdateContactID");

                entity.Property(e => e.LastUpdateContactTVItemID)
                    .IsRequired()
                    .HasAnnotation("Min", 1)
                    .HasAnnotation("ObjectExist", "TVItem");

                entity.HasOne(d => d.FromTVItem)
                    .WithMany(p => p.TVItemLinksFromTVItem)
                    .HasForeignKey(d => d.FromTVItemID)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_TVItemLinks_FromTVItems");

                entity.HasOne(d => d.ParentTVItemLink)
                    .WithMany(p => p.InverseParentTVItemLink)
                    .HasForeignKey(d => d.ParentTVItemLinkID)
                    .HasConstraintName("FK_TVItemLinks_ParentTVItemLinks");

                entity.HasOne(d => d.ToTVItem)
                    .WithMany(p => p.TVItemLinksToTVItem)
                    .HasForeignKey(d => d.ToTVItemID)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_TVItemLinks_ToTVItems");
            });
        }
        private void OnModelCreating_TVItem(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TVItem>(entity =>
            {
                entity.HasKey(e => e.TVItemID)
                    .HasName("PK_TVItems");

                entity.ToTable("TVItems");

                entity.HasIndex(e => e.TVLevel)
                    .HasName("IX_TVLevel");

                entity.Property(e => e.TVLevel)
                    .IsRequired()
                    .HasAnnotation("Min", 0)
                    .HasAnnotation("Max", 12);

                entity.HasIndex(e => e.TVPath)
                    .HasName("IX_TVPath");

                entity.Property(e => e.TVPath)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasAnnotation("Min", 2);

                entity.HasIndex(e => e.TVType)
                    .HasName("IX_TVType");

                entity.Property(e => e.TVType)
                    .IsRequired()
                    .HasAnnotation("Type", typeof(TVTypeEnum));

                entity.HasIndex(e => e.ParentID)
                    .HasName("IX_ParentID");

                entity.Property(e => e.ParentID)
                    .IsRequired()
                    .HasAnnotation("Min", 1)
                    .HasAnnotation("ObjectExist", "TVItem");

                entity.HasIndex(e => e.IsActive)
                    .HasName("IX_IsActive");

                entity.Property(e => e.IsActive)
                    .IsRequired();

                entity.HasIndex(e => e.LastUpdateDate_UTC)
                    .HasName("IX_LastUpdateDate_UTC");

                entity.Property(e => e.LastUpdateDate_UTC)
                    .IsRequired()
                    .HasColumnType("datetime")
                    .HasAnnotation("DateAfterYear", 1980);

                entity.HasIndex(e => e.LastUpdateContactTVItemID)
                    .HasName("IX_LastUpdateContactID");

                entity.Property(e => e.LastUpdateContactTVItemID)
                    .IsRequired()
                    .HasAnnotation("Min", 1)
                    .HasAnnotation("ObjectExist", "TVItem");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.InverseParent)
                    .HasForeignKey(d => d.ParentID)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_TVItems_ParentID");
            });
        }
        private void OnModelCreating_TVItemStat(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TVItemStat>(entity =>
            {
                entity.HasKey(e => e.TVItemStatID)
                    .HasName("PK_TVItemStats");

                entity.ToTable("TVItemStats");

                entity.HasIndex(e => e.TVItemID)
                    .HasName("IX_TVItemID");

                entity.Property(e => e.TVItemID)
                    .IsRequired()
                    .HasAnnotation("Min", 1)
                    .HasAnnotation("ObjectExist", "TVItem");

                entity.HasIndex(e => e.TVType)
                    .HasName("IX_TVType");

                entity.Property(e => e.TVType)
                    .IsRequired()
                    .HasAnnotation("Type", typeof(TVTypeEnum));

                entity.HasIndex(e => e.ChildCount)
                    .HasName("IX_ChildCount");

                entity.Property(e => e.ChildCount)
                    .IsRequired()
                    .HasAnnotation("Min", 0)
                    .HasAnnotation("Max", 100000000);

                entity.HasIndex(e => e.LastUpdateDate_UTC)
                    .HasName("IX_LastUpdateDate_UTC");

                entity.Property(e => e.LastUpdateDate_UTC)
                    .IsRequired()
                    .HasColumnType("datetime")
                    .HasAnnotation("DateAfterYear", 1980);

                entity.HasIndex(e => e.LastUpdateContactTVItemID)
                    .HasName("IX_LastUpdateContactID");

                entity.Property(e => e.LastUpdateContactTVItemID)
                    .IsRequired()
                    .HasAnnotation("Min", 1)
                    .HasAnnotation("ObjectExist", "TVItem");

                entity.HasOne(d => d.TVItem)
                    .WithMany(p => p.TVItemStats)
                    .HasForeignKey(d => d.TVItemID)
                    .HasConstraintName("FK_TVItemStats_TVItems");
            });
        }
        private void OnModelCreating_TVItemUserAuthorization(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TVItemUserAuthorization>(entity =>
            {
                entity.HasKey(e => e.TVItemUserAuthorizationID)
                    .HasName("PK_TVItemsUserAuthorizations");

                entity.ToTable("TVItemUserAuthorizations");

                entity.HasIndex(e => e.ContactTVItemID)
                    .HasName("IX_ContactTVItemID");

                entity.Property(e => e.ContactTVItemID)
                    .IsRequired()
                    .HasAnnotation("Min", 1)
                    .HasAnnotation("ObjectExist", "TVItem");

                entity.HasIndex(e => e.TVItemID1)
                    .HasName("IX_TVItemID");

                entity.Property(e => e.TVItemID1)
                    .IsRequired()
                    .HasAnnotation("Min", 1)
                    .HasAnnotation("ObjectExist", "TVItem");

                entity.Property(e => e.TVItemID2)
                    .HasAnnotation("Min", 1)
                    .HasAnnotation("ObjectExist", "TVItem");

                entity.Property(e => e.TVItemID3)
                    .HasAnnotation("Min", 1)
                    .HasAnnotation("ObjectExist", "TVItem");

                entity.Property(e => e.TVItemID4)
                    .HasAnnotation("Min", 1)
                    .HasAnnotation("ObjectExist", "TVItem");

                entity.HasIndex(e => e.TVAuth)
                    .HasName("IX_TVAuth");

                entity.Property(e => e.TVAuth)
                    .IsRequired()
                    .HasAnnotation("Type", typeof(TVAuthEnum));

                entity.HasIndex(e => e.LastUpdateDate_UTC)
                    .HasName("IX_LastUpdateDate_UTC");

                entity.Property(e => e.LastUpdateDate_UTC)
                    .IsRequired()
                    .HasColumnType("datetime")
                    .HasAnnotation("DateAfterYear", 1980);

                entity.HasIndex(e => e.LastUpdateContactTVItemID)
                    .HasName("IX_LastUpdateContactID");

                entity.Property(e => e.LastUpdateContactTVItemID)
                    .IsRequired()
                    .HasAnnotation("Min", 1)
                    .HasAnnotation("ObjectExist", "TVItem");

                entity.HasOne(d => d.ContactTVItem)
                    .WithMany(p => p.TVItemUserAuthorizationsContactTVItem)
                    .HasForeignKey(d => d.ContactTVItemID)
                    .HasConstraintName("FK_TVItemUserAuthorizations_Contacts");

                entity.HasOne(d => d.TVItemID1Navigation)
                    .WithMany(p => p.TVItemUserAuthorizationsTVItemID1Navigation)
                    .HasForeignKey(d => d.TVItemID1)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_TVItemsUserAuthorizations_TVItems");
            });
        }
        private void OnModelCreating_TVTypeUserAuthorization(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TVTypeUserAuthorization>(entity =>
            {
                entity.HasKey(e => e.TVTypeUserAuthorizationID)
                    .HasName("PK_TVTypeUserAuthorizations");

                entity.ToTable("TVTypeUserAuthorizations");

                entity.HasIndex(e => e.ContactTVItemID)
                    .HasName("IX_ContactTVItemID");

                entity.Property(e => e.ContactTVItemID)
                    .IsRequired()
                    .HasAnnotation("Min", 1)
                    .HasAnnotation("ObjectExist", "TVItem");

                entity.HasIndex(e => e.TVType)
                    .HasName("IX_TVType");

                entity.Property(e => e.TVType)
                    .IsRequired()
                    .HasAnnotation("Type", typeof(TVTypeEnum));

                entity.HasIndex(e => e.TVAuth)
                    .HasName("IX_TVAuth");

                entity.Property(e => e.TVAuth)
                    .IsRequired()
                    .HasAnnotation("Type", typeof(TVAuthEnum));

                entity.HasIndex(e => e.LastUpdateDate_UTC)
                    .HasName("IX_LastUpdateDate_UTC");

                entity.Property(e => e.LastUpdateDate_UTC)
                    .IsRequired()
                    .HasColumnType("datetime")
                    .HasAnnotation("DateAfterYear", 1980);

                entity.HasIndex(e => e.LastUpdateContactTVItemID)
                    .HasName("IX_LastUpdateContactID");

                entity.Property(e => e.LastUpdateContactTVItemID)
                    .IsRequired()
                    .HasAnnotation("Min", 1)
                    .HasAnnotation("ObjectExist", "TVItem");

                entity.HasOne(d => d.ContactTVItem)
                    .WithMany(p => p.TVTypeUserAuthorizations)
                    .HasForeignKey(d => d.ContactTVItemID)
                    .HasConstraintName("FK_TVTypeUserAuthorizations_Contacts");
            });
        }
        private void OnModelCreating_UseOfSite(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UseOfSite>(entity =>
            {
                entity.HasKey(e => e.UseOfSiteID)
                    .HasName("PK_UseOfClimateSites");

                entity.ToTable("UseOfSites");

                entity.HasIndex(e => e.SiteTVItemID)
                    .HasName("IX_SiteTVItemID");

                entity.Property(e => e.SiteTVItemID)
                    .IsRequired()
                    .HasAnnotation("Min", 1)
                    .HasAnnotation("ObjectExist", "TVItem");

                entity.HasIndex(e => e.SubsectorTVItemID)
                    .HasName("IX_SubsectorTVItemID");

                entity.Property(e => e.SubsectorTVItemID)
                    .IsRequired()
                    .HasAnnotation("Min", 1)
                    .HasAnnotation("ObjectExist", "TVItem");

                entity.HasIndex(e => e.SiteType)
                    .HasName("IX_SiteType");

                entity.Property(e => e.SiteType)
                    .IsRequired()
                    .HasAnnotation("Type", typeof(SiteTypeEnum));

                entity.HasIndex(e => e.Ordinal)
                    .HasName("IX_Ordinal");

                entity.Property(e => e.Ordinal)
                    .IsRequired()
                    .HasAnnotation("Min", 0)
                    .HasAnnotation("Max", 1000);

                entity.HasIndex(e => e.StartYear)
                    .HasName("IX_StartYear");

                entity.Property(e => e.StartYear)
                    .IsRequired()
                    .HasAnnotation("Min", 1980)
                    .HasAnnotation("Max", 2050);

                entity.HasIndex(e => e.EndYear)
                    .HasName("IX_EndYear");

                entity.Property(e => e.EndYear)
                    .HasAnnotation("Min", 1980)
                    .HasAnnotation("Max", 2050);

                entity.HasIndex(e => e.UseWeight)
                    .HasName("IX_UseWeight");

                entity.Property(e => e.UseWeight);

                entity.HasIndex(e => e.Weight_perc)
                    .HasName("IX_Weight_perc");

                entity.Property(e => e.Weight_perc)
                    .HasAnnotation("Min", 0.0f)
                    .HasAnnotation("Max", 1000.0f);

                entity.HasIndex(e => e.UseEquation)
                    .HasName("IX_UseEquation");

                entity.Property(e => e.UseEquation);

                entity.Property(e => e.Param1)
                    .HasAnnotation("Min", 0.0f)
                    .HasAnnotation("Max", 1000.0f);

                entity.Property(e => e.Param2)
                    .HasAnnotation("Min", 0.0f)
                    .HasAnnotation("Max", 1000.0f);

                entity.Property(e => e.Param3)
                    .HasAnnotation("Min", 0.0f)
                    .HasAnnotation("Max", 1000.0f);

                entity.Property(e => e.Param4)
                    .HasAnnotation("Min", 0.0f)
                    .HasAnnotation("Max", 1000.0f);

                entity.HasIndex(e => e.LastUpdateDate_UTC)
                    .HasName("IX_LastUpdateDate_UTC");

                entity.Property(e => e.LastUpdateDate_UTC)
                    .IsRequired()
                    .HasColumnType("datetime")
                    .HasAnnotation("DateAfterYear", 1980);

                entity.HasIndex(e => e.LastUpdateContactTVItemID)
                    .HasName("IX_LastUpdateContactID");

                entity.Property(e => e.LastUpdateContactTVItemID)
                    .IsRequired()
                    .HasAnnotation("Min", 1)
                    .HasAnnotation("ObjectExist", "TVItem");

                entity.HasOne(d => d.SiteTVItem)
                    .WithMany(p => p.UseOfSitesSiteTVItem)
                    .HasForeignKey(d => d.SiteTVItemID)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_UseOfSites_SiteTVItems");

                entity.HasOne(d => d.SubsectorTVItem)
                    .WithMany(p => p.UseOfSitesSubsectorTVItem)
                    .HasForeignKey(d => d.SubsectorTVItemID)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_UseOfSites_SubsectorTVItems");
            });
        }
        private void OnModelCreating_VPAmbient(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<VPAmbient>(entity =>
            {
                entity.HasKey(e => e.VPAmbientID)
                    .HasName("PK_VPAmbients");

                entity.ToTable("VPAmbients");

                entity.HasIndex(e => e.VPScenarioID)
                    .HasName("IX_VPScenarioID");

                entity.Property(e => e.VPScenarioID)
                    .IsRequired()
                    .HasAnnotation("Min", 1)
                    .HasAnnotation("ObjectExist", "VPScenario");

                entity.HasIndex(e => e.Row)
                    .HasName("IX_Row");

                entity.Property(e => e.Row)
                    .IsRequired()
                    .HasAnnotation("Min", 1)
                    .HasAnnotation("Max", 8);

                entity.HasIndex(e => e.MeasurementDepth_m)
                    .HasName("IX_MeasurementDepth_m");

                entity.Property(e => e.MeasurementDepth_m)
                    .IsRequired()
                    .HasAnnotation("Min", 0.0f)
                    .HasAnnotation("Max", 1000.0f);

                entity.HasIndex(e => e.CurrentSpeed_m_s)
                    .HasName("IX_CurrentSpeed_m_s");

                entity.Property(e => e.CurrentSpeed_m_s)
                    .IsRequired()
                    .HasAnnotation("Min", 0.0f)
                    .HasAnnotation("Max", 10.0f);

                entity.HasIndex(e => e.CurrentDirection_deg)
                    .HasName("IX_CurrentDirection_deg");

                entity.Property(e => e.CurrentDirection_deg)
                    .IsRequired()
                    .HasAnnotation("Min", 0.0f)
                    .HasAnnotation("Max", 360.0f);

                entity.HasIndex(e => e.AmbientSalinity_PSU)
                    .HasName("IX_AmbientSalinity_PSU");

                entity.Property(e => e.AmbientSalinity_PSU)
                    .IsRequired()
                    .HasAnnotation("Min", 0.0f)
                    .HasAnnotation("Max", 40.0f);

                entity.HasIndex(e => e.AmbientTemperature_C)
                    .HasName("IX_AmbientTemperature_C");

                entity.Property(e => e.AmbientTemperature_C)
                    .IsRequired()
                    .HasAnnotation("Min", 0.0f)
                    .HasAnnotation("Max", 50.0f);

                entity.HasIndex(e => e.BackgroundConcentration_MPN_100ml)
                    .HasName("IX_BackgroundConcentration_MPN_100ml");

                entity.Property(e => e.BackgroundConcentration_MPN_100ml)
                    .IsRequired()
                    .HasAnnotation("Min", 0)
                    .HasAnnotation("Max", 100000000);

                entity.HasIndex(e => e.PollutantDecayRate_per_day)
                    .HasName("IX_PollutantDecayRate_per_day");

                entity.Property(e => e.PollutantDecayRate_per_day)
                    .IsRequired()
                    .HasAnnotation("Min", 0.0f)
                    .HasAnnotation("Max", 1000.0f);

                entity.HasIndex(e => e.FarFieldCurrentSpeed_m_s)
                    .HasName("IX_FarFieldCurrentSpeed_m_s");

                entity.Property(e => e.FarFieldCurrentSpeed_m_s)
                    .IsRequired()
                    .HasAnnotation("Min", 0.0f)
                    .HasAnnotation("Max", 10.0f);

                entity.HasIndex(e => e.FarFieldCurrentDirection_deg)
                    .HasName("IX_FarFieldCurrentDirection_deg");

                entity.Property(e => e.FarFieldCurrentDirection_deg)
                    .IsRequired()
                    .HasAnnotation("Min", 0.0f)
                    .HasAnnotation("Max", 360.0f);

                entity.HasIndex(e => e.FarFieldDiffusionCoefficient)
                    .HasName("IX_FarFieldDiffusionCoefficient");

                entity.Property(e => e.FarFieldDiffusionCoefficient)
                    .IsRequired()
                    .HasAnnotation("Min", 0.0f)
                    .HasAnnotation("Max", 10.0f);

                entity.HasIndex(e => e.LastUpdateDate_UTC)
                    .HasName("IX_LastUpdateDate_UTC");

                entity.Property(e => e.LastUpdateDate_UTC)
                    .IsRequired()
                    .HasColumnType("datetime")
                    .HasAnnotation("DateAfterYear", 1980);

                entity.HasIndex(e => e.LastUpdateContactTVItemID)
                    .HasName("IX_LastUpdateContactID");

                entity.Property(e => e.LastUpdateContactTVItemID)
                    .IsRequired()
                    .HasAnnotation("Min", 1)
                    .HasAnnotation("ObjectExist", "TVItem");

                entity.HasOne(d => d.VPScenario)
                    .WithMany(p => p.VPAmbients)
                    .HasForeignKey(d => d.VPScenarioID)
                    .HasConstraintName("FK_VPAmbients_VPScenarios");
            });
        }
        private void OnModelCreating_VPResult(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<VPResult>(entity =>
            {
                entity.HasKey(e => e.VPResultID)
                    .HasName("PK_VPResults");

                entity.ToTable("VPResults");

                entity.HasIndex(e => e.VPScenarioID)
                    .HasName("IX_VPScenarioID");

                entity.Property(e => e.VPScenarioID)
                    .IsRequired()
                    .HasAnnotation("Min", 1)
                    .HasAnnotation("ObjectExist", "VPScenario");

                entity.HasIndex(e => e.Ordinal)
                    .HasName("IX_Ordinal");

                entity.Property(e => e.Ordinal)
                    .IsRequired()
                    .HasAnnotation("Min", 0)
                    .HasAnnotation("Max", 100);

                entity.HasIndex(e => e.Concentration_MPN_100ml)
                    .HasName("IX_Concentration_MPN_100ml");

                entity.Property(e => e.Concentration_MPN_100ml)
                    .IsRequired()
                    .HasAnnotation("Min", 0)
                    .HasAnnotation("Max", 20000000);

                entity.HasIndex(e => e.Dilution)
                    .HasName("IX_Dilution");

                entity.Property(e => e.Dilution)
                    .IsRequired()
                    .HasAnnotation("Min", 0.0f)
                    .HasAnnotation("Max", 1000000.0f);

                entity.HasIndex(e => e.FarFieldWidth_m)
                    .HasName("IX_FarFieldWidth_m");

                entity.Property(e => e.FarFieldWidth_m)
                    .IsRequired()
                    .HasAnnotation("Min", 0.0f)
                    .HasAnnotation("Max", 100000.0f);

                entity.HasIndex(e => e.DispersionDistance_m)
                    .HasName("IX_DispersionDistance_m");

                entity.Property(e => e.DispersionDistance_m)
                    .IsRequired()
                    .HasAnnotation("Min", 0.0f)
                    .HasAnnotation("Max", 100000.0f);

                entity.HasIndex(e => e.TravelTime_hour)
                    .HasName("IX_TravelTime_hour");

                entity.Property(e => e.TravelTime_hour)
                    .IsRequired()
                    .HasAnnotation("Min", 0.0f)
                    .HasAnnotation("Max", 1000.0f);

                entity.HasIndex(e => e.LastUpdateDate_UTC)
                    .HasName("IX_LastUpdateDate_UTC");

                entity.Property(e => e.LastUpdateDate_UTC)
                    .IsRequired()
                    .HasColumnType("datetime")
                    .HasAnnotation("DateAfterYear", 1980);

                entity.HasIndex(e => e.LastUpdateContactTVItemID)
                    .HasName("IX_LastUpdateContactID");

                entity.Property(e => e.LastUpdateContactTVItemID)
                    .IsRequired()
                    .HasAnnotation("Min", 1)
                    .HasAnnotation("ObjectExist", "TVItem");

                entity.HasOne(d => d.VPScenario)
                    .WithMany(p => p.VPResults)
                    .HasForeignKey(d => d.VPScenarioID)
                    .HasConstraintName("FK_VPResults_VPScenarios");
            });
        }
        private void OnModelCreating_VPScenarioLanguage(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<VPScenarioLanguage>(entity =>
            {
                entity.HasKey(e => e.VPScenarioLanguageID)
                    .HasName("PK_VPScenarioLanguages");

                entity.ToTable("VPScenarioLanguages");

                entity.HasIndex(e => e.VPScenarioID)
                    .HasName("IX_VPScenarioID");

                entity.Property(e => e.VPScenarioID)
                    .IsRequired()
                    .HasAnnotation("Min", 1)
                    .HasAnnotation("ObjectExist", "VPScenario");

                entity.HasIndex(e => e.Language)
                    .HasName("IX_Language");

                entity.Property(e => e.Language)
                    .IsRequired()
                    .HasAnnotation("Type", typeof(LanguageEnum));

                entity.HasIndex(e => e.VPScenarioName)
                    .HasName("IX_VPScenarioName");

                entity.Property(e => e.VPScenarioName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasAnnotation("Min", 1);

                entity.HasIndex(e => e.TranslationStatus)
                    .HasName("IX_VPScenarioNameStatus");

                entity.Property(e => e.TranslationStatus)
                    .IsRequired()
                    .HasAnnotation("Type", typeof(TranslationStatusEnum));

                entity.HasIndex(e => e.LastUpdateDate_UTC)
                    .HasName("IX_LastUpdateDate_UTC");

                entity.Property(e => e.LastUpdateDate_UTC)
                    .IsRequired()
                    .HasColumnType("datetime")
                    .HasAnnotation("DateAfterYear", 1980);

                entity.HasIndex(e => e.LastUpdateContactTVItemID)
                    .HasName("IX_LastUpdateContactID");

                entity.Property(e => e.LastUpdateContactTVItemID)
                    .IsRequired()
                    .HasAnnotation("Min", 1)
                    .HasAnnotation("ObjectExist", "TVItem");

                entity.HasOne(d => d.VPScenario)
                    .WithMany(p => p.VPScenarioLanguages)
                    .HasForeignKey(d => d.VPScenarioID)
                    .HasConstraintName("FK_VPScenarioLanguages_VPScenarios");
            });
        }
        private void OnModelCreating_VPScenario(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<VPScenario>(entity =>
            {
                entity.HasKey(e => e.VPScenarioID)
                    .HasName("PK_Scenarios");

                entity.ToTable("VPScenarios");

                entity.HasIndex(e => e.InfrastructureTVItemID)
                    .HasName("IX_InfrastructureTVItemID");

                entity.Property(e => e.InfrastructureTVItemID)
                    .IsRequired()
                    .HasAnnotation("Min", 1)
                    .HasAnnotation("ObjectExist", "TVItem");

                entity.Property(e => e.VPScenarioStatus)
                    .IsRequired()
                    .HasAnnotation("Type", typeof(ScenarioStatusEnum));

                entity.HasIndex(e => e.UseAsBestEstimate)
                    .HasName("IX_UseAsBestEstimate");

                entity.Property(e => e.UseAsBestEstimate)
                    .IsRequired();

                entity.HasIndex(e => e.EffluentFlow_m3_s)
                    .HasName("IX_EffluentFlow_m3_s");

                entity.Property(e => e.EffluentFlow_m3_s)
                    .IsRequired()
                    .HasAnnotation("Min", 0.0f)
                    .HasAnnotation("Max", 100000.0f);

                entity.HasIndex(e => e.EffluentConcentration_MPN_100ml)
                    .HasName("IX_EffluentConcentration_MPN_100ml");

                entity.Property(e => e.EffluentConcentration_MPN_100ml)
                    .IsRequired()
                    .HasAnnotation("Min", 0)
                    .HasAnnotation("Max", 100000000);

                entity.HasIndex(e => e.FroudeNumber)
                    .HasName("IX_FroudeNumber");

                entity.Property(e => e.FroudeNumber)
                    .IsRequired()
                    .HasAnnotation("Min", 0.0f)
                    .HasAnnotation("Max", 1000000.0f);

                entity.HasIndex(e => e.PortDiameter_m)
                    .HasName("IX_PortDiameter_m");

                entity.Property(e => e.PortDiameter_m)
                    .IsRequired()
                    .HasAnnotation("Min", 0.0f)
                    .HasAnnotation("Max", 100.0f);

                entity.HasIndex(e => e.PortDepth_m)
                    .HasName("IX_PortDepth_m");

                entity.Property(e => e.PortDepth_m)
                    .IsRequired()
                    .HasAnnotation("Min", 0.0f)
                    .HasAnnotation("Max", 1000.0f);

                entity.HasIndex(e => e.PortElevation_m)
                    .HasName("IX_PortElevation_m");

                entity.Property(e => e.PortElevation_m)
                    .IsRequired()
                    .HasAnnotation("Min", 0.0f)
                    .HasAnnotation("Max", 1000.0f);

                entity.HasIndex(e => e.VerticalAngle_deg)
                    .HasName("IX_VerticalAngle_deg");

                entity.Property(e => e.VerticalAngle_deg)
                    .IsRequired()
                    .HasAnnotation("Min", 0.0f)
                    .HasAnnotation("Max", 180.0f);

                entity.HasIndex(e => e.HorizontalAngle_deg)
                    .HasName("IX_HorizontalAngle_deg");

                entity.Property(e => e.HorizontalAngle_deg)
                    .IsRequired()
                    .HasAnnotation("Min", -180.0f)
                    .HasAnnotation("Max", 180.0f);

                entity.HasIndex(e => e.NumberOfPorts)
                    .HasName("IX_NumberOfPorts");

                entity.Property(e => e.NumberOfPorts)
                    .IsRequired()
                    .HasAnnotation("Min", 1)
                    .HasAnnotation("Max", 100);

                entity.HasIndex(e => e.PortSpacing_m)
                    .HasName("IX_PortSpacing_m");

                entity.Property(e => e.PortSpacing_m)
                    .IsRequired()
                    .HasAnnotation("Min", 0.0f)
                    .HasAnnotation("Max", 1000.0f);

                entity.HasIndex(e => e.AcuteMixZone_m)
                    .HasName("IX_AcuteMixZone_m");

                entity.Property(e => e.AcuteMixZone_m)
                    .IsRequired()
                    .HasAnnotation("Min", 0.0f)
                    .HasAnnotation("Max", 100000.0f);

                entity.HasIndex(e => e.ChronicMixZone_m)
                    .HasName("IX_ChronicMixZone_m");

                entity.Property(e => e.ChronicMixZone_m)
                    .IsRequired()
                    .HasAnnotation("Min", 0.0f)
                    .HasAnnotation("Max", 100000.0f);

                entity.HasIndex(e => e.EffluentSalinity_PSU)
                    .HasName("IX_EffluentSalinity_PSU");

                entity.Property(e => e.EffluentSalinity_PSU)
                    .IsRequired()
                    .HasAnnotation("Min", 0.0f)
                    .HasAnnotation("Max", 40.0f);

                entity.HasIndex(e => e.EffluentTemperature_C)
                    .HasName("IX_EffluentTemperature_C");

                entity.Property(e => e.EffluentTemperature_C)
                    .IsRequired()
                    .HasAnnotation("Min", -10.0f)
                    .HasAnnotation("Max", 40.0f);

                entity.HasIndex(e => e.EffluentVelocity_m_s)
                    .HasName("IX_EffluentVelocity_m_s");

                entity.Property(e => e.EffluentVelocity_m_s)
                    .IsRequired()
                    .HasAnnotation("Min", 0.0f)
                    .HasAnnotation("Max", 10.0f);

                entity.Property(e => e.RawResults)
                    .HasColumnType("text");

                entity.HasIndex(e => e.LastUpdateDate_UTC)
                    .HasName("IX_LastUpdateDate_UTC");

                entity.Property(e => e.LastUpdateDate_UTC)
                    .IsRequired()
                    .HasColumnType("datetime")
                    .HasAnnotation("DateAfterYear", 1980);

                entity.HasIndex(e => e.LastUpdateContactTVItemID)
                    .HasName("IX_LastUpdateContactID");

                entity.Property(e => e.LastUpdateContactTVItemID)
                    .IsRequired()
                    .HasAnnotation("Min", 1)
                    .HasAnnotation("ObjectExist", "TVItem");

                entity.HasOne(d => d.InfrastructureTVItem)
                    .WithMany(p => p.VPScenarios)
                    .HasForeignKey(d => d.InfrastructureTVItemID)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_VPScenarios_InfrastructureTVItems");
            });
        }
        #endregion Functions private


    }
}