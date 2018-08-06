/*
 * Manually edited by Charles LeBlanc 
 * 
 */
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
        [CSSPDisplayEN(DisplayEN = "Contact ID")]
        [CSSPDisplayFR(DisplayFR = "Contact ID")]
        [CSSPDescriptionEN(DescriptionEN = @"Contains the unique ""identifier on each row of the Contacts table")]
        [CSSPDescriptionFR(DescriptionFR = @"Contient l'identifiant unique sur chaque ligne de la table Contacts")]
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

        #region Constructors
        public Contact() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class ContactWeb : Contact
    {
        #region Properties for web information
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "ContactTVItemID", FillReturnField = "", FillNeedLanguage = true)]
        public TVItemLanguage ContactTVItemLanguage { get; set; }
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "", FillNeedLanguage = true)]
        [CSSPDisplayEN(DisplayEN = "Last update contact TVItemLanguage")]
        [CSSPDisplayFR(DisplayFR = "TVItemLanguage du contact ayant fait le dernière changement")]
        [CSSPDescriptionEN(DescriptionEN = @"Last update contact TVItemLanguage DB object")]
        [CSSPDescriptionFR(DescriptionFR = @"Object BD TVItemLanguage du contact ayant fait le dernière changement")]
        public TVItemLanguage LastUpdateContactTVItemLanguage { get; set; }
        [CSSPFill(FillTypeName = "TVItem", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "ContactTVItemID", FillReturnField = "ParentID", FillNeedLanguage = false)]
        public int ParentTVItemID { get; set; }
        [CSSPEnumTypeText(EnumTypeName = "ContactTitleEnum", EnumType = "ContactTitle")]
        [CSSPAllowNull]
        public string ContactTitleText { get; set; }
        #endregion Properties for web information

        #region Constructors
        public ContactWeb() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class ContactReport : ContactWeb
    {
        #region Properties for report information
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "Report test")]
        [CSSPDisplayFR(DisplayFR = "Test report")]
        [CSSPDescriptionEN(DescriptionEN = @"Report test description")]
        [CSSPDescriptionFR(DescriptionFR = @"Description de test report")]
        public string ContactReportTest { get; set; }
        #endregion Properties for report information

        #region Constructors
        public ContactReport() : base()
        {
        }
        #endregion Constructors
    }
}
