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
    public partial class StepTwo : Form
    {
        public StepTwo()
        {
            InitializeComponent();
        }

        DataSet ds = new DataSet();
        DataTable dt = new DataTable();
        OleDbConnection connec = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=..\..\..\Base\baseFrigo.mdb");

        private void StepTwo_Load(object sender, EventArgs e)
        {
            try
            {
                connec.Open();
                DataTable SchemaTable = connec.GetOleDbSchemaTable(
                    OleDbSchemaGuid.Tables,
                    new object[] { null, null, null, "TABLE" });


                foreach (DataRow r in SchemaTable.Rows)
                {
                    string req0 = @"SELECT * FROM [" + r[2].ToString() + "]";     // Prends toutes les tables dans 2eme colonnes (DataGridView)
                    OleDbCommand cd = new OleDbCommand(req0, connec);
                    OleDbDataAdapter da = new OleDbDataAdapter(cd);
                    da.Fill(ds, r[2].ToString());
                }


                string req1 = "SELECT libCategorie FROM Catégories";
                OleDbCommand cd1 = new OleDbCommand(req1, connec);
                OleDbDataAdapter da1 = new OleDbDataAdapter(cd1);
                da1.Fill(ds, "LibCategorie");

                int i = 0;
                int x = 30;
                int y = 30;
                foreach (DataRow row in ds.Tables["LibCategorie"].Rows)
                {

                    if (i < 3)
                    {

                        RadioButton rdbType = new RadioButton();
                        rdbType.Text = row[0].ToString();
                        rdbType.Location = new Point(x, y);
                        y += 40;
                        rdbType.AutoSize = true;
                        rdbType.Font = new Font("Arial", 9, FontStyle.Bold);
                        grpType.Controls.Add(rdbType);
                        i++;

                    }
                    else
                    {
                        RadioButton rdbType = new RadioButton();
                        rdbType.Text = row[0].ToString();
                        rdbType.Location = new Point(x, y);
                        rdbType.AutoSize = true;
                        rdbType.Font = new Font("Arial", 9, FontStyle.Bold);
                        grpType.Controls.Add(rdbType);
                        x += 160;
                        y = 30;
                        i = 0;
                    }
                }

                string req2 = "SELECT categPrix FROM Recettes";
                OleDbCommand cd2 = new OleDbCommand(req2, connec);
                OleDbDataAdapter da2 = new OleDbDataAdapter(cd2);
                da2.Fill(ds, "categPrix");

                int a = 20;
                int b = 20;
                foreach (DataRow row in ds.Tables["categPrix"].Rows)
                {
                    RadioButton rdbBudget = new RadioButton();
                    rdbBudget.Text = row[0].ToString();
                    rdbBudget.Location = new Point(a, b);
                    a += 100;
                    rdbBudget.AutoSize = true;
                    grpBudget.Controls.Add(rdbBudget);
                }


            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connec.Close();
            }


        }
    }
}
