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
    public partial class MWQMLookupMPNTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private MWQMLookupMPN mWQMLookupMPN { get; set; }
        #endregion Properties

        #region Constructors
        public MWQMLookupMPNTest()
        {
            mWQMLookupMPN = new MWQMLookupMPN();
        }
        #endregion Constructors

        #region Tests Functions public
        [TestMethod]
        public void MWQMLookupMPN_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "MWQMLookupMPNID", "Tubes10", "Tubes1", "Tubes01", "MPN_100ml", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "MWQMLookupMPNWeb", "MWQMLookupMPNReport", "HasErrors",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(CSSPModels.MWQMLookupMPN).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(MWQMLookupMPN).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void MWQMLookupMPN_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(MWQMLookupMPN).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(MWQMLookupMPN).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void MWQMLookupMPN_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(MWQMLookupMPN).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void MWQMLookupMPN_Every_Property_Has_A_Resource_OK()
        {
               Assert.IsNotNull(CSSPModelsRes.MWQMLookupMPNMWQMLookupMPNID);
               Assert.IsNotNull(CSSPModelsRes.MWQMLookupMPNTubes10);
               Assert.IsNotNull(CSSPModelsRes.MWQMLookupMPNTubes1);
               Assert.IsNotNull(CSSPModelsRes.MWQMLookupMPNTubes01);
               Assert.IsNotNull(CSSPModelsRes.MWQMLookupMPNMPN_100ml);
               Assert.IsNotNull(CSSPModelsRes.MWQMLookupMPNLastUpdateDate_UTC);
               Assert.IsNotNull(CSSPModelsRes.MWQMLookupMPNLastUpdateContactTVItemID);
               Assert.IsNotNull(CSSPModelsRes.MWQMLookupMPNHasErrors);
        }
        [TestMethod]
        public void MWQMLookupMPN_Every_Property_Has_Get_Set_Test()
        {
               int val1 = 45;
               mWQMLookupMPN.MWQMLookupMPNID = val1;
               Assert.AreEqual(val1, mWQMLookupMPN.MWQMLookupMPNID);
               int val2 = 45;
               mWQMLookupMPN.Tubes10 = val2;
               Assert.AreEqual(val2, mWQMLookupMPN.Tubes10);
               int val3 = 45;
               mWQMLookupMPN.Tubes1 = val3;
               Assert.AreEqual(val3, mWQMLookupMPN.Tubes1);
               int val4 = 45;
               mWQMLookupMPN.Tubes01 = val4;
               Assert.AreEqual(val4, mWQMLookupMPN.Tubes01);
               int val5 = 45;
               mWQMLookupMPN.MPN_100ml = val5;
               Assert.AreEqual(val5, mWQMLookupMPN.MPN_100ml);
               DateTime val6 = new DateTime(2010, 3, 4);
               mWQMLookupMPN.LastUpdateDate_UTC = val6;
               Assert.AreEqual(val6, mWQMLookupMPN.LastUpdateDate_UTC);
               int val7 = 45;
               mWQMLookupMPN.LastUpdateContactTVItemID = val7;
               Assert.AreEqual(val7, mWQMLookupMPN.LastUpdateContactTVItemID);
               bool val8 = true;
               mWQMLookupMPN.HasErrors = val8;
               Assert.AreEqual(val8, mWQMLookupMPN.HasErrors);
               IEnumerable<ValidationResult> val31 = new List<ValidationResult>().AsEnumerable();
               mWQMLookupMPN.ValidationResults = val31;
               Assert.AreEqual(val31, mWQMLookupMPN.ValidationResults);
        }
        #endregion Tests Functions public
    }
}
