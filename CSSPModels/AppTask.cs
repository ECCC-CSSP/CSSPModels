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
        [Key]
        public int AppTaskID { get; set; }
        [Range(1, -1)]
        [CSSPExist(TypeName = "TVItem", Plurial = "s", FieldID = "TVItemID")]
        public int TVItemID { get; set; }
        [Range(1, -1)]
        [CSSPExist(TypeName = "TVItem", Plurial = "s", FieldID = "TVItemID")]
        public int TVItemID2 { get; set; }
        [CSSPEnumType]
        public AppTaskCommandEnum AppTaskCommand { get; set; }
        [CSSPEnumType]
        public AppTaskStatusEnum AppTaskStatus { get; set; }
        [Range(0, 100)]
        public int PercentCompleted { get; set; }
        public string Parameters { get; set; }
        [CSSPEnumType]
        public LanguageEnum Language { get; set; }
        [CSSPAfter(Year = 1980)]
        public DateTime StartDateTime_UTC { get; set; }
        [CSSPAfter(Year = 1980)]
        [CSSPBigger(OtherField = "StartDateTime_UTC")]
        public DateTime? EndDateTime_UTC { get; set; }
        [Range(0, 1000000)]
        public int? EstimatedLength_second { get; set; }
        [Range(0, 1000000)]
        public int? RemainingTime_second { get; set; }
        [CSSPAfter(Year = 1980)]
        public DateTime LastUpdateDate_UTC { get; set; }
        [CSSPExist(TypeName = "TVItem", Plurial = "s", FieldID = "TVItemID")]
        [Range(1, -1)]
        public int LastUpdateContactTVItemID { get; set; }

        public virtual ICollection<AppTaskLanguage> AppTaskLanguages { get; set; }
        public virtual TVItem TVItem { get; set; }
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
