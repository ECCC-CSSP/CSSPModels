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
    public partial class MWQMSample : LastUpdate
    {
        #region Properties in DB
        [Key]
        [CSSPDisplayEN(DisplayEN = "MWQMSample ID")]
        [CSSPDisplayFR(DisplayFR = "MWQMSample ID")]
        [CSSPDescriptionEN(DescriptionEN = @"Contains the unique ""identifier on each row of the MWQMSamples table")]
        [CSSPDescriptionFR(DescriptionFR = @"Contient l'identifiant unique sur chaque ligne de la table MWQMSamples")]
        public int MWQMSampleID { get; set; }
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "16")]
        public int MWQMSiteTVItemID { get; set; }
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "31")]
        public int MWQMRunTVItemID { get; set; }
        [CSSPAfter(Year = 1980)]
        public DateTime SampleDateTime_Local { get; set; }
        [Range(0.0D, 1000.0D)]
        public double? Depth_m { get; set; }
        [Range(0, 10000000)]
        public int FecCol_MPN_100ml { get; set; }
        [Range(0.0D, 40.0D)]
        public double? Salinity_PPT { get; set; }
        [Range(-10.0D, 40.0D)]
        public double? WaterTemp_C { get; set; }
        [Range(0.0D, 14.0D)]
        public double? PH { get; set; }
        [StringLength(50)]
        public string SampleTypesText { get; set; }
        [CSSPEnumType]
        [CSSPAllowNull]
        public SampleTypeEnum? SampleType_old { get; set; }
        [Range(0, 5)]
        public int? Tube_10 { get; set; }
        [Range(0, 5)]
        public int? Tube_1_0 { get; set; }
        [Range(0, 5)]
        public int? Tube_0_1 { get; set; }
        [StringLength(10)]
        [CSSPAllowNull]
        public string ProcessedBy { get; set; }
        public bool UseForOpenData { get; set; }
        #endregion Properties in DB

        #region Constructors
        public MWQMSample() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class MWQMSampleWeb : MWQMSample
    {
        #region Properties for web information
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "MWQMSiteTVItemID", FillReturnField = "", FillNeedLanguage = true)]
        public TVItemLanguage MWQMSiteTVItemLanguage { get; set; }
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "MWQMRunTVItemID", FillReturnField = "", FillNeedLanguage = true)]
        public TVItemLanguage MWQMRunTVItemLanguage { get; set; }
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "", FillNeedLanguage = true)]
        [CSSPDisplayEN(DisplayEN = "Last update contact TVItemLanguage")]
        [CSSPDisplayFR(DisplayFR = "TVItemLanguage du contact ayant fait le dernière changement")]
        [CSSPDescriptionEN(DescriptionEN = @"Last update contact TVItemLanguage DB object")]
        [CSSPDescriptionFR(DescriptionFR = @"Object BD TVItemLanguage du contact ayant fait le dernière changement")]
        public TVItemLanguage LastUpdateContactTVItemLanguage { get; set; }
        [CSSPEnumTypeText(EnumTypeName = "SampleTypeEnum", EnumType = "SampleType_old")]
        [CSSPAllowNull]
        public string SampleType_oldText { get; set; }
        #endregion Properties for web information

        #region Constructors
        public MWQMSampleWeb() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class MWQMSampleReport : MWQMSampleWeb
    {
        #region Properties for report information
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "Report test")]
        [CSSPDisplayFR(DisplayFR = "Test report")]
        [CSSPDescriptionEN(DescriptionEN = @"Report test description")]
        [CSSPDescriptionFR(DescriptionFR = @"Description de test report")]
        public string MWQMSampleReportTest { get; set; }
        #endregion Properties for report information

        #region Constructors
        public MWQMSampleReport() : base()
        {
        }
        #endregion Constructors
    }
}
