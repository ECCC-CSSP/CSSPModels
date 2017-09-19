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
    /// > <para>**Other properties** : [VPScenarioID](CSSPModels.VPScenarioIDAndRawResults.html#CSSPModels_VPScenarioIDAndRawResults_VPScenarioID), [RawResults](CSSPModels.VPScenarioIDAndRawResults.html#CSSPModels_VPScenarioIDAndRawResults_RawResults), [HasErrors](CSSPModels.VPScenarioIDAndRawResults.html#CSSPModels_VPScenarioIDAndRawResults_HasErrors), [ValidationResults](CSSPModels.VPScenarioIDAndRawResults.html#CSSPModels_VPScenarioIDAndRawResults_ValidationResults), </para>
    /// > 
    /// > <para>**Used by [CSSPServices](CSSPServices.html)** : [VPScenarioIDAndRawResultsService](CSSPServices.VPScenarioIDAndRawResultsService.html)</para>
    /// > <para>**Return to [CSSPModels](CSSPModels.html)**</para>
    /// </summary>
    [NotMapped]
    public partial class VPScenarioIDAndRawResults
    {
        #region Properties in DB
        #endregion Properties in DB

        #region Properties not in DB
        [Range(1, -1)]
        public int VPScenarioID { get; set; }
        public string RawResults { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>Will be set to true if an error occurs during CRUD (Creating, Reading, Updating or Deleting) of [VPScenarioIDAndRawResults](CSSPModels.VPScenarioIDAndRawResults)</para>
        /// </summary>
        public bool HasErrors { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>Will hold all errors which were detected prior or during CRUD (Creating, Reading, Updating or Deleting) of [VPScenarioIDAndRawResults](CSSPModels.VPScenarioIDAndRawResults)</para>
        /// </summary>
        public IEnumerable<ValidationResult> ValidationResults { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public VPScenarioIDAndRawResults()
        {
            ValidationResults = new List<ValidationResult>();
        }
        #endregion Constructors
    }
}
