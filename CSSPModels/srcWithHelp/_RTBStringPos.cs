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
    /// > <para>**Other properties** : [StartPos](CSSPModels.RTBStringPos.html#CSSPModels_RTBStringPos_StartPos), [EndPos](CSSPModels.RTBStringPos.html#CSSPModels_RTBStringPos_EndPos), [Text](CSSPModels.RTBStringPos.html#CSSPModels_RTBStringPos_Text), [TagText](CSSPModels.RTBStringPos.html#CSSPModels_RTBStringPos_TagText), [HasErrors](CSSPModels.RTBStringPos.html#CSSPModels_RTBStringPos_HasErrors), [ValidationResults](CSSPModels.RTBStringPos.html#CSSPModels_RTBStringPos_ValidationResults), </para>
    /// > 
    /// > <para>**Used by [CSSPServices](CSSPServices.html)** : [RTBStringPosService](CSSPServices.RTBStringPosService.html)</para>
    /// > <para>**Return to [CSSPModels](CSSPModels.html)**</para>
    /// </summary>
    [NotMapped]
    public partial class RTBStringPos : Error
    {
        #region Properties in DB
        #endregion Properties in DB

        #region Properties not in DB
        [Range(0, -1)]
        public int StartPos { get; set; }
        [Range(0, -1)]
        public int EndPos { get; set; }
        public string Text { get; set; }
        public string TagText { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public RTBStringPos() : base()
        {
        }
        #endregion Constructors
    }
}
