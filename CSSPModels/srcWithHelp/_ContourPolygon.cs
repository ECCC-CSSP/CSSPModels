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
    /// > <para>**Other properties** : [ContourValue](CSSPModels.ContourPolygon.html#CSSPModels_ContourPolygon_ContourValue), [Layer](CSSPModels.ContourPolygon.html#CSSPModels_ContourPolygon_Layer), [Depth](CSSPModels.ContourPolygon.html#CSSPModels_ContourPolygon_Depth), [ContourNodeList](CSSPModels.ContourPolygon.html#CSSPModels_ContourPolygon_ContourNodeList), [HasErrors](CSSPModels.ContourPolygon.html#CSSPModels_ContourPolygon_HasErrors), [ValidationResults](CSSPModels.ContourPolygon.html#CSSPModels_ContourPolygon_ValidationResults), </para>
    /// > 
    /// > <para>**Used by [CSSPServices](CSSPServices.html)** : [ContourPolygonService](CSSPServices.ContourPolygonService.html)</para>
    /// > <para>**Return to [CSSPModels](CSSPModels.html)**</para>
    /// </summary>
    [NotMapped]
    public partial class ContourPolygon
    {
        #region Properties in DB
        #endregion Properties in DB

        #region Properties not in DB
        [Range(0.0D, -1.0D)]
        public double ContourValue { get; set; }
        [Range(1, 100)]
        public int Layer { get; set; }
        [Range(1.0D, 10000.0D)]
        public double Depth { get; set; }
        public virtual List<Node> ContourNodeList { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>Will be set to true if an error occurs during CRUD (Creating, Reading, Updating or Deleting) of [ContourPolygon](CSSPModels.ContourPolygon)</para>
        /// </summary>
        public bool HasErrors { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>Will hold all errors which were detected prior or during CRUD (Creating, Reading, Updating or Deleting) of [ContourPolygon](CSSPModels.ContourPolygon)</para>
        /// </summary>
        public IEnumerable<ValidationResult> ValidationResults { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public ContourPolygon()
        {
            ContourNodeList = new List<Node>();
            ValidationResults = new List<ValidationResult>();
        }
        #endregion Constructors
    }
}
