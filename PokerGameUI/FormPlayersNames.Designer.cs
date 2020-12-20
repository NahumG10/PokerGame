namespace PokerGameUI
{
    partial class FormPlayersNames
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
            this.m_LabelFirstPlayerName = new System.Windows.Forms.Label();
            this.TextBoxPlayerName = new System.Windows.Forms.TextBox();
            this.buttonSubmitPlayerName = new System.Windows.Forms.Button();
            this.buttonCancelRegistry = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // m_LabelFirstPlayerName
            // 
            this.m_LabelFirstPlayerName.AutoSize = true;
            this.m_LabelFirstPlayerName.Location = new System.Drawing.Point(32, 40);
            this.m_LabelFirstPlayerName.Name = "m_LabelFirstPlayerName";
            this.m_LabelFirstPlayerName.Size = new System.Drawing.Size(93, 17);
            this.m_LabelFirstPlayerName.TabIndex = 4;
            this.m_LabelFirstPlayerName.Text = "Player Name:";
            // 
            // TextBoxPlayerName
            // 
            this.TextBoxPlayerName.Location = new System.Drawing.Point(243, 37);
            this.TextBoxPlayerName.Name = "TextBoxPlayerName";
            this.TextBoxPlayerName.Size = new System.Drawing.Size(154, 22);
            this.TextBoxPlayerName.TabIndex = 3;
            // 
            // buttonSubmitPlayerName
            // 
            this.buttonSubmitPlayerName.Location = new System.Drawing.Point(51, 85);
            this.buttonSubmitPlayerName.Name = "buttonSubmitPlayerName";
            this.buttonSubmitPlayerName.Size = new System.Drawing.Size(346, 37);
            this.buttonSubmitPlayerName.TabIndex = 5;
            this.buttonSubmitPlayerName.Text = "Add";
            this.buttonSubmitPlayerName.UseVisualStyleBackColor = true;
            this.buttonSubmitPlayerName.Click += new System.EventHandler(this.buttonSubmitPlayerName_Click);
            // 
            // buttonCancelRegistry
            // 
            this.buttonCancelRegistry.Location = new System.Drawing.Point(159, 147);
            this.buttonCancelRegistry.Name = "buttonCancelRegistry";
            this.buttonCancelRegistry.Size = new System.Drawing.Size(120, 37);
            this.buttonCancelRegistry.TabIndex = 6;
            this.buttonCancelRegistry.Text = "Cancel";
            this.buttonCancelRegistry.UseVisualStyleBackColor = true;
            this.buttonCancelRegistry.Click += new System.EventHandler(this.buttonCancelRegistry_Click);
            // 
            // FormPlayersNames
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 216);
            this.ControlBox = false;
            this.Controls.Add(this.buttonCancelRegistry);
            this.Controls.Add(this.buttonSubmitPlayerName);
            this.Controls.Add(this.m_LabelFirstPlayerName);
            this.Controls.Add(this.TextBoxPlayerName);
            this.Name = "FormPlayersNames";
            this.Text = "PlayersNamesForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label m_LabelFirstPlayerName;
        private System.Windows.Forms.TextBox TextBoxPlayerName;
        public System.Windows.Forms.Button buttonSubmitPlayerName;
        private System.Windows.Forms.Button buttonCancelRegistry;
    }
}