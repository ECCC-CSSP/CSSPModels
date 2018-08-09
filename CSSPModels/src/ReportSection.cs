/*
 * Manually edited by Charles LeBlanc 
 * 
 */
using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace CSSPModels
{
    public partial class ReportSection : LastUpdate
    {
        #region Properties in DB
        [Key]
        [CSSPDisplayEN(DisplayEN = "ReportSection ID")]
        [CSSPDisplayFR(DisplayFR = "ReportSection ID")]
        [CSSPDescriptionEN(DescriptionEN = @"Contains the unique ""identifier on each row of the ReportSections table")]
        [CSSPDescriptionFR(DescriptionFR = @"Contient l'identifiant unique sur chaque ligne de la table ReportSections")]
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
    public partial class ReportSection_A : ReportSection
    {
        #region Properties
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "", FillNeedLanguage = true, FillIsList = false)]
        [CSSPDisplayEN(DisplayEN = "Last update contact TVItemLanguage")]
        [CSSPDisplayFR(DisplayFR = "TVItemLanguage du contact ayant fait le dernière changement")]
        [CSSPDescriptionEN(DescriptionEN = @"Last update contact TVItemLanguage DB object")]
        [CSSPDescriptionFR(DescriptionFR = @"Object BD TVItemLanguage du contact ayant fait le dernière changement")]
        public TVItemLanguage LastUpdateContactTVItemLanguage { get; set; }
        [CSSPFill(FillTypeName = "ReportSectionLanguage", FillPlurial = "s", FillFieldID = "ReportSectionID", FillEqualField = "ReportSectionID", FillReturnField = "", FillNeedLanguage = true, FillIsList = false)]
        public ReportSectionLanguage ReportSectionName { get; set; }
        [CSSPFill(FillTypeName = "ReportSectionLanguage", FillPlurial = "s", FillFieldID = "ReportSectionID", FillEqualField = "ReportSectionID", FillReturnField = "", FillNeedLanguage = true, FillIsList = false)]
        public ReportSectionLanguage ReportSectionText { get; set; }
        #endregion Properties

        #region Constructors
        public ReportSection_A() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class ReportSection_B : ReportSection_A
    {
        #region Properties
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "TVText", FillNeedLanguage = true, FillIsList = false)]
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "Report test")]
        [CSSPDisplayFR(DisplayFR = "Test report")]
        [CSSPDescriptionEN(DescriptionEN = @"Report test description")]
        [CSSPDescriptionFR(DescriptionFR = @"Description de test report")]
        public string ReportSectionReportTest { get; set; }
        #endregion Properties

        #region Constructors
        public ReportSection_B() : base()
        {
        }
        #endregion Constructors
    }
}
