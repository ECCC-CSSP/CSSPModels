using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    public partial class HydrometricDataValue
    {
        #region Properties in DB
        public int HydrometricDataValueID { get; set; }
        public int HydrometricSiteID { get; set; }
        public DateTime DateTime_Local { get; set; }
        public bool Keep { get; set; }
        public StorageDataTypeEnum StorageDataType { get; set; }
        public float Flow_m3_s { get; set; }
        public string HourlyValues { get; set; }
        public DateTime LastUpdateDate_UTC { get; set; }
        public int LastUpdateContactTVItemID { get; set; }

        public virtual HydrometricSite HydrometricSite { get; set; }
        #endregion Properties in DB

        #region Properties not in DB
        [NotMapped]
        public IEnumerable<ValidationResult> ValidationResults { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public HydrometricDataValue()
        {
            // empty for now
        }
        #endregion Constructors
    }
}
