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
    /// > <para>**Other properties** : [PropertyName](CSSPModels.WhereInfo.html#CSSPModels_WhereInfo_PropertyName), [PropertyType](CSSPModels.WhereInfo.html#CSSPModels_WhereInfo_PropertyType), [WhereOperator](CSSPModels.WhereInfo.html#CSSPModels_WhereInfo_WhereOperator), [Value](CSSPModels.WhereInfo.html#CSSPModels_WhereInfo_Value), [ValueInt](CSSPModels.WhereInfo.html#CSSPModels_WhereInfo_ValueInt), [ValueDouble](CSSPModels.WhereInfo.html#CSSPModels_WhereInfo_ValueDouble), [ValueBool](CSSPModels.WhereInfo.html#CSSPModels_WhereInfo_ValueBool), [ValueDateTime](CSSPModels.WhereInfo.html#CSSPModels_WhereInfo_ValueDateTime), [ValueEnumText](CSSPModels.WhereInfo.html#CSSPModels_WhereInfo_ValueEnumText), [HasErrors](CSSPModels.WhereInfo.html#CSSPModels_WhereInfo_HasErrors), [ValidationResults](CSSPModels.WhereInfo.html#CSSPModels_WhereInfo_ValidationResults), </para>
    /// > 
    /// > <para>**Used by [CSSPServices](CSSPServices.html)** : [WhereInfoService](CSSPServices.WhereInfoService.html)</para>
    /// > <para>**Requires [CSSPEnums](CSSPEnums.html)** : [PropertyTypeEnum](CSSPEnums.PropertyTypeEnum.html), [WhereOperatorEnum](CSSPEnums.WhereOperatorEnum.html)</para>
    /// > <para>**Return to [CSSPModels](CSSPModels.html)**</para>
    /// </summary>
    [NotMapped]
    public partial class WhereInfo : Error
    {
        #region Properties in DB
        #endregion Properties in DB

        #region Properties not in DB
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Property name")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Nom de la propriété")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Property name")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Nom de la propriété")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Property name
        /// 
        /// **Display (fr)** --- Nom de la propriété
        /// 
        /// **Description (en)** --- Property name
        /// 
        /// **Description (fr)** --- Nom de la propriété
        /// </returns>
        [StringLength(100)]
        [CSSPDisplayEN(DisplayEN = "Property name")]
        [CSSPDisplayFR(DisplayFR = "Nom de la propriété")]
        [CSSPDescriptionEN(DescriptionEN = @"Property name")]
        [CSSPDescriptionFR(DescriptionFR = @"Nom de la propriété")]
        public string PropertyName { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPEnumType](CSSPModels.CSSPEnumTypeAttribute.html)]</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Property type")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Type de propriété")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Property type")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Type de propriété")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Property type
        /// 
        /// **Display (fr)** --- Type de propriété
        /// 
        /// **Description (en)** --- Property type
        /// 
        /// **Description (fr)** --- Type de propriété
        /// </returns>
        [CSSPEnumType]
        [CSSPDisplayEN(DisplayEN = "Property type")]
        [CSSPDisplayFR(DisplayFR = "Type de propriété")]
        [CSSPDescriptionEN(DescriptionEN = @"Property type")]
        [CSSPDescriptionFR(DescriptionFR = @"Type de propriété")]
        public PropertyTypeEnum PropertyType { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPEnumType](CSSPModels.CSSPEnumTypeAttribute.html)]</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Where operator (Ex: Equal, LessThan, GreaterThan, Contains, StartsWith, EndsWith)")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Opérateur de filtre (Ex: Equal, LessThan, GreaterThan, Contains, StartsWith, EndsWith)")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Where operator (Ex: Equal, LessThan, GreaterThan, Contains, StartsWith, EndsWith)")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Opérateur de filtre (Ex: Equal, LessThan, GreaterThan, Contains, StartsWith, EndsWith)")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Where operator (Ex: Equal, LessThan, GreaterThan, Contains, StartsWith, EndsWith)
        /// 
        /// **Display (fr)** --- Opérateur de filtre (Ex: Equal, LessThan, GreaterThan, Contains, StartsWith, EndsWith)
        /// 
        /// **Description (en)** --- Where operator (Ex: Equal, LessThan, GreaterThan, Contains, StartsWith, EndsWith)
        /// 
        /// **Description (fr)** --- Opérateur de filtre (Ex: Equal, LessThan, GreaterThan, Contains, StartsWith, EndsWith)
        /// </returns>
        [CSSPEnumType]
        [CSSPDisplayEN(DisplayEN = "Where operator (Ex: Equal, LessThan, GreaterThan, Contains, StartsWith, EndsWith)")]
        [CSSPDisplayFR(DisplayFR = "Opérateur de filtre (Ex: Equal, LessThan, GreaterThan, Contains, StartsWith, EndsWith)")]
        [CSSPDescriptionEN(DescriptionEN = @"Where operator (Ex: Equal, LessThan, GreaterThan, Contains, StartsWith, EndsWith)")]
        [CSSPDescriptionFR(DescriptionFR = @"Opérateur de filtre (Ex: Equal, LessThan, GreaterThan, Contains, StartsWith, EndsWith)")]
        public WhereOperatorEnum WhereOperator { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Value")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Valeur")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Value")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Valeur")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Value
        /// 
        /// **Display (fr)** --- Valeur
        /// 
        /// **Description (en)** --- Value
        /// 
        /// **Description (fr)** --- Valeur
        /// </returns>
        [StringLength(100)]
        [CSSPDisplayEN(DisplayEN = "Value")]
        [CSSPDisplayFR(DisplayFR = "Valeur")]
        [CSSPDescriptionEN(DescriptionEN = @"Value")]
        [CSSPDescriptionFR(DescriptionFR = @"Valeur")]
        public string Value { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Value (int)")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Valeur (int)")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Value (int)")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Valeur (int)")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Value (int)
        /// 
        /// **Display (fr)** --- Valeur (int)
        /// 
        /// **Description (en)** --- Value (int)
        /// 
        /// **Description (fr)** --- Valeur (int)
        /// </returns>
        [Range(-1, -1)]
        [CSSPDisplayEN(DisplayEN = "Value (int)")]
        [CSSPDisplayFR(DisplayFR = "Valeur (int)")]
        [CSSPDescriptionEN(DescriptionEN = @"Value (int)")]
        [CSSPDescriptionFR(DescriptionFR = @"Valeur (int)")]
        public int ValueInt { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Value (double)")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Valeur (double)")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Value (double)")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Valeur (double)")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Value (double)
        /// 
        /// **Display (fr)** --- Valeur (double)
        /// 
        /// **Description (en)** --- Value (double)
        /// 
        /// **Description (fr)** --- Valeur (double)
        /// </returns>
        [Range(-1.0D, -1.0D)]
        [CSSPDisplayEN(DisplayEN = "Value (double)")]
        [CSSPDisplayFR(DisplayFR = "Valeur (double)")]
        [CSSPDescriptionEN(DescriptionEN = @"Value (double)")]
        [CSSPDescriptionFR(DescriptionFR = @"Valeur (double)")]
        public double ValueDouble { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Value (bool)")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Valeur (bool)")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Value (bool)")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Valeur (bool)")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Value (bool)
        /// 
        /// **Display (fr)** --- Valeur (bool)
        /// 
        /// **Description (en)** --- Value (bool)
        /// 
        /// **Description (fr)** --- Valeur (bool)
        /// </returns>
        [CSSPDisplayEN(DisplayEN = "Value (bool)")]
        [CSSPDisplayFR(DisplayFR = "Valeur (bool)")]
        [CSSPDescriptionEN(DescriptionEN = @"Value (bool)")]
        [CSSPDescriptionFR(DescriptionFR = @"Valeur (bool)")]
        public bool ValueBool { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPAfter](CSSPModels.CSSPAfterAttribute.html)(Year = 1900)]</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Value (DateTime)")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Valeur (DateTime)")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Value (DateTime)")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Valeur (DateTime)")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Value (DateTime)
        /// 
        /// **Display (fr)** --- Valeur (DateTime)
        /// 
        /// **Description (en)** --- Value (DateTime)
        /// 
        /// **Description (fr)** --- Valeur (DateTime)
        /// </returns>
        [CSSPAfter(Year = 1900)]
        [CSSPDisplayEN(DisplayEN = "Value (DateTime)")]
        [CSSPDisplayFR(DisplayFR = "Valeur (DateTime)")]
        [CSSPDescriptionEN(DescriptionEN = @"Value (DateTime)")]
        [CSSPDescriptionFR(DescriptionFR = @"Valeur (DateTime)")]
        public DateTime ValueDateTime { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Value (Enum)")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Valeur (Enum)")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Value (Enum)")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Valeur (Enum)")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Value (Enum)
        /// 
        /// **Display (fr)** --- Valeur (Enum)
        /// 
        /// **Description (en)** --- Value (Enum)
        /// 
        /// **Description (fr)** --- Valeur (Enum)
        /// </returns>
        [StringLength(100)]
        [CSSPDisplayEN(DisplayEN = "Value (Enum)")]
        [CSSPDisplayFR(DisplayFR = "Valeur (Enum)")]
        [CSSPDescriptionEN(DescriptionEN = @"Value (Enum)")]
        [CSSPDescriptionFR(DescriptionFR = @"Valeur (Enum)")]
        public string ValueEnumText { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public WhereInfo() : base()
        {
        }
        #endregion Constructors
    }
}
