using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IntegracionEF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (MODELO_DATOS_UAMEntities db = new MODELO_DATOS_UAMEntities())
            {
                var listaProfes = db.PROFESORES;

                foreach (var profe in listaProfes)
                {
                    MessageBox.Show(profe.NOMBRE_COMPLETO);
                }
            }
        }
    }
}
