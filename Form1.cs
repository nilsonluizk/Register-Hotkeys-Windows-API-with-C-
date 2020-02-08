using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace ATENDIMENTO_MÓVEL
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll")]
        public static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vlc);
        [DllImport("user32.dll")]
        public static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            textBox1.Text = Properties.Settings.Default.textbox1;
            textBox2.Text = Properties.Settings.Default.textbox2;
            textBox3.Text = Properties.Settings.Default.textbox3;
            textBox4.Text = Properties.Settings.Default.textbox4;
            textBox5.Text = Properties.Settings.Default.textbox5;
            textBox6.Text = Properties.Settings.Default.textbox6;
            textBox7.Text = Properties.Settings.Default.textbox7;
            textBox8.Text = Properties.Settings.Default.textbox8;
            textBox9.Text = Properties.Settings.Default.textbox9;
            textBox10.Text = Properties.Settings.Default.textbox10;
            textBox11.Text = Properties.Settings.Default.textbox11;
            textBox12.Text = Properties.Settings.Default.textbox12;
            textBox13.Text = Properties.Settings.Default.textbox13;
            textBox14.Text = Properties.Settings.Default.textbox14;
            //checkbox
            checkBox2.Checked = Properties.Settings.Default.check2;
            checkBox3.Checked = Properties.Settings.Default.check1;
            checkBox4.Checked = Properties.Settings.Default.check3;
            checkBox5.Checked = Properties.Settings.Default.check4;
            checkBox6.Checked = Properties.Settings.Default.check5;
            checkBox7.Checked = Properties.Settings.Default.check6;
            checkBox8.Checked = Properties.Settings.Default.check7;
            checkBox9.Checked = Properties.Settings.Default.check8;
            checkBox10.Checked = Properties.Settings.Default.check9;
            checkBox11.Checked = Properties.Settings.Default.check10;
            checkBox12.Checked = Properties.Settings.Default.check11;
            checkBox13.Checked = Properties.Settings.Default.check12;
            checkBox14.Checked = Properties.Settings.Default.check13;
            checkBox15.Checked = Properties.Settings.Default.check14;


        }

        protected override void WndProc(ref Message m)
        {
            //F1
            int FirstHotkeyId = 1;
            int FirstHotKeyKey = (int)Keys.F1;
            if (checkBox2.Checked) { RegisterHotKey(this.Handle, FirstHotkeyId, 0x0000, FirstHotKeyKey); }
            else { UnregisterHotKey(this.Handle, FirstHotkeyId); }
            //F2
            int SecondHotkeyId = 2;
            int SecondHotKeyKey = (int)Keys.F2;
            if (checkBox3.Checked) { RegisterHotKey(this.Handle, SecondHotkeyId, 0x0000, SecondHotKeyKey); }
            else { UnregisterHotKey(this.Handle, SecondHotkeyId); }

            //F3
            int TerceiraHotkeyId = 3;
            int TerceiraHotKeyKey = (int)Keys.F3;
            if (checkBox4.Checked) { RegisterHotKey(this.Handle, TerceiraHotkeyId, 0x0000, TerceiraHotKeyKey); }
            else { UnregisterHotKey(this.Handle, TerceiraHotkeyId); }
            //F4
            int QuartoHotkeyId = 4;
            int QuartoHotKeyKey = (int)Keys.F4;
            if (checkBox5.Checked) { RegisterHotKey(this.Handle, QuartoHotkeyId, 0x0000, QuartoHotKeyKey); }
            else { UnregisterHotKey(this.Handle, QuartoHotkeyId); }
            //F5
            int QuintoHotkeyId = 5;
            int QuintoHotKeyKey = (int)Keys.F5;
            if (checkBox6.Checked) { RegisterHotKey(this.Handle, QuintoHotkeyId, 0x0000, QuintoHotKeyKey); }
            else { UnregisterHotKey(this.Handle, QuintoHotkeyId); }

            //F6
            int SextoHotkeyId = 6;
            int SextoHotKeyKey = (int)Keys.F6;
            if (checkBox7.Checked) { RegisterHotKey(this.Handle, SextoHotkeyId, 0x0000, SextoHotKeyKey); }
            else { UnregisterHotKey(this.Handle, SextoHotkeyId); }

            //F7
            int SetimoHotkeyId = 7;
            int SetimoHotKeyKey = (int)Keys.F7;
            if (checkBox8.Checked) { RegisterHotKey(this.Handle, SetimoHotkeyId, 0x0000, SetimoHotKeyKey); }
            else { UnregisterHotKey(this.Handle, SetimoHotkeyId); }

            //F8
            int OitavoHotkeyId = 8;
            int OitavoHotKeyKey = (int)Keys.F8;
            if (checkBox9.Checked) { RegisterHotKey(this.Handle, OitavoHotkeyId, 0x0000, OitavoHotKeyKey); }
            else { UnregisterHotKey(this.Handle, OitavoHotkeyId); }
            //F9
            int NonoHotkeyId = 9;
            int NovoHotKeyKey = (int)Keys.F9;
            if (checkBox10.Checked){ RegisterHotKey(this.Handle, NonoHotkeyId, 0x0000, NovoHotKeyKey); }
            else{UnregisterHotKey(this.Handle, NonoHotkeyId);}

            
            //F10
            int DecimoHotkeyId = 10;
            int DecimHotKeyKey = (int)Keys.F10;
            if (checkBox11.Checked) { RegisterHotKey(this.Handle, DecimoHotkeyId, 0x0000, DecimHotKeyKey); }
            else { UnregisterHotKey(this.Handle, DecimoHotkeyId); }

            //F11
            int DecimoprimHotkeyId = 11;
            int DecimpriHotKeyKey = (int)Keys.F11;
            if (checkBox12.Checked) { RegisterHotKey(this.Handle, DecimoprimHotkeyId, 0x0000, DecimpriHotKeyKey); }
            else { UnregisterHotKey(this.Handle, DecimoprimHotkeyId); }


            //HOME
            int DecimosegHotkeyId = 13;
            int DecimsegHotKeyKey = (int)Keys.Home;
            if (checkBox13.Checked) { RegisterHotKey(this.Handle, DecimosegHotkeyId, 0x0000, DecimsegHotKeyKey); }
            else { UnregisterHotKey(this.Handle, DecimosegHotkeyId); }

            //INSERT
            int DecimotercHotkeyId = 12;
            int DecimtercHotKeyKey = (int)Keys.Insert;
            if (checkBox14.Checked) { RegisterHotKey(this.Handle, DecimotercHotkeyId, 0x0000, DecimtercHotKeyKey); }
            else { UnregisterHotKey(this.Handle, DecimotercHotkeyId); }

            //END
            int DecimoQUacHotkeyId = 14;
            int DecimQUAHotKeyKey = (int)Keys.End;
            if (checkBox15.Checked) { RegisterHotKey(this.Handle, DecimoQUacHotkeyId, 0x0000, DecimQUAHotKeyKey); }
            else { UnregisterHotKey(this.Handle, DecimoQUacHotkeyId); }

            

            // 5. Catch when a HotKey is pressed !
            if (m.Msg == 0x0312)
            {
                int id = m.WParam.ToInt32();
                // MessageBox.Show(string.Format("Hotkey #{0} pressed", id));

                // 6. Handle what will happen once a respective hotkey is pressed
                switch (id)
                {
                    //F1
                    case 1:
                         
                        SendKeys.Send(textBox1.Text);
                        break;
                    //F2
                    case 2:
                        Clipboard.SetText(textBox2.Text);
                        SendKeys.Send("^v");
                        
                        break;
                    //F3
                    case 3:
                        Clipboard.SetText(textBox3.Text);
                        SendKeys.Send("^v");
                        
                        break;
                    //F4
                    case 4:
                        Clipboard.SetText(textBox4.Text);
                        SendKeys.Send("^v");
                        
                        break;
                    //F5
                    case 5:
                        Clipboard.SetText(textBox5.Text);
                        SendKeys.Send("^v");
                        
                        break;
                    //F6
                    case 6:
                        Clipboard.SetText(textBox6.Text);
                        SendKeys.Send("^v");
                        
                        break;
                    //F7
                    case 7:
                        Clipboard.SetText(textBox7.Text);
                        SendKeys.Send("^v");
                        
                        break;
                    //F8
                    case 8:
                        Clipboard.SetText(textBox8.Text);
                        SendKeys.Send("^v");
                        
                        break;
                    //F9
                    case 9:
                        Clipboard.SetText(textBox9.Text);
                        SendKeys.Send("^v");
                        
                        break;
                    //F10
                    case 10:
                        Clipboard.SetText(textBox10.Text);
                        SendKeys.Send("^v");
                        
                        break;
                    //F11
                    case 11:
                        Clipboard.SetText(textBox11.Text);
                        SendKeys.Send("^v");
                        
                        break;
                    //12
                    case 12:
                        Clipboard.SetText(textBox12.Text);
                        SendKeys.Send("^v");
                        
                        break;
                    case 13:
                        Clipboard.SetText(textBox13.Text);
                        SendKeys.Send("^v");
                        
                        break;
                    case 14:
                        Clipboard.SetText(textBox14.Text);
                        SendKeys.Send("^v");
                        
                        break;
                    
                }
            }

            base.WndProc(ref m);
        }

        private void button1_Click(object sender, EventArgs e)
        {

           

        }

        private void sALVARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.textbox1 = textBox1.Text;
            Properties.Settings.Default.textbox2 = textBox2.Text;
            Properties.Settings.Default.textbox3 = textBox3.Text;
            Properties.Settings.Default.textbox4 = textBox4.Text;
            Properties.Settings.Default.textbox5 = textBox5.Text;
            Properties.Settings.Default.textbox6 = textBox6.Text;
            Properties.Settings.Default.textbox7 = textBox7.Text;
            Properties.Settings.Default.textbox8 = textBox8.Text;
            Properties.Settings.Default.textbox9 = textBox9.Text;
            Properties.Settings.Default.textbox10 = textBox10.Text;
            Properties.Settings.Default.textbox11 = textBox11.Text;
            Properties.Settings.Default.textbox12 = textBox12.Text;
            Properties.Settings.Default.textbox13 = textBox13.Text;
            Properties.Settings.Default.textbox14 = textBox14.Text;
            //cheackbox
            Properties.Settings.Default.check2 = checkBox2.Checked;
            Properties.Settings.Default.check1 = checkBox3.Checked;
            Properties.Settings.Default.check3 = checkBox4.Checked;
            Properties.Settings.Default.check4 = checkBox5.Checked;
            Properties.Settings.Default.check5 = checkBox6.Checked;
            Properties.Settings.Default.check6 = checkBox7.Checked;
            Properties.Settings.Default.check7 = checkBox8.Checked;
            Properties.Settings.Default.check8 = checkBox9.Checked;
            Properties.Settings.Default.check9 = checkBox10.Checked;
            Properties.Settings.Default.check10 = checkBox11.Checked;
            Properties.Settings.Default.check11 = checkBox12.Checked;
            Properties.Settings.Default.check12 = checkBox13.Checked;
            Properties.Settings.Default.check13 = checkBox14.Checked;
            Properties.Settings.Default.check14 = checkBox15.Checked;
            


            Properties.Settings.Default.Save();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                Navegadores ex = new Navegadores();
                ex.AbrirUmEx();
            }
            else
            {
                Navegadores ex = new Navegadores();
                ex.AbrirumCr();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                Navegadores ex = new Navegadores();
                ex.AbrirdoisEx();
            }
            else
            {
                Navegadores ex = new Navegadores();
                ex.AbrirdoisCr();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                Navegadores ex = new Navegadores();
                ex.AbrirTresEx();
            }
            else
            {
                Navegadores ex = new Navegadores();
                ex.AbrirTresCr();
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
          

        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                Navegadores ex = new Navegadores();
                ex.AbrircincoEx();
            }
            else
            {
                Navegadores ex = new Navegadores();
                ex.AbrircincoCr();
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                Navegadores ex = new Navegadores();
                ex.AbrirseisEx();
            }
            else
            {
                Navegadores ex = new Navegadores();
                ex.AbrirseisCr();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                Navegadores ex = new Navegadores();
                ex.AbrirseteEx();
            }
            else
            {
                Navegadores ex = new Navegadores();
                ex.AbrirseteCr();
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                Navegadores ex = new Navegadores();
                ex.AbriroitoEx();
            }
            else
            {
                Navegadores ex = new Navegadores();
                ex.AbriroitoCr();
            }
        
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                Navegadores ex = new Navegadores();
                ex.AbrirnoveEx();
            }
            else
            {
                Navegadores ex = new Navegadores();
                ex.AbrirnoveCr();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                Navegadores ex = new Navegadores();
                ex.AbrirdezEx();
            }
            else
            {
                Navegadores ex = new Navegadores();
                ex.AbrirdezCr();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                Navegadores ex = new Navegadores();
                ex.AbrironzeEx();
            }
            else
            {
                Navegadores ex = new Navegadores();
                ex.AbrironzeCr();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                Navegadores ex = new Navegadores();
                ex.AbrirdozeEx();
            }
            else
            {
                Navegadores ex = new Navegadores();
                ex.AbrirdozeCr();
            }
            

        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                Navegadores ex = new Navegadores();
                ex.AbrirtrezeEx();
            }
            else
            {
                Navegadores ex = new Navegadores();
                ex.AbrirtrezeCr();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Navegadores ex = new Navegadores();
            ex.AbrirquatorzeCr();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Navegadores ex = new Navegadores();
            ex.AbrirquinzeCr();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Navegadores ex = new Navegadores();
            ex.AbrirdezesseisCr();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Navegadores ex = new Navegadores();
            ex.AbrirdezesseteCr();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Navegadores ex = new Navegadores();
            ex.AbrirdezoitoCr();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                Navegadores ex = new Navegadores();
                ex.AbrirdoisEx();
            }
            else
            {
                Navegadores ex = new Navegadores();
                ex.AbrirdoisCr();
            }
            if (checkBox1.Checked)
            {
                Navegadores ex = new Navegadores();
                ex.AbrirTresEx();
            }
            else
            {
                Navegadores ex = new Navegadores();
                ex.AbrirTresCr();
            }
            if (checkBox1.Checked)
            {
                Navegadores ex = new Navegadores();
                ex.AbrirUmEx();
            }
            else
            {
                Navegadores ex = new Navegadores();
                ex.AbrirumCr();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 2000;

            Random MeuNome = new Random();
            int A = MeuNome.Next(0, 255);
            int R = MeuNome.Next(0, 255);
            int G = MeuNome.Next(0, 255);
            int B = MeuNome.Next(0, 255);

            label1.ForeColor = Color.FromArgb(A, R, G, B);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            {
               Microsoft.Win32.RegistryKey reg = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
                reg.SetValue("My Application", Application.ExecutablePath.ToString());
                MessageBox.Show("Agora seu APP iniciará automaticamente com o Windows.", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
