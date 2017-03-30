namespace Bevzuk_tomogram_visualizer
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
            this.glControl1 = new OpenTK.GLControl();
            this.trackBar_layers = new System.Windows.Forms.TrackBar();
            this.label_max = new System.Windows.Forms.Label();
            this.label_min = new System.Windows.Forms.Label();
            this.radioButton_Quad = new System.Windows.Forms.RadioButton();
            this.radioButton_Texture = new System.Windows.Forms.RadioButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.radioButton_QuadStrip = new System.Windows.Forms.RadioButton();
            this.trackBar_TFMin = new System.Windows.Forms.TrackBar();
            this.label_TFMin = new System.Windows.Forms.Label();
            this.label_TFMax = new System.Windows.Forms.Label();
            this.trackBar_TFHeight = new System.Windows.Forms.TrackBar();
            this.label_TFMinHeight = new System.Windows.Forms.Label();
            this.label_TFMaxHeight = new System.Windows.Forms.Label();
            this.label_TFHieghtCurrent = new System.Windows.Forms.Label();
            this.label_TFMinCurrent = new System.Windows.Forms.Label();
            this.label_LayerCurrent = new System.Windows.Forms.Label();
            this.label_TFMaxCurrent = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_layers)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_TFMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_TFHeight)).BeginInit();
            this.SuspendLayout();
            // 
            // glControl1
            // 
            this.glControl1.AutoSize = true;
            this.glControl1.BackColor = System.Drawing.Color.Black;
            this.glControl1.Location = new System.Drawing.Point(27, 41);
            this.glControl1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.glControl1.Name = "glControl1";
            this.glControl1.Size = new System.Drawing.Size(338, 343);
            this.glControl1.TabIndex = 3;
            this.glControl1.VSync = false;
            this.glControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.glControl1_Paint);
            // 
            // trackBar_layers
            // 
            this.trackBar_layers.Location = new System.Drawing.Point(27, 397);
            this.trackBar_layers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.trackBar_layers.Maximum = 50;
            this.trackBar_layers.Name = "trackBar_layers";
            this.trackBar_layers.Size = new System.Drawing.Size(338, 69);
            this.trackBar_layers.TabIndex = 5;
            this.trackBar_layers.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label_max
            // 
            this.label_max.AutoSize = true;
            this.label_max.Location = new System.Drawing.Point(338, 446);
            this.label_max.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_max.Name = "label_max";
            this.label_max.Size = new System.Drawing.Size(27, 20);
            this.label_max.TabIndex = 6;
            this.label_max.Text = "77";
            // 
            // label_min
            // 
            this.label_min.AutoSize = true;
            this.label_min.Location = new System.Drawing.Point(23, 446);
            this.label_min.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_min.Name = "label_min";
            this.label_min.Size = new System.Drawing.Size(18, 20);
            this.label_min.TabIndex = 7;
            this.label_min.Text = "0";
            // 
            // radioButton_Quad
            // 
            this.radioButton_Quad.AutoSize = true;
            this.radioButton_Quad.Checked = true;
            this.radioButton_Quad.Location = new System.Drawing.Point(447, 60);
            this.radioButton_Quad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButton_Quad.Name = "radioButton_Quad";
            this.radioButton_Quad.Size = new System.Drawing.Size(81, 24);
            this.radioButton_Quad.TabIndex = 8;
            this.radioButton_Quad.TabStop = true;
            this.radioButton_Quad.Text = "Quads";
            this.radioButton_Quad.UseVisualStyleBackColor = true;
            // 
            // radioButton_Texture
            // 
            this.radioButton_Texture.AutoSize = true;
            this.radioButton_Texture.Location = new System.Drawing.Point(674, 60);
            this.radioButton_Texture.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButton_Texture.Name = "radioButton_Texture";
            this.radioButton_Texture.Size = new System.Drawing.Size(87, 24);
            this.radioButton_Texture.TabIndex = 9;
            this.radioButton_Texture.TabStop = true;
            this.radioButton_Texture.Text = "Texture";
            this.radioButton_Texture.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(824, 33);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(94, 29);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // radioButton_QuadStrip
            // 
            this.radioButton_QuadStrip.AutoSize = true;
            this.radioButton_QuadStrip.Location = new System.Drawing.Point(548, 60);
            this.radioButton_QuadStrip.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButton_QuadStrip.Name = "radioButton_QuadStrip";
            this.radioButton_QuadStrip.Size = new System.Drawing.Size(106, 24);
            this.radioButton_QuadStrip.TabIndex = 11;
            this.radioButton_QuadStrip.TabStop = true;
            this.radioButton_QuadStrip.Text = "QuadStrip";
            this.radioButton_QuadStrip.UseVisualStyleBackColor = true;
            // 
            // trackBar_TFMin
            // 
            this.trackBar_TFMin.Location = new System.Drawing.Point(447, 126);
            this.trackBar_TFMin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.trackBar_TFMin.Maximum = 4000;
            this.trackBar_TFMin.Name = "trackBar_TFMin";
            this.trackBar_TFMin.Size = new System.Drawing.Size(314, 69);
            this.trackBar_TFMin.TabIndex = 12;
            this.trackBar_TFMin.Scroll += new System.EventHandler(this.trackBar_TFMin_Scroll);
            // 
            // label_TFMin
            // 
            this.label_TFMin.AutoSize = true;
            this.label_TFMin.Location = new System.Drawing.Point(443, 175);
            this.label_TFMin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_TFMin.Name = "label_TFMin";
            this.label_TFMin.Size = new System.Drawing.Size(18, 20);
            this.label_TFMin.TabIndex = 13;
            this.label_TFMin.Text = "0";
            // 
            // label_TFMax
            // 
            this.label_TFMax.AutoSize = true;
            this.label_TFMax.Location = new System.Drawing.Point(716, 166);
            this.label_TFMax.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_TFMax.Name = "label_TFMax";
            this.label_TFMax.Size = new System.Drawing.Size(45, 20);
            this.label_TFMax.TabIndex = 14;
            this.label_TFMax.Text = "4000";
            // 
            // trackBar_TFHeight
            // 
            this.trackBar_TFHeight.Location = new System.Drawing.Point(447, 258);
            this.trackBar_TFHeight.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.trackBar_TFHeight.Maximum = 4000;
            this.trackBar_TFHeight.Minimum = 1;
            this.trackBar_TFHeight.Name = "trackBar_TFHeight";
            this.trackBar_TFHeight.Size = new System.Drawing.Size(314, 69);
            this.trackBar_TFHeight.TabIndex = 15;
            this.trackBar_TFHeight.Value = 2000;
            this.trackBar_TFHeight.Scroll += new System.EventHandler(this.trackBar_TFHeight_Scroll);
            // 
            // label_TFMinHeight
            // 
            this.label_TFMinHeight.AutoSize = true;
            this.label_TFMinHeight.Location = new System.Drawing.Point(443, 307);
            this.label_TFMinHeight.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_TFMinHeight.Name = "label_TFMinHeight";
            this.label_TFMinHeight.Size = new System.Drawing.Size(18, 20);
            this.label_TFMinHeight.TabIndex = 16;
            this.label_TFMinHeight.Text = "0";
            // 
            // label_TFMaxHeight
            // 
            this.label_TFMaxHeight.AutoSize = true;
            this.label_TFMaxHeight.Location = new System.Drawing.Point(716, 307);
            this.label_TFMaxHeight.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_TFMaxHeight.Name = "label_TFMaxHeight";
            this.label_TFMaxHeight.Size = new System.Drawing.Size(45, 20);
            this.label_TFMaxHeight.TabIndex = 17;
            this.label_TFMaxHeight.Text = "4000";
            // 
            // label_TFHieghtCurrent
            // 
            this.label_TFHieghtCurrent.AutoSize = true;
            this.label_TFHieghtCurrent.Location = new System.Drawing.Point(443, 455);
            this.label_TFHieghtCurrent.Name = "label_TFHieghtCurrent";
            this.label_TFHieghtCurrent.Size = new System.Drawing.Size(188, 20);
            this.label_TFHieghtCurrent.TabIndex = 18;
            this.label_TFHieghtCurrent.Text = "Текущая ширина = 2000";
            // 
            // label_TFMinCurrent
            // 
            this.label_TFMinCurrent.AutoSize = true;
            this.label_TFMinCurrent.Location = new System.Drawing.Point(443, 360);
            this.label_TFMinCurrent.Name = "label_TFMinCurrent";
            this.label_TFMinCurrent.Size = new System.Drawing.Size(170, 20);
            this.label_TFMinCurrent.TabIndex = 19;
            this.label_TFMinCurrent.Text = "Текущий минимум = 0";
            // 
            // label_LayerCurrent
            // 
            this.label_LayerCurrent.AutoSize = true;
            this.label_LayerCurrent.Location = new System.Drawing.Point(99, 471);
            this.label_LayerCurrent.Name = "label_LayerCurrent";
            this.label_LayerCurrent.Size = new System.Drawing.Size(168, 20);
            this.label_LayerCurrent.TabIndex = 20;
            this.label_LayerCurrent.Text = "Текущий уровень = 0 ";
            // 
            // label_TFMaxCurrent
            // 
            this.label_TFMaxCurrent.AutoSize = true;
            this.label_TFMaxCurrent.Location = new System.Drawing.Point(443, 400);
            this.label_TFMaxCurrent.Name = "label_TFMaxCurrent";
            this.label_TFMaxCurrent.Size = new System.Drawing.Size(204, 20);
            this.label_TFMaxCurrent.TabIndex = 21;
            this.label_TFMaxCurrent.Text = "Текущий максимум = 2000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(443, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "Минимальное значение TF:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(443, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 20);
            this.label2.TabIndex = 23;
            this.label2.Text = "Ширина окна визуализации:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 538);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_TFMaxCurrent);
            this.Controls.Add(this.label_LayerCurrent);
            this.Controls.Add(this.label_TFMinCurrent);
            this.Controls.Add(this.label_TFHieghtCurrent);
            this.Controls.Add(this.label_TFMaxHeight);
            this.Controls.Add(this.label_TFMinHeight);
            this.Controls.Add(this.trackBar_TFHeight);
            this.Controls.Add(this.label_TFMax);
            this.Controls.Add(this.label_TFMin);
            this.Controls.Add(this.trackBar_TFMin);
            this.Controls.Add(this.radioButton_QuadStrip);
            this.Controls.Add(this.radioButton_Texture);
            this.Controls.Add(this.radioButton_Quad);
            this.Controls.Add(this.label_min);
            this.Controls.Add(this.label_max);
            this.Controls.Add(this.trackBar_layers);
            this.Controls.Add(this.glControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_layers)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_TFMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_TFHeight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private OpenTK.GLControl glControl1;
        private System.Windows.Forms.TrackBar trackBar_layers;
        private System.Windows.Forms.Label label_max;
        private System.Windows.Forms.Label label_min;
        private System.Windows.Forms.RadioButton radioButton_Quad;
        private System.Windows.Forms.RadioButton radioButton_Texture;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.RadioButton radioButton_QuadStrip;
        private System.Windows.Forms.TrackBar trackBar_TFMin;
        private System.Windows.Forms.Label label_TFMin;
        private System.Windows.Forms.Label label_TFMax;
        private System.Windows.Forms.TrackBar trackBar_TFHeight;
        private System.Windows.Forms.Label label_TFMinHeight;
        private System.Windows.Forms.Label label_TFMaxHeight;
        private System.Windows.Forms.Label label_TFHieghtCurrent;
        private System.Windows.Forms.Label label_TFMinCurrent;
        private System.Windows.Forms.Label label_LayerCurrent;
        private System.Windows.Forms.Label label_TFMaxCurrent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

