namespace _05Lab1
{
    partial class FrmStudentRecord
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStudentRecord));
            label1 = new Label();
            listView1 = new ListView();
            btnRegister = new Button();
            btnFind = new Button();
            btnUpload = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(7, 8);
            label1.Name = "label1";
            label1.Size = new Size(131, 30);
            label1.TabIndex = 0;
            label1.Text = "View Record";
            // 
            // listView1
            // 
            listView1.Location = new Point(12, 43);
            listView1.Name = "listView1";
            listView1.Size = new Size(367, 179);
            listView1.TabIndex = 1;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(385, 43);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(75, 23);
            btnRegister.TabIndex = 2;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            // 
            // btnFind
            // 
            btnFind.Location = new Point(385, 72);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(75, 23);
            btnFind.TabIndex = 3;
            btnFind.Text = "Find";
            btnFind.UseVisualStyleBackColor = true;
            // 
            // btnUpload
            // 
            btnUpload.Location = new Point(385, 101);
            btnUpload.Name = "btnUpload";
            btnUpload.Size = new Size(75, 23);
            btnUpload.TabIndex = 4;
            btnUpload.Text = "Upload";
            btnUpload.UseVisualStyleBackColor = true;
            // 
            // FrmStudentRecord
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(463, 243);
            Controls.Add(btnUpload);
            Controls.Add(btnFind);
            Controls.Add(btnRegister);
            Controls.Add(listView1);
            Controls.Add(label1);
            Name = "FrmStudentRecord";
            Text = "FrmStudentRecord";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListView listView1;
        private Button btnRegister;
        private Button btnFind;
        private Button btnUpload;
    }
}