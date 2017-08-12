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
    public partial class DBTableTest : SetupData
    {
        [TestMethod]
        public void DBTable_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "TableName", "Plurial", "HasErrors",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(DBTable).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
            {
                Assert.AreEqual(propertyInfo.Name, propNameList[index]);
                index += 1;
            }

            Assert.AreEqual(propNameList.Count, index);
        }
        [TestMethod]
        public void DBTable_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(DBTable).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void DBTable_Every_Property_Has_A_Resource_OK()
        {
               Assert.IsNotNull(ModelsRes.DBTableTableName);
               Assert.IsNotNull(ModelsRes.DBTablePlurial);
               Assert.IsNotNull(ModelsRes.DBTableHasErrors);
        }
        [TestMethod]
        public void DBTable_Every_Property_Has_Get_Set_Test()
        {
               string val1 = "Some text";
               dBTable.TableName = val1;
               Assert.AreEqual(val1, dBTable.TableName);
               string val2 = "Some text";
               dBTable.Plurial = val2;
               Assert.AreEqual(val2, dBTable.Plurial);
               bool val3 = true;
               dBTable.HasErrors = val3;
               Assert.AreEqual(val3, dBTable.HasErrors);
               IEnumerable<ValidationResult> val12 = new List<ValidationResult>().AsEnumerable();
               dBTable.ValidationResults = val12;
               Assert.AreEqual(val12, dBTable.ValidationResults);
        }
    }
}
