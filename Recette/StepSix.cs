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
    public partial class StepSix : Form
    {
        Bitmap bitmapBtnDisabled = new Bitmap(new Bitmap(@"../../../Images/Etoile_Blanche.png"), new Size(30, 30));
        Bitmap bitmapBtnEnabled = new Bitmap(new Bitmap(@"../../../Images/Etoile_Jaune.png"), new Size(30, 30));
        static string ch_connec = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:/Users/yoann/Documents/Semestre 2/Projet D21/Mini_Projet_Recettes/Base/baseFrigo.mdb";
        OleDbConnection connec = new OleDbConnection(ch_connec);
        DataSet ds = new DataSet();
        int note = 1;
        public StepSix()
        {
            InitializeComponent();
        }

        private void btnNote1_Click(object sender, EventArgs e)
        {
            switch (((Button)sender).Tag.ToString())
            {
                case "1":
                    btnNote1.BackgroundImage = bitmapBtnEnabled;
                    btnNote2.BackgroundImage = bitmapBtnDisabled;
                    btnNote3.BackgroundImage = bitmapBtnDisabled;
                    btnNote4.BackgroundImage = bitmapBtnDisabled;
                    note = 1;
                    break;
                case "2":
                    btnNote1.BackgroundImage = bitmapBtnEnabled;
                    btnNote2.BackgroundImage = bitmapBtnEnabled;
                    btnNote3.BackgroundImage = bitmapBtnDisabled;
                    btnNote4.BackgroundImage = bitmapBtnDisabled;
                    note = 2;
                    break;
                case "3":
                    btnNote1.BackgroundImage = bitmapBtnEnabled;
                    btnNote2.BackgroundImage = bitmapBtnEnabled;
                    btnNote3.BackgroundImage = bitmapBtnEnabled;
                    btnNote4.BackgroundImage = bitmapBtnDisabled;
                    note = 3;
                    break;
                case "4":
                    btnNote1.BackgroundImage = bitmapBtnEnabled;
                    btnNote2.BackgroundImage = bitmapBtnEnabled;
                    btnNote3.BackgroundImage = bitmapBtnEnabled;
                    btnNote4.BackgroundImage = bitmapBtnEnabled;
                    note = 4;
                    break;
            }
        }
        private void StepSix_Load(object sender, EventArgs e)
        {
            btnNote1.BackgroundImage = bitmapBtnEnabled;
            btnNote2.BackgroundImage = bitmapBtnDisabled;
            btnNote3.BackgroundImage = bitmapBtnDisabled;
            btnNote4.BackgroundImage = bitmapBtnDisabled;


            string req1 = "SELECT * FROM Recettes";
            OleDbDataAdapter da = new OleDbDataAdapter(req1, ch_connec);
            da.Fill(ds, "Recettes");
            cboRecettes.DataSource = ds.Tables["Recettes"];
            cboRecettes.DisplayMember = "description";
            cboRecettes.ValueMember = "codeRecette";

            OleDbCommand cmd = new OleDbCommand("CREATE TABLE IF NOT EXIST tblAvis ( [codeRecette] INT, [pseudoUtilisateur] VARCHAR(20), [dateAvis] DATE,[note] INT,[appreciation] VARCHAR(255) )", connec);
            da = new OleDbDataAdapter(cmd);
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
