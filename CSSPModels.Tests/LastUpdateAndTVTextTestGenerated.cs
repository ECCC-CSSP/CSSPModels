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
    public partial class LastUpdateAndTVTextTest
    {
        [TestMethod]
        public void LastUpdateAndTVText_Properties_OK()
        {
            List<string> propNameList = new List<string>() { "Error", "LastUpdateDate_UTC", "LastUpdateDate_Local", "TVText",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(LastUpdateAndTVText).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
            {
                Assert.AreEqual(propertyInfo.Name, propNameList[index]);
                index += 1;
            }

            Assert.AreEqual(propNameList.Count, index);
        }
        [TestMethod]
        public void LastUpdateAndTVText_Has_ValidationResults_OK()
        {
             Assert.IsTrue(typeof(LastUpdateAndTVText).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void LastUpdateAndTVText_Every_Property_Has_A_Resource_OK()
        {
               Assert.IsNotNull(ModelsRes.LastUpdateAndTVTextError);
               Assert.IsNotNull(ModelsRes.LastUpdateAndTVTextLastUpdateDate_UTC);
               Assert.IsNotNull(ModelsRes.LastUpdateAndTVTextLastUpdateDate_Local);
               Assert.IsNotNull(ModelsRes.LastUpdateAndTVTextTVText);
        }
    }
}
