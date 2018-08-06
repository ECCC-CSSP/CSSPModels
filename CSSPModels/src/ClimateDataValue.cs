/*
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
    public partial class ClimateDataValue : LastUpdate
    {
        #region Properties in DB
        [Key]
        [CSSPDisplayEN(DisplayEN = "ClimateDataValue ID")]
        [CSSPDisplayFR(DisplayFR = "ClimateDataValue ID")]
        [CSSPDescriptionEN(DescriptionEN = @"Contains the unique ""identifier on each row of the ClimateDataValues table")]
        [CSSPDescriptionFR(DescriptionFR = @"Contient l'identifiant unique sur chaque ligne de la table ClimateDataValues")]
        public int ClimateDataValueID { get; set; }
        [CSSPExist(ExistTypeName = "ClimateSite", ExistPlurial = "s", ExistFieldID = "ClimateSiteID")]
        public int ClimateSiteID { get; set; }
        [CSSPAfter(Year = 1980)]
        public DateTime DateTime_Local { get; set; }
        public bool Keep { get; set; }
        [CSSPEnumType]
        public StorageDataTypeEnum StorageDataType { get; set; }
        public bool HasBeenRead { get; set; }
        [Range(0.0D, 10000.0D)]
        public double? Snow_cm { get; set; }
        [Range(0.0D, 10000.0D)]
        public double? Rainfall_mm { get; set; }
        [Range(0.0D, 10000.0D)]
        public double? RainfallEntered_mm { get; set; }
        [Range(0.0D, 10000.0D)]
        public double? TotalPrecip_mm_cm { get; set; }
        [Range(-50.0D, 50.0D)]
        public double? MaxTemp_C { get; set; }
        [Range(-50.0D, 50.0D)]
        public double? MinTemp_C { get; set; }
        [Range(-1000.0D, 100.0D)]
        public double? HeatDegDays_C { get; set; }
        [Range(-1000.0D, 100.0D)]
        public double? CoolDegDays_C { get; set; }
        [Range(0.0D, 10000.0D)]
        public double? SnowOnGround_cm { get; set; }
        [Range(0.0D, 360.0D)]
        public double? DirMaxGust_0North { get; set; }
        [Range(0.0D, 300.0D)]
        public double? SpdMaxGust_kmh { get; set; }
        [CSSPAllowNull]
        public string HourlyValues { get; set; }
        #endregion Properties in DB

        #region Constructors
        public ClimateDataValue() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class ClimateDataValueWeb : ClimateDataValue
    {
        #region Properties for web information
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "", FillNeedLanguage = true)]
        [CSSPDisplayEN(DisplayEN = "Last update contact TVItemLanguage")]
        [CSSPDisplayFR(DisplayFR = "TVItemLanguage du contact ayant fait le dernière changement")]
        [CSSPDescriptionEN(DescriptionEN = @"Last update contact TVItemLanguage DB object")]
        [CSSPDescriptionFR(DescriptionFR = @"Object BD TVItemLanguage du contact ayant fait le dernière changement")]
        public TVItemLanguage LastUpdateContactTVItemLanguage { get; set; }
        [CSSPEnumTypeText(EnumTypeName = "StorageDataTypeEnum", EnumType = "StorageDataType")]
        [CSSPAllowNull]
        public string StorageDataTypeEnumText { get; set; }
        #endregion Properties for web information

        #region Constructors
        public ClimateDataValueWeb() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class ClimateDataValueReport : ClimateDataValueWeb
    {
        #region Properties for report information
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "Report test")]
        [CSSPDisplayFR(DisplayFR = "Test report")]
        [CSSPDescriptionEN(DescriptionEN = @"Report test description")]
        [CSSPDescriptionFR(DescriptionFR = @"Description de test report")]
        public string ClimateDataValueReportTest { get; set; }
        #endregion Properties for report information

        #region Constructors
        public ClimateDataValueReport() : base()
        {
        }
        #endregion Constructors
    }
}
