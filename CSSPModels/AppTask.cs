using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    public partial class AppTask
    {
        #region Properties in DB
        public int AppTaskID { get; set; }
        public int TVItemID { get; set; }
        public int TVItemID2 { get; set; }
        public AppTaskCommandEnum Command { get; set; }
        public AppTaskStatusEnum Status { get; set; }
        public int PercentCompleted { get; set; }
        public string Parameters { get; set; }
        public LanguageEnum Language { get; set; }
        public DateTime StartDateTime_UTC { get; set; }
        public DateTime? EndDateTime_UTC { get; set; }
        public int? EstimatedLength_second { get; set; }
        public int? RemainingTime_second { get; set; }
        public DateTime LastUpdateDate_UTC { get; set; }
        public int LastUpdateContactTVItemID { get; set; }

        public virtual ICollection<AppTaskLanguage> AppTaskLanguages { get; set; }
        public virtual TVItem TVItemIDNavigation { get; set; }
        public virtual TVItem TVItemID2Navigation { get; set; }
        #endregion Properties in DB

        #region Properties not in DB
        [NotMapped]
        public IEnumerable<ValidationResult> ValidationResults { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public AppTask()
        {
            AppTaskLanguages = new HashSet<AppTaskLanguage>();
        }
        #endregion Constructors


    }
}
