/*
 * Auto generated from the CSSPCodeWriter.proj by clicking on the [\srcWithDoc\[ModelClassName]Generated.cs] button
 *
 * Do not edit this file.
 *
 * Last generated by leblancc on WMON01DTCHLEBL2 machine
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
    /// > <para>**DB properties for table PolSourceObservationIssues** : [PolSourceObservationIssueID](CSSPModels.PolSourceObservationIssue.html#CSSPModels_PolSourceObservationIssue_PolSourceObservationIssueID), [PolSourceObservationID](CSSPModels.PolSourceObservationIssue.html#CSSPModels_PolSourceObservationIssue_PolSourceObservationID), [ObservationInfo](CSSPModels.PolSourceObservationIssue.html#CSSPModels_PolSourceObservationIssue_ObservationInfo), [Ordinal](CSSPModels.PolSourceObservationIssue.html#CSSPModels_PolSourceObservationIssue_Ordinal), [ExtraComment](CSSPModels.PolSourceObservationIssue.html#CSSPModels_PolSourceObservationIssue_ExtraComment), [LastUpdateDate_UTC](CSSPModels.PolSourceObservationIssue.html#CSSPModels_PolSourceObservationIssue_LastUpdateDate_UTC), [LastUpdateContactTVItemID](CSSPModels.PolSourceObservationIssue.html#CSSPModels_PolSourceObservationIssue_LastUpdateContactTVItemID), </para>
    /// > <para>**Other properties** : [PolSourceObservationIssueWeb](CSSPModels.PolSourceObservationIssue.html#CSSPModels_PolSourceObservationIssue_PolSourceObservationIssueWeb), [PolSourceObservationIssueReport](CSSPModels.PolSourceObservationIssue.html#CSSPModels_PolSourceObservationIssue_PolSourceObservationIssueReport), [HasErrors](CSSPModels.PolSourceObservationIssue.html#CSSPModels_PolSourceObservationIssue_HasErrors), [ValidationResults](CSSPModels.PolSourceObservationIssue.html#CSSPModels_PolSourceObservationIssue_ValidationResults), </para>
    /// > 
    /// > <para>**Used by [CSSPServices](CSSPServices.html)** : [PolSourceObservationIssueService](CSSPServices.PolSourceObservationIssueService.html)</para>
    /// > <para>**Return to [CSSPModels](CSSPModels.html)**</para>
    /// </summary>
    public partial class PolSourceObservationIssue : LastUpdate
    {
        #region Properties in DB
        [Key]
        [CSSPDisplayEN(DisplayEN = "PolSourceObservationIssue ID")]
        [CSSPDisplayFR(DisplayFR = "PolSourceObservationIssue ID")]
        [CSSPDescriptionEN(DescriptionEN = @"Contains the unique ""identifier on each row of the PolSourceObservationIssues table")]
        [CSSPDescriptionFR(DescriptionFR = @"Contient l'identifiant unique sur chaque ligne du tableau PolSourceObservationIssues")]
        public int PolSourceObservationIssueID { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPExist](CSSPModels.CSSPExistAttribute.html)(ExistTypeName = "PolSourceObservation", ExistPlurial = "s", ExistFieldID = "PolSourceObservationID")]</para>
        /// </summary>
        [CSSPExist(ExistTypeName = "PolSourceObservation", ExistPlurial = "s", ExistFieldID = "PolSourceObservationID")]
        public int PolSourceObservationID { get; set; }
        [StringLength(250)]
        public string ObservationInfo { get; set; }
        [Range(0, 1000)]
        public int Ordinal { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        [CSSPAllowNull]
        public string ExtraComment { get; set; }
        #endregion Properties in DB

        #region Properties not in DB
        [NotMapped]
        [CSSPAllowNull]
        public PolSourceObservationIssueWeb PolSourceObservationIssueWeb { get; set; }
        [NotMapped]
        [CSSPAllowNull]
        public PolSourceObservationIssueReport PolSourceObservationIssueReport { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public PolSourceObservationIssue() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class PolSourceObservationIssueWeb
    {
        #region Properties for web information
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPFill](CSSPModels.CSSPFillAttribute.html)(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "", FillNeedLanguage = true)]</para>
        /// </summary>
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "", FillNeedLanguage = true)]
        public TVItemLanguage LastUpdateContactTVItemLanguage { get; set; }
        #endregion Properties for web information

        #region Constructors
        public PolSourceObservationIssueWeb()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class PolSourceObservationIssueReport
    {
        #region Properties for report information
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        [CSSPAllowNull]
        public string PolSourceObservationIssueReportTest { get; set; }
        #endregion Properties for report information

        #region Constructors
        public PolSourceObservationIssueReport()
        {
        }
        #endregion Constructors
    }
}
