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


        public Form1()
        {
            RotorTypes = new Rotor[3];
            RotorTypes[0] = new RotorI();
            RotorTypes[1] = new RotorII();
            RotorTypes[2] = new RotorIII();

            Offsets = new int[27] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26 };

            P = new Plugboard(new Aplicacion("abcdefghijklmnñopqrstuvwxyz".ToCharArray()));

            InitializeComponent();

            cbbRotor1.DataSource = RotorTypes;
            cbbRotor2.DataSource = RotorTypes;
            cbbRotor3.DataSource = RotorTypes;
            cbbOffset1.DataSource = Offsets;
            cbbOffset2.DataSource = Offsets;
            cbbOffset3.DataSource = Offsets;
        }

        private void ChangeEnigma()
        {
            Rotor[] rotors = new Rotor[3] { cbbRotor1.SelectedItem as Rotor, cbbRotor2.SelectedItem as Rotor, cbbRotor3.SelectedItem as Rotor};
            Enigma = new Socket(rotors, P);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
