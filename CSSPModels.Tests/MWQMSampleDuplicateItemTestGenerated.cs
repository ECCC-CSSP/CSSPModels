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
    public partial class MWQMSampleDuplicateItemTest : SetupData
    {
        [TestMethod]
        public void MWQMSampleDuplicateItem_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "ParentSite", "DuplicateSite",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(MWQMSampleDuplicateItem).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
            {
                Assert.AreEqual(propertyInfo.Name, propNameList[index]);
                index += 1;
            }

            Assert.AreEqual(propNameList.Count, index);
        }
        [TestMethod]
        public void MWQMSampleDuplicateItem_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(MWQMSampleDuplicateItem).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void MWQMSampleDuplicateItem_Every_Property_Has_A_Resource_OK()
        {
               Assert.IsNotNull(ModelsRes.MWQMSampleDuplicateItemParentSite);
               Assert.IsNotNull(ModelsRes.MWQMSampleDuplicateItemDuplicateSite);
        }
        [TestMethod]
        public void MWQMSampleDuplicateItem_Every_Property_Has_Get_Set_Test()
        {
               string val1 = "Some text";
               mWQMSampleDuplicateItem.ParentSite = val1;
               Assert.AreEqual(val1, mWQMSampleDuplicateItem.ParentSite);
               string val2 = "Some text";
               mWQMSampleDuplicateItem.DuplicateSite = val2;
               Assert.AreEqual(val2, mWQMSampleDuplicateItem.DuplicateSite);
               IEnumerable<ValidationResult> val9 = new List<ValidationResult>().AsEnumerable();
               mWQMSampleDuplicateItem.ValidationResults = val9;
               Assert.AreEqual(val9, mWQMSampleDuplicateItem.ValidationResults);
        }
    }
}
