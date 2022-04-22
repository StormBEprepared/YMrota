using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;
using Application = System.Windows.Forms.Application;
using DataTable = System.Data.DataTable;
using System.Xml.Linq;
using System.Xml;
using System.IO;
using System.Globalization;

namespace YMrota//Create a function for deploying on each position by taking only the persons who are having the training for that pos ex: 
                //            foreach (YM ym in Form1.AvailableYM.Where(ym => ym.trainingGH == true&& ym.DayShift==true).ToList())

{
    public partial class Rota : Form
    {//Variables to determine the number of available spaces on specific positions
        public static int InboundOutside = 2; //public static int InboundOutsideAfter1430 = 2; public static int InboundOutsideAfter1630 =1;//Tino
        public static int OutboundOutside = 1; //public static int OutboundOutsideAfter1430 = 1;
        public static int Gatehouse = 1; //public static int GatehouseAfter1430 = 1; public static int GatehouseAfter1630 = 1;//Tino
        public static int InboundIndoor = 1; //public static int InboundIndoorAfter1430 =1;
        public static int OutboundIndoor = 1; //public static int OutboundIndoorAfter1430 = 1;
        public static int ClerkInbound = 1; 
        public static int ClerkOutbound = 1; 
        public static int Sortation = 0; //public static int SortationAfter1130 = 3;// ++when 8 ym positions filled

        public static bool AllPosFilled = false;

        public List<YM> availYMforRichtext = new List<YM>();

        public static string AssNameToPass;
        public List<string> YMname = new List<string>();
        public static List<string> AvailPosMorning= new List<string>() {"Out OB","Out IB"};
        public static List<string> AvailPosDay = new List<string>() {"GH","Out OB","Clerk OB","In OB","In IB","Clerk IB","Out IB"}; //{ "GH","GH after 14:30","GH after 16:30","Out OB","Out OB after 14:30","In OB","In OB after 14:30","Clerk OB","Clerk IB","Out IB","Out IB after 14:30","Out IB after 16:30"};
        public List<string> TrainedPos = new List<string>();
        public List<string> JointPositionList = new List<string>();


        public static string GH=string.Empty;
        public static string OutOB=string.Empty;
        public static string ClerkOB=string.Empty;
        public static string InOB=string.Empty;
        public static string InIB=string.Empty;
        public static string ClerkIB=string.Empty;
        public static string OutIB1=string.Empty;
        public static string OutIB2=string.Empty;
        public List<YM> MarshalsfromForm1 = new List<YM> ();


        public Timer x = new Timer ();
        public Rota()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Restart();

        }
        private void Rota_Load(object sender, EventArgs e)
        {
            availYMforRichtext.AddRange(Form1.AvailableYM);
            GenerateRotaButton.Enabled = true;
            ExtractExcelButton.Enabled = false;
            richTextBox1.Visible = false;
            checkBox1.Enabled = false;checkBox1.Hide();
            button3.Enabled = false;button3.Hide();
            foreach (var item in Form1.AvailableYM)//to see the names in the listview
            {
                YMname.Add(item.Name);
            }
            listBox1.DataSource = YMname;

            foreach (YM yM in Form1.AvailableYM)
            {
                MarshalsfromForm1.Add(yM);
            }
            
            // An example on how to not use sql for non-complex data storage https://stackoverflow.com/questions/30582668/shortest-way-to-save-datatable-to-textfile
            
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            richTextBox1.Text = GetVar(availYMforRichtext[listBox1.SelectedIndex]);//add the values to a richtextbox so you can use the function that you created

            string[] lines = richTextBox1.Text.Split(new string[] { "\r\n", "\r", "\n" },StringSplitOptions.None);           
            
            //prints out the training that every selected associate has.
            //listBox2.DataSource= GetVar(Form1.AvailableYM[listBox1.SelectedIndex]).ToList();
            listBox2.DataSource=lines;//The list from which you can choose what custom position a selected associate should do.
                                      //Here you can see the past positions for the selected associate in listbox1
            DataSet ds = new DataSet();
            ds.ReadXml("YMrota.xml");
            DataView dv = new DataView();
            dv = ds.Tables[0].DefaultView;
            dv.RowFilter =$"Name='{listBox1.SelectedItem.ToString()}'";
            dataGridView2.DataSource = dv;
            dataGridView2.Sort(dataGridView2.Columns["Date"], ListSortDirection.Descending);

        }
        public static string GetVar(YM t)//for richtextbox1
        {
            string result=string.Empty;
            if (t.GHtrainingBool==true)
            {
                result += "GH\n";
            }
            if (t.OutdoorOBTrainingBool==true)
            {
                result += "Out OB\n";
            }
            if (t.IndoorOBTrainingBool==true)
            {
                result += "In OB\n";
            }
            if (t.ClerkOBTraininBool==true)
            {
                result += "Clerk OB\n";
            }
            if (t.IndoorIBTrainingBool==true)
            {
                result += "In IB\n";
            }
            if (t.ClerkIBTrainingBool==true)
            {
                result += "Clerk IB\n";
            }
            if (t.OutdoorIBTrainingBool==true)
            {
                result += "Out IB\n";
            }
            return result;
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
           
        }
        public static void CheckPosAvail()
        {
            if (InboundIndoor==0&&InboundOutside==0&&ClerkInbound==0&&ClerkOutbound==0&&OutboundIndoor==0&&OutboundOutside==0&&Gatehouse==0)
            {
                AllPosFilled = true;
                AvailPosDay.Clear();//ADDED AFTER, DELETE IF NECESSARY
                AvailPosDay.Add("Sortation");//THIS ONE TOO
            }
        }
        private void button3_Click(object sender, EventArgs e)//AssignCustomPosition button // DISABLED FOR THE MOMENT
        {
            string Name = listBox1.SelectedItem.ToString();
            string Position = listBox2.SelectedItem.ToString();
            InsertInXMLfile(Name, Position);
            dataGridView1.Rows.Add(Position, Name);
            YM YM=new YM();
            Name=YM.Name;
            Form1.AvailableYM.Remove(YM);
            //YM.CB.CheckState = CheckState.Unchecked;
            //Here you need to make sure that the checkbox in the form 1 for the current YM is unchecked so it will not be added again to the availymlist.

            switch (Position)
            {
                case "GH":
                    Gatehouse--;
                    break;
                case "Out OB":
                    OutboundOutside--;
                    break;
                case "Clerk OB":
                    ClerkOutbound--;
                    break;
                case "In OB":
                    OutboundIndoor--;
                    break;
                case "In IB":
                    InboundIndoor--;
                    break;
                case "Clerk IB":
                    ClerkInbound--;
                    break;
                case "Out IB":
                    InboundOutside--;
                    break;
                default:
                    Sortation++;
                    break;
            }
            PosCounterConstructor();
            CheckPosAvail();
            //dt.Rows.Add($"{Name}",$"{Position}",$"{DateTime.Now.ToString("dd-MM-yyyy")}");

            /*dataGridView1.Rows.Add(Position, Name);
            PosCounterConstructor();
            CheckPosAvail();
            JointPositionList.Clear();
            TrainedPos.Clear();*/

        }
        public void InsertInXMLfile(string Name, string Position)
        {
            DataSet ds = new DataSet();
            ds.ReadXml("YMrota.xml");
            
            DataTable dt = ds.Tables[0];
            DataRow dr = dt.NewRow();
            dr["Name"] = Name;
            dr["Position"] = Position;
            dr["Date"] = DateTime.Now.ToString("dd-MM-yyyy");
            dt.Rows.Add(dr);
            ds.WriteXml("YMrota.xml");
        }
        public static void PosCounterConstructor()
        {
            if (Gatehouse==0)
            {
                    AvailPosDay.Remove("GH");
            }
                
            if (OutboundOutside == 0)
            {
                    AvailPosDay.Remove("Out OB");
            }
                        
            if (OutboundIndoor == 0)
            {
                    AvailPosDay.Remove("In OB");
            }
                        
            if (ClerkOutbound == 0)
            {
                    AvailPosDay.Remove("Clerk OB");
            }
                        
            if (InboundIndoor == 0)
            {
                    AvailPosDay.Remove("In IB");
            }
                       
            if (ClerkInbound == 0)
            {
                    AvailPosDay.Remove("Clerk IB");
            }
            
            if (InboundOutside == 0)
            {
                    AvailPosDay.Remove("Out IB");
            }
           
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void RandomPos4RiskAssessed(List<YM> ym)
        {
            string position = string.Empty;
            foreach (YM yM in MarshalsfromForm1.Where(item=> item.RiskAssesed==true).ToList())
            {
                if (yM.GHtrainingBool == true)
                {
                    //allow to be deployed by adding the position to the trained position list
                    TrainedPos.Add("GH");
                }
                if (yM.ClerkIBTrainingBool == true)
                {
                    TrainedPos.Add("Clerk IB");
                }
                if (yM.ClerkOBTraininBool == true)
                {
                    TrainedPos.Add("Clerk OB");
                }
                if (yM.IndoorIBTrainingBool == true)
                {
                    TrainedPos.Add("In IB");
                }
                if (yM.OutdoorIBTrainingBool == true)
                {
                    TrainedPos.Add("Out IB");
                }
                if (yM.IndoorOBTrainingBool == true)
                {
                    TrainedPos.Add("In OB");
                }
                if (yM.OutdoorOBTrainingBool == true)
                {
                    TrainedPos.Add("Out OB");
                }
                Random rand = new Random();
                JointPositionList = AvailPosDay.Intersect(TrainedPos).ToList();
                int index = rand.Next(JointPositionList.Count);
                position += JointPositionList[index];
                switch (position)
                {
                    case "GH":
                        Gatehouse--;
                        break;
                    case "Out OB":
                        OutboundOutside--;
                        break;
                    case "Clerk OB":
                        ClerkOutbound--;
                        break;
                    case "In OB":
                        OutboundIndoor--;
                        break;
                    case "In IB":
                        InboundIndoor--;
                        break;
                    case "Clerk IB":
                        ClerkInbound--;
                        break;
                    case "Out IB":
                        InboundOutside--;
                        break;
                    default:
                        Sortation++;
                        break;
                }
                dataGridView1.Rows.Add(position, yM.Name);
                PosCounterConstructor();
                CheckPosAvail();
                InsertInXMLfile(yM.Name, position);
                position = string.Empty;
                JointPositionList.Clear();
                TrainedPos.Clear();
                MarshalsfromForm1.Remove(yM);
            }
        }
        //tuessday front end sort
        //wednesday mix back and front sort
        //thursday back end sort
        //daytime

        public string RandomPos(YM ym)
        {
            PosCounterConstructor();
            CheckPosAvail();
            string position=string.Empty;
            if (ym.RiskAssesed == false)
            {
                if (ym.GHtrainingBool == true)
                {
                    //allow to be deployed by adding the position to the trained position list
                    TrainedPos.Add("GH");
                }
                if (ym.ClerkIBTrainingBool == true)
                {
                    TrainedPos.Add("Clerk IB");
                }
                if (ym.ClerkOBTraininBool == true)
                {
                    TrainedPos.Add("Clerk OB");
                }
                if (ym.IndoorIBTrainingBool == true)
                {
                    TrainedPos.Add("In IB");
                }
                if (ym.OutdoorIBTrainingBool == true)
                {
                    TrainedPos.Add("Out IB");
                }
                if (ym.IndoorOBTrainingBool == true)
                {
                    TrainedPos.Add("In OB");
                }
                if (ym.OutdoorOBTrainingBool == true)
                {
                    TrainedPos.Add("Out OB");
                }
                Random rand = new Random();
                JointPositionList = AvailPosDay.Intersect(TrainedPos).ToList();
                int index = rand.Next(JointPositionList.Count);
                //position += JointPositionList[index];
                if (index <= 0)
                {
                    position += "Sortation";
                }
                else
                {
                    position += JointPositionList[index];
                }
            }
            else if (AllPosFilled==true)
            {
                AvailPosDay.Clear();
                AvailPosDay.Add("Sortation");
                position += AvailPosDay[0];

            }
            PosCounterConstructor();
            CheckPosAvail();
            return position;
        }

        private void GenerateRotaButton_Click(object sender, EventArgs e)
        {
            ExtractExcelButton.Enabled = true;
            foreach (YM ym in Form1.AvailableYM.Where(YM => YM.DayShift == false).ToList())
            {

                dataGridView1.Rows.Add("", ym.Name);
                PosCounterConstructor();
                CheckPosAvail();
                InsertInXMLfile(ym.Name, "");
                MarshalsfromForm1.Remove(ym);
            }//prints morning shift first with blank positions
            RandomPos4RiskAssessed(Form1.AvailableYM);//prints the positions for the riskassessed on shift.

            List<YM> yMs = new List<YM>();
                Random random = new Random();
            if (AvailPosDay.Contains("GH"))
            {
                foreach (YM yM in MarshalsfromForm1.Where(item => item.GHtrainingBool == true && AvailPosDay.Contains("GH")))
                {
                    yMs.Add(yM);
                }
                int index1 = random.Next(0, yMs.Count);
                GH += yMs[index1].Name;//INDEX OUT OF RANGE WAS TAKEN OUT BY ENTEING yMs.Count-1
                AvailPosDay.Remove("GH"); InsertInXMLfile(GH, "GH"); dataGridView1.Rows.Add("GH", GH);
                MarshalsfromForm1.Remove(yMs[index1]);//yMs[index].CB.CheckState = CheckState.Unchecked;
                yMs.Clear(); 
            }
            if (AvailPosDay.Contains("Out OB"))
            {
                foreach (YM yM in MarshalsfromForm1.Where(item => item.OutdoorOBTrainingBool == true && AvailPosDay.Contains("Out OB")))
                {
                    yMs.Add(yM);
                }
                int index2 = random.Next(0, yMs.Count);
                OutOB = yMs[index2].Name; InsertInXMLfile(OutOB, "Out OB"); dataGridView1.Rows.Add("Out OB", OutOB);
                AvailPosDay.Remove("Out OB");
                MarshalsfromForm1.Remove(yMs[index2]);//yMs[index].CB.CheckState = CheckState.Unchecked;
                yMs.Clear(); //index2 = 0;
            }
            if (AvailPosDay.Contains("Clerk OB"))
            {
                foreach (YM yM in MarshalsfromForm1)
                {
                    if (yM.ClerkOBTraininBool == true && AvailPosDay.Contains("Clerk OB"))
                    {
                        yMs.Add(yM);
                    }
                }
                int index3 = random.Next(0, yMs.Count);
                ClerkOB = yMs[index3].Name; InsertInXMLfile(ClerkOB, "Clerk OB"); dataGridView1.Rows.Add("Clerk OB", ClerkOB);
                AvailPosDay.Remove("Clerk OB");
                MarshalsfromForm1.Remove(yMs[index3]);//yMs[index].CB.CheckState = CheckState.Unchecked;
                yMs.Clear(); //index3 = 0;
            }
            if (AvailPosDay.Contains("In OB"))
            {
                foreach (YM yM in MarshalsfromForm1)
                {
                    if (yM.IndoorOBTrainingBool == true && AvailPosDay.Contains("In OB"))
                    {
                        yMs.Add(yM);
                    }
                }
                int index4 = random.Next(0, yMs.Count);
                InOB = yMs[index4].Name; InsertInXMLfile(InOB, "In OB"); dataGridView1.Rows.Add("In OB", InOB);
                AvailPosDay.Remove("In OB");
                MarshalsfromForm1.Remove(yMs[index4]);//yMs[index].CB.CheckState = CheckState.Unchecked;
                yMs.Clear(); //index4 = 0;
            }
            if (AvailPosDay.Contains("In IB"))
            {
                foreach (YM yM in MarshalsfromForm1)
                {
                    if (yM.IndoorIBTrainingBool == true && AvailPosDay.Contains("In IB"))
                    {
                        yMs.Add(yM);
                    }
                }
                int index5 = random.Next(0, yMs.Count);
                InIB = yMs[index5].Name; InsertInXMLfile(InIB, "In IB"); dataGridView1.Rows.Add("In IB", InIB);
                AvailPosDay.Remove("In IB");
                MarshalsfromForm1.Remove(yMs[index5]);//yMs[index].CB.CheckState = CheckState.Unchecked;
                yMs.Clear(); //index5 = 0;
            }
            if (AvailPosDay.Contains("Clerk IB"))
            {
                foreach (YM yM in MarshalsfromForm1)
                {
                    if (yM.ClerkIBTrainingBool == true && AvailPosDay.Contains("Clerk IB"))
                    {
                        yMs.Add(yM);
                    }
                }
                int index6 = random.Next(0, yMs.Count);
                ClerkIB = yMs[index6].Name; InsertInXMLfile(ClerkIB, "Clerk IB"); dataGridView1.Rows.Add("Clerk IB", ClerkIB);
                AvailPosDay.Remove("Clerk IB");
                MarshalsfromForm1.Remove(yMs[index6]);//yMs[index].CB.CheckState = CheckState.Unchecked;
                yMs.Clear(); //index6 = 0;
            }
            if (AvailPosDay.Contains("Out IB"))//WORK ON THIS AS A LOT OF TIMES THE TWO OUT IB POSITIONS ARE OCUPPIED BY THE SAME PERS.
            {
                foreach (YM yM in MarshalsfromForm1)
                {
                    if (yM.OutdoorIBTrainingBool == true && AvailPosDay.Contains("Out IB"))
                    {
                        yMs.Add(yM);
                    }
                }
                int index7a = random.Next(0, yMs.Count);
                OutIB1 = yMs[index7a].Name; InsertInXMLfile(OutIB1, "Out IB"); dataGridView1.Rows.Add("Out IB", OutIB1);
                MarshalsfromForm1.Remove(yMs[index7a]);//yMs[index].CB.CheckState = CheckState.Unchecked;
                index7a = 0;
                yMs.Clear(); //index7b = 0;
                foreach (YM yM in MarshalsfromForm1)
                {
                    if (yM.OutdoorIBTrainingBool == true && AvailPosDay.Contains("Out IB"))
                    {
                        yMs.Add(yM);
                    }
                }
                int index7b = random.Next(0, yMs.Count);
                OutIB2 = yMs[index7b].Name; InsertInXMLfile(OutIB2, "Out IB");dataGridView1.Rows.Add("Out IB", OutIB2);
                MarshalsfromForm1.Remove(yMs[index7b]);//yMs[index].CB.CheckState = CheckState.Unchecked;
                AvailPosDay.Remove("Clerk IB");

                yMs.Clear(); //index7b = 0;
                
            }
            if (MarshalsfromForm1.Count>0)
            {
                AvailPosDay.Clear();
                AvailPosDay.Add("Sortation");
                foreach (YM yM in MarshalsfromForm1.ToList())
                {
                    InsertInXMLfile(yM.Name, "Sortation");
                    MarshalsfromForm1.Remove(yM);
                    dataGridView1.Rows.Add("Sortation", yM.Name);
                }
            }
            else
            {

            }
           // MessageBox.Show($"GH-{GH},Out OB-{OutOB}, Clerk OK-{ClerkOB}, In OB-{InOB}, In IB-{InIB}, Clerk IB-{ClerkIB}, Out IB-{OutIB1}, {OutIB2}"); IT WAS HERE TO CHECK IF THE APP DOES WHAT IT IS SUPPOSED TO
           GenerateRotaButton.Enabled = false;
        }

        private void ExtractExcelButton_Click(object sender, EventArgs e)
        {
            Excel.Application excel = new Excel.Application();
            excel.Visible = true;
            object Missing = Type.Missing;
            Workbook workbook = excel.Workbooks.Add(Missing);
            Worksheet sheet1 = (Worksheet)workbook.Sheets[1];
            int StartCol = 1;
            int StartRow = 1;
            for (int j = 0; j < dataGridView1.Columns.Count; j++)
            {
                Range myRange = (Range)sheet1.Cells[StartRow, StartCol + j];
                myRange.Value2 = dataGridView1.Columns[j].HeaderText;
            }
            StartRow++;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {

                    Range myRange = (Range)sheet1.Cells[StartRow + i, StartCol + j];
                    myRange.Value2 = dataGridView1[j, i].Value == null ? "" : dataGridView1[j, i].Value;
                    myRange.Select();
                }
            }
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Escape))
            {
                Close();
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Here you can see the past positions for the selected associate in listbox1
            
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
