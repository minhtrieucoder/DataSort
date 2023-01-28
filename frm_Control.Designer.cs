
namespace CuoiKy_ProjectSort
{
    partial class frm_Control
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Control));
            this.btn_interchange = new System.Windows.Forms.Button();
            this.btn_selection = new System.Windows.Forms.Button();
            this.btn_bubble = new System.Windows.Forms.Button();
            this.btn_insertion = new System.Windows.Forms.Button();
            this.lb_title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_interchange
            // 
            this.btn_interchange.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_interchange.Font = new System.Drawing.Font("Comic Sans MS", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_interchange.ForeColor = System.Drawing.Color.OrangeRed;
            this.btn_interchange.Location = new System.Drawing.Point(164, 228);
            this.btn_interchange.Name = "btn_interchange";
            this.btn_interchange.Size = new System.Drawing.Size(328, 63);
            this.btn_interchange.TabIndex = 0;
            this.btn_interchange.Text = "Interchange Sort";
            this.btn_interchange.UseVisualStyleBackColor = true;
            this.btn_interchange.Click += new System.EventHandler(this.btn_interchange_Click);
            // 
            // btn_selection
            // 
            this.btn_selection.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_selection.Font = new System.Drawing.Font("Comic Sans MS", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_selection.ForeColor = System.Drawing.Color.OrangeRed;
            this.btn_selection.Location = new System.Drawing.Point(587, 228);
            this.btn_selection.Name = "btn_selection";
            this.btn_selection.Size = new System.Drawing.Size(328, 63);
            this.btn_selection.TabIndex = 1;
            this.btn_selection.Text = "Selection Sort";
            this.btn_selection.UseVisualStyleBackColor = true;
            this.btn_selection.Click += new System.EventHandler(this.btn_selection_Click);
            // 
            // btn_bubble
            // 
            this.btn_bubble.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_bubble.Font = new System.Drawing.Font("Comic Sans MS", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_bubble.ForeColor = System.Drawing.Color.OrangeRed;
            this.btn_bubble.Location = new System.Drawing.Point(164, 376);
            this.btn_bubble.Name = "btn_bubble";
            this.btn_bubble.Size = new System.Drawing.Size(328, 63);
            this.btn_bubble.TabIndex = 2;
            this.btn_bubble.Text = "Bubble Sort";
            this.btn_bubble.UseVisualStyleBackColor = true;
            this.btn_bubble.Click += new System.EventHandler(this.btn_bubble_Click);
            // 
            // btn_insertion
            // 
            this.btn_insertion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_insertion.Font = new System.Drawing.Font("Comic Sans MS", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_insertion.ForeColor = System.Drawing.Color.OrangeRed;
            this.btn_insertion.Location = new System.Drawing.Point(587, 376);
            this.btn_insertion.Name = "btn_insertion";
            this.btn_insertion.Size = new System.Drawing.Size(328, 63);
            this.btn_insertion.TabIndex = 3;
            this.btn_insertion.Text = "Insertion Sort";
            this.btn_insertion.UseVisualStyleBackColor = true;
            this.btn_insertion.Click += new System.EventHandler(this.btn_insertion_Click);
            // 
            // lb_title
            // 
            this.lb_title.AutoSize = true;
            this.lb_title.BackColor = System.Drawing.Color.Transparent;
            this.lb_title.Font = new System.Drawing.Font("Calibri", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_title.Location = new System.Drawing.Point(174, 99);
            this.lb_title.Name = "lb_title";
            this.lb_title.Size = new System.Drawing.Size(716, 44);
            this.lb_title.TabIndex = 4;
            this.lb_title.Text = "Chọn thuật toán bạn muốn sử dụng để sắp xếp";
            this.lb_title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frm_Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1079, 547);
            this.Controls.Add(this.lb_title);
            this.Controls.Add(this.btn_insertion);
            this.Controls.Add(this.btn_bubble);
            this.Controls.Add(this.btn_selection);
            this.Controls.Add(this.btn_interchange);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DoubleBuffered = true;
            this.Name = "frm_Control";
            this.Text = "control";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_interchange;
        private System.Windows.Forms.Button btn_selection;
        private System.Windows.Forms.Button btn_bubble;
        private System.Windows.Forms.Button btn_insertion;
        private System.Windows.Forms.Label lb_title;
    }
}

