using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    public partial class PolSourceSite
    {
        #region Properties in DB
        [Key]
        public int PolSourceSiteID { get; set; }
        [CSSPExist(TypeName = "TVItem", Plurial = "s", FieldID = "TVItemID", TVType = TVTypeEnum.PolSourceSite)]
        public int PolSourceSiteTVItemID { get; set; }
        [StringLength(50)]
        [CSSPAllowNull]
        public string Temp_Locator_CanDelete { get; set; }
        [Range(0, 1000)]
        public int? Oldsiteid { get; set; }
        [Range(0, 1000)]
        public int? Site { get; set; }
        [Range(0, 1000)]
        public int? SiteID { get; set; }
        public bool IsPointSource { get; set; }
        [CSSPEnumType]
        [CSSPAllowNull]
        public PolSourceInactiveReasonEnum? InactiveReason { get; set; }
        [CSSPExist(TypeName = "TVItem", Plurial = "s", FieldID = "TVItemID", TVType = TVTypeEnum.Address)]
        public int? CivicAddressTVItemID { get; set; }
        [CSSPAfter(Year = 1980)]
        public DateTime LastUpdateDate_UTC { get; set; }
        [CSSPExist(TypeName = "TVItem", Plurial = "s", FieldID = "TVItemID", TVType = TVTypeEnum.Contact)]
        public int LastUpdateContactTVItemID { get; set; }


        public virtual ICollection<PolSourceObservation> PolSourceObservations { get; set; }
        public virtual TVItem PolSourceSiteTVItem { get; set; }
        #endregion Properties in DB

        #region Properties not in DB
        [NotMapped]
        public IEnumerable<ValidationResult> ValidationResults { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public PolSourceSite()
        {
            // empty for now
        }
        #endregion Constructors
    }
}
