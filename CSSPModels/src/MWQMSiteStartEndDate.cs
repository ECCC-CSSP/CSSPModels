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
    public partial class MWQMSiteStartEndDate : LastUpdate
    {
        #region Properties in DB
        [Key]
        [CSSPDisplayEN(DisplayEN = "MWQMSiteStartEndDate ID")]
        [CSSPDisplayFR(DisplayFR = "MWQMSiteStartEndDate ID")]
        [CSSPDescriptionEN(DescriptionEN = @"Contains the unique ""identifier on each row of the MWQMSiteStartEndDates table")]
        [CSSPDescriptionFR(DescriptionFR = @"Contient l'identifiant unique sur chaque ligne du tableau MWQMSiteStartEndDates")]
        public int MWQMSiteStartEndDateID { get; set; }
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "16")]
        public int MWQMSiteTVItemID { get; set; }
        [CSSPAfter(Year = 1980)]
        public DateTime StartDate { get; set; }
        [CSSPAfter(Year = 1980)]
        [CSSPBigger(OtherField = "StartDate")]
        public DateTime? EndDate { get; set; }
        #endregion Properties in DB

        #region Constructors
        public MWQMSiteStartEndDate() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class MWQMSiteStartEndDateWeb : MWQMSiteStartEndDate
    {
        #region Properties for web information
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "MWQMSiteTVItemID", FillReturnField = "", FillNeedLanguage = true)]
        public TVItemLanguage MWQMSiteTVItemLanguage { get; set; }
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "", FillNeedLanguage = true)]
        public TVItemLanguage LastUpdateContactTVItemLanguage { get; set; }
        #endregion Properties for web information

        #region Constructors
        public MWQMSiteStartEndDateWeb() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class MWQMSiteStartEndDateReport : MWQMSiteStartEndDateWeb
    {
        #region Properties for report information
        [CSSPAllowNull]
        public string MWQMSiteStartEndDateReportTest { get; set; }
        #endregion Properties for report information

        #region Constructors
        public MWQMSiteStartEndDateReport() : base()
        {
        }
        #endregion Constructors
    }
}
