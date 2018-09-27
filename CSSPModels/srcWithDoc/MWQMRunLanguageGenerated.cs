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
using System.Linq;

namespace CSSPModels
{
    /// <summary>
    /// > [!NOTE]
    /// > 
    /// > <para>**DB properties for table MWQMRunLanguages** : [MWQMRunLanguageID](CSSPModels.MWQMRunLanguage.html#CSSPModels_MWQMRunLanguage_MWQMRunLanguageID), [MWQMRunID](CSSPModels.MWQMRunLanguage.html#CSSPModels_MWQMRunLanguage_MWQMRunID), [Language](CSSPModels.MWQMRunLanguage.html#CSSPModels_MWQMRunLanguage_Language), [RunComment](CSSPModels.MWQMRunLanguage.html#CSSPModels_MWQMRunLanguage_RunComment), [TranslationStatusRunComment](CSSPModels.MWQMRunLanguage.html#CSSPModels_MWQMRunLanguage_TranslationStatusRunComment), [RunWeatherComment](CSSPModels.MWQMRunLanguage.html#CSSPModels_MWQMRunLanguage_RunWeatherComment), [TranslationStatusRunWeatherComment](CSSPModels.MWQMRunLanguage.html#CSSPModels_MWQMRunLanguage_TranslationStatusRunWeatherComment), [LastUpdateDate_UTC](CSSPModels.MWQMRunLanguage.html#CSSPModels_MWQMRunLanguage_LastUpdateDate_UTC), [LastUpdateContactTVItemID](CSSPModels.MWQMRunLanguage.html#CSSPModels_MWQMRunLanguage_LastUpdateContactTVItemID), </para>
    /// > <para>**Other properties** : [HasErrors](CSSPModels.MWQMRunLanguage.html#CSSPModels_MWQMRunLanguage_HasErrors), [ValidationResults](CSSPModels.MWQMRunLanguage.html#CSSPModels_MWQMRunLanguage_ValidationResults), </para>
    /// > 
    /// > <para>**Used by [CSSPServices](CSSPServices.html)** : [MWQMRunLanguageService](CSSPServices.MWQMRunLanguageService.html)</para>
    /// > <para>**Requires [CSSPEnums](CSSPEnums.html)** : [LanguageEnum](CSSPEnums.LanguageEnum.html), [TranslationStatusEnum](CSSPEnums.TranslationStatusEnum.html), [TranslationStatusEnum](CSSPEnums.TranslationStatusEnum.html)</para>
    /// > <para>**Return to [CSSPModels](CSSPModels.html)**</para>
    /// </summary>
    public partial class MWQMRunLanguage : LastUpdate
    {
        #region Properties in DB
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "MWQMRunLanguage ID")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "MWQMRunLanguage ID")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Contains the unique "identifier on each row of the MWQMRunLanguages table")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Contient l'identifiant unique sur chaque ligne de la table MWQMRunLanguages")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- MWQMRunLanguage ID
        /// 
        /// **Display (fr)** --- MWQMRunLanguage ID
        /// 
        /// **Description (en)** --- Contains the unique "identifier on each row of the MWQMRunLanguages table
        /// 
        /// **Description (fr)** --- Contient l'identifiant unique sur chaque ligne de la table MWQMRunLanguages
        /// </returns>
        [Key]
        [CSSPDisplayEN(DisplayEN = "MWQMRunLanguage ID")]
        [CSSPDisplayFR(DisplayFR = "MWQMRunLanguage ID")]
        [CSSPDescriptionEN(DescriptionEN = @"Contains the unique ""identifier on each row of the MWQMRunLanguages table")]
        [CSSPDescriptionFR(DescriptionFR = @"Contient l'identifiant unique sur chaque ligne de la table MWQMRunLanguages")]
        public int MWQMRunLanguageID { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPExist](CSSPModels.CSSPExistAttribute.html)(ExistTypeName = "MWQMRun", ExistPlurial = "s", ExistFieldID = "MWQMRunID")]</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "MWQM run")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Tournée de MWQM (fr)")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Link to the MWQMRuns table representing the MWQM run")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Lien à la table MWQMRuns représentant la tournée MWQM (fr)")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- MWQM run
        /// 
        /// **Display (fr)** --- Tournée de MWQM (fr)
        /// 
        /// **Description (en)** --- Link to the MWQMRuns table representing the MWQM run
        /// 
        /// **Description (fr)** --- Lien à la table MWQMRuns représentant la tournée MWQM (fr)
        /// </returns>
        [CSSPExist(ExistTypeName = "MWQMRun", ExistPlurial = "s", ExistFieldID = "MWQMRunID")]
        [CSSPDisplayEN(DisplayEN = "MWQM run")]
        [CSSPDisplayFR(DisplayFR = "Tournée de MWQM (fr)")]
        [CSSPDescriptionEN(DescriptionEN = @"Link to the MWQMRuns table representing the MWQM run")]
        [CSSPDescriptionFR(DescriptionFR = @"Lien à la table MWQMRuns représentant la tournée MWQM (fr)")]
        public int MWQMRunID { get; set; }
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
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Run comment")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Commentaire de la tournée")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Run comment")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Commentaire de la tournée")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Run comment
        /// 
        /// **Display (fr)** --- Commentaire de la tournée
        /// 
        /// **Description (en)** --- Run comment
        /// 
        /// **Description (fr)** --- Commentaire de la tournée
        /// </returns>
        [CSSPDisplayEN(DisplayEN = "Run comment")]
        [CSSPDisplayFR(DisplayFR = "Commentaire de la tournée")]
        [CSSPDescriptionEN(DescriptionEN = @"Run comment")]
        [CSSPDescriptionFR(DescriptionFR = @"Commentaire de la tournée")]
        public string RunComment { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPEnumType](CSSPModels.CSSPEnumTypeAttribute.html)]</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Translation status")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Le statut de la traduction")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Translation status of the run comment")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Le statut de la traduction du commentaire de la tournée")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Translation status
        /// 
        /// **Display (fr)** --- Le statut de la traduction
        /// 
        /// **Description (en)** --- Translation status of the run comment
        /// 
        /// **Description (fr)** --- Le statut de la traduction du commentaire de la tournée
        /// </returns>
        [CSSPEnumType]
        [CSSPDisplayEN(DisplayEN = "Translation status")]
        [CSSPDisplayFR(DisplayFR = "Le statut de la traduction")]
        [CSSPDescriptionEN(DescriptionEN = @"Translation status of the run comment")]
        [CSSPDescriptionFR(DescriptionFR = @"Le statut de la traduction du commentaire de la tournée")]
        public TranslationStatusEnum TranslationStatusRunComment { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Run weather comment")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Commentaire de la météo de la tournée")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Run weather comment")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Commentaire de la météo de la tournée")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Run weather comment
        /// 
        /// **Display (fr)** --- Commentaire de la météo de la tournée
        /// 
        /// **Description (en)** --- Run weather comment
        /// 
        /// **Description (fr)** --- Commentaire de la météo de la tournée
        /// </returns>
        [CSSPDisplayEN(DisplayEN = "Run weather comment")]
        [CSSPDisplayFR(DisplayFR = "Commentaire de la météo de la tournée")]
        [CSSPDescriptionEN(DescriptionEN = @"Run weather comment")]
        [CSSPDescriptionFR(DescriptionFR = @"Commentaire de la météo de la tournée")]
        public string RunWeatherComment { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPEnumType](CSSPModels.CSSPEnumTypeAttribute.html)]</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Translation status")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Le statut de la traduction")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Translation status of the run weather comment")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Le statut de la traduction du commentaire de la météo de la tournée")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Translation status
        /// 
        /// **Display (fr)** --- Le statut de la traduction
        /// 
        /// **Description (en)** --- Translation status of the run weather comment
        /// 
        /// **Description (fr)** --- Le statut de la traduction du commentaire de la météo de la tournée
        /// </returns>
        [CSSPEnumType]
        [CSSPDisplayEN(DisplayEN = "Translation status")]
        [CSSPDisplayFR(DisplayFR = "Le statut de la traduction")]
        [CSSPDescriptionEN(DescriptionEN = @"Translation status of the run weather comment")]
        [CSSPDescriptionFR(DescriptionFR = @"Le statut de la traduction du commentaire de la météo de la tournée")]
        public TranslationStatusEnum TranslationStatusRunWeatherComment { get; set; }
        #endregion Properties in DB

        #region Constructors
        public MWQMRunLanguage() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class MWQMRunLanguage_A : MWQMRunLanguage
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
        /// > <para>[[CSSPEnumTypeText](CSSPModels.CSSPEnumTypeTextAttribute.html)(EnumTypeName = "TranslationStatusEnum", EnumType = "TranslationStatusRunComment")]</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Translation status text")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Le texte du statut de la traduction")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Translation status text of the run comment")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Le texte du statut de la traduction du commentaire de la tournée")]</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Translation status text
        /// 
        /// **Display (fr)** --- Le texte du statut de la traduction
        /// 
        /// **Description (en)** --- Translation status text of the run comment
        /// 
        /// **Description (fr)** --- Le texte du statut de la traduction du commentaire de la tournée
        /// </returns>
        [CSSPEnumTypeText(EnumTypeName = "TranslationStatusEnum", EnumType = "TranslationStatusRunComment")]
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "Translation status text")]
        [CSSPDisplayFR(DisplayFR = "Le texte du statut de la traduction")]
        [CSSPDescriptionEN(DescriptionEN = @"Translation status text of the run comment")]
        [CSSPDescriptionFR(DescriptionFR = @"Le texte du statut de la traduction du commentaire de la tournée")]
        public string TranslationStatusRunCommentText { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPEnumTypeText](CSSPModels.CSSPEnumTypeTextAttribute.html)(EnumTypeName = "TranslationStatusEnum", EnumType = "TranslationStatusRunWeatherComment")]</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Translation status text")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Le texte du statut de la traduction")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Translation status text of the run weather comment")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Le texte du statut de la traduction du commentaire de la météo de la tournée")]</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Translation status text
        /// 
        /// **Display (fr)** --- Le texte du statut de la traduction
        /// 
        /// **Description (en)** --- Translation status text of the run weather comment
        /// 
        /// **Description (fr)** --- Le texte du statut de la traduction du commentaire de la météo de la tournée
        /// </returns>
        [CSSPEnumTypeText(EnumTypeName = "TranslationStatusEnum", EnumType = "TranslationStatusRunWeatherComment")]
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "Translation status text")]
        [CSSPDisplayFR(DisplayFR = "Le texte du statut de la traduction")]
        [CSSPDescriptionEN(DescriptionEN = @"Translation status text of the run weather comment")]
        [CSSPDescriptionFR(DescriptionFR = @"Le texte du statut de la traduction du commentaire de la météo de la tournée")]
        public string TranslationStatusRunWeatherCommentText { get; set; }
        #endregion Properties

        #region Constructors
        public MWQMRunLanguage_A() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class MWQMRunLanguage_B : MWQMRunLanguage_A
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
        public string MWQMRunLanguageReportTest { get; set; }
        #endregion Properties

        #region Constructors
        public MWQMRunLanguage_B() : base()
        {
        }
        #endregion Constructors
    }
}
