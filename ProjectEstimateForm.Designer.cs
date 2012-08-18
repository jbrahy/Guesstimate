namespace Guesstimate
{
    partial class ProjectEstimateForm
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
            this.manageProjectScopeButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.label2 = new System.Windows.Forms.Label();
            this.rdMin = new System.Windows.Forms.TextBox();
            this.exportBreakdownButton = new System.Windows.Forms.Button();
            this.saveGuesstimationProjectButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.rdMax = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.developmentMax = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.developmentMin = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.qaMax = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.qaMin = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.loadGuesstimationProjectButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // manageProjectScopeButton
            // 
            this.manageProjectScopeButton.Location = new System.Drawing.Point(13, 13);
            this.manageProjectScopeButton.Name = "manageProjectScopeButton";
            this.manageProjectScopeButton.Size = new System.Drawing.Size(259, 23);
            this.manageProjectScopeButton.TabIndex = 0;
            this.manageProjectScopeButton.Text = "Manage Project Scope";
            this.manageProjectScopeButton.UseVisualStyleBackColor = true;
            this.manageProjectScopeButton.Click += new System.EventHandler(this.ManageProjectScopeButtonClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Estimate Breakdown";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(284, 415);
            this.shapeContainer1.TabIndex = 2;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 24;
            this.lineShape1.X2 = 263;
            this.lineShape1.Y1 = 64;
            this.lineShape1.Y2 = 64;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Research and Development";
            // 
            // rdMin
            // 
            this.rdMin.Location = new System.Drawing.Point(119, 110);
            this.rdMin.Name = "rdMin";
            this.rdMin.ReadOnly = true;
            this.rdMin.Size = new System.Drawing.Size(144, 20);
            this.rdMin.TabIndex = 4;
            // 
            // exportBreakdownButton
            // 
            this.exportBreakdownButton.Location = new System.Drawing.Point(16, 380);
            this.exportBreakdownButton.Name = "exportBreakdownButton";
            this.exportBreakdownButton.Size = new System.Drawing.Size(250, 23);
            this.exportBreakdownButton.TabIndex = 9;
            this.exportBreakdownButton.Text = "Export Breakdown";
            this.exportBreakdownButton.UseVisualStyleBackColor = true;
            this.exportBreakdownButton.Click += new System.EventHandler(this.ExportBreakdownButtonClick);
            // 
            // saveGuesstimationProjectButton
            // 
            this.saveGuesstimationProjectButton.Location = new System.Drawing.Point(151, 333);
            this.saveGuesstimationProjectButton.Name = "saveGuesstimationProjectButton";
            this.saveGuesstimationProjectButton.Size = new System.Drawing.Size(115, 41);
            this.saveGuesstimationProjectButton.TabIndex = 10;
            this.saveGuesstimationProjectButton.Text = "Save Guesstimation Project";
            this.saveGuesstimationProjectButton.UseVisualStyleBackColor = true;
            this.saveGuesstimationProjectButton.Click += new System.EventHandler(this.SaveGuesstimationProjectButtonClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Minimum Hours:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Maximum Hours:";
            // 
            // rdMax
            // 
            this.rdMax.Location = new System.Drawing.Point(119, 138);
            this.rdMax.Name = "rdMax";
            this.rdMax.ReadOnly = true;
            this.rdMax.Size = new System.Drawing.Size(144, 20);
            this.rdMax.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Maximum Hours:";
            // 
            // developmentMax
            // 
            this.developmentMax.Location = new System.Drawing.Point(119, 221);
            this.developmentMax.Name = "developmentMax";
            this.developmentMax.ReadOnly = true;
            this.developmentMax.Size = new System.Drawing.Size(144, 20);
            this.developmentMax.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Minimum Hours:";
            // 
            // developmentMin
            // 
            this.developmentMin.Location = new System.Drawing.Point(119, 193);
            this.developmentMin.Name = "developmentMin";
            this.developmentMin.ReadOnly = true;
            this.developmentMin.Size = new System.Drawing.Size(144, 20);
            this.developmentMin.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 167);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Development Cycle";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 310);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Maximum Hours:";
            // 
            // qaMax
            // 
            this.qaMax.Location = new System.Drawing.Point(119, 307);
            this.qaMax.Name = "qaMax";
            this.qaMax.ReadOnly = true;
            this.qaMax.Size = new System.Drawing.Size(144, 20);
            this.qaMax.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 282);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Minimum Hours:";
            // 
            // qaMin
            // 
            this.qaMin.Location = new System.Drawing.Point(119, 279);
            this.qaMin.Name = "qaMin";
            this.qaMin.ReadOnly = true;
            this.qaMin.Size = new System.Drawing.Size(144, 20);
            this.qaMin.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 253);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(141, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Question and Answer Period";
            // 
            // loadGuesstimationProjectButton
            // 
            this.loadGuesstimationProjectButton.Location = new System.Drawing.Point(12, 333);
            this.loadGuesstimationProjectButton.Name = "loadGuesstimationProjectButton";
            this.loadGuesstimationProjectButton.Size = new System.Drawing.Size(119, 41);
            this.loadGuesstimationProjectButton.TabIndex = 24;
            this.loadGuesstimationProjectButton.Text = "Load Guesstimation Project";
            this.loadGuesstimationProjectButton.UseVisualStyleBackColor = true;
            this.loadGuesstimationProjectButton.Click += new System.EventHandler(this.LoadGuesstimationProjectButtonClick);
            // 
            // ProjectEstimateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 415);
            this.Controls.Add(this.loadGuesstimationProjectButton);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.qaMax);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.qaMin);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.developmentMax);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.developmentMin);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rdMax);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.saveGuesstimationProjectButton);
            this.Controls.Add(this.exportBreakdownButton);
            this.Controls.Add(this.rdMin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.manageProjectScopeButton);
            this.Controls.Add(this.shapeContainer1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 453);
            this.MinimumSize = new System.Drawing.Size(300, 453);
            this.Name = "ProjectEstimateForm";
            this.Text = "Begin Project Estimate";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProjectEstimateFormFormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button manageProjectScopeButton;
        private System.Windows.Forms.Label label1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox rdMin;
        private System.Windows.Forms.Button exportBreakdownButton;
        private System.Windows.Forms.Button saveGuesstimationProjectButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox rdMax;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox developmentMax;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox developmentMin;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox qaMax;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox qaMin;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button loadGuesstimationProjectButton;
    }
}

