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
    /// > <para>**DB properties for table MikeSourceStartEnds** : [MikeSourceStartEndID](CSSPModels.MikeSourceStartEnd.html#CSSPModels_MikeSourceStartEnd_MikeSourceStartEndID), [MikeSourceID](CSSPModels.MikeSourceStartEnd.html#CSSPModels_MikeSourceStartEnd_MikeSourceID), [StartDateAndTime_Local](CSSPModels.MikeSourceStartEnd.html#CSSPModels_MikeSourceStartEnd_StartDateAndTime_Local), [EndDateAndTime_Local](CSSPModels.MikeSourceStartEnd.html#CSSPModels_MikeSourceStartEnd_EndDateAndTime_Local), [SourceFlowStart_m3_day](CSSPModels.MikeSourceStartEnd.html#CSSPModels_MikeSourceStartEnd_SourceFlowStart_m3_day), [SourceFlowEnd_m3_day](CSSPModels.MikeSourceStartEnd.html#CSSPModels_MikeSourceStartEnd_SourceFlowEnd_m3_day), [SourcePollutionStart_MPN_100ml](CSSPModels.MikeSourceStartEnd.html#CSSPModels_MikeSourceStartEnd_SourcePollutionStart_MPN_100ml), [SourcePollutionEnd_MPN_100ml](CSSPModels.MikeSourceStartEnd.html#CSSPModels_MikeSourceStartEnd_SourcePollutionEnd_MPN_100ml), [SourceTemperatureStart_C](CSSPModels.MikeSourceStartEnd.html#CSSPModels_MikeSourceStartEnd_SourceTemperatureStart_C), [SourceTemperatureEnd_C](CSSPModels.MikeSourceStartEnd.html#CSSPModels_MikeSourceStartEnd_SourceTemperatureEnd_C), [SourceSalinityStart_PSU](CSSPModels.MikeSourceStartEnd.html#CSSPModels_MikeSourceStartEnd_SourceSalinityStart_PSU), [SourceSalinityEnd_PSU](CSSPModels.MikeSourceStartEnd.html#CSSPModels_MikeSourceStartEnd_SourceSalinityEnd_PSU), [LastUpdateDate_UTC](CSSPModels.MikeSourceStartEnd.html#CSSPModels_MikeSourceStartEnd_LastUpdateDate_UTC), [LastUpdateContactTVItemID](CSSPModels.MikeSourceStartEnd.html#CSSPModels_MikeSourceStartEnd_LastUpdateContactTVItemID), </para>
    /// > <para>**Other properties** : [MikeSourceStartEndWeb](CSSPModels.MikeSourceStartEnd.html#CSSPModels_MikeSourceStartEnd_MikeSourceStartEndWeb), [MikeSourceStartEndReport](CSSPModels.MikeSourceStartEnd.html#CSSPModels_MikeSourceStartEnd_MikeSourceStartEndReport), [HasErrors](CSSPModels.MikeSourceStartEnd.html#CSSPModels_MikeSourceStartEnd_HasErrors), [ValidationResults](CSSPModels.MikeSourceStartEnd.html#CSSPModels_MikeSourceStartEnd_ValidationResults), </para>
    /// > 
    /// > <para>**Used by [CSSPServices](CSSPServices.html)** : [MikeSourceStartEndService](CSSPServices.MikeSourceStartEndService.html)</para>
    /// > <para>**Return to [CSSPModels](CSSPModels.html)**</para>
    /// </summary>
    public partial class MikeSourceStartEnd : LastUpdate
    {
        #region Properties in DB
        [Key]
        [CSSPDisplayEN(DisplayEN = "MikeSourceStartEnd ID")]
        [CSSPDisplayFR(DisplayFR = "MikeSourceStartEnd ID")]
        [CSSPDescriptionEN(DescriptionEN = @"Contains the unique ""identifier on each row of the MikeSourceStartEnds table")]
        [CSSPDescriptionFR(DescriptionFR = @"Contient l'identifiant unique sur chaque ligne du tableau MikeSourceStartEnds")]
        public int MikeSourceStartEndID { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPExist](CSSPModels.CSSPExistAttribute.html)(ExistTypeName = "MikeSource", ExistPlurial = "s", ExistFieldID = "MikeSourceID")]</para>
        /// </summary>
        [CSSPExist(ExistTypeName = "MikeSource", ExistPlurial = "s", ExistFieldID = "MikeSourceID")]
        public int MikeSourceID { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPAfter](CSSPModels.CSSPAfterAttribute.html)(Year = 1980)]</para>
        /// </summary>
        [CSSPAfter(Year = 1980)]
        public DateTime StartDateAndTime_Local { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPAfter](CSSPModels.CSSPAfterAttribute.html)(Year = 1980)]</para>
        /// > <para>[[CSSPBigger](CSSPModels.CSSPBiggerAttribute.html)(OtherField = "StartDateAndTime_Local")]</para>
        /// </summary>
        [CSSPAfter(Year = 1980)]
        [CSSPBigger(OtherField = "StartDateAndTime_Local")]
        public DateTime EndDateAndTime_Local { get; set; }
        [Range(0.0D, 1000000.0D)]
        public double SourceFlowStart_m3_day { get; set; }
        [Range(0.0D, 1000000.0D)]
        public double SourceFlowEnd_m3_day { get; set; }
        [Range(0, 10000000)]
        public int SourcePollutionStart_MPN_100ml { get; set; }
        [Range(0, 10000000)]
        public int SourcePollutionEnd_MPN_100ml { get; set; }
        [Range(-10.0D, 40.0D)]
        public double SourceTemperatureStart_C { get; set; }
        [Range(-10.0D, 40.0D)]
        public double SourceTemperatureEnd_C { get; set; }
        [Range(0.0D, 40.0D)]
        public double SourceSalinityStart_PSU { get; set; }
        [Range(0.0D, 40.0D)]
        public double SourceSalinityEnd_PSU { get; set; }
        #endregion Properties in DB

        #region Properties not in DB
        [NotMapped]
        [CSSPAllowNull]
        public MikeSourceStartEndWeb MikeSourceStartEndWeb { get; set; }
        [NotMapped]
        [CSSPAllowNull]
        public MikeSourceStartEndReport MikeSourceStartEndReport { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public MikeSourceStartEnd() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class MikeSourceStartEndWeb
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
        #endregion Properties for web information

        #region Constructors
        public MikeSourceStartEndWeb()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class MikeSourceStartEndReport
    {
        #region Properties for report information
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        [CSSPAllowNull]
        public string MikeSourceStartEndReportTest { get; set; }
        #endregion Properties for report information

        #region Constructors
        public MikeSourceStartEndReport()
        {
        }
        #endregion Constructors
    }
}