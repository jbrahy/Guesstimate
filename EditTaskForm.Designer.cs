﻿namespace Guesstimate
{
    partial class EditTaskForm
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
            this.rdLabel = new System.Windows.Forms.Label();
            this.rdMin = new System.Windows.Forms.NumericUpDown();
            this.rdMax = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.developmentMax = new System.Windows.Forms.NumericUpDown();
            this.developmentMin = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.qaMax = new System.Windows.Forms.NumericUpDown();
            this.qaMin = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.addTaskButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.taskTitle = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.rdMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.developmentMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.developmentMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qaMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qaMin)).BeginInit();
            this.SuspendLayout();
            // 
            // rdLabel
            // 
            this.rdLabel.AutoSize = true;
            this.rdLabel.Location = new System.Drawing.Point(13, 47);
            this.rdLabel.Name = "rdLabel";
            this.rdLabel.Size = new System.Drawing.Size(140, 13);
            this.rdLabel.TabIndex = 2;
            this.rdLabel.Text = "Research and Development";
            // 
            // rdMin
            // 
            this.rdMin.DecimalPlaces = 2;
            this.rdMin.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.rdMin.Location = new System.Drawing.Point(152, 66);
            this.rdMin.Name = "rdMin";
            this.rdMin.Size = new System.Drawing.Size(120, 20);
            this.rdMin.TabIndex = 4;
            this.rdMin.ValueChanged += new System.EventHandler(this.RdMinValueChanged);
            // 
            // rdMax
            // 
            this.rdMax.DecimalPlaces = 2;
            this.rdMax.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.rdMax.Location = new System.Drawing.Point(151, 93);
            this.rdMax.Name = "rdMax";
            this.rdMax.Size = new System.Drawing.Size(120, 20);
            this.rdMax.TabIndex = 5;
            this.rdMax.ValueChanged += new System.EventHandler(this.RdMaxValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Minimum Hours";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Maximum Hours";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Development Cycle";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Maximum Hours";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Minimum Hours";
            // 
            // developmentMax
            // 
            this.developmentMax.DecimalPlaces = 2;
            this.developmentMax.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.developmentMax.Location = new System.Drawing.Point(149, 173);
            this.developmentMax.Name = "developmentMax";
            this.developmentMax.Size = new System.Drawing.Size(120, 20);
            this.developmentMax.TabIndex = 10;
            this.developmentMax.ValueChanged += new System.EventHandler(this.DevelopmentMaxValueChanged);
            // 
            // developmentMin
            // 
            this.developmentMin.DecimalPlaces = 2;
            this.developmentMin.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.developmentMin.Location = new System.Drawing.Point(150, 146);
            this.developmentMin.Name = "developmentMin";
            this.developmentMin.Size = new System.Drawing.Size(120, 20);
            this.developmentMin.TabIndex = 9;
            this.developmentMin.ValueChanged += new System.EventHandler(this.DevelopmentMinValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 258);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Maximum Hours";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 229);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Minimum Hours";
            // 
            // qaMax
            // 
            this.qaMax.DecimalPlaces = 2;
            this.qaMax.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.qaMax.Location = new System.Drawing.Point(149, 256);
            this.qaMax.Name = "qaMax";
            this.qaMax.Size = new System.Drawing.Size(120, 20);
            this.qaMax.TabIndex = 15;
            this.qaMax.ValueChanged += new System.EventHandler(this.QAMaxValueChanged);
            // 
            // qaMin
            // 
            this.qaMin.DecimalPlaces = 2;
            this.qaMin.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.qaMin.Location = new System.Drawing.Point(150, 229);
            this.qaMin.Name = "qaMin";
            this.qaMin.Size = new System.Drawing.Size(120, 20);
            this.qaMin.TabIndex = 14;
            this.qaMin.ValueChanged += new System.EventHandler(this.QAMinValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 210);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(141, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Question and Answer Period";
            // 
            // addTaskButton
            // 
            this.addTaskButton.Location = new System.Drawing.Point(196, 288);
            this.addTaskButton.Name = "addTaskButton";
            this.addTaskButton.Size = new System.Drawing.Size(75, 23);
            this.addTaskButton.TabIndex = 18;
            this.addTaskButton.Text = "Save Task";
            this.addTaskButton.UseVisualStyleBackColor = true;
            this.addTaskButton.Click += new System.EventHandler(this.AddTaskButtonClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Title:";
            // 
            // taskTitle
            // 
            this.taskTitle.Location = new System.Drawing.Point(89, 14);
            this.taskTitle.Name = "taskTitle";
            this.taskTitle.Size = new System.Drawing.Size(183, 20);
            this.taskTitle.TabIndex = 22;
            // 
            // EditTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 323);
            this.Controls.Add(this.taskTitle);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.addTaskButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.qaMax);
            this.Controls.Add(this.qaMin);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.developmentMax);
            this.Controls.Add(this.developmentMin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rdMax);
            this.Controls.Add(this.rdMin);
            this.Controls.Add(this.rdLabel);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 361);
            this.MinimumSize = new System.Drawing.Size(300, 361);
            this.Name = "EditTaskForm";
            this.Text = "Edit Task";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditTaskFormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.rdMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.developmentMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.developmentMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qaMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qaMin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label rdLabel;
        private System.Windows.Forms.NumericUpDown rdMin;
        private System.Windows.Forms.NumericUpDown rdMax;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown developmentMax;
        private System.Windows.Forms.NumericUpDown developmentMin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown qaMax;
        private System.Windows.Forms.NumericUpDown qaMin;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button addTaskButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox taskTitle;
    }
}