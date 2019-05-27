using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Recette
{
    public partial class Buttons : UserControl
    {
        public Buttons()
        {
            InitializeComponent();
        }

        public Buttons(string nom, Panel p, string tag)
        {
            InitializeComponent();
            btnUC.Text = nom;
            pnl = p;
            btnUC.Tag = tag;
        }

        Panel pnl = new Panel();
        OleDbConnection connec = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=..\..\..\Base\baseFrigo.mdb");
        DataSet ds = new DataSet();

        private void Buttons_Load(object sender, EventArgs e)
        {
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
        }

        private void btnUC_Click(object sender, EventArgs e)
        {
            Label l = new Label();
            int x = 10;
            int y = 10;
            switch (this.btnUC.Tag.ToString())
            {
                case "1":
                    pnl.Controls.Clear();
                    l.Text = btnUC.Text;
                    l.Location = new Point(10, 10);
                    pnl.Controls.Add(l);
                    foreach(DataRow r in ds.Tables["Ingrédients"].Rows)
                    {
                        if(r[2].ToString() == btnUC.Tag.ToString())
                        {
                            CheckBox cbx = new CheckBox();
                            cbx.Location = new Point(x, y);
                            cbx.Text = r[1].ToString();
                            pnl.Controls.Add(cbx);
                            y += 20;
                        }
                    }
                    break;
                case "2":
                    pnl.Controls.Clear();
                    l.Text = btnUC.Text;
                    l.Location = new Point(10, 10);
                    pnl.Controls.Add(l);
                    foreach (DataRow r in ds.Tables["Ingrédients"].Rows)
                    {
                        if (r[2].ToString() == btnUC.Tag.ToString())
                        {
                            CheckBox cbx = new CheckBox();
                            cbx.Location = new Point(x, y);
                            cbx.Text = r[1].ToString();
                            pnl.Controls.Add(cbx);
                            y += 20;
                        }
                    }
                    break;
                case "3":
                    pnl.Controls.Clear();
                    l.Text = btnUC.Text;
                    l.Location = new Point(10, 10);
                    pnl.Controls.Add(l);
                    foreach (DataRow r in ds.Tables["Ingrédients"].Rows)
                    {
                        if (r[2].ToString() == btnUC.Tag.ToString())
                        {
                            CheckBox cbx = new CheckBox();
                            cbx.Location = new Point(x, y);
                            cbx.Text = r[1].ToString();
                            pnl.Controls.Add(cbx);
                            y += 20;
                        }
                    }
                    break;
                case "4":
                    pnl.Controls.Clear();
                    l.Text = btnUC.Text;
                    l.Location = new Point(10, 10);
                    pnl.Controls.Add(l);
                    foreach (DataRow r in ds.Tables["Ingrédients"].Rows)
                    {
                        if (r[2].ToString() == btnUC.Tag.ToString())
                        {
                            CheckBox cbx = new CheckBox();
                            cbx.Location = new Point(x, y);
                            cbx.Text = r[1].ToString();
                            pnl.Controls.Add(cbx);
                            y += 20;
                        }
                    }
                    break;
                case "5":
                    pnl.Controls.Clear();
                    l.Text = btnUC.Text;
                    l.Location = new Point(10, 10);
                    pnl.Controls.Add(l);
                    foreach (DataRow r in ds.Tables["Ingrédients"].Rows)
                    {
                        if (r[2].ToString() == btnUC.Tag.ToString())
                        {
                            CheckBox cbx = new CheckBox();
                            cbx.Location = new Point(x, y);
                            cbx.Text = r[1].ToString();
                            pnl.Controls.Add(cbx);
                            y += 20;
                        }
                    }
                    break;
                case "6":
                    pnl.Controls.Clear();
                    l.Text = btnUC.Text;
                    l.Location = new Point(10, 10);
                    pnl.Controls.Add(l);
                    foreach (DataRow r in ds.Tables["Ingrédients"].Rows)
                    {
                        if (r[2].ToString() == btnUC.Tag.ToString())
                        {
                            CheckBox cbx = new CheckBox();
                            cbx.Location = new Point(x, y);
                            cbx.Text = r[1].ToString();
                            pnl.Controls.Add(cbx);
                            y += 20;
                        }
                    }
                    break;
                case "7":
                    pnl.Controls.Clear();
                    l.Text = btnUC.Text;
                    l.Location = new Point(10, 10);
                    pnl.Controls.Add(l);
                    foreach (DataRow r in ds.Tables["Ingrédients"].Rows)
                    {
                        if (r[2].ToString() == btnUC.Tag.ToString())
                        {
                            CheckBox cbx = new CheckBox();
                            cbx.Location = new Point(x, y);
                            cbx.Text = r[1].ToString();
                            pnl.Controls.Add(cbx);
                            y += 20;
                        }
                    }
                    break;
                case "8":
                    pnl.Controls.Clear();
                    l.Text = btnUC.Text;
                    l.Location = new Point(10, 10);
                    pnl.Controls.Add(l);
                    foreach (DataRow r in ds.Tables["Ingrédients"].Rows)
                    {
                        if (r[2].ToString() == btnUC.Tag.ToString())
                        {
                            CheckBox cbx = new CheckBox();
                            cbx.Location = new Point(x, y);
                            cbx.Text = r[1].ToString();
                            pnl.Controls.Add(cbx);
                            y += 20;
                        }
                    }
                    break;
                case "9":
                    pnl.Controls.Clear();
                    l.Text = btnUC.Text;
                    l.Location = new Point(10, 10);
                    pnl.Controls.Add(l);
                    foreach (DataRow r in ds.Tables["Ingrédients"].Rows)
                    {
                        if (r[2].ToString() == btnUC.Tag.ToString())
                        {
                            CheckBox cbx = new CheckBox();
                            cbx.Location = new Point(x, y);
                            cbx.Text = r[1].ToString();
                            pnl.Controls.Add(cbx);
                            y += 20;
                        }
                    }
                    break;
                case "10":
                    pnl.Controls.Clear();
                    l.Text = btnUC.Text;
                    l.Location = new Point(10, 10);
                    pnl.Controls.Add(l);
                    foreach (DataRow r in ds.Tables["Ingrédients"].Rows)
                    {
                        if (r[2].ToString() == btnUC.Tag.ToString())
                        {
                            CheckBox cbx = new CheckBox();
                            cbx.Location = new Point(x, y);
                            cbx.Text = r[1].ToString();
                            pnl.Controls.Add(cbx);
                            y += 20;
                        }
                    }
                    break;
                case "11":
                    pnl.Controls.Clear();
                    l.Text = btnUC.Text;
                    l.Location = new Point(10, 10);
                    pnl.Controls.Add(l);
                    foreach (DataRow r in ds.Tables["Ingrédients"].Rows)
                    {
                        if (r[2].ToString() == btnUC.Tag.ToString())
                        {
                            CheckBox cbx = new CheckBox();
                            cbx.Location = new Point(x, y);
                            cbx.Text = r[1].ToString();
                            pnl.Controls.Add(cbx);
                            y += 20;
                        }
                    }
                    break;
                case "12":
                    pnl.Controls.Clear();
                    l.Text = btnUC.Text;
                    l.Location = new Point(10, 10);
                    pnl.Controls.Add(l);
                    foreach (DataRow r in ds.Tables["Ingrédients"].Rows)
                    {
                        if (r[2].ToString() == btnUC.Tag.ToString())
                        {
                            CheckBox cbx = new CheckBox();
                            cbx.Location = new Point(x, y);
                            cbx.Text = r[1].ToString();
                            pnl.Controls.Add(cbx);
                            y += 20;
                        }
                    }
                    break;
                case "13":
                    pnl.Controls.Clear();
                    l.Text = btnUC.Text;
                    l.Location = new Point(10, 10);
                    pnl.Controls.Add(l);
                    foreach (DataRow r in ds.Tables["Ingrédients"].Rows)
                    {
                        if (r[2].ToString() == btnUC.Tag.ToString())
                        {
                            CheckBox cbx = new CheckBox();
                            cbx.Location = new Point(x, y);
                            cbx.Text = r[1].ToString();
                            pnl.Controls.Add(cbx);
                            y += 20;
                        }
                    }
                    break;
                case "14":
                    pnl.Controls.Clear();
                    l.Text = btnUC.Text;
                    l.Location = new Point(10, 10);
                    pnl.Controls.Add(l);
                    foreach (DataRow r in ds.Tables["Ingrédients"].Rows)
                    {
                        if (r[2].ToString() == btnUC.Tag.ToString())
                        {
                            CheckBox cbx = new CheckBox();
                            cbx.Location = new Point(x, y);
                            cbx.Text = r[1].ToString();
                            pnl.Controls.Add(cbx);
                            y += 20;
                        }
                    }
                    break;
                case "15":
                    pnl.Controls.Clear();
                    l.Text = btnUC.Text;
                    l.Location = new Point(10, 10);
                    pnl.Controls.Add(l);
                    foreach (DataRow r in ds.Tables["Ingrédients"].Rows)
                    {
                        if (r[2].ToString() == btnUC.Tag.ToString())
                        {
                            CheckBox cbx = new CheckBox();
                            cbx.Location = new Point(x, y);
                            cbx.Text = r[1].ToString();
                            pnl.Controls.Add(cbx);
                            y += 20;
                        }
                    }
                    break;
            }
        }
    }
}
