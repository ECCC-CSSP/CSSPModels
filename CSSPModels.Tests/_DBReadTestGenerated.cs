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

namespace CSSPModels.Tests
{
    [TestClass]
    public partial class DBReadTestGenerated
    {
        #region Variables
        #endregion Variables

        #region Properties
        #endregion Properties

        #region Constructors
        public DBReadTestGenerated()
        {
        }
        #endregion Constructors

        #region Tests
        [TestMethod]
        public void Testing_Reading_Every_Table_In_CSSPWebToolsDB()
        {
            using (CSSPWebToolsDBContext db = new CSSPWebToolsDBContext(DatabaseTypeEnum.SqlServerCSSPWebToolsDB))
            {
                try
                {
                    var addresses = db.Addresses.Take(1).FirstOrDefault();
                    var apperrlogs = db.AppErrLogs.Take(1).FirstOrDefault();
                    var apptasklanguages = db.AppTaskLanguages.Take(1).FirstOrDefault();
                    var apptasks = db.AppTasks.Take(1).FirstOrDefault();
                    //var aspnetroles = db.AspNetRoles.Take(1).FirstOrDefault();
                    //var aspnetuserclaims = db.AspNetUserClaims.Take(1).FirstOrDefault();
                    //var aspnetuserlogins = db.AspNetUserLogins.Take(1).FirstOrDefault();
                    //var aspnetuserroles = db.AspNetUserRoles.Take(1).FirstOrDefault();
                    //var aspnetusers = db.AspNetUsers.Take(1).FirstOrDefault();
                    var boxmodellanguages = db.BoxModelLanguages.Take(1).FirstOrDefault();
                    var boxmodelresults = db.BoxModelResults.Take(1).FirstOrDefault();
                    var boxmodels = db.BoxModels.Take(1).FirstOrDefault();
                    var climatedatavalues = db.ClimateDataValues.Take(1).FirstOrDefault();
                    var climatesites = db.ClimateSites.Take(1).FirstOrDefault();
                    var contactlogins = db.ContactLogins.Take(1).FirstOrDefault();
                    var contactpreferences = db.ContactPreferences.Take(1).FirstOrDefault();
                    var contacts = db.Contacts.Take(1).FirstOrDefault();
                    var contactshortcuts = db.ContactShortcuts.Take(1).FirstOrDefault();
                    var doctemplates = db.DocTemplates.Take(1).FirstOrDefault();
                    var emaildistributionlistcontacts = db.EmailDistributionListContacts.Take(1).FirstOrDefault();
                    var emaildistributionlists = db.EmailDistributionLists.Take(1).FirstOrDefault();
                    var emails = db.Emails.Take(1).FirstOrDefault();
                    var hydrometricdatavalues = db.HydrometricDataValues.Take(1).FirstOrDefault();
                    var hydrometricsites = db.HydrometricSites.Take(1).FirstOrDefault();
                    var infrastructurelanguages = db.InfrastructureLanguages.Take(1).FirstOrDefault();
                    var infrastructures = db.Infrastructures.Take(1).FirstOrDefault();
                    var labsheetdetails = db.LabSheetDetails.Take(1).FirstOrDefault();
                    var labsheets = db.LabSheets.Take(1).FirstOrDefault();
                    var labsheettubempndetails = db.LabSheetTubeMPNDetails.Take(1).FirstOrDefault();
                    var logs = db.Logs.Take(1).FirstOrDefault();
                    var mapinfopoints = db.MapInfoPoints.Take(1).FirstOrDefault();
                    var mapinfos = db.MapInfos.Take(1).FirstOrDefault();
                    var mikeboundaryconditions = db.MikeBoundaryConditions.Take(1).FirstOrDefault();
                    var mikescenarios = db.MikeScenarios.Take(1).FirstOrDefault();
                    var mikesources = db.MikeSources.Take(1).FirstOrDefault();
                    var mikesourcestartends = db.MikeSourceStartEnds.Take(1).FirstOrDefault();
                    var mwqmlookupmpns = db.MWQMLookupMPNs.Take(1).FirstOrDefault();
                    var mwqmrunlanguages = db.MWQMRunLanguages.Take(1).FirstOrDefault();
                    var mwqmruns = db.MWQMRuns.Take(1).FirstOrDefault();
                    var mwqmsamplelanguages = db.MWQMSampleLanguages.Take(1).FirstOrDefault();
                    var mwqmsamples = db.MWQMSamples.Take(1).FirstOrDefault();
                    var mwqmsites = db.MWQMSites.Take(1).FirstOrDefault();
                    var mwqmsitestartenddates = db.MWQMSiteStartEndDates.Take(1).FirstOrDefault();
                    var mwqmsubsectorlanguages = db.MWQMSubsectorLanguages.Take(1).FirstOrDefault();
                    var mwqmsubsectors = db.MWQMSubsectors.Take(1).FirstOrDefault();
                    var polsourceobservationissues = db.PolSourceObservationIssues.Take(1).FirstOrDefault();
                    var polsourceobservations = db.PolSourceObservations.Take(1).FirstOrDefault();
                    var polsourcesites = db.PolSourceSites.Take(1).FirstOrDefault();
                    //var rainexceedances = db.RainExceedances.Take(1).FirstOrDefault();
                    var ratingcurves = db.RatingCurves.Take(1).FirstOrDefault();
                    var ratingcurvevalues = db.RatingCurveValues.Take(1).FirstOrDefault();
                    var resetpasswords = db.ResetPasswords.Take(1).FirstOrDefault();
                    var samplingplans = db.SamplingPlans.Take(1).FirstOrDefault();
                    var samplingplansubsectors = db.SamplingPlanSubsectors.Take(1).FirstOrDefault();
                    var samplingplansubsectorsites = db.SamplingPlanSubsectorSites.Take(1).FirstOrDefault();
                    var spilllanguages = db.SpillLanguages.Take(1).FirstOrDefault();
                    var spills = db.Spills.Take(1).FirstOrDefault();
                    //var sysdiagrams = db.sysdiagrams.Take(1).FirstOrDefault();
                    var tels = db.Tels.Take(1).FirstOrDefault();
                    var tidedatavalues = db.TideDataValues.Take(1).FirstOrDefault();
                    var tidelocations = db.TideLocations.Take(1).FirstOrDefault();
                    var tidesites = db.TideSites.Take(1).FirstOrDefault();
                    var tvfilelanguages = db.TVFileLanguages.Take(1).FirstOrDefault();
                    var tvfiles = db.TVFiles.Take(1).FirstOrDefault();
                    var tvitemlanguages = db.TVItemLanguages.Take(1).FirstOrDefault();
                    var tvitemlinks = db.TVItemLinks.Take(1).FirstOrDefault();
                    var tvitems = db.TVItems.Take(1).FirstOrDefault();
                    var tvitemstats = db.TVItemStats.Take(1).FirstOrDefault();
                    var tvitemuserauthorizations = db.TVItemUserAuthorizations.Take(1).FirstOrDefault();
                    var tvtypeuserauthorizations = db.TVTypeUserAuthorizations.Take(1).FirstOrDefault();
                    var useofsites = db.UseOfSites.Take(1).FirstOrDefault();
                    var vpambients = db.VPAmbients.Take(1).FirstOrDefault();
                    var vpresults = db.VPResults.Take(1).FirstOrDefault();
                    var vpscenariolanguages = db.VPScenarioLanguages.Take(1).FirstOrDefault();
                    var vpscenarios = db.VPScenarios.Take(1).FirstOrDefault();
                }
                catch (Exception ex)
                {
                    Assert.AreEqual("", ex.Message);
                }
            }
        }
        #endregion Tests
    }
}
