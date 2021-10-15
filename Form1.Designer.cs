

using System.Drawing;
using System.Windows.Forms;

namespace HW_5_IdentityCards
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox_Info1 = new System.Windows.Forms.GroupBox();
            this.comboBox_CompanyCode = new System.Windows.Forms.ComboBox();
            this.label_CompanyCode = new System.Windows.Forms.Label();
            this.comboBox_CompanyName = new System.Windows.Forms.ComboBox();
            this.label_CompanyName = new System.Windows.Forms.Label();
            this.tabControl_general = new System.Windows.Forms.TabControl();
            this.tabPage_GeneralInformation = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel_PlaceOfResidence = new System.Windows.Forms.Panel();
            this.button_Further1 = new System.Windows.Forms.Button();
            this.label_Pass = new System.Windows.Forms.Label();
            this.label_FactPlaceOfResidence = new System.Windows.Forms.Label();
            this.textBox_FactPlaceOfResidence = new System.Windows.Forms.TextBox();
            this.label_PlaceStateReg = new System.Windows.Forms.Label();
            this.textBox_PlaceStateReg = new System.Windows.Forms.TextBox();
            this.label_PassSeries = new System.Windows.Forms.Label();
            this.textBox_PassIssuedBy = new System.Windows.Forms.TextBox();
            this.maskedTextBox_PassNumber = new System.Windows.Forms.MaskedTextBox();
            this.label_PassNumber = new System.Windows.Forms.Label();
            this.dateTimePicker_PassDateIssue = new System.Windows.Forms.DateTimePicker();
            this.label_PassDateIssue = new System.Windows.Forms.Label();
            this.label_PassIssuedBy = new System.Windows.Forms.Label();
            this.textBox_PassSeries = new System.Windows.Forms.TextBox();
            this.maskedTextBox_PhoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.label_PhoneNumber = new System.Windows.Forms.Label();
            this.panel_FamilyStatus = new System.Windows.Forms.Panel();
            this.familyCompositiondataGridView = new System.Windows.Forms.DataGridView();
            this.Column12 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox_FamilyStatus = new System.Windows.Forms.ComboBox();
            this.label_FamilyStatus = new System.Windows.Forms.Label();
            this.panel_Professionallnstitution = new System.Windows.Forms.Panel();
            this.afterGraduationDataGridView = new System.Windows.Forms.DataGridView();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label_Info2 = new System.Windows.Forms.Label();
            this.checkBox__PreparationType3 = new System.Windows.Forms.CheckBox();
            this.checkBox__PreparationType2 = new System.Windows.Forms.CheckBox();
            this.checkBox__PreparationType1 = new System.Windows.Forms.CheckBox();
            this.label_PreparationType = new System.Windows.Forms.Label();
            this.panel_LastWork = new System.Windows.Forms.Panel();
            this.label_ProfessionHere = new System.Windows.Forms.Label();
            this.textBox_PensionInfo = new System.Windows.Forms.TextBox();
            this.comboBox_FireReason = new System.Windows.Forms.ComboBox();
            this.label_BYears = new System.Windows.Forms.Label();
            this.label_WYears = new System.Windows.Forms.Label();
            this.label_BMonth = new System.Windows.Forms.Label();
            this.label_WMonth = new System.Windows.Forms.Label();
            this.label_BDays = new System.Windows.Forms.Label();
            this.label_WDays = new System.Windows.Forms.Label();
            this.label_Benefits = new System.Windows.Forms.Label();
            this.label_Total = new System.Windows.Forms.Label();
            this.label_PensionInfo = new System.Windows.Forms.Label();
            this.label_FireReason = new System.Windows.Forms.Label();
            this.label_FireDate = new System.Windows.Forms.Label();
            this.label_WorkExpirience = new System.Windows.Forms.Label();
            this.maskedTextBox_BYears = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox_WYears = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox_BMonth = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox_WMonth = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox_BDays = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox_WDays = new System.Windows.Forms.MaskedTextBox();
            this.label_LastWork = new System.Windows.Forms.Label();
            this.textBox_ProfessionHere = new System.Windows.Forms.TextBox();
            this.dateTimePicker_FireDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_WorkExp = new System.Windows.Forms.DateTimePicker();
            this.textBox_LastWork = new System.Windows.Forms.TextBox();
            this.panel_Educationalnstitution = new System.Windows.Forms.Panel();
            this.label_Info = new System.Windows.Forms.Label();
            this.DataGridView_Education = new System.Windows.Forms.DataGridView();
            this.Column1_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2_Diplome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3_Year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4_Specialty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5_qualification = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6_FormOfEducation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox_PersonInformation = new System.Windows.Forms.GroupBox();
            this.dateTimePicker_BirthDate = new System.Windows.Forms.DateTimePicker();
            this.comboBox_Education = new System.Windows.Forms.ComboBox();
            this.comboBox_Nationality = new System.Windows.Forms.ComboBox();
            this.label_Education = new System.Windows.Forms.Label();
            this.label_Nationality = new System.Windows.Forms.Label();
            this.label_BirthDate = new System.Windows.Forms.Label();
            this.textBox_Patronymic = new System.Windows.Forms.TextBox();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.textBox_Surname = new System.Windows.Forms.TextBox();
            this.label_Patronymic = new System.Windows.Forms.Label();
            this.label_Name = new System.Windows.Forms.Label();
            this.label_Surname = new System.Windows.Forms.Label();
            this.tabPage_MilitaryAccounting = new System.Windows.Forms.TabPage();
            this.button_Back1 = new System.Windows.Forms.Button();
            this.button_Further2 = new System.Windows.Forms.Button();
            this.tabPage_EducationInProduction = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ProfEducationDataGridView = new System.Windows.Forms.DataGridView();
            this.Column1_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2_struct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3_Interval = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4_Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5_Form = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Column6_NameDok = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_Further3 = new System.Windows.Forms.Button();
            this.button_Back2 = new System.Windows.Forms.Button();
            this.tabPage_AppointmentAndTransfer = new System.Windows.Forms.TabPage();
            this.button_Back3 = new System.Windows.Forms.Button();
            this.button_Further4 = new System.Windows.Forms.Button();
            this.tabPage_Holidays = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.VacationsDataGridView = new System.Windows.Forms.DataGridView();
            this.Column21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_Save = new System.Windows.Forms.Button();
            this.button_back4 = new System.Windows.Forms.Button();
            this.groupBox_Cap = new System.Windows.Forms.GroupBox();
            this.button_Open = new System.Windows.Forms.Button();
            this.pictureBox_Photo = new System.Windows.Forms.PictureBox();
            this.comboBox_WorkType = new System.Windows.Forms.ComboBox();
            this.label_WorkType = new System.Windows.Forms.Label();
            this.comboBox_Gender = new System.Windows.Forms.ComboBox();
            this.label_Gender = new System.Windows.Forms.Label();
            this.maskedTextBox_IPN = new System.Windows.Forms.MaskedTextBox();
            this.label_IPN = new System.Windows.Forms.Label();
            this.maskedTextBox_TabNumber = new System.Windows.Forms.MaskedTextBox();
            this.label_TabNumber = new System.Windows.Forms.Label();
            this.dateTimePicker_FillDate = new System.Windows.Forms.DateTimePicker();
            this.label_Date = new System.Windows.Forms.Label();
            this.menuStrip_Clouse = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.styleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton_Open = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_Clear = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_Save = new System.Windows.Forms.ToolStripButton();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox_Info1.SuspendLayout();
            this.tabControl_general.SuspendLayout();
            this.tabPage_GeneralInformation.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel_PlaceOfResidence.SuspendLayout();
            this.panel_FamilyStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.familyCompositiondataGridView)).BeginInit();
            this.panel_Professionallnstitution.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.afterGraduationDataGridView)).BeginInit();
            this.panel_LastWork.SuspendLayout();
            this.panel_Educationalnstitution.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_Education)).BeginInit();
            this.groupBox_PersonInformation.SuspendLayout();
            this.tabPage_MilitaryAccounting.SuspendLayout();
            this.tabPage_EducationInProduction.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProfEducationDataGridView)).BeginInit();
            this.tabPage_AppointmentAndTransfer.SuspendLayout();
            this.tabPage_Holidays.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VacationsDataGridView)).BeginInit();
            this.groupBox_Cap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Photo)).BeginInit();
            this.menuStrip_Clouse.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_Info1
            // 
            this.groupBox_Info1.Controls.Add(this.comboBox_CompanyCode);
            this.groupBox_Info1.Controls.Add(this.label_CompanyCode);
            this.groupBox_Info1.Controls.Add(this.comboBox_CompanyName);
            this.groupBox_Info1.Controls.Add(this.label_CompanyName);
            this.groupBox_Info1.Location = new System.Drawing.Point(6, 52);
            this.groupBox_Info1.Name = "groupBox_Info1";
            this.groupBox_Info1.Size = new System.Drawing.Size(234, 126);
            this.groupBox_Info1.TabIndex = 352;
            this.groupBox_Info1.TabStop = false;
            this.groupBox_Info1.Text = "Інформація про організацію";
            // 
            // comboBox_CompanyCode
            // 
            this.comboBox_CompanyCode.AutoCompleteCustomSource.AddRange(new string[] {
            "01020304",
            "32568987"});
            this.comboBox_CompanyCode.FormattingEnabled = true;
            this.comboBox_CompanyCode.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboBox_CompanyCode.Location = new System.Drawing.Point(104, 76);
            this.comboBox_CompanyCode.Name = "comboBox_CompanyCode";
            this.comboBox_CompanyCode.Size = new System.Drawing.Size(121, 23);
            this.comboBox_CompanyCode.TabIndex = 1;
            // 
            // label_CompanyCode
            // 
            this.label_CompanyCode.AutoSize = true;
            this.label_CompanyCode.Location = new System.Drawing.Point(6, 76);
            this.label_CompanyCode.Name = "label_CompanyCode";
            this.label_CompanyCode.Size = new System.Drawing.Size(83, 15);
            this.label_CompanyCode.TabIndex = 351;
            this.label_CompanyCode.Text = "Код ЄДРПОУ";
            // 
            // comboBox_CompanyName
            // 
            this.comboBox_CompanyName.AutoCompleteCustomSource.AddRange(new string[] {
            "ТОВ \"Усе буде добре\"",
            "ТОВ \"Тут\""});
            this.comboBox_CompanyName.FormattingEnabled = true;
            this.comboBox_CompanyName.Location = new System.Drawing.Point(105, 37);
            this.comboBox_CompanyName.Name = "comboBox_CompanyName";
            this.comboBox_CompanyName.Size = new System.Drawing.Size(121, 23);
            this.comboBox_CompanyName.TabIndex = 0;
            // 
            // label_CompanyName
            // 
            this.label_CompanyName.AutoSize = true;
            this.label_CompanyName.Location = new System.Drawing.Point(6, 30);
            this.label_CompanyName.Name = "label_CompanyName";
            this.label_CompanyName.Size = new System.Drawing.Size(93, 30);
            this.label_CompanyName.TabIndex = 350;
            this.label_CompanyName.Text = "Найменування\r\nорганізації";
            // 
            // tabControl_general
            // 
            this.tabControl_general.Controls.Add(this.tabPage_GeneralInformation);
            this.tabControl_general.Controls.Add(this.tabPage_MilitaryAccounting);
            this.tabControl_general.Controls.Add(this.tabPage_EducationInProduction);
            this.tabControl_general.Controls.Add(this.tabPage_AppointmentAndTransfer);
            this.tabControl_general.Controls.Add(this.tabPage_Holidays);
            this.tabControl_general.Location = new System.Drawing.Point(6, 184);
            this.tabControl_general.Name = "tabControl_general";
            this.tabControl_general.SelectedIndex = 0;
            this.tabControl_general.Size = new System.Drawing.Size(1037, 668);
            this.tabControl_general.TabIndex = 358;
            // 
            // tabPage_GeneralInformation
            // 
            this.tabPage_GeneralInformation.AutoScroll = true;
            this.tabPage_GeneralInformation.Controls.Add(this.groupBox1);
            this.tabPage_GeneralInformation.Controls.Add(this.panel_PlaceOfResidence);
            this.tabPage_GeneralInformation.Controls.Add(this.panel_FamilyStatus);
            this.tabPage_GeneralInformation.Controls.Add(this.panel_Professionallnstitution);
            this.tabPage_GeneralInformation.Controls.Add(this.panel_LastWork);
            this.tabPage_GeneralInformation.Controls.Add(this.panel_Educationalnstitution);
            this.tabPage_GeneralInformation.Controls.Add(this.groupBox_PersonInformation);
            this.tabPage_GeneralInformation.Location = new System.Drawing.Point(4, 24);
            this.tabPage_GeneralInformation.Name = "tabPage_GeneralInformation";
            this.tabPage_GeneralInformation.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_GeneralInformation.Size = new System.Drawing.Size(1029, 640);
            this.tabPage_GeneralInformation.TabIndex = 0;
            this.tabPage_GeneralInformation.Text = "1. Загальні відомості";
            this.tabPage_GeneralInformation.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1005, 103);
            this.groupBox1.TabIndex = 360;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Відомості про особу";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(469, 63);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(189, 21);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "базова загальна середня",
            "повна загальна середня",
            "професійно-технічна",
            "неповна вища",
            "базова вища",
            "повна вища"});
            this.comboBox1.Location = new System.Drawing.Point(797, 61);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 23);
            this.comboBox1.TabIndex = 12;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Австралія (офіц. назва - Австралійський Союз)",
            "Австрія (офіц. назва - Республіка Австрія)",
            "Азербайджан (офіц. назва - Азербайджанська Республіка)*",
            "Албанія (офіц. назва - Республіка Албанія)",
            "Андорра (офіц. назва - Князівство Андорра)",
            "Антигуа і Барбуда",
            "Аргентина (офіц. назва - Аргентинська Республіка)",
            "Багами (офіц. назва - Співдружність Багамських островів)",
            "Барбадос",
            "Бахрейн (офіц. назва - Королівство Бахрейн)",
            "Беліз",
            "Бельгія (офіц. назва - Королівство Бельгія)",
            "Білорусь (офіц. назва - Республіка Білорусь)*",
            "Болгарія (офіц. назва - Республіка Болгарія)*",
            "Болівія (офіц. назва - Багатонаціональна Держава Болівія)",
            "Боснія і Герцеговина",
            "Ботсвана (офіц. назва - Республіка Ботсвана)",
            "Бразилія (офіц. назва - Федеративна Республіка Бразилія)",
            "Бруней (офіц. назва - Держава Бруней-Даруссалам)",
            "Бурунді (офіц. назва - Республіка Бурунді)",
            "Вануату (офіц. назва - Республіка Вануату)",
            "Венесуела (офіц. назва - Боліварська Республіка Венесуела)",
            "Вірменія (офіц. назва - Республіка Вірменія)*",
            "Гайана (офіц. назва - Кооперативна Республіка Гайана)",
            "Гватемала (офіц. назва - Республіка Гватемала)",
            "Гондурас (офіц. назва - Республіка Гондурас)",
            "Гренада",
            "Греція (офіц. назва - Грецька Республіка)",
            "Грузія*: Не поширюється на Автономну Республіку Абхазії та колишню Автономну обла" +
                "сть Південної Осетії",
            "Данія (офіц. назва - Королівство Данія): Не поширюється на Гренландію та Фарерськ" +
                "і острови",
            "Домініка (офіц. назва - Співдружність Домініки)",
            "Домініканська Республіка",
            "Еквадор (офіц. назва - Республіка Еквадор)",
            "Естонія (офіц. назва - Естонська Республіка)*",
            "Ізраїль (офіц. назва - Держава Ізраїль)",
            "Індія (офіц. назва - Республіка Індія)",
            "Ірландія (офіц. назва - Республіка Ірландія)",
            "Ісландія",
            "Іспанія (офіц. назва - Королівство Іспанія)",
            "Італія (офіц. назва - Італійська Республіка)",
            "Кабо-Верде (офіц. назва - Республіка Кабо-Верде)",
            "Казахстан (офіц. назва - Республіка Казахстан)*",
            "Киргизстан (офіц. назва - Киргизька Республіка)*",
            "Китай (офіц. назва - Китайська Народна Республіка): Поширюється лише на Гонконг и" +
                " Макао",
            "Кіпр (офіц. назва - Республіка Кіпр)",
            "Колумбія (офіц. назва - Республіка Колумбія)",
            "Королівство Есватіні (до 2018 р. - Королівство Свазіленд)",
            "Королівство Нідерландів",
            "Косово (офіц. назва - Республіка Косово)**",
            "Коста-Рика (офіц. назва - Республіка Коста-Рика)",
            "Латвія (офіц. назва - Латвійська Республіка)*",
            "Лесото (офіц. назва - Королівство Лесото)",
            "Литва (офіц. назва - Литовська Республіка)*",
            "Ліберія (офіц. назва - Республіка Ліберія)",
            "Ліхтенштейн (офіц. назва - Князівство Ліхтенштейн)",
            "Люксембург (офіц. назва - Велике Герцогство Люксембург)",
            "Маврикій (офіц. назва - Республіка Маврикій)",
            "Малаві (офіц. назва - Республіка Малаві)",
            "Мальта (офіц. назва - Республіка Мальта)",
            "Марокко (офіц. назва - Королівство Марокко)",
            "Маршалові Острови (офіц. назва - Республіка Маршалові Острови)",
            "Мексика (офіц. назва - Мексиканські Сполучені Штати)",
            "Молдова (офіц. назва - Республіка Молдова)*",
            "Монако (офіц. назва - Князівство Монако)",
            "Монголія*",
            "Намібія (офіц. назва - Республіка Намібія)",
            "Нікарагуа (офіц. назва - Республіка Нікарагуа)",
            "Німеччина (офіц. назва - Федеративна Республіка Німеччина)",
            "Ніуе",
            "Нова Зеландія: Не поширюється на Токелау",
            "Норвегія (офіц. назва - Королівство Норвегія)",
            "Оман (офіц. назва - Султанат Оман)",
            "Острови Кука",
            "Палау (офіц. назва - Республіка Палау)",
            "Панама (офіц. назва - Республіка Панама)",
            "Парагвай (офіц. назва - Республіка Парагвай)",
            "Перу (офіц. назва - Республіка Перу)",
            "Південно-Африканська Республіка (ПАР)",
            "Північна Македонія (офіц. назва - Республіка Північна Македонія)*",
            "Польща (офіц. назва - Республіка Польща)*",
            "Португалія (офіц. назва - Португальська Республіка)",
            "Республіка Ель Сальвадор",
            "Республіка Корея",
            "Росія (офіц. назва - Російська Федерація)*",
            "Румунія*",
            "Самоа (офіц. назва - Незалежна Держава Самоа)",
            "Сан-Марино (офіц. назва - Найясніша Республіка Сан-Марино)",
            "Сан-Томе і Принсіпі (офіц. назва - Демократична Республіка Сан-Томе і Принсіпі)",
            "Сейшельські острови (офіц. назва - Республіка Сейшельські острови)",
            "Сент-Вінсент і Гренадіни",
            "Сент-Кітс і Невіс (офіц. назва - Федерація Сент-Кітс і Невіс)",
            "Сент-Люсія",
            "Сербія (офіц. назва - Республіка Сербія)*",
            "Сінгапур (офіц. назва - Республіка Сінгапур) - з 16.09.2021",
            "Словаччина (офіц. назва - Словацька Республіка)",
            "Словенія (офіц. назва - Республіка Словенія)",
            "Сполучене Королівство Великобританії та Північної Ірландії: Не поширюється на кра" +
                "їни, які здобувши незалежність (вийшли зі складу Великої Британії) не підписали " +
                "Конвенцію",
            "Сполучені Штати Америки",
            "Суринам (офіц. назва - Республіка Суринам)",
            "Таджикистан (офіц. назва - Республіка Таджикистан)*",
            "Тонга (офіц. назва - Королівство Тонга)",
            "Тринідад і Тобаго (офіц. назва - Республіка Тринідад і Тобаго)",
            "Туніс (офіц. назва - Туніська Республіка)",
            "Туреччина (офіц. назва - Турецька Республіка)",
            "Угорщина*",
            "Узбекистан (офіц. назва - Республіка Узбекистан)*",
            "Україна (Не поширюється на тимчасово окуповані території Донецької і Луганської о" +
                "бластей, Автономну Республіку Крим та м. Севастополь)",
            "Уругвай (офіц. назва - Східна Республіка Уругвай)",
            "Фіджі (офіц. назва - Республіка Фіджі)",
            "Філіппіни (офіц. назва - Республіка Філіппіни)",
            "Фінляндія (офіц. назва - Фінляндська Республіка)",
            "Франція (офіц. назва - Французька Республіка)",
            "Хорватія (офіц. назва - Республіка Хорватія)",
            "Чехія (офіц. назва - Чеська Республіка)*",
            "Чилі (офіц. назва - Республіка Чилі)",
            "Чорногорія",
            "Швейцарія (офіц. назва - Швейцарська Конфедерація)",
            "Швеція (офіц. назва - Королівство Швеція)",
            "Ямайка - з 03.07.2021",
            "Японія (офіц. назва - Японська Держава)"});
            this.comboBox2.Location = new System.Drawing.Point(123, 61);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(189, 23);
            this.comboBox2.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(723, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 26);
            this.label1.TabIndex = 366;
            this.label1.Text = "Освіта:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(10, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 26);
            this.label2.TabIndex = 362;
            this.label2.Text = "Громадянство:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(327, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 25);
            this.label3.TabIndex = 364;
            this.label3.Text = "Дата народження:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(795, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(202, 21);
            this.textBox1.TabIndex = 9;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(467, 28);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(189, 21);
            this.textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(123, 28);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(189, 21);
            this.textBox3.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(678, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 21);
            this.label4.TabIndex = 365;
            this.label4.Text = "По батькові:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(401, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 21);
            this.label5.TabIndex = 363;
            this.label5.Text = "Ім\'я:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(32, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 21);
            this.label6.TabIndex = 361;
            this.label6.Text = "Прізвище:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_PlaceOfResidence
            // 
            this.panel_PlaceOfResidence.AutoScroll = true;
            this.panel_PlaceOfResidence.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel_PlaceOfResidence.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_PlaceOfResidence.Controls.Add(this.button_Further1);
            this.panel_PlaceOfResidence.Controls.Add(this.label_Pass);
            this.panel_PlaceOfResidence.Controls.Add(this.label_FactPlaceOfResidence);
            this.panel_PlaceOfResidence.Controls.Add(this.textBox_FactPlaceOfResidence);
            this.panel_PlaceOfResidence.Controls.Add(this.label_PlaceStateReg);
            this.panel_PlaceOfResidence.Controls.Add(this.textBox_PlaceStateReg);
            this.panel_PlaceOfResidence.Controls.Add(this.label_PassSeries);
            this.panel_PlaceOfResidence.Controls.Add(this.textBox_PassIssuedBy);
            this.panel_PlaceOfResidence.Controls.Add(this.maskedTextBox_PassNumber);
            this.panel_PlaceOfResidence.Controls.Add(this.label_PassNumber);
            this.panel_PlaceOfResidence.Controls.Add(this.dateTimePicker_PassDateIssue);
            this.panel_PlaceOfResidence.Controls.Add(this.label_PassDateIssue);
            this.panel_PlaceOfResidence.Controls.Add(this.label_PassIssuedBy);
            this.panel_PlaceOfResidence.Controls.Add(this.textBox_PassSeries);
            this.panel_PlaceOfResidence.Controls.Add(this.maskedTextBox_PhoneNumber);
            this.panel_PlaceOfResidence.Controls.Add(this.label_PhoneNumber);
            this.panel_PlaceOfResidence.Location = new System.Drawing.Point(6, 868);
            this.panel_PlaceOfResidence.Name = "panel_PlaceOfResidence";
            this.panel_PlaceOfResidence.Size = new System.Drawing.Size(1005, 193);
            this.panel_PlaceOfResidence.TabIndex = 7;
            // 
            // button_Further1
            // 
            this.button_Further1.BackColor = System.Drawing.SystemColors.Info;
            this.button_Further1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Further1.Location = new System.Drawing.Point(568, 141);
            this.button_Further1.Name = "button_Further1";
            this.button_Further1.Size = new System.Drawing.Size(115, 43);
            this.button_Further1.TabIndex = 39;
            this.button_Further1.Text = "Далі";
            this.button_Further1.UseVisualStyleBackColor = false;
            this.button_Further1.Click += new System.EventHandler(this.Button_Further1_Click);
            // 
            // label_Pass
            // 
            this.label_Pass.Location = new System.Drawing.Point(31, 102);
            this.label_Pass.Name = "label_Pass";
            this.label_Pass.Size = new System.Drawing.Size(69, 22);
            this.label_Pass.TabIndex = 388;
            this.label_Pass.Text = "Паспорт";
            this.label_Pass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_FactPlaceOfResidence
            // 
            this.label_FactPlaceOfResidence.Location = new System.Drawing.Point(7, 10);
            this.label_FactPlaceOfResidence.Name = "label_FactPlaceOfResidence";
            this.label_FactPlaceOfResidence.Size = new System.Drawing.Size(194, 56);
            this.label_FactPlaceOfResidence.TabIndex = 385;
            this.label_FactPlaceOfResidence.Text = "Місце фактичного проживання (область,місто,район, буд, квартира)";
            this.label_FactPlaceOfResidence.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox_FactPlaceOfResidence
            // 
            this.textBox_FactPlaceOfResidence.Location = new System.Drawing.Point(207, 10);
            this.textBox_FactPlaceOfResidence.Multiline = true;
            this.textBox_FactPlaceOfResidence.Name = "textBox_FactPlaceOfResidence";
            this.textBox_FactPlaceOfResidence.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_FactPlaceOfResidence.Size = new System.Drawing.Size(197, 59);
            this.textBox_FactPlaceOfResidence.TabIndex = 32;
            // 
            // label_PlaceStateReg
            // 
            this.label_PlaceStateReg.Location = new System.Drawing.Point(415, 13);
            this.label_PlaceStateReg.Name = "label_PlaceStateReg";
            this.label_PlaceStateReg.Size = new System.Drawing.Size(156, 56);
            this.label_PlaceStateReg.TabIndex = 386;
            this.label_PlaceStateReg.Text = "Місце проживання за державною реєстрацією";
            this.label_PlaceStateReg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox_PlaceStateReg
            // 
            this.textBox_PlaceStateReg.Location = new System.Drawing.Point(577, 13);
            this.textBox_PlaceStateReg.Multiline = true;
            this.textBox_PlaceStateReg.Name = "textBox_PlaceStateReg";
            this.textBox_PlaceStateReg.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_PlaceStateReg.Size = new System.Drawing.Size(202, 56);
            this.textBox_PlaceStateReg.TabIndex = 33;
            // 
            // label_PassSeries
            // 
            this.label_PassSeries.Location = new System.Drawing.Point(99, 102);
            this.label_PassSeries.Name = "label_PassSeries";
            this.label_PassSeries.Size = new System.Drawing.Size(52, 22);
            this.label_PassSeries.TabIndex = 389;
            this.label_PassSeries.Text = "Серія:";
            this.label_PassSeries.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_PassIssuedBy
            // 
            this.textBox_PassIssuedBy.Location = new System.Drawing.Point(480, 105);
            this.textBox_PassIssuedBy.Name = "textBox_PassIssuedBy";
            this.textBox_PassIssuedBy.Size = new System.Drawing.Size(238, 21);
            this.textBox_PassIssuedBy.TabIndex = 37;
            // 
            // maskedTextBox_PassNumber
            // 
            this.maskedTextBox_PassNumber.Location = new System.Drawing.Point(318, 103);
            this.maskedTextBox_PassNumber.Name = "maskedTextBox_PassNumber";
            this.maskedTextBox_PassNumber.Size = new System.Drawing.Size(79, 21);
            this.maskedTextBox_PassNumber.TabIndex = 36;
            this.maskedTextBox_PassNumber.Text = "123456";
            this.maskedTextBox_PassNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedTextBox_PassNumber.ValidatingType = typeof(int);
            // 
            // label_PassNumber
            // 
            this.label_PassNumber.Location = new System.Drawing.Point(218, 102);
            this.label_PassNumber.Name = "label_PassNumber";
            this.label_PassNumber.Size = new System.Drawing.Size(82, 22);
            this.label_PassNumber.TabIndex = 390;
            this.label_PassNumber.Text = "Номер:";
            this.label_PassNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateTimePicker_PassDateIssue
            // 
            this.dateTimePicker_PassDateIssue.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_PassDateIssue.Location = new System.Drawing.Point(831, 103);
            this.dateTimePicker_PassDateIssue.Name = "dateTimePicker_PassDateIssue";
            this.dateTimePicker_PassDateIssue.Size = new System.Drawing.Size(84, 21);
            this.dateTimePicker_PassDateIssue.TabIndex = 38;
            // 
            // label_PassDateIssue
            // 
            this.label_PassDateIssue.Location = new System.Drawing.Point(738, 103);
            this.label_PassDateIssue.Name = "label_PassDateIssue";
            this.label_PassDateIssue.Size = new System.Drawing.Size(87, 22);
            this.label_PassDateIssue.TabIndex = 392;
            this.label_PassDateIssue.Text = "Дата видачі:";
            this.label_PassDateIssue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_PassIssuedBy
            // 
            this.label_PassIssuedBy.Location = new System.Drawing.Point(403, 92);
            this.label_PassIssuedBy.Name = "label_PassIssuedBy";
            this.label_PassIssuedBy.Size = new System.Drawing.Size(64, 44);
            this.label_PassIssuedBy.TabIndex = 391;
            this.label_PassIssuedBy.Text = "Ким виданий:";
            this.label_PassIssuedBy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox_PassSeries
            // 
            this.textBox_PassSeries.Location = new System.Drawing.Point(164, 104);
            this.textBox_PassSeries.Name = "textBox_PassSeries";
            this.textBox_PassSeries.Size = new System.Drawing.Size(49, 21);
            this.textBox_PassSeries.TabIndex = 35;
            this.textBox_PassSeries.Text = "WW";
            this.textBox_PassSeries.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // maskedTextBox_PhoneNumber
            // 
            this.maskedTextBox_PhoneNumber.Location = new System.Drawing.Point(831, 45);
            this.maskedTextBox_PhoneNumber.Mask = "(999) 000-0000";
            this.maskedTextBox_PhoneNumber.Name = "maskedTextBox_PhoneNumber";
            this.maskedTextBox_PhoneNumber.Size = new System.Drawing.Size(150, 21);
            this.maskedTextBox_PhoneNumber.TabIndex = 34;
            this.maskedTextBox_PhoneNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_PhoneNumber
            // 
            this.label_PhoneNumber.Location = new System.Drawing.Point(807, 19);
            this.label_PhoneNumber.Name = "label_PhoneNumber";
            this.label_PhoneNumber.Size = new System.Drawing.Size(171, 23);
            this.label_PhoneNumber.TabIndex = 387;
            this.label_PhoneNumber.Text = "Контактний телефон:";
            this.label_PhoneNumber.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel_FamilyStatus
            // 
            this.panel_FamilyStatus.AutoScroll = true;
            this.panel_FamilyStatus.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel_FamilyStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_FamilyStatus.Controls.Add(this.familyCompositiondataGridView);
            this.panel_FamilyStatus.Controls.Add(this.comboBox_FamilyStatus);
            this.panel_FamilyStatus.Controls.Add(this.label_FamilyStatus);
            this.panel_FamilyStatus.Location = new System.Drawing.Point(6, 698);
            this.panel_FamilyStatus.Name = "panel_FamilyStatus";
            this.panel_FamilyStatus.Size = new System.Drawing.Size(1005, 164);
            this.panel_FamilyStatus.TabIndex = 7;
            // 
            // familyCompositiondataGridView
            // 
            this.familyCompositiondataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.familyCompositiondataGridView.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.familyCompositiondataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.familyCompositiondataGridView.ColumnHeadersHeight = 40;
            this.familyCompositiondataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column12,
            this.Column13,
            this.Column14});
            this.familyCompositiondataGridView.Location = new System.Drawing.Point(6, 48);
            this.familyCompositiondataGridView.Name = "familyCompositiondataGridView";
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.familyCompositiondataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle17;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.familyCompositiondataGridView.RowsDefaultCellStyle = dataGridViewCellStyle18;
            this.familyCompositiondataGridView.RowTemplate.Height = 35;
            this.familyCompositiondataGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.familyCompositiondataGridView.Size = new System.Drawing.Size(986, 111);
            this.familyCompositiondataGridView.TabIndex = 31;
            // 
            // Column12
            // 
            this.Column12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column12.FillWeight = 100.4264F;
            this.Column12.HeaderText = "Ступінь родинного зв\'язку";
            this.Column12.Items.AddRange(new object[] {
            "батько",
            "мати",
            "чоловік",
            "дружина",
            "син",
            "дочка"});
            this.Column12.Name = "Column12";
            this.Column12.Width = 148;
            // 
            // Column13
            // 
            this.Column13.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column13.FillWeight = 35.7868F;
            this.Column13.HeaderText = "П.І.Б.";
            this.Column13.Name = "Column13";
            // 
            // Column14
            // 
            this.Column14.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column14.FillWeight = 25.7868F;
            this.Column14.HeaderText = "Рік народження";
            this.Column14.Name = "Column14";
            this.Column14.Width = 114;
            // 
            // comboBox_FamilyStatus
            // 
            this.comboBox_FamilyStatus.FormattingEnabled = true;
            this.comboBox_FamilyStatus.Items.AddRange(new object[] {
            "заміжня",
            "незаміжня",
            "вдова",
            "вдоведь",
            "одружений",
            "не одружений"});
            this.comboBox_FamilyStatus.Location = new System.Drawing.Point(191, 18);
            this.comboBox_FamilyStatus.Name = "comboBox_FamilyStatus";
            this.comboBox_FamilyStatus.Size = new System.Drawing.Size(120, 23);
            this.comboBox_FamilyStatus.TabIndex = 30;
            this.comboBox_FamilyStatus.Text = "(не вказано)";
            // 
            // label_FamilyStatus
            // 
            this.label_FamilyStatus.Location = new System.Drawing.Point(10, 18);
            this.label_FamilyStatus.Name = "label_FamilyStatus";
            this.label_FamilyStatus.Size = new System.Drawing.Size(156, 23);
            this.label_FamilyStatus.TabIndex = 384;
            this.label_FamilyStatus.Text = "Родинний стан:";
            this.label_FamilyStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_Professionallnstitution
            // 
            this.panel_Professionallnstitution.AutoScroll = true;
            this.panel_Professionallnstitution.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel_Professionallnstitution.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Professionallnstitution.Controls.Add(this.afterGraduationDataGridView);
            this.panel_Professionallnstitution.Controls.Add(this.label_Info2);
            this.panel_Professionallnstitution.Controls.Add(this.checkBox__PreparationType3);
            this.panel_Professionallnstitution.Controls.Add(this.checkBox__PreparationType2);
            this.panel_Professionallnstitution.Controls.Add(this.checkBox__PreparationType1);
            this.panel_Professionallnstitution.Controls.Add(this.label_PreparationType);
            this.panel_Professionallnstitution.Location = new System.Drawing.Point(6, 277);
            this.panel_Professionallnstitution.Name = "panel_Professionallnstitution";
            this.panel_Professionallnstitution.Size = new System.Drawing.Size(1005, 164);
            this.panel_Professionallnstitution.TabIndex = 5;
            // 
            // afterGraduationDataGridView
            // 
            this.afterGraduationDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.afterGraduationDataGridView.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.afterGraduationDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.afterGraduationDataGridView.ColumnHeadersHeight = 40;
            this.afterGraduationDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11});
            this.afterGraduationDataGridView.Location = new System.Drawing.Point(3, 47);
            this.afterGraduationDataGridView.Name = "afterGraduationDataGridView";
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.afterGraduationDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle20;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.afterGraduationDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle21;
            this.afterGraduationDataGridView.RowTemplate.Height = 35;
            this.afterGraduationDataGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.afterGraduationDataGridView.Size = new System.Drawing.Size(989, 102);
            this.afterGraduationDataGridView.TabIndex = 17;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column7.FillWeight = 149F;
            this.Column7.HeaderText = "Назва освітнього, наукового закладу";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column8.HeaderText = "Диплом (свідоцтво) серія, номер";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Дата видачи";
            this.Column9.Name = "Column9";
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Рік закінчення";
            this.Column10.Name = "Column10";
            // 
            // Column11
            // 
            this.Column11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column11.HeaderText = "Науковий ступінь, вчене звання";
            this.Column11.Name = "Column11";
            // 
            // label_Info2
            // 
            this.label_Info2.AutoSize = true;
            this.label_Info2.Location = new System.Drawing.Point(4, 9);
            this.label_Info2.Name = "label_Info2";
            this.label_Info2.Size = new System.Drawing.Size(238, 15);
            this.label_Info2.TabIndex = 368;
            this.label_Info2.Text = "Післядипломна професійна підготовка:";
            // 
            // checkBox__PreparationType3
            // 
            this.checkBox__PreparationType3.AutoSize = true;
            this.checkBox__PreparationType3.Location = new System.Drawing.Point(770, 11);
            this.checkBox__PreparationType3.Name = "checkBox__PreparationType3";
            this.checkBox__PreparationType3.Size = new System.Drawing.Size(103, 19);
            this.checkBox__PreparationType3.TabIndex = 16;
            this.checkBox__PreparationType3.Text = "докторантурі";
            this.checkBox__PreparationType3.UseVisualStyleBackColor = true;
            // 
            // checkBox__PreparationType2
            // 
            this.checkBox__PreparationType2.AutoSize = true;
            this.checkBox__PreparationType2.Location = new System.Drawing.Point(643, 11);
            this.checkBox__PreparationType2.Name = "checkBox__PreparationType2";
            this.checkBox__PreparationType2.Size = new System.Drawing.Size(87, 19);
            this.checkBox__PreparationType2.TabIndex = 15;
            this.checkBox__PreparationType2.Text = "ад\'юнктурі";
            this.checkBox__PreparationType2.UseVisualStyleBackColor = true;
            // 
            // checkBox__PreparationType1
            // 
            this.checkBox__PreparationType1.AutoSize = true;
            this.checkBox__PreparationType1.Location = new System.Drawing.Point(496, 11);
            this.checkBox__PreparationType1.Name = "checkBox__PreparationType1";
            this.checkBox__PreparationType1.Size = new System.Drawing.Size(92, 19);
            this.checkBox__PreparationType1.TabIndex = 14;
            this.checkBox__PreparationType1.Text = "аспірантурі";
            this.checkBox__PreparationType1.UseVisualStyleBackColor = true;
            // 
            // label_PreparationType
            // 
            this.label_PreparationType.Location = new System.Drawing.Point(326, 9);
            this.label_PreparationType.Name = "label_PreparationType";
            this.label_PreparationType.Size = new System.Drawing.Size(149, 35);
            this.label_PreparationType.TabIndex = 369;
            this.label_PreparationType.Text = "Навчання в:\r\n(необхідне відмітити Х)\r\n\r\n";
            this.label_PreparationType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_LastWork
            // 
            this.panel_LastWork.AutoScroll = true;
            this.panel_LastWork.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel_LastWork.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_LastWork.Controls.Add(this.label_ProfessionHere);
            this.panel_LastWork.Controls.Add(this.textBox_PensionInfo);
            this.panel_LastWork.Controls.Add(this.comboBox_FireReason);
            this.panel_LastWork.Controls.Add(this.label_BYears);
            this.panel_LastWork.Controls.Add(this.label_WYears);
            this.panel_LastWork.Controls.Add(this.label_BMonth);
            this.panel_LastWork.Controls.Add(this.label_WMonth);
            this.panel_LastWork.Controls.Add(this.label_BDays);
            this.panel_LastWork.Controls.Add(this.label_WDays);
            this.panel_LastWork.Controls.Add(this.label_Benefits);
            this.panel_LastWork.Controls.Add(this.label_Total);
            this.panel_LastWork.Controls.Add(this.label_PensionInfo);
            this.panel_LastWork.Controls.Add(this.label_FireReason);
            this.panel_LastWork.Controls.Add(this.label_FireDate);
            this.panel_LastWork.Controls.Add(this.label_WorkExpirience);
            this.panel_LastWork.Controls.Add(this.maskedTextBox_BYears);
            this.panel_LastWork.Controls.Add(this.maskedTextBox_WYears);
            this.panel_LastWork.Controls.Add(this.maskedTextBox_BMonth);
            this.panel_LastWork.Controls.Add(this.maskedTextBox_WMonth);
            this.panel_LastWork.Controls.Add(this.maskedTextBox_BDays);
            this.panel_LastWork.Controls.Add(this.maskedTextBox_WDays);
            this.panel_LastWork.Controls.Add(this.label_LastWork);
            this.panel_LastWork.Controls.Add(this.textBox_ProfessionHere);
            this.panel_LastWork.Controls.Add(this.dateTimePicker_FireDate);
            this.panel_LastWork.Controls.Add(this.dateTimePicker_WorkExp);
            this.panel_LastWork.Controls.Add(this.textBox_LastWork);
            this.panel_LastWork.Location = new System.Drawing.Point(6, 447);
            this.panel_LastWork.Name = "panel_LastWork";
            this.panel_LastWork.Size = new System.Drawing.Size(1005, 245);
            this.panel_LastWork.TabIndex = 6;
            // 
            // label_ProfessionHere
            // 
            this.label_ProfessionHere.AutoSize = true;
            this.label_ProfessionHere.Location = new System.Drawing.Point(94, 45);
            this.label_ProfessionHere.Name = "label_ProfessionHere";
            this.label_ProfessionHere.Size = new System.Drawing.Size(119, 15);
            this.label_ProfessionHere.TabIndex = 371;
            this.label_ProfessionHere.Text = "Посада (професія):";
            // 
            // textBox_PensionInfo
            // 
            this.textBox_PensionInfo.Location = new System.Drawing.Point(251, 159);
            this.textBox_PensionInfo.Multiline = true;
            this.textBox_PensionInfo.Name = "textBox_PensionInfo";
            this.textBox_PensionInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_PensionInfo.Size = new System.Drawing.Size(268, 62);
            this.textBox_PensionInfo.TabIndex = 22;
            // 
            // comboBox_FireReason
            // 
            this.comboBox_FireReason.FormattingEnabled = true;
            this.comboBox_FireReason.Items.AddRange(new object[] {
            "скорочення штатів",
            "за власним бажанням",
            "прогул",
            "інші порушення",
            "невідповідній займаній посаді"});
            this.comboBox_FireReason.Location = new System.Drawing.Point(251, 118);
            this.comboBox_FireReason.Name = "comboBox_FireReason";
            this.comboBox_FireReason.Size = new System.Drawing.Size(268, 23);
            this.comboBox_FireReason.TabIndex = 21;
            this.comboBox_FireReason.Text = "за власним бажанням";
            // 
            // label_BYears
            // 
            this.label_BYears.Location = new System.Drawing.Point(858, 159);
            this.label_BYears.Name = "label_BYears";
            this.label_BYears.Size = new System.Drawing.Size(52, 32);
            this.label_BYears.TabIndex = 383;
            this.label_BYears.Text = "років";
            this.label_BYears.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_WYears
            // 
            this.label_WYears.Location = new System.Drawing.Point(858, 78);
            this.label_WYears.Name = "label_WYears";
            this.label_WYears.Size = new System.Drawing.Size(52, 32);
            this.label_WYears.TabIndex = 379;
            this.label_WYears.Text = "років";
            this.label_WYears.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_BMonth
            // 
            this.label_BMonth.Location = new System.Drawing.Point(763, 159);
            this.label_BMonth.Name = "label_BMonth";
            this.label_BMonth.Size = new System.Drawing.Size(52, 32);
            this.label_BMonth.TabIndex = 382;
            this.label_BMonth.Text = "місяців";
            this.label_BMonth.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_WMonth
            // 
            this.label_WMonth.Location = new System.Drawing.Point(763, 78);
            this.label_WMonth.Name = "label_WMonth";
            this.label_WMonth.Size = new System.Drawing.Size(52, 32);
            this.label_WMonth.TabIndex = 378;
            this.label_WMonth.Text = "місяців";
            this.label_WMonth.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_BDays
            // 
            this.label_BDays.Location = new System.Drawing.Point(689, 159);
            this.label_BDays.Name = "label_BDays";
            this.label_BDays.Size = new System.Drawing.Size(31, 32);
            this.label_BDays.TabIndex = 381;
            this.label_BDays.Text = "днів";
            this.label_BDays.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_WDays
            // 
            this.label_WDays.Location = new System.Drawing.Point(689, 78);
            this.label_WDays.Name = "label_WDays";
            this.label_WDays.Size = new System.Drawing.Size(31, 32);
            this.label_WDays.TabIndex = 377;
            this.label_WDays.Text = "днів";
            this.label_WDays.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_Benefits
            // 
            this.label_Benefits.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Benefits.Location = new System.Drawing.Point(583, 118);
            this.label_Benefits.Name = "label_Benefits";
            this.label_Benefits.Size = new System.Drawing.Size(269, 41);
            this.label_Benefits.TabIndex = 380;
            this.label_Benefits.Text = "що дає право на надбавку за вислугу років:";
            this.label_Benefits.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_Total
            // 
            this.label_Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Total.Location = new System.Drawing.Point(583, 78);
            this.label_Total.Name = "label_Total";
            this.label_Total.Size = new System.Drawing.Size(62, 32);
            this.label_Total.TabIndex = 376;
            this.label_Total.Text = "Загальний";
            this.label_Total.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_PensionInfo
            // 
            this.label_PensionInfo.Location = new System.Drawing.Point(10, 144);
            this.label_PensionInfo.Name = "label_PensionInfo";
            this.label_PensionInfo.Size = new System.Drawing.Size(235, 82);
            this.label_PensionInfo.TabIndex = 374;
            this.label_PensionInfo.Text = "Відомості про отримання пенсії (у разі наявності вказати вид пенсійних виплат згі" +
    "дно з чинним законодавством)";
            this.label_PensionInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_FireReason
            // 
            this.label_FireReason.Location = new System.Drawing.Point(117, 112);
            this.label_FireReason.Name = "label_FireReason";
            this.label_FireReason.Size = new System.Drawing.Size(125, 32);
            this.label_FireReason.TabIndex = 373;
            this.label_FireReason.Text = "Причина звільнення:";
            this.label_FireReason.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_FireDate
            // 
            this.label_FireDate.Location = new System.Drawing.Point(117, 74);
            this.label_FireDate.Name = "label_FireDate";
            this.label_FireDate.Size = new System.Drawing.Size(106, 32);
            this.label_FireDate.TabIndex = 372;
            this.label_FireDate.Text = "Дата звільнення:";
            this.label_FireDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_WorkExpirience
            // 
            this.label_WorkExpirience.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_WorkExpirience.Location = new System.Drawing.Point(583, 28);
            this.label_WorkExpirience.Name = "label_WorkExpirience";
            this.label_WorkExpirience.Size = new System.Drawing.Size(106, 32);
            this.label_WorkExpirience.TabIndex = 375;
            this.label_WorkExpirience.Text = "Стаж роботи станом на:";
            this.label_WorkExpirience.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // maskedTextBox_BYears
            // 
            this.maskedTextBox_BYears.Location = new System.Drawing.Point(821, 166);
            this.maskedTextBox_BYears.Mask = "0000";
            this.maskedTextBox_BYears.Name = "maskedTextBox_BYears";
            this.maskedTextBox_BYears.Size = new System.Drawing.Size(31, 21);
            this.maskedTextBox_BYears.TabIndex = 29;
            this.maskedTextBox_BYears.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedTextBox_BYears.ValidatingType = typeof(int);
            // 
            // maskedTextBox_WYears
            // 
            this.maskedTextBox_WYears.Location = new System.Drawing.Point(821, 85);
            this.maskedTextBox_WYears.Mask = "0000";
            this.maskedTextBox_WYears.Name = "maskedTextBox_WYears";
            this.maskedTextBox_WYears.Size = new System.Drawing.Size(31, 21);
            this.maskedTextBox_WYears.TabIndex = 26;
            this.maskedTextBox_WYears.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedTextBox_WYears.ValidatingType = typeof(int);
            // 
            // maskedTextBox_BMonth
            // 
            this.maskedTextBox_BMonth.Location = new System.Drawing.Point(726, 166);
            this.maskedTextBox_BMonth.Mask = "00";
            this.maskedTextBox_BMonth.Name = "maskedTextBox_BMonth";
            this.maskedTextBox_BMonth.Size = new System.Drawing.Size(31, 21);
            this.maskedTextBox_BMonth.TabIndex = 28;
            this.maskedTextBox_BMonth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedTextBox_BMonth.ValidatingType = typeof(int);
            // 
            // maskedTextBox_WMonth
            // 
            this.maskedTextBox_WMonth.Location = new System.Drawing.Point(726, 85);
            this.maskedTextBox_WMonth.Mask = "00";
            this.maskedTextBox_WMonth.Name = "maskedTextBox_WMonth";
            this.maskedTextBox_WMonth.Size = new System.Drawing.Size(31, 21);
            this.maskedTextBox_WMonth.TabIndex = 25;
            this.maskedTextBox_WMonth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedTextBox_WMonth.ValidatingType = typeof(int);
            // 
            // maskedTextBox_BDays
            // 
            this.maskedTextBox_BDays.Location = new System.Drawing.Point(652, 166);
            this.maskedTextBox_BDays.Mask = "00";
            this.maskedTextBox_BDays.Name = "maskedTextBox_BDays";
            this.maskedTextBox_BDays.Size = new System.Drawing.Size(31, 21);
            this.maskedTextBox_BDays.TabIndex = 27;
            this.maskedTextBox_BDays.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedTextBox_BDays.ValidatingType = typeof(int);
            // 
            // maskedTextBox_WDays
            // 
            this.maskedTextBox_WDays.Location = new System.Drawing.Point(652, 85);
            this.maskedTextBox_WDays.Mask = "00";
            this.maskedTextBox_WDays.Name = "maskedTextBox_WDays";
            this.maskedTextBox_WDays.Size = new System.Drawing.Size(31, 21);
            this.maskedTextBox_WDays.TabIndex = 24;
            this.maskedTextBox_WDays.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedTextBox_WDays.ValidatingType = typeof(int);
            // 
            // label_LastWork
            // 
            this.label_LastWork.Location = new System.Drawing.Point(75, 12);
            this.label_LastWork.Name = "label_LastWork";
            this.label_LastWork.Size = new System.Drawing.Size(148, 20);
            this.label_LastWork.TabIndex = 370;
            this.label_LastWork.Text = "Останнє місце роботи:";
            this.label_LastWork.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_ProfessionHere
            // 
            this.textBox_ProfessionHere.Location = new System.Drawing.Point(251, 45);
            this.textBox_ProfessionHere.Name = "textBox_ProfessionHere";
            this.textBox_ProfessionHere.Size = new System.Drawing.Size(268, 21);
            this.textBox_ProfessionHere.TabIndex = 19;
            // 
            // dateTimePicker_FireDate
            // 
            this.dateTimePicker_FireDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_FireDate.Location = new System.Drawing.Point(251, 85);
            this.dateTimePicker_FireDate.Name = "dateTimePicker_FireDate";
            this.dateTimePicker_FireDate.Size = new System.Drawing.Size(268, 21);
            this.dateTimePicker_FireDate.TabIndex = 20;
            // 
            // dateTimePicker_WorkExp
            // 
            this.dateTimePicker_WorkExp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_WorkExp.Location = new System.Drawing.Point(695, 32);
            this.dateTimePicker_WorkExp.Name = "dateTimePicker_WorkExp";
            this.dateTimePicker_WorkExp.Size = new System.Drawing.Size(183, 21);
            this.dateTimePicker_WorkExp.TabIndex = 23;
            // 
            // textBox_LastWork
            // 
            this.textBox_LastWork.Location = new System.Drawing.Point(251, 12);
            this.textBox_LastWork.Name = "textBox_LastWork";
            this.textBox_LastWork.Size = new System.Drawing.Size(268, 21);
            this.textBox_LastWork.TabIndex = 18;
            // 
            // panel_Educationalnstitution
            // 
            this.panel_Educationalnstitution.AutoScroll = true;
            this.panel_Educationalnstitution.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel_Educationalnstitution.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Educationalnstitution.Controls.Add(this.label_Info);
            this.panel_Educationalnstitution.Controls.Add(this.DataGridView_Education);
            this.panel_Educationalnstitution.Location = new System.Drawing.Point(6, 115);
            this.panel_Educationalnstitution.Name = "panel_Educationalnstitution";
            this.panel_Educationalnstitution.Size = new System.Drawing.Size(1005, 158);
            this.panel_Educationalnstitution.TabIndex = 4;
            // 
            // label_Info
            // 
            this.label_Info.AutoSize = true;
            this.label_Info.Location = new System.Drawing.Point(3, 9);
            this.label_Info.Name = "label_Info";
            this.label_Info.Size = new System.Drawing.Size(140, 15);
            this.label_Info.TabIndex = 367;
            this.label_Info.Text = "Інформація про освіту:";
            // 
            // DataGridView_Education
            // 
            this.DataGridView_Education.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridView_Education.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle22.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView_Education.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.DataGridView_Education.ColumnHeadersHeight = 40;
            this.DataGridView_Education.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1_Name,
            this.Column2_Diplome,
            this.Column3_Year,
            this.Column4_Specialty,
            this.Column5_qualification,
            this.Column6_FormOfEducation});
            this.DataGridView_Education.Location = new System.Drawing.Point(3, 27);
            this.DataGridView_Education.Name = "DataGridView_Education";
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle23.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView_Education.RowHeadersDefaultCellStyle = dataGridViewCellStyle23;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DataGridView_Education.RowsDefaultCellStyle = dataGridViewCellStyle24;
            this.DataGridView_Education.RowTemplate.Height = 35;
            this.DataGridView_Education.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView_Education.Size = new System.Drawing.Size(989, 123);
            this.DataGridView_Education.TabIndex = 13;
            // 
            // Column1_Name
            // 
            this.Column1_Name.FillWeight = 80F;
            this.Column1_Name.HeaderText = "Назва освітнього закладу";
            this.Column1_Name.Name = "Column1_Name";
            this.Column1_Name.Width = 180;
            // 
            // Column2_Diplome
            // 
            this.Column2_Diplome.HeaderText = "Диплом (свідоцтво), серія, номер";
            this.Column2_Diplome.Name = "Column2_Diplome";
            this.Column2_Diplome.Width = 200;
            // 
            // Column3_Year
            // 
            this.Column3_Year.HeaderText = "Рік закінчення";
            this.Column3_Year.Name = "Column3_Year";
            // 
            // Column4_Specialty
            // 
            this.Column4_Specialty.HeaderText = "Спеціальність (професія) за дипломом (свідоцтвом)";
            this.Column4_Specialty.Name = "Column4_Specialty";
            this.Column4_Specialty.Width = 150;
            // 
            // Column5_qualification
            // 
            this.Column5_qualification.HeaderText = "Кваліфікація за дипломом (свідоцтвом)";
            this.Column5_qualification.Name = "Column5_qualification";
            this.Column5_qualification.Width = 150;
            // 
            // Column6_FormOfEducation
            // 
            this.Column6_FormOfEducation.HeaderText = "Форма навчання (денна, вечірня, заочна)";
            this.Column6_FormOfEducation.Name = "Column6_FormOfEducation";
            this.Column6_FormOfEducation.Width = 150;
            // 
            // groupBox_PersonInformation
            // 
            this.groupBox_PersonInformation.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox_PersonInformation.Controls.Add(this.dateTimePicker_BirthDate);
            this.groupBox_PersonInformation.Controls.Add(this.comboBox_Education);
            this.groupBox_PersonInformation.Controls.Add(this.comboBox_Nationality);
            this.groupBox_PersonInformation.Controls.Add(this.label_Education);
            this.groupBox_PersonInformation.Controls.Add(this.label_Nationality);
            this.groupBox_PersonInformation.Controls.Add(this.label_BirthDate);
            this.groupBox_PersonInformation.Controls.Add(this.textBox_Patronymic);
            this.groupBox_PersonInformation.Controls.Add(this.textBox_Name);
            this.groupBox_PersonInformation.Controls.Add(this.textBox_Surname);
            this.groupBox_PersonInformation.Controls.Add(this.label_Patronymic);
            this.groupBox_PersonInformation.Controls.Add(this.label_Name);
            this.groupBox_PersonInformation.Controls.Add(this.label_Surname);
            this.groupBox_PersonInformation.Location = new System.Drawing.Point(6, -413);
            this.groupBox_PersonInformation.Name = "groupBox_PersonInformation";
            this.groupBox_PersonInformation.Size = new System.Drawing.Size(1005, 103);
            this.groupBox_PersonInformation.TabIndex = 1;
            this.groupBox_PersonInformation.TabStop = false;
            this.groupBox_PersonInformation.Text = "Відомості про особу";
            // 
            // dateTimePicker_BirthDate
            // 
            this.dateTimePicker_BirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_BirthDate.Location = new System.Drawing.Point(469, 63);
            this.dateTimePicker_BirthDate.Name = "dateTimePicker_BirthDate";
            this.dateTimePicker_BirthDate.Size = new System.Drawing.Size(189, 21);
            this.dateTimePicker_BirthDate.TabIndex = 13;
            // 
            // comboBox_Education
            // 
            this.comboBox_Education.FormattingEnabled = true;
            this.comboBox_Education.Items.AddRange(new object[] {
            "базова загальна середня",
            "повна загальна середня",
            "професійно-технічна",
            "неповна вища",
            "базова вища",
            "повна вища"});
            this.comboBox_Education.Location = new System.Drawing.Point(797, 61);
            this.comboBox_Education.Name = "comboBox_Education";
            this.comboBox_Education.Size = new System.Drawing.Size(200, 23);
            this.comboBox_Education.TabIndex = 11;
            // 
            // comboBox_Nationality
            // 
            this.comboBox_Nationality.FormattingEnabled = true;
            this.comboBox_Nationality.Items.AddRange(new object[] {
            "Австралія (офіц. назва - Австралійський Союз)",
            "Австрія (офіц. назва - Республіка Австрія)",
            "Азербайджан (офіц. назва - Азербайджанська Республіка)*",
            "Албанія (офіц. назва - Республіка Албанія)",
            "Андорра (офіц. назва - Князівство Андорра)",
            "Антигуа і Барбуда",
            "Аргентина (офіц. назва - Аргентинська Республіка)",
            "Багами (офіц. назва - Співдружність Багамських островів)",
            "Барбадос",
            "Бахрейн (офіц. назва - Королівство Бахрейн)",
            "Беліз",
            "Бельгія (офіц. назва - Королівство Бельгія)",
            "Білорусь (офіц. назва - Республіка Білорусь)*",
            "Болгарія (офіц. назва - Республіка Болгарія)*",
            "Болівія (офіц. назва - Багатонаціональна Держава Болівія)",
            "Боснія і Герцеговина",
            "Ботсвана (офіц. назва - Республіка Ботсвана)",
            "Бразилія (офіц. назва - Федеративна Республіка Бразилія)",
            "Бруней (офіц. назва - Держава Бруней-Даруссалам)",
            "Бурунді (офіц. назва - Республіка Бурунді)",
            "Вануату (офіц. назва - Республіка Вануату)",
            "Венесуела (офіц. назва - Боліварська Республіка Венесуела)",
            "Вірменія (офіц. назва - Республіка Вірменія)*",
            "Гайана (офіц. назва - Кооперативна Республіка Гайана)",
            "Гватемала (офіц. назва - Республіка Гватемала)",
            "Гондурас (офіц. назва - Республіка Гондурас)",
            "Гренада",
            "Греція (офіц. назва - Грецька Республіка)",
            "Грузія*: Не поширюється на Автономну Республіку Абхазії та колишню Автономну обла" +
                "сть Південної Осетії",
            "Данія (офіц. назва - Королівство Данія): Не поширюється на Гренландію та Фарерськ" +
                "і острови",
            "Домініка (офіц. назва - Співдружність Домініки)",
            "Домініканська Республіка",
            "Еквадор (офіц. назва - Республіка Еквадор)",
            "Естонія (офіц. назва - Естонська Республіка)*",
            "Ізраїль (офіц. назва - Держава Ізраїль)",
            "Індія (офіц. назва - Республіка Індія)",
            "Ірландія (офіц. назва - Республіка Ірландія)",
            "Ісландія",
            "Іспанія (офіц. назва - Королівство Іспанія)",
            "Італія (офіц. назва - Італійська Республіка)",
            "Кабо-Верде (офіц. назва - Республіка Кабо-Верде)",
            "Казахстан (офіц. назва - Республіка Казахстан)*",
            "Киргизстан (офіц. назва - Киргизька Республіка)*",
            "Китай (офіц. назва - Китайська Народна Республіка): Поширюється лише на Гонконг и" +
                " Макао",
            "Кіпр (офіц. назва - Республіка Кіпр)",
            "Колумбія (офіц. назва - Республіка Колумбія)",
            "Королівство Есватіні (до 2018 р. - Королівство Свазіленд)",
            "Королівство Нідерландів",
            "Косово (офіц. назва - Республіка Косово)**",
            "Коста-Рика (офіц. назва - Республіка Коста-Рика)",
            "Латвія (офіц. назва - Латвійська Республіка)*",
            "Лесото (офіц. назва - Королівство Лесото)",
            "Литва (офіц. назва - Литовська Республіка)*",
            "Ліберія (офіц. назва - Республіка Ліберія)",
            "Ліхтенштейн (офіц. назва - Князівство Ліхтенштейн)",
            "Люксембург (офіц. назва - Велике Герцогство Люксембург)",
            "Маврикій (офіц. назва - Республіка Маврикій)",
            "Малаві (офіц. назва - Республіка Малаві)",
            "Мальта (офіц. назва - Республіка Мальта)",
            "Марокко (офіц. назва - Королівство Марокко)",
            "Маршалові Острови (офіц. назва - Республіка Маршалові Острови)",
            "Мексика (офіц. назва - Мексиканські Сполучені Штати)",
            "Молдова (офіц. назва - Республіка Молдова)*",
            "Монако (офіц. назва - Князівство Монако)",
            "Монголія*",
            "Намібія (офіц. назва - Республіка Намібія)",
            "Нікарагуа (офіц. назва - Республіка Нікарагуа)",
            "Німеччина (офіц. назва - Федеративна Республіка Німеччина)",
            "Ніуе",
            "Нова Зеландія: Не поширюється на Токелау",
            "Норвегія (офіц. назва - Королівство Норвегія)",
            "Оман (офіц. назва - Султанат Оман)",
            "Острови Кука",
            "Палау (офіц. назва - Республіка Палау)",
            "Панама (офіц. назва - Республіка Панама)",
            "Парагвай (офіц. назва - Республіка Парагвай)",
            "Перу (офіц. назва - Республіка Перу)",
            "Південно-Африканська Республіка (ПАР)",
            "Північна Македонія (офіц. назва - Республіка Північна Македонія)*",
            "Польща (офіц. назва - Республіка Польща)*",
            "Португалія (офіц. назва - Португальська Республіка)",
            "Республіка Ель Сальвадор",
            "Республіка Корея",
            "Росія (офіц. назва - Російська Федерація)*",
            "Румунія*",
            "Самоа (офіц. назва - Незалежна Держава Самоа)",
            "Сан-Марино (офіц. назва - Найясніша Республіка Сан-Марино)",
            "Сан-Томе і Принсіпі (офіц. назва - Демократична Республіка Сан-Томе і Принсіпі)",
            "Сейшельські острови (офіц. назва - Республіка Сейшельські острови)",
            "Сент-Вінсент і Гренадіни",
            "Сент-Кітс і Невіс (офіц. назва - Федерація Сент-Кітс і Невіс)",
            "Сент-Люсія",
            "Сербія (офіц. назва - Республіка Сербія)*",
            "Сінгапур (офіц. назва - Республіка Сінгапур) - з 16.09.2021",
            "Словаччина (офіц. назва - Словацька Республіка)",
            "Словенія (офіц. назва - Республіка Словенія)",
            "Сполучене Королівство Великобританії та Північної Ірландії: Не поширюється на кра" +
                "їни, які здобувши незалежність (вийшли зі складу Великої Британії) не підписали " +
                "Конвенцію",
            "Сполучені Штати Америки",
            "Суринам (офіц. назва - Республіка Суринам)",
            "Таджикистан (офіц. назва - Республіка Таджикистан)*",
            "Тонга (офіц. назва - Королівство Тонга)",
            "Тринідад і Тобаго (офіц. назва - Республіка Тринідад і Тобаго)",
            "Туніс (офіц. назва - Туніська Республіка)",
            "Туреччина (офіц. назва - Турецька Республіка)",
            "Угорщина*",
            "Узбекистан (офіц. назва - Республіка Узбекистан)*",
            "Україна (Не поширюється на тимчасово окуповані території Донецької і Луганської о" +
                "бластей, Автономну Республіку Крим та м. Севастополь)",
            "Уругвай (офіц. назва - Східна Республіка Уругвай)",
            "Фіджі (офіц. назва - Республіка Фіджі)",
            "Філіппіни (офіц. назва - Республіка Філіппіни)",
            "Фінляндія (офіц. назва - Фінляндська Республіка)",
            "Франція (офіц. назва - Французька Республіка)",
            "Хорватія (офіц. назва - Республіка Хорватія)",
            "Чехія (офіц. назва - Чеська Республіка)*",
            "Чилі (офіц. назва - Республіка Чилі)",
            "Чорногорія",
            "Швейцарія (офіц. назва - Швейцарська Конфедерація)",
            "Швеція (офіц. назва - Королівство Швеція)",
            "Ямайка - з 03.07.2021",
            "Японія (офіц. назва - Японська Держава)"});
            this.comboBox_Nationality.Location = new System.Drawing.Point(123, 61);
            this.comboBox_Nationality.Name = "comboBox_Nationality";
            this.comboBox_Nationality.Size = new System.Drawing.Size(189, 23);
            this.comboBox_Nationality.TabIndex = 12;
            // 
            // label_Education
            // 
            this.label_Education.Location = new System.Drawing.Point(723, 58);
            this.label_Education.Name = "label_Education";
            this.label_Education.Size = new System.Drawing.Size(59, 26);
            this.label_Education.TabIndex = 8;
            this.label_Education.Text = "Освіта:";
            this.label_Education.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Nationality
            // 
            this.label_Nationality.Location = new System.Drawing.Point(10, 58);
            this.label_Nationality.Name = "label_Nationality";
            this.label_Nationality.Size = new System.Drawing.Size(102, 26);
            this.label_Nationality.TabIndex = 9;
            this.label_Nationality.Text = "Громадянство:";
            this.label_Nationality.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_BirthDate
            // 
            this.label_BirthDate.Location = new System.Drawing.Point(327, 61);
            this.label_BirthDate.Name = "label_BirthDate";
            this.label_BirthDate.Size = new System.Drawing.Size(129, 25);
            this.label_BirthDate.TabIndex = 10;
            this.label_BirthDate.Text = "Дата народження:";
            this.label_BirthDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_Patronymic
            // 
            this.textBox_Patronymic.Location = new System.Drawing.Point(795, 28);
            this.textBox_Patronymic.Name = "textBox_Patronymic";
            this.textBox_Patronymic.Size = new System.Drawing.Size(202, 21);
            this.textBox_Patronymic.TabIndex = 5;
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(467, 28);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(189, 21);
            this.textBox_Name.TabIndex = 6;
            // 
            // textBox_Surname
            // 
            this.textBox_Surname.Location = new System.Drawing.Point(123, 28);
            this.textBox_Surname.Name = "textBox_Surname";
            this.textBox_Surname.Size = new System.Drawing.Size(189, 21);
            this.textBox_Surname.TabIndex = 7;
            // 
            // label_Patronymic
            // 
            this.label_Patronymic.Location = new System.Drawing.Point(678, 28);
            this.label_Patronymic.Name = "label_Patronymic";
            this.label_Patronymic.Size = new System.Drawing.Size(102, 21);
            this.label_Patronymic.TabIndex = 2;
            this.label_Patronymic.Text = "По батькові:";
            this.label_Patronymic.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Name
            // 
            this.label_Name.Location = new System.Drawing.Point(401, 28);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(53, 21);
            this.label_Name.TabIndex = 3;
            this.label_Name.Text = "Ім\'я:";
            this.label_Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Surname
            // 
            this.label_Surname.Location = new System.Drawing.Point(32, 28);
            this.label_Surname.Name = "label_Surname";
            this.label_Surname.Size = new System.Drawing.Size(78, 21);
            this.label_Surname.TabIndex = 4;
            this.label_Surname.Text = "Прізвище:";
            this.label_Surname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage_MilitaryAccounting
            // 
            this.tabPage_MilitaryAccounting.AutoScroll = true;
            this.tabPage_MilitaryAccounting.Controls.Add(this.button_Back1);
            this.tabPage_MilitaryAccounting.Controls.Add(this.button_Further2);
            this.tabPage_MilitaryAccounting.Location = new System.Drawing.Point(4, 24);
            this.tabPage_MilitaryAccounting.Name = "tabPage_MilitaryAccounting";
            this.tabPage_MilitaryAccounting.Size = new System.Drawing.Size(1029, 640);
            this.tabPage_MilitaryAccounting.TabIndex = 2;
            this.tabPage_MilitaryAccounting.Text = "2. Відомості про військовий облік";
            this.tabPage_MilitaryAccounting.UseVisualStyleBackColor = true;
            // 
            // button_Back1
            // 
            this.button_Back1.BackColor = System.Drawing.SystemColors.Info;
            this.button_Back1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Back1.Location = new System.Drawing.Point(131, 24);
            this.button_Back1.Name = "button_Back1";
            this.button_Back1.Size = new System.Drawing.Size(115, 43);
            this.button_Back1.TabIndex = 98;
            this.button_Back1.Text = "Назад";
            this.button_Back1.UseVisualStyleBackColor = false;
            this.button_Back1.Click += new System.EventHandler(this.Button_Back1_Click);
            // 
            // button_Further2
            // 
            this.button_Further2.BackColor = System.Drawing.SystemColors.Info;
            this.button_Further2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Further2.Location = new System.Drawing.Point(289, 24);
            this.button_Further2.Name = "button_Further2";
            this.button_Further2.Size = new System.Drawing.Size(115, 43);
            this.button_Further2.TabIndex = 97;
            this.button_Further2.Text = "Далі";
            this.button_Further2.UseVisualStyleBackColor = false;
            this.button_Further2.Click += new System.EventHandler(this.Button_Further2_Click);
            // 
            // tabPage_EducationInProduction
            // 
            this.tabPage_EducationInProduction.AutoScroll = true;
            this.tabPage_EducationInProduction.AutoScrollMargin = new System.Drawing.Size(2, 2);
            this.tabPage_EducationInProduction.AutoScrollMinSize = new System.Drawing.Size(2, 2);
            this.tabPage_EducationInProduction.Controls.Add(this.panel1);
            this.tabPage_EducationInProduction.Location = new System.Drawing.Point(4, 24);
            this.tabPage_EducationInProduction.Name = "tabPage_EducationInProduction";
            this.tabPage_EducationInProduction.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_EducationInProduction.Size = new System.Drawing.Size(1029, 640);
            this.tabPage_EducationInProduction.TabIndex = 1;
            this.tabPage_EducationInProduction.Text = "3. Професійна освіта на виробництві";
            this.tabPage_EducationInProduction.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.ProfEducationDataGridView);
            this.panel1.Controls.Add(this.button_Further3);
            this.panel1.Controls.Add(this.button_Back2);
            this.panel1.Location = new System.Drawing.Point(6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1004, 472);
            this.panel1.TabIndex = 99;
            // 
            // ProfEducationDataGridView
            // 
            this.ProfEducationDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProfEducationDataGridView.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle25.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle25.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle25.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle25.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle25.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProfEducationDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle25;
            this.ProfEducationDataGridView.ColumnHeadersHeight = 100;
            this.ProfEducationDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1_Date,
            this.Column2_struct,
            this.Column3_Interval,
            this.Column4_Type,
            this.Column5_Form,
            this.Column6_NameDok});
            this.ProfEducationDataGridView.Location = new System.Drawing.Point(3, 3);
            this.ProfEducationDataGridView.Name = "ProfEducationDataGridView";
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle26.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle26.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProfEducationDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle26;
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ProfEducationDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle27;
            this.ProfEducationDataGridView.RowTemplate.Height = 35;
            this.ProfEducationDataGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ProfEducationDataGridView.Size = new System.Drawing.Size(998, 396);
            this.ProfEducationDataGridView.TabIndex = 2;
            // 
            // Column1_Date
            // 
            this.Column1_Date.HeaderText = "Дата";
            this.Column1_Date.Name = "Column1_Date";
            this.Column1_Date.Width = 50;
            // 
            // Column2_struct
            // 
            this.Column2_struct.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2_struct.HeaderText = "Назва стуктурного підрозділу";
            this.Column2_struct.Name = "Column2_struct";
            // 
            // Column3_Interval
            // 
            this.Column3_Interval.HeaderText = "Період навчання";
            this.Column3_Interval.Name = "Column3_Interval";
            // 
            // Column4_Type
            // 
            this.Column4_Type.HeaderText = "Вид навчання";
            this.Column4_Type.Name = "Column4_Type";
            // 
            // Column5_Form
            // 
            this.Column5_Form.HeaderText = "Форма навчання";
            this.Column5_Form.Items.AddRange(new object[] {
            "денна",
            "заочна",
            "інтернатура",
            ""});
            this.Column5_Form.Name = "Column5_Form";
            // 
            // Column6_NameDok
            // 
            this.Column6_NameDok.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column6_NameDok.HeaderText = "Назва документа, що посвідчує професійну освіту, ким виданий";
            this.Column6_NameDok.Name = "Column6_NameDok";
            // 
            // button_Further3
            // 
            this.button_Further3.BackColor = System.Drawing.SystemColors.Info;
            this.button_Further3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Further3.Location = new System.Drawing.Point(615, 405);
            this.button_Further3.Name = "button_Further3";
            this.button_Further3.Size = new System.Drawing.Size(115, 43);
            this.button_Further3.TabIndex = 97;
            this.button_Further3.Text = "Далі";
            this.button_Further3.UseVisualStyleBackColor = false;
            this.button_Further3.Click += new System.EventHandler(this.Button_Further3_Click);
            // 
            // button_Back2
            // 
            this.button_Back2.BackColor = System.Drawing.SystemColors.Info;
            this.button_Back2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Back2.Location = new System.Drawing.Point(230, 405);
            this.button_Back2.Name = "button_Back2";
            this.button_Back2.Size = new System.Drawing.Size(115, 43);
            this.button_Back2.TabIndex = 98;
            this.button_Back2.Text = "Назад";
            this.button_Back2.UseVisualStyleBackColor = false;
            this.button_Back2.Click += new System.EventHandler(this.Button_Back2_Click);
            // 
            // tabPage_AppointmentAndTransfer
            // 
            this.tabPage_AppointmentAndTransfer.AutoScroll = true;
            this.tabPage_AppointmentAndTransfer.Controls.Add(this.button_Back3);
            this.tabPage_AppointmentAndTransfer.Controls.Add(this.button_Further4);
            this.tabPage_AppointmentAndTransfer.Location = new System.Drawing.Point(4, 24);
            this.tabPage_AppointmentAndTransfer.Name = "tabPage_AppointmentAndTransfer";
            this.tabPage_AppointmentAndTransfer.Size = new System.Drawing.Size(1029, 640);
            this.tabPage_AppointmentAndTransfer.TabIndex = 3;
            this.tabPage_AppointmentAndTransfer.Text = "4. Призначення і переведення";
            this.tabPage_AppointmentAndTransfer.UseVisualStyleBackColor = true;
            // 
            // button_Back3
            // 
            this.button_Back3.BackColor = System.Drawing.SystemColors.Info;
            this.button_Back3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Back3.Location = new System.Drawing.Point(236, 57);
            this.button_Back3.Name = "button_Back3";
            this.button_Back3.Size = new System.Drawing.Size(115, 43);
            this.button_Back3.TabIndex = 98;
            this.button_Back3.Text = "Назад";
            this.button_Back3.UseVisualStyleBackColor = false;
            this.button_Back3.Click += new System.EventHandler(this.Button_Back3_Click);
            // 
            // button_Further4
            // 
            this.button_Further4.BackColor = System.Drawing.SystemColors.Info;
            this.button_Further4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Further4.Location = new System.Drawing.Point(583, 57);
            this.button_Further4.Name = "button_Further4";
            this.button_Further4.Size = new System.Drawing.Size(115, 43);
            this.button_Further4.TabIndex = 97;
            this.button_Further4.Text = "Далі";
            this.button_Further4.UseVisualStyleBackColor = false;
            this.button_Further4.Click += new System.EventHandler(this.Button_Further4_Click);
            // 
            // tabPage_Holidays
            // 
            this.tabPage_Holidays.AutoScroll = true;
            this.tabPage_Holidays.Controls.Add(this.panel2);
            this.tabPage_Holidays.Location = new System.Drawing.Point(4, 24);
            this.tabPage_Holidays.Name = "tabPage_Holidays";
            this.tabPage_Holidays.Size = new System.Drawing.Size(1029, 640);
            this.tabPage_Holidays.TabIndex = 4;
            this.tabPage_Holidays.Text = "5. Відпустки";
            this.tabPage_Holidays.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel2.Controls.Add(this.VacationsDataGridView);
            this.panel2.Controls.Add(this.button_Save);
            this.panel2.Controls.Add(this.button_back4);
            this.panel2.Location = new System.Drawing.Point(2, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1008, 475);
            this.panel2.TabIndex = 98;
            // 
            // VacationsDataGridView
            // 
            this.VacationsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.VacationsDataGridView.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle28.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle28.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle28.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle28.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle28.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle28.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.VacationsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle28;
            this.VacationsDataGridView.ColumnHeadersHeight = 50;
            this.VacationsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column21,
            this.Column22,
            this.Column23,
            this.Column24,
            this.Column25});
            this.VacationsDataGridView.Location = new System.Drawing.Point(3, 3);
            this.VacationsDataGridView.Name = "VacationsDataGridView";
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle29.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle29.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle29.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle29.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle29.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.VacationsDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle29;
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.VacationsDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle30;
            this.VacationsDataGridView.RowTemplate.Height = 35;
            this.VacationsDataGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.VacationsDataGridView.Size = new System.Drawing.Size(1002, 359);
            this.VacationsDataGridView.TabIndex = 98;
            // 
            // Column21
            // 
            this.Column21.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column21.HeaderText = "Вид відпустки";
            this.Column21.Name = "Column21";
            // 
            // Column22
            // 
            this.Column22.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column22.HeaderText = "За який період";
            this.Column22.Name = "Column22";
            // 
            // Column23
            // 
            this.Column23.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column23.HeaderText = "Дата початку відпустки";
            this.Column23.Name = "Column23";
            // 
            // Column24
            // 
            this.Column24.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column24.HeaderText = "Дата закінчення відпустки";
            this.Column24.Name = "Column24";
            // 
            // Column25
            // 
            this.Column25.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column25.HeaderText = "Підстава, наказ №";
            this.Column25.Name = "Column25";
            // 
            // button_Save
            // 
            this.button_Save.Image = ((System.Drawing.Image)(resources.GetObject("button_Save.Image")));
            this.button_Save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Save.Location = new System.Drawing.Point(843, 420);
            this.button_Save.Name = "button_Save";
            this.button_Save.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button_Save.Size = new System.Drawing.Size(149, 43);
            this.button_Save.TabIndex = 96;
            this.button_Save.Text = "Зберегти форму";
            this.button_Save.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.Button_Save_Click);
            // 
            // button_back4
            // 
            this.button_back4.BackColor = System.Drawing.SystemColors.Info;
            this.button_back4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_back4.Location = new System.Drawing.Point(185, 420);
            this.button_back4.Name = "button_back4";
            this.button_back4.Size = new System.Drawing.Size(115, 43);
            this.button_back4.TabIndex = 97;
            this.button_back4.Text = "Назад";
            this.button_back4.UseVisualStyleBackColor = false;
            this.button_back4.Click += new System.EventHandler(this.Button_back4_Click);
            // 
            // groupBox_Cap
            // 
            this.groupBox_Cap.Controls.Add(this.button_Open);
            this.groupBox_Cap.Controls.Add(this.pictureBox_Photo);
            this.groupBox_Cap.Controls.Add(this.comboBox_WorkType);
            this.groupBox_Cap.Controls.Add(this.label_WorkType);
            this.groupBox_Cap.Controls.Add(this.comboBox_Gender);
            this.groupBox_Cap.Controls.Add(this.label_Gender);
            this.groupBox_Cap.Controls.Add(this.maskedTextBox_IPN);
            this.groupBox_Cap.Controls.Add(this.label_IPN);
            this.groupBox_Cap.Controls.Add(this.maskedTextBox_TabNumber);
            this.groupBox_Cap.Controls.Add(this.label_TabNumber);
            this.groupBox_Cap.Controls.Add(this.dateTimePicker_FillDate);
            this.groupBox_Cap.Controls.Add(this.label_Date);
            this.groupBox_Cap.Location = new System.Drawing.Point(246, 52);
            this.groupBox_Cap.Name = "groupBox_Cap";
            this.groupBox_Cap.Size = new System.Drawing.Size(796, 126);
            this.groupBox_Cap.TabIndex = 2;
            this.groupBox_Cap.TabStop = false;
            // 
            // button_Open
            // 
            this.button_Open.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_Open.Image = ((System.Drawing.Image)(resources.GetObject("button_Open.Image")));
            this.button_Open.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Open.Location = new System.Drawing.Point(656, 51);
            this.button_Open.Name = "button_Open";
            this.button_Open.Size = new System.Drawing.Size(118, 40);
            this.button_Open.TabIndex = 94;
            this.button_Open.Text = "Завантажити картку";
            this.button_Open.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_Open.UseVisualStyleBackColor = true;
            this.button_Open.Click += new System.EventHandler(this.Button_Open_Click);
            // 
            // pictureBox_Photo
            // 
            this.pictureBox_Photo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_Photo.Image = global::HW_5_IdentityCards.Properties.Resources.Загрузить_фото;
            this.pictureBox_Photo.Location = new System.Drawing.Point(538, 19);
            this.pictureBox_Photo.Name = "pictureBox_Photo";
            this.pictureBox_Photo.Size = new System.Drawing.Size(105, 100);
            this.pictureBox_Photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Photo.TabIndex = 12;
            this.pictureBox_Photo.TabStop = false;
            this.pictureBox_Photo.Click += new System.EventHandler(this.pictureBox_Photo_Click);
            // 
            // comboBox_WorkType
            // 
            this.comboBox_WorkType.FormattingEnabled = true;
            this.comboBox_WorkType.Items.AddRange(new object[] {
            "Основна",
            "За сумісництвом"});
            this.comboBox_WorkType.Location = new System.Drawing.Point(413, 76);
            this.comboBox_WorkType.Name = "comboBox_WorkType";
            this.comboBox_WorkType.Size = new System.Drawing.Size(113, 23);
            this.comboBox_WorkType.TabIndex = 6;
            // 
            // label_WorkType
            // 
            this.label_WorkType.Location = new System.Drawing.Point(418, 25);
            this.label_WorkType.Name = "label_WorkType";
            this.label_WorkType.Size = new System.Drawing.Size(107, 43);
            this.label_WorkType.TabIndex = 357;
            this.label_WorkType.Text = "Вид роботи";
            this.label_WorkType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox_Gender
            // 
            this.comboBox_Gender.FormattingEnabled = true;
            this.comboBox_Gender.Items.AddRange(new object[] {
            "Чоловіча",
            "Жіноча",
            "Не вказано"});
            this.comboBox_Gender.Location = new System.Drawing.Point(301, 76);
            this.comboBox_Gender.Name = "comboBox_Gender";
            this.comboBox_Gender.Size = new System.Drawing.Size(104, 23);
            this.comboBox_Gender.TabIndex = 5;
            // 
            // label_Gender
            // 
            this.label_Gender.Location = new System.Drawing.Point(309, 25);
            this.label_Gender.Name = "label_Gender";
            this.label_Gender.Size = new System.Drawing.Size(96, 41);
            this.label_Gender.TabIndex = 356;
            this.label_Gender.Text = "Стать";
            this.label_Gender.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // maskedTextBox_IPN
            // 
            this.maskedTextBox_IPN.Location = new System.Drawing.Point(200, 77);
            this.maskedTextBox_IPN.Mask = "0000000000";
            this.maskedTextBox_IPN.Name = "maskedTextBox_IPN";
            this.maskedTextBox_IPN.Size = new System.Drawing.Size(95, 21);
            this.maskedTextBox_IPN.TabIndex = 4;
            this.maskedTextBox_IPN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedTextBox_IPN.ValidatingType = typeof(int);
            // 
            // label_IPN
            // 
            this.label_IPN.Location = new System.Drawing.Point(200, 30);
            this.label_IPN.Name = "label_IPN";
            this.label_IPN.Size = new System.Drawing.Size(95, 41);
            this.label_IPN.TabIndex = 355;
            this.label_IPN.Text = "Індивідуальний податковий номер";
            this.label_IPN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // maskedTextBox_TabNumber
            // 
            this.maskedTextBox_TabNumber.Location = new System.Drawing.Point(103, 77);
            this.maskedTextBox_TabNumber.Mask = "0000000";
            this.maskedTextBox_TabNumber.Name = "maskedTextBox_TabNumber";
            this.maskedTextBox_TabNumber.Size = new System.Drawing.Size(91, 21);
            this.maskedTextBox_TabNumber.TabIndex = 3;
            this.maskedTextBox_TabNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedTextBox_TabNumber.ValidatingType = typeof(int);
            // 
            // label_TabNumber
            // 
            this.label_TabNumber.Location = new System.Drawing.Point(108, 27);
            this.label_TabNumber.Name = "label_TabNumber";
            this.label_TabNumber.Size = new System.Drawing.Size(77, 41);
            this.label_TabNumber.TabIndex = 354;
            this.label_TabNumber.Text = "Табельний номер";
            this.label_TabNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateTimePicker_FillDate
            // 
            this.dateTimePicker_FillDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_FillDate.Location = new System.Drawing.Point(6, 77);
            this.dateTimePicker_FillDate.Name = "dateTimePicker_FillDate";
            this.dateTimePicker_FillDate.Size = new System.Drawing.Size(91, 21);
            this.dateTimePicker_FillDate.TabIndex = 2;
            this.dateTimePicker_FillDate.Value = new System.DateTime(2021, 9, 16, 20, 51, 35, 0);
            // 
            // label_Date
            // 
            this.label_Date.Location = new System.Drawing.Point(6, 19);
            this.label_Date.Name = "label_Date";
            this.label_Date.Size = new System.Drawing.Size(85, 41);
            this.label_Date.TabIndex = 353;
            this.label_Date.Text = "Дата заповнення";
            this.label_Date.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip_Clouse
            // 
            this.menuStrip_Clouse.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.styleToolStripMenuItem});
            this.menuStrip_Clouse.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_Clouse.Name = "menuStrip_Clouse";
            this.menuStrip_Clouse.Size = new System.Drawing.Size(1043, 24);
            this.menuStrip_Clouse.TabIndex = 3;
            this.menuStrip_Clouse.Text = "Закрыть";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem,
            this.openToolStripMenuItem,
            this.clearToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.FileToolStripMenuItem.Text = "File";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.CloseToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // styleToolStripMenuItem
            // 
            this.styleToolStripMenuItem.CheckOnClick = true;
            this.styleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.blueToolStripMenuItem});
            this.styleToolStripMenuItem.Name = "styleToolStripMenuItem";
            this.styleToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.styleToolStripMenuItem.Text = "Style";
            // 
            // blueToolStripMenuItem
            // 
            this.blueToolStripMenuItem.Checked = true;
            this.blueToolStripMenuItem.CheckOnClick = true;
            this.blueToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.blueToolStripMenuItem.Name = "blueToolStripMenuItem";
            this.blueToolStripMenuItem.Size = new System.Drawing.Size(97, 22);
            this.blueToolStripMenuItem.Text = "Blue";
            this.blueToolStripMenuItem.Click += new System.EventHandler(this.BlueToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 852);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1043, 22);
            this.statusStrip1.TabIndex = 359;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(439, 17);
            this.toolStripStatusLabel1.Text = "Кнопка збереження знаходиться в кінці картки. Заповніть всі поля, будь-ласка";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_Open,
            this.toolStripButton_Clear,
            this.toolStripButton_Save});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1043, 25);
            this.toolStrip1.TabIndex = 360;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton_Open
            // 
            this.toolStripButton_Open.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_Open.Image = global::HW_5_IdentityCards.Properties.Resources.open;
            this.toolStripButton_Open.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Open.Name = "toolStripButton_Open";
            this.toolStripButton_Open.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton_Open.Text = "Відкрити картку";
            this.toolStripButton_Open.Click += new System.EventHandler(this.toolStripButton_Open_Click);
            // 
            // toolStripButton_Clear
            // 
            this.toolStripButton_Clear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_Clear.Image = global::HW_5_IdentityCards.Properties.Resources.clear;
            this.toolStripButton_Clear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Clear.Name = "toolStripButton_Clear";
            this.toolStripButton_Clear.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton_Clear.Text = "Очистити картку";
            this.toolStripButton_Clear.Click += new System.EventHandler(this.toolStripButton_Clear_Click);
            // 
            // toolStripButton_Save
            // 
            this.toolStripButton_Save.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_Save.Image = global::HW_5_IdentityCards.Properties.Resources.save;
            this.toolStripButton_Save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Save.Name = "toolStripButton_Save";
            this.toolStripButton_Save.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton_Save.Text = "Зберегти картку";
            this.toolStripButton_Save.Click += new System.EventHandler(this.toolStripButton_Save_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(0, 17);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1059, 713);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox_Cap);
            this.Controls.Add(this.tabControl_general);
            this.Controls.Add(this.groupBox_Info1);
            this.Controls.Add(this.menuStrip_Clouse);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenuStrip = this.menuStrip_Clouse;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1300, 1100);
            this.MinimumSize = new System.Drawing.Size(1075, 750);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Особова кaртка працівника";
            this.groupBox_Info1.ResumeLayout(false);
            this.groupBox_Info1.PerformLayout();
            this.tabControl_general.ResumeLayout(false);
            this.tabPage_GeneralInformation.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel_PlaceOfResidence.ResumeLayout(false);
            this.panel_PlaceOfResidence.PerformLayout();
            this.panel_FamilyStatus.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.familyCompositiondataGridView)).EndInit();
            this.panel_Professionallnstitution.ResumeLayout(false);
            this.panel_Professionallnstitution.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.afterGraduationDataGridView)).EndInit();
            this.panel_LastWork.ResumeLayout(false);
            this.panel_LastWork.PerformLayout();
            this.panel_Educationalnstitution.ResumeLayout(false);
            this.panel_Educationalnstitution.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_Education)).EndInit();
            this.groupBox_PersonInformation.ResumeLayout(false);
            this.groupBox_PersonInformation.PerformLayout();
            this.tabPage_MilitaryAccounting.ResumeLayout(false);
            this.tabPage_EducationInProduction.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProfEducationDataGridView)).EndInit();
            this.tabPage_AppointmentAndTransfer.ResumeLayout(false);
            this.tabPage_Holidays.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.VacationsDataGridView)).EndInit();
            this.groupBox_Cap.ResumeLayout(false);
            this.groupBox_Cap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Photo)).EndInit();
            this.menuStrip_Clouse.ResumeLayout(false);
            this.menuStrip_Clouse.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_Info1;
        private System.Windows.Forms.ComboBox comboBox_CompanyCode;
        private System.Windows.Forms.Label label_CompanyCode;
        private System.Windows.Forms.ComboBox comboBox_CompanyName;
        private System.Windows.Forms.Label label_CompanyName;
        private System.Windows.Forms.TabControl tabControl_general;
        private System.Windows.Forms.TabPage tabPage_MilitaryAccounting;
        private System.Windows.Forms.TabPage tabPage_EducationInProduction;
        private System.Windows.Forms.TabPage tabPage_AppointmentAndTransfer;
        private System.Windows.Forms.TabPage tabPage_Holidays;
        private System.Windows.Forms.GroupBox groupBox_Cap;
        private System.Windows.Forms.Label label_WorkType;
        private System.Windows.Forms.Label label_Gender;
        private System.Windows.Forms.Label label_IPN;
        private System.Windows.Forms.Label label_TabNumber;
        private System.Windows.Forms.Label label_Date;
        private System.Windows.Forms.ComboBox comboBox_WorkType;
        private System.Windows.Forms.ComboBox comboBox_Gender;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_IPN;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_TabNumber;
        private System.Windows.Forms.DateTimePicker dateTimePicker_FillDate;
        private System.Windows.Forms.PictureBox pictureBox_Photo;
        private System.Windows.Forms.TabPage tabPage_GeneralInformation;
        private System.Windows.Forms.GroupBox groupBox_PersonInformation;
        private System.Windows.Forms.DateTimePicker dateTimePicker_BirthDate;
        private System.Windows.Forms.ComboBox comboBox_Education;
        private System.Windows.Forms.ComboBox comboBox_Nationality;
        private System.Windows.Forms.Label label_Education;
        private System.Windows.Forms.Label label_Nationality;
        private System.Windows.Forms.Label label_BirthDate;
        private System.Windows.Forms.TextBox textBox_Patronymic;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.TextBox textBox_Surname;
        private System.Windows.Forms.Label label_Patronymic;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.Label label_Surname;
        private System.Windows.Forms.Panel panel_Professionallnstitution;
        private System.Windows.Forms.Panel panel_Educationalnstitution;
        private System.Windows.Forms.Panel panel_LastWork;
        private System.Windows.Forms.CheckBox checkBox__PreparationType3;
        private System.Windows.Forms.CheckBox checkBox__PreparationType2;
        private System.Windows.Forms.CheckBox checkBox__PreparationType1;
        private System.Windows.Forms.Label label_PreparationType;
        private System.Windows.Forms.Panel panel_PlaceOfResidence;
        private System.Windows.Forms.Panel panel_FamilyStatus;
        private System.Windows.Forms.Label label_Pass;
        private System.Windows.Forms.Label label_FactPlaceOfResidence;
        private System.Windows.Forms.TextBox textBox_FactPlaceOfResidence;
        private System.Windows.Forms.Label label_PlaceStateReg;
        private System.Windows.Forms.TextBox textBox_PlaceStateReg;
        private System.Windows.Forms.Label label_PassSeries;
        private System.Windows.Forms.TextBox textBox_PassIssuedBy;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_PassNumber;
        private System.Windows.Forms.Label label_PassNumber;
        private System.Windows.Forms.DateTimePicker dateTimePicker_PassDateIssue;
        private System.Windows.Forms.Label label_PassDateIssue;
        private System.Windows.Forms.Label label_PassIssuedBy;
        private System.Windows.Forms.TextBox textBox_PassSeries;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_PhoneNumber;
        private System.Windows.Forms.Label label_PhoneNumber;
        private System.Windows.Forms.ComboBox comboBox_FamilyStatus;
        private System.Windows.Forms.Label label_FamilyStatus;
        private System.Windows.Forms.TextBox textBox_PensionInfo;
        private System.Windows.Forms.ComboBox comboBox_FireReason;
        private System.Windows.Forms.Label label_BYears;
        private System.Windows.Forms.Label label_WYears;
        private System.Windows.Forms.Label label_BMonth;
        private System.Windows.Forms.Label label_WMonth;
        private System.Windows.Forms.Label label_BDays;
        private System.Windows.Forms.Label label_WDays;
        private System.Windows.Forms.Label label_Benefits;
        private System.Windows.Forms.Label label_Total;
        private System.Windows.Forms.Label label_PensionInfo;
        private System.Windows.Forms.Label label_FireReason;
        private System.Windows.Forms.Label label_FireDate;
        private System.Windows.Forms.Label label_WorkExpirience;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_BYears;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_WYears;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_BMonth;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_WMonth;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_BDays;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_WDays;
        private System.Windows.Forms.Label label_LastWork;
        private System.Windows.Forms.TextBox textBox_ProfessionHere;
        private System.Windows.Forms.DateTimePicker dateTimePicker_FireDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker_WorkExp;
        private System.Windows.Forms.TextBox textBox_LastWork;
        private System.Windows.Forms.Label label_ProfessionHere;
        private System.Windows.Forms.MenuStrip menuStrip_Clouse;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem styleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blueToolStripMenuItem;
        private System.Windows.Forms.Button button_Further1;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.Button button_Open;

        

        private Button button_Back1;
        private Button button_Further2;
        private Button button_Back2;
        private Button button_Further3;
        private Button button_Back3;
        private Button button_Further4;
        private Button button_back4;
        private SaveFileDialog saveFileDialog1;
        private OpenFileDialog openFileDialog1;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem clearToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private DataGridView DataGridView_Education;
        private DataGridView afterGraduationDataGridView;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column10;
        private DataGridViewTextBoxColumn Column11;
        private Label label_Info2;
        private Label label_Info;
        private GroupBox groupBox1;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label4;
        private Label label5;
        private Label label6;
        private DataGridView familyCompositiondataGridView;
        private DataGridViewComboBoxColumn Column12;
        private DataGridViewTextBoxColumn Column13;
        private DataGridViewTextBoxColumn Column14;
        private DataGridViewTextBoxColumn Column1_Name;
        private DataGridViewTextBoxColumn Column2_Diplome;
        private DataGridViewTextBoxColumn Column3_Year;
        private DataGridViewTextBoxColumn Column4_Specialty;
        private DataGridViewTextBoxColumn Column5_qualification;
        private DataGridViewTextBoxColumn Column6_FormOfEducation;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStrip toolStrip1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripButton toolStripButton_Open;
        private ToolStripButton toolStripButton_Clear;
        private ToolStripButton toolStripButton_Save;
        private Panel panel1;
        private DataGridView ProfEducationDataGridView;
        private Panel panel2;
        private DataGridView VacationsDataGridView;
        private DataGridViewTextBoxColumn Column21;
        private DataGridViewTextBoxColumn Column22;
        private DataGridViewTextBoxColumn Column23;
        private DataGridViewTextBoxColumn Column24;
        private DataGridViewTextBoxColumn Column25;
        private DataGridViewTextBoxColumn Column1_Date;
        private DataGridViewTextBoxColumn Column2_struct;
        private DataGridViewTextBoxColumn Column3_Interval;
        private DataGridViewTextBoxColumn Column4_Type;
        private DataGridViewComboBoxColumn Column5_Form;
        private DataGridViewTextBoxColumn Column6_NameDok;
        private ToolStripStatusLabel toolStripStatusLabel2;
    }
}

