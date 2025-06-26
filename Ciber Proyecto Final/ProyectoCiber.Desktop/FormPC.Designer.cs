namespace ProyectoCiber.Desktop
{
    partial class FormPC
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
            dgvPCs = new DataGridView();
            btnAgregar = new Button();
            btnActualizar = new Button();
            btnEliminar = new Button();
            txtTipo = new TextBox();
            txtGama = new TextBox();
            txtDuracion = new TextBox();
            txtId = new TextBox();
            label1 = new Label();
            GAMA = new Label();
            label3 = new Label();
            label4 = new Label();
            label2 = new Label();
            btnVolver = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPCs).BeginInit();
            SuspendLayout();
            // 
            // dgvPCs
            // 
            dgvPCs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPCs.Location = new Point(43, 23);
            dgvPCs.Name = "dgvPCs";
            dgvPCs.RowHeadersWidth = 51;
            dgvPCs.Size = new Size(418, 266);
            dgvPCs.TabIndex = 0;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(55, 314);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(120, 33);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(181, 314);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(121, 33);
            btnActualizar.TabIndex = 1;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(55, 362);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(120, 29);
            btnEliminar.TabIndex = 1;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // txtTipo
            // 
            txtTipo.Location = new Point(631, 266);
            txtTipo.Name = "txtTipo";
            txtTipo.Size = new Size(125, 27);
            txtTipo.TabIndex = 2;
            // 
            // txtGama
            // 
            txtGama.Location = new Point(631, 129);
            txtGama.Name = "txtGama";
            txtGama.Size = new Size(125, 27);
            txtGama.TabIndex = 2;
            // 
            // txtDuracion
            // 
            txtDuracion.Location = new Point(631, 200);
            txtDuracion.Name = "txtDuracion";
            txtDuracion.Size = new Size(125, 27);
            txtDuracion.TabIndex = 2;
            // 
            // txtId
            // 
            txtId.Location = new Point(631, 64);
            txtId.Name = "txtId";
            txtId.Size = new Size(125, 27);
            txtId.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Indigo;
            label1.ForeColor = Color.White;
            label1.Location = new Point(494, 67);
            label1.Name = "label1";
            label1.Size = new Size(24, 20);
            label1.TabIndex = 3;
            label1.Text = "ID";
            // 
            // GAMA
            // 
            GAMA.AutoSize = true;
            GAMA.ForeColor = Color.White;
            GAMA.Location = new Point(488, 129);
            GAMA.Name = "GAMA";
            GAMA.Size = new Size(52, 20);
            GAMA.TabIndex = 3;
            GAMA.Text = "GAMA";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(494, 187);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(490, 207);
            label4.Name = "label4";
            label4.Size = new Size(84, 20);
            label4.TabIndex = 3;
            label4.Text = "DURACION";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(494, 269);
            label2.Name = "label2";
            label2.Size = new Size(40, 20);
            label2.TabIndex = 4;
            label2.Text = "TIPO";
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(181, 358);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(121, 33);
            btnVolver.TabIndex = 5;
            btnVolver.Text = "Volver Atras";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // FormPC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Indigo;
            ClientSize = new Size(800, 450);
            Controls.Add(btnVolver);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(GAMA);
            Controls.Add(label1);
            Controls.Add(txtId);
            Controls.Add(txtDuracion);
            Controls.Add(txtGama);
            Controls.Add(txtTipo);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);
            Controls.Add(btnAgregar);
            Controls.Add(dgvPCs);
            Name = "FormPC";
            Text = "FormPC";
            Load += FormPC_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPCs).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvPCs;
        private Button btnAgregar;
        private Button btnActualizar;
        private Button btnEliminar;
        private TextBox txtTipo;
        private TextBox txtGama;
        private TextBox txtDuracion;
        private TextBox txtId;
        private Label label1;
        private Label GAMA;
        private Label label3;
        private Label label4;
        private Label label2;
        private Button btnVolver;
    }
}