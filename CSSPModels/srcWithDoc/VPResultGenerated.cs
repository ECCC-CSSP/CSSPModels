/*
 * Auto generated from the CSSPCodeWriter.proj by clicking on the [\srcWithDoc\[ModelClassName]Generated.cs] button
 *
 * Do not edit this file.
 *
 * Last generated on 2018 July 28 02:03
 * by Charles on CHARLES-PC machine
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
    /// > <para>**DB properties for table VPResults** : [VPResultID](CSSPModels.VPResult.html#CSSPModels_VPResult_VPResultID), [VPScenarioID](CSSPModels.VPResult.html#CSSPModels_VPResult_VPScenarioID), [Ordinal](CSSPModels.VPResult.html#CSSPModels_VPResult_Ordinal), [Concentration_MPN_100ml](CSSPModels.VPResult.html#CSSPModels_VPResult_Concentration_MPN_100ml), [Dilution](CSSPModels.VPResult.html#CSSPModels_VPResult_Dilution), [FarFieldWidth_m](CSSPModels.VPResult.html#CSSPModels_VPResult_FarFieldWidth_m), [DispersionDistance_m](CSSPModels.VPResult.html#CSSPModels_VPResult_DispersionDistance_m), [TravelTime_hour](CSSPModels.VPResult.html#CSSPModels_VPResult_TravelTime_hour), [LastUpdateDate_UTC](CSSPModels.VPResult.html#CSSPModels_VPResult_LastUpdateDate_UTC), [LastUpdateContactTVItemID](CSSPModels.VPResult.html#CSSPModels_VPResult_LastUpdateContactTVItemID), </para>
    /// > <para>**Other properties** : [VPResultWeb](CSSPModels.VPResult.html#CSSPModels_VPResult_VPResultWeb), [VPResultReport](CSSPModels.VPResult.html#CSSPModels_VPResult_VPResultReport), [HasErrors](CSSPModels.VPResult.html#CSSPModels_VPResult_HasErrors), [ValidationResults](CSSPModels.VPResult.html#CSSPModels_VPResult_ValidationResults), </para>
    /// > 
    /// > <para>**Used by [CSSPServices](CSSPServices.html)** : [VPResultService](CSSPServices.VPResultService.html)</para>
    /// > <para>**Return to [CSSPModels](CSSPModels.html)**</para>
    /// </summary>
    public partial class VPResult : LastUpdate
    {
        #region Properties in DB
        [Key]
        [CSSPDisplayEN(DisplayEN = "VPResult ID")]
        [CSSPDisplayFR(DisplayFR = "VPResult ID")]
        [CSSPDescriptionEN(DescriptionEN = @"Contains the unique ""identifier on each row of the VPResults table")]
        [CSSPDescriptionFR(DescriptionFR = @"Contient l'identifiant unique sur chaque ligne du tableau VPResults")]
        public int VPResultID { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPExist](CSSPModels.CSSPExistAttribute.html)(ExistTypeName = "VPScenario", ExistPlurial = "s", ExistFieldID = "VPScenarioID")]</para>
        /// </summary>
        [CSSPExist(ExistTypeName = "VPScenario", ExistPlurial = "s", ExistFieldID = "VPScenarioID")]
        public int VPScenarioID { get; set; }
        [Range(0, 1000)]
        public int Ordinal { get; set; }
        [Range(0, 10000000)]
        public int Concentration_MPN_100ml { get; set; }
        [Range(0.0D, 1000000.0D)]
        public double Dilution { get; set; }
        [Range(0.0D, 10000.0D)]
        public double FarFieldWidth_m { get; set; }
        [Range(0.0D, 100000.0D)]
        public double DispersionDistance_m { get; set; }
        [Range(0.0D, 100.0D)]
        public double TravelTime_hour { get; set; }
        #endregion Properties in DB

        #region Properties not in DB
        [NotMapped]
        [CSSPAllowNull]
        public VPResultWeb VPResultWeb { get; set; }
        [NotMapped]
        [CSSPAllowNull]
        public VPResultReport VPResultReport { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public VPResult() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class VPResultWeb
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
        public VPResultWeb()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class VPResultReport
    {
        #region Properties for report information
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        [CSSPAllowNull]
        public string VPResultReportTest { get; set; }
        #endregion Properties for report information

        #region Constructors
        public VPResultReport()
        {
        }
        #endregion Constructors
    }
}
