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
    public partial class PlugboardView : Form
    {
        Plugboard P;
        Dictionary<char, int> IntCharCorrespondency;
        ComboBox[] ComboBoxArray;
        char[] Abecedario;
        int[] IndexesSelected;
        bool finishedLoading = false;

        public PlugboardView(Plugboard p)
        {
            P = p;
            
            InitializeComponent();

            Abecedario = "abcdefghijklmnñopqrstuvwxyz".ToCharArray();

            IntCharCorrespondency = new Dictionary<char, int>(27)
            {
                { 'a', 0 },
                { 'b', 1 },
                { 'c', 2 },
                { 'd', 3 },
                { 'e', 4 },
                { 'f', 5 },
                { 'g', 6 },
                { 'h', 7 },
                { 'i', 8 },
                { 'j', 9 },
                { 'k', 10 },
                { 'l', 11 },
                { 'm', 12 },
                { 'n', 13 },
                { 'ñ', 14 },
                { 'o', 15 },
                { 'p', 16 },
                { 'q', 17 },
                { 'r', 18 },
                { 's', 19 },
                { 't', 20 },
                { 'u', 21 },
                { 'v', 22 },
                { 'w', 23 },
                { 'x', 24 },
                { 'y', 25 },
                { 'z', 26 }
            };

            ComboBoxArray = new ComboBox[] { cbbA, cbbB, cbbC, cbbD, cbbE, cbbF, cbbG, cbbH, cbbI, cbbJ, cbbK, cbbL, cbbM, cbbN, cbbNN, cbbO, cbbP, cbbQ, cbbR,
                                             cbbS, cbbT, cbbU, cbbV, cbbW, cbbX, cbbY, cbbZ};


            FillIndexesSelected();

            cbbA.DataSource = Abecedario;
            cbbB.BindingContext = new BindingContext();
            cbbB.DataSource = Abecedario;
            cbbC.BindingContext = new BindingContext();
            cbbC.DataSource = Abecedario;
            cbbD.BindingContext = new BindingContext();
            cbbD.DataSource = Abecedario;
            cbbE.BindingContext = new BindingContext();
            cbbE.DataSource = Abecedario;
            cbbF.BindingContext = new BindingContext();
            cbbF.DataSource = Abecedario;
            cbbG.BindingContext = new BindingContext();
            cbbG.DataSource = Abecedario;
            cbbH.BindingContext = new BindingContext();
            cbbH.DataSource = Abecedario;
            cbbI.BindingContext = new BindingContext();
            cbbI.DataSource = Abecedario;
            cbbJ.BindingContext = new BindingContext();
            cbbJ.DataSource = Abecedario;
            cbbK.BindingContext = new BindingContext();
            cbbK.DataSource = Abecedario;
            cbbL.BindingContext = new BindingContext();
            cbbL.DataSource = Abecedario;
            cbbM.BindingContext = new BindingContext();
            cbbM.DataSource = Abecedario;
            cbbN.BindingContext = new BindingContext();
            cbbN.DataSource = Abecedario;
            cbbNN.BindingContext = new BindingContext();
            cbbNN.DataSource = Abecedario;
            cbbO.BindingContext = new BindingContext();
            cbbO.DataSource = Abecedario;
            cbbP.BindingContext = new BindingContext();
            cbbP.DataSource = Abecedario;
            cbbQ.BindingContext = new BindingContext();
            cbbQ.DataSource = Abecedario;
            cbbR.BindingContext = new BindingContext();
            cbbR.DataSource = Abecedario;
            cbbS.BindingContext = new BindingContext();
            cbbS.DataSource = Abecedario;
            cbbT.BindingContext = new BindingContext();
            cbbT.DataSource = Abecedario;
            cbbU.BindingContext = new BindingContext();
            cbbU.DataSource = Abecedario;
            cbbV.BindingContext = new BindingContext();
            cbbV.DataSource = Abecedario;
            cbbW.BindingContext = new BindingContext();
            cbbW.DataSource = Abecedario;
            cbbX.BindingContext = new BindingContext();
            cbbX.DataSource = Abecedario;
            cbbY.BindingContext = new BindingContext();
            cbbY.DataSource = Abecedario;
            cbbZ.BindingContext = new BindingContext();
            cbbZ.DataSource = Abecedario;

            UpdateComboBoxes();

            finishedLoading = true;
        }

        private void UpdateComboBoxes()
        {
            for(int i = 0; i < P.aplicacion.output.Length; ++i)
            {
                ComboBoxArray[i].SelectedItem = P.aplicacion.output[i];
            }
        }

        private void SelectionChanged(object sender, EventArgs e)
        {
            if (!finishedLoading)
                return;

            char output = (char)(sender as ComboBox).SelectedItem;
            int indexInput = 0, indexOutput = 0;

            for(int i = 0; i < ComboBoxArray.Length; ++i)
            {
                if(ComboBoxArray[i] == sender as ComboBox)
                {
                    indexInput = i;
                }
            }

            IntCharCorrespondency.TryGetValue(output, out indexOutput);

            if(indexOutput == IndexesSelected[indexInput])
            {
                return;
            }

            if(IndexesSelected[indexInput] != indexInput && IndexesSelected[indexOutput] != indexOutput)
            {
                ComboBoxArray[indexInput].SelectedItem = Abecedario[IndexesSelected[indexInput]];
                return;
            }

            if (IndexesSelected[indexInput] != indexInput) //Plugged input
            {
                IndexesSelected[IndexesSelected[indexInput]] = IndexesSelected[indexInput];
                ComboBoxArray[IndexesSelected[indexInput]].SelectedItem = Abecedario[IndexesSelected[indexInput]];
            }

            if (IndexesSelected[indexOutput] != indexOutput && indexOutput != indexInput) //Plugged output
            {
                if ((char)ComboBoxArray[indexInput].SelectedItem != Abecedario[IndexesSelected[indexInput]])
                {
                    ComboBoxArray[indexInput].SelectedItem = Abecedario[IndexesSelected[indexInput]];
                }
                return;
            }

            IndexesSelected[indexInput] = indexOutput;
            IndexesSelected[indexOutput] = indexInput;
            ComboBoxArray[indexOutput].SelectedItem = Abecedario[indexInput];
        }

        private void UpdatePlugboard()
        {
            char[] output = Abecedario;

            for (int i = 0; i < ComboBoxArray.Length; i++)
            {
                output[i] = (char)ComboBoxArray[i].SelectedItem;
            }

            P.aplicacion.output = output;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            UpdatePlugboard();
            Close();
        }

        private void FillIndexesSelected()
        {
            IndexesSelected = new int[27];

            for(int i = 0; i < P.aplicacion.output.Length; ++i)
            {
                int index;
                IntCharCorrespondency.TryGetValue(P.aplicacion.output[i], out index);
                IndexesSelected[i] = index;
            }
        }
    }
}
