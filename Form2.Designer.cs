namespace Saturn
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            button1 = new Button();
            a = new Button();
            AnimationHub = new Button();
            Betterbypasser = new Button();
            button4 = new Button();
            Nameless = new Button();
            quirkycmd = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(158, 86);
            button1.TabIndex = 0;
            button1.Text = "Click to tp";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // a
            // 
            a.Location = new Point(176, 12);
            a.Name = "a";
            a.Size = new Size(154, 86);
            a.TabIndex = 1;
            a.Text = "Infinite Yield";
            a.UseVisualStyleBackColor = true;
            a.Click += a_Click;
            // 
            // AnimationHub
            // 
            AnimationHub.Location = new Point(504, 12);
            AnimationHub.Name = "AnimationHub";
            AnimationHub.Size = new Size(142, 86);
            AnimationHub.TabIndex = 2;
            AnimationHub.Text = "AnimationHub";
            AnimationHub.UseVisualStyleBackColor = true;
            AnimationHub.Click += AnimationHub_Click;
            // 
            // Betterbypasser
            // 
            Betterbypasser.Location = new Point(336, 12);
            Betterbypasser.Name = "Betterbypasser";
            Betterbypasser.Size = new Size(162, 86);
            Betterbypasser.TabIndex = 3;
            Betterbypasser.Text = "Betterbypasser";
            Betterbypasser.UseVisualStyleBackColor = true;
            Betterbypasser.Click += Betterbypasser_Click;
            // 
            // button4
            // 
            button4.Location = new Point(652, 12);
            button4.Name = "button4";
            button4.Size = new Size(136, 86);
            button4.TabIndex = 4;
            button4.Text = "Bang gui cuz i didnt found J### OFF";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Nameless
            // 
            Nameless.Location = new Point(12, 104);
            Nameless.Name = "Nameless";
            Nameless.Size = new Size(158, 89);
            Nameless.TabIndex = 5;
            Nameless.Text = "Nameless admin";
            Nameless.UseVisualStyleBackColor = true;
            Nameless.Click += Nameless_Click;
            // 
            // quirkycmd
            // 
            quirkycmd.Location = new Point(176, 104);
            quirkycmd.Name = "quirkycmd";
            quirkycmd.Size = new Size(154, 89);
            quirkycmd.TabIndex = 6;
            quirkycmd.Text = "Remote abuse (QuirkyCMD)";
            quirkycmd.UseVisualStyleBackColor = true;
            quirkycmd.Click += quirkycmd_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(quirkycmd);
            Controls.Add(Nameless);
            Controls.Add(button4);
            Controls.Add(Betterbypasser);
            Controls.Add(AnimationHub);
            Controls.Add(a);
            Controls.Add(button1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form2";
            Text = "Scripts";
            Load += Form2_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button a;
        private Button AnimationHub;
        private Button Betterbypasser;
        private Button button4;
        private Button Nameless;
        private Button quirkycmd;
    }
}