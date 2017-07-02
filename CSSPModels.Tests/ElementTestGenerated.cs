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
    public partial class ElementTest
    {
        [TestMethod]
        public void Element_Properties_OK()
        {
            List<string> propNameList = new List<string>() { "ID", "Type", "NumbOfNodes", "Value", "XNode0", "YNode0", "ZNode0", "NodeList",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(Element).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
            {
                Assert.AreEqual(propertyInfo.Name, propNameList[index]);
                index += 1;
            }

            Assert.AreEqual(propNameList.Count, index);
        }
        [TestMethod]
        public void Element_Has_ValidationResults_OK()
        {
             Assert.IsTrue(typeof(Element).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void Element_Every_Property_Has_A_Resource_OK()
        {
               Assert.IsNotNull(ModelsRes.ElementID);
               Assert.IsNotNull(ModelsRes.ElementType);
               Assert.IsNotNull(ModelsRes.ElementNumbOfNodes);
               Assert.IsNotNull(ModelsRes.ElementValue);
               Assert.IsNotNull(ModelsRes.ElementXNode0);
               Assert.IsNotNull(ModelsRes.ElementYNode0);
               Assert.IsNotNull(ModelsRes.ElementZNode0);
               Assert.IsNotNull(ModelsRes.ElementNodeList);
        }
    }
}
