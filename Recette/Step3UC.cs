using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recette
{
    public partial class Step3UC : UserControl
    {
        public Step3UC()
        {
            InitializeComponent();
        }

        public string image { get { return this.pibMiniature.Anchor.ToString(); } set
            {
                Image image = Image.FromFile("Images/" + value);
                pibMiniature.Image = image;
                pibMiniature.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            }
        }

        public string titre { get { return this.lblDesc.Text; } set { this.lblDesc.Text = value; } }
        public string time { get { return this.lblHorloge.Text; } set { this.lblHorloge.Text = value; } }
        public string price { get { return this.lblPrice.Text; } set { this.lblPrice.Text = value; } }

        public void setRecette(string imagePath, string titre, string time, string price)
        {
            this.titre = titre;
            this.time = time;
            this.price = price;
            this.image = imagePath;
        }

        private void Step3UC_Load(object sender, EventArgs e)
        {

        }
    }
}
