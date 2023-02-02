using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalizarTextBox
{
    public partial class TextBoxPasarRaton: TextBox
    {
        public TextBoxPasarRaton()
        {
            InitializeComponent();
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);

            this.Size = new Size(225, 26);
        }

        protected override void OnMouseHover(EventArgs e)
        {
            base.OnMouseHover(e);
            this.Size = new Size(225, 26);
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);

            this.Size = new Size(100, 26);
        }
    }
}
