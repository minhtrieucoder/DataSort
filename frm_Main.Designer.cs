
namespace CuoiKy_ProjectSort
{
    partial class frm_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Main));
            this.btn_export = new System.Windows.Forms.Button();
            this.btn_sort = new System.Windows.Forms.Button();
            this.tbx_output = new System.Windows.Forms.TextBox();
            this.tbx_input = new System.Windows.Forms.TextBox();
            this.lb_output = new System.Windows.Forms.Label();
            this.lb_input = new System.Windows.Forms.Label();
            this.lb_name = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_export
            // 
            this.btn_export.BackColor = System.Drawing.Color.Snow;
            this.btn_export.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_export.Font = new System.Drawing.Font("Comic Sans MS", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btn_export.ForeColor = System.Drawing.Color.Red;
            this.btn_export.Location = new System.Drawing.Point(859, 387);
            this.btn_export.Name = "btn_export";
            this.btn_export.Size = new System.Drawing.Size(147, 174);
            this.btn_export.TabIndex = 11;
            this.btn_export.Text = "Export file and down";
            this.btn_export.UseVisualStyleBackColor = false;
            this.btn_export.Click += new System.EventHandler(this.btn_export_Click);
            // 
            // btn_sort
            // 
            this.btn_sort.BackColor = System.Drawing.Color.Snow;
            this.btn_sort.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_sort.Font = new System.Drawing.Font("Comic Sans MS", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btn_sort.ForeColor = System.Drawing.Color.Red;
            this.btn_sort.Location = new System.Drawing.Point(859, 250);
            this.btn_sort.Name = "btn_sort";
            this.btn_sort.Size = new System.Drawing.Size(147, 59);
            this.btn_sort.TabIndex = 10;
            this.btn_sort.Text = "Sort";
            this.btn_sort.UseVisualStyleBackColor = false;
            this.btn_sort.Click += new System.EventHandler(this.btn_sort_Click);
            // 
            // tbx_output
            // 
            this.tbx_output.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_output.Location = new System.Drawing.Point(252, 259);
            this.tbx_output.Multiline = true;
            this.tbx_output.Name = "tbx_output";
            this.tbx_output.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbx_output.Size = new System.Drawing.Size(512, 434);
            this.tbx_output.TabIndex = 9;
            // 
            // tbx_input
            // 
            this.tbx_input.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_input.Location = new System.Drawing.Point(252, 184);
            this.tbx_input.Multiline = true;
            this.tbx_input.Name = "tbx_input";
            this.tbx_input.Size = new System.Drawing.Size(512, 43);
            this.tbx_input.TabIndex = 8;
            // 
            // lb_output
            // 
            this.lb_output.BackColor = System.Drawing.Color.Transparent;
            this.lb_output.Font = new System.Drawing.Font("Comic Sans MS", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_output.ForeColor = System.Drawing.Color.Black;
            this.lb_output.Location = new System.Drawing.Point(71, 259);
            this.lb_output.Name = "lb_output";
            this.lb_output.Size = new System.Drawing.Size(175, 44);
            this.lb_output.TabIndex = 7;
            this.lb_output.Text = "Output:";
            // 
            // lb_input
            // 
            this.lb_input.BackColor = System.Drawing.Color.Transparent;
            this.lb_input.Font = new System.Drawing.Font("Comic Sans MS", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_input.ForeColor = System.Drawing.Color.Black;
            this.lb_input.Location = new System.Drawing.Point(98, 183);
            this.lb_input.Name = "lb_input";
            this.lb_input.Size = new System.Drawing.Size(148, 44);
            this.lb_input.TabIndex = 6;
            this.lb_input.Text = "Input:";
            // 
            // lb_name
            // 
            this.lb_name.BackColor = System.Drawing.Color.Transparent;
            this.lb_name.Font = new System.Drawing.Font("Comic Sans MS", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_name.ForeColor = System.Drawing.Color.OliveDrab;
            this.lb_name.Location = new System.Drawing.Point(240, 93);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(520, 69);
            this.lb_name.TabIndex = 13;
            this.lb_name.Text = "Thuat toan sap xep";
            this.lb_name.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1096, 789);
            this.Controls.Add(this.lb_name);
            this.Controls.Add(this.btn_export);
            this.Controls.Add(this.btn_sort);
            this.Controls.Add(this.tbx_output);
            this.Controls.Add(this.tbx_input);
            this.Controls.Add(this.lb_output);
            this.Controls.Add(this.lb_input);
            this.DoubleBuffered = true;
            this.Name = "frm_Main";
            this.Text = "frm_Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_export;
        private System.Windows.Forms.Button btn_sort;
        private System.Windows.Forms.TextBox tbx_output;
        private System.Windows.Forms.TextBox tbx_input;
        private System.Windows.Forms.Label lb_output;
        private System.Windows.Forms.Label lb_input;
        private System.Windows.Forms.Label lb_name;
    }
}