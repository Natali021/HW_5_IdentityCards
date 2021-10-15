using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW_5_IdentityCards
{
    public partial class Form1
    {
        /// <summary>
        /// Описання структур для зберігання даних
        /// </summary>
        public struct GeneralInformation    // основні дані
        {

            public string CompanyName;
            public string CompanyCode;
            public DateTime FillDate;
            public string TabNumber;
            public string IPN;
            public string Gender;
            public string WorkType;
        }

        public struct PersonalInformation    //1 загальні відомості
        {
            public string Surname;
            public string Name;
            public string Patronymic;
            public string Nationality;
            public DateTime BirthDate;
            public string Education;
        }

        public struct FirstEducation     // 1. освіта 
        {
            public string Educationalnstitution;
            public string Diplomalnstitution;
            public string YearEndlnstitution;
            public string Profession;
            public string Qualification;
            public string FormOfStudy;
        }

        public struct AfterEducation  //// 1.  профпідготовка
        {
            public string Professionallnstitution;
            public string DiplomaProfessionallnstitution;
            public string DateOfIssue;
            public string YearEndProfessionallnstitution;
            public string Degree;
        }

        public struct EducationGeneral   //освіта general
        {
            public FirstEducation[] FirstEducation_;
            public bool isAspiranture;
            public bool isAdjuncture;
            public bool isDoctoranture;//////////+checkBox
            public AfterEducation[] AfterEducation_;
        }

        public struct LastPlaceOfWork  //// 1. робота
        {
            public string LastWork;
            public string ProfessionHere;
            public DateTime FireDate;
            public string FireReason;
            public string PensionInfo;
            public DateTime WorkExp;
            public string WDays;
            public string WMonth;
            public string WYears;
            public string BDays;
            public string BMonth;
            public string BYears;
        }

        public struct FamilyComposition    // сім'я
        {
            public string FamilyBond;
            public string FamilyPIB;
            public string FamilyBirthDate;
        }

        public struct FamilyStatusGeneral     // сім'я general
        {
            public string FamilyStatus_;
            public FamilyComposition[] FamilyCompositions_;
        }

        public struct PlaceOfResidence  // місце проживання та особисті дані
        {
            public string FactPlaceOfResidence;
            public string PlaceStateReg;
            public string PhoneNumber;
            public string PassSeries;
            public string PassNumber;
            public string PassIssuedBy;
            public DateTime PassDateIssue;
        }

        public struct ProfessionalEducation   // 3. професійна освіта
        {
            public string date;
            public string departmentName;
            public string studyPeriod;
            public string typeOfEducation;
            public string formOfEducation;
            public string infoAboutEducationDocument;
        }

        public struct ProfessionalEducationGeneral   // професійна освіта general
        {
            public ProfessionalEducation[] ProfessionalEducation_;
        }


        public struct VacationRecord      // V. Відпустки
        {
            public string typeOfVacation;
            public string vacationPeriod;
            public string vacationStartDate;
            public string vacationFinishDate;
            public string vacationIssue;
        }

        public struct VacationGeneral
        {
            public VacationRecord[] VacationRecords_;
            
        }


        // зведена структура
        public struct EmployeeCard_
        {
            public GeneralInformation GeneralInformation; // основні дані 
            public PersonalInformation PersonalInformation; // інформація з розділу 1
            public EducationGeneral EducationGeneral;
            public LastPlaceOfWork LastPlaceOfWork;
            public FamilyStatusGeneral FamilyStatusGeneral;
            public PlaceOfResidence PlaceOfResidence;
            public ProfessionalEducationGeneral ProfessionalEducationGeneral;// дані з розділу 3
            public VacationGeneral VacationGeneral; // дані з розділу 5

        }


        // екземпляр обєкта EmployeeCard_
        public EmployeeCard_ DataForm_ = new EmployeeCard_();
    }
}
