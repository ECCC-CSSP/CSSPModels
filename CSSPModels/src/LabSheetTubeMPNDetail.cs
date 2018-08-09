/*
 * Manually edited by Charles LeBlanc 
 * 
 */
using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace CSSPModels
{
    public partial class LabSheetTubeMPNDetail : LastUpdate
    {
        #region Properties in DB
        [Key]
        [CSSPDisplayEN(DisplayEN = "LabSheetTubeMPNDetail ID")]
        [CSSPDisplayFR(DisplayFR = "LabSheetTubeMPNDetail ID")]
        [CSSPDescriptionEN(DescriptionEN = @"Contains the unique ""identifier on each row of the LabSheetTubeMPNDetails table")]
        [CSSPDescriptionFR(DescriptionFR = @"Contient l'identifiant unique sur chaque ligne de la table LabSheetTubeMPNDetails")]
        public int LabSheetTubeMPNDetailID { get; set; }
        [CSSPExist(ExistTypeName = "LabSheetDetail", ExistPlurial = "s", ExistFieldID = "LabSheetDetailID")]
        public int LabSheetDetailID { get; set; }
        [Range(0, 1000)]
        public int Ordinal { get; set; }
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "16")]
        public int MWQMSiteTVItemID { get; set; }
        [CSSPAfter(Year = 1980)]
        public DateTime? SampleDateTime { get; set; }
        [Range(1, 10000000)]
        public int? MPN { get; set; }
        [Range(0, 5)]
        public int? Tube10 { get; set; }
        [Range(0, 5)]
        public int? Tube1_0 { get; set; }
        [Range(0, 5)]
        public int? Tube0_1 { get; set; }
        [Range(0.0D, 40.0D)]
        public double? Salinity { get; set; }
        [Range(-10.0D, 40.0D)]
        public double? Temperature { get; set; }
        [StringLength(10)]
        [CSSPAllowNull]
        public string ProcessedBy { get; set; }
        [CSSPEnumType]
        public SampleTypeEnum SampleType { get; set; }
        [StringLength(250)]
        [CSSPAllowNull]
        public string SiteComment { get; set; }
        #endregion Properties in DB

        #region Constructors
        public LabSheetTubeMPNDetail() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class LabSheetTubeMPNDetail_A : LabSheetTubeMPNDetail
    {
        #region Properties
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "MWQMSiteTVItemID", FillReturnField = "", FillNeedLanguage = true, FillIsList = false)]
        public TVItemLanguage MWQMSiteTVItemLanguage { get; set; }
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "", FillNeedLanguage = true, FillIsList = false)]
        [CSSPDisplayEN(DisplayEN = "Last update contact TVItemLanguage")]
        [CSSPDisplayFR(DisplayFR = "TVItemLanguage du contact ayant fait le dernière changement")]
        [CSSPDescriptionEN(DescriptionEN = @"Last update contact TVItemLanguage DB object")]
        [CSSPDescriptionFR(DescriptionFR = @"Object BD TVItemLanguage du contact ayant fait le dernière changement")]
        public TVItemLanguage LastUpdateContactTVItemLanguage { get; set; }
        [CSSPEnumTypeText(EnumTypeName = "SampleTypeEnum", EnumType = "SampleType")]
        [CSSPAllowNull]
        public string SampleTypeText { get; set; }
        #endregion Properties

        #region Constructors
        public LabSheetTubeMPNDetail_A() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class LabSheetTubeMPNDetail_B : LabSheetTubeMPNDetail_A
    {
        #region Properties
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "TVText", FillNeedLanguage = true, FillIsList = false)]
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "Report test")]
        [CSSPDisplayFR(DisplayFR = "Test report")]
        [CSSPDescriptionEN(DescriptionEN = @"Report test description")]
        [CSSPDescriptionFR(DescriptionFR = @"Description de test report")]
        public string LabSheetTubeMPNDetailReportTest { get; set; }
        #endregion Properties

        #region Constructors
        public LabSheetTubeMPNDetail_B() : base()
        {
        }
        #endregion Constructors
    }
}
