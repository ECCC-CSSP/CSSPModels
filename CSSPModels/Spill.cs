using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    public partial class Spill
    {
        #region Properties in DB
        public int SpillID { get; set; }
        public int MunicipalityTVItemID { get; set; }
        public int? InfrastructureTVItemID { get; set; }
        public DateTime StartDateTime_Local { get; set; }
        public DateTime? EndDateTime_Local { get; set; }
        public float AverageFlow_m3_day { get; set; }
        public DateTime LastUpdateDate_UTC { get; set; }
        public int LastUpdateContactTVItemID { get; set; }

        public virtual ICollection<SpillLanguage> SpillLanguages { get; set; }
        public virtual TVItem InfrastructureTVItem { get; set; }
        public virtual TVItem MunicipalityTVItem { get; set; }
        #endregion Properties in DB

        #region Properties not in DB
        [NotMapped]
        public IEnumerable<ValidationResult> ValidationResults { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public Spill()
        {
            SpillLanguages = new HashSet<SpillLanguage>();
        }
        #endregion Constructors

    }
}
