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
    public partial class TideDataValue : LastUpdate
    {
        #region Properties in DB
        [Key]
        [CSSPDisplayEN(DisplayEN = "TideDataValue ID")]
        [CSSPDisplayFR(DisplayFR = "TideDataValue ID")]
        [CSSPDescriptionEN(DescriptionEN = @"Contains the unique ""identifier on each row of the TideDataValues table")]
        [CSSPDescriptionFR(DescriptionFR = @"Contient l'identifiant unique sur chaque ligne de la table TideDataValues")]
        public int TideDataValueID { get; set; }
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "22")]
        [CSSPDisplayEN(DisplayEN = "Tide site")]
        [CSSPDisplayFR(DisplayFR = "Site de marée")]
        [CSSPDescriptionEN(DescriptionEN = @"Link to the TVItems table representing the tide site")]
        [CSSPDescriptionFR(DescriptionFR = @"Lien à la table TVItems représentant le site de marée")]
        public int TideSiteTVItemID { get; set; }
        [CSSPAfter(Year = 1980)]
        [CSSPDisplayEN(DisplayEN = "Date (local)")]
        [CSSPDisplayFR(DisplayFR = "Date (local)")]
        [CSSPDescriptionEN(DescriptionEN = @"Date (local)")]
        [CSSPDescriptionFR(DescriptionFR = @"Date (local)")]
        public DateTime DateTime_Local { get; set; }
        [CSSPDisplayEN(DisplayEN = "Keep")]
        [CSSPDisplayFR(DisplayFR = "Sauvegarder")]
        [CSSPDescriptionEN(DescriptionEN = @"Keep")]
        [CSSPDescriptionFR(DescriptionFR = @"Sauvegarder")]
        public bool Keep { get; set; }
        [CSSPEnumType]
        [CSSPDisplayEN(DisplayEN = "Tide data type")]
        [CSSPDisplayFR(DisplayFR = "Type de donnée de marée")]
        [CSSPDescriptionEN(DescriptionEN = @"Tide data type")]
        [CSSPDescriptionFR(DescriptionFR = @"Type de donnée de marée")]
        public TideDataTypeEnum TideDataType { get; set; }
        [CSSPEnumType]
        [CSSPDisplayEN(DisplayEN = "Storage data type")]
        [CSSPDisplayFR(DisplayFR = "Type de sauvegarde des données")]
        [CSSPDescriptionEN(DescriptionEN = @"Storage data type")]
        [CSSPDescriptionFR(DescriptionFR = @"Type de sauvegarde des données")]
        public StorageDataTypeEnum StorageDataType { get; set; }
        [Range(0.0D, 10000.0D)]
        [CSSPDisplayEN(DisplayEN = "Depth (m)")]
        [CSSPDisplayFR(DisplayFR = "Profondeur (m)")]
        [CSSPDescriptionEN(DescriptionEN = @"Depth in meters")]
        [CSSPDescriptionFR(DescriptionFR = @"Profondeur en mètres")]
        public double Depth_m { get; set; }
        [Range(0.0D, 10.0D)]
        [CSSPDisplayEN(DisplayEN = "U velocity (m/s)")]
        [CSSPDisplayFR(DisplayFR = "U vélocité (m/s)")]
        [CSSPDescriptionEN(DescriptionEN = @"U velocity in meters per second")]
        [CSSPDescriptionFR(DescriptionFR = @"U vélocité en mètres par second")]
        public double UVelocity_m_s { get; set; }
        [Range(0.0D, 10.0D)]
        [CSSPDisplayEN(DisplayEN = "V velocity (m/s)")]
        [CSSPDisplayFR(DisplayFR = "V vélocité (m/s)")]
        [CSSPDescriptionEN(DescriptionEN = @"V velocity in meters per second")]
        [CSSPDescriptionFR(DescriptionFR = @"V vélocité en mètres par second")]
        public double VVelocity_m_s { get; set; }
        [CSSPEnumType]
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "Tide text start")]
        [CSSPDisplayFR(DisplayFR = "Tide text de départ")]
        [CSSPDescriptionEN(DescriptionEN = @"Tide text start")]
        [CSSPDescriptionFR(DescriptionFR = @"Tide text de départ")]
        public TideTextEnum? TideStart { get; set; }
        [CSSPEnumType]
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "Tide text end")]
        [CSSPDisplayFR(DisplayFR = "Tide text de fin")]
        [CSSPDescriptionEN(DescriptionEN = @"Tide text end")]
        [CSSPDescriptionFR(DescriptionFR = @"Tide text de fin")]
        public TideTextEnum? TideEnd { get; set; }
        #endregion Properties in DB

        #region Constructors
        public TideDataValue() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class TideDataValueExtraA : TideDataValue
    {
        #region Properties
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "TideSiteTVItemID", FillReturnField = "TVText", FillNeedLanguage = true, FillIsList = false)]
        [CSSPDisplayEN(DisplayEN = "Tide site text")]
        [CSSPDisplayFR(DisplayFR = "Texte du site de marée")]
        [CSSPDescriptionEN(DescriptionEN = @"Tide site text")]
        [CSSPDescriptionFR(DescriptionFR = @"Texte du site de marée")]
        public string TideSiteText { get; set; }
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "TVText", FillNeedLanguage = true, FillIsList = false)]
        [CSSPDisplayEN(DisplayEN = "Last update contact name")]
        [CSSPDisplayFR(DisplayFR = "Nom du contact ayant fait le dernière changement")]
        [CSSPDescriptionEN(DescriptionEN = @"Last update contact name")]
        [CSSPDescriptionFR(DescriptionFR = @"Nom du contact ayant fait le dernière changement")]
        public string LastUpdateContactText { get; set; }
        [CSSPEnumTypeText(EnumTypeName = "TideDataTypeEnum", EnumType = "TideDataType")]
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "Tide data type text")]
        [CSSPDisplayFR(DisplayFR = "Texte du type de marée")]
        [CSSPDescriptionEN(DescriptionEN = @"Tide data type text")]
        [CSSPDescriptionFR(DescriptionFR = @"Texte du type de marée")]
        public string TideDataTypeText { get; set; }
        [CSSPEnumTypeText(EnumTypeName = "StorageDataTypeEnum", EnumType = "StorageDataType")]
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "Storage data type text")]
        [CSSPDisplayFR(DisplayFR = "Texte du type de sauvegarde des données")]
        [CSSPDescriptionEN(DescriptionEN = @"Storage data type text")]
        [CSSPDescriptionFR(DescriptionFR = @"Texte du type de sauvegarde des données")]
        public string StorageDataTypeText { get; set; }
        [CSSPEnumTypeText(EnumTypeName = "TideTextEnum", EnumType = "TideStart")]
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "Tide text start")]
        [CSSPDisplayFR(DisplayFR = "Texte des marées de début")]
        [CSSPDescriptionEN(DescriptionEN = @"Tide text start")]
        [CSSPDescriptionFR(DescriptionFR = @"Texte des marées de début")]
        public string TideStartText { get; set; }
        [CSSPEnumTypeText(EnumTypeName = "TideTextEnum", EnumType = "TideEnd")]
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "Tide text end")]
        [CSSPDisplayFR(DisplayFR = "Texte des marées de fin")]
        [CSSPDescriptionEN(DescriptionEN = @"Tide text end")]
        [CSSPDescriptionFR(DescriptionFR = @"Texte des marées de fin")]
        public string TideEndText { get; set; }
        #endregion Properties

        #region Constructors
        public TideDataValueExtraA() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class TideDataValueExtraB : TideDataValueExtraA
    {
        #region Properties
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "TVText", FillNeedLanguage = true, FillIsList = false)]
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "Report test")]
        [CSSPDisplayFR(DisplayFR = "Test report")]
        [CSSPDescriptionEN(DescriptionEN = @"Report test description")]
        [CSSPDescriptionFR(DescriptionFR = @"Description de test report")]
        public string TideDataValueReportTest { get; set; }
        #endregion Properties

        #region Constructors
        public TideDataValueExtraB() : base()
        {
        }
        #endregion Constructors
    }
}
