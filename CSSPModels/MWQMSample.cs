using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    public partial class MWQMSample
    {
        #region Properties in DB
        public int MWQMSampleID { get; set; }
        public int MWQMSiteTVItemID { get; set; }
        public int MWQMRunTVItemID { get; set; }
        public DateTime SampleDateTime_Local { get; set; }
        public float? Depth_m { get; set; }
        public int FecCol_MPN_100ml { get; set; }
        public float? Salinity_PPT { get; set; }
        public float? WaterTemp_C { get; set; }
        public float? PH { get; set; }
        public string SampleTypesText { get; set; }
        public SampleTypeEnum SampleType_old { get; set; }
        public int? Tube_10 { get; set; }
        public int? Tube_1_0 { get; set; }
        public int? Tube_0_1 { get; set; }
        public string ProcessedBy { get; set; }
        public DateTime LastUpdateDate_UTC { get; set; }
        public int LastUpdateContactTVItemID { get; set; }

        public virtual ICollection<MWQMSampleLanguage> MWQMSampleLanguages { get; set; }
        public virtual TVItem MWQMRunTVItem { get; set; }
        public virtual TVItem MWQMSiteTVItem { get; set; }
        #endregion Properties in DB

        #region Properties not in DB
        [NotMapped]
        public IEnumerable<ValidationResult> ValidationResults { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public MWQMSample()
        {
            MWQMSampleLanguages = new HashSet<MWQMSampleLanguage>();
        }
        #endregion Constructors

    }
}
