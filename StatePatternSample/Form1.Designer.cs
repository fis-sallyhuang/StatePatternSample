
namespace StatePatternSample
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
            this.btnGoNext = new System.Windows.Forms.Button();
            this.btnGoNextAction = new System.Windows.Forms.Button();
            this.btnGenAct = new System.Windows.Forms.Button();
            this.btnGenActionWithTask = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGoNext
            // 
            this.btnGoNext.Location = new System.Drawing.Point(413, 99);
            this.btnGoNext.Name = "btnGoNext";
            this.btnGoNext.Size = new System.Drawing.Size(75, 23);
            this.btnGoNext.TabIndex = 0;
            this.btnGoNext.Text = "GoNext";
            this.btnGoNext.UseVisualStyleBackColor = true;
            this.btnGoNext.Click += new System.EventHandler(this.btnGoNext_Click);
            // 
            // btnGoNextAction
            // 
            this.btnGoNextAction.Location = new System.Drawing.Point(413, 163);
            this.btnGoNextAction.Name = "btnGoNextAction";
            this.btnGoNextAction.Size = new System.Drawing.Size(130, 23);
            this.btnGoNextAction.TabIndex = 1;
            this.btnGoNextAction.Text = "GoNextAction";
            this.btnGoNextAction.UseVisualStyleBackColor = true;
            this.btnGoNextAction.Click += new System.EventHandler(this.btnGoNextAction_Click);
            // 
            // btnGenAct
            // 
            this.btnGenAct.Location = new System.Drawing.Point(413, 214);
            this.btnGenAct.Name = "btnGenAct";
            this.btnGenAct.Size = new System.Drawing.Size(130, 23);
            this.btnGenAct.TabIndex = 2;
            this.btnGenAct.Text = "GoGenAction";
            this.btnGenAct.UseVisualStyleBackColor = true;
            this.btnGenAct.Click += new System.EventHandler(this.btnGenAct_Click);
            // 
            // btnGenActionWithTask
            // 
            this.btnGenActionWithTask.Location = new System.Drawing.Point(413, 255);
            this.btnGenActionWithTask.Name = "btnGenActionWithTask";
            this.btnGenActionWithTask.Size = new System.Drawing.Size(159, 23);
            this.btnGenActionWithTask.TabIndex = 3;
            this.btnGenActionWithTask.Text = "GoGenActionWithTask";
            this.btnGenActionWithTask.UseVisualStyleBackColor = true;
            this.btnGenActionWithTask.Click += new System.EventHandler(this.btnGenActionWithTask_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGenActionWithTask);
            this.Controls.Add(this.btnGenAct);
            this.Controls.Add(this.btnGoNextAction);
            this.Controls.Add(this.btnGoNext);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGoNext;
        private System.Windows.Forms.Button btnGoNextAction;
        private System.Windows.Forms.Button btnGenAct;
        private System.Windows.Forms.Button btnGenActionWithTask;
    }
}

