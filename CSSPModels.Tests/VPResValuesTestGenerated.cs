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
    public partial class VPResValuesTest
    {
        [TestMethod]
        public void VPResValues_Properties_OK()
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
        public void VPResValues_Has_ValidationResults_OK()
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
    }
}
