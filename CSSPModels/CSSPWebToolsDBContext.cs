using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System.Configuration;
using CSSPEnums;

namespace CSSPModels
{
    public partial class CSSPWebToolsDBContext : DbContext
    {
        // Used Custom Annotations
        // Min (used with numbers) with int or float as value also use with string to determine minimum length
        // Max (used with numbers) with int or float as value
        // Type (used with Enums) with type as value
        // DateBiggerThanOtherField (used with date) with other date field name as value
        // DateAfterYear (used with date with year as value
        // Equal (use with anytype) with other field name as value
        // ObjectExist (use with anytype) with other entity name as value

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
                entity.HasKey(e => e.AddressID)
                    .HasName("PK_Addresses");

                entity.ToTable("Addresses");

                entity.HasIndex(e => e.AddressTVItemID)
                    .HasName("IX_AddressTVItemID");

                entity.Property("AddressTVItemID")
                    .IsRequired()
                    .HasAnnotation("Min", 1)
                    .HasAnnotation("ObjectExist", "TVItem");

                entity.HasIndex(e => e.AddressType)
                    .HasName("IX_AddressType");

                entity.Property("AddressType")
                    .IsRequired()
                    .HasAnnotation("Type", typeof(AddressTypeEnum));

                entity.HasIndex(e => e.CountryTVItemID)
                    .HasName("IX_CountryTVItemID");

                entity.Property("CountryTVItemID")
                    .IsRequired()
                    .HasAnnotation("Min", 1)
                    .HasAnnotation("ObjectExist", "TVItem");

                entity.HasIndex(e => e.ProvinceTVItemID)
                    .HasName("IX_ProvinceTVItemID");

                entity.Property("ProvinceTVItemID")
                    .IsRequired()
                    .HasAnnotation("Min", 1)
                    .HasAnnotation("ObjectExist", "TVItem");

                entity.HasIndex(e => e.MunicipalityTVItemID)
                    .HasName("IX_MunicipalityTVItemID");

                entity.Property("MunicipalityTVItemID")
                    .IsRequired()
                    .HasAnnotation("Min", 1)
                    .HasAnnotation("ObjectExist", "TVItem");

                entity.HasIndex(e => e.StreetName)
                    .HasName("IX_StreetName");

                entity.Property("StreetName")
                    .HasMaxLength(200)
                    .HasAnnotation("Min", 1);

                entity.HasIndex(e => e.StreetNumber)
                    .HasName("IX_StreetNumber");

                entity.Property("StreetNumber")
                    .HasMaxLength(50)
                    .HasAnnotation("Min", 1);

                entity.HasIndex(e => e.StreetType)
                    .HasName("IX_StreetType");

                entity.Property("StreetType")
                    .HasAnnotation("Type", typeof(StreetTypeEnum));

                entity.Property(e => e.PostalCode)
                    .HasMaxLength(11)
                    .HasAnnotation("Min", 6);

                entity.Property(e => e.GoogleAddressText)
                    .HasMaxLength(200)
                    .HasAnnotation("Min", 1);

                entity.HasIndex(e => e.LastUpdateDate_UTC)
                    .HasName("IX_LastUpdateDate_UTC");

                entity.Property("LastUpdateDate_UTC")
                    .IsRequired()
                    .HasColumnType("datetime")
                    .HasAnnotation("DateAfterYear", 1980);

                entity.HasIndex(e => e.LastUpdateContactTVItemID)
                    .HasName("IX_LastUpdateContactID");

                entity.Property("LastUpdateContactTVItemID")
                    .IsRequired()
                    .HasAnnotation("Min", 1)
                    .HasAnnotation("ObjectExist", "TVItem");

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
                entity.HasKey(e => e.AppErrLogID)
                    .HasName("PK_AppErrLogs");

                entity.ToTable("AppErrLogs");

                entity.HasIndex(e => e.Tag)
                    .HasName("IX_Tag");

                entity.Property(e => e.Tag)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasIndex(e => e.LineNumber)
                    .HasName("IX_LineNumber");

                entity.Property(e => e.LineNumber)
                    .IsRequired()
                    .HasAnnotation("Min", 1)
                    .HasAnnotation("Max", 100000);

                entity.Property(e => e.Source)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.Message)
                    .IsRequired()
                    .HasColumnType("text");

                entity.HasIndex(e => e.DateTime_UTC)
                    .HasName("IX_DateTime_UTC");

