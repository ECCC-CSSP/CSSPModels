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
    public partial class VPResValuesTest : SetupData
    {
        [TestMethod]
        public void VPResValues_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "Conc", "Dilu", "FarfieldWidth", "Distance", "TheTime", "Decay",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(VPResValues).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
            {
                Assert.AreEqual(propertyInfo.Name, propNameList[index]);
                index += 1;
            }

            Assert.AreEqual(propNameList.Count, index);
        }
        [TestMethod]
        public void VPResValues_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(VPResValues).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void VPResValues_Every_Property_Has_A_Resource_OK()
        {
               Assert.IsNotNull(ModelsRes.VPResValuesConc);
               Assert.IsNotNull(ModelsRes.VPResValuesDilu);
               Assert.IsNotNull(ModelsRes.VPResValuesFarfieldWidth);
               Assert.IsNotNull(ModelsRes.VPResValuesDistance);
               Assert.IsNotNull(ModelsRes.VPResValuesTheTime);
               Assert.IsNotNull(ModelsRes.VPResValuesDecay);
        }
        [TestMethod]
        public void VPResValues_Every_Property_Has_Get_Set_Test()
        {
               int val1 = 45;
               vPResValues.Conc = val1;
               Assert.AreEqual(val1, vPResValues.Conc);
               double val2 = 87.9D;
               vPResValues.Dilu = val2;
               Assert.AreEqual(val2, vPResValues.Dilu);
               double val3 = 87.9D;
               vPResValues.FarfieldWidth = val3;
               Assert.AreEqual(val3, vPResValues.FarfieldWidth);
               double val4 = 87.9D;
               vPResValues.Distance = val4;
               Assert.AreEqual(val4, vPResValues.Distance);
               double val5 = 87.9D;
               vPResValues.TheTime = val5;
               Assert.AreEqual(val5, vPResValues.TheTime);
               double val6 = 87.9D;
               vPResValues.Decay = val6;
               Assert.AreEqual(val6, vPResValues.Decay);
               IEnumerable<ValidationResult> val21 = new List<ValidationResult>().AsEnumerable();
               vPResValues.ValidationResults = val21;
               Assert.AreEqual(val21, vPResValues.ValidationResults);
        }
    }
}
