﻿using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    [NotMapped]
    public partial class Element
    {
        #region Properties in DB
        #endregion Properties in DB

        #region Properties not in DB
        [Required]
        [Range(1, -1)]
        public int ID { get; set; }
        [Required]
        [Range(1, -1)]
        public int Type { get; set; }
        [Required]
        [Range(1, -1)]
        public int NumbOfNodes { get; set; }
        [Required]
        public float Value { get; set; }
        [Required]
        public float XNode0 { get; set; }
        [Required]
        public float YNode0 { get; set; }
        [Required]
        public float ZNode0 { get; set; }

        public virtual List<Node> NodeList { get; set; }
        public IEnumerable<ValidationResult> ValidationResults { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public Element()
        {
            NodeList = new List<Node>();
        }
        #endregion Constructors
    }
}
