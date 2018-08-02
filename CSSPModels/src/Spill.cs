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
    public partial class Spill : LastUpdate
    {
        #region Properties in DB
        [Key]
        [CSSPDisplayEN(DisplayEN = "Spill ID")]
        [CSSPDisplayFR(DisplayFR = "Spill ID")]
        [CSSPDescriptionEN(DescriptionEN = @"Contains the unique ""identifier on each row of the Spills table")]
        [CSSPDescriptionFR(DescriptionFR = @"Contient l'identifiant unique sur chaque ligne du tableau Spills")]
        public int SpillID { get; set; }
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "15")]
        public int MunicipalityTVItemID { get; set; }
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "10")]
        public int? InfrastructureTVItemID { get; set; }
        [CSSPAfter(Year = 1980)]
        public DateTime StartDateTime_Local { get; set; }
        [CSSPAfter(Year = 1980)]
        [CSSPBigger(OtherField = "StartDateTime_Local")]
        public DateTime? EndDateTime_Local { get; set; }
        [Range(0.0D, 1000000.0D)]
        public double AverageFlow_m3_day { get; set; }
        #endregion Properties in DB

        #region Properties not in DB
        [NotMapped]
        [CSSPAllowNull]
        public SpillWeb SpillWeb { get; set; }
        [NotMapped]
        [CSSPAllowNull]
        public SpillReport SpillReport { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public Spill() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class SpillWeb
    {
        #region Properties for web information
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "MunicipalityTVItemID", FillReturnField = "", FillNeedLanguage = true)]
        public TVItemLanguage MunicipalityTVItemLanguage { get; set; }
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "InfrastructureTVItemID", FillReturnField = "", FillNeedLanguage = true)]
        public TVItemLanguage InfrastructureTVItemLanguage { get; set; }
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "", FillNeedLanguage = true)]
        public TVItemLanguage LastUpdateContactTVItemLanguage { get; set; }
        #endregion Properties for web information

        #region Constructors
        public SpillWeb()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class SpillReport
    {
        #region Properties for report information
        [CSSPAllowNull]
        public string SpillReportTest { get; set; }
        #endregion Properties for report information

        #region Constructors
        public SpillReport()
        {
        }
        #endregion Constructors
    }
}
