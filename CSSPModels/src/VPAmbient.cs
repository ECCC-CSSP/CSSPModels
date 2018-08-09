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
    public partial class VPAmbient : LastUpdate
    {
        #region Properties in DB
        [Key]
        [CSSPDisplayEN(DisplayEN = "VPAmbient ID")]
        [CSSPDisplayFR(DisplayFR = "VPAmbient ID")]
        [CSSPDescriptionEN(DescriptionEN = @"Contains the unique ""identifier on each row of the VPAmbients table")]
        [CSSPDescriptionFR(DescriptionFR = @"Contient l'identifiant unique sur chaque ligne de la table VPAmbients")]
        public int VPAmbientID { get; set; }
        [CSSPExist(ExistTypeName = "VPScenario", ExistPlurial = "s", ExistFieldID = "VPScenarioID")]
        public int VPScenarioID { get; set; }
        [Range(0, 10)]
        public int Row { get; set; }
        [Range(0.0D, 1000.0D)]
        public double? MeasurementDepth_m { get; set; }
        [Range(0.0D, 10.0D)]
        public double? CurrentSpeed_m_s { get; set; }
        [Range(-180.0D, 180.0D)]
        public double? CurrentDirection_deg { get; set; }
        [Range(0.0D, 40.0D)]
        public double? AmbientSalinity_PSU { get; set; }
        [Range(-10.0D, 40.0D)]
        public double? AmbientTemperature_C { get; set; }
        [Range(0, 10000000)]
        public int? BackgroundConcentration_MPN_100ml { get; set; }
        [Range(0.0D, 100.0D)]
        public double? PollutantDecayRate_per_day { get; set; }
        [Range(0.0D, 10.0D)]
        public double? FarFieldCurrentSpeed_m_s { get; set; }
        [Range(-180.0D, 180.0D)]
        public double? FarFieldCurrentDirection_deg { get; set; }
        [Range(0.0D, 1.0D)]
        public double? FarFieldDiffusionCoefficient { get; set; }
        #endregion Properties in DB

        #region Constructors
        public VPAmbient() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class VPAmbient_A : VPAmbient
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
        public VPAmbient_A() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class VPAmbient_B : VPAmbient_A
    {
        #region Properties
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "TVText", FillNeedLanguage = true, FillIsList = false)]
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "Report test")]
        [CSSPDisplayFR(DisplayFR = "Test report")]
        [CSSPDescriptionEN(DescriptionEN = @"Report test description")]
        [CSSPDescriptionFR(DescriptionFR = @"Description de test report")]
        public string VPAmbientReportTest { get; set; }
        #endregion Properties

        #region Constructors
        public VPAmbient_B() : base()
        {
        }
        #endregion Constructors
    }
}
