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
using System.Linq;

namespace CSSPModels
{
    /// <summary>
    /// > [!NOTE]
    /// > 
    /// > <para>**No DB properties** :</para>
    /// > <para>**Other properties** : [TVItemUserAuthID](CSSPModels.TVItemTVAuth.html#CSSPModels_TVItemTVAuth_TVItemUserAuthID), [TVText](CSSPModels.TVItemTVAuth.html#CSSPModels_TVItemTVAuth_TVText), [TVItemID1](CSSPModels.TVItemTVAuth.html#CSSPModels_TVItemTVAuth_TVItemID1), [TVTypeStr](CSSPModels.TVItemTVAuth.html#CSSPModels_TVItemTVAuth_TVTypeStr), [TVAuth](CSSPModels.TVItemTVAuth.html#CSSPModels_TVItemTVAuth_TVAuth), [TVAuthText](CSSPModels.TVItemTVAuth.html#CSSPModels_TVItemTVAuth_TVAuthText), [HasErrors](CSSPModels.TVItemTVAuth.html#CSSPModels_TVItemTVAuth_HasErrors), [ValidationResults](CSSPModels.TVItemTVAuth.html#CSSPModels_TVItemTVAuth_ValidationResults), </para>
    /// > 
    /// > <para>**Used by [CSSPServices](CSSPServices.html)** : [TVItemTVAuthService](CSSPServices.TVItemTVAuthService.html)</para>
    /// > <para>**Requires [CSSPEnums](CSSPEnums.html)** : [TVAuthEnum](CSSPEnums.TVAuthEnum.html)</para>
    /// > <para>**Return to [CSSPModels](CSSPModels.html)**</para>
    /// </summary>
    [NotMapped]
    public partial class TVItemTVAuth : Error
    {
        #region Properties in DB
        #endregion Properties in DB

        #region Properties not in DB
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "User authorization TV item")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "L'item de l'arbre visuel avec l'authorisation de l'utilisateur")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "User authorization TV item")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "L'item de l'arbre visuel avec l'authorisation de l'utilisateur")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- User authorization TV item
        /// 
        /// **Display (fr)** --- L'item de l'arbre visuel avec l'authorisation de l'utilisateur
        /// 
        /// **Description (en)** --- User authorization TV item
        /// 
        /// **Description (fr)** --- L'item de l'arbre visuel avec l'authorisation de l'utilisateur
        /// </returns>
        [Range(1, -1)]
        [CSSPDisplayEN(DisplayEN = "User authorization TV item")]
        [CSSPDisplayFR(DisplayFR = "L'item de l'arbre visuel avec l'authorisation de l'utilisateur")]
        [CSSPDescriptionEN(DescriptionEN = @"User authorization TV item")]
        [CSSPDescriptionFR(DescriptionFR = @"L'item de l'arbre visuel avec l'authorisation de l'utilisateur")]
        public int TVItemUserAuthID { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "TV text")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Text de l'arbre visuel")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Tree view text")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Text de l'arbre visuel")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- TV text
        /// 
        /// **Display (fr)** --- Text de l'arbre visuel
        /// 
        /// **Description (en)** --- Tree view text
        /// 
        /// **Description (fr)** --- Text de l'arbre visuel
        /// </returns>
        [StringLength(255, MinimumLength = 1)]
        [CSSPDisplayEN(DisplayEN = "TV text")]
        [CSSPDisplayFR(DisplayFR = "Text de l'arbre visuel")]
        [CSSPDescriptionEN(DescriptionEN = @"Tree view text")]
        [CSSPDescriptionFR(DescriptionFR = @"Text de l'arbre visuel")]
        public string TVText { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "TV item 1")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Item 1 de l'arbre visuel")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Tree view item 1")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Item 1 de l'arbre visuel")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- TV item 1
        /// 
        /// **Display (fr)** --- Item 1 de l'arbre visuel
        /// 
        /// **Description (en)** --- Tree view item 1
        /// 
        /// **Description (fr)** --- Item 1 de l'arbre visuel
        /// </returns>
        [Range(1, -1)]
        [CSSPDisplayEN(DisplayEN = "TV item 1")]
        [CSSPDisplayFR(DisplayFR = "Item 1 de l'arbre visuel")]
        [CSSPDescriptionEN(DescriptionEN = @"Tree view item 1")]
        [CSSPDescriptionFR(DescriptionFR = @"Item 1 de l'arbre visuel")]
        public int TVItemID1 { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "TV type text")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Texte du type d'arbre visuel")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Tree view type text")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Texte du type d'arbre visuel")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- TV type text
        /// 
        /// **Display (fr)** --- Texte du type d'arbre visuel
        /// 
        /// **Description (en)** --- Tree view type text
        /// 
        /// **Description (fr)** --- Texte du type d'arbre visuel
        /// </returns>
        [StringLength(255, MinimumLength = 1)]
        [CSSPDisplayEN(DisplayEN = "TV type text")]
        [CSSPDisplayFR(DisplayFR = "Texte du type d'arbre visuel")]
        [CSSPDescriptionEN(DescriptionEN = @"Tree view type text")]
        [CSSPDescriptionFR(DescriptionFR = @"Texte du type d'arbre visuel")]
        public string TVTypeStr { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPEnumType](CSSPModels.CSSPEnumTypeAttribute.html)]</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "TV auth")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Auth de l'arbre visuel")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Tree view authorization")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Authorisation de l'arbre visuel")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- TV auth
        /// 
        /// **Display (fr)** --- Auth de l'arbre visuel
        /// 
        /// **Description (en)** --- Tree view authorization
        /// 
        /// **Description (fr)** --- Authorisation de l'arbre visuel
        /// </returns>
        [CSSPEnumType]
        [CSSPDisplayEN(DisplayEN = "TV auth")]
        [CSSPDisplayFR(DisplayFR = "Auth de l'arbre visuel")]
        [CSSPDescriptionEN(DescriptionEN = @"Tree view authorization")]
        [CSSPDescriptionFR(DescriptionFR = @"Authorisation de l'arbre visuel")]
        public TVAuthEnum TVAuth { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPEnumTypeText](CSSPModels.CSSPEnumTypeTextAttribute.html)(EnumTypeName = "TVAuthEnum", EnumType = "TVAuth")]</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "TV auth text")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Texte de l'authorisation de l'arbre visuel")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Tree view auth text")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Texte de l'authorisation de l'arbre visuel")]</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- TV auth text
        /// 
        /// **Display (fr)** --- Texte de l'authorisation de l'arbre visuel
        /// 
        /// **Description (en)** --- Tree view auth text
        /// 
        /// **Description (fr)** --- Texte de l'authorisation de l'arbre visuel
        /// </returns>
        [StringLength(100)]
        [CSSPEnumTypeText(EnumTypeName = "TVAuthEnum", EnumType = "TVAuth")]
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "TV auth text")]
        [CSSPDisplayFR(DisplayFR = "Texte de l'authorisation de l'arbre visuel")]
        [CSSPDescriptionEN(DescriptionEN = @"Tree view auth text")]
        [CSSPDescriptionFR(DescriptionFR = @"Texte de l'authorisation de l'arbre visuel")]
        public string TVAuthText { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public TVItemTVAuth() : base()
        {
        }
        #endregion Constructors
    }
}
