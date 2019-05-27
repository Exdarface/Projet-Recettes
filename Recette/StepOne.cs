using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Recette
{
    public partial class StepOne : Form
    {
        public StepOne()
        {
            InitializeComponent();
        }

        OleDbConnection connec = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\Fichiers\IUT2018-19\S2\D21\Projet Recette 2019\baseFrigo1.mdb");
        DataSet ds = new DataSet();

        private void StepOne_Load(object sender, EventArgs e)
        {
            lblEtape1.Text += " Choisissez au max. 3 ingrédients dont vous disposez ou passez directement à l'étape 2.";

            connec.Open();
            DataTable schemaTable = connec.GetOleDbSchemaTable(
                OleDbSchemaGuid.Tables,
                new object[] { null, null, null, "TABLE" });

            foreach (DataRow r in schemaTable.Rows)
            {
                string req = @"SELECT * FROM [" + r[2].ToString() + "]";
                OleDbCommand cd = new OleDbCommand(req, connec);
                OleDbDataAdapter da = new OleDbDataAdapter(cd);
                da.Fill(ds, r[2].ToString());
            }
            connec.Close();

            int x = 5;
            int y = 0;

            foreach (DataRow r in ds.Tables["Famille"].Rows)
            {
                string s = r[1].ToString();
                Buttons b = new Buttons(s, pnlListe, r[0].ToString());
                b.Location = new Point(x, y);
                pnlFamilles.Controls.Add(b);
                y += 35;
            }
        }
    }
}
