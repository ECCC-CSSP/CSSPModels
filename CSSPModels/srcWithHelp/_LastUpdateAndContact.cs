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
    /// > <para>**Other properties** : [Error](CSSPModels.LastUpdateAndContact.html#CSSPModels_LastUpdateAndContact_Error), [LastUpdateDate_UTC](CSSPModels.LastUpdateAndContact.html#CSSPModels_LastUpdateAndContact_LastUpdateDate_UTC), [LastUpdateContactTVItemID](CSSPModels.LastUpdateAndContact.html#CSSPModels_LastUpdateAndContact_LastUpdateContactTVItemID), [HasErrors](CSSPModels.LastUpdateAndContact.html#CSSPModels_LastUpdateAndContact_HasErrors), [ValidationResults](CSSPModels.LastUpdateAndContact.html#CSSPModels_LastUpdateAndContact_ValidationResults), </para>
    /// > 
    /// > <para>**Used by [CSSPServices](CSSPServices.html)** : [LastUpdateAndContactService](CSSPServices.LastUpdateAndContactService.html)</para>
    /// > <para>**Return to [CSSPModels](CSSPModels.html)**</para>
    /// </summary>
    [NotMapped]
    public partial class LastUpdateAndContact
    {
        #region Properties in DB
        #endregion Properties in DB

        #region Properties not in DB
        public string Error { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPAfter](CSSPModels.CSSPAfterAttribute.html)(Year = 1980)]</para>
        /// </summary>
        [CSSPAfter(Year = 1980)]
        public DateTime LastUpdateDate_UTC { get; set; }
        [Range(1, -1)]
        public int LastUpdateContactTVItemID { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>Will be set to true if an error occurs during CRUD (Creating, Reading, Updating or Deleting) of [LastUpdateAndContact](CSSPModels.LastUpdateAndContact)</para>
        /// </summary>
        public bool HasErrors { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>Will hold all errors which were detected prior or during CRUD (Creating, Reading, Updating or Deleting) of [LastUpdateAndContact](CSSPModels.LastUpdateAndContact)</para>
        /// </summary>
        public IEnumerable<ValidationResult> ValidationResults { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public LastUpdateAndContact()
        {
            ValidationResults = new List<ValidationResult>();
        }
        #endregion Constructors
    }
}
