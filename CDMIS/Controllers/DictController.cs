using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Web.Mvc;
using CDMIS.ViewModels;
using CDMIS.Models;
using CDMIS.ServiceReference;
using CDMIS.OtherCs;

namespace CDMIS.Controllers
{
    [UserAuthorize]
    public class DictController : Controller
    {
        //
        // GET: /Dict/
        public static ServicesSoapClient _ServicesSoapClient = new ServicesSoapClient();//WebService

        //字典选择
        public ActionResult Index()
        {
            DictViewModel dict = new DictViewModel();
            return View(dict);
        }

        #region < "YDS" >
        //治疗字典
        public ActionResult Treatment()
        {
            List<AbsType> treatment = new List<AbsType>();
            DataSet info = _ServicesSoapClient.GetTreatment();
            foreach (DataRow row in info.Tables[0].Rows)
            {
                AbsType absinfo = new AbsType();

                absinfo.Type = row[0].ToString();
                absinfo.Code = row[1].ToString();
                absinfo.TypeName = row[2].ToString();
                absinfo.Name = row[3].ToString();
                absinfo.InputCode = row[4].ToString();
                absinfo.SortNo = Convert.ToInt32(row[5]);

                treatment.Add(absinfo);
            }
            return View(treatment);
        }

        //症状字典
        public ActionResult Symptoms()
        {
            List<AbsType> symptoms = new List<AbsType>();
            DataSet info = _ServicesSoapClient.GetSymptoms();
            foreach (DataRow row in info.Tables[0].Rows)
            {
                AbsType absinfo = new AbsType();

                absinfo.Type = row[0].ToString();
                absinfo.Code = row[1].ToString();
                absinfo.TypeName = row[2].ToString();
                absinfo.Name = row[3].ToString();
                absinfo.InputCode = row[4].ToString();
                absinfo.SortNo = Convert.ToInt32(row[5]);

                symptoms.Add(absinfo);
            }
            return View(symptoms);
        }

        //诊断字典
        public ActionResult Diagnosis()
        {
            List<AbsType> diagnosis = new List<AbsType>();
            DataSet info = _ServicesSoapClient.GetDiagnosis();
            foreach (DataRow row in info.Tables[0].Rows)
            {
                AbsType absinfo = new AbsType();

                absinfo.Type = row[0].ToString();
                absinfo.Code = row[1].ToString();
                absinfo.TypeName = row[2].ToString();
                absinfo.Name = row[3].ToString();
                absinfo.InputCode = row[4].ToString();
                absinfo.SortNo = Convert.ToInt32(row[5]);

                diagnosis.Add(absinfo);
            }
            return View(diagnosis);
        }

        //体征字典
        public ActionResult VitalSigns()
        {
            List<AbsType> vitalsigns = new List<AbsType>();
            DataSet info = _ServicesSoapClient.GetVitalSigns();
            foreach (DataRow row in info.Tables[0].Rows)
            {
                AbsType absinfo = new AbsType();

                absinfo.Type = row[0].ToString();
                absinfo.Code = row[1].ToString();
                absinfo.TypeName = row[2].ToString();
                absinfo.Name = row[3].ToString();
                absinfo.InputCode = row[4].ToString();
                absinfo.SortNo = Convert.ToInt32(row[5]);

                vitalsigns.Add(absinfo);
            }
            return View(vitalsigns);
        }

        //检查字典
        public ActionResult ExaminationItem()
        {
            List<AbsType> examinationitem = new List<AbsType>();
            DataSet info = _ServicesSoapClient.GetExaminationItem();
            foreach (DataRow row in info.Tables[0].Rows)
            {
                AbsType absinfo = new AbsType();

                absinfo.Type = row[0].ToString();
                absinfo.Code = row[1].ToString();
                absinfo.TypeName = row[2].ToString();
                absinfo.Name = row[3].ToString();
                absinfo.InputCode = row[4].ToString();
                absinfo.SortNo = Convert.ToInt32(row[5]);

                examinationitem.Add(absinfo);
            }
            return View(examinationitem);
        }

