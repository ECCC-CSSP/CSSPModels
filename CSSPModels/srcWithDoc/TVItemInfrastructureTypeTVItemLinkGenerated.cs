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
    /// > <para>**No DB properties** :</para>
    /// > <para>**Other properties** : [InfrastructureType](CSSPModels.TVItemInfrastructureTypeTVItemLink.html#CSSPModels_TVItemInfrastructureTypeTVItemLink_InfrastructureType), [SeeOtherTVItemID](CSSPModels.TVItemInfrastructureTypeTVItemLink.html#CSSPModels_TVItemInfrastructureTypeTVItemLink_SeeOtherTVItemID), [InfrastructureTypeText](CSSPModels.TVItemInfrastructureTypeTVItemLink.html#CSSPModels_TVItemInfrastructureTypeTVItemLink_InfrastructureTypeText), [TVItem](CSSPModels.TVItemInfrastructureTypeTVItemLink.html#CSSPModels_TVItemInfrastructureTypeTVItemLink_TVItem), [TVItemLinkList](CSSPModels.TVItemInfrastructureTypeTVItemLink.html#CSSPModels_TVItemInfrastructureTypeTVItemLink_TVItemLinkList), [FlowTo](CSSPModels.TVItemInfrastructureTypeTVItemLink.html#CSSPModels_TVItemInfrastructureTypeTVItemLink_FlowTo), [HasErrors](CSSPModels.TVItemInfrastructureTypeTVItemLink.html#CSSPModels_TVItemInfrastructureTypeTVItemLink_HasErrors), [ValidationResults](CSSPModels.TVItemInfrastructureTypeTVItemLink.html#CSSPModels_TVItemInfrastructureTypeTVItemLink_ValidationResults), </para>
    /// > 
    /// > <para>**Used by [CSSPServices](CSSPServices.html)** : [TVItemInfrastructureTypeTVItemLinkService](CSSPServices.TVItemInfrastructureTypeTVItemLinkService.html)</para>
    /// > <para>**Requires [CSSPEnums](CSSPEnums.html)** : [InfrastructureTypeEnum](CSSPEnums.InfrastructureTypeEnum.html)</para>
    /// > <para>**Return to [CSSPModels](CSSPModels.html)**</para>
    /// </summary>
    [NotMapped]
    public partial class TVItemInfrastructureTypeTVItemLink : Error
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
        public InfrastructureTypeEnum InfrastructureType { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        [CSSPAllowNull]
        public int? SeeOtherTVItemID { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPEnumTypeText](CSSPModels.CSSPEnumTypeTextAttribute.html)(EnumTypeName = "InfrastructureTypeEnum", EnumType = "InfrastructureType")]</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        [StringLength(100)]
        [CSSPEnumTypeText(EnumTypeName = "InfrastructureTypeEnum", EnumType = "InfrastructureType")]
        [CSSPAllowNull]
        public string InfrastructureTypeText { get; set; }
        public virtual TVItem TVItem { get; set; }
        public virtual List<TVItemLink> TVItemLinkList { get; set; }
        public virtual TVItemInfrastructureTypeTVItemLink FlowTo { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public TVItemInfrastructureTypeTVItemLink() : base()
        {
            TVItemLinkList = new List<TVItemLink>();
        }
        #endregion Constructors
    }
}