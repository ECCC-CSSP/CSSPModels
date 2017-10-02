using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    public partial class Log : LastUpdate
    {
        #region Properties in DB
        [Key]
        public int LogID { get; set; }
        [StringLength(50)]
        public string TableName { get; set; }
        [Range(1, -1)]
        public int ID { get; set; }
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
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "TVText", FillNeedLanguage = true)]
        [CSSPAllowNull]
        public string LastUpdateContactTVText { get; set; }
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
