using System;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading;

namespace BBCF_PalEdit
{
    public partial class MainWindow : Form
    {
        List<byte> fileData;
        //List<byte> imgpac;

        string strWrongFormat = "Invalid file format.";
        string strPngMismatch = "Images don't match.";

        string fileType;
        string ftFpac = "FPAC";
        string ftHpal = "HPAL";

        PalFpac palFpac;
        Hpal hpalFromOpen;
        ///ImgFpac imgFpac;

        PreviewWindow previewWindow;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void openPac_Click(object sender, EventArgs e)
        {
            DialogResult result = openPalPacDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                string filePath = openPalPacDialog.FileName;
                try
                {
                    FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
                    byte[] fileDataB = new byte[fs.Length];
                    fs.Read(fileDataB, 0, (int)(fs.Length));
                    fs.Flush();
                    fs.Close();
                    fileData = new List<byte>(fileDataB);

                    byte[] fileHead = fileData.Take(4).ToArray();
                    byte[] hexFPAC = { 0x46, 0x50, 0x41, 0x43 };
                    byte[] hexHPAL = { 0x48, 0x50, 0x41, 0x4C };
                    if (fileHead.SequenceEqual(hexFPAC))
                    {
                        byte[] temp = fileData.Skip(4).Take(4).ToArray();
                        byte[] temp2 = fileData.Skip(32 + 16 + 8).Take(4).ToArray();
                        palFpac = new PalFpac(BitConverter.ToInt32(temp, 0), BitConverter.ToInt32(temp2, 0), fileData);
                        fileType = ftFpac;
                    }
                    else if (fileHead.SequenceEqual(hexHPAL))
                    {
                        hpalFromOpen = new Hpal(fileData);
                        fileType = ftHpal;
                    }

                    if (fileType == ftFpac)
                    {
                        savePac.Enabled = true;
                        saveHpl.Enabled = true;
                        importHpl.Enabled = true;
                        currentFilePath.Text = filePath;
                        selectPalette.Enabled = true;
                        selectSub.Enabled = true;
                        selectColor.Enabled = true;
                        applyColor.Enabled = true;
                        valueR.Enabled = true;
                        valueG.Enabled = true;
                        valueB.Enabled = true;
                        buttonColorSel.Enabled = true;
                        enablePreview.Enabled = false;
                        fromPng.Enabled = true;

                        treeView1.Nodes.Clear();

                        for (int i = 0; i < palFpac.palettes.Count; i++)
                        {
                            treeView1.Nodes.Add(i.ToString());
                            for (int j = 0; j < palFpac.palettes[i].subs.Count; j++)
                            {
                                treeView1.Nodes[i].Nodes.Add(j.ToString());
                                for (int k = 0; k < palFpac.palettes[i].subs[j].colorData.Count / 4; k++)
                                {
                                    treeView1.Nodes[i].Nodes[j].Nodes.Add(k.ToString());
                                }
                            }
                        }

                        updateMaxPal();
                        updateColorFromFpac();
                    }
                    else if (fileType == ftHpal)
                    {
                        savePac.Enabled = true;
                        saveHpl.Enabled = false;
                        importHpl.Enabled = false;
                        currentFilePath.Text = filePath;
                        selectPalette.Enabled = false;
                        selectSub.Enabled = false;
                        selectColor.Enabled = true;
                        applyColor.Enabled = true;
                        valueR.Enabled = true;
                        valueG.Enabled = true;
                        valueB.Enabled = true;
                        buttonColorSel.Enabled = true;
                        enablePreview.Enabled = false;
                        fromPng.Enabled = true;

                        treeView1.Nodes.Clear();

                        for (int i = 0; i < hpalFromOpen.colorData.Count / 4; i++)
                        {
                            treeView1.Nodes.Add(i.ToString());
                        }

                        updateMaxCol();
                        updateColor();
                    }
                    else
                    {
                        currentFilePath.Text = strWrongFormat;
                    }
                }
                catch (IOException) { }
            }
        }

