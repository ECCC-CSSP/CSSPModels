/*
 * Auto generated from the CSSPCodeWriter.proj by clicking on the [\srcWithDoc\[ModelClassName]Generated.cs] button
 *
 * Do not edit this file.
 *
 * Last generated on 2018 July 27 04:56
 * by leblancc on WMON01DTCHLEBL2 machine
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
    /// > <para>**DB properties for table ReportTypes** : [ReportTypeID](CSSPModels.ReportType.html#CSSPModels_ReportType_ReportTypeID), [TVType](CSSPModels.ReportType.html#CSSPModels_ReportType_TVType), [FileType](CSSPModels.ReportType.html#CSSPModels_ReportType_FileType), [UniqueCode](CSSPModels.ReportType.html#CSSPModels_ReportType_UniqueCode), [LastUpdateDate_UTC](CSSPModels.ReportType.html#CSSPModels_ReportType_LastUpdateDate_UTC), [LastUpdateContactTVItemID](CSSPModels.ReportType.html#CSSPModels_ReportType_LastUpdateContactTVItemID), </para>
    /// > <para>**Other properties** : [ReportTypeWeb](CSSPModels.ReportType.html#CSSPModels_ReportType_ReportTypeWeb), [ReportTypeReport](CSSPModels.ReportType.html#CSSPModels_ReportType_ReportTypeReport), [HasErrors](CSSPModels.ReportType.html#CSSPModels_ReportType_HasErrors), [ValidationResults](CSSPModels.ReportType.html#CSSPModels_ReportType_ValidationResults), </para>
    /// > 
    /// > <para>**Used by [CSSPServices](CSSPServices.html)** : [ReportTypeService](CSSPServices.ReportTypeService.html)</para>
    /// > <para>**Requires [CSSPEnums](CSSPEnums.html)** : [TVTypeEnum](CSSPEnums.TVTypeEnum.html), [FileTypeEnum](CSSPEnums.FileTypeEnum.html)</para>
    /// > <para>**Return to [CSSPModels](CSSPModels.html)**</para>
    /// </summary>
    public partial class ReportType : LastUpdate
    {
        #region Properties in DB
        [Key]
        [CSSPDisplayEN(DisplayEN = "ReportType ID")]
        [CSSPDisplayFR(DisplayFR = "ReportType ID")]
        [CSSPDescriptionEN(DescriptionEN = @"Contains the unique ""identifier on each row of the ReportTypes table")]
        [CSSPDescriptionFR(DescriptionFR = @"Contient l'identifiant unique sur chaque ligne du tableau ReportTypes")]
        public int ReportTypeID { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPEnumType](CSSPModels.CSSPEnumTypeAttribute.html)]</para>
        /// </summary>
        [CSSPEnumType]
        public TVTypeEnum TVType { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPEnumType](CSSPModels.CSSPEnumTypeAttribute.html)]</para>
        /// </summary>
        [CSSPEnumType]
        public FileTypeEnum FileType { get; set; }
        [StringLength(100)]
        public string UniqueCode { get; set; }
        #endregion Properties in DB

        #region Properties not in DB
        [NotMapped]
        [CSSPAllowNull]
        public ReportTypeWeb ReportTypeWeb { get; set; }
        [NotMapped]
        [CSSPAllowNull]
        public ReportTypeReport ReportTypeReport { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public ReportType() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class ReportTypeWeb
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
        #endregion Properties for web information

        #region Constructors
        public ReportTypeWeb()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class ReportTypeReport
    {
        #region Properties for report information
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        [CSSPAllowNull]
        public string ReportTypeReportTest { get; set; }
        #endregion Properties for report information

        #region Constructors
        public ReportTypeReport()
        {
        }
        #endregion Constructors
    }
}