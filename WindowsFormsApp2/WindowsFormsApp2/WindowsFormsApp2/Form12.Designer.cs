namespace WindowsFormsApp2
{
    partial class Form12
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.选择题库ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.选择题查看ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.选择题增加ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.选择题修改ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.选择题删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.判断题库ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.判断题查看ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.判断题增加ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.判断题修改ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.判断题删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.填空题库ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.填空题查看ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.填空题修改ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.填空题增加ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.填空题删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.学生得分ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(554, 339);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(75, 21);
            this.textBox1.TabIndex = 70;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(510, 342);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 12);
            this.label1.TabIndex = 69;
            this.label1.Text = "num";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(693, 337);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 68;
            this.button2.Text = "删除";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(756, 282);
            this.dataGridView1.TabIndex = 67;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.选择题库ToolStripMenuItem,
            this.判断题库ToolStripMenuItem,
            this.填空题库ToolStripMenuItem,
            this.学生得分ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 25);
            this.menuStrip1.TabIndex = 66;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // 选择题库ToolStripMenuItem
            // 
            this.选择题库ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.选择题查看ToolStripMenuItem,
            this.选择题增加ToolStripMenuItem,
            this.选择题修改ToolStripMenuItem,
            this.选择题删除ToolStripMenuItem});
            this.选择题库ToolStripMenuItem.Name = "选择题库ToolStripMenuItem";
            this.选择题库ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.选择题库ToolStripMenuItem.Text = "选择题库";
            this.选择题库ToolStripMenuItem.Click += new System.EventHandler(this.选择题库ToolStripMenuItem_Click);
            // 
            // 选择题查看ToolStripMenuItem
            // 
            this.选择题查看ToolStripMenuItem.Name = "选择题查看ToolStripMenuItem";
            this.选择题查看ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.选择题查看ToolStripMenuItem.Text = "选择题查看";
            this.选择题查看ToolStripMenuItem.Click += new System.EventHandler(this.选择题查看ToolStripMenuItem_Click);
            // 
            // 选择题增加ToolStripMenuItem
            // 
            this.选择题增加ToolStripMenuItem.Name = "选择题增加ToolStripMenuItem";
            this.选择题增加ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.选择题增加ToolStripMenuItem.Text = "选择题增加";
            this.选择题增加ToolStripMenuItem.Click += new System.EventHandler(this.选择题增加ToolStripMenuItem_Click);
            // 
            // 选择题修改ToolStripMenuItem
            // 
            this.选择题修改ToolStripMenuItem.Name = "选择题修改ToolStripMenuItem";
            this.选择题修改ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.选择题修改ToolStripMenuItem.Text = "选择题修改";
            this.选择题修改ToolStripMenuItem.Click += new System.EventHandler(this.选择题修改ToolStripMenuItem_Click);
            // 
            // 选择题删除ToolStripMenuItem
            // 
            this.选择题删除ToolStripMenuItem.Name = "选择题删除ToolStripMenuItem";
            this.选择题删除ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.选择题删除ToolStripMenuItem.Text = "选择题删除";
            this.选择题删除ToolStripMenuItem.Click += new System.EventHandler(this.选择题删除ToolStripMenuItem_Click);
            // 
            // 判断题库ToolStripMenuItem
            // 
            this.判断题库ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.判断题查看ToolStripMenuItem,
            this.判断题增加ToolStripMenuItem,
            this.判断题修改ToolStripMenuItem,
            this.判断题删除ToolStripMenuItem});
            this.判断题库ToolStripMenuItem.Name = "判断题库ToolStripMenuItem";
            this.判断题库ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.判断题库ToolStripMenuItem.Text = "判断题库";
            // 
            // 判断题查看ToolStripMenuItem
            // 
            this.判断题查看ToolStripMenuItem.Name = "判断题查看ToolStripMenuItem";
            this.判断题查看ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.判断题查看ToolStripMenuItem.Text = "判断题查看";
            this.判断题查看ToolStripMenuItem.Click += new System.EventHandler(this.判断题查看ToolStripMenuItem_Click);
            // 
            // 判断题增加ToolStripMenuItem
            // 
            this.判断题增加ToolStripMenuItem.Name = "判断题增加ToolStripMenuItem";
            this.判断题增加ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.判断题增加ToolStripMenuItem.Text = "判断题增加";
            this.判断题增加ToolStripMenuItem.Click += new System.EventHandler(this.判断题增加ToolStripMenuItem_Click);
            // 
            // 判断题修改ToolStripMenuItem
            // 
            this.判断题修改ToolStripMenuItem.Name = "判断题修改ToolStripMenuItem";
            this.判断题修改ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.判断题修改ToolStripMenuItem.Text = "判断题修改";
            this.判断题修改ToolStripMenuItem.Click += new System.EventHandler(this.判断题修改ToolStripMenuItem_Click);
            // 
            // 判断题删除ToolStripMenuItem
            // 
            this.判断题删除ToolStripMenuItem.Name = "判断题删除ToolStripMenuItem";
            this.判断题删除ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.判断题删除ToolStripMenuItem.Text = "判断题删除";
            this.判断题删除ToolStripMenuItem.Click += new System.EventHandler(this.判断题删除ToolStripMenuItem_Click);
            // 
            // 填空题库ToolStripMenuItem
            // 
            this.填空题库ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.填空题查看ToolStripMenuItem,
            this.填空题修改ToolStripMenuItem,
            this.填空题增加ToolStripMenuItem,
            this.填空题删除ToolStripMenuItem});
            this.填空题库ToolStripMenuItem.Name = "填空题库ToolStripMenuItem";
            this.填空题库ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.填空题库ToolStripMenuItem.Text = "填空题库";
            // 
            // 填空题查看ToolStripMenuItem
            // 
            this.填空题查看ToolStripMenuItem.Name = "填空题查看ToolStripMenuItem";
            this.填空题查看ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.填空题查看ToolStripMenuItem.Text = "填空题查看";
            this.填空题查看ToolStripMenuItem.Click += new System.EventHandler(this.填空题查看ToolStripMenuItem_Click);
            // 
            // 填空题修改ToolStripMenuItem
            // 
            this.填空题修改ToolStripMenuItem.Name = "填空题修改ToolStripMenuItem";
            this.填空题修改ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.填空题修改ToolStripMenuItem.Text = "填空题修改";
            this.填空题修改ToolStripMenuItem.Click += new System.EventHandler(this.填空题修改ToolStripMenuItem_Click);
            // 
            // 填空题增加ToolStripMenuItem
            // 
            this.填空题增加ToolStripMenuItem.Name = "填空题增加ToolStripMenuItem";
            this.填空题增加ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.填空题增加ToolStripMenuItem.Text = "填空题增加";
            this.填空题增加ToolStripMenuItem.Click += new System.EventHandler(this.填空题增加ToolStripMenuItem_Click);
            // 
            // 填空题删除ToolStripMenuItem
            // 
            this.填空题删除ToolStripMenuItem.Name = "填空题删除ToolStripMenuItem";
            this.填空题删除ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.填空题删除ToolStripMenuItem.Text = "填空题删除";
            this.填空题删除ToolStripMenuItem.Click += new System.EventHandler(this.填空题删除ToolStripMenuItem_Click);
            // 
            // 学生得分ToolStripMenuItem
            // 
            this.学生得分ToolStripMenuItem.Name = "学生得分ToolStripMenuItem";
            this.学生得分ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.学生得分ToolStripMenuItem.Text = "学生得分";
            this.学生得分ToolStripMenuItem.Click += new System.EventHandler(this.学生得分ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.退出ToolStripMenuItem.Text = "返回";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // Form12
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form12";
            this.Text = "判断题删除";
            this.Load += new System.EventHandler(this.Form12_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 选择题库ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 选择题查看ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 选择题增加ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 选择题修改ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 选择题删除ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 判断题库ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 判断题查看ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 判断题增加ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 判断题修改ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 判断题删除ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 填空题库ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 填空题查看ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 填空题修改ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 填空题增加ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 填空题删除ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 学生得分ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
    }
}