/*
 * Auto generated from the CSSPCodeWriter.proj by clicking on the [[ModelClassName]TestGenerated.cs] button
 *
 * Do not edit this file.
 *
 * Last generated on 2018 August 01 05:00
 * by leblancc on WMON01DTCHLEBL2 machine
 *
 */ 
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
        public void VPFull_Every_Property_Has_A_Resource_OK()
        {
               Assert.IsNotNull(CSSPModelsRes.VPFullVPScenario);
               Assert.IsNotNull(CSSPModelsRes.VPFullVPAmbientList);
               Assert.IsNotNull(CSSPModelsRes.VPFullVPResultList);
               Assert.IsNotNull(CSSPModelsRes.VPFullHasErrors);
        }
        [TestMethod]
        public void VPFull_Every_Property_Has_Get_Set_Test()
        {
               bool val4 = true;
               vPFull.HasErrors = val4;
               Assert.AreEqual(val4, vPFull.HasErrors);
               VPScenario val6 = new VPScenario();
               vPFull.VPScenario = val6;
               Assert.AreEqual(val6, vPFull.VPScenario);
               List<VPAmbient> val7 = new List<VPAmbient>();
               vPFull.VPAmbientList = val7;
               Assert.AreEqual(val7, vPFull.VPAmbientList);
               List<VPResult> val8 = new List<VPResult>();
               vPFull.VPResultList = val8;
               Assert.AreEqual(val8, vPFull.VPResultList);
               IEnumerable<ValidationResult> val15 = new List<ValidationResult>().AsEnumerable();
               vPFull.ValidationResults = val15;
               Assert.AreEqual(val15, vPFull.ValidationResults);
        }
        #endregion Tests Functions public
    }
}
