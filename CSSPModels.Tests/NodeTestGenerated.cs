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
    public partial class NodeTest : SetupData
    {
        [TestMethod]
        public void Node_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "ID", "X", "Y", "Z", "Code", "Value", "ElementList", "ConnectNodeList",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(Node).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
            {
                Assert.AreEqual(propertyInfo.Name, propNameList[index]);
                index += 1;
            }

            Assert.AreEqual(propNameList.Count, index);
        }
        [TestMethod]
        public void Node_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(Node).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void Node_Every_Property_Has_A_Resource_OK()
        {
               Assert.IsNotNull(ModelsRes.NodeID);
               Assert.IsNotNull(ModelsRes.NodeX);
               Assert.IsNotNull(ModelsRes.NodeY);
               Assert.IsNotNull(ModelsRes.NodeZ);
               Assert.IsNotNull(ModelsRes.NodeCode);
               Assert.IsNotNull(ModelsRes.NodeValue);
               Assert.IsNotNull(ModelsRes.NodeElementList);
               Assert.IsNotNull(ModelsRes.NodeConnectNodeList);
        }
        [TestMethod]
        public void Node_Every_Property_Has_Get_Set_Test()
        {
               int val1 = 45;
               node.ID = val1;
               Assert.AreEqual(val1, node.ID);
               double val2 = 87.9D;
               node.X = val2;
               Assert.AreEqual(val2, node.X);
               double val3 = 87.9D;
               node.Y = val3;
               Assert.AreEqual(val3, node.Y);
               double val4 = 87.9D;
               node.Z = val4;
               Assert.AreEqual(val4, node.Z);
               int val5 = 45;
               node.Code = val5;
               Assert.AreEqual(val5, node.Code);
               double val6 = 87.9D;
               node.Value = val6;
               Assert.AreEqual(val6, node.Value);
               List<Element> val16 = new List<Element>();
               node.ElementList = val16;
               Assert.AreEqual(val16, node.ElementList);
               List<Node> val17 = new List<Node>();
               node.ConnectNodeList = val17;
               Assert.AreEqual(val17, node.ConnectNodeList);
               IEnumerable<ValidationResult> val27 = new List<ValidationResult>().AsEnumerable();
               node.ValidationResults = val27;
               Assert.AreEqual(val27, node.ValidationResults);
        }
    }
}
