//using CSSPEnums;
//using System;
//using System.Collections.Generic;
//using System.ComponentModel.DataAnnotations;
//using System.ComponentModel.DataAnnotations.Schema;

//namespace CSSPModels
//{
//    public partial class ContactLogin : LastUpdate
//    {
//        #region Properties in DB
//        [Key]
//        public int ContactLoginID { get; set; }
//        [CSSPExist(ExistTypeName = "Contact", ExistPlurial = "s", ExistFieldID = "ContactID")]
//        public int ContactID { get; set; }
//        [StringLength(200)]
//        [DataType(DataType.EmailAddress)]
//        public string LoginEmail { get; set; }
//        public byte[] PasswordHash { get; set; }
//        public byte[] PasswordSalt { get; set; }
//        #endregion Properties in DB

//        #region Properties not in DB
//        [NotMapped]
//        [CSSPAllowNull]
//        public ContactLoginWeb ContactLoginWeb { get; set; }
//        [NotMapped]
//        [CSSPAllowNull]
//        public ContactLoginReport ContactLoginReport { get; set; }
//        #endregion Properties not in DB

//        #region Constructors
//        public ContactLogin() : base()
//        {
//        }
//        #endregion Constructors
//    }
//    [NotMapped]
//    public partial class ContactLoginWeb
//    {
//        #region Properties for web information
//        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "TVText", FillNeedLanguage = true)]
//        [CSSPAllowNull]
//        public string LastUpdateContactTVText { get; set; }
//        [CSSPAllowNull]
//        public string Password { get; set; }
//        [CSSPAllowNull]
//        public string ConfirmPassword { get; set; }
//        #endregion Properties for web information

//        #region Constructors
//        public ContactLoginWeb()
//        {
//        }
//        #endregion Constructors
//    }
//    [NotMapped]
//    public partial class ContactLoginReport
//    {
//        #region Properties for report information
//        [CSSPAllowNull]
//        public string ContactLoginReportTest { get; set; }
//        #endregion Properties for report information

//        #region Constructors
//        public ContactLoginReport()
//        {
//        }
//        #endregion Constructors
//    }
//}
