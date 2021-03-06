﻿/*
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
        [CSSPDisplayEN(DisplayEN = "TVItem")]
        [CSSPDisplayFR(DisplayFR = "Item TV")]
        [CSSPDescriptionEN(DescriptionEN = @"Link to the TVItems table representing the item")]
        [CSSPDescriptionFR(DescriptionFR = @"Lien à la table TVItems représentant l'item")]
        public int TVItemID { get; set; }
        [CSSPEnumType]
        [CSSPDisplayEN(DisplayEN = "TVType")]
        [CSSPDisplayFR(DisplayFR = "Type de l'arbre visuel")]
        [CSSPDescriptionEN(DescriptionEN = @"Tree view type")]
        [CSSPDescriptionFR(DescriptionFR = @"Type de l'arbre visuel")]
        public TVTypeEnum TVType { get; set; }
        [Range(-90.0D, 90.0D)]
        [CSSPDisplayEN(DisplayEN = "Lat min")]
        [CSSPDisplayFR(DisplayFR = "Lat min")]
        [CSSPDescriptionEN(DescriptionEN = @"Latitude minimum")]
        [CSSPDescriptionFR(DescriptionFR = @"Latitude minimum")]
        public double LatMin { get; set; }
        [Range(-90.0D, 90.0D)]
        [CSSPDisplayEN(DisplayEN = "Lat max")]
        [CSSPDisplayFR(DisplayFR = "Lat max")]
        [CSSPDescriptionEN(DescriptionEN = @"Latitude maximum")]
        [CSSPDescriptionFR(DescriptionFR = @"Latitude maximum")]
        public double LatMax { get; set; }
        [Range(-180.0D, 180.0D)]
        [CSSPDisplayEN(DisplayEN = "Lng min")]
        [CSSPDisplayFR(DisplayFR = "Lng min")]
        [CSSPDescriptionEN(DescriptionEN = @"Longitude minimum")]
        [CSSPDescriptionFR(DescriptionFR = @"Longitude minimum")]
        public double LngMin { get; set; }
        [Range(-180.0D, 180.0D)]
        [CSSPDisplayEN(DisplayEN = "Lng max")]
        [CSSPDisplayFR(DisplayFR = "Lng max")]
        [CSSPDescriptionEN(DescriptionEN = @"Longitude maximum")]
        [CSSPDescriptionFR(DescriptionFR = @"Longitude maximum")]
        public double LngMax { get; set; }
        [CSSPEnumType]
        [CSSPDisplayEN(DisplayEN = "Map object draw type")]
        [CSSPDisplayFR(DisplayFR = "Type d'object pour carte")]
        [CSSPDescriptionEN(DescriptionEN = @"Map object draw type")]
        [CSSPDescriptionFR(DescriptionFR = @"Type d'object pour carte")]
        public MapInfoDrawTypeEnum MapInfoDrawType { get; set; }
        #endregion Properties in DB

        #region Constructors
        public MapInfo() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class MapInfoExtraA : MapInfo
    {
        #region Properties
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "TVItemID", FillReturnField = "TVText", FillNeedLanguage = true, FillIsList = false)]
        [CSSPDisplayEN(DisplayEN = "Item text")]
        [CSSPDisplayFR(DisplayFR = "Texte de l'élément")]
        [CSSPDescriptionEN(DescriptionEN = @"Item text")]
        [CSSPDescriptionFR(DescriptionFR = @"Texte de l'élément")]
        public string TVItemText { get; set; }
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "TVText", FillNeedLanguage = true, FillIsList = false)]
        [CSSPDisplayEN(DisplayEN = "Last update contact name")]
        [CSSPDisplayFR(DisplayFR = "Nom du contact ayant fait le dernière changement")]
        [CSSPDescriptionEN(DescriptionEN = @"Last update contact name")]
        [CSSPDescriptionFR(DescriptionFR = @"Nom du contact ayant fait le dernière changement")]
        public string LastUpdateContactText { get; set; }
        [CSSPEnumTypeText(EnumTypeName = "TVTypeEnum", EnumType = "TVType")]
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "Map object draw type text")]
        [CSSPDisplayFR(DisplayFR = "Texte du type d'object pour carte")]
        [CSSPDescriptionEN(DescriptionEN = @"Map object draw type text")]
        [CSSPDescriptionFR(DescriptionFR = @"Texte du type d'object pour carte")]
        public string TVTypeText { get; set; }
        [CSSPEnumTypeText(EnumTypeName = "MapInfoDrawTypeEnum", EnumType = "MapInfoDrawType")]
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "Tree view type text")]
        [CSSPDisplayFR(DisplayFR = "Texte de l'arbre visuel")]
        [CSSPDescriptionEN(DescriptionEN = @"Tree view type text")]
        [CSSPDescriptionFR(DescriptionFR = @"Texte de l'arbre visuel")]
        public string MapInfoDrawTypeText { get; set; }
        #endregion Properties

        #region Constructors
        public MapInfoExtraA() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class MapInfoExtraB : MapInfoExtraA
    {
        #region Properties
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "TVText", FillNeedLanguage = true, FillIsList = false)]
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "Report test")]
        [CSSPDisplayFR(DisplayFR = "Test report")]
        [CSSPDescriptionEN(DescriptionEN = @"Report test description")]
        [CSSPDescriptionFR(DescriptionFR = @"Description de test report")]
        public string MapInfoReportTest { get; set; }
        #endregion Properties

        #region Constructors
        public MapInfoExtraB() : base()
        {
        }
        #endregion Constructors
    }
}
