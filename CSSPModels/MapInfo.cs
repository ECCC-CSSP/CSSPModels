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
        [Key]
        public int MapInfoID { get; set; }
        [Range(1, -1)]
        [CSSPExist(TypeName = "TVItem", Plurial = "s", FieldID = "TVItemID")]
        public int TVItemID { get; set; }
        [CSSPEnumType]
        public TVTypeEnum TVType { get; set; }
        [Range(-90.0D, 90.0D)]
        public double LatMin { get; set; }
        [Range(-90.0D, 90.0D)]
        public double LatMax { get; set; }
        [Range(-180.0D, 180.0D)]
        public double LngMin { get; set; }
        [Range(-180.0D, 180.0D)]
        public double LngMax { get; set; }
        [CSSPEnumType]
        public MapInfoDrawTypeEnum MapInfoDrawType { get; set; }
        [CSSPAfter(Year = 1980)]
        public DateTime LastUpdateDate_UTC { get; set; }
        [Range(1, -1)]
        [CSSPExist(TypeName = "TVItem", Plurial = "s", FieldID = "TVItemID")]
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
