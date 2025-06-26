namespace ProyectoCiber.Desktop
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            btnPC_Click = new Button();
            btnTurnos_Click = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnPC_Click
            // 
            btnPC_Click.Location = new Point(122, 291);
            btnPC_Click.Name = "btnPC_Click";
            btnPC_Click.Size = new Size(169, 88);
            btnPC_Click.TabIndex = 0;
            btnPC_Click.Text = "Gestionar Pc's";
            btnPC_Click.UseVisualStyleBackColor = true;
            btnPC_Click.Click += btnPC_Click_Click;
            // 
            // btnTurnos_Click
            // 
            btnTurnos_Click.Location = new Point(361, 291);
            btnTurnos_Click.Name = "btnTurnos_Click";
            btnTurnos_Click.Size = new Size(169, 88);
            btnTurnos_Click.TabIndex = 0;
            btnTurnos_Click.Text = "Gestionar Turnos";
            btnTurnos_Click.UseVisualStyleBackColor = true;
            btnTurnos_Click.Click += btnTurnos_Click_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-3, -2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(659, 193);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Indigo;
            ClientSize = new Size(650, 450);
            Controls.Add(pictureBox1);
            Controls.Add(btnTurnos_Click);
            Controls.Add(btnPC_Click);
            Name = "FormMain";
            Text = "Form1";
            Load += FormMain_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnPC_Click;
        private Button btnTurnos_Click;
        private PictureBox pictureBox1;
    }
}
