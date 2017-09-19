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
    /// > <para>**Other properties** : [Name](CSSPModels.FileItem.html#CSSPModels_FileItem_Name), [TVItemID](CSSPModels.FileItem.html#CSSPModels_FileItem_TVItemID), [HasErrors](CSSPModels.FileItem.html#CSSPModels_FileItem_HasErrors), [ValidationResults](CSSPModels.FileItem.html#CSSPModels_FileItem_ValidationResults), </para>
    /// > 
    /// > <para>**Used by [CSSPServices](CSSPServices.html)** : [FileItemService](CSSPServices.FileItemService.html)</para>
    /// > <para>**Return to [CSSPModels](CSSPModels.html)**</para>
    /// </summary>
    [NotMapped]
    public partial class FileItem
    {
        #region Properties in DB
        #endregion Properties in DB

        #region Properties not in DB
        [StringLength(255, MinimumLength = 0)]
        public string Name { get; set; }
        [Range(1, -1)]
        public int TVItemID { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>Will be set to true if an error occurs during CRUD (Creating, Reading, Updating or Deleting) of [FileItem](CSSPModels.FileItem)</para>
        /// </summary>
        public bool HasErrors { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>Will hold all errors which were detected prior or during CRUD (Creating, Reading, Updating or Deleting) of [FileItem](CSSPModels.FileItem)</para>
        /// </summary>
        public IEnumerable<ValidationResult> ValidationResults { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public FileItem()
        {
            ValidationResults = new List<ValidationResult>();
        }
        #endregion Constructors
    }
}
