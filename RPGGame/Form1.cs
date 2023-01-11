namespace RPGGame
{
    public partial class Form1 : Form
    {
        int index = 0;
        int _str;
        int _dex;
        int _con;
        int _int;
        int _wis;
        int _cha;
        public Form1()
        {
            InitializeComponent();
            InitialSettings();
        }

        void InitialSettings()
        {
            panel1.Visible = false;
            btn_Roll.Enabled = false;
        }
        private void btn_Start_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void btn_Accept_Click(object sender, EventArgs e)
        {
           
            btn_Roll.Enabled = true;
           
        }

        private void btn_Roll_Click(object sender, EventArgs e)
        {
         switch(index)
            {
                case 0:
                    _str = RollStart();
                    lbl_Str.Text = String.Format("Strenght:{0}", RollStart());
                    break;
               case 1:
                    _dex = RollStart();
                    lbl_Dex.Text = String.Format("Dexterity:{0}", RollStart());
                    break;
               case 2:
                    _con = RollStart();
                    lbl_Con.Text = String.Format("Constitution:{0}", RollStart());
                    break;
               case 3:
                    _int = RollStart();
                    lbl_Int.Text = String.Format("Intelligence:{0}", RollStart());
                    break;
               case 4:
                    _wis = RollStart();
                    lbl_Wis.Text = String.Format("Wisdom:{0}", RollStart());
                    break;
               case 5:
                    _cha = RollStart();
                    lbl_Cha.Text = String.Format("Charisma:{0}", RollStart());
                    break;

            }

            if(index < 6)
            {
                index++;
            }
            else
            {
                player p = new player(tb_Name.Text, _str, _dex, _con, _int, _wis, _cha);
                cb_ClassChoice.Visible = true;
                btn_Roll.Visible = false;

                cb_ClassChoice.Items.Clear();

                if(_str >= 9)
                {
                    cb_ClassChoice.Items.Add("Fighter");
                }
                if(_dex >= 9)
                {
                    cb_ClassChoice.Items.Add("Thief");
                }
                if(_wis >= 9)
                {
                    cb_ClassChoice.Items.Add("Priest");
                }
                if(_int >= 9)
                {
                    cb_ClassChoice.Items.Add("Wizard");
                }
                if(cb_ClassChoice.Items.Count == 0)
                {
                    Reset();
                }
            }
        }

        void Reset()
        {
           if(btn_Roll.Visible == false)
            {
                btn_Roll.Visible = true;
            }
            index = 0;
            lbl_Str.Text = "Str";
            lbl_Dex.Text = "Dex";
            lbl_Con.Text = "Con";
            lbl_Int.Text = "Int";
            lbl_Wis.Text = "Wis";
            lbl_Cha.Text = "Cha";


        }
        int RollStart()
        {
            int returnValue = 0;
            Random rand = new Random();
            for (int i = 0; i < 3; i++)
                {
                returnValue += rand.Next(1, 6);
                }
            return returnValue;
        }
    }
}