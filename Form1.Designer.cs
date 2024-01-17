namespace SAHEP
{
    partial class terminal_segura
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitulo = new Label();
            txaConsola = new RichTextBox();
            btnEnviar = new Button();
            txaRespuesta = new RichTextBox();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Consolas", 21.73585F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(158, 42);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(575, 37);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Agencia Hiper Secreta de Espías";
            // 
            // txaConsola
            // 
            txaConsola.AccessibleRole = AccessibleRole.None;
            txaConsola.BackColor = Color.FromArgb(31, 31, 31);
            txaConsola.Cursor = Cursors.No;
            txaConsola.Font = new Font("Consolas", 12.2264156F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txaConsola.ForeColor = Color.WhiteSmoke;
            txaConsola.ImeMode = ImeMode.NoControl;
            txaConsola.Location = new Point(88, 129);
            txaConsola.Name = "txaConsola";
            txaConsola.ReadOnly = true;
            txaConsola.Size = new Size(711, 228);
            txaConsola.TabIndex = 2;
            txaConsola.Text = "";
            // 
            // btnEnviar
            // 
            btnEnviar.BackColor = Color.Black;
            btnEnviar.Font = new Font("Consolas", 14.2641506F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEnviar.Location = new Point(377, 547);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(160, 41);
            btnEnviar.TabIndex = 3;
            btnEnviar.Text = "Enviar";
            btnEnviar.UseVisualStyleBackColor = false;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // txaRespuesta
            // 
            txaRespuesta.BackColor = SystemColors.InfoText;
            txaRespuesta.ForeColor = Color.Lime;
            txaRespuesta.Location = new Point(88, 422);
            txaRespuesta.Name = "txaRespuesta";
            txaRespuesta.Size = new Size(711, 94);
            txaRespuesta.TabIndex = 0;
            txaRespuesta.Text = "";
            txaRespuesta.UseWaitCursor = true;
            // 
            // terminal_segura
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(885, 631);
            Controls.Add(txaRespuesta);
            Controls.Add(btnEnviar);
            Controls.Add(txaConsola);
            Controls.Add(lblTitulo);
            Font = new Font("Consolas", 10.8679247F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.Lime;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(4, 3, 4, 3);
            Name = "terminal_segura";
            Text = "terminal_segura";
            Load += terminal_segura_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private RichTextBox txaConsola;
        private Button btnEnviar;
        private RichTextBox txaRespuesta;
    }
}
