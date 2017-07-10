using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    public partial class BoxModel
    {
        #region Properties in DB
        [Key]
        public int BoxModelID { get; set; }
        [Range(1, -1)]
        [CSSPExist(TypeName = "TVItem", Plurial = "s", FieldID = "TVItemID")]
        public int InfrastructureTVItemID { get; set; }
        [Range(0.0f, 10000.0f)]
        public float Flow_m3_day { get; set; }
        [Range(0.0f, 1000.0f)]
        public float Depth_m { get; set; }
        [Range(-15.0f, 40.0f)]
        public float Temperature_C { get; set; }
        [Range(0.0f, 10000000.0f)]
        public float Dilution { get; set; }
        [Range(0.0f, 100.0f)]
        public float DecayRate_per_day { get; set; }
        [Range(0, 10000000)]
        public int FCUntreated_MPN_100ml { get; set; }
        [Range(0, 10000000)]
        public int FCPreDisinfection_MPN_100ml { get; set; }
        [Range(0, 10000000)]
        public int Concentration_MPN_100ml { get; set; }
        [Range(0.0f, -1.0f)]
        public float T90_hour { get; set; }
        [Range(0.0f, 24.0f)]
        public float FlowDuration_hour { get; set; }
        [CSSPAfter(Year = 1980)]
        public DateTime LastUpdateDate_UTC { get; set; }
        [Range(1, -1)]
        [CSSPExist(TypeName = "TVItem", Plurial = "s", FieldID = "TVItemID")]
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
