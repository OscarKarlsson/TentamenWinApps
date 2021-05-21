
namespace FrontEndGUI
{
    partial class RemoveBooking
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.eventId = new System.Windows.Forms.ColumnHeader();
            this.movie = new System.Windows.Forms.ColumnHeader();
            this.startTime = new System.Windows.Forms.ColumnHeader();
            this.seatId = new System.Windows.Forms.ColumnHeader();
            this.BtnRemove = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.eventId,
            this.movie,
            this.startTime,
            this.seatId});
            this.listView1.ForeColor = System.Drawing.Color.Gainsboro;
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(64, 57);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(662, 360);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // eventId
            // 
            this.eventId.Text = "Event";
            this.eventId.Width = 80;
            // 
            // movie
            // 
            this.movie.Text = "Movie";
            this.movie.Width = 250;
            // 
            // startTime
            // 
            this.startTime.Text = "Start time";
            this.startTime.Width = 250;
            // 
            // seatId
            // 
            this.seatId.Text = "Seat";
            // 
            // BtnRemove
            // 
            this.BtnRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.BtnRemove.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRemove.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtnRemove.Location = new System.Drawing.Point(166, 475);
            this.BtnRemove.Name = "BtnRemove";
            this.BtnRemove.Size = new System.Drawing.Size(156, 79);
            this.BtnRemove.TabIndex = 2;
            this.BtnRemove.Text = "Cancel";
            this.BtnRemove.UseVisualStyleBackColor = false;
            this.BtnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Gainsboro;
            this.button1.Location = new System.Drawing.Point(449, 475);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 79);
            this.button1.TabIndex = 3;
            this.button1.Text = "Remove selected";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RemoveBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(803, 610);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnRemove);
            this.Controls.Add(this.listView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RemoveBooking";
            this.Text = "RemoveBooking";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader movie;
        private System.Windows.Forms.ColumnHeader startTime;
        private System.Windows.Forms.ColumnHeader seatId;
        private System.Windows.Forms.Button BtnRemove;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ColumnHeader eventId;
    }
}