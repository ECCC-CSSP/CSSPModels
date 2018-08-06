﻿/*
 * Manually edited by Charles LeBlanc 
 * 
 */
using CSSPEnums;
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
        [CSSPDisplayEN(DisplayEN = "AppErrLog ID")]
        [CSSPDisplayFR(DisplayFR = "AppErrLog ID")]
        [CSSPDescriptionEN(DescriptionEN = @"Contains the unique ""identifier on each row of the AppErrLogs table")]
        [CSSPDescriptionFR(DescriptionFR = @"Contient l'identifiant unique sur chaque ligne de la table AppErrLogs")]
        public int AppErrLogID { get; set; }
        [StringLength(100)]
        [CSSPDisplayEN(DisplayEN = "Tag")]
        [CSSPDisplayFR(DisplayFR = "Tag")]
        [CSSPDescriptionEN(DescriptionEN = @"Unique tag of the exception")]
        [CSSPDescriptionFR(DescriptionFR = @"Tag unique de l'exception")]
        public string Tag { get; set; }
        [Range(1, -1)]
        [CSSPDisplayEN(DisplayEN = "Line number")]
        [CSSPDisplayFR(DisplayFR = "Numéro de la ligne")]
        [CSSPDescriptionEN(DescriptionEN = @"Line number of the exception")]
        [CSSPDescriptionFR(DescriptionFR = @"Numéro de la ligne de l'exception")]
        public int LineNumber { get; set; }
        [CSSPDisplayEN(DisplayEN = "Source")]
        [CSSPDisplayFR(DisplayFR = "Source")]
        [CSSPDescriptionEN(DescriptionEN = @"Source of the exception")]
        [CSSPDescriptionFR(DescriptionFR = @"Source de l'exception")]
        public string Source { get; set; }
        [CSSPDisplayEN(DisplayEN = "Message")]
        [CSSPDisplayFR(DisplayFR = "Message")]
        [CSSPDescriptionEN(DescriptionEN = @"Message of the exception")]
        [CSSPDescriptionFR(DescriptionFR = @"Message de l'exception")]
        public string Message { get; set; }
        [CSSPAfter(Year = 1980)]
        [CSSPDisplayEN(DisplayEN = "Date and time")]
        [CSSPDisplayFR(DisplayFR = "Date et temps")]
        [CSSPDescriptionEN(DescriptionEN = @"Date and time of the exception")]
        [CSSPDescriptionFR(DescriptionFR = @"Date et temps de l'exception")]
        public DateTime DateTime_UTC { get; set; }
        #endregion Properties in DB

        #region Constructors
        public AppErrLog() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class AppErrLogWeb : AppErrLog
    {
        #region Properties for web information
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "", FillNeedLanguage = true)]
        [CSSPDisplayEN(DisplayEN = "Last update contact TVItemLanguage")]
        [CSSPDisplayFR(DisplayFR = "TVItemLanguage du contact ayant fait le dernière changement")]
        [CSSPDescriptionEN(DescriptionEN = @"Last update contact TVItemLanguage DB object")]
        [CSSPDescriptionFR(DescriptionFR = @"Object BD TVItemLanguage du contact ayant fait le dernière changement")]
        public TVItemLanguage LastUpdateContactTVItemLanguage { get; set; }
        #endregion Properties for web information

        #region Constructors
        public AppErrLogWeb() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class AppErrLogReport : AppErrLogWeb
    {
        #region Properties for report information
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "Report test")]
        [CSSPDisplayFR(DisplayFR = "Test report")]
        [CSSPDescriptionEN(DescriptionEN = @"Report test description")]
        [CSSPDescriptionFR(DescriptionFR = @"Description de test report")]
        public string AppErrLogReportTest { get; set; }
        #endregion Properties for report information

        #region Constructors
        public AppErrLogReport() : base()
        {
        }
        #endregion Constructors
    }
}
