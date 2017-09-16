using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    public partial class Contact
    {
        #region Properties in DB
        [Key]
        public int ContactID { get; set; }
        [StringLength(128)]
        public string Id { get; set; }
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "5")]
        public int ContactTVItemID { get; set; }
        [StringLength(255, MinimumLength = 6)]
        [DataType(DataType.EmailAddress)]
        public string LoginEmail { get; set; }
        [StringLength(100)]
        public string FirstName { get; set; }
        [StringLength(100)]
        public string LastName { get; set; }
        [StringLength(50)]
        [CSSPAllowNull]
        public string Initial { get; set; }
        [StringLength(100)]
        public string WebName { get; set; }
        [CSSPEnumType]
        [CSSPAllowNull]
        public ContactTitleEnum? ContactTitle { get; set; }
        public bool IsAdmin { get; set; }
        public bool EmailValidated { get; set; }
        public bool Disabled { get; set; }
        public bool IsNew { get; set; }
        [StringLength(200)]
        [CSSPAllowNull]
        public string SamplingPlanner_ProvincesTVItemID { get; set; }
        [CSSPAfter(Year = 1980)]
        public DateTime LastUpdateDate_UTC { get; set; }
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "5")]
        public int LastUpdateContactTVItemID { get; set; }
        #endregion Properties in DB

        #region Properties not in DB
        [NotMapped]
        [StringLength(200)]
        [CSSPAllowNull]
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "ContactTVItemID", FillReturnField = "TVText", FillNeedLanguage = true)]
        public string ContactTVText { get; set; }
        [NotMapped]
        [StringLength(200)]
        [CSSPAllowNull]
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "TVText", FillNeedLanguage = true)]
        public string LastUpdateContactTVText { get; set; }
        [NotMapped]
        [Range(1, -1)]
        public int ParentTVItemID { get; set; }
        [NotMapped]
        [StringLength(100)]
        [CSSPAllowNull]
        [CSSPEnumTypeText(EnumTypeName = "ContactTitleEnum", EnumType = "ContactTitle")]
        public string ContactTitleText { get; set; }
        [NotMapped]
        public bool HasErrors { get; set; }
        [NotMapped]
        public IEnumerable<ValidationResult> ValidationResults { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public Contact()
        {
            ValidationResults = new List<ValidationResult>();
        }
        #endregion Constructors
    }
}
