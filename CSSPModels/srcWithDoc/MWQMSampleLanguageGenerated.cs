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
    /// > <para>**DB properties for table MWQMSampleLanguages** : [MWQMSampleLanguageID](CSSPModels.MWQMSampleLanguage.html#CSSPModels_MWQMSampleLanguage_MWQMSampleLanguageID), [MWQMSampleID](CSSPModels.MWQMSampleLanguage.html#CSSPModels_MWQMSampleLanguage_MWQMSampleID), [Language](CSSPModels.MWQMSampleLanguage.html#CSSPModels_MWQMSampleLanguage_Language), [MWQMSampleNote](CSSPModels.MWQMSampleLanguage.html#CSSPModels_MWQMSampleLanguage_MWQMSampleNote), [TranslationStatus](CSSPModels.MWQMSampleLanguage.html#CSSPModels_MWQMSampleLanguage_TranslationStatus), [LastUpdate.LastUpdateDate_UTC](CSSPModels.LastUpdate.html#CSSPModels_LastUpdate_LastUpdateDate_UTC), [LastUpdate.LastUpdateContactTVItemID](CSSPModels.LastUpdate.html#CSSPModels_LastUpdate_LastUpdateContactTVItemID)</para>
    /// > <para>**Other properties** : [CSSPError.HasErrors](CSSPModels.CSSPError.html#CSSPModels_CSSPError_HasErrors), [CSSPError.ValidationResults](CSSPModels.CSSPError.html#CSSPModels_CSSPError_ValidationResults)</para>
    /// > 
    /// > <para>**Used by [CSSPServices](CSSPServices.html)** : [MWQMSampleLanguageService](CSSPServices.MWQMSampleLanguageService.html)</para>
    /// > <para>**Used by [CSSPWebAPI.Controllers](CSSPWebAPI.Controllers.html)** : [MWQMSampleLanguageController](CSSPWebAPI.Controllers.MWQMSampleLanguageController.html)</para>
    /// > <para>**Requires [CSSPEnums](CSSPEnums.html)** : [LanguageEnum](CSSPEnums.LanguageEnum.html), [TranslationStatusEnum](CSSPEnums.TranslationStatusEnum.html)</para>
    /// > <para>**Inherits [LastUpdate](CSSPModels.LastUpdate.html)**</para>
    /// > <para>**Return to [CSSPModels](CSSPModels.html)**</para>
    /// </summary>
    public partial class MWQMSampleLanguage : LastUpdate
    {
        #region Properties in DB
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "MWQMSampleLanguage ID")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "MWQMSampleLanguage ID")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Contains the unique "identifier on each row of the MWQMSampleLanguages table")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Contient l'identifiant unique sur chaque ligne de la table MWQMSampleLanguages")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- MWQMSampleLanguage ID
        /// 
        /// **Display (fr)** --- MWQMSampleLanguage ID
        /// 
        /// **Description (en)** --- Contains the unique "identifier on each row of the MWQMSampleLanguages table
        /// 
        /// **Description (fr)** --- Contient l'identifiant unique sur chaque ligne de la table MWQMSampleLanguages
        /// </returns>
        [Key]
        [CSSPDisplayEN(DisplayEN = "MWQMSampleLanguage ID")]
        [CSSPDisplayFR(DisplayFR = "MWQMSampleLanguage ID")]
        [CSSPDescriptionEN(DescriptionEN = @"Contains the unique ""identifier on each row of the MWQMSampleLanguages table")]
        [CSSPDescriptionFR(DescriptionFR = @"Contient l'identifiant unique sur chaque ligne de la table MWQMSampleLanguages")]
        public int MWQMSampleLanguageID { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPExist](CSSPModels.CSSPExistAttribute.html)(ExistTypeName = "MWQMSample", ExistPlurial = "s", ExistFieldID = "MWQMSampleID")]</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "MWQM sample ID")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Échantillon MWQM ID")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Link to the MWQMSamples table representing the MWQM sample")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Lien à la table MWQMSamples représentant l'échantillon MWQM")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- MWQM sample ID
        /// 
        /// **Display (fr)** --- Échantillon MWQM ID
        /// 
        /// **Description (en)** --- Link to the MWQMSamples table representing the MWQM sample
        /// 
        /// **Description (fr)** --- Lien à la table MWQMSamples représentant l'échantillon MWQM
        /// </returns>
        [CSSPExist(ExistTypeName = "MWQMSample", ExistPlurial = "s", ExistFieldID = "MWQMSampleID")]
        [CSSPDisplayEN(DisplayEN = "MWQM sample ID")]
        [CSSPDisplayFR(DisplayFR = "Échantillon MWQM ID")]
        [CSSPDescriptionEN(DescriptionEN = @"Link to the MWQMSamples table representing the MWQM sample")]
        [CSSPDescriptionFR(DescriptionFR = @"Lien à la table MWQMSamples représentant l'échantillon MWQM")]
        public int MWQMSampleID { get; set; }
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
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "MWQM sample note")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Échantillon MWQM note")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "MWQM sample note")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Échantillon MWQM note")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- MWQM sample note
        /// 
        /// **Display (fr)** --- Échantillon MWQM note
        /// 
        /// **Description (en)** --- MWQM sample note
        /// 
        /// **Description (fr)** --- Échantillon MWQM note
        /// </returns>
        [CSSPDisplayEN(DisplayEN = "MWQM sample note")]
        [CSSPDisplayFR(DisplayFR = "Échantillon MWQM note")]
        [CSSPDescriptionEN(DescriptionEN = @"MWQM sample note")]
        [CSSPDescriptionFR(DescriptionFR = @"Échantillon MWQM note")]
        public string MWQMSampleNote { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPEnumType](CSSPModels.CSSPEnumTypeAttribute.html)]</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Translation status")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Le statut de la traduction")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Translation status of the comment")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Le statut de la traduction du commentaire")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Translation status
        /// 
        /// **Display (fr)** --- Le statut de la traduction
        /// 
        /// **Description (en)** --- Translation status of the comment
        /// 
        /// **Description (fr)** --- Le statut de la traduction du commentaire
        /// </returns>
        [CSSPEnumType]
        [CSSPDisplayEN(DisplayEN = "Translation status")]
        [CSSPDisplayFR(DisplayFR = "Le statut de la traduction")]
        [CSSPDescriptionEN(DescriptionEN = @"Translation status of the comment")]
        [CSSPDescriptionFR(DescriptionFR = @"Le statut de la traduction du commentaire")]
        public TranslationStatusEnum TranslationStatus { get; set; }
        #endregion Properties in DB

        #region Constructors
        public MWQMSampleLanguage() : base()
        {
        }
        #endregion Constructors
    }
    /// <summary>
    /// > [!NOTE]
    /// > 
    /// > <para>**No DB properties** :</para>
    /// > <para>**Other properties** : [LastUpdateContactText](CSSPModels.MWQMSampleLanguage.html#CSSPModels_MWQMSampleLanguage_LastUpdateContactText), [LanguageText](CSSPModels.MWQMSampleLanguage.html#CSSPModels_MWQMSampleLanguage_LanguageText), [TranslationStatusText](CSSPModels.MWQMSampleLanguage.html#CSSPModels_MWQMSampleLanguage_TranslationStatusText)</para>
    /// > 
    /// > <para>**Used by [CSSPServices](CSSPServices.html)** : [MWQMSampleLanguageService](CSSPServices.MWQMSampleLanguageService.html)</para>
    /// > <para>**Used by [CSSPWebAPI.Controllers](CSSPWebAPI.Controllers.html)** : [MWQMSampleLanguageController](CSSPWebAPI.Controllers.MWQMSampleLanguageController.html)</para>
    /// > <para>**Requires [CSSPEnums](CSSPEnums.html)** : [LanguageEnum](CSSPEnums.LanguageEnum.html), [TranslationStatusEnum](CSSPEnums.TranslationStatusEnum.html)</para>
    /// > <para>**Inherits [MWQMSampleLanguage](CSSPModels.MWQMSampleLanguage.html)**</para>
    /// > <para>**Return to [CSSPModels](CSSPModels.html)**</para>
    /// </summary>
    [NotMapped]
    public partial class MWQMSampleLanguageExtraA : MWQMSampleLanguage
    {
        #region Properties
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPFill](CSSPModels.CSSPFillAttribute.html)(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "TVText", FillNeedLanguage = true, FillIsList = false)]</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Last update contact name")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Nom du contact ayant fait le dernière changement")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Last update contact name")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Nom du contact ayant fait le dernière changement")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Last update contact name
        /// 
        /// **Display (fr)** --- Nom du contact ayant fait le dernière changement
        /// 
        /// **Description (en)** --- Last update contact name
        /// 
        /// **Description (fr)** --- Nom du contact ayant fait le dernière changement
        /// </returns>
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "TVText", FillNeedLanguage = true, FillIsList = false)]
        [CSSPDisplayEN(DisplayEN = "Last update contact name")]
        [CSSPDisplayFR(DisplayFR = "Nom du contact ayant fait le dernière changement")]
        [CSSPDescriptionEN(DescriptionEN = @"Last update contact name")]
        [CSSPDescriptionFR(DescriptionFR = @"Nom du contact ayant fait le dernière changement")]
        public string LastUpdateContactText { get; set; }
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
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Translation status text of the MWQMSample")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Le texte du statut de la traduction de MWQMSample")]</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Translation status text
        /// 
        /// **Display (fr)** --- Le texte du statut de la traduction
        /// 
        /// **Description (en)** --- Translation status text of the MWQMSample
        /// 
        /// **Description (fr)** --- Le texte du statut de la traduction de MWQMSample
        /// </returns>
        [CSSPEnumTypeText(EnumTypeName = "TranslationStatusEnum", EnumType = "TranslationStatus")]
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "Translation status text")]
        [CSSPDisplayFR(DisplayFR = "Le texte du statut de la traduction")]
        [CSSPDescriptionEN(DescriptionEN = @"Translation status text of the MWQMSample")]
        [CSSPDescriptionFR(DescriptionFR = @"Le texte du statut de la traduction de MWQMSample")]
        public string TranslationStatusText { get; set; }
        #endregion Properties

        #region Constructors
        public MWQMSampleLanguageExtraA() : base()
        {
        }
        #endregion Constructors
    }
    /// <summary>
    /// > [!NOTE]
    /// > 
    /// > <para>**No DB properties** :</para>
    /// > <para>**Other properties** : [MWQMSampleLanguageReportTest](CSSPModels.MWQMSampleLanguage.html#CSSPModels_MWQMSampleLanguage_MWQMSampleLanguageReportTest)</para>
    /// > 
    /// > <para>**Used by [CSSPServices](CSSPServices.html)** : [MWQMSampleLanguageService](CSSPServices.MWQMSampleLanguageService.html)</para>
    /// > <para>**Used by [CSSPWebAPI.Controllers](CSSPWebAPI.Controllers.html)** : [MWQMSampleLanguageController](CSSPWebAPI.Controllers.MWQMSampleLanguageController.html)</para>
    /// > <para>**Requires [CSSPEnums](CSSPEnums.html)** : [LanguageEnum](CSSPEnums.LanguageEnum.html), [TranslationStatusEnum](CSSPEnums.TranslationStatusEnum.html)</para>
    /// > <para>**Inherits [MWQMSampleLanguageExtraA](CSSPModels.MWQMSampleLanguageExtraA.html)**</para>
    /// > <para>**Return to [CSSPModels](CSSPModels.html)**</para>
    /// </summary>
    [NotMapped]
    public partial class MWQMSampleLanguageExtraB : MWQMSampleLanguageExtraA
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
        public string MWQMSampleLanguageReportTest { get; set; }
        #endregion Properties

        #region Constructors
        public MWQMSampleLanguageExtraB() : base()
        {
        }
        #endregion Constructors
    }
}
