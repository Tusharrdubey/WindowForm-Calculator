namespace frmCalculator
{
    partial class frmCalculator
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
            splitContainer1 = new SplitContainer();
            txtLastOperationHistory = new TextBox();
            txtResult = new TextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            button1 = new Button();
            btnDecimal = new Button();
            btnEqualTo = new Button();
            btnAdd = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            btnSubtract = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            btnMultiplication = new Button();
            button13 = new Button();
            button14 = new Button();
            button15 = new Button();
            btnDivision = new Button();
            btnChangeSign = new Button();
            btnBack = new Button();
            btnC = new Button();
            btnCE = new Button();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Margin = new Padding(4);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(txtLastOperationHistory);
            splitContainer1.Panel1.Controls.Add(txtResult);
            splitContainer1.Panel1.Padding = new Padding(3);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(tableLayoutPanel1);
            splitContainer1.Size = new Size(334, 401);
            splitContainer1.SplitterDistance = 80;
            splitContainer1.SplitterWidth = 6;
            splitContainer1.TabIndex = 0;
            // 
            // txtLastOperationHistory
            // 
            txtLastOperationHistory.BackColor = SystemColors.ScrollBar;
            txtLastOperationHistory.Dock = DockStyle.Bottom;
            txtLastOperationHistory.Location = new Point(3, 48);
            txtLastOperationHistory.Name = "txtLastOperationHistory";
            txtLastOperationHistory.Size = new Size(328, 29);
            txtLastOperationHistory.TabIndex = 1;
            txtLastOperationHistory.TextAlign = HorizontalAlignment.Right;
            // 
            // txtResult
            // 
            txtResult.AccessibleName = "txtResult";
            txtResult.BackColor = SystemColors.Control;
            txtResult.Dock = DockStyle.Fill;
            txtResult.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            txtResult.Location = new Point(3, 3);
            txtResult.Margin = new Padding(4);
            txtResult.Multiline = true;
            txtResult.Name = "txtResult";
            txtResult.ReadOnly = true;
            txtResult.Size = new Size(328, 74);
            txtResult.TabIndex = 0;
            txtResult.TextAlign = HorizontalAlignment.Right;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(button1, 0, 4);
            tableLayoutPanel1.Controls.Add(btnDecimal, 1, 4);
            tableLayoutPanel1.Controls.Add(btnEqualTo, 2, 4);
            tableLayoutPanel1.Controls.Add(btnAdd, 3, 4);
            tableLayoutPanel1.Controls.Add(button5, 0, 3);
            tableLayoutPanel1.Controls.Add(button6, 1, 3);
            tableLayoutPanel1.Controls.Add(button7, 2, 3);
            tableLayoutPanel1.Controls.Add(btnSubtract, 3, 3);
            tableLayoutPanel1.Controls.Add(button9, 0, 2);
            tableLayoutPanel1.Controls.Add(button10, 1, 2);
            tableLayoutPanel1.Controls.Add(button11, 2, 2);
            tableLayoutPanel1.Controls.Add(btnMultiplication, 3, 2);
            tableLayoutPanel1.Controls.Add(button13, 0, 1);
            tableLayoutPanel1.Controls.Add(button14, 1, 1);
            tableLayoutPanel1.Controls.Add(button15, 2, 1);
            tableLayoutPanel1.Controls.Add(btnDivision, 3, 1);
            tableLayoutPanel1.Controls.Add(btnChangeSign, 0, 0);
            tableLayoutPanel1.Controls.Add(btnBack, 1, 0);
            tableLayoutPanel1.Controls.Add(btnC, 2, 0);
            tableLayoutPanel1.Controls.Add(btnCE, 3, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Size = new Size(334, 315);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.AccessibleName = "btn0";
            button1.BackColor = SystemColors.ButtonShadow;
            button1.Dock = DockStyle.Fill;
            button1.Location = new Point(3, 255);
            button1.Name = "button1";
            button1.Size = new Size(77, 57);
            button1.TabIndex = 0;
            button1.Text = "0";
            button1.UseVisualStyleBackColor = false;
            button1.Click += btnArgument_Click;
            // 
            // btnDecimal
            // 
            btnDecimal.AccessibleName = "btnDecimal";
            btnDecimal.BackColor = SystemColors.ButtonShadow;
            btnDecimal.Dock = DockStyle.Fill;
            btnDecimal.Location = new Point(86, 255);
            btnDecimal.Name = "btnDecimal";
            btnDecimal.Size = new Size(77, 57);
            btnDecimal.TabIndex = 1;
            btnDecimal.Text = ".";
            btnDecimal.UseVisualStyleBackColor = false;
            btnDecimal.Click += btnArgument_Click;
            // 
            // btnEqualTo
            // 
            btnEqualTo.AccessibleName = "btnEqualTo";
            btnEqualTo.BackColor = SystemColors.ButtonShadow;
            btnEqualTo.Dock = DockStyle.Fill;
            btnEqualTo.Location = new Point(169, 255);
            btnEqualTo.Name = "btnEqualTo";
            btnEqualTo.Size = new Size(77, 57);
            btnEqualTo.TabIndex = 2;
            btnEqualTo.Text = "=";
            btnEqualTo.UseVisualStyleBackColor = false;
            btnEqualTo.Click += btnOperator_Click;
            // 
            // btnAdd
            // 
            btnAdd.AccessibleName = "btnAdd";
            btnAdd.BackColor = SystemColors.ButtonShadow;
            btnAdd.Dock = DockStyle.Fill;
            btnAdd.Location = new Point(252, 255);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(79, 57);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnOperator_Click;
            // 
            // button5
            // 
            button5.AccessibleName = "btn1";
            button5.BackColor = SystemColors.ButtonShadow;
            button5.Dock = DockStyle.Fill;
            button5.Location = new Point(3, 192);
            button5.Name = "button5";
            button5.Size = new Size(77, 57);
            button5.TabIndex = 4;
            button5.Text = "1";
            button5.UseVisualStyleBackColor = false;
            button5.Click += btnArgument_Click;
            // 
            // button6
            // 
            button6.AccessibleName = "btn2";
            button6.BackColor = SystemColors.ButtonShadow;
            button6.Dock = DockStyle.Fill;
            button6.Location = new Point(86, 192);
            button6.Name = "button6";
            button6.Size = new Size(77, 57);
            button6.TabIndex = 5;
            button6.Text = "2";
            button6.UseVisualStyleBackColor = false;
            button6.Click += btnArgument_Click;
            // 
            // button7
            // 
            button7.AccessibleName = "btn3";
            button7.BackColor = SystemColors.ButtonShadow;
            button7.Dock = DockStyle.Fill;
            button7.Location = new Point(169, 192);
            button7.Name = "button7";
            button7.Size = new Size(77, 57);
            button7.TabIndex = 6;
            button7.Text = "3";
            button7.UseVisualStyleBackColor = false;
            button7.Click += btnArgument_Click;
            // 
            // btnSubtract
            // 
            btnSubtract.AccessibleName = "btnSubtract";
            btnSubtract.BackColor = SystemColors.ButtonShadow;
            btnSubtract.Dock = DockStyle.Fill;
            btnSubtract.Location = new Point(252, 192);
            btnSubtract.Name = "btnSubtract";
            btnSubtract.Size = new Size(79, 57);
            btnSubtract.TabIndex = 7;
            btnSubtract.Text = "-";
            btnSubtract.UseVisualStyleBackColor = false;
            btnSubtract.Click += btnOperator_Click;
            // 
            // button9
            // 
            button9.AccessibleName = "btn4";
            button9.BackColor = SystemColors.ButtonShadow;
            button9.Dock = DockStyle.Fill;
            button9.Location = new Point(3, 129);
            button9.Name = "button9";
            button9.Size = new Size(77, 57);
            button9.TabIndex = 8;
            button9.Text = "4";
            button9.UseVisualStyleBackColor = false;
            button9.Click += btnArgument_Click;
            // 
            // button10
            // 
            button10.AccessibleName = "btn5";
            button10.BackColor = SystemColors.ButtonShadow;
            button10.Dock = DockStyle.Fill;
            button10.Location = new Point(86, 129);
            button10.Name = "button10";
            button10.Size = new Size(77, 57);
            button10.TabIndex = 9;
            button10.Text = "5";
            button10.UseVisualStyleBackColor = false;
            button10.Click += btnArgument_Click;
            // 
            // button11
            // 
            button11.AccessibleName = "btn6";
            button11.BackColor = SystemColors.ButtonShadow;
            button11.Dock = DockStyle.Fill;
            button11.Location = new Point(169, 129);
            button11.Name = "button11";
            button11.Size = new Size(77, 57);
            button11.TabIndex = 10;
            button11.Text = "6";
            button11.UseVisualStyleBackColor = false;
            button11.Click += btnArgument_Click;
            // 
            // btnMultiplication
            // 
            btnMultiplication.AccessibleName = "btnMultiplication";
            btnMultiplication.BackColor = SystemColors.ButtonShadow;
            btnMultiplication.Dock = DockStyle.Fill;
            btnMultiplication.Location = new Point(252, 129);
            btnMultiplication.Name = "btnMultiplication";
            btnMultiplication.Size = new Size(79, 57);
            btnMultiplication.TabIndex = 11;
            btnMultiplication.Text = "*";
            btnMultiplication.UseVisualStyleBackColor = false;
            btnMultiplication.Click += btnOperator_Click;
            // 
            // button13
            // 
            button13.AccessibleName = "btn7";
            button13.BackColor = SystemColors.ButtonShadow;
            button13.Dock = DockStyle.Fill;
            button13.Location = new Point(3, 66);
            button13.Name = "button13";
            button13.Size = new Size(77, 57);
            button13.TabIndex = 12;
            button13.Text = "7";
            button13.UseVisualStyleBackColor = false;
            button13.Click += btnArgument_Click;
            // 
            // button14
            // 
            button14.AccessibleName = "btn8";
            button14.BackColor = SystemColors.ButtonShadow;
            button14.Dock = DockStyle.Fill;
            button14.Location = new Point(86, 66);
            button14.Name = "button14";
            button14.Size = new Size(77, 57);
            button14.TabIndex = 13;
            button14.Text = "8";
            button14.UseVisualStyleBackColor = false;
            button14.Click += btnArgument_Click;
            // 
            // button15
            // 
            button15.AccessibleName = "btn9";
            button15.BackColor = SystemColors.ButtonShadow;
            button15.Dock = DockStyle.Fill;
            button15.Location = new Point(169, 66);
            button15.Name = "button15";
            button15.Size = new Size(77, 57);
            button15.TabIndex = 14;
            button15.Text = "9";
            button15.UseVisualStyleBackColor = false;
            button15.Click += btnArgument_Click;
            // 
            // btnDivision
            // 
            btnDivision.AccessibleName = "btnDivision";
            btnDivision.BackColor = SystemColors.ButtonShadow;
            btnDivision.Dock = DockStyle.Fill;
            btnDivision.Location = new Point(252, 66);
            btnDivision.Name = "btnDivision";
            btnDivision.Size = new Size(79, 57);
            btnDivision.TabIndex = 15;
            btnDivision.Text = "/";
            btnDivision.UseVisualStyleBackColor = false;
            btnDivision.Click += btnOperator_Click;
            // 
            // btnChangeSign
            // 
            btnChangeSign.AccessibleName = "btnChangeSign";
            btnChangeSign.BackColor = SystemColors.ButtonShadow;
            btnChangeSign.Dock = DockStyle.Fill;
            btnChangeSign.Location = new Point(3, 3);
            btnChangeSign.Name = "btnChangeSign";
            btnChangeSign.Padding = new Padding(3);
            btnChangeSign.Size = new Size(77, 57);
            btnChangeSign.TabIndex = 16;
            btnChangeSign.Text = "+/-";
            btnChangeSign.UseVisualStyleBackColor = false;
            btnChangeSign.Click += btnChangeSign_Click;
            // 
            // btnBack
            // 
            btnBack.AccessibleName = "btnBack";
            btnBack.BackColor = SystemColors.ButtonShadow;
            btnBack.Dock = DockStyle.Fill;
            btnBack.Location = new Point(86, 3);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(77, 57);
            btnBack.TabIndex = 17;
            btnBack.Text = "<";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnC
            // 
            btnC.AccessibleName = "btnC";
            btnC.BackColor = SystemColors.ButtonShadow;
            btnC.Dock = DockStyle.Fill;
            btnC.Location = new Point(169, 3);
            btnC.Name = "btnC";
            btnC.Size = new Size(77, 57);
            btnC.TabIndex = 18;
            btnC.Text = "C";
            btnC.UseVisualStyleBackColor = false;
            btnC.Click += btnC_Click;
            // 
            // btnCE
            // 
            btnCE.AccessibleName = "btnCE";
            btnCE.BackColor = SystemColors.ButtonShadow;
            btnCE.Dock = DockStyle.Fill;
            btnCE.Location = new Point(252, 3);
            btnCE.Name = "btnCE";
            btnCE.Size = new Size(79, 57);
            btnCE.TabIndex = 19;
            btnCE.Text = "CE";
            btnCE.UseVisualStyleBackColor = false;
            btnCE.Click += btnCE_Click;
            // 
            // frmCalculator
            // 
            AccessibleName = "frmCalculator";
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(334, 401);
            Controls.Add(splitContainer1);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "frmCalculator";
            Text = "Calculator";
            Load += Form1_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private TextBox txtResult;
        private TableLayoutPanel tableLayoutPanel1;
        private Button button1;
        private Button btnDecimal;
        private Button btnEqualTo;
        private Button btnAdd;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button btnSubtract;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button btnMultiplication;
        private Button button13;
        private Button button14;
        private Button button15;
        private Button btnDivision;
        private Button btnChangeSign;
        private Button btnBack;
        private Button btnC;
        private Button btnCE;
        private TextBox txtLastOperationHistory;
    }
}
