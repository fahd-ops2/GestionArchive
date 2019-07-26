namespace GestionArchive
{
    partial class FrmAnneeScolaire
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
            this.dtgv = new System.Windows.Forms.DataGridView();
            this.add = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.show = new System.Windows.Forms.Button();
            this.cbc = new System.Windows.Forms.ComboBox();
            this.cba = new System.Windows.Forms.ComboBox();
            this.cbe = new System.Windows.Forms.ComboBox();
            this.classe = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgv
            // 
            this.dtgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv.Location = new System.Drawing.Point(-2, 122);
            this.dtgv.Name = "dtgv";
            this.dtgv.Size = new System.Drawing.Size(720, 227);
            this.dtgv.TabIndex = 0;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(64, 367);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(113, 34);
            this.add.TabIndex = 1;
            this.add.Text = "ADD";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(223, 367);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(108, 34);
            this.update.TabIndex = 2;
            this.update.Text = "UPDATE";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(389, 367);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(106, 34);
            this.delete.TabIndex = 3;
            this.delete.Text = "DELETE";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // show
            // 
            this.show.Location = new System.Drawing.Point(559, 367);
            this.show.Name = "show";
            this.show.Size = new System.Drawing.Size(111, 34);
            this.show.TabIndex = 4;
            this.show.Text = "SHOW";
            this.show.UseVisualStyleBackColor = true;
            this.show.Click += new System.EventHandler(this.show_Click);
            // 
            // cbc
            // 
            this.cbc.FormattingEnabled = true;
            this.cbc.Location = new System.Drawing.Point(64, 79);
            this.cbc.Name = "cbc";
            this.cbc.Size = new System.Drawing.Size(148, 21);
            this.cbc.TabIndex = 5;
            // 
            // cba
            // 
            this.cba.FormattingEnabled = true;
            this.cba.Location = new System.Drawing.Point(271, 79);
            this.cba.Name = "cba";
            this.cba.Size = new System.Drawing.Size(157, 21);
            this.cba.TabIndex = 6;
            // 
            // cbe
            // 
            this.cbe.FormattingEnabled = true;
            this.cbe.Location = new System.Drawing.Point(479, 79);
            this.cbe.Name = "cbe";
            this.cbe.Size = new System.Drawing.Size(156, 21);
            this.cbe.TabIndex = 7;
            // 
            // classe
            // 
            this.classe.AutoSize = true;
            this.classe.Location = new System.Drawing.Point(134, 48);
            this.classe.Name = "classe";
            this.classe.Size = new System.Drawing.Size(37, 13);
            this.classe.TabIndex = 8;
            this.classe.Text = "classe";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(324, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "annee";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(524, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "etudiant";
            // 
            // FrmAnneeScolaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 413);
            this.Controls.Add(this.cbc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.classe);
            this.Controls.Add(this.cbe);
            this.Controls.Add(this.cba);
            this.Controls.Add(this.show);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.update);
            this.Controls.Add(this.add);
            this.Controls.Add(this.dtgv);
            this.Name = "FrmAnneeScolaire";
            this.Text = "FrmAnneeScolaire";
            this.Load += new System.EventHandler(this.FrmAnneeScolaire_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgv;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button show;
        private System.Windows.Forms.ComboBox cbc;
        private System.Windows.Forms.ComboBox cba;
        private System.Windows.Forms.ComboBox cbe;
        private System.Windows.Forms.Label classe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}