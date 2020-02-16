using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeKeeping.Data.Interface;
using TimeKeeping.Models;

namespace TimeKeeping.Data
{
    public class EmployeeRepository : DataManager, IEmployeeRepository
    {
        public int Employee_Insert(EmployeeForInsertModel em)
        {
            using (var con = GetDbConnection())
            {
                con.Open();
                using (var tran = con.BeginTransaction())
                {
                    try
                    {
                        int employeeId = con.ExecuteScalar<int>("dbo.Usp_EmployeeBasicInfo_Insert",
                            new
                            {
                                @iStrLastName = em.EmployeeBasicInfo.LastName,
                                @iStrFirstName = em.EmployeeBasicInfo.FirstName,
                                @iStrMiddleName = em.EmployeeBasicInfo.MiddleName,
                                @iStrSuffix = em.EmployeeBasicInfo.Suffix,
                                @iStrBirthDate = em.EmployeeBasicInfo.BirthDate,
                                @iStrPlaceOfBirth = em.EmployeeBasicInfo.PlaceOfBirth,
                                @iStrCitizenship = em.EmployeeBasicInfo.Citizenship,
                                @iStrHeight = em.EmployeeBasicInfo.Height,
                                @iStrWeight = em.EmployeeBasicInfo.Weight,
                                @iStrReligion = em.EmployeeBasicInfo.Religion,
                                @iStrResidentialAddress1 = em.EmployeeBasicInfo.ResidentialAddress1,
                                @iStrResidentialAddress2 = em.EmployeeBasicInfo.ResidentialAddress2,
                                @iStrCurrentAddress1 = em.EmployeeBasicInfo.CurrentAddress1,
                                @iStrCurrentAddress2 = em.EmployeeBasicInfo.CurrentAddress2,
                                @iStrGender = em.EmployeeBasicInfo.Gender,
                                @iStrCivilStatus = em.EmployeeBasicInfo.CivilStatus,
                                @iStrPicName = em.EmployeeBasicInfo.PicName

                            },
                            transaction: tran, commandType: CommandType.StoredProcedure);

                        con.Execute("dbo.Usp_EmployeeContactInfo_Insert",
                                 new
                                 {
                                     @iIntEmployeeId = employeeId,
                                     @iStrSpouseName = em.EmployeeContactInfo.SpouseName,
                                     @iStrSpouseOccupation = em.EmployeeContactInfo.SpouseOccupation,
                                     @iDtSpouseBirthDate = em.EmployeeContactInfo.SpouseBirthDate,
                                     @iStrFatherName = em.EmployeeContactInfo.FatherName,
                                     @iStrFatherOccupation = em.EmployeeContactInfo.FatherOccupation,
                                     @iDtFatherBirthDate = em.EmployeeContactInfo.FatherBirthDate,
                                     @iStrMotherName = em.EmployeeContactInfo.MotherName,
                                     @iStrMotherOccupation = em.EmployeeContactInfo.MotherOccupation,
                                     @iDtMotherBirthDate = em.EmployeeContactInfo.MotherBirthDate,
                                     @iStrParentAddress1 = em.EmployeeContactInfo.ParentAddress1,
                                     @iStrParentAddress2 = em.EmployeeContactInfo.ParentAddress2,
                                     @iStrContactNum1 = em.EmployeeContactInfo.ContactNum1,
                                     @iStrContactNum2 = em.EmployeeContactInfo.ContactNum2,
                                     @iStrEmailAddress = em.EmployeeContactInfo.EmailAddress,
                                     @iStrContactPersonName = em.EmployeeContactInfo.ContactPersonName,
                                     @iStrContactPersonNumber = em.EmployeeContactInfo.ContactPersonNumber,
                                     @iStrContactPersonAddress1 = em.EmployeeContactInfo.ContactPersonAddress1,
                                     @iStrContactPersonAddress2 = em.EmployeeContactInfo.ContactPersonAddress2
                                 },
                                 transaction: tran, commandType: CommandType.StoredProcedure);

                        con.Execute("dbo.Usp_EmployeeEducation_Insert",
                                 new
                                 {
                                     @iIntEmployeeId = employeeId,
                                     @iStrElementary = em.EmployeeEducation.Elementary,
                                     @iDtElemDateGraduated = em.EmployeeEducation.ElemDateGraduated,
                                     @iStrHighSchool = em.EmployeeEducation.HighSchool,
                                     @iDtHighSchoolDateGraduated = em.EmployeeEducation.HighSchoolDateGraduated,
                                     @iStrVocational = em.EmployeeEducation.Vocational,
                                     @iStrVocationalCourse = em.EmployeeEducation.VocationalCourse,
                                     @iDtVocationalDateGraduated = em.EmployeeEducation.VocationalDateGraduated,
                                     @iStrCollege = em.EmployeeEducation.College,
                                     @iStrCollegeCourse = em.EmployeeEducation.CollegeCourse,
                                     @iDtCollegeDateGraduated = em.EmployeeEducation.CollegeDateGraduated,
                                     @iStrHighestEducAttainment = em.EmployeeEducation.HighestEducAttainment,
                                     @iStrEducationalBackgroundRemarks = em.EmployeeEducation.EducationalBackgroundRemarks
                                 },
                                 transaction: tran, commandType: CommandType.StoredProcedure);

                        con.Execute("dbo.Usp_EmployeeEmpInfo_Insert",
                                new
                                {
                                    @iIntEmployeeId = employeeId,
                                    @iStrDesignation = em.EmployeeEmpInfo.Designation,
                                    @iIntDepartment = em.EmployeeEmpInfo.DepartmentId,
                                    @iStrEmploymentType = em.EmployeeEmpInfo.EmploymentType,
                                    @iDecBasicPay = em.EmployeeEmpInfo.BasicPay,
                                    @iDtDateHired = em.EmployeeEmpInfo.DateHired,
                                    @iStrTINNo = em.EmployeeEmpInfo.TINNo,
                                    @iStrSSSNo = em.EmployeeEmpInfo.SSSNo,
                                    @iStrPhilHealth = em.EmployeeEmpInfo.PhilHealth,
                                    @iStrPagIbigNo = em.EmployeeEmpInfo.PagIbigNo,
                                    @iStrCharRefFullName1 = em.EmployeeEmpInfo.CharRefFullName1,
                                    @iStrCharRefOccupation1 = em.EmployeeEmpInfo.CharRefOccupation1,
                                    @iStrCharRefContactNum1 = em.EmployeeEmpInfo.CharRefContactNum1,
                                    @iStrCharRefFullName2 = em.EmployeeEmpInfo.CharRefFullName2,
                                    @iStrCharRefOccupation2 = em.EmployeeEmpInfo.CharRefOccupation2,
                                    @iStrCharRefContactNum2 = em.EmployeeEmpInfo.CharRefContactNum2,
                                    @iStrCharRefFullName3 = em.EmployeeEmpInfo.CharRefFullName3,
                                    @iStrCharRefOccupation3 = em.EmployeeEmpInfo.CharRefOccupation3,
                                    @iStrCharRefContactNum3 = em.EmployeeEmpInfo.CharRefContactNum3,
                                    @istrEmpStatus = em.EmployeeEmpInfo.EmpStatus,
                                    @iStrBasicPayOption = em.EmployeeEmpInfo.BasicRateOption
                                },
                                transaction: tran, commandType: CommandType.StoredProcedure);

                        tran.Commit();
                        return employeeId;
                    }
                    catch (Exception ex)
                    {
                        tran.Rollback();
                        throw new Exception(ex.Message);
                    }
                    finally
                    {
                        con.Close();
                    }
                }
            }
        }

