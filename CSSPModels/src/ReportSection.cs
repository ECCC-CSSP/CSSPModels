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
        [CSSPDisplayEN(DisplayEN = "Report type ID")]
        [CSSPDisplayFR(DisplayFR = "Type de raport ID")]
        [CSSPDescriptionEN(DescriptionEN = @"Link to the ReportTypes table representing the report type")]
        [CSSPDescriptionFR(DescriptionFR = @"Lien à la table ReportTypes représentant le type de raport")]
        public int ReportTypeID { get; set; }
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID")]
        [CSSPDisplayEN(DisplayEN = "Item TVItemID")]
        [CSSPDisplayFR(DisplayFR = "L'item TVItemID")]
        [CSSPDescriptionEN(DescriptionEN = @"Link to the TVItems table representing the item")]
        [CSSPDescriptionFR(DescriptionFR = @"Lien à la table TVItems représentant l'item")]
        public int? TVItemID { get; set; }
        [Range(0, 1000)]
        [CSSPDisplayEN(DisplayEN = "Ordinal")]
        [CSSPDisplayFR(DisplayFR = "Ordre")]
        [CSSPDescriptionEN(DescriptionEN = @"Ordinal")]
        [CSSPDescriptionFR(DescriptionFR = @"Ordre")]
        public int Ordinal { get; set; }
        [CSSPDisplayEN(DisplayEN = "Is static")]
        [CSSPDisplayFR(DisplayFR = "Est statique")]
        [CSSPDescriptionEN(DescriptionEN = @"Is static --- the text will not change in time")]
        [CSSPDescriptionFR(DescriptionFR = @"Est statique --- le texte ne changera pas dans le temps")]
        public bool IsStatic { get; set; }
        [CSSPExist(ExistTypeName = "ReportSection", ExistPlurial = "s", ExistFieldID = "ReportSectionID")]
        [CSSPDisplayEN(DisplayEN = "Parent report section ID")]
        [CSSPDisplayFR(DisplayFR = "Section du raport du parent ID")]
        [CSSPDescriptionEN(DescriptionEN = @"Parent report section ID")]
        [CSSPDescriptionFR(DescriptionFR = @"Section du raport du parent ID")]
        public int? ParentReportSectionID { get; set; }
        [Range(1979, 2050)]
        [CSSPDisplayEN(DisplayEN = "Year")]
        [CSSPDisplayFR(DisplayFR = "Année")]
        [CSSPDescriptionEN(DescriptionEN = @"Year for which the text is applicable")]
        [CSSPDescriptionFR(DescriptionFR = @"Année dont le texte est applicable")]
        public int? Year { get; set; }
        [CSSPDisplayEN(DisplayEN = "Locked")]
        [CSSPDisplayFR(DisplayFR = "Barré")]
        [CSSPDescriptionEN(DescriptionEN = @"Locked --- not currently used")]
        [CSSPDescriptionFR(DescriptionFR = @"Barré --- pas utilisé encore")]
        public bool Locked { get; set; }
        [CSSPExist(ExistTypeName = "ReportSection", ExistPlurial = "s", ExistFieldID = "ReportSectionID")]
        [CSSPDisplayEN(DisplayEN = "Template report section ID")]
        [CSSPDisplayFR(DisplayFR = "Gabari de la section du raport ID")]
        [CSSPDescriptionEN(DescriptionEN = @"Template report section ID --- not currently used")]
        [CSSPDescriptionFR(DescriptionFR = @"Gabari de la section du raport ID --- pas utilisé encore")]
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
        [CSSPDisplayEN(DisplayEN = "Report section name")]
        [CSSPDisplayFR(DisplayFR = "Nom de la section du raport")]
        [CSSPDescriptionEN(DescriptionEN = @"Report section name")]
        [CSSPDescriptionFR(DescriptionFR = @"Nom de la section du raport")]
        public ReportSectionLanguage ReportSectionName { get; set; }
        [CSSPFill(FillTypeName = "ReportSectionLanguage", FillPlurial = "s", FillFieldID = "ReportSectionID", FillEqualField = "ReportSectionID", FillReturnField = "", FillNeedLanguage = true, FillIsList = false)]
        [CSSPDisplayEN(DisplayEN = "Report section text")]
        [CSSPDisplayFR(DisplayFR = "Texte de la section du raport")]
        [CSSPDescriptionEN(DescriptionEN = @"Report section text")]
        [CSSPDescriptionFR(DescriptionFR = @"Texte de la section du raport")]
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
