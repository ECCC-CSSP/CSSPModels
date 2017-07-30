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
    public partial class TVItemTVAuthTest : SetupData
    {
        [TestMethod]
        public void TVItemTVAuth_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "Error", "TVItemUserAuthID", "TVText", "TVItemID1", "TVTypeStr", "TVAuth",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(TVItemTVAuth).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
            {
                Assert.AreEqual(propertyInfo.Name, propNameList[index]);
                index += 1;
            }

            Assert.AreEqual(propNameList.Count, index);
        }
        [TestMethod]
        public void TVItemTVAuth_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(TVItemTVAuth).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void TVItemTVAuth_Every_Property_Has_A_Resource_OK()
        {
               Assert.IsNotNull(ModelsRes.TVItemTVAuthError);
               Assert.IsNotNull(ModelsRes.TVItemTVAuthTVItemUserAuthID);
               Assert.IsNotNull(ModelsRes.TVItemTVAuthTVText);
               Assert.IsNotNull(ModelsRes.TVItemTVAuthTVItemID1);
               Assert.IsNotNull(ModelsRes.TVItemTVAuthTVTypeStr);
               Assert.IsNotNull(ModelsRes.TVItemTVAuthTVAuth);
        }
        [TestMethod]
        public void TVItemTVAuth_Every_Property_Has_Get_Set_Test()
        {
               string val1 = "Some text";
               tVItemTVAuth.Error = val1;
               Assert.AreEqual(val1, tVItemTVAuth.Error);
               int val2 = 45;
               tVItemTVAuth.TVItemUserAuthID = val2;
               Assert.AreEqual(val2, tVItemTVAuth.TVItemUserAuthID);
               string val3 = "Some text";
               tVItemTVAuth.TVText = val3;
               Assert.AreEqual(val3, tVItemTVAuth.TVText);
               int val4 = 45;
               tVItemTVAuth.TVItemID1 = val4;
               Assert.AreEqual(val4, tVItemTVAuth.TVItemID1);
               string val5 = "Some text";
               tVItemTVAuth.TVTypeStr = val5;
               Assert.AreEqual(val5, tVItemTVAuth.TVTypeStr);
               TVAuthEnum val6 = (TVAuthEnum)3;
               tVItemTVAuth.TVAuth = val6;
               Assert.AreEqual(val6, tVItemTVAuth.TVAuth);
               IEnumerable<ValidationResult> val21 = new List<ValidationResult>().AsEnumerable();
               tVItemTVAuth.ValidationResults = val21;
               Assert.AreEqual(val21, tVItemTVAuth.ValidationResults);
        }
    }
}
