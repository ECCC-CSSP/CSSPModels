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

namespace CSSPModels
{
    /// <summary>
    /// > [!NOTE]
    /// > 
    /// > <para>**No DB properties** :</para>
    /// > <para>**Other properties** : [Name](CSSPModels.AppTaskParameter.html#CSSPModels_AppTaskParameter_Name), [Value](CSSPModels.AppTaskParameter.html#CSSPModels_AppTaskParameter_Value), [HasErrors](CSSPModels.AppTaskParameter.html#CSSPModels_AppTaskParameter_HasErrors), [ValidationResults](CSSPModels.AppTaskParameter.html#CSSPModels_AppTaskParameter_ValidationResults), </para>
    /// > 
    /// > <para>**Used by [CSSPServices](CSSPServices.html)** : [AppTaskParameterService](CSSPServices.AppTaskParameterService.html)</para>
    /// > <para>**Return to [CSSPModels](CSSPModels.html)**</para>
    /// </summary>
    [NotMapped]
    public partial class AppTaskParameter : Error
    {
        #region Properties in DB
        #endregion Properties in DB

        #region Properties not in DB
        [StringLength(255)]
        public string Name { get; set; }
        [StringLength(255)]
        public string Value { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public AppTaskParameter() : base()
        {
        }
        #endregion Constructors
    }
}
