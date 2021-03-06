/*
 * Auto generated from the CSSPCodeWriter.proj by clicking on the [[ModelClassName]TestGenerated.cs] button
 *
 * Do not edit this file.
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
    public partial class TVTypeNamesAndPathTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private TVTypeNamesAndPath tVTypeNamesAndPath { get; set; }
        #endregion Properties

        #region Constructors
        public TVTypeNamesAndPathTest()
        {
            tVTypeNamesAndPath = new TVTypeNamesAndPath();
        }
        #endregion Constructors

        #region Tests Functions public
        [TestMethod]
        public void TVTypeNamesAndPath_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "TVTypeName", "Index", "TVPath", "HasErrors",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(TVTypeNamesAndPath).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
            {
                Assert.AreEqual(propertyInfo.Name, propNameList[index]);
                index += 1;
            }

            Assert.AreEqual(propNameList.Count, index);
        }
        [TestMethod]
        public void TVTypeNamesAndPath_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(TVTypeNamesAndPath).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void TVTypeNamesAndPath_Every_Property_Has_Get_Set_Test()
        {
               string val1 = "Some text";
               tVTypeNamesAndPath.TVTypeName = val1;
               Assert.AreEqual(val1, tVTypeNamesAndPath.TVTypeName);
               int val2 = 45;
               tVTypeNamesAndPath.Index = val2;
               Assert.AreEqual(val2, tVTypeNamesAndPath.Index);
               string val3 = "Some text";
               tVTypeNamesAndPath.TVPath = val3;
               Assert.AreEqual(val3, tVTypeNamesAndPath.TVPath);
               bool val4 = true;
               tVTypeNamesAndPath.HasErrors = val4;
               Assert.AreEqual(val4, tVTypeNamesAndPath.HasErrors);
               IEnumerable<ValidationResult> val15 = new List<ValidationResult>() { new ValidationResult("First CSSPError Message") }.AsEnumerable();
               tVTypeNamesAndPath.ValidationResults = val15;
               Assert.AreEqual(val15, tVTypeNamesAndPath.ValidationResults);
        }
        #endregion Tests Functions public
    }
}
