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
    public partial class CoordTest : SetupData
    {
        [TestMethod]
        public void Coord_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "Lat", "Lng", "Ordinal", "HasErrors",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(Coord).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
            {
                Assert.AreEqual(propertyInfo.Name, propNameList[index]);
                index += 1;
            }

            Assert.AreEqual(propNameList.Count, index);
        }
        [TestMethod]
        public void Coord_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(Coord).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void Coord_Every_Property_Has_A_Resource_OK()
        {
               Assert.IsNotNull(ModelsRes.CoordLat);
               Assert.IsNotNull(ModelsRes.CoordLng);
               Assert.IsNotNull(ModelsRes.CoordOrdinal);
               Assert.IsNotNull(ModelsRes.CoordHasErrors);
        }
        [TestMethod]
        public void Coord_Every_Property_Has_Get_Set_Test()
        {
               double val1 = 87.9D;
               coord.Lat = val1;
               Assert.AreEqual(val1, coord.Lat);
               double val2 = 87.9D;
               coord.Lng = val2;
               Assert.AreEqual(val2, coord.Lng);
               int val3 = 45;
               coord.Ordinal = val3;
               Assert.AreEqual(val3, coord.Ordinal);
               bool val4 = true;
               coord.HasErrors = val4;
               Assert.AreEqual(val4, coord.HasErrors);
               IEnumerable<ValidationResult> val15 = new List<ValidationResult>().AsEnumerable();
               coord.ValidationResults = val15;
               Assert.AreEqual(val15, coord.ValidationResults);
        }
    }
}
