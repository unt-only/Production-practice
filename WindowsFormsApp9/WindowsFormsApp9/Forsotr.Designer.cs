namespace WindowsFormsApp9
{
    partial class Forsotr
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListView listViewTasks;
        private System.Windows.Forms.ColumnHeader columnHeaderTitle;
        private System.Windows.Forms.ColumnHeader columnHeaderDescription;
        private System.Windows.Forms.ColumnHeader columnHeaderDeadline;
        private System.Windows.Forms.ColumnHeader columnHeaderReward;

        private void InitializeComponent()
        {
            this.listViewTasks = new System.Windows.Forms.ListView();
            this.columnHeaderTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDeadline = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderReward = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listViewTasks
            // 
            this.listViewTasks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderTitle,
            this.columnHeaderDescription,
            this.columnHeaderDeadline,
            this.columnHeaderReward});
            this.listViewTasks.Font = new System.Drawing.Font("Code Pro Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewTasks.FullRowSelect = true;
            this.listViewTasks.HideSelection = false;
            this.listViewTasks.Location = new System.Drawing.Point(12, 12);
            this.listViewTasks.MultiSelect = false;
            this.listViewTasks.Name = "listViewTasks";
            this.listViewTasks.Size = new System.Drawing.Size(880, 415);
            this.listViewTasks.TabIndex = 0;
            this.listViewTasks.UseCompatibleStateImageBehavior = false;
            this.listViewTasks.View = System.Windows.Forms.View.Details;
            this.listViewTasks.SelectedIndexChanged += new System.EventHandler(this.listViewTasks_SelectedIndexChanged);
            // 
            // columnHeaderTitle
            // 
            this.columnHeaderTitle.Text = "Название задания";
            this.columnHeaderTitle.Width = 186;
            // 
            // columnHeaderDescription
            // 
            this.columnHeaderDescription.Text = "Описание задания";
            this.columnHeaderDescription.Width = 324;
            // 
            // columnHeaderDeadline
            // 
            this.columnHeaderDeadline.Text = "Сроки задания";
            this.columnHeaderDeadline.Width = 170;
            // 
            // columnHeaderReward
            // 
            this.columnHeaderReward.Text = "Награды";
            this.columnHeaderReward.Width = 166;
            // 
            // Forsotr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 462);
            this.Controls.Add(this.listViewTasks);
            this.Name = "Forsotr";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Задания сотрудников";
            this.ResumeLayout(false);

        }
    }

}