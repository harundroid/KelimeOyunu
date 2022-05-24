using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KelimeOyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private DataTable GetWords()
        {
            DataSet ds = new DataSet();
            ds.ReadXml(this.GetType().Assembly.GetManifestResourceStream("KelimeOyunu.Kelimeler.xml"));
            DataTable table = new DataTable();
            table.Columns.Add("ID");
            table.Columns.Add("Ing");
            table.Columns.Add("TR");
            DataRow newRow = table.NewRow();

            int column = 0;
            for (int i = 0; i < ds.Tables[1].Rows.Count; i++)
            {
                DataRow currentRow = ds.Tables[1].Rows[i];
                //DataRow exRow = ds.Tables[1].Rows[i > 0 ? i - 1 : 0];
                //if (exRow[1].ToString() == currentRow[1].ToString())
                {
                    switch (column)
                    {
                        case 0:
                            newRow[0] = currentRow[0];
                            column++;
                            break;
                        case 1:
                            newRow[1] = currentRow[0];
                            column++;
                            break;
                        case 2:
                            newRow[2] = currentRow[0];
                            table.Rows.Add(newRow);
                            column = 0;
                            newRow = table.NewRow();
                            break;
                    }
                }
            }
            for (int i = 0; i < table.Rows.Count; i++)
            {
                table.Rows[i][0] = i + 1;
            }
            return table;
        }
        void GetQuestion()
        {
            Random random = new Random();
            questionRow = words.Rows[random.Next(words.Rows.Count)];//Soru Bulunuyor

            this.question.Text = questionRow[1].ToString();//Soru Yazılıyor.
            int ans = random.Next(2);//Cevap butonu bulunuyor.
            buttons[ans].Text = questionRow[2].ToString();//Cevap butona yazılıyor
            for (int i = 0; i < buttons.Count; i++)
            {
                if (ans == i) continue;//Cevap butonu ayıklanıyor
                else buttons[i].Text = words.Rows[random.Next(words.Rows.Count)][2].ToString();//Yanlış cevaplar yazılıyor.
            }
        }
        DataTable words = new DataTable();
        List<Button> buttons = new List<Button>();
        DataRow questionRow { get; set; }
        private void Form1_Load(object sender, EventArgs e)
        {
            buttons.Add(answerA);
            buttons.Add(answerB);
            buttons.Add(answerC);
            words = GetWords();
            GetQuestion();//Soru çağırılıyor.
        }
        void DogruCevap()
        {
            question.Text = "Doğru Cevap:)";
            for (int i = 0; i < buttons.Count; i++)
            {
                buttons[i].Text = "Devam...";
                buttons[i].Enabled = true;
                buttons[i].BackColor=Color.White;
                buttons[i].ForeColor = Color.Black;
            }
        }
        private void answerA_Click(object sender, EventArgs e)
        {
            if (answerA.Text.ToString() == "Devam...")
            {
                GetQuestion();
            }
            else
            {
                if (answerA.Text.ToString() == questionRow[2].ToString())
                {
                    DogruCevap();
                }
                else
                {
                    //SolidColorBrush b = new SolidColorBrush();
                    //b.Color = Colors.Red;
                    //answerA.Foreground = b;
                    //answerA.IsEnabled = false;
                    answerA.ForeColor = Color.WhiteSmoke;
                    answerA.BackColor = Color.Red;
                    answerA.Enabled = false;
                }
            }
        }

        private void answerB_Click(object sender, EventArgs e)
        {
            if (answerB.Text.ToString() == "Devam...")
            {
                GetQuestion();
            }
            else
            {
                if (answerB.Text.ToString() == questionRow[2].ToString())
                {
                    DogruCevap();
                }
                else
                {
                    //SolidColorBrush b = new SolidColorBrush();
                    //b.Color = Colors.Red;
                    //answerA.Foreground = b;
                    //answerA.IsEnabled = false;
                    answerB.ForeColor = Color.WhiteSmoke;
                    answerB.BackColor = Color.Red;
                    answerB.Enabled = false;
                }
            }
        }

        private void answerC_Click(object sender, EventArgs e)
        {
            if (answerC.Text.ToString() == "Devam...")
            {
                GetQuestion();
            }
            else
            {
                if (answerC.Text.ToString() == questionRow[2].ToString())
                {
                    DogruCevap();
                }
                else
                {
                    //SolidColorBrush b = new SolidColorBrush();
                    //b.Color = Colors.Red;
                    //answerA.Foreground = b;
                    //answerA.IsEnabled = false;
                    answerC.ForeColor = Color.WhiteSmoke;
                    answerC.BackColor = Color.Red;
                    answerC.Enabled = false;
                }
            }
        }
    }
}
