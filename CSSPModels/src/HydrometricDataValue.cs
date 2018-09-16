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
    public partial class HydrometricDataValue : LastUpdate
    {
        #region Properties in DB
        [Key]
        [CSSPDisplayEN(DisplayEN = "HydrometricDataValue ID")]
        [CSSPDisplayFR(DisplayFR = "HydrometricDataValue ID")]
        [CSSPDescriptionEN(DescriptionEN = @"Contains the unique ""identifier on each row of the HydrometricDataValues table")]
        [CSSPDescriptionFR(DescriptionFR = @"Contient l'identifiant unique sur chaque ligne de la table HydrometricDataValues")]
        public int HydrometricDataValueID { get; set; }
        [CSSPExist(ExistTypeName = "HydrometricSite", ExistPlurial = "s", ExistFieldID = "HydrometricSiteID")]
        [CSSPDisplayEN(DisplayEN = "HydrometricSite link")]
        [CSSPDisplayFR(DisplayFR = "Lien HydrometricSite")]
        [CSSPDescriptionEN(DescriptionEN = @"HydrometricSite link to parent HydrometricSites table item")]
        [CSSPDescriptionFR(DescriptionFR = @"Lien au parent CydrometricSite à l'item de la table HydrometricSites")]
        public int HydrometricSiteID { get; set; }
        [CSSPAfter(Year = 1980)]
        [CSSPDisplayEN(DisplayEN = "Date and time of observation")]
        [CSSPDisplayFR(DisplayFR = "Date et temps de l'observation")]
        [CSSPDescriptionEN(DescriptionEN = @"Date and time of observation. Almost all data is coming from the water office web site.")]
        [CSSPDescriptionFR(DescriptionFR = @"Date et temps de l'observation. Pratiquement tous les données proviennent de site web water office")]
        public DateTime DateTime_Local { get; set; }
        [CSSPDisplayEN(DisplayEN = "Keep")]
        [CSSPDisplayFR(DisplayFR = "Garder")]
        [CSSPDescriptionEN(DescriptionEN = @"Keep the data within the database. Sometime the database might get some data from the water office web site as temporary data which can be removed at a later date")]
        [CSSPDescriptionFR(DescriptionFR = @"Conservez les données dans la base de données. Parfois, la base de données peut obtenir des données du site Web du bureau hydrométrique en tant que données temporaires pouvant être supprimées ultérieurement.")]
        public bool Keep { get; set; }
        [CSSPEnumType]
        [CSSPDisplayEN(DisplayEN = "Storage data type")]
        [CSSPDisplayFR(DisplayFR = "Type de données sauvegardez")]
        [CSSPDescriptionEN(DescriptionEN = @"Storage data type can be archived, forcasted or observed")]
        [CSSPDescriptionFR(DescriptionFR = @"Type de données sauvegardez peut être archivés, prévisions ou observés")]
        public StorageDataTypeEnum StorageDataType { get; set; }
        [CSSPDisplayEN(DisplayEN = "Has been read")]
        [CSSPDisplayFR(DisplayFR = "Ont été lus")]
        [CSSPDescriptionEN(DescriptionEN = @"The stored data has been read from the weather office web site")]
        [CSSPDescriptionFR(DescriptionFR = @"Les données stockées ont été lues sur le site Web du bureau météorologique")]
        public bool HasBeenRead { get; set; }
        [Range(0.0D, 100000.0D)]
        [CSSPDisplayEN(DisplayEN = "Flows (Discharges) in m3/s")]
        [CSSPDisplayFR(DisplayFR = "Débits en m3/s")]
        [CSSPDescriptionEN(DescriptionEN = @"Flows (Discharges) in m3/s")]
        [CSSPDescriptionFR(DescriptionFR = @"Débits en m3/s")]
        public double? Flow_m3_s { get; set; }
        [Range(0.0D, 10000.0D)]
        [CSSPDisplayEN(DisplayEN = "Levels in m")]
        [CSSPDisplayFR(DisplayFR = "Niveaux en m")]
        [CSSPDescriptionEN(DescriptionEN = @"Levels in m")]
        [CSSPDescriptionFR(DescriptionFR = @"Niveaux en m")]
        public double? Level_m { get; set; }
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "String containing hourly values")]
        [CSSPDisplayFR(DisplayFR = "Texte contenant les valeurs horaires")]
        [CSSPDescriptionEN(DescriptionEN = @"String containing hourly values")]
        [CSSPDescriptionFR(DescriptionFR = @"Texte contenant les valeurs horaires")]
        public string HourlyValues { get; set; }
        #endregion Properties in DB

        #region Constructors
        public HydrometricDataValue() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class HydrometricDataValue_A : HydrometricDataValue
    {
        #region Properties
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "", FillNeedLanguage = true, FillIsList = false)]
        [CSSPDisplayEN(DisplayEN = "Last update contact TVItemLanguage")]
        [CSSPDisplayFR(DisplayFR = "TVItemLanguage du contact ayant fait le dernière changement")]
        [CSSPDescriptionEN(DescriptionEN = @"Last update contact TVItemLanguage DB object")]
        [CSSPDescriptionFR(DescriptionFR = @"Object BD TVItemLanguage du contact ayant fait le dernière changement")]
        public TVItemLanguage LastUpdateContactTVItemLanguage { get; set; }
        [CSSPEnumTypeText(EnumTypeName = "StorageDataTypeEnum", EnumType = "StorageDataType")]
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "Storage data type text")]
        [CSSPDisplayFR(DisplayFR = "Texte du type de storage")]
        [CSSPDescriptionEN(DescriptionEN = @"Storage data type text")]
        [CSSPDescriptionFR(DescriptionFR = @"Texte du type de storage")]
        public string StorageDataTypeText { get; set; }
        #endregion Properties

        #region Constructors
        public HydrometricDataValue_A() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class HydrometricDataValue_B : HydrometricDataValue_A
    {
        #region Properties
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "TVText", FillNeedLanguage = true, FillIsList = false)]
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "Report test")]
        [CSSPDisplayFR(DisplayFR = "Test report")]
        [CSSPDescriptionEN(DescriptionEN = @"Report test description")]
        [CSSPDescriptionFR(DescriptionFR = @"Description de test report")]
        public string HydrometricDataValueReportTest { get; set; }
        #endregion Properties

        #region Constructors
        public HydrometricDataValue_B() : base()
        {
        }
        #endregion Constructors
    }
}