        //检验字典
        public ActionResult LabTestItems()
        {
            List<AbsType> labtestitems = new List<AbsType>();
            DataSet info = _ServicesSoapClient.GetLabTestItems();
            foreach (DataRow row in info.Tables[0].Rows)
            {
                AbsType absinfo = new AbsType();

                absinfo.Type = row[0].ToString();
                absinfo.Code = row[1].ToString();
                absinfo.TypeName = row[2].ToString();
                absinfo.Name = row[3].ToString();
                absinfo.InputCode = row[4].ToString();
                absinfo.SortNo = Convert.ToInt32(row[5]);

                labtestitems.Add(absinfo);
            }
            return View(labtestitems);
        }

        //类型字典表
        public ActionResult BasicType()
        {
            List<BasicType> basictype = new List<BasicType>();
            DataSet info = _ServicesSoapClient.GetType();
            foreach (DataRow row in info.Tables[0].Rows)
            {
                BasicType basicinfo = new BasicType();

                basicinfo.Category = row[0].ToString();
                basicinfo.Type = Convert.ToInt32(row[1]);
                basicinfo.Name = row[2].ToString();
                basicinfo.SortNo = Convert.ToInt32(row[4]);

                basictype.Add(basicinfo);
            }
            return View(basictype);
        }

        //警戒字典表
        public ActionResult BasicAlert()
        {
            BasicAlertViewModel basicalertview = new BasicAlertViewModel();
            DataSet info = _ServicesSoapClient.GetBasicAlert();
            foreach (DataRow row in info.Tables[0].Rows)
            {
                BasicAlert basicinfo = new BasicAlert();

                basicinfo.AlertItemCode = row[0].ToString();
                basicinfo.AlertItemName = row[1].ToString();
                basicinfo.Min = Convert.ToDecimal(row[2]);
                basicinfo.Max = Convert.ToDecimal(row[3]);
                basicinfo.Units = row[4].ToString();

                basicalertview.BasicAlertList.Add(basicinfo);
            }
            return View(basicalertview);
        }

        //科室字典表
        public ActionResult Division()
        {
            List<Hospital> division = new List<Hospital>();
            DataSet info = _ServicesSoapClient.GetDivision();
            foreach (DataRow row in info.Tables[0].Rows)
            {
                Hospital divisioninfo = new Hospital();

                divisioninfo.Type = Convert.ToInt32(row[0]);
                divisioninfo.Code = row[1].ToString();
                divisioninfo.Name = row[2].ToString();
                divisioninfo.SortNo = Convert.ToInt32(row[3]);
                divisioninfo.StartDate = row[4].ToString();
                divisioninfo.EndDate = row[5].ToString();

                division.Add(divisioninfo);
            }
            return View(division);
        }

        //医院字典表
        public ActionResult Hospital()
        {
            List<Hospital> hospital = new List<Hospital>();
            DataSet info = _ServicesSoapClient.GetHospital();
            foreach (DataRow row in info.Tables[0].Rows)
            {
                Hospital hospitalinfo = new Hospital();

                hospitalinfo.Type = Convert.ToInt32(row[1]);
                hospitalinfo.Code = row[0].ToString();       //数据库调用方法写反了，故此处也交换次序
                hospitalinfo.Name = row[2].ToString();
                hospitalinfo.SortNo = Convert.ToInt32(row[3]);
                hospitalinfo.StartDate = row[4].ToString();
                hospitalinfo.EndDate = row[5].ToString();

                hospital.Add(hospitalinfo);
            }
            return View(hospital);
        }

