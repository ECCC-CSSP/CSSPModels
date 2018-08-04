/*
 * Auto generated from the CSSPCodeWriter.proj by clicking on the [[ModelClassName]TestGenerated.cs] button
 *
 * Do not edit this file.
 *
 * Last generated by Charles on CHARLES-PC machine
 *
 */ 
using System;
using System.Text;
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
    [TestClass]
    public partial class NodeTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private Node node { get; set; }
        #endregion Properties

        #region Constructors
        public NodeTest()
        {
            node = new Node();
        }
        #endregion Constructors

        #region Tests Functions public
        [TestMethod]
        public void Node_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "ID", "X", "Y", "Z", "Code", "Value", "ElementList", "ConnectNodeList", "HasErrors",  }.OrderBy(c => c).ToList();
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
               List<Element> val7 = new List<Element>() { new Element(), new Element() };
               node.ElementList = val7;
               Assert.AreEqual(val7, node.ElementList);
               List<Node> val8 = new List<Node>() { new Node(), new Node() };
               node.ConnectNodeList = val8;
               Assert.AreEqual(val8, node.ConnectNodeList);
               bool val9 = true;
               node.HasErrors = val9;
               Assert.AreEqual(val9, node.HasErrors);
               IEnumerable<ValidationResult> val30 = new List<ValidationResult>() { new ValidationResult("First Error Message") }.AsEnumerable();
               node.ValidationResults = val30;
               Assert.AreEqual(val30, node.ValidationResults);
        }
        #endregion Tests Functions public
    }
}
