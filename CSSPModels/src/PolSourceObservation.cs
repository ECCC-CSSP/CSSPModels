/*
 * Manually edited by Charles LeBlanc 
 * 
 */
using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    public partial class PolSourceObservation : LastUpdate
    {
        #region Properties in DB
        [Key]
        [CSSPDisplayEN(DisplayEN = "PolSourceObservation ID")]
        [CSSPDisplayFR(DisplayFR = "PolSourceObservation ID")]
        [CSSPDescriptionEN(DescriptionEN = @"Contains the unique ""identifier on each row of the PolSourceObservations table")]
        [CSSPDescriptionFR(DescriptionFR = @"Contient l'identifiant unique sur chaque ligne du tableau PolSourceObservations")]
        public int PolSourceObservationID { get; set; }
        [CSSPExist(ExistTypeName = "PolSourceSite", ExistPlurial = "s", ExistFieldID = "PolSourceSiteID")]
        public int PolSourceSiteID { get; set; }
        [CSSPAfter(Year = 1980)]
        public DateTime ObservationDate_Local { get; set; }
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "5")]
        public int ContactTVItemID { get; set; }
        public string Observation_ToBeDeleted { get; set; }
        #endregion Properties in DB

        #region Properties not in DB
        [NotMapped]
        [CSSPAllowNull]
        public PolSourceObservationWeb PolSourceObservationWeb { get; set; }
        [NotMapped]
        [CSSPAllowNull]
        public PolSourceObservationReport PolSourceObservationReport { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public PolSourceObservation() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class PolSourceObservationWeb
    {
        #region Properties for web information
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "PolSourceSiteID", FillReturnField = "", FillNeedLanguage = true)]
        public TVItemLanguage PolSourceSiteTVItemLanguage { get; set; }
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "ContactTVItemID", FillReturnField = "", FillNeedLanguage = true)]
        public TVItemLanguage ContactTVItemLanguage { get; set; }
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "", FillNeedLanguage = true)]
        public TVItemLanguage LastUpdateContactTVItemLanguage { get; set; }
        #endregion Properties for web information

        #region Constructors
        public PolSourceObservationWeb()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class PolSourceObservationReport
    {
        #region Properties for report information
        [CSSPAllowNull]
        public string PolSourceObservationReportTest { get; set; }
        #endregion Properties for report information

        #region Constructors
        public PolSourceObservationReport()
        {
        }
        #endregion Constructors
    }
}
