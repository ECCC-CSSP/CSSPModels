using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    public partial class MWQMSite
    {
        #region Properties in DB
        [Key]
        public int MWQMSiteID { get; set; }
        [Range(1, -1)]
        [CSSPExist(TypeName = "TVItem", Plurial = "s", FieldID = "TVItemID")]
        public int MWQMSiteTVItemID { get; set; }
        [StringLength(8)]
        public string MWQMSiteNumber { get; set; }
        [StringLength(200)]
        public string MWQMSiteDescription { get; set; }
        [CSSPEnumType]
        public MWQMSiteLatestClassificationEnum MWQMSiteLatestClassification { get; set; }
        [Range(0, 1000)]
        public int Ordinal { get; set; }
        [CSSPAfter(Year = 1980)]
        public DateTime LastUpdateDate_UTC { get; set; }
        [Range(1, -1)]
        [CSSPExist(TypeName = "TVItem", Plurial = "s", FieldID = "TVItemID")]
        public int LastUpdateContactTVItemID { get; set; }

        public virtual TVItem MWQMSiteTVItem { get; set; }
        #endregion Properties in DB

        #region Properties not in DB
        [NotMapped]
        public IEnumerable<ValidationResult> ValidationResults { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public MWQMSite()
        {
            // empty for now
        }
        #endregion Constructors
    }
}
