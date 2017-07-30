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
    public partial class RTBStringPosTest : SetupData
    {
        [TestMethod]
        public void RTBStringPos_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "StartPos", "EndPos", "Text", "TagText",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(RTBStringPos).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
            {
                Assert.AreEqual(propertyInfo.Name, propNameList[index]);
                index += 1;
            }

            Assert.AreEqual(propNameList.Count, index);
        }
        [TestMethod]
        public void RTBStringPos_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(RTBStringPos).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void RTBStringPos_Every_Property_Has_A_Resource_OK()
        {
               Assert.IsNotNull(ModelsRes.RTBStringPosStartPos);
               Assert.IsNotNull(ModelsRes.RTBStringPosEndPos);
               Assert.IsNotNull(ModelsRes.RTBStringPosText);
               Assert.IsNotNull(ModelsRes.RTBStringPosTagText);
        }
        [TestMethod]
        public void RTBStringPos_Every_Property_Has_Get_Set_Test()
        {
               int val1 = 45;
               rTBStringPos.StartPos = val1;
               Assert.AreEqual(val1, rTBStringPos.StartPos);
               int val2 = 45;
               rTBStringPos.EndPos = val2;
               Assert.AreEqual(val2, rTBStringPos.EndPos);
               string val3 = "Some text";
               rTBStringPos.Text = val3;
               Assert.AreEqual(val3, rTBStringPos.Text);
               string val4 = "Some text";
               rTBStringPos.TagText = val4;
               Assert.AreEqual(val4, rTBStringPos.TagText);
               IEnumerable<ValidationResult> val15 = new List<ValidationResult>().AsEnumerable();
               rTBStringPos.ValidationResults = val15;
               Assert.AreEqual(val15, rTBStringPos.ValidationResults);
        }
    }
}
