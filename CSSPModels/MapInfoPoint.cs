using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    public partial class MapInfoPoint
    {
        #region Properties in DB
        public int MapInfoPointID { get; set; }
        public int MapInfoID { get; set; }
        public int Ordinal { get; set; }
        public float Lat { get; set; }
        public float Lng { get; set; }
        public DateTime LastUpdateDate_UTC { get; set; }
        public int LastUpdateContactTVItemID { get; set; }

        public virtual MapInfo MapInfo { get; set; }
        #endregion Properties in DB

        #region Properties not in DB
        [NotMapped]
        public IEnumerable<ValidationResult> ValidationResults { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public MapInfoPoint()
        {
            // empty for now
        }
        #endregion Constructors
    }
}
