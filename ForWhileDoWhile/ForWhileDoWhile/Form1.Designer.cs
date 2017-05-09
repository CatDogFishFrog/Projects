namespace ForWhileDoWhile
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.TextBoxWhenX = new MetroFramework.Controls.MetroTextBox();
            this.ButtonFor = new MetroFramework.Controls.MetroButton();
            this.ButtonWhile = new MetroFramework.Controls.MetroButton();
            this.ButtonDoWhile = new MetroFramework.Controls.MetroButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.forfor = new MetroFramework.Controls.MetroTextBox();
            this.forwhile = new MetroFramework.Controls.MetroTextBox();
            this.fordowhile = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(13, 60);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(149, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Введите значение X =";
            // 
            // TextBoxWhenX
            // 
            this.TextBoxWhenX.Location = new System.Drawing.Point(174, 60);
            this.TextBoxWhenX.Name = "TextBoxWhenX";
            this.TextBoxWhenX.Size = new System.Drawing.Size(136, 23);
            this.TextBoxWhenX.TabIndex = 1;
            this.TextBoxWhenX.Text = "27,39";
            // 
            // ButtonFor
            // 
            this.ButtonFor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonFor.Location = new System.Drawing.Point(23, 101);
            this.ButtonFor.Name = "ButtonFor";
            this.ButtonFor.Size = new System.Drawing.Size(110, 25);
            this.ButtonFor.TabIndex = 2;
            this.ButtonFor.Text = "for";
            this.ButtonFor.UseMnemonic = false;
            this.ButtonFor.Click += new System.EventHandler(this.ButtonFor_Click);
            // 
            // ButtonWhile
            // 
            this.ButtonWhile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonWhile.Location = new System.Drawing.Point(23, 141);
            this.ButtonWhile.Name = "ButtonWhile";
            this.ButtonWhile.Size = new System.Drawing.Size(110, 25);
            this.ButtonWhile.TabIndex = 3;
            this.ButtonWhile.Text = "while";
            this.ButtonWhile.UseMnemonic = false;
            this.ButtonWhile.Click += new System.EventHandler(this.ButtonWhile_Click);
            // 
            // ButtonDoWhile
            // 
            this.ButtonDoWhile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonDoWhile.Location = new System.Drawing.Point(23, 181);
            this.ButtonDoWhile.Name = "ButtonDoWhile";
            this.ButtonDoWhile.Size = new System.Drawing.Size(110, 25);
            this.ButtonDoWhile.TabIndex = 4;
            this.ButtonDoWhile.Text = "do-while";
            this.ButtonDoWhile.UseMnemonic = false;
            this.ButtonDoWhile.Click += new System.EventHandler(this.ButtonDoWhile_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(144, 101);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(18, 19);
            this.metroLabel2.TabIndex = 5;
            this.metroLabel2.Text = "=";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(144, 141);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(18, 19);
            this.metroLabel3.TabIndex = 6;
            this.metroLabel3.Text = "=";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(144, 181);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(18, 19);
            this.metroLabel4.TabIndex = 7;
            this.metroLabel4.Text = "=";
            // 
            // forfor
            // 
            this.forfor.Location = new System.Drawing.Point(174, 101);
            this.forfor.Name = "forfor";
            this.forfor.ReadOnly = true;
            this.forfor.Size = new System.Drawing.Size(136, 23);
            this.forfor.TabIndex = 8;
            // 
            // forwhile
            // 
            this.forwhile.Location = new System.Drawing.Point(174, 141);
            this.forwhile.Name = "forwhile";
            this.forwhile.ReadOnly = true;
            this.forwhile.Size = new System.Drawing.Size(136, 23);
            this.forwhile.TabIndex = 9;
            // 
            // fordowhile
            // 
            this.fordowhile.Location = new System.Drawing.Point(174, 181);
            this.fordowhile.Name = "fordowhile";
            this.fordowhile.ReadOnly = true;
            this.fordowhile.Size = new System.Drawing.Size(136, 23);
            this.fordowhile.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 230);
            this.Controls.Add(this.fordowhile);
            this.Controls.Add(this.forwhile);
            this.Controls.Add(this.forfor);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.ButtonDoWhile);
            this.Controls.Add(this.ButtonWhile);
            this.Controls.Add(this.ButtonFor);
            this.Controls.Add(this.TextBoxWhenX);
            this.Controls.Add(this.metroLabel1);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Name = "Form1";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroForm.MetroFormShadowType.Flat;
            this.Text = "Цыклы (for, while, do while)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox TextBoxWhenX;
        private MetroFramework.Controls.MetroButton ButtonFor;
        private MetroFramework.Controls.MetroButton ButtonWhile;
        private MetroFramework.Controls.MetroButton ButtonDoWhile;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox forfor;
        private MetroFramework.Controls.MetroTextBox forwhile;
        private MetroFramework.Controls.MetroTextBox fordowhile;
    }
}

