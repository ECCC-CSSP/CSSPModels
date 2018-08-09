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
    public partial class MikeSourceStartEnd : LastUpdate
    {
        #region Properties in DB
        [Key]
        [CSSPDisplayEN(DisplayEN = "MikeSourceStartEnd ID")]
        [CSSPDisplayFR(DisplayFR = "MikeSourceStartEnd ID")]
        [CSSPDescriptionEN(DescriptionEN = @"Contains the unique ""identifier on each row of the MikeSourceStartEnds table")]
        [CSSPDescriptionFR(DescriptionFR = @"Contient l'identifiant unique sur chaque ligne de la table MikeSourceStartEnds")]
        public int MikeSourceStartEndID { get; set; }
        [CSSPExist(ExistTypeName = "MikeSource", ExistPlurial = "s", ExistFieldID = "MikeSourceID")]
        public int MikeSourceID { get; set; }
        [CSSPAfter(Year = 1980)]
        public DateTime StartDateAndTime_Local { get; set; }
        [CSSPAfter(Year = 1980)]
        [CSSPBigger(OtherField = "StartDateAndTime_Local")]
        public DateTime EndDateAndTime_Local { get; set; }
        [Range(0.0D, 1000000.0D)]
        public double SourceFlowStart_m3_day { get; set; }
        [Range(0.0D, 1000000.0D)]
        public double SourceFlowEnd_m3_day { get; set; }
        [Range(0, 10000000)]
        public int SourcePollutionStart_MPN_100ml { get; set; }
        [Range(0, 10000000)]
        public int SourcePollutionEnd_MPN_100ml { get; set; }
        [Range(-10.0D, 40.0D)]
        public double SourceTemperatureStart_C { get; set; }
        [Range(-10.0D, 40.0D)]
        public double SourceTemperatureEnd_C { get; set; }
        [Range(0.0D, 40.0D)]
        public double SourceSalinityStart_PSU { get; set; }
        [Range(0.0D, 40.0D)]
        public double SourceSalinityEnd_PSU { get; set; }
        #endregion Properties in DB

        #region Constructors
        public MikeSourceStartEnd() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class MikeSourceStartEnd_A : MikeSourceStartEnd
    {
        #region Properties
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "", FillNeedLanguage = true, FillIsList = false)]
        [CSSPDisplayEN(DisplayEN = "Last update contact TVItemLanguage")]
        [CSSPDisplayFR(DisplayFR = "TVItemLanguage du contact ayant fait le dernière changement")]
        [CSSPDescriptionEN(DescriptionEN = @"Last update contact TVItemLanguage DB object")]
        [CSSPDescriptionFR(DescriptionFR = @"Object BD TVItemLanguage du contact ayant fait le dernière changement")]
        public TVItemLanguage LastUpdateContactTVItemLanguage { get; set; }
        #endregion Properties

        #region Constructors
        public MikeSourceStartEnd_A() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class MikeSourceStartEnd_B : MikeSourceStartEnd_A
    {
        #region Properties
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "TVText", FillNeedLanguage = true, FillIsList = false)]
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "Report test")]
        [CSSPDisplayFR(DisplayFR = "Test report")]
        [CSSPDescriptionEN(DescriptionEN = @"Report test description")]
        [CSSPDescriptionFR(DescriptionFR = @"Description de test report")]
        public string MikeSourceStartEndReportTest { get; set; }
        #endregion Properties

        #region Constructors
        public MikeSourceStartEnd_B() : base()
        {
        }
        #endregion Constructors
    }
}
