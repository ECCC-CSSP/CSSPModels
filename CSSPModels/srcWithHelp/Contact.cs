using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    public partial class Contact : LastUpdate
    {
        #region Properties in DB
        [Key]
        public int ContactID { get; set; }
        [CSSPExist(ExistTypeName = "AspNetUser", ExistPlurial = "s", ExistFieldID = "Id")]
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
        #endregion Properties in DB

        #region Properties not in DB
        [NotMapped]
        [CSSPAllowNull]
        public ContactWeb ContactWeb { get; set; }
        [NotMapped]
        [CSSPAllowNull]
        public ContactReport ContactReport { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public Contact() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class ContactWeb
    {
        #region Properties for web information
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "ContactTVItemID", FillReturnField = "TVText", FillNeedLanguage = true)]
        [CSSPAllowNull]
        public string ContactTVText { get; set; }
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "TVText", FillNeedLanguage = true)]
        [CSSPAllowNull]
        public string LastUpdateContactTVText { get; set; }
        [CSSPFill(FillTypeName = "TVItem", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "ContactTVItemID", FillReturnField = "ParentID", FillNeedLanguage = false)]
        public int ParentTVItemID { get; set; }
        [CSSPEnumTypeText(EnumTypeName = "ContactTitleEnum", EnumType = "ContactTitle")]
        [CSSPAllowNull]
        public string ContactTitleText { get; set; }
        #endregion Properties for web information

        #region Constructors
        public ContactWeb()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class ContactReport
    {
        #region Properties for report information
        [CSSPAllowNull]
        public string ContactReportTest { get; set; }
        #endregion Properties for report information

        #region Constructors
        public ContactReport()
        {
        }
        #endregion Constructors
    }
}
