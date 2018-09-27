namespace markmerakendus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.addnote_btn = new System.Windows.Forms.Button();
            this.notelist = new System.Windows.Forms.ListBox();
            this.tekstiaken = new System.Windows.Forms.TextBox();
            this.lisa_btn = new System.Windows.Forms.Button();
            this.tekstipealkiri = new System.Windows.Forms.TextBox();
            this.labelpealkiri = new System.Windows.Forms.Label();
            this.labeltekst = new System.Windows.Forms.Label();
            this.ava_btn = new System.Windows.Forms.Button();
            this.kustuta_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addnote_btn
            // 
            this.addnote_btn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.addnote_btn.Location = new System.Drawing.Point(354, 118);
            this.addnote_btn.Name = "addnote_btn";
            this.addnote_btn.Size = new System.Drawing.Size(116, 27);
            this.addnote_btn.TabIndex = 0;
            this.addnote_btn.Text = "LISA UUS";
            this.addnote_btn.UseVisualStyleBackColor = false;
            this.addnote_btn.Click += new System.EventHandler(this.addnote_btn_Click);
            // 
            // notelist
            // 
            this.notelist.FormattingEnabled = true;
            this.notelist.Location = new System.Drawing.Point(354, 273);
            this.notelist.Name = "notelist";
            this.notelist.Size = new System.Drawing.Size(407, 121);
            this.notelist.TabIndex = 1;
            // 
            // tekstiaken
            // 
            this.tekstiaken.Location = new System.Drawing.Point(26, 208);
            this.tekstiaken.Multiline = true;
            this.tekstiaken.Name = "tekstiaken";
            this.tekstiaken.Size = new System.Drawing.Size(274, 186);
            this.tekstiaken.TabIndex = 2;
            this.tekstiaken.Visible = false;
            // 
            // lisa_btn
            // 
            this.lisa_btn.Location = new System.Drawing.Point(26, 401);
            this.lisa_btn.Name = "lisa_btn";
            this.lisa_btn.Size = new System.Drawing.Size(75, 23);
            this.lisa_btn.TabIndex = 3;
            this.lisa_btn.Text = "VALMIS";
            this.lisa_btn.UseVisualStyleBackColor = true;
            this.lisa_btn.Visible = false;
            this.lisa_btn.Click += new System.EventHandler(this.lisa_btn_Click);
            // 
            // tekstipealkiri
            // 
            this.tekstipealkiri.Location = new System.Drawing.Point(26, 146);
            this.tekstipealkiri.Name = "tekstipealkiri";
            this.tekstipealkiri.Size = new System.Drawing.Size(274, 20);
            this.tekstipealkiri.TabIndex = 4;
            this.tekstipealkiri.Visible = false;
            // 
            // labelpealkiri
            // 
            this.labelpealkiri.AutoSize = true;
            this.labelpealkiri.Location = new System.Drawing.Point(23, 118);
            this.labelpealkiri.Name = "labelpealkiri";
            this.labelpealkiri.Size = new System.Drawing.Size(55, 13);
            this.labelpealkiri.TabIndex = 5;
            this.labelpealkiri.Text = "PEALKIRI";
            this.labelpealkiri.Visible = false;
            // 
            // labeltekst
            // 
            this.labeltekst.AutoSize = true;
            this.labeltekst.Location = new System.Drawing.Point(23, 178);
            this.labeltekst.Name = "labeltekst";
            this.labeltekst.Size = new System.Drawing.Size(73, 13);
            this.labeltekst.TabIndex = 6;
            this.labeltekst.Text = "TEKSTI SISU";
            this.labeltekst.Visible = false;
            // 
            // ava_btn
            // 
            this.ava_btn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ava_btn.Location = new System.Drawing.Point(499, 118);
            this.ava_btn.Name = "ava_btn";
            this.ava_btn.Size = new System.Drawing.Size(116, 27);
            this.ava_btn.TabIndex = 7;
            this.ava_btn.Text = "AVA";
            this.ava_btn.UseVisualStyleBackColor = false;
            this.ava_btn.Click += new System.EventHandler(this.ava_btn_Click);
            // 
            // kustuta_btn
            // 
            this.kustuta_btn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.kustuta_btn.Location = new System.Drawing.Point(645, 118);
            this.kustuta_btn.Name = "kustuta_btn";
            this.kustuta_btn.Size = new System.Drawing.Size(116, 27);
            this.kustuta_btn.TabIndex = 9;
            this.kustuta_btn.Text = "KUSTUTA";
            this.kustuta_btn.UseVisualStyleBackColor = false;
            this.kustuta_btn.Click += new System.EventHandler(this.kustuta_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Copperplate Gothic Light", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(56, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 52);
            this.label1.TabIndex = 10;
            this.label1.Text = "NOTES";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kustuta_btn);
            this.Controls.Add(this.ava_btn);
            this.Controls.Add(this.labeltekst);
            this.Controls.Add(this.labelpealkiri);
            this.Controls.Add(this.tekstipealkiri);
            this.Controls.Add(this.lisa_btn);
            this.Controls.Add(this.tekstiaken);
            this.Controls.Add(this.notelist);
            this.Controls.Add(this.addnote_btn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addnote_btn;
        private System.Windows.Forms.ListBox notelist;
        private System.Windows.Forms.TextBox tekstiaken;
        private System.Windows.Forms.Button lisa_btn;
        private System.Windows.Forms.TextBox tekstipealkiri;
        private System.Windows.Forms.Label labelpealkiri;
        private System.Windows.Forms.Label labeltekst;
        private System.Windows.Forms.Button ava_btn;
        private System.Windows.Forms.Button kustuta_btn;
        private System.Windows.Forms.Label label1;
    }
}

