namespace SystAnalys_lr1
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.listBoxMatrix = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.about = new System.Windows.Forms.ToolStripMenuItem();
            this.saveButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBus1 = new System.Windows.Forms.PictureBox();
            this.cycleButton = new System.Windows.Forms.Button();
            this.chainButton = new System.Windows.Forms.Button();
            this.selectButton = new System.Windows.Forms.Button();
            this.buttonInc = new System.Windows.Forms.Button();
            this.buttonAdj = new System.Windows.Forms.Button();
            this.deleteALLButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.drawEdgeButton = new System.Windows.Forms.Button();
            this.drawVertexButton = new System.Windows.Forms.Button();
            this.sheet = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBus1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sheet)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxMatrix
            // 
            this.listBoxMatrix.FormattingEnabled = true;
            this.listBoxMatrix.Location = new System.Drawing.Point(1341, 97);
            this.listBoxMatrix.Name = "listBoxMatrix";
            this.listBoxMatrix.Size = new System.Drawing.Size(329, 303);
            this.listBoxMatrix.TabIndex = 6;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.about});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1608, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // about
            // 
            this.about.Name = "about";
            this.about.Size = new System.Drawing.Size(12, 20);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(1452, 475);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(96, 23);
            this.saveButton.TabIndex = 13;
            this.saveButton.Text = "Сохранить граф";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1354, 507);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "label1";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::SystAnalys_lr1.Properties.Resources.Map;
            this.pictureBox3.Location = new System.Drawing.Point(94, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(1216, 823);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 18;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SystAnalys_lr1.Properties.Resources.shkolnyy_avtobus1;
            this.pictureBox2.Location = new System.Drawing.Point(1167, 39);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(10, 12);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SystAnalys_lr1.Properties.Resources.shkolnyy_avtobus2;
            this.pictureBox1.Location = new System.Drawing.Point(922, 411);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(10, 13);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBus1
            // 
            this.pictureBus1.Image = global::SystAnalys_lr1.Properties.Resources.shkolnyy_avtobus;
            this.pictureBus1.Location = new System.Drawing.Point(282, 453);
            this.pictureBus1.Name = "pictureBus1";
            this.pictureBus1.Size = new System.Drawing.Size(10, 12);
            this.pictureBus1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBus1.TabIndex = 14;
            this.pictureBus1.TabStop = false;
            // 
            // cycleButton
            // 
            this.cycleButton.Image = global::SystAnalys_lr1.Properties.Resources.cycle;
            this.cycleButton.Location = new System.Drawing.Point(1535, 420);
            this.cycleButton.Name = "cycleButton";
            this.cycleButton.Size = new System.Drawing.Size(70, 45);
            this.cycleButton.TabIndex = 11;
            this.cycleButton.UseVisualStyleBackColor = true;
            this.cycleButton.Click += new System.EventHandler(this.cycleButton_Click);
            // 
            // chainButton
            // 
            this.chainButton.Image = global::SystAnalys_lr1.Properties.Resources.chain;
            this.chainButton.Location = new System.Drawing.Point(1393, 420);
            this.chainButton.Name = "chainButton";
            this.chainButton.Size = new System.Drawing.Size(70, 45);
            this.chainButton.TabIndex = 10;
            this.chainButton.UseVisualStyleBackColor = true;
            this.chainButton.Click += new System.EventHandler(this.chainButton_Click);
            // 
            // selectButton
            // 
            this.selectButton.Image = global::SystAnalys_lr1.Properties.Resources.cursor;
            this.selectButton.Location = new System.Drawing.Point(12, 12);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(45, 45);
            this.selectButton.TabIndex = 9;
            this.selectButton.UseVisualStyleBackColor = true;
            this.selectButton.Click += new System.EventHandler(this.selectButton_Click);
            // 
            // buttonInc
            // 
            this.buttonInc.Image = global::SystAnalys_lr1.Properties.Resources.inc;
            this.buttonInc.Location = new System.Drawing.Point(1466, 39);
            this.buttonInc.Name = "buttonInc";
            this.buttonInc.Size = new System.Drawing.Size(92, 52);
            this.buttonInc.TabIndex = 8;
            this.buttonInc.UseVisualStyleBackColor = true;
            this.buttonInc.Click += new System.EventHandler(this.buttonInc_Click);
            // 
            // buttonAdj
            // 
            this.buttonAdj.Image = global::SystAnalys_lr1.Properties.Resources.smezh;
            this.buttonAdj.Location = new System.Drawing.Point(1341, 39);
            this.buttonAdj.Name = "buttonAdj";
            this.buttonAdj.Size = new System.Drawing.Size(92, 52);
            this.buttonAdj.TabIndex = 7;
            this.buttonAdj.UseVisualStyleBackColor = true;
            this.buttonAdj.Click += new System.EventHandler(this.buttonAdj_Click);
            // 
            // deleteALLButton
            // 
            this.deleteALLButton.Image = global::SystAnalys_lr1.Properties.Resources.deleteAll;
            this.deleteALLButton.Location = new System.Drawing.Point(13, 217);
            this.deleteALLButton.Name = "deleteALLButton";
            this.deleteALLButton.Size = new System.Drawing.Size(45, 45);
            this.deleteALLButton.TabIndex = 5;
            this.deleteALLButton.UseVisualStyleBackColor = true;
            this.deleteALLButton.Click += new System.EventHandler(this.deleteALLButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Image = global::SystAnalys_lr1.Properties.Resources.delete;
            this.deleteButton.Location = new System.Drawing.Point(13, 166);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(45, 45);
            this.deleteButton.TabIndex = 3;
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // drawEdgeButton
            // 
            this.drawEdgeButton.Image = global::SystAnalys_lr1.Properties.Resources.edge;
            this.drawEdgeButton.Location = new System.Drawing.Point(12, 115);
            this.drawEdgeButton.Name = "drawEdgeButton";
            this.drawEdgeButton.Size = new System.Drawing.Size(45, 45);
            this.drawEdgeButton.TabIndex = 2;
            this.drawEdgeButton.UseVisualStyleBackColor = true;
            this.drawEdgeButton.Click += new System.EventHandler(this.drawEdgeButton_Click);
            // 
            // drawVertexButton
            // 
            this.drawVertexButton.Image = global::SystAnalys_lr1.Properties.Resources.vertex;
            this.drawVertexButton.Location = new System.Drawing.Point(13, 64);
            this.drawVertexButton.Name = "drawVertexButton";
            this.drawVertexButton.Size = new System.Drawing.Size(45, 45);
            this.drawVertexButton.TabIndex = 1;
            this.drawVertexButton.UseVisualStyleBackColor = true;
            this.drawVertexButton.Click += new System.EventHandler(this.drawVertexButton_Click);
            // 
            // sheet
            // 
            this.sheet.BackColor = System.Drawing.SystemColors.Control;
            this.sheet.Location = new System.Drawing.Point(94, 12);
            this.sheet.Name = "sheet";
            this.sheet.Size = new System.Drawing.Size(1216, 823);
            this.sheet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sheet.TabIndex = 0;
            this.sheet.TabStop = false;
            this.sheet.MouseClick += new System.Windows.Forms.MouseEventHandler(this.sheet_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1608, 847);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBus1);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.cycleButton);
            this.Controls.Add(this.chainButton);
            this.Controls.Add(this.selectButton);
            this.Controls.Add(this.buttonInc);
            this.Controls.Add(this.buttonAdj);
            this.Controls.Add(this.listBoxMatrix);
            this.Controls.Add(this.deleteALLButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.drawEdgeButton);
            this.Controls.Add(this.drawVertexButton);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.sheet);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "SEX_WITH_DIPLOM VER 0.003 (WORK IN PROGRESS)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBus1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sheet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox sheet;
        private System.Windows.Forms.Button drawVertexButton;
        private System.Windows.Forms.Button drawEdgeButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button deleteALLButton;
        private System.Windows.Forms.ListBox listBoxMatrix;
        private System.Windows.Forms.Button buttonAdj;
        private System.Windows.Forms.Button buttonInc;
        private System.Windows.Forms.Button selectButton;
        private System.Windows.Forms.Button chainButton;
        private System.Windows.Forms.Button cycleButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem about;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBus1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

