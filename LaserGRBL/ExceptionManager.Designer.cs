namespace LaserGRBL
{
	partial class ExceptionManager
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExceptionManager));
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.TbExMessage = new System.Windows.Forms.RichTextBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.LblFormDescription = new System.Windows.Forms.RichTextBox();
			this.LblOOPS = new System.Windows.Forms.Label();
			this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.BtnContinue = new System.Windows.Forms.Button();
			this.BtnAbort = new System.Windows.Forms.Button();
			this.tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.tableLayoutPanel2.SuspendLayout();
			this.tableLayoutPanel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.25F));
			this.tableLayoutPanel1.Controls.Add(this.TbExMessage, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 2);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 3;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 76.22222F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(857, 543);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// TbExMessage
			// 
			this.TbExMessage.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.tableLayoutPanel1.SetColumnSpan(this.TbExMessage, 2);
			this.TbExMessage.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TbExMessage.ForeColor = System.Drawing.SystemColors.WindowText;
			this.TbExMessage.Location = new System.Drawing.Point(4, 135);
			this.TbExMessage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.TbExMessage.Name = "TbExMessage";
			this.TbExMessage.ReadOnly = true;
			this.TbExMessage.Size = new System.Drawing.Size(849, 336);
			this.TbExMessage.TabIndex = 5;
			this.TbExMessage.Text = "";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(4, 15);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(114, 100);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.AutoSize = true;
			this.tableLayoutPanel2.ColumnCount = 1;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel2.Controls.Add(this.LblFormDescription, 0, 1);
			this.tableLayoutPanel2.Controls.Add(this.LblOOPS, 0, 0);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(126, 4);
			this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 2;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(727, 123);
			this.tableLayoutPanel2.TabIndex = 3;
			// 
			// LblFormDescription
			// 
			this.LblFormDescription.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.LblFormDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.LblFormDescription.Dock = System.Windows.Forms.DockStyle.Fill;
			this.LblFormDescription.Location = new System.Drawing.Point(4, 43);
			this.LblFormDescription.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.LblFormDescription.Name = "LblFormDescription";
			this.LblFormDescription.ReadOnly = true;
			this.LblFormDescription.Size = new System.Drawing.Size(719, 76);
			this.LblFormDescription.TabIndex = 3;
			this.LblFormDescription.Text = resources.GetString("LblFormDescription.Text");
			this.LblFormDescription.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.LblFormDescription_LinkClicked);
			// 
			// LblOOPS
			// 
			this.LblOOPS.AutoSize = true;
			this.LblOOPS.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LblOOPS.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.LblOOPS.Location = new System.Drawing.Point(7, 6);
			this.LblOOPS.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
			this.LblOOPS.Name = "LblOOPS";
			this.LblOOPS.Size = new System.Drawing.Size(345, 27);
			this.LblOOPS.TabIndex = 0;
			this.LblOOPS.Text = "Ooops! Something went wrong";
			// 
			// tableLayoutPanel3
			// 
			this.tableLayoutPanel3.AutoSize = true;
			this.tableLayoutPanel3.ColumnCount = 3;
			this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel3, 2);
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel3.Controls.Add(this.BtnContinue, 2, 0);
			this.tableLayoutPanel3.Controls.Add(this.BtnAbort, 1, 0);
			this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel3.Location = new System.Drawing.Point(4, 479);
			this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.tableLayoutPanel3.Name = "tableLayoutPanel3";
			this.tableLayoutPanel3.RowCount = 1;
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel3.Size = new System.Drawing.Size(849, 60);
			this.tableLayoutPanel3.TabIndex = 4;
			// 
			// BtnContinue
			// 
			this.BtnContinue.Image = ((System.Drawing.Image)(resources.GetObject("BtnContinue.Image")));
			this.BtnContinue.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.BtnContinue.Location = new System.Drawing.Point(702, 4);
			this.BtnContinue.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.BtnContinue.Name = "BtnContinue";
			this.BtnContinue.Size = new System.Drawing.Size(143, 52);
			this.BtnContinue.TabIndex = 16;
			this.BtnContinue.Text = " Continue";
			this.BtnContinue.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.BtnContinue.UseVisualStyleBackColor = true;
			this.BtnContinue.Click += new System.EventHandler(this.BtnContinue_Click);
			// 
			// BtnAbort
			// 
			this.BtnAbort.Image = ((System.Drawing.Image)(resources.GetObject("BtnAbort.Image")));
			this.BtnAbort.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.BtnAbort.Location = new System.Drawing.Point(551, 4);
			this.BtnAbort.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.BtnAbort.Name = "BtnAbort";
			this.BtnAbort.Size = new System.Drawing.Size(143, 52);
			this.BtnAbort.TabIndex = 14;
			this.BtnAbort.Text = "Abort";
			this.BtnAbort.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.BtnAbort.UseVisualStyleBackColor = true;
			this.BtnAbort.Click += new System.EventHandler(this.BtnAbort_Click);
			// 
			// ExceptionManager
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.ClientSize = new System.Drawing.Size(857, 543);
			this.Controls.Add(this.tableLayoutPanel1);
			this.ForeColor = System.Drawing.SystemColors.WindowText;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "ExceptionManager";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Exception Manager";
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel2.PerformLayout();
			this.tableLayoutPanel3.ResumeLayout(false);
			this.ResumeLayout(false);
		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.Label LblOOPS;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
		private System.Windows.Forms.Button BtnAbort;
		private System.Windows.Forms.Button BtnContinue;
		private System.Windows.Forms.RichTextBox LblFormDescription;
		private System.Windows.Forms.RichTextBox TbExMessage;
	}
}