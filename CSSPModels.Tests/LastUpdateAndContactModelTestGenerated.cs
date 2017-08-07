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
    public partial class LastUpdateAndContactModelTest : SetupData
    {
        [TestMethod]
        public void LastUpdateAndContactModel_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(LastUpdateAndContactModel).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
            {
                Assert.AreEqual(propertyInfo.Name, propNameList[index]);
                index += 1;
            }

            Assert.AreEqual(propNameList.Count, index);
        }
        [TestMethod]
        public void LastUpdateAndContactModel_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(LastUpdateAndContactModel).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void LastUpdateAndContactModel_Every_Property_Has_A_Resource_OK()
        {
               Assert.IsNotNull(ModelsRes.LastUpdateAndContactModelLastUpdateDate_UTC);
               Assert.IsNotNull(ModelsRes.LastUpdateAndContactModelLastUpdateContactTVItemID);
        }
        [TestMethod]
        public void LastUpdateAndContactModel_Every_Property_Has_Get_Set_Test()
        {
               DateTime val1 = new DateTime(2010, 3, 4);
               lastUpdateAndContactModel.LastUpdateDate_UTC = val1;
               Assert.AreEqual(val1, lastUpdateAndContactModel.LastUpdateDate_UTC);
               int val2 = 45;
               lastUpdateAndContactModel.LastUpdateContactTVItemID = val2;
               Assert.AreEqual(val2, lastUpdateAndContactModel.LastUpdateContactTVItemID);
        }
    }
}
