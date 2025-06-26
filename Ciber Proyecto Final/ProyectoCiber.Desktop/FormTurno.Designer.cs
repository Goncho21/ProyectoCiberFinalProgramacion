using ProyectoCiber.Data;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;



namespace ProyectoCiber.Desktop
{
    partial class FormTurno
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
            dtInicio = new DateTimePicker();
            btnCrearTurno = new Button();
            dgvTurnos = new DataGridView();
            btnVolver = new Button();
            label1 = new Label();
            FECHA = new Label();
            cbIdPC = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvTurnos).BeginInit();
            SuspendLayout();
            // 
            // dtInicio
            // 
            dtInicio.Location = new Point(108, 42);
            dtInicio.Name = "dtInicio";
            dtInicio.Size = new Size(245, 27);
            dtInicio.TabIndex = 1;
            // 
            // btnCrearTurno
            // 
            btnCrearTurno.Location = new Point(46, 158);
            btnCrearTurno.Name = "btnCrearTurno";
            btnCrearTurno.Size = new Size(300, 29);
            btnCrearTurno.TabIndex = 2;
            btnCrearTurno.Text = "Turno";
            btnCrearTurno.UseVisualStyleBackColor = true;
            btnCrearTurno.Click += btnCrearTurno_Click;
            // 
            // dgvTurnos
            // 
            dgvTurnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTurnos.Location = new Point(46, 207);
            dgvTurnos.Name = "dgvTurnos";
            dgvTurnos.RowHeadersWidth = 51;
            dgvTurnos.Size = new Size(300, 145);
            dgvTurnos.TabIndex = 3;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(46, 379);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(121, 33);
            btnVolver.TabIndex = 6;
            btnVolver.Text = "Volver Atras";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Indigo;
            label1.ForeColor = Color.White;
            label1.Location = new Point(46, 96);
            label1.Name = "label1";
            label1.Size = new Size(24, 20);
            label1.TabIndex = 7;
            label1.Text = "ID";
            // 
            // FECHA
            // 
            FECHA.AutoSize = true;
            FECHA.ForeColor = Color.White;
            FECHA.Location = new Point(46, 47);
            FECHA.Name = "FECHA";
            FECHA.Size = new Size(54, 20);
            FECHA.TabIndex = 8;
            FECHA.Text = "FECHA";
            // 
            // cbIdPC
            // 
            cbIdPC.FormattingEnabled = true;
            cbIdPC.Location = new Point(82, 98);
            cbIdPC.Name = "cbIdPC";
            cbIdPC.Size = new Size(93, 28);
            cbIdPC.TabIndex = 10;
            // 
            // FormTurno
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Indigo;
            ClientSize = new Size(384, 494);
            Controls.Add(cbIdPC);
            Controls.Add(FECHA);
            Controls.Add(label1);
            Controls.Add(btnVolver);
            Controls.Add(dgvTurnos);
            Controls.Add(btnCrearTurno);
            Controls.Add(dtInicio);
            Name = "FormTurno";
            Text = "FormTurno";
            Load += FormTurno_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTurnos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DateTimePicker dtInicio;
        private Button btnCrearTurno;
        private DataGridView dgvTurnos;
        private Button btnVolver;
        private Label label1;
        private Label FECHA;
        private ComboBox cbIdPC;
    }
}