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
            string ConnectionString = "";

            using (CSSPWebToolsDBContext db = new CSSPWebToolsDBContext())
            {
                ConnectionString = db.GetConnectionString();
            }

            if (DatabaseType == DatabaseTypeEnum.MemoryNoDBShape)
            {
                optionsBuilder.UseInMemoryDatabase(ConnectionString);
            }
            else if (DatabaseType == DatabaseTypeEnum.MemoryWithDBShape)
            {
                optionsBuilder.UseInMemoryDatabase(ConnectionString);
            }
            else if (DatabaseType == DatabaseTypeEnum.SQLite)
            {
                optionsBuilder.UseSqlite("Data Source=TestingCSSPWebToolsDB.db");
            }
            else if (DatabaseType == DatabaseTypeEnum.SqlServer)
            {
                optionsBuilder.UseSqlServer(ConnectionString);
            }
            else
            {
                throw new Exception("Please select a DatabaseType");
            }
        }
        #endregion Overrides

        #region Functions private
        public string GetConnectionString()
        {
            string ConnectionString = ConfigurationManager.ConnectionStrings["CSSPWebToolsDB"].ConnectionString;
            if (System.Environment.UserName == "leblancc" || System.Environment.UserName == "admin-leblancc")
            {
                return ConnectionString.Replace("aaaaaa", "wmon01dtchlebl2");
            }
            else
            {
                return ConnectionString.Replace("aaaaaa", "charles-pc");
            }
        }
        #endregion Functions private
    }
}