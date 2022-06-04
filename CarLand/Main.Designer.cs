namespace CarLand
{
    partial class Main
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
            this.listViewOfCars = new System.Windows.Forms.ListView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.TakeOrder = new System.Windows.Forms.Button();
            this.LIKE = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.PictureBox();
            this.PersonalOffice = new System.Windows.Forms.PictureBox();
            this.ClearListOfCarsThatLikes = new System.Windows.Forms.Button();
            this.ShowAllCars = new System.Windows.Forms.Button();
            this.CarsThatLikes = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SaveLikeList = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PersonalOffice)).BeginInit();
            this.SuspendLayout();
            // 
            // listViewOfCars
            // 
            this.listViewOfCars.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.listViewOfCars.Cursor = System.Windows.Forms.Cursors.Default;
            this.listViewOfCars.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listViewOfCars.HideSelection = false;
            this.listViewOfCars.Location = new System.Drawing.Point(12, 53);
            this.listViewOfCars.Name = "listViewOfCars";
            this.listViewOfCars.Size = new System.Drawing.Size(514, 548);
            this.listViewOfCars.TabIndex = 0;
            this.listViewOfCars.UseCompatibleStateImageBehavior = false;
            this.listViewOfCars.View = System.Windows.Forms.View.List;
            this.listViewOfCars.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(906, 403);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(346, 198);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(906, 359);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(346, 38);
            this.textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox3.Location = new System.Drawing.Point(906, 289);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(346, 62);
            this.textBox3.TabIndex = 3;
            // 
            // TakeOrder
            // 
            this.TakeOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.TakeOrder.Location = new System.Drawing.Point(1015, 607);
            this.TakeOrder.Name = "TakeOrder";
            this.TakeOrder.Size = new System.Drawing.Size(154, 45);
            this.TakeOrder.TabIndex = 5;
            this.TakeOrder.Text = "ЗАМОВИТИ";
            this.TakeOrder.UseVisualStyleBackColor = false;
            this.TakeOrder.Click += new System.EventHandler(this.TakeOrder_Click);
            // 
            // LIKE
            // 
            this.LIKE.BackColor = System.Drawing.Color.BlueViolet;
            this.LIKE.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LIKE.ForeColor = System.Drawing.Color.Black;
            this.LIKE.Location = new System.Drawing.Point(12, 611);
            this.LIKE.Name = "LIKE";
            this.LIKE.Size = new System.Drawing.Size(69, 45);
            this.LIKE.TabIndex = 6;
            this.LIKE.Text = "LIKE!";
            this.LIKE.UseVisualStyleBackColor = false;
            this.LIKE.Click += new System.EventHandler(this.LIKE_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.Transparent;
            this.Exit.Image = global::CarLand.Properties.Resources.black_circle_close_button_png_5;
            this.Exit.Location = new System.Drawing.Point(1217, 2);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(35, 35);
            this.Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Exit.TabIndex = 7;
            this.Exit.TabStop = false;
            this.Exit.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // PersonalOffice
            // 
            this.PersonalOffice.BackColor = System.Drawing.Color.Transparent;
            this.PersonalOffice.Image = global::CarLand.Properties.Resources.Account_Logo;
            this.PersonalOffice.Location = new System.Drawing.Point(1136, -13);
            this.PersonalOffice.Name = "PersonalOffice";
            this.PersonalOffice.Size = new System.Drawing.Size(75, 66);
            this.PersonalOffice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PersonalOffice.TabIndex = 8;
            this.PersonalOffice.TabStop = false;
            this.PersonalOffice.Click += new System.EventHandler(this.PersonalOffice_Click);
            // 
            // ClearListOfCarsThatLikes
            // 
            this.ClearListOfCarsThatLikes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ClearListOfCarsThatLikes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClearListOfCarsThatLikes.ForeColor = System.Drawing.Color.White;
            this.ClearListOfCarsThatLikes.Location = new System.Drawing.Point(197, 611);
            this.ClearListOfCarsThatLikes.Name = "ClearListOfCarsThatLikes";
            this.ClearListOfCarsThatLikes.Size = new System.Drawing.Size(108, 45);
            this.ClearListOfCarsThatLikes.TabIndex = 9;
            this.ClearListOfCarsThatLikes.Text = "Скинути список \"LIKE\"";
            this.ClearListOfCarsThatLikes.UseVisualStyleBackColor = false;
            this.ClearListOfCarsThatLikes.Click += new System.EventHandler(this.ClearListOfCarsThatLikes_Click);
            // 
            // ShowAllCars
            // 
            this.ShowAllCars.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ShowAllCars.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShowAllCars.ForeColor = System.Drawing.Color.Black;
            this.ShowAllCars.Location = new System.Drawing.Point(438, 611);
            this.ShowAllCars.Name = "ShowAllCars";
            this.ShowAllCars.Size = new System.Drawing.Size(78, 45);
            this.ShowAllCars.TabIndex = 10;
            this.ShowAllCars.Text = "Всі автомобілі";
            this.ShowAllCars.UseVisualStyleBackColor = false;
            this.ShowAllCars.Click += new System.EventHandler(this.ShowAllCars_Click);
            // 
            // CarsThatLikes
            // 
            this.CarsThatLikes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.CarsThatLikes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CarsThatLikes.ForeColor = System.Drawing.Color.Black;
            this.CarsThatLikes.Location = new System.Drawing.Point(83, 611);
            this.CarsThatLikes.Name = "CarsThatLikes";
            this.CarsThatLikes.Size = new System.Drawing.Size(108, 45);
            this.CarsThatLikes.TabIndex = 11;
            this.CarsThatLikes.Text = "Авто, які сподобалися";
            this.CarsThatLikes.UseVisualStyleBackColor = false;
            this.CarsThatLikes.Click += new System.EventHandler(this.CarsThatLikes_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Bisque;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(977, 655);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Для замовлення, оберіть автомобіль!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Bisque;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(9, 659);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Для Like, оберіть автомобіль";
            // 
            // SaveLikeList
            // 
            this.SaveLikeList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.SaveLikeList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveLikeList.ForeColor = System.Drawing.Color.Black;
            this.SaveLikeList.Location = new System.Drawing.Point(311, 611);
            this.SaveLikeList.Name = "SaveLikeList";
            this.SaveLikeList.Size = new System.Drawing.Size(108, 45);
            this.SaveLikeList.TabIndex = 14;
            this.SaveLikeList.Text = "Зберегти LIKE у файл";
            this.SaveLikeList.UseVisualStyleBackColor = false;
            this.SaveLikeList.Click += new System.EventHandler(this.SaveLikeList_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CarLand.Properties.Resources.LogoMain1;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.SaveLikeList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CarsThatLikes);
            this.Controls.Add(this.ShowAllCars);
            this.Controls.Add(this.ClearListOfCarsThatLikes);
            this.Controls.Add(this.PersonalOffice);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.LIKE);
            this.Controls.Add(this.TakeOrder);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listViewOfCars);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Main";
            this.Text = "Main";
            ((System.ComponentModel.ISupportInitialize)(this.Exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PersonalOffice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewOfCars;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button TakeOrder;
        private System.Windows.Forms.Button LIKE;
        private System.Windows.Forms.PictureBox Exit;
        private System.Windows.Forms.PictureBox PersonalOffice;
        private System.Windows.Forms.Button ClearListOfCarsThatLikes;
        private System.Windows.Forms.Button ShowAllCars;
        private System.Windows.Forms.Button CarsThatLikes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SaveLikeList;
    }
}