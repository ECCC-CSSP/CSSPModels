using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    public partial class BoxModelResult
    {
        #region Properties in DB
        [Key]
        public int BoxModelResultID { get; set; }
        [Range(1, -1)]
        [CSSPExist(TypeName = "BoxModel", Plurial = "s", FieldID = "BoxModelID")]
        public int BoxModelID { get; set; }
        [CSSPEnumType]
        public BoxModelResultTypeEnum BoxModelResultType { get; set; }
        public float Volume_m3 { get; set; }
        public float Surface_m2 { get; set; }
        public float Radius_m { get; set; }
        public float LeftSideDiameterLineAngle_deg { get; set; }
        public float CircleCenterLatitude { get; set; }
        public float CircleCenterLongitude { get; set; }
        public bool FixLength { get; set; }
        public bool FixWidth { get; set; }
        public float RectLength_m { get; set; }
        public float RectWidth_m { get; set; }
        public float LeftSideLineAngle_deg { get; set; }
        public float LeftSideLineStartLatitude { get; set; }
        public float LeftSideLineStartLongitude { get; set; }
        [CSSPAfter(Year = 1980)]
        public DateTime LastUpdateDate_UTC { get; set; }
        [Range(1, -1)]
        [CSSPExist(TypeName = "TVItem", Plurial = "s", FieldID = "TVItemID")]
        public int LastUpdateContactTVItemID { get; set; }

        public virtual BoxModel BoxModel { get; set; }
        #endregion Properties in DB

        #region Properties not in DB
        [NotMapped]
        public IEnumerable<ValidationResult> ValidationResults { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public BoxModelResult()
        {
            // empty for now
        }
        #endregion Constructors
    }
}
