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
        public int MikeBoundaryConditionID { get; set; }
        public int MikeBoundaryConditionTVItemID { get; set; }
        public string MikeBoundaryConditionCode { get; set; }
        public string MikeBoundaryConditionName { get; set; }
        public float MikeBoundaryConditionLength_m { get; set; }
        public string MikeBoundaryConditionFormat { get; set; }
        public MikeBoundaryConditionLevelOrVelocityEnum MikeBoundaryConditionLevelOrVelocity { get; set; }
        public WebTideDataSetEnum WebTideDataSet { get; set; }
        public int NumberOfWebTideNodes { get; set; }
        public string WebTideDataFromStartToEndDate { get; set; }
        public TVTypeEnum TVType { get; set; }
        public DateTime LastUpdateDate_UTC { get; set; }
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
