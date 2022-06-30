namespace SnakeGame
{
    partial class FormNewRecord
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
            this.scoreList = new SnakeGame.ScoreList();
            this.label = new System.Windows.Forms.Label();
            this.textBoxEnterName = new System.Windows.Forms.TextBox();
            this.buttonClose = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.scoreList, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBoxEnterName, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.buttonClose, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(608, 448);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // scoreList
            // 
            this.scoreList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scoreList.FormattingEnabled = true;
            this.scoreList.ItemHeight = 15;
            this.scoreList.Location = new System.Drawing.Point(3, 3);
            this.scoreList.Name = "scoreList";
            this.scoreList.Size = new System.Drawing.Size(602, 337);
            this.scoreList.TabIndex = 0;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label.Location = new System.Drawing.Point(3, 343);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(602, 40);
            this.label.TabIndex = 1;
            this.label.Text = "label";
            // 
            // textBoxEnterName
            // 
            this.textBoxEnterName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxEnterName.Location = new System.Drawing.Point(3, 386);
            this.textBoxEnterName.Name = "textBoxEnterName";
            this.textBoxEnterName.Size = new System.Drawing.Size(602, 23);
            this.textBoxEnterName.TabIndex = 2;
            this.textBoxEnterName.TextChanged += new System.EventHandler(this.textBoxEnterName_TextChanged);
            // 
            // buttonClose
            // 
            this.buttonClose.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonClose.Location = new System.Drawing.Point(3, 411);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(602, 34);
            this.buttonClose.TabIndex = 3;
            this.buttonClose.Text = "Сохранить рекорд";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // FormNewRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 448);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FormNewRecord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Новый рекорд";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private ScoreList scoreList;
        private Label label;
        private TextBox textBoxEnterName;
        private Button buttonClose;
    }
}