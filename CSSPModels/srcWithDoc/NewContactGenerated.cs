/*
 * Auto generated from the CSSPCodeWriter.proj by clicking on the [\srcWithDoc\[ModelClassName]Generated.cs] button
 *
 * Do not edit this file.
 *
 * Last generated by leblancc on WMON01DTCHLEBL2 machine
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
    /// > <para>**Other properties** : [LoginEmail](CSSPModels.NewContact.html#CSSPModels_NewContact_LoginEmail), [FirstName](CSSPModels.NewContact.html#CSSPModels_NewContact_FirstName), [LastName](CSSPModels.NewContact.html#CSSPModels_NewContact_LastName), [Initial](CSSPModels.NewContact.html#CSSPModels_NewContact_Initial), [ContactTitle](CSSPModels.NewContact.html#CSSPModels_NewContact_ContactTitle), [ContactTitleText](CSSPModels.NewContact.html#CSSPModels_NewContact_ContactTitleText), [HasErrors](CSSPModels.NewContact.html#CSSPModels_NewContact_HasErrors), [ValidationResults](CSSPModels.NewContact.html#CSSPModels_NewContact_ValidationResults), </para>
    /// > 
    /// > <para>**Used by [CSSPServices](CSSPServices.html)** : [NewContactService](CSSPServices.NewContactService.html)</para>
    /// > <para>**Requires [CSSPEnums](CSSPEnums.html)** : [ContactTitleEnum](CSSPEnums.ContactTitleEnum.html)</para>
    /// > <para>**Return to [CSSPModels](CSSPModels.html)**</para>
    /// </summary>
    [NotMapped]
    public partial class NewContact : Error
    {
        #region Properties in DB
        #endregion Properties in DB

        #region Properties not in DB
        [StringLength(200, MinimumLength = 1)]
        public string LoginEmail { get; set; }
        [StringLength(200, MinimumLength = 1)]
        public string FirstName { get; set; }
        [StringLength(200, MinimumLength = 1)]
        public string LastName { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        [StringLength(50)]
        [CSSPAllowNull]
        public string Initial { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPEnumType](CSSPModels.CSSPEnumTypeAttribute.html)]</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        [CSSPEnumType]
        [CSSPAllowNull]
        public ContactTitleEnum? ContactTitle { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPEnumTypeText](CSSPModels.CSSPEnumTypeTextAttribute.html)(EnumTypeName = "ContactTitleEnum", EnumType = "ContactTitle")]</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        [StringLength(100)]
        [CSSPEnumTypeText(EnumTypeName = "ContactTitleEnum", EnumType = "ContactTitle")]
        [CSSPAllowNull]
        public string ContactTitleText { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public NewContact() : base()
        {
        }
        #endregion Constructors
    }
}
