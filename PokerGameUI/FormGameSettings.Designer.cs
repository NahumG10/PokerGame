namespace PokerGameUI
{
    partial class FormGameSettings
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
            this.comboBoxNumOfPlayers = new System.Windows.Forms.ComboBox();
            this.labelNumOfPlayers = new System.Windows.Forms.Label();
            this.buttonRegisterPlayers = new System.Windows.Forms.Button();
            this.listViewPlayersNames = new System.Windows.Forms.ListView();
            this.buttonStartGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxNumOfPlayers
            // 
            this.comboBoxNumOfPlayers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNumOfPlayers.FormattingEnabled = true;
            this.comboBoxNumOfPlayers.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboBoxNumOfPlayers.Location = new System.Drawing.Point(359, 89);
            this.comboBoxNumOfPlayers.Name = "comboBoxNumOfPlayers";
            this.comboBoxNumOfPlayers.Size = new System.Drawing.Size(121, 24);
            this.comboBoxNumOfPlayers.TabIndex = 0;
            // 
            // labelNumOfPlayers
            // 
            this.labelNumOfPlayers.AutoSize = true;
            this.labelNumOfPlayers.Location = new System.Drawing.Point(101, 92);
            this.labelNumOfPlayers.Name = "labelNumOfPlayers";
            this.labelNumOfPlayers.Size = new System.Drawing.Size(166, 17);
            this.labelNumOfPlayers.TabIndex = 1;
            this.labelNumOfPlayers.Text = "Enter Number Of Players";
            // 
            // buttonRegisterPlayers
            // 
            this.buttonRegisterPlayers.Location = new System.Drawing.Point(359, 135);
            this.buttonRegisterPlayers.Name = "buttonRegisterPlayers";
            this.buttonRegisterPlayers.Size = new System.Drawing.Size(130, 45);
            this.buttonRegisterPlayers.TabIndex = 2;
            this.buttonRegisterPlayers.Text = "Register Players";
            this.buttonRegisterPlayers.UseVisualStyleBackColor = true;
            this.buttonRegisterPlayers.Click += new System.EventHandler(this.buttonRegisterPlayers_Click);
            // 
            // listViewPlayersNames
            // 
            this.listViewPlayersNames.HideSelection = false;
            this.listViewPlayersNames.Location = new System.Drawing.Point(86, 212);
            this.listViewPlayersNames.Name = "listViewPlayersNames";
            this.listViewPlayersNames.Size = new System.Drawing.Size(199, 75);
            this.listViewPlayersNames.TabIndex = 3;
            this.listViewPlayersNames.UseCompatibleStateImageBehavior = false;
            // 
            // buttonStartGame
            // 
            this.buttonStartGame.Location = new System.Drawing.Point(348, 222);
            this.buttonStartGame.Name = "buttonStartGame";
            this.buttonStartGame.Size = new System.Drawing.Size(156, 65);
            this.buttonStartGame.TabIndex = 4;
            this.buttonStartGame.Text = "Start Game";
            this.buttonStartGame.UseVisualStyleBackColor = true;
            this.buttonStartGame.Click += new System.EventHandler(this.buttonStartGame_Click);
            // 
            // FormGameSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 525);
            this.Controls.Add(this.buttonStartGame);
            this.Controls.Add(this.listViewPlayersNames);
            this.Controls.Add(this.buttonRegisterPlayers);
            this.Controls.Add(this.labelNumOfPlayers);
            this.Controls.Add(this.comboBoxNumOfPlayers);
            this.Name = "FormGameSettings";
            this.Text = "Game Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxNumOfPlayers;
        private System.Windows.Forms.Label labelNumOfPlayers;
        private System.Windows.Forms.Button buttonRegisterPlayers;
        private System.Windows.Forms.ListView listViewPlayersNames;
        private System.Windows.Forms.Button buttonStartGame;
    }
}

