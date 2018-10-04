/*
 * Auto generated from the CSSPCodeWriter.proj by clicking on the [\srcWithDoc\[ModelClassName]Generated.cs] button
 *
 * Do not edit this file.
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
    /// <summary>
    /// > [!NOTE]
    /// > 
    /// > <para>**DB properties for table ReportSections** : [ReportSectionID](CSSPModels.ReportSection.html#CSSPModels_ReportSection_ReportSectionID), [ReportTypeID](CSSPModels.ReportSection.html#CSSPModels_ReportSection_ReportTypeID), [TVItemID](CSSPModels.ReportSection.html#CSSPModels_ReportSection_TVItemID), [Ordinal](CSSPModels.ReportSection.html#CSSPModels_ReportSection_Ordinal), [IsStatic](CSSPModels.ReportSection.html#CSSPModels_ReportSection_IsStatic), [ParentReportSectionID](CSSPModels.ReportSection.html#CSSPModels_ReportSection_ParentReportSectionID), [Year](CSSPModels.ReportSection.html#CSSPModels_ReportSection_Year), [Locked](CSSPModels.ReportSection.html#CSSPModels_ReportSection_Locked), [TemplateReportSectionID](CSSPModels.ReportSection.html#CSSPModels_ReportSection_TemplateReportSectionID), [LastUpdateDate_UTC](CSSPModels.ReportSection.html#CSSPModels_ReportSection_LastUpdateDate_UTC), [LastUpdateContactTVItemID](CSSPModels.ReportSection.html#CSSPModels_ReportSection_LastUpdateContactTVItemID), </para>
    /// > <para>**Other properties** : [HasErrors](CSSPModels.ReportSection.html#CSSPModels_ReportSection_HasErrors), [ValidationResults](CSSPModels.ReportSection.html#CSSPModels_ReportSection_ValidationResults), </para>
    /// > 
    /// > <para>**Used by [CSSPServices](CSSPServices.html)** : [ReportSectionService](CSSPServices.ReportSectionService.html)</para>
    /// > <para>**Return to [CSSPModels](CSSPModels.html)**</para>
    /// </summary>
    public partial class ReportSection : LastUpdate
    {
        #region Properties in DB
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "ReportSection ID")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "ReportSection ID")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Contains the unique "identifier on each row of the ReportSections table")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Contient l'identifiant unique sur chaque ligne de la table ReportSections")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- ReportSection ID
        /// 
        /// **Display (fr)** --- ReportSection ID
        /// 
        /// **Description (en)** --- Contains the unique "identifier on each row of the ReportSections table
        /// 
        /// **Description (fr)** --- Contient l'identifiant unique sur chaque ligne de la table ReportSections
        /// </returns>
        [Key]
        [CSSPDisplayEN(DisplayEN = "ReportSection ID")]
        [CSSPDisplayFR(DisplayFR = "ReportSection ID")]
        [CSSPDescriptionEN(DescriptionEN = @"Contains the unique ""identifier on each row of the ReportSections table")]
        [CSSPDescriptionFR(DescriptionFR = @"Contient l'identifiant unique sur chaque ligne de la table ReportSections")]
        public int ReportSectionID { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPExist](CSSPModels.CSSPExistAttribute.html)(ExistTypeName = "ReportType", ExistPlurial = "s", ExistFieldID = "ReportTypeID")]</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Report type ID")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Type de raport ID")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Link to the ReportTypes table representing the report type")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Lien à la table ReportTypes représentant le type de raport")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Report type ID
        /// 
        /// **Display (fr)** --- Type de raport ID
        /// 
        /// **Description (en)** --- Link to the ReportTypes table representing the report type
        /// 
        /// **Description (fr)** --- Lien à la table ReportTypes représentant le type de raport
        /// </returns>
        [CSSPExist(ExistTypeName = "ReportType", ExistPlurial = "s", ExistFieldID = "ReportTypeID")]
        [CSSPDisplayEN(DisplayEN = "Report type ID")]
        [CSSPDisplayFR(DisplayFR = "Type de raport ID")]
        [CSSPDescriptionEN(DescriptionEN = @"Link to the ReportTypes table representing the report type")]
        [CSSPDescriptionFR(DescriptionFR = @"Lien à la table ReportTypes représentant le type de raport")]
        public int ReportTypeID { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPExist](CSSPModels.CSSPExistAttribute.html)(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID")]</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Item TVItemID")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "L'item TVItemID")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Link to the TVItems table representing the item")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Lien à la table TVItems représentant l'item")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Item TVItemID
        /// 
        /// **Display (fr)** --- L'item TVItemID
        /// 
        /// **Description (en)** --- Link to the TVItems table representing the item
        /// 
        /// **Description (fr)** --- Lien à la table TVItems représentant l'item
        /// </returns>
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID")]
        [CSSPDisplayEN(DisplayEN = "Item TVItemID")]
        [CSSPDisplayFR(DisplayFR = "L'item TVItemID")]
        [CSSPDescriptionEN(DescriptionEN = @"Link to the TVItems table representing the item")]
        [CSSPDescriptionFR(DescriptionFR = @"Lien à la table TVItems représentant l'item")]
        public int? TVItemID { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Ordinal")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Ordre")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Ordinal")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Ordre")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Ordinal
        /// 
        /// **Display (fr)** --- Ordre
        /// 
        /// **Description (en)** --- Ordinal
        /// 
        /// **Description (fr)** --- Ordre
        /// </returns>
        [Range(0, 1000)]
        [CSSPDisplayEN(DisplayEN = "Ordinal")]
        [CSSPDisplayFR(DisplayFR = "Ordre")]
        [CSSPDescriptionEN(DescriptionEN = @"Ordinal")]
        [CSSPDescriptionFR(DescriptionFR = @"Ordre")]
        public int Ordinal { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Is static")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Est statique")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Is static --- the text will not change in time")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Est statique --- le texte ne changera pas dans le temps")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Is static
        /// 
        /// **Display (fr)** --- Est statique
        /// 
        /// **Description (en)** --- Is static --- the text will not change in time
        /// 
        /// **Description (fr)** --- Est statique --- le texte ne changera pas dans le temps
        /// </returns>
        [CSSPDisplayEN(DisplayEN = "Is static")]
        [CSSPDisplayFR(DisplayFR = "Est statique")]
        [CSSPDescriptionEN(DescriptionEN = @"Is static --- the text will not change in time")]
        [CSSPDescriptionFR(DescriptionFR = @"Est statique --- le texte ne changera pas dans le temps")]
        public bool IsStatic { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPExist](CSSPModels.CSSPExistAttribute.html)(ExistTypeName = "ReportSection", ExistPlurial = "s", ExistFieldID = "ReportSectionID")]</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Parent report section ID")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Section du raport du parent ID")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Parent report section ID")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Section du raport du parent ID")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Parent report section ID
        /// 
        /// **Display (fr)** --- Section du raport du parent ID
        /// 
        /// **Description (en)** --- Parent report section ID
        /// 
        /// **Description (fr)** --- Section du raport du parent ID
        /// </returns>
        [CSSPExist(ExistTypeName = "ReportSection", ExistPlurial = "s", ExistFieldID = "ReportSectionID")]
        [CSSPDisplayEN(DisplayEN = "Parent report section ID")]
        [CSSPDisplayFR(DisplayFR = "Section du raport du parent ID")]
        [CSSPDescriptionEN(DescriptionEN = @"Parent report section ID")]
        [CSSPDescriptionFR(DescriptionFR = @"Section du raport du parent ID")]
        public int? ParentReportSectionID { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Year")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Année")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Year for which the text is applicable")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Année dont le texte est applicable")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Year
        /// 
        /// **Display (fr)** --- Année
        /// 
        /// **Description (en)** --- Year for which the text is applicable
        /// 
        /// **Description (fr)** --- Année dont le texte est applicable
        /// </returns>
        [Range(1979, 2050)]
        [CSSPDisplayEN(DisplayEN = "Year")]
        [CSSPDisplayFR(DisplayFR = "Année")]
        [CSSPDescriptionEN(DescriptionEN = @"Year for which the text is applicable")]
        [CSSPDescriptionFR(DescriptionFR = @"Année dont le texte est applicable")]
        public int? Year { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Locked")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Barré")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Locked --- not currently used")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Barré --- pas utilisé encore")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Locked
        /// 
        /// **Display (fr)** --- Barré
        /// 
        /// **Description (en)** --- Locked --- not currently used
        /// 
        /// **Description (fr)** --- Barré --- pas utilisé encore
        /// </returns>
        [CSSPDisplayEN(DisplayEN = "Locked")]
        [CSSPDisplayFR(DisplayFR = "Barré")]
        [CSSPDescriptionEN(DescriptionEN = @"Locked --- not currently used")]
        [CSSPDescriptionFR(DescriptionFR = @"Barré --- pas utilisé encore")]
        public bool Locked { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPExist](CSSPModels.CSSPExistAttribute.html)(ExistTypeName = "ReportSection", ExistPlurial = "s", ExistFieldID = "ReportSectionID")]</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Template report section ID")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Gabari de la section du raport ID")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Template report section ID --- not currently used")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Gabari de la section du raport ID --- pas utilisé encore")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Template report section ID
        /// 
        /// **Display (fr)** --- Gabari de la section du raport ID
        /// 
        /// **Description (en)** --- Template report section ID --- not currently used
        /// 
        /// **Description (fr)** --- Gabari de la section du raport ID --- pas utilisé encore
        /// </returns>
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
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPFill](CSSPModels.CSSPFillAttribute.html)(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "", FillNeedLanguage = true, FillIsList = false)]</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Last update contact TVItemLanguage")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "TVItemLanguage du contact ayant fait le dernière changement")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Last update contact TVItemLanguage DB object")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Object BD TVItemLanguage du contact ayant fait le dernière changement")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Last update contact TVItemLanguage
        /// 
        /// **Display (fr)** --- TVItemLanguage du contact ayant fait le dernière changement
        /// 
        /// **Description (en)** --- Last update contact TVItemLanguage DB object
        /// 
        /// **Description (fr)** --- Object BD TVItemLanguage du contact ayant fait le dernière changement
        /// </returns>
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "", FillNeedLanguage = true, FillIsList = false)]
        [CSSPDisplayEN(DisplayEN = "Last update contact TVItemLanguage")]
        [CSSPDisplayFR(DisplayFR = "TVItemLanguage du contact ayant fait le dernière changement")]
        [CSSPDescriptionEN(DescriptionEN = @"Last update contact TVItemLanguage DB object")]
        [CSSPDescriptionFR(DescriptionFR = @"Object BD TVItemLanguage du contact ayant fait le dernière changement")]
        public TVItemLanguage LastUpdateContactTVItemLanguage { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPFill](CSSPModels.CSSPFillAttribute.html)(FillTypeName = "ReportSectionLanguage", FillPlurial = "s", FillFieldID = "ReportSectionID", FillEqualField = "ReportSectionID", FillReturnField = "", FillNeedLanguage = true, FillIsList = false)]</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Report section name")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Nom de la section du raport")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Report section name")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Nom de la section du raport")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Report section name
        /// 
        /// **Display (fr)** --- Nom de la section du raport
        /// 
        /// **Description (en)** --- Report section name
        /// 
        /// **Description (fr)** --- Nom de la section du raport
        /// </returns>
        [CSSPFill(FillTypeName = "ReportSectionLanguage", FillPlurial = "s", FillFieldID = "ReportSectionID", FillEqualField = "ReportSectionID", FillReturnField = "", FillNeedLanguage = true, FillIsList = false)]
        [CSSPDisplayEN(DisplayEN = "Report section name")]
        [CSSPDisplayFR(DisplayFR = "Nom de la section du raport")]
        [CSSPDescriptionEN(DescriptionEN = @"Report section name")]
        [CSSPDescriptionFR(DescriptionFR = @"Nom de la section du raport")]
        public ReportSectionLanguage ReportSectionName { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPFill](CSSPModels.CSSPFillAttribute.html)(FillTypeName = "ReportSectionLanguage", FillPlurial = "s", FillFieldID = "ReportSectionID", FillEqualField = "ReportSectionID", FillReturnField = "", FillNeedLanguage = true, FillIsList = false)]</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Report section text")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Texte de la section du raport")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Report section text")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Texte de la section du raport")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Report section text
        /// 
        /// **Display (fr)** --- Texte de la section du raport
        /// 
        /// **Description (en)** --- Report section text
        /// 
        /// **Description (fr)** --- Texte de la section du raport
        /// </returns>
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
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPFill](CSSPModels.CSSPFillAttribute.html)(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "TVText", FillNeedLanguage = true, FillIsList = false)]</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Report test")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Test report")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Report test description")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Description de test report")]</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Report test
        /// 
        /// **Display (fr)** --- Test report
        /// 
        /// **Description (en)** --- Report test description
        /// 
        /// **Description (fr)** --- Description de test report
        /// </returns>
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
