
namespace CuoiKy_ProjectSort
{
    partial class frm_interchange
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
            this.lb_inputInterchange = new System.Windows.Forms.Label();
            this.lb_outputInterchange = new System.Windows.Forms.Label();
            this.tbx_inputInterchange = new System.Windows.Forms.TextBox();
            this.tbx_outputInterchange = new System.Windows.Forms.TextBox();
            this.btn_sortInterchange = new System.Windows.Forms.Button();
            this.btn_exportInterchange = new System.Windows.Forms.Button();
            this.tbx_countNumber = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lb_inputInterchange
            // 
            this.lb_inputInterchange.Font = new System.Drawing.Font("Comic Sans MS", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_inputInterchange.Location = new System.Drawing.Point(148, 65);
            this.lb_inputInterchange.Name = "lb_inputInterchange";
            this.lb_inputInterchange.Size = new System.Drawing.Size(118, 44);
            this.lb_inputInterchange.TabIndex = 0;
            this.lb_inputInterchange.Text = "Input";
            // 
            // lb_outputInterchange
            // 
            this.lb_outputInterchange.Font = new System.Drawing.Font("Comic Sans MS", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_outputInterchange.Location = new System.Drawing.Point(148, 210);
            this.lb_outputInterchange.Name = "lb_outputInterchange";
            this.lb_outputInterchange.Size = new System.Drawing.Size(118, 44);
            this.lb_outputInterchange.TabIndex = 1;
            this.lb_outputInterchange.Text = "Output";
            // 
            // tbx_inputInterchange
            // 
            this.tbx_inputInterchange.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_inputInterchange.Location = new System.Drawing.Point(392, 65);
            this.tbx_inputInterchange.Multiline = true;
            this.tbx_inputInterchange.Name = "tbx_inputInterchange";
            this.tbx_inputInterchange.Size = new System.Drawing.Size(512, 43);
            this.tbx_inputInterchange.TabIndex = 2;
            // 
            // tbx_outputInterchange
            // 
            this.tbx_outputInterchange.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_outputInterchange.Location = new System.Drawing.Point(392, 211);
            this.tbx_outputInterchange.Multiline = true;
            this.tbx_outputInterchange.Name = "tbx_outputInterchange";
            this.tbx_outputInterchange.Size = new System.Drawing.Size(512, 416);
            this.tbx_outputInterchange.TabIndex = 3;
            // 
            // btn_sortInterchange
            // 
            this.btn_sortInterchange.Font = new System.Drawing.Font("Comic Sans MS", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btn_sortInterchange.Location = new System.Drawing.Point(994, 65);
            this.btn_sortInterchange.Name = "btn_sortInterchange";
            this.btn_sortInterchange.Size = new System.Drawing.Size(116, 47);
            this.btn_sortInterchange.TabIndex = 4;
            this.btn_sortInterchange.Text = "Sort";
            this.btn_sortInterchange.UseVisualStyleBackColor = true;
            this.btn_sortInterchange.Click += new System.EventHandler(this.btn_sortInterchange_Click);
            // 
            // btn_exportInterchange
            // 
            this.btn_exportInterchange.Font = new System.Drawing.Font("Comic Sans MS", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btn_exportInterchange.Location = new System.Drawing.Point(972, 316);
            this.btn_exportInterchange.Name = "btn_exportInterchange";
            this.btn_exportInterchange.Size = new System.Drawing.Size(138, 174);
            this.btn_exportInterchange.TabIndex = 5;
            this.btn_exportInterchange.Text = "Export file and down";
            this.btn_exportInterchange.UseVisualStyleBackColor = true;
            // 
            // tbx_countNumber
            // 
            this.tbx_countNumber.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_countNumber.Location = new System.Drawing.Point(392, 114);
            this.tbx_countNumber.Multiline = true;
            this.tbx_countNumber.Name = "tbx_countNumber";
            this.tbx_countNumber.Size = new System.Drawing.Size(512, 43);
            this.tbx_countNumber.TabIndex = 6;
            // 
            // frm_interchange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1193, 738);
            this.Controls.Add(this.tbx_countNumber);
            this.Controls.Add(this.btn_exportInterchange);
            this.Controls.Add(this.btn_sortInterchange);
            this.Controls.Add(this.tbx_outputInterchange);
            this.Controls.Add(this.tbx_inputInterchange);
            this.Controls.Add(this.lb_outputInterchange);
            this.Controls.Add(this.lb_inputInterchange);
            this.Name = "frm_interchange";
            this.Text = "frm_interchange";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_inputInterchange;
        private System.Windows.Forms.Label lb_outputInterchange;
        private System.Windows.Forms.TextBox tbx_inputInterchange;
        private System.Windows.Forms.TextBox tbx_outputInterchange;
        private System.Windows.Forms.Button btn_sortInterchange;
        private System.Windows.Forms.Button btn_exportInterchange;
        private System.Windows.Forms.TextBox tbx_countNumber;
    }
}