/*
 * Auto generated from the CSSPCodeWriter.proj by clicking on the [\srcWithDoc\[ModelClassName]Generated.cs] button
 *
 * Do not edit this file.
 *
 * Last generated by Charles on CHARLES-PC machine
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
    /// > <para>**DB properties for table ContactPreferences** : [ContactPreferenceID](CSSPModels.ContactPreference.html#CSSPModels_ContactPreference_ContactPreferenceID), [ContactID](CSSPModels.ContactPreference.html#CSSPModels_ContactPreference_ContactID), [TVType](CSSPModels.ContactPreference.html#CSSPModels_ContactPreference_TVType), [MarkerSize](CSSPModels.ContactPreference.html#CSSPModels_ContactPreference_MarkerSize), [LastUpdateDate_UTC](CSSPModels.ContactPreference.html#CSSPModels_ContactPreference_LastUpdateDate_UTC), [LastUpdateContactTVItemID](CSSPModels.ContactPreference.html#CSSPModels_ContactPreference_LastUpdateContactTVItemID), </para>
    /// > <para>**Other properties** : [HasErrors](CSSPModels.ContactPreference.html#CSSPModels_ContactPreference_HasErrors), [ValidationResults](CSSPModels.ContactPreference.html#CSSPModels_ContactPreference_ValidationResults), </para>
    /// > 
    /// > <para>**Used by [CSSPServices](CSSPServices.html)** : [ContactPreferenceService](CSSPServices.ContactPreferenceService.html)</para>
    /// > <para>**Requires [CSSPEnums](CSSPEnums.html)** : [TVTypeEnum](CSSPEnums.TVTypeEnum.html)</para>
    /// > <para>**Return to [CSSPModels](CSSPModels.html)**</para>
    /// </summary>
    public partial class ContactPreference : LastUpdate
    {
        #region Properties in DB
        [Key]
        [CSSPDisplayEN(DisplayEN = "ContactPreference ID")]
        [CSSPDisplayFR(DisplayFR = "ContactPreference ID")]
        [CSSPDescriptionEN(DescriptionEN = @"Contains the unique ""identifier on each row of the ContactPreferences table")]
        [CSSPDescriptionFR(DescriptionFR = @"Contient l'identifiant unique sur chaque ligne du tableau ContactPreferences")]
        public int ContactPreferenceID { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPExist](CSSPModels.CSSPExistAttribute.html)(ExistTypeName = "Contact", ExistPlurial = "s", ExistFieldID = "ContactID")]</para>
        /// </summary>
        [CSSPExist(ExistTypeName = "Contact", ExistPlurial = "s", ExistFieldID = "ContactID")]
        public int ContactID { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPEnumType](CSSPModels.CSSPEnumTypeAttribute.html)]</para>
        /// </summary>
        [CSSPEnumType]
        public TVTypeEnum TVType { get; set; }
        [Range(1, 1000)]
        public int MarkerSize { get; set; }
        #endregion Properties in DB

        #region Constructors
        public ContactPreference() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class ContactPreferenceWeb : ContactPreference
    {
        #region Properties for web information
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPFill](CSSPModels.CSSPFillAttribute.html)(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "", FillNeedLanguage = true)]</para>
        /// </summary>
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "", FillNeedLanguage = true)]
        public TVItemLanguage LastUpdateContactTVItemLanguage { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPEnumTypeText](CSSPModels.CSSPEnumTypeTextAttribute.html)(EnumTypeName = "TVTypeEnum", EnumType = "TVType")]</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        [CSSPEnumTypeText(EnumTypeName = "TVTypeEnum", EnumType = "TVType")]
        [CSSPAllowNull]
        public string TVTypeText { get; set; }
        #endregion Properties for web information

        #region Constructors
        public ContactPreferenceWeb() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class ContactPreferenceReport : ContactPreferenceWeb
    {
        #region Properties for report information
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        [CSSPAllowNull]
        public string ContactPreferenceReportTest { get; set; }
        #endregion Properties for report information

        #region Constructors
        public ContactPreferenceReport() : base()
        {
        }
        #endregion Constructors
    }
}
