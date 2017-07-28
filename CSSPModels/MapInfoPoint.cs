using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    public partial class MapInfoPoint
    {
        #region Properties in DB
        [Key]
        public int MapInfoPointID { get; set; }
        [CSSPExist(TypeName = "MapInfo", Plurial = "s", FieldID = "MapInfoID")]
        public int MapInfoID { get; set; }
        [Range(0, -1)]
        public int Ordinal { get; set; }
        [Range(-90.0D, 90.0D)]
        public double Lat { get; set; }
        [Range(-180.0D, 180.0D)]
        public double Lng { get; set; }
        [CSSPAfter(Year = 1980)]
        public DateTime LastUpdateDate_UTC { get; set; }
        [CSSPExist(TypeName = "TVItem", Plurial = "s", FieldID = "TVItemID", TVType = TVTypeEnum.Contact)]
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
