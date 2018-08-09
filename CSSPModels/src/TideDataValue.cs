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
        public int TideSiteTVItemID { get; set; }
        [CSSPAfter(Year = 1980)]
        public DateTime DateTime_Local { get; set; }
        public bool Keep { get; set; }
        [CSSPEnumType]
        public TideDataTypeEnum TideDataType { get; set; }
        [CSSPEnumType]
        public StorageDataTypeEnum StorageDataType { get; set; }
        [Range(0.0D, 10000.0D)]
        public double Depth_m { get; set; }
        [Range(0.0D, 10.0D)]
        public double UVelocity_m_s { get; set; }
        [Range(0.0D, 10.0D)]
        public double VVelocity_m_s { get; set; }
        [CSSPEnumType]
        [CSSPAllowNull]
        public TideTextEnum? TideStart { get; set; }
        [CSSPEnumType]
        [CSSPAllowNull]
        public TideTextEnum? TideEnd { get; set; }
        #endregion Properties in DB

        #region Constructors
        public TideDataValue() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class TideDataValue_A : TideDataValue
    {
        #region Properties
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "TideSiteTVItemID", FillReturnField = "", FillNeedLanguage = true, FillIsList = false)]
        public TVItemLanguage TideSiteTVItemLanguage { get; set; }
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "", FillNeedLanguage = true, FillIsList = false)]
        [CSSPDisplayEN(DisplayEN = "Last update contact TVItemLanguage")]
        [CSSPDisplayFR(DisplayFR = "TVItemLanguage du contact ayant fait le dernière changement")]
        [CSSPDescriptionEN(DescriptionEN = @"Last update contact TVItemLanguage DB object")]
        [CSSPDescriptionFR(DescriptionFR = @"Object BD TVItemLanguage du contact ayant fait le dernière changement")]
        public TVItemLanguage LastUpdateContactTVItemLanguage { get; set; }
        [CSSPEnumTypeText(EnumTypeName = "TideDataTypeEnum", EnumType = "TideDataType")]
        [CSSPAllowNull]
        public string TideDataTypeText { get; set; }
        [CSSPEnumTypeText(EnumTypeName = "StorageDataTypeEnum", EnumType = "StorageDataType")]
        [CSSPAllowNull]
        public string StorageDataTypeText { get; set; }
        [CSSPEnumTypeText(EnumTypeName = "TideTextEnum", EnumType = "TideStart")]
        [CSSPAllowNull]
        public string TideStartText { get; set; }
        [CSSPEnumTypeText(EnumTypeName = "TideTextEnum", EnumType = "TideEnd")]
        [CSSPAllowNull]
        public string TideEndText { get; set; }
        #endregion Properties

        #region Constructors
        public TideDataValue_A() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class TideDataValue_B : TideDataValue_A
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
        public TideDataValue_B() : base()
        {
        }
        #endregion Constructors
    }
}
