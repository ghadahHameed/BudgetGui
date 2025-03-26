namespace BudgetGui
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            salaryBox = new TextBox();
            salaryLbL = new Label();
            percentLbL = new Label();
            percentBox = new TextBox();
            monthBox = new TextBox();
            monthLbL = new Label();
            label2 = new Label();
            APMBox = new TextBox();
            clearBtn = new Button();
            calcBtn = new Button();
            prcntLbL = new Label();
            prcntBox = new TextBox();
            slrLbL = new Label();
            mthLbL = new Label();
            mthBox = new TextBox();
            TASLbL = new Label();
            TASBox = new TextBox();
            nxtPgBtn = new Button();
            panel1 = new Panel();
            stPg = new Button();
            feaddBox = new PictureBox();
            pnlSv = new Panel();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)feaddBox).BeginInit();
            pnlSv.SuspendLayout();
            SuspendLayout();
            // 
            // salaryBox
            // 
            salaryBox.Location = new Point(301, 100);
            salaryBox.Name = "salaryBox";
            salaryBox.Size = new Size(180, 31);
            salaryBox.TabIndex = 0;
            salaryBox.TextChanged += salaryBox_TextChanged;
            // 
            // salaryLbL
            // 
            salaryLbL.AutoSize = true;
            salaryLbL.Font = new Font("Sylfaen", 16F, FontStyle.Regular, GraphicsUnit.Point);
            salaryLbL.Location = new Point(23, 91);
            salaryLbL.Name = "salaryLbL";
            salaryLbL.Size = new Size(257, 42);
            salaryLbL.TabIndex = 1;
            salaryLbL.Text = "Enter your salary:";
            salaryLbL.Click += label1_Click;
            // 
            // percentLbL
            // 
            percentLbL.AutoSize = true;
            percentLbL.Font = new Font("Sylfaen", 16F, FontStyle.Regular, GraphicsUnit.Point);
            percentLbL.Location = new Point(23, 160);
            percentLbL.Name = "percentLbL";
            percentLbL.Size = new Size(541, 42);
            percentLbL.TabIndex = 3;
            percentLbL.Text = "Enter the percentage you want to save:";
            // 
            // percentBox
            // 
            percentBox.Location = new Point(624, 170);
            percentBox.Name = "percentBox";
            percentBox.Size = new Size(180, 31);
            percentBox.TabIndex = 4;
            percentBox.TextChanged += percentBox_TextChanged;
            // 
            // monthBox
            // 
            monthBox.Location = new Point(624, 244);
            monthBox.Name = "monthBox";
            monthBox.Size = new Size(180, 31);
            monthBox.TabIndex = 5;
            monthBox.TextChanged += monthBox_TextChanged;
            // 
            // monthLbL
            // 
            monthLbL.AutoSize = true;
            monthLbL.Font = new Font("Sylfaen", 16F, FontStyle.Regular, GraphicsUnit.Point);
            monthLbL.Location = new Point(23, 233);
            monthLbL.Name = "monthLbL";
            monthLbL.Size = new Size(595, 42);
            monthLbL.TabIndex = 6;
            monthLbL.Text = "Enter how many months you want to save:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sylfaen", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(33, 447);
            label2.Name = "label2";
            label2.Size = new Size(377, 36);
            label2.TabIndex = 7;
            label2.Text = "The amount per month will be";
            // 
            // APMBox
            // 
            APMBox.Location = new Point(407, 449);
            APMBox.Name = "APMBox";
            APMBox.Size = new Size(57, 31);
            APMBox.TabIndex = 8;
            APMBox.TextChanged += APMBox_TextChanged;
            // 
            // clearBtn
            // 
            clearBtn.Anchor = AnchorStyles.Bottom;
            clearBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(253, 179, 235);
            clearBtn.FlatStyle = FlatStyle.Flat;
            clearBtn.Font = new Font("Sylfaen", 16F, FontStyle.Regular, GraphicsUnit.Point);
            clearBtn.Location = new Point(5, 397);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(165, 68);
            clearBtn.TabIndex = 9;
            clearBtn.Text = "clear all";
            clearBtn.UseVisualStyleBackColor = true;
            clearBtn.Click += clearBtn_Click;
            // 
            // calcBtn
            // 
            calcBtn.Font = new Font("Sylfaen", 28F, FontStyle.Regular, GraphicsUnit.Point);
            calcBtn.Location = new Point(252, 309);
            calcBtn.Name = "calcBtn";
            calcBtn.Size = new Size(385, 96);
            calcBtn.TabIndex = 11;
            calcBtn.Text = "calculate";
            calcBtn.UseVisualStyleBackColor = true;
            calcBtn.Click += calcBtn_Click;
            // 
            // prcntLbL
            // 
            prcntLbL.AutoSize = true;
            prcntLbL.Font = new Font("Sylfaen", 14F, FontStyle.Regular, GraphicsUnit.Point);
            prcntLbL.Location = new Point(34, 496);
            prcntLbL.Name = "prcntLbL";
            prcntLbL.Size = new Size(155, 36);
            prcntLbL.TabIndex = 12;
            prcntLbL.Text = "if you saved";
            // 
            // prcntBox
            // 
            prcntBox.Location = new Point(185, 501);
            prcntBox.Name = "prcntBox";
            prcntBox.Size = new Size(89, 31);
            prcntBox.TabIndex = 13;
            // 
            // slrLbL
            // 
            slrLbL.AutoSize = true;
            slrLbL.Font = new Font("Sylfaen", 14F, FontStyle.Regular, GraphicsUnit.Point);
            slrLbL.Location = new Point(273, 496);
            slrLbL.Name = "slrLbL";
            slrLbL.Size = new Size(296, 36);
            slrLbL.TabIndex = 14;
            slrLbL.Text = "%   from your salary for";
            // 
            // mthLbL
            // 
            mthLbL.AutoSize = true;
            mthLbL.Font = new Font("Sylfaen", 14F, FontStyle.Regular, GraphicsUnit.Point);
            mthLbL.Location = new Point(661, 496);
            mthLbL.Name = "mthLbL";
            mthLbL.Size = new Size(110, 36);
            mthLbL.TabIndex = 15;
            mthLbL.Text = "months.";
            mthLbL.Click += mthLbL_Click;
            // 
            // mthBox
            // 
            mthBox.Location = new Point(570, 501);
            mthBox.Name = "mthBox";
            mthBox.Size = new Size(92, 31);
            mthBox.TabIndex = 16;
            mthBox.TextChanged += mthBox_TextChanged;
            // 
            // TASLbL
            // 
            TASLbL.AutoSize = true;
            TASLbL.Font = new Font("Sylfaen", 14F, FontStyle.Regular, GraphicsUnit.Point);
            TASLbL.Location = new Point(32, 553);
            TASLbL.Name = "TASLbL";
            TASLbL.Size = new Size(402, 36);
            TASLbL.TabIndex = 17;
            TASLbL.Text = "the total amount you will save is:";
            // 
            // TASBox
            // 
            TASBox.Location = new Point(428, 557);
            TASBox.Name = "TASBox";
            TASBox.Size = new Size(99, 31);
            TASBox.TabIndex = 18;
            // 
            // nxtPgBtn
            // 
            nxtPgBtn.Anchor = AnchorStyles.Bottom;
            nxtPgBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(253, 179, 235);
            nxtPgBtn.FlatStyle = FlatStyle.Flat;
            nxtPgBtn.Font = new Font("Sylfaen", 12F, FontStyle.Regular, GraphicsUnit.Point);
            nxtPgBtn.Location = new Point(5, 475);
            nxtPgBtn.Name = "nxtPgBtn";
            nxtPgBtn.Size = new Size(165, 68);
            nxtPgBtn.TabIndex = 19;
            nxtPgBtn.Text = "Good's Page";
            nxtPgBtn.UseVisualStyleBackColor = true;
            nxtPgBtn.Click += nxtPgBtn_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(254, 231, 248);
            panel1.Controls.Add(stPg);
            panel1.Controls.Add(feaddBox);
            panel1.Controls.Add(clearBtn);
            panel1.Controls.Add(nxtPgBtn);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(926, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(173, 634);
            panel1.TabIndex = 20;
            // 
            // stPg
            // 
            stPg.Anchor = AnchorStyles.Bottom;
            stPg.FlatAppearance.MouseOverBackColor = Color.FromArgb(253, 179, 235);
            stPg.FlatStyle = FlatStyle.Flat;
            stPg.Font = new Font("Sylfaen", 12F, FontStyle.Regular, GraphicsUnit.Point);
            stPg.Location = new Point(5, 554);
            stPg.Name = "stPg";
            stPg.Size = new Size(165, 68);
            stPg.TabIndex = 21;
            stPg.Text = "Starting Page";
            stPg.UseVisualStyleBackColor = true;
            stPg.Click += stPg_Click;
            // 
            // feaddBox
            // 
            feaddBox.Anchor = AnchorStyles.Top;
            feaddBox.ErrorImage = (Image)resources.GetObject("feaddBox.ErrorImage");
            feaddBox.Image = (Image)resources.GetObject("feaddBox.Image");
            feaddBox.Location = new Point(0, 3);
            feaddBox.Name = "feaddBox";
            feaddBox.Size = new Size(173, 105);
            feaddBox.SizeMode = PictureBoxSizeMode.Zoom;
            feaddBox.TabIndex = 20;
            feaddBox.TabStop = false;
            // 
            // pnlSv
            // 
            pnlSv.Controls.Add(label1);
            pnlSv.Controls.Add(TASBox);
            pnlSv.Controls.Add(TASLbL);
            pnlSv.Controls.Add(mthBox);
            pnlSv.Controls.Add(mthLbL);
            pnlSv.Controls.Add(slrLbL);
            pnlSv.Controls.Add(prcntBox);
            pnlSv.Controls.Add(prcntLbL);
            pnlSv.Controls.Add(calcBtn);
            pnlSv.Controls.Add(APMBox);
            pnlSv.Controls.Add(label2);
            pnlSv.Controls.Add(monthLbL);
            pnlSv.Controls.Add(monthBox);
            pnlSv.Controls.Add(percentBox);
            pnlSv.Controls.Add(percentLbL);
            pnlSv.Controls.Add(salaryLbL);
            pnlSv.Controls.Add(salaryBox);
            pnlSv.Location = new Point(5, 6);
            pnlSv.Name = "pnlSv";
            pnlSv.Size = new Size(917, 624);
            pnlSv.TabIndex = 21;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sylfaen", 26F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(301, 13);
            label1.Name = "label1";
            label1.Size = new Size(369, 67);
            label1.TabIndex = 19;
            label1.Text = "SAVING PAGE";
            label1.Click += label1_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(254, 218, 245);
            ClientSize = new Size(1099, 634);
            Controls.Add(pnlSv);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)feaddBox).EndInit();
            pnlSv.ResumeLayout(false);
            pnlSv.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox salaryBox;
        private Label salaryLbL;
        private Label percentLbL;
        private TextBox percentBox;
        private TextBox monthBox;
        private Label monthLbL;
        private Label label2;
        private TextBox APMBox;
        private Button clearBtn;
        private Label invalidLbL;
        private Button calcBtn;
        private Label prcntLbL;
        private TextBox prcntBox;
        private Label slrLbL;
        private Label mthLbL;
        private TextBox mthBox;
        private Label TASLbL;
        private TextBox TASBox;
        private Button nxtPgBtn;
        private Panel panel1;
        private PictureBox feaddBox;
        private Panel pnlSv;
        private Button stPg;
        private Label label1;
    }
}