/*
 * Manually edited by Charles LeBlanc 
 * 
 */
using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    [NotMapped]
    public partial class Element : Error
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
        #endregion Properties not in DB

        #region Constructors
        public Element() : base()
        {
            NodeList = new List<Node>();
        }
        #endregion Constructors
    }
}