        //用户信息表
        public ActionResult InfoItemCategory()
        {
            List<InfoItemCategory> infoitemcategory = new List<InfoItemCategory>();
            DataSet info = _ServicesSoapClient.GetInfoItemCategory();
            foreach (DataRow row in info.Tables[0].Rows)
            {
                InfoItemCategory infoitemcategoryinfo = new InfoItemCategory();

                infoitemcategoryinfo.Code = row[0].ToString();
                infoitemcategoryinfo.Name = row[1].ToString();
                infoitemcategoryinfo.SortNo = Convert.ToInt32(row[2]);
                infoitemcategoryinfo.StartDate = row[3].ToString();
                infoitemcategoryinfo.EndDate = row[4].ToString();

                infoitemcategory.Add(infoitemcategoryinfo);
            }
            return View(infoitemcategory);
        }

        //详细信息表
        public ActionResult InfoItem()
        {
            InfoItemViewModel infoitemview = new InfoItemViewModel();
            DataSet info = _ServicesSoapClient.GetInfoItem();
            foreach (DataRow row in info.Tables[0].Rows)
            {
                InfoItem infoiteminfo = new InfoItem();

                infoiteminfo.CategoryCode = row[0].ToString();
                infoiteminfo.Code = row[1].ToString();
                infoiteminfo.Name = row[2].ToString();
                infoiteminfo.ParentCode = row[3].ToString();
                infoiteminfo.SortNo = Convert.ToInt32(row[4]);
                infoiteminfo.ControlCode = row[8].ToString();
                if (infoiteminfo.ControlCode != "")
                {
                    infoiteminfo.ControlType = _ServicesSoapClient.GetMstTypeName("ControlType", Convert.ToInt32(infoiteminfo.ControlCode));
                }
                else
                {
                    infoiteminfo.ControlType = "";
                }
                infoiteminfo.OptionCategory = row[9].ToString();

                infoitemview.InfoItemList.Add(infoiteminfo);
            }
            return View(infoitemview);
        }

        //治疗字典表数据插入
        public JsonResult TreatmentEdit(string Type, string Code, string TypeName, string Name, string InputCode)
        {
            var res = new JsonResult();
            if (Code == "") Code = _ServicesSoapClient.GetTreatmentMaxCode(Type);
            int SortNo = Convert.ToInt32(Code);
            bool flag = _ServicesSoapClient.SetTreatment(Type, Code, TypeName, Name, InputCode, SortNo, "", 0);
            if (flag)
            {
                res.Data = true;
            }
            else
            {
                res.Data = false;
            }
            res.JsonRequestBehavior = JsonRequestBehavior.AllowGet;
            return res;
        }

        //治疗字典表数据删除
        public JsonResult TreatmentDelete(string Type, string Code)
        {
            var res = new JsonResult();
            int flag = _ServicesSoapClient.DeleteTreatment(Type, Code);
            if (flag == 1)
            {
                res.Data = true;
            }
            else
            {
                res.Data = false;
            }
            res.JsonRequestBehavior = JsonRequestBehavior.AllowGet;
            return res;
        }

        //类型字典表数据插入
        public JsonResult BasicTypeEdit(string Category, string Type, string Name)
        {
            var user = Session["CurrentUser"] as UserAndRole;
            var res = new JsonResult();
            if (Type == "")
            {
                Type = _ServicesSoapClient.GetTypeMaxCode(Category);
            }
            int SortNo = Convert.ToInt32(Type);
            bool flag = _ServicesSoapClient.SetType(Category, Convert.ToInt32(Type), Name, 0, SortNo, user.UserId, user.TerminalName, user.TerminalIP, user.DeviceType);
            if (flag)
            {
                res.Data = true;
            }
            else
            {
                res.Data = false;
            }
            res.JsonRequestBehavior = JsonRequestBehavior.AllowGet;
            return res;
        }

        //类型字典表数据删除
        public JsonResult BasicTypeDelete(string Category, int Type)
        {
            var res = new JsonResult();
            int flag = _ServicesSoapClient.DeleteType(Category, Type);
            if (flag == 1)
            {
                res.Data = true;
            }
            else
            {
                res.Data = false;
            }
            res.JsonRequestBehavior = JsonRequestBehavior.AllowGet;
            return res;
        }

