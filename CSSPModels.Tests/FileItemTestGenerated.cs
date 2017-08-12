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
    public partial class FileItemTest : SetupData
    {
        [TestMethod]
        public void FileItem_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "Name", "TVItemID", "HasErrors",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(FileItem).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
            {
                Assert.AreEqual(propertyInfo.Name, propNameList[index]);
                index += 1;
            }

            Assert.AreEqual(propNameList.Count, index);
        }
        [TestMethod]
        public void FileItem_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(FileItem).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void FileItem_Every_Property_Has_A_Resource_OK()
        {
               Assert.IsNotNull(ModelsRes.FileItemName);
               Assert.IsNotNull(ModelsRes.FileItemTVItemID);
               Assert.IsNotNull(ModelsRes.FileItemHasErrors);
        }
        [TestMethod]
        public void FileItem_Every_Property_Has_Get_Set_Test()
        {
               string val1 = "Some text";
               fileItem.Name = val1;
               Assert.AreEqual(val1, fileItem.Name);
               int val2 = 45;
               fileItem.TVItemID = val2;
               Assert.AreEqual(val2, fileItem.TVItemID);
               bool val3 = true;
               fileItem.HasErrors = val3;
               Assert.AreEqual(val3, fileItem.HasErrors);
               IEnumerable<ValidationResult> val12 = new List<ValidationResult>().AsEnumerable();
               fileItem.ValidationResults = val12;
               Assert.AreEqual(val12, fileItem.ValidationResults);
        }
    }
}
