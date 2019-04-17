namespace TickTackToeApp
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnUL = new System.Windows.Forms.Button();
            this.btnUM = new System.Windows.Forms.Button();
            this.btnUR = new System.Windows.Forms.Button();
            this.btnMR = new System.Windows.Forms.Button();
            this.btnMM = new System.Windows.Forms.Button();
            this.btnML = new System.Windows.Forms.Button();
            this.btnLR = new System.Windows.Forms.Button();
            this.btnLM = new System.Windows.Forms.Button();
            this.btnLL = new System.Windows.Forms.Button();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuNew = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.aboutMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUL
            // 
            this.btnUL.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F);
            this.btnUL.Location = new System.Drawing.Point(35, 38);
            this.btnUL.Name = "btnUL";
            this.btnUL.Size = new System.Drawing.Size(52, 52);
            this.btnUL.TabIndex = 12;
            this.btnUL.UseVisualStyleBackColor = true;
            this.btnUL.Visible = false;
            this.btnUL.Click += new System.EventHandler(this.button_click);
            // 
            // btnUM
            // 
            this.btnUM.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F);
            this.btnUM.Location = new System.Drawing.Point(93, 38);
            this.btnUM.Name = "btnUM";
            this.btnUM.Size = new System.Drawing.Size(52, 52);
            this.btnUM.TabIndex = 13;
            this.btnUM.UseVisualStyleBackColor = true;
            this.btnUM.Visible = false;
            this.btnUM.Click += new System.EventHandler(this.button_click);
            // 
            // btnUR
            // 
            this.btnUR.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F);
            this.btnUR.Location = new System.Drawing.Point(151, 38);
            this.btnUR.Name = "btnUR";
            this.btnUR.Size = new System.Drawing.Size(52, 52);
            this.btnUR.TabIndex = 14;
            this.btnUR.UseVisualStyleBackColor = true;
            this.btnUR.Visible = false;
            this.btnUR.Click += new System.EventHandler(this.button_click);
            // 
            // btnMR
            // 
            this.btnMR.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F);
            this.btnMR.Location = new System.Drawing.Point(151, 96);
            this.btnMR.Name = "btnMR";
            this.btnMR.Size = new System.Drawing.Size(52, 52);
            this.btnMR.TabIndex = 17;
            this.btnMR.UseVisualStyleBackColor = true;
            this.btnMR.Visible = false;
            this.btnMR.Click += new System.EventHandler(this.button_click);
            // 
            // btnMM
            // 
            this.btnMM.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F);
            this.btnMM.Location = new System.Drawing.Point(93, 96);
            this.btnMM.Name = "btnMM";
            this.btnMM.Size = new System.Drawing.Size(52, 52);
            this.btnMM.TabIndex = 16;
            this.btnMM.UseVisualStyleBackColor = true;
            this.btnMM.Visible = false;
            this.btnMM.Click += new System.EventHandler(this.button_click);
            // 
            // btnML
            // 
            this.btnML.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F);
            this.btnML.Location = new System.Drawing.Point(35, 96);
            this.btnML.Name = "btnML";
            this.btnML.Size = new System.Drawing.Size(52, 52);
            this.btnML.TabIndex = 15;
            this.btnML.UseVisualStyleBackColor = true;
            this.btnML.Visible = false;
            this.btnML.Click += new System.EventHandler(this.button_click);
            // 
            // btnLR
            // 
            this.btnLR.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLR.Location = new System.Drawing.Point(151, 154);
            this.btnLR.Name = "btnLR";
            this.btnLR.Size = new System.Drawing.Size(52, 52);
            this.btnLR.TabIndex = 20;
            this.btnLR.UseVisualStyleBackColor = true;
            this.btnLR.Visible = false;
            this.btnLR.Click += new System.EventHandler(this.button_click);
            // 
            // btnLM
            // 
            this.btnLM.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F);
            this.btnLM.Location = new System.Drawing.Point(93, 154);
            this.btnLM.Name = "btnLM";
            this.btnLM.Size = new System.Drawing.Size(52, 52);
            this.btnLM.TabIndex = 19;
            this.btnLM.UseVisualStyleBackColor = true;
            this.btnLM.Visible = false;
            this.btnLM.Click += new System.EventHandler(this.button_click);
            // 
            // btnLL
            // 
            this.btnLL.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F);
            this.btnLL.Location = new System.Drawing.Point(35, 154);
            this.btnLL.Name = "btnLL";
            this.btnLL.Size = new System.Drawing.Size(52, 52);
            this.btnLL.TabIndex = 18;
            this.btnLL.UseVisualStyleBackColor = true;
            this.btnLL.Visible = false;
            this.btnLL.Click += new System.EventHandler(this.button_click);
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.aboutMenu});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(234, 24);
            this.menu.TabIndex = 21;
            this.menu.Text = "menuStrip1";
            // 
            // menuFile
            // 
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuNew,
            this.menuExit});
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(37, 20);
            this.menuFile.Text = "File";
            // 
            // menuNew
            // 
            this.menuNew.Name = "menuNew";
            this.menuNew.Size = new System.Drawing.Size(132, 22);
            this.menuNew.Text = "New Game";
            this.menuNew.Click += new System.EventHandler(this.menuNew_Click);
            // 
            // menuExit
            // 
            this.menuExit.Name = "menuExit";
            this.menuExit.Size = new System.Drawing.Size(132, 22);
            this.menuExit.Text = "Exit";
            this.menuExit.Click += new System.EventHandler(this.menuExit_Click);
            // 
            // btnNewGame
            // 
            this.btnNewGame.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewGame.Location = new System.Drawing.Point(67, 69);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(104, 30);
            this.btnNewGame.TabIndex = 22;
            this.btnNewGame.Text = "New Game";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(67, 119);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(104, 31);
            this.btnExit.TabIndex = 23;
            this.btnExit.Text = "Exit Game";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // aboutMenu
            // 
            this.aboutMenu.Name = "aboutMenu";
            this.aboutMenu.Size = new System.Drawing.Size(52, 20);
            this.aboutMenu.Text = "About";
            this.aboutMenu.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(234, 225);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.btnLR);
            this.Controls.Add(this.btnLM);
            this.Controls.Add(this.btnLL);
            this.Controls.Add(this.btnMR);
            this.Controls.Add(this.btnMM);
            this.Controls.Add(this.btnML);
            this.Controls.Add(this.btnUR);
            this.Controls.Add(this.btnUM);
            this.Controls.Add(this.btnUL);
            this.Controls.Add(this.menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.AlphaFull;
            this.MainMenuStrip = this.menu;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tick Tack Toe";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnUL;
        private System.Windows.Forms.Button btnUM;
        private System.Windows.Forms.Button btnUR;
        private System.Windows.Forms.Button btnMR;
        private System.Windows.Forms.Button btnMM;
        private System.Windows.Forms.Button btnML;
        private System.Windows.Forms.Button btnLR;
        private System.Windows.Forms.Button btnLM;
        private System.Windows.Forms.Button btnLL;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem menuNew;
        private System.Windows.Forms.ToolStripMenuItem menuExit;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ToolStripMenuItem aboutMenu;
    }
}

