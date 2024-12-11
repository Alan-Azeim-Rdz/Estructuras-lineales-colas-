namespace Estructuras_lineales_colas_
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
            BtnAddTurn = new Button();
            BtnServeTurn = new Button();
            LstBoxQueue = new ListBox();
            LstBoxServedTurns = new ListBox();
            TxtDishName = new TextBox();
            TxtDishPrice = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // BtnAddTurn
            // 
            BtnAddTurn.Location = new Point(21, 137);
            BtnAddTurn.Name = "BtnAddTurn";
            BtnAddTurn.Size = new Size(113, 46);
            BtnAddTurn.TabIndex = 0;
            BtnAddTurn.Text = "Add";
            BtnAddTurn.UseVisualStyleBackColor = true;
            BtnAddTurn.Click += BtnAddTurn_Click_1;
            // 
            // BtnServeTurn
            // 
            BtnServeTurn.Location = new Point(21, 283);
            BtnServeTurn.Name = "BtnServeTurn";
            BtnServeTurn.Size = new Size(113, 45);
            BtnServeTurn.TabIndex = 1;
            BtnServeTurn.Text = "Serv";
            BtnServeTurn.UseVisualStyleBackColor = true;
            BtnServeTurn.Click += BtnServeTurn_Click;
            // 
            // LstBoxQueue
            // 
            LstBoxQueue.FormattingEnabled = true;
            LstBoxQueue.ItemHeight = 15;
            LstBoxQueue.Location = new Point(256, 36);
            LstBoxQueue.Name = "LstBoxQueue";
            LstBoxQueue.Size = new Size(164, 379);
            LstBoxQueue.TabIndex = 2;
            // 
            // LstBoxServedTurns
            // 
            LstBoxServedTurns.FormattingEnabled = true;
            LstBoxServedTurns.ItemHeight = 15;
            LstBoxServedTurns.Location = new Point(459, 36);
            LstBoxServedTurns.Name = "LstBoxServedTurns";
            LstBoxServedTurns.Size = new Size(167, 379);
            LstBoxServedTurns.TabIndex = 3;
            // 
            // TxtDishName
            // 
            TxtDishName.Location = new Point(57, 21);
            TxtDishName.Name = "TxtDishName";
            TxtDishName.Size = new Size(171, 23);
            TxtDishName.TabIndex = 4;
            // 
            // TxtDishPrice
            // 
            TxtDishPrice.Location = new Point(57, 69);
            TxtDishPrice.Name = "TxtDishPrice";
            TxtDishPrice.Size = new Size(171, 23);
            TxtDishPrice.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 24);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 6;
            label1.Text = "saucer";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 77);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 7;
            label2.Text = "Price";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(665, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(TxtDishPrice);
            Controls.Add(TxtDishName);
            Controls.Add(LstBoxServedTurns);
            Controls.Add(LstBoxQueue);
            Controls.Add(BtnServeTurn);
            Controls.Add(BtnAddTurn);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnAddTurn;
        private Button BtnServeTurn;
        private ListBox LstBoxQueue;
        private ListBox LstBoxServedTurns;
        private TextBox TxtDishName;
        private TextBox TxtDishPrice;
        private Label label1;
        private Label label2;
    }
}
