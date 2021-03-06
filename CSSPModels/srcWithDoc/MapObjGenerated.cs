/*
 * Auto generated from the CSSPCodeWriter.proj by clicking on the [\srcWithDoc\[ModelClassName]Generated.cs] button
 *
 * Do not edit this file.
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
    /// <summary>
    /// > [!NOTE]
    /// > 
    /// > <para>**No DB properties** :</para>
    /// > <para>**Other properties** : [MapInfoID](CSSPModels.MapObj.html#CSSPModels_MapObj_MapInfoID), [MapInfoDrawType](CSSPModels.MapObj.html#CSSPModels_MapObj_MapInfoDrawType), [MapInfoDrawTypeText](CSSPModels.MapObj.html#CSSPModels_MapObj_MapInfoDrawTypeText), [CoordList](CSSPModels.MapObj.html#CSSPModels_MapObj_CoordList), [CSSPError.HasErrors](CSSPModels.CSSPError.html#CSSPModels_CSSPError_HasErrors), [CSSPError.ValidationResults](CSSPModels.CSSPError.html#CSSPModels_CSSPError_ValidationResults)</para>
    /// > 
    /// > <para>**Requires [CSSPEnums](CSSPEnums.html)** : [MapInfoDrawTypeEnum](CSSPEnums.MapInfoDrawTypeEnum.html)</para>
    /// > <para>**Inherits [CSSPError](CSSPModels.CSSPError.html)**</para>
    /// > <para>**Return to [CSSPModels](CSSPModels.html)**</para>
    /// </summary>
    [NotMapped]
    public partial class MapObj : CSSPError
    {
        #region Properties in DB
        #endregion Properties in DB

        #region Properties not in DB
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "MapInfoID")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "MapInfoID")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "MapInfoID of the MapInfos database table")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "MapInfoID de la table MapInfos de la base de données")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- MapInfoID
        /// 
        /// **Display (fr)** --- MapInfoID
        /// 
        /// **Description (en)** --- MapInfoID of the MapInfos database table
        /// 
        /// **Description (fr)** --- MapInfoID de la table MapInfos de la base de données
        /// </returns>
        [Range(1, -1)]
        [CSSPDisplayEN(DisplayEN = "MapInfoID")]
        [CSSPDisplayFR(DisplayFR = "MapInfoID")]
        [CSSPDescriptionEN(DescriptionEN = @"MapInfoID of the MapInfos database table")]
        [CSSPDescriptionFR(DescriptionFR = @"MapInfoID de la table MapInfos de la base de données")]
        public int MapInfoID { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPEnumType](CSSPModels.CSSPEnumTypeAttribute.html)]</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Map info draw type")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Type d'object de l'info pour carte")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Map info draw type")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Type d'object de l'info pour carte")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Map info draw type
        /// 
        /// **Display (fr)** --- Type d'object de l'info pour carte
        /// 
        /// **Description (en)** --- Map info draw type
        /// 
        /// **Description (fr)** --- Type d'object de l'info pour carte
        /// </returns>
        [CSSPEnumType]
        [CSSPDisplayEN(DisplayEN = "Map info draw type")]
        [CSSPDisplayFR(DisplayFR = "Type d'object de l'info pour carte")]
        [CSSPDescriptionEN(DescriptionEN = @"Map info draw type")]
        [CSSPDescriptionFR(DescriptionFR = @"Type d'object de l'info pour carte")]
        public MapInfoDrawTypeEnum MapInfoDrawType { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPEnumTypeText](CSSPModels.CSSPEnumTypeTextAttribute.html)(EnumTypeName = "MapInfoDrawTypeEnum", EnumType = "MapInfoDrawType")]</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Map info draw type text")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Texte du type d'object de l'info pour carte")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Map info draw type text")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Texte du type d'object de l'info pour carte")]</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Map info draw type text
        /// 
        /// **Display (fr)** --- Texte du type d'object de l'info pour carte
        /// 
        /// **Description (en)** --- Map info draw type text
        /// 
        /// **Description (fr)** --- Texte du type d'object de l'info pour carte
        /// </returns>
        [StringLength(100)]
        [CSSPEnumTypeText(EnumTypeName = "MapInfoDrawTypeEnum", EnumType = "MapInfoDrawType")]
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "Map info draw type text")]
        [CSSPDisplayFR(DisplayFR = "Texte du type d'object de l'info pour carte")]
        [CSSPDescriptionEN(DescriptionEN = @"Map info draw type text")]
        [CSSPDescriptionFR(DescriptionFR = @"Texte du type d'object de l'info pour carte")]
        public string MapInfoDrawTypeText { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Coord list")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "List Coord")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Coord list")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "List Coord")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Coord list
        /// 
        /// **Display (fr)** --- List Coord
        /// 
        /// **Description (en)** --- Coord list
        /// 
        /// **Description (fr)** --- List Coord
        /// </returns>
        [CSSPDisplayEN(DisplayEN = "Coord list")]
        [CSSPDisplayFR(DisplayFR = "List Coord")]
        [CSSPDescriptionEN(DescriptionEN = @"Coord list")]
        [CSSPDescriptionFR(DescriptionFR = @"List Coord")]
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
