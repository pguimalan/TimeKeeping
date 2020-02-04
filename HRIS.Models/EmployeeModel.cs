using System;

namespace HRIS.Models
{
    public class EmployeeForInsertModel
    {
        public int EmployeeId { get; set; }
        public EmployeeBasicInfoForInsertModel EmployeeBasicInfo { get; set; }
        public EmployeeContactInfoForInsertModel EmployeeContactInfo { get; set; }
        public EmployeeEducationForInsertModel EmployeeEducation { get; set; }
        public EmployeeEmpInfoForInsertModel EmployeeEmpInfo { get; set; }
    }
        
    public class EmployeeBasicInfoForInsertModel
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string Suffix { get; set; }
        public string BirthDate { get; set; }
        public string PlaceOfBirth { get; set; }
        public string Citizenship { get; set; }
        public string Height { get; set; }
        public string Weight { get; set; }
        public string Religion { get; set; }
        public string ResidentialAddress1 { get; set; }
        public string ResidentialAddress2 { get; set; }
        public string CurrentAddress1 { get; set; }
        public string CurrentAddress2 { get; set; }
        public string Gender { get; set; }
        public string CivilStatus { get; set; }
    }

    public class EmployeeContactInfoForInsertModel
    {
        public int EmployeeId { get; set; }
        public string SpouseName { get; set; }
        public string SpouseOccupation { get; set; }
        public DateTime SpouseBirthDate { get; set; }
        public string FatherName { get; set; }
        public string FatherOccupation { get; set; }
        public DateTime FatherBirthDate { get; set; }
        public string MotherName { get; set; }
        public string MotherOccupation { get; set; }
        public DateTime MotherBirthDate { get; set; }
        public string ParentAddress1 { get; set; }
        public string ParentAddress2 { get; set; }
        public string ContactNum1 { get; set; }
        public string ContactNum2 { get; set; }
        public string EmailAddress { get; set; }
        public string ContactPersonName { get; set; }
        public string ContactPersonNumber { get; set; }
        public string ContactPersonAddress1 { get; set; }
        public string ContactPersonAddress2 { get; set; }
    }

    public class EmployeeEducationForInsertModel
    {
        public int EmployeeId { get; set; }
        public string Elementary { get; set; }
        public DateTime ElemDateGraduated { get; set; }
        public string HighSchool { get; set; }
        public DateTime HighSchoolDateGraduated { get; set; }
        public string Vocational { get; set; }
        public string VocationalCourse { get; set; }
        public DateTime VocationalDateGraduated { get; set; }
        public string College { get; set; }
        public string CollegeCourse { get; set; }
        public DateTime CollegeDateGraduated { get; set; }
        public string HighestEducAttainment { get; set; }
        public string EducationalBackgroundRemarks { get; set; }
    }

    public class EmployeeEmpInfoForInsertModel
    {
        public int EmployeeId { get; set; }
        public string Designation { get; set; }
        public string Department { get; set; }
        public string EmploymentStatus { get; set; }
        public decimal BasicPay { get; set; }
        public DateTime DateHired { get; set; }
        public string TINNo { get; set; }
        public string SSSNo { get; set; }
        public string PhilHealth { get; set; }
        public string PagIbigNo { get; set; }
        public string CharRefFullName1 { get; set; }
        public string CharRefOccupation1 { get; set; }
        public string CharRefContactNum1 { get; set; }
        public string CharRefFullName2 { get; set; }
        public string CharRefOccupation2 { get; set; }
        public string CharRefContactNum2 { get; set; }
        public string CharRefFullName3 { get; set; }
        public string CharRefOccupation3 { get; set; }
        public string CharRefContactNum3 { get; set; }
    }

    public class EmployeeForSelectModel
    {
        public int EmployeeId { get; set; }
        public string EmployeeIDNumber { get; set; }
        public string Suffix { get; set; }
        public string EmployeeFullName { get; set; }
        public string Designation { get; set; }
        public string ContactNumbers { get; set; }
        public string Department { get; set; }
    }
}
