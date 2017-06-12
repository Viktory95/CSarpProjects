namespace Рисовалка
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.ellipse = new System.Windows.Forms.Button();
            this.rectangle = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.step_forward = new System.Windows.Forms.Button();
            this.step_back = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.open = new System.Windows.Forms.Button();
            this.New = new System.Windows.Forms.Button();
            this.eraser = new System.Windows.Forms.Button();
            this.brush = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ellipse
            // 
            this.ellipse.Location = new System.Drawing.Point(782, 179);
            this.ellipse.Name = "ellipse";
            this.ellipse.Size = new System.Drawing.Size(108, 23);
            this.ellipse.TabIndex = 2;
            this.ellipse.Text = "Эллипс";
            this.ellipse.UseVisualStyleBackColor = true;
            this.ellipse.Click += new System.EventHandler(this.ellipse_Click);
            // 
            // rectangle
            // 
            this.rectangle.Location = new System.Drawing.Point(782, 150);
            this.rectangle.Name = "rectangle";
            this.rectangle.Size = new System.Drawing.Size(108, 23);
            this.rectangle.TabIndex = 3;
            this.rectangle.Text = "Прямоугольник";
            this.rectangle.UseVisualStyleBackColor = true;
            this.rectangle.Click += new System.EventHandler(this.rectangle_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(863, 68);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 10;
            this.textBox1.Text = "Толщина кисти";
            this.textBox1.Click += new System.EventHandler(this.textBox1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(863, 124);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 11;
            this.textBox2.Text = "Толщина ластика";
            this.textBox2.Click += new System.EventHandler(this.textBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Рисовалка.Properties.Resources.cercle_de_couleurs_02;
            this.pictureBox2.Location = new System.Drawing.Point(782, 208);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(201, 199);
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseClick);
            // 
            // step_forward
            // 
            this.step_forward.Image = global::Рисовалка.Properties.Resources.arrow_2_;
            this.step_forward.Location = new System.Drawing.Point(578, 0);
            this.step_forward.Name = "step_forward";
            this.step_forward.Size = new System.Drawing.Size(36, 33);
            this.step_forward.TabIndex = 9;
            this.step_forward.UseVisualStyleBackColor = true;
            this.step_forward.Click += new System.EventHandler(this.step_forward_Click);
            // 
            // step_back
            // 
            this.step_back.Image = global::Рисовалка.Properties.Resources.arrow_3_;
            this.step_back.Location = new System.Drawing.Point(481, 0);
            this.step_back.Name = "step_back";
            this.step_back.Size = new System.Drawing.Size(36, 33);
            this.step_back.TabIndex = 8;
            this.step_back.UseVisualStyleBackColor = true;
            this.step_back.Click += new System.EventHandler(this.step_back_Click);
            // 
            // save
            // 
            this.save.Image = global::Рисовалка.Properties.Resources.sketch;
            this.save.Location = new System.Drawing.Point(375, 0);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(36, 33);
            this.save.TabIndex = 7;
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // open
            // 
            this.open.Image = global::Рисовалка.Properties.Resources.folder;
            this.open.Location = new System.Drawing.Point(271, 0);
            this.open.Name = "open";
            this.open.Size = new System.Drawing.Size(36, 33);
            this.open.TabIndex = 6;
            this.open.UseVisualStyleBackColor = true;
            this.open.Click += new System.EventHandler(this.open_Click);
            // 
            // New
            // 
            this.New.Image = global::Рисовалка.Properties.Resources.canvas1;
            this.New.Location = new System.Drawing.Point(163, 0);
            this.New.Name = "New";
            this.New.Size = new System.Drawing.Size(36, 33);
            this.New.TabIndex = 5;
            this.New.UseVisualStyleBackColor = true;
            this.New.Click += new System.EventHandler(this.New_Click);
            // 
            // eraser
            // 
            this.eraser.Image = global::Рисовалка.Properties.Resources.eraser2;
            this.eraser.Location = new System.Drawing.Point(782, 95);
            this.eraser.Name = "eraser";
            this.eraser.Size = new System.Drawing.Size(45, 49);
            this.eraser.TabIndex = 4;
            this.eraser.UseVisualStyleBackColor = true;
            this.eraser.Click += new System.EventHandler(this.eraser_Click);
            // 
            // brush
            // 
            this.brush.Image = global::Рисовалка.Properties.Resources.brush1;
            this.brush.Location = new System.Drawing.Point(782, 39);
            this.brush.Name = "brush";
            this.brush.Size = new System.Drawing.Size(45, 49);
            this.brush.TabIndex = 1;
            this.brush.UseVisualStyleBackColor = true;
            this.brush.Click += new System.EventHandler(this.brush_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(1, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(775, 521);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.step_forward);
            this.Controls.Add(this.step_back);
            this.Controls.Add(this.save);
            this.Controls.Add(this.open);
            this.Controls.Add(this.New);
            this.Controls.Add(this.eraser);
            this.Controls.Add(this.rectangle);
            this.Controls.Add(this.ellipse);
            this.Controls.Add(this.brush);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button brush;
        private System.Windows.Forms.Button ellipse;
        private System.Windows.Forms.Button rectangle;
        private System.Windows.Forms.Button eraser;
        private System.Windows.Forms.Button New;
        private System.Windows.Forms.Button open;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button step_back;
        private System.Windows.Forms.Button step_forward;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

