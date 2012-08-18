namespace Guesstimate
{
    partial class ProjectScopeForm
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
            this.addTaskButton = new System.Windows.Forms.Button();
            this.taskList = new System.Windows.Forms.ListBox();
            this.editTaskButton = new System.Windows.Forms.Button();
            this.removeTasksButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addTaskButton
            // 
            this.addTaskButton.Location = new System.Drawing.Point(13, 13);
            this.addTaskButton.Name = "addTaskButton";
            this.addTaskButton.Size = new System.Drawing.Size(259, 23);
            this.addTaskButton.TabIndex = 0;
            this.addTaskButton.Text = "Add Task";
            this.addTaskButton.UseVisualStyleBackColor = true;
            this.addTaskButton.Click += new System.EventHandler(this.AddTaskButtonClick);
            // 
            // taskList
            // 
            this.taskList.FormattingEnabled = true;
            this.taskList.Location = new System.Drawing.Point(13, 43);
            this.taskList.Name = "taskList";
            this.taskList.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.taskList.Size = new System.Drawing.Size(259, 186);
            this.taskList.TabIndex = 1;
            this.taskList.SelectedIndexChanged += new System.EventHandler(this.TaskListSelectedIndexChanged);
            // 
            // editTaskButton
            // 
            this.editTaskButton.Enabled = false;
            this.editTaskButton.Location = new System.Drawing.Point(197, 238);
            this.editTaskButton.Name = "editTaskButton";
            this.editTaskButton.Size = new System.Drawing.Size(75, 23);
            this.editTaskButton.TabIndex = 2;
            this.editTaskButton.Text = "Edit Task";
            this.editTaskButton.UseVisualStyleBackColor = true;
            this.editTaskButton.Click += new System.EventHandler(this.EditTaskButtonClick);
            // 
            // removeTasksButton
            // 
            this.removeTasksButton.Enabled = false;
            this.removeTasksButton.Location = new System.Drawing.Point(88, 238);
            this.removeTasksButton.Name = "removeTasksButton";
            this.removeTasksButton.Size = new System.Drawing.Size(103, 23);
            this.removeTasksButton.TabIndex = 3;
            this.removeTasksButton.Text = "Remove Task(s)";
            this.removeTasksButton.UseVisualStyleBackColor = true;
            this.removeTasksButton.Click += new System.EventHandler(this.RemoveTasksButtonClick);
            // 
            // ProjectScopeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 269);
            this.Controls.Add(this.removeTasksButton);
            this.Controls.Add(this.editTaskButton);
            this.Controls.Add(this.taskList);
            this.Controls.Add(this.addTaskButton);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 307);
            this.MinimumSize = new System.Drawing.Size(300, 307);
            this.Name = "ProjectScopeForm";
            this.Text = "Manage Project Scope";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ProjectScopeFormFormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addTaskButton;
        private System.Windows.Forms.ListBox taskList;
        private System.Windows.Forms.Button editTaskButton;
        private System.Windows.Forms.Button removeTasksButton;
    }
}