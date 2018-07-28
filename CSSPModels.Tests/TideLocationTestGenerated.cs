/*
 * Auto generated from the CSSPCodeWriter.proj by clicking on the [[ModelClassName]TestGenerated.cs] button
 *
 * Do not edit this file.
 *
 * Last generated on 2018 July 28 01:58
 * by Charles on CHARLES-PC machine
 *
 */ 
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
    [TestClass]
    public partial class TideLocationTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private TideLocation tideLocation { get; set; }
        #endregion Properties

        #region Constructors
        public TideLocationTest()
        {
            tideLocation = new TideLocation();
        }
        #endregion Constructors

        #region Tests Functions public
        [TestMethod]
        public void TideLocation_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "TideLocationID", "Zone", "Name", "Prov", "sid", "Lat", "Lng", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "TideLocationWeb", "TideLocationReport", "HasErrors",  }.OrderBy(c => c).ToList();

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
               Assert.IsNotNull(CSSPModelsRes.TideLocationTideLocationID);
               Assert.IsNotNull(CSSPModelsRes.TideLocationZone);
               Assert.IsNotNull(CSSPModelsRes.TideLocationName);
               Assert.IsNotNull(CSSPModelsRes.TideLocationProv);
               Assert.IsNotNull(CSSPModelsRes.TideLocationsid);
               Assert.IsNotNull(CSSPModelsRes.TideLocationLat);
               Assert.IsNotNull(CSSPModelsRes.TideLocationLng);
               Assert.IsNotNull(CSSPModelsRes.TideLocationLastUpdateDate_UTC);
               Assert.IsNotNull(CSSPModelsRes.TideLocationLastUpdateContactTVItemID);
               Assert.IsNotNull(CSSPModelsRes.TideLocationHasErrors);
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
               DateTime val8 = new DateTime(2010, 3, 4);
               tideLocation.LastUpdateDate_UTC = val8;
               Assert.AreEqual(val8, tideLocation.LastUpdateDate_UTC);
               int val9 = 45;
               tideLocation.LastUpdateContactTVItemID = val9;
               Assert.AreEqual(val9, tideLocation.LastUpdateContactTVItemID);
               bool val10 = true;
               tideLocation.HasErrors = val10;
               Assert.AreEqual(val10, tideLocation.HasErrors);
               IEnumerable<ValidationResult> val37 = new List<ValidationResult>().AsEnumerable();
               tideLocation.ValidationResults = val37;
               Assert.AreEqual(val37, tideLocation.ValidationResults);
        }
        #endregion Tests Functions public
    }
}
