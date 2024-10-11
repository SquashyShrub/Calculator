namespace Assignment_4._1._2
{
    partial class Calculator
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
            panel1 = new Panel();
            txtDisplay = new TextBox();
            calculatorButtonsGroup = new GroupBox();
            negativeButton = new Button();
            oneButton = new Button();
            fourButton = new Button();
            percentButton = new Button();
            sevenButton = new Button();
            threeButton = new Button();
            historyButton = new Button();
            fractionButton = new Button();
            squaredButton = new Button();
            squareRootButton = new Button();
            divideButton = new Button();
            periodButton = new Button();
            equalsButton = new Button();
            plusButton = new Button();
            subtractButton = new Button();
            multiplyButton = new Button();
            sixButton = new Button();
            clearButton = new Button();
            nineButton = new Button();
            zeroButton = new Button();
            twoButton = new Button();
            clearEverythingButton = new Button();
            fiveButton = new Button();
            eightButton = new Button();
            historyGroupBox = new GroupBox();
            hideHistoryButton = new Button();
            historyList = new ListBox();
            panel1.SuspendLayout();
            calculatorButtonsGroup.SuspendLayout();
            historyGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 128, 0);
            panel1.Controls.Add(txtDisplay);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(242, 47);
            panel1.TabIndex = 0;
            // 
            // txtDisplay
            // 
            txtDisplay.BackColor = Color.FromArgb(255, 128, 0);
            txtDisplay.BorderStyle = BorderStyle.FixedSingle;
            txtDisplay.Font = new Font("Lucida Console", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDisplay.Location = new Point(6, 3);
            txtDisplay.Name = "txtDisplay";
            txtDisplay.Size = new Size(230, 42);
            txtDisplay.TabIndex = 0;
            txtDisplay.TextAlign = HorizontalAlignment.Right;
            // 
            // calculatorButtonsGroup
            // 
            calculatorButtonsGroup.Controls.Add(negativeButton);
            calculatorButtonsGroup.Controls.Add(oneButton);
            calculatorButtonsGroup.Controls.Add(fourButton);
            calculatorButtonsGroup.Controls.Add(percentButton);
            calculatorButtonsGroup.Controls.Add(sevenButton);
            calculatorButtonsGroup.Controls.Add(threeButton);
            calculatorButtonsGroup.Controls.Add(historyButton);
            calculatorButtonsGroup.Controls.Add(fractionButton);
            calculatorButtonsGroup.Controls.Add(squaredButton);
            calculatorButtonsGroup.Controls.Add(squareRootButton);
            calculatorButtonsGroup.Controls.Add(divideButton);
            calculatorButtonsGroup.Controls.Add(periodButton);
            calculatorButtonsGroup.Controls.Add(equalsButton);
            calculatorButtonsGroup.Controls.Add(plusButton);
            calculatorButtonsGroup.Controls.Add(subtractButton);
            calculatorButtonsGroup.Controls.Add(multiplyButton);
            calculatorButtonsGroup.Controls.Add(sixButton);
            calculatorButtonsGroup.Controls.Add(clearButton);
            calculatorButtonsGroup.Controls.Add(nineButton);
            calculatorButtonsGroup.Controls.Add(zeroButton);
            calculatorButtonsGroup.Controls.Add(twoButton);
            calculatorButtonsGroup.Controls.Add(clearEverythingButton);
            calculatorButtonsGroup.Controls.Add(fiveButton);
            calculatorButtonsGroup.Controls.Add(eightButton);
            calculatorButtonsGroup.FlatStyle = FlatStyle.Flat;
            calculatorButtonsGroup.Font = new Font("Lucida Console", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            calculatorButtonsGroup.ForeColor = SystemColors.ControlText;
            calculatorButtonsGroup.Location = new Point(12, 65);
            calculatorButtonsGroup.Name = "calculatorButtonsGroup";
            calculatorButtonsGroup.Size = new Size(242, 280);
            calculatorButtonsGroup.TabIndex = 1;
            calculatorButtonsGroup.TabStop = false;
            // 
            // negativeButton
            // 
            negativeButton.BackColor = Color.Silver;
            negativeButton.FlatAppearance.BorderColor = Color.DimGray;
            negativeButton.FlatStyle = FlatStyle.Flat;
            negativeButton.Location = new Point(7, 231);
            negativeButton.Name = "negativeButton";
            negativeButton.Size = new Size(53, 40);
            negativeButton.TabIndex = 0;
            negativeButton.Text = "(-)";
            negativeButton.UseVisualStyleBackColor = false;
            negativeButton.Click += negativeButton_Click;
            // 
            // oneButton
            // 
            oneButton.BackColor = Color.Silver;
            oneButton.FlatAppearance.BorderColor = Color.DimGray;
            oneButton.FlatStyle = FlatStyle.Flat;
            oneButton.Font = new Font("Lucida Console", 15.75F, FontStyle.Bold);
            oneButton.Location = new Point(6, 185);
            oneButton.Name = "oneButton";
            oneButton.Size = new Size(53, 40);
            oneButton.TabIndex = 0;
            oneButton.Text = "1";
            oneButton.UseVisualStyleBackColor = false;
            oneButton.Click += oneButton_Click;
            // 
            // fourButton
            // 
            fourButton.BackColor = Color.Silver;
            fourButton.FlatAppearance.BorderColor = Color.DimGray;
            fourButton.FlatStyle = FlatStyle.Flat;
            fourButton.Font = new Font("Lucida Console", 15.75F, FontStyle.Bold);
            fourButton.Location = new Point(6, 139);
            fourButton.Name = "fourButton";
            fourButton.Size = new Size(53, 40);
            fourButton.TabIndex = 0;
            fourButton.Text = "4";
            fourButton.UseVisualStyleBackColor = false;
            fourButton.Click += fourButton_Click;
            // 
            // percentButton
            // 
            percentButton.BackColor = Color.Silver;
            percentButton.FlatAppearance.BorderColor = Color.DimGray;
            percentButton.FlatStyle = FlatStyle.Flat;
            percentButton.Location = new Point(6, 47);
            percentButton.Name = "percentButton";
            percentButton.Size = new Size(53, 40);
            percentButton.TabIndex = 0;
            percentButton.Text = "%";
            percentButton.UseVisualStyleBackColor = false;
            percentButton.Click += percentButton_Click;
            // 
            // sevenButton
            // 
            sevenButton.BackColor = Color.Silver;
            sevenButton.FlatAppearance.BorderColor = Color.DimGray;
            sevenButton.FlatStyle = FlatStyle.Flat;
            sevenButton.Font = new Font("Lucida Console", 15.75F, FontStyle.Bold);
            sevenButton.Location = new Point(6, 93);
            sevenButton.Name = "sevenButton";
            sevenButton.Size = new Size(53, 40);
            sevenButton.TabIndex = 0;
            sevenButton.Text = "7";
            sevenButton.UseVisualStyleBackColor = false;
            sevenButton.Click += sevenButton_Click;
            // 
            // threeButton
            // 
            threeButton.BackColor = Color.Silver;
            threeButton.FlatAppearance.BorderColor = Color.DimGray;
            threeButton.FlatStyle = FlatStyle.Flat;
            threeButton.Font = new Font("Lucida Console", 15.75F, FontStyle.Bold);
            threeButton.Location = new Point(126, 185);
            threeButton.Name = "threeButton";
            threeButton.Size = new Size(53, 40);
            threeButton.TabIndex = 0;
            threeButton.Text = "3";
            threeButton.UseVisualStyleBackColor = false;
            threeButton.Click += threeButton_Click;
            // 
            // historyButton
            // 
            historyButton.BackColor = Color.Silver;
            historyButton.FlatAppearance.BorderColor = Color.DimGray;
            historyButton.FlatStyle = FlatStyle.Flat;
            historyButton.Font = new Font("Lucida Console", 6.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            historyButton.ForeColor = Color.MediumBlue;
            historyButton.Location = new Point(8, 15);
            historyButton.Name = "historyButton";
            historyButton.Size = new Size(53, 26);
            historyButton.TabIndex = 0;
            historyButton.Text = "History";
            historyButton.UseVisualStyleBackColor = false;
            historyButton.Click += historyButton_Click;
            // 
            // fractionButton
            // 
            fractionButton.BackColor = Color.Silver;
            fractionButton.FlatAppearance.BorderColor = Color.DimGray;
            fractionButton.FlatStyle = FlatStyle.Flat;
            fractionButton.Location = new Point(67, 15);
            fractionButton.Name = "fractionButton";
            fractionButton.Size = new Size(53, 26);
            fractionButton.TabIndex = 0;
            fractionButton.Text = "1/x";
            fractionButton.UseVisualStyleBackColor = false;
            fractionButton.Click += fractionButton_Click;
            // 
            // squaredButton
            // 
            squaredButton.BackColor = Color.Silver;
            squaredButton.FlatAppearance.BorderColor = Color.DimGray;
            squaredButton.FlatStyle = FlatStyle.Flat;
            squaredButton.Location = new Point(126, 15);
            squaredButton.Name = "squaredButton";
            squaredButton.Size = new Size(53, 26);
            squaredButton.TabIndex = 0;
            squaredButton.Text = "x^2";
            squaredButton.UseVisualStyleBackColor = false;
            squaredButton.Click += squaredButton_Click;
            // 
            // squareRootButton
            // 
            squareRootButton.BackColor = Color.Silver;
            squareRootButton.FlatAppearance.BorderColor = Color.DimGray;
            squareRootButton.FlatStyle = FlatStyle.Flat;
            squareRootButton.Location = new Point(183, 15);
            squareRootButton.Name = "squareRootButton";
            squareRootButton.Size = new Size(53, 26);
            squareRootButton.TabIndex = 0;
            squareRootButton.Text = "√";
            squareRootButton.UseVisualStyleBackColor = false;
            squareRootButton.Click += squareRootButton_Click;
            // 
            // divideButton
            // 
            divideButton.BackColor = Color.Silver;
            divideButton.FlatAppearance.BorderColor = Color.DimGray;
            divideButton.FlatStyle = FlatStyle.Flat;
            divideButton.Location = new Point(183, 47);
            divideButton.Name = "divideButton";
            divideButton.Size = new Size(53, 40);
            divideButton.TabIndex = 0;
            divideButton.Text = "÷";
            divideButton.UseVisualStyleBackColor = false;
            divideButton.Click += divideButton_Click;
            // 
            // periodButton
            // 
            periodButton.BackColor = Color.Silver;
            periodButton.FlatAppearance.BorderColor = Color.DimGray;
            periodButton.FlatStyle = FlatStyle.Flat;
            periodButton.Location = new Point(126, 231);
            periodButton.Name = "periodButton";
            periodButton.Size = new Size(53, 40);
            periodButton.TabIndex = 0;
            periodButton.Text = ".";
            periodButton.UseVisualStyleBackColor = false;
            periodButton.Click += periodButton_Click;
            // 
            // equalsButton
            // 
            equalsButton.BackColor = Color.Silver;
            equalsButton.FlatAppearance.BorderColor = Color.DimGray;
            equalsButton.FlatStyle = FlatStyle.Flat;
            equalsButton.Location = new Point(183, 231);
            equalsButton.Name = "equalsButton";
            equalsButton.Size = new Size(53, 40);
            equalsButton.TabIndex = 0;
            equalsButton.Text = "=";
            equalsButton.UseVisualStyleBackColor = false;
            equalsButton.Click += equalsButton_Click;
            // 
            // plusButton
            // 
            plusButton.BackColor = Color.Silver;
            plusButton.FlatAppearance.BorderColor = Color.DimGray;
            plusButton.FlatStyle = FlatStyle.Flat;
            plusButton.Location = new Point(183, 185);
            plusButton.Name = "plusButton";
            plusButton.Size = new Size(53, 40);
            plusButton.TabIndex = 0;
            plusButton.Text = "+";
            plusButton.UseVisualStyleBackColor = false;
            plusButton.Click += plusButton_Click;
            // 
            // subtractButton
            // 
            subtractButton.BackColor = Color.Silver;
            subtractButton.FlatAppearance.BorderColor = Color.DimGray;
            subtractButton.FlatStyle = FlatStyle.Flat;
            subtractButton.Location = new Point(183, 139);
            subtractButton.Name = "subtractButton";
            subtractButton.Size = new Size(53, 40);
            subtractButton.TabIndex = 0;
            subtractButton.Text = "-";
            subtractButton.UseVisualStyleBackColor = false;
            subtractButton.Click += subtractButton_Click;
            // 
            // multiplyButton
            // 
            multiplyButton.BackColor = Color.Silver;
            multiplyButton.FlatAppearance.BorderColor = Color.DimGray;
            multiplyButton.FlatStyle = FlatStyle.Flat;
            multiplyButton.Font = new Font("Lucida Console", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            multiplyButton.Location = new Point(183, 93);
            multiplyButton.Name = "multiplyButton";
            multiplyButton.Size = new Size(53, 40);
            multiplyButton.TabIndex = 0;
            multiplyButton.Text = "X";
            multiplyButton.UseVisualStyleBackColor = false;
            multiplyButton.Click += multiplyButton_Click;
            // 
            // sixButton
            // 
            sixButton.BackColor = Color.Silver;
            sixButton.FlatAppearance.BorderColor = Color.DimGray;
            sixButton.FlatStyle = FlatStyle.Flat;
            sixButton.Font = new Font("Lucida Console", 15.75F, FontStyle.Bold);
            sixButton.Location = new Point(126, 139);
            sixButton.Name = "sixButton";
            sixButton.Size = new Size(53, 40);
            sixButton.TabIndex = 0;
            sixButton.Text = "6";
            sixButton.UseVisualStyleBackColor = false;
            sixButton.Click += sixButton_Click;
            // 
            // clearButton
            // 
            clearButton.BackColor = Color.Silver;
            clearButton.FlatAppearance.BorderColor = Color.DimGray;
            clearButton.FlatStyle = FlatStyle.Flat;
            clearButton.ForeColor = Color.Red;
            clearButton.Location = new Point(126, 47);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(53, 40);
            clearButton.TabIndex = 0;
            clearButton.Text = "C";
            clearButton.UseVisualStyleBackColor = false;
            clearButton.Click += clearButton_Click;
            // 
            // nineButton
            // 
            nineButton.BackColor = Color.Silver;
            nineButton.FlatAppearance.BorderColor = Color.DimGray;
            nineButton.FlatStyle = FlatStyle.Flat;
            nineButton.Font = new Font("Lucida Console", 15.75F, FontStyle.Bold);
            nineButton.Location = new Point(126, 93);
            nineButton.Name = "nineButton";
            nineButton.Size = new Size(53, 40);
            nineButton.TabIndex = 0;
            nineButton.Text = "9";
            nineButton.UseVisualStyleBackColor = false;
            nineButton.Click += nineButton_Click;
            // 
            // zeroButton
            // 
            zeroButton.BackColor = Color.Silver;
            zeroButton.FlatAppearance.BorderColor = Color.DimGray;
            zeroButton.FlatStyle = FlatStyle.Flat;
            zeroButton.Font = new Font("Lucida Console", 15.75F, FontStyle.Bold);
            zeroButton.Location = new Point(66, 231);
            zeroButton.Name = "zeroButton";
            zeroButton.Size = new Size(53, 40);
            zeroButton.TabIndex = 0;
            zeroButton.Text = "0";
            zeroButton.UseVisualStyleBackColor = false;
            zeroButton.Click += zeroButton_Click;
            // 
            // twoButton
            // 
            twoButton.BackColor = Color.Silver;
            twoButton.FlatAppearance.BorderColor = Color.DimGray;
            twoButton.FlatStyle = FlatStyle.Flat;
            twoButton.Font = new Font("Lucida Console", 15.75F, FontStyle.Bold);
            twoButton.Location = new Point(66, 185);
            twoButton.Name = "twoButton";
            twoButton.Size = new Size(53, 40);
            twoButton.TabIndex = 0;
            twoButton.Text = "2";
            twoButton.UseVisualStyleBackColor = false;
            twoButton.Click += twoButton_Click;
            // 
            // clearEverythingButton
            // 
            clearEverythingButton.BackColor = Color.Silver;
            clearEverythingButton.FlatAppearance.BorderColor = Color.DimGray;
            clearEverythingButton.FlatStyle = FlatStyle.Flat;
            clearEverythingButton.ForeColor = Color.Red;
            clearEverythingButton.Location = new Point(66, 47);
            clearEverythingButton.Name = "clearEverythingButton";
            clearEverythingButton.Size = new Size(53, 40);
            clearEverythingButton.TabIndex = 0;
            clearEverythingButton.Text = "CE";
            clearEverythingButton.UseVisualStyleBackColor = false;
            clearEverythingButton.Click += clearEverythingButton_Click;
            // 
            // fiveButton
            // 
            fiveButton.BackColor = Color.Silver;
            fiveButton.FlatAppearance.BorderColor = Color.DimGray;
            fiveButton.FlatStyle = FlatStyle.Flat;
            fiveButton.Font = new Font("Lucida Console", 15.75F, FontStyle.Bold);
            fiveButton.Location = new Point(66, 139);
            fiveButton.Name = "fiveButton";
            fiveButton.Size = new Size(53, 40);
            fiveButton.TabIndex = 0;
            fiveButton.Text = "5";
            fiveButton.UseVisualStyleBackColor = false;
            fiveButton.Click += fiveButton_Click;
            // 
            // eightButton
            // 
            eightButton.BackColor = Color.Silver;
            eightButton.FlatAppearance.BorderColor = Color.DimGray;
            eightButton.FlatStyle = FlatStyle.Flat;
            eightButton.Font = new Font("Lucida Console", 15.75F, FontStyle.Bold);
            eightButton.Location = new Point(66, 93);
            eightButton.Name = "eightButton";
            eightButton.Size = new Size(53, 40);
            eightButton.TabIndex = 0;
            eightButton.Text = "8";
            eightButton.UseVisualStyleBackColor = false;
            eightButton.Click += eightButton_Click;
            // 
            // historyGroupBox
            // 
            historyGroupBox.BackColor = Color.DimGray;
            historyGroupBox.Controls.Add(hideHistoryButton);
            historyGroupBox.Controls.Add(historyList);
            historyGroupBox.FlatStyle = FlatStyle.Flat;
            historyGroupBox.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            historyGroupBox.ForeColor = Color.Cornsilk;
            historyGroupBox.Location = new Point(12, 112);
            historyGroupBox.Name = "historyGroupBox";
            historyGroupBox.Size = new Size(242, 233);
            historyGroupBox.TabIndex = 1;
            historyGroupBox.TabStop = false;
            historyGroupBox.Text = "History";
            // 
            // hideHistoryButton
            // 
            hideHistoryButton.BackColor = Color.Transparent;
            hideHistoryButton.FlatStyle = FlatStyle.Flat;
            hideHistoryButton.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            hideHistoryButton.ForeColor = Color.Black;
            hideHistoryButton.Location = new Point(216, 210);
            hideHistoryButton.Name = "hideHistoryButton";
            hideHistoryButton.Size = new Size(26, 23);
            hideHistoryButton.TabIndex = 1;
            hideHistoryButton.Text = "\\/";
            hideHistoryButton.UseVisualStyleBackColor = false;
            hideHistoryButton.Click += hideHistoryButton_Click;
            // 
            // historyList
            // 
            historyList.AccessibleName = "";
            historyList.BackColor = SystemColors.WindowFrame;
            historyList.BorderStyle = BorderStyle.None;
            historyList.ForeColor = SystemColors.InactiveCaptionText;
            historyList.FormattingEnabled = true;
            historyList.ItemHeight = 20;
            historyList.Location = new Point(6, 26);
            historyList.Name = "historyList";
            historyList.Size = new Size(230, 200);
            historyList.TabIndex = 0;
            // 
            // Calculator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(266, 357);
            Controls.Add(historyGroupBox);
            Controls.Add(calculatorButtonsGroup);
            Controls.Add(panel1);
            Name = "Calculator";
            Text = "Calculator";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            calculatorButtonsGroup.ResumeLayout(false);
            historyGroupBox.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private GroupBox calculatorButtonsGroup;

        private Button oneButton;
        private Button fourButton;
        private Button percentButton;
        private Button sevenButton;

        private Button threeButton;

        private Button divideButton;
        private Button multiplyButton;
        private Button sixButton;
        private Button clearButton;
        private Button nineButton;
        private Button zeroButton;
        private Button twoButton;
        private Button clearEverythingButton;
        private Button fiveButton;
        private Button eightButton;
        private Button negativeButton;
        private Button periodButton;
        private Button equalsButton;
        private Button plusButton;
        private Button subtractButton;
        private TextBox txtDisplay;
        private Button historyButton;
        private Button fractionButton;
        private Button squaredButton;
        private Button squareRootButton;
        private GroupBox historyGroupBox;
        private ListBox historyList;
        private Button hideHistoryButton;
    }
}