        private void buttonColorSel_Click(object sender, EventArgs e)
        {
            DialogResult result = colorDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                Color color = colorDialog1.Color;
                valueR.Value = color.R;
                valueG.Value = color.G;
                valueB.Value = color.B;
            }
        }

        private void updateColor()
        {
            button5.BackColor = Color.FromArgb((int)valueR.Value, (int)valueG.Value, (int)valueB.Value);
        }

        private void updateColorFromFpac()
        {
            byte[] data = { 0x00, 0x00, 0x00 };
            if (fileType == ftFpac)
            {
                data = palFpac.palettes[(int)selectPalette.Value].subs[(int)selectSub.Value].colorData.Skip((int)selectColor.Value * 4).Take(3).ToArray();
            }
            else if (fileType == ftHpal)
            {
                data = hpalFromOpen.colorData.Skip((int)selectColor.Value * 4).Take(3).ToArray();
            }
            valueB.Value = data[0];
            valueG.Value = data[1];
            valueR.Value = data[2];
            updateColor();
        }

        private void updateMaxPal()
        {
            selectPalette.Maximum = palFpac.palettes.Count - 1;
            selectPalette.Value = 0;
            updateMaxSub();
        }

        private void updateMaxSub()
        {
            selectSub.Maximum = palFpac.palettes[(int)selectPalette.Value].subs.Count - 1;
            selectSub.Value = 0;
            updateMaxCol();
        }

        private void updateMaxCol()
        {
            if (fileType == ftFpac)
            {
                selectColor.Maximum = palFpac.palettes[(int)selectPalette.Value].subs[(int)selectSub.Value].colorData.Count / 4 - 1;
            }
            else if (fileType == ftHpal)
            {
                selectColor.Maximum = hpalFromOpen.colorData.Count / 4 - 1;
            }
            selectColor.Value = 0;
            updateColorFromFpac();
        }

        private void updateColorEvent(object sender, EventArgs e) { updateColor(); }

        private void selectPalette_ValueChanged(object sender, EventArgs e) { updateMaxSub(); }

        private void selectSub_ValueChanged(object sender, EventArgs e) { updateMaxCol(); }

        private void selectColor_ValueChanged(object sender, EventArgs e) { updateColorFromFpac(); }

        private void applyColor_Click(object sender, EventArgs e)
        {
            byte[] data = { (byte)valueB.Value, (byte)valueG.Value, (byte)valueR.Value };
            for (int i = 0; i < 3; i++)
            {
                if (fileType == ftFpac)
                {
                    palFpac.palettes[(int)selectPalette.Value].subs[(int)selectSub.Value].colorData[(int)selectColor.Value * 4 + i] = data[i];
                }
                else if (fileType == ftHpal)
                {
                    hpalFromOpen.colorData[(int)selectColor.Value * 4 + i] = data[i];
                }
            }

        }

        private void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (fileType == ftFpac)
            {
                if ((e.Node.Parent != null) && (e.Node.Parent.Parent != null))
                {
                    selectPalette.Value = int.Parse(e.Node.Parent.Parent.Text);
                    selectSub.Value = int.Parse(e.Node.Parent.Text);
                    selectColor.Value = int.Parse(e.Node.Text);
                    byte[] data = palFpac.palettes[(int)selectPalette.Value].subs[(int)selectSub.Value].colorData.Skip((int)selectColor.Value * 4).Take(3).ToArray();
                    valueB.Value = data[0];
                    valueG.Value = data[1];
                    valueR.Value = data[2];
                    updateColor();
                }
            }
            else if (fileType == ftHpal)
            {
                selectColor.Value = int.Parse(e.Node.Text);
                byte[] data = hpalFromOpen.colorData.Skip((int)selectColor.Value * 4).Take(3).ToArray();
                valueB.Value = data[0];
                valueG.Value = data[1];
                valueR.Value = data[2];
                updateColor();
            }
            
        }

        private void saveHpl_Click(object sender, EventArgs e)
        {
            DialogResult result = saveHplDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                string filePath = saveHplDialog.FileName;
                try
                {
                    FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.Write);
                    Hpal hpalOut = palFpac.palettes[(int)selectPalette.Value].subs[(int)selectSub.Value];
                    List<byte> hpalOutB = new List<byte>(hpalOut.header.Count + hpalOut.colorData.Count);
                    hpalOutB.AddRange(hpalOut.header);
                    hpalOutB.AddRange(hpalOut.colorData);
                    fs.Write(hpalOutB.ToArray(), 0, hpalOutB.Count);
                    fs.Close();
                }
                catch (IOException) { }
            }
        }

        private void importHpl_Click(object sender, EventArgs e)
        {
            DialogResult result = openHplDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                string filePath = openHplDialog.FileName;
                try
                {
                    FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
                    byte[] hplRead = new byte[fs.Length];
                    fs.Read(hplRead, 0, (int)(fs.Length));
                    fs.Close();

                    palFpac.palettes[(int)selectPalette.Value].subs[(int)selectSub.Value] = new Hpal(hplRead.ToList());
                    updateColor();
                }
                catch (IOException) { }
            }
        }

        private void savePac_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            if (fileType == ftFpac)
            {
                dialog = savePalPacDialog;
            }
            else if (fileType == ftHpal)
            {
                dialog = saveHplDialog;
            }

            DialogResult result = dialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                string filePath = dialog.FileName;
                try
                {
                    FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.Write);
                    List<byte> fileOut = new List<byte>();

                    if (fileType == ftFpac)
                    {
                        int asdf = BitConverter.ToInt32(fileData.ToArray(), 4);
                        fileOut = fileData.Take(BitConverter.ToInt32(fileData.ToArray(), 4)).ToList();
                        for (int i = 0; i < palFpac.palettes.Count; i++)
                        {
                            for (int j = 0; j < palFpac.palettes[i].subs.Count; j++)
                            {
                                fileOut.AddRange(palFpac.palettes[i].subs[j].header);
                                fileOut.AddRange(palFpac.palettes[i].subs[j].colorData);
                            }
                        }
                    } else if (fileType == ftHpal)
                    {
                        fileOut.AddRange(hpalFromOpen.header);
                        fileOut.AddRange(hpalFromOpen.colorData);
                    }
                    

                    fs.Write(fileOut.ToArray(), 0, fileOut.Count);
                    fs.Close();
                }
                catch (IOException) { }
            }
        }

        private void enablePreview_CheckedChanged(object sender, EventArgs e)
        {
            if (enablePreview.Checked && previewWindow == null)
            {
                previewWindow = new PreviewWindow();
                previewWindow.Show();
            }
            else if (!enablePreview.Checked && previewWindow != null)
            {
                previewWindow.Close();
                previewWindow = null;
            }

        }

        private void fromPng_Click(object sender, EventArgs e)
        {
            DialogResult result = openPngDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                string filePath = openPngDialog1.FileName;
                try
                {
                    Bitmap png1 = (Bitmap)Image.FromFile(filePath);

                    result = openPngDialog2.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        filePath = openPngDialog2.FileName;
                        try
                        {
                            Bitmap png2 = (Bitmap)Image.FromFile(filePath);

                            if (png1.Size == png2.Size)
                            {
                                Hpal tempHpal = new Hpal(new List<byte>());
                                int colorsChanged = 0;
                                if (fileType == ftFpac)
                                {
                                    tempHpal = palFpac.palettes[(int)selectPalette.Value].subs[(int)selectSub.Value];
                                }
                                else if (fileType == ftHpal)
                                {
                                    tempHpal = hpalFromOpen;
                                }
                                
                                List<Thread> threads = new List<Thread>(tempHpal.colorData.Count / 4);
                                for (int i = 0; i < tempHpal.colorData.Count / 4; i++)
                                {
                                    List<byte> targetColor = tempHpal.colorData.Skip(i * 4).Take(3).ToList();

                                    for (int j = 0; j < png1.Height; j++)
                                    {
                                        for (int k = 0; k < png1.Width; k++)
                                        {
                                            if (png1.GetPixel(k, j).R == targetColor[2] &&
                                                png1.GetPixel(k, j).G == targetColor[1] &&
                                                png1.GetPixel(k, j).B == targetColor[0])
                                            {
                                                Color newColor = png2.GetPixel(k, j);
                                                tempHpal.colorData[i * 4] = newColor.B;
                                                tempHpal.colorData[i * 4 + 1] = newColor.G;
                                                tempHpal.colorData[i * 4 + 2] = newColor.R;
                                                colorsChanged++;
                                                k = png1.Width;
                                                j = png1.Height;
                                            }
                                        }
                                    }
                                }

                                if (fileType == ftFpac)
                                {
                                    palFpac.palettes[(int)selectPalette.Value].subs[(int)selectSub.Value] = tempHpal;
                                }
                                else if (fileType == ftHpal)
                                {
                                    hpalFromOpen = tempHpal;
                                }

                                MessageBox.Show("Palette imported, " + colorsChanged.ToString() + " colors changed.");
                            }
                            else
                            {
                                currentFilePath.Text = strPngMismatch;
                            }
                        }
                        catch (IOException) { }
                    }
                }
                catch (IOException) { }
            }
        }
    }
}
