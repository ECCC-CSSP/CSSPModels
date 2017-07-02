using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Globalization;
using System.Transactions;
using System.Collections.Generic;
using CSSPModels.Resources;
using Microsoft.EntityFrameworkCore.Metadata;
using System.Reflection;

namespace CSSPModels.Tests
{
    public partial class LabSheetAndA1SheetTest
    {
        [TestMethod]
        public void LabSheetAndA1Sheet_Properties_OK()
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
        public void LabSheetAndA1Sheet_Has_ValidationResults_OK()
        {
             Assert.IsTrue(typeof(LabSheetAndA1Sheet).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void LabSheetAndA1Sheet_Every_Property_Has_A_Resource_OK()
        {
               Assert.IsNotNull(ModelsRes.LabSheetAndA1SheetLabSheet);
               Assert.IsNotNull(ModelsRes.LabSheetAndA1SheetLabSheetA1Sheet);
        }
    }
}
