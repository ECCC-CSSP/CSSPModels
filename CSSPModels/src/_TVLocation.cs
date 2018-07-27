/*
 * Manually edited by Charles LeBlanc 
 * 
 */
using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    [NotMapped]
    public partial class TVLocation : Error
    {
        #region Properties in DB
        #endregion Properties in DB

        #region Properties not in DB
        public string Error { get; set; }
        [Range(1, -1)]
        public int TVItemID { get; set; }
        [StringLength(255, MinimumLength = 1)]
        public string TVText { get; set; }
        [CSSPEnumType]
        public TVTypeEnum TVType { get; set; }
        [CSSPEnumType]
        public TVTypeEnum SubTVType { get; set; }
        [StringLength(100)]
        [CSSPEnumTypeText(EnumTypeName = "TVTypeEnum", EnumType = "TVType")]
        [CSSPAllowNull]
        public string TVTypeText { get; set; }
        [StringLength(100)]
        [CSSPEnumTypeText(EnumTypeName = "TVTypeEnum", EnumType = "SubTVType")]
        [CSSPAllowNull]
        public string SubTVTypeText { get; set; }
        public virtual List<MapObj> MapObjList { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public TVLocation() : base()
        {
            MapObjList = new List<MapObj>();
        }
        #endregion Constructors
    }
}
