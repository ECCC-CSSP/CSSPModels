using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    public partial class BoxModel
    {
        #region Properties in DB
        public int BoxModelID { get; set; }
        public int InfrastructureTVItemID { get; set; }
        public float Flow_m3_day { get; set; }
        public float Depth_m { get; set; }
        public float Temperature_C { get; set; }
        public float Dilution { get; set; }
        public float DecayRate_per_day { get; set; }
        public int FCUntreated_MPN_100ml { get; set; }
        public int FCPreDisinfection_MPN_100ml { get; set; }
        public int Concentration_MPN_100ml { get; set; }
        public float T90_hour { get; set; }
        public float FlowDuration_hour { get; set; }
        public DateTime LastUpdateDate_UTC { get; set; }
        public int LastUpdateContactTVItemID { get; set; }

        public virtual ICollection<BoxModelLanguage> BoxModelLanguages { get; set; }
        public virtual ICollection<BoxModelResult> BoxModelResults { get; set; }
        public virtual TVItem InfrastructureTVItem { get; set; }
        #endregion Properties in DB

        #region Properties not in DB
        [NotMapped]
        public IEnumerable<ValidationResult> ValidationResults { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public BoxModel()
        {
            BoxModelLanguages = new HashSet<BoxModelLanguage>();
            BoxModelResults = new HashSet<BoxModelResult>();

        }
        #endregion Constructors
    }
}
