namespace BudgetGui
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            svPG = new Button();
            nxPG = new Button();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Sylfaen", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(426, 91);
            label1.Name = "label1";
            label1.Size = new Size(214, 52);
            label1.TabIndex = 0;
            label1.Text = "welcome to";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.ErrorImage = (Image)resources.GetObject("pictureBox1.ErrorImage");
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(166, 137);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(764, 304);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // svPG
            // 
            svPG.Anchor = AnchorStyles.None;
            svPG.FlatAppearance.MouseOverBackColor = Color.FromArgb(253, 179, 235);
            svPG.FlatStyle = FlatStyle.Flat;
            svPG.Font = new Font("Sylfaen", 16F, FontStyle.Regular, GraphicsUnit.Point);
            svPG.Location = new Point(426, 447);
            svPG.Name = "svPG";
            svPG.Size = new Size(232, 64);
            svPG.TabIndex = 2;
            svPG.Text = "Saving page";
            svPG.UseVisualStyleBackColor = true;
            svPG.Click += svPG_Click;
            // 
            // nxPG
            // 
            nxPG.Anchor = AnchorStyles.None;
            nxPG.FlatAppearance.MouseOverBackColor = Color.FromArgb(253, 179, 235);
            nxPG.FlatStyle = FlatStyle.Flat;
            nxPG.Font = new Font("Sylfaen", 16F, FontStyle.Regular, GraphicsUnit.Point);
            nxPG.Location = new Point(426, 530);
            nxPG.Name = "nxPG";
            nxPG.Size = new Size(232, 64);
            nxPG.TabIndex = 3;
            nxPG.Text = "Good's Page";
            nxPG.UseVisualStyleBackColor = true;
            nxPG.Click += nxPG_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(891, 539);
            textBox1.Name = "textBox1";
            textBox1.PasswordChar = '*';
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 4;
            textBox1.UseSystemPasswordChar = true;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(254, 218, 245);
            ClientSize = new Size(1099, 634);
            Controls.Add(textBox1);
            Controls.Add(nxPG);
            Controls.Add(svPG);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Button svPG;
        private Button nxPG;
        private TextBox textBox1;
    }
}