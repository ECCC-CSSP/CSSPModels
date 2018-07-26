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
    /// > <para>**Other properties** : [LoginEmail](CSSPModels.Register.html#CSSPModels_Register_LoginEmail), [FirstName](CSSPModels.Register.html#CSSPModels_Register_FirstName), [Initial](CSSPModels.Register.html#CSSPModels_Register_Initial), [LastName](CSSPModels.Register.html#CSSPModels_Register_LastName), [WebName](CSSPModels.Register.html#CSSPModels_Register_WebName), [Password](CSSPModels.Register.html#CSSPModels_Register_Password), [ConfirmPassword](CSSPModels.Register.html#CSSPModels_Register_ConfirmPassword), [HasErrors](CSSPModels.Register.html#CSSPModels_Register_HasErrors), [ValidationResults](CSSPModels.Register.html#CSSPModels_Register_ValidationResults), </para>
    /// > 
    /// > <para>**Used by [CSSPServices](CSSPServices.html)** : [RegisterService](CSSPServices.RegisterService.html)</para>
    /// > <para>**Return to [CSSPModels](CSSPModels.html)**</para>
    /// </summary>
    [NotMapped]
    public partial class Register : Error
    {
        #region Properties in DB
        #endregion Properties in DB

        #region Properties not in DB
        [StringLength(255, MinimumLength = 6)]
        public string LoginEmail { get; set; }
        [StringLength(100, MinimumLength = 1)]
        public string FirstName { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        [StringLength(50)]
        [CSSPAllowNull]
        public string Initial { get; set; }
        [StringLength(100, MinimumLength = 1)]
        public string LastName { get; set; }
        [StringLength(100, MinimumLength = 1)]
        public string WebName { get; set; }
        [StringLength(100, MinimumLength = 6)]
        public string Password { get; set; }
        [StringLength(100, MinimumLength = 6)]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public Register() : base()
        {
        }
        #endregion Constructors
    }
}
