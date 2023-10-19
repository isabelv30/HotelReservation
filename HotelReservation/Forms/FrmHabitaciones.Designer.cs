namespace HotelReservation.Forms
{
    partial class FrmHabitaciones
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
            gridHabitaciones = new DataGridView();
            pnlCrearHab = new Panel();
            LblTitulo = new Label();
            label1 = new Label();
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)gridHabitaciones).BeginInit();
            pnlCrearHab.SuspendLayout();
            SuspendLayout();
            // 
            // gridHabitaciones
            // 
            gridHabitaciones.BorderStyle = BorderStyle.None;
            gridHabitaciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridHabitaciones.Location = new Point(173, 274);
            gridHabitaciones.Margin = new Padding(3, 4, 3, 4);
            gridHabitaciones.Name = "gridHabitaciones";
            gridHabitaciones.RowTemplate.Height = 25;
            gridHabitaciones.Size = new Size(419, 223);
            gridHabitaciones.TabIndex = 0;
            // 
            // pnlCrearHab
            // 
            pnlCrearHab.Controls.Add(comboBox1);
            pnlCrearHab.Controls.Add(label1);
            pnlCrearHab.Controls.Add(LblTitulo);
            pnlCrearHab.Location = new Point(12, 12);
            pnlCrearHab.Name = "pnlCrearHab";
            pnlCrearHab.Size = new Size(744, 194);
            pnlCrearHab.TabIndex = 2;
            // 
            // LblTitulo
            // 
            LblTitulo.AutoSize = true;
            LblTitulo.Location = new Point(23, 17);
            LblTitulo.Name = "LblTitulo";
            LblTitulo.Size = new Size(66, 19);
            LblTitulo.TabIndex = 2;
            LblTitulo.Text = "Check-In";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 57);
            label1.Name = "label1";
            label1.Size = new Size(82, 19);
            label1.TabIndex = 3;
            label1.Text = "Habitación";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(161, 54);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(419, 27);
            comboBox1.TabIndex = 4;
            // 
            // FrmHabitaciones
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(768, 575);
            Controls.Add(pnlCrearHab);
            Controls.Add(gridHabitaciones);
            Font = new Font("Gadugi", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmHabitaciones";
            Text = "FrmHabitaciones";
            Load += FrmHabitaciones_Load;
            ((System.ComponentModel.ISupportInitialize)gridHabitaciones).EndInit();
            pnlCrearHab.ResumeLayout(false);
            pnlCrearHab.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView gridHabitaciones;
        private Panel pnlCrearHab;
        private Label label1;
        private Label LblTitulo;
        private ComboBox comboBox1;
    }
}