namespace knockoutDarts
{
    partial class showPlayer
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Lname = new System.Windows.Forms.Label();
            this.Lpoints = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Lname
            // 
            this.Lname.AutoSize = true;
            this.Lname.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Lname.Location = new System.Drawing.Point(15, 31);
            this.Lname.Name = "Lname";
            this.Lname.Size = new System.Drawing.Size(93, 33);
            this.Lname.TabIndex = 0;
            this.Lname.Text = "label1";
            // 
            // Lpoints
            // 
            this.Lpoints.AutoSize = true;
            this.Lpoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Lpoints.Location = new System.Drawing.Point(144, 31);
            this.Lpoints.Name = "Lpoints";
            this.Lpoints.Size = new System.Drawing.Size(93, 33);
            this.Lpoints.TabIndex = 1;
            this.Lpoints.Text = "label1";
            // 
            // showPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.Lpoints);
            this.Controls.Add(this.Lname);
            this.Name = "showPlayer";
            this.Size = new System.Drawing.Size(238, 270);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lname;
        private System.Windows.Forms.Label Lpoints;
    }
}
