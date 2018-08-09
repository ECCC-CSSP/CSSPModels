/*
 * Manually edited by Charles LeBlanc 
 * 
 */
using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace CSSPModels
{
    [NotMapped]
    public partial class MapObj : Error
    {
        #region Properties in DB
        #endregion Properties in DB

        #region Properties not in DB
        [Range(1, -1)]
        public int MapInfoID { get; set; }
        [CSSPEnumType]
        public MapInfoDrawTypeEnum MapInfoDrawType { get; set; }
        [StringLength(100)]
        [CSSPEnumTypeText(EnumTypeName = "MapInfoDrawTypeEnum", EnumType = "MapInfoDrawType")]
        [CSSPAllowNull]
        public string MapInfoDrawTypeText { get; set; }
        public List<Coord> CoordList { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public MapObj() : base()
        {
            CoordList = new List<Coord>();
        }
        #endregion Constructors
    }
}
