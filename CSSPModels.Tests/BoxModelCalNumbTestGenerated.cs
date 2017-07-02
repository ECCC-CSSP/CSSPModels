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
    public partial class BoxModelCalNumbTest
    {
        [TestMethod]
        public void BoxModelCalNumb_Properties_OK()
        {
            List<string> propNameList = new List<string>() { "Error", "BoxModelResultType", "CalLength_m", "CalRadius_m", "CalSurface_m2", "CalVolume_m3", "CalWidth_m", "FixLength", "FixWidth",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(BoxModelCalNumb).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
            {
                Assert.AreEqual(propertyInfo.Name, propNameList[index]);
                index += 1;
            }

            Assert.AreEqual(propNameList.Count, index);
        }
        [TestMethod]
        public void BoxModelCalNumb_Has_ValidationResults_OK()
        {
             Assert.IsTrue(typeof(BoxModelCalNumb).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void BoxModelCalNumb_Every_Property_Has_A_Resource_OK()
        {
               Assert.IsNotNull(ModelsRes.BoxModelCalNumbError);
               Assert.IsNotNull(ModelsRes.BoxModelCalNumbBoxModelResultType);
               Assert.IsNotNull(ModelsRes.BoxModelCalNumbCalLength_m);
               Assert.IsNotNull(ModelsRes.BoxModelCalNumbCalRadius_m);
               Assert.IsNotNull(ModelsRes.BoxModelCalNumbCalSurface_m2);
               Assert.IsNotNull(ModelsRes.BoxModelCalNumbCalVolume_m3);
               Assert.IsNotNull(ModelsRes.BoxModelCalNumbCalWidth_m);
               Assert.IsNotNull(ModelsRes.BoxModelCalNumbFixLength);
               Assert.IsNotNull(ModelsRes.BoxModelCalNumbFixWidth);
        }
    }
}
