namespace prjVocabJSON
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
            this.lblKey = new System.Windows.Forms.Label();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.lblValue = new System.Windows.Forms.Label();
            this.lblTitel = new System.Windows.Forms.Label();
            this.lblObjectQuantity = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.sfdVocabulary = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // lblKey
            // 
            this.lblKey.AutoSize = true;
            this.lblKey.Location = new System.Drawing.Point(12, 93);
            this.lblKey.Name = "lblKey";
            this.lblKey.Size = new System.Drawing.Size(33, 13);
            this.lblKey.TabIndex = 0;
            this.lblKey.Text = "Word";
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(12, 109);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(103, 20);
            this.txtKey.TabIndex = 1;
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(195, 109);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(100, 20);
            this.txtValue.TabIndex = 2;
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.Location = new System.Drawing.Point(195, 90);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(48, 13);
            this.lblValue.TabIndex = 3;
            this.lblValue.Text = "Meaning";
            // 
            // lblTitel
            // 
            this.lblTitel.AutoSize = true;
            this.lblTitel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitel.Location = new System.Drawing.Point(39, 9);
            this.lblTitel.Name = "lblTitel";
            this.lblTitel.Size = new System.Drawing.Size(189, 24);
            this.lblTitel.TabIndex = 4;
            this.lblTitel.Text = "Vocabulary Creator";
            // 
            // lblObjectQuantity
            // 
            this.lblObjectQuantity.AutoSize = true;
            this.lblObjectQuantity.Location = new System.Drawing.Point(12, 179);
            this.lblObjectQuantity.Name = "lblObjectQuantity";
            this.lblObjectQuantity.Size = new System.Drawing.Size(180, 13);
            this.lblObjectQuantity.TabIndex = 5;
            this.lblObjectQuantity.Text = "Quantity of cards in your Vocabulary:";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(13, 252);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(282, 32);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save as";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(117, 139);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add card";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // sfdVocabulary
            // 
            this.sfdVocabulary.DefaultExt = "json";
            this.sfdVocabulary.Filter = "JSON Files|*.json";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 307);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblObjectQuantity);
            this.Controls.Add(this.lblTitel);
            this.Controls.Add(this.lblValue);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.lblKey);
            this.Name = "Form1";
            this.Text = "Vocabulary Creator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKey;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.Label lblTitel;
        private System.Windows.Forms.Label lblObjectQuantity;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.SaveFileDialog sfdVocabulary;
    }
}

