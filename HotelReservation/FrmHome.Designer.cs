namespace HotelReservation
{
    partial class FrmHome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlFondo = new Panel();
            pnlHabitaciones = new Panel();
            lblMenuHabitaciones = new Label();
            pnlHabitaciones.SuspendLayout();
            SuspendLayout();
            // 
            // pnlFondo
            // 
            pnlFondo.BackColor = Color.Transparent;
            pnlFondo.Location = new Point(186, 0);
            pnlFondo.Name = "pnlFondo";
            pnlFondo.Size = new Size(768, 575);
            pnlFondo.TabIndex = 0;
            // 
            // pnlHabitaciones
            // 
            pnlHabitaciones.BackColor = Color.Transparent;
            pnlHabitaciones.Controls.Add(lblMenuHabitaciones);
            pnlHabitaciones.Location = new Point(1, 58);
            pnlHabitaciones.Name = "pnlHabitaciones";
            pnlHabitaciones.Size = new Size(180, 45);
            pnlHabitaciones.TabIndex = 1;
            pnlHabitaciones.Click += pnlHabitaciones_Click;
            // 
            // lblMenuHabitaciones
            // 
            lblMenuHabitaciones.AutoSize = true;
            lblMenuHabitaciones.Font = new Font("Gadugi", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblMenuHabitaciones.ForeColor = Color.Black;
            lblMenuHabitaciones.Location = new Point(69, 13);
            lblMenuHabitaciones.Name = "lblMenuHabitaciones";
            lblMenuHabitaciones.Size = new Size(96, 19);
            lblMenuHabitaciones.TabIndex = 0;
            lblMenuHabitaciones.Text = "Habitaciones";
            // 
            // FrmHome
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(955, 574);
            Controls.Add(pnlHabitaciones);
            Controls.Add(pnlFondo);
            Font = new Font("Gadugi", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4);
            Name = "FrmHome";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hotel";
            Load += FrmHome_Load;
            pnlHabitaciones.ResumeLayout(false);
            pnlHabitaciones.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlFondo;
        private Panel pnlHabitaciones;
        private Label lblMenuHabitaciones;
    }
}