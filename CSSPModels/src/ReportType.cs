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
    public partial class ReportType : LastUpdate
    {
        #region Properties in DB
        [Key]
        [CSSPDisplayEN(DisplayEN = "ReportType ID")]
        [CSSPDisplayFR(DisplayFR = "ReportType ID")]
        [CSSPDescriptionEN(DescriptionEN = @"Contains the unique ""identifier on each row of the ReportTypes table")]
        [CSSPDescriptionFR(DescriptionFR = @"Contient l'identifiant unique sur chaque ligne du tableau ReportTypes")]
        public int ReportTypeID { get; set; }
        [CSSPEnumType]
        public TVTypeEnum TVType { get; set; }
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
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "", FillNeedLanguage = true)]
        public TVItemLanguage LastUpdateContactTVItemLanguage { get; set; }
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
