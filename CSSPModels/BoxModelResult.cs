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
        [Range(0.0D, -1.0D)]
        public double Volume_m3 { get; set; }
        [Range(0.0D, -1.0D)]
        public double Surface_m2 { get; set; }
        [Range(0.0D, 100000.0D)]
        public double Radius_m { get; set; }
        [Range(0.0D, 360.0D)]
        public double LeftSideDiameterLineAngle_deg { get; set; }
        [Range(-90.0D, 90.0D)]
        public double CircleCenterLatitude { get; set; }
        [Range(-180.0D, 180.0D)]
        public double CircleCenterLongitude { get; set; }
        public bool FixLength { get; set; }
        public bool FixWidth { get; set; }
        [Range(0.0D, 100000.0D)]
        public double RectLength_m { get; set; }
        [Range(0.0D, 100000.0D)]
        public double RectWidth_m { get; set; }
        [Range(0.0D, 360.0D)]
        public double LeftSideLineAngle_deg { get; set; }
        [Range(-90.0D, 90.0D)]
        public double LeftSideLineStartLatitude { get; set; }
        [Range(-180.0D, 180.0d)]
        public double LeftSideLineStartLongitude { get; set; }
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
