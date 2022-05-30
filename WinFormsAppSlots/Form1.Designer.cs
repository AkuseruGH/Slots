namespace WinFormsAppSlots
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button_play = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.a_box = new System.Windows.Forms.PictureBox();
            this.b_box = new System.Windows.Forms.PictureBox();
            this.c_box = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.a_box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.b_box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c_box)).BeginInit();
            this.SuspendLayout();
            // 
            // button_play
            // 
            this.button_play.BackColor = System.Drawing.Color.Transparent;
            this.button_play.ForeColor = System.Drawing.Color.DimGray;
            this.button_play.Image = global::WinFormsAppSlots.Properties.Resources.slots_button;
            this.button_play.Location = new System.Drawing.Point(676, 80);
            this.button_play.Name = "button_play";
            this.button_play.Size = new System.Drawing.Size(105, 349);
            this.button_play.TabIndex = 0;
            this.button_play.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_play.UseVisualStyleBackColor = false;
            this.button_play.Click += new System.EventHandler(this.button_play_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // a_box
            // 
            this.a_box.BackColor = System.Drawing.Color.White;
            this.a_box.Location = new System.Drawing.Point(75, 190);
            this.a_box.Name = "a_box";
            this.a_box.Size = new System.Drawing.Size(120, 120);
            this.a_box.TabIndex = 1;
            this.a_box.TabStop = false;
            // 
            // b_box
            // 
            this.b_box.BackColor = System.Drawing.Color.White;
            this.b_box.Location = new System.Drawing.Point(296, 190);
            this.b_box.Name = "b_box";
            this.b_box.Size = new System.Drawing.Size(120, 120);
            this.b_box.TabIndex = 1;
            this.b_box.TabStop = false;
            // 
            // c_box
            // 
            this.c_box.BackColor = System.Drawing.Color.White;
            this.c_box.Location = new System.Drawing.Point(513, 190);
            this.c_box.Name = "c_box";
            this.c_box.Size = new System.Drawing.Size(120, 120);
            this.c_box.TabIndex = 1;
            this.c_box.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(834, 511);
            this.Controls.Add(this.c_box);
            this.Controls.Add(this.b_box);
            this.Controls.Add(this.a_box);
            this.Controls.Add(this.button_play);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.LavenderBlush;
            ((System.ComponentModel.ISupportInitialize)(this.a_box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.b_box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c_box)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button button_play;
        private ImageList imageList1;
        private System.Windows.Forms.Timer timer1;
        private PictureBox a_box;
        private PictureBox b_box;
        private PictureBox c_box;
    }
}