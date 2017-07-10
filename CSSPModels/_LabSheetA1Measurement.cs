﻿using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    [NotMapped]
    public partial class LabSheetA1Measurement
    {
        #region Properties in DB
        #endregion Properties in DB

        #region Properties not in DB
        public string Site { get; set; }
        [Range(1, -1)]
        public int TVItemID { get; set; }
        public DateTime? Time { get; set; }
        public int? MPN { get; set; }
        public int? Tube10 { get; set; }
        public int? Tube1_0 { get; set; }
        public int? Tube0_1 { get; set; }
        public float? Salinity { get; set; }
        public float Temperature { get; set; }
        public string ProcessedBy { get; set; }
        public SampleTypeEnum? SampleType { get; set; }
        public string SiteComment { get; set; }

        public IEnumerable<ValidationResult> ValidationResults { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public LabSheetA1Measurement()
        {
            // empty for now
        }
        #endregion Constructors
    }
}
