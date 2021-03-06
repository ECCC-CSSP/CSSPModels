﻿/*
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
    public partial class LabSheet : LastUpdate
    {
        #region Properties in DB
        [Key]
        [CSSPDisplayEN(DisplayEN = "LabSheet ID")]
        [CSSPDisplayFR(DisplayFR = "LabSheet ID")]
        [CSSPDescriptionEN(DescriptionEN = @"Contains the unique ""identifier on each row of the LabSheets table")]
        [CSSPDescriptionFR(DescriptionFR = @"Contient l'identifiant unique sur chaque ligne de la table LabSheets")]
        public int LabSheetID { get; set; }
        [Range(1, -1)]
        [CSSPDisplayEN(DisplayEN = "Other server lab sheet ID")]
        [CSSPDisplayFR(DisplayFR = "ID de la feuille de laboratoire de l'autre server")]
        [CSSPDescriptionEN(DescriptionEN = @"Other server lab sheet ID")]
        [CSSPDescriptionFR(DescriptionFR = @"ID de la feuille de laboratoire de l'autre server")]
        public int OtherServerLabSheetID { get; set; }
        [CSSPExist(ExistTypeName = "SamplingPlan", ExistPlurial = "s", ExistFieldID = "SamplingPlanID")]
        [CSSPDisplayEN(DisplayEN = "Sampling plan")]
        [CSSPDisplayFR(DisplayFR = "Plan d'échantillonnage")]
        [CSSPDescriptionEN(DescriptionEN = @"Link to the SamplingPlan table representing the sampling plan")]
        [CSSPDescriptionFR(DescriptionFR = @"Lien à la table SamplingPlan représentant le plan d'échantillonnage")]
        public int SamplingPlanID { get; set; }
        [StringLength(250, MinimumLength = 1)]
        [CSSPDisplayEN(DisplayEN = "Sampling plan name")]
        [CSSPDisplayFR(DisplayFR = "Nom du plan d'échantillonnage")]
        [CSSPDescriptionEN(DescriptionEN = @"Sampling plan name")]
        [CSSPDescriptionFR(DescriptionFR = @"Nom du plan d'échantillonnage")]
        public string SamplingPlanName { get; set; }
        [Range(1980, -1)]
        [CSSPDisplayEN(DisplayEN = "Year of run")]
        [CSSPDisplayFR(DisplayFR = "Année de la tournée")]
        [CSSPDescriptionEN(DescriptionEN = @"Year of run")]
        [CSSPDescriptionFR(DescriptionFR = @"Année de la tournée")]
        public int Year { get; set; }
        [Range(1, 12)]
        [CSSPDisplayEN(DisplayEN = "Month of run")]
        [CSSPDisplayFR(DisplayFR = "Mois de la tournée")]
        [CSSPDescriptionEN(DescriptionEN = @"Month of run")]
        [CSSPDescriptionFR(DescriptionFR = @"Mois de la tournée")]
        public int Month { get; set; }
        [Range(1, 31)]
        [CSSPDisplayEN(DisplayEN = "Day of run")]
        [CSSPDisplayFR(DisplayFR = "Jour de la tournée")]
        [CSSPDescriptionEN(DescriptionEN = @"Day of run")]
        [CSSPDescriptionFR(DescriptionFR = @"Jour de la tournée")]
        public int Day { get; set; }
        [Range(1, 100)]
        [CSSPDisplayEN(DisplayEN = "Run number")]
        [CSSPDisplayFR(DisplayFR = "Numéro de la tournée")]
        [CSSPDescriptionEN(DescriptionEN = @"Run number")]
        [CSSPDescriptionFR(DescriptionFR = @"Numéro de la tournée")]
        public int RunNumber { get; set; }
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "20")]
        [CSSPDisplayEN(DisplayEN = "Subsector TVItemID")]
        [CSSPDisplayFR(DisplayFR = "Subsector TVItemID")]
        [CSSPDescriptionEN(DescriptionEN = @"Link to the TVItems table with the unique identifier")]
        [CSSPDescriptionFR(DescriptionFR = @"Lien à la table TVItems avec l'identifiant unique")]
        public int SubsectorTVItemID { get; set; }
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "31")]
        [CSSPDisplayEN(DisplayEN = "Run TVItemID")]
        [CSSPDisplayFR(DisplayFR = "Trounée TVItemID")]
        [CSSPDescriptionEN(DescriptionEN = @"Link to the TVItems table with the unique identifier")]
        [CSSPDescriptionFR(DescriptionFR = @"Lien à la table TVItems avec l'identifiant unique")]
        public int? MWQMRunTVItemID { get; set; }
        [CSSPEnumType]
        [CSSPDisplayEN(DisplayEN = "Sampling plan type")]
        [CSSPDisplayFR(DisplayFR = "Type de plan d'échantillonnage")]
        [CSSPDescriptionEN(DescriptionEN = @"Sampling plan type")]
        [CSSPDescriptionFR(DescriptionFR = @"Type de plan d'échantillonnage")]
        public SamplingPlanTypeEnum SamplingPlanType { get; set; }
        [CSSPEnumType]
        [CSSPDisplayEN(DisplayEN = "Sample type")]
        [CSSPDisplayFR(DisplayFR = "Type d'échantillonnage")]
        [CSSPDescriptionEN(DescriptionEN = @"Sample type")]
        [CSSPDescriptionFR(DescriptionFR = @"Type d'échantillonnage")]
        public SampleTypeEnum SampleType { get; set; }
        [CSSPEnumType]
        [CSSPDisplayEN(DisplayEN = "Lab sheet type")]
        [CSSPDisplayFR(DisplayFR = "Type de feuille de laboratoire")]
        [CSSPDescriptionEN(DescriptionEN = @"Lab sheet type")]
        [CSSPDescriptionFR(DescriptionFR = @"Type de feuille de laboratoire")]
        public LabSheetTypeEnum LabSheetType { get; set; }
        [CSSPEnumType]
        [CSSPDisplayEN(DisplayEN = "Lab sheet status")]
        [CSSPDisplayFR(DisplayFR = "État de la feuille de laboratoire")]
        [CSSPDescriptionEN(DescriptionEN = @"Lab sheet statue")]
        [CSSPDescriptionFR(DescriptionFR = @"État de la feuille de laboratoire")]
        public LabSheetStatusEnum LabSheetStatus { get; set; }
        [StringLength(250, MinimumLength = 1)]
        [CSSPDisplayEN(DisplayEN = "File name")]
        [CSSPDisplayFR(DisplayFR = "Nom de la filière")]
        [CSSPDescriptionEN(DescriptionEN = @"File name")]
        [CSSPDescriptionFR(DescriptionFR = @"Nom de la filière")]
        public string FileName { get; set; }
        [CSSPAfter(Year = 1980)]
        [CSSPDisplayEN(DisplayEN = "File last modified date (local)")]
        [CSSPDisplayFR(DisplayFR = "Date du dernier changement de la filière (local)")]
        [CSSPDescriptionEN(DescriptionEN = @"File last modified date (local)")]
        [CSSPDescriptionFR(DescriptionFR = @"Date du dernier changement de la filière (local)")]
        public DateTime FileLastModifiedDate_Local { get; set; }
        [CSSPDisplayEN(DisplayEN = "File content")]
        [CSSPDisplayFR(DisplayFR = "Contenu de la filière")]
        [CSSPDescriptionEN(DescriptionEN = @"File content")]
        [CSSPDescriptionFR(DescriptionFR = @"Contenu de la filière")]
        public string FileContent { get; set; }
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "5")]
        [CSSPDisplayEN(DisplayEN = "Accepted or rejected by Contact TVItemID")]
        [CSSPDisplayFR(DisplayFR = "Accepté ou rejeté par contact TVItemID")]
        [CSSPDescriptionEN(DescriptionEN = @"Accepted or rejected by Contact TVItemID")]
        [CSSPDescriptionFR(DescriptionFR = @"Accepté ou rejeté par contact TVItemID")]
        public int? AcceptedOrRejectedByContactTVItemID { get; set; }
        [CSSPAfter(Year = 1980)]
        [CSSPDisplayEN(DisplayEN = "Accepted or rejected date (local)")]
        [CSSPDisplayFR(DisplayFR = "Date de l'acceptation ou rejet (local)")]
        [CSSPDescriptionEN(DescriptionEN = @"Accepted or rejected date (local)")]
        [CSSPDescriptionFR(DescriptionFR = @"Date de l'acceptation ou rejet (local)")]
        public DateTime? AcceptedOrRejectedDateTime { get; set; }
        [StringLength(250)]
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "Reject reason")]
        [CSSPDisplayFR(DisplayFR = "Raison du rejet")]
        [CSSPDescriptionEN(DescriptionEN = @"Reject reason")]
        [CSSPDescriptionFR(DescriptionFR = @"Raison du rejet")]
        public string RejectReason { get; set; }
        #endregion Properties in DB

        #region Constructors
        public LabSheet() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class LabSheetExtraA : LabSheet
    {
        #region Properties
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "SubsectorTVItemID", FillReturnField = "TVText", FillNeedLanguage = true, FillIsList = false)]
        [CSSPDisplayEN(DisplayEN = "Subsector text")]
        [CSSPDisplayFR(DisplayFR = "Texte du sous-secteur")]
        [CSSPDescriptionEN(DescriptionEN = @"Subsector text")]
        [CSSPDescriptionFR(DescriptionFR = @"Texte du sous-secteur")]
        public string SubsectorText { get; set; }
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "MWQMRunTVItemID", FillReturnField = "TVText", FillNeedLanguage = true, FillIsList = false)]
        [CSSPDisplayEN(DisplayEN = "Run text")]
        [CSSPDisplayFR(DisplayFR = "Texte de la tournée")]
        [CSSPDescriptionEN(DescriptionEN = @"Run text")]
        [CSSPDescriptionFR(DescriptionFR = @"Texte de la tournée")]
        public string MWQMRunText { get; set; }
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "AcceptedOrRejectedByContactTVItemID", FillReturnField = "TVText", FillNeedLanguage = true, FillIsList = false)]
        [CSSPDisplayEN(DisplayEN = "Accepted or rejected contact name")]
        [CSSPDisplayFR(DisplayFR = "Nom du contact qui a accepté ou rejeté")]
        [CSSPDescriptionEN(DescriptionEN = @"Accepted or rejected contact name")]
        [CSSPDescriptionFR(DescriptionFR = @"Nom du contact qui a accepté ou rejeté")]
        public string AcceptedOrRejectedByContactName { get; set; }
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "TVText", FillNeedLanguage = true, FillIsList = false)]
        [CSSPDisplayEN(DisplayEN = "Last update contact name")]
        [CSSPDisplayFR(DisplayFR = "Nom du contact ayant fait le dernière changement")]
        [CSSPDescriptionEN(DescriptionEN = @"Last update contact name")]
        [CSSPDescriptionFR(DescriptionFR = @"Nom du contact ayant fait le dernière changement")]
        public string LastUpdateContactText { get; set; }
        [CSSPEnumTypeText(EnumTypeName = "SamplingPlanTypeEnum", EnumType = "SamplingPlanType")]
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "Sampling plan type text")]
        [CSSPDisplayFR(DisplayFR = "Texte du type de plan d'échantillonnage")]
        [CSSPDescriptionEN(DescriptionEN = @"Sampling plan type text")]
        [CSSPDescriptionFR(DescriptionFR = @"Texte du type de plan d'échantillonnage")]
        public string SamplingPlanTypeText { get; set; }
        [CSSPEnumTypeText(EnumTypeName = "SampleTypeEnum", EnumType = "SampleType")]
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "Sampling type text")]
        [CSSPDisplayFR(DisplayFR = "Texte du type d'échantillonnage")]
        [CSSPDescriptionEN(DescriptionEN = @"Sampling type text")]
        [CSSPDescriptionFR(DescriptionFR = @"Texte du type d'échantillonnage")]
        public string SampleTypeText { get; set; }
        [CSSPEnumTypeText(EnumTypeName = "LabSheetTypeEnum", EnumType = "LabSheetType")]
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "Lab sheet type text")]
        [CSSPDisplayFR(DisplayFR = "Texte du type de feuille de laboratoire")]
        [CSSPDescriptionEN(DescriptionEN = @"Lab sheet type text")]
        [CSSPDescriptionFR(DescriptionFR = @"Texte du type de feuille de laboratoire")]
        public string LabSheetTypeText { get; set; }
        [CSSPEnumTypeText(EnumTypeName = "LabSheetStatusEnum", EnumType = "LabSheetStatus")]
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "Lab sheet status text")]
        [CSSPDisplayFR(DisplayFR = "Texte de l'état de la feuille de laboratoire")]
        [CSSPDescriptionEN(DescriptionEN = @"Lab sheet status text")]
        [CSSPDescriptionFR(DescriptionFR = @"Texte de l'état de la feuille de laboratoire")]
        public string LabSheetStatusText { get; set; }
        #endregion Properties

        #region Constructors
        public LabSheetExtraA() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class LabSheetExtraB : LabSheetExtraA
    {
        #region Properties
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "TVText", FillNeedLanguage = true, FillIsList = false)]
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "Report test")]
        [CSSPDisplayFR(DisplayFR = "Test report")]
        [CSSPDescriptionEN(DescriptionEN = @"Report test description")]
        [CSSPDescriptionFR(DescriptionFR = @"Description de test report")]
        public string LabSheetReportTest { get; set; }
        #endregion Properties

        #region Constructors
        public LabSheetExtraB() : base()
        {
        }
        #endregion Constructors
    }
}
