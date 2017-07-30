using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Globalization;
using System.Transactions;
using System.Collections.Generic;
using CSSPModels.Resources;
using Microsoft.EntityFrameworkCore.Metadata;
using System.Reflection;
using CSSPEnums;
using System.ComponentModel.DataAnnotations;

namespace CSSPModels.Tests
{
    public partial class NodeLayerTest : SetupData
    {
        [TestMethod]
        public void NodeLayer_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "Layer", "Z", "Node",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(NodeLayer).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
            {
                Assert.AreEqual(propertyInfo.Name, propNameList[index]);
                index += 1;
            }

            Assert.AreEqual(propNameList.Count, index);
        }
        [TestMethod]
        public void NodeLayer_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(NodeLayer).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void NodeLayer_Every_Property_Has_A_Resource_OK()
        {
               Assert.IsNotNull(ModelsRes.NodeLayerLayer);
               Assert.IsNotNull(ModelsRes.NodeLayerZ);
               Assert.IsNotNull(ModelsRes.NodeLayerNode);
        }
        [TestMethod]
        public void NodeLayer_Every_Property_Has_Get_Set_Test()
        {
               int val1 = 45;
               nodeLayer.Layer = val1;
               Assert.AreEqual(val1, nodeLayer.Layer);
               double val2 = 87.9D;
               nodeLayer.Z = val2;
               Assert.AreEqual(val2, nodeLayer.Z);
               Node val7 = new Node();
               nodeLayer.Node = val7;
               Assert.AreEqual(val7, nodeLayer.Node);
               IEnumerable<ValidationResult> val12 = new List<ValidationResult>().AsEnumerable();
               nodeLayer.ValidationResults = val12;
               Assert.AreEqual(val12, nodeLayer.ValidationResults);
        }
    }
}
