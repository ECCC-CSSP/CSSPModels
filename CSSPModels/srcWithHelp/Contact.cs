/*
 * Auto generated from the CSSPModelsGenerateCode.proj by clicking on the [Generate Models With Help] button
 *
 * Do not edit this file.
 *
 * Last generated by Charles LeBlanc
 *
 */
using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    /// <summary>
    /// > [!NOTE]
    /// > 
    /// > <para>**DB properties for table Contacts** : [ContactID](CSSPModels.Contact.html#CSSPModels_Contact_ContactID), [Id](CSSPModels.Contact.html#CSSPModels_Contact_Id), [ContactTVItemID](CSSPModels.Contact.html#CSSPModels_Contact_ContactTVItemID), [LoginEmail](CSSPModels.Contact.html#CSSPModels_Contact_LoginEmail), [FirstName](CSSPModels.Contact.html#CSSPModels_Contact_FirstName), [LastName](CSSPModels.Contact.html#CSSPModels_Contact_LastName), [Initial](CSSPModels.Contact.html#CSSPModels_Contact_Initial), [WebName](CSSPModels.Contact.html#CSSPModels_Contact_WebName), [ContactTitle](CSSPModels.Contact.html#CSSPModels_Contact_ContactTitle), [IsAdmin](CSSPModels.Contact.html#CSSPModels_Contact_IsAdmin), [EmailValidated](CSSPModels.Contact.html#CSSPModels_Contact_EmailValidated), [Disabled](CSSPModels.Contact.html#CSSPModels_Contact_Disabled), [IsNew](CSSPModels.Contact.html#CSSPModels_Contact_IsNew), [SamplingPlanner_ProvincesTVItemID](CSSPModels.Contact.html#CSSPModels_Contact_SamplingPlanner_ProvincesTVItemID), [LastUpdateDate_UTC](CSSPModels.Contact.html#CSSPModels_Contact_LastUpdateDate_UTC), [LastUpdateContactTVItemID](CSSPModels.Contact.html#CSSPModels_Contact_LastUpdateContactTVItemID), </para>
    /// > <para>**Other properties** : [ContactTVText](CSSPModels.Contact.html#CSSPModels_Contact_ContactTVText), [LastUpdateContactTVText](CSSPModels.Contact.html#CSSPModels_Contact_LastUpdateContactTVText), [ParentTVItemID](CSSPModels.Contact.html#CSSPModels_Contact_ParentTVItemID), [ContactTitleText](CSSPModels.Contact.html#CSSPModels_Contact_ContactTitleText), [HasErrors](CSSPModels.Contact.html#CSSPModels_Contact_HasErrors), [ValidationResults](CSSPModels.Contact.html#CSSPModels_Contact_ValidationResults), </para>
    /// > 
    /// > <para>**Used by [CSSPServices](CSSPServices.html)** : [ContactService](CSSPServices.ContactService.html)</para>
    /// > <para>**Requires [CSSPEnums](CSSPEnums.html)** : [ContactTitleEnum](CSSPEnums.ContactTitleEnum.html)</para>
    /// > <para>**Return to [CSSPModels](CSSPModels.html)**</para>
    /// </summary>
    public partial class Contact
    {
        #region Properties in DB
        [Key]
        public int ContactID { get; set; }
        [StringLength(128)]
        public string Id { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>**AllowableTVTypeList is of type [CSSPEnums.TVTypeEnum](CSSPEnums.TVTypeEnum.html)**</para>
        /// > <para>5 == Contact</para>
        /// > <para>[[CSSPExist](CSSPModels.CSSPExistAttribute.html)(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "5")]</para>
        /// </summary>
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "5")]
        public int ContactTVItemID { get; set; }
        [StringLength(255, MinimumLength = 6)]
        [DataType(DataType.EmailAddress)]
        public string LoginEmail { get; set; }
        [StringLength(100)]
        public string FirstName { get; set; }
        [StringLength(100)]
        public string LastName { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        [StringLength(50)]
        [CSSPAllowNull]
        public string Initial { get; set; }
        [StringLength(100)]
        public string WebName { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPEnumType](CSSPModels.CSSPEnumTypeAttribute.html)]</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        [CSSPEnumType]
        [CSSPAllowNull]
        public ContactTitleEnum? ContactTitle { get; set; }
        public bool IsAdmin { get; set; }
        public bool EmailValidated { get; set; }
        public bool Disabled { get; set; }
        public bool IsNew { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        [StringLength(200)]
        [CSSPAllowNull]
        public string SamplingPlanner_ProvincesTVItemID { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPAfter](CSSPModels.CSSPAfterAttribute.html)(Year = 1980)]</para>
        /// </summary>
        [CSSPAfter(Year = 1980)]
        public DateTime LastUpdateDate_UTC { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>**AllowableTVTypeList is of type [CSSPEnums.TVTypeEnum](CSSPEnums.TVTypeEnum.html)**</para>
        /// > <para>5 == Contact</para>
        /// > <para>[[CSSPExist](CSSPModels.CSSPExistAttribute.html)(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "5")]</para>
        /// </summary>
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "5")]
        public int LastUpdateContactTVItemID { get; set; }
        #endregion Properties in DB

        #region Properties not in DB
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// > <para>[[CSSPFill](CSSPModels.CSSPFillAttribute.html)(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "ContactTVItemID", FillReturnField = "TVText", FillNeedLanguage = true)]</para>
        /// </summary>
        [NotMapped]
        [StringLength(200)]
        [CSSPAllowNull]
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "ContactTVItemID", FillReturnField = "TVText", FillNeedLanguage = true)]
        public string ContactTVText { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// > <para>[[CSSPFill](CSSPModels.CSSPFillAttribute.html)(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "TVText", FillNeedLanguage = true)]</para>
        /// </summary>
        [NotMapped]
        [StringLength(200)]
        [CSSPAllowNull]
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "TVText", FillNeedLanguage = true)]
        public string LastUpdateContactTVText { get; set; }
        [NotMapped]
        [Range(1, -1)]
        public int ParentTVItemID { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// > <para>[[CSSPEnumTypeText](CSSPModels.CSSPEnumTypeTextAttribute.html)(EnumTypeName = "ContactTitleEnum", EnumType = "ContactTitle")]</para>
        /// </summary>
        [NotMapped]
        [StringLength(100)]
        [CSSPAllowNull]
        [CSSPEnumTypeText(EnumTypeName = "ContactTitleEnum", EnumType = "ContactTitle")]
        public string ContactTitleText { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>Will be set to true if an error occurs during CRUD (Creating, Reading, Updating or Deleting) of [Contact](CSSPModels.Contact)</para>
        /// </summary>
        [NotMapped]
        public bool HasErrors { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>Will hold all errors which were detected prior or during CRUD (Creating, Reading, Updating or Deleting) of [Contact](CSSPModels.Contact)</para>
        /// </summary>
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
