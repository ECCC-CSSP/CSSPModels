using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    public partial class PolSourceObservation
    {
        #region Properties in DB
        [Key]
        public int PolSourceObservationID { get; set; }
        [Range(1, -1)]
        [CSSPExist(TypeName = "PolSourceSite", Plurial = "s", FieldID = "PolSourceSiteID")]
        public int PolSourceSiteID { get; set; }
        [CSSPAfter(Year = 1980)]
        public DateTime ObservationDate_Local { get; set; }
        [Range(1, -1)]
        [CSSPExist(TypeName = "TVItem", Plurial = "s", FieldID = "TVItemID", TVType = TVTypeEnum.Contact)]
        public int ContactTVItemID { get; set; }
        public string Observation_ToBeDeleted { get; set; }
        [CSSPAfter(Year = 1980)]
        public DateTime LastUpdateDate_UTC { get; set; }
        [Range(1, -1)]
        [CSSPExist(TypeName = "TVItem", Plurial = "s", FieldID = "TVItemID", TVType = TVTypeEnum.Contact)]
        public int LastUpdateContactTVItemID { get; set; }

        public virtual ICollection<PolSourceObservationIssue> PolSourceObservationIssues { get; set; }
        public virtual TVItem ContactTVItem { get; set; }
        public virtual PolSourceSite PolSourceSite { get; set; }
        #endregion Properties in DB

        #region Properties not in DB
        [NotMapped]
        public IEnumerable<ValidationResult> ValidationResults { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public PolSourceObservation()
        {
            PolSourceObservationIssues = new HashSet<PolSourceObservationIssue>();
        }
        #endregion Constructors

    }
}
