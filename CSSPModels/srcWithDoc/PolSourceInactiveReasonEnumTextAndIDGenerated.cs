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
    /// > <para>**Other properties** : [Text](CSSPModels.PolSourceInactiveReasonEnumTextAndID.html#CSSPModels_PolSourceInactiveReasonEnumTextAndID_Text), [ID](CSSPModels.PolSourceInactiveReasonEnumTextAndID.html#CSSPModels_PolSourceInactiveReasonEnumTextAndID_ID), [HasErrors](CSSPModels.PolSourceInactiveReasonEnumTextAndID.html#CSSPModels_PolSourceInactiveReasonEnumTextAndID_HasErrors), [ValidationResults](CSSPModels.PolSourceInactiveReasonEnumTextAndID.html#CSSPModels_PolSourceInactiveReasonEnumTextAndID_ValidationResults), </para>
    /// > 
    /// > <para>**Used by [CSSPServices](CSSPServices.html)** : [PolSourceInactiveReasonEnumTextAndIDService](CSSPServices.PolSourceInactiveReasonEnumTextAndIDService.html)</para>
    /// > <para>**Return to [CSSPModels](CSSPModels.html)**</para>
    /// </summary>
    [NotMapped]
    public partial class PolSourceInactiveReasonEnumTextAndID : CSSPError
    {
        #region Properties in DB
        #endregion Properties in DB

        #region Properties not in DB
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Text")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Texte")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Text")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Texte")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Text
        /// 
        /// **Display (fr)** --- Texte
        /// 
        /// **Description (en)** --- Text
        /// 
        /// **Description (fr)** --- Texte
        /// </returns>
        [CSSPDisplayEN(DisplayEN = "Text")]
        [CSSPDisplayFR(DisplayFR = "Texte")]
        [CSSPDescriptionEN(DescriptionEN = @"Text")]
        [CSSPDescriptionFR(DescriptionFR = @"Texte")]
        public string Text { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "ID")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "ID")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "ID")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Identifiant")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- ID
        /// 
        /// **Display (fr)** --- ID
        /// 
        /// **Description (en)** --- ID
        /// 
        /// **Description (fr)** --- Identifiant
        /// </returns>
        [Range(1, -1)]
        [CSSPDisplayEN(DisplayEN = "ID")]
        [CSSPDisplayFR(DisplayFR = "ID")]
        [CSSPDescriptionEN(DescriptionEN = @"ID")]
        [CSSPDescriptionFR(DescriptionFR = @"Identifiant")]
        public int ID { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public PolSourceInactiveReasonEnumTextAndID() : base()
        {
        }
        #endregion Constructors
    }
}
