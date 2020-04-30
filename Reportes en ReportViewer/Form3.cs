using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reportes_en_ReportViewer
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
           
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'Ds.Productos' Puede moverla o quitarla según sea necesario.
            int valor;
            valor = Convert.ToInt32(textBox1.Text);
            this.ProductosTableAdapter.Fill(this.Ds.Productos,valor);

            this.reportViewer1.RefreshReport();
        }
    }
}