        //诊断字典表数据插入
        public JsonResult DiagnosisEdit(string Type, string Code, string TypeName, string Name, string InputCode, string SortNo)
        {
            var res = new JsonResult();
            if (SortNo == "") SortNo = _ServicesSoapClient.GetDiagnosisMaxCode(Type);
            bool flag = _ServicesSoapClient.SetDiagnosis(Type, Code, TypeName, Name, InputCode, Convert.ToInt32(SortNo), "", 0);
            if (flag)
            {
                res.Data = true;
            }
            else
            {
                res.Data = false;
            }
            res.JsonRequestBehavior = JsonRequestBehavior.AllowGet;
            return res;
        }

        //诊断字典表数据删除
        public JsonResult DiagnosisDelete(string Type, string Code)
        {
            var res = new JsonResult();
            int flag = _ServicesSoapClient.DeleteDiagnosis(Type, Code);
            if (flag == 1)
            {
                res.Data = true;
            }
            else
            {
                res.Data = false;
            }
            res.JsonRequestBehavior = JsonRequestBehavior.AllowGet;
            return res;
        }

        //检验字典表数据插入
        public JsonResult LabTestItemsEdit(string Type, string Code, string TypeName, string Name, string InputCode)
        {
            var res = new JsonResult();
            if (Code == "") Code = _ServicesSoapClient.GetLabTestItemsMaxCode(Type);
            int SortNo = Convert.ToInt32(Code.Split(new char[] { '_' })[1]);
            bool flag = _ServicesSoapClient.SetLabTestItems(Type, Code, TypeName, Name, InputCode, SortNo, "", 0);
            if (flag)
            {
                res.Data = true;
            }
            else
            {
                res.Data = false;
            }
            res.JsonRequestBehavior = JsonRequestBehavior.AllowGet;
            return res;
        }

        //检验字典表数据删除
        public JsonResult LabTestItemsDelete(string Type, string Code)
        {
            var res = new JsonResult();
            int flag = _ServicesSoapClient.DeleteLabTestItems(Type, Code);
            if (flag == 1)
            {
                res.Data = true;
            }
            else
            {
                res.Data = false;
            }
            res.JsonRequestBehavior = JsonRequestBehavior.AllowGet;
            return res;
        }

        //检查字典表数据插入
        public JsonResult ExaminationItemEdit(string Type, string Code, string TypeName, string Name, string InputCode)
        {
            var res = new JsonResult();
            if (Code == "") Code = _ServicesSoapClient.GetExaminationItemMaxCode(Type);
            int SortNo = Convert.ToInt32(Code.Split(new char[] { '_' })[1]);
            bool flag = _ServicesSoapClient.SetExaminationItem(Type, Code, TypeName, Name, InputCode, SortNo, "", 0);
            if (flag)
            {
                res.Data = true;
            }
            else
            {
                res.Data = false;
            }
            res.JsonRequestBehavior = JsonRequestBehavior.AllowGet;
            return res;
        }

        //检查字典表数据删除
        public JsonResult ExaminationItemDelete(string Type, string Code)
        {
            var res = new JsonResult();
            int flag = _ServicesSoapClient.DeleteExaminationItem(Type, Code);
            if (flag == 1)
            {
                res.Data = true;
            }
            else
            {
                res.Data = false;
            }
            res.JsonRequestBehavior = JsonRequestBehavior.AllowGet;
            return res;
        }

        //体征字典表数据插入
        public JsonResult VitalSignsEdit(string Type, string Code, string TypeName, string Name, string InputCode)
        {
            var res = new JsonResult();
            if (Code == "") Code = _ServicesSoapClient.GetVitalSignsMaxCode(Type);
            int SortNo = Convert.ToInt32(Code.Split(new char[] { '_' })[1]);
            bool flag = _ServicesSoapClient.SetVitalSigns(Type, Code, TypeName, Name, InputCode, SortNo, "", 0);
            if (flag)
            {
                res.Data = true;
            }
            else
            {
                res.Data = false;
            }
            res.JsonRequestBehavior = JsonRequestBehavior.AllowGet;
            return res;
        }

