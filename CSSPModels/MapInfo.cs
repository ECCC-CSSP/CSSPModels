using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    public partial class MapInfo
    {
        #region Properties in DB
        public int MapInfoID { get; set; }
        public int TVItemID { get; set; }
        public TVTypeEnum TVType { get; set; }
        public float LatMin { get; set; }
        public float LatMax { get; set; }
        public float LngMin { get; set; }
        public float LngMax { get; set; }
        public MapInfoDrawTypeEnum MapInfoDrawType { get; set; }
        public DateTime LastUpdateDate_UTC { get; set; }
        public int LastUpdateContactTVItemID { get; set; }

        public virtual ICollection<MapInfoPoint> MapInfoPoints { get; set; }
        public virtual TVItem TVItem { get; set; }
        #endregion Properties in DB

        #region Properties not in DB
        [NotMapped]
        public IEnumerable<ValidationResult> ValidationResults { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public MapInfo()
        {
            MapInfoPoints = new HashSet<MapInfoPoint>();
        }
        #endregion Constructors

    }
}
