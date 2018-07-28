/*
 * Auto generated from the CSSPCodeWriter.proj by clicking on the [\srcWithDoc\[ModelClassName]Generated.cs] button
 *
 * Do not edit this file.
 *
 * Last generated on 2018 July 28 02:03
 * by Charles on CHARLES-PC machine
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
    /// > <para>**DB properties for table ReportSections** : [ReportSectionID](CSSPModels.ReportSection.html#CSSPModels_ReportSection_ReportSectionID), [ReportTypeID](CSSPModels.ReportSection.html#CSSPModels_ReportSection_ReportTypeID), [TVItemID](CSSPModels.ReportSection.html#CSSPModels_ReportSection_TVItemID), [Ordinal](CSSPModels.ReportSection.html#CSSPModels_ReportSection_Ordinal), [IsStatic](CSSPModels.ReportSection.html#CSSPModels_ReportSection_IsStatic), [ParentReportSectionID](CSSPModels.ReportSection.html#CSSPModels_ReportSection_ParentReportSectionID), [Year](CSSPModels.ReportSection.html#CSSPModels_ReportSection_Year), [Locked](CSSPModels.ReportSection.html#CSSPModels_ReportSection_Locked), [TemplateReportSectionID](CSSPModels.ReportSection.html#CSSPModels_ReportSection_TemplateReportSectionID), [LastUpdateDate_UTC](CSSPModels.ReportSection.html#CSSPModels_ReportSection_LastUpdateDate_UTC), [LastUpdateContactTVItemID](CSSPModels.ReportSection.html#CSSPModels_ReportSection_LastUpdateContactTVItemID), </para>
    /// > <para>**Other properties** : [ReportSectionWeb](CSSPModels.ReportSection.html#CSSPModels_ReportSection_ReportSectionWeb), [ReportSectionReport](CSSPModels.ReportSection.html#CSSPModels_ReportSection_ReportSectionReport), [HasErrors](CSSPModels.ReportSection.html#CSSPModels_ReportSection_HasErrors), [ValidationResults](CSSPModels.ReportSection.html#CSSPModels_ReportSection_ValidationResults), </para>
    /// > 
    /// > <para>**Used by [CSSPServices](CSSPServices.html)** : [ReportSectionService](CSSPServices.ReportSectionService.html)</para>
    /// > <para>**Return to [CSSPModels](CSSPModels.html)**</para>
    /// </summary>
    public partial class ReportSection : LastUpdate
    {
        #region Properties in DB
        [Key]
        [CSSPDisplayEN(DisplayEN = "ReportSection ID")]
        [CSSPDisplayFR(DisplayFR = "ReportSection ID")]
        [CSSPDescriptionEN(DescriptionEN = @"Contains the unique ""identifier on each row of the ReportSections table")]
        [CSSPDescriptionFR(DescriptionFR = @"Contient l'identifiant unique sur chaque ligne du tableau ReportSections")]
        public int ReportSectionID { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPExist](CSSPModels.CSSPExistAttribute.html)(ExistTypeName = "ReportType", ExistPlurial = "s", ExistFieldID = "ReportTypeID")]</para>
        /// </summary>
        [CSSPExist(ExistTypeName = "ReportType", ExistPlurial = "s", ExistFieldID = "ReportTypeID")]
        public int ReportTypeID { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPExist](CSSPModels.CSSPExistAttribute.html)(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID")]</para>
        /// </summary>
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID")]
        public int? TVItemID { get; set; }
        [Range(0, 1000)]
        public int Ordinal { get; set; }
        public bool IsStatic { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPExist](CSSPModels.CSSPExistAttribute.html)(ExistTypeName = "ReportSection", ExistPlurial = "s", ExistFieldID = "ReportSectionID")]</para>
        /// </summary>
        [CSSPExist(ExistTypeName = "ReportSection", ExistPlurial = "s", ExistFieldID = "ReportSectionID")]
        public int? ParentReportSectionID { get; set; }
        [Range(1979, 2050)]
        public int? Year { get; set; }
        public bool Locked { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPExist](CSSPModels.CSSPExistAttribute.html)(ExistTypeName = "ReportSection", ExistPlurial = "s", ExistFieldID = "ReportSectionID")]</para>
        /// </summary>
        [CSSPExist(ExistTypeName = "ReportSection", ExistPlurial = "s", ExistFieldID = "ReportSectionID")]
        public int? TemplateReportSectionID { get; set; }
        #endregion Properties in DB

        #region Properties not in DB
        [NotMapped]
        [CSSPAllowNull]
        public ReportSectionWeb ReportSectionWeb { get; set; }
        [NotMapped]
        [CSSPAllowNull]
        public ReportSectionReport ReportSectionReport { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public ReportSection() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class ReportSectionWeb
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
        /// > <para>[[CSSPFill](CSSPModels.CSSPFillAttribute.html)(FillTypeName = "ReportSectionLanguage", FillPlurial = "s", FillFieldID = "ReportSectionID", FillEqualField = "ReportSectionID", FillReturnField = "ReportSectionName", FillNeedLanguage = true)]</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        [CSSPFill(FillTypeName = "ReportSectionLanguage", FillPlurial = "s", FillFieldID = "ReportSectionID", FillEqualField = "ReportSectionID", FillReturnField = "ReportSectionName", FillNeedLanguage = true)]
        [CSSPAllowNull]
        public string ReportSectionName { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPFill](CSSPModels.CSSPFillAttribute.html)(FillTypeName = "ReportSectionLanguage", FillPlurial = "s", FillFieldID = "ReportSectionID", FillEqualField = "ReportSectionID", FillReturnField = "ReportSectionText", FillNeedLanguage = true)]</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        [CSSPFill(FillTypeName = "ReportSectionLanguage", FillPlurial = "s", FillFieldID = "ReportSectionID", FillEqualField = "ReportSectionID", FillReturnField = "ReportSectionText", FillNeedLanguage = true)]
        [CSSPAllowNull]
        public string ReportSectionText { get; set; }
        #endregion Properties for web information

        #region Constructors
        public ReportSectionWeb()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class ReportSectionReport
    {
        #region Properties for report information
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        [CSSPAllowNull]
        public string ReportSectionReportTest { get; set; }
        #endregion Properties for report information

        #region Constructors
        public ReportSectionReport()
        {
        }
        #endregion Constructors
    }
}
