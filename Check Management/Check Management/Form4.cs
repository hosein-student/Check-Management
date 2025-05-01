using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Globalization;
using System.Runtime.InteropServices;

namespace Check_Management
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        string Savephoto="not available";
        string sech = "not found";
        string sech1 = "Search";
       public string usersave;
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text == "") 
                return;
            string ew = textBox3.Text.Replace(",", "");

            int cu = textBox3.SelectionStart;
            textBox3.Text = long.Parse(ew).ToString("N0");
            textBox3.SelectionStart = textBox3.Text.Length - (ew.Length - cu);
             


            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode>=Keys.NumPad0&&e.KeyCode<=Keys.NumPad9||e.KeyCode==Keys.Back)
            {
                return;
            }
            if(!(char.IsDigit((char)e.KeyCode)))
            {
                e.SuppressKeyPress = true;
            }
        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9 || e.KeyCode == Keys.Back)
            {
                return;
            }
            if (!(char.IsDigit((char)e.KeyCode)))
            {
                e.SuppressKeyPress = true;
            }
        }

        private void glassButton1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox4.Text);
            File.AppendAllText("list1" + usersave + ".txt", textBox4.Text + Environment.NewLine);
            listBox2.Items.Add(textBox2.Text);
            File.AppendAllText("list2" + usersave + ".txt", textBox2.Text + Environment.NewLine);
            listBox4.Items.Add(textBox3.Text);
            File.AppendAllText("list4" + usersave + ".txt", textBox3.Text + Environment.NewLine);
            listBox3.Items.Add(textBox5.Text);
            File.AppendAllText("list3" + usersave + ".txt", textBox5.Text + Environment.NewLine);
            
            listBox6.Items.Add(Savephoto);
            File.AppendAllText("list6" + usersave + ".txt", Savephoto + Environment.NewLine);
            
            string date = string.Format(textBox1.Text + "/" + textBox7.Text + "/" + textBox8.Text);
            listBox5.Items.Add(date);
            File.AppendAllText("list5" + usersave + ".txt", date + Environment.NewLine);
            listBox7.Items.Add("not paid check");
            File.AppendAllText("list7" + usersave + ".txt", "not paid check" + Environment.NewLine);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox p = sender as ListBox;

            int selekt = p.SelectedIndex;
            listBox1.SelectedIndex = selekt;
            listBox2.SelectedIndex = selekt;
            listBox3.SelectedIndex = selekt;
            listBox4.SelectedIndex = selekt;
            listBox5.SelectedIndex = selekt;
            listBox6.SelectedIndex = selekt;
            listBox7.SelectedIndex = selekt;
            pictureBox1.ImageLocation = listBox6.SelectedItem.ToString();
            
        }

        private void label8_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Select photo";
            openFileDialog1.Filter = "photo|*.jpg;*.jpeg;*.png";
            openFileDialog1.ShowDialog();
           

            

            Savephoto= openFileDialog1.FileName ;

        }
        void persian()
        {
            فارسیToolStripMenuItem.Checked = true;
            انگلیسیToolStripMenuItem.Checked = false;
            tabPage1.Text = "افزودن چک جدید";
            tabPage2.Text = "تغییر وضعیت چک";
            tabPage3.Text = "حذف چک";
            tabPage4.Text = "جستجو چک";
            tabControl1.RightToLeft = RightToLeft.Yes;
            tabControl1.RightToLeftLayout = true;
            label20.Visible = true;
            label21.Visible = true;
            label22.Visible = true;
            label23.Visible = true;
            label24.Visible = true;
            label1.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label7.Visible = false;
            label2.Visible = false;
            label8.Text = "عکس چک را انتخاب کنید";
            glassButton1.Text = "اضافه کردن";
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            label19.Visible = false;
            label13.Visible = false;
            label26.Visible = true;
            label27.Visible = true;
            label28.Visible = true;
            label29.Visible = true;
            label30.Visible = true;
            label25.Visible = true;
            label18.Visible = false;
            label31.Visible = true;
            radioButton1.Text = "برگشت شده";
            radioButton2.Text = "پاس شده";
            glassButton5.Text = "تغیر";
            label32.Visible = true;
            label16.Visible = false;
            glassButton4.Text = "حذف";
            label17.Text = "از حذف مطمئنی؟";
            glassButton2.Text = "جستوجو";
            label15.Visible = false;
            label33.Visible = true;
            glassButton3.Text = "حذف";
            sech = "پیدا نشد";
            sech1 = "جستوجو";
            this.Text = "مدیریت چک";
            File.WriteAllText("language.txt", "2");
        }
        void English()
        {
            فارسیToolStripMenuItem.Checked = false;
            انگلیسیToolStripMenuItem.Checked = true;
            tabPage1.Text = "Add New Check";
            tabPage2.Text = "Change check status";
            tabPage3.Text = "Delete Check";
            tabPage4.Text = "Search Check";
            tabControl1.RightToLeft = RightToLeft.No;
            tabControl1.RightToLeftLayout = false;
            label1.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label7.Visible = true;
            label2.Visible = true;
            label20.Visible = false;
            label21.Visible = false;
            label22.Visible = false;
            label23.Visible = false;
            label24.Visible = false;
            label25.Visible = false;
            label8.Text = "Choose a check photo";
            glassButton1.Text = "Add";
            label9.Visible = true;
            label10.Visible = true;
            label11.Visible = true;
            label12.Visible = true;
            label19.Visible = true;
            label13.Visible = true;
            label26.Visible = false;
            label27.Visible = false;
            label28.Visible = false;
            label29.Visible = false;
            label30.Visible = false;

            label18.Visible = true;
            label31.Visible = false;
            radioButton1.Text = "Check bounced";
            radioButton2.Text = "Paid check";
            glassButton5.Text = "Change";
            label32.Visible = false;
            label16.Visible = true;
            glassButton4.Text = "Delete";
            label17.Text = "Are you sure about deleting?";
            glassButton2.Text = "جستوجو";
            glassButton2.Text = "Search";
            label15.Visible = true;
            label33.Visible = false;
            glassButton3.Text = "Delete";
            sech = "not found";
            sech1 = "Search";
            this.Text = "Check Management";
            File.WriteAllText("language.txt", "1");
        }
        private void CheckDueDates()
{
    List<string> alerts = new List<string>();
    PersianCalendar pc = new PersianCalendar();
    DateTime todayMiladi = DateTime.Today;

    // تاریخ امروز به شمسی
    string todayShamsi = pc.GetYear(todayMiladi) + "/" +
                         pc.GetMonth(todayMiladi).ToString("00") + "/" +
                         pc.GetDayOfMonth(todayMiladi).ToString("00");

    for (int i = 0; i < listBox5.Items.Count; i++)
    {
        string itemDateStr = listBox5.Items[i].ToString();
        string amount = listBox4.Items[i].ToString(); // مبلغ
        string bank = listBox3.Items[i].ToString();   // بانک
        try
        {
            string[] parts = itemDateStr.Split('/');
            if (parts.Length == 3)
            {
                int year = int.Parse(parts[0]);
                int month = int.Parse(parts[1]);
                int day = int.Parse(parts[2]);

                // تبدیل تاریخ شمسی به میلادی
                DateTime dueDate = pc.ToDateTime(year, month, day, 0, 0, 0, 0);

                int daysLeft = (dueDate - todayMiladi).Days;
                string amountLine = string.Format("💵 مبلغ: {0} تومان", amount);
                string bankLine = string.Format("🏦 بانک: {0}", bank);
                string dateLine = string.Format("📅 تاریخ: {0}", itemDateStr);
                string baseMessage = string.Format("{0}\n{1}\n{2}", amountLine, bankLine, dateLine);
                switch (daysLeft)
                {
                    case 2:
                        alerts.Add(string.Format("🔔 چک پس‌فردا سررسید می‌شود:\n{0}", baseMessage));
                        break;
                    case 1:

                        alerts.Add(string.Format("⚠️ چک فردا سررسید می‌شود:\n{0}", baseMessage));
                        break;
                    case 0:
                        alerts.Add(string.Format("❗ چک امروز سررسید دارد!\n{0}", baseMessage));
                       
                        break;
                }
            }
        }
        catch
        {
            // اگر تاریخ خراب یا نادرست بود نادیده بگیر
            continue;
        }
    }

    if (alerts.Count > 0)
    {
        string message = string.Join(Environment.NewLine, alerts);
        MessageBox.Show(message, "هشدار چک‌های نزدیک به سررسید", MessageBoxButtons.OK, MessageBoxIcon.Warning);
    }
}
        private void Form4_Load(object sender, EventArgs e)
        {
            







            string language = File.ReadAllText("language.txt");
            if (language == "1")
            {
                English();
            }
            else
                persian();

            string[] l1;
            string[] l2;
            string[] l3;
            string[] l4;
            string[] l5;
            string[] l6;
            string[] l7;
            if (File.Exists("list1" + usersave + ".txt"))
            {
            l1 = File.ReadAllLines("list1" + usersave + ".txt");
            listBox1.Items.AddRange(l1);
            }

            if (File.Exists("list2" + usersave + ".txt"))
            {
                l2 = File.ReadAllLines("list2" + usersave + ".txt");
                listBox2.Items.AddRange(l2);
            }
            if (File.Exists("list3" + usersave + ".txt"))
            {
                l3 = File.ReadAllLines("list3" + usersave + ".txt");
                listBox3.Items.AddRange(l3);
            }
            if (File.Exists("list4" + usersave + ".txt"))
            {
                l4 = File.ReadAllLines("list4" + usersave + ".txt");
                listBox4.Items.AddRange(l4);
            }
            if (File.Exists("list5" + usersave + ".txt"))
            {
                l5 = File.ReadAllLines("list5" + usersave + ".txt");
                listBox5.Items.AddRange(l5);
            }
            if (File.Exists("list6" + usersave + ".txt"))
            {
                l6 = File.ReadAllLines("list6" + usersave + ".txt");
                listBox6.Items.AddRange(l6);
            }
            if (File.Exists("list7" + usersave + ".txt"))
            {
                l7 = File.ReadAllLines("list7" + usersave + ".txt");
                listBox7.Items.AddRange(l7);
            }

        }

        private void glassButton2_Click(object sender, EventArgs e)
        {
            if (listBox2.Items.IndexOf(textBox6.Text) > -1)
            {
                listBox1.SelectedIndex = listBox2.Items.IndexOf(textBox6.Text);
                listBox2.SelectedIndex = listBox2.Items.IndexOf(textBox6.Text);
                listBox3.SelectedIndex = listBox2.Items.IndexOf(textBox6.Text);
                listBox4.SelectedIndex = listBox2.Items.IndexOf(textBox6.Text);
                listBox5.SelectedIndex = listBox2.Items.IndexOf(textBox6.Text);
                listBox6.SelectedIndex = listBox2.Items.IndexOf(textBox6.Text);
                textBox6.Clear();
            }
            else
                MessageBox.Show(sech,sech1,MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void glassButton3_Click(object sender, EventArgs e)
        {
            if (listBox2.Items.IndexOf(textBox9.Text) > -1)
            {
                listBox1.SelectedIndex = listBox2.Items.IndexOf(textBox9.Text);
                listBox2.SelectedIndex = listBox2.Items.IndexOf(textBox9.Text);
                listBox3.SelectedIndex = listBox2.Items.IndexOf(textBox9.Text);
                listBox4.SelectedIndex = listBox2.Items.IndexOf(textBox9.Text);
                listBox5.SelectedIndex = listBox2.Items.IndexOf(textBox9.Text);
                listBox6.SelectedIndex = listBox2.Items.IndexOf(textBox9.Text);
               
                glassButton3.Visible = false;
                glassButton4.Visible = true;
                label17.Visible = true;
            }
            else
                MessageBox.Show(sech, sech1, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        void lood()
        {
            string[] l1;
            string[] l2;
            string[] l3;
            string[] l4;
            string[] l5;
            string[] l6;
            string[] l7;
            if (File.Exists("list1" + usersave + ".txt"))
            {
                l1 = File.ReadAllLines("list1" + usersave + ".txt");
                listBox1.Items.AddRange(l1);
            }

            if (File.Exists("list2" + usersave + ".txt"))
            {
                l2 = File.ReadAllLines("list2" + usersave + ".txt");
                listBox2.Items.AddRange(l2);
            }
            if (File.Exists("list3" + usersave + ".txt"))
            {
                l3 = File.ReadAllLines("list3" + usersave + ".txt");
                listBox3.Items.AddRange(l3);
            }
            if (File.Exists("list4" + usersave + ".txt"))
            {
                l4 = File.ReadAllLines("list4" + usersave + ".txt");
                listBox4.Items.AddRange(l4);
            }
            if (File.Exists("list5" + usersave + ".txt"))
            {
                l5 = File.ReadAllLines("list5" + usersave + ".txt");
                listBox5.Items.AddRange(l5);
            }
            if (File.Exists("list6" + usersave + ".txt"))
            {
                l6 = File.ReadAllLines("list6" + usersave + ".txt");
                listBox6.Items.AddRange(l6);
            }
            if (File.Exists("list7" + usersave + ".txt"))
            {
                l7 = File.ReadAllLines("list7" + usersave + ".txt");
                listBox7.Items.AddRange(l7);
            }
        }
        private void glassButton4_Click(object sender, EventArgs e)
        {
            label17.Visible = false;
            glassButton4.Visible = false;
            glassButton3.Visible = true;
            if (File.Exists("list2" + usersave + ".txt"))
            {
                string[] li1 = File.ReadAllLines("list1" + usersave + ".txt");
                string[] li2 = File.ReadAllLines("list2" + usersave + ".txt");
                string[] li3 = File.ReadAllLines("list3" + usersave + ".txt");
                string[] li4 = File.ReadAllLines("list4" + usersave + ".txt");
                string[] li5 = File.ReadAllLines("list5" + usersave + ".txt");
                string[] li6 = File.ReadAllLines("list6" + usersave + ".txt");
                string[] li7 = File.ReadAllLines("list7" + usersave + ".txt");
                File.WriteAllText("list1" + usersave + ".txt", "");
                File.WriteAllText("list2" + usersave + ".txt", "");
                File.WriteAllText("list3" + usersave + ".txt", "");
                File.WriteAllText("list4" + usersave + ".txt", "");
                File.WriteAllText("list5" + usersave + ".txt", "");
                File.WriteAllText("list6" + usersave + ".txt", "");
                File.WriteAllText("list7" + usersave + ".txt", "");
                for (int i = 0; i < li2.Length; i++)
                {
                    if (li2[i] != textBox9.Text)
                    {
                        File.AppendAllText("list1" + usersave + ".txt", li1[i] + "\r\n");
                        File.AppendAllText("list2" + usersave + ".txt", li2[i] + "\r\n");
                        File.AppendAllText("list3" + usersave + ".txt", li3[i] + "\r\n");
                        File.AppendAllText("list4" + usersave + ".txt", li4[i] + "\r\n");
                        File.AppendAllText("list5" + usersave + ".txt", li5[i] + "\r\n");
                        File.AppendAllText("list6" + usersave + ".txt", li6[i] + "\r\n");
                        File.AppendAllText("list7" + usersave + ".txt", li7[i] + "\r\n");
                    }
                   
                }


            }
            textBox9.Clear();
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            listBox4.Items.Clear();
            listBox5.Items.Clear();
            listBox6.Items.Clear();
            listBox7.Items.Clear();
            lood();

        }

        private void glassButton5_Click(object sender, EventArgs e)
        {
            if((listBox2.Items.IndexOf(textBox10.Text) > -1))
            {
                string[] l2 = File.ReadAllLines("list2" + usersave + ".txt");
                string[] l7 = File.ReadAllLines("list7" + usersave + ".txt");

                File.WriteAllText("list7" + usersave + ".txt", "");
                for (int i = 0; i < l2.Length; i++)
                {
                    if (l2[i] == textBox10.Text)
                    {
                        if (radioButton1.Checked == true)
                        {
                            File.AppendAllText("list7" + usersave + ".txt", radioButton1.Text + "\r\n");
                        }
                        else
                        {
                            File.AppendAllText("list7" + usersave + ".txt", radioButton2.Text + "\r\n");
                        }

                    }
                    else
                    {
                        File.AppendAllText("list7" + usersave + ".txt", l7[i] + "\r\n");
                    }
                   
                }
                textBox10.Clear();
                listBox1.Items.Clear();
                listBox2.Items.Clear();
                listBox3.Items.Clear();
                listBox4.Items.Clear();
                listBox5.Items.Clear();
                listBox6.Items.Clear();
                listBox7.Items.Clear();
                lood();
            }
            else
            {
                MessageBox.Show(sech, sech1, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           


        }

        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void فارسیToolStripMenuItem_Click(object sender, EventArgs e)
        {
            persian();
        }

        private void انگلیسیToolStripMenuItem_Click(object sender, EventArgs e)
        {
            English();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9 || e.KeyCode == Keys.Back)
            {
                return;
            }
            if (!(char.IsDigit((char)e.KeyCode)))
            {
                e.SuppressKeyPress = true;
            }
        }

        private void textBox7_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9 || e.KeyCode == Keys.Back)
            {
                return;
            }
            if (!(char.IsDigit((char)e.KeyCode)))
            {
                e.SuppressKeyPress = true;
            }
        }

        private void textBox8_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9 || e.KeyCode == Keys.Back)
            {
                return;
            }
            if (!(char.IsDigit((char)e.KeyCode)))
            {
                e.SuppressKeyPress = true;
            }
        }

        [DllImport("user32.dll")]
        private static extern bool FlashWindow(IntPtr hwnd, bool bInvert);
        private void ShowAlert()
        {
            
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Normal;
            }

            
            this.Activate();

            
            this.TopMost = true;
            this.TopMost = false;

            
            FlashWindow(this.Handle, true);
            try
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer("tt.wav");
                player.Play();
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطا در پخش صدا: " + ex.Message);
            }
        }
        private void Form4_Shown(object sender, EventArgs e)
        {
            CheckDueDates();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            CheckDueDates();
            ShowAlert();
        }
        }
    
}
