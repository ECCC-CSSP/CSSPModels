/*
 * Auto generated from the CSSPModelsGenerateCode.proj by clicking on the [Generate Models With Help] button
 *
 * Do not edit this file.
 *
 * Last generated by Charles LeBlanc
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
    /// > <para>**Other properties** : [VPScenario](CSSPModels.VPFull.html#CSSPModels_VPFull_VPScenario), [VPAmbientList](CSSPModels.VPFull.html#CSSPModels_VPFull_VPAmbientList), [VPResultList](CSSPModels.VPFull.html#CSSPModels_VPFull_VPResultList), [HasErrors](CSSPModels.VPFull.html#CSSPModels_VPFull_HasErrors), [ValidationResults](CSSPModels.VPFull.html#CSSPModels_VPFull_ValidationResults), </para>
    /// > 
    /// > <para>**Used by [CSSPServices](CSSPServices.html)** : [VPFullService](CSSPServices.VPFullService.html)</para>
    /// > <para>**Return to [CSSPModels](CSSPModels.html)**</para>
    /// </summary>
    [NotMapped]
    public partial class VPFull : Error
    {
        #region Properties in DB
        #endregion Properties in DB

        #region Properties not in DB
        public virtual VPScenario VPScenario { get; set; }
        public virtual List<VPAmbient> VPAmbientList { get; set; }
        public virtual List<VPResult> VPResultList { get; set; }
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
