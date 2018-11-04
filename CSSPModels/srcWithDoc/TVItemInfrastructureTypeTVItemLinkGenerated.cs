/*
 * Auto generated from the CSSPCodeWriter.proj by clicking on the [\srcWithDoc\[ModelClassName]Generated.cs] button
 *
 * Do not edit this file.
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
    /// <summary>
    /// > [!NOTE]
    /// > 
    /// > <para>**No DB properties** :</para>
    /// > <para>**Other properties** : [InfrastructureType](CSSPModels.TVItemInfrastructureTypeTVItemLink.html#CSSPModels_TVItemInfrastructureTypeTVItemLink_InfrastructureType), [SeeOtherTVItemID](CSSPModels.TVItemInfrastructureTypeTVItemLink.html#CSSPModels_TVItemInfrastructureTypeTVItemLink_SeeOtherTVItemID), [InfrastructureTypeText](CSSPModels.TVItemInfrastructureTypeTVItemLink.html#CSSPModels_TVItemInfrastructureTypeTVItemLink_InfrastructureTypeText), [TVItem](CSSPModels.TVItemInfrastructureTypeTVItemLink.html#CSSPModels_TVItemInfrastructureTypeTVItemLink_TVItem), [TVItemLinkList](CSSPModels.TVItemInfrastructureTypeTVItemLink.html#CSSPModels_TVItemInfrastructureTypeTVItemLink_TVItemLinkList), [FlowTo](CSSPModels.TVItemInfrastructureTypeTVItemLink.html#CSSPModels_TVItemInfrastructureTypeTVItemLink_FlowTo), [CSSPError.HasErrors](CSSPModels.CSSPError.html#CSSPModels_CSSPError_HasErrors), [CSSPError.ValidationResults](CSSPModels.CSSPError.html#CSSPModels_CSSPError_ValidationResults)</para>
    /// > 
    /// > <para>**Requires [CSSPEnums](CSSPEnums.html)** : [InfrastructureTypeEnum](CSSPEnums.InfrastructureTypeEnum.html)</para>
    /// > <para>**Inherits [CSSPError](CSSPModels.CSSPError.html)**</para>
    /// > <para>**Return to [CSSPModels](CSSPModels.html)**</para>
    /// </summary>
    [NotMapped]
    public partial class TVItemInfrastructureTypeTVItemLink : CSSPError
    {
        #region Properties in DB
        #endregion Properties in DB

        #region Properties not in DB
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPEnumType](CSSPModels.CSSPEnumTypeAttribute.html)]</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Infrastructure type")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Type d'infrastructure")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Infrastructure type")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Type d'infrastructure")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Infrastructure type
        /// 
        /// **Display (fr)** --- Type d'infrastructure
        /// 
        /// **Description (en)** --- Infrastructure type
        /// 
        /// **Description (fr)** --- Type d'infrastructure
        /// </returns>
        [CSSPEnumType]
        [CSSPDisplayEN(DisplayEN = "Infrastructure type")]
        [CSSPDisplayFR(DisplayFR = "Type d'infrastructure")]
        [CSSPDescriptionEN(DescriptionEN = @"Infrastructure type")]
        [CSSPDescriptionFR(DescriptionFR = @"Type d'infrastructure")]
        public InfrastructureTypeEnum InfrastructureType { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "See other TVItemID")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Voir autre TVItemID")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Link to the TVItems table representing the other infrastructure")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Lien à la table TVItems représentant l'autre infrastructure")]</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- See other TVItemID
        /// 
        /// **Display (fr)** --- Voir autre TVItemID
        /// 
        /// **Description (en)** --- Link to the TVItems table representing the other infrastructure
        /// 
        /// **Description (fr)** --- Lien à la table TVItems représentant l'autre infrastructure
        /// </returns>
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "See other TVItemID")]
        [CSSPDisplayFR(DisplayFR = "Voir autre TVItemID")]
        [CSSPDescriptionEN(DescriptionEN = @"Link to the TVItems table representing the other infrastructure")]
        [CSSPDescriptionFR(DescriptionFR = @"Lien à la table TVItems représentant l'autre infrastructure")]
        public int? SeeOtherTVItemID { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPEnumTypeText](CSSPModels.CSSPEnumTypeTextAttribute.html)(EnumTypeName = "InfrastructureTypeEnum", EnumType = "InfrastructureType")]</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Infrastructure type text")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Texte du type d'infrastructure")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Infrastructure type text")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Texte du type d'infrastructure")]</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Infrastructure type text
        /// 
        /// **Display (fr)** --- Texte du type d'infrastructure
        /// 
        /// **Description (en)** --- Infrastructure type text
        /// 
        /// **Description (fr)** --- Texte du type d'infrastructure
        /// </returns>
        [StringLength(100)]
        [CSSPEnumTypeText(EnumTypeName = "InfrastructureTypeEnum", EnumType = "InfrastructureType")]
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "Infrastructure type text")]
        [CSSPDisplayFR(DisplayFR = "Texte du type d'infrastructure")]
        [CSSPDescriptionEN(DescriptionEN = @"Infrastructure type text")]
        [CSSPDescriptionFR(DescriptionFR = @"Texte du type d'infrastructure")]
        public string InfrastructureTypeText { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "TV Item")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "TV Item")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Tree view item")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "L'item de l'arbre visuel")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- TV Item
        /// 
        /// **Display (fr)** --- TV Item
        /// 
        /// **Description (en)** --- Tree view item
        /// 
        /// **Description (fr)** --- L'item de l'arbre visuel
        /// </returns>
        [CSSPDisplayEN(DisplayEN = "TV Item")]
        [CSSPDisplayFR(DisplayFR = "TV Item")]
        [CSSPDescriptionEN(DescriptionEN = @"Tree view item")]
        [CSSPDescriptionFR(DescriptionFR = @"L'item de l'arbre visuel")]
        public TVItem TVItem { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "TV item link list")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "List de liens entre items de l'arbre visuel")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Tree view item link list")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "List de liens entre items de l'arbre visuel")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- TV item link list
        /// 
        /// **Display (fr)** --- List de liens entre items de l'arbre visuel
        /// 
        /// **Description (en)** --- Tree view item link list
        /// 
        /// **Description (fr)** --- List de liens entre items de l'arbre visuel
        /// </returns>
        [CSSPDisplayEN(DisplayEN = "TV item link list")]
        [CSSPDisplayFR(DisplayFR = "List de liens entre items de l'arbre visuel")]
        [CSSPDescriptionEN(DescriptionEN = @"Tree view item link list")]
        [CSSPDescriptionFR(DescriptionFR = @"List de liens entre items de l'arbre visuel")]
        public List<TVItemLink> TVItemLinkList { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Flow to")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Coule vers")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Infrastructure which flows to another infrastructure")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Infrastructure coulant vers un autre infrastructure")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Flow to
        /// 
        /// **Display (fr)** --- Coule vers
        /// 
        /// **Description (en)** --- Infrastructure which flows to another infrastructure
        /// 
        /// **Description (fr)** --- Infrastructure coulant vers un autre infrastructure
        /// </returns>
        [CSSPDisplayEN(DisplayEN = "Flow to")]
        [CSSPDisplayFR(DisplayFR = "Coule vers")]
        [CSSPDescriptionEN(DescriptionEN = @"Infrastructure which flows to another infrastructure")]
        [CSSPDescriptionFR(DescriptionFR = @"Infrastructure coulant vers un autre infrastructure")]
        public TVItemInfrastructureTypeTVItemLink FlowTo { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public TVItemInfrastructureTypeTVItemLink() : base()
        {
            TVItemLinkList = new List<TVItemLink>();
        }
        #endregion Constructors
    }
}
