/*
 * Auto generated from the CSSPCodeWriter.proj by clicking on the [\srcWithDoc\[ModelClassName]Generated.cs] button
 *
 * Do not edit this file.
 *
 * Last generated on 2018 July 27 04:56
 * by leblancc on WMON01DTCHLEBL2 machine
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
    /// > <para>**DB properties for table Tels** : [TelID](CSSPModels.Tel.html#CSSPModels_Tel_TelID), [TelTVItemID](CSSPModels.Tel.html#CSSPModels_Tel_TelTVItemID), [TelNumber](CSSPModels.Tel.html#CSSPModels_Tel_TelNumber), [TelType](CSSPModels.Tel.html#CSSPModels_Tel_TelType), [LastUpdateDate_UTC](CSSPModels.Tel.html#CSSPModels_Tel_LastUpdateDate_UTC), [LastUpdateContactTVItemID](CSSPModels.Tel.html#CSSPModels_Tel_LastUpdateContactTVItemID), </para>
    /// > <para>**Other properties** : [TelWeb](CSSPModels.Tel.html#CSSPModels_Tel_TelWeb), [TelReport](CSSPModels.Tel.html#CSSPModels_Tel_TelReport), [HasErrors](CSSPModels.Tel.html#CSSPModels_Tel_HasErrors), [ValidationResults](CSSPModels.Tel.html#CSSPModels_Tel_ValidationResults), </para>
    /// > 
    /// > <para>**Used by [CSSPServices](CSSPServices.html)** : [TelService](CSSPServices.TelService.html)</para>
    /// > <para>**Requires [CSSPEnums](CSSPEnums.html)** : [TelTypeEnum](CSSPEnums.TelTypeEnum.html)</para>
    /// > <para>**Return to [CSSPModels](CSSPModels.html)**</para>
    /// </summary>
    public partial class Tel : LastUpdate
    {
        #region Properties in DB
        [Key]
        [CSSPDisplayEN(DisplayEN = "Tel ID")]
        [CSSPDisplayFR(DisplayFR = "Tel ID")]
        [CSSPDescriptionEN(DescriptionEN = @"Contains the unique ""identifier on each row of the Tels table")]
        [CSSPDescriptionFR(DescriptionFR = @"Contient l'identifiant unique sur chaque ligne du tableau Tels")]
        public int TelID { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>**AllowableTVTypeList is of type [CSSPEnums.TVTypeEnum](CSSPEnums.TVTypeEnum.html)**</para>
        /// > <para>21 == Tel</para>
        /// > <para>[[CSSPExist](CSSPModels.CSSPExistAttribute.html)(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "21")]</para>
        /// </summary>
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "21")]
        public int TelTVItemID { get; set; }
        [StringLength(50)]
        public string TelNumber { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPEnumType](CSSPModels.CSSPEnumTypeAttribute.html)]</para>
        /// </summary>
        [CSSPEnumType]
        public TelTypeEnum TelType { get; set; }
        #endregion Properties in DB

        #region Properties not in DB
        [NotMapped]
        [CSSPAllowNull]
        public TelWeb TelWeb { get; set; }
        [NotMapped]
        [CSSPAllowNull]
        public TelReport TelReport { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public Tel() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class TelWeb
    {
        #region Properties for web information
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPFill](CSSPModels.CSSPFillAttribute.html)(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "TelTVItemID", FillReturnField = "TVText", FillNeedLanguage = true)]</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "TelTVItemID", FillReturnField = "TVText", FillNeedLanguage = true)]
        [CSSPAllowNull]
        public string TelTVText { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPFill](CSSPModels.CSSPFillAttribute.html)(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "TVText", FillNeedLanguage = true)]</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "TVText", FillNeedLanguage = true)]
        [CSSPAllowNull]
        public string LastUpdateContactTVText { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPEnumTypeText](CSSPModels.CSSPEnumTypeTextAttribute.html)(EnumTypeName = "TelTypeEnum", EnumType = "TelType")]</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        [CSSPEnumTypeText(EnumTypeName = "TelTypeEnum", EnumType = "TelType")]
        [CSSPAllowNull]
        public string TelTypeText { get; set; }
        #endregion Properties for web information

        #region Constructors
        public TelWeb()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class TelReport
    {
        #region Properties for report information
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        [CSSPAllowNull]
        public string TelReportTest { get; set; }
        #endregion Properties for report information

        #region Constructors
        public TelReport()
        {
        }
        #endregion Constructors
    }
}