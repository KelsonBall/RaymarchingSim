using Kelson.Common.Vectors;
using ShaderSim;
using System;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;

namespace RaymarchingSim
{
    partial class Window
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

        public vec4[,] CreateFrame(IShader shader)
        {
            var runner = new SynchronousCpuShaderRunner(UI_Display.Width - 3, UI_Display.Height - 3);            
            return runner.ToBuffer(shader);            
        }

        public void LoadBitmap(Bitmap image)
        {
            Invoke((Action)(() => UI_Display.Image = image));       
        }

        ConcurrentQueue<vec4[,]> frames_queue = new ConcurrentQueue<vec4[,]>();
        Bitmap front_map = null;
        Bitmap back_map = null;

        AutoResetEvent frame_ready = new AutoResetEvent(false);        

        public Func<IShader> ShaderSource { get; set; }

        int run_width;
        int run_height;

        private void UI_NextButton_Click(object sender, EventArgs e)
        {
            run_width = UI_Display.Width;
            run_height = UI_Display.Height;
            front_map = new Bitmap(run_width, run_height);
            back_map = new Bitmap(run_width, run_height);
            //Task.Factory.StartNew(GenerateFrames);
            //Task.Factory.StartNew(ApplyFrames);
            new SynchronousCpuShaderRunner(run_width, run_height)
                        .LoadBitmap(ShaderSource(), ref back_map);
            UI_Display.Image = back_map;
        }
        
        private void GenerateFrames()
        {
            while (true)
            {
                Console.WriteLine(frames_queue.Count);
                if (frames_queue.Count > 5)
                {
                    Thread.Sleep(50);
                    continue;
                }
                
                frames_queue.Enqueue(
                    new SynchronousCpuShaderRunner(run_width, run_height)
                        .ToBuffer(ShaderSource()));
            }
        }

        private void ApplyFrames()
        {
            var swapped = new AutoResetEvent(false);
            while (true)
            {
                //if (frames_queue.TryDequeue(out vec4[,] buffer))
                //{
                    new SynchronousCpuShaderRunner(run_width, run_height)
                        .LoadBitmap(ShaderSource(), ref back_map);
                    Invoke((Action)(() =>
                    {
                        var temp = front_map;
                        UI_Display.Image = back_map;
                        front_map = back_map;
                        back_map = temp;
                        swapped.Set();

                    }));
                    swapped.WaitOne();
                //}
                //else
                //    Thread.Sleep(50);
            }
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.UI_NextButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.UI_Display = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UI_Display)).BeginInit();
            this.SuspendLayout();
            // 
            // UI_NextButton
            // 
            this.UI_NextButton.Location = new System.Drawing.Point(3, 3);
            this.UI_NextButton.Name = "UI_NextButton";
            this.UI_NextButton.Size = new System.Drawing.Size(37, 23);
            this.UI_NextButton.TabIndex = 0;
            this.UI_NextButton.Text = "Play";
            this.UI_NextButton.UseVisualStyleBackColor = true;
            this.UI_NextButton.Click += new System.EventHandler(this.UI_NextButton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.UI_NextButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.UI_Display, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(234, 161);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // UI_Display
            // 
            this.UI_Display.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UI_Display.Location = new System.Drawing.Point(53, 3);
            this.UI_Display.Name = "UI_Display";
            this.UI_Display.Size = new System.Drawing.Size(178, 155);
            this.UI_Display.TabIndex = 1;
            this.UI_Display.TabStop = false;
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 161);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Window";
            this.Text = "Raymarch";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.UI_Display)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button UI_NextButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox UI_Display;
    }
}

