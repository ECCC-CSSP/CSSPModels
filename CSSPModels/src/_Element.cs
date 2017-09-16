using CSSPEnums;
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
        [Range(1, -1)]
        public int ID { get; set; }
        [Range(1, -1)]
        public int Type { get; set; }
        [Range(1, -1)]
        public int NumbOfNodes { get; set; }
        public double Value { get; set; }
        public double XNode0 { get; set; }
        public double YNode0 { get; set; }
        public double ZNode0 { get; set; }
        public virtual List<Node> NodeList { get; set; }
        public bool HasErrors { get; set; }
        public IEnumerable<ValidationResult> ValidationResults { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public Element()
        {
            NodeList = new List<Node>();
            ValidationResults = new List<ValidationResult>();
        }
        #endregion Constructors
    }
}
