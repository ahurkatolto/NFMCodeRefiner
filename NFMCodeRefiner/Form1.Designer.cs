namespace NFMCodeRefiner
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.CodeMenu = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ImportFromFile = new System.Windows.Forms.ToolStripMenuItem();
            this.ImportFromClipboard = new System.Windows.Forms.ToolStripMenuItem();
            this.CodeSave = new System.Windows.Forms.ToolStripMenuItem();
            this.polyCountStrip = new System.Windows.Forms.StatusStrip();
            this.statusPoly = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.EngineSelect = new System.Windows.Forms.ComboBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.EditCrash = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.EditPhysics = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.EditRearWheels = new System.Windows.Forms.Button();
            this.EditFrontWheels = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.EditAlign = new System.Windows.Forms.Button();
            this.EditScale = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.EditStatsAndClass = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.EditSecondColor = new System.Windows.Forms.Button();
            this.EditFirstColor = new System.Windows.Forms.Button();
            this.polyGrid = new System.Windows.Forms.DataGridView();
            this.polygonBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.polygonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Points = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            this.polyCountStrip.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.polyGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.polygonBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.polygonBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CodeMenu});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(784, 25);
            this.toolStrip1.Stretch = true;
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // CodeMenu
            // 
            this.CodeMenu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.CodeMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.CodeSave});
            this.CodeMenu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CodeMenu.Name = "CodeMenu";
            this.CodeMenu.Size = new System.Drawing.Size(48, 22);
            this.CodeMenu.Text = "Code";
            this.CodeMenu.ToolTipText = "Code menu.";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ImportFromFile,
            this.ImportFromClipboard});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(110, 22);
            this.toolStripMenuItem1.Text = "Import";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // ImportFromFile
            // 
            this.ImportFromFile.Name = "ImportFromFile";
            this.ImportFromFile.Size = new System.Drawing.Size(157, 22);
            this.ImportFromFile.Text = "From File";
            // 
            // ImportFromClipboard
            // 
            this.ImportFromClipboard.Name = "ImportFromClipboard";
            this.ImportFromClipboard.Size = new System.Drawing.Size(157, 22);
            this.ImportFromClipboard.Text = "From Clipboard";
            // 
            // CodeSave
            // 
            this.CodeSave.Name = "CodeSave";
            this.CodeSave.Size = new System.Drawing.Size(110, 22);
            this.CodeSave.Text = "Save";
            // 
            // polyCountStrip
            // 
            this.polyCountStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusPoly});
            this.polyCountStrip.Location = new System.Drawing.Point(0, 539);
            this.polyCountStrip.Name = "polyCountStrip";
            this.polyCountStrip.Size = new System.Drawing.Size(784, 22);
            this.polyCountStrip.TabIndex = 1;
            this.polyCountStrip.Text = "statusStrip1";
            // 
            // statusPoly
            // 
            this.statusPoly.Name = "statusPoly";
            this.statusPoly.Size = new System.Drawing.Size(91, 17);
            this.statusPoly.Text = "Polygons: 0/210";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox8);
            this.panel1.Controls.Add(this.groupBox7);
            this.panel1.Controls.Add(this.groupBox6);
            this.panel1.Controls.Add(this.groupBox5);
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 71);
            this.panel1.TabIndex = 2;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.checkBox1);
            this.groupBox8.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox8.Location = new System.Drawing.Point(664, 0);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(116, 71);
            this.groupBox8.TabIndex = 7;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Misc";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBox1.Location = new System.Drawing.Point(3, 16);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(110, 20);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "newstone( )";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.EngineSelect);
            this.groupBox7.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox7.Location = new System.Drawing.Point(557, 0);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(107, 71);
            this.groupBox7.TabIndex = 6;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Engine";
            // 
            // EngineSelect
            // 
            this.EngineSelect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EngineSelect.FormattingEnabled = true;
            this.EngineSelect.Items.AddRange(new object[] {
            "Normal",
            "V8",
            "Retro",
            "Power",
            "Diesel"});
            this.EngineSelect.Location = new System.Drawing.Point(3, 16);
            this.EngineSelect.Name = "EngineSelect";
            this.EngineSelect.Size = new System.Drawing.Size(101, 21);
            this.EngineSelect.TabIndex = 0;
            this.EngineSelect.Text = "Normal";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.EditCrash);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox6.Location = new System.Drawing.Point(499, 0);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(58, 71);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Carsh";
            // 
            // EditCrash
            // 
            this.EditCrash.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EditCrash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditCrash.Location = new System.Drawing.Point(3, 16);
            this.EditCrash.Name = "EditCrash";
            this.EditCrash.Size = new System.Drawing.Size(52, 52);
            this.EditCrash.TabIndex = 0;
            this.EditCrash.Text = "Edit Crash";
            this.EditCrash.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.EditPhysics);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox5.Location = new System.Drawing.Point(431, 0);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(68, 71);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Physics";
            // 
            // EditPhysics
            // 
            this.EditPhysics.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EditPhysics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditPhysics.Location = new System.Drawing.Point(3, 16);
            this.EditPhysics.Name = "EditPhysics";
            this.EditPhysics.Size = new System.Drawing.Size(62, 52);
            this.EditPhysics.TabIndex = 0;
            this.EditPhysics.Text = "Edit Physics";
            this.EditPhysics.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.EditRearWheels);
            this.groupBox4.Controls.Add(this.EditFrontWheels);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox4.Location = new System.Drawing.Point(326, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(105, 71);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Wheels";
            // 
            // EditRearWheels
            // 
            this.EditRearWheels.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.EditRearWheels.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditRearWheels.Location = new System.Drawing.Point(3, 45);
            this.EditRearWheels.Name = "EditRearWheels";
            this.EditRearWheels.Size = new System.Drawing.Size(99, 23);
            this.EditRearWheels.TabIndex = 2;
            this.EditRearWheels.Text = "Edit Rear";
            this.EditRearWheels.UseVisualStyleBackColor = true;
            // 
            // EditFrontWheels
            // 
            this.EditFrontWheels.Dock = System.Windows.Forms.DockStyle.Top;
            this.EditFrontWheels.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditFrontWheels.Location = new System.Drawing.Point(3, 16);
            this.EditFrontWheels.Name = "EditFrontWheels";
            this.EditFrontWheels.Size = new System.Drawing.Size(99, 23);
            this.EditFrontWheels.TabIndex = 1;
            this.EditFrontWheels.Text = "Edit Front";
            this.EditFrontWheels.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.EditAlign);
            this.groupBox3.Controls.Add(this.EditScale);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox3.Location = new System.Drawing.Point(217, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(109, 71);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Scale and Align";
            // 
            // EditAlign
            // 
            this.EditAlign.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.EditAlign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditAlign.Location = new System.Drawing.Point(3, 45);
            this.EditAlign.Name = "EditAlign";
            this.EditAlign.Size = new System.Drawing.Size(103, 23);
            this.EditAlign.TabIndex = 2;
            this.EditAlign.Text = "Edit Align";
            this.EditAlign.UseVisualStyleBackColor = true;
            // 
            // EditScale
            // 
            this.EditScale.Dock = System.Windows.Forms.DockStyle.Top;
            this.EditScale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditScale.Location = new System.Drawing.Point(3, 16);
            this.EditScale.Name = "EditScale";
            this.EditScale.Size = new System.Drawing.Size(103, 23);
            this.EditScale.TabIndex = 1;
            this.EditScale.Text = "Edit Scale";
            this.EditScale.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.EditStatsAndClass);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox2.Location = new System.Drawing.Point(97, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(120, 71);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Stats and Class";
            // 
            // EditStatsAndClass
            // 
            this.EditStatsAndClass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EditStatsAndClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditStatsAndClass.Location = new System.Drawing.Point(3, 16);
            this.EditStatsAndClass.Name = "EditStatsAndClass";
            this.EditStatsAndClass.Size = new System.Drawing.Size(114, 52);
            this.EditStatsAndClass.TabIndex = 0;
            this.EditStatsAndClass.Text = "Edit Stats and Class";
            this.EditStatsAndClass.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.EditSecondColor);
            this.groupBox1.Controls.Add(this.EditFirstColor);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(97, 71);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Colors";
            // 
            // EditSecondColor
            // 
            this.EditSecondColor.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.EditSecondColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditSecondColor.Location = new System.Drawing.Point(3, 45);
            this.EditSecondColor.Name = "EditSecondColor";
            this.EditSecondColor.Size = new System.Drawing.Size(91, 23);
            this.EditSecondColor.TabIndex = 1;
            this.EditSecondColor.Text = "2ndColor";
            this.EditSecondColor.UseVisualStyleBackColor = true;
            // 
            // EditFirstColor
            // 
            this.EditFirstColor.Dock = System.Windows.Forms.DockStyle.Top;
            this.EditFirstColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditFirstColor.Location = new System.Drawing.Point(3, 16);
            this.EditFirstColor.Name = "EditFirstColor";
            this.EditFirstColor.Size = new System.Drawing.Size(91, 23);
            this.EditFirstColor.TabIndex = 0;
            this.EditFirstColor.Text = "1stColor";
            this.EditFirstColor.UseVisualStyleBackColor = true;
            // 
            // polyGrid
            // 
            this.polyGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.polyGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.polyGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.polyGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Number,
            this.Points,
            this.Color,
            this.Fs,
            this.Gr});
            this.polyGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.polyGrid.Location = new System.Drawing.Point(0, 96);
            this.polyGrid.Name = "polyGrid";
            this.polyGrid.Size = new System.Drawing.Size(784, 443);
            this.polyGrid.TabIndex = 3;
            // 
            // polygonBindingSource1
            // 
            this.polygonBindingSource1.DataSource = typeof(NFMCodeRefiner.Polygon);
            // 
            // polygonBindingSource
            // 
            this.polygonBindingSource.DataSource = typeof(NFMCodeRefiner.Polygon);
            // 
            // Number
            // 
            this.Number.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Number.FillWeight = 30F;
            this.Number.HeaderText = "#";
            this.Number.MinimumWidth = 40;
            this.Number.Name = "Number";
            this.Number.Width = 40;
            // 
            // Points
            // 
            this.Points.HeaderText = "Points";
            this.Points.Name = "Points";
            // 
            // Color
            // 
            this.Color.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Color.FillWeight = 30F;
            this.Color.HeaderText = "Color";
            this.Color.MinimumWidth = 70;
            this.Color.Name = "Color";
            this.Color.Width = 70;
            // 
            // Fs
            // 
            this.Fs.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Fs.FillWeight = 30F;
            this.Fs.HeaderText = "Fs";
            this.Fs.MinimumWidth = 40;
            this.Fs.Name = "Fs";
            this.Fs.Width = 40;
            // 
            // Gr
            // 
            this.Gr.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Gr.FillWeight = 30F;
            this.Gr.HeaderText = "Gr";
            this.Gr.MinimumWidth = 40;
            this.Gr.Name = "Gr";
            this.Gr.Width = 40;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.polyGrid);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.polyCountStrip);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Need for Madness Code Refiner";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.polyCountStrip.ResumeLayout(false);
            this.polyCountStrip.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.polyGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.polygonBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.polygonBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton CodeMenu;
        private System.Windows.Forms.ToolStripMenuItem CodeSave;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ImportFromFile;
        private System.Windows.Forms.ToolStripMenuItem ImportFromClipboard;
        private System.Windows.Forms.StatusStrip polyCountStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusPoly;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button EditRearWheels;
        private System.Windows.Forms.Button EditFrontWheels;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button EditScale;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button EditStatsAndClass;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button EditSecondColor;
        private System.Windows.Forms.Button EditFirstColor;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.ComboBox EngineSelect;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button EditCrash;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button EditPhysics;
        private System.Windows.Forms.Button EditAlign;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.BindingSource polygonBindingSource;
        private System.Windows.Forms.BindingSource polygonBindingSource1;
        private System.Windows.Forms.DataGridView polyGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Points;
        private System.Windows.Forms.DataGridViewTextBoxColumn Color;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fs;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gr;
    }
}

