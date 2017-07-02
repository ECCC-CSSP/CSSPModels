using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    [NotMapped]
    public partial class Node
    {
        #region Properties in DB
        #endregion Properties in DB

        #region Properties not in DB
        [Required]
        [Range(1, 1000000)]
        public int ID { get; set; }
        [Required]
        public float X { get; set; }
        [Required]
        public float Y { get; set; }
        [Required]
        public float Z { get; set; }
        [Required]
        public int Code { get; set; }
        [Required]
        public float Value { get; set; }

        public virtual List<Element> ElementList { get; set; }
        public virtual List<Node> ConnectNodeList { get; set; }
        public IEnumerable<ValidationResult> ValidationResults { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public Node()
        {
            ElementList = new List<Element>();
            ConnectNodeList = new List<Node>();
        }
        #endregion Constructors
    }
}
