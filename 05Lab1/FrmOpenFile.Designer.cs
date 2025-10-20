namespace _05Lab1
{
    partial class FrmOpenFile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOpenFile));
            lvShowText = new ListView();
            btnOpen = new Button();
            openFileDialog1 = new OpenFileDialog();
            SuspendLayout();
            // 
            // lvShowText
            // 
            lvShowText.Location = new Point(12, 12);
            lvShowText.Name = "lvShowText";
            lvShowText.Size = new Size(335, 204);
            lvShowText.TabIndex = 0;
            lvShowText.UseCompatibleStateImageBehavior = false;
            // 
            // btnOpen
            // 
            btnOpen.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOpen.ForeColor = SystemColors.ActiveCaptionText;
            btnOpen.Location = new Point(125, 237);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(107, 36);
            btnOpen.TabIndex = 1;
            btnOpen.Text = "Open";
            btnOpen.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.FileOk += openFileDialog1_FileOk;
            // 
            // FrmOpenFile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(359, 297);
            Controls.Add(btnOpen);
            Controls.Add(lvShowText);
            ForeColor = SystemColors.ControlLight;
            Name = "FrmOpenFile";
            Text = "FrmOpenFile";
            ResumeLayout(false);
        }

        #endregion

        private ListView lvShowText;
        private Button btnOpen;
        private OpenFileDialog openFileDialog1;
    }
}