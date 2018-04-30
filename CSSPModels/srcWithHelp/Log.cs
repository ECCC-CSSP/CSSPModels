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
    /// > <para>**DB properties for table Logs** : [LogID](CSSPModels.Log.html#CSSPModels_Log_LogID), [TableName](CSSPModels.Log.html#CSSPModels_Log_TableName), [ID](CSSPModels.Log.html#CSSPModels_Log_ID), [LogCommand](CSSPModels.Log.html#CSSPModels_Log_LogCommand), [Information](CSSPModels.Log.html#CSSPModels_Log_Information), [LastUpdateDate_UTC](CSSPModels.Log.html#CSSPModels_Log_LastUpdateDate_UTC), [LastUpdateContactTVItemID](CSSPModels.Log.html#CSSPModels_Log_LastUpdateContactTVItemID), </para>
    /// > <para>**Other properties** : [LogWeb](CSSPModels.Log.html#CSSPModels_Log_LogWeb), [LogReport](CSSPModels.Log.html#CSSPModels_Log_LogReport), [HasErrors](CSSPModels.Log.html#CSSPModels_Log_HasErrors), [ValidationResults](CSSPModels.Log.html#CSSPModels_Log_ValidationResults), </para>
    /// > 
    /// > <para>**Used by [CSSPServices](CSSPServices.html)** : [LogService](CSSPServices.LogService.html)</para>
    /// > <para>**Requires [CSSPEnums](CSSPEnums.html)** : [LogCommandEnum](CSSPEnums.LogCommandEnum.html)</para>
    /// > <para>**Return to [CSSPModels](CSSPModels.html)**</para>
    /// </summary>
    public partial class Log : LastUpdate
    {
        #region Properties in DB
        [Key]
        public int LogID { get; set; }
        [StringLength(50)]
        public string TableName { get; set; }
        [Range(1, -1)]
        public int ID { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPEnumType](CSSPModels.CSSPEnumTypeAttribute.html)]</para>
        /// </summary>
        [CSSPEnumType]
        public LogCommandEnum LogCommand { get; set; }
        public string Information { get; set; }
        #endregion Properties in DB

        #region Properties not in DB
        [NotMapped]
        [CSSPAllowNull]
        public LogWeb LogWeb { get; set; }
        [NotMapped]
        [CSSPAllowNull]
        public LogReport LogReport { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public Log() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class LogWeb
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
        /// > <para>[[CSSPEnumTypeText](CSSPModels.CSSPEnumTypeTextAttribute.html)(EnumTypeName = "LogCommandEnum", EnumType = "LogCommand")]</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        [CSSPEnumTypeText(EnumTypeName = "LogCommandEnum", EnumType = "LogCommand")]
        [CSSPAllowNull]
        public string LogCommandText { get; set; }
        #endregion Properties for web information

        #region Constructors
        public LogWeb()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class LogReport
    {
        #region Properties for report information
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        [CSSPAllowNull]
        public string LogReportTest { get; set; }
        #endregion Properties for report information

        #region Constructors
        public LogReport()
        {
        }
        #endregion Constructors
    }
}
