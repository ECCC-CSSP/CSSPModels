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
    public partial class ReportSection : LastUpdate
    {
        #region Properties in DB
        [Key]
        [CSSPDisplayEN(DisplayEN = "ReportSection ID")]
        [CSSPDisplayFR(DisplayFR = "ReportSection ID")]
        [CSSPDescriptionEN(DescriptionEN = @"Contains the unique ""identifier on each row of the ReportSections table")]
        [CSSPDescriptionFR(DescriptionFR = @"Contient l'identifiant unique sur chaque ligne du tableau ReportSections")]
        public int ReportSectionID { get; set; }
        [CSSPExist(ExistTypeName = "ReportType", ExistPlurial = "s", ExistFieldID = "ReportTypeID")]
        public int ReportTypeID { get; set; }
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID")]
        public int? TVItemID { get; set; }
        [Range(0, 1000)]
        public int Ordinal { get; set; }
        public bool IsStatic { get; set; }
        [CSSPExist(ExistTypeName = "ReportSection", ExistPlurial = "s", ExistFieldID = "ReportSectionID")]
        public int? ParentReportSectionID { get; set; }
        [Range(1979, 2050)]
        public int? Year { get; set; }
        public bool Locked { get; set; }
        [CSSPExist(ExistTypeName = "ReportSection", ExistPlurial = "s", ExistFieldID = "ReportSectionID")]
        public int? TemplateReportSectionID { get; set; }
        #endregion Properties in DB

        #region Constructors
        public ReportSection() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class ReportSectionWeb : ReportSection
    {
        #region Properties for web information
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "", FillNeedLanguage = true)]
        public TVItemLanguage LastUpdateContactTVItemLanguage { get; set; }
        [CSSPFill(FillTypeName = "ReportSectionLanguage", FillPlurial = "s", FillFieldID = "ReportSectionID", FillEqualField = "ReportSectionID", FillReturnField = "", FillNeedLanguage = true)]
        public ReportSectionLanguage ReportSectionName { get; set; }
        [CSSPFill(FillTypeName = "ReportSectionLanguage", FillPlurial = "s", FillFieldID = "ReportSectionID", FillEqualField = "ReportSectionID", FillReturnField = "", FillNeedLanguage = true)]
        public ReportSectionLanguage ReportSectionText { get; set; }
        #endregion Properties for web information

        #region Constructors
        public ReportSectionWeb() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class ReportSectionReport : ReportSectionWeb
    {
        #region Properties for report information
        [CSSPAllowNull]
        public string ReportSectionReportTest { get; set; }
        #endregion Properties for report information

        #region Constructors
        public ReportSectionReport() : base()
        {
        }
        #endregion Constructors
    }
}
