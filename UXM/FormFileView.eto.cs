
namespace UXM
{
    partial class FormFileView
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
            //this.elementHost1 = new Eto.Forms.Integration.ElementHost();
            this.FileView = new UXM.FileView();
            this.SuspendLayout();
            // 
            // elementHost1
            // 
            //this.elementHost1.Dock = Eto.Forms.DockStyle.Fill;
            //this.elementHost1.Location = new System.Drawing.Point(0, 0);
            //this.elementHost1.Name = "elementHost1";
            //this.elementHost1.Size = new System.Drawing.Size(819, 515);
            //this.elementHost1.TabIndex = 0;
            //this.elementHost1.Text = "elementHost1";
            //this.elementHost1.Child = this.FileView;
            // 
            // FormFileView
            // 
            //this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            //this.AutoScaleMode = Eto.Forms.AutoScaleMode.Font;
            this.ClientSize = new Eto.Drawing.Size(819, 515);
            this.Content = new Eto.Forms.PixelLayout();
            var Controls = this.Content as Eto.Forms.PixelLayout;
            //this.Controls.Add(this.elementHost1);
            //Controls.Add(this.FileView, new Eto.Drawing.Point(0,0));
            this.Tag = "FormFileView";
            this.Title = "Select Files";
            this.ResumeLayout();

        }

        #endregion

        //private Eto.Forms.Integration.ElementHost elementHost1;
        private FileView FileView;
    }
}