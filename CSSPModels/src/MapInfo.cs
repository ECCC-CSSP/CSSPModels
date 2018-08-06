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
    public partial class MapInfo : LastUpdate
    {
        #region Properties in DB
        [Key]
        [CSSPDisplayEN(DisplayEN = "MapInfo ID")]
        [CSSPDisplayFR(DisplayFR = "MapInfo ID")]
        [CSSPDescriptionEN(DescriptionEN = @"Contains the unique ""identifier on each row of the MapInfos table")]
        [CSSPDescriptionFR(DescriptionFR = @"Contient l'identifiant unique sur chaque ligne de la table MapInfos")]
        public int MapInfoID { get; set; }
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "1,2,3,4,6,8,9,11,12,14,15,16,17,18,19,20,22,24,25,26,29,30,41,42,79,80,81,82,83,84")]
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
        #endregion Properties in DB

        #region Constructors
        public MapInfo() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class MapInfoWeb : MapInfo
    {
        #region Properties for web information
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "TVItemID", FillReturnField = "", FillNeedLanguage = true)]
        public TVItemLanguage TVItemLanguage { get; set; }
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "", FillNeedLanguage = true)]
        [CSSPDisplayEN(DisplayEN = "Last update contact TVItemLanguage")]
        [CSSPDisplayFR(DisplayFR = "TVItemLanguage du contact ayant fait le dernière changement")]
        [CSSPDescriptionEN(DescriptionEN = @"Last update contact TVItemLanguage DB object")]
        [CSSPDescriptionFR(DescriptionFR = @"Object BD TVItemLanguage du contact ayant fait le dernière changement")]
        public TVItemLanguage LastUpdateContactTVItemLanguage { get; set; }
        [CSSPEnumTypeText(EnumTypeName = "TVTypeEnum", EnumType = "TVType")]
        [CSSPAllowNull]
        public string TVTypeText { get; set; }
        [CSSPEnumTypeText(EnumTypeName = "MapInfoDrawTypeEnum", EnumType = "MapInfoDrawType")]
        [CSSPAllowNull]
        public string MapInfoDrawTypeText { get; set; }
        #endregion Properties for web information

        #region Constructors
        public MapInfoWeb() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class MapInfoReport : MapInfoWeb
    {
        #region Properties for report information
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "Report test")]
        [CSSPDisplayFR(DisplayFR = "Test report")]
        [CSSPDescriptionEN(DescriptionEN = @"Report test description")]
        [CSSPDescriptionFR(DescriptionFR = @"Description de test report")]
        public string MapInfoReportTest { get; set; }
        #endregion Properties for report information

        #region Constructors
        public MapInfoReport() : base()
        {
        }
        #endregion Constructors
    }
}
