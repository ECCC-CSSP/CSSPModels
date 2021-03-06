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
    /// > <para>**Other properties** : [VPScenario](CSSPModels.VPFull.html#CSSPModels_VPFull_VPScenario), [VPAmbientList](CSSPModels.VPFull.html#CSSPModels_VPFull_VPAmbientList), [VPResultList](CSSPModels.VPFull.html#CSSPModels_VPFull_VPResultList), [CSSPError.HasErrors](CSSPModels.CSSPError.html#CSSPModels_CSSPError_HasErrors), [CSSPError.ValidationResults](CSSPModels.CSSPError.html#CSSPModels_CSSPError_ValidationResults)</para>
    /// > 
    /// > <para>**Inherits [CSSPError](CSSPModels.CSSPError.html)**</para>
    /// > <para>**Return to [CSSPModels](CSSPModels.html)**</para>
    /// </summary>
    [NotMapped]
    public partial class VPFull : CSSPError
    {
        #region Properties in DB
        #endregion Properties in DB

        #region Properties not in DB
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "VP scenario")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Scénario VP")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Visual plumes sceniaro")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Scénario visuel plumes")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- VP scenario
        /// 
        /// **Display (fr)** --- Scénario VP
        /// 
        /// **Description (en)** --- Visual plumes sceniaro
        /// 
        /// **Description (fr)** --- Scénario visuel plumes
        /// </returns>
        [CSSPDisplayEN(DisplayEN = "VP scenario")]
        [CSSPDisplayFR(DisplayFR = "Scénario VP")]
        [CSSPDescriptionEN(DescriptionEN = @"Visual plumes sceniaro")]
        [CSSPDescriptionFR(DescriptionFR = @"Scénario visuel plumes")]
        public VPScenario VPScenario { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "VP ambient list")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Liste visuel plumes ambiant")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Visual plumes ambient list")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Liste visuel plumes des paramètres ambiants")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- VP ambient list
        /// 
        /// **Display (fr)** --- Liste visuel plumes ambiant
        /// 
        /// **Description (en)** --- Visual plumes ambient list
        /// 
        /// **Description (fr)** --- Liste visuel plumes des paramètres ambiants
        /// </returns>
        [CSSPDisplayEN(DisplayEN = "VP ambient list")]
        [CSSPDisplayFR(DisplayFR = "Liste visuel plumes ambiant")]
        [CSSPDescriptionEN(DescriptionEN = @"Visual plumes ambient list")]
        [CSSPDescriptionFR(DescriptionFR = @"Liste visuel plumes des paramètres ambiants")]
        public List<VPAmbient> VPAmbientList { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "VP result list")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Liste des résultats VP")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Visual plumes result list")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Liste des résultats visual plumes")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- VP result list
        /// 
        /// **Display (fr)** --- Liste des résultats VP
        /// 
        /// **Description (en)** --- Visual plumes result list
        /// 
        /// **Description (fr)** --- Liste des résultats visual plumes
        /// </returns>
        [CSSPDisplayEN(DisplayEN = "VP result list")]
        [CSSPDisplayFR(DisplayFR = "Liste des résultats VP")]
        [CSSPDescriptionEN(DescriptionEN = @"Visual plumes result list")]
        [CSSPDescriptionFR(DescriptionFR = @"Liste des résultats visual plumes")]
        public List<VPResult> VPResultList { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public VPFull() : base()
        {
            VPAmbientList = new List<VPAmbient>();
            VPResultList = new List<VPResult>();
        }
        #endregion Constructors
    }
}
