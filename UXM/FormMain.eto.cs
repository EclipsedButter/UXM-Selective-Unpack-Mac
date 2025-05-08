namespace UXM
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            Eto.Forms.Label lblBreak;
            Eto.Forms.Label lblExePath;
            Eto.Forms.Label lblStatus;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.btnPatch = new Eto.Forms.Button();
            this.btnUnpack = new Eto.Forms.Button();
            this.btnRestore = new Eto.Forms.Button();
            this.btnAbort = new Eto.Forms.Button();
            this.btnExplore = new Eto.Forms.Button();
            this.btnBrowse = new Eto.Forms.Button();
            this.txtExePath = new Eto.Forms.TextBox();
            this.lblUpdate = new Eto.Forms.Label();
            //this.llbUpdate = new Eto.Forms.LinkLabel();
            this.llbUpdate = new Eto.Forms.LinkButton();
            this.txtStatus = new Eto.Forms.TextBox();
            this.pbrProgress = new Eto.Forms.ProgressBar();
            this.ofdExe = new Eto.Forms.OpenFileDialog();
            //this.toolTip1 = new Eto.Forms.ToolTip(this.components);
            this.cbxSkip = new Eto.Forms.CheckBox();
            this.btnFileView = new Eto.Forms.Button();
            lblBreak = new Eto.Forms.Label();
            lblExePath = new Eto.Forms.Label();
            lblStatus = new Eto.Forms.Label();
            this.SuspendLayout();
            // 
            // lblBreak
            // 
            //lblBreak.Anchor = ((Eto.Forms.AnchorStyles)(((Eto.Forms.AnchorStyles.Top | Eto.Forms.AnchorStyles.Left) 
            //| Eto.Forms.AnchorStyles.Right)));
            //lblBreak.BorderStyle = Eto.Forms.BorderStyle.Fixed3D;
            var lblBreakLocation = new Eto.Drawing.Point(-20, 131);
            //lblBreak.Margin = new Eto.Forms.Padding(4, 0, 4, 0);
            //lblBreak.Tag = "lblBreak";
            lblBreak.Tag = "lblBreak";
            lblBreak.Size = new Eto.Drawing.Size(998, 3);
            lblBreak.TabIndex = 31;
            // 
            // lblExePath
            // 
            //lblExePath.AutoSize = true;
            var lblExePathLocation = new Eto.Drawing.Point(18, 14);
            //lblExePath.Margin = new Eto.Forms.Padding(4, 0, 4, 0);
            lblExePath.Tag = "lblExePath";
            lblExePath.Size = new Eto.Drawing.Size(125, 20);
            lblExePath.TabIndex = 30;
            lblExePath.Text = "Executable Path";
            // 
            // lblStatus
            // 
            //lblStatus.AutoSize = true;
            var lblStatusLocation = new Eto.Drawing.Point(18, 143);
            //lblStatus.Margin = new Eto.Forms.Padding(4, 0, 4, 0);
            lblStatus.Tag = "lblStatus";
            lblStatus.Size = new Eto.Drawing.Size(56, 20);
            lblStatus.TabIndex = 32;
            lblStatus.Text = "Status";
            // 
            // btnPatch
            // 
            //this.btnPatch.Anchor = ((Eto.Forms.AnchorStyles)((Eto.Forms.AnchorStyles.Top | Eto.Forms.AnchorStyles.Right)));
            var btnPatchLocation = new Eto.Drawing.Point(588, 80);
            //this.btnPatch.Margin = new Eto.Forms.Padding(4, 5, 4, 5);
            this.btnPatch.Tag = "btnPatch";
            this.btnPatch.Size = new Eto.Drawing.Size(112, 35);
            this.btnPatch.TabIndex = 27;
            this.btnPatch.Text = "Patch";
            //this.btnPatch.UseVisualStyleBackColor = true;
            this.btnPatch.Click += new System.EventHandler<System.EventArgs>(this.btnPatch_Click);
            // 
            // btnUnpack
            // 
            //this.btnUnpack.Anchor = ((Eto.Forms.AnchorStyles)((Eto.Forms.AnchorStyles.Top | Eto.Forms.AnchorStyles.Right)));
            var btnUnpackLocation = new Eto.Drawing.Point(466, 80);
            //this.btnUnpack.Margin = new Eto.Forms.Padding(4, 5, 4, 5);
            this.btnUnpack.Tag = "btnUnpack";
            this.btnUnpack.Size = new Eto.Drawing.Size(112, 35);
            this.btnUnpack.TabIndex = 26;
            this.btnUnpack.Text = "Unpack";
            //this.btnUnpack.UseVisualStyleBackColor = true;
            this.btnUnpack.Click += new System.EventHandler<System.EventArgs>(this.btnUnpack_Click);
            // 
            // btnRestore
            // 
            //this.btnRestore.Anchor = ((Eto.Forms.AnchorStyles)((Eto.Forms.AnchorStyles.Top | Eto.Forms.AnchorStyles.Right)));
            var btnRestoreLocation = new Eto.Drawing.Point(710, 80);
            //this.btnRestore.Margin = new Eto.Forms.Padding(4, 5, 4, 5);
            this.btnRestore.Tag = "btnRestore";
            this.btnRestore.Size = new Eto.Drawing.Size(112, 35);
            this.btnRestore.TabIndex = 28;
            this.btnRestore.Text = "Restore";
            //this.btnRestore.UseVisualStyleBackColor = true;
            this.btnRestore.Click += new System.EventHandler<System.EventArgs>(this.btnRestore_Click);
            // 
            // btnAbort
            // 
            //this.btnAbort.Anchor = ((Eto.Forms.AnchorStyles)((Eto.Forms.AnchorStyles.Top | Eto.Forms.AnchorStyles.Right)));
            this.btnAbort.Enabled = false;
            var btnAbortLocation = new Eto.Drawing.Point(831, 80);
            //this.btnAbort.Margin = new Eto.Forms.Padding(4, 5, 4, 5);
            this.btnAbort.Tag = "btnAbort";
            this.btnAbort.Size = new Eto.Drawing.Size(112, 35);
            this.btnAbort.TabIndex = 29;
            this.btnAbort.Text = "Abort";
            //this.btnAbort.UseVisualStyleBackColor = true;
            this.btnAbort.Click += new System.EventHandler<System.EventArgs>(this.btnAbort_Click);
            // 
            // btnExplore
            // 
            //this.btnExplore.Anchor = ((Eto.Forms.AnchorStyles)((Eto.Forms.AnchorStyles.Top | Eto.Forms.AnchorStyles.Right)));
            var btnExploreLocation = new Eto.Drawing.Point(831, 35);
            //this.btnExplore.Margin = new Eto.Forms.Padding(4, 5, 4, 5);
            this.btnExplore.Tag = "btnExplore";
            this.btnExplore.Size = new Eto.Drawing.Size(112, 35);
            this.btnExplore.TabIndex = 25;
            this.btnExplore.Text = "Explore";
            //this.btnExplore.UseVisualStyleBackColor = true;
            this.btnExplore.Click += new System.EventHandler<System.EventArgs>(this.btnExplore_Click);
            // 
            // btnBrowse
            // 
            //this.btnBrowse.Anchor = ((Eto.Forms.AnchorStyles)((Eto.Forms.AnchorStyles.Top | Eto.Forms.AnchorStyles.Right)));
            var btnBrowseLocation = new Eto.Drawing.Point(710, 35);
            //this.btnBrowse.Margin = new Eto.Forms.Padding(4, 5, 4, 5);
            this.btnBrowse.Tag = "btnBrowse";
            this.btnBrowse.Size = new Eto.Drawing.Size(112, 35);
            this.btnBrowse.TabIndex = 24;
            this.btnBrowse.Text = "Browse";
            //this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler<System.EventArgs>(this.btnBrowse_Click);
            // 
            // txtExePath
            // 
            //this.txtExePath.Anchor = ((Eto.Forms.AnchorStyles)(((Eto.Forms.AnchorStyles.Top | Eto.Forms.AnchorStyles.Left) 
            //| Eto.Forms.AnchorStyles.Right)));
            var txtExePathLocation = new Eto.Drawing.Point(18, 38);
            //this.txtExePath.Margin = new Eto.Forms.Padding(4, 5, 4, 5);
            this.txtExePath.Tag = "txtExePath";
            this.txtExePath.Size = new Eto.Drawing.Size(680, 26);
            this.txtExePath.TabIndex = 23;
            this.txtExePath.Text = "{0}/steamapps/common/EldenRing/Game/eldenring.exe";
            this.txtExePath.TextChanged += new System.EventHandler<System.EventArgs>(this.txtExePath_TextChanged);
            // 
            // lblUpdate
            // 
            //this.lblUpdate.Anchor = ((Eto.Forms.AnchorStyles)((Eto.Forms.AnchorStyles.Top | Eto.Forms.AnchorStyles.Right)));
            var lblUpdateLocation = new Eto.Drawing.Point(264, 257);
            //this.lblUpdate.Margin = new Eto.Forms.Padding(4, 0, 4, 0);
            this.lblUpdate.Tag = "lblUpdate";
            this.lblUpdate.Size = new Eto.Drawing.Size(680, 20);
            this.lblUpdate.TabIndex = 35;
            this.lblUpdate.Text = "Checking for update...";
            this.lblUpdate.TextAlignment = Eto.Forms.TextAlignment.Right;
            this.lblUpdate.VerticalAlignment = Eto.Forms.VerticalAlignment.Top;
            // 
            // llbUpdate
            // 
            //this.llbUpdate.Anchor = ((Eto.Forms.AnchorStyles)((Eto.Forms.AnchorStyles.Top | Eto.Forms.AnchorStyles.Right)));
            var llbUpdateLocation = new Eto.Drawing.Point(268, 257);
            //this.llbUpdate.Margin = new Eto.Forms.Padding(4, 0, 4, 0);
            this.llbUpdate.Tag = "llbUpdate";
            this.llbUpdate.Size = new Eto.Drawing.Size(675, 20);
            this.llbUpdate.TabIndex = 36;
            //this.llbUpdate.TabStop = true;
            this.llbUpdate.Text = "New version available!";
            this.lblUpdate.TextAlignment = Eto.Forms.TextAlignment.Right;
            this.lblUpdate.VerticalAlignment = Eto.Forms.VerticalAlignment.Top;
            this.llbUpdate.Visible = false;
            this.llbUpdate.Click += new System.EventHandler<System.EventArgs>(this.llbUpdate_LinkClicked);
            // 
            // txtStatus
            // 
            //this.txtStatus.Anchor = ((Eto.Forms.AnchorStyles)(((Eto.Forms.AnchorStyles.Top | Eto.Forms.AnchorStyles.Left) 
            //| Eto.Forms.AnchorStyles.Right)));
            var txtStatusLocation = new Eto.Drawing.Point(18, 168);
            //this.txtStatus.Margin = new Eto.Forms.Padding(4, 5, 4, 5);
            this.txtStatus.Tag = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new Eto.Drawing.Size(924, 26);
            this.txtStatus.TabIndex = 33;
            // 
            // pbrProgress
            // 
            //this.pbrProgress.Anchor = ((Eto.Forms.AnchorStyles)(((Eto.Forms.AnchorStyles.Top | Eto.Forms.AnchorStyles.Left) 
            //| Eto.Forms.AnchorStyles.Right)));
            var pbrProgressLocation = new Eto.Drawing.Point(18, 208);
            //this.pbrProgress.Margin = new Eto.Forms.Padding(4, 5, 4, 5);
            this.pbrProgress.MaxValue = 1000;
            this.pbrProgress.Tag = "pbrProgress";
            this.pbrProgress.Size = new Eto.Drawing.Size(926, 35);
            this.pbrProgress.TabIndex = 34;
            // 
            // ofdExe
            // 
            this.ofdExe.FileName = "eldenring.exe";
            //this.ofdExe.CurrentFilter = "FromSoft Game Executable|.exe;"; //!
            this.ofdExe.Title = "Select FromSoft Game executable...";
            // 
            // cbxSkip
            // 
            //this.cbxSkip.AutoSize = true;
            var cbxSkipLocation = new Eto.Drawing.Point(137, 86);
            this.cbxSkip.Tag = "cbxSkip";
            this.cbxSkip.Size = new Eto.Drawing.Size(168, 24);
            this.cbxSkip.TabIndex = 37;
            this.cbxSkip.Text = "Use Selected Files";
            //this.cbxSkip.UseVisualStyleBackColor = true;
            this.cbxSkip.CheckedChanged += new System.EventHandler<System.EventArgs>(this.cbxSkip_CheckedChanged);
            // 
            // btnFileView
            // 
            var btnFileViewLocation = new Eto.Drawing.Point(18, 80);
            //this.btnFileView.Margin = new Eto.Forms.Padding(4, 5, 4, 5);
            this.btnFileView.Tag = "btnFileView";
            this.btnFileView.Size = new Eto.Drawing.Size(112, 35);
            this.btnFileView.TabIndex = 38;
            this.btnFileView.Text = "View Files";
            //this.btnFileView.UseVisualStyleBackColor = true;
            this.btnFileView.Click += new System.EventHandler<System.EventArgs>(this.btnView_Click);
            //
            // formFileView
            //
            //formFileView = new FormFileView(this);
            // 
            // FormMain
            // 
            //this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            //this.AutoScaleMode = Eto.Forms.AutoScaleMode.Font;
            this.ClientSize = new Eto.Drawing.Size(962, 274);
            this.Content = new Eto.Forms.PixelLayout();
            var Controls = this.Content as Eto.Forms.PixelLayout;
            Controls.Add(this.btnFileView, btnFileViewLocation);
            Controls.Add(this.cbxSkip, cbxSkipLocation);
            Controls.Add(this.llbUpdate, llbUpdateLocation);
            Controls.Add(this.txtStatus, txtStatusLocation);
            Controls.Add(lblStatus, lblStatusLocation);
            Controls.Add(this.pbrProgress, pbrProgressLocation);
            Controls.Add(lblBreak, lblBreakLocation);
            Controls.Add(this.btnPatch, btnPatchLocation);
            Controls.Add(this.btnUnpack, btnUnpackLocation);
            Controls.Add(this.btnRestore, btnRestoreLocation);
            Controls.Add(this.btnAbort, btnAbortLocation);
            Controls.Add(this.btnExplore, btnExploreLocation);
            Controls.Add(this.btnBrowse, btnBrowseLocation);
            Controls.Add(this.txtExePath, txtExePathLocation);
            Controls.Add(lblExePath, lblExePathLocation);
            Controls.Add(this.lblUpdate, lblUpdateLocation);
            //Controls.Add(this.formFileView, new Eto.Drawing.Point(0, 0));
            //this.Icon = ((Eto.Drawing.Icon)(resources.GetObject("$this.Icon"))); //!
            //this.Margin = new Eto.Forms.Padding(4, 5, 4, 5);
            //this.MaximumSize = new Eto.Drawing.Size(2989, 330);
            this.MinimumSize = new Eto.Drawing.Size(984, 330);
            this.Tag = "FormMain";
            //this.Text = "UXM <version>";
            this.Title = "UXM <version>";
            this.Shown += new System.EventHandler<System.EventArgs>(this.FormMain_Activated);
            this.Closing += new System.EventHandler<System.ComponentModel.CancelEventArgs>(this.FormMain_FormClosing);
            this.Load += new System.EventHandler<System.EventArgs>(this.FormMain_Load);
            //this.ResumeLayout(false);
            this.ResumeLayout();
            //this.PerformLayout();
            this.UpdateLayout();

        }

        #endregion

        private Eto.Forms.Button btnPatch;
        private Eto.Forms.Button btnUnpack;
        private Eto.Forms.Button btnRestore;
        private Eto.Forms.Button btnAbort;
        private Eto.Forms.Button btnExplore;
        private Eto.Forms.Button btnBrowse;
        private Eto.Forms.TextBox txtExePath;
        private Eto.Forms.Label lblUpdate;
        private Eto.Forms.LinkButton llbUpdate;
        private Eto.Forms.TextBox txtStatus;
        private Eto.Forms.ProgressBar pbrProgress;
        private Eto.Forms.OpenFileDialog ofdExe;
        //private Eto.Forms.ToolTip toolTip1;
        private Eto.Forms.CheckBox cbxSkip;
        private Eto.Forms.Button btnFileView;
    }
}

