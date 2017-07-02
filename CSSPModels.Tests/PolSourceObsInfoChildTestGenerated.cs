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
    public partial class PolSourceObsInfoChildTest
    {
        [TestMethod]
        public void PolSourceObsInfoChild_Properties_OK()
        {
            List<string> propNameList = new List<string>() { "PolSourceObsInfo", "PolSourceObsInfoChildStart",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(PolSourceObsInfoChild).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
            {
                Assert.AreEqual(propertyInfo.Name, propNameList[index]);
                index += 1;
            }

            Assert.AreEqual(propNameList.Count, index);
        }
        [TestMethod]
        public void PolSourceObsInfoChild_Has_ValidationResults_OK()
        {
             Assert.IsTrue(typeof(PolSourceObsInfoChild).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void PolSourceObsInfoChild_Every_Property_Has_A_Resource_OK()
        {
               Assert.IsNotNull(ModelsRes.PolSourceObsInfoChildPolSourceObsInfo);
               Assert.IsNotNull(ModelsRes.PolSourceObsInfoChildPolSourceObsInfoChildStart);
        }
    }
}
