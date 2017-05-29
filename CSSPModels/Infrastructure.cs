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
        public int InfrastructureID { get; set; }
        public int InfrastructureTVItemID { get; set; }
        public int? PrismID { get; set; }
        public int? TPID { get; set; }
        public int? LSID { get; set; }
        public int? SiteID { get; set; }
        public int? Site { get; set; }
        public string InfrastructureCategory { get; set; }
        public InfrastructureTypeEnum? InfrastructureType { get; set; }
        public FacilityTypeEnum? FacilityType { get; set; }
        public bool? IsMechanicallyAerated { get; set; }
        public int? NumberOfCells { get; set; }
        public int? NumberOfAeratedCells { get; set; }
        public AerationTypeEnum? AerationType { get; set; }
        public PreliminaryTreatmentTypeEnum? PreliminaryTreatmentType { get; set; }
        public PrimaryTreatmentTypeEnum? PrimaryTreatmentType { get; set; }
        public SecondaryTreatmentTypeEnum? SecondaryTreatmentType { get; set; }
        public TertiaryTreatmentTypeEnum? TertiaryTreatmentType { get; set; }
        public TreatmentTypeEnum? TreatmentType { get; set; }
        public DisinfectionTypeEnum? DisinfectionType { get; set; }
        public CollectionSystemTypeEnum? CollectionSystemType { get; set; }
        public AlarmSystemTypeEnum? AlarmSystemType { get; set; }
        public float? DesignFlow_m3_day { get; set; }
        public float? AverageFlow_m3_day { get; set; }
        public float? PeakFlow_m3_day { get; set; }
        public int? PopServed { get; set; }
        public bool? CanOverflow { get; set; }
        public float? PercFlowOfTotal { get; set; }
        public float? TimeOffset_hour { get; set; }
        public string TempCatchAllRemoveLater { get; set; }
        public float? AverageDepth_m { get; set; }
        public int? NumberOfPorts { get; set; }
        public float? PortDiameter_m { get; set; }
        public float? PortSpacing_m { get; set; }
        public float? PortElevation_m { get; set; }
        public float? VerticalAngle_deg { get; set; }
        public float? HorizontalAngle_deg { get; set; }
        public float? DecayRate_per_day { get; set; }
        public float? NearFieldVelocity_m_s { get; set; }
        public float? FarFieldVelocity_m_s { get; set; }
        public float? ReceivingWaterSalinity_PSU { get; set; }
        public float? ReceivingWaterTemperature_C { get; set; }
        public int? ReceivingWater_MPN_per_100ml { get; set; }
        public float? DistanceFromShore_m { get; set; }
        public int? SeeOtherTVItemID { get; set; }
        public int? CivicAddressTVItemID { get; set; }
        public DateTime LastUpdateDate_UTC { get; set; }
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
