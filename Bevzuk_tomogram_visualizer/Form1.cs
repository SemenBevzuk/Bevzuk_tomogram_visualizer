using System;
using System.Windows.Forms;

namespace Bevzuk_tomogram_visualizer
{
    public partial class Form1 : Form
    {
        Bin bin = new Bin();
        View view = new View();
        bool loaded = false;
        int currentLayer = 0;
        int FrameCount;
        DateTime NextFPSUpdate = DateTime.Now.AddSeconds(1);
        void displayFPS()
        {
            if (DateTime.Now >= NextFPSUpdate)
            {
                Text = String.Format("CT Visualizer (fps = {0})", FrameCount);
                NextFPSUpdate = DateTime.Now.AddSeconds(1);
                FrameCount = 0;
            }
            FrameCount++;
        }
        
        public Form1()
        {
            InitializeComponent();
            label_LayerCurrent.Text = "Текущий уровень = ";
        }

        private bool needReload = false;
        private void glControl1_Paint(object sender, PaintEventArgs e)
        {
            if (loaded)
            {
                if (radioButton_Quad.Checked)
                {
                    view.DrawQuads(currentLayer);
                }
                if (radioButton_Texture.Checked)
                {
                    if (needReload)
                    {
                        view.generateTextureImage(currentLayer);
                        view.Load2DTexture();
                        needReload = false;
                    }
                    view.DrawTexture();
                }
                glControl1.SwapBuffers();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Application.Idle += Application_Idle;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            currentLayer = trackBar_layers.Value;
            label_LayerCurrent.Text = "Текущий уровень = "+currentLayer;
            needReload = true;
        }

        void Application_Idle(object sender, EventArgs e)
        {
            while (glControl1.IsIdle)
            {
                displayFPS();
                glControl1.Invalidate();
            }
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string str = dialog.FileName;
                bin.readBin(str);
                trackBar_layers.SetRange(0, Bin.Z - 1);
                view.SetupView(glControl1.Width, glControl1.Height);
                loaded = true;
                glControl1.Invalidate();
            }
            label_max.Text = ""+(Bin.Z-1);
            label_LayerCurrent.Text = "Текущий уровень = "+currentLayer;
        }

        private void trackBar_TFMin_Scroll(object sender, EventArgs e)
        {
            view.SetMinMaxTransferFunction(trackBar_TFMin.Value, trackBar_TFMin.Value+trackBar_TFHeight.Value);
            label_TFMinCurrent.Text = "Текущий минимум = " + trackBar_TFMin.Value;
            label_TFMaxCurrent.Text = "Текущий максимум = " + (trackBar_TFMin.Value+trackBar_TFHeight.Value);
            needReload = true;
        }

        private void trackBar_TFHeight_Scroll(object sender, EventArgs e)
        {
            view.SetMinMaxTransferFunction(trackBar_TFMin.Value, trackBar_TFMin.Value+trackBar_TFHeight.Value);
            label_TFHieghtCurrent.Text = "Текущая ширина = " + trackBar_TFHeight.Value;
            label_TFMaxCurrent.Text = "Текущий максимум = " + (trackBar_TFMin.Value+trackBar_TFHeight.Value);
            needReload = true;
        }
    }
}


