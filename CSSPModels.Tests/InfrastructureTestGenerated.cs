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
    public partial class InfrastructureTest : SetupData
    {
        [TestMethod]
        public void Infrastructure_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "InfrastructureID", "InfrastructureTVItemID", "PrismID", "TPID", "LSID", "SiteID", "Site", "InfrastructureCategory", "InfrastructureType", "FacilityType", "IsMechanicallyAerated", "NumberOfCells", "NumberOfAeratedCells", "AerationType", "PreliminaryTreatmentType", "PrimaryTreatmentType", "SecondaryTreatmentType", "TertiaryTreatmentType", "TreatmentType", "DisinfectionType", "CollectionSystemType", "AlarmSystemType", "DesignFlow_m3_day", "AverageFlow_m3_day", "PeakFlow_m3_day", "PopServed", "CanOverflow", "PercFlowOfTotal", "TimeOffset_hour", "TempCatchAllRemoveLater", "AverageDepth_m", "NumberOfPorts", "PortDiameter_m", "PortSpacing_m", "PortElevation_m", "VerticalAngle_deg", "HorizontalAngle_deg", "DecayRate_per_day", "NearFieldVelocity_m_s", "FarFieldVelocity_m_s", "ReceivingWaterSalinity_PSU", "ReceivingWaterTemperature_C", "ReceivingWater_MPN_per_100ml", "DistanceFromShore_m", "SeeOtherTVItemID", "CivicAddressTVItemID", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(CSSPModels.Infrastructure).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(Infrastructure).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void Infrastructure_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() { "InfrastructureTVItem",  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() { "InfrastructureLanguages",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(Infrastructure).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(Infrastructure).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void Infrastructure_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(Infrastructure).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void Infrastructure_Every_Property_Has_A_Resource_OK()
        {
               Assert.IsNotNull(ModelsRes.InfrastructureInfrastructureID);
               Assert.IsNotNull(ModelsRes.InfrastructureInfrastructureTVItemID);
               Assert.IsNotNull(ModelsRes.InfrastructurePrismID);
               Assert.IsNotNull(ModelsRes.InfrastructureTPID);
               Assert.IsNotNull(ModelsRes.InfrastructureLSID);
               Assert.IsNotNull(ModelsRes.InfrastructureSiteID);
               Assert.IsNotNull(ModelsRes.InfrastructureSite);
               Assert.IsNotNull(ModelsRes.InfrastructureInfrastructureCategory);
               Assert.IsNotNull(ModelsRes.InfrastructureInfrastructureType);
               Assert.IsNotNull(ModelsRes.InfrastructureFacilityType);
               Assert.IsNotNull(ModelsRes.InfrastructureIsMechanicallyAerated);
               Assert.IsNotNull(ModelsRes.InfrastructureNumberOfCells);
               Assert.IsNotNull(ModelsRes.InfrastructureNumberOfAeratedCells);
               Assert.IsNotNull(ModelsRes.InfrastructureAerationType);
               Assert.IsNotNull(ModelsRes.InfrastructurePreliminaryTreatmentType);
               Assert.IsNotNull(ModelsRes.InfrastructurePrimaryTreatmentType);
               Assert.IsNotNull(ModelsRes.InfrastructureSecondaryTreatmentType);
               Assert.IsNotNull(ModelsRes.InfrastructureTertiaryTreatmentType);
               Assert.IsNotNull(ModelsRes.InfrastructureTreatmentType);
               Assert.IsNotNull(ModelsRes.InfrastructureDisinfectionType);
               Assert.IsNotNull(ModelsRes.InfrastructureCollectionSystemType);
               Assert.IsNotNull(ModelsRes.InfrastructureAlarmSystemType);
               Assert.IsNotNull(ModelsRes.InfrastructureDesignFlow_m3_day);
               Assert.IsNotNull(ModelsRes.InfrastructureAverageFlow_m3_day);
               Assert.IsNotNull(ModelsRes.InfrastructurePeakFlow_m3_day);
               Assert.IsNotNull(ModelsRes.InfrastructurePopServed);
               Assert.IsNotNull(ModelsRes.InfrastructureCanOverflow);
               Assert.IsNotNull(ModelsRes.InfrastructurePercFlowOfTotal);
               Assert.IsNotNull(ModelsRes.InfrastructureTimeOffset_hour);
               Assert.IsNotNull(ModelsRes.InfrastructureTempCatchAllRemoveLater);
               Assert.IsNotNull(ModelsRes.InfrastructureAverageDepth_m);
               Assert.IsNotNull(ModelsRes.InfrastructureNumberOfPorts);
               Assert.IsNotNull(ModelsRes.InfrastructurePortDiameter_m);
               Assert.IsNotNull(ModelsRes.InfrastructurePortSpacing_m);
               Assert.IsNotNull(ModelsRes.InfrastructurePortElevation_m);
               Assert.IsNotNull(ModelsRes.InfrastructureVerticalAngle_deg);
               Assert.IsNotNull(ModelsRes.InfrastructureHorizontalAngle_deg);
               Assert.IsNotNull(ModelsRes.InfrastructureDecayRate_per_day);
               Assert.IsNotNull(ModelsRes.InfrastructureNearFieldVelocity_m_s);
               Assert.IsNotNull(ModelsRes.InfrastructureFarFieldVelocity_m_s);
               Assert.IsNotNull(ModelsRes.InfrastructureReceivingWaterSalinity_PSU);
               Assert.IsNotNull(ModelsRes.InfrastructureReceivingWaterTemperature_C);
               Assert.IsNotNull(ModelsRes.InfrastructureReceivingWater_MPN_per_100ml);
               Assert.IsNotNull(ModelsRes.InfrastructureDistanceFromShore_m);
               Assert.IsNotNull(ModelsRes.InfrastructureSeeOtherTVItemID);
               Assert.IsNotNull(ModelsRes.InfrastructureCivicAddressTVItemID);
               Assert.IsNotNull(ModelsRes.InfrastructureLastUpdateDate_UTC);
               Assert.IsNotNull(ModelsRes.InfrastructureLastUpdateContactTVItemID);
               Assert.IsNotNull(ModelsRes.InfrastructureInfrastructureLanguages);
               Assert.IsNotNull(ModelsRes.InfrastructureInfrastructureTVItem);
        }
        [TestMethod]
        public void Infrastructure_Every_Property_Has_Get_Set_Test()
        {
               int val1 = 45;
               infrastructure.InfrastructureID = val1;
               Assert.AreEqual(val1, infrastructure.InfrastructureID);
               int val2 = 45;
               infrastructure.InfrastructureTVItemID = val2;
               Assert.AreEqual(val2, infrastructure.InfrastructureTVItemID);
               int val3 = 45;
               infrastructure.PrismID = val3;
               Assert.AreEqual(val3, infrastructure.PrismID);
               int val4 = 45;
               infrastructure.TPID = val4;
               Assert.AreEqual(val4, infrastructure.TPID);
               int val5 = 45;
               infrastructure.LSID = val5;
               Assert.AreEqual(val5, infrastructure.LSID);
               int val6 = 45;
               infrastructure.SiteID = val6;
               Assert.AreEqual(val6, infrastructure.SiteID);
               int val7 = 45;
               infrastructure.Site = val7;
               Assert.AreEqual(val7, infrastructure.Site);
               string val8 = "Some text";
               infrastructure.InfrastructureCategory = val8;
               Assert.AreEqual(val8, infrastructure.InfrastructureCategory);
               InfrastructureTypeEnum val9 = (InfrastructureTypeEnum)3;
               infrastructure.InfrastructureType = val9;
               Assert.AreEqual(val9, infrastructure.InfrastructureType);
               FacilityTypeEnum val10 = (FacilityTypeEnum)3;
               infrastructure.FacilityType = val10;
               Assert.AreEqual(val10, infrastructure.FacilityType);
               bool val11 = true;
               infrastructure.IsMechanicallyAerated = val11;
               Assert.AreEqual(val11, infrastructure.IsMechanicallyAerated);
               int val12 = 45;
               infrastructure.NumberOfCells = val12;
               Assert.AreEqual(val12, infrastructure.NumberOfCells);
               int val13 = 45;
               infrastructure.NumberOfAeratedCells = val13;
               Assert.AreEqual(val13, infrastructure.NumberOfAeratedCells);
               AerationTypeEnum val14 = (AerationTypeEnum)3;
               infrastructure.AerationType = val14;
               Assert.AreEqual(val14, infrastructure.AerationType);
               PreliminaryTreatmentTypeEnum val15 = (PreliminaryTreatmentTypeEnum)3;
               infrastructure.PreliminaryTreatmentType = val15;
               Assert.AreEqual(val15, infrastructure.PreliminaryTreatmentType);
               PrimaryTreatmentTypeEnum val16 = (PrimaryTreatmentTypeEnum)3;
               infrastructure.PrimaryTreatmentType = val16;
               Assert.AreEqual(val16, infrastructure.PrimaryTreatmentType);
               SecondaryTreatmentTypeEnum val17 = (SecondaryTreatmentTypeEnum)3;
               infrastructure.SecondaryTreatmentType = val17;
               Assert.AreEqual(val17, infrastructure.SecondaryTreatmentType);
               TertiaryTreatmentTypeEnum val18 = (TertiaryTreatmentTypeEnum)3;
               infrastructure.TertiaryTreatmentType = val18;
               Assert.AreEqual(val18, infrastructure.TertiaryTreatmentType);
               TreatmentTypeEnum val19 = (TreatmentTypeEnum)3;
               infrastructure.TreatmentType = val19;
               Assert.AreEqual(val19, infrastructure.TreatmentType);
               DisinfectionTypeEnum val20 = (DisinfectionTypeEnum)3;
               infrastructure.DisinfectionType = val20;
               Assert.AreEqual(val20, infrastructure.DisinfectionType);
               CollectionSystemTypeEnum val21 = (CollectionSystemTypeEnum)3;
               infrastructure.CollectionSystemType = val21;
               Assert.AreEqual(val21, infrastructure.CollectionSystemType);
               AlarmSystemTypeEnum val22 = (AlarmSystemTypeEnum)3;
               infrastructure.AlarmSystemType = val22;
               Assert.AreEqual(val22, infrastructure.AlarmSystemType);
               double val23 = 87.9D;
               infrastructure.DesignFlow_m3_day = val23;
               Assert.AreEqual(val23, infrastructure.DesignFlow_m3_day);
               double val24 = 87.9D;
               infrastructure.AverageFlow_m3_day = val24;
               Assert.AreEqual(val24, infrastructure.AverageFlow_m3_day);
               double val25 = 87.9D;
               infrastructure.PeakFlow_m3_day = val25;
               Assert.AreEqual(val25, infrastructure.PeakFlow_m3_day);
               int val26 = 45;
               infrastructure.PopServed = val26;
               Assert.AreEqual(val26, infrastructure.PopServed);
               bool val27 = true;
               infrastructure.CanOverflow = val27;
               Assert.AreEqual(val27, infrastructure.CanOverflow);
               double val28 = 87.9D;
               infrastructure.PercFlowOfTotal = val28;
               Assert.AreEqual(val28, infrastructure.PercFlowOfTotal);
               double val29 = 87.9D;
               infrastructure.TimeOffset_hour = val29;
               Assert.AreEqual(val29, infrastructure.TimeOffset_hour);
               string val30 = "Some text";
               infrastructure.TempCatchAllRemoveLater = val30;
               Assert.AreEqual(val30, infrastructure.TempCatchAllRemoveLater);
               double val31 = 87.9D;
               infrastructure.AverageDepth_m = val31;
               Assert.AreEqual(val31, infrastructure.AverageDepth_m);
               int val32 = 45;
               infrastructure.NumberOfPorts = val32;
               Assert.AreEqual(val32, infrastructure.NumberOfPorts);
               double val33 = 87.9D;
               infrastructure.PortDiameter_m = val33;
               Assert.AreEqual(val33, infrastructure.PortDiameter_m);
               double val34 = 87.9D;
               infrastructure.PortSpacing_m = val34;
               Assert.AreEqual(val34, infrastructure.PortSpacing_m);
               double val35 = 87.9D;
               infrastructure.PortElevation_m = val35;
               Assert.AreEqual(val35, infrastructure.PortElevation_m);
               double val36 = 87.9D;
               infrastructure.VerticalAngle_deg = val36;
               Assert.AreEqual(val36, infrastructure.VerticalAngle_deg);
               double val37 = 87.9D;
               infrastructure.HorizontalAngle_deg = val37;
               Assert.AreEqual(val37, infrastructure.HorizontalAngle_deg);
               double val38 = 87.9D;
               infrastructure.DecayRate_per_day = val38;
               Assert.AreEqual(val38, infrastructure.DecayRate_per_day);
               double val39 = 87.9D;
               infrastructure.NearFieldVelocity_m_s = val39;
               Assert.AreEqual(val39, infrastructure.NearFieldVelocity_m_s);
               double val40 = 87.9D;
               infrastructure.FarFieldVelocity_m_s = val40;
               Assert.AreEqual(val40, infrastructure.FarFieldVelocity_m_s);
               double val41 = 87.9D;
               infrastructure.ReceivingWaterSalinity_PSU = val41;
               Assert.AreEqual(val41, infrastructure.ReceivingWaterSalinity_PSU);
               double val42 = 87.9D;
               infrastructure.ReceivingWaterTemperature_C = val42;
               Assert.AreEqual(val42, infrastructure.ReceivingWaterTemperature_C);
               int val43 = 45;
               infrastructure.ReceivingWater_MPN_per_100ml = val43;
               Assert.AreEqual(val43, infrastructure.ReceivingWater_MPN_per_100ml);
               double val44 = 87.9D;
               infrastructure.DistanceFromShore_m = val44;
               Assert.AreEqual(val44, infrastructure.DistanceFromShore_m);
               int val45 = 45;
               infrastructure.SeeOtherTVItemID = val45;
               Assert.AreEqual(val45, infrastructure.SeeOtherTVItemID);
               int val46 = 45;
               infrastructure.CivicAddressTVItemID = val46;
               Assert.AreEqual(val46, infrastructure.CivicAddressTVItemID);
               DateTime val47 = new DateTime(2010, 3, 4);
               infrastructure.LastUpdateDate_UTC = val47;
               Assert.AreEqual(val47, infrastructure.LastUpdateDate_UTC);
               int val48 = 45;
               infrastructure.LastUpdateContactTVItemID = val48;
               Assert.AreEqual(val48, infrastructure.LastUpdateContactTVItemID);
               ICollection<InfrastructureLanguage> val100 = new List<InfrastructureLanguage>();
               infrastructure.InfrastructureLanguages = val100;
               Assert.AreEqual(val100, infrastructure.InfrastructureLanguages);
               TVItem val101 = new TVItem();
               infrastructure.InfrastructureTVItem = val101;
               Assert.AreEqual(val101, infrastructure.InfrastructureTVItem);
               IEnumerable<ValidationResult> val153 = new List<ValidationResult>().AsEnumerable();
               infrastructure.ValidationResults = val153;
               Assert.AreEqual(val153, infrastructure.ValidationResults);
        }
    }
}
