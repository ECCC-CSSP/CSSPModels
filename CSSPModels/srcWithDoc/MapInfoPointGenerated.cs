/*
 * Auto generated from the CSSPCodeWriter.proj by clicking on the [\srcWithDoc\[ModelClassName]Generated.cs] button
 *
 * Do not edit this file.
 *
 * Last generated by Charles on CHARLES-PC machine
 *
 */ 
using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    /// <summary>
    /// > [!NOTE]
    /// > 
    /// > <para>**DB properties for table MapInfoPoints** : [MapInfoPointID](CSSPModels.MapInfoPoint.html#CSSPModels_MapInfoPoint_MapInfoPointID), [MapInfoID](CSSPModels.MapInfoPoint.html#CSSPModels_MapInfoPoint_MapInfoID), [Ordinal](CSSPModels.MapInfoPoint.html#CSSPModels_MapInfoPoint_Ordinal), [Lat](CSSPModels.MapInfoPoint.html#CSSPModels_MapInfoPoint_Lat), [Lng](CSSPModels.MapInfoPoint.html#CSSPModels_MapInfoPoint_Lng), [LastUpdateDate_UTC](CSSPModels.MapInfoPoint.html#CSSPModels_MapInfoPoint_LastUpdateDate_UTC), [LastUpdateContactTVItemID](CSSPModels.MapInfoPoint.html#CSSPModels_MapInfoPoint_LastUpdateContactTVItemID), </para>
    /// > <para>**Other properties** : [HasErrors](CSSPModels.MapInfoPoint.html#CSSPModels_MapInfoPoint_HasErrors), [ValidationResults](CSSPModels.MapInfoPoint.html#CSSPModels_MapInfoPoint_ValidationResults), </para>
    /// > 
    /// > <para>**Used by [CSSPServices](CSSPServices.html)** : [MapInfoPointService](CSSPServices.MapInfoPointService.html)</para>
    /// > <para>**Return to [CSSPModels](CSSPModels.html)**</para>
    /// </summary>
    public partial class MapInfoPoint : LastUpdate
    {
        #region Properties in DB
        [Key]
        [CSSPDisplayEN(DisplayEN = "MapInfoPoint ID")]
        [CSSPDisplayFR(DisplayFR = "MapInfoPoint ID")]
        [CSSPDescriptionEN(DescriptionEN = @"Contains the unique ""identifier on each row of the MapInfoPoints table")]
        [CSSPDescriptionFR(DescriptionFR = @"Contient l'identifiant unique sur chaque ligne du tableau MapInfoPoints")]
        public int MapInfoPointID { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPExist](CSSPModels.CSSPExistAttribute.html)(ExistTypeName = "MapInfo", ExistPlurial = "s", ExistFieldID = "MapInfoID")]</para>
        /// </summary>
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
    public partial class MapInfoPointWeb : MapInfoPoint
    {
        #region Properties for web information
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPFill](CSSPModels.CSSPFillAttribute.html)(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "", FillNeedLanguage = true)]</para>
        /// </summary>
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "", FillNeedLanguage = true)]
        public TVItemLanguage LastUpdateContactTVItemLanguage { get; set; }
        #endregion Properties for web information

        #region Constructors
        public MapInfoPointWeb() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class MapInfoPointReport : MapInfoPointWeb
    {
        #region Properties for report information
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        [CSSPAllowNull]
        public string MapInfoPointReportTest { get; set; }
        #endregion Properties for report information

        #region Constructors
        public MapInfoPointReport() : base()
        {
        }
        #endregion Constructors
    }
}
