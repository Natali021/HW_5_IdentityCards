using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace HW_5_IdentityCards
{
    public partial class Form1 
    {
        
        #region Методи запису інформації до файлу з масивів даних        

        private void ReadTableFirstEducation(ref FirstEducation[] firstEdu)
        {
            FirstEducation[] arr = new FirstEducation[DataGridView_Education.Rows.Count - 1];
            for (int i = 0; i < (DataGridView_Education.Rows.Count - 1); i++)
            {
                arr[i].Educationalnstitution = (string)DataGridView_Education["Column1_Name", i].Value;
                arr[i].Diplomalnstitution = (string)DataGridView_Education["Column2_Diplome", i].Value;
                arr[i].YearEndlnstitution = (string)DataGridView_Education["Column3_Year", i].Value;
                arr[i].Profession = (string)DataGridView_Education["Column4_Specialty", i].Value;
                arr[i].Qualification = (string)DataGridView_Education["Column5_qualification", i].Value;
                arr[i].FormOfStudy = (string)DataGridView_Education["Column6_FormOfEducation", i].Value;

            }

            firstEdu = arr;
        }
                
        private void ReadTableAfterEducation(ref AfterEducation[] afterEd)
        {
            AfterEducation[] arr = new AfterEducation[afterGraduationDataGridView.Rows.Count - 1];      
            for (int i = 0; i < (afterGraduationDataGridView.Rows.Count - 1); i++)
            {
                arr[i].Professionallnstitution = (string)afterGraduationDataGridView["Column7", i].Value;
                arr[i].DiplomaProfessionallnstitution = (string)afterGraduationDataGridView["Column8", i].Value;
                arr[i].DateOfIssue = (string)afterGraduationDataGridView["Column9", i].Value;
                arr[i].YearEndProfessionallnstitution = (string)afterGraduationDataGridView["Column10", i].Value;
                arr[i].Degree = (string)afterGraduationDataGridView["Column11", i].Value;

            }

            afterEd = arr;
        }

       
        private void ReadTableFamilyComposition(ref FamilyComposition[] familyComp)
        {
            FamilyComposition[] arr = new FamilyComposition[familyCompositiondataGridView.Rows.Count - 1];
            for (int i = 0; i < (familyCompositiondataGridView.Rows.Count - 1); i++)
            {
                arr[i].FamilyBond = (string)familyCompositiondataGridView["Column12", i].Value;
                arr[i].FamilyPIB = (string)familyCompositiondataGridView["Column13", i].Value;
                arr[i].FamilyBirthDate = (string)familyCompositiondataGridView["Column14", i].Value;
            }

            familyComp = arr;
        }

        private void ReadTableProfessionalEducation(ref ProfessionalEducation[] profEdu)
        {
            ProfessionalEducation[] arr = new ProfessionalEducation[ProfEducationDataGridView.Rows.Count - 1];
            for (int i = 0; i < (ProfEducationDataGridView.Rows.Count - 1); i++)
            {
                arr[i].date = (string)ProfEducationDataGridView["Column1_Date", i].Value;
                arr[i].departmentName = (string)ProfEducationDataGridView["Column2_struct", i].Value;
                arr[i].studyPeriod = (string)ProfEducationDataGridView["Column3_Interval", i].Value;
                arr[i].typeOfEducation = (string)ProfEducationDataGridView["Column4_Type", i].Value;
                arr[i].formOfEducation = (string)ProfEducationDataGridView["Column5_Form", i].Value;
                arr[i].infoAboutEducationDocument = (string)ProfEducationDataGridView["Column6_NameDok", i].Value;

            }

            profEdu = arr;
        }

        private void ReadTableVacations(ref VacationRecord[] vacations)
        {
            VacationRecord[] arr = new VacationRecord[VacationsDataGridView.Rows.Count - 1];
            for (int i = 0; i < (VacationsDataGridView.Rows.Count - 1); i++)
            {
                arr[i].typeOfVacation = (string)VacationsDataGridView["Column21", i].Value;
                arr[i].vacationPeriod = (string)VacationsDataGridView["Column22", i].Value;
                arr[i].vacationStartDate = (string)VacationsDataGridView["Column23", i].Value;
                arr[i].vacationFinishDate = (string)VacationsDataGridView["Column24", i].Value;
                arr[i].vacationIssue = (string)VacationsDataGridView["Column25", i].Value;

            }

            vacations = arr;
        }

        #endregion

        /// <summary>
        /// Процедура зберігання у файл
        /// </summary>
        private void SaveDataToFile()
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {

                string fileName = saveFileDialog1.FileName;

                #region Собрать информацию из формы в стуктуру
                //GeneralInformation
                DataForm_.GeneralInformation.CompanyName = this.comboBox_CompanyName.Text;
                DataForm_.GeneralInformation.CompanyCode = this.comboBox_CompanyCode.Text;
                DataForm_.GeneralInformation.FillDate = this.dateTimePicker_FillDate.Value;
                DataForm_.GeneralInformation.TabNumber = this.maskedTextBox_TabNumber.Text;
                DataForm_.GeneralInformation.IPN = this.maskedTextBox_IPN.Text;
                DataForm_.GeneralInformation.Gender = this.comboBox_Gender.Text;
                DataForm_.GeneralInformation.WorkType = this.comboBox_WorkType.Text;
                //PersonalInformation
                DataForm_.PersonalInformation.Surname = this.textBox_Surname.Text;
                DataForm_.PersonalInformation.Name = this.textBox_Name.Text;
                DataForm_.PersonalInformation.Patronymic = this.textBox_Patronymic.Text;
                DataForm_.PersonalInformation.Nationality = this.comboBox_Nationality.Text;
                DataForm_.PersonalInformation.BirthDate = this.dateTimePicker_BirthDate.Value;
                DataForm_.PersonalInformation.Education = this.comboBox_Education.Text;
                //EducationGeneral                
                ReadTableFirstEducation(ref DataForm_.EducationGeneral.FirstEducation_);                
                ReadTableAfterEducation(ref DataForm_.EducationGeneral.AfterEducation_);                  
                DataForm_.EducationGeneral.isAspiranture = checkBox__PreparationType1.Checked;// checkboxes
                DataForm_.EducationGeneral.isAdjuncture = checkBox__PreparationType2.Checked;
                DataForm_.EducationGeneral.isDoctoranture = checkBox__PreparationType3.Checked;
                //LastPlaceOfWork
                DataForm_.LastPlaceOfWork.LastWork = this.textBox_LastWork.Text;
                DataForm_.LastPlaceOfWork.ProfessionHere = this.textBox_ProfessionHere.Text;
                DataForm_.LastPlaceOfWork.FireDate = this.dateTimePicker_FireDate.Value;
                DataForm_.LastPlaceOfWork.FireReason = this.comboBox_FireReason.Text;
                DataForm_.LastPlaceOfWork.PensionInfo = this.textBox_PensionInfo.Text;
                DataForm_.LastPlaceOfWork.WorkExp = this.dateTimePicker_WorkExp.Value;
                DataForm_.LastPlaceOfWork.WDays = this.maskedTextBox_WDays.Text;
                DataForm_.LastPlaceOfWork.WMonth = this.maskedTextBox_WMonth.Text;
                DataForm_.LastPlaceOfWork.WYears = this.maskedTextBox_WYears.Text;
                DataForm_.LastPlaceOfWork.BDays = this.maskedTextBox_BDays.Text;
                DataForm_.LastPlaceOfWork.BMonth = this.maskedTextBox_BDays.Text;
                DataForm_.LastPlaceOfWork.BYears = this.maskedTextBox_BYears.Text;
                //FamilyStatusGeneral     родинний стан
                DataForm_.FamilyStatusGeneral.FamilyStatus_ = comboBox_FamilyStatus.Text;
                ReadTableFamilyComposition(ref DataForm_.FamilyStatusGeneral.FamilyCompositions_);
                //PlaceOfResidence
                DataForm_.PlaceOfResidence.FactPlaceOfResidence = this.textBox_FactPlaceOfResidence.Text;
                DataForm_.PlaceOfResidence.PlaceStateReg = this.textBox_PlaceStateReg.Text;
                DataForm_.PlaceOfResidence.PhoneNumber = this.maskedTextBox_PhoneNumber.Text;
                DataForm_.PlaceOfResidence.PassSeries = this.textBox_PassSeries.Text;
                DataForm_.PlaceOfResidence.PassNumber = this.maskedTextBox_PassNumber.Text;
                DataForm_.PlaceOfResidence.PassIssuedBy = this.textBox_PassIssuedBy.Text;
                DataForm_.PlaceOfResidence.PassDateIssue = this.dateTimePicker_PassDateIssue.Value;
                //ProfessionalEducationGeneral     Дані профпідготовки на виробництві 
                ReadTableProfessionalEducation(ref DataForm_.ProfessionalEducationGeneral.ProfessionalEducation_);
                //VacationGeneral   Дані про відпустки
                ReadTableVacations(ref DataForm_.VacationGeneral.VacationRecords_);

                #endregion

                // запись в xml файл
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(EmployeeCard_));
                XmlSerializer xmlSerialaizer = xmlSerializer;

                try
                {
                    FileStream fw = new FileStream(fileName, FileMode.Create);
                    xmlSerialaizer.Serialize(fw, DataForm_);
                    fw.Close();
                    MessageBox.Show("Данные сохранены!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (IOException exeption)
                {
                    MessageBox.Show(exeption.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        
        #region Методи зчитування інформації з файлу в масиви даних        

        private void WriteTableFirstEducation(ref FirstEducation[] firstEdu)
        {
            int i = 0;
            foreach (var el in firstEdu)
            {
                DataGridView_Education.Rows.Add();
                DataGridView_Education["Column1_Name", i].Value = el.Educationalnstitution;
                DataGridView_Education["Column2_Diplome", i].Value = el.Diplomalnstitution;
                DataGridView_Education["Column3_Year", i].Value = el.YearEndlnstitution;
                DataGridView_Education["Column4_Specialty", i].Value = el.Profession;
                DataGridView_Education["Column5_qualification", i].Value = el.Qualification;
                DataGridView_Education["Column6_FormOfEducation", i].Value = el.FormOfStudy;
                i++;
            }
        }

        private void WriteTableAfterEducation(ref AfterEducation[] afterGrad)
        {
            int i = 0;
            foreach (var el in afterGrad)
            {
                afterGraduationDataGridView.Rows.Add();
                afterGraduationDataGridView["Column7", i].Value = el.Professionallnstitution;
                afterGraduationDataGridView["Column8", i].Value = el.DiplomaProfessionallnstitution;
                afterGraduationDataGridView["Column9", i].Value = el.DateOfIssue;
                afterGraduationDataGridView["Column10", i].Value = el.YearEndProfessionallnstitution;
                afterGraduationDataGridView["Column11", i].Value = el.Degree;

                i++;
            }
        }

        private void WriteTableFamilyComposition(ref FamilyComposition[] familyComp)
        {
            int i = 0;
            foreach (var el in familyComp)
            {
                familyCompositiondataGridView.Rows.Add();
                familyCompositiondataGridView["Column12", i].Value = el.FamilyBond;
                familyCompositiondataGridView["Column13", i].Value = el.FamilyPIB;
                familyCompositiondataGridView["Column14", i].Value = el.FamilyBirthDate;

                i++;
            }
        }

        private void WriteTableProfessionalEducation(ref ProfessionalEducation[] profEdu)
        {
            int i = 0;
            foreach (var el in profEdu)
            {
                ProfEducationDataGridView.Rows.Add();
                ProfEducationDataGridView["Column1_Date", i].Value = el.date;
                ProfEducationDataGridView["Column2_struct", i].Value = el.departmentName;
                ProfEducationDataGridView["Column3_Interval", i].Value = el.studyPeriod;
                ProfEducationDataGridView["Column4_Type", i].Value = el.typeOfEducation;
                ProfEducationDataGridView["Column5_Form", i].Value = el.formOfEducation;
                ProfEducationDataGridView["Column6_NameDok", i].Value = el.infoAboutEducationDocument;

                i++;
            }
        }

        private void WriteTableVacations(ref VacationRecord[] vacations)
        {
            int i = 0;
            foreach (var el in vacations)
            {
                VacationsDataGridView.Rows.Add();
                VacationsDataGridView["Column21", i].Value = el.typeOfVacation;
                VacationsDataGridView["Column22", i].Value = el.vacationPeriod;
                VacationsDataGridView["Column23", i].Value = el.vacationStartDate;
                VacationsDataGridView["Column24", i].Value = el.vacationFinishDate;
                VacationsDataGridView["Column25", i].Value = el.vacationIssue;

                i++;
            }
        }

        #endregion

        /// <summary>
        /// Процедура загрузки з файлу
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenForm(object sender, EventArgs e)
        {

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                XmlSerializer xmlSerializer = new XmlSerializer(typeof(EmployeeCard_));
                XmlSerializer xmlSerialaizer = xmlSerializer;
                string fileName = openFileDialog1.FileName;

                try
                {
                    FileStream fr = new FileStream(fileName, FileMode.Open);
                    DataForm_ = (EmployeeCard_)xmlSerialaizer.Deserialize(fr);
                    fr.Close();

                    #region Собрать информацию из стуктуры в форму
                    //GeneralInformation
                    this.comboBox_CompanyName.Text=DataForm_.GeneralInformation.CompanyName;
                    this.comboBox_CompanyCode.Text=DataForm_.GeneralInformation.CompanyCode;
                    this.dateTimePicker_FillDate.Value=DataForm_.GeneralInformation.FillDate;
                    this.maskedTextBox_TabNumber.Text=DataForm_.GeneralInformation.TabNumber;
                    this.maskedTextBox_IPN.Text=DataForm_.GeneralInformation.IPN;
                    this.comboBox_Gender.Text=DataForm_.GeneralInformation.Gender;
                    this.comboBox_WorkType.Text=DataForm_.GeneralInformation.WorkType;
                    //PersonalInformation
                    this.textBox_Surname.Text=DataForm_.PersonalInformation.Surname;
                    this.textBox_Name.Text=DataForm_.PersonalInformation.Name;
                    this.textBox_Patronymic.Text=DataForm_.PersonalInformation.Patronymic;
                    this.comboBox_Nationality.Text=DataForm_.PersonalInformation.Nationality;
                    this.dateTimePicker_BirthDate.Value=DataForm_.PersonalInformation.BirthDate;
                    this.comboBox_Education.Text=DataForm_.PersonalInformation.Education;
                    //EducationGeneral
                    WriteTableFirstEducation(ref DataForm_.EducationGeneral.FirstEducation_);
                    WriteTableAfterEducation(ref DataForm_.EducationGeneral.AfterEducation_);
                    checkBox__PreparationType1.Checked = DataForm_.EducationGeneral.isAspiranture;//+checkboxes
                    checkBox__PreparationType2.Checked = DataForm_.EducationGeneral.isAdjuncture;
                    checkBox__PreparationType3.Checked = DataForm_.EducationGeneral.isDoctoranture;
                    //LastPlaceOfWork
                    this.textBox_LastWork.Text=DataForm_.LastPlaceOfWork.LastWork;
                    this.textBox_ProfessionHere.Text=DataForm_.LastPlaceOfWork.ProfessionHere;
                    this.dateTimePicker_FireDate.Value=DataForm_.LastPlaceOfWork.FireDate;
                    this.comboBox_FireReason.Text=DataForm_.LastPlaceOfWork.FireReason;
                    this.textBox_PensionInfo.Text=DataForm_.LastPlaceOfWork.PensionInfo;
                    this.dateTimePicker_WorkExp.Value=DataForm_.LastPlaceOfWork.WorkExp;
                    this.maskedTextBox_WDays.Text=DataForm_.LastPlaceOfWork.WDays;
                    this.maskedTextBox_WMonth.Text=DataForm_.LastPlaceOfWork.WMonth;
                    this.maskedTextBox_WYears.Text=DataForm_.LastPlaceOfWork.WYears;
                    this.maskedTextBox_BDays.Text=DataForm_.LastPlaceOfWork.BDays;
                    this.maskedTextBox_BDays.Text=DataForm_.LastPlaceOfWork.BMonth;
                    this.maskedTextBox_BYears.Text=DataForm_.LastPlaceOfWork.BYears;
                    //FamilyStatusGeneral     родинний стан
                    comboBox_FamilyStatus.Text = DataForm_.FamilyStatusGeneral.FamilyStatus_;
                    WriteTableFamilyComposition(ref DataForm_.FamilyStatusGeneral.FamilyCompositions_);
                    //PlaceOfResidence
                    this.textBox_FactPlaceOfResidence.Text=DataForm_.PlaceOfResidence.FactPlaceOfResidence;
                    this.textBox_PlaceStateReg.Text=DataForm_.PlaceOfResidence.PlaceStateReg;
                    this.maskedTextBox_PhoneNumber.Text=DataForm_.PlaceOfResidence.PhoneNumber;
                    this.textBox_PassSeries.Text=DataForm_.PlaceOfResidence.PassSeries;
                    this.maskedTextBox_PassNumber.Text=DataForm_.PlaceOfResidence.PassNumber;
                    this.textBox_PassIssuedBy.Text=DataForm_.PlaceOfResidence.PassIssuedBy;
                    this.dateTimePicker_PassDateIssue.Value=DataForm_.PlaceOfResidence.PassDateIssue;
                    //ProfessionalEducationGeneral     Дані профпідготовки на виробництві 
                    WriteTableProfessionalEducation(ref DataForm_.ProfessionalEducationGeneral.ProfessionalEducation_);
                    //VacationGeneral   Дані про відпустки
                    WriteTableVacations(ref DataForm_.VacationGeneral.VacationRecords_);

                    #endregion

                    MessageBox.Show("Данные загружены!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (IOException exeption)
                {
                    MessageBox.Show(exeption.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }

        /// <summary>
        /// Процедура очищення
        /// </summary>
        /// <param name=""></param>
        /// <param name=""></param>
        private void ClearForm(object sender, EventArgs e) {
            if (MessageBox.Show("Ви дійсно бажаєте очистити всю форму?", "Підтвердження дії", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ClearAllElements(this);
                toolStripStatusLabel2.Text = "Форму очищено";
            }
        }
        

        // очистить все элементы 
        private void ClearAllElements(Control form)
        {
            Clear_all_TextBox(form);
            Clear_all_ComboBox(form);
            Clear_all_dateTimePicker(form);
            Clear_all_DataGridView(form);
            Clear_all_MaskeTextBox(form);

            checkBox__PreparationType1.Checked = false;
            checkBox__PreparationType2.Checked = false;
            checkBox__PreparationType3.Checked = false;
            pictureBox_Photo.Image = null;
        }

        // Очищаємо всі реквізити типу TextBox
        private void Clear_all_TextBox(Control control)
        {

            var elements = control.Controls.OfType<TextBox>();
            foreach (TextBox text_box in elements)
            {
                text_box.Clear();
            }

            foreach (Control element in control.Controls)
            {
                Clear_all_TextBox(element);
            }

        }

        // Очищаємо всі реквізити типу ComboBox
        private void Clear_all_ComboBox(Control control)
        {

            var elements = control.Controls.OfType<ComboBox>();
            foreach (ComboBox comboBox in elements)
            {
                comboBox.Text = "";
            }

            foreach (Control element in control.Controls)
            {
                Clear_all_ComboBox(element);
            }

        }

        // Очищаємо всі реквізити типу dateTimePicker
        private void Clear_all_dateTimePicker(Control control)
        {

            var elements = control.Controls.OfType<DateTimePicker>();
            foreach (DateTimePicker dateTimePicker in elements)
            {
                dateTimePicker.Value = DateTime.Now;
            }

            foreach (Control element in control.Controls)
            {
                Clear_all_dateTimePicker(element);
            }

        }

        // MaskedTextBox
        private void Clear_all_MaskeTextBox(Control control)
        {
            var elements = control.Controls.OfType<MaskedTextBox>();
            foreach (MaskedTextBox maskedTextBox in elements)
            {
                maskedTextBox.Text = "";
            }
            foreach (Control element in control.Controls)
            {
                Clear_all_MaskeTextBox(element);
            }
        }

        // Очищаємо всі реквізити типу DataGridView
        private void Clear_all_DataGridView(Control control)
        {

            var elements = control.Controls.OfType<DataGridView>();
            foreach (DataGridView dataGridView in elements)
            {
                dataGridView.Rows.Clear();
            }

            foreach (Control element in control.Controls)
            {
                Clear_all_DataGridView(element);
            }

        }





    }
}
