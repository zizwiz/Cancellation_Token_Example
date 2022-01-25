
namespace Cancel_Token_Example
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbl_output = new System.Windows.Forms.Label();
            this.btn_abort = new System.Windows.Forms.Button();
            this.btn_run = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_output
            // 
            this.lbl_output.AutoSize = true;
            this.lbl_output.Location = new System.Drawing.Point(187, 52);
            this.lbl_output.Name = "lbl_output";
            this.lbl_output.Size = new System.Drawing.Size(157, 17);
            this.lbl_output.TabIndex = 0;
            this.lbl_output.Text = "Output_text_goes_here";
            // 
            // btn_abort
            // 
            this.btn_abort.Location = new System.Drawing.Point(302, 132);
            this.btn_abort.Name = "btn_abort";
            this.btn_abort.Size = new System.Drawing.Size(94, 57);
            this.btn_abort.TabIndex = 1;
            this.btn_abort.Text = "Abort";
            this.btn_abort.UseVisualStyleBackColor = true;
            this.btn_abort.Click += new System.EventHandler(this.btn_abort_Click);
            // 
            // btn_run
            // 
            this.btn_run.Location = new System.Drawing.Point(165, 132);
            this.btn_run.Name = "btn_run";
            this.btn_run.Size = new System.Drawing.Size(94, 57);
            this.btn_run.TabIndex = 2;
            this.btn_run.Text = "Run";
            this.btn_run.UseVisualStyleBackColor = true;
            this.btn_run.Click += new System.EventHandler(this.btn_run_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 268);
            this.Controls.Add(this.btn_run);
            this.Controls.Add(this.btn_abort);
            this.Controls.Add(this.lbl_output);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "CancelToken Example";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_output;
        private System.Windows.Forms.Button btn_abort;
        private System.Windows.Forms.Button btn_run;
    }
}

