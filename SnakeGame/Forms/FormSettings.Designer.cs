namespace SnakeGame
{
    partial class FormSettings
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageGame = new System.Windows.Forms.TabPage();
            this.tableLayoutPanelGame = new System.Windows.Forms.TableLayoutPanel();
            this.trackBarSpeed = new System.Windows.Forms.TrackBar();
            this.textBoxWidth = new System.Windows.Forms.TextBox();
            this.textBoxHeight = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPageGraphics = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonBorderColor = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBox = new System.Windows.Forms.CheckBox();
            this.buttonBackColor = new System.Windows.Forms.Button();
            this.buttonResource1 = new System.Windows.Forms.Button();
            this.buttonResource2 = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonAccept = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageGame.SuspendLayout();
            this.tableLayoutPanelGame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSpeed)).BeginInit();
            this.tabPageGraphics.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.tabControl1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageGame);
            this.tabControl1.Controls.Add(this.tabPageGraphics);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(794, 404);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPageGame
            // 
            this.tabPageGame.Controls.Add(this.tableLayoutPanelGame);
            this.tabPageGame.Location = new System.Drawing.Point(4, 24);
            this.tabPageGame.Name = "tabPageGame";
            this.tabPageGame.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGame.Size = new System.Drawing.Size(786, 376);
            this.tabPageGame.TabIndex = 0;
            this.tabPageGame.Text = "Игра";
            this.tabPageGame.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanelGame
            // 
            this.tableLayoutPanelGame.ColumnCount = 2;
            this.tableLayoutPanelGame.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelGame.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelGame.Controls.Add(this.trackBarSpeed, 0, 3);
            this.tableLayoutPanelGame.Controls.Add(this.textBoxWidth, 0, 1);
            this.tableLayoutPanelGame.Controls.Add(this.textBoxHeight, 1, 1);
            this.tableLayoutPanelGame.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanelGame.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanelGame.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanelGame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelGame.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelGame.Name = "tableLayoutPanelGame";
            this.tableLayoutPanelGame.RowCount = 4;
            this.tableLayoutPanelGame.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelGame.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelGame.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelGame.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelGame.Size = new System.Drawing.Size(780, 370);
            this.tableLayoutPanelGame.TabIndex = 1;
            // 
            // trackBarSpeed
            // 
            this.tableLayoutPanelGame.SetColumnSpan(this.trackBarSpeed, 2);
            this.trackBarSpeed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackBarSpeed.Location = new System.Drawing.Point(3, 279);
            this.trackBarSpeed.Name = "trackBarSpeed";
            this.trackBarSpeed.Size = new System.Drawing.Size(774, 88);
            this.trackBarSpeed.TabIndex = 6;
            // 
            // textBoxWidth
            // 
            this.textBoxWidth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxWidth.Location = new System.Drawing.Point(3, 95);
            this.textBoxWidth.Name = "textBoxWidth";
            this.textBoxWidth.Size = new System.Drawing.Size(384, 23);
            this.textBoxWidth.TabIndex = 1;
            this.textBoxWidth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // textBoxHeight
            // 
            this.textBoxHeight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxHeight.Location = new System.Drawing.Point(393, 95);
            this.textBoxHeight.Name = "textBoxHeight";
            this.textBoxHeight.Size = new System.Drawing.Size(384, 23);
            this.textBoxHeight.TabIndex = 2;
            this.textBoxHeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(384, 92);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ширина поля";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(393, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(384, 92);
            this.label2.TabIndex = 4;
            this.label2.Text = "Высота поля";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.tableLayoutPanelGame.SetColumnSpan(this.label3, 2);
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(774, 92);
            this.label3.TabIndex = 5;
            this.label3.Text = "Скорость змейки";
            // 
            // tabPageGraphics
            // 
            this.tabPageGraphics.Controls.Add(this.tableLayoutPanel3);
            this.tabPageGraphics.Location = new System.Drawing.Point(4, 24);
            this.tabPageGraphics.Name = "tabPageGraphics";
            this.tabPageGraphics.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGraphics.Size = new System.Drawing.Size(786, 376);
            this.tabPageGraphics.TabIndex = 1;
            this.tabPageGraphics.Text = "Графика";
            this.tabPageGraphics.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.buttonBorderColor, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.buttonResource1, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.buttonResource2, 1, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(780, 370);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // buttonBorderColor
            // 
            this.buttonBorderColor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonBorderColor.Location = new System.Drawing.Point(393, 3);
            this.buttonBorderColor.Name = "buttonBorderColor";
            this.buttonBorderColor.Size = new System.Drawing.Size(384, 179);
            this.buttonBorderColor.TabIndex = 0;
            this.buttonBorderColor.Text = "Выбрать цвет границ";
            this.buttonBorderColor.UseVisualStyleBackColor = true;
            this.buttonBorderColor.Click += new System.EventHandler(this.buttonBorderColor_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.checkBox);
            this.panel1.Controls.Add(this.buttonBackColor);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(384, 179);
            this.panel1.TabIndex = 1;
            // 
            // checkBox
            // 
            this.checkBox.AutoSize = true;
            this.checkBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.checkBox.Location = new System.Drawing.Point(0, 0);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(116, 179);
            this.checkBox.TabIndex = 1;
            this.checkBox.Text = "Рисовать клетки";
            this.checkBox.UseVisualStyleBackColor = true;
            this.checkBox.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // buttonBackColor
            // 
            this.buttonBackColor.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonBackColor.Location = new System.Drawing.Point(122, 0);
            this.buttonBackColor.Name = "buttonBackColor";
            this.buttonBackColor.Size = new System.Drawing.Size(262, 179);
            this.buttonBackColor.TabIndex = 0;
            this.buttonBackColor.Text = "Выбрать цвет клеток";
            this.buttonBackColor.UseVisualStyleBackColor = true;
            this.buttonBackColor.Click += new System.EventHandler(this.buttonBackColor_Click);
            // 
            // buttonResource1
            // 
            this.buttonResource1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonResource1.Location = new System.Drawing.Point(3, 188);
            this.buttonResource1.Name = "buttonResource1";
            this.buttonResource1.Size = new System.Drawing.Size(384, 179);
            this.buttonResource1.TabIndex = 2;
            this.buttonResource1.Text = "Змейка";
            this.buttonResource1.UseVisualStyleBackColor = true;
            this.buttonResource1.Click += new System.EventHandler(this.buttonResource1_Click);
            // 
            // buttonResource2
            // 
            this.buttonResource2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonResource2.Location = new System.Drawing.Point(393, 188);
            this.buttonResource2.Name = "buttonResource2";
            this.buttonResource2.Size = new System.Drawing.Size(384, 179);
            this.buttonResource2.TabIndex = 3;
            this.buttonResource2.Text = "Гирлянда";
            this.buttonResource2.UseVisualStyleBackColor = true;
            this.buttonResource2.Click += new System.EventHandler(this.buttonResource2_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.buttonAccept, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttonCancel, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 413);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(794, 34);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // buttonAccept
            // 
            this.buttonAccept.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonAccept.Location = new System.Drawing.Point(3, 3);
            this.buttonAccept.Name = "buttonAccept";
            this.buttonAccept.Size = new System.Drawing.Size(391, 28);
            this.buttonAccept.TabIndex = 0;
            this.buttonAccept.Text = "Применить";
            this.buttonAccept.UseVisualStyleBackColor = true;
            this.buttonAccept.Click += new System.EventHandler(this.buttonAccept_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonCancel.Location = new System.Drawing.Point(400, 3);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(391, 28);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Отменить";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // colorDialog1
            // 
            this.colorDialog1.FullOpen = true;
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FormSettings";
            this.Text = "FormSettings";
            this.Load += new System.EventHandler(this.FormSettings_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPageGame.ResumeLayout(false);
            this.tableLayoutPanelGame.ResumeLayout(false);
            this.tableLayoutPanelGame.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSpeed)).EndInit();
            this.tabPageGraphics.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TabControl tabControl1;
        private TabPage tabPageGame;
        private TableLayoutPanel tableLayoutPanelGame;
        private TabPage tabPageGraphics;
        private TrackBar trackBarSpeed;
        private TextBox textBoxWidth;
        private TextBox textBoxHeight;
        private Label label1;
        private Label label2;
        private Label label3;
        private TableLayoutPanel tableLayoutPanel2;
        private Button buttonAccept;
        private Button buttonCancel;
        private TableLayoutPanel tableLayoutPanel3;
        private Button buttonBorderColor;
        private Panel panel1;
        private CheckBox checkBox;
        private Button buttonBackColor;
        private Button buttonResource1;
        private Button buttonResource2;
        private ColorDialog colorDialog1;
    }
}