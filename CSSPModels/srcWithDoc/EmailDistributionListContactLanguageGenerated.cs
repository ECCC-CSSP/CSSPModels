/*
 * Auto generated from the CSSPCodeWriter.proj by clicking on the [\srcWithDoc\[ModelClassName]Generated.cs] button
 *
 * Do not edit this file.
 *
 */ 
using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace CSSPModels
{
    /// <summary>
    /// > [!NOTE]
    /// > 
    /// > <para>**DB properties for table EmailDistributionListContactLanguages** : [EmailDistributionListContactLanguageID](CSSPModels.EmailDistributionListContactLanguage.html#CSSPModels_EmailDistributionListContactLanguage_EmailDistributionListContactLanguageID), [EmailDistributionListContactID](CSSPModels.EmailDistributionListContactLanguage.html#CSSPModels_EmailDistributionListContactLanguage_EmailDistributionListContactID), [Language](CSSPModels.EmailDistributionListContactLanguage.html#CSSPModels_EmailDistributionListContactLanguage_Language), [Agency](CSSPModels.EmailDistributionListContactLanguage.html#CSSPModels_EmailDistributionListContactLanguage_Agency), [TranslationStatus](CSSPModels.EmailDistributionListContactLanguage.html#CSSPModels_EmailDistributionListContactLanguage_TranslationStatus), [LastUpdateDate_UTC](CSSPModels.EmailDistributionListContactLanguage.html#CSSPModels_EmailDistributionListContactLanguage_LastUpdateDate_UTC), [LastUpdateContactTVItemID](CSSPModels.EmailDistributionListContactLanguage.html#CSSPModels_EmailDistributionListContactLanguage_LastUpdateContactTVItemID), </para>
    /// > <para>**Other properties** : [HasErrors](CSSPModels.EmailDistributionListContactLanguage.html#CSSPModels_EmailDistributionListContactLanguage_HasErrors), [ValidationResults](CSSPModels.EmailDistributionListContactLanguage.html#CSSPModels_EmailDistributionListContactLanguage_ValidationResults), </para>
    /// > 
    /// > <para>**Used by [CSSPServices](CSSPServices.html)** : [EmailDistributionListContactLanguageService](CSSPServices.EmailDistributionListContactLanguageService.html)</para>
    /// > <para>**Requires [CSSPEnums](CSSPEnums.html)** : [LanguageEnum](CSSPEnums.LanguageEnum.html), [TranslationStatusEnum](CSSPEnums.TranslationStatusEnum.html)</para>
    /// > <para>**Return to [CSSPModels](CSSPModels.html)**</para>
    /// </summary>
    public partial class EmailDistributionListContactLanguage : LastUpdate
    {
        #region Properties in DB
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "EmailDistributionListContactLanguage ID")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "EmailDistributionListContactLanguage ID")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Contains the unique "identifier on each row of the EmailDistributionListContactLanguages table")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Contient l'identifiant unique sur chaque ligne de la table EmailDistributionListContactLanguages")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- EmailDistributionListContactLanguage ID
        /// 
        /// **Display (fr)** --- EmailDistributionListContactLanguage ID
        /// 
        /// **Description (en)** --- Contains the unique "identifier on each row of the EmailDistributionListContactLanguages table
        /// 
        /// **Description (fr)** --- Contient l'identifiant unique sur chaque ligne de la table EmailDistributionListContactLanguages
        /// </returns>
        [Key]
        [CSSPDisplayEN(DisplayEN = "EmailDistributionListContactLanguage ID")]
        [CSSPDisplayFR(DisplayFR = "EmailDistributionListContactLanguage ID")]
        [CSSPDescriptionEN(DescriptionEN = @"Contains the unique ""identifier on each row of the EmailDistributionListContactLanguages table")]
        [CSSPDescriptionFR(DescriptionFR = @"Contient l'identifiant unique sur chaque ligne de la table EmailDistributionListContactLanguages")]
        public int EmailDistributionListContactLanguageID { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPExist](CSSPModels.CSSPExistAttribute.html)(ExistTypeName = "EmailDistributionListContact", ExistPlurial = "s", ExistFieldID = "EmailDistributionListContactID")]</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Email distribution list contact")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Liste de distribution des courriels contact")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Link to the EmailDistributionListContact table representing the email distribution list contact")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Lien à la table EmailDistributionListContact représentant la liste de distribution des courriels contact")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Email distribution list contact
        /// 
        /// **Display (fr)** --- Liste de distribution des courriels contact
        /// 
        /// **Description (en)** --- Link to the EmailDistributionListContact table representing the email distribution list contact
        /// 
        /// **Description (fr)** --- Lien à la table EmailDistributionListContact représentant la liste de distribution des courriels contact
        /// </returns>
        [CSSPExist(ExistTypeName = "EmailDistributionListContact", ExistPlurial = "s", ExistFieldID = "EmailDistributionListContactID")]
        [CSSPDisplayEN(DisplayEN = "Email distribution list contact")]
        [CSSPDisplayFR(DisplayFR = "Liste de distribution des courriels contact")]
        [CSSPDescriptionEN(DescriptionEN = @"Link to the EmailDistributionListContact table representing the email distribution list contact")]
        [CSSPDescriptionFR(DescriptionFR = @"Lien à la table EmailDistributionListContact représentant la liste de distribution des courriels contact")]
        public int EmailDistributionListContactID { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPEnumType](CSSPModels.CSSPEnumTypeAttribute.html)]</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Language")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Langage")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Language of item")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Langage de l'item")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Language
        /// 
        /// **Display (fr)** --- Langage
        /// 
        /// **Description (en)** --- Language of item
        /// 
        /// **Description (fr)** --- Langage de l'item
        /// </returns>
        [CSSPEnumType]
        [CSSPDisplayEN(DisplayEN = "Language")]
        [CSSPDisplayFR(DisplayFR = "Langage")]
        [CSSPDescriptionEN(DescriptionEN = @"Language of item")]
        [CSSPDescriptionFR(DescriptionFR = @"Langage de l'item")]
        public LanguageEnum Language { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Agency")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Agence")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Agency")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Agence")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Agency
        /// 
        /// **Display (fr)** --- Agence
        /// 
        /// **Description (en)** --- Agency
        /// 
        /// **Description (fr)** --- Agence
        /// </returns>
        [StringLength(100, MinimumLength = 1)]
        [CSSPDisplayEN(DisplayEN = "Agency")]
        [CSSPDisplayFR(DisplayFR = "Agence")]
        [CSSPDescriptionEN(DescriptionEN = @"Agency")]
        [CSSPDescriptionFR(DescriptionFR = @"Agence")]
        public string Agency { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPEnumType](CSSPModels.CSSPEnumTypeAttribute.html)]</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Translation status")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Le statut de la traduction")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Translation status of the agency")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Le statut de la traduction du nom de l'agence")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Translation status
        /// 
        /// **Display (fr)** --- Le statut de la traduction
        /// 
        /// **Description (en)** --- Translation status of the agency
        /// 
        /// **Description (fr)** --- Le statut de la traduction du nom de l'agence
        /// </returns>
        [CSSPEnumType]
        [CSSPDisplayEN(DisplayEN = "Translation status")]
        [CSSPDisplayFR(DisplayFR = "Le statut de la traduction")]
        [CSSPDescriptionEN(DescriptionEN = @"Translation status of the agency")]
        [CSSPDescriptionFR(DescriptionFR = @"Le statut de la traduction du nom de l'agence")]
        public TranslationStatusEnum TranslationStatus { get; set; }
        #endregion Properties in DB

        #region Constructors
        public EmailDistributionListContactLanguage() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class EmailDistributionListContactLanguage_A : EmailDistributionListContactLanguage
    {
        #region Properties
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPFill](CSSPModels.CSSPFillAttribute.html)(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "", FillNeedLanguage = true, FillIsList = false)]</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Last update contact TVItemLanguage")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "TVItemLanguage du contact ayant fait le dernière changement")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Last update contact TVItemLanguage DB object")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Object BD TVItemLanguage du contact ayant fait le dernière changement")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Last update contact TVItemLanguage
        /// 
        /// **Display (fr)** --- TVItemLanguage du contact ayant fait le dernière changement
        /// 
        /// **Description (en)** --- Last update contact TVItemLanguage DB object
        /// 
        /// **Description (fr)** --- Object BD TVItemLanguage du contact ayant fait le dernière changement
        /// </returns>
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "", FillNeedLanguage = true, FillIsList = false)]
        [CSSPDisplayEN(DisplayEN = "Last update contact TVItemLanguage")]
        [CSSPDisplayFR(DisplayFR = "TVItemLanguage du contact ayant fait le dernière changement")]
        [CSSPDescriptionEN(DescriptionEN = @"Last update contact TVItemLanguage DB object")]
        [CSSPDescriptionFR(DescriptionFR = @"Object BD TVItemLanguage du contact ayant fait le dernière changement")]
        public TVItemLanguage LastUpdateContactTVItemLanguage { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPEnumTypeText](CSSPModels.CSSPEnumTypeTextAttribute.html)(EnumTypeName = "LanguageEnum", EnumType = "Language")]</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Language text")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Texte du langage")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Language text [en, fr]")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Texte du langage [en, fr]")]</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Language text
        /// 
        /// **Display (fr)** --- Texte du langage
        /// 
        /// **Description (en)** --- Language text [en, fr]
        /// 
        /// **Description (fr)** --- Texte du langage [en, fr]
        /// </returns>
        [CSSPEnumTypeText(EnumTypeName = "LanguageEnum", EnumType = "Language")]
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "Language text")]
        [CSSPDisplayFR(DisplayFR = "Texte du langage")]
        [CSSPDescriptionEN(DescriptionEN = @"Language text [en, fr]")]
        [CSSPDescriptionFR(DescriptionFR = @"Texte du langage [en, fr]")]
        public string LanguageText { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPEnumTypeText](CSSPModels.CSSPEnumTypeTextAttribute.html)(EnumTypeName = "TranslationStatusEnum", EnumType = "TranslationStatus")]</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Translation status text")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Le texte du statut de la traduction")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Translation status text of the EmailDistributionListContact")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Le texte du statut de la traduction de EmailDistributionListContact")]</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Translation status text
        /// 
        /// **Display (fr)** --- Le texte du statut de la traduction
        /// 
        /// **Description (en)** --- Translation status text of the EmailDistributionListContact
        /// 
        /// **Description (fr)** --- Le texte du statut de la traduction de EmailDistributionListContact
        /// </returns>
        [CSSPEnumTypeText(EnumTypeName = "TranslationStatusEnum", EnumType = "TranslationStatus")]
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "Translation status text")]
        [CSSPDisplayFR(DisplayFR = "Le texte du statut de la traduction")]
        [CSSPDescriptionEN(DescriptionEN = @"Translation status text of the EmailDistributionListContact")]
        [CSSPDescriptionFR(DescriptionFR = @"Le texte du statut de la traduction de EmailDistributionListContact")]
        public string TranslationStatusText { get; set; }
        #endregion Properties

        #region Constructors
        public EmailDistributionListContactLanguage_A() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class EmailDistributionListContactLanguage_B : EmailDistributionListContactLanguage_A
    {
        #region Properties
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPFill](CSSPModels.CSSPFillAttribute.html)(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "TVText", FillNeedLanguage = true, FillIsList = false)]</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Report test")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Test report")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Report test description")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Description de test report")]</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Report test
        /// 
        /// **Display (fr)** --- Test report
        /// 
        /// **Description (en)** --- Report test description
        /// 
        /// **Description (fr)** --- Description de test report
        /// </returns>
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "TVText", FillNeedLanguage = true, FillIsList = false)]
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "Report test")]
        [CSSPDisplayFR(DisplayFR = "Test report")]
        [CSSPDescriptionEN(DescriptionEN = @"Report test description")]
        [CSSPDescriptionFR(DescriptionFR = @"Description de test report")]
        public string EmailDistributionListContactLanguageReportTest { get; set; }
        #endregion Properties

        #region Constructors
        public EmailDistributionListContactLanguage_B() : base()
        {
        }
        #endregion Constructors
    }
}
