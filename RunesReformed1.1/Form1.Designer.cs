﻿namespace RunesReformed1._1
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
            this.Champbox = new System.Windows.Forms.ComboBox();
            this.Pagebox = new System.Windows.Forms.ComboBox();
            this.Champlbl = new System.Windows.Forms.Label();
            this.Rolelbl = new System.Windows.Forms.Label();
            this.Pagelbl = new System.Windows.Forms.Label();
            this.Runebtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Champbox
            // 
            this.Champbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Champbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Champbox.FormattingEnabled = true;
            this.Champbox.Location = new System.Drawing.Point(100, 12);
            this.Champbox.Name = "Champbox";
            this.Champbox.Size = new System.Drawing.Size(172, 21);
            this.Champbox.TabIndex = 0;
            this.Champbox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Pagebox
            // 
            this.Pagebox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Pagebox.FormattingEnabled = true;
            this.Pagebox.Location = new System.Drawing.Point(100, 39);
            this.Pagebox.Name = "Pagebox";
            this.Pagebox.Size = new System.Drawing.Size(172, 21);
            this.Pagebox.TabIndex = 1;
            // 
            // Champlbl
            // 
            this.Champlbl.AutoSize = true;
            this.Champlbl.Location = new System.Drawing.Point(12, 15);
            this.Champlbl.Name = "Champlbl";
            this.Champlbl.Size = new System.Drawing.Size(54, 13);
            this.Champlbl.TabIndex = 3;
            this.Champlbl.Text = "Champion";
            this.Champlbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // Rolelbl
            // 
            this.Rolelbl.AutoSize = true;
            this.Rolelbl.Location = new System.Drawing.Point(12, 42);
            this.Rolelbl.Name = "Rolelbl";
            this.Rolelbl.Size = new System.Drawing.Size(32, 13);
            this.Rolelbl.TabIndex = 4;
            this.Rolelbl.Text = "Page";
            // 
            // Pagelbl
            // 
            this.Pagelbl.AutoSize = true;
            this.Pagelbl.Location = new System.Drawing.Point(12, 69);
            this.Pagelbl.Name = "Pagelbl";
            this.Pagelbl.Size = new System.Drawing.Size(0, 13);
            this.Pagelbl.TabIndex = 5;
            // 
            // Runebtn
            // 
            this.Runebtn.Location = new System.Drawing.Point(15, 66);
            this.Runebtn.Name = "Runebtn";
            this.Runebtn.Size = new System.Drawing.Size(257, 23);
            this.Runebtn.TabIndex = 6;
            this.Runebtn.Text = "Set Runes";
            this.Runebtn.UseVisualStyleBackColor = true;
            this.Runebtn.Click += new System.EventHandler(this.Runebtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 98);
            this.Controls.Add(this.Runebtn);
            this.Controls.Add(this.Pagelbl);
            this.Controls.Add(this.Rolelbl);
            this.Controls.Add(this.Champlbl);
            this.Controls.Add(this.Pagebox);
            this.Controls.Add(this.Champbox);
            this.Name = "Form1";
            this.Text = "RuneReformed";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Champbox;
        private System.Windows.Forms.ComboBox Pagebox;
        private System.Windows.Forms.Label Champlbl;
        private System.Windows.Forms.Label Rolelbl;
        private System.Windows.Forms.Label Pagelbl;
        private System.Windows.Forms.Button Runebtn;
    }
}

