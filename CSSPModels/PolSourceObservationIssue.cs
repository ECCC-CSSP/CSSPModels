using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    public partial class PolSourceObservationIssue
    {
        #region Properties in DB
        [Key]
        public int PolSourceObservationIssueID { get; set; }
        [Range(1, -1)]
        [CSSPExist(TypeName = "PolSourceObservation", Plurial = "s", FieldID = "PolSourceObservationID")]
        public int PolSourceObservationID { get; set; }
        [StringLength(250)]
        public string ObservationInfo { get; set; }
        [Range(0, 1000)]
        public int Ordinal { get; set; }
        [CSSPAfter(Year = 1980)]
        public DateTime LastUpdateDate_UTC { get; set; }
        [Range(1, -1)]
        [CSSPExist(TypeName = "TVItem", Plurial = "s", FieldID = "TVItemID")]
        public int LastUpdateContactTVItemID { get; set; }

        public virtual PolSourceObservation PolSourceObservation { get; set; }
        #endregion Properties in DB

        #region Properties not in DB
        [NotMapped]
        public IEnumerable<ValidationResult> ValidationResults { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public PolSourceObservationIssue()
        {
            // empty for now
        }
        #endregion Constructors
    }
}
