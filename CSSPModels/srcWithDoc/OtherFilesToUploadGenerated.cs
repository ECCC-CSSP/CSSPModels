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

namespace CSSPModels
{
    /// <summary>
    /// > [!NOTE]
    /// > 
    /// > <para>**No DB properties** :</para>
    /// > <para>**Other properties** : [Error](CSSPModels.OtherFilesToUpload.html#CSSPModels_OtherFilesToUpload_Error), [MikeScenarioID](CSSPModels.OtherFilesToUpload.html#CSSPModels_OtherFilesToUpload_MikeScenarioID), [TVFileList](CSSPModels.OtherFilesToUpload.html#CSSPModels_OtherFilesToUpload_TVFileList), [HasErrors](CSSPModels.OtherFilesToUpload.html#CSSPModels_OtherFilesToUpload_HasErrors), [ValidationResults](CSSPModels.OtherFilesToUpload.html#CSSPModels_OtherFilesToUpload_ValidationResults), </para>
    /// > 
    /// > <para>**Used by [CSSPServices](CSSPServices.html)** : [OtherFilesToUploadService](CSSPServices.OtherFilesToUploadService.html)</para>
    /// > <para>**Return to [CSSPModels](CSSPModels.html)**</para>
    /// </summary>
    [NotMapped]
    public partial class OtherFilesToUpload : Error
    {
        #region Properties in DB
        #endregion Properties in DB

        #region Properties not in DB
        public string Error { get; set; }
        [Range(1, -1)]
        public int MikeScenarioID { get; set; }
        public List<TVFile> TVFileList { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public OtherFilesToUpload() : base()
        {
            TVFileList = new List<TVFile>();
        }
        #endregion Constructors
    }
}
