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
    /// > <para>**DB properties for table MWQMSamples** : [MWQMSampleID](CSSPModels.MWQMSample.html#CSSPModels_MWQMSample_MWQMSampleID), [MWQMSiteTVItemID](CSSPModels.MWQMSample.html#CSSPModels_MWQMSample_MWQMSiteTVItemID), [MWQMRunTVItemID](CSSPModels.MWQMSample.html#CSSPModels_MWQMSample_MWQMRunTVItemID), [SampleDateTime_Local](CSSPModels.MWQMSample.html#CSSPModels_MWQMSample_SampleDateTime_Local), [Depth_m](CSSPModels.MWQMSample.html#CSSPModels_MWQMSample_Depth_m), [FecCol_MPN_100ml](CSSPModels.MWQMSample.html#CSSPModels_MWQMSample_FecCol_MPN_100ml), [Salinity_PPT](CSSPModels.MWQMSample.html#CSSPModels_MWQMSample_Salinity_PPT), [WaterTemp_C](CSSPModels.MWQMSample.html#CSSPModels_MWQMSample_WaterTemp_C), [PH](CSSPModels.MWQMSample.html#CSSPModels_MWQMSample_PH), [SampleTypesText](CSSPModels.MWQMSample.html#CSSPModels_MWQMSample_SampleTypesText), [SampleType_old](CSSPModels.MWQMSample.html#CSSPModels_MWQMSample_SampleType_old), [Tube_10](CSSPModels.MWQMSample.html#CSSPModels_MWQMSample_Tube_10), [Tube_1_0](CSSPModels.MWQMSample.html#CSSPModels_MWQMSample_Tube_1_0), [Tube_0_1](CSSPModels.MWQMSample.html#CSSPModels_MWQMSample_Tube_0_1), [ProcessedBy](CSSPModels.MWQMSample.html#CSSPModels_MWQMSample_ProcessedBy), [UseForOpenData](CSSPModels.MWQMSample.html#CSSPModels_MWQMSample_UseForOpenData), [LastUpdateDate_UTC](CSSPModels.MWQMSample.html#CSSPModels_MWQMSample_LastUpdateDate_UTC), [LastUpdateContactTVItemID](CSSPModels.MWQMSample.html#CSSPModels_MWQMSample_LastUpdateContactTVItemID), </para>
    /// > <para>**Other properties** : [HasErrors](CSSPModels.MWQMSample.html#CSSPModels_MWQMSample_HasErrors), [ValidationResults](CSSPModels.MWQMSample.html#CSSPModels_MWQMSample_ValidationResults), </para>
    /// > 
    /// > <para>**Used by [CSSPServices](CSSPServices.html)** : [MWQMSampleService](CSSPServices.MWQMSampleService.html)</para>
    /// > <para>**Requires [CSSPEnums](CSSPEnums.html)** : [SampleTypeEnum](CSSPEnums.SampleTypeEnum.html)</para>
    /// > <para>**Return to [CSSPModels](CSSPModels.html)**</para>
    /// </summary>
    public partial class MWQMSample : LastUpdate
    {
        #region Properties in DB
        [Key]
        [CSSPDisplayEN(DisplayEN = "MWQMSample ID")]
        [CSSPDisplayFR(DisplayFR = "MWQMSample ID")]
        [CSSPDescriptionEN(DescriptionEN = @"Contains the unique ""identifier on each row of the MWQMSamples table")]
        [CSSPDescriptionFR(DescriptionFR = @"Contient l'identifiant unique sur chaque ligne du tableau MWQMSamples")]
        public int MWQMSampleID { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>**AllowableTVTypeList is of type [CSSPEnums.TVTypeEnum](CSSPEnums.TVTypeEnum.html)**</para>
        /// > <para>16 == MWQMSite</para>
        /// > <para>[[CSSPExist](CSSPModels.CSSPExistAttribute.html)(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "16")]</para>
        /// </summary>
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "16")]
        public int MWQMSiteTVItemID { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>**AllowableTVTypeList is of type [CSSPEnums.TVTypeEnum](CSSPEnums.TVTypeEnum.html)**</para>
        /// > <para>31 == MWQMRun</para>
        /// > <para>[[CSSPExist](CSSPModels.CSSPExistAttribute.html)(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "31")]</para>
        /// </summary>
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "31")]
        public int MWQMRunTVItemID { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPAfter](CSSPModels.CSSPAfterAttribute.html)(Year = 1980)]</para>
        /// </summary>
        [CSSPAfter(Year = 1980)]
        public DateTime SampleDateTime_Local { get; set; }
        [Range(0,0D, 1000,0D)]
        public double? Depth_m { get; set; }
        [Range(0, 10000000)]
        public int FecCol_MPN_100ml { get; set; }
        [Range(0,0D, 40,0D)]
        public double? Salinity_PPT { get; set; }
        [Range(-10,0D, 40,0D)]
        public double? WaterTemp_C { get; set; }
        [Range(0,0D, 14,0D)]
        public double? PH { get; set; }
        [StringLength(50)]
        public string SampleTypesText { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPEnumType](CSSPModels.CSSPEnumTypeAttribute.html)]</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        [CSSPEnumType]
        [CSSPAllowNull]
        public SampleTypeEnum? SampleType_old { get; set; }
        [Range(0, 5)]
        public int? Tube_10 { get; set; }
        [Range(0, 5)]
        public int? Tube_1_0 { get; set; }
        [Range(0, 5)]
        public int? Tube_0_1 { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        [StringLength(10)]
        [CSSPAllowNull]
        public string ProcessedBy { get; set; }
        public bool UseForOpenData { get; set; }
        #endregion Properties in DB

        #region Constructors
        public MWQMSample() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class MWQMSampleWeb : MWQMSample
    {
        #region Properties for web information
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPFill](CSSPModels.CSSPFillAttribute.html)(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "MWQMSiteTVItemID", FillReturnField = "", FillNeedLanguage = true)]</para>
        /// </summary>
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "MWQMSiteTVItemID", FillReturnField = "", FillNeedLanguage = true)]
        public TVItemLanguage MWQMSiteTVItemLanguage { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPFill](CSSPModels.CSSPFillAttribute.html)(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "MWQMRunTVItemID", FillReturnField = "", FillNeedLanguage = true)]</para>
        /// </summary>
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "MWQMRunTVItemID", FillReturnField = "", FillNeedLanguage = true)]
        public TVItemLanguage MWQMRunTVItemLanguage { get; set; }
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
        /// > <para>[[CSSPEnumTypeText](CSSPModels.CSSPEnumTypeTextAttribute.html)(EnumTypeName = "SampleTypeEnum", EnumType = "SampleType_old")]</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        [CSSPEnumTypeText(EnumTypeName = "SampleTypeEnum", EnumType = "SampleType_old")]
        [CSSPAllowNull]
        public string SampleType_oldText { get; set; }
        #endregion Properties for web information

        #region Constructors
        public MWQMSampleWeb() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class MWQMSampleReport : MWQMSampleWeb
    {
        #region Properties for report information
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        [CSSPAllowNull]
        public string MWQMSampleReportTest { get; set; }
        #endregion Properties for report information

        #region Constructors
        public MWQMSampleReport() : base()
        {
        }
        #endregion Constructors
    }
}
