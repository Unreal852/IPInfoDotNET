namespace IPInfo.NET.Sample
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
            this.label3 = new System.Windows.Forms.Label();
            this.cmbFields = new System.Windows.Forms.ComboBox();
            this.ckAsync = new System.Windows.Forms.CheckBox();
            this.pbRequesting = new System.Windows.Forms.ProgressBar();
            this.txtToken = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRequest = new System.Windows.Forms.Button();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.treeResult = new System.Windows.Forms.TreeView();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.picLocMap = new System.Windows.Forms.PictureBox();
            this.pnlControls.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLocMap)).BeginInit();
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(253, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Field:";
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
            // pbRequesting
            // 
            this.pbRequesting.Location = new System.Drawing.Point(12, 83);
            this.pbRequesting.MarqueeAnimationSpeed = 5;
            this.pbRequesting.Name = "pbRequesting";
            this.pbRequesting.Size = new System.Drawing.Size(235, 19);
            this.pbRequesting.TabIndex = 5;
            // 
            // txtToken
            // 
            this.txtToken.Location = new System.Drawing.Point(90, 32);
            this.txtToken.Name = "txtToken";
            this.txtToken.Size = new System.Drawing.Size(157, 20);
            this.txtToken.TabIndex = 4;
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
            // btnRequest
            // 
            this.btnRequest.Location = new System.Drawing.Point(90, 58);
            this.btnRequest.Name = "btnRequest";
            this.btnRequest.Size = new System.Drawing.Size(157, 20);
            this.btnRequest.TabIndex = 2;
            this.btnRequest.Text = "Look Up !";
            this.btnRequest.UseVisualStyleBackColor = true;
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(90, 6);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(157, 20);
            this.txtIP.TabIndex = 1;
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
            // panel2
            // 
            this.panel2.Controls.Add(this.splitContainer1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 109);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(568, 367);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // treeResult
            // 
            this.treeResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeResult.Location = new System.Drawing.Point(0, 0);
            this.treeResult.Name = "treeResult";
            this.treeResult.Size = new System.Drawing.Size(288, 367);
            this.treeResult.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.treeResult);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.picLocMap);
            this.splitContainer1.Size = new System.Drawing.Size(568, 367);
            this.splitContainer1.SplitterDistance = 288;
            this.splitContainer1.TabIndex = 1;
            // 
            // picLocMap
            // 
            this.picLocMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picLocMap.Location = new System.Drawing.Point(0, 0);
            this.picLocMap.Name = "picLocMap";
            this.picLocMap.Size = new System.Drawing.Size(276, 367);
            this.picLocMap.TabIndex = 0;
            this.picLocMap.TabStop = false;
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
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLocMap)).EndInit();
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
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox picLocMap;
    }
}