        //体征字典表数据删除
        public JsonResult VitalSignsDelete(string Type, string Code)
        {
            var res = new JsonResult();
            int flag = _ServicesSoapClient.DeleteVitalSigns(Type, Code);
            if (flag == 1)
            {
                res.Data = true;
            }
            else
            {
                res.Data = false;
            }
            res.JsonRequestBehavior = JsonRequestBehavior.AllowGet;
            return res;
        }

        //症状字典表数据插入
        public JsonResult SymptomsEdit(string Type, string Code, string TypeName, string Name, string InputCode)
        {
            var res = new JsonResult();
            if (Code == "")
            {
                Code = _ServicesSoapClient.GetSymptomsMaxCode(Type);
            }
            int SortNo = Convert.ToInt32(Code);
            bool flag = _ServicesSoapClient.SetSymptoms(Type, Code, TypeName, Name, InputCode, SortNo, "", 0);
            if (flag)
            {
                res.Data = true;
            }
            else
            {
                res.Data = false;
            }
            res.JsonRequestBehavior = JsonRequestBehavior.AllowGet;
            return res;
        }

        //症状字典表数据删除
        public JsonResult SymptomsDelete(string Type, string Code)
        {
            var res = new JsonResult();
            int flag = _ServicesSoapClient.DeleteSymptoms(Type, Code);
            if (flag == 1)
            {
                res.Data = true;
            }
            else
            {
                res.Data = false;
            }
            res.JsonRequestBehavior = JsonRequestBehavior.AllowGet;
            return res;
        }

        //医院字典表数据插入
        public JsonResult HospitalEdit(string Type, string Code, string Name, string SortNo, string StartDate, string EndDate)
        {
            var user = Session["CurrentUser"] as UserAndRole;
            var res = new JsonResult();
            int k;
            if (SortNo == "")
            {
                k = _ServicesSoapClient.GetDivisionMaxCode() + 1;
            }
            else
            {
                k = Convert.ToInt32(SortNo);
            }
            bool flag = _ServicesSoapClient.SetHospital(Code, Convert.ToInt32(Type), Name, k, Convert.ToInt32(StartDate), Convert.ToInt32(EndDate), user.UserId, user.TerminalName, user.TerminalIP, user.DeviceType);
            if (flag)
            {
                res.Data = true;
            }
            else
            {
                res.Data = false;
            }
            res.JsonRequestBehavior = JsonRequestBehavior.AllowGet;
            return res;
        }

        //医院字典表数据删除
        public JsonResult HospitalDelete(string Code)
        {
            var res = new JsonResult();
            int flag = _ServicesSoapClient.DeleteHospital(Code);
            if (flag == 1)
            {
                res.Data = true;
            }
            else
            {
                res.Data = false;
            }
            res.JsonRequestBehavior = JsonRequestBehavior.AllowGet;
            return res;
        }

        //科室字典表数据插入
        public JsonResult DivisionEdit(string Type, string Code, string Name, string SortNo, string StartDate, string EndDate)
        {
            var user = Session["CurrentUser"] as UserAndRole;
            var res = new JsonResult();
            int k;
            if (SortNo == "")
            {
                k = _ServicesSoapClient.GetDivisionMaxCode() + 1;
            }
            else
            {
                k = Convert.ToInt32(SortNo);
            }
            bool flag = _ServicesSoapClient.SetDivision(Convert.ToInt32(Type), Code, "", Name, "", "", user.UserId, user.TerminalName, user.TerminalIP, user.DeviceType);
            if (flag)
            {
                res.Data = true;
            }
            else
            {
                res.Data = false;
            }
            res.JsonRequestBehavior = JsonRequestBehavior.AllowGet;
            return res;
        }

