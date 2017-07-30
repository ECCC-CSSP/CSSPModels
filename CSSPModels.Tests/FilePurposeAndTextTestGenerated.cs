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
    public partial class FilePurposeAndTextTest : SetupData
    {
        [TestMethod]
        public void FilePurposeAndText_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "FilePurpose", "FilePurposeText",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(FilePurposeAndText).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
            {
                Assert.AreEqual(propertyInfo.Name, propNameList[index]);
                index += 1;
            }

            Assert.AreEqual(propNameList.Count, index);
        }
        [TestMethod]
        public void FilePurposeAndText_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(FilePurposeAndText).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void FilePurposeAndText_Every_Property_Has_A_Resource_OK()
        {
               Assert.IsNotNull(ModelsRes.FilePurposeAndTextFilePurpose);
               Assert.IsNotNull(ModelsRes.FilePurposeAndTextFilePurposeText);
        }
        [TestMethod]
        public void FilePurposeAndText_Every_Property_Has_Get_Set_Test()
        {
               FilePurposeEnum val1 = (FilePurposeEnum)3;
               filePurposeAndText.FilePurpose = val1;
               Assert.AreEqual(val1, filePurposeAndText.FilePurpose);
               string val2 = "Some text";
               filePurposeAndText.FilePurposeText = val2;
               Assert.AreEqual(val2, filePurposeAndText.FilePurposeText);
               IEnumerable<ValidationResult> val9 = new List<ValidationResult>().AsEnumerable();
               filePurposeAndText.ValidationResults = val9;
               Assert.AreEqual(val9, filePurposeAndText.ValidationResults);
        }
    }
}
