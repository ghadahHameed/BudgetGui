namespace BudgetGui
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            pnl2 = new Panel();
            label2 = new Label();
            remMnthBox = new TextBox();
            yearBox = new TextBox();
            reqMnBox = new TextBox();
            amnSvBox = new TextBox();
            calcBtn = new Button();
            monthLbL = new Label();
            yerLbL = new Label();
            label1 = new Label();
            mnthLbL = new Label();
            reqMnLbL = new Label();
            amnSvLbL = new Label();
            prcPrdcBox = new TextBox();
            prcPrdcLbL = new Label();
            panel2 = new Panel();
            stPg = new Button();
            backBtn = new Button();
            clrBtn = new Button();
            feaddpic = new PictureBox();
            pnl2.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)feaddpic).BeginInit();
            SuspendLayout();
            // 
            // pnl2
            // 
            pnl2.Controls.Add(label2);
            pnl2.Controls.Add(remMnthBox);
            pnl2.Controls.Add(yearBox);
            pnl2.Controls.Add(reqMnBox);
            pnl2.Controls.Add(amnSvBox);
            pnl2.Controls.Add(calcBtn);
            pnl2.Controls.Add(monthLbL);
            pnl2.Controls.Add(yerLbL);
            pnl2.Controls.Add(label1);
            pnl2.Controls.Add(mnthLbL);
            pnl2.Controls.Add(reqMnLbL);
            pnl2.Controls.Add(amnSvLbL);
            pnl2.Controls.Add(prcPrdcBox);
            pnl2.Controls.Add(prcPrdcLbL);
            pnl2.Dock = DockStyle.Fill;
            pnl2.Location = new Point(0, 0);
            pnl2.Name = "pnl2";
            pnl2.Size = new Size(1099, 634);
            pnl2.TabIndex = 0;
            pnl2.Paint += pnl2_Paint;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sylfaen", 26F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(327, 24);
            label2.Name = "label2";
            label2.Size = new Size(366, 67);
            label2.TabIndex = 13;
            label2.Text = "GOOD'S PAGE";
            // 
            // remMnthBox
            // 
            remMnthBox.Location = new Point(380, 476);
            remMnthBox.Name = "remMnthBox";
            remMnthBox.Size = new Size(87, 31);
            remMnthBox.TabIndex = 12;
            // 
            // yearBox
            // 
            yearBox.Location = new Point(171, 476);
            yearBox.Name = "yearBox";
            yearBox.Size = new Size(87, 31);
            yearBox.TabIndex = 11;
            // 
            // reqMnBox
            // 
            reqMnBox.Location = new Point(606, 405);
            reqMnBox.Name = "reqMnBox";
            reqMnBox.Size = new Size(87, 31);
            reqMnBox.TabIndex = 10;
            // 
            // amnSvBox
            // 
            amnSvBox.Location = new Point(705, 214);
            amnSvBox.Name = "amnSvBox";
            amnSvBox.Size = new Size(160, 31);
            amnSvBox.TabIndex = 9;
            // 
            // calcBtn
            // 
            calcBtn.Font = new Font("Sylfaen", 24F, FontStyle.Regular, GraphicsUnit.Point);
            calcBtn.Location = new Point(340, 291);
            calcBtn.Name = "calcBtn";
            calcBtn.Size = new Size(385, 96);
            calcBtn.TabIndex = 8;
            calcBtn.Text = "calculate";
            calcBtn.UseVisualStyleBackColor = true;
            calcBtn.Click += button1_Click;
            // 
            // monthLbL
            // 
            monthLbL.AutoSize = true;
            monthLbL.Font = new Font("Sylfaen", 14F, FontStyle.Regular, GraphicsUnit.Point);
            monthLbL.Location = new Point(467, 472);
            monthLbL.Name = "monthLbL";
            monthLbL.Size = new Size(110, 36);
            monthLbL.TabIndex = 7;
            monthLbL.Text = "months.";
            monthLbL.Click += monthLbL_Click;
            // 
            // yerLbL
            // 
            yerLbL.AutoSize = true;
            yerLbL.Font = new Font("Sylfaen", 14F, FontStyle.Regular, GraphicsUnit.Point);
            yerLbL.Location = new Point(258, 471);
            yerLbL.Name = "yerLbL";
            yerLbL.Size = new Size(123, 36);
            yerLbL.TabIndex = 6;
            yerLbL.Text = "year  and";
            yerLbL.Click += yerLbL_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sylfaen", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 471);
            label1.Name = "label1";
            label1.Size = new Size(174, 36);
            label1.TabIndex = 5;
            label1.Text = "Which mean ";
            // 
            // mnthLbL
            // 
            mnthLbL.AutoSize = true;
            mnthLbL.Font = new Font("Sylfaen", 14F, FontStyle.Regular, GraphicsUnit.Point);
            mnthLbL.Location = new Point(693, 400);
            mnthLbL.Name = "mnthLbL";
            mnthLbL.Size = new Size(110, 36);
            mnthLbL.TabIndex = 4;
            mnthLbL.Text = "months.";
            // 
            // reqMnLbL
            // 
            reqMnLbL.AutoSize = true;
            reqMnLbL.Font = new Font("Sylfaen", 14F, FontStyle.Regular, GraphicsUnit.Point);
            reqMnLbL.Location = new Point(12, 400);
            reqMnLbL.Name = "reqMnLbL";
            reqMnLbL.Size = new Size(595, 36);
            reqMnLbL.TabIndex = 3;
            reqMnLbL.Text = "The required amount will be accumulated within";
            // 
            // amnSvLbL
            // 
            amnSvLbL.AutoSize = true;
            amnSvLbL.Font = new Font("Sylfaen", 14F, FontStyle.Regular, GraphicsUnit.Point);
            amnSvLbL.Location = new Point(12, 209);
            amnSvLbL.Name = "amnSvLbL";
            amnSvLbL.Size = new Size(591, 36);
            amnSvLbL.TabIndex = 2;
            amnSvLbL.Text = "Enter the amount you want to save every month:";
            // 
            // prcPrdcBox
            // 
            prcPrdcBox.Location = new Point(705, 132);
            prcPrdcBox.Name = "prcPrdcBox";
            prcPrdcBox.Size = new Size(160, 31);
            prcPrdcBox.TabIndex = 1;
            prcPrdcBox.TextChanged += prcPrdcBox_TextChanged;
            // 
            // prcPrdcLbL
            // 
            prcPrdcLbL.AutoSize = true;
            prcPrdcLbL.Font = new Font("Sylfaen", 14F, FontStyle.Regular, GraphicsUnit.Point);
            prcPrdcLbL.Location = new Point(12, 127);
            prcPrdcLbL.Name = "prcPrdcLbL";
            prcPrdcLbL.Size = new Size(632, 36);
            prcPrdcLbL.TabIndex = 0;
            prcPrdcLbL.Text = "Enter the price of the product you want to purchase:";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(254, 231, 248);
            panel2.Controls.Add(stPg);
            panel2.Controls.Add(backBtn);
            panel2.Controls.Add(clrBtn);
            panel2.Controls.Add(feaddpic);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(926, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(173, 634);
            panel2.TabIndex = 1;
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
            stPg.TabIndex = 3;
            stPg.Text = "Starting Page";
            stPg.UseVisualStyleBackColor = true;
            stPg.Click += stPg_Click;
            // 
            // backBtn
            // 
            backBtn.Anchor = AnchorStyles.Bottom;
            backBtn.FlatAppearance.MouseDownBackColor = Color.White;
            backBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(253, 179, 235);
            backBtn.FlatStyle = FlatStyle.Flat;
            backBtn.Font = new Font("Sylfaen", 14F, FontStyle.Regular, GraphicsUnit.Point);
            backBtn.Location = new Point(5, 475);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(165, 68);
            backBtn.TabIndex = 2;
            backBtn.Text = "Saving Page";
            backBtn.UseVisualStyleBackColor = true;
            backBtn.Click += backBtn_Click;
            // 
            // clrBtn
            // 
            clrBtn.Anchor = AnchorStyles.Bottom;
            clrBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(253, 179, 235);
            clrBtn.FlatStyle = FlatStyle.Flat;
            clrBtn.Font = new Font("Sylfaen", 16F, FontStyle.Regular, GraphicsUnit.Point);
            clrBtn.Location = new Point(5, 397);
            clrBtn.Name = "clrBtn";
            clrBtn.Size = new Size(165, 68);
            clrBtn.TabIndex = 1;
            clrBtn.Text = "Clear all";
            clrBtn.UseVisualStyleBackColor = true;
            clrBtn.Click += clrBtn_Click;
            // 
            // feaddpic
            // 
            feaddpic.Anchor = AnchorStyles.Top;
            feaddpic.Image = (Image)resources.GetObject("feaddpic.Image");
            feaddpic.Location = new Point(0, 1);
            feaddpic.Name = "feaddpic";
            feaddpic.Size = new Size(173, 105);
            feaddpic.SizeMode = PictureBoxSizeMode.Zoom;
            feaddpic.TabIndex = 0;
            feaddpic.TabStop = false;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(254, 218, 245);
            ClientSize = new Size(1099, 634);
            Controls.Add(panel2);
            Controls.Add(pnl2);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            pnl2.ResumeLayout(false);
            pnl2.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)feaddpic).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnl2;
        private Panel panel2;
        private PictureBox feaddpic;
        private Button clrBtn;
        private Button backBtn;
        private Label prcPrdcLbL;
        private TextBox prcPrdcBox;
        private Label amnSvLbL;
        private Label reqMnLbL;
        private Label mnthLbL;
        private Label label1;
        private Label yerLbL;
        private Label monthLbL;
        private Button calcBtn;
        private TextBox reqMnBox;
        private TextBox amnSvBox;
        private TextBox yearBox;
        private TextBox remMnthBox;
        private Button stPg;
        private Label label2;
    }
}