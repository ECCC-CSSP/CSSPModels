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
    public partial class MapInfoPoint : LastUpdate
    {
        #region Properties in DB
        [Key]
        [CSSPDisplayEN(DisplayEN = "MapInfoPoint ID")]
        [CSSPDisplayFR(DisplayFR = "MapInfoPoint ID")]
        [CSSPDescriptionEN(DescriptionEN = @"Contains the unique ""identifier on each row of the MapInfoPoints table")]
        [CSSPDescriptionFR(DescriptionFR = @"Contient l'identifiant unique sur chaque ligne de la table MapInfoPoints")]
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

        #region Constructors
        public MapInfoPoint() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class MapInfoPoint_A : MapInfoPoint
    {
        #region Properties
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "", FillNeedLanguage = true, FillIsList = false)]
        [CSSPDisplayEN(DisplayEN = "Last update contact TVItemLanguage")]
        [CSSPDisplayFR(DisplayFR = "TVItemLanguage du contact ayant fait le dernière changement")]
        [CSSPDescriptionEN(DescriptionEN = @"Last update contact TVItemLanguage DB object")]
        [CSSPDescriptionFR(DescriptionFR = @"Object BD TVItemLanguage du contact ayant fait le dernière changement")]
        public TVItemLanguage LastUpdateContactTVItemLanguage { get; set; }
        #endregion Properties

        #region Constructors
        public MapInfoPoint_A() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class MapInfoPoint_B : MapInfoPoint_A
    {
        #region Properties
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "TVText", FillNeedLanguage = true, FillIsList = false)]
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "Report test")]
        [CSSPDisplayFR(DisplayFR = "Test report")]
        [CSSPDescriptionEN(DescriptionEN = @"Report test description")]
        [CSSPDescriptionFR(DescriptionFR = @"Description de test report")]
        public string MapInfoPointReportTest { get; set; }
        #endregion Properties

        #region Constructors
        public MapInfoPoint_B() : base()
        {
        }
        #endregion Constructors
    }
}
