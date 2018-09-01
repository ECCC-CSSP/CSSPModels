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
    public partial class FileItemListTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private FileItemList fileItemList { get; set; }
        #endregion Properties

        #region Constructors
        public FileItemListTest()
        {
            fileItemList = new FileItemList();
        }
        #endregion Constructors

        #region Tests Functions public
        [TestMethod]
        public void FileItemList_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "Text", "FileName", "HasErrors",  }.OrderBy(c => c).ToList();
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
        public void FileItemList_Every_Property_Has_Get_Set_Test()
        {
               string val1 = "Some text";
               fileItemList.Text = val1;
               Assert.AreEqual(val1, fileItemList.Text);
               string val2 = "Some text";
               fileItemList.FileName = val2;
               Assert.AreEqual(val2, fileItemList.FileName);
               bool val3 = true;
               fileItemList.HasErrors = val3;
               Assert.AreEqual(val3, fileItemList.HasErrors);
               IEnumerable<ValidationResult> val12 = new List<ValidationResult>() { new ValidationResult("First Error Message") }.AsEnumerable();
               fileItemList.ValidationResults = val12;
               Assert.AreEqual(val12, fileItemList.ValidationResults);
        }
        #endregion Tests Functions public
    }
}
