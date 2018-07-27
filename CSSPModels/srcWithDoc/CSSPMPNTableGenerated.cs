/*
 * Auto generated from the CSSPCodeWriter.proj by clicking on the [\srcWithDoc\[ModelClassName]Generated.cs] button
 *
 * Do not edit this file.
 *
 * Last generated on 2018 July 27 04:56
 * by leblancc on WMON01DTCHLEBL2 machine
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
    /// > <para>**Other properties** : [Tube10](CSSPModels.CSSPMPNTable.html#CSSPModels_CSSPMPNTable_Tube10), [Tube1_0](CSSPModels.CSSPMPNTable.html#CSSPModels_CSSPMPNTable_Tube1_0), [Tube0_1](CSSPModels.CSSPMPNTable.html#CSSPModels_CSSPMPNTable_Tube0_1), [MPN](CSSPModels.CSSPMPNTable.html#CSSPModels_CSSPMPNTable_MPN), [HasErrors](CSSPModels.CSSPMPNTable.html#CSSPModels_CSSPMPNTable_HasErrors), [ValidationResults](CSSPModels.CSSPMPNTable.html#CSSPModels_CSSPMPNTable_ValidationResults), </para>
    /// > 
    /// > <para>**Used by [CSSPServices](CSSPServices.html)** : [CSSPMPNTableService](CSSPServices.CSSPMPNTableService.html)</para>
    /// > <para>**Return to [CSSPModels](CSSPModels.html)**</para>
    /// </summary>
    [NotMapped]
    public partial class CSSPMPNTable : Error
    {
        #region Properties in DB
        #endregion Properties in DB

        #region Properties not in DB
        [Range(0, 5)]
        public int Tube10 { get; set; }
        [Range(0, 5)]
        public int Tube1_0 { get; set; }
        [Range(0, 5)]
        public int Tube0_1 { get; set; }
        [Range(0, 100000000)]
        public int MPN { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public CSSPMPNTable() : base()
        {
        }
        #endregion Constructors
    }
}