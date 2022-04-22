using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YMrota
{//THE ROTA SHOULD BE PRINTED ONLY ONE TIME IN THE MORNING WHEN YOU HAVE ALL OF THE ASSOCIATES IN// PRINT THE ROTA FOR THE UPCOMING 3 DAYS CONSIDERING THAT ALL OF THE YM WILL BE PRESENT.
    
    //Find a way to properly distribute the whole team: early shift and day shift without overlaping positions from 11:30 up until 14:30. (16:30 for Tino)
    //this will be possible if you place in the list opposite positions ( if there is a GH position until 16:30 there should be another available for dayshift coming after 16:30,
    //if there is a position for IB until 14:30 then it should be a position for IB outside from 14:30,
    //if there is a position of sortation after 11:30 then there should be the normal positions that dayshift should cover)

    //Te morning shift can cover the whole IB from clerk position or the whole OB from GH. After 11:30 they can only be sortation, gatehouse or IB outside so the handover for clerk and indoor 
    //will take place early to avoid any misscomunication during the handover ( such as an uncompleted TDR of a door or a missing trailer from yard). EX: If a early shift is
    //doing a mistake at 14:25 and it leaves the next clerk will have to solve it which is unfair and unprofessional and also may lead to an affected performance of the operations.

    //Make the app to first output the rota for morning only for 2 / 4 (crossover shift) associates and positions respectively: IB and OB. The morning guys should have 
    //a limited number of options. If ym was in IB then two options available: stay in IB out/ sortation after 11:30. If ym was OB then: Stay OB GH/sortation after 11:30.
    public partial class Form1 : Form
    {
        public static List<YM> AvailableYM = new List<YM>();
        public bool PaulaCB = false;
        public bool LeonidCB=false;
        public bool StefanCB = false;
        public bool IonCB = false;
        public bool KalinCB = false;
        public bool SaraCB = false;
        public bool BorraoCB = false;
        public bool GraemeCB = false;
        public bool RyanCB = false;
        public bool RobertaCB = false;
        public bool CretzuCB=false;
        public bool NathanCB = false;
        public bool ClaudiuCB = false;
        public bool DianaCB=false;
        public bool LauraCB=false;
        public bool ParmeetCB=false;
        public bool ConstantinCB=false;
        public bool DayanaCB=false;
        public bool CedrykCB=false;
        public bool DevanteCB = false;
        public bool ShalaCB = false;    

        private bool ActivateConfirmB=false;
        //If you check a name multiple times then multiple instances of the YM class will be created under the same name.
        public Form1()
        {
            InitializeComponent(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var form2 = new Rota();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
            this.Hide();
            
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            if (ActivateConfirmB==false)
            {
                button1.Enabled = false;
            }
            /*FrontEndCheck.Hide();
            BackEndCheck.Hide();*/
            
        }

        private void Paula_CheckedChanged(object sender, EventArgs e)
        {
            YM Paula = new YM();
            YMAtributes(Paula, PaulaCheck,true,false,false,true,true,true,true,true); //ym,checkbox,ibout,ibin,obin,obout,gh,clib,clob
            YMState(PaulaCheck,PaulaCB,Paula);//add the ym to the available yard marshalls list
            Paula.RiskAssesed = true;
        }

        private void Leonid_CheckedChanged(object sender, EventArgs e)
        {
            YM Leonid = new YM();
            YMAtributes(Leonid, LeonidCheck, true, true, true, true, true, true, false, true); //ym,checkbox,ibout,ibin,obin,obout,gh,clib,clob
            YMState(LeonidCheck, LeonidCB, Leonid);
        }

        private void Stefan_CheckedChanged(object sender, EventArgs e)
        {
            YM Stefan = new YM();
            YMAtributes(Stefan, StefanCheck, true, true, true, true, false, true, false, true); //ym,checkbox,ibout,ibin,obin,obout,gh,clib,clob
            YMState(StefanCheck, StefanCB, Stefan);
        }

        private void Ion_CheckedChanged(object sender, EventArgs e)
        {
            YM Ion = new YM();
            YMAtributes(Ion, IonCheck, true, true, true, true, false, true, true, true); //ym,checkbox,ibout,ibin,obin,obout,gh,clib,clob
            YMState(IonCheck, IonCB, Ion);
        }

        private void Kalin_CheckedChanged(object sender, EventArgs e)
        {
            YM Kalin = new YM();
            YMAtributes(Kalin, KalinCheck, true, true, true, true, true, false, false, true); //ym,checkbox,ibout,ibin,obin,obout,gh,clib,clob
            YMState(KalinCheck, KalinCB, Kalin);
        }

        private void Sara_CheckedChanged(object sender, EventArgs e)
        {
            YM Sara = new YM();
            YMAtributes(Sara, SaraCheck, false, false, false, false, true, true, true, true); //ym,checkbox,ibout,ibin,obin,obout,gh,clib,clob
            YMState(SaraCheck, SaraCB, Sara);
            Sara.RiskAssesed=true;
        }
     
        private void Borrao_CheckedChanged(object sender, EventArgs e)
        {
            YM Borrao = new YM();
            YMAtributes(Borrao, BorraoCheck, true, true, true, true, true, true, true, true); //ym,checkbox,ibout,ibin,obin,obout,gh,clib,clob
            YMState(BorraoCheck, BorraoCB, Borrao);
        }

        private void Graeme_CheckedChanged(object sender, EventArgs e)
        {
            YM Graeme = new YM();
            YMAtributes(Graeme, GraemeCheck, true, true, true, true, true, true, true, true); //ym,checkbox,ibout,ibin,obin,obout,gh,clib,clob
            YMState(GraemeCheck, GraemeCB, Graeme);
        }

        private void Ryan_CheckedChanged(object sender, EventArgs e)
        {
            YM Ryan = new YM();
            YMAtributes(Ryan, RyanCheck, true, true, true, true, true, true, true, true); //ym,checkbox,ibout,ibin,obin,obout,gh,clib,clob
            YMState(RyanCheck, RyanCB, Ryan);
        }

        private void Roberta_CheckedChanged(object sender, EventArgs e)
        {
            YM Roberta = new YM();
            YMAtributes(Roberta, RobertaCheck, true, true, true, true, false, true, true, true); //ym,checkbox,ibout,ibin,obin,obout,gh,clib,clob
            YMState(RobertaCheck, RobertaCB, Roberta);
        }

        private void Cretzu_CheckedChanged(object sender, EventArgs e)
        {
            YM Cretzu = new YM();
            YMAtributes(Cretzu, CretzuCheck, true, true, true, true, true, true, true, true); //ym,checkbox,ibout,ibin,obin,obout,gh,clib,clob
            YMState(CretzuCheck, CretzuCB, Cretzu);
        }

        private void Nathan_CheckedChanged(object sender, EventArgs e)
        {
            YM Nathan = new YM();
            YMAtributes(Nathan, NathanCheck, true, true, true, true, true, true, true, true); //ym,checkbox,ibout,ibin,obin,obout,gh,clib,clob
            YMState(NathanCheck, NathanCB, Nathan);
        }

        private void Claudiu_CheckedChanged(object sender, EventArgs e)
        {
            YM Claudiu = new YM();
            YMAtributes(Claudiu, ClaudiuCheck, true, true, true, true, true, true, true, true); //ym,checkbox,ibout,ibin,obin,obout,gh,clib,clob
            YMState(ClaudiuCheck, ClaudiuCB, Claudiu);
        }

        private void Diana_CheckedChanged(object sender, EventArgs e)
        {
            YM Diana = new YM();
            YMAtributes(Diana, DianaCheck, true, true, true, true, false, true, true, true); //ym,checkbox,ibout,ibin,obin,obout,gh,clib,clob
            YMState(DianaCheck, DianaCB, Diana);
        }

        private void Laura_CheckedChanged(object sender, EventArgs e)
        {
            YM Laura = new YM();
            YMAtributes(Laura, LauraCheck, true, true, true, true, false, true, false, true); //ym,checkbox,ibout,ibin,obin,obout,gh,clib,clob,dayshift
            YMState(LauraCheck, LauraCB, Laura);
        }

        private void Parmeet_CheckedChanged(object sender, EventArgs e)
        {
            YM Parmeet = new YM();
            YMAtributes(Parmeet, ParmeetCheck, true, true, true, true, false, false, false, true); //ym,checkbox,ibout,ibin,obin,obout,gh,clib,clob,dayshift
            YMState(ParmeetCheck, ParmeetCB, Parmeet);
            
        }

        public void YMState(CheckBox cb, bool C,YM ym)
        {
            if (cb.CheckState == CheckState.Checked)
            {
                C = true;
                AvailableYM.Add(ym); //.Name???
            }
            else if (cb.CheckState==CheckState.Unchecked)
            {
                C = false;
                AvailableYM.Remove(ym);
            }
        }
        public void YMAtributes(YM yardMarshall,CheckBox CB,bool trIbOUT, bool trIbIN, bool trObIN, bool trObOUT ,bool trGH, bool trCLib, bool trCLob, bool shift)//ym,checkbox,ibout,ibin,obin,obout,gh,clib,clob.shift
        {
            
            yardMarshall.Name = CB.Text;
            yardMarshall.CB = CB;
            yardMarshall.ClerkOBTraininBool = trCLob;
            yardMarshall.ClerkIBTrainingBool = trCLib;
            yardMarshall.GHtrainingBool = trGH;
            yardMarshall.IndoorIBTrainingBool = trIbIN;
            yardMarshall.OutdoorIBTrainingBool=trIbOUT;
            yardMarshall.IndoorOBTrainingBool=trObIN;
            yardMarshall.OutdoorOBTrainingBool = trObOUT;
            yardMarshall.DayShift= shift;
            
        }
        public static string ReturnMarshalName(YM ym,CheckBox CB)
        {
            string name;
            ym.Name = CB.Text;
            name = ym.Name;
            CB.CheckState = CheckState.Unchecked;
            return name;
        }

        private void Constantin_CheckedChanged(object sender, EventArgs e)
        {
            YM Constantin = new YM();
            YMAtributes(Constantin, ConstantinCheck, true, true, true, true, true, true, false, false); //ym,checkbox,ibout,ibin,obin,obout,gh,clib,clob
            YMState(ConstantinCheck, ConstantinCB, Constantin);

          /*  if (DayanaCheck.CheckState == CheckState.Checked || DevanteCheck.CheckState == CheckState.Checked || ConstantinCheck.CheckState == CheckState.Checked || CedrykCheck.CheckState == CheckState.Checked)
            {
                button1.Enabled = true;
            }*/
        }

        private void Dayana_CheckedChanged(object sender, EventArgs e)
        {
            YM Dayana = new YM();
            YMAtributes(Dayana, DayanaCheck, true, true, true, true, true, true, false, false); //ym,checkbox,ibout,ibin,obin,obout,gh,clib,clob
            YMState(DayanaCheck, DayanaCB, Dayana);

           /* if (DayanaCheck.CheckState == CheckState.Checked || DevanteCheck.CheckState == CheckState.Checked || ConstantinCheck.CheckState == CheckState.Checked || CedrykCheck.CheckState == CheckState.Checked)
            {
                button1.Enabled = true;
            }*/
        }

        private void Cedryk_CheckedChanged(object sender, EventArgs e)
        {
            YM Cedryk = new YM();
            YMAtributes(Cedryk, CedrykCheck, true, true, true, true, true, true, false, false); //ym,checkbox,ibout,ibin,obin,obout,gh,clib,clob
            YMState(CedrykCheck, CedrykCB, Cedryk);

           /* if (DayanaCheck.CheckState == CheckState.Checked || DevanteCheck.CheckState == CheckState.Checked || ConstantinCheck.CheckState == CheckState.Checked || CedrykCheck.CheckState == CheckState.Checked)
            {
                button1.Enabled = true;
            }*/
            
            
        }

        private void Devante_CheckedChanged(object sender, EventArgs e)
        {
            YM Devante = new YM();
            YMAtributes(Devante, DevanteCheck, true, true, true, true, true, true, false, false); //ym,checkbox,ibout,ibin,obin,obout,gh,clib,clob
            YMState(DevanteCheck, DevanteCB, Devante);

           /* if (DayanaCheck.CheckState == CheckState.Checked || DevanteCheck.CheckState == CheckState.Checked || ConstantinCheck.CheckState == CheckState.Checked || CedrykCheck.CheckState == CheckState.Checked)
            {
                button1.Enabled = true;
            }*/
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            YM Shala = new YM();
            YMAtributes(Shala, ShalaCheck, false, false, false, false, false, true, true, true);
            YMState(ShalaCheck, ShalaCB, Shala);
            Shala.RiskAssesed = true;
        }

        private void FrontEndCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (FrontEndCheck.CheckState==CheckState.Checked)
            {
                DianaCheck.CheckState = CheckState.Checked;
                StefanCheck.CheckState = CheckState.Checked;
                IonCheck.CheckState = CheckState.Checked;
                BorraoCheck.CheckState = CheckState.Checked;
                DianaCheck.CheckState = CheckState.Checked;
                CretzuCheck.CheckState = CheckState.Checked;
                RyanCheck.CheckState = CheckState.Checked;
                RobertaCheck.CheckState = CheckState.Checked;
                ShalaCheck.CheckState = CheckState.Checked;
                PaulaCheck.CheckState = CheckState.Checked;
            }
            else if (FrontEndCheck.CheckState==CheckState.Unchecked)
            {
                DianaCheck.CheckState = CheckState.Unchecked;
                StefanCheck.CheckState = CheckState.Unchecked;
                IonCheck.CheckState = CheckState.Unchecked;
                BorraoCheck.CheckState = CheckState.Unchecked;
                DianaCheck.CheckState = CheckState.Unchecked;
                CretzuCheck.CheckState = CheckState.Unchecked;
                RyanCheck.CheckState = CheckState.Unchecked;
                RobertaCheck.CheckState = CheckState.Unchecked;
                ShalaCheck.CheckState = CheckState.Unchecked;
                PaulaCheck.CheckState = CheckState.Unchecked;
            }
        }

        private void BackEndCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (BackEndCheck.CheckState==CheckState.Checked)
            {
                GraemeCheck.CheckState = CheckState.Checked;
                NathanCheck.CheckState=CheckState.Checked;
                ClaudiuCheck.CheckState = CheckState.Checked;
                ParmeetCheck.CheckState = CheckState.Checked;
                LauraCheck.CheckState = CheckState.Checked;
                SaraCheck.CheckState = CheckState.Checked;
                KalinCheck.CheckState = CheckState.Checked;
                LeonidCheck.CheckState = CheckState.Checked;
            }
            else if (BackEndCheck.CheckState==CheckState.Unchecked)
            {
                GraemeCheck.CheckState = CheckState.Unchecked;
                NathanCheck.CheckState = CheckState.Unchecked;
                ClaudiuCheck.CheckState = CheckState.Unchecked;
                ParmeetCheck.CheckState = CheckState.Unchecked;
                LauraCheck.CheckState = CheckState.Unchecked;
                SaraCheck.CheckState = CheckState.Unchecked;
                KalinCheck.CheckState = CheckState.Unchecked;
                LeonidCheck.CheckState = CheckState.Unchecked;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Escape))
            {
                Close();
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void toggleButton1_CheckedChanged(object sender, EventArgs e)
        {
            bool MorningShift=false;
            List<YM> asd= new List<YM> ();
            //if (ConstantinCheck.CheckState == CheckState.Unchecked)//Do something to check what checkbox is ticked and if it is to eliminate all individuals that are inserted
                                                                   //into availymlist that are with that name (as it can be done multiple times by checking and unchecking the tickbox multiple times) and then add it back only once.
            foreach (YM yM in AvailableYM.ToList())
            {
                if (yM.CB.CheckState==CheckState.Unchecked)
                {
                    AvailableYM.Remove(yM);
                }
                else if (yM.CB.CheckState==CheckState.Checked)
                {
                    foreach (YM yM1 in AvailableYM.Where(yardm=>yardm.Name==yM.Name).ToList())
                    {
                        AvailableYM.Remove(yM1);
                    }
                    AvailableYM.Add(yM);
                }
            }
            foreach (YM yM2 in AvailableYM.Where(item => item.DayShift == false).ToList())
            {
                asd.Add(yM2);
                if (asd.Count>=1)
                {
                    MorningShift = true;
                }
                else
                {
                    MorningShift=false;
                }
            }
            if (MorningShift == true)
            {
                label1.Text=string.Empty;
                //deactivate all checkboxes
                ConstantinCheck.Enabled = false; DevanteCheck.Enabled = false; DianaCheck.Enabled = false;
                StefanCheck.Enabled = false; IonCheck.Enabled = false; BorraoCheck.Enabled = false;
                CretzuCheck.Enabled = false; RyanCheck.Enabled = false; RobertaCheck.Enabled = false;
                ShalaCheck.Enabled = false; PaulaCheck.Enabled = false;
                DayanaCheck.Enabled = false; CedrykCheck.Enabled = false; NathanCheck.Enabled = false;
                ClaudiuCheck.Enabled = false; ParmeetCheck.Enabled = false; LauraCheck.Enabled = false;
                KalinCheck.Enabled = false; SaraCheck.Enabled = false; LeonidCheck.Enabled = false; GraemeCheck.Enabled = false;
                //clear asd list
                asd.Clear();
                //enable confirm button
                if (AvailableYM.Count>=9)
                {
                    ActivateConfirmB = true;
                    button1.Enabled = true;
                }
                else 
                {
                    label1.ForeColor = Color.Red;
                    label1.Text = "Not enough people to fill the roles.";
                    toggleButton1.CheckState = CheckState.Unchecked;
                    ConstantinCheck.Enabled = true; DevanteCheck.Enabled = true; DianaCheck.Enabled = true;
                    StefanCheck.Enabled = true; IonCheck.Enabled = true; BorraoCheck.Enabled = true;
                    CretzuCheck.Enabled = true; RyanCheck.Enabled = true; RobertaCheck.Enabled = true;
                    ShalaCheck.Enabled = true; PaulaCheck.Enabled = true;
                    DayanaCheck.Enabled = true; CedrykCheck.Enabled = true; NathanCheck.Enabled = true;
                    ClaudiuCheck.Enabled = true; ParmeetCheck.Enabled = true; LauraCheck.Enabled = true;
                    KalinCheck.Enabled = true; SaraCheck.Enabled = true; LeonidCheck.Enabled = true; GraemeCheck.Enabled = true;
                }
                
            }
            else
            {
                label1.ForeColor = Color.Red;
                label1.Text = "Select the morning shift associates!";
                toggleButton1.CheckState = CheckState.Unchecked;
            }

        }
    }
    public class YM
        {
        public string Name { get; set; }
        public bool IndoorIBTrainingBool { get; set; }
        public bool IndoorOBTrainingBool { get; set; }
        public bool OutdoorIBTrainingBool { get; set; }
        public bool OutdoorOBTrainingBool { get; set; }
        public bool ClerkIBTrainingBool { get; set; }
        public bool ClerkOBTraininBool { get; set; }
        public bool GHtrainingBool { get; set; }
        public bool DayShift { get; set; }
        public CheckBox CB { get; set; }
        public bool RiskAssesed { get; set; }
    }

}
