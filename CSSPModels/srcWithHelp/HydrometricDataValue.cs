/*
 * Auto generated from the CSSPModelsGenerateCode.proj by clicking on the [Generate Models With Help] button
 *
 * Do not edit this file.
 *
 * Last generated by Charles LeBlanc
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
    /// > <para>**DB properties for table HydrometricDataValues** : [HydrometricDataValueID](CSSPModels.HydrometricDataValue.html#CSSPModels_HydrometricDataValue_HydrometricDataValueID), [HydrometricSiteID](CSSPModels.HydrometricDataValue.html#CSSPModels_HydrometricDataValue_HydrometricSiteID), [DateTime_Local](CSSPModels.HydrometricDataValue.html#CSSPModels_HydrometricDataValue_DateTime_Local), [Keep](CSSPModels.HydrometricDataValue.html#CSSPModels_HydrometricDataValue_Keep), [StorageDataType](CSSPModels.HydrometricDataValue.html#CSSPModels_HydrometricDataValue_StorageDataType), [Flow_m3_s](CSSPModels.HydrometricDataValue.html#CSSPModels_HydrometricDataValue_Flow_m3_s), [HourlyValues](CSSPModels.HydrometricDataValue.html#CSSPModels_HydrometricDataValue_HourlyValues), [LastUpdateDate_UTC](CSSPModels.HydrometricDataValue.html#CSSPModels_HydrometricDataValue_LastUpdateDate_UTC), [LastUpdateContactTVItemID](CSSPModels.HydrometricDataValue.html#CSSPModels_HydrometricDataValue_LastUpdateContactTVItemID), </para>
    /// > <para>**Other properties** : [HydrometricDataValueWeb](CSSPModels.HydrometricDataValue.html#CSSPModels_HydrometricDataValue_HydrometricDataValueWeb), [HydrometricDataValueReport](CSSPModels.HydrometricDataValue.html#CSSPModels_HydrometricDataValue_HydrometricDataValueReport), [HasErrors](CSSPModels.HydrometricDataValue.html#CSSPModels_HydrometricDataValue_HasErrors), [ValidationResults](CSSPModels.HydrometricDataValue.html#CSSPModels_HydrometricDataValue_ValidationResults), </para>
    /// > 
    /// > <para>**Used by [CSSPServices](CSSPServices.html)** : [HydrometricDataValueService](CSSPServices.HydrometricDataValueService.html)</para>
    /// > <para>**Requires [CSSPEnums](CSSPEnums.html)** : [StorageDataTypeEnum](CSSPEnums.StorageDataTypeEnum.html)</para>
    /// > <para>**Return to [CSSPModels](CSSPModels.html)**</para>
    /// </summary>
    public partial class HydrometricDataValue : LastUpdate
    {
        #region Properties in DB
        [Key]
        public int HydrometricDataValueID { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPExist](CSSPModels.CSSPExistAttribute.html)(ExistTypeName = "HydrometricSite", ExistPlurial = "s", ExistFieldID = "HydrometricSiteID")]</para>
        /// </summary>
        [CSSPExist(ExistTypeName = "HydrometricSite", ExistPlurial = "s", ExistFieldID = "HydrometricSiteID")]
        public int HydrometricSiteID { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPAfter](CSSPModels.CSSPAfterAttribute.html)(Year = 1980)]</para>
        /// </summary>
        [CSSPAfter(Year = 1980)]
        public DateTime DateTime_Local { get; set; }
        public bool Keep { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPEnumType](CSSPModels.CSSPEnumTypeAttribute.html)]</para>
        /// </summary>
        [CSSPEnumType]
        public StorageDataTypeEnum StorageDataType { get; set; }
        [Range(0.0D, 10000.0D)]
        public double Flow_m3_s { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        [CSSPAllowNull]
        public string HourlyValues { get; set; }
        #endregion Properties in DB

        #region Properties not in DB
        [NotMapped]
        [CSSPAllowNull]
        public HydrometricDataValueWeb HydrometricDataValueWeb { get; set; }
        [NotMapped]
        [CSSPAllowNull]
        public HydrometricDataValueReport HydrometricDataValueReport { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public HydrometricDataValue() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class HydrometricDataValueWeb
    {
        #region Properties for web information
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
        /// > <para>[[CSSPEnumTypeText](CSSPModels.CSSPEnumTypeTextAttribute.html)(EnumTypeName = "StorageDataTypeEnum", EnumType = "StorageDataType")]</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        [CSSPEnumTypeText(EnumTypeName = "StorageDataTypeEnum", EnumType = "StorageDataType")]
        [CSSPAllowNull]
        public string StorageDataTypeText { get; set; }
        #endregion Properties for web information

        #region Constructors
        public HydrometricDataValueWeb()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class HydrometricDataValueReport
    {
        #region Properties for report information
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        [CSSPAllowNull]
        public string HydrometricDataValueReportTest { get; set; }
        #endregion Properties for report information

        #region Constructors
        public HydrometricDataValueReport()
        {
        }
        #endregion Constructors
    }
}
