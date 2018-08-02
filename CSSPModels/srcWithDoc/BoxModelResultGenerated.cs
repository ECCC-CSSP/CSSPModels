/*
 * Auto generated from the CSSPCodeWriter.proj by clicking on the [\srcWithDoc\[ModelClassName]Generated.cs] button
 *
 * Do not edit this file.
 *
 * Last generated by leblancc on WMON01DTCHLEBL2 machine
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
    /// > <para>**DB properties for table BoxModelResults** : [BoxModelResultID](CSSPModels.BoxModelResult.html#CSSPModels_BoxModelResult_BoxModelResultID), [BoxModelID](CSSPModels.BoxModelResult.html#CSSPModels_BoxModelResult_BoxModelID), [BoxModelResultType](CSSPModels.BoxModelResult.html#CSSPModels_BoxModelResult_BoxModelResultType), [Volume_m3](CSSPModels.BoxModelResult.html#CSSPModels_BoxModelResult_Volume_m3), [Surface_m2](CSSPModels.BoxModelResult.html#CSSPModels_BoxModelResult_Surface_m2), [Radius_m](CSSPModels.BoxModelResult.html#CSSPModels_BoxModelResult_Radius_m), [LeftSideDiameterLineAngle_deg](CSSPModels.BoxModelResult.html#CSSPModels_BoxModelResult_LeftSideDiameterLineAngle_deg), [CircleCenterLatitude](CSSPModels.BoxModelResult.html#CSSPModels_BoxModelResult_CircleCenterLatitude), [CircleCenterLongitude](CSSPModels.BoxModelResult.html#CSSPModels_BoxModelResult_CircleCenterLongitude), [FixLength](CSSPModels.BoxModelResult.html#CSSPModels_BoxModelResult_FixLength), [FixWidth](CSSPModels.BoxModelResult.html#CSSPModels_BoxModelResult_FixWidth), [RectLength_m](CSSPModels.BoxModelResult.html#CSSPModels_BoxModelResult_RectLength_m), [RectWidth_m](CSSPModels.BoxModelResult.html#CSSPModels_BoxModelResult_RectWidth_m), [LeftSideLineAngle_deg](CSSPModels.BoxModelResult.html#CSSPModels_BoxModelResult_LeftSideLineAngle_deg), [LeftSideLineStartLatitude](CSSPModels.BoxModelResult.html#CSSPModels_BoxModelResult_LeftSideLineStartLatitude), [LeftSideLineStartLongitude](CSSPModels.BoxModelResult.html#CSSPModels_BoxModelResult_LeftSideLineStartLongitude), [LastUpdateDate_UTC](CSSPModels.BoxModelResult.html#CSSPModels_BoxModelResult_LastUpdateDate_UTC), [LastUpdateContactTVItemID](CSSPModels.BoxModelResult.html#CSSPModels_BoxModelResult_LastUpdateContactTVItemID), </para>
    /// > <para>**Other properties** : [BoxModelResultWeb](CSSPModels.BoxModelResult.html#CSSPModels_BoxModelResult_BoxModelResultWeb), [BoxModelResultReport](CSSPModels.BoxModelResult.html#CSSPModels_BoxModelResult_BoxModelResultReport), [HasErrors](CSSPModels.BoxModelResult.html#CSSPModels_BoxModelResult_HasErrors), [ValidationResults](CSSPModels.BoxModelResult.html#CSSPModels_BoxModelResult_ValidationResults), </para>
    /// > 
    /// > <para>**Used by [CSSPServices](CSSPServices.html)** : [BoxModelResultService](CSSPServices.BoxModelResultService.html)</para>
    /// > <para>**Requires [CSSPEnums](CSSPEnums.html)** : [BoxModelResultTypeEnum](CSSPEnums.BoxModelResultTypeEnum.html)</para>
    /// > <para>**Return to [CSSPModels](CSSPModels.html)**</para>
    /// </summary>
    public partial class BoxModelResult : LastUpdate
    {
        #region Properties in DB
        [Key]
        [CSSPDisplayEN(DisplayEN = "BoxModelResult ID")]
        [CSSPDisplayFR(DisplayFR = "BoxModelResult ID")]
        [CSSPDescriptionEN(DescriptionEN = @"Contains the unique ""identifier on each row of the BoxModelResults table")]
        [CSSPDescriptionFR(DescriptionFR = @"Contient l'identifiant unique sur chaque ligne du tableau BoxModelResults")]
        public int BoxModelResultID { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPExist](CSSPModels.CSSPExistAttribute.html)(ExistTypeName = "BoxModel", ExistPlurial = "s", ExistFieldID = "BoxModelID")]</para>
        /// </summary>
        [CSSPExist(ExistTypeName = "BoxModel", ExistPlurial = "s", ExistFieldID = "BoxModelID")]
        public int BoxModelID { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPEnumType](CSSPModels.CSSPEnumTypeAttribute.html)]</para>
        /// </summary>
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

        #region Properties not in DB
        [NotMapped]
        [CSSPAllowNull]
        public BoxModelResultWeb BoxModelResultWeb { get; set; }
        [NotMapped]
        [CSSPAllowNull]
        public BoxModelResultReport BoxModelResultReport { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public BoxModelResult() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class BoxModelResultWeb
    {
        #region Properties for web information
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPFill](CSSPModels.CSSPFillAttribute.html)(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "", FillNeedLanguage = true)]</para>
        /// </summary>
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "", FillNeedLanguage = true)]
        public TVItemLanguage LastUpdateContactTVItemLanguage { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPEnumTypeText](CSSPModels.CSSPEnumTypeTextAttribute.html)(EnumTypeName = "BoxModelResultTypeEnum", EnumType = "BoxModelResultType")]</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        [CSSPEnumTypeText(EnumTypeName = "BoxModelResultTypeEnum", EnumType = "BoxModelResultType")]
        [CSSPAllowNull]
        public string BoxModelResultTypeText { get; set; }
        #endregion Properties for web information

        #region Constructors
        public BoxModelResultWeb()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class BoxModelResultReport
    {
        #region Properties for report information
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        [CSSPAllowNull]
        public string BoxModelResultReportTest { get; set; }
        #endregion Properties for report information

        #region Constructors
        public BoxModelResultReport()
        {
        }
        #endregion Constructors
    }
}
