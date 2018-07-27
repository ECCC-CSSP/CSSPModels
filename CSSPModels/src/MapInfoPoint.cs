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
    public partial class MapInfoPoint : LastUpdate
    {
        #region Properties in DB
        [Key]
        [CSSPDisplayEN(DisplayEN = "MapInfoPoint ID")]
        [CSSPDisplayFR(DisplayFR = "MapInfoPoint ID")]
        [CSSPDescriptionEN(DescriptionEN = @"Contains the unique ""identifier on each row of the MapInfoPoints table")]
        [CSSPDescriptionFR(DescriptionFR = @"Contient l'identifiant unique sur chaque ligne du tableau MapInfoPoints")]
        public int MapInfoPointID { get; set; }
        [CSSPExist(ExistTypeName = "MapInfo", ExistPlurial = "s", ExistFieldID = "MapInfoID")]
        public int MapInfoID { get; set; }
        [Range(0, -1)]
        public int Ordinal { get; set; }
        [Range(-90.0D, 90.0D)]
        public double Lat { get; set; }
        [Range(-180.0D, 180.0D)]
        public double Lng { get; set; }
        #endregion Properties in DB

        #region Properties not in DB
        [NotMapped]
        [CSSPAllowNull]
        public MapInfoPointWeb MapInfoPointWeb { get; set; }
        [NotMapped]
        [CSSPAllowNull]
        public MapInfoPointReport MapInfoPointReport { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public MapInfoPoint() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class MapInfoPointWeb
    {
        #region Properties for web information
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "TVText", FillNeedLanguage = true)]
        [CSSPAllowNull]
        public string LastUpdateContactTVText { get; set; }
        #endregion Properties for web information

        #region Constructors
        public MapInfoPointWeb()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class MapInfoPointReport
    {
        #region Properties for report information
        [CSSPAllowNull]
        public string MapInfoPointReportTest { get; set; }
        #endregion Properties for report information

        #region Constructors
        public MapInfoPointReport()
        {
        }
        #endregion Constructors
    }
}
