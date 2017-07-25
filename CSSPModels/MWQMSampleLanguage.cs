using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    public partial class MWQMSampleLanguage
    {
        #region Properties in DB
        [Key]
        public int MWQMSampleLanguageID { get; set; }
        [Range(1, -1)]
        [CSSPExist(TypeName = "MWQMSample", Plurial = "s", FieldID = "MWQMSampleID")]
        public int MWQMSampleID { get; set; }
        [CSSPEnumType]
        public LanguageEnum Language { get; set; }
        public string MWQMSampleNote { get; set; }
        [CSSPEnumType]
        public TranslationStatusEnum TranslationStatus { get; set; }
        [CSSPAfter(Year = 1980)]
        public DateTime LastUpdateDate_UTC { get; set; }
        [Range(1, -1)]
        [CSSPExist(TypeName = "TVItem", Plurial = "s", FieldID = "TVItemID", TVType = TVTypeEnum.Contact)]
        public int LastUpdateContactTVItemID { get; set; }

        public virtual MWQMSample MWQMSample { get; set; }
        #endregion Properties in DB

        #region Properties not in DB
        [NotMapped]
        public IEnumerable<ValidationResult> ValidationResults { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public MWQMSampleLanguage()
        {
            // empty for now
        }
        #endregion Constructors
    }
}
