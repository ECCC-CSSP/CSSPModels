using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    public partial class LabSheetTubeMPNDetail
    {
        #region Properties in DB
        [Key]
        public int LabSheetTubeMPNDetailID { get; set; }
        [Range(1, -1)]
        [CSSPExist(TypeName = "LabSheetDetail", Plurial = "s", FieldID = "LabSheetDetailID")]
        public int LabSheetDetailID { get; set; }
        [Range(0, 1000)]
        public int Ordinal { get; set; }
        [Range(1, -1)]
        [CSSPExist(TypeName = "TVItem", Plurial = "s", FieldID = "TVItemID", TVType = TVTypeEnum.MWQMSite)]
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
        [CSSPAfter(Year = 1980)]
        public DateTime LastUpdateDate_UTC { get; set; }
        [Range(1, -1)]
        [CSSPExist(TypeName = "TVItem", Plurial = "s", FieldID = "TVItemID", TVType = TVTypeEnum.Contact)]
        public int LastUpdateContactTVItemID { get; set; }

        public virtual LabSheetDetail LabSheetDetail { get; set; }
        public virtual TVItem MWQMSiteTVItem { get; set; }
        #endregion Properties in DB

        #region Properties not in DB
        [NotMapped]
        public IEnumerable<ValidationResult> ValidationResults { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public LabSheetTubeMPNDetail()
        {
            // empty for now
        }
        #endregion Constructors
    }
}
