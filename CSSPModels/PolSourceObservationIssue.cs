using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    public partial class PolSourceObservationIssue
    {
        #region Properties in DB
        public int PolSourceObservationIssueID { get; set; }
        public int PolSourceObservationID { get; set; }
        public string ObservationInfo { get; set; }
        public int Ordinal { get; set; }
        public DateTime LastUpdateDate_UTC { get; set; }
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
