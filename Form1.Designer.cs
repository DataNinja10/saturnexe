namespace Saturn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            rich = new RichTextBox();
            abcforfree1 = new Button();
            abcforfree2 = new Button();
            clear = new Button();
            scripts = new Button();
            open = new Button();
            save = new Button();
            settings = new Button();
            SuspendLayout();
            // 
            // rich
            // 
            rich.BackColor = Color.White;
            rich.Location = new Point(15, 20);
            rich.Name = "rich";
            rich.Size = new Size(808, 350);
            rich.TabIndex = 0;
            rich.Text = "";
            rich.TextChanged += rich_TextChanged;
            // 
            // abcforfree1
            // 
            abcforfree1.Location = new Point(12, 398);
            abcforfree1.Name = "abcforfree1";
            abcforfree1.Size = new Size(112, 34);
            abcforfree1.TabIndex = 1;
            abcforfree1.Text = "inject";
            abcforfree1.UseVisualStyleBackColor = true;
            abcforfree1.Click += abcforfree1_Click;
            // 
            // abcforfree2
            // 
            abcforfree2.Location = new Point(130, 398);
            abcforfree2.Name = "abcforfree2";
            abcforfree2.Size = new Size(112, 34);
            abcforfree2.TabIndex = 2;
            abcforfree2.Text = "execute";
            abcforfree2.UseVisualStyleBackColor = true;
            abcforfree2.Click += abcforfree2_Click;
            // 
            // clear
            // 
            clear.Location = new Point(248, 398);
            clear.Name = "clear";
            clear.Size = new Size(112, 34);
            clear.TabIndex = 3;
            clear.Text = "clear";
            clear.UseVisualStyleBackColor = true;
            clear.Click += clear_Click;
            // 
            // scripts
            // 
            scripts.Location = new Point(366, 398);
            scripts.Name = "scripts";
            scripts.Size = new Size(112, 34);
            scripts.TabIndex = 4;
            scripts.Text = "scripts";
            scripts.UseVisualStyleBackColor = true;
            scripts.Click += scripts_Click;
            // 
            // open
            // 
            open.Location = new Point(484, 398);
            open.Name = "open";
            open.Size = new Size(112, 34);
            open.TabIndex = 5;
            open.Text = "open";
            open.UseVisualStyleBackColor = true;
            open.Click += open_Click;
            // 
            // save
            // 
            save.Location = new Point(602, 398);
            save.Name = "save";
            save.Size = new Size(112, 34);
            save.TabIndex = 6;
            save.Text = "save";
            save.UseVisualStyleBackColor = true;
            save.Click += save_Click;
            // 
            // settings
            // 
            settings.Location = new Point(720, 398);
            settings.Name = "settings";
            settings.Size = new Size(103, 34);
            settings.TabIndex = 7;
            settings.Text = "settings";
            settings.UseVisualStyleBackColor = true;
            settings.Click += settings_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(835, 450);
            Controls.Add(settings);
            Controls.Add(save);
            Controls.Add(open);
            Controls.Add(scripts);
            Controls.Add(clear);
            Controls.Add(abcforfree2);
            Controls.Add(abcforfree1);
            Controls.Add(rich);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Saturn";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox rich;
        private Button abcforfree1;
        private Button abcforfree2;
        private Button clear;
        private Button scripts;
        private Button open;
        private Button save;
        private Button settings;
    }
}
