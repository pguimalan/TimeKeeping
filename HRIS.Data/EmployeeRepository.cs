using Dapper;
using HRIS.Data.Interface;
using HRIS.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Data
{
    public class EmployeeRepository : DataManager, IEmployeeRepository
    {
        public int Employee_Insert(EmplyeeForInsertModel em)
        {
            using (var con = GetDbConnection())
            {
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
                                @iDtBirthDate = em.EmployeeBasicInfo.BirthDate,
                                @iStrPlaceOfBirth = em.EmployeeBasicInfo.PlaceOfBirth,
                                @iStrCitizenship = em.EmployeeBasicInfo.Citizenship,
                                @iStrHeight = em.EmployeeBasicInfo.Height,
                                @iStrWeight = em.EmployeeBasicInfo.Weight,
                                @iStrReligion = em.EmployeeBasicInfo.Religion,
                                @iStrResidentialAddress1 = em.EmployeeBasicInfo.ResidentialAddress1,
                                @iStrResidentialAddress2 = em.EmployeeBasicInfo.ResidentialAddress2,
                                @iStrCurrentAddress1 = em.EmployeeBasicInfo.CurrentAddress1,
                                @iStrCurrentAddress2 = em.EmployeeBasicInfo.CurrentAddress2
                            },
                            transaction: tran, commandType: CommandType.StoredProcedure);

                        con.Execute("dbo.Usp_EmployeeContactInfo_Insert",
                                 new
                                 {
                                     @iIntEmployeeId = em.EmployeeContactInfo.EmployeeId,
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
                                     @iIntEmployeeId = em.EmployeeEducation.EmployeeId,
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
                                     @iStrEducationalBackgroundRemarks = em.EmployeeEducation.EducationalBackgroundRemarks
                                 },
                                 transaction: tran, commandType: CommandType.StoredProcedure);

                        con.Execute("dbo.Usp_EmployeeEmpInfo_Insert",
                                new
                                {
                                    @iIntEmployeeId = em.EmployeeEmpInfo.EmployeeId,
                                    @iStrDesignation = em.EmployeeEmpInfo.Designation,
                                    @iStrDepartment = em.EmployeeEmpInfo.Department,
                                    @iStrEmploymentStatus = em.EmployeeEmpInfo.EmploymentStatus,
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
                                    @iStrCharRefContactNum3 = em.EmployeeEmpInfo.CharRefContactNum3
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
                    var result = con.Query<EmployeeForSelectModel>("dbo.Usp_Employee_Select",
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
    }
}
