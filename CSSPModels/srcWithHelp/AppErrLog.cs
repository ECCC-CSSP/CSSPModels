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
    /// > <para>**DB properties for table AppErrLogs** : [AppErrLogID](CSSPModels.AppErrLog.html#CSSPModels_AppErrLog_AppErrLogID), [Tag](CSSPModels.AppErrLog.html#CSSPModels_AppErrLog_Tag), [LineNumber](CSSPModels.AppErrLog.html#CSSPModels_AppErrLog_LineNumber), [Source](CSSPModels.AppErrLog.html#CSSPModels_AppErrLog_Source), [Message](CSSPModels.AppErrLog.html#CSSPModels_AppErrLog_Message), [DateTime_UTC](CSSPModels.AppErrLog.html#CSSPModels_AppErrLog_DateTime_UTC), [LastUpdateDate_UTC](CSSPModels.AppErrLog.html#CSSPModels_AppErrLog_LastUpdateDate_UTC), [LastUpdateContactTVItemID](CSSPModels.AppErrLog.html#CSSPModels_AppErrLog_LastUpdateContactTVItemID), </para>
    /// > <para>**Other properties** : [AppErrLogWeb](CSSPModels.AppErrLog.html#CSSPModels_AppErrLog_AppErrLogWeb), [AppErrLogReport](CSSPModels.AppErrLog.html#CSSPModels_AppErrLog_AppErrLogReport), [HasErrors](CSSPModels.AppErrLog.html#CSSPModels_AppErrLog_HasErrors), [ValidationResults](CSSPModels.AppErrLog.html#CSSPModels_AppErrLog_ValidationResults), </para>
    /// > 
    /// > <para>**Used by [CSSPServices](CSSPServices.html)** : [AppErrLogService](CSSPServices.AppErrLogService.html)</para>
    /// > <para>**Return to [CSSPModels](CSSPModels.html)**</para>
    /// </summary>
    public partial class AppErrLog : LastUpdate
    {
        #region Properties in DB
        [Key]
        public int AppErrLogID { get; set; }
        [StringLength(100)]
        public string Tag { get; set; }
        [Range(1, -1)]
        public int LineNumber { get; set; }
        public string Source { get; set; }
        public string Message { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPAfter](CSSPModels.CSSPAfterAttribute.html)(Year = 1980)]</para>
        /// </summary>
        [CSSPAfter(Year = 1980)]
        public DateTime DateTime_UTC { get; set; }
        #endregion Properties in DB

        #region Properties not in DB
        [NotMapped]
        [CSSPAllowNull]
        public AppErrLogWeb AppErrLogWeb { get; set; }
        [NotMapped]
        [CSSPAllowNull]
        public AppErrLogReport AppErrLogReport { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public AppErrLog() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class AppErrLogWeb
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
        public AppErrLogWeb()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class AppErrLogReport
    {
        #region Properties for report information
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        [CSSPAllowNull]
        public string AppErrLogTest { get; set; }
        #endregion Properties for report information

        #region Constructors
        public AppErrLogReport()
        {
        }
        #endregion Constructors
    }
}
