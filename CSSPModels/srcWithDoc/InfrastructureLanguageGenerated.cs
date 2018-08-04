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
    /// > <para>**DB properties for table InfrastructureLanguages** : [InfrastructureLanguageID](CSSPModels.InfrastructureLanguage.html#CSSPModels_InfrastructureLanguage_InfrastructureLanguageID), [InfrastructureID](CSSPModels.InfrastructureLanguage.html#CSSPModels_InfrastructureLanguage_InfrastructureID), [Language](CSSPModels.InfrastructureLanguage.html#CSSPModels_InfrastructureLanguage_Language), [Comment](CSSPModels.InfrastructureLanguage.html#CSSPModels_InfrastructureLanguage_Comment), [TranslationStatus](CSSPModels.InfrastructureLanguage.html#CSSPModels_InfrastructureLanguage_TranslationStatus), [LastUpdateDate_UTC](CSSPModels.InfrastructureLanguage.html#CSSPModels_InfrastructureLanguage_LastUpdateDate_UTC), [LastUpdateContactTVItemID](CSSPModels.InfrastructureLanguage.html#CSSPModels_InfrastructureLanguage_LastUpdateContactTVItemID), </para>
    /// > <para>**Other properties** : [HasErrors](CSSPModels.InfrastructureLanguage.html#CSSPModels_InfrastructureLanguage_HasErrors), [ValidationResults](CSSPModels.InfrastructureLanguage.html#CSSPModels_InfrastructureLanguage_ValidationResults), </para>
    /// > 
    /// > <para>**Used by [CSSPServices](CSSPServices.html)** : [InfrastructureLanguageService](CSSPServices.InfrastructureLanguageService.html)</para>
    /// > <para>**Requires [CSSPEnums](CSSPEnums.html)** : [LanguageEnum](CSSPEnums.LanguageEnum.html), [TranslationStatusEnum](CSSPEnums.TranslationStatusEnum.html)</para>
    /// > <para>**Return to [CSSPModels](CSSPModels.html)**</para>
    /// </summary>
    public partial class InfrastructureLanguage : LastUpdate
    {
        #region Properties in DB
        [Key]
        [CSSPDisplayEN(DisplayEN = "InfrastructureLanguage ID")]
        [CSSPDisplayFR(DisplayFR = "InfrastructureLanguage ID")]
        [CSSPDescriptionEN(DescriptionEN = @"Contains the unique ""identifier on each row of the InfrastructureLanguages table")]
        [CSSPDescriptionFR(DescriptionFR = @"Contient l'identifiant unique sur chaque ligne du tableau InfrastructureLanguages")]
        public int InfrastructureLanguageID { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPExist](CSSPModels.CSSPExistAttribute.html)(ExistTypeName = "Infrastructure", ExistPlurial = "s", ExistFieldID = "InfrastructureID")]</para>
        /// </summary>
        [CSSPExist(ExistTypeName = "Infrastructure", ExistPlurial = "s", ExistFieldID = "InfrastructureID")]
        public int InfrastructureID { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPEnumType](CSSPModels.CSSPEnumTypeAttribute.html)]</para>
        /// </summary>
        [CSSPEnumType]
        public LanguageEnum Language { get; set; }
        public string Comment { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPEnumType](CSSPModels.CSSPEnumTypeAttribute.html)]</para>
        /// </summary>
        [CSSPEnumType]
        public TranslationStatusEnum TranslationStatus { get; set; }
        #endregion Properties in DB

        #region Constructors
        public InfrastructureLanguage() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class InfrastructureLanguageWeb : InfrastructureLanguage
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
        public InfrastructureLanguageWeb() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class InfrastructureLanguageReport : InfrastructureLanguageWeb
    {
        #region Properties for report information
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        [CSSPAllowNull]
        public string InfrastructureLanguageReportTest { get; set; }
        #endregion Properties for report information

        #region Constructors
        public InfrastructureLanguageReport() : base()
        {
        }
        #endregion Constructors
    }
}
