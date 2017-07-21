using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    public partial class Infrastructure
    {
        #region Properties in DB
        [Key]
        public int InfrastructureID { get; set; }
        [Range(1, -1)]
        [CSSPExist(TypeName = "TVItem", Plurial = "s", FieldID = "TVItemID")]
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
        [Range(0.0f, 1000000.0f)]
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
        [Range(1, -1)]
        [CSSPExist(TypeName = "TVItem", Plurial = "s", FieldID = "TVItemID")]
        public int? SeeOtherTVItemID { get; set; }
        [Range(1, -1)]
        [CSSPExist(TypeName = "TVItem", Plurial = "s", FieldID = "TVItemID")]
        public int? CivicAddressTVItemID { get; set; }
        [CSSPAfter(Year = 1980)]
        public DateTime LastUpdateDate_UTC { get; set; }
        [Range(1, -1)]
        [CSSPExist(TypeName = "TVItem", Plurial = "s", FieldID = "TVItemID")]
        public int LastUpdateContactTVItemID { get; set; }

        public virtual ICollection<InfrastructureLanguage> InfrastructureLanguages { get; set; }
        public virtual TVItem InfrastructureTVItem { get; set; }
        #endregion Properties in DB

        #region Properties not in DB
        [NotMapped]
        public IEnumerable<ValidationResult> ValidationResults { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public Infrastructure()
        {
            InfrastructureLanguages = new HashSet<InfrastructureLanguage>();
        }
        #endregion Constructors

    }
}