        //科室字典表数据删除
        public JsonResult DivisionDelete(string Type, string Code)
        {
            var res = new JsonResult();
            int flag = _ServicesSoapClient.DeleteDivision(Convert.ToInt32(Type), Code);
            if (flag == 1)
            {
                res.Data = true;
            }
            else
            {
                res.Data = false;
            }
            res.JsonRequestBehavior = JsonRequestBehavior.AllowGet;
            return res;
        }

        //用户信息表数据插入
        public JsonResult InfoItemCategoryEdit(string Code, string Name, string SortNo, string StarDate, string EndDate)
        {
            var user = Session["CurrentUser"] as UserAndRole;
            var res = new JsonResult();
            bool flag = _ServicesSoapClient.SetInfoItemCategory(Code, Name, Convert.ToInt32(SortNo), Convert.ToInt32(StarDate), Convert.ToInt32(EndDate), user.UserId, user.TerminalName, user.TerminalIP, user.DeviceType);
            if (flag)
            {
                res.Data = true;
            }
            else
            {
                res.Data = false;
            }
            res.JsonRequestBehavior = JsonRequestBehavior.AllowGet;
            return res;
        }

        //用户信息表数据删除
        public JsonResult InfoItemCategoryDelete(string Code)
        {
            var res = new JsonResult();
            int flag = _ServicesSoapClient.DeleteInfoItemCategory(Code);
            if (flag == 1)
            {
                res.Data = true;
            }
            else
            {
                res.Data = false;
            }
            res.JsonRequestBehavior = JsonRequestBehavior.AllowGet;
            return res;
        }

        //警戒字典表数据插入
        public JsonResult BasicAlertEdit(string AlertItemCode, string AlertItemName, string Min, string Max, string Units)
        {
            var user = Session["CurrentUser"] as UserAndRole;
            var res = new JsonResult();
            if (Units != "")
            {
                int type = Convert.ToInt32(Units);
                Units = _ServicesSoapClient.GetMstTypeName("CommonUnit", type);
            }
            bool flag = _ServicesSoapClient.SetBasicAlert(AlertItemCode, AlertItemName, Convert.ToDecimal(Min), Convert.ToDecimal(Max), Units, "", user.UserId, user.TerminalName, user.TerminalIP, user.DeviceType);
            if (flag)
            {
                res.Data = true;
            }
            else
            {
                res.Data = false;
            }
            res.JsonRequestBehavior = JsonRequestBehavior.AllowGet;
            return res;
        }

        //警戒字典表数据删除
        public JsonResult BasicAlertDelete(string AlertItemCode)
        {
            var res = new JsonResult();
            int flag = _ServicesSoapClient.DeleteBasicAlert(AlertItemCode);
            if (flag == 1)
            {
                res.Data = true;
            }
            else
            {
                res.Data = false;
            }
            res.JsonRequestBehavior = JsonRequestBehavior.AllowGet;
            return res;
        }

        //详细信息表数据插入
        public JsonResult InfoItemEdit(string CategoryCode, string Code, string Name, string SortNo, string ControlType, string OptionCategory)
        {
            var user = Session["CurrentUser"] as UserAndRole;
            var res = new JsonResult();
            bool flag = false;
            if (ControlType == "0")
            {
                string ParentCode = "";
                flag = _ServicesSoapClient.SetInfoItem(CategoryCode, Code, Name, ParentCode, Convert.ToInt32(SortNo), 0, 99999999, 1, "", "", user.UserId, user.TerminalName, user.TerminalIP, user.DeviceType);
            }
            else
            {
                string ParentCode = Code.Split(new char[] { '_' })[0];
                if (SortNo == "")
                {
                    SortNo = Code.Split(new char[] { '_' })[1];
                }
                flag = _ServicesSoapClient.SetInfoItem(CategoryCode, Code, Name, ParentCode, Convert.ToInt32(SortNo), 0, 99999999, 0, ControlType, OptionCategory, user.UserId, user.TerminalName, user.TerminalIP, user.DeviceType);
            }
            if (flag)
            {
                res.Data = true;
            }
            else
            {
                res.Data = false;
            }
            res.JsonRequestBehavior = JsonRequestBehavior.AllowGet;
            return res;
        }

