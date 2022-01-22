namespace PanelTitlebarExample
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
            this.panelEx1 = new PanelTitlebarExample.PanelEx();
            this.panelEx2 = new PanelTitlebarExample.PanelEx();
            this.panelEx3 = new PanelTitlebarExample.PanelEx();
            this.panelEx4 = new PanelTitlebarExample.PanelEx();
            this.panelEx5 = new PanelTitlebarExample.PanelEx();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.AutoScroll = true;
            this.panelEx1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelEx1.Location = new System.Drawing.Point(19, 19);
            this.panelEx1.Margin = new System.Windows.Forms.Padding(10);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(385, 243);
            this.panelEx1.TabIndex = 0;
            this.panelEx1.Text = "Panel Title";
            this.panelEx1.TitlebarBackColor = System.Drawing.Color.DodgerBlue;
            this.panelEx1.TitlebarTextPadding = new System.Windows.Forms.Padding(10);
            this.panelEx1.Paint += new System.Windows.Forms.PaintEventHandler(this.panelEx1_Paint);
            // 
            // panelEx2
            // 
            this.panelEx2.AutoScroll = true;
            this.panelEx2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelEx2.Location = new System.Drawing.Point(19, 268);
            this.panelEx2.Margin = new System.Windows.Forms.Padding(10);
            this.panelEx2.Name = "panelEx2";
            this.panelEx2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panelEx2.Size = new System.Drawing.Size(385, 243);
            this.panelEx2.TabIndex = 0;
            this.panelEx2.Text = "عنوان پنل - Right to left";
            this.panelEx2.TitlebarBackColor = System.Drawing.Color.MediumSeaGreen;
            this.panelEx2.TitlebarTextPadding = new System.Windows.Forms.Padding(10);
            this.panelEx2.Paint += new System.Windows.Forms.PaintEventHandler(this.panelEx1_Paint);
            // 
            // panelEx3
            // 
            this.panelEx3.AutoScroll = true;
            this.panelEx3.AutoScrollMinSize = new System.Drawing.Size(500, 500);
            this.panelEx3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelEx3.Location = new System.Drawing.Point(411, 19);
            this.panelEx3.Margin = new System.Windows.Forms.Padding(10);
            this.panelEx3.Name = "panelEx3";
            this.panelEx3.Size = new System.Drawing.Size(385, 243);
            this.panelEx3.TabIndex = 0;
            this.panelEx3.Text = "Panel Title";
            this.panelEx3.TitlebarBackColor = System.Drawing.Color.MediumPurple;
            this.panelEx3.TitlebarTextPadding = new System.Windows.Forms.Padding(10);
            this.panelEx3.Paint += new System.Windows.Forms.PaintEventHandler(this.panelEx1_Paint);
            // 
            // panelEx4
            // 
            this.panelEx4.AutoScroll = true;
            this.panelEx4.AutoScrollMinSize = new System.Drawing.Size(500, 500);
            this.panelEx4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelEx4.Location = new System.Drawing.Point(411, 268);
            this.panelEx4.Margin = new System.Windows.Forms.Padding(10);
            this.panelEx4.Name = "panelEx4";
            this.panelEx4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panelEx4.Size = new System.Drawing.Size(385, 243);
            this.panelEx4.TabIndex = 1;
            this.panelEx4.Text = "عنوان پنل - Right to left";
            this.panelEx4.TitlebarBackColor = System.Drawing.Color.Chocolate;
            this.panelEx4.TitlebarForeColor = System.Drawing.Color.Black;
            this.panelEx4.TitlebarTextPadding = new System.Windows.Forms.Padding(10);
            // 
            // panelEx5
            // 
            this.panelEx5.AutoScroll = true;
            this.panelEx5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelEx5.Location = new System.Drawing.Point(19, 520);
            this.panelEx5.Margin = new System.Windows.Forms.Padding(10);
            this.panelEx5.Name = "panelEx5";
            this.panelEx5.Size = new System.Drawing.Size(777, 210);
            this.panelEx5.TabIndex = 1;
            this.panelEx5.Text = "Panel Title";
            this.panelEx5.TitlebarFont = new System.Drawing.Font("Segoe UI", 15.9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.panelEx5.TitlebarTextPadding = new System.Windows.Forms.Padding(10);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 749);
            this.Controls.Add(this.panelEx5);
            this.Controls.Add(this.panelEx4);
            this.Controls.Add(this.panelEx2);
            this.Controls.Add(this.panelEx3);
            this.Controls.Add(this.panelEx1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private PanelEx panelEx1;
        private PanelEx panelEx2;
        private PanelEx panelEx3;
        private PanelEx panelEx4;
        private PanelEx panelEx5;
    }
}