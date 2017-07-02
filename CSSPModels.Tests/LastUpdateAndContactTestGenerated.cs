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
    public partial class LastUpdateAndContactTest
    {
        [TestMethod]
        public void LastUpdateAndContact_Properties_OK()
        {
            List<string> propNameList = new List<string>() { "Error", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(LastUpdateAndContact).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
            {
                Assert.AreEqual(propertyInfo.Name, propNameList[index]);
                index += 1;
            }

            Assert.AreEqual(propNameList.Count, index);
        }
        [TestMethod]
        public void LastUpdateAndContact_Has_ValidationResults_OK()
        {
             Assert.IsTrue(typeof(LastUpdateAndContact).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void LastUpdateAndContact_Every_Property_Has_A_Resource_OK()
        {
               Assert.IsNotNull(ModelsRes.LastUpdateAndContactError);
               Assert.IsNotNull(ModelsRes.LastUpdateAndContactLastUpdateDate_UTC);
               Assert.IsNotNull(ModelsRes.LastUpdateAndContactLastUpdateContactTVItemID);
        }
    }
}
