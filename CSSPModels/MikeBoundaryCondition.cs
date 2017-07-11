using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    public partial class MikeBoundaryCondition
    {
        #region Properties in DB
        [Key]
        public int MikeBoundaryConditionID { get; set; }
        [Range(1, -1)]
        [CSSPExist(TypeName = "TVItem", Plurial = "s", FieldID = "TVItemID")]
        public int MikeBoundaryConditionTVItemID { get; set; }
        [StringLength(100)]
        public string MikeBoundaryConditionCode { get; set; }
        [StringLength(100)]
        public string MikeBoundaryConditionName { get; set; }
        [Range(1.0f, 100000.0f)]
        public float MikeBoundaryConditionLength_m { get; set; }
        [StringLength(100)]
        public string MikeBoundaryConditionFormat { get; set; }
        public MikeBoundaryConditionLevelOrVelocityEnum MikeBoundaryConditionLevelOrVelocity { get; set; }
        [CSSPEnumType]
        public WebTideDataSetEnum WebTideDataSet { get; set; }
        [Range(0, 1000)]
        public int NumberOfWebTideNodes { get; set; }
        public string WebTideDataFromStartToEndDate { get; set; }
        [CSSPEnumType]
        public TVTypeEnum TVType { get; set; }
        [CSSPAfter(Year = 1980)]
        public DateTime LastUpdateDate_UTC { get; set; }
        [Range(1, -1)]
        [CSSPExist(TypeName = "TVItem", Plurial = "s", FieldID = "TVItemID")]
        public int LastUpdateContactTVItemID { get; set; }

        public virtual TVItem MikeBoundaryConditionTVItem { get; set; }
        #endregion Properties in DB

        #region Properties not in DB
        [NotMapped]
        public IEnumerable<ValidationResult> ValidationResults { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public MikeBoundaryCondition()
        {
            // empty for now
        }
        #endregion Constructors
    }
}
