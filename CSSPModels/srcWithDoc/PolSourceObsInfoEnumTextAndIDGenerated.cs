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
    /// > <para>**No DB properties** :</para>
    /// > <para>**Other properties** : [Text](CSSPModels.PolSourceObsInfoEnumTextAndID.html#CSSPModels_PolSourceObsInfoEnumTextAndID_Text), [ID](CSSPModels.PolSourceObsInfoEnumTextAndID.html#CSSPModels_PolSourceObsInfoEnumTextAndID_ID), [HasErrors](CSSPModels.PolSourceObsInfoEnumTextAndID.html#CSSPModels_PolSourceObsInfoEnumTextAndID_HasErrors), [ValidationResults](CSSPModels.PolSourceObsInfoEnumTextAndID.html#CSSPModels_PolSourceObsInfoEnumTextAndID_ValidationResults), </para>
    /// > 
    /// > <para>**Used by [CSSPServices](CSSPServices.html)** : [PolSourceObsInfoEnumTextAndIDService](CSSPServices.PolSourceObsInfoEnumTextAndIDService.html)</para>
    /// > <para>**Return to [CSSPModels](CSSPModels.html)**</para>
    /// </summary>
    [NotMapped]
    public partial class PolSourceObsInfoEnumTextAndID : Error
    {
        #region Properties in DB
        #endregion Properties in DB

        #region Properties not in DB
        public string Text { get; set; }
        [Range(1, -1)]
        public int ID { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public PolSourceObsInfoEnumTextAndID() : base()
        {
        }
        #endregion Constructors
    }
}
