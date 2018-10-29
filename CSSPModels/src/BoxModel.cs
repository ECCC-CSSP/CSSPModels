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
    public partial class BoxModel : LastUpdate
    {
        #region Properties in DB
        [Key]
        [CSSPDisplayEN(DisplayEN = "BoxModel ID")]
        [CSSPDisplayFR(DisplayFR = "BoxModel ID")]
        [CSSPDescriptionEN(DescriptionEN = @"Contains the unique ""identifier on each row of the BoxModels table")]
        [CSSPDescriptionFR(DescriptionFR = @"Contient l'identifiant unique sur chaque ligne de la table BoxModels")]
        public int BoxModelID { get; set; }
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "10")]
        [CSSPDisplayEN(DisplayEN = "Infrastructure")]
        [CSSPDisplayFR(DisplayFR = "Infrastructure")]
        [CSSPDescriptionEN(DescriptionEN = @"Link to the TVItems table representing the infrastructure")]
        [CSSPDescriptionFR(DescriptionFR = @"Lien à la table TVItems représentant la infrastructure")]
        public int InfrastructureTVItemID { get; set; }
        [Range(0.0D, 10000.0D)]
        [CSSPDisplayEN(DisplayEN = "Discharge (m3/d)")]
        [CSSPDisplayFR(DisplayFR = "Débit (m3/j)")]
        [CSSPDescriptionEN(DescriptionEN = @"Discharge (m3/d) spilled by the infrastructure")]
        [CSSPDescriptionFR(DescriptionFR = @"Débit (m3/d) déversé par l' infrastructure")]
        public double Discharge_m3_day { get; set; }
        [Range(0.0D, 1000.0D)]
        [CSSPDisplayEN(DisplayEN = "Depth (m)")]
        [CSSPDisplayFR(DisplayFR = "Profondeur (m)")]
        [CSSPDescriptionEN(DescriptionEN = @"Average depth (m) of water in the vicinity of the spill")]
        [CSSPDescriptionFR(DescriptionFR = @"Profondeur moyenne (m) des eaux aux environs du déversement")]
        public double Depth_m { get; set; }
        [Range(-15.0D, 40.0D)]
        [CSSPDisplayEN(DisplayEN = "Temperature (deg C)")]
        [CSSPDisplayFR(DisplayFR = "Température (dég C)")]
        [CSSPDescriptionEN(DescriptionEN = @"Temperature (deg C) of water in the vicinity of the spill")]
        [CSSPDescriptionFR(DescriptionFR = @"Température (deg C) des eaux aux environs du déversement")]
        public double Temperature_C { get; set; }
        [Range(0, 10000000)]
        [CSSPDisplayEN(DisplayEN = "Dilution (MPN / 100 mL)")]
        [CSSPDisplayFR(DisplayFR = "Dilution (NPP / 100 mL)")]
        [CSSPDescriptionEN(DescriptionEN = @"Dilution (MPN / 100 mL) level to uptain in the vicinity of the spill")]
        [CSSPDescriptionFR(DescriptionFR = @"Niveau de dilution (NPP / 100 mL) à obtenir aux environs du déversement")]
        public int Dilution { get; set; }
        [Range(0.0D, 100.0D)]
        [CSSPDisplayEN(DisplayEN = "Decay rate (/day)")]
        [CSSPDisplayFR(DisplayFR = "Taux de décroissance (/jour)")]
        [CSSPDescriptionEN(DescriptionEN = @"Average decay rate (/day) of the fecal coliform colonies")]
        [CSSPDescriptionFR(DescriptionFR = @"Taux de décroissance moyen (/jour) des colonies de coliform fécaux")]
        public double DecayRate_per_day { get; set; }
        [Range(0, 10000000)]
        [CSSPDisplayEN(DisplayEN = "Fecal coliform concentration of untreaded waste water (MPN / 100 mL)")]
        [CSSPDisplayFR(DisplayFR = "Concentration de coliform fécaux des eaux usées non traité (NPP / 100 mL)")]
        [CSSPDescriptionEN(DescriptionEN = @"Fecal coliform concentration of untreaded waste water (MPN / 100 mL)")]
        [CSSPDescriptionFR(DescriptionFR = @"Concentration de coliform fécaux des eaux usées non traité (NPP / 100 mL)")]
        public int FCUntreated_MPN_100ml { get; set; }
        [Range(0, 10000000)]
        [CSSPDisplayEN(DisplayEN = "Fecal coliform concentration of pre-disinfected waste water (MPN / 100 mL)")]
        [CSSPDisplayFR(DisplayFR = "Concentration de coliform fécaux des eaux usées pré-désinfecté (NPP / 100 mL)")]
        [CSSPDescriptionEN(DescriptionEN = @"Fecal coliform concentration of pre-disinfected waste water (MPN / 100 mL)")]
        [CSSPDescriptionFR(DescriptionFR = @"Concentration de coliform fécaux des eaux usées pré-désinfecté (NPP / 100 mL)")]
        public int FCPreDisinfection_MPN_100ml { get; set; }
        [Range(0, 10000000)]
        [CSSPDisplayEN(DisplayEN = "Fecal coliform concentration objective after dilution (MPN / 100 mL)")]
        [CSSPDisplayFR(DisplayFR = "Objectif de concentration de coliform fécaux apres dilution (NPP / 100 mL)")]
        [CSSPDescriptionEN(DescriptionEN = @"Fecal coliform concentration objective after dilution (MPN / 100 mL)")]
        [CSSPDescriptionFR(DescriptionFR = @"Objectif de concentration de coliform fécaux apres dilution (NPP / 100 mL)")]
        public int Concentration_MPN_100ml { get; set; }
        [Range(0.0D, -1.0D)]
        [CSSPDisplayEN(DisplayEN = "T90 (hour)")]
        [CSSPDisplayFR(DisplayFR = "T90 (heur)")]
        [CSSPDescriptionEN(DescriptionEN = @"Time (hour) required for 90 % of the fecal coliform colonies to die off")]
        [CSSPDescriptionFR(DescriptionFR = @"Temps (heur) requis pour que 90% des colonies de coliformes fécaux meurent")]
        public double T90_hour { get; set; }
        [Range(0.0D, 24.0D)]
        [CSSPDisplayEN(DisplayEN = "Flow duration (hour/day)")]
        [CSSPDisplayFR(DisplayFR = "Durée de l'écoulement (heur/jour)")]
        [CSSPDescriptionEN(DescriptionEN = @"Flow duration (hour/day)")]
        [CSSPDescriptionFR(DescriptionFR = @"Durée de l'écoulement (heur/jour)")]
        public double FlowDuration_hour { get; set; }
        #endregion Properties in DB

        #region Constructors
        public BoxModel() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class BoxModelExtraA : BoxModel
    {
        #region Properties
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "InfrastructureTVItemID", FillReturnField = "TVText", FillNeedLanguage = true, FillIsList = false)]
        [CSSPDisplayEN(DisplayEN = "Infrastructure TVItemLanguage")]
        [CSSPDisplayFR(DisplayFR = "TVItemLanguage de l'infrastructure")]
        [CSSPDescriptionEN(DescriptionEN = @"Infrastructure TVItemLanguage DB object")]
        [CSSPDescriptionFR(DescriptionFR = @"Object BD TVItemLanguage de l'infrastructure")]
        public string InfrastructureText { get; set; }
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "TVText", FillNeedLanguage = true, FillIsList = false)]
        [CSSPDisplayEN(DisplayEN = "Last update contact name")]
        [CSSPDisplayFR(DisplayFR = "Nom du contact ayant fait le dernière changement")]
        [CSSPDescriptionEN(DescriptionEN = @"Last update contact name")]
        [CSSPDescriptionFR(DescriptionFR = @"Nom du contact ayant fait le dernière changement")]
        public string LastUpdateContactText { get; set; }
        #endregion Properties

        #region Constructors
        public BoxModelExtraA() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class BoxModelExtraB : BoxModelExtraA
    {
        #region Properties
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "TVText", FillNeedLanguage = true, FillIsList = false)]
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "Report test")]
        [CSSPDisplayFR(DisplayFR = "Test report")]
        [CSSPDescriptionEN(DescriptionEN = @"Report test description")]
        [CSSPDescriptionFR(DescriptionFR = @"Description de test report")]
        public string BoxModelReportTest { get; set; }
        #endregion Properties

        #region Constructors
        public BoxModelExtraB() : base()
        {
        }
        #endregion Constructors
    }
}
