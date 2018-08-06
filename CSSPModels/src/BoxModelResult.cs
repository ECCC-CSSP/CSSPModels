﻿/*
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
    public partial class BoxModelResult : LastUpdate
    {
        #region Properties in DB
        [Key]
        [CSSPDisplayEN(DisplayEN = "BoxModelResult ID")]
        [CSSPDisplayFR(DisplayFR = "BoxModelResult ID")]
        [CSSPDescriptionEN(DescriptionEN = @"Contains the unique ""identifier on each row of the BoxModelResults table")]
        [CSSPDescriptionFR(DescriptionFR = @"Contient l'identifiant unique sur chaque ligne de la table BoxModelResults")]
        public int BoxModelResultID { get; set; }
        [CSSPExist(ExistTypeName = "BoxModel", ExistPlurial = "s", ExistFieldID = "BoxModelID")]
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
        public double? LeftSideDiameterLineAngle_deg { get; set; }
        [Range(-90.0D, 90.0D)]
        public double? CircleCenterLatitude { get; set; }
        [Range(-180.0D, 180.0D)]
        public double? CircleCenterLongitude { get; set; }
        public bool FixLength { get; set; }
        public bool FixWidth { get; set; }
        [Range(0.0D, 100000.0D)]
        public double RectLength_m { get; set; }
        [Range(0.0D, 100000.0D)]
        public double RectWidth_m { get; set; }
        [Range(0.0D, 360.0D)]
        public double? LeftSideLineAngle_deg { get; set; }
        [Range(-90.0D, 90.0D)]
        public double? LeftSideLineStartLatitude { get; set; }
        [Range(-180.0D, 180.0D)]
        public double? LeftSideLineStartLongitude { get; set; }
        #endregion Properties in DB

        #region Constructors
        public BoxModelResult() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class BoxModelResultWeb : BoxModelResult
    {
        #region Properties for web information
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "", FillNeedLanguage = true)]
        [CSSPDisplayEN(DisplayEN = "Last update contact TVItemLanguage")]
        [CSSPDisplayFR(DisplayFR = "TVItemLanguage du contact ayant fait le dernière changement")]
        [CSSPDescriptionEN(DescriptionEN = @"Last update contact TVItemLanguage DB object")]
        [CSSPDescriptionFR(DescriptionFR = @"Object BD TVItemLanguage du contact ayant fait le dernière changement")]
        public TVItemLanguage LastUpdateContactTVItemLanguage { get; set; }
        [CSSPEnumTypeText(EnumTypeName = "BoxModelResultTypeEnum", EnumType = "BoxModelResultType")]
        [CSSPAllowNull]
        public string BoxModelResultTypeText { get; set; }
        #endregion Properties for web information

        #region Constructors
        public BoxModelResultWeb() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class BoxModelResultReport : BoxModelResultWeb
    {
        #region Properties for report information
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "Report test")]
        [CSSPDisplayFR(DisplayFR = "Test report")]
        [CSSPDescriptionEN(DescriptionEN = @"Report test description")]
        [CSSPDescriptionFR(DescriptionFR = @"Description de test report")]
        public string BoxModelResultReportTest { get; set; }
        #endregion Properties for report information

        #region Constructors
        public BoxModelResultReport() : base()
        {
        }
        #endregion Constructors
    }
}
