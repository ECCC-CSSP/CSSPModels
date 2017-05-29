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
        public int LabSheetTubeMPNDetailID { get; set; }
        public int LabSheetDetailID { get; set; }
        public int Ordinal { get; set; }
        public int MWQMSiteTVItemID { get; set; }
        public DateTime? SampleDateTime { get; set; }
        public int? MPN { get; set; }
        public int? Tube10 { get; set; }
        public int? Tube1_0 { get; set; }
        public int? Tube0_1 { get; set; }
        public float? Salinity { get; set; }
        public float? Temperature { get; set; }
        public string ProcessedBy { get; set; }
        public SampleTypeEnum SampleType { get; set; }
        public string SiteComment { get; set; }
        public DateTime LastUpdateDate_UTC { get; set; }
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
