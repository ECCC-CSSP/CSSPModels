using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    public partial class PolSourceObservation
    {
        #region Properties in DB
        public int PolSourceObservationID { get; set; }
        public int PolSourceSiteTVItemID { get; set; }
        public DateTime ObservationDate_Local { get; set; }
        public int ContactTVItemID { get; set; }
        public string Observation_ToBeDeleted { get; set; }
        public DateTime LastUpdateDate_UTC { get; set; }
        public int LastUpdateContactTVItemID { get; set; }

        public virtual ICollection<PolSourceObservationIssue> PolSourceObservationIssues { get; set; }
        public virtual TVItem ContactTVItem { get; set; }
        public virtual TVItem PolSourceSiteTVItem { get; set; }
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
