using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace QuanlyKhoHang1 
{ 
    public partial class ChonNgay : Form
    {
        #region Peoperties

        private string filePath = "data.xml";
        private List<List<Button>> matrix;

        public List<List<Button>> Matrix { get => matrix; set => matrix = value; }
        
        private PlanData job;
        public PlanData Job { get => job; set => job = value; }


        private List<string> dateOfWeek = new List<string>() { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

        #endregion

        public ChonNgay()
        {
            InitializeComponent();

            LoadMatrix();
            
            try 
            {
                DeserializeFromXML(filePath);
            } catch  { }
            
        }

        void LoadMatrix()
        {
            Matrix = new List<List<Button>>();


            Button oldBtn = new Button() { Width = 0, Height = 0, Location = new Point( -Cons.margin,0)}; 
            for ( int i = 0; i < Cons.DayOfColumn; i++ )
            {
                Matrix.Add(new List<Button>());

                for ( int j = 0; j < Cons.DayOfWeek; j++ )
                {
                    Button btn = new Button() { Width = Cons.dayButtonWidth, Height = Cons.dayButtonHeight};
                    btn.Location = new Point(oldBtn.Location.X + oldBtn.Width + Cons.margin, oldBtn.Location.Y);
                    btn.Click += Btn_Click;

                    pnlMatrix.Controls.Add(btn);
                    Matrix[i].Add(btn);

                    oldBtn = btn;
                }
                oldBtn = new Button() { Width = 0, Height = 0, Location = new Point(-Cons.margin, oldBtn.Location.Y + Cons.dayButtonHeight) };

            }

            setDefaultDate();
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty((sender as Button).Text))
                return; 
            DangKyLichlam daily = new DangKyLichlam(new DateTime(dtpkDate.Value.Year, dtpkDate.Value.Month, Convert.ToInt32((sender as Button).Text)));
            daily.ShowDialog();
        }

        int DayOfMonth (DateTime date)
        {
            switch (date.Month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    return 31;
                case 2:
                    if ((date.Year % 4 == 0 && date.Year % 100 != 0) || date.Year % 400 == 0)
                        return 29;
                    else
                        return 28;
                    
                default:
                    return 30;

            }
        }

        void AddNumberIntoMatricByMonth ( DateTime date)
        {
            ClearMaxtrix();
            DateTime useDate = new DateTime(date.Year, date.Month, 1);
            
            int line = 0;

            for (int i = 1; i <= DayOfMonth(date); i++)
            {
                int column = dateOfWeek.IndexOf(useDate.DayOfWeek.ToString());

                Button btn = Matrix[line][column];
                btn.Text = i.ToString();

                // so sanh vs usedate de ngay Today co mau vang
                if (isEqualDate(useDate, DateTime.Now))
                {
                    btn.BackColor = Color.Yellow;
                }

                // Ngay duoc chon se co mau Aqua
                if (isEqualDate(useDate, date))
                {
                    btn.BackColor = Color.Aqua;
                }

                if (column >= 6)
                    line++;

                useDate = useDate.AddDays(1);
            }
        }

        bool isEqualDate(DateTime dateA, DateTime dateB)
        {
            return dateA.Year == dateB.Year && dateA.Month == dateB.Month && dateA.Day == dateB.Day;
        }

        void ClearMaxtrix()
        {
            for (int i = 0; i < Matrix.Count; i++)
            {
                for (int j = 0; j < Matrix[i].Count; j++)
                {
                    Button btn = Matrix[i][j];
                    btn.Text = "";
                    btn.BackColor = Color.WhiteSmoke;
                }
            }
        }

        void setDefaultDate()
        {
            dtpkDate.Value = DateTime.Now;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dtpkDate_ValueChanged(object sender, EventArgs e)
        {
            AddNumberIntoMatricByMonth((sender as DateTimePicker).Value);

        }

        private void btnLastMonth_Click(object sender, EventArgs e)
        {
            dtpkDate.Value = dtpkDate.Value.AddMonths(-1);
        }

        private void btnNextMonth_Click(object sender, EventArgs e)
        {
            dtpkDate.Value = dtpkDate.Value.AddMonths(1);
        }

        private void btnToday_Click(object sender, EventArgs e)
        {
            setDefaultDate();
        }

        private void SerializeToXML(object data, string filePath)
        {
            FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Write);
            XmlSerializer sr = new XmlSerializer(typeof(PlanData));

            sr.Serialize(fs, data);

            fs.Close();
        }

        private object DeserializeFromXML(string filePath)
        {
            FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Read);
            XmlSerializer sr = new XmlSerializer(typeof(PlanData));

            try
            {
                object result = sr.Deserialize(fs);
                fs.Close();
                return result;
            } catch (Exception e) 
            {
                fs.Close();
                throw new NotImplementedException();
            }
            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SerializeToXML(Job, filePath);
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }
    }
}
