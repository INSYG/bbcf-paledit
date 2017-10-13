namespace BBCF_PalEdit
{
    partial class MainWindow
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
            this.savePac = new System.Windows.Forms.Button();
            this.openPac = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.valueR = new System.Windows.Forms.NumericUpDown();
            this.valueG = new System.Windows.Forms.NumericUpDown();
            this.valueB = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.selectPalette = new System.Windows.Forms.NumericUpDown();
            this.selectColor = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.enablePreview = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.importHpl = new System.Windows.Forms.Button();
            this.saveHpl = new System.Windows.Forms.Button();
            this.currentFilePath = new System.Windows.Forms.Label();
            this.openPalPacDialog = new System.Windows.Forms.OpenFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.buttonColorSel = new System.Windows.Forms.Button();
            this.openImgPacDialog = new System.Windows.Forms.OpenFileDialog();
            this.selectSub = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.applyColor = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.saveHplDialog = new System.Windows.Forms.SaveFileDialog();
            this.openHplDialog = new System.Windows.Forms.OpenFileDialog();
            this.savePalPacDialog = new System.Windows.Forms.SaveFileDialog();
            this.fromPng = new System.Windows.Forms.Button();
            this.openPngDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openPngDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valueR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valueG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valueB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectPalette)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectSub)).BeginInit();
            this.SuspendLayout();
            // 
            // savePac
            // 
            this.savePac.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.savePac.Enabled = false;
            this.savePac.Location = new System.Drawing.Point(93, 12);
            this.savePac.Name = "savePac";
            this.savePac.Size = new System.Drawing.Size(75, 23);
            this.savePac.TabIndex = 1;
            this.savePac.Text = "Save";
            this.savePac.UseVisualStyleBackColor = true;
            this.savePac.Click += new System.EventHandler(this.savePac_Click);
            // 
            // openPac
            // 
            this.openPac.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.openPac.Location = new System.Drawing.Point(12, 12);
            this.openPac.Name = "openPac";
            this.openPac.Size = new System.Drawing.Size(75, 23);
            this.openPac.TabIndex = 2;
            this.openPac.Text = "Open";
            this.openPac.UseVisualStyleBackColor = true;
            this.openPac.Click += new System.EventHandler(this.openPac_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.numericUpDown1.Enabled = false;
            this.numericUpDown1.Location = new System.Drawing.Point(126, 200);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(50, 20);
            this.numericUpDown1.TabIndex = 3;
            // 
            // valueR
            // 
            this.valueR.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.valueR.Enabled = false;
            this.valueR.Location = new System.Drawing.Point(126, 109);
            this.valueR.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.valueR.Name = "valueR";
            this.valueR.Size = new System.Drawing.Size(50, 20);
            this.valueR.TabIndex = 8;
            this.valueR.ValueChanged += new System.EventHandler(this.updateColorEvent);
            // 
            // valueG
            // 
            this.valueG.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.valueG.Enabled = false;
            this.valueG.Location = new System.Drawing.Point(182, 109);
            this.valueG.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.valueG.Name = "valueG";
            this.valueG.Size = new System.Drawing.Size(50, 20);
            this.valueG.TabIndex = 9;
            this.valueG.ValueChanged += new System.EventHandler(this.updateColorEvent);
            // 
            // valueB
            // 
            this.valueB.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.valueB.Enabled = false;
            this.valueB.Location = new System.Drawing.Point(238, 109);
            this.valueB.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.valueB.Name = "valueB";
            this.valueB.Size = new System.Drawing.Size(50, 20);
            this.valueB.TabIndex = 10;
            this.valueB.ValueChanged += new System.EventHandler(this.updateColorEvent);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label1.Location = new System.Drawing.Point(123, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Value (RGB)";
            // 
            // selectPalette
            // 
            this.selectPalette.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.selectPalette.Enabled = false;
            this.selectPalette.Location = new System.Drawing.Point(126, 70);
            this.selectPalette.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.selectPalette.Name = "selectPalette";
            this.selectPalette.Size = new System.Drawing.Size(50, 20);
            this.selectPalette.TabIndex = 4;
            this.selectPalette.ValueChanged += new System.EventHandler(this.selectPalette_ValueChanged);
            // 
            // selectColor
            // 
            this.selectColor.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.selectColor.Enabled = false;
            this.selectColor.Location = new System.Drawing.Point(238, 70);
            this.selectColor.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.selectColor.Name = "selectColor";
            this.selectColor.Size = new System.Drawing.Size(50, 20);
            this.selectColor.TabIndex = 5;
            this.selectColor.ValueChanged += new System.EventHandler(this.selectColor_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label2.Location = new System.Drawing.Point(123, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Frame";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label3.Location = new System.Drawing.Point(123, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Palette";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label4.Location = new System.Drawing.Point(235, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Color";
            // 
            // enablePreview
            // 
            this.enablePreview.AutoSize = true;
            this.enablePreview.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.enablePreview.Enabled = false;
            this.enablePreview.Location = new System.Drawing.Point(126, 164);
            this.enablePreview.Name = "enablePreview";
            this.enablePreview.Size = new System.Drawing.Size(64, 17);
            this.enablePreview.TabIndex = 6;
            this.enablePreview.Text = "Preview";
            this.enablePreview.UseVisualStyleBackColor = true;
            this.enablePreview.CheckedChanged += new System.EventHandler(this.enablePreview_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.checkBox2.Enabled = false;
            this.checkBox2.Location = new System.Drawing.Point(196, 164);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(98, 17);
            this.checkBox2.TabIndex = 7;
            this.checkBox2.Text = "Show Selected";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // importHpl
            // 
            this.importHpl.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.importHpl.Enabled = false;
            this.importHpl.Location = new System.Drawing.Point(174, 12);
            this.importHpl.Name = "importHpl";
            this.importHpl.Size = new System.Drawing.Size(75, 23);
            this.importHpl.TabIndex = 12;
            this.importHpl.Text = "Import HPL";
            this.importHpl.UseVisualStyleBackColor = true;
            this.importHpl.Click += new System.EventHandler(this.importHpl_Click);
            // 
            // saveHpl
            // 
            this.saveHpl.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.saveHpl.Enabled = false;
            this.saveHpl.Location = new System.Drawing.Point(255, 12);
            this.saveHpl.Name = "saveHpl";
            this.saveHpl.Size = new System.Drawing.Size(75, 23);
            this.saveHpl.TabIndex = 13;
            this.saveHpl.Text = "Export HPL";
            this.saveHpl.UseVisualStyleBackColor = true;
            this.saveHpl.Click += new System.EventHandler(this.saveHpl_Click);
            // 
            // currentFilePath
            // 
            this.currentFilePath.AutoSize = true;
            this.currentFilePath.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.currentFilePath.Location = new System.Drawing.Point(12, 38);
            this.currentFilePath.Name = "currentFilePath";
            this.currentFilePath.Size = new System.Drawing.Size(67, 13);
            this.currentFilePath.TabIndex = 14;
            this.currentFilePath.Text = "No file open.";
            // 
            // openPalPacDialog
            // 
            this.openPalPacDialog.Filter = "All compatible files|*.hpl;*pal.pac|HPAL files|*hpl|Palete files|*pal.pac|All fil" +
    "es|*";
            // 
            // buttonColorSel
            // 
            this.buttonColorSel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.buttonColorSel.Enabled = false;
            this.buttonColorSel.Location = new System.Drawing.Point(126, 135);
            this.buttonColorSel.Name = "buttonColorSel";
            this.buttonColorSel.Size = new System.Drawing.Size(75, 23);
            this.buttonColorSel.TabIndex = 15;
            this.buttonColorSel.Text = "Pick Color";
            this.buttonColorSel.UseVisualStyleBackColor = true;
            this.buttonColorSel.Click += new System.EventHandler(this.buttonColorSel_Click);
            // 
            // openImgPacDialog
            // 
            this.openImgPacDialog.Filter = "Image files|*img.pac|All files|*";
            // 
            // selectSub
            // 
            this.selectSub.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.selectSub.Enabled = false;
            this.selectSub.Location = new System.Drawing.Point(182, 70);
            this.selectSub.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.selectSub.Name = "selectSub";
            this.selectSub.Size = new System.Drawing.Size(50, 20);
            this.selectSub.TabIndex = 16;
            this.selectSub.ValueChanged += new System.EventHandler(this.selectSub_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label5.Location = new System.Drawing.Point(179, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Sub";
            // 
            // button5
            // 
            this.button5.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button5.Enabled = false;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(294, 54);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(44, 218);
            this.button5.TabIndex = 18;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // applyColor
            // 
            this.applyColor.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.applyColor.Enabled = false;
            this.applyColor.Location = new System.Drawing.Point(207, 135);
            this.applyColor.Name = "applyColor";
            this.applyColor.Size = new System.Drawing.Size(75, 23);
            this.applyColor.TabIndex = 19;
            this.applyColor.Text = "Apply Color";
            this.applyColor.UseVisualStyleBackColor = true;
            this.applyColor.Click += new System.EventHandler(this.applyColor_Click);
            // 
            // treeView1
            // 
            this.treeView1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.treeView1.Location = new System.Drawing.Point(12, 54);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(108, 218);
            this.treeView1.TabIndex = 20;
            this.treeView1.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseDoubleClick);
            // 
            // saveHplDialog
            // 
            this.saveHplDialog.DefaultExt = "hpl";
            this.saveHplDialog.Filter = "Palette file|*.hpl|All files|*";
            // 
            // openHplDialog
            // 
            this.openHplDialog.Filter = "Palette file|*.hpl|All files|*";
            // 
            // savePalPacDialog
            // 
            this.savePalPacDialog.DefaultExt = "pac";
            this.savePalPacDialog.Filter = "Palete files|*pal.pac|All files|*";
            // 
            // fromPng
            // 
            this.fromPng.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.fromPng.Enabled = false;
            this.fromPng.Location = new System.Drawing.Point(126, 249);
            this.fromPng.Name = "fromPng";
            this.fromPng.Size = new System.Drawing.Size(162, 23);
            this.fromPng.TabIndex = 21;
            this.fromPng.Text = "Import from PNG (Experimental)";
            this.fromPng.UseVisualStyleBackColor = true;
            this.fromPng.Click += new System.EventHandler(this.fromPng_Click);
            // 
            // openPngDialog1
            // 
            this.openPngDialog1.Filter = "PNG files|*png|All files|*";
            // 
            // openPngDialog2
            // 
            this.openPngDialog2.Filter = "PNG files|*png|All files|*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(126, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "May take ~1 minute:";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 284);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.fromPng);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.applyColor);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.selectSub);
            this.Controls.Add(this.buttonColorSel);
            this.Controls.Add(this.currentFilePath);
            this.Controls.Add(this.saveHpl);
            this.Controls.Add(this.importHpl);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.enablePreview);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.selectColor);
            this.Controls.Add(this.selectPalette);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.valueB);
            this.Controls.Add(this.valueG);
            this.Controls.Add(this.valueR);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.openPac);
            this.Controls.Add(this.savePac);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainWindow";
            this.Text = "BBCF PalEdit";
            this.Click += new System.EventHandler(this.updateColorEvent);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valueR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valueG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valueB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectPalette)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectSub)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button savePac;
        private System.Windows.Forms.Button openPac;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown valueR;
        private System.Windows.Forms.NumericUpDown valueG;
        private System.Windows.Forms.NumericUpDown valueB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown selectPalette;
        private System.Windows.Forms.NumericUpDown selectColor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox enablePreview;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Button importHpl;
        private System.Windows.Forms.Button saveHpl;
        private System.Windows.Forms.Label currentFilePath;
        private System.Windows.Forms.OpenFileDialog openPalPacDialog;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button buttonColorSel;
        private System.Windows.Forms.OpenFileDialog openImgPacDialog;
        private System.Windows.Forms.NumericUpDown selectSub;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button applyColor;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.SaveFileDialog saveHplDialog;
        private System.Windows.Forms.OpenFileDialog openHplDialog;
        private System.Windows.Forms.SaveFileDialog savePalPacDialog;
        private System.Windows.Forms.Button fromPng;
        private System.Windows.Forms.OpenFileDialog openPngDialog1;
        private System.Windows.Forms.OpenFileDialog openPngDialog2;
        private System.Windows.Forms.Label label6;
    }
}

