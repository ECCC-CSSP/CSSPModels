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
    public partial class TideLocationTest : SetupData
    {
        [TestMethod]
        public void TideLocation_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "TideLocationID", "Zone", "Name", "Prov", "sid", "Lat", "Lng",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "HasErrors",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(CSSPModels.TideLocation).GetProperties().OrderBy(c => c.Name))
            {
                if (!propertyInfo.GetGetMethod().IsVirtual
                    && propertyInfo.Name != "ValidationResults"
                    && !propertyInfo.CustomAttributes.Where(c => c.AttributeType.Name.Contains("NotMappedAttribute")).Any())
                {
                    Assert.AreEqual(propNameList[index], propertyInfo.Name);
                    index += 1;
                }
            }

            Assert.AreEqual(propNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(TideLocation).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
            {
                foreach (CustomAttributeData customAttributeData in propertyInfo.CustomAttributes)
                {
                    if (customAttributeData.AttributeType.Name == "NotMappedAttribute")
                    {
                        Assert.AreEqual(propertyInfo.Name, propNameNotMappedList[index]);
                        index += 1;
                    }
                }
            }

            Assert.AreEqual(propNameNotMappedList.Count, index);

        }
        [TestMethod]
        public void TideLocation_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(TideLocation).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(TideLocation).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
            {
                if (propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameCollectionList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameCollectionList.Count, index);

        }
        [TestMethod]
        public void TideLocation_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(TideLocation).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void TideLocation_Every_Property_Has_A_Resource_OK()
        {
               Assert.IsNotNull(ModelsRes.TideLocationTideLocationID);
               Assert.IsNotNull(ModelsRes.TideLocationZone);
               Assert.IsNotNull(ModelsRes.TideLocationName);
               Assert.IsNotNull(ModelsRes.TideLocationProv);
               Assert.IsNotNull(ModelsRes.TideLocationsid);
               Assert.IsNotNull(ModelsRes.TideLocationLat);
               Assert.IsNotNull(ModelsRes.TideLocationLng);
               Assert.IsNotNull(ModelsRes.TideLocationHasErrors);
        }
        [TestMethod]
        public void TideLocation_Every_Property_Has_Get_Set_Test()
        {
               int val1 = 45;
               tideLocation.TideLocationID = val1;
               Assert.AreEqual(val1, tideLocation.TideLocationID);
               int val2 = 45;
               tideLocation.Zone = val2;
               Assert.AreEqual(val2, tideLocation.Zone);
               string val3 = "Some text";
               tideLocation.Name = val3;
               Assert.AreEqual(val3, tideLocation.Name);
               string val4 = "Some text";
               tideLocation.Prov = val4;
               Assert.AreEqual(val4, tideLocation.Prov);
               int val5 = 45;
               tideLocation.sid = val5;
               Assert.AreEqual(val5, tideLocation.sid);
               double val6 = 87.9D;
               tideLocation.Lat = val6;
               Assert.AreEqual(val6, tideLocation.Lat);
               double val7 = 87.9D;
               tideLocation.Lng = val7;
               Assert.AreEqual(val7, tideLocation.Lng);
               bool val8 = true;
               tideLocation.HasErrors = val8;
               Assert.AreEqual(val8, tideLocation.HasErrors);
               IEnumerable<ValidationResult> val27 = new List<ValidationResult>().AsEnumerable();
               tideLocation.ValidationResults = val27;
               Assert.AreEqual(val27, tideLocation.ValidationResults);
        }
    }
}
