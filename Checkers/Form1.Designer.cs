using System.Windows.Forms;

namespace Checkers
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
            this.lblPlayer = new System.Windows.Forms.Label();
            this.dgvMap = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.fromX = new System.Windows.Forms.TextBox();
            this.fromY = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ToX = new System.Windows.Forms.TextBox();
            this.ToY = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.WhiteScore = new System.Windows.Forms.Label();
            this.BlackScore = new System.Windows.Forms.Label();
            this.btnNewGame = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMap)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPlayer
            // 
            this.lblPlayer.AutoSize = true;
            this.lblPlayer.Location = new System.Drawing.Point(89, 202);
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.Size = new System.Drawing.Size(60, 13);
            this.lblPlayer.TabIndex = 0;
            this.lblPlayer.Text = "Ход белых";
            // 
            // dgvMap
            // 
            this.dgvMap.AllowUserToAddRows = false;
            this.dgvMap.AllowUserToDeleteRows = false;
            this.dgvMap.AllowUserToResizeColumns = false;
            this.dgvMap.AllowUserToResizeRows = false;
            this.dgvMap.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvMap.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMap.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgvMap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMap.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvMap.Location = new System.Drawing.Point(12, 12);
            this.dgvMap.MultiSelect = false;
            this.dgvMap.Name = "dgvMap";
            this.dgvMap.ReadOnly = true;
            this.dgvMap.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvMap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvMap.ShowEditingIcon = false;
            this.dgvMap.Size = new System.Drawing.Size(215, 187);
            this.dgvMap.StandardTab = true;
            this.dgvMap.TabIndex = 1;
            this.dgvMap.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMap_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Откуда";
            // 
            // fromX
            // 
            this.fromX.Location = new System.Drawing.Point(89, 242);
            this.fromX.Name = "fromX";
            this.fromX.Size = new System.Drawing.Size(51, 20);
            this.fromX.TabIndex = 3;
            // 
            // fromY
            // 
            this.fromY.Location = new System.Drawing.Point(153, 242);
            this.fromY.Name = "fromY";
            this.fromY.Size = new System.Drawing.Size(51, 20);
            this.fromY.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 280);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Куда";
            // 
            // ToX
            // 
            this.ToX.Location = new System.Drawing.Point(89, 277);
            this.ToX.Name = "ToX";
            this.ToX.Size = new System.Drawing.Size(51, 20);
            this.ToX.TabIndex = 3;
            // 
            // ToY
            // 
            this.ToY.Location = new System.Drawing.Point(153, 277);
            this.ToY.Name = "ToY";
            this.ToY.Size = new System.Drawing.Size(51, 20);
            this.ToY.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(92, 319);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Сходить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 349);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Счет белых:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(129, 349);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Счет черных: ";
            // 
            // WhiteScore
            // 
            this.WhiteScore.AutoSize = true;
            this.WhiteScore.Location = new System.Drawing.Point(85, 349);
            this.WhiteScore.Name = "WhiteScore";
            this.WhiteScore.Size = new System.Drawing.Size(13, 13);
            this.WhiteScore.TabIndex = 5;
            this.WhiteScore.Text = "0";
            // 
            // BlackScore
            // 
            this.BlackScore.AutoSize = true;
            this.BlackScore.Location = new System.Drawing.Point(210, 349);
            this.BlackScore.Name = "BlackScore";
            this.BlackScore.Size = new System.Drawing.Size(13, 13);
            this.BlackScore.TabIndex = 6;
            this.BlackScore.Text = "0";
            // 
            // btnNewGame
            // 
            this.btnNewGame.Location = new System.Drawing.Point(88, 393);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(75, 23);
            this.btnNewGame.TabIndex = 7;
            this.btnNewGame.Text = "Новая игра";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 422);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.BlackScore);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.WhiteScore);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ToY);
            this.Controls.Add(this.fromY);
            this.Controls.Add(this.ToX);
            this.Controls.Add(this.fromX);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvMap);
            this.Controls.Add(this.lblPlayer);
            this.Name = "Form1";
            this.Text = "Шашки";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPlayer;
        private System.Windows.Forms.DataGridView dgvMap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fromX;
        private System.Windows.Forms.TextBox fromY;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ToX;
        private System.Windows.Forms.TextBox ToY;
        private System.Windows.Forms.Button button1;
        private Label label5;
        private Label label4;
        private Label WhiteScore;
        private Label BlackScore;
        private Button btnNewGame;
    }
}

