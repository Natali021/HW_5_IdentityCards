using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace HW_5_IdentityCards
{
    public partial class Form1 : Form
    {
        private Color c;
               
        public Form1()
        {
            InitializeComponent();
            c = this.BackColor;
        }

        private void CloseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Обираємо стиль форми
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BlueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem it = (ToolStripMenuItem)sender;

            if (it.Checked == true)
            {
                this.BackColor = Color.LightSkyBlue;
            }
            else
            {
                this.BackColor = c;
            }
        }

        /// <summary>
        /// Переходимо на наступну вкладку
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Further1_Click(object sender, EventArgs e)
        {
            this.tabControl_general.SelectedIndex = (tabControl_general.SelectedIndex + 1 < tabControl_general.TabCount) ?
                             tabControl_general.SelectedIndex + 1 : tabControl_general.SelectedIndex;
        }

        private void Button_Further2_Click(object sender, EventArgs e)
        {
            this.tabControl_general.SelectedIndex = (tabControl_general.SelectedIndex + 1 < tabControl_general.TabCount) ?
                             tabControl_general.SelectedIndex + 1 : tabControl_general.SelectedIndex;
        }

        private void Button_Further3_Click(object sender, EventArgs e)
        {
            this.tabControl_general.SelectedIndex = (tabControl_general.SelectedIndex + 1 < tabControl_general.TabCount) ?
                             tabControl_general.SelectedIndex + 1 : tabControl_general.SelectedIndex;
        }

        private void Button_Further4_Click(object sender, EventArgs e)
        {
            this.tabControl_general.SelectedIndex = (tabControl_general.SelectedIndex + 1 < tabControl_general.TabCount) ?
                             tabControl_general.SelectedIndex + 1 : tabControl_general.SelectedIndex;
        }

        /// <summary>
        /// Переходимо на попередню вкладку
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Back1_Click(object sender, EventArgs e)
        {
            this.tabControl_general.SelectedIndex = (tabControl_general.SelectedIndex - 1 >=0) ?
                             tabControl_general.SelectedIndex - 1 : tabControl_general.SelectedIndex;
        }

        private void Button_Back2_Click(object sender, EventArgs e)
        {
            this.tabControl_general.SelectedIndex = (tabControl_general.SelectedIndex - 1 >= 0) ?
                             tabControl_general.SelectedIndex - 1 : tabControl_general.SelectedIndex;
        }

        private void Button_Back3_Click(object sender, EventArgs e)
        {
            this.tabControl_general.SelectedIndex = (tabControl_general.SelectedIndex - 1 >= 0) ?
                             tabControl_general.SelectedIndex - 1 : tabControl_general.SelectedIndex;
        }

        private void Button_back4_Click(object sender, EventArgs e)
        {
            this.tabControl_general.SelectedIndex = (tabControl_general.SelectedIndex - 1 >= 0) ?
                             tabControl_general.SelectedIndex - 1 : tabControl_general.SelectedIndex;
        }

       
        

        /// <summary>
        /// Зберегти у файл
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Save_Click(object sender, EventArgs e)
        {
            SaveDataToFile();
        }
        
        private void toolStripButton_Save_Click(object sender, EventArgs e)
        {
            SaveDataToFile();
        }
        
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveDataToFile();
        }

        /// <summary>
        /// Завантажити із файлу
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Open_Click(object sender, EventArgs e)
        {
            OpenForm(sender, e);
        }

        private void toolStripButton_Open_Click(object sender, EventArgs e)
        {
            OpenForm(sender, e);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(sender, e);
        }

        /// <summary>
        /// Очистити форму
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearForm(sender, e);
        }

        private void toolStripButton_Clear_Click(object sender, EventArgs e)
        {
            ClearForm(sender, e);
        }

        /// <summary>
        /// Завантажити фото
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox_Photo_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog
            {
                Filter = "Файл зображення (*.BMP; *.PNG)|*.BMP; *.PNG|Всі файли(*.*)|*.*"
            };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    this.pictureBox_Photo.Image = new Bitmap(ofd.FileName);
                }
                catch (IOException exeption)
                {
                    MessageBox.Show(exeption.Message, "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