        //详细信息表数据删除
        public JsonResult InfoItemDelete(string CategoryCode, string Code)
        {
            var res = new JsonResult();
            int flag = _ServicesSoapClient.DeleteInfoItem(CategoryCode, Code);
            if (flag == 1)
            {
                res.Data = true;
            }
            else
            {
                res.Data = false;
            }
            res.JsonRequestBehavior = JsonRequestBehavior.AllowGet;
            return res;
        }

        //详细信息表根据CategoryCode动态加载Code下拉框
        public JsonResult GetListbyCategory(string CategoryCode)
        {
            var res = new JsonResult();
            DataSet info = _ServicesSoapClient.GetNextCode(CategoryCode);
            List<string> codelist = new List<string>();
            foreach (DataRow row in info.Tables[0].Rows)
            {
                string rowinfo = row[0].ToString();
                codelist.Add(rowinfo);
            }
            res.Data = codelist;
            res.JsonRequestBehavior = JsonRequestBehavior.AllowGet;
            return res;
        }
        #endregion

        #region < "GL" >
        //血压字典获取信息
        public ActionResult MstBloodPressure()
        {
            List<BloodPressure> items = new List<BloodPressure>();
            DataSet ds = _ServicesSoapClient.GetBloodPressureList();
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                BloodPressure item = new BloodPressure();
                item.Code = row[0].ToString();
                item.Name = row[1].ToString();
                item.Description = row[2].ToString();
                item.SBP = Convert.ToInt32(row[3]);
                item.DBP = Convert.ToInt32(row[4]);
                item.PatientClass = row[5].ToString();
                item.Redundance = row[6].ToString();

                items.Add(item);
            }
            return View(items);
        }

        //血压字典数据插入
        public JsonResult BloodPressureEdit(string Code, string Name, string Description, int SBP, int DBP, string PatientClass, string Redundance)
        {
            var res = new JsonResult();
            var flag = 0;
            flag = _ServicesSoapClient.SetBloodPressure(Code, Name, Description, SBP, DBP, PatientClass, "");
            var ret = false;
            if (flag == 1)
            {
                ret = true;
            }
            res.Data = ret;
            res.JsonRequestBehavior = JsonRequestBehavior.AllowGet;
            return res;
        }
        //血压字典数据删除

        public JsonResult BloodPressureDelete(string Code)
        {
            var res = new JsonResult();
            var flag = 0;
            flag = _ServicesSoapClient.DeleteBloodPressure(Code);
            var ret = false;
            if (flag == 1)
            {
                ret = true;
            }
            res.Data = ret;
            res.JsonRequestBehavior = JsonRequestBehavior.AllowGet;
            return res;
        }

