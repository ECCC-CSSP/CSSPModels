/*
 * Auto generated from the CSSPCodeWriter.proj by clicking on the [\srcWithDoc\[ModelClassName]Generated.cs] button
 *
 * Do not edit this file.
 *
 * Last generated on 2018 August 01 05:00
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
    /// > <para>**No DB properties** :</para>
    /// > <para>**Other properties** : [CSSPWQInputType](CSSPModels.CSSPWQInputParam.html#CSSPModels_CSSPWQInputParam_CSSPWQInputType), [Name](CSSPModels.CSSPWQInputParam.html#CSSPModels_CSSPWQInputParam_Name), [TVItemID](CSSPModels.CSSPWQInputParam.html#CSSPModels_CSSPWQInputParam_TVItemID), [CSSPWQInputTypeText](CSSPModels.CSSPWQInputParam.html#CSSPModels_CSSPWQInputParam_CSSPWQInputTypeText), [sidList](CSSPModels.CSSPWQInputParam.html#CSSPModels_CSSPWQInputParam_sidList), [MWQMSiteList](CSSPModels.CSSPWQInputParam.html#CSSPModels_CSSPWQInputParam_MWQMSiteList), [MWQMSiteTVItemIDList](CSSPModels.CSSPWQInputParam.html#CSSPModels_CSSPWQInputParam_MWQMSiteTVItemIDList), [DailyDuplicateMWQMSiteList](CSSPModels.CSSPWQInputParam.html#CSSPModels_CSSPWQInputParam_DailyDuplicateMWQMSiteList), [DailyDuplicateMWQMSiteTVItemIDList](CSSPModels.CSSPWQInputParam.html#CSSPModels_CSSPWQInputParam_DailyDuplicateMWQMSiteTVItemIDList), [InfrastructureList](CSSPModels.CSSPWQInputParam.html#CSSPModels_CSSPWQInputParam_InfrastructureList), [InfrastructureTVItemIDList](CSSPModels.CSSPWQInputParam.html#CSSPModels_CSSPWQInputParam_InfrastructureTVItemIDList), [HasErrors](CSSPModels.CSSPWQInputParam.html#CSSPModels_CSSPWQInputParam_HasErrors), [ValidationResults](CSSPModels.CSSPWQInputParam.html#CSSPModels_CSSPWQInputParam_ValidationResults), </para>
    /// > 
    /// > <para>**Used by [CSSPServices](CSSPServices.html)** : [CSSPWQInputParamService](CSSPServices.CSSPWQInputParamService.html)</para>
    /// > <para>**Requires [CSSPEnums](CSSPEnums.html)** : [CSSPWQInputTypeEnum](CSSPEnums.CSSPWQInputTypeEnum.html)</para>
    /// > <para>**Return to [CSSPModels](CSSPModels.html)**</para>
    /// </summary>
    [NotMapped]
    public partial class CSSPWQInputParam : Error
    {
        #region Properties in DB
        #endregion Properties in DB

        #region Properties not in DB
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPEnumType](CSSPModels.CSSPEnumTypeAttribute.html)]</para>
        /// </summary>
        [CSSPEnumType]
        public CSSPWQInputTypeEnum CSSPWQInputType { get; set; }
        [StringLength(200, MinimumLength = 1)]
        public string Name { get; set; }
        [Range(1, -1)]
        public int TVItemID { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPEnumTypeText](CSSPModels.CSSPEnumTypeTextAttribute.html)(EnumTypeName = "CSSPWQInputTypeEnum", EnumType = "CSSPWQInputType")]</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        [StringLength(100)]
        [CSSPEnumTypeText(EnumTypeName = "CSSPWQInputTypeEnum", EnumType = "CSSPWQInputType")]
        [CSSPAllowNull]
        public string CSSPWQInputTypeText { get; set; }
        public virtual List<string> sidList { get; set; }
        public virtual List<string> MWQMSiteList { get; set; }
        public virtual List<int> MWQMSiteTVItemIDList { get; set; }
        public virtual List<string> DailyDuplicateMWQMSiteList { get; set; }
        public virtual List<int> DailyDuplicateMWQMSiteTVItemIDList { get; set; }
        public virtual List<string> InfrastructureList { get; set; }
        public virtual List<int> InfrastructureTVItemIDList { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public CSSPWQInputParam() : base()
        {
            sidList = new List<string>();
            MWQMSiteList = new List<string>();
            MWQMSiteTVItemIDList = new List<int>();
            DailyDuplicateMWQMSiteList = new List<string>();
            DailyDuplicateMWQMSiteTVItemIDList = new List<int>();
            InfrastructureList = new List<string>();
            InfrastructureTVItemIDList = new List<int>();
        }
        #endregion Constructors
    }
}
