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
    public partial class TVTypeNamesAndPathTest : SetupData
    {
        [TestMethod]
        public void TVTypeNamesAndPath_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "TVTypeName", "Index", "TVPath",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(TVTypeNamesAndPath).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
            {
                Assert.AreEqual(propertyInfo.Name, propNameList[index]);
                index += 1;
            }

            Assert.AreEqual(propNameList.Count, index);
        }
        [TestMethod]
        public void TVTypeNamesAndPath_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(TVTypeNamesAndPath).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void TVTypeNamesAndPath_Every_Property_Has_A_Resource_OK()
        {
               Assert.IsNotNull(ModelsRes.TVTypeNamesAndPathTVTypeName);
               Assert.IsNotNull(ModelsRes.TVTypeNamesAndPathIndex);
               Assert.IsNotNull(ModelsRes.TVTypeNamesAndPathTVPath);
        }
        [TestMethod]
        public void TVTypeNamesAndPath_Every_Property_Has_Get_Set_Test()
        {
               string val1 = "Some text";
               tVTypeNamesAndPath.TVTypeName = val1;
               Assert.AreEqual(val1, tVTypeNamesAndPath.TVTypeName);
               int val2 = 45;
               tVTypeNamesAndPath.Index = val2;
               Assert.AreEqual(val2, tVTypeNamesAndPath.Index);
               string val3 = "Some text";
               tVTypeNamesAndPath.TVPath = val3;
               Assert.AreEqual(val3, tVTypeNamesAndPath.TVPath);
               IEnumerable<ValidationResult> val12 = new List<ValidationResult>().AsEnumerable();
               tVTypeNamesAndPath.ValidationResults = val12;
               Assert.AreEqual(val12, tVTypeNamesAndPath.ValidationResults);
        }
    }
}