        //健康教育字典
        public ActionResult MstHealthEducation()
        {
            List<MstHealthEducation> items = new List<MstHealthEducation>();
            DataSet ds = _ServicesSoapClient.GetHealthEducationList();
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                MstHealthEducation item = new MstHealthEducation();
                item.Module = row[0].ToString();
                item.HealthId = row[1].ToString();
                item.Type = Convert.ToInt32(row[2]);
                item.FileName = row[3].ToString();
                item.Path = row[4].ToString();
                item.Introduction = row[5].ToString();
                item.Redundance = row[6].ToString();

                items.Add(item);
            }
            return View(items);
        }

        //健康教育字典数据插入
        public JsonResult HealthEducationEdit(string Module, string HealthId, int Type, string FileName, string Path, string Introduction)
        {
            var res = new JsonResult();
            var user = Session["CurrentUser"] as UserAndRole;
            var flag = false;
            flag = _ServicesSoapClient.SetHealthEducation(Module, HealthId, Type, FileName, Path, Introduction, "", user.UserId, user.TerminalName, user.TerminalIP, user.DeviceType);
            res.Data = flag;
            res.JsonRequestBehavior = JsonRequestBehavior.AllowGet;
            return res;
        }
        //健康教育字典数据删除
        public JsonResult HealthEducationDelete(string Module, string HealthId)
        {
            var res = new JsonResult();
            var flag = 0;
            flag = _ServicesSoapClient.DeleteHealthEducationInfo(Module, HealthId);
            var ret = false;
            if (flag == 1)
            {
                ret = true;
            }
            res.Data = ret;
            res.JsonRequestBehavior = JsonRequestBehavior.AllowGet;
            return res;
        }

        //生活方式字典
        public ActionResult MstLifeStyle()
        {
            List<LifeStyle> items = new List<LifeStyle>();
            DataSet ds = _ServicesSoapClient.GetLifeStyleList();
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                LifeStyle item = new LifeStyle();
                item.StyleId = row[0].ToString();
                item.Name = row[1].ToString();
                item.Redundance = row[2].ToString();

                items.Add(item);
            }
            return View(items);
        }

        //生活方式字典数据插入
        public JsonResult LifeStyleEdit(string StyleId, string Name)
        {
            var res = new JsonResult();
            var flag = false;
            flag = _ServicesSoapClient.SetLifeStyle(StyleId, Name, "");
            res.Data = flag;
            res.JsonRequestBehavior = JsonRequestBehavior.AllowGet;
            return res;
        }

        //生活方式字典数据删除
        public JsonResult LifeStyleDelete(string StyleId)
        {
            var res = new JsonResult();
            var flag = 0;
            flag = _ServicesSoapClient.DeleteLifeStyle(StyleId);
            var ret = false;
            if (flag == 1)
            {
                ret = true;
            }
            res.Data = ret;
            res.JsonRequestBehavior = JsonRequestBehavior.AllowGet;
            return res;
        }

        //生活方式详细字典
        // //StyleId, Module, CurativeEffect, SideEffect, Instruction, HealthEffect, Unit, Redundance
        public ActionResult MstLifeStyleDetail()
        {
            List<LifeStyleDetail> items = new List<LifeStyleDetail>();
            DataSet ds = _ServicesSoapClient.GetLifeStyleDetailList();
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                LifeStyleDetail item = new LifeStyleDetail();
                item.StyleId = row[0].ToString();
                item.Module = row[1].ToString();
                item.CurativeEffect = row[2].ToString();
                item.SideEffect = row[3].ToString();
                item.Instruction = row[4].ToString();
                item.HealthEffect = row[5].ToString();
                item.Unit = row[6].ToString();
                item.Redundance = row[7].ToString();

                items.Add(item);
            }
            return View(items);
        }

        //生活方式详细字典数据插入
        public JsonResult LifeStyleDetailEdit(string StyleId, string Module, string CurativeEffect, string SideEffect, string Instruction, string HealthEffect, string Unit)
        {
            var res = new JsonResult();
            var flag = false;
            flag = _ServicesSoapClient.SetLifeStyleDetail(StyleId, Module, CurativeEffect, SideEffect, Instruction, HealthEffect, Unit, "");
            res.Data = flag;
            res.JsonRequestBehavior = JsonRequestBehavior.AllowGet;
            return res;
        }

        //生活方式详细字典数据删除
        public JsonResult LifeStyleDetailDelete(string StyleId, string Module)
        {
            var res = new JsonResult();
            var flag = 0;
            flag = _ServicesSoapClient.DeleteLifeStyleDetail(StyleId, Module);
            var ret = false;
            if (flag == 1)
            {
                ret = true;
            }
            res.Data = ret;
            res.JsonRequestBehavior = JsonRequestBehavior.AllowGet;
            return res;
        }
        #endregion
    }
}

