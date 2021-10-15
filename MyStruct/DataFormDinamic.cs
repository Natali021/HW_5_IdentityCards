using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW_5_IdentityCards
{
    /// <summary>
    /// Клас для зберігання динамічних даних    
    /// </summary>
    public class DataFormDinamic
    {
        // освіта
        public List<TextBox> List_textBox_Educationalnstitution = new List<TextBox>();        
        public List<TextBox> List_textBox_Diplomalnstitution = new List<TextBox>();
        public List<MaskedTextBox> List_maskedTextBox_YearEndlnstitution = new List<MaskedTextBox>();
        public List<TextBox> List_textBox_Profession = new List<TextBox>();
        public List<TextBox> List_textBox_Qualification = new List<TextBox>();
        public List<ComboBox> List_comboBox_FormOfStudy = new List<ComboBox>();

        // профпідготовка
        public List<TextBox> List_textBox_Professionallnstitution = new List<TextBox>();
        public List<TextBox> List_textBox_DiplomaProfessionallnstitution = new List<TextBox>();
        public List<DateTimePicker> List_dateTimePicker_DateOfIssue = new List<DateTimePicker>();
        public List<MaskedTextBox> List_maskedTextBox_YearEndProfessionallnstitution = new List<MaskedTextBox>();
        public List<ComboBox> List_comboBox_Degree = new List<ComboBox>();

        // сім'я
        public List<ComboBox> List_comboBox_FamilyBond = new List<ComboBox>();
        public List<TextBox> List_textBox_FamilyPIB = new List<TextBox>();
        public List<DateTimePicker> List_dateTimePicker_FamilyBirthDate = new List<DateTimePicker>();

        
    }
}
