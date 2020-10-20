namespace RegisztracioAlkalmazas
{
    partial class Form1
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
            this.nevLB = new System.Windows.Forms.Label();
            this.ujhobbiTB = new System.Windows.Forms.TextBox();
            this.ujhobbiLB = new System.Windows.Forms.Label();
            this.kedvenchobbiLB = new System.Windows.Forms.Label();
            this.nemLB = new System.Windows.Forms.Label();
            this.szuldLB = new System.Windows.Forms.Label();
            this.fRB = new System.Windows.Forms.RadioButton();
            this.nRB = new System.Windows.Forms.RadioButton();
            this.nevTB = new System.Windows.Forms.TextBox();
            this.hozzaadBTN = new System.Windows.Forms.Button();
            this.mentesBTN = new System.Windows.Forms.Button();
            this.betoltesBTN = new System.Windows.Forms.Button();
            this.szulDTP = new System.Windows.Forms.DateTimePicker();
            this.hobbiLIST = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // nevLB
            // 
            this.nevLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nevLB.Location = new System.Drawing.Point(38, 74);
            this.nevLB.Name = "nevLB";
            this.nevLB.Size = new System.Drawing.Size(57, 30);
            this.nevLB.TabIndex = 1;
            this.nevLB.Text = "Név:";
            // 
            // ujhobbiTB
            // 
            this.ujhobbiTB.Location = new System.Drawing.Point(557, 188);
            this.ujhobbiTB.Name = "ujhobbiTB";
            this.ujhobbiTB.Size = new System.Drawing.Size(159, 20);
            this.ujhobbiTB.TabIndex = 3;
            // 
            // ujhobbiLB
            // 
            this.ujhobbiLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ujhobbiLB.Location = new System.Drawing.Point(452, 182);
            this.ujhobbiLB.Name = "ujhobbiLB";
            this.ujhobbiLB.Size = new System.Drawing.Size(99, 30);
            this.ujhobbiLB.TabIndex = 6;
            this.ujhobbiLB.Text = "Új hobbi:";
            // 
            // kedvenchobbiLB
            // 
            this.kedvenchobbiLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kedvenchobbiLB.Location = new System.Drawing.Point(552, 30);
            this.kedvenchobbiLB.Name = "kedvenchobbiLB";
            this.kedvenchobbiLB.Size = new System.Drawing.Size(164, 30);
            this.kedvenchobbiLB.TabIndex = 7;
            this.kedvenchobbiLB.Text = "Kedvenc hobbi:";
            // 
            // nemLB
            // 
            this.nemLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nemLB.Location = new System.Drawing.Point(38, 141);
            this.nemLB.Name = "nemLB";
            this.nemLB.Size = new System.Drawing.Size(67, 30);
            this.nemLB.TabIndex = 8;
            this.nemLB.Text = "Nem:";
            // 
            // szuldLB
            // 
            this.szuldLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.szuldLB.Location = new System.Drawing.Point(38, 104);
            this.szuldLB.Name = "szuldLB";
            this.szuldLB.Size = new System.Drawing.Size(129, 30);
            this.szuldLB.TabIndex = 9;
            this.szuldLB.Text = "Szül.dátum:";
            // 
            // fRB
            // 
            this.fRB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.fRB.Location = new System.Drawing.Point(173, 141);
            this.fRB.Name = "fRB";
            this.fRB.Size = new System.Drawing.Size(80, 39);
            this.fRB.TabIndex = 10;
            this.fRB.TabStop = true;
            this.fRB.Text = "F";
            this.fRB.UseVisualStyleBackColor = true;
            // 
            // nRB
            // 
            this.nRB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nRB.Location = new System.Drawing.Point(227, 141);
            this.nRB.Name = "nRB";
            this.nRB.Size = new System.Drawing.Size(80, 39);
            this.nRB.TabIndex = 11;
            this.nRB.TabStop = true;
            this.nRB.Text = "N";
            this.nRB.UseVisualStyleBackColor = true;
            // 
            // nevTB
            // 
            this.nevTB.Location = new System.Drawing.Point(173, 74);
            this.nevTB.Name = "nevTB";
            this.nevTB.Size = new System.Drawing.Size(159, 20);
            this.nevTB.TabIndex = 12;
            // 
            // hozzaadBTN
            // 
            this.hozzaadBTN.Location = new System.Drawing.Point(589, 216);
            this.hozzaadBTN.Name = "hozzaadBTN";
            this.hozzaadBTN.Size = new System.Drawing.Size(92, 34);
            this.hozzaadBTN.TabIndex = 0;
            this.hozzaadBTN.Text = "Hozzáad";
            this.hozzaadBTN.UseVisualStyleBackColor = true;
            this.hozzaadBTN.Click += new System.EventHandler(this.hozzaadBTN_Click);
            // 
            // mentesBTN
            // 
            this.mentesBTN.Location = new System.Drawing.Point(624, 387);
            this.mentesBTN.Name = "mentesBTN";
            this.mentesBTN.Size = new System.Drawing.Size(92, 34);
            this.mentesBTN.TabIndex = 14;
            this.mentesBTN.Text = "Mentés";
            this.mentesBTN.UseVisualStyleBackColor = true;
            this.mentesBTN.Click += new System.EventHandler(this.mentesBTN_Click);
            // 
            // betoltesBTN
            // 
            this.betoltesBTN.Location = new System.Drawing.Point(520, 387);
            this.betoltesBTN.Name = "betoltesBTN";
            this.betoltesBTN.Size = new System.Drawing.Size(92, 34);
            this.betoltesBTN.TabIndex = 15;
            this.betoltesBTN.Text = "Betöltés";
            this.betoltesBTN.UseVisualStyleBackColor = true;
            // 
            // szulDTP
            // 
            this.szulDTP.Location = new System.Drawing.Point(173, 107);
            this.szulDTP.Name = "szulDTP";
            this.szulDTP.Size = new System.Drawing.Size(200, 20);
            this.szulDTP.TabIndex = 16;
            // 
            // hobbiLIST
            // 
            this.hobbiLIST.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.hobbiLIST.FormattingEnabled = true;
            this.hobbiLIST.ItemHeight = 20;
            this.hobbiLIST.Location = new System.Drawing.Point(557, 68);
            this.hobbiLIST.Name = "hobbiLIST";
            this.hobbiLIST.Size = new System.Drawing.Size(159, 104);
            this.hobbiLIST.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.hobbiLIST);
            this.Controls.Add(this.szulDTP);
            this.Controls.Add(this.betoltesBTN);
            this.Controls.Add(this.mentesBTN);
            this.Controls.Add(this.nevTB);
            this.Controls.Add(this.nRB);
            this.Controls.Add(this.fRB);
            this.Controls.Add(this.szuldLB);
            this.Controls.Add(this.nemLB);
            this.Controls.Add(this.kedvenchobbiLB);
            this.Controls.Add(this.ujhobbiLB);
            this.Controls.Add(this.ujhobbiTB);
            this.Controls.Add(this.nevLB);
            this.Controls.Add(this.hozzaadBTN);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nevLB;
        private System.Windows.Forms.TextBox ujhobbiTB;
        private System.Windows.Forms.Label ujhobbiLB;
        private System.Windows.Forms.Label kedvenchobbiLB;
        private System.Windows.Forms.Label nemLB;
        private System.Windows.Forms.Label szuldLB;
        private System.Windows.Forms.RadioButton fRB;
        private System.Windows.Forms.RadioButton nRB;
        private System.Windows.Forms.TextBox nevTB;
        private System.Windows.Forms.Button hozzaadBTN;
        private System.Windows.Forms.Button mentesBTN;
        private System.Windows.Forms.Button betoltesBTN;
        private System.Windows.Forms.DateTimePicker szulDTP;
        private System.Windows.Forms.ListBox hobbiLIST;
    }
}

