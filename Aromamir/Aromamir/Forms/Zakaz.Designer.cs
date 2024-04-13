namespace Aromamir.Forms
{
    partial class Zakaz
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
            this.btCozdat = new System.Windows.Forms.Button();
            this.btOtmena = new System.Windows.Forms.Button();
            this.btNazad = new System.Windows.Forms.Button();
            this.gbZayavka = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbFio = new System.Windows.Forms.TextBox();
            this.lbFio = new System.Windows.Forms.Label();
            this.tbOpicanie = new System.Windows.Forms.TextBox();
            this.cbTip = new System.Windows.Forms.ComboBox();
            this.cbOborudovanie = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lb = new System.Windows.Forms.Label();
            this.lbOborudovanie = new System.Windows.Forms.Label();
            this.tbNomer = new System.Windows.Forms.TextBox();
            this.dtData = new System.Windows.Forms.DateTimePicker();
            this.lbData = new System.Windows.Forms.Label();
            this.lbNomer = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.gbZayavka.SuspendLayout();
            this.SuspendLayout();
            // 
            // btCozdat
            // 
            this.btCozdat.Location = new System.Drawing.Point(10, 345);
            this.btCozdat.Name = "btCozdat";
            this.btCozdat.Size = new System.Drawing.Size(117, 27);
            this.btCozdat.TabIndex = 15;
            this.btCozdat.Text = "Создать";
            this.btCozdat.UseVisualStyleBackColor = true;
            // 
            // btOtmena
            // 
            this.btOtmena.Location = new System.Drawing.Point(165, 345);
            this.btOtmena.Name = "btOtmena";
            this.btOtmena.Size = new System.Drawing.Size(117, 27);
            this.btOtmena.TabIndex = 16;
            this.btOtmena.Text = "Очитить";
            this.btOtmena.UseVisualStyleBackColor = true;
            this.btOtmena.Click += new System.EventHandler(this.btOtmena_Click);
            // 
            // btNazad
            // 
            this.btNazad.Location = new System.Drawing.Point(128, 448);
            this.btNazad.Name = "btNazad";
            this.btNazad.Size = new System.Drawing.Size(117, 27);
            this.btNazad.TabIndex = 18;
            this.btNazad.Text = "К товарам";
            this.btNazad.UseVisualStyleBackColor = true;
            this.btNazad.Click += new System.EventHandler(this.btNazad_Click);
            // 
            // gbZayavka
            // 
            this.gbZayavka.Controls.Add(this.btOtmena);
            this.gbZayavka.Controls.Add(this.btCozdat);
            this.gbZayavka.Controls.Add(this.comboBox1);
            this.gbZayavka.Controls.Add(this.label1);
            this.gbZayavka.Controls.Add(this.tbFio);
            this.gbZayavka.Controls.Add(this.lbFio);
            this.gbZayavka.Controls.Add(this.tbOpicanie);
            this.gbZayavka.Controls.Add(this.cbTip);
            this.gbZayavka.Controls.Add(this.cbOborudovanie);
            this.gbZayavka.Controls.Add(this.label2);
            this.gbZayavka.Controls.Add(this.lb);
            this.gbZayavka.Controls.Add(this.lbOborudovanie);
            this.gbZayavka.Controls.Add(this.tbNomer);
            this.gbZayavka.Controls.Add(this.dtData);
            this.gbZayavka.Controls.Add(this.lbData);
            this.gbZayavka.Controls.Add(this.lbNomer);
            this.gbZayavka.Location = new System.Drawing.Point(30, 38);
            this.gbZayavka.Name = "gbZayavka";
            this.gbZayavka.Size = new System.Drawing.Size(314, 383);
            this.gbZayavka.TabIndex = 17;
            this.gbZayavka.TabStop = false;
            this.gbZayavka.Text = "Добавление нового заказа";
            this.gbZayavka.Enter += new System.EventHandler(this.gbZayavka_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 296);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Статус";
            // 
            // tbFio
            // 
            this.tbFio.Location = new System.Drawing.Point(126, 85);
            this.tbFio.Name = "tbFio";
            this.tbFio.Size = new System.Drawing.Size(166, 20);
            this.tbFio.TabIndex = 11;
            // 
            // lbFio
            // 
            this.lbFio.AutoSize = true;
            this.lbFio.Location = new System.Drawing.Point(7, 88);
            this.lbFio.Name = "lbFio";
            this.lbFio.Size = new System.Drawing.Size(78, 13);
            this.lbFio.TabIndex = 10;
            this.lbFio.Text = "ФИО клиента";
            // 
            // tbOpicanie
            // 
            this.tbOpicanie.Location = new System.Drawing.Point(125, 251);
            this.tbOpicanie.Multiline = true;
            this.tbOpicanie.Name = "tbOpicanie";
            this.tbOpicanie.Size = new System.Drawing.Size(166, 20);
            this.tbOpicanie.TabIndex = 9;
            // 
            // cbTip
            // 
            this.cbTip.FormattingEnabled = true;
            this.cbTip.Items.AddRange(new object[] {
            "ПВЗ",
            "Курьером"});
            this.cbTip.Location = new System.Drawing.Point(125, 204);
            this.cbTip.Name = "cbTip";
            this.cbTip.Size = new System.Drawing.Size(166, 21);
            this.cbTip.TabIndex = 8;
            // 
            // cbOborudovanie
            // 
            this.cbOborudovanie.FormattingEnabled = true;
            this.cbOborudovanie.Items.AddRange(new object[] {
            "обычная ",
            "экспресс"});
            this.cbOborudovanie.Location = new System.Drawing.Point(125, 163);
            this.cbOborudovanie.Name = "cbOborudovanie";
            this.cbOborudovanie.Size = new System.Drawing.Size(166, 21);
            this.cbOborudovanie.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 254);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Адресс";
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Location = new System.Drawing.Point(6, 212);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(76, 13);
            this.lb.TabIndex = 5;
            this.lb.Text = "Тип доставки";
            // 
            // lbOborudovanie
            // 
            this.lbOborudovanie.AutoSize = true;
            this.lbOborudovanie.Location = new System.Drawing.Point(6, 163);
            this.lbOborudovanie.Name = "lbOborudovanie";
            this.lbOborudovanie.Size = new System.Drawing.Size(65, 13);
            this.lbOborudovanie.TabIndex = 4;
            this.lbOborudovanie.Text = "Тип заказа";
            // 
            // tbNomer
            // 
            this.tbNomer.Location = new System.Drawing.Point(125, 53);
            this.tbNomer.Name = "tbNomer";
            this.tbNomer.Size = new System.Drawing.Size(166, 20);
            this.tbNomer.TabIndex = 3;
            // 
            // dtData
            // 
            this.dtData.Location = new System.Drawing.Point(125, 123);
            this.dtData.Name = "dtData";
            this.dtData.Size = new System.Drawing.Size(166, 20);
            this.dtData.TabIndex = 2;
            // 
            // lbData
            // 
            this.lbData.AutoSize = true;
            this.lbData.Location = new System.Drawing.Point(6, 123);
            this.lbData.Name = "lbData";
            this.lbData.Size = new System.Drawing.Size(36, 13);
            this.lbData.TabIndex = 1;
            this.lbData.Text = "Дата ";
            // 
            // lbNomer
            // 
            this.lbNomer.AutoSize = true;
            this.lbNomer.Location = new System.Drawing.Point(6, 53);
            this.lbNomer.Name = "lbNomer";
            this.lbNomer.Size = new System.Drawing.Size(80, 13);
            this.lbNomer.TabIndex = 0;
            this.lbNomer.Text = "Номер заказа";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "заказа",
            "собрано складом",
            "в пути ",
            "поставлено ",
            "получено "});
            this.comboBox1.Location = new System.Drawing.Point(125, 288);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(166, 21);
            this.comboBox1.TabIndex = 13;
            // 
            // Zakaz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 507);
            this.Controls.Add(this.btNazad);
            this.Controls.Add(this.gbZayavka);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Zakaz";
            this.Text = "Zakaz";
            this.gbZayavka.ResumeLayout(false);
            this.gbZayavka.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btCozdat;
        private System.Windows.Forms.Button btOtmena;
        private System.Windows.Forms.Button btNazad;
        private System.Windows.Forms.GroupBox gbZayavka;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbFio;
        private System.Windows.Forms.Label lbFio;
        private System.Windows.Forms.TextBox tbOpicanie;
        private System.Windows.Forms.ComboBox cbTip;
        private System.Windows.Forms.ComboBox cbOborudovanie;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.Label lbOborudovanie;
        private System.Windows.Forms.TextBox tbNomer;
        private System.Windows.Forms.DateTimePicker dtData;
        private System.Windows.Forms.Label lbData;
        private System.Windows.Forms.Label lbNomer;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}