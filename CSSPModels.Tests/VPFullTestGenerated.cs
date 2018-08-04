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
    public partial class VPFullTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private VPFull vPFull { get; set; }
        #endregion Properties

        #region Constructors
        public VPFullTest()
        {
            vPFull = new VPFull();
        }
        #endregion Constructors

        #region Tests Functions public
        [TestMethod]
        public void VPFull_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "VPScenario", "VPAmbientList", "VPResultList", "HasErrors",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(VPFull).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
            {
                Assert.AreEqual(propertyInfo.Name, propNameList[index]);
                index += 1;
            }

            Assert.AreEqual(propNameList.Count, index);
        }
        [TestMethod]
        public void VPFull_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(VPFull).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void VPFull_Every_Property_Has_Get_Set_Test()
        {
               VPScenario val1 = new VPScenario();
               vPFull.VPScenario = val1;
               Assert.AreEqual(val1, vPFull.VPScenario);
               List<VPAmbient> val2 = new List<VPAmbient>() { new VPAmbient(), new VPAmbient() };
               vPFull.VPAmbientList = val2;
               Assert.AreEqual(val2, vPFull.VPAmbientList);
               List<VPResult> val3 = new List<VPResult>() { new VPResult(), new VPResult() };
               vPFull.VPResultList = val3;
               Assert.AreEqual(val3, vPFull.VPResultList);
               bool val4 = true;
               vPFull.HasErrors = val4;
               Assert.AreEqual(val4, vPFull.HasErrors);
               IEnumerable<ValidationResult> val15 = new List<ValidationResult>() { new ValidationResult("First Error Message") }.AsEnumerable();
               vPFull.ValidationResults = val15;
               Assert.AreEqual(val15, vPFull.ValidationResults);
        }
        #endregion Tests Functions public
    }
}
