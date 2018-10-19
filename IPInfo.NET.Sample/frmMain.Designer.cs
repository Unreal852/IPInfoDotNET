﻿namespace IPInfo.NET.Sample
{
    partial class frmMain
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlControls = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.btnRequest = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtToken = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.treeResult = new System.Windows.Forms.TreeView();
            this.pbRequesting = new System.Windows.Forms.ProgressBar();
            this.ckAsync = new System.Windows.Forms.CheckBox();
            this.cmbFields = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlControls.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlControls
            // 
            this.pnlControls.Controls.Add(this.label3);
            this.pnlControls.Controls.Add(this.cmbFields);
            this.pnlControls.Controls.Add(this.ckAsync);
            this.pnlControls.Controls.Add(this.pbRequesting);
            this.pnlControls.Controls.Add(this.txtToken);
            this.pnlControls.Controls.Add(this.label2);
            this.pnlControls.Controls.Add(this.btnRequest);
            this.pnlControls.Controls.Add(this.txtIP);
            this.pnlControls.Controls.Add(this.label1);
            this.pnlControls.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlControls.Location = new System.Drawing.Point(0, 0);
            this.pnlControls.Name = "pnlControls";
            this.pnlControls.Size = new System.Drawing.Size(568, 109);
            this.pnlControls.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lookup IP:";
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(90, 6);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(157, 20);
            this.txtIP.TabIndex = 1;
            // 
            // btnRequest
            // 
            this.btnRequest.Location = new System.Drawing.Point(90, 58);
            this.btnRequest.Name = "btnRequest";
            this.btnRequest.Size = new System.Drawing.Size(157, 20);
            this.btnRequest.TabIndex = 2;
            this.btnRequest.Text = "Look Up !";
            this.btnRequest.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "IPInfo Token:";
            // 
            // txtToken
            // 
            this.txtToken.Location = new System.Drawing.Point(90, 32);
            this.txtToken.Name = "txtToken";
            this.txtToken.Size = new System.Drawing.Size(157, 20);
            this.txtToken.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.treeResult);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 109);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(568, 367);
            this.panel2.TabIndex = 1;
            // 
            // treeResult
            // 
            this.treeResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeResult.Location = new System.Drawing.Point(0, 0);
            this.treeResult.Name = "treeResult";
            this.treeResult.Size = new System.Drawing.Size(568, 367);
            this.treeResult.TabIndex = 0;
            // 
            // pbRequesting
            // 
            this.pbRequesting.Location = new System.Drawing.Point(12, 83);
            this.pbRequesting.MarqueeAnimationSpeed = 5;
            this.pbRequesting.Name = "pbRequesting";
            this.pbRequesting.Size = new System.Drawing.Size(235, 19);
            this.pbRequesting.TabIndex = 5;
            // 
            // ckAsync
            // 
            this.ckAsync.AutoSize = true;
            this.ckAsync.Location = new System.Drawing.Point(12, 60);
            this.ckAsync.Name = "ckAsync";
            this.ckAsync.Size = new System.Drawing.Size(55, 17);
            this.ckAsync.TabIndex = 6;
            this.ckAsync.Text = "Async";
            this.ckAsync.UseVisualStyleBackColor = true;
            // 
            // cmbFields
            // 
            this.cmbFields.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFields.FormattingEnabled = true;
            this.cmbFields.Location = new System.Drawing.Point(291, 6);
            this.cmbFields.Name = "cmbFields";
            this.cmbFields.Size = new System.Drawing.Size(121, 21);
            this.cmbFields.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(253, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Field:";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 476);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlControls);
            this.Name = "frmMain";
            this.Text = "IPInfo.NET Sample";
            this.pnlControls.ResumeLayout(false);
            this.pnlControls.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlControls;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRequest;
        private System.Windows.Forms.TextBox txtToken;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TreeView treeResult;
        private System.Windows.Forms.ProgressBar pbRequesting;
        private System.Windows.Forms.CheckBox ckAsync;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbFields;
    }
}

