namespace PersonalizarTextBox
{
    partial class TextBoxPasarRaton
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tB
            // 
            this.tB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tB.Location = new System.Drawing.Point(0, 0);
            this.tB.Name = "tB";
            this.tB.Size = new System.Drawing.Size(100, 19);
            this.tB.TabIndex = 0;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tB;
    }
}
