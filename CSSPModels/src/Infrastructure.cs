﻿using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    public partial class Infrastructure : LastUpdate
    {
        #region Properties in DB
        [Key]
        public int InfrastructureID { get; set; }
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "10")]
        public int InfrastructureTVItemID { get; set; }
        [Range(0, 100000)]
        public int? PrismID { get; set; }
        [Range(0, 100000)]
        public int? TPID { get; set; }
        [Range(0, 100000)]
        public int? LSID { get; set; }
        [Range(0, 100000)]
        public int? SiteID { get; set; }
        [Range(0, 100000)]
        public int? Site { get; set; }
        [StringLength(1, MinimumLength = 1)]
        [CSSPAllowNull]
        public string InfrastructureCategory { get; set; }
        [CSSPEnumType]
        [CSSPAllowNull]
        public InfrastructureTypeEnum? InfrastructureType { get; set; }
        [CSSPEnumType]
        [CSSPAllowNull]
        public FacilityTypeEnum? FacilityType { get; set; }
        public bool? IsMechanicallyAerated { get; set; }
        [Range(0, 10)]
        public int? NumberOfCells { get; set; }
        [Range(0, 10)]
        public int? NumberOfAeratedCells { get; set; }
        [CSSPEnumType]
        [CSSPAllowNull]
        public AerationTypeEnum? AerationType { get; set; }
        [CSSPEnumType]
        [CSSPAllowNull]
        public PreliminaryTreatmentTypeEnum? PreliminaryTreatmentType { get; set; }
        [CSSPEnumType]
        [CSSPAllowNull]
        public PrimaryTreatmentTypeEnum? PrimaryTreatmentType { get; set; }
        [CSSPEnumType]
        [CSSPAllowNull]
        public SecondaryTreatmentTypeEnum? SecondaryTreatmentType { get; set; }
        [CSSPEnumType]
        [CSSPAllowNull]
        public TertiaryTreatmentTypeEnum? TertiaryTreatmentType { get; set; }
        [CSSPEnumType]
        [CSSPAllowNull]
        public TreatmentTypeEnum? TreatmentType { get; set; }
        [CSSPEnumType]
        [CSSPAllowNull]
        public DisinfectionTypeEnum? DisinfectionType { get; set; }
        [CSSPEnumType]
        [CSSPAllowNull]
        public CollectionSystemTypeEnum? CollectionSystemType { get; set; }
        [CSSPEnumType]
        [CSSPAllowNull]
        public AlarmSystemTypeEnum? AlarmSystemType { get; set; }
        [Range(0.0D, 1000000.0D)]
        public double? DesignFlow_m3_day { get; set; }
        [Range(0.0D, 1000000.0D)]
        public double? AverageFlow_m3_day { get; set; }
        [Range(0.0D, 1000000.0D)]
        public double? PeakFlow_m3_day { get; set; }
        [Range(0, 1000000)]
        public int? PopServed { get; set; }
        public bool? CanOverflow { get; set; }
        [Range(0.0D, 100.0D)]
        public double? PercFlowOfTotal { get; set; }
        [Range(-10.0D, 0.0D)]
        public double? TimeOffset_hour { get; set; }
        [CSSPAllowNull]
        public string TempCatchAllRemoveLater { get; set; }
        [Range(0.0D, 1000.0D)]
        public double? AverageDepth_m { get; set; }
        [Range(1, 1000)]
        public int? NumberOfPorts { get; set; }
        [Range(0.0D, 10.0D)]
        public double? PortDiameter_m { get; set; }
        [Range(0.0D, 10000.0D)]
        public double? PortSpacing_m { get; set; }
        [Range(0.0D, 1000.0D)]
        public double? PortElevation_m { get; set; }
        [Range(-90.0D, 90.0D)]
        public double? VerticalAngle_deg { get; set; }
        [Range(-180.0D, 180.0D)]
        public double? HorizontalAngle_deg { get; set; }
        [Range(0.0D, 100.0D)]
        public double? DecayRate_per_day { get; set; }
        [Range(0.0D, 10.0D)]
        public double? NearFieldVelocity_m_s { get; set; }
        [Range(0.0D, 10.0D)]
        public double? FarFieldVelocity_m_s { get; set; }
        [Range(0.0D, 40.0D)]
        public double? ReceivingWaterSalinity_PSU { get; set; }
        [Range(-10.0D, 40.0D)]
        public double? ReceivingWaterTemperature_C { get; set; }
        [Range(0, 10000000)]
        public int? ReceivingWater_MPN_per_100ml { get; set; }
        [Range(0.0D, 1000.0D)]
        public double? DistanceFromShore_m { get; set; }
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "10")]
        public int? SeeOtherTVItemID { get; set; }
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "2")]
        public int? CivicAddressTVItemID { get; set; }
        #endregion Properties in DB

        #region Properties not in DB
        [NotMapped]
        [CSSPAllowNull]
        public InfrastructureWeb InfrastructureWeb { get; set; }
        [NotMapped]
        [CSSPAllowNull]
        public InfrastructureReport InfrastructureReport { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public Infrastructure() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class InfrastructureWeb
    {
        #region Properties for web information
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "InfrastructureTVItemID", FillReturnField = "TVText", FillNeedLanguage = true)]
        public string InfrastructureTVText { get; set; }
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "SeeOtherTVItemID", FillReturnField = "TVText", FillNeedLanguage = true)]
        public string SeeOtherTVText { get; set; }
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "CivicAddressTVItemID", FillReturnField = "TVText", FillNeedLanguage = true)]
        public string CivicAddressTVText { get; set; }
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "TVText", FillNeedLanguage = true)]
        public string LastUpdateContactTVText { get; set; }
        [CSSPEnumTypeText(EnumTypeName = "InfrastructureTypeEnum", EnumType = "InfrastructureType")]
        public string InfrastructureTypeText { get; set; }
        [CSSPEnumTypeText(EnumTypeName = "FacilityTypeEnum", EnumType = "FacilityType")]
        public string FacilityTypeText { get; set; }
        [CSSPEnumTypeText(EnumTypeName = "AerationTypeEnum", EnumType = "AerationType")]
        public string AerationTypeText { get; set; }
        [CSSPEnumTypeText(EnumTypeName = "PreliminaryTreatmentTypeEnum", EnumType = "PreliminaryTreatmentType")]
        public string PreliminaryTreatmentTypeText { get; set; }
        [CSSPEnumTypeText(EnumTypeName = "PrimaryTreatmentTypeEnum", EnumType = "PrimaryTreatmentType")]
        public string PrimaryTreatmentTypeText { get; set; }
        [CSSPEnumTypeText(EnumTypeName = "SecondaryTreatmentTypeEnum", EnumType = "SecondaryTreatmentType")]
        public string SecondaryTreatmentTypeText { get; set; }
        [CSSPEnumTypeText(EnumTypeName = "TertiaryTreatmentTypeEnum", EnumType = "TertiaryTreatmentType")]
        public string TertiaryTreatmentTypeText { get; set; }
        [CSSPEnumTypeText(EnumTypeName = "TreatmentTypeEnum", EnumType = "TreatmentType")]
        public string TreatmentTypeText { get; set; }
        [CSSPEnumTypeText(EnumTypeName = "DisinfectionTypeEnum", EnumType = "DisinfectionType")]
        public string DisinfectionTypeText { get; set; }
        [CSSPEnumTypeText(EnumTypeName = "CollectionSystemTypeEnum", EnumType = "CollectionSystemType")]
        public string CollectionSystemTypeText { get; set; }
        [CSSPEnumTypeText(EnumTypeName = "AlarmSystemTypeEnum", EnumType = "AlarmSystemType")]
        public string AlarmSystemTypeText { get; set; }
        #endregion Properties for web information

        #region Constructors
        public InfrastructureWeb()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class InfrastructureReport
    {
        #region Properties for report information
        public string InfrastructureReportTest { get; set; }
        #endregion Properties for report information

        #region Constructors
        public InfrastructureReport()
        {
        }
        #endregion Constructors
    }
}
