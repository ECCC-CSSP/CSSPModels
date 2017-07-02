using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    [NotMapped]
    public partial class TVLocation
    {
        #region Properties in DB
        #endregion Properties in DB

        #region Properties not in DB
        public string Error { get; set; }
        [Required]
        [Range(1, -1)]
        public int TVItemID { get; set; }
        [Required]
        [Range(1, 255)]
        public string TVText { get; set; }
        [Required]
        public TVTypeEnum TVType { get; set; }
        public TVTypeEnum SubTVType { get; set; }

        public virtual List<MapObj> MapObjList { get; set; }
        public IEnumerable<ValidationResult> ValidationResults { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public TVLocation()
        {
            MapObjList = new List<MapObj>();
        }
        #endregion Constructors
    }
}
