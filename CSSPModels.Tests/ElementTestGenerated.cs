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
    public partial class ElementTest : SetupData
    {
        [TestMethod]
        public void Element_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "ID", "Type", "NumbOfNodes", "Value", "XNode0", "YNode0", "ZNode0", "NodeList", "HasErrors",  }.OrderBy(c => c).ToList();
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
        public void Element_Has_ValidationResults_Test()
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
               Assert.IsNotNull(ModelsRes.ElementHasErrors);
        }
        [TestMethod]
        public void Element_Every_Property_Has_Get_Set_Test()
        {
               int val1 = 45;
               element.ID = val1;
               Assert.AreEqual(val1, element.ID);
               int val2 = 45;
               element.Type = val2;
               Assert.AreEqual(val2, element.Type);
               int val3 = 45;
               element.NumbOfNodes = val3;
               Assert.AreEqual(val3, element.NumbOfNodes);
               double val4 = 87.9D;
               element.Value = val4;
               Assert.AreEqual(val4, element.Value);
               double val5 = 87.9D;
               element.XNode0 = val5;
               Assert.AreEqual(val5, element.XNode0);
               double val6 = 87.9D;
               element.YNode0 = val6;
               Assert.AreEqual(val6, element.YNode0);
               double val7 = 87.9D;
               element.ZNode0 = val7;
               Assert.AreEqual(val7, element.ZNode0);
               bool val9 = true;
               element.HasErrors = val9;
               Assert.AreEqual(val9, element.HasErrors);
               List<Node> val18 = new List<Node>();
               element.NodeList = val18;
               Assert.AreEqual(val18, element.NodeList);
               IEnumerable<ValidationResult> val30 = new List<ValidationResult>().AsEnumerable();
               element.ValidationResults = val30;
               Assert.AreEqual(val30, element.ValidationResults);
        }
    }
}