                entity.Property(e => e.DateTime_UTC)
                    .IsRequired()
                    .HasColumnType("datetime")
                    .HasAnnotation("DateAfterYear", 1980);

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

            });
        }
        private void OnModelCreating_AppTaskLanguage(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppTaskLanguage>(entity =>
            {
                entity.HasKey(e => e.AppTaskLanguageID)
                    .HasName("PK_AppTaskLanguages");

                entity.ToTable("AppTaskLanguage");

                entity.HasIndex(e => e.AppTaskID)
                    .HasName("IX_AppTaskID");

                entity.Property(e => e.AppTaskID)
                    .IsRequired()
                    .HasAnnotation("Min", 1)
                    .HasAnnotation("ObjectExist", "AppTask");

                entity.HasIndex(e => e.Language)
                    .HasName("IX_Language");

                entity.Property(e => e.Language)
                    .IsRequired()
                    .HasAnnotation("Type", typeof(LanguageEnum));

                entity.Property(e => e.StatusText)
                    .HasMaxLength(250);

                entity.Property(e => e.ErrorText)
                    .HasMaxLength(250);

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
                entity.HasKey(e => e.AppTaskID)
                    .HasName("PK_AppTasks");

                entity.ToTable("AppTasks");

                entity.HasIndex(e => e.TVItemID)
                    .HasName("IX_TVItemID");

                entity.Property(e => e.TVItemID)
                    .IsRequired()
                    .HasAnnotation("Min", 1)
                    .HasAnnotation("ObjectExist", "TVItem");

                entity.HasIndex(e => e.TVItemID2)
                    .HasName("IX_TVItemID2");

                entity.Property(e => e.TVItemID2)
                    .IsRequired()
                    .HasAnnotation("Min", 1)
                    .HasAnnotation("ObjectExist", "TVItem");

                entity.HasIndex(e => e.Command)
                    .HasName("IX_AppTaskName");

                entity.Property(e => e.Command)
                    .IsRequired()
                    .HasAnnotation("Type", typeof(AppTaskCommandEnum));

                entity.HasIndex(e => e.Status)
                    .HasName("IX_Status");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasAnnotation("Type", typeof(AppTaskStatusEnum));

                entity.HasIndex(e => e.PercentCompleted)
                    .HasName("IX_PercentCompleted");

                entity.Property(e => e.PercentCompleted)
                    .IsRequired()
                    .HasAnnotation("Min", 0)
                    .HasAnnotation("Max", 100);

                entity.Property(e => e.Parameters)
                    .IsRequired()
                    .HasColumnType("text");

                entity.HasIndex(e => e.Language)
                    .HasName("IX_Language");

                entity.Property(e => e.Language)
                    .IsRequired()
                    .HasAnnotation("Type", typeof(LanguageEnum));

                entity.HasIndex(e => e.StartDateTime_UTC)
                    .HasName("IX_StartDateTime_UTC");

                entity.Property(e => e.StartDateTime_UTC)
                    .IsRequired()
                    .HasColumnType("datetime")
                    .HasAnnotation("DateAfterYear", 1980);

                entity.HasIndex(e => e.EndDateTime_UTC)
                    .HasName("IX_EndDateTime_UTC");

                entity.Property(e => e.EndDateTime_UTC)
                    .HasColumnType("datetime")
                    .HasAnnotation("DateBiggerThanOtherField", "StartDateTime_UTC");

                entity.HasIndex(e => e.EstimatedLength_second)
                    .HasName("IX_EstimatedLength_second");

                entity.Property(e => e.EstimatedLength_second)
                    .HasAnnotation("Min", 0)
                    .HasAnnotation("Max", 1000000);

                entity.HasIndex(e => e.RemainingTime_second)
                    .HasName("IX_RemainingTime_second");

                entity.Property(e => e.RemainingTime_second)
                    .HasAnnotation("Min", 0)
                    .HasAnnotation("Max", 1000000);

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
                entity.HasKey(e => e.BoxModelLanguageID)
                    .HasName("PK_BoxModelLanguages");

                entity.ToTable("BoxModelLanguages");

                entity.HasIndex(e => e.BoxModelID)
                    .HasName("IX_BoxModelID");

                entity.Property(e => e.BoxModelID)
                    .IsRequired()
                    .HasAnnotation("Min", 1)
                    .HasAnnotation("ObjectExist", "BoxModel");

                entity.HasIndex(e => e.Language)
                    .HasName("IX_Language");

                entity.Property(e => e.Language)
                    .IsRequired()
                    .HasAnnotation("Type", typeof(LanguageEnum));

                entity.HasIndex(e => e.ScenarioName)
                    .HasName("IX_ScenarioName");

                entity.Property(e => e.ScenarioName)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.HasIndex(e => e.TranslationStatus)
                    .HasName("IX_ScenarioNameStatus");

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
                entity.HasKey(e => e.BoxModelResultID)
                    .HasName("PK_BoxModelResults");

                entity.ToTable("BoxModelResults");

                entity.HasIndex(e => e.BoxModelID)
                    .HasName("IX_BoxModelID");

                entity.Property(e => e.BoxModelID)
                    .IsRequired()
                    .HasAnnotation("Min", 1)
                    .HasAnnotation("ObjectExist", "BoxModel");

                entity.HasIndex(e => e.BoxModelResultType)
                    .HasName("IX_BoxModelResultType");

                entity.Property(e => e.BoxModelResultType)
                    .IsRequired()
                    .HasAnnotation("Type", typeof(BoxModelResultTypeEnum));

                entity.HasIndex(e => e.Volume_m3)
                    .HasName("IX_Volume_m3");

                entity.Property(e => e.Volume_m3)
                    .IsRequired()
                    .HasAnnotation("Min", 0.0f)
                    .HasAnnotation("Max", 900000.0f);

                entity.HasIndex(e => e.Surface_m2)
                    .HasName("IX_Surface_m2");

                entity.Property(e => e.Surface_m2)
                    .IsRequired()
                    .HasAnnotation("Min", 0.0f)
                    .HasAnnotation("Max", 900000.0f);

                entity.HasIndex(e => e.Radius_m)
                    .HasName("IX_Radius_m");

                entity.Property(e => e.Radius_m)
                    .IsRequired()
                    .HasAnnotation("Min", 0.0f)
                    .HasAnnotation("Max", 100000.0f);

                entity.HasIndex(e => e.LeftSideDiameterLineAngle_deg)
                    .HasName("IX_LeftSideDiameterLineAngle_deg");

                entity.Property(e => e.LeftSideDiameterLineAngle_deg)
                    .IsRequired()
                    .HasAnnotation("Min", 0.0f)
                    .HasAnnotation("Max", 360.0f);

                entity.HasIndex(e => e.CircleCenterLatitude)
                    .HasName("IX_CircleCenterLatitude");

                entity.Property(e => e.CircleCenterLatitude)
                    .IsRequired()
                    .HasAnnotation("Min", -90.0f)
                    .HasAnnotation("Max", 90.0f);

                entity.HasIndex(e => e.CircleCenterLongitude)
                    .HasName("IX_CircleCenterLongitude");

                entity.Property(e => e.CircleCenterLongitude)
                    .IsRequired()
                    .HasAnnotation("Min", -180.0f)
                    .HasAnnotation("Max", 180.0f);

                entity.HasIndex(e => e.FixLength)
                    .HasName("IX_FixLength");

                entity.Property(e => e.FixLength)
                    .IsRequired();

                entity.HasIndex(e => e.FixWidth)
                    .HasName("IX_FixWidth");

                entity.Property(e => e.FixWidth)
                    .IsRequired();

                entity.HasIndex(e => e.RectLength_m)
                    .HasName("IX_RectLength_m");

                entity.Property(e => e.RectLength_m)
                    .IsRequired()
                    .HasAnnotation("Min", 0.0f)
                    .HasAnnotation("Max", 100000.0f);

                entity.HasIndex(e => e.RectWidth_m)
                    .HasName("IX_RectWidth_m");

                entity.Property(e => e.RectWidth_m)
                    .IsRequired()
                    .HasAnnotation("Min", 0.0f)
                    .HasAnnotation("Max", 100000.0f);

                entity.HasIndex(e => e.LeftSideLineAngle_deg)
                    .HasName("IX_LeftSideLineAngle_deg");

                entity.Property(e => e.LeftSideLineAngle_deg)
                    .IsRequired()
                    .HasAnnotation("Min", 0.0f)
                    .HasAnnotation("Max", 360.0f);

                entity.HasIndex(e => e.LeftSideLineStartLatitude)
                    .HasName("IX_LeftSideLineStartLatitude");

                entity.Property(e => e.LeftSideLineStartLatitude)
                    .IsRequired()
                    .HasAnnotation("Min", -90.0f)
                    .HasAnnotation("Max", 90.0f);

                entity.HasIndex(e => e.LeftSideLineStartLongitude)
                    .HasName("IX_LeftSideLineStartLongitude");

                entity.Property(e => e.LeftSideLineStartLongitude)
                    .IsRequired()
                    .HasAnnotation("Min", -180.0f)
                    .HasAnnotation("Max", 180.0f);

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
                entity.HasKey(e => e.BoxModelID)
                    .HasName("PK_BoxModels");

                entity.ToTable("BoxModels");

                entity.HasIndex(e => e.InfrastructureTVItemID)
                    .HasName("IX_InfrastructureTVItemID");

                entity.Property(e => e.InfrastructureTVItemID)
                    .IsRequired()
                    .HasAnnotation("Min", 1)
                    .HasAnnotation("ObjectExist", "TVItem");

                entity.HasIndex(e => e.Flow_m3_day)
                    .HasName("IX_Flow_m3_day");

                entity.Property(e => e.Flow_m3_day)
                    .IsRequired()
                    .HasAnnotation("Min", 0.0f)
                    .HasAnnotation("Max", 1000000.0f);

                entity.HasIndex(e => e.Depth_m)
                    .HasName("IX_Depth_m");

                entity.Property(e => e.Depth_m)
                    .IsRequired()
                    .HasAnnotation("Min", 0.0f)
                    .HasAnnotation("Max", 1000.0f);

                entity.HasIndex(e => e.Temperature_C)
                    .HasName("IX_Temperature_C");

                entity.Property(e => e.Temperature_C)
                    .IsRequired()
                    .HasAnnotation("Min", 0.0f)
                    .HasAnnotation("Max", 50.0f);

                entity.HasIndex(e => e.Dilution)
                    .HasName("IX_Dilution");

                entity.Property(e => e.Dilution)
                    .IsRequired()
                    .HasAnnotation("Min", 0.0f)
                    .HasAnnotation("Max", 1000000.0f);

                entity.HasIndex(e => e.DecayRate_per_day)
                    .HasName("IX_DecayRate_per_day");

                entity.Property(e => e.DecayRate_per_day)
                    .IsRequired()
                    .HasAnnotation("Min", 0.0f)
                    .HasAnnotation("Max", 1000.0f);

                entity.HasIndex(e => e.FCUntreated_MPN_100ml)
                    .HasName("IX_FCUntreated_MPN_100ml");

                entity.Property(e => e.FCUntreated_MPN_100ml)
                    .IsRequired()
                    .HasAnnotation("Min", 0)
                    .HasAnnotation("Max", 20000000);

                entity.HasIndex(e => e.FCPreDisinfection_MPN_100ml)
                    .HasName("IX_FCPreDisinfection_MPN_100ml");

                entity.Property(e => e.FCPreDisinfection_MPN_100ml)
                    .IsRequired()
                    .HasAnnotation("Min", 0)
                    .HasAnnotation("Max", 20000000);

                entity.HasIndex(e => e.Concentration_MPN_100ml)
                    .HasName("IX_Concentration_MPN_100ml");

                entity.Property(e => e.Concentration_MPN_100ml)
                    .IsRequired()
                    .HasAnnotation("Min", 0)
                    .HasAnnotation("Max", 20000000);

                entity.HasIndex(e => e.T90_hour)
                    .HasName("IX_T90_hour");

                entity.Property(e => e.T90_hour)
                    .IsRequired()
                    .HasAnnotation("Min", 0.0f)
                    .HasAnnotation("Max", 10000.0f);

                entity.HasIndex(e => e.FlowDuration_hour)
                    .HasName("IX_FlowDuration_hour");

                entity.Property(e => e.FlowDuration_hour)
                    .IsRequired()
                    .HasAnnotation("Min", 0.0f)
                    .HasAnnotation("Max", 10000.0f);

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
                    .WithMany(p => p.BoxModels)
                    .HasForeignKey(d => d.InfrastructureTVItemID)
                    .HasConstraintName("FK_BoxModels_InfrastructureTVItemID");
            });
        }
        private void OnModelCreating_ClimateDataValue(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ClimateDataValue>(entity =>
            {
                entity.HasKey(e => e.ClimateDataValueID)
                    .HasName("PK_ClimateDataValues");

                entity.ToTable("ClimateDataValues");

                entity.HasIndex(e => e.ClimateSiteID)
                    .HasName("IX_ClimateSiteID");

                entity.Property(e => e.ClimateSiteID)
                    .IsRequired()
                    .HasAnnotation("Min", 1)
                    .HasAnnotation("ObjectExist", "ClimateSite");

                entity.HasIndex(e => e.DateTime_Local)
                    .HasName("IX_DateTime_UTC");

                entity.Property(e => e.DateTime_Local)
                    .IsRequired()
                    .HasColumnType("datetime")
                    .HasAnnotation("DateAfterYear", 1980);

                entity.HasIndex(e => e.Keep)
                    .HasName("IX_Keep");

                entity.Property(e => e.Keep)
                    .IsRequired();

                entity.HasIndex(e => e.StorageDataType)
                    .HasName("IX_StorageDataType");

                entity.Property(e => e.StorageDataType)
                    .IsRequired()
                    .HasAnnotation("Type", typeof(StorageDataTypeEnum));

                entity.HasIndex(e => e.Snow_cm)
                    .HasName("IX_Snow_cm");

                entity.Property(e => e.Snow_cm)
                    .HasAnnotation("Min", 0.0f)
                    .HasAnnotation("Max", 1000.0f);

                entity.HasIndex(e => e.Rainfall_mm)
                    .HasName("IX_Rainfall_mm");

                entity.Property(e => e.Rainfall_mm)
                    .HasAnnotation("Min", 0.0f)
                    .HasAnnotation("Max", 1000.0f);

                entity.HasIndex(e => e.RainfallEntered_mm)
                    .HasName("IX_RainfallEntered_mm");

                entity.Property(e => e.RainfallEntered_mm)
                    .HasAnnotation("Min", 0.0f)
                    .HasAnnotation("Max", 1000.0f);

                entity.HasIndex(e => e.TotalPrecip_mm_cm)
                    .HasName("IX_TotalPrecip_mm_cm");

                entity.Property(e => e.TotalPrecip_mm_cm)
                    .HasAnnotation("Min", 0.0f)
                    .HasAnnotation("Max", 1000.0f);

                entity.HasIndex(e => e.MaxTemp_C)
                    .HasName("IX_MaxTemp_C");

                entity.Property(e => e.MaxTemp_C)
                    .HasAnnotation("Min", -50.0f)
                    .HasAnnotation("Max", 50.0f);

                entity.HasIndex(e => e.MinTemp_C)
                    .HasName("IX_MinTemp_C");

                entity.Property(e => e.MinTemp_C)
                    .HasAnnotation("Min", -50.0f)
                    .HasAnnotation("Max", 50.0f);

                entity.HasIndex(e => e.HeatDegDays_C)
                    .HasName("IX_HeatDegDays_C");

                entity.Property(e => e.HeatDegDays_C)
                    .HasAnnotation("Min", 0.0f)
                    .HasAnnotation("Max", 10000.0f);

                entity.HasIndex(e => e.CoolDegDays_C)
                    .HasName("IX_CoolDegDays_C");

                entity.Property(e => e.CoolDegDays_C)
                    .HasAnnotation("Min", 0.0f)
                    .HasAnnotation("Max", 10000.0f);

                entity.HasIndex(e => e.SnowOnGround_cm)
                    .HasName("IX_SnowOnGround_cm");

                entity.Property(e => e.SnowOnGround_cm)
                    .HasAnnotation("Min", 0.0f)
                    .HasAnnotation("Max", 10000.0f);

                entity.HasIndex(e => e.DirMaxGust_0North)
                    .HasName("IX_DirMaxGust_0North");

                entity.Property(e => e.DirMaxGust_0North)
                    .HasAnnotation("Min", 0.0f)
                    .HasAnnotation("Max", 360.0f);

                entity.HasIndex(e => e.SpdMaxGust_kmh)
                    .HasName("IX_SpdMaxGust_kmh");

                entity.Property(e => e.SpdMaxGust_kmh)
                    .HasAnnotation("Min", 0.0f)
                    .HasAnnotation("Max", 300.0f);

                entity.Property(e => e.HourlyValues)
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
                entity.HasKey(e => e.ClimateSiteID)
                    .HasName("PK_ClimateSites");

                entity.ToTable("ClimateSites");

                entity.HasIndex(e => e.ClimateSiteTVItemID)
                    .HasName("IX_TVItemID");

                entity.Property(e => e.ClimateSiteTVItemID)
                    .IsRequired()
                    .HasAnnotation("Min", 1)
                    .HasAnnotation("ObjectExist", "TVItem");

                entity.HasIndex(e => e.ECDBID)
                    .HasName("IX_ECDBID");

                entity.Property(e => e.ECDBID)
                    .IsRequired()
                    .HasAnnotation("Min", 1);

                entity.HasIndex(e => e.ClimateSiteName)
                    .HasName("IX_ClimateSiteName");

                entity.Property(e => e.ClimateSiteName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasIndex(e => e.Province)
                    .HasName("IX_Province");

                entity.Property(e => e.Province)
                    .IsRequired()
                    .HasMaxLength(4);

                entity.HasIndex(e => e.Elevation_m)
                    .HasName("IX_Elevation_m");

                entity.Property(e => e.Elevation_m)
                    .HasAnnotation("Min", 0.0f)
                    .HasAnnotation("Max", 10000.0f);

                entity.HasIndex(e => e.ClimateID)
                    .HasName("IX_ClimateID");

                entity.Property(e => e.ClimateID)
                    .HasMaxLength(10);

                entity.HasIndex(e => e.WMOID)
                    .HasName("IX_WMOID");

                entity.Property(e => e.WMOID)
                    .HasAnnotation("Min", 1)
                    .HasAnnotation("Max", 1000000);

                entity.HasIndex(e => e.TCID)
                    .HasName("IX_TCID");

                entity.Property(e => e.TCID)
                    .HasMaxLength(3);

                entity.HasIndex(e => e.IsProvincial)
                    .HasName("IX_IsProvincial");

                entity.Property(e => e.IsProvincial);

                entity.Property(e => e.ProvSiteID)
                    .HasMaxLength(50);

                entity.HasIndex(e => e.TimeOffset_hour)
                    .HasName("IX_TimeOffset_hour");

                entity.Property(e => e.TimeOffset_hour)
                    .HasAnnotation("Min", -12.0f)
                    .HasAnnotation("Max", 12.0f);

                entity.HasIndex(e => e.File_desc)
                    .HasName("IX_File_desc");

                entity.Property(e => e.File_desc)
                    .HasMaxLength(50);

                entity.HasIndex(e => e.HourlyStartDate_Local)
                    .HasName("IX_HourlyStartDate_UTC");

                entity.Property(e => e.HourlyStartDate_Local)
                    .HasColumnType("datetime");


                entity.HasIndex(e => e.HourlyEndDate_Local)
                    .HasName("IX_HourlyEndDate_UTC");

                entity.Property(e => e.HourlyEndDate_Local)
                    .HasColumnType("datetime");

                entity.HasIndex(e => e.HourlyNow)
                    .HasName("IX_HourlyNow");

                entity.Property(e => e.HourlyNow);

                entity.HasIndex(e => e.DailyStartDate_Local)
                    .HasName("IX_DailyStartDate_UTC");

                entity.Property(e => e.DailyStartDate_Local)
                    .HasColumnType("datetime");

                entity.HasIndex(e => e.DailyEndDate_Local)
                    .HasName("IX_DailyEndDate_UTC");

                entity.Property(e => e.DailyEndDate_Local)
                    .HasColumnType("datetime");

                entity.HasIndex(e => e.DailyNow)
                    .HasName("IX_DailyNow");

                entity.Property(e => e.DailyNow);

                entity.HasIndex(e => e.MonthlyStartDate_Local)
                    .HasName("IX_MonthlyStartDate_UTC");

                entity.Property(e => e.MonthlyStartDate_Local)
                    .HasColumnType("datetime");

                entity.HasIndex(e => e.MonthlyEndDate_Local)
                    .HasName("IX_MonthlyEndDate_UTC");

                entity.Property(e => e.MonthlyEndDate_Local)
                    .HasColumnType("datetime");

                entity.HasIndex(e => e.MonthlyNow)
                    .HasName("IX_MonthlyNow");

                entity.Property(e => e.MonthlyNow);

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
                entity.HasKey(e => e.ContactID)
                    .HasName("PK_Contacts");

                entity.ToTable("Contacts");

                entity.HasIndex(e => e.ContactTVItemID)
                    .HasName("IX_ContactTVItemID");

                entity.Property(e => e.ContactTVItemID)
                    .IsRequired()
                    .HasAnnotation("Min", 1)
                    .HasAnnotation("ObjectExist", "TVItem");

                entity.HasIndex(e => e.LoginEmail)
                    .HasName("IX_LoginEmail");

                entity.Property(e => e.LoginEmail)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.HasIndex(e => e.FirstName)
                    .HasName("IX_FirstName");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasIndex(e => e.LastName)
                    .HasName("IX_LastName");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasIndex(e => e.Initial)
                    .HasName("IX_Initial");

                entity.Property(e => e.Initial)
                    .HasMaxLength(50);

                entity.HasIndex(e => e.WebName)
                    .HasName("IX_WebName");

                entity.Property(e => e.WebName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ContactTitle)
                    .HasAnnotation("Type", typeof(ContactTitleEnum));

                entity.HasIndex(e => e.IsAdmin)
                    .HasName("IX_IsAdmin");

                entity.Property(e => e.IsAdmin);

                entity.HasIndex(e => e.EmailValidated)
                    .HasName("IX_EmailValidated");

                entity.Property(e => e.EmailValidated);

                entity.HasIndex(e => e.Disabled)
                    .HasName("IX_Disabled");

                entity.Property(e => e.Disabled);

                entity.HasIndex(e => e.IsNew)
                    .HasName("IX_IsNew");

                entity.Property(e => e.IsNew);

                entity.Property(e => e.SamplingPlanner_ProvincesTVItemID)
                    .HasMaxLength(200);

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
                entity.HasKey(e => e.ContactLoginID)
                    .HasName("PK_ContactLogins");

                entity.ToTable("ContactLogins");

                entity.HasIndex(e => e.ContactID)
                    .HasName("IX_ContactID");

                entity.Property(e => e.ContactID)
                    .IsRequired()
                    .HasAnnotation("Min", 1)
                    .HasAnnotation("ObjectExist", "TVItem");

                entity.HasIndex(e => e.LoginEmail)
                    .HasName("IX_LoginEmail");

                entity.Property(e => e.LoginEmail)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.PasswordHash)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.PasswordSalt)
                    .IsRequired()
                    .HasMaxLength(200);

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
                entity.HasKey(e => e.ContactPreferenceID)
                    .HasName("PK_ContactPreferences");

                entity.ToTable("ContactPreferences");

                entity.HasIndex(e => e.ContactID)
                    .HasName("IX_ContactID");

                entity.Property(e => e.ContactID)
                    .IsRequired()
                    .HasAnnotation("Min", 1)
                    .HasAnnotation("ObjectExist", "Contact");

                entity.HasIndex(e => e.TVType)
                    .HasName("IX_TVType");

                entity.Property(e => e.TVType)
                    .IsRequired()
                    .HasAnnotation("Type", typeof(TVTypeEnum));

                entity.HasIndex(e => e.MarkerSize)
                    .HasName("IX_MarkerSize");

                entity.Property(e => e.MarkerSize)
                    .IsRequired()
                    .HasAnnotation("Min", 1)
                    .HasAnnotation("Max", 1000);

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
                    .HasAnnotation("Min", 1);

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
                entity.HasKey(e => e.ContactShortcutID)
                    .HasName("PK_ContactShortcuts");

                entity.ToTable("ContactShortcuts");

                entity.HasIndex(e => e.ContactID)
                    .HasName("IX_ContactID");

                entity.Property(e => e.ContactID)
                    .IsRequired()
                    .HasAnnotation("Min", 1)
                    .HasAnnotation("ObjectExist", "Contact");

                entity.HasIndex(e => e.ShortCutText)
                    .HasName("IX_ShortCutText");

                entity.Property(e => e.ShortCutText)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasIndex(e => e.ShortCutAddress)
                    .HasName("IX_ShortCutAddress");

                entity.Property(e => e.ShortCutAddress)
                    .IsRequired()
                    .HasMaxLength(200);

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
                entity.HasKey(e => e.DocTemplateID)
                    .HasName("PK_DocTemplates");

                entity.ToTable("DocTemplates");

                entity.HasIndex(e => e.Language)
                    .HasName("IX_Language");

                entity.Property(e => e.Language)
                    .IsRequired()
                    .HasAnnotation("Type", typeof(LanguageEnum));

                entity.HasIndex(e => e.TVType)
                    .HasName("IX_TVType");

                entity.Property(e => e.TVType)
                    .IsRequired()
                    .HasAnnotation("Type", typeof(TVTypeEnum));

                entity.HasIndex(e => e.TVFileTVItemID)
                    .HasName("IX_TVFileTVItemID");

                entity.Property(e => e.TVFileTVItemID)
                    .IsRequired()
                    .HasAnnotation("Min", 1)
                    .HasAnnotation("ObjectExist", "TVItem");

                entity.HasIndex(e => e.FileName)
                    .HasName("IX_FileName");

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasMaxLength(150);

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
                entity.HasKey(e => e.EmailID)
                    .HasName("PK_Emails");

                entity.ToTable("Emails");

                entity.HasIndex(e => e.EmailTVItemID)
                    .HasName("IX_EmailTVItemID");

                entity.Property(e => e.EmailTVItemID)
                    .IsRequired()
                    .HasAnnotation("Min", 1)
                    .HasAnnotation("ObjectExist", "TVItem");

                entity.HasIndex(e => e.EmailAddress)
                    .HasName("IX_EmailAddress");

                entity.Property(e => e.EmailAddress)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.HasIndex(e => e.EmailType)
                    .HasName("IX_EmailType");

                entity.Property(e => e.EmailType)
                    .IsRequired()
                    .HasAnnotation("Type", typeof(EmailTypeEnum));

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
                entity.HasKey(e => e.HydrometricDataValueID)
                    .HasName("PK_HydrometricDataValues");

                entity.ToTable("HydrometricDataValues");

                entity.HasIndex(e => e.HydrometricSiteID)
                    .HasName("IX_HydrometricSiteID");

                entity.Property(e => e.HydrometricSiteID)
                    .IsRequired()
                    .HasAnnotation("Min", 1)
                    .HasAnnotation("OjbectExist", "HydrometricSite");

                entity.HasIndex(e => e.DateTime_Local)
                    .HasName("IX_DateTime_UTC");

                entity.Property(e => e.DateTime_Local)
                    .IsRequired()
                    .HasColumnType("datetime")
                    .HasAnnotation("DateAfterYear", 1980);

                entity.HasIndex(e => e.Keep)
                    .HasName("IX_Keep");

                entity.Property(e => e.Keep)
                    .IsRequired();

                entity.HasIndex(e => e.StorageDataType)
                    .HasName("IX_StorageDataType");

                entity.Property(e => e.StorageDataType)
                    .IsRequired()
                    .HasAnnotation("Type", typeof(StorageDataTypeEnum));

                entity.HasIndex(e => e.Flow_m3_s)
                    .HasName("IX_Flow_m3_s");

                entity.Property(e => e.Flow_m3_s)
                    .IsRequired()
                    .HasAnnotation("Min", 0.0f)
                    .HasAnnotation("Max", 1000000.0f);

                entity.Property(e => e.HourlyValues)
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
                entity.HasKey(e => e.HydrometricSiteID)
                    .HasName("PK_HydrometricSites");

                entity.ToTable("HydrometricSites");

                entity.HasIndex(e => e.HydrometricSiteTVItemID)
                    .HasName("IX_TVItemID");

                entity.Property(e => e.HydrometricSiteTVItemID)
                    .IsRequired()
                    .HasAnnotation("Min", 1)
                    .HasAnnotation("ObjectExist", "TVItem");

                entity.HasIndex(e => e.FedSiteNumber)
                    .HasName("IX_FedSiteNumber");

                entity.Property(e => e.FedSiteNumber)
                    .HasMaxLength(7);

                entity.HasIndex(e => e.QuebecSiteNumber)
                    .HasName("IX_QuebecSiteNumber");

                entity.Property(e => e.QuebecSiteNumber)
                    .HasMaxLength(7);

                entity.HasIndex(e => e.HydrometricSiteName)
                    .HasName("IX_HydrometricSiteName");

                entity.Property(e => e.HydrometricSiteName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Description)
                    .HasMaxLength(200);

                entity.HasIndex(e => e.Province)
                    .HasName("IX_Province");

                entity.Property(e => e.Province)
                    .IsRequired()
                    .HasMaxLength(4);

                entity.HasIndex(e => e.Elevation_m)
                    .HasName("IX_Elevation_m");

                entity.Property(e => e.Elevation_m)
                    .HasAnnotation("Min", 0.0f)
                    .HasAnnotation("Max", 10000.0f);

                entity.HasIndex(e => e.StartDate_Local)
                    .HasName("IX_StartDate_UTC");

                entity.Property(e => e.StartDate_Local)
                    .HasColumnType("datetime")
                    .HasAnnotation("DateAfterYear", 1980);

                entity.HasIndex(e => e.EndDate_Local)
                    .HasName("IX_EndDate_UTC");

                entity.Property(e => e.EndDate_Local)
                    .HasColumnType("datetime")
                    .HasAnnotation("DateBiggerThanOtherField", "StartDate_Local");

                entity.HasIndex(e => e.TimeOffset_hour)
                    .HasName("IX_TimeOffset_hour");

                entity.Property(e => e.TimeOffset_hour)
                    .HasAnnotation("Min", -12.0f)
                    .HasAnnotation("Max", 12.0f);

                entity.HasIndex(e => e.DrainageArea_km2)
                    .HasName("IX_DrainageArea_km2");

                entity.Property(e => e.DrainageArea_km2)
                    .HasAnnotation("Min", 0.0f)
                    .HasAnnotation("Max", 1000000.0f);

                entity.HasIndex(e => e.IsNatural)
                    .HasName("IX_IsNatural");

                entity.Property(e => e.IsNatural);

                entity.HasIndex(e => e.IsActive)
                    .HasName("IX_IsActive");

                entity.Property(e => e.IsActive);

                entity.HasIndex(e => e.Sediment)
                    .HasName("IX_Sediment");

                entity.Property(e => e.Sediment);

                entity.HasIndex(e => e.RHBN)
                    .HasName("IX_RHBN");

                entity.Property(e => e.RHBN);

                entity.HasIndex(e => e.RealTime)
                    .HasName("IX_RealTime");

                entity.Property(e => e.RealTime);

                entity.HasIndex(e => e.HasRatingCurve)
                    .HasName("IX_HasRatingCurve");

                entity.Property(e => e.HasRatingCurve);

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
                entity.HasKey(e => e.InfrastructureLanguageID)
                    .HasName("PK_InfrastructureLanguages");

                entity.ToTable("InfrastructureLanguages");

                entity.HasIndex(e => e.InfrastructureID)
                    .HasName("IX_InfrastructureID");

                entity.Property(e => e.InfrastructureID)
                    .IsRequired()
                    .HasAnnotation("Min", 1)
                    .HasAnnotation("ObjectExist", "Infrastructure");

                entity.HasIndex(e => e.Language)
                    .HasName("IX_Language");

                entity.Property(e => e.Language)
                    .IsRequired()
                    .HasAnnotation("Type", typeof(LanguageEnum));

                entity.Property(e => e.Comment)
                    .IsRequired()
                    .HasColumnType("text");

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
                    .HasName("IX_LastUpdateContactID");

                entity.Property(e => e.LastUpdateContactTVItemID)
                    .IsRequired()
                    .HasAnnotation("Min", 1)
                    .HasAnnotation("ObjectExist", "TVItem");

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
                entity.HasKey(e => e.InfrastructureID)
                    .HasName("PK_Infrastructures");

                entity.ToTable("Infrastructures");

                entity.HasIndex(e => e.InfrastructureTVItemID)
                    .HasName("IX_InfrastructureTVItemID");

                entity.Property(e => e.InfrastructureTVItemID)
                    .IsRequired()
                    .HasAnnotation("Min", 1)
                    .HasAnnotation("ObjectExist", "TVItem");

                entity.HasIndex(e => e.PrismID)
                    .HasName("IX_PrismID");

                entity.Property(e => e.PrismID)
                    .HasAnnotation("Min", 1);

                entity.HasIndex(e => e.TPID)
                    .HasName("IX_TPID");

                entity.Property(e => e.TPID)
                    .HasAnnotation("Min", 1);

                entity.HasIndex(e => e.LSID)
                    .HasName("IX_LSID");

                entity.Property(e => e.LSID)
                    .HasAnnotation("Min", 1);

                entity.HasIndex(e => e.SiteID)
                    .HasName("IX_SiteID");

                entity.Property(e => e.SiteID)
                    .HasAnnotation("Min", 1);

                entity.HasIndex(e => e.Site)
                    .HasName("IX_Site");

                entity.Property(e => e.Site)
                    .HasAnnotation("Min", 1);

                entity.HasIndex(e => e.InfrastructureCategory)
                    .HasName("IX_InfrastructureCategory");

                entity.Property(e => e.InfrastructureCategory)
                    .HasColumnType("nvarchar(1)")
                    .HasAnnotation("Min", 1)
                    .HasAnnotation("Max", 1);

                entity.HasIndex(e => e.InfrastructureType)
                    .HasName("IX_InfrastructureType");

                entity.Property(e => e.InfrastructureType)
                    .HasAnnotation("Type", typeof(InfrastructureTypeEnum));

                entity.HasIndex(e => e.FacilityType)
                    .HasName("IX_FacilityType");

                entity.Property(e => e.FacilityType)
                    .HasAnnotation("Type", typeof(FacilityTypeEnum));

                entity.HasIndex(e => e.IsMechanicallyAerated)
                    .HasName("IX_IsMechanicallyAerated");

                entity.Property(e => e.IsMechanicallyAerated);

                entity.HasIndex(e => e.NumberOfCells)
                    .HasName("IX_NumberOfCells");

                entity.Property(e => e.NumberOfCells)
                    .HasAnnotation("Min", 0)
                    .HasAnnotation("Max", 10);

                entity.HasIndex(e => e.NumberOfAeratedCells)
                    .HasName("IX_NumberOfAeratedCells");

                entity.Property(e => e.NumberOfAeratedCells)
                    .HasAnnotation("Min", 0)
                    .HasAnnotation("Max", 10);

                entity.HasIndex(e => e.AerationType)
                    .HasName("IX_AerationType");

                entity.Property(e => e.AerationType)
                    .HasAnnotation("Type", typeof(AerationTypeEnum));

                entity.HasIndex(e => e.PreliminaryTreatmentType)
                    .HasName("IX_PreliminaryTreatmentType");

                entity.Property(e => e.PreliminaryTreatmentType)
                    .HasAnnotation("Type", typeof(PreliminaryTreatmentTypeEnum));

                entity.HasIndex(e => e.PrimaryTreatmentType)
                    .HasName("IX_PrimaryTreatmentType");

                entity.Property(e => e.PrimaryTreatmentType)
                    .HasAnnotation("Type", typeof(PrimaryTreatmentTypeEnum));

                entity.HasIndex(e => e.SecondaryTreatmentType)
                    .HasName("IX_SecondaryTreatmentType");

                entity.Property(e => e.SecondaryTreatmentType)
                    .HasAnnotation("Type", typeof(SecondaryTreatmentTypeEnum));

                entity.HasIndex(e => e.TertiaryTreatmentType)
                    .HasName("IX_TertiaryTreatmentType");

                entity.Property(e => e.TertiaryTreatmentType)
                    .HasAnnotation("Type", typeof(TertiaryTreatmentTypeEnum));

                entity.HasIndex(e => e.TreatmentType)
                    .HasName("IX_TreatmentType");

                entity.Property(e => e.TreatmentType)
                    .HasAnnotation("Type", typeof(TreatmentTypeEnum));

                entity.HasIndex(e => e.DisinfectionType)
                    .HasName("IX_DisinfectionType");

                entity.Property(e => e.DisinfectionType)
                    .HasAnnotation("Type", typeof(DisinfectionTypeEnum));

                entity.HasIndex(e => e.CollectionSystemType)
                    .HasName("IX_CollectionSystemType");

                entity.Property(e => e.CollectionSystemType)
                    .HasAnnotation("Type", typeof(CollectionSystemTypeEnum));

                entity.HasIndex(e => e.AlarmSystemType)
                    .HasName("IX_AlarmSystemType");

                entity.Property(e => e.AlarmSystemType)
                    .HasAnnotation("Type", typeof(AlarmSystemTypeEnum));

                entity.HasIndex(e => e.DesignFlow_m3_day)
                    .HasName("IX_DesignFlow_m3_day");

                entity.Property(e => e.DesignFlow_m3_day)
                    .HasAnnotation("Min", 0.0f)
                    .HasAnnotation("Max", 1000000.0f);

                entity.HasIndex(e => e.AverageFlow_m3_day)
                    .HasName("IX_AverageFlow_m3_day");

                entity.Property(e => e.AverageFlow_m3_day)
                    .HasAnnotation("Min", 0.0f)
                    .HasAnnotation("Max", 1000000.0f);

                entity.HasIndex(e => e.PeakFlow_m3_day)
                    .HasName("IX_PeakFlow_m3_day");

                entity.Property(e => e.PeakFlow_m3_day)
                    .HasAnnotation("Min", 0.0f)
                    .HasAnnotation("Max", 1000000.0f);

                entity.HasIndex(e => e.PopServed)
                    .HasName("IX_PopServed");

                entity.Property(e => e.PopServed)
                    .HasAnnotation("Min", 0)
                    .HasAnnotation("Max", 1000000);

                entity.HasIndex(e => e.CanOverflow)
                    .HasName("IX_CanOverflow");

                entity.Property(e => e.CanOverflow);

                entity.HasIndex(e => e.PercFlowOfTotal)
                    .HasName("IX_PercFlowOfTotal");

                entity.Property(e => e.PercFlowOfTotal)
                    .HasAnnotation("Min", 0.0f)
                    .HasAnnotation("Max", 1000000.0f);

                entity.HasIndex(e => e.TimeOffset_hour)
                    .HasName("IX_TimeOffset_hour");

                entity.Property(e => e.TimeOffset_hour)
                    .HasAnnotation("Min", -12.0f)
                    .HasAnnotation("Max", 12.0f);

                entity.Property(e => e.TempCatchAllRemoveLater)
                    .HasColumnType("text");

                entity.HasIndex(e => e.AverageDepth_m)
                    .HasName("IX_AverageDepth_m");

                entity.Property(e => e.AverageDepth_m)
                    .HasAnnotation("Min", 0.0f)
                    .HasAnnotation("Max", 1000.0f);

                entity.HasIndex(e => e.NumberOfPorts)
                    .HasName("IX_NumberOfPorts");

                entity.Property(e => e.NumberOfPorts)
                    .HasAnnotation("Min", 1)
                    .HasAnnotation("Max", 100);

                entity.HasIndex(e => e.PortDiameter_m)
                    .HasName("IX_PortDiameter_m");

                entity.Property(e => e.PortDiameter_m)
                    .HasAnnotation("Min", 0.0f)
                    .HasAnnotation("Max", 100.0f);

                entity.HasIndex(e => e.PortSpacing_m)
                    .HasName("IX_PortSpacing_m");

                entity.Property(e => e.PortSpacing_m)
                    .HasAnnotation("Min", 0.0f)
                    .HasAnnotation("Max", 1000.0f);

                entity.HasIndex(e => e.PortElevation_m)
                    .HasName("IX_PortElevation_m");

                entity.Property(e => e.PortElevation_m)
                    .HasAnnotation("Min", 0.0f)
                    .HasAnnotation("Max", 1000.0f);

                entity.HasIndex(e => e.VerticalAngle_deg)
                    .HasName("IX_VerticalAngle_deg");

                entity.Property(e => e.VerticalAngle_deg)
                    .HasAnnotation("Min", -90.0f)
                    .HasAnnotation("Max", 90.0f);

                entity.HasIndex(e => e.HorizontalAngle_deg)
                    .HasName("IX_HorizontalAngle_deg");

                entity.Property(e => e.HorizontalAngle_deg)
                    .HasAnnotation("Min", -180.0f)
                    .HasAnnotation("Max", 180.0f);

                entity.HasIndex(e => e.DecayRate_per_day)
                    .HasName("IX_DecayRate_per_day");

                entity.Property(e => e.DecayRate_per_day)
                    .HasAnnotation("Min", 0.0f)
                    .HasAnnotation("Max", 1000.0f);

                entity.HasIndex(e => e.NearFieldVelocity_m_s)
                    .HasName("IX_NearFieldVelocity_m_s");

                entity.Property(e => e.NearFieldVelocity_m_s)
                    .HasAnnotation("Min", 0.0f)
                    .HasAnnotation("Max", 10.0f);

                entity.HasIndex(e => e.FarFieldVelocity_m_s)
                    .HasName("IX_FarFieldVelocity_m_s");

                entity.Property(e => e.FarFieldVelocity_m_s)
                    .HasAnnotation("Min", 0.0f)
                    .HasAnnotation("Max", 10.0f);

                entity.HasIndex(e => e.ReceivingWaterSalinity_PSU)
                    .HasName("IX_ReceivingWaterSalinity_PSU");

                entity.Property(e => e.ReceivingWaterSalinity_PSU)
                    .HasAnnotation("Min", 0.0f)
                    .HasAnnotation("Max", 40.0f);

                entity.HasIndex(e => e.ReceivingWaterTemperature_C)
                    .HasName("IX_ReceivingWaterTemperature_C");

                entity.Property(e => e.ReceivingWaterTemperature_C)
                    .HasAnnotation("Min", 0.0f)
                    .HasAnnotation("Max", 40.0f);

                entity.HasIndex(e => e.ReceivingWater_MPN_per_100ml)
                    .HasName("IX_ReceivingWater_MPN_per_100ml");

                entity.Property(e => e.ReceivingWater_MPN_per_100ml)
                    .HasAnnotation("Min", 0)
                    .HasAnnotation("Max", 20000000);

                entity.HasIndex(e => e.DistanceFromShore_m)
                    .HasName("IX_DistanceFromShore_m");

                entity.Property(e => e.DistanceFromShore_m)
                    .HasAnnotation("Min", 0.0f)
                    .HasAnnotation("Max", 10000.0f);

                entity.HasIndex(e => e.SeeOtherTVItemID)
                    .HasName("IX_SeeOtherTVItemID");

                entity.Property(e => e.SeeOtherTVItemID)
                    .HasAnnotation("Min", 1);

                entity.HasIndex(e => e.CivicAddressTVItemID)
                    .HasName("IX_CivicAddressTVItemID");

                entity.Property(e => e.CivicAddressTVItemID)
                    .HasAnnotation("Min", 1);

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
                entity.HasKey(e => e.LabSheetDetailID)
                    .HasName("PK_LabSheetDetails");

                entity.ToTable("LabSheetDetails");

                entity.HasIndex(e => e.LabSheetID)
                    .HasName("IX_LabSheetID");

                entity.Property(e => e.LabSheetID)
                    .IsRequired()
                    .HasAnnotation("Min", 1)
                    .HasAnnotation("ObjectExist", "LabSheet");

                entity.HasIndex(e => e.SamplingPlanID)
                    .HasName("IX_MWQMPlanID")
                    .HasAnnotation("Min", 1)
                    .HasAnnotation("ObjectExist", "SamplingPlan");

                entity.Property(e => e.SamplingPlanID)
                    .IsRequired()
                    .HasAnnotation("Min", 1);

                entity.HasIndex(e => e.SubsectorTVItemID)
                    .HasName("IX_SubsectorTVItemID")
                    .HasAnnotation("Min", 1)
                    .HasAnnotation("ObjectExist", "TVItem");

                entity.Property(e => e.SubsectorTVItemID)
                    .IsRequired()
                    .HasAnnotation("Min", 1);

                entity.HasIndex(e => e.Version)
                    .HasName("IX_Version")
                    .HasAnnotation("Min", 1);

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasAnnotation("Min", 1);

                entity.HasIndex(e => e.RunDate)
                    .HasName("IX_RunDate");

                entity.Property(e => e.RunDate)
                    .HasColumnType("datetime")
                    .HasAnnotation("DateAfterYear", 1980);

                entity.HasIndex(e => e.Tides)
                    .HasName("IX_Tides");

                entity.Property(e => e.Tides)
                    .IsRequired()
                    .HasMaxLength(7);

                entity.HasIndex(e => e.SampleCrewInitials)
                    .HasName("IX_SamplingContactID");

                entity.Property(e => e.SampleCrewInitials)
                    .HasMaxLength(20);

                entity.Property(e => e.WaterBathCount)
                    .HasAnnotation("Min", 1)
                    .HasAnnotation("Max", 3);

                entity.HasIndex(e => e.IncubationBath1StartTime)
                    .HasName("IX_IncubationBath1StartTime");

                entity.Property(e => e.IncubationBath1StartTime)
                    .HasColumnType("datetime")
                    .HasAnnotation("DateAfterYear", 1980);

                entity.HasIndex(e => e.IncubationBath2StartTime)
                    .HasName("IX_IncubationBath2StartTime");

                entity.Property(e => e.IncubationBath2StartTime)
                    .HasColumnType("datetime")
                    .HasAnnotation("DateAfterYear", 1980);

                entity.HasIndex(e => e.IncubationBath3StartTime)
                    .HasName("IX_IncubationBath3StartTime");

                entity.Property(e => e.IncubationBath3StartTime)
                    .HasColumnType("datetime")
                    .HasAnnotation("DateAfterYear", 1980);

                entity.HasIndex(e => e.IncubationBath1EndTime)
                    .HasName("IX_IncubationBath1EndTime");

                entity.Property(e => e.IncubationBath1EndTime)
                    .HasColumnType("datetime")
                    .HasAnnotation("DateBiggerThanOtherField", "IncubationBath1StartTime");

                entity.HasIndex(e => e.IncubationBath2EndTime)
                    .HasName("IX_IncubationBath2EndTime");

                entity.Property(e => e.IncubationBath2EndTime)
                    .HasColumnType("datetime")
                    .HasAnnotation("DateBiggerThanOtherField", "IncubationBath2StartTime");

                entity.HasIndex(e => e.IncubationBath3EndTime)
                    .HasName("IX_IncubationBath3EndTime");

                entity.Property(e => e.IncubationBath3EndTime)
                    .HasColumnType("datetime")
                    .HasAnnotation("DateBiggerThanOtherField", "IncubationBath3StartTime");

                entity.Property(e => e.IncubationBath1TimeCalculated_minutes)
                    .HasAnnotation("Min", 1)
                    .HasAnnotation("Max", 1000);

                entity.Property(e => e.IncubationBath2TimeCalculated_minutes)
                    .HasAnnotation("Min", 1)
                    .HasAnnotation("Max", 1000);

                entity.Property(e => e.IncubationBath3TimeCalculated_minutes)
                    .HasAnnotation("Min", 1)
                    .HasAnnotation("Max", 1000);

                entity.Property(e => e.WaterBath1)
                    .HasMaxLength(10);

                entity.Property(e => e.WaterBath2)
                    .HasMaxLength(10);

                entity.Property(e => e.WaterBath3)
                    .HasMaxLength(10);

                entity.HasIndex(e => e.TCField1)
                    .HasName("IX_TCField1");

                entity.Property(e => e.TCField1)
                    .HasAnnotation("Min", 0.0f)
                    .HasAnnotation("Max", 40.0f);

                entity.HasIndex(e => e.TCLab1)
                    .HasName("IX_TCLab1");

                entity.Property(e => e.TCLab1)
                    .HasAnnotation("Min", 0.0f)
                    .HasAnnotation("Max", 40.0f);

                entity.HasIndex(e => e.TCField2)
                    .HasName("IX_TCField2");

                entity.Property(e => e.TCField2)
                    .HasAnnotation("Min", 0.0f)
                    .HasAnnotation("Max", 40.0f);

                entity.HasIndex(e => e.TCLab2)
                    .HasName("IX_TCLab2");

                entity.Property(e => e.TCLab2)
                    .HasAnnotation("Min", 0.0f)
                    .HasAnnotation("Max", 40.0f);

                entity.HasIndex(e => e.TCFirst)
                    .HasName("IX_TCFirst");

                entity.Property(e => e.TCFirst)
                    .HasAnnotation("Min", 0.0f)
                    .HasAnnotation("Max", 40.0f);

                entity.HasIndex(e => e.TCAverage)
                    .HasName("IX_TCAverage");

                entity.Property(e => e.TCAverage)
                    .HasAnnotation("Min", 0.0f)
                    .HasAnnotation("Max", 40.0f);

                entity.Property(e => e.ControlLot)
                    .HasMaxLength(100);

                entity.HasIndex(e => e.Positive35)
                    .HasName("IX_Positive35");

                entity.Property(e => e.Positive35)
                    .HasColumnType("nchar(1)");

                entity.HasIndex(e => e.NonTarget35)
                    .HasName("IX_NonTarget35");

                entity.Property(e => e.NonTarget35)
                    .HasColumnType("nchar(1)");

                entity.HasIndex(e => e.Negative35)
                    .HasName("IX_Negative35");

                entity.Property(e => e.Negative35)
                    .HasColumnType("nchar(1)");

                entity.HasIndex(e => e.Bath1Positive44_5)
                    .HasName("IX_Bath1Positive44_5");

                entity.Property(e => e.Bath1Positive44_5)
                    .HasColumnType("nchar(1)")
                    .HasAnnotation("Min", 1)
                    .HasAnnotation("Max", 1);

                entity.HasIndex(e => e.Bath2Positive44_5)
                    .HasName("IX_Bath2Positive44_5");

                entity.Property(e => e.Bath2Positive44_5)
                    .HasColumnType("nchar(1)")
                    .HasAnnotation("Min", 1)
                    .HasAnnotation("Max", 1);

                entity.HasIndex(e => e.Bath3Positive44_5)
                    .HasName("IX_Bath3Positive44_5");

                entity.Property(e => e.Bath3Positive44_5)
                    .HasColumnType("nchar(1)")
                    .HasAnnotation("Min", 1)
                    .HasAnnotation("Max", 1);

                entity.HasIndex(e => e.Bath1NonTarget44_5)
                    .HasName("IX_Bath1NonTarget44_5");

                entity.Property(e => e.Bath1NonTarget44_5)
                    .HasColumnType("nchar(1)")
                    .HasAnnotation("Min", 1)
                    .HasAnnotation("Max", 1);

                entity.HasIndex(e => e.Bath2NonTarget44_5)
                    .HasName("IX_Bath2NonTarget44_5");

                entity.Property(e => e.Bath2NonTarget44_5)
                    .HasColumnType("nchar(1)")
                    .HasAnnotation("Min", 1)
                    .HasAnnotation("Max", 1);

                entity.HasIndex(e => e.Bath3NonTarget44_5)
                    .HasName("IX_Bath3NonTarget44_5");

                entity.Property(e => e.Bath3NonTarget44_5)
                    .HasColumnType("nchar(1)")
                    .HasAnnotation("Min", 1)
                    .HasAnnotation("Max", 1);

                entity.HasIndex(e => e.Bath1Negative44_5)
                    .HasName("IX_Bath1Negative44_5");

                entity.Property(e => e.Bath1Negative44_5)
                    .HasColumnType("nchar(1)")
                    .HasAnnotation("Min", 1)
                    .HasAnnotation("Max", 1);

                entity.HasIndex(e => e.Bath2Negative44_5)
                    .HasName("IX_Bath2Negative44_5");

                entity.Property(e => e.Bath2Negative44_5)
                    .HasColumnType("nchar(1)")
                    .HasAnnotation("Min", 1)
                    .HasAnnotation("Max", 1);

                entity.HasIndex(e => e.Bath3Negative44_5)
                    .HasName("IX_Bath3Negative44_5");

                entity.Property(e => e.Bath3Negative44_5)
                    .HasColumnType("nchar(1)")
                    .HasAnnotation("Min", 1)
                    .HasAnnotation("Max", 1);

                entity.HasIndex(e => e.Blank35)
                    .HasName("IX_Blank35");

                entity.Property(e => e.Blank35)
                    .HasColumnType("nchar(1)")
                    .HasAnnotation("Min", 1)
                    .HasAnnotation("Max", 1);

                entity.HasIndex(e => e.Bath1Blank44_5)
                    .HasName("IX_Bath1Blank44_5");

                entity.Property(e => e.Bath1Blank44_5)
                    .HasColumnType("nchar(1)")
                    .HasAnnotation("Min", 1)
                    .HasAnnotation("Max", 1);

                entity.HasIndex(e => e.Bath2Blank44_5)
                    .HasName("IX_Bath2Blank44_5");

                entity.Property(e => e.Bath2Blank44_5)
                    .HasColumnType("nchar(1)")
                    .HasAnnotation("Min", 1)
                    .HasAnnotation("Max", 1);

                entity.HasIndex(e => e.Bath3Blank44_5)
                    .HasName("IX_Bath3Blank44_5");

                entity.Property(e => e.Bath3Blank44_5)
                    .HasColumnType("nchar(1)")
                    .HasAnnotation("Min", 1)
                    .HasAnnotation("Max", 1);

                entity.HasIndex(e => e.Lot35)
                    .HasName("IX_Lot35");

                entity.Property(e => e.Lot35)
                    .HasMaxLength(20);

                entity.HasIndex(e => e.Lot44_5)
                    .HasName("IX_Lot44_5");

                entity.Property(e => e.Lot44_5)
                    .HasMaxLength(20);

                entity.Property(e => e.Weather)
                    .HasMaxLength(250);

                entity.Property(e => e.RunComment)
                    .HasMaxLength(250);

                entity.Property(e => e.RunWeatherComment)
                    .HasMaxLength(250);

                entity.Property(e => e.SampleBottleLotNumber)
                    .HasMaxLength(20);

                entity.HasIndex(e => e.SalinitiesReadBy)
                    .HasName("IX_SalinitiesReadBy");

                entity.Property(e => e.SalinitiesReadBy)
                    .HasMaxLength(20);

                entity.HasIndex(e => e.SalinitiesReadDate)
                    .HasName("IX_SalinitiesReadDate");

                entity.Property(e => e.SalinitiesReadDate)
                    .HasColumnType("datetime")
                    .HasAnnotation("DateAfterYear", 1980);

                entity.HasIndex(e => e.ResultsReadBy)
                    .HasName("IX_ResultsReadBy");

                entity.Property(e => e.ResultsReadBy)
                    .HasMaxLength(20);

                entity.HasIndex(e => e.ResultsReadDate)
                    .HasName("IX_ResultsReadDate");

                entity.Property(e => e.ResultsReadDate)
                    .HasColumnType("datetime")
                    .HasAnnotation("DateAfterYear", 1980);

                entity.HasIndex(e => e.ResultsRecordedBy)
                    .HasName("IX_ResultsRecordedBy");

                entity.Property(e => e.ResultsRecordedBy)
                    .HasMaxLength(20);

                entity.HasIndex(e => e.ResultsRecordedDate)
                    .HasName("IX_ResultsRecordedDate");

                entity.Property(e => e.ResultsRecordedDate)
                    .HasColumnType("datetime")
                    .HasAnnotation("DateAfterYear", 1980)
                    .HasAnnotation("DateBiggerThanOtherField", "RunDate");

                entity.HasIndex(e => e.DailyDuplicateRlog)
                    .HasName("IX_DailyDuplicateRlog");

                entity.Property(e => e.DailyDuplicateRlog)
                    .HasAnnotation("Min", 0.0f)
                    .HasAnnotation("Max", 1000.0f);

                entity.HasIndex(e => e.DailyDuplicatePrecisionCriteria)
                    .HasName("IX_DailyDuplicatePrecisionCriteria");

                entity.Property(e => e.DailyDuplicatePrecisionCriteria)
                    .HasAnnotation("Min", 0.0f)
                    .HasAnnotation("Max", 1000.0f);

                entity.HasIndex(e => e.DailyDuplicateAcceptable)
                    .HasName("IX_DuplicateAcceptable");

                entity.Property(e => e.DailyDuplicateAcceptable);

                entity.HasIndex(e => e.IntertechDuplicateRlog)
                    .HasName("IX_IntertechDuplicateRlog");

                entity.Property(e => e.IntertechDuplicateRlog)
                    .HasAnnotation("Min", 0.0f)
                    .HasAnnotation("Max", 1000.0f);

                entity.HasIndex(e => e.IntertechDuplicatePrecisionCriteria)
                    .HasName("IX_IntertechDuplicatePrecisionCriteria");

                entity.Property(e => e.IntertechDuplicatePrecisionCriteria)
                    .HasAnnotation("Min", 0.0f)
                    .HasAnnotation("Max", 1000.0f);

                entity.HasIndex(e => e.IntertechDuplicateAcceptable)
                    .HasName("IX_IntertechDuplicateAcceptable");

                entity.Property(e => e.IntertechDuplicateAcceptable);

                entity.HasIndex(e => e.IntertechReadAcceptable)
                    .HasName("IX_IntertechReadAcceptable");

                entity.Property(e => e.IntertechReadAcceptable);

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
                entity.HasKey(e => e.LabSheetID)
                    .HasName("PK_LabSheets");

                entity.ToTable("LabSheets");

                entity.HasIndex(e => e.OtherServerLabSheetID)
                    .HasName("IX_OtherServerLabSheetID");

                entity.Property(e => e.OtherServerLabSheetID)
                    .IsRequired()
                    .HasAnnotation("Min", 1);

                entity.HasIndex(e => e.SamplingPlanID)
                    .HasName("IX_SamplingPlanID");

                entity.Property(e => e.SamplingPlanID)
                    .IsRequired()
                    .HasAnnotation("Min", 1)
                    .HasAnnotation("ObjectExist", "SamplingPlan");

                entity.HasIndex(e => e.SamplingPlanName)
                    .HasName("IX_SamplingPlanName");

                entity.Property(e => e.SamplingPlanName)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.HasIndex(e => e.Year)
                    .HasName("IX_Year");

                entity.Property(e => e.Year)
                    .IsRequired()
                    .HasAnnotation("Min", 1980)
                    .HasAnnotation("Max", 2050);

                entity.HasIndex(e => e.Month)
                    .HasName("IX_Month");

                entity.Property(e => e.Month)
                    .IsRequired()
                    .HasAnnotation("Min", 1)
                    .HasAnnotation("Max", 12);

                entity.HasIndex(e => e.Day)
                    .HasName("IX_Day");

                entity.Property(e => e.Day)
                    .IsRequired()
                    .HasAnnotation("Min", 1)
                    .HasAnnotation("Max", 31);

                entity.HasIndex(e => e.RunNumber)
                    .HasName("IX_RunNumber");

                entity.Property(e => e.RunNumber)
                    .IsRequired()
                    .HasAnnotation("Min", 1)
                    .HasAnnotation("Max", 1000);

                entity.HasIndex(e => e.SubsectorTVItemID)
                    .HasName("IX_SubsectorTVItemID");

                entity.Property(e => e.SubsectorTVItemID)
                    .IsRequired()
                    .HasAnnotation("Min", 1)
                    .HasAnnotation("ObjectExist", "TVItem");

                entity.HasIndex(e => e.MWQMRunTVItemID)
                    .HasName("IX_MWQMRunTVItemID");

                entity.Property(e => e.MWQMRunTVItemID)
                    .HasAnnotation("Min", 1)
                    .HasAnnotation("ObjectExist", "TVItem");

                entity.HasIndex(e => e.SamplingPlanType)
                    .HasName("IX_SamplingPlanType");

                entity.Property(e => e.SamplingPlanType)
                    .IsRequired()
                    .HasAnnotation("Type", typeof(SamplingPlanTypeEnum));

                entity.HasIndex(e => e.SampleType)
                    .HasName("IX_SampleType");

                entity.Property(e => e.SampleType)
                    .IsRequired()
                    .HasAnnotation("Type", typeof(SampleTypeEnum));

                entity.HasIndex(e => e.LabSheetType)
                    .HasName("IX_LabSheetType");

                entity.Property(e => e.LabSheetType)
                    .IsRequired()
                    .HasAnnotation("Type", typeof(LabSheetTypeEnum));

                entity.HasIndex(e => e.LabSheetStatus)
                    .HasName("IX_LabSheetStatus");

                entity.Property(e => e.LabSheetStatus)
                    .IsRequired()
                    .HasAnnotation("Type", typeof(LabSheetStatusEnum));

                entity.HasIndex(e => e.FileName)
                    .HasName("IX_FileName");

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.HasIndex(e => e.FileLastModifiedDate_Local)
                    .HasName("IX_FileLastModifiedDate_Local");

                entity.Property(e => e.FileLastModifiedDate_Local)
                    .HasColumnType("datetime")
                    .IsRequired();

                entity.Property(e => e.FileContent)
                    .IsRequired();

                entity.HasIndex(e => e.AcceptedOrRejectedByContactTVItemID)
                    .HasName("IX_AcceptedByContactTVItemID");

                entity.Property(e => e.AcceptedOrRejectedByContactTVItemID)
                    .HasAnnotation("Min", 1)
                    .HasAnnotation("ObjectExist", "TVItem");

                entity.HasIndex(e => e.AcceptedOrRejectedDateTime)
                    .HasName("IX_AcceptedDateTime");

                entity.Property(e => e.AcceptedOrRejectedDateTime)
                    .HasColumnType("datetime")
                    .HasAnnotation("DateAfterYear", 1980);

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
                entity.HasKey(e => e.LabSheetTubeMPNDetailID)
                    .HasName("PK_LabSheetTubeMPNDetailID");

                entity.ToTable("LabSheetTubeMPNDetails");

                entity.HasIndex(e => e.LabSheetDetailID)
                    .HasName("IX_LabSheetDetailID");

                entity.Property(e => e.LabSheetDetailID)
                    .IsRequired()
                    .HasAnnotation("Min", 1)
                    .HasAnnotation("ObjectExist", "LabSheetDetail");

                entity.HasIndex(e => e.Ordinal)
                    .HasName("IX_Ordinal");

                entity.Property(e => e.Ordinal)
                    .IsRequired()
                    .HasAnnotation("Min", 0)
                    .HasAnnotation("Max", 1000);

                entity.HasIndex(e => e.MWQMSiteTVItemID)
                    .HasName("IX_MWQMSiteTVItemID");

                entity.Property(e => e.MWQMSiteTVItemID)
                    .IsRequired()
                    .HasAnnotation("Min", 1)
                    .HasAnnotation("ObjectExist", "TVItem");

                entity.HasIndex(e => e.SampleDateTime)
                    .HasName("IX_SampleDateTime");

                entity.Property(e => e.SampleDateTime)
                    .HasColumnType("datetime")
                    .HasAnnotation("DateAfterYear", 1980);

                entity.HasIndex(e => e.MPN)
                    .HasName("IX_MPN");

                entity.Property(e => e.MPN)
                    .HasAnnotation("Min", 1)
                    .HasAnnotation("Max", 20000000);

                entity.HasIndex(e => e.Tube10)
                    .HasName("IX_Tube10");

                entity.Property(e => e.Tube10)
                    .HasAnnotation("Min", 0)
                    .HasAnnotation("Max", 5);

                entity.HasIndex(e => e.Tube1_0)
                    .HasName("IX_Tube1_0");

                entity.Property(e => e.Tube1_0)
                    .HasAnnotation("Min", 0)
                    .HasAnnotation("Max", 5);

                entity.HasIndex(e => e.Tube0_1)
                    .HasName("IX_Tube0_1");

                entity.Property(e => e.Tube0_1)
                    .HasAnnotation("Min", 0)
                    .HasAnnotation("Max", 5);

                entity.HasIndex(e => e.Salinity)
                    .HasName("IX_Salinity");

                entity.Property(e => e.Salinity)
                    .HasAnnotation("Min", 0.0f)
                    .HasAnnotation("Max", 40.0f);

                entity.HasIndex(e => e.Temperature)
                    .HasName("IX_Temperature");

                entity.Property(e => e.Temperature)
                    .HasAnnotation("Min", 0.0f)
                    .HasAnnotation("Max", 40.0f);

                entity.HasIndex(e => e.ProcessedBy)
                    .HasName("IX_ProcessedBy");

                entity.Property(e => e.ProcessedBy)
                    .HasMaxLength(10);

                entity.HasIndex(e => e.SampleType)
                    .HasName("IX_SampleType");

                entity.Property(e => e.SampleType)
                    .IsRequired()
                    .HasAnnotation("Type", typeof(SampleTypeEnum));

                entity.HasIndex(e => e.SiteComment)
                    .HasName("IX_SiteComment");

                entity.Property(e => e.SiteComment)
                    .HasMaxLength(250);

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
                entity.HasKey(e => e.LogID)
                    .HasName("PK_Logs");

                entity.ToTable("Logs");

                entity.HasIndex(e => e.TableName)
                    .HasName("IX_TableName");

                entity.Property(e => e.TableName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasIndex(e => e.ID)
                    .HasName("IX_ID");

                entity.Property(e => e.ID)
                    .IsRequired()
                    .HasAnnotation("Min", 1);

                entity.HasIndex(e => e.LogCommand)
                    .HasName("IX_LogCommand");

                entity.Property(e => e.LogCommand)
                    .IsRequired()
                    .HasAnnotation("Type", typeof(LogCommandEnum));

                entity.Property(e => e.Information)
                    .IsRequired()
                    .HasColumnType("text");

                entity.HasIndex(e => e.LastUpdateDate_UTC)
                    .HasName("IX_LastUpdateDate_UTC");

                entity.Property(e => e.LastUpdateDate_UTC)
                    .HasColumnType("datetime")
                    .IsRequired()
                    .HasAnnotation("DateAfterYear", 1980);

                entity.HasIndex(e => e.LastUpdateContactTVItemID)
                    .HasName("IX_LastUpdateContactTVItemID");

                entity.Property(e => e.LastUpdateContactTVItemID)
                    .IsRequired()
                    .HasAnnotation("Min", 1)
                    .HasAnnotation("ObjectExist", "TVItem");
            });
        }
        private void OnModelCreating_MapInfoPoint(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MapInfoPoint>(entity =>
            {
                entity.HasKey(e => e.MapInfoPointID)
                    .HasName("PK_MapInfoPoints");

                entity.ToTable("MapInfoPoints");

                entity.HasIndex(e => e.MapInfoID)
                    .HasName("IX_MapInfoID");

                entity.Property(e => e.MapInfoID)
                    .IsRequired()
                    .HasAnnotation("Min", 1)
                    .HasAnnotation("ObjectExist", "MapInfo");

                entity.HasIndex(e => e.Ordinal)
                    .HasName("IX_Ordinal");

                entity.Property(e => e.Ordinal)
                    .IsRequired()
                    .HasAnnotation("Min", 0)
                    .HasAnnotation("Max", 1000000);

                entity.HasIndex(e => e.Lat)
                    .HasName("IX_Lat");

                entity.Property(e => e.Lat)
                    .IsRequired()
                    .HasAnnotation("Min", -90.0f)
                    .HasAnnotation("Max", 90.0f);

                entity.HasIndex(e => e.Lng)
                    .HasName("IX_Lng");

                entity.Property(e => e.Lng)
                    .IsRequired()
                    .HasAnnotation("Min", -180.0f)
                    .HasAnnotation("Max", 180.0f);

                entity.HasIndex(e => e.LastUpdateDate_UTC)
                    .HasName("IX_LastUpdateDate_UTC");

                entity.Property(e => e.LastUpdateDate_UTC)
                    .HasColumnType("datetime")
                    .IsRequired()
                    .HasAnnotation("DateAfterYear", 1980);

                entity.HasIndex(e => e.LastUpdateContactTVItemID)
                    .HasName("IX_LastUpdateContactID");

                entity.Property(e => e.LastUpdateContactTVItemID)
                    .IsRequired()
                    .HasAnnotation("Min", 1)
                    .HasAnnotation("ObjectExist", "TVItem");

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
                entity.HasKey(e => e.MapInfoID)
                    .HasName("PK_MapInfos");

                entity.ToTable("MapInfos");

                entity.HasIndex(e => e.TVItemID)
                    .HasName("IX_TVItemID");

                entity.Property(e => e.TVItemID)
                    .IsRequired()
                    .HasAnnotation("Min", 1)
                    .HasAnnotation("OjbectExist", "TVItem");

                entity.HasIndex(e => e.TVType)
                    .HasName("IX_TVType");

                entity.Property(e => e.TVType)
                    .IsRequired()
                    .HasAnnotation("Type", typeof(TVTypeEnum));

                entity.HasIndex(e => e.LatMin)
                    .HasName("IX_LatMin");

                entity.Property(e => e.LatMin)
                    .IsRequired()
                    .HasAnnotation("Min", -90.0f)
                    .HasAnnotation("Max", 90.0f);

                entity.HasIndex(e => e.LatMax)
                    .HasName("IX_LatMax");

                entity.Property(e => e.LatMax)
                    .IsRequired()
                    .HasAnnotation("Min", -90.0f)
                    .HasAnnotation("Max", 90.0f);

                entity.HasIndex(e => e.LngMin)
                    .HasName("IX_LngMin");

                entity.Property(e => e.LngMin)
                    .IsRequired()
                    .HasAnnotation("Min", -180.0f)
                    .HasAnnotation("Max", 180.0f);

                entity.HasIndex(e => e.LngMax)
                    .HasName("IX_LngMax");

                entity.Property(e => e.LngMax)
                    .IsRequired()
                    .HasAnnotation("Min", -180.0f)
                    .HasAnnotation("Max", 180.0f);

                entity.HasIndex(e => e.MapInfoDrawType)
                    .HasName("IX_DrawType");

                entity.Property(e => e.MapInfoDrawType)
                    .IsRequired()
                    .HasAnnotation("Type", typeof(MapInfoDrawTypeEnum));

                entity.HasIndex(e => e.LastUpdateDate_UTC)
                    .HasName("IX_LastUpdateDate_UTC");

                entity.Property(e => e.LastUpdateDate_UTC)
                    .HasColumnType("datetime")
                    .IsRequired()
                    .HasAnnotation("DateAfterYear", 1980);

                entity.HasIndex(e => e.LastUpdateContactTVItemID)
                    .HasName("IX_LastUpdateContactID");

                entity.Property(e => e.LastUpdateContactTVItemID)
                    .IsRequired()
                    .HasAnnotation("Min", 1)
                    .HasAnnotation("ObjectExist", "TVItem");

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
                entity.HasKey(e => e.MikeBoundaryConditionID)
                    .HasName("IX_MikeBoundaryConditionID");

                entity.ToTable("MikeBoundaryConditions");

                entity.HasIndex(e => e.MikeBoundaryConditionTVItemID)
                    .HasName("IX_TVItemID");

                entity.Property(e => e.MikeBoundaryConditionTVItemID)
                    .IsRequired()
                    .HasAnnotation("Min", 1)
                    .HasAnnotation("ObjectExist", "TVItem");

                entity.HasIndex(e => e.MikeBoundaryConditionCode)
                    .HasName("IX_MikeBoundaryConditionCode");

                entity.Property(e => e.MikeBoundaryConditionCode)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasIndex(e => e.MikeBoundaryConditionName)
                    .HasName("IX_MikeBoundaryConditionName");

                entity.Property(e => e.MikeBoundaryConditionName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasIndex(e => e.MikeBoundaryConditionLength_m)
                    .HasName("IX_MikeBoundaryConditionLength_m");

                entity.Property(e => e.MikeBoundaryConditionLength_m)
                    .IsRequired()
                    .HasAnnotation("Min", 0.0f)
                    .HasAnnotation("Max", 1000000.0f);

                entity.HasIndex(e => e.MikeBoundaryConditionFormat)
                    .HasName("IX_MIkeBoundaryConditionFormat");

                entity.Property(e => e.MikeBoundaryConditionFormat)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasIndex(e => e.MikeBoundaryConditionLevelOrVelocity)
                    .HasName("IX_MikeBoundaryConditionLevelOrVelocity");

                entity.Property(e => e.MikeBoundaryConditionLevelOrVelocity)
                    .IsRequired()
                    .HasAnnotation("Type", typeof(MikeBoundaryConditionLevelOrVelocityEnum));

                entity.HasIndex(e => e.WebTideDataSet)
                    .HasName("IX_WebTideDataSet");

                entity.Property(e => e.WebTideDataSet)
                    .IsRequired()
                    .HasAnnotation("Type", typeof(WebTideDataSetEnum));

                entity.HasIndex(e => e.NumberOfWebTideNodes)
                    .HasName("IX_NumberOfWebTideNodes");

                entity.Property(e => e.NumberOfWebTideNodes)
                    .IsRequired()
                    .HasAnnotation("Min", 1)
                    .HasAnnotation("Max", 100);

                entity.Property(e => e.WebTideDataFromStartToEndDate)
                    .HasColumnType("text");

                entity.HasIndex(e => e.TVType)
                    .HasName("IX_TVType");

                entity.Property(e => e.TVType)
                    .IsRequired()
                    .HasAnnotation("Type", typeof(TVTypeEnum));

                entity.HasIndex(e => e.LastUpdateDate_UTC)
                    .HasName("IX_LastUpdateDate_UTC");

                entity.Property(e => e.LastUpdateDate_UTC)
                    .HasColumnType("datetime")
                    .IsRequired()
                    .HasAnnotation("DateAfterYear", 1980);

                entity.HasIndex(e => e.LastUpdateContactTVItemID)
                    .HasName("IX_LastUpdateContactID");

                entity.Property(e => e.LastUpdateContactTVItemID)
                    .IsRequired()
                    .HasAnnotation("Min", 1)
                    .HasAnnotation("ObjectExist", "TVItem");

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
                entity.HasKey(e => e.MikeScenarioID)
                    .HasName("PK_MikeScenarios");

                entity.ToTable("MikeScenarios");

                entity.HasIndex(e => e.MikeScenarioTVItemID)
                    .HasName("IX_MikeScenarioTVItemID");

                entity.Property(e => e.MikeScenarioTVItemID)
                    .IsRequired()
                    .HasAnnotation("Min", 1)
                    .HasAnnotation("ObjectExist", "TVItem");

                entity.HasIndex(e => e.ParentMikeScenarioID)
                    .HasName("IX_ParentMikeScenarioID");

                entity.Property(e => e.ParentMikeScenarioID)
                    .HasAnnotation("Min", 1)
                    .HasAnnotation("ObjectExist", "TVItem");

                entity.HasIndex(e => e.ScenarioStatus)
                    .HasName("IX_ScenarioStatus");

                entity.Property(e => e.ScenarioStatus)
                    .IsRequired()
                    .HasAnnotation("Type", typeof(ScenarioStatusEnum));

                entity.Property(e => e.ErrorInfo)
                    .HasColumnType("text");

                entity.HasIndex(e => e.MikeScenarioStartDateTime_Local)
                    .HasName("IX_ScenarioStartDateAndTime_UTC");

                entity.Property(e => e.MikeScenarioStartDateTime_Local)
                    .IsRequired()
                    .HasColumnType("datetime")
                    .HasAnnotation("DateAfterYear", 1980);

                entity.HasIndex(e => e.MikeScenarioEndDateTime_Local)
                    .HasName("IX_ScenarioEndDateAndTime_UTC");

                entity.Property(e => e.MikeScenarioEndDateTime_Local)
                    .IsRequired()
                    .HasColumnType("datetime")
                    .HasAnnotation("DateBiggerThanOtherField", "MikeScenarioStartDateTime_Local");

                entity.HasIndex(e => e.MikeScenarioStartExecutionDateTime_Local)
                    .HasName("IX_ScenarioStartExecutionDateAndTime");

                entity.Property(e => e.MikeScenarioStartExecutionDateTime_Local)
                    .HasColumnType("datetime")
                    .HasAnnotation("DateAfterYear", 1980);

                entity.HasIndex(e => e.MikeScenarioExecutionTime_min)
                    .HasName("IX_ScenarioExecutionTime_min");

                entity.Property(e => e.MikeScenarioExecutionTime_min)
                    .HasAnnotation("Min", 0.0f)
                    .HasAnnotation("Max", 10000.0f);

                entity.HasIndex(e => e.WindSpeed_km_h)
                    .HasName("IX_WindSpeed_m_s");

                entity.Property(e => e.WindSpeed_km_h)
                    .IsRequired()
                    .HasAnnotation("Min", 0.0f)
                    .HasAnnotation("Max", 200.0f);

                entity.HasIndex(e => e.WindDirection_deg)
                    .HasName("IX_WindDirection_deg");

                entity.Property(e => e.WindDirection_deg)
                    .IsRequired()
                    .HasAnnotation("Min", 0.0f)
                    .HasAnnotation("Max", 360.0f);

                entity.HasIndex(e => e.DecayFactor_per_day)
                    .HasName("IX_DecayFactor_per_day");

                entity.Property(e => e.DecayFactor_per_day)
                    .IsRequired()
                    .HasAnnotation("Min", 0.0f)
                    .HasAnnotation("Max", 1000.0f);

                entity.HasIndex(e => e.DecayIsConstant)
                    .HasName("IX_DecayIsConstant");

                entity.Property(e => e.DecayIsConstant)
                    .IsRequired();

                entity.HasIndex(e => e.DecayFactorAmplitude)
                    .HasName("IX_DecayFactorAmplitude");

                entity.Property(e => e.DecayFactorAmplitude)
                    .IsRequired()
                    .HasAnnotation("Min", 0.0f)
                    .HasAnnotation("Max", 1000.0f);

                entity.HasIndex(e => e.ResultFrequency_min)
                    .HasName("IX_ResultFrequency_min");

                entity.Property(e => e.ResultFrequency_min)
                    .IsRequired()
                    .HasAnnotation("Min", 15)
                    .HasAnnotation("Max", 60);

                entity.HasIndex(e => e.AmbientTemperature_C)
                    .HasName("IX_AmbientTemperature_C");

                entity.Property(e => e.AmbientTemperature_C)
                    .IsRequired()
                    .HasAnnotation("Min", 0.0f)
                    .HasAnnotation("Max", 50.0f);

                entity.HasIndex(e => e.AmbientSalinity_PSU)
                    .HasName("IX_AmbientSalinity_PSU");

                entity.Property(e => e.AmbientSalinity_PSU)
                    .IsRequired()
                    .HasAnnotation("Min", 0.0f)
                    .HasAnnotation("Max", 40.0f);

                entity.HasIndex(e => e.ManningNumber)
                    .HasName("IX_ManningNumber");

                entity.Property(e => e.ManningNumber)
                    .IsRequired()
                    .HasAnnotation("Min", 0.0f)
                    .HasAnnotation("Max", 100.0f);

                entity.HasIndex(e => e.NumberOfElements)
                    .HasName("IX_NumberOfElements");

                entity.Property(e => e.NumberOfElements)
                    .HasAnnotation("Min", 1)
                    .HasAnnotation("Max", 1000000);

                entity.HasIndex(e => e.NumberOfTimeSteps)
                    .HasName("IX_NumberOfTimeSteps");

                entity.Property(e => e.NumberOfTimeSteps)
                    .HasAnnotation("Min", 1)
                    .HasAnnotation("Max", 1000000);

                entity.HasIndex(e => e.NumberOfSigmaLayers)
                    .HasName("IX_NumberOfSigmaLayers");

                entity.Property(e => e.NumberOfSigmaLayers)
                    .HasAnnotation("Min", 1)
                    .HasAnnotation("Max", 1000000);

                entity.HasIndex(e => e.NumberOfZlayers)
                    .HasName("IX_NumberOfZLayers");

                entity.Property(e => e.NumberOfZlayers)
                    .HasAnnotation("Min", 1)
                    .HasAnnotation("Max", 1000000);

                entity.HasIndex(e => e.NumberOfHydroOutputParameters)
                    .HasName("IX_NumberOfHydroOutputParameters");

                entity.Property(e => e.NumberOfHydroOutputParameters)
                    .HasAnnotation("Min", 1)
                    .HasAnnotation("Max", 1000000);

                entity.HasIndex(e => e.NumberOfTransOutputParameters)
                    .HasName("IX_NumberOfTransOutputParameters");

                entity.Property(e => e.NumberOfTransOutputParameters)
                    .HasAnnotation("Min", 1)
                    .HasAnnotation("Max", 1000000);

                entity.HasIndex(e => e.EstimatedHydroFileSize)
                    .HasName("IX_MikeScenarios");

                entity.Property(e => e.EstimatedHydroFileSize)
                    .HasAnnotation("Min", 1)
                    .HasAnnotation("Max", 10000000);

                entity.HasIndex(e => e.EstimatedTransFileSize)
                    .HasName("IX_EstimatedTransFileSize");

                entity.Property(e => e.EstimatedTransFileSize)
                    .HasAnnotation("Min", 1)
                    .HasAnnotation("Max", 10000000);

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
                    .HasAnnotation("ObjectExit", "TVItem");

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
                entity.HasKey(e => e.MikeSourceID)
                    .HasName("PK_MikeSources");

                entity.ToTable("MikeSources");

                entity.HasIndex(e => e.MikeSourceTVItemID)
                    .HasName("IX_MikeSourceTVItemID");

                entity.Property(e => e.MikeSourceTVItemID)
                    .IsRequired()
                    .HasAnnotation("Min", 1)
                    .HasAnnotation("ObjectExist", "TVItem");

                entity.HasIndex(e => e.IsContinuous)
                    .HasName("IX_IsContinuous");

                entity.Property(e => e.IsContinuous)
                    .IsRequired();

                entity.HasIndex(e => e.Include)
                    .HasName("IX_Include");

                entity.Property(e => e.Include)
                    .IsRequired();

                entity.HasIndex(e => e.IsRiver)
                    .HasName("IX_IsRiver");

                entity.Property(e => e.IsRiver)
                    .IsRequired();

                entity.HasIndex(e => e.SourceNumberString)
                    .HasName("IX_SourceNumberString");

                entity.Property(e => e.SourceNumberString)
                    .IsRequired()
                    .HasMaxLength(50);

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
                entity.HasKey(e => e.MikeSourceStartEndID)
                    .HasName("PK_MikeSourceStartEnds");

                entity.ToTable("MikeSourceStartEnds");

                entity.HasIndex(e => e.MikeSourceID)
                    .HasName("IX_TVItemID");

                entity.Property(e => e.MikeSourceID)
                    .IsRequired()
                    .HasAnnotation("Min", 1)
                    .HasAnnotation("ObjectExist", "MikeSource");

                entity.HasIndex(e => e.StartDateAndTime_Local)
                    .HasName("IX_StartDateAndTime_UTC");

                entity.Property(e => e.StartDateAndTime_Local)
                    .IsRequired()
                    .HasColumnType("datetime")
                    .HasAnnotation("DateAfterYear", 1980);

                entity.HasIndex(e => e.EndDateAndTime_Local)
                    .HasName("IX_EndDateAndTime_UTC");

                entity.Property(e => e.EndDateAndTime_Local)
                    .HasColumnType("datetime")
                    .IsRequired()
                    .HasAnnotation("DateBiggerThanOtherField", "StartDateAndTime_Local");

                entity.HasIndex(e => e.SourceFlowStart_m3_day)
                    .HasName("IX_SourceFlowStart_m3_day");

                entity.Property(e => e.SourceFlowStart_m3_day)
                    .IsRequired()
                    .HasAnnotation("Min", 0.0f)
                    .HasAnnotation("Max", 1000000.0f);

                entity.HasIndex(e => e.SourceFlowEnd_m3_day)
                    .HasName("IX_SourceFlowEnd_m3_day");

                entity.Property(e => e.SourceFlowEnd_m3_day)
                    .IsRequired()
                    .HasAnnotation("Min", 0.0f)
                    .HasAnnotation("Max", 1000000.0f);

                entity.HasIndex(e => e.SourcePollutionStart_MPN_100ml)
                    .HasName("IX_SourcePollutionStart_MPN_100ml");

                entity.Property(e => e.SourcePollutionStart_MPN_100ml)
                    .IsRequired()
                    .HasAnnotation("Min", 0)
                    .HasAnnotation("Max", 20000000);

                entity.HasIndex(e => e.SourcePollutionEnd_MPN_100ml)
                    .HasName("IX_SourcePollutionEnd_MPN_100ml");

                entity.Property(e => e.SourcePollutionEnd_MPN_100ml)
                    .IsRequired()
                    .HasAnnotation("Min", 0)
                    .HasAnnotation("Max", 20000000);

                entity.HasIndex(e => e.SourceTemperatureStart_C)
                    .HasName("IX_SourceTemperatureStart_C");

                entity.Property(e => e.SourceTemperatureStart_C)
                    .IsRequired()
                    .HasAnnotation("Min", 0.0f)
                    .HasAnnotation("Max", 40.0f);

                entity.HasIndex(e => e.SourceTemperatureEnd_C)
                    .HasName("IX_SourceTemperatureEnd_C");

                entity.Property(e => e.SourceTemperatureEnd_C)
                    .IsRequired()
                    .HasAnnotation("Min", 0.0f)
                    .HasAnnotation("Max", 40.0f);

                entity.HasIndex(e => e.SourceSalinityStart_PSU)
                    .HasName("IX_SourceSalinityStart_PSU");

                entity.Property(e => e.SourceSalinityStart_PSU)
                    .IsRequired()
                    .HasAnnotation("Min", 0.0f)
                    .HasAnnotation("Max", 40.0f);

                entity.HasIndex(e => e.SourceSalinityEnd_PSU)
                    .HasName("IX_SourceSalinityEnd_PSU");

                entity.Property(e => e.SourceSalinityEnd_PSU)
                    .IsRequired()
                    .HasAnnotation("Min", 0.0f)
                    .HasAnnotation("Max", 40.0f);

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
                entity.HasKey(e => e.MWQMLookupMPNID)
                    .HasName("PK_MWQMLookupMPNs");

                entity.ToTable("MWQMLookupMPNs");

                entity.HasIndex(e => new { e.Tubes01, e.Tubes1, e.Tubes10 })
                    .HasName("IX_MWQMMPNs")
                    .IsUnique();

                entity.Property(e => e.Tubes10)
                    .IsRequired()
                    .HasAnnotation("Min", 0)
                    .HasAnnotation("Max", 5);

                entity.Property(e => e.Tubes1)
                    .IsRequired()
                    .HasAnnotation("Min", 0)
                    .HasAnnotation("Max", 5);

                entity.Property(e => e.Tubes01)
                    .IsRequired()
                    .HasAnnotation("Min", 0)
                    .HasAnnotation("Max", 5);

                entity.HasIndex(e => e.MPN_100ml)
                    .HasName("IX_MPN_100ml");

                entity.Property(e => e.MPN_100ml)
                    .IsRequired()
                    .HasAnnotation("Min", 1)
                    .HasAnnotation("Max", 1700);

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

            });
        }
        private void OnModelCreating_MWQMRunLanguage(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MWQMRunLanguage>(entity =>
            {
                entity.HasKey(e => e.MWQMRunLanguageID)
                    .HasName("PK_MWQMRunLanguages");

                entity.ToTable("MWQMRunLanguages");

                entity.HasIndex(e => e.MWQMRunID)
                    .HasName("IX_MWQMRunID");

                entity.Property(e => e.MWQMRunID)
                    .IsRequired()
                    .HasAnnotation("Min", 1)
                    .HasAnnotation("ObjectExist", "MWQMRun");

                entity.HasIndex(e => e.Language)
                    .HasName("IX_Language");

                entity.Property(e => e.Language)
                    .IsRequired()
                    .HasAnnotation("Type", typeof(LanguageEnum));

                entity.Property(e => e.RunComment)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.TranslationStatusRunComment)
                    .IsRequired()
                    .HasAnnotation("Type", typeof(TranslationStatusEnum));

                entity.Property(e => e.RunWeatherComment)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.TranslationStatusRunWeatherComment)
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
                entity.HasKey(e => e.MWQMRunID)
                    .HasName("PK_MWQMRuns");

                entity.ToTable("MWQMRuns");

                entity.HasIndex(e => e.SubsectorTVItemID)
                    .HasName("IX_MWQMSiteTVItemID");

                entity.Property(e => e.SubsectorTVItemID)
                    .IsRequired()
                    .HasAnnotation("Min", 1)
                    .HasAnnotation("ObjectExist", "TVItem");

                entity.HasIndex(e => e.MWQMRunTVItemID)
                    .HasName("IX_MWQMRunTVItemID");

                entity.Property(e => e.MWQMRunTVItemID)
                    .IsRequired()
                    .HasAnnotation("Min", 1)
                    .HasAnnotation("OjectExist", "TVItem");

                entity.Property(e => e.RunSampleType)
                    .IsRequired()
                    .HasAnnotation("Type", typeof(SampleTypeEnum));

                entity.HasIndex(e => e.DateTime_Local)
                    .HasName("IX_Date_UTC");

                entity.Property(e => e.DateTime_Local)
                    .HasColumnType("datetime")
                    .IsRequired();

                entity.Property(e => e.RunNumber)
                    .IsRequired()
                    .HasAnnotation("Min", 1)
                    .HasAnnotation("Max", 1000);

                entity.HasIndex(e => e.StartDateTime_Local)
                    .HasName("IX_StartTime_UTC");

                entity.Property(e => e.StartDateTime_Local)
                    .HasColumnType("datetime")
                    .HasAnnotation("DateAfterYear", 1980);

                entity.HasIndex(e => e.EndDateTime_Local)
                    .HasName("IX_EndTime_UTC");

                entity.Property(e => e.EndDateTime_Local)
                    .HasColumnType("datetime")
                    .HasAnnotation("DateBiggerThanOtherField", "StartDateTime_Local");

                entity.HasIndex(e => e.LabReceivedDateTime_Local)
                    .HasName("IX_LabReceivedTime_UTC");

                entity.Property(e => e.LabReceivedDateTime_Local)
                    .HasColumnType("datetime")
                    .HasAnnotation("DateAfterYear", 1980);

                entity.HasIndex(e => e.TemperatureControl1_C)
                    .HasName("IX_TemperatureControl1_C");

                entity.Property(e => e.TemperatureControl1_C)
                    .HasAnnotation("Min", 0.0f)
                    .HasAnnotation("Max", 40.0f);

                entity.HasIndex(e => e.TemperatureControl2_C)
                    .HasName("IX_TemperatureControl2_C");

                entity.Property(e => e.TemperatureControl2_C)
                    .HasAnnotation("Min", 0.0f)
                    .HasAnnotation("Max", 40.0f);

                entity.HasIndex(e => e.SeaStateAtStart_BeaufortScale)
                    .HasName("IX_SeaStateAtStart_BeaufortScale");

                entity.Property(e => e.SeaStateAtStart_BeaufortScale)
                    .HasAnnotation("Type", typeof(BeaufortScaleEnum));

                entity.HasIndex(e => e.SeaStateAtEnd_BeaufortScale)
                    .HasName("IX_SeaStateAtEnd_BeaufortScale");

                entity.Property(e => e.SeaStateAtEnd_BeaufortScale)
                    .HasAnnotation("Type", typeof(BeaufortScaleEnum));

                entity.HasIndex(e => e.WaterLevelAtBrook_m)
                    .HasName("IX_WaterLevelAtBrook_m");

                entity.Property(e => e.WaterLevelAtBrook_m)
                    .HasAnnotation("Min", 0.0f)
                    .HasAnnotation("Max", 100.0f);

                entity.HasIndex(e => e.WaveHightAtStart_m)
                    .HasName("IX_WaveHightAtStart_m");

                entity.Property(e => e.WaveHightAtStart_m)
                    .HasAnnotation("Min", 0.0f)
                    .HasAnnotation("Max", 100.0f);

                entity.HasIndex(e => e.WaveHightAtEnd_m)
                    .HasName("IX_WaveHightAtEnd_m");

                entity.Property(e => e.WaveHightAtEnd_m)
                    .HasAnnotation("Min", 0.0f)
                    .HasAnnotation("Max", 100.0f);

                entity.HasIndex(e => e.AnalyzeMethod)
                    .HasName("IX_AnayseMethodTVItemID");

                entity.Property(e => e.AnalyzeMethod)
                    .HasAnnotation("Type", typeof(AnalyzeMethodEnum));

                entity.HasIndex(e => e.SampleMatrix)
                    .HasName("IX_MatrixTVItemID");

                entity.Property(e => e.SampleMatrix)
                    .HasAnnotation("Type", typeof(SampleTypeEnum));

                entity.HasIndex(e => e.Laboratory)
                    .HasName("IX_LabTVItemID");

                entity.Property(e => e.Laboratory)
                    .HasAnnotation("Type", typeof(LaboratoryEnum));

                entity.HasIndex(e => e.SampleStatus)
                    .HasName("IX_StatusStatus");

                entity.Property(e => e.SampleStatus)
                    .HasAnnotation("Type", typeof(SampleStatusEnum));

                entity.HasIndex(e => e.LabSampleApprovalContactTVItemID)
                    .HasName("IX_ValidatorContactID");

                entity.Property(e => e.LabSampleApprovalContactTVItemID)
                    .HasAnnotation("Min", 1);

                entity.Property(e => e.LabAnalyzeBath1IncubationStartDateTime_Local)
                    .HasColumnType("datetime")
                    .HasAnnotation("DateAfterYear", 1980);

                entity.Property(e => e.LabAnalyzeBath2IncubationStartDateTime_Local)
                    .HasColumnType("datetime")
                    .HasAnnotation("DateAfterYear", 1980);

                entity.Property(e => e.LabAnalyzeBath3IncubationStartDateTime_Local)
                    .HasColumnType("datetime")
                    .HasAnnotation("DateAfterYear", 1980);

                entity.HasIndex(e => e.LabRunSampleApprovalDateTime_Local)
                    .HasName("IX_ValidateTime_UTC");

                entity.Property(e => e.LabRunSampleApprovalDateTime_Local)
                    .HasColumnType("datetime")
                    .HasAnnotation("DateAfterYear", 1980);

                entity.HasIndex(e => e.Tide_Start)
                    .HasName("IX_Tide_Start");

                entity.Property(e => e.Tide_Start)
                    .HasAnnotation("Type", typeof(TideTextEnum));

                entity.HasIndex(e => e.Tide_End)
                    .HasName("IX_Tide_End");

                entity.Property(e => e.Tide_End)
                    .HasAnnotation("Type", typeof(TideTextEnum));

                entity.HasIndex(e => e.RainDay0_mm)
                    .HasName("IX_RainDay0_mm");

                entity.Property(e => e.RainDay0_mm)
                    .HasAnnotation("Min", 0.0f)
                    .HasAnnotation("Max", 1000.0f);

                entity.HasIndex(e => e.RainDay1_mm)
                    .HasName("IX_RainDay1_mm");

                entity.Property(e => e.RainDay1_mm)
                    .HasAnnotation("Min", 0.0f)
                    .HasAnnotation("Max", 1000.0f);

                entity.HasIndex(e => e.RainDay2_mm)
                    .HasName("IX_RainDay2_mm");

                entity.Property(e => e.RainDay2_mm)
                    .HasAnnotation("Min", 0.0f)
                    .HasAnnotation("Max", 1000.0f);

                entity.HasIndex(e => e.RainDay3_mm)
                    .HasName("IX_RainDay3_mm");

                entity.Property(e => e.RainDay3_mm)
                    .HasAnnotation("Min", 0.0f)
                    .HasAnnotation("Max", 1000.0f);

                entity.HasIndex(e => e.RainDay4_mm)
                    .HasName("IX_RainDay4_mm");

                entity.Property(e => e.RainDay4_mm)
                    .HasAnnotation("Min", 0.0f)
                    .HasAnnotation("Max", 1000.0f);

                entity.HasIndex(e => e.RainDay5_mm)
                    .HasName("IX_RainDay5_mm");

                entity.Property(e => e.RainDay5_mm)
                    .HasAnnotation("Min", 0.0f)
                    .HasAnnotation("Max", 1000.0f);

                entity.HasIndex(e => e.RainDay6_mm)
                    .HasName("IX_RainDay6_mm");

                entity.Property(e => e.RainDay6_mm)
                    .HasAnnotation("Min", 0.0f)
                    .HasAnnotation("Max", 1000.0f);

                entity.HasIndex(e => e.RainDay7_mm)
                    .HasName("IX_RainDay7_mm");

                entity.Property(e => e.RainDay7_mm)
                    .HasAnnotation("Min", 0.0f)
                    .HasAnnotation("Max", 1000.0f);

                entity.HasIndex(e => e.RainDay8_mm)
                    .HasName("IX_RainDay8_mm");

                entity.Property(e => e.RainDay8_mm)
                    .HasAnnotation("Min", 0.0f)
                    .HasAnnotation("Max", 1000.0f);

                entity.HasIndex(e => e.RainDay9_mm)
                    .HasName("IX_RainDay9_mm");

                entity.Property(e => e.RainDay9_mm)
                    .HasAnnotation("Min", 0.0f)
                    .HasAnnotation("Max", 1000.0f);

                entity.HasIndex(e => e.RainDay10_mm)
                    .HasName("IX_RainDay10_mm");

                entity.Property(e => e.RainDay10_mm)
                    .HasAnnotation("Min", 0.0f)
                    .HasAnnotation("Max", 1000.0f);

                entity.Property(e => e.RemoveFromStat);

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
                entity.HasKey(e => e.MWQMSampleLanguageID)
                    .HasName("PK_MWQMSampleLanguages");

                entity.ToTable("MWQMSampleLanguages");

                entity.HasIndex(e => e.MWQMSampleID)
                    .HasName("IX_MWQMSampleID");

                entity.Property(e => e.MWQMSampleID)
                    .IsRequired()
                    .HasAnnotation("Min", 1)
                    .HasAnnotation("ObjectExist", "MWQMSample");

                entity.HasIndex(e => e.Language)
                    .HasName("IX_Language");

                entity.Property(e => e.Language)
                    .IsRequired()
                    .HasAnnotation("Type", typeof(LanguageEnum));

                entity.Property(e => e.MWQMSampleNote)
                    .IsRequired()
                    .HasColumnType("text");

                entity.HasIndex(e => e.TranslationStatus)
                    .HasName("IX_MWQMSampleNoteStatus");

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
                entity.HasKey(e => e.MWQMSampleID)
                    .HasName("PK_MWQMSamples");

                entity.ToTable("MWQMSamples");

                entity.HasIndex(e => e.MWQMSiteTVItemID)
                    .HasName("IX_MWQMSiteTVItemID");

                entity.Property(e => e.MWQMSiteTVItemID)
                    .IsRequired()
                    .HasAnnotation("Min", 1)
                    .HasAnnotation("ObjectExist", "TVItem");

                entity.HasIndex(e => e.MWQMRunTVItemID)
                    .HasName("IX_MWQMRunTVItemID");

                entity.Property(e => e.MWQMRunTVItemID)
                    .IsRequired()
                    .HasAnnotation("Min", 1)
                    .HasAnnotation("ObjectExist", "TVItem");

                entity.HasIndex(e => e.SampleDateTime_Local)
                    .HasName("IX_SampleDateTime_UTC");

                entity.Property(e => e.SampleDateTime_Local)
                    .IsRequired()
                    .HasColumnType("datetime")
                    .HasAnnotation("DateAfterYear", 1980);

                entity.HasIndex(e => e.Depth_m)
                    .HasName("IX_Depth_m");

                entity.Property(e => e.Depth_m)
                    .HasAnnotation("Min", 0.0f)
                    .HasAnnotation("Max", 1000.0f);

                entity.HasIndex(e => e.FecCol_MPN_100ml)
                    .HasName("IX_FecCol_MPN_100ml");

                entity.Property(e => e.FecCol_MPN_100ml)
                    .IsRequired()
                    .HasAnnotation("Min", 0)
                    .HasAnnotation("Max", 20000000);

                entity.HasIndex(e => e.Salinity_PPT)
                    .HasName("IX_Salinity_PSU");

                entity.Property(e => e.Salinity_PPT)
                    .HasAnnotation("Min", 0.0f)
                    .HasAnnotation("Max", 40.0f);

                entity.HasIndex(e => e.WaterTemp_C)
                    .HasName("IX_WaterTemp_C");

                entity.Property(e => e.WaterTemp_C)
                    .HasAnnotation("Min", 0.0f)
                    .HasAnnotation("Max", 40.0f);

                entity.HasIndex(e => e.PH)
                    .HasName("IX_PH");

                entity.Property(e => e.PH)
                    .HasAnnotation("Min", 0.0f)
                    .HasAnnotation("Max", 14.0f);

                entity.Property(e => e.SampleTypesText)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasIndex(e => e.SampleType_old)
                    .HasName("IX_SampleType");

                entity.Property(e => e.SampleType_old)
                    .IsRequired()
                    .HasAnnotation("Type", typeof(SampleTypeEnum));

                entity.Property(e => e.Tube_10)
                    .HasAnnotation("Min", 0)
                    .HasAnnotation("Max", 5);

                entity.Property(e => e.Tube_1_0)
                    .HasAnnotation("Min", 0)
                    .HasAnnotation("Max", 5);

                entity.Property(e => e.Tube_0_1)
                    .HasAnnotation("Min", 0)
                    .HasAnnotation("Max", 5);

                entity.Property(e => e.ProcessedBy)
                    .HasMaxLength(10);

                entity.HasIndex(e => e.LastUpdateDate_UTC)
                    .HasName("IX_LastUpdateDate_UTC");

                entity.Property(e => e.LastUpdateDate_UTC)
                    .HasColumnType("datetime")
                    .IsRequired()
                    .HasAnnotation("DateAfterYear", 1980);

                entity.HasIndex(e => e.LastUpdateContactTVItemID)
                    .HasName("IX_LastUpdateContactID");

                entity.Property(e => e.LastUpdateContactTVItemID)
                    .IsRequired()
                    .HasAnnotation("Min", 1)
                    .HasAnnotation("ObjectExist", "TVItem");

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
                entity.HasKey(e => e.MWQMSiteID)
                    .HasName("PK_MWQMSites");

                entity.ToTable("MWQMSites");

                entity.HasIndex(e => e.MWQMSiteTVItemID)
                    .HasName("IX_MWQMSiteTVItemID");

                entity.Property(e => e.MWQMSiteTVItemID)
                    .IsRequired()
                    .HasAnnotation("Min", 1)
                    .HasAnnotation("ObjectExist", "TVItem");

                entity.HasIndex(e => e.MWQMSiteNumber)
                    .HasName("IX_MWQMSiteNumber");

                entity.Property(e => e.MWQMSiteNumber)
                    .IsRequired()
                    .HasMaxLength(8);

                entity.Property(e => e.MWQMSiteDescription)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.HasIndex(e => e.MWQMSiteLatestClassification)
                    .HasName("IX_MWQMSiteLatestClassification");

                entity.Property(e => e.MWQMSiteLatestClassification)
                    .IsRequired()
                    .HasAnnotation("Type", typeof(MWQMSiteLatestClassificationEnum));

                entity.HasIndex(e => e.Ordinal)
                    .HasName("IX_Ordinal");

                entity.Property(e => e.Ordinal)
                    .IsRequired()
                    .HasAnnotation("Min", 0)
                    .HasAnnotation("Max", 1000);

                entity.HasIndex(e => e.LastUpdateDate_UTC)
                    .HasName("IX_LastUpdateDate_UTC");

                entity.Property(e => e.LastUpdateDate_UTC)
                    .HasColumnType("datetime")
                    .IsRequired()
                    .HasAnnotation("DateAfterYear", 1980);

                entity.HasIndex(e => e.LastUpdateContactTVItemID)
                    .HasName("IX_LastUpdateContactID");

                entity.Property(e => e.LastUpdateContactTVItemID)
                    .IsRequired()
                    .HasAnnotation("Min", 1)
                    .HasAnnotation("ObjectExist", "TVItem");

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
                entity.HasKey(e => e.MWQMSiteStartEndDateID)
                    .HasName("PK_MWQMSiteStartEndDates");

                entity.ToTable("MWQMSiteStartEndDates");

                entity.HasIndex(e => e.MWQMSiteTVItemID)
                    .HasName("IX_MWQMSiteTVItemID");

                entity.Property(e => e.MWQMSiteTVItemID)
                    .IsRequired()
                    .HasAnnotation("Min", 1)
                    .HasAnnotation("ObjectExist", "TVItem");

                entity.HasIndex(e => e.StartDate)
                    .HasName("IX_StartDate");

                entity.Property(e => e.StartDate)
                    .HasColumnType("datetime")
                    .IsRequired()
                    .HasAnnotation("DateAfterYear", 1980);

                entity.HasIndex(e => e.EndDate)
                    .HasName("IX_EndDate");

                entity.Property(e => e.EndDate)
                    .HasColumnType("datetime")
                    .HasAnnotation("DateBiggerThanOtherField", "StartDate");

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
                entity.HasKey(e => e.MWQMSubsectorLanguageID)
                    .HasName("PK_MWQMSubsectorLanguages");

                entity.ToTable("MWQMSubsectorLanguages");

                entity.HasIndex(e => e.MWQMSubsectorID)
                    .HasName("IX_MWQMSubsectorID");

                entity.Property(e => e.MWQMSubsectorID)
                    .IsRequired()
                    .HasAnnotation("Min", 1)
                    .HasAnnotation("ObjectExist", "MWQMSubsector");

                entity.HasIndex(e => e.Language)
                    .HasName("IX_Language");

                entity.Property(e => e.Language)
                    .IsRequired()
                    .HasAnnotation("Type", typeof(LanguageEnum));

                entity.HasIndex(e => e.SubsectorDesc)
                    .HasName("IX_SubsectorDesc");

                entity.Property(e => e.SubsectorDesc)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.HasIndex(e => e.TranslationStatus)
                    .HasName("IX_SubsectorDescStatus");

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
                entity.HasKey(e => e.MWQMSubsectorID)
                    .HasName("PK_MWQMSubsectors");

                entity.ToTable("MWQMSubsectors");

                entity.HasIndex(e => e.MWQMSubsectorTVItemID)
                    .HasName("IX_TVItemID");

                entity.Property(e => e.MWQMSubsectorTVItemID)
                    .IsRequired()
                    .HasAnnotation("Min", 1)
                    .HasAnnotation("ObjectExist", "TVItem");

                entity.HasIndex(e => e.SubsectorHistoricKey)
                    .HasName("IX_SubsectorHistoricKey");

                entity.Property(e => e.SubsectorHistoricKey)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.TideLocationSIDText)
                    .HasMaxLength(30);

                entity.Property(e => e.RainDay0Limit)
                    .HasAnnotation("Min", 0.0f)
                    .HasAnnotation("Max", 1000.0f);

                entity.Property(e => e.RainDay1Limit)
                    .HasAnnotation("Min", 0.0f)
                    .HasAnnotation("Max", 1000.0f);

                entity.Property(e => e.RainDay2Limit)
                    .HasAnnotation("Min", 0.0f)
                    .HasAnnotation("Max", 1000.0f);

                entity.Property(e => e.RainDay3Limit)
                    .HasAnnotation("Min", 0.0f)
                    .HasAnnotation("Max", 1000.0f);

                entity.Property(e => e.RainDay4Limit)
                    .HasAnnotation("Min", 0.0f)
                    .HasAnnotation("Max", 1000.0f);

                entity.Property(e => e.RainDay5Limit)
                    .HasAnnotation("Min", 0.0f)
                    .HasAnnotation("Max", 1000.0f);

                entity.Property(e => e.RainDay6Limit)
                    .HasAnnotation("Min", 0.0f)
                    .HasAnnotation("Max", 1000.0f);

                entity.Property(e => e.RainDay7Limit)
                    .HasAnnotation("Min", 0.0f)
                    .HasAnnotation("Max", 1000.0f);

                entity.Property(e => e.RainDay8Limit)
                    .HasAnnotation("Min", 0.0f)
                    .HasAnnotation("Max", 1000.0f);

                entity.Property(e => e.RainDay9Limit)
                    .HasAnnotation("Min", 0.0f)
                    .HasAnnotation("Max", 1000.0f);

                entity.Property(e => e.RainDay10Limit)
                    .HasAnnotation("Min", 0.0f)
                    .HasAnnotation("Max", 1000.0f);

                entity.Property(e => e.IncludeRainStartDate)
                    .HasColumnType("datetime");

                entity.Property(e => e.IncludeRainEndDate)
                    .HasColumnType("datetime")
                    .HasAnnotation("DateAfterYear", 1980);

                entity.Property(e => e.IncludeRainRunCount)
                    .HasAnnotation("Min", 0);

                entity.Property(e => e.IncludeRainSelectFullYear);

                entity.Property(e => e.NoRainStartDate)
                    .HasColumnType("datetime")
                    .HasAnnotation("DateAfterYear", 1980);

                entity.Property(e => e.NoRainEndDate)
                    .HasColumnType("datetime")
                    .HasAnnotation("DateBiggerThanOtherField", "NoRainStartDate");

                entity.Property(e => e.NoRainRunCount)
                    .HasAnnotation("Min", 0);

                entity.Property(e => e.NoRainSelectFullYear);

                entity.Property(e => e.OnlyRainStartDate)
                    .HasColumnType("datetime")
                    .HasAnnotation("DateAfterYear", 1980); ;

                entity.Property(e => e.OnlyRainEndDate)
                    .HasColumnType("datetime")
                    .HasAnnotation("DateBiggerThanOtherField", "OnlyRainStartDate");

                entity.Property(e => e.OnlyRainRunCount)
                    .HasAnnotation("Min", 0);

                entity.Property(e => e.OnlyRainSelectFullYear);

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
                entity.HasKey(e => e.PolSourceObservationIssueID)
                    .HasName("PK_PolSourceObservationIssues");

                entity.ToTable("PolSourceObservationIssues");

                entity.HasIndex(e => e.PolSourceObservationID)
                    .HasName("IX_PolSourceObservationID");

                entity.Property(e => e.PolSourceObservationID)
                    .IsRequired()
                    .HasAnnotation("Min", 1)
                    .HasAnnotation("ObjectExist", "PolSourceObservation");

                entity.Property(e => e.ObservationInfo)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.HasIndex(e => e.Ordinal)
                    .HasName("IX_Ordinal");

                entity.Property(e => e.Ordinal)
                    .IsRequired()
                    .HasAnnotation("Min", 0)
                    .HasAnnotation("Max", 1000);

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
                entity.HasKey(e => e.PolSourceObservationID)
                    .HasName("IX_PolSourceObservationID");

                entity.ToTable("PolSourceObservations");

                entity.HasIndex(e => e.PolSourceSiteTVItemID)
                    .HasName("IX_PolSourceSiteTVItemID");

                entity.Property(e => e.PolSourceSiteTVItemID)
                    .IsRequired()
                    .HasAnnotation("Min", 1)
                    .HasAnnotation("ObjectExist", "TVItem");

                entity.HasIndex(e => e.ObservationDate_Local)
                    .HasName("IX_ObservationDate_UTC");

                entity.Property(e => e.ObservationDate_Local)
                    .IsRequired()
                    .HasColumnType("datetime")
                    .HasAnnotation("DateAfterYear", 1980);

                entity.HasIndex(e => e.ContactTVItemID)
                    .HasName("IX_ContactTVItemID");

                entity.Property(e => e.ContactTVItemID)
                    .IsRequired()
                    .HasAnnotation("Min", 1)
                    .HasAnnotation("ObjectExist", "TVItem");

                entity.Property(e => e.Observation_ToBeDeleted)
                    .IsRequired()
                    .HasColumnType("text");

                entity.HasIndex(e => e.LastUpdateDate_UTC)
                    .HasName("IX_LastUpdateDate_UTC");

                entity.Property(e => e.LastUpdateDate_UTC)
                    .IsRequired()
                    .HasAnnotation("Min", 1)
                    .HasAnnotation("DateAfterYear", 1980);

                entity.HasIndex(e => e.LastUpdateContactTVItemID)
                    .HasName("IX_LastUpdateContactID");

                entity.Property(e => e.LastUpdateContactTVItemID)
                    .IsRequired()
                    .HasAnnotation("Min", 1)
                    .HasAnnotation("ObjectExist", "TVItem");

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
                entity.HasKey(e => e.PolSourceSiteID)
                    .HasName("IX_PolSourceSites");

                entity.ToTable("PolSourceSites");

                entity.HasIndex(e => e.PolSourceSiteTVItemID)
                    .HasName("IX_TVItemID");

                entity.Property(e => e.PolSourceSiteTVItemID)
                    .IsRequired()
                    .HasAnnotation("Min", 1)
                    .HasAnnotation("ObjectExist", "TVItem");

                entity.Property(e => e.Temp_Locator_CanDelete)
                    .HasMaxLength(50);

                entity.HasIndex(e => e.Oldsiteid)
                    .HasName("IX_Oldsiteid");

                entity.Property(e => e.Oldsiteid)
                    .HasAnnotation("Min", 0);

                entity.HasIndex(e => e.Site)
                    .HasName("IX_Site");

                entity.Property(e => e.Site)
                    .HasAnnotation("Min", 0);

                entity.HasIndex(e => e.SiteID)
                    .HasName("IX_siteid");

                entity.Property(e => e.SiteID)
                    .HasAnnotation("Min", 0);

                entity.HasIndex(e => e.IsPointSource)
                    .HasName("IX_IsPointSource");

                entity.Property(e => e.IsPointSource)
                    .IsRequired();

                entity.Property(e => e.InactiveReason)
                    .HasAnnotation("Type", typeof(PolSourceInactiveReasonEnum));

                entity.Property(e => e.CivicAddressTVItemID)
                    .HasAnnotation("Min", 1);

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
                entity.HasKey(e => e.RatingCurveID)
                    .HasName("PK_RatingCurves");

                entity.ToTable("RatingCurves");

                entity.HasIndex(e => e.HydrometricSiteID)
                    .HasName("IX_HydrometricSiteID");

                entity.Property(e => e.HydrometricSiteID)
                    .IsRequired()
                    .HasAnnotation("Min", 1)
                    .HasAnnotation("ObjectExist", "TVItem");

                entity.HasIndex(e => e.RatingCurveNumber)
                    .HasName("IX_RatingCurveNumber");

                entity.Property(e => e.RatingCurveNumber)
                    .IsRequired()
                    .HasMaxLength(50);

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
                entity.HasKey(e => e.RatingCurveValueID)
                    .HasName("PK_RatingCurveValues");

                entity.ToTable("RatingCurveValues");

                entity.HasIndex(e => e.RatingCurveID)
                    .HasName("IX_RatingCurveID");

                entity.Property(e => e.RatingCurveID)
                    .IsRequired()
                    .HasAnnotation("Min", 1)
                    .HasAnnotation("ObjectExist", "RatingCurve");

                entity.HasIndex(e => e.StageValue_m)
                    .HasName("IX_StageValue");

                entity.Property(e => e.StageValue_m)
                    .IsRequired()
                    .HasAnnotation("Min", 0.0f)
                    .HasAnnotation("Max", 1000.0f);

                entity.HasIndex(e => e.DischargeValue_m3_s)
                    .HasName("IX_DischargeValue");

                entity.Property(e => e.DischargeValue_m3_s)
                    .IsRequired()
                    .HasAnnotation("Min", 0.0f)
                    .HasAnnotation("Max", 1000000.0f);

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
                entity.HasKey(e => e.ResetPasswordID)
                    .HasName("PK_ResetPasswords");

                entity.ToTable("ResetPasswords");

                entity.HasIndex(e => e.Email)
                    .HasName("IX_Email");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.HasIndex(e => e.ExpireDate_Local)
                    .HasName("IX_ExpireDate");

                entity.Property(e => e.ExpireDate_Local)
                    .IsRequired()
                    .HasColumnType("datetime")
                    .HasAnnotation("DateAfterYear", 1980);

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(8)
                    .HasAnnotation("Min", 8);

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

            });
        }
        private void OnModelCreating_SamplingPlan(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SamplingPlan>(entity =>
            {
                entity.HasKey(e => e.SamplingPlanID)
                    .HasName("PK_SamplingPlans");

                entity.ToTable("SamplingPlans");

                entity.HasIndex(e => e.SamplingPlanName)
                    .HasName("IX_SamplingPlanName")
                    .IsUnique();

                entity.Property(e => e.SamplingPlanName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.HasIndex(e => e.ForGroupName)
                    .HasName("IX_ForGroupName");

                entity.Property(e => e.ForGroupName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.SampleType)
                    .IsRequired()
                    .HasAnnotation("Type", typeof(SampleTypeEnum));

                entity.Property(e => e.SamplingPlanType)
                    .IsRequired()
                    .HasAnnotation("Type", typeof(SamplingPlanTypeEnum));

                entity.Property(e => e.LabSheetType)
                    .IsRequired()
                    .HasAnnotation("Type", typeof(LabSheetTypeEnum));

                entity.HasIndex(e => e.ProvinceTVItemID)
                    .HasName("IX_ProvinceTVItemID");

                entity.Property(e => e.ProvinceTVItemID)
                    .IsRequired()
                    .HasAnnotation("Min", 1)
                    .HasAnnotation("ObjectExist", "TVItem");

                entity.HasIndex(e => e.CreatorTVItemID)
                    .HasName("IX_CreatorTVItemID");

                entity.Property(e => e.CreatorTVItemID)
                    .IsRequired()
                    .HasAnnotation("Min", 1)
                    .HasAnnotation("ObjectExist", "TVItem");

                entity.HasIndex(e => e.Year)
                    .HasName("IX_Year");

                entity.Property(e => e.Year)
                    .IsRequired()
                    .HasAnnotation("Min", 1980)
                    .HasAnnotation("Max", 2050);

                entity.HasIndex(e => e.AccessCode)
                    .HasName("IX_AccessCode");

                entity.Property(e => e.AccessCode)
                    .IsRequired()
                    .HasAnnotation("Min", 3)
                    .HasAnnotation("Max", 15);

                entity.Property(e => e.DailyDuplicatePrecisionCriteria)
                    .IsRequired()
                    .HasAnnotation("Min", 0.0f)
                    .HasAnnotation("Max", 100.0f);

                entity.Property(e => e.IntertechDuplicatePrecisionCriteria)
                    .IsRequired()
                    .HasAnnotation("Min", 0.0f)
                    .HasAnnotation("Max", 100.0f);

                entity.Property(e => e.IncludeLaboratoryQAQC)
                    .IsRequired();

                entity.Property(e => e.AccessCode)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.HasIndex(e => e.SamplingPlanFileTVItemID)
                    .HasName("IX_SamplingPlanFileTVItemID");

                entity.Property(e => e.SamplingPlanFileTVItemID)
                    .HasAnnotation("Min", 1);

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
                entity.HasKey(e => e.SamplingPlanSubsectorID)
                    .HasName("PK_SamplingPlanSubsectors");

                entity.ToTable("SamplingPlanSubsectors");

                entity.HasIndex(e => e.SamplingPlanID)
                    .HasName("IX_SamplingPlanID");

                entity.Property(e => e.SamplingPlanID)
                    .IsRequired()
                    .HasAnnotation("Min", 1)
                    .HasAnnotation("ObjectExist", "SamplingPlan");

                entity.HasIndex(e => e.SubsectorTVItemID)
                    .HasName("IX_SubsectorTVItemID");

                entity.Property(e => e.SubsectorTVItemID)
                    .IsRequired()
                    .HasAnnotation("Min", 1)
                    .HasAnnotation("ObjectExist", "TVItem");

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
                entity.HasKey(e => e.SamplingPlanSubsectorSiteID)
                    .HasName("PK_SamplingPlanSubsectorSites");

                entity.ToTable("SamplingPlanSubsectorSites");

                entity.HasIndex(e => e.SamplingPlanSubsectorID)
                    .HasName("IX_SamplingPlanSubsectorID");

                entity.Property(e => e.SamplingPlanSubsectorID)
                    .IsRequired()
                    .HasAnnotation("Min", 1)
                    .HasAnnotation("ObjectExist", "SamplingPlanSubsector");

                entity.HasIndex(e => e.MWQMSiteTVItemID)
                    .HasName("IX_MWQMSiteTVItemID");

                entity.Property(e => e.MWQMSiteTVItemID)
                    .IsRequired()
                    .HasAnnotation("Min", 1)
                    .HasAnnotation("ObjectExist", "TVItem");

                entity.Property(e => e.IsDuplicate)
                    .IsRequired();

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
                entity.HasKey(e => e.SpillLanguageID)
                    .HasName("PK_SpillLanguages");

                entity.ToTable("SpillLanguages");

                entity.Property(e => e.SpillID)
                    .IsRequired()
                    .HasAnnotation("Min", 1)
                    .HasAnnotation("ObjectExist", "Spill");

                entity.HasIndex(e => e.Language)
                    .HasName("IX_Language");

                entity.Property(e => e.Language)
                    .IsRequired()
                    .HasAnnotation("Type", typeof(LanguageEnum));

                entity.Property(e => e.SpillComment)
                    .IsRequired()
                    .HasColumnType("text");

                entity.HasIndex(e => e.TranslationStatus)
                    .HasName("IX_SpillCommentStatus");

                entity.Property(e => e.TranslationStatus)
                    .IsRequired()
                    .HasAnnotation("Type", typeof(TranslationStatusEnum));

                entity.HasIndex(e => e.LastUpdateDate_UTC)
                    .HasName("IX_LastUpdateDate_UTC");

                entity.Property(e => e.LastUpdateDate_UTC)
                    .HasColumnType("datetime")
                    .IsRequired()
                    .HasAnnotation("DateAfterYear", 1980);

                entity.HasIndex(e => e.LastUpdateContactTVItemID)
                    .HasName("IX_LastUpdateContactID");

                entity.Property(e => e.LastUpdateContactTVItemID)
                    .IsRequired()
                    .HasAnnotation("Min", 1)
                    .HasAnnotation("ObjectExist", "TVItem");

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
                entity.HasKey(e => e.SpillID)
                    .HasName("PK_Spills");

                entity.ToTable("Spills");

                entity.HasIndex(e => e.MunicipalityTVItemID)
                    .HasName("IX_MunicipalityTVItemID");

                entity.Property(e => e.MunicipalityTVItemID)
                    .IsRequired()
                    .HasAnnotation("Min", 1)
                    .HasAnnotation("ObjectExist", "TVItem");

                entity.HasIndex(e => e.InfrastructureTVItemID)
                    .HasName("IX_InfrastructureTVItemID");

                entity.Property(e => e.InfrastructureTVItemID)
                    .HasAnnotation("Min", 1)
                    .HasAnnotation("ObjectExist", "TVItem");

                entity.HasIndex(e => e.StartDateTime_Local)
                    .HasName("IX_StartDateTime_UTC");

                entity.Property(e => e.StartDateTime_Local)
                    .IsRequired()
                    .HasColumnType("datetime")
                    .HasAnnotation("DateAfterYear", 1980);

                entity.HasIndex(e => e.EndDateTime_Local)
                    .HasName("IX_EndDateTime_UTC");

                entity.Property(e => e.EndDateTime_Local)
                    .HasColumnType("datetime")
                    .HasAnnotation("DateBiggerThanOtherField", "StartDateTime_Local");

                entity.HasIndex(e => e.AverageFlow_m3_day)
                    .HasName("IX_AverageFlow_m3_s");

                entity.Property(e => e.AverageFlow_m3_day)
                    .IsRequired()
                    .HasAnnotation("Min", 0.0f)
                    .HasAnnotation("Max", 1000000.0f);

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
                entity.HasKey(e => e.TelID)
                    .HasName("PK_Tels");

                entity.ToTable("Tels");

                entity.HasIndex(e => e.TelTVItemID)
                    .HasName("IX_TelTVItemID");

                entity.Property(e => e.TelTVItemID)
                    .IsRequired()
                    .HasAnnotation("Min", 1)
                    .HasAnnotation("ObjectExist", "TVItem");

                entity.HasIndex(e => e.TelNumber)
                    .HasName("IX_TelNumber");

                entity.Property(e => e.TelNumber)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasIndex(e => e.TelType)
                    .HasName("IX_TelTypeTVItemID");

                entity.Property(e => e.TelType)
                    .IsRequired()
                    .HasAnnotation("Type", typeof(TelTypeEnum));

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
                entity.HasKey(e => e.TideDataValueID)
                    .HasName("PK_TideDataValues");

                entity.ToTable("TideDataValues");

                entity.HasIndex(e => e.TideSiteTVItemID)
                    .HasName("IX_TideSiteTVItemID");

                entity.Property(e => e.TideSiteTVItemID)
                    .IsRequired()
                    .HasAnnotation("Min", 1)
                    .HasAnnotation("ObjectExist", "TVItem");

                entity.HasIndex(e => e.DateTime_Local)
                    .HasName("IX_DateTime_UTC");

                entity.Property(e => e.DateTime_Local)
                    .IsRequired()
                    .HasColumnType("datetime")
                    .HasAnnotation("DateAfterYear", 1980);

                entity.HasIndex(e => e.Keep)
                    .HasName("IX_Keep");

                entity.Property(e => e.Keep)
                    .IsRequired();

                entity.HasIndex(e => e.TideDataType)
                    .HasName("IX_TideDataType");

                entity.Property(e => e.TideDataType)
                    .IsRequired()
                    .HasAnnotation("Type", typeof(TideDataTypeEnum));

                entity.HasIndex(e => e.StorageDataType)
                    .HasName("IX_StorageDataType");

                entity.Property(e => e.StorageDataType)
                    .IsRequired()
                    .HasAnnotation("Type", typeof(StorageDataTypeEnum));

                entity.HasIndex(e => e.Depth_m)
                    .HasName("IX_Depth_m");

                entity.Property(e => e.Depth_m)
                    .IsRequired()
                    .HasAnnotation("Min", 0.0f)
                    .HasAnnotation("Max", 1000.0f);

                entity.HasIndex(e => e.UVelocity_m_s)
                    .HasName("IX_UVelocity_m_s");

                entity.Property(e => e.UVelocity_m_s)
                    .IsRequired()
                    .HasAnnotation("Min", -10.0f)
                    .HasAnnotation("Max", 10.0f);

                entity.HasIndex(e => e.VVelocity_m_s)
                    .HasName("IX_VVelocity_m_s");

                entity.Property(e => e.VVelocity_m_s)
                    .IsRequired()
                    .HasAnnotation("Min", -10.0f)
                    .HasAnnotation("Max", 10.0f);

                entity.Property(e => e.TideStart)
                    .HasAnnotation("Type", typeof(TideTextEnum));

                entity.Property(e => e.TideEnd)
                    .HasAnnotation("Type", typeof(TideTextEnum));

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
                entity.HasKey(e => e.TideLocationID)
                    .HasName("PK_TideLocations_1");

                entity.ToTable("TideLocations");

                entity.Property(e => e.TideLocationID)
                    .HasMaxLength(20);

                entity.HasIndex(e => e.Zone)
                    .HasName("IX_Zone");

                entity.Property(e => e.Zone)
                    .IsRequired()
                    .HasAnnotation("Min", 1);

                entity.HasIndex(e => e.Name)
                    .HasName("IX_Name");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasIndex(e => e.Prov)
                    .HasName("IX_Prov");

                entity.Property(e => e.Prov)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.HasIndex(e => e.sid)
                    .HasName("IX_sid");

                entity.Property(e => e.sid)
                    .IsRequired()
                    .HasAnnotation("Min", 1);

                entity.HasIndex(e => e.Lat)
                    .HasName("IX_Lat");

                entity.Property(e => e.Lat)
                    .IsRequired()
                    .HasAnnotation("Min", -90.0f)
                    .HasAnnotation("Max", 90.0f);

                entity.HasIndex(e => e.Lng)
                    .HasName("IX_Lng");

                entity.Property(e => e.Lng)
                    .IsRequired()
                    .HasAnnotation("Min", -180.0f)
                    .HasAnnotation("Max", 180.0f);
            });
        }
        private void OnModelCreating_TideSite(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TideSite>(entity =>
            {
                entity.HasKey(e => e.TideSiteID)
                    .HasName("PK_TideSites");

                entity.ToTable("TideSites");

                entity.HasIndex(e => e.TideSiteTVItemID)
                    .HasName("IX_TVItemID");

                entity.Property(e => e.TideSiteTVItemID)
                    .IsRequired()
                    .HasAnnotation("Min", 1)
                    .HasAnnotation("ObjectExist", "TVItem");

                entity.HasIndex(e => e.WebTideModel)
                    .HasName("IX_WebTideModel");

                entity.Property(e => e.WebTideModel)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasIndex(e => e.WebTideDatum_m)
                    .HasName("IX_WebTideDatum_m");

                entity.Property(e => e.WebTideDatum_m)
                    .IsRequired()
                    .HasAnnotation("Min", 0.0f)
                    .HasAnnotation("Max", 100.0f);

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