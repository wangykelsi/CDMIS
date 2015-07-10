using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CDMIS.Models;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace CDMIS.ViewModels
{
    public class Dictionary
    {
    }

    //字典维护界面 YDS 2014-12-09
    public class DictViewModel
    {
        public List<SelectListItem> DictList()
        {
            return CommonVariables.GetDictList();
        }
        public string DictSelected { get; set; }
    }

    //患者详细信息项目表 YDS 2014-12-09
    public class InfoItemViewModel
    {
        public List<InfoItem> InfoItemList { get; set; }  //列表

        public List<SelectListItem> ControlTypeList()
        {
            return CommonVariables.GetControlTypeList();
        }
        public string ControlTypeSelected { get; set; }

        public List<SelectListItem> OptionCategoryList()
        {
            return CommonVariables.GetOptionCategoryList();
        }
        public string OptionCategorySelected { get; set; }

        public List<SelectListItem> CategoryCodeList()
        {
            return CommonVariables.GetCategoryCodeList();
        }
        public string CategoryCodeSelected { get; set; }

        public InfoItemViewModel()
        {
            InfoItemList = new List<InfoItem>();
        }
    }

    //警戒字典表 YDS 2014-01-13
    public class BasicAlertViewModel
    {
        public List<BasicAlert> BasicAlertList { get; set; }  //列表

        public List<SelectListItem> UnitList()
        {
            return CommonVariables.GetAllUnit();
        }
        public string UnitSelected { get; set; }

        public BasicAlertViewModel()
        {
            BasicAlertList = new List<BasicAlert>();
        }
    }

    //未匹配科室字典表 WF 2015-07-07
    public class UnCompDivisionViewModel
    {
        public List<TmpDivisionDict> TmpDivision{ get; set; } 
        public List<SelectListItem> DivisionList()
        {
            return CommonVariables.GetDivisionList();
        }
        public string DivisionSelected { get; set; }

        public UnCompDivisionViewModel()
        {
            TmpDivision = new List<TmpDivisionDict>();
        }
    }

}