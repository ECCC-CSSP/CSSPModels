﻿/*
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
        [CSSPDescriptionFR(DescriptionFR = @"Contient l'identifiant unique sur chaque ligne de la table Spills")]
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

        #region Constructors
        public Spill() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class SpillWeb : Spill
    {
        #region Properties for web information
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "MunicipalityTVItemID", FillReturnField = "", FillNeedLanguage = true)]
        public TVItemLanguage MunicipalityTVItemLanguage { get; set; }
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "InfrastructureTVItemID", FillReturnField = "", FillNeedLanguage = true)]
        public TVItemLanguage InfrastructureTVItemLanguage { get; set; }
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "", FillNeedLanguage = true)]
        [CSSPDisplayEN(DisplayEN = "Last update contact TVItemLanguage")]
        [CSSPDisplayFR(DisplayFR = "TVItemLanguage du contact ayant fait le dernière changement")]
        [CSSPDescriptionEN(DescriptionEN = @"Last update contact TVItemLanguage DB object")]
        [CSSPDescriptionFR(DescriptionFR = @"Object BD TVItemLanguage du contact ayant fait le dernière changement")]
        public TVItemLanguage LastUpdateContactTVItemLanguage { get; set; }
        #endregion Properties for web information

        #region Constructors
        public SpillWeb() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class SpillReport : SpillWeb
    {
        #region Properties for report information
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "Report test")]
        [CSSPDisplayFR(DisplayFR = "Test report")]
        [CSSPDescriptionEN(DescriptionEN = @"Report test description")]
        [CSSPDescriptionFR(DescriptionFR = @"Description de test report")]
        public string SpillReportTest { get; set; }
        #endregion Properties for report information

        #region Constructors
        public SpillReport() : base()
        {
        }
        #endregion Constructors
    }
}
