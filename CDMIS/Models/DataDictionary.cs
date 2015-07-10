using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CDMIS.Models
{
    public class DataDictionary
    {
    }

    #region <字典表 袁冬生 2014.12.10>
    public class AbsType
    {
        public string Type { get; set; }
        public string Code { get; set; }
        public string TypeName { get; set; }
        public string Name { get; set; }
        public string InputCode { get; set; }
        public int SortNo { get; set; }
        public string Redundance { get; set; }
        public int InvalidFlag { get; set; }
    }

    public class BasicType
    {
        public string Category { get; set; }
        public int Type { get; set; }
        public string Name { get; set; }
        public int InvalidFlag { get; set; }
        public int SortNo { get; set; }
    }

    //public class Hospital
    //{
    //    public int Type { get; set; }
    //    public string Code { get; set; }
    //    public string Name { get; set; }
    //    public int SortNo { get; set; }
    //    public string StartDate { get; set; }
    //    public string EndDate { get; set; }
    //}


    public class Hospital
    {
        public int Type { get; set; }
        public string Code { get; set; }
        public string TypeName { get; set; }
        public string Name { get; set; }
        public string InputCode { get; set; }
        public string Description { get; set; }
    }

    public class TmpDivisionDict
    {
        public string HospitalCode { get; set; }
        public string HospitalName { get; set; }
        public string Type { get; set; }
        public string Code { get; set; }
        public string TypeName { get; set; }
        public string Name { get; set; }
        public string InputCode { get; set; }
        public string Description { get; set; }
        public int Status { get; set; }

    }

    public class MpDivisionCmp
    {
        public string HospitalCode { get; set; }
        public string HospitalName { get; set; }
        public int Type { get; set; }
        public string TypeName { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string HZCode { get; set; }
        public string HZName { get; set; }
        public string Redundance { get; set; }

    }

    public class InfoItemCategory
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public int SortNo { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
    }

    public class InfoItem
    {
        public string CategoryCode { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }             //项目名称
        public string ParentCode { get; set; }
        public int SortNo { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public int GroupHeaderFlag { get; set; }
        public string ControlCode { get; set; }
        public string ControlType { get; set; }
        public string OptionCategory { get; set; }
        public List<SelectListItem> OptionList { get; set; }  //选项下拉框

    }

    public class SubItem
    {
        public string Code { get; set; }
        public string SubCode { get; set; }
        public string Name { get; set; }
        public int SortNo { get; set; }
        public string Redundance { get; set; }
        public int InvalidFlag { get; set; }
    }

    public class BasicAlert
    {
        public string AlertItemCode { get; set; }
        public string AlertItemName { get; set; }
        public decimal Min { get; set; }
        public decimal Max { get; set; }
        public string Units { get; set; }
        public string Remarks { get; set; }
    }

    public class BloodPressure  //2015-05-29 GL
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int SBP { get; set; }
        public int DBP { get; set; }
        public string PatientClass { get; set; }
        public string Redundance { get; set; }
    }

    public class MstHealthEducation //2015-05-29 GL
    {
        public string Module { get; set; }
        public string HealthId { get; set; }
        public int Type { get; set; }
        public string FileName { get; set; }
        public string Path { get; set; }
        public string Introduction { get; set; }
        public string Redundance { get; set; }
    }

    public class LifeStyle //2015-05-29 GL
    {
        public string StyleId { get; set; }
        public string Name { get; set; }
        public string Redundance { get; set; }
    }

    public class LifeStyleDetail //2015-05-29 GL
    {
        public string StyleId { get; set; }
        public string Module { get; set; }
        public string CurativeEffect { get; set; }
        public string SideEffect { get; set; }
        public string Instruction { get; set; }
        public string HealthEffect { get; set; }
        public string Unit { get; set; }
        public string Redundance { get; set; }

    }
    #endregion

}