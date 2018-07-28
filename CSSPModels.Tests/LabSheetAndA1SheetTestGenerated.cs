/*
 * Auto generated from the CSSPCodeWriter.proj by clicking on the [[ModelClassName]TestGenerated.cs] button
 *
 * Do not edit this file.
 *
 * Last generated on 2018 July 28 01:58
 * by Charles on CHARLES-PC machine
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
    public partial class LabSheetAndA1SheetTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private LabSheetAndA1Sheet labSheetAndA1Sheet { get; set; }
        #endregion Properties

        #region Constructors
        public LabSheetAndA1SheetTest()
        {
            labSheetAndA1Sheet = new LabSheetAndA1Sheet();
        }
        #endregion Constructors

        #region Tests Functions public
        [TestMethod]
        public void LabSheetAndA1Sheet_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "LabSheet", "LabSheetA1Sheet", "HasErrors",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(LabSheetAndA1Sheet).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
            {
                Assert.AreEqual(propertyInfo.Name, propNameList[index]);
                index += 1;
            }

            Assert.AreEqual(propNameList.Count, index);
        }
        [TestMethod]
        public void LabSheetAndA1Sheet_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(LabSheetAndA1Sheet).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void LabSheetAndA1Sheet_Every_Property_Has_A_Resource_OK()
        {
               Assert.IsNotNull(CSSPModelsRes.LabSheetAndA1SheetLabSheet);
               Assert.IsNotNull(CSSPModelsRes.LabSheetAndA1SheetLabSheetA1Sheet);
               Assert.IsNotNull(CSSPModelsRes.LabSheetAndA1SheetHasErrors);
        }
        [TestMethod]
        public void LabSheetAndA1Sheet_Every_Property_Has_Get_Set_Test()
        {
               bool val3 = true;
               labSheetAndA1Sheet.HasErrors = val3;
               Assert.AreEqual(val3, labSheetAndA1Sheet.HasErrors);
               LabSheet val5 = new LabSheet();
               labSheetAndA1Sheet.LabSheet = val5;
               Assert.AreEqual(val5, labSheetAndA1Sheet.LabSheet);
               LabSheetA1Sheet val6 = new LabSheetA1Sheet();
               labSheetAndA1Sheet.LabSheetA1Sheet = val6;
               Assert.AreEqual(val6, labSheetAndA1Sheet.LabSheetA1Sheet);
               IEnumerable<ValidationResult> val12 = new List<ValidationResult>().AsEnumerable();
               labSheetAndA1Sheet.ValidationResults = val12;
               Assert.AreEqual(val12, labSheetAndA1Sheet.ValidationResults);
        }
        #endregion Tests Functions public
    }
}
