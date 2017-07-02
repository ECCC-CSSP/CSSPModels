using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Collections.Generic;
using CSSPModels;
using Microsoft.EntityFrameworkCore.Metadata;
using System.Reflection;
using CSSPEnums;

namespace CSSPModels.Tests
{
    [TestClass]
    public partial class NodeLayerTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private CSSPWebToolsDBContext db { get; set; }
        private NodeLayer nodeLayer { get; set; }
        #endregion Properties

        #region Constructors
        public NodeLayerTest()
        {
            db = new CSSPWebToolsDBContext(DatabaseTypeEnum.MemoryNoDBShape);
            nodeLayer = new NodeLayer();
        }
        #endregion Constructors

        #region Tests
        // most of the tests are located under NodeLayerTestGenerated.cs
        #endregion Tests
    }
}
