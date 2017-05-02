namespace Estimating_Energy
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series13 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series14 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series15 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series16 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series17 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series18 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series19 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series20 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.StartHr = new System.Windows.Forms.ComboBox();
            this.StartMin = new System.Windows.Forms.ComboBox();
            this.EndHr = new System.Windows.Forms.ComboBox();
            this.EndMin = new System.Windows.Forms.ComboBox();
            this.SelectDevice = new System.Windows.Forms.ComboBox();
            this.SelectTariff = new System.Windows.Forms.ComboBox();
            this.Added_Devices = new System.Windows.Forms.ListBox();
            this.Add_Estimate_btn = new System.Windows.Forms.Button();
            this.Remove_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Icon = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Power_txt = new System.Windows.Forms.TextBox();
            this.Calculate_btn = new System.Windows.Forms.Button();
            this.Total_Energy = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Total_Cost = new System.Windows.Forms.TextBox();
            this.Clear_btn = new System.Windows.Forms.Button();
            this.Energy_Graph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label7 = new System.Windows.Forms.Label();
            this.Generate_Graph_btn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Energy_Graph)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // StartHr
            // 
            this.StartHr.FormattingEnabled = true;
            this.StartHr.Location = new System.Drawing.Point(291, 51);
            this.StartHr.Name = "StartHr";
            this.StartHr.Size = new System.Drawing.Size(35, 21);
            this.StartHr.TabIndex = 3;
            this.StartHr.Text = "00";
            // 
            // StartMin
            // 
            this.StartMin.FormattingEnabled = true;
            this.StartMin.Location = new System.Drawing.Point(334, 51);
            this.StartMin.Name = "StartMin";
            this.StartMin.Size = new System.Drawing.Size(37, 21);
            this.StartMin.TabIndex = 4;
            this.StartMin.Text = "00";
            // 
            // EndHr
            // 
            this.EndHr.FormattingEnabled = true;
            this.EndHr.Location = new System.Drawing.Point(291, 79);
            this.EndHr.Name = "EndHr";
            this.EndHr.Size = new System.Drawing.Size(35, 21);
            this.EndHr.TabIndex = 5;
            this.EndHr.Text = "00";
            // 
            // EndMin
            // 
            this.EndMin.FormattingEnabled = true;
            this.EndMin.Location = new System.Drawing.Point(335, 79);
            this.EndMin.Name = "EndMin";
            this.EndMin.Size = new System.Drawing.Size(36, 21);
            this.EndMin.TabIndex = 6;
            this.EndMin.Text = "00";
            // 
            // SelectDevice
            // 
            this.SelectDevice.FormattingEnabled = true;
            this.SelectDevice.Location = new System.Drawing.Point(6, 28);
            this.SelectDevice.Name = "SelectDevice";
            this.SelectDevice.Size = new System.Drawing.Size(121, 21);
            this.SelectDevice.TabIndex = 7;
            this.SelectDevice.Text = "Select Device";
            this.SelectDevice.SelectedIndexChanged += new System.EventHandler(this.SelectDevice_SelectedIndexChanged);
            // 
            // SelectTariff
            // 
            this.SelectTariff.FormattingEnabled = true;
            this.SelectTariff.Location = new System.Drawing.Point(6, 59);
            this.SelectTariff.Name = "SelectTariff";
            this.SelectTariff.Size = new System.Drawing.Size(121, 21);
            this.SelectTariff.TabIndex = 8;
            this.SelectTariff.Text = "Select Tariff";
            this.SelectTariff.SelectedIndexChanged += new System.EventHandler(this.SelectTariff_SelectedIndexChanged);
            // 
            // Added_Devices
            // 
            this.Added_Devices.FormattingEnabled = true;
            this.Added_Devices.Location = new System.Drawing.Point(476, 12);
            this.Added_Devices.Name = "Added_Devices";
            this.Added_Devices.Size = new System.Drawing.Size(208, 95);
            this.Added_Devices.TabIndex = 9;
            this.Added_Devices.SelectedIndexChanged += new System.EventHandler(this.Added_Items_SelectedIndexChanged);
            // 
            // Add_Estimate_btn
            // 
            this.Add_Estimate_btn.Location = new System.Drawing.Point(377, 54);
            this.Add_Estimate_btn.Name = "Add_Estimate_btn";
            this.Add_Estimate_btn.Size = new System.Drawing.Size(75, 44);
            this.Add_Estimate_btn.TabIndex = 10;
            this.Add_Estimate_btn.Text = "Add to Estimate";
            this.Add_Estimate_btn.UseVisualStyleBackColor = true;
            this.Add_Estimate_btn.Click += new System.EventHandler(this.Add_Estimate_btn_Click);
            // 
            // Remove_btn
            // 
            this.Remove_btn.Location = new System.Drawing.Point(696, 118);
            this.Remove_btn.Name = "Remove_btn";
            this.Remove_btn.Size = new System.Drawing.Size(208, 44);
            this.Remove_btn.TabIndex = 11;
            this.Remove_btn.Text = "Remove From Estimate";
            this.Remove_btn.UseVisualStyleBackColor = true;
            this.Remove_btn.Click += new System.EventHandler(this.Remove_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(227, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Device On";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(227, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Device Off";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Icon);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.Power_txt);
            this.groupBox1.Controls.Add(this.Add_Estimate_btn);
            this.groupBox1.Controls.Add(this.StartHr);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.StartMin);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.EndHr);
            this.groupBox1.Controls.Add(this.SelectTariff);
            this.groupBox1.Controls.Add(this.EndMin);
            this.groupBox1.Controls.Add(this.SelectDevice);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(458, 149);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Device Selection";
            // 
            // Icon
            // 
            this.Icon.Location = new System.Drawing.Point(134, 54);
            this.Icon.Name = "Icon";
            this.Icon.Size = new System.Drawing.Size(87, 89);
            this.Icon.TabIndex = 18;
            this.Icon.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(181, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "W/h";
            // 
            // Power_txt
            // 
            this.Power_txt.Location = new System.Drawing.Point(134, 28);
            this.Power_txt.Name = "Power_txt";
            this.Power_txt.Size = new System.Drawing.Size(40, 20);
            this.Power_txt.TabIndex = 16;
            // 
            // Calculate_btn
            // 
            this.Calculate_btn.Location = new System.Drawing.Point(6, 28);
            this.Calculate_btn.Name = "Calculate_btn";
            this.Calculate_btn.Size = new System.Drawing.Size(75, 23);
            this.Calculate_btn.TabIndex = 21;
            this.Calculate_btn.Text = "Calculate";
            this.Calculate_btn.UseVisualStyleBackColor = true;
            this.Calculate_btn.Click += new System.EventHandler(this.Calculate_btn_Click);
            // 
            // Total_Energy
            // 
            this.Total_Energy.Location = new System.Drawing.Point(84, 30);
            this.Total_Energy.Name = "Total_Energy";
            this.Total_Energy.Size = new System.Drawing.Size(100, 20);
            this.Total_Energy.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(188, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Watts";
            // 
            // Total_Cost
            // 
            this.Total_Cost.Location = new System.Drawing.Point(84, 60);
            this.Total_Cost.Name = "Total_Cost";
            this.Total_Cost.Size = new System.Drawing.Size(100, 20);
            this.Total_Cost.TabIndex = 24;
            // 
            // Clear_btn
            // 
            this.Clear_btn.Location = new System.Drawing.Point(6, 57);
            this.Clear_btn.Name = "Clear_btn";
            this.Clear_btn.Size = new System.Drawing.Size(75, 23);
            this.Clear_btn.TabIndex = 25;
            this.Clear_btn.Text = "Clear All";
            this.Clear_btn.UseVisualStyleBackColor = true;
            this.Clear_btn.Click += new System.EventHandler(this.Clear_btn_Click);
            // 
            // Energy_Graph
            // 
            this.Energy_Graph.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea2.Name = "ChartArea1";
            this.Energy_Graph.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.Energy_Graph.Legends.Add(legend2);
            this.Energy_Graph.Location = new System.Drawing.Point(12, 168);
            this.Energy_Graph.Name = "Energy_Graph";
            series11.BorderWidth = 3;
            series11.ChartArea = "ChartArea1";
            series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series11.Legend = "Legend1";
            series11.Name = "Television";
            series12.BorderWidth = 3;
            series12.ChartArea = "ChartArea1";
            series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series12.Legend = "Legend1";
            series12.Name = "Desktop";
            series13.BorderWidth = 3;
            series13.ChartArea = "ChartArea1";
            series13.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series13.Legend = "Legend1";
            series13.Name = "Laptop";
            series14.BorderWidth = 3;
            series14.ChartArea = "ChartArea1";
            series14.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series14.Legend = "Legend1";
            series14.Name = "Oven";
            series15.BorderWidth = 3;
            series15.ChartArea = "ChartArea1";
            series15.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series15.Legend = "Legend1";
            series15.Name = "Washing Machine";
            series16.BorderWidth = 3;
            series16.ChartArea = "ChartArea1";
            series16.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series16.Legend = "Legend1";
            series16.Name = "Lights";
            series17.BorderWidth = 3;
            series17.ChartArea = "ChartArea1";
            series17.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series17.Legend = "Legend1";
            series17.Name = "Dishwasher";
            series18.BorderWidth = 3;
            series18.ChartArea = "ChartArea1";
            series18.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series18.Legend = "Legend1";
            series18.Name = "Central Heating";
            series19.BorderWidth = 3;
            series19.ChartArea = "ChartArea1";
            series19.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series19.Legend = "Legend1";
            series19.Name = "Tumble Dryer";
            series20.BorderWidth = 3;
            series20.ChartArea = "ChartArea1";
            series20.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series20.Legend = "Legend1";
            series20.Name = "Mobile Phone Charger";
            this.Energy_Graph.Series.Add(series11);
            this.Energy_Graph.Series.Add(series12);
            this.Energy_Graph.Series.Add(series13);
            this.Energy_Graph.Series.Add(series14);
            this.Energy_Graph.Series.Add(series15);
            this.Energy_Graph.Series.Add(series16);
            this.Energy_Graph.Series.Add(series17);
            this.Energy_Graph.Series.Add(series18);
            this.Energy_Graph.Series.Add(series19);
            this.Energy_Graph.Series.Add(series20);
            this.Energy_Graph.Size = new System.Drawing.Size(911, 470);
            this.Energy_Graph.TabIndex = 26;
            this.Energy_Graph.Text = "chart1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(188, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "£";
            // 
            // Generate_Graph_btn
            // 
            this.Generate_Graph_btn.Location = new System.Drawing.Point(476, 120);
            this.Generate_Graph_btn.Name = "Generate_Graph_btn";
            this.Generate_Graph_btn.Size = new System.Drawing.Size(208, 41);
            this.Generate_Graph_btn.TabIndex = 16;
            this.Generate_Graph_btn.Text = "Generate Graph";
            this.Generate_Graph_btn.UseVisualStyleBackColor = true;
            this.Generate_Graph_btn.Click += new System.EventHandler(this.Generate_Graph_btn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Calculate_btn);
            this.groupBox2.Controls.Add(this.Clear_btn);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.Total_Energy);
            this.groupBox2.Controls.Add(this.Total_Cost);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(690, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(238, 100);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Total Cost and Usage for 25 Hour Period";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(332, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Mins";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(288, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Hrs";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 650);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Generate_Graph_btn);
            this.Controls.Add(this.Energy_Graph);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Remove_btn);
            this.Controls.Add(this.Added_Devices);
            this.Name = "Form1";
            this.Text = "Domestic Energy Estimator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Energy_Graph)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox StartHr;
        private System.Windows.Forms.ComboBox StartMin;
        private System.Windows.Forms.ComboBox EndHr;
        private System.Windows.Forms.ComboBox EndMin;
        private System.Windows.Forms.ComboBox SelectDevice;
        private System.Windows.Forms.ComboBox SelectTariff;
        private System.Windows.Forms.ListBox Added_Devices;
        private System.Windows.Forms.Button Add_Estimate_btn;
        private System.Windows.Forms.Button Remove_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Power_txt;
        private System.Windows.Forms.Button Calculate_btn;
        private System.Windows.Forms.TextBox Total_Energy;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Total_Cost;
        private System.Windows.Forms.Button Clear_btn;
        private System.Windows.Forms.DataVisualization.Charting.Chart Energy_Graph;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox Icon;
        private System.Windows.Forms.Button Generate_Graph_btn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;

    }
}

