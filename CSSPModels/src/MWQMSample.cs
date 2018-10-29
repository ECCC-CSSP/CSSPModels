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
    public partial class MWQMSample : LastUpdate
    {
        #region Properties in DB
        [Key]
        [CSSPDisplayEN(DisplayEN = "MWQMSample ID")]
        [CSSPDisplayFR(DisplayFR = "MWQMSample ID")]
        [CSSPDescriptionEN(DescriptionEN = @"Contains the unique ""identifier on each row of the MWQMSamples table")]
        [CSSPDescriptionFR(DescriptionFR = @"Contient l'identifiant unique sur chaque ligne de la table MWQMSamples")]
        public int MWQMSampleID { get; set; }
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "16")]
        public int MWQMSiteTVItemID { get; set; }
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "31")]
        [CSSPDisplayEN(DisplayEN = "MWQM run TVItemID")]
        [CSSPDisplayFR(DisplayFR = "Tournée MWQM TVItemID (fr)")]
        [CSSPDescriptionEN(DescriptionEN = @"Link to the TVItems table representing MWQM run")]
        [CSSPDescriptionFR(DescriptionFR = @"Lien à la table TVItems représentant le la tournée MWQM")]
        public int MWQMRunTVItemID { get; set; }
        [CSSPAfter(Year = 1980)]
        [CSSPDisplayEN(DisplayEN = "Sample date and time (local)")]
        [CSSPDisplayFR(DisplayFR = "Date et temps de l'échantillon (local)")]
        [CSSPDescriptionEN(DescriptionEN = @"Sample date and time (local)")]
        [CSSPDescriptionFR(DescriptionFR = @"Date et temps de l'échantillon (local)")]
        public DateTime SampleDateTime_Local { get; set; }
        [Range(0.0D, 1000.0D)]
        [CSSPDisplayEN(DisplayEN = "Depth (m)")]
        [CSSPDisplayFR(DisplayFR = "Profondeur (m)")]
        [CSSPDescriptionEN(DescriptionEN = @"Depth in meters")]
        [CSSPDescriptionFR(DescriptionFR = @"Profondeur en mètres")]
        public double? Depth_m { get; set; }
        [Range(0, 10000000)]
        [CSSPDisplayEN(DisplayEN = "FC (MPN / 100 mL)")]
        [CSSPDisplayFR(DisplayFR = "CF (NPP / 100 mL)")]
        [CSSPDescriptionEN(DescriptionEN = @"Most probable number of fecal coliform colonies per 100 milli-Litres")]
        [CSSPDescriptionFR(DescriptionFR = @"Number plus probable de colonies de coliform fécaux par 100 milli-Litres")]
        public int FecCol_MPN_100ml { get; set; }
        [Range(0.0D, 40.0D)]
        [CSSPDisplayEN(DisplayEN = "Salinity (PPT)")]
        [CSSPDisplayFR(DisplayFR = "Salinité (PPT) (fr)")]
        [CSSPDescriptionEN(DescriptionEN = @"Salinity in parts per thousand")]
        [CSSPDescriptionFR(DescriptionFR = @"Salinité en partis par millier")]
        public double? Salinity_PPT { get; set; }
        [Range(-10.0D, 40.0D)]
        [CSSPDisplayEN(DisplayEN = "Temperature (°C)")]
        [CSSPDisplayFR(DisplayFR = "Température (°C)")]
        [CSSPDescriptionEN(DescriptionEN = @"Temperatrue in degree Celcius")]
        [CSSPDescriptionFR(DescriptionFR = @"Température en dégré Celcius")]
        public double? WaterTemp_C { get; set; }
        [Range(0.0D, 14.0D)]
        [CSSPDisplayEN(DisplayEN = "pH")]
        [CSSPDisplayFR(DisplayFR = "pH")]
        [CSSPDescriptionEN(DescriptionEN = @"pH")]
        [CSSPDescriptionFR(DescriptionFR = @"pH")]
        public double? PH { get; set; }
        [StringLength(50)]
        [CSSPDisplayEN(DisplayEN = "Sample types")]
        [CSSPDisplayFR(DisplayFR = "Types de l'échantillon")]
        [CSSPDescriptionEN(DescriptionEN = @"Sample types")]
        [CSSPDescriptionFR(DescriptionFR = @"Types de l'échantillon")]
        public string SampleTypesText { get; set; }
        [CSSPEnumType]
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "Old sample type")]
        [CSSPDisplayFR(DisplayFR = "Vieu type d'échantillon")]
        [CSSPDescriptionEN(DescriptionEN = @"Old sample type")]
        [CSSPDescriptionFR(DescriptionFR = @"Vieu type d'échantillon")]
        public SampleTypeEnum? SampleType_old { get; set; }
        [Range(0, 5)]
        [CSSPDisplayEN(DisplayEN = "Tube 10")]
        [CSSPDisplayFR(DisplayFR = "Tube 10")]
        [CSSPDescriptionEN(DescriptionEN = @"Number of positive tube for Tube 10")]
        [CSSPDescriptionFR(DescriptionFR = @"Nombre de tube positif pour Tube 10")]
        public int? Tube_10 { get; set; }
        [Range(0, 5)]
        [CSSPDisplayEN(DisplayEN = "Tube 1")]
        [CSSPDisplayFR(DisplayFR = "Tube 1")]
        [CSSPDescriptionEN(DescriptionEN = @"Number of positive tube for Tube 1")]
        [CSSPDescriptionFR(DescriptionFR = @"Nombre de tube positif pour Tube 1")]
        public int? Tube_1_0 { get; set; }
        [Range(0, 5)]
        [CSSPDisplayEN(DisplayEN = "Tube .1")]
        [CSSPDisplayFR(DisplayFR = "Tube .1")]
        [CSSPDescriptionEN(DescriptionEN = @"Number of positive tube for Tube .1")]
        [CSSPDescriptionFR(DescriptionFR = @"Nombre de tube positif pour Tube .1")]
        public int? Tube_0_1 { get; set; }
        [StringLength(10)]
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "Processed by")]
        [CSSPDisplayFR(DisplayFR = "Traité par")]
        [CSSPDescriptionEN(DescriptionEN = @"Processed by")]
        [CSSPDescriptionFR(DescriptionFR = @"Traité par")]
        public string ProcessedBy { get; set; }
        [CSSPDisplayEN(DisplayEN = "Used for open data")]
        [CSSPDisplayFR(DisplayFR = "Utilisé pour les données ouvertes")]
        [CSSPDescriptionEN(DescriptionEN = @"Used for open data")]
        [CSSPDescriptionFR(DescriptionFR = @"Utilisé pour les données ouvertes")]
        public bool UseForOpenData { get; set; }
        #endregion Properties in DB

        #region Constructors
        public MWQMSample() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class MWQMSampleExtraA : MWQMSample
    {
        #region Properties
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "MWQMSiteTVItemID", FillReturnField = "TVText", FillNeedLanguage = true, FillIsList = false)]
        [CSSPDisplayEN(DisplayEN = "MWQM site text")]
        [CSSPDisplayFR(DisplayFR = "Texte du site MWQM (fr)")]
        [CSSPDescriptionEN(DescriptionEN = @"MWQM site text")]
        [CSSPDescriptionFR(DescriptionFR = @"Texte du site MWQM (fr)")]
        public string MWQMSiteText { get; set; }
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "MWQMRunTVItemID", FillReturnField = "TVText", FillNeedLanguage = true, FillIsList = false)]
        [CSSPDisplayEN(DisplayEN = "MWQM run text")]
        [CSSPDisplayFR(DisplayFR = "Texte de la tournée MWQM (fr)")]
        [CSSPDescriptionEN(DescriptionEN = @"MWQM run text")]
        [CSSPDescriptionFR(DescriptionFR = @"Texte de la tournée MWQM (fr)")]
        public string MWQMRunText { get; set; }
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "TVText", FillNeedLanguage = true, FillIsList = false)]
        [CSSPDisplayEN(DisplayEN = "Last update contact name")]
        [CSSPDisplayFR(DisplayFR = "Nom du contact ayant fait le dernière changement")]
        [CSSPDescriptionEN(DescriptionEN = @"Last update contact name")]
        [CSSPDescriptionFR(DescriptionFR = @"Nom du contact ayant fait le dernière changement")]
        public string LastUpdateContactText { get; set; }
        [CSSPEnumTypeText(EnumTypeName = "SampleTypeEnum", EnumType = "SampleType_old")]
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "Old sample type text")]
        [CSSPDisplayFR(DisplayFR = "Texte du vieu type de l'échantillon")]
        [CSSPDescriptionEN(DescriptionEN = @"Old sample type text")]
        [CSSPDescriptionFR(DescriptionFR = @"Texte du vieu type de l'échantillon")]
        public string SampleType_oldText { get; set; }
        #endregion Properties

        #region Constructors
        public MWQMSampleExtraA() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class MWQMSampleExtraB : MWQMSampleExtraA
    {
        #region Properties
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "TVText", FillNeedLanguage = true, FillIsList = false)]
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "Report test")]
        [CSSPDisplayFR(DisplayFR = "Test report")]
        [CSSPDescriptionEN(DescriptionEN = @"Report test description")]
        [CSSPDescriptionFR(DescriptionFR = @"Description de test report")]
        public string MWQMSampleReportTest { get; set; }
        #endregion Properties

        #region Constructors
        public MWQMSampleExtraB() : base()
        {
        }
        #endregion Constructors
    }
}
