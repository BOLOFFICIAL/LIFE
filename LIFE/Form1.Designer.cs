namespace LIFE
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.label3Lifes = new System.Windows.Forms.Label();
            this.buttonAction = new System.Windows.Forms.Button();
            this.numericUpDown2Density = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1Resolution = new System.Windows.Forms.NumericUpDown();
            this.label2Density = new System.Windows.Forms.Label();
            this.label1Resolution = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.информацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2Density)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1Resolution)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer
            // 
            this.splitContainer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer.IsSplitterFixed = true;
            this.splitContainer.Location = new System.Drawing.Point(0, 29);
            this.splitContainer.Margin = new System.Windows.Forms.Padding(10);
            this.splitContainer.MinimumSize = new System.Drawing.Size(712, 521);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.label3Lifes);
            this.splitContainer.Panel1.Controls.Add(this.buttonAction);
            this.splitContainer.Panel1.Controls.Add(this.numericUpDown2Density);
            this.splitContainer.Panel1.Controls.Add(this.numericUpDown1Resolution);
            this.splitContainer.Panel1.Controls.Add(this.label2Density);
            this.splitContainer.Panel1.Controls.Add(this.label1Resolution);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.pictureBox1);
            this.splitContainer.Size = new System.Drawing.Size(737, 521);
            this.splitContainer.SplitterDistance = 183;
            this.splitContainer.SplitterWidth = 10;
            this.splitContainer.TabIndex = 0;
            // 
            // label3Lifes
            // 
            this.label3Lifes.AutoSize = true;
            this.label3Lifes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label3Lifes.ForeColor = System.Drawing.SystemColors.Control;
            this.label3Lifes.Location = new System.Drawing.Point(3, 7);
            this.label3Lifes.Name = "label3Lifes";
            this.label3Lifes.Size = new System.Drawing.Size(82, 24);
            this.label3Lifes.TabIndex = 6;
            this.label3Lifes.Text = "Живых:";
            // 
            // buttonAction
            // 
            this.buttonAction.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonAction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonAction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAction.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAction.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonAction.Location = new System.Drawing.Point(3, 99);
            this.buttonAction.Name = "buttonAction";
            this.buttonAction.Size = new System.Drawing.Size(173, 415);
            this.buttonAction.TabIndex = 5;
            this.buttonAction.Text = "Start";
            this.buttonAction.UseVisualStyleBackColor = false;
            this.buttonAction.Click += new System.EventHandler(this.buttonAction_Click);
            // 
            // numericUpDown2Density
            // 
            this.numericUpDown2Density.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.numericUpDown2Density.Location = new System.Drawing.Point(125, 67);
            this.numericUpDown2Density.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDown2Density.Name = "numericUpDown2Density";
            this.numericUpDown2Density.Size = new System.Drawing.Size(51, 26);
            this.numericUpDown2Density.TabIndex = 4;
            this.numericUpDown2Density.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown2Density.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // numericUpDown1Resolution
            // 
            this.numericUpDown1Resolution.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDown1Resolution.Location = new System.Drawing.Point(125, 38);
            this.numericUpDown1Resolution.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDown1Resolution.Name = "numericUpDown1Resolution";
            this.numericUpDown1Resolution.Size = new System.Drawing.Size(51, 26);
            this.numericUpDown1Resolution.TabIndex = 1;
            this.numericUpDown1Resolution.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown1Resolution.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label2Density
            // 
            this.label2Density.AutoSize = true;
            this.label2Density.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2Density.ForeColor = System.Drawing.SystemColors.Control;
            this.label2Density.Location = new System.Drawing.Point(3, 66);
            this.label2Density.Name = "label2Density";
            this.label2Density.Size = new System.Drawing.Size(116, 24);
            this.label2Density.TabIndex = 2;
            this.label2Density.Text = "Плотность";
            this.label2Density.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1Resolution
            // 
            this.label1Resolution.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1Resolution.ForeColor = System.Drawing.SystemColors.Control;
            this.label1Resolution.Location = new System.Drawing.Point(3, 37);
            this.label1Resolution.Name = "label1Resolution";
            this.label1Resolution.Size = new System.Drawing.Size(116, 27);
            this.label1Resolution.TabIndex = 0;
            this.label1Resolution.Text = "Размер";
            this.label1Resolution.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(540, 517);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.информацияToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(737, 29);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // информацияToolStripMenuItem
            // 
            this.информацияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справкаToolStripMenuItem});
            this.информацияToolStripMenuItem.Name = "информацияToolStripMenuItem";
            this.информацияToolStripMenuItem.Size = new System.Drawing.Size(110, 25);
            this.информацияToolStripMenuItem.Text = "Программа";
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(142, 26);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(737, 549);
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(753, 588);
            this.Name = "Form1";
            this.Text = "Симуляция жизни";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel1.PerformLayout();
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2Density)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1Resolution)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.Button buttonAction;
        private System.Windows.Forms.NumericUpDown numericUpDown2Density;
        private System.Windows.Forms.NumericUpDown numericUpDown1Resolution;
        private System.Windows.Forms.Label label2Density;
        private System.Windows.Forms.Label label1Resolution;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label3Lifes;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem информацияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
    }
}

