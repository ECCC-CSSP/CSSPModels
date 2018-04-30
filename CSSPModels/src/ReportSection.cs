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
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "TVText", FillNeedLanguage = true)]
        [CSSPAllowNull]
        public string LastUpdateContactTVText { get; set; }
        [CSSPFill(FillTypeName = "ReportSectionLanguage", FillPlurial = "s", FillFieldID = "ReportSectionID", FillEqualField = "ReportSectionID", FillReturnField = "ReportSectionName", FillNeedLanguage = true)]
        [CSSPAllowNull]
        public string ReportSectionName { get; set; }
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
