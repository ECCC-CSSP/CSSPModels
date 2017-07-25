using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    public partial class InfrastructureLanguage
    {
        #region Properties in DB
        [Key]
        public int InfrastructureLanguageID { get; set; }
        [Range(1, -1)]
        [CSSPExist(TypeName = "Infrastructure", Plurial = "s", FieldID = "InfrastructureID")]
        public int InfrastructureID { get; set; }
        [CSSPEnumType]
        public LanguageEnum Language { get; set; }
        public string Comment { get; set; }
        [CSSPEnumType]
        public TranslationStatusEnum TranslationStatus { get; set; }
        [CSSPAfter(Year = 1980)]
        public DateTime LastUpdateDate_UTC { get; set; }
        [Range(1, -1)]
        [CSSPExist(TypeName = "TVItem", Plurial = "s", FieldID = "TVItemID", TVType = TVTypeEnum.Contact)]
        public int LastUpdateContactTVItemID { get; set; }

        public virtual Infrastructure Infrastructure { get; set; }
        #endregion Properties in DB

        #region Properties not in DB
        [NotMapped]
        public IEnumerable<ValidationResult> ValidationResults { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public InfrastructureLanguage()
        {
            // empty for now
        }
        #endregion Constructors
    }
}
