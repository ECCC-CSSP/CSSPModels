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
    /// > <para>**Other properties** : [TVTypeName](CSSPModels.TVTypeNamesAndPath.html#CSSPModels_TVTypeNamesAndPath_TVTypeName), [Index](CSSPModels.TVTypeNamesAndPath.html#CSSPModels_TVTypeNamesAndPath_Index), [TVPath](CSSPModels.TVTypeNamesAndPath.html#CSSPModels_TVTypeNamesAndPath_TVPath), [HasErrors](CSSPModels.TVTypeNamesAndPath.html#CSSPModels_TVTypeNamesAndPath_HasErrors), [ValidationResults](CSSPModels.TVTypeNamesAndPath.html#CSSPModels_TVTypeNamesAndPath_ValidationResults), </para>
    /// > 
    /// > <para>**Used by [CSSPServices](CSSPServices.html)** : [TVTypeNamesAndPathService](CSSPServices.TVTypeNamesAndPathService.html)</para>
    /// > <para>**Return to [CSSPModels](CSSPModels.html)**</para>
    /// </summary>
    [NotMapped]
    public partial class TVTypeNamesAndPath : Error
    {
        #region Properties in DB
        #endregion Properties in DB

        #region Properties not in DB
        [StringLength(255, MinimumLength = 1)]
        public string TVTypeName { get; set; }
        [Range(1, -1)]
        public int Index { get; set; }
        [StringLength(255, MinimumLength = 1)]
        public string TVPath { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public TVTypeNamesAndPath() : base()
        {
        }
        #endregion Constructors
    }
}
