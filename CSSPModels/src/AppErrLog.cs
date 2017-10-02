﻿using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
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