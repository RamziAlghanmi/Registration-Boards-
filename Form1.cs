using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace Registration
{
    public partial class frmMainPage : Form
    {
        public frmMainPage()
        {
            InitializeComponent();
        }
        Form showPersons;
        bool isValidEmaile, isValidAcademic, isValidPass=false;
        Person person = new Person();
        List<Person> persons = new List<Person>();  
        
        private void frmMainPage_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                this.SelectNextControl(this.ActiveControl, true, true, true, false);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

       

        private void btnMin_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                WindowState = FormWindowState.Normal;
            }
            else
            {
                WindowState = FormWindowState.Minimized;
            }
        }

        private void txtName_Validating(object sender, CancelEventArgs e)
        {
            if (txtName.Text == "")
            {
                MessageBox.Show(" يجب عليك إدخال الاسم \n أدخل الاسم من جديد  ");
                e.Cancel = true;
                txtName.Focus();
            }
            else
            {
                person.Name = txtName.Text;
            }
        }


        // منع الإدخال لغير الأرقام
        private void txtNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtAcademicNumber_OnValueChanged(object sender, EventArgs e)
        {
         
            if (txtAcademicNumber.Text.Length >= 5)
            {
                isValidAcademic = true;
                labCheckAcademic.Text = " صحيح ";
                labCheckAcademic.ForeColor = Color.Green;

            }
            else
            {
                labCheckAcademic.Text = " يجب ألا يقل عن 5 أرقام";             
                labCheckAcademic.ForeColor = Color.Red;
                
            }
        }

        private void txtAcademicNumber_Validating(object sender, CancelEventArgs e)
        {
            if (!isValidAcademic)
            {
                MessageBox.Show(" الرقم الأكاديمي غير صحيح ");
                e.Cancel = true;
                txtName.Focus();
            }
            else
            {
                long id = Convert.ToInt64(txtAcademicNumber.Text);
                person.Academic_Number = id;

            }


        }

        private void txtPass_OnValueChanged(object sender, EventArgs e)
        {

            if (txtPass.Text.Length >= 8)
            {
                isValidPass = true;
                labCheckPass.Text = " صحيح ";
                labCheckPass.ForeColor = Color.Green;

            }
            else
            {
                labCheckPass.Text = " يجب ألا يقل عن 8 أرقام";
                labCheckPass.ForeColor = Color.Red;

            }
        }
        private void txtPass_Validating(object sender, CancelEventArgs e)
        {
            if (!isValidPass)
            {
                MessageBox.Show(" كلمة المرور غير صحيحة ");
                e.Cancel = true;
                txtName.Focus();
            }
            else
            {
               
                person.Passwoord = txtPass.Text;

            }
        }

        

        private void txtEmaile_OnValueChanged(object sender, EventArgs e)
        {
            string emaile = txtEmaile.Text;
            string pattern = @"^[^@ \s \d]+[^@ \s]+@[^@ \s]+\.[^@ \s \d]+$";
            isValidEmaile = Regex.IsMatch(emaile, pattern);
            if (isValidEmaile)
            {
                labCheckEmaile.Text = " بريداً الكتتونياً صالحاً";
                labCheckEmaile.ForeColor = Color.Green;

            }
            else
            {
                labCheckEmaile.Text = " بريداً الكتونياً غير صالحاً";
                labCheckEmaile.ForeColor = Color.Red;
             
            }

        }

        private void txtEmaile_Validating(object sender, CancelEventArgs e)
        {
            if (!isValidEmaile)
            {
                MessageBox.Show(" يجب عليك إدخال البريد الإلكتروني  \n ");
                e.Cancel = true;
                txtName.Focus();
            }
            else
            {
                person.Emaile = txtEmaile.Text;
            }

        }

        private void dateBirth_Validated(object sender, CancelEventArgs e)
        {
            person.Date_Of_Birth = dateBirth.Value;
        }

        string getGender()
        {
            if (radMain.Checked)
            {
               return "Man";
            }
            else
            {
                return "Male";
            }

        }

       

        private void labDownloadImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (openFileImage.ShowDialog() == DialogResult.OK)
            {
                photo.Image = Image.FromFile(openFileImage.FileName);
                person.Photo_Path = openFileImage.FileName;
            }
        }

        static void saveStuents(List<Person> persons, string file_path)
        {
            string json = JsonConvert.SerializeObject(persons, Formatting.Indented);
            File.WriteAllText(file_path, json);
        }

        private void btnLoade_Click(object sender, EventArgs e)
        {
             persons = loadStudent(@"Students.txt");
            showPersons = new frmShowPersons(persons);
            showPersons.ShowDialog();

        }

       

        static List<Person> loadStudent(string file_path)
        {
            if (!File.Exists(file_path))
            {
                return new List<Person>();
            }
            string json = File.ReadAllText(file_path);
            return JsonConvert.DeserializeObject<List<Person>>(json);

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            person.Gender = getGender();
            persons.Add(person); 
            saveStuents(persons, @"Students.txt");
            MessageBox.Show(" تم الحفظ بنجاح ");

        MessageBox.Show(" \n  تم إضافة الطالب بنجاح ");

        }

        private void comboBoxCountry_Validating(object sender, CancelEventArgs e)
        {
            if(comboBoxCountry.SelectedIndex == -1)
            {
                MessageBox.Show(" يجب عليك إدخال العنوان   \n ");
                e.Cancel = true;
                comboBoxCountry.Focus();
            }
            else
            {

                person.Address= comboBoxCountry.SelectedItem.ToString();
            }
        
        }

        private void frmMainPage_Load(object sender, EventArgs e)
        {
            txtPass.isPassword=true;
          
        }

        void clearInputs(Control parent)
        {
            foreach(Control c in parent.Controls){
             
                if (c is TextBox)
                {
c.Text= String.Empty;

                }
                else if(c is ComboBox)
                {
                    ((ComboBox)c).SelectedIndex = -1;
                }
                else if (c is ComboBox)
                {
                    ((DateTimePicker)c).Value =DateTime.Now;
                }
                else
                {
                    clearInputs(c);
                }
            }

        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            clearInputs(this);
        }
    }
}
