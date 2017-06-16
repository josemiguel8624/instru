using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Collections;//Para poder usar las colecciones (ArrayList)
using ZedGraph;//Para poder usar los comandos relacionados con el gráfico

using System.IO.Ports;

namespace ProyectoInstru
{
    public partial class Sensores : Form
    {
        //Variable global
        ArrayList Puntos = new ArrayList();
        public Sensores()
        {
            InitializeComponent();
            MaximizeBox = false;
            Text = "Sensores MSP430G2553";
            Width = 800;
            Height = 600;
            CenterToScreen();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            string[] ports = SerialPort.GetPortNames();
            string[] senses = { "LDR", "LM35", "DHT11" };

            title.Text = "Proyecto Final. Instrumentación 2CM3";
            title.SetBounds(50, 50, 5, 30);

            members.Text = "Gorriz Barrera Alejandra\nPuente Gallegos Diego\nTejeda Martínez José Miguel";
            members.SetBounds(50, 80, 5, 30);

            comboCOM.SetBounds(50, 150, 100, 30);
            comboCOM.DataSource = ports;
            comboCOM.DropDownStyle = ComboBoxStyle.DropDownList;

            type_sense.SetBounds(200, 150, 100, 30);
            type_sense.DataSource = senses;
            type_sense.DropDownStyle = ComboBoxStyle.DropDownList;

            iniciar.SetBounds(400, 150, 100, 30);

            zedGraphControl1.SetBounds(80, 200, 640, 320);
            
        }

        private void title_Click(object sender, EventArgs e)
        {

        }

        private void members_Click(object sender, EventArgs e)
        {

        }

        private void comboCOM_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void zedGraphControl1_Load(object sender, EventArgs e)
        {

        }

        private void iniciar_Click(object sender, EventArgs e)
        {
            string port = comboCOM.SelectedItem.ToString();
            string sense = type_sense.SelectedItem.ToString();

            MessageBox.Show(port, sense, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            if (sense.Equals("LDR"))
            {
                Sense1();
            }
        }

        #region sensores
        private void Sense1()
        {
            MessageBox.Show("The calculations are complete", "My Application", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
        }

        private void Sense2()
        {
            ;
        }
        private void Sense3()
        {
            ;
        }
        #endregion

        private void fx()
        {
            ;
        }
    }
}
