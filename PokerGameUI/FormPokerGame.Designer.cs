using System.Windows.Forms;
using PokerGameLogic;

namespace PokerGameUI
{
    partial class FormPokerGame
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.buttonPlayerCard1 = new System.Windows.Forms.Button();
            this.buttonPlayerCard2 = new System.Windows.Forms.Button();
            this.buttonRaise = new System.Windows.Forms.Button();
            this.buttonFold = new System.Windows.Forms.Button();
            this.buttonMakeEqual = new System.Windows.Forms.Button();
            this.textBoxRaiseAmount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelCurrentPlayer = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelAmountToEqual = new System.Windows.Forms.Label();
            this.labelMoneyOnBoard = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(111, 282);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 160);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(240, 282);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 160);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(360, 282);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(114, 160);
            this.button3.TabIndex = 2;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(480, 282);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(114, 160);
            this.button4.TabIndex = 3;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(600, 282);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(114, 160);
            this.button5.TabIndex = 4;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // buttonPlayerCard1
            // 
            this.buttonPlayerCard1.Location = new System.Drawing.Point(508, 120);
            this.buttonPlayerCard1.Name = "buttonPlayerCard1";
            this.buttonPlayerCard1.Size = new System.Drawing.Size(92, 135);
            this.buttonPlayerCard1.TabIndex = 5;
            this.buttonPlayerCard1.UseVisualStyleBackColor = true;
            // 
            // buttonPlayerCard2
            // 
            this.buttonPlayerCard2.Location = new System.Drawing.Point(622, 120);
            this.buttonPlayerCard2.Name = "buttonPlayerCard2";
            this.buttonPlayerCard2.Size = new System.Drawing.Size(92, 135);
            this.buttonPlayerCard2.TabIndex = 6;
            this.buttonPlayerCard2.UseVisualStyleBackColor = true;
            // 
            // buttonRaise
            // 
            this.buttonRaise.Location = new System.Drawing.Point(393, 595);
            this.buttonRaise.Name = "buttonRaise";
            this.buttonRaise.Size = new System.Drawing.Size(114, 43);
            this.buttonRaise.TabIndex = 9;
            this.buttonRaise.Text = "Raise By";
            this.buttonRaise.UseVisualStyleBackColor = true;
            // 
            // buttonFold
            // 
            this.buttonFold.Location = new System.Drawing.Point(258, 595);
            this.buttonFold.Name = "buttonFold";
            this.buttonFold.Size = new System.Drawing.Size(114, 43);
            this.buttonFold.TabIndex = 8;
            this.buttonFold.Text = "Fold";
            this.buttonFold.UseVisualStyleBackColor = true;
            // 
            // buttonMakeEqual
            // 
            this.buttonMakeEqual.Location = new System.Drawing.Point(129, 595);
            this.buttonMakeEqual.Name = "buttonMakeEqual";
            this.buttonMakeEqual.Size = new System.Drawing.Size(114, 43);
            this.buttonMakeEqual.TabIndex = 7;
            this.buttonMakeEqual.Text = "Equal";
            this.buttonMakeEqual.UseVisualStyleBackColor = true;
            this.buttonMakeEqual.Click += new System.EventHandler(this.buttonMakeEqual_Click);
            // 
            // textBoxRaiseAmount
            // 
            this.textBoxRaiseAmount.Location = new System.Drawing.Point(524, 605);
            this.textBoxRaiseAmount.Name = "textBoxRaiseAmount";
            this.textBoxRaiseAmount.Size = new System.Drawing.Size(126, 22);
            this.textBoxRaiseAmount.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 510);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Current player\'s turn:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelCurrentPlayer
            // 
            this.labelCurrentPlayer.AutoSize = true;
            this.labelCurrentPlayer.Location = new System.Drawing.Point(280, 510);
            this.labelCurrentPlayer.Name = "labelCurrentPlayer";
            this.labelCurrentPlayer.Size = new System.Drawing.Size(0, 17);
            this.labelCurrentPlayer.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(128, 563);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Amount to equal:";
            // 
            // labelAmountToEqual
            // 
            this.labelAmountToEqual.AutoSize = true;
            this.labelAmountToEqual.Location = new System.Drawing.Point(257, 563);
            this.labelAmountToEqual.Name = "labelAmountToEqual";
            this.labelAmountToEqual.Size = new System.Drawing.Size(0, 17);
            this.labelAmountToEqual.TabIndex = 14;
            // 
            // labelMoneyOnBoard
            // 
            this.labelMoneyOnBoard.AutoSize = true;
            this.labelMoneyOnBoard.Location = new System.Drawing.Point(274, 223);
            this.labelMoneyOnBoard.Name = "labelMoneyOnBoard";
            this.labelMoneyOnBoard.Size = new System.Drawing.Size(0, 17);
            this.labelMoneyOnBoard.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(145, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Money on board:";
            // 
            // FormPokerGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 678);
            this.Controls.Add(this.labelMoneyOnBoard);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelAmountToEqual);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelCurrentPlayer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxRaiseAmount);
            this.Controls.Add(this.buttonRaise);
            this.Controls.Add(this.buttonFold);
            this.Controls.Add(this.buttonMakeEqual);
            this.Controls.Add(this.buttonPlayerCard2);
            this.Controls.Add(this.buttonPlayerCard1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "FormPokerGame";
            this.Text = "Poker Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button buttonPlayerCard1;
        private Button buttonPlayerCard2;
        private Button buttonRaise;
        private Button buttonFold;
        private Button buttonMakeEqual;
        private TextBox textBoxRaiseAmount;
        private Label label1;
        private Label labelCurrentPlayer;
        private Label label2;
        public Label labelAmountToEqual;
        public Label labelMoneyOnBoard;
        private Label label4;
    }
}