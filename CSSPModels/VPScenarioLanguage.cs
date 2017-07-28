using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    public partial class VPScenarioLanguage
    {
        #region Properties in DB
        [Key]
        public int VPScenarioLanguageID { get; set; }
        [CSSPExist(TypeName = "VPScenario", Plurial = "s", FieldID = "VPScenarioID")]
        public int VPScenarioID { get; set; }
        [CSSPEnumType]
        public LanguageEnum Language { get; set; }
        [StringLength(100)]
        public string VPScenarioName { get; set; }
        [CSSPEnumType]
        public TranslationStatusEnum TranslationStatus { get; set; }
        [CSSPAfter(Year = 1980)]
        public DateTime LastUpdateDate_UTC { get; set; }
        [CSSPExist(TypeName = "TVItem", Plurial = "s", FieldID = "TVItemID", TVType = TVTypeEnum.Contact)]
        public int LastUpdateContactTVItemID { get; set; }

        public virtual VPScenario VPScenario { get; set; }
        #endregion Properties in DB

        #region Properties not in DB
        [NotMapped]
        public IEnumerable<ValidationResult> ValidationResults { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public VPScenarioLanguage()
        {
            // empty for now
        }
        #endregion Constructors
    }
}
