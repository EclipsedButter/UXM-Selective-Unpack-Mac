using System;
using Eto.Forms;
using Eto.Drawing;

namespace UXM
{
    partial class FileView : Form
    {
        private System.ComponentModel.IContainer components = null;
        private Button btnOk;
        private Button btnSelectAll;
        private Button btnClear;
        private TextBox txtItemFilter;
        private Label lblSearch;
        private TreeGridView fileTree;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnOk = new Button();
            this.btnSelectAll = new Button();
            this.btnClear = new Button();
            this.txtItemFilter = new TextBox();
            this.lblSearch = new Label();
            this.fileTree = new TreeGridView();

            // 
            // btnOk
            // 
            var btnOkLocation = new Point(690, 10);
            //this.btnOk.Name = "btnOk";
            this.btnOk.Tag = "btnOk";
            this.btnOk.Size = new Size(75, 25);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "Ok";
            //this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new EventHandler<EventArgs>(this.Ok_Click);

            // 
            // btnSelectAll
            // 
            var btnSelectAllLocation = new Point(690, 40);
            this.btnSelectAll.Tag = "btnSelectAll";
            this.btnSelectAll.Size = new Size(75, 25);
            this.btnSelectAll.TabIndex = 1;
            this.btnSelectAll.Text = "Select All";
            //this.btnSelectAll.UseVisualStyleBackColor = true;
            this.btnSelectAll.Click += new EventHandler<EventArgs>(this.SelectAll_Click);

            // 
            // btnClear
            // 
            var btnClearLocation = new Point(690, 70);
            this.btnClear.Tag = "btnClear";
            this.btnClear.Size = new Size(75, 25);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear";
            //this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new EventHandler<EventArgs>(this.Clear_Click);

            // 
            // txtItemFilter
            // 
            var txtItemFilterLocation = new Point(10, 10);
            this.txtItemFilter.Tag = "txtItemFilter";
            this.txtItemFilter.Size = new Size(150, 20);
            this.txtItemFilter.TabIndex = 3;
            this.txtItemFilter.Bind<string>("Text", this, "ItemFilter");

            // 
            // lblSearch
            // 
            //this.lblSearch.AutoSize = true;
            //this.lblSearch.ForeColor = System.Drawing.Color.LightSlateGray;
            var lblSearchLocation = new Point(170, 10);
            this.lblSearch.Tag = "lblSearch";
            this.lblSearch.Size = new Size(57, 13);
            this.lblSearch.TabIndex = 4;
            this.lblSearch.Text = "Search...";
            this.lblSearch.Visible = false;  // Would be toggled based on filter

            // 
            // fileTree
            // 
            var fileTreeLocation = new Point(10, 40);
            this.fileTree.Tag = "fileTree";
            this.fileTree.Size = new Size(670, 400);
            this.fileTree.TabIndex = 5;
            fileTree.Columns.Add(new GridColumn
            {
                HeaderText = "File",
                DataCell = new TextBoxCell("Name"),
                Editable = false,
                Width = 100,
                MinWidth = 100,
                AutoSize = true,
                Resizable = true
            });
            fileTree.Columns.Add(new GridColumn
            {
                HeaderText = "",
                DataCell = new CheckBoxCell("Selected"),
                Editable = true,
                Width = 50,
                MinWidth = 50,
                Resizable = false
            });


            // 
            // FileView
            //
            //this.Content = new PixelLayout();
            //var Controls = this.Content as PixelLayout;
            //Controls.Add(this.btnOk, btnOkLocation);
            //Controls.Add(this.btnSelectAll, btnSelectAllLocation);
            //Controls.Add(this.btnClear, btnClearLocation);
            //Controls.Add(this.txtItemFilter, txtItemFilterLocation);
            //Controls.Add(this.lblSearch, lblSearchLocation);
            //Controls.Add(this.fileTree, fileTreeLocation);

            this.Content = new DynamicLayout();
            var Controls = this.Content as DynamicLayout;
            Controls.Padding = 10;
            Controls.Spacing = new Size(10, 10);
            Controls.BeginVertical();
            Controls.BeginHorizontal();
            Controls.BeginHorizontal();
            Controls.Add(this.txtItemFilter);
            Controls.Add(null);
            Controls.EndHorizontal();
            Controls.Add(this.lblSearch);
            Controls.EndBeginHorizontal();
            Controls.Add(this.fileTree, true);
            Controls.BeginVertical(padding: new Padding(10),
                                   spacing: new Size(10, 10));
            Controls.Add(this.btnOk);
            Controls.Add(this.btnSelectAll);
            Controls.Add(this.btnClear);
            Controls.Add(null);
            Controls.EndVertical();
            Controls.EndHorizontal();

            this.Tag = "FileView";
            this.Title = "Select Files";
            this.Size = new Size(800, 450);
            this.MinimumSize = new Size(400, 200);
        }
    }
}
