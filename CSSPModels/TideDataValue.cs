using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    public partial class TideDataValue
    {
        #region Properties in DB
        public int TideDataValueID { get; set; }
        public int TideSiteTVItemID { get; set; }
        public DateTime DateTime_Local { get; set; }
        public bool Keep { get; set; }
        public TideDataTypeEnum TideDataType { get; set; }
        public StorageDataTypeEnum StorageDataType { get; set; }
        public float Depth_m { get; set; }
        public float UVelocity_m_s { get; set; }
        public float VVelocity_m_s { get; set; }
        public TideTextEnum? TideStart { get; set; }
        public TideTextEnum? TideEnd { get; set; }
        public DateTime LastUpdateDate_UTC { get; set; }
        public int LastUpdateContactTVItemID { get; set; }

        public virtual TVItem TideSiteTVItem { get; set; }
        #endregion Properties in DB

        #region Properties not in DB
        [NotMapped]
        public IEnumerable<ValidationResult> ValidationResults { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public TideDataValue()
        {
            // empty for now
        }
        #endregion Constructors
    }
}
