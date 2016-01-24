namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Refresh_btn = new System.Windows.Forms.Button();
            this.ProcessView = new System.Windows.Forms.ListView();
            this.PID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Process = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Memory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StartTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.change_btn = new System.Windows.Forms.Button();
            this.Proccess_new_name = new System.Windows.Forms.TextBox();
            this.made_by = new System.Windows.Forms.Label();
            this.git_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Refresh_btn
            // 
            this.Refresh_btn.Location = new System.Drawing.Point(644, 287);
            this.Refresh_btn.Name = "Refresh_btn";
            this.Refresh_btn.Size = new System.Drawing.Size(142, 41);
            this.Refresh_btn.TabIndex = 0;
            this.Refresh_btn.Text = "Refresh";
            this.Refresh_btn.UseVisualStyleBackColor = true;
            this.Refresh_btn.Click += new System.EventHandler(this.Reload_Click);
            // 
            // ProcessView
            // 
            this.ProcessView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.PID,
            this.Process,
            this.Title,
            this.Memory,
            this.StartTime});
            this.ProcessView.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ProcessView.FullRowSelect = true;
            this.ProcessView.GridLines = true;
            this.ProcessView.HideSelection = false;
            this.ProcessView.Location = new System.Drawing.Point(16, 12);
            this.ProcessView.MultiSelect = false;
            this.ProcessView.Name = "ProcessView";
            this.ProcessView.Size = new System.Drawing.Size(606, 329);
            this.ProcessView.TabIndex = 1;
            this.ProcessView.UseCompatibleStateImageBehavior = false;
            this.ProcessView.View = System.Windows.Forms.View.Details;
            // 
            // PID
            // 
            this.PID.Text = "PID";
            // 
            // Process
            // 
            this.Process.Text = "Process";
            this.Process.Width = 100;
            // 
            // Title
            // 
            this.Title.Text = "Title";
            this.Title.Width = 150;
            // 
            // Memory
            // 
            this.Memory.Text = "Memory";
            this.Memory.Width = 110;
            // 
            // StartTime
            // 
            this.StartTime.Text = "Start Time";
            this.StartTime.Width = 150;
            // 
            // change_btn
            // 
            this.change_btn.Location = new System.Drawing.Point(805, 223);
            this.change_btn.Name = "change_btn";
            this.change_btn.Size = new System.Drawing.Size(139, 39);
            this.change_btn.TabIndex = 3;
            this.change_btn.Text = "change";
            this.change_btn.UseVisualStyleBackColor = true;
            this.change_btn.Click += new System.EventHandler(this.change_btn_Click);
            // 
            // Proccess_new_name
            // 
            this.Proccess_new_name.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Proccess_new_name.Location = new System.Drawing.Point(644, 223);
            this.Proccess_new_name.Name = "Proccess_new_name";
            this.Proccess_new_name.Size = new System.Drawing.Size(141, 39);
            this.Proccess_new_name.TabIndex = 4;
            // 
            // made_by
            // 
            this.made_by.AutoSize = true;
            this.made_by.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.made_by.Location = new System.Drawing.Point(802, 297);
            this.made_by.Name = "made_by";
            this.made_by.Size = new System.Drawing.Size(142, 16);
            this.made_by.TabIndex = 5;
            this.made_by.Text = "Made by rinechran";
            // 
            // git_btn
            // 
            this.git_btn.BackgroundImage = global::Title_Changer.Properties.Resources._155128011;
            this.git_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.git_btn.Location = new System.Drawing.Point(721, 36);
            this.git_btn.Name = "git_btn";
            this.git_btn.Size = new System.Drawing.Size(159, 151);
            this.git_btn.TabIndex = 6;
            this.git_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.git_btn.UseCompatibleTextRendering = true;
            this.git_btn.UseVisualStyleBackColor = true;
            this.git_btn.Click += new System.EventHandler(this.git_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(956, 355);
            this.Controls.Add(this.git_btn);
            this.Controls.Add(this.made_by);
            this.Controls.Add(this.Proccess_new_name);
            this.Controls.Add(this.change_btn);
            this.Controls.Add(this.ProcessView);
            this.Controls.Add(this.Refresh_btn);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Program Title Changer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Refresh_btn;
        private System.Windows.Forms.ColumnHeader PID;
        private System.Windows.Forms.ColumnHeader Process;
        private System.Windows.Forms.ColumnHeader Memory;
        private System.Windows.Forms.ColumnHeader Title;
        private System.Windows.Forms.ColumnHeader StartTime;
        public System.Windows.Forms.ListView ProcessView;
        private System.Windows.Forms.Button change_btn;
        private System.Windows.Forms.TextBox Proccess_new_name;
        private System.Windows.Forms.Label made_by;
        private System.Windows.Forms.Button git_btn;
    }
}

