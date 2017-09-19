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
    /// > <para>**Other properties** : [Text](CSSPModels.FileItemList.html#CSSPModels_FileItemList_Text), [FileName](CSSPModels.FileItemList.html#CSSPModels_FileItemList_FileName), [HasErrors](CSSPModels.FileItemList.html#CSSPModels_FileItemList_HasErrors), [ValidationResults](CSSPModels.FileItemList.html#CSSPModels_FileItemList_ValidationResults), </para>
    /// > 
    /// > <para>**Used by [CSSPServices](CSSPServices.html)** : [FileItemListService](CSSPServices.FileItemListService.html)</para>
    /// > <para>**Return to [CSSPModels](CSSPModels.html)**</para>
    /// </summary>
    [NotMapped]
    public partial class FileItemList
    {
        #region Properties in DB
        #endregion Properties in DB

        #region Properties not in DB
        [StringLength(255, MinimumLength = 1)]
        public string Text { get; set; }
        [StringLength(255, MinimumLength = 1)]
        public string FileName { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>Will be set to true if an error occurs during CRUD (Creating, Reading, Updating or Deleting) of [FileItemList](CSSPModels.FileItemList)</para>
        /// </summary>
        public bool HasErrors { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>Will hold all errors which were detected prior or during CRUD (Creating, Reading, Updating or Deleting) of [FileItemList](CSSPModels.FileItemList)</para>
        /// </summary>
        public IEnumerable<ValidationResult> ValidationResults { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public FileItemList()
        {
            ValidationResults = new List<ValidationResult>();
        }
        #endregion Constructors
    }
}