        public List<EmployeeForSelectModel> Employee_Select(string strSearch)
        {
            try
            {
                using (var con = GetDbConnection())
                {
                    var result = con.Query<EmployeeForSelectModel>("dbo.Usp_Employee_SelectAll",
                                  new { @iStrSearch = strSearch },
                                  commandType: CommandType.StoredProcedure);

                    return result.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Employee_Update(EmployeeForInsertModel em)
        {
            using (var con = GetDbConnection())
            {
                con.Open();
                using (var tran = con.BeginTransaction())
                {
                    try
                    {
                        con.Execute("dbo.Usp_EmployeeBasicInfo_Update",
                            new
                            {
                                @iIntEmployeeId = em.EmployeeId,
                                @iStrLastName = em.EmployeeBasicInfo.LastName,
                                @iStrFirstName = em.EmployeeBasicInfo.FirstName,
                                @iStrMiddleName = em.EmployeeBasicInfo.MiddleName,
                                @iStrSuffix = em.EmployeeBasicInfo.Suffix,
                                @iStrBirthDate = em.EmployeeBasicInfo.BirthDate,
                                @iStrPlaceOfBirth = em.EmployeeBasicInfo.PlaceOfBirth,
                                @iStrCitizenship = em.EmployeeBasicInfo.Citizenship,
                                @iStrHeight = em.EmployeeBasicInfo.Height,
                                @iStrWeight = em.EmployeeBasicInfo.Weight,
                                @iStrReligion = em.EmployeeBasicInfo.Religion,
                                @iStrResidentialAddress1 = em.EmployeeBasicInfo.ResidentialAddress1,
                                @iStrResidentialAddress2 = em.EmployeeBasicInfo.ResidentialAddress2,
                                @iStrCurrentAddress1 = em.EmployeeBasicInfo.CurrentAddress1,
                                @iStrCurrentAddress2 = em.EmployeeBasicInfo.CurrentAddress2,
                                @iStrGender = em.EmployeeBasicInfo.Gender,
                                @iStrCivilStatus = em.EmployeeBasicInfo.CivilStatus,
                                @iStrPicName = em.EmployeeBasicInfo.PicName
                            },
                            transaction: tran, commandType: CommandType.StoredProcedure);

                        con.Execute("dbo.Usp_EmployeeContactInfo_Update",
                                 new
                                 {
                                     @iIntEmployeeId = em.EmployeeId,
                                     @iStrSpouseName = em.EmployeeContactInfo.SpouseName,
                                     @iStrSpouseOccupation = em.EmployeeContactInfo.SpouseOccupation,
                                     @iDtSpouseBirthDate = em.EmployeeContactInfo.SpouseBirthDate,
                                     @iStrFatherName = em.EmployeeContactInfo.FatherName,
                                     @iStrFatherOccupation = em.EmployeeContactInfo.FatherOccupation,
                                     @iDtFatherBirthDate = em.EmployeeContactInfo.FatherBirthDate,
                                     @iStrMotherName = em.EmployeeContactInfo.MotherName,
                                     @iStrMotherOccupation = em.EmployeeContactInfo.MotherOccupation,
                                     @iDtMotherBirthDate = em.EmployeeContactInfo.MotherBirthDate,
                                     @iStrParentAddress1 = em.EmployeeContactInfo.ParentAddress1,
                                     @iStrParentAddress2 = em.EmployeeContactInfo.ParentAddress2,
                                     @iStrContactNum1 = em.EmployeeContactInfo.ContactNum1,
                                     @iStrContactNum2 = em.EmployeeContactInfo.ContactNum2,
                                     @iStrEmailAddress = em.EmployeeContactInfo.EmailAddress,
                                     @iStrContactPersonName = em.EmployeeContactInfo.ContactPersonName,
                                     @iStrContactPersonNumber = em.EmployeeContactInfo.ContactPersonNumber,
                                     @iStrContactPersonAddress1 = em.EmployeeContactInfo.ContactPersonAddress1,
                                     @iStrContactPersonAddress2 = em.EmployeeContactInfo.ContactPersonAddress2
                                 },
                                 transaction: tran, commandType: CommandType.StoredProcedure);

                        con.Execute("dbo.Usp_EmployeeEducation_Update",
                                 new
                                 {
                                     @iIntEmployeeId = em.EmployeeId,
                                     @iStrElementary = em.EmployeeEducation.Elementary,
                                     @iDtElemDateGraduated = em.EmployeeEducation.ElemDateGraduated,
                                     @iStrHighSchool = em.EmployeeEducation.HighSchool,
                                     @iDtHighSchoolDateGraduated = em.EmployeeEducation.HighSchoolDateGraduated,
                                     @iStrVocational = em.EmployeeEducation.Vocational,
                                     @iStrVocationalCourse = em.EmployeeEducation.VocationalCourse,
                                     @iDtVocationalDateGraduated = em.EmployeeEducation.VocationalDateGraduated,
                                     @iStrCollege = em.EmployeeEducation.College,
                                     @iStrCollegeCourse = em.EmployeeEducation.CollegeCourse,
                                     @iDtCollegeDateGraduated = em.EmployeeEducation.CollegeDateGraduated,
                                     @iStrHighestEducAttainment = em.EmployeeEducation.HighestEducAttainment,
                                     @iStrEducationalBackgroundRemarks = em.EmployeeEducation.EducationalBackgroundRemarks
                                 },
                                 transaction: tran, commandType: CommandType.StoredProcedure);

                        con.Execute("dbo.Usp_EmployeeEmpInfo_Update",
                                new
                                {
                                    @iIntEmployeeId = em.EmployeeId,
                                    @iStrDesignation = em.EmployeeEmpInfo.Designation,
                                    @iIntDepartment = em.EmployeeEmpInfo.DepartmentId,
                                    @iStrEmploymentType = em.EmployeeEmpInfo.EmploymentType,
                                    @iDecBasicPay = em.EmployeeEmpInfo.BasicPay,
                                    @iDtDateHired = em.EmployeeEmpInfo.DateHired,
                                    @iStrTINNo = em.EmployeeEmpInfo.TINNo,
                                    @iStrSSSNo = em.EmployeeEmpInfo.SSSNo,
                                    @iStrPhilHealth = em.EmployeeEmpInfo.PhilHealth,
                                    @iStrPagIbigNo = em.EmployeeEmpInfo.PagIbigNo,
                                    @iStrCharRefFullName1 = em.EmployeeEmpInfo.CharRefFullName1,
                                    @iStrCharRefOccupation1 = em.EmployeeEmpInfo.CharRefOccupation1,
                                    @iStrCharRefContactNum1 = em.EmployeeEmpInfo.CharRefContactNum1,
                                    @iStrCharRefFullName2 = em.EmployeeEmpInfo.CharRefFullName2,
                                    @iStrCharRefOccupation2 = em.EmployeeEmpInfo.CharRefOccupation2,
                                    @iStrCharRefContactNum2 = em.EmployeeEmpInfo.CharRefContactNum2,
                                    @iStrCharRefFullName3 = em.EmployeeEmpInfo.CharRefFullName3,
                                    @iStrCharRefOccupation3 = em.EmployeeEmpInfo.CharRefOccupation3,
                                    @iStrCharRefContactNum3 = em.EmployeeEmpInfo.CharRefContactNum3,
                                    @istrEmpStatus = em.EmployeeEmpInfo.EmpStatus,
                                    @iStrBasicPayOption = em.EmployeeEmpInfo.BasicRateOption
                                },
                                transaction: tran, commandType: CommandType.StoredProcedure);

                        tran.Commit();
                    }
                    catch (Exception ex)
                    {
                        tran.Rollback();
                        throw new Exception(ex.Message);
                    }
                    finally
                    {
                        con.Close();
                    }
                }
            }
        }

        public EmployeeForInsertModel Employee_SelectById(int empId)
        {
            using (var con = GetDbConnection())
            {
                try
                {
                    EmployeeForInsertModel em = new EmployeeForInsertModel
                    {
                        EmployeeId = empId,
                        EmployeeBasicInfo = con.QueryFirstOrDefault<EmployeeBasicInfoForInsertModel>("dbo.Usp_EmployeeBasicInfo_GetById",
                                  new { @iIntEmployeeId = empId },
                                  commandType: CommandType.StoredProcedure),
                        EmployeeContactInfo = con.QueryFirstOrDefault<EmployeeContactInfoForInsertModel>("dbo.Usp_EmployeeContactInfo_GetByEmployeeId",
                                  new { @iIntEmployeeId = empId },
                                  commandType: CommandType.StoredProcedure),
                        EmployeeEducation = con.QueryFirstOrDefault<EmployeeEducationForInsertModel>("dbo.Usp_EmployeeEducation_GetByEmpId",
                                  new { @iIntEmployeeId = empId },
                                  commandType: CommandType.StoredProcedure),
                        EmployeeEmpInfo = con.QueryFirstOrDefault<EmployeeEmpInfoForInsertModel>("dbo.Usp_EmployeeEmpInfo_GetByEmpId",
                                  new { @iIntEmployeeId = empId },
                                  commandType: CommandType.StoredProcedure)
                    };
                    return em;
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
        }

        public EmployeeLeaveCreditsModel LeaveCredits_Select(int empId)
        {
            using (var con = GetDbConnection())
            {
                try
                {

                    var result = con.QuerySingleOrDefault<EmployeeLeaveCreditsModel>("dbo.Usp_LeaveCredits_Select",
                              new { @iIntEmployeeId = empId },
                              commandType: CommandType.StoredProcedure);

                    return result;
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
        }

        public int LeaveCredits_Update(int empId)
        {
            try
            {
                using (var con = GetDbConnection())
                {
                    var result = con.ExecuteScalar<int>("dbo.Usp_LeaveCredits_Update",
                                new
                                {
                                    @iIntEmployeeId = empId
                                }, commandType: CommandType.StoredProcedure);
                    return result;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public EmployeeBasicInfo Employee_BasicInfo(int id)
        {
            try
            {
                using (var con = GetDbConnection())
                {
                    var result = con.QueryFirstOrDefault<EmployeeBasicInfo>("dbo.Usp_Employee_BasicInfo",
                                  new { @iIntEmployeeId = id },
                                  commandType: CommandType.StoredProcedure);

                    return result;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
