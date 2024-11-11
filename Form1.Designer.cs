namespace zd3_v1_Mezenceva_Polina
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
            textBoxWidth = new TextBox();
            textBoxLength = new TextBox();
            textBoxRoadMass = new TextBox();
            textBoxLocation = new TextBox();
            loadButton = new Button();
            dataGridViewRoadWorks = new DataGridView();
            removeButton1 = new Button();
            removeButton2 = new Button();
            removeButtom3 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBoxIndex = new TextBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            textBoxTraffic = new TextBox();
            textBoxServiceLife = new TextBox();
            textBoxYear = new TextBox();
            buttonQ = new Button();
            label10 = new Label();
            comboBoxP = new ComboBox();
            buttonSearchType = new Button();
            comboBoxSearchType = new ComboBox();
            comboBoxType = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRoadWorks).BeginInit();
            SuspendLayout();
            // 
            // textBoxWidth
            // 
            textBoxWidth.Location = new Point(30, 42);
            textBoxWidth.Name = "textBoxWidth";
            textBoxWidth.Size = new Size(133, 27);
            textBoxWidth.TabIndex = 0;
            textBoxWidth.Text = "10";
            // 
            // textBoxLength
            // 
            textBoxLength.Location = new Point(30, 101);
            textBoxLength.Name = "textBoxLength";
            textBoxLength.Size = new Size(133, 27);
            textBoxLength.TabIndex = 1;
            textBoxLength.Text = "35000";
            // 
            // textBoxRoadMass
            // 
            textBoxRoadMass.Location = new Point(30, 179);
            textBoxRoadMass.Name = "textBoxRoadMass";
            textBoxRoadMass.Size = new Size(133, 27);
            textBoxRoadMass.TabIndex = 2;
            textBoxRoadMass.Text = "250";
            // 
            // textBoxLocation
            // 
            textBoxLocation.Location = new Point(227, 42);
            textBoxLocation.Name = "textBoxLocation";
            textBoxLocation.Size = new Size(133, 27);
            textBoxLocation.TabIndex = 3;
            textBoxLocation.Text = "Курган";
            // 
            // loadButton
            // 
            loadButton.BackColor = Color.DarkSeaGreen;
            loadButton.Location = new Point(612, 40);
            loadButton.Name = "loadButton";
            loadButton.Size = new Size(133, 29);
            loadButton.TabIndex = 6;
            loadButton.Text = "Загрузить";
            loadButton.UseVisualStyleBackColor = false;
            loadButton.Click += loadButton_Click;
            // 
            // dataGridViewRoadWorks
            // 
            dataGridViewRoadWorks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRoadWorks.Dock = DockStyle.Bottom;
            dataGridViewRoadWorks.Location = new Point(0, 223);
            dataGridViewRoadWorks.Name = "dataGridViewRoadWorks";
            dataGridViewRoadWorks.RowHeadersWidth = 51;
            dataGridViewRoadWorks.Size = new Size(1198, 291);
            dataGridViewRoadWorks.TabIndex = 5;
            dataGridViewRoadWorks.SelectionChanged += dataGridViewRoadWorks_SelectionChanged;
            // 
            // removeButton1
            // 
            removeButton1.BackColor = Color.DarkSeaGreen;
            removeButton1.Location = new Point(612, 88);
            removeButton1.Name = "removeButton1";
            removeButton1.Size = new Size(131, 29);
            removeButton1.TabIndex = 8;
            removeButton1.Text = "Удалить(1)";
            removeButton1.UseVisualStyleBackColor = false;
            removeButton1.Click += removeButton1_Click;
            // 
            // removeButton2
            // 
            removeButton2.BackColor = Color.DarkSeaGreen;
            removeButton2.Location = new Point(612, 132);
            removeButton2.Name = "removeButton2";
            removeButton2.Size = new Size(131, 29);
            removeButton2.TabIndex = 9;
            removeButton2.Text = "Удалить(2)";
            removeButton2.UseVisualStyleBackColor = false;
            removeButton2.Click += removeButton2_Click;
            // 
            // removeButtom3
            // 
            removeButtom3.BackColor = Color.DarkSeaGreen;
            removeButtom3.Location = new Point(612, 177);
            removeButtom3.Name = "removeButtom3";
            removeButtom3.Size = new Size(131, 29);
            removeButtom3.TabIndex = 0;
            removeButtom3.Text = "Удалить(3)";
            removeButtom3.UseVisualStyleBackColor = false;
            removeButtom3.Click += removeButton3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 19);
            label1.Name = "label1";
            label1.Size = new Size(146, 20);
            label1.TabIndex = 12;
            label1.Text = "Ширина дороги (м)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 77);
            label2.Name = "label2";
            label2.Size = new Size(132, 20);
            label2.TabIndex = 13;
            label2.Text = "Длина дороги (м)";
            // 
            // label3
            // 
            label3.Location = new Point(30, 135);
            label3.Name = "label3";
            label3.Size = new Size(174, 40);
            label3.TabIndex = 14;
            label3.Text = "Масса дорожного покрытия на 1 кв.м. (кг)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(227, 19);
            label4.Name = "label4";
            label4.Size = new Size(132, 20);
            label4.TabIndex = 15;
            label4.Text = "Местоположение";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(227, 78);
            label5.Name = "label5";
            label5.Size = new Size(190, 20);
            label5.TabIndex = 16;
            label5.Text = "Тип дорожного покрытия";
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 7.5F);
            label6.Location = new Point(227, 140);
            label6.Name = "label6";
            label6.Size = new Size(204, 37);
            label6.TabIndex = 17;
            label6.Text = "Коэф. прочности в зависимости от погодных условий (P)";
            // 
            // textBoxIndex
            // 
            textBoxIndex.Location = new Point(748, 136);
            textBoxIndex.Name = "textBoxIndex";
            textBoxIndex.Size = new Size(76, 27);
            textBoxIndex.TabIndex = 18;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F);
            label7.Location = new Point(442, 156);
            label7.Name = "label7";
            label7.Size = new Size(134, 20);
            label7.TabIndex = 24;
            label7.Text = "Трафик движения\r\n";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(442, 78);
            label8.Name = "label8";
            label8.Size = new Size(141, 20);
            label8.TabIndex = 23;
            label8.Text = "Срок эксплуатации";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(442, 19);
            label9.Name = "label9";
            label9.Size = new Size(158, 20);
            label9.TabIndex = 22;
            label9.Text = "Год окончания работ";
            // 
            // textBoxTraffic
            // 
            textBoxTraffic.Location = new Point(442, 179);
            textBoxTraffic.Name = "textBoxTraffic";
            textBoxTraffic.Size = new Size(133, 27);
            textBoxTraffic.TabIndex = 21;
            textBoxTraffic.Text = "4";
            // 
            // textBoxServiceLife
            // 
            textBoxServiceLife.Location = new Point(442, 101);
            textBoxServiceLife.Name = "textBoxServiceLife";
            textBoxServiceLife.Size = new Size(133, 27);
            textBoxServiceLife.TabIndex = 20;
            textBoxServiceLife.Text = "40 лет";
            // 
            // textBoxYear
            // 
            textBoxYear.Location = new Point(442, 42);
            textBoxYear.Name = "textBoxYear";
            textBoxYear.Size = new Size(133, 27);
            textBoxYear.TabIndex = 19;
            textBoxYear.Text = "2023";
            // 
            // buttonQ
            // 
            buttonQ.BackColor = Color.DarkSeaGreen;
            buttonQ.Location = new Point(860, 35);
            buttonQ.Name = "buttonQ";
            buttonQ.Size = new Size(133, 171);
            buttonQ.TabIndex = 27;
            buttonQ.Text = "Вывести информацию о выделенном объекте";
            buttonQ.UseVisualStyleBackColor = false;
            buttonQ.Click += buttonQ_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 6F);
            label10.Location = new Point(748, 122);
            label10.Name = "label10";
            label10.Size = new Size(40, 12);
            label10.TabIndex = 28;
            label10.Text = "Индекс:";
            // 
            // comboBoxP
            // 
            comboBoxP.FormattingEnabled = true;
            comboBoxP.Items.AddRange(new object[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            comboBoxP.Location = new Point(227, 180);
            comboBoxP.Name = "comboBoxP";
            comboBoxP.Size = new Size(133, 28);
            comboBoxP.TabIndex = 29;
            // 
            // buttonSearchType
            // 
            buttonSearchType.BackColor = Color.DarkSeaGreen;
            buttonSearchType.Location = new Point(1027, 35);
            buttonSearchType.Name = "buttonSearchType";
            buttonSearchType.Size = new Size(133, 123);
            buttonSearchType.TabIndex = 30;
            buttonSearchType.Text = "Вывести список объектов по выбранному критерию ";
            buttonSearchType.UseVisualStyleBackColor = false;
            buttonSearchType.Click += button1_Click;
            // 
            // comboBoxSearchType
            // 
            comboBoxSearchType.FormattingEnabled = true;
            comboBoxSearchType.Items.AddRange(new object[] { "Асфальт", "Щебень" });
            comboBoxSearchType.Location = new Point(1026, 178);
            comboBoxSearchType.Name = "comboBoxSearchType";
            comboBoxSearchType.Size = new Size(133, 28);
            comboBoxSearchType.TabIndex = 31;
            // 
            // comboBoxType
            // 
            comboBoxType.FormattingEnabled = true;
            comboBoxType.Items.AddRange(new object[] { "Асфальт", "Щебень" });
            comboBoxType.Location = new Point(227, 100);
            comboBoxType.Name = "comboBoxType";
            comboBoxType.Size = new Size(133, 28);
            comboBoxType.TabIndex = 32;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1198, 514);
            Controls.Add(comboBoxType);
            Controls.Add(comboBoxSearchType);
            Controls.Add(buttonSearchType);
            Controls.Add(comboBoxP);
            Controls.Add(label10);
            Controls.Add(buttonQ);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(textBoxTraffic);
            Controls.Add(textBoxServiceLife);
            Controls.Add(textBoxYear);
            Controls.Add(textBoxIndex);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(removeButton2);
            Controls.Add(removeButtom3);
            Controls.Add(removeButton1);
            Controls.Add(loadButton);
            Controls.Add(dataGridViewRoadWorks);
            Controls.Add(textBoxLocation);
            Controls.Add(textBoxRoadMass);
            Controls.Add(textBoxLength);
            Controls.Add(textBoxWidth);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewRoadWorks).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxWidth;
        private TextBox textBoxLength;
        private TextBox textBoxRoadMass;
        private TextBox textBoxLocation;
        private TextBox textBoxType;
        private Button loadButton;
        private DataGridView dataGridViewRoadWorks;
        private Button removeButton1;
        private Button removeButton2;
        private Button removeButtom3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBoxIndex;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox textBoxTraffic;
        private TextBox textBoxServiceLife;
        private TextBox textBoxYear;
        private Button buttonQ;
        private Label label10;
        private ComboBox comboBoxP;
        private Button buttonSearchType;
        private ComboBox comboBoxSearchType;
        private ComboBox comboBoxType;
    }
}
