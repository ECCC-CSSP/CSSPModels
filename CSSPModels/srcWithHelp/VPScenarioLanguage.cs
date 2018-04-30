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
    /// > <para>**DB properties for table VPScenarioLanguages** : [VPScenarioLanguageID](CSSPModels.VPScenarioLanguage.html#CSSPModels_VPScenarioLanguage_VPScenarioLanguageID), [VPScenarioID](CSSPModels.VPScenarioLanguage.html#CSSPModels_VPScenarioLanguage_VPScenarioID), [Language](CSSPModels.VPScenarioLanguage.html#CSSPModels_VPScenarioLanguage_Language), [VPScenarioName](CSSPModels.VPScenarioLanguage.html#CSSPModels_VPScenarioLanguage_VPScenarioName), [TranslationStatus](CSSPModels.VPScenarioLanguage.html#CSSPModels_VPScenarioLanguage_TranslationStatus), [LastUpdateDate_UTC](CSSPModels.VPScenarioLanguage.html#CSSPModels_VPScenarioLanguage_LastUpdateDate_UTC), [LastUpdateContactTVItemID](CSSPModels.VPScenarioLanguage.html#CSSPModels_VPScenarioLanguage_LastUpdateContactTVItemID), </para>
    /// > <para>**Other properties** : [VPScenarioLanguageWeb](CSSPModels.VPScenarioLanguage.html#CSSPModels_VPScenarioLanguage_VPScenarioLanguageWeb), [VPScenarioLanguageReport](CSSPModels.VPScenarioLanguage.html#CSSPModels_VPScenarioLanguage_VPScenarioLanguageReport), [HasErrors](CSSPModels.VPScenarioLanguage.html#CSSPModels_VPScenarioLanguage_HasErrors), [ValidationResults](CSSPModels.VPScenarioLanguage.html#CSSPModels_VPScenarioLanguage_ValidationResults), </para>
    /// > 
    /// > <para>**Used by [CSSPServices](CSSPServices.html)** : [VPScenarioLanguageService](CSSPServices.VPScenarioLanguageService.html)</para>
    /// > <para>**Requires [CSSPEnums](CSSPEnums.html)** : [LanguageEnum](CSSPEnums.LanguageEnum.html), [TranslationStatusEnum](CSSPEnums.TranslationStatusEnum.html)</para>
    /// > <para>**Return to [CSSPModels](CSSPModels.html)**</para>
    /// </summary>
    public partial class VPScenarioLanguage : LastUpdate
    {
        #region Properties in DB
        [Key]
        [CSSPDisplayEN(DisplayEN = "VPScenarioLanguage ID")]
        [CSSPDisplayFR(DisplayFR = "VPScenarioLanguage ID")]
        [CSSPDescriptionEN(DescriptionEN = @"Contains the unique ""identifier on each row of the VPScenarioLanguages table")]
        [CSSPDescriptionFR(DescriptionFR = @"Contient l'identifiant unique sur chaque ligne du tableau VPScenarioLanguages")]
        public int VPScenarioLanguageID { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPExist](CSSPModels.CSSPExistAttribute.html)(ExistTypeName = "VPScenario", ExistPlurial = "s", ExistFieldID = "VPScenarioID")]</para>
        /// </summary>
        [CSSPExist(ExistTypeName = "VPScenario", ExistPlurial = "s", ExistFieldID = "VPScenarioID")]
        public int VPScenarioID { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPEnumType](CSSPModels.CSSPEnumTypeAttribute.html)]</para>
        /// </summary>
        [CSSPEnumType]
        public LanguageEnum Language { get; set; }
        [StringLength(100)]
        public string VPScenarioName { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPEnumType](CSSPModels.CSSPEnumTypeAttribute.html)]</para>
        /// </summary>
        [CSSPEnumType]
        public TranslationStatusEnum TranslationStatus { get; set; }
        #endregion Properties in DB

        #region Properties not in DB
        [NotMapped]
        [CSSPAllowNull]
        public VPScenarioLanguageWeb VPScenarioLanguageWeb { get; set; }
        [NotMapped]
        [CSSPAllowNull]
        public VPScenarioLanguageReport VPScenarioLanguageReport { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public VPScenarioLanguage() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class VPScenarioLanguageWeb
    {
        #region Properties for web information
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPFill](CSSPModels.CSSPFillAttribute.html)(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "TVText", FillNeedLanguage = true)]</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "TVText", FillNeedLanguage = true)]
        [CSSPAllowNull]
        public string LastUpdateContactTVText { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPEnumTypeText](CSSPModels.CSSPEnumTypeTextAttribute.html)(EnumTypeName = "LanguageEnum", EnumType = "Language")]</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        [CSSPEnumTypeText(EnumTypeName = "LanguageEnum", EnumType = "Language")]
        [CSSPAllowNull]
        public string LanguageText { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPEnumTypeText](CSSPModels.CSSPEnumTypeTextAttribute.html)(EnumTypeName = "TranslationStatusEnum", EnumType = "TranslationStatus")]</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        [CSSPEnumTypeText(EnumTypeName = "TranslationStatusEnum", EnumType = "TranslationStatus")]
        [CSSPAllowNull]
        public string TranslationStatusText { get; set; }
        #endregion Properties for web information

        #region Constructors
        public VPScenarioLanguageWeb()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class VPScenarioLanguageReport
    {
        #region Properties for report information
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        [CSSPAllowNull]
        public string VPScenarioLanguageReportTest { get; set; }
        #endregion Properties for report information

        #region Constructors
        public VPScenarioLanguageReport()
        {
        }
        #endregion Constructors
    }
}
