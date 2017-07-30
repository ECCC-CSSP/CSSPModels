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
    public partial class FileItemListTest : SetupData
    {
        [TestMethod]
        public void FileItemList_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "Text", "FileName",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(FileItemList).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
            {
                Assert.AreEqual(propertyInfo.Name, propNameList[index]);
                index += 1;
            }

            Assert.AreEqual(propNameList.Count, index);
        }
        [TestMethod]
        public void FileItemList_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(FileItemList).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void FileItemList_Every_Property_Has_A_Resource_OK()
        {
               Assert.IsNotNull(ModelsRes.FileItemListText);
               Assert.IsNotNull(ModelsRes.FileItemListFileName);
        }
        [TestMethod]
        public void FileItemList_Every_Property_Has_Get_Set_Test()
        {
               string val1 = "Some text";
               fileItemList.Text = val1;
               Assert.AreEqual(val1, fileItemList.Text);
               string val2 = "Some text";
               fileItemList.FileName = val2;
               Assert.AreEqual(val2, fileItemList.FileName);
               IEnumerable<ValidationResult> val9 = new List<ValidationResult>().AsEnumerable();
               fileItemList.ValidationResults = val9;
               Assert.AreEqual(val9, fileItemList.ValidationResults);
        }
    }
}
