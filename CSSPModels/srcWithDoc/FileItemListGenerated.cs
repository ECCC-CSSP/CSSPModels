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
using System.Linq;

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
    public partial class FileItemList : Error
    {
        #region Properties in DB
        #endregion Properties in DB

        #region Properties not in DB
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Text")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Texte")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Text")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Texte")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Text
        /// 
        /// **Display (fr)** --- Texte
        /// 
        /// **Description (en)** --- Text
        /// 
        /// **Description (fr)** --- Texte
        /// </returns>
        [StringLength(255, MinimumLength = 1)]
        [CSSPDisplayEN(DisplayEN = "Text")]
        [CSSPDisplayFR(DisplayFR = "Texte")]
        [CSSPDescriptionEN(DescriptionEN = @"Text")]
        [CSSPDescriptionFR(DescriptionFR = @"Texte")]
        public string Text { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "File name")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Nom du fichier")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "File name")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Nom du fichier")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- File name
        /// 
        /// **Display (fr)** --- Nom du fichier
        /// 
        /// **Description (en)** --- File name
        /// 
        /// **Description (fr)** --- Nom du fichier
        /// </returns>
        [StringLength(255, MinimumLength = 1)]
        [CSSPDisplayEN(DisplayEN = "File name")]
        [CSSPDisplayFR(DisplayFR = "Nom du fichier")]
        [CSSPDescriptionEN(DescriptionEN = @"File name")]
        [CSSPDescriptionFR(DescriptionFR = @"Nom du fichier")]
        public string FileName { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public FileItemList() : base()
        {
        }
        #endregion Constructors
    }
}
