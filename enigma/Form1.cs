using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace enigma
{
    public partial class Form1 : Form
    {
        private Rotor[] RotorTypes;
        private int[] Offsets;
        Socket Enigma;
        Plugboard P;
        Dictionary<ComboBox, int> RotorSelected;



        public Form1()
        {
            RotorTypes = new Rotor[3];
            RotorTypes[0] = new RotorI(0);
            RotorTypes[1] = new RotorII(0);
            RotorTypes[2] = new RotorIII(0);

            RotorSelected = new Dictionary<ComboBox, int>(3);

            Offsets = new int[27] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26 };

            P = new Plugboard(new Aplicacion("abcdefghijklmnñopqrstuvwxyz".ToCharArray()));

            InitializeComponent();

            cbbRotor1.DataSource = RotorTypes;
            cbbOffset1.DataSource = Offsets;
            cbbRotor2.BindingContext = new BindingContext();
            cbbOffset2.BindingContext = new BindingContext();
            cbbRotor2.DataSource = RotorTypes;
            cbbOffset2.DataSource = Offsets;
            cbbRotor3.BindingContext = new BindingContext();
            cbbOffset3.BindingContext = new BindingContext(); 
            cbbRotor3.DataSource = RotorTypes;
            cbbOffset3.DataSource = Offsets;

            cbbRotor2.SelectedIndex = 1;
            cbbRotor3.SelectedIndex = 2;
            ChangeEnigma();
            RotorSelected.Add(cbbRotor1, cbbRotor1.SelectedIndex);
            RotorSelected.Add(cbbRotor2, cbbRotor2.SelectedIndex);
            RotorSelected.Add(cbbRotor3, cbbRotor3.SelectedIndex);

            Enigma.EncriptacionFinalizada += EventoLogChanged;
            Enigma.EventoRotacionRotor += EventoRotacion;
        }

        private void EventoRotacion(object sender, EventArgs e)
        {
            int index = Convert.ToInt32(sender);
            switch (index)
            {
                case 0:
                    cbbOffset1.SelectedItem = (cbbRotor1.SelectedItem as Rotor).GetOffset();
                    break;
                case 1:
                    cbbOffset2.SelectedItem = (cbbRotor2.SelectedItem as Rotor).GetOffset();
                    break;
                case 2:
                    cbbOffset3.SelectedItem = (cbbRotor3.SelectedItem as Rotor).GetOffset();
                    break;
                default:
                    break;
            }
        }

        private void ChangeEnigma()
        {
            Rotor[] rotors = new Rotor[3] { cbbRotor1.SelectedItem as Rotor, cbbRotor2.SelectedItem as Rotor, cbbRotor3.SelectedItem as Rotor};
            Enigma = new Socket(rotors, P);
        }

        private void ChangeOffset(object sender, EventArgs e)
        {
            RotorTypes[0].ChangeOffset(Convert.ToInt32(cbbOffset1.SelectedItem));
            RotorTypes[1].ChangeOffset(Convert.ToInt32(cbbOffset2.SelectedItem));
            RotorTypes[2].ChangeOffset(Convert.ToInt32(cbbOffset3.SelectedItem));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            PlugboardView pgv = new PlugboardView(P);
            pgv.ShowDialog();
            pgv.Dispose();
        }

        private void btnEncriptar_Click(object sender, EventArgs e)
        {
            string input = txtInput.Text;
            txtOutput.Clear();
            txtOutput.Text = Enigma.Enigma(input);
        }

        private void EventoLogChanged(object sender, EventArgs e)
        {
            lbLog.Items.Clear();
            foreach (var item in Enigma.Log.Entries)
            {
                lbLog.Items.Add(item);
            }
        }

        private void RotorChanged(object sender, EventArgs e)
        {
            if(Enigma != null)
            {
                ComboBox changed = sender as ComboBox;

                foreach (KeyValuePair<ComboBox, int> a in RotorSelected)
                {
                    if(a.Key != changed && a.Key.SelectedItem == changed.SelectedItem)
                    {
                        int index;
                        RotorSelected.TryGetValue(changed, out index);
                        a.Key.SelectedIndex = index;
                        RotorSelected.Remove(changed);
                        RotorSelected.Add(changed, changed.SelectedIndex);
                        RotorSelected.Remove(a.Key);
                        RotorSelected.Add(a.Key, a.Key.SelectedIndex);
                        break;
                    }
                }

                if (changed == cbbRotor1)
                {
                    Enigma.ChangeRotor(0, cbbRotor1.SelectedItem as Rotor);
                }
                else if (changed == cbbRotor2)
                {
                    Enigma.ChangeRotor(1, cbbRotor2.SelectedItem as Rotor);
                }
                else if (changed == cbbRotor3)
                {
                    Enigma.ChangeRotor(2, cbbRotor3.SelectedItem as Rotor);
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Enigma.Log.Entries.Clear();
            lbLog.Items.Clear();
        }
    }
}
