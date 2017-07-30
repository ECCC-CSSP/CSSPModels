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
    public partial class LabSheetAndA1SheetTest : SetupData
    {
        [TestMethod]
        public void LabSheetAndA1Sheet_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "LabSheet", "LabSheetA1Sheet",  }.OrderBy(c => c).ToList();
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
               Assert.IsNotNull(ModelsRes.LabSheetAndA1SheetLabSheet);
               Assert.IsNotNull(ModelsRes.LabSheetAndA1SheetLabSheetA1Sheet);
        }
        [TestMethod]
        public void LabSheetAndA1Sheet_Every_Property_Has_Get_Set_Test()
        {
               LabSheet val4 = new LabSheet();
               labSheetAndA1Sheet.LabSheet = val4;
               Assert.AreEqual(val4, labSheetAndA1Sheet.LabSheet);
               LabSheetA1Sheet val5 = new LabSheetA1Sheet();
               labSheetAndA1Sheet.LabSheetA1Sheet = val5;
               Assert.AreEqual(val5, labSheetAndA1Sheet.LabSheetA1Sheet);
               IEnumerable<ValidationResult> val9 = new List<ValidationResult>().AsEnumerable();
               labSheetAndA1Sheet.ValidationResults = val9;
               Assert.AreEqual(val9, labSheetAndA1Sheet.ValidationResults);
        }
    }
}
