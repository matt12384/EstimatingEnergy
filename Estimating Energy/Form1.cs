using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estimating_Energy
{
    public partial class Form1 : Form
    {
        public double P1, P2, P3;
        public double H1, H2, M1, M2;
        public double t1, t2, T;
        public double tariff, cost;
        public bool z;

        string user_text, TV_Coords, Desktop_Coords, Laptop_Coords, 
            Oven_Coords, WM_Coords, Lights_Coords, Dishwasher_Coords, 
            CH_Coords, TD_Coords, MPC_Coords;
        string FILE_NAME = "user_text.dat";
        string FILE_NAME3 = "TV_Coords.dat";
        string FILE_NAME4 = "Desktop_Coords.dat";
        string FILE_NAME5 = "Laptop_Coords.dat";
        string FILE_NAME6 = "Oven_Coords.dat";
        string FILE_NAME7 = "WM_Coords.dat";
        string FILE_NAME8 = "Lights_Coords.dat";
        string FILE_NAME9 = "Dishwasher_Coords.dat";
        string FILE_NAME10 = "CH_Coords.dat";
        string FILE_NAME11 = "TD_Coords.dat";
        string FILE_NAME12 = "MPC_Coords.dat";
        string FILE_NAME13 = "Total_Coords.dat";

        public Form1()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;

            Power_txt.ReadOnly = true;
            Total_Energy.ReadOnly = true;
            Total_Cost.ReadOnly = true;

            Add_Estimate_btn.Enabled = false;
            Remove_btn.Enabled = false;

            StartHr.Items.Add("00");
            StartHr.Items.Add("01");
            StartHr.Items.Add("02");
            StartHr.Items.Add("03");
            StartHr.Items.Add("04");
            StartHr.Items.Add("05");
            StartHr.Items.Add("06");
            StartHr.Items.Add("07");
            StartHr.Items.Add("08");
            StartHr.Items.Add("09");
            StartHr.Items.Add("10");
            StartHr.Items.Add("11");
            StartHr.Items.Add("12");
            StartHr.Items.Add("13");
            StartHr.Items.Add("14");
            StartHr.Items.Add("15");
            StartHr.Items.Add("16");
            StartHr.Items.Add("17");
            StartHr.Items.Add("18");
            StartHr.Items.Add("19");
            StartHr.Items.Add("20");
            StartHr.Items.Add("21");
            StartHr.Items.Add("22");
            StartHr.Items.Add("23");
            StartHr.Items.Add("24");

            StartMin.Items.Add("00");
            StartMin.Items.Add("15");
            StartMin.Items.Add("30");
            StartMin.Items.Add("45");

            EndHr.Items.Add("00");
            EndHr.Items.Add("01");
            EndHr.Items.Add("02");
            EndHr.Items.Add("03");
            EndHr.Items.Add("04");
            EndHr.Items.Add("05");
            EndHr.Items.Add("06");
            EndHr.Items.Add("07");
            EndHr.Items.Add("08");
            EndHr.Items.Add("09");
            EndHr.Items.Add("10");
            EndHr.Items.Add("11");
            EndHr.Items.Add("12");
            EndHr.Items.Add("13");
            EndHr.Items.Add("14");
            EndHr.Items.Add("15");
            EndHr.Items.Add("16");
            EndHr.Items.Add("17");
            EndHr.Items.Add("18");
            EndHr.Items.Add("19");
            EndHr.Items.Add("20");
            EndHr.Items.Add("21");
            EndHr.Items.Add("22");
            EndHr.Items.Add("23");
            EndHr.Items.Add("24");

            EndMin.Items.Add("00");
            EndMin.Items.Add("15");
            EndMin.Items.Add("30");
            EndMin.Items.Add("45");

            SelectDevice.Items.Add("Television");
            SelectDevice.Items.Add("Desktop");
            SelectDevice.Items.Add("Laptop");
            SelectDevice.Items.Add("Oven");
            SelectDevice.Items.Add("Washing Machine");
            SelectDevice.Items.Add("Lights");
            SelectDevice.Items.Add("Dishwasher");
            SelectDevice.Items.Add("Central Heating");
            SelectDevice.Items.Add("Tumble Dryer");
            SelectDevice.Items.Add("Mobile Phone Charger");

            SelectTariff.Items.Add("British Gas");
            SelectTariff.Items.Add("Eon");
            SelectTariff.Items.Add("nPower");
        }

        private void Add_Estimate_btn_Click(object sender, EventArgs e)
        {
            if (EndHr.SelectedIndex < StartHr.SelectedIndex)
            {
                MessageBox.Show("Please insert a appropriate End time", "Error");
            }
            else
            {
                Added_Devices.Items.Add(SelectDevice.Text);

                if (SelectDevice.Text != "Select Device")
                {
                    P1 = int.Parse(Power_txt.Text);
                    H1 = int.Parse(StartHr.Text);
                    M1 = int.Parse(StartMin.Text);
                    H2 = int.Parse(EndHr.Text);
                    M2 = int.Parse(EndMin.Text);
                    t1 = H2 - H1;
                    t2 = M2 - M1;

                    if (t2 == 15)
                    {
                        t2 = 0.25;
                    }

                    if (t2 == 30)
                    {
                        t2 = 0.5;
                    }

                    if (t2 == 45)
                    {
                        t2 = 0.75;
                    }

                    if (t2 == -15)
                    {
                        t2 = 0.75;
                    }

                    if (t2 == -30)
                    {
                        t2 = 0.5;
                    }

                    if (t2 == -45)
                    {
                        t2 = 0.25;
                    }

                    T = P1 * (t1 + t2);

                    if (SelectTariff.SelectedItem.ToString() == "British Gas")
                    {
                        tariff = 0.00001647;
                    }

                    if (SelectTariff.SelectedItem.ToString() == "Eon")
                    {
                        tariff = 0.00001859;
                    }

                    if (SelectTariff.SelectedItem.ToString() == "nPower")
                    {
                        tariff = 0.00002035;
                    }

                    cost = T * tariff;
                }



                System.IO.StreamWriter sw = new
                    System.IO.StreamWriter(FILE_NAME, true);

                user_text = T.ToString() + " " + SelectDevice.Text + " " + cost.ToString();

                sw.WriteLine(user_text);

                sw.Close();
            }

            double start_h = double.Parse(StartHr.Text);
            double start_m = double.Parse(StartMin.Text);
            double end_h = double.Parse(EndHr.Text);
            double end_m = double.Parse(EndMin.Text);
            double a, b;

            if (start_m == 15)
            {
                start_m = 0.25;
            }

            if (start_m == 30)
            {
                start_m = 0.5;
            }

            if (start_m == 45)
            {
                start_m = 0.75;
            }

            if (end_m == 15)
            {
                end_m = 0.25;
            }

            if (end_m == 30)
            {
                end_m = 0.5;
            }

            if (end_m == 45)
            {
                end_m = 0.75;
            }

            a = start_h + start_m;
            b = end_h + end_m;

            if (SelectDevice.SelectedItem.ToString() == "Television")
            {
                while (b >= a)
                {
                    System.IO.StreamWriter sw2 = new
                        System.IO.StreamWriter(FILE_NAME3, true);

                    TV_Coords = a.ToString() + " " + Power_txt.Text;
                    a = a + 0.25;

                    sw2.WriteLine(TV_Coords);

                    sw2.Close();
                }
            }

            if (SelectDevice.SelectedItem.ToString() == "Desktop")
            {
                while (b >= a)
                {
                    System.IO.StreamWriter sw2 = new
                        System.IO.StreamWriter(FILE_NAME4, true);

                    Desktop_Coords = a.ToString() + " " + Power_txt.Text;
                    a = a + 0.25;

                    sw2.WriteLine(Desktop_Coords);

                    sw2.Close();
                }
            }

            if (SelectDevice.SelectedItem.ToString() == "Laptop")
            {
                while (b >= a)
                {
                    System.IO.StreamWriter sw2 = new
                        System.IO.StreamWriter(FILE_NAME5, true);

                    Laptop_Coords = a.ToString() + " " + Power_txt.Text;
                    a = a + 0.25;

                    sw2.WriteLine(Laptop_Coords);

                    sw2.Close();
                }
            }

            if (SelectDevice.SelectedItem.ToString() == "Oven")
            {
                while (b >= a)
                {
                    System.IO.StreamWriter sw2 = new
                        System.IO.StreamWriter(FILE_NAME6, true);

                    Oven_Coords = a.ToString() + " " + Power_txt.Text;
                    a = a + 0.25;

                    sw2.WriteLine(Oven_Coords);

                    sw2.Close();
                }
            }

            if (SelectDevice.SelectedItem.ToString() == "Washing Machine")
            {
                while (b >= a)
                {
                    System.IO.StreamWriter sw2 = new
                        System.IO.StreamWriter(FILE_NAME7, true);

                    WM_Coords = a.ToString() + " " + Power_txt.Text;
                    a = a + 0.25;

                    sw2.WriteLine(WM_Coords);

                    sw2.Close();
                }
            }

            if (SelectDevice.SelectedItem.ToString() == "Lights")
            {
                while (b >= a)
                {
                    System.IO.StreamWriter sw2 = new
                        System.IO.StreamWriter(FILE_NAME8, true);

                    Lights_Coords = a.ToString() + " " + Power_txt.Text;
                    a = a + 0.25;

                    sw2.WriteLine(Lights_Coords);

                    sw2.Close();
                }
            }

            if (SelectDevice.SelectedItem.ToString() == "Dishwasher")
            {
                while (b >= a)
                {
                    System.IO.StreamWriter sw2 = new
                        System.IO.StreamWriter(FILE_NAME9, true);

                    Dishwasher_Coords = a.ToString() + " " + Power_txt.Text;
                    a = a + 0.25;

                    sw2.WriteLine(Dishwasher_Coords);

                    sw2.Close();
                }
            }

            if (SelectDevice.SelectedItem.ToString() == "Central Heating")
            {
                while (b >= a)
                {
                    System.IO.StreamWriter sw2 = new
                        System.IO.StreamWriter(FILE_NAME10, true);

                    CH_Coords = a.ToString() + " " + Power_txt.Text;
                    a = a + 0.25;

                    sw2.WriteLine(CH_Coords);

                    sw2.Close();
                }
            }

            if (SelectDevice.SelectedItem.ToString() == "Tumble Dryer")
            {
                while (b >= a)
                {
                    System.IO.StreamWriter sw2 = new
                        System.IO.StreamWriter(FILE_NAME11, true);

                    TD_Coords = a.ToString() + " " + Power_txt.Text;
                    a = a + 0.25;

                    sw2.WriteLine(TD_Coords);

                    sw2.Close();
                }
            }

            if (SelectDevice.SelectedItem.ToString() == "Mobile Phone Charger")
            {
                while (b >= a)
                {
                    System.IO.StreamWriter sw2 = new
                        System.IO.StreamWriter(FILE_NAME12, true);

                    MPC_Coords = a.ToString() + " " + Power_txt.Text;
                    a = a + 0.25;

                    sw2.WriteLine(MPC_Coords);

                    sw2.Close();
                }
            }
        }

        private void Remove_btn_Click(object sender, EventArgs e)
        {
            if (Added_Devices.SelectedItem.ToString() == "Television")
            {
                var oldLines = System.IO.File.ReadAllLines("user_text.dat");
                var newLines = oldLines.Where(line => !line.Contains("Television"));
                System.IO.File.WriteAllLines("user_text.dat", newLines);
                System.IO.StreamWriter sw = new
                        System.IO.StreamWriter(FILE_NAME3);

                TV_Coords = "";

                sw.WriteLine(TV_Coords);

                sw.Close();
            }

            if (Added_Devices.SelectedItem.ToString() == "Desktop")
            {
                var oldLines = System.IO.File.ReadAllLines("user_text.dat");
                var newLines = oldLines.Where(line => !line.Contains("Desktop"));
                System.IO.File.WriteAllLines("user_text.dat", newLines);
                System.IO.StreamWriter sw = new
                        System.IO.StreamWriter(FILE_NAME4);

                Desktop_Coords = "";

                sw.WriteLine(Desktop_Coords);

                sw.Close();
            }

            if (Added_Devices.SelectedItem.ToString() == "Laptop")
            {
                var oldLines = System.IO.File.ReadAllLines("user_text.dat");
                var newLines = oldLines.Where(line => !line.Contains("Laptop"));
                Power_txt.Text = newLines.ToString();
                System.IO.File.WriteAllLines("user_text.dat", newLines);
                System.IO.StreamWriter sw = new
                        System.IO.StreamWriter(FILE_NAME5);

                Laptop_Coords = "";

                sw.WriteLine(Laptop_Coords);

                sw.Close();
            }

            if (Added_Devices.SelectedItem.ToString() == "Oven")
            {
                var oldLines = System.IO.File.ReadAllLines("user_text.dat");
                var newLines = oldLines.Where(line => !line.Contains("Oven"));
                System.IO.File.WriteAllLines("user_text.dat", newLines);
                System.IO.StreamWriter sw = new
                        System.IO.StreamWriter(FILE_NAME6);

                Oven_Coords = "";

                sw.WriteLine(Oven_Coords);

                sw.Close();
            }

            if (Added_Devices.SelectedItem.ToString() == "Washing Machine")
            {
                var oldLines = System.IO.File.ReadAllLines("user_text.dat");
                var newLines = oldLines.Where(line => !line.Contains("Washing Machine"));
                System.IO.File.WriteAllLines("user_text.dat", newLines);
                System.IO.StreamWriter sw = new
                        System.IO.StreamWriter(FILE_NAME7);

                WM_Coords = "";

                sw.WriteLine(WM_Coords);

                sw.Close();
            }

            if (Added_Devices.SelectedItem.ToString() == "Lights")
            {
                var oldLines = System.IO.File.ReadAllLines("user_text.dat");
                var newLines = oldLines.Where(line => !line.Contains("Lights"));
                System.IO.File.WriteAllLines("user_text.dat", newLines);
                System.IO.StreamWriter sw = new
                        System.IO.StreamWriter(FILE_NAME8);

                Lights_Coords = "";

                sw.WriteLine(Lights_Coords);

                sw.Close();
            }

            if (Added_Devices.SelectedItem.ToString() == "Dishwasher")
            {
                var oldLines = System.IO.File.ReadAllLines("user_text.dat");
                var newLines = oldLines.Where(line => !line.Contains("Dishwasher"));
                System.IO.File.WriteAllLines("user_text.dat", newLines);
                System.IO.StreamWriter sw = new
                        System.IO.StreamWriter(FILE_NAME9);

                Dishwasher_Coords = "";

                sw.WriteLine(Dishwasher_Coords);

                sw.Close();
            }

            if (Added_Devices.SelectedItem.ToString() == "Central Heating")
            {
                var oldLines = System.IO.File.ReadAllLines("user_text.dat");
                var newLines = oldLines.Where(line => !line.Contains("Central Heating"));
                System.IO.File.WriteAllLines("user_text.dat", newLines);
                System.IO.StreamWriter sw = new
                        System.IO.StreamWriter(FILE_NAME10);

                CH_Coords = "";

                sw.WriteLine(CH_Coords);

                sw.Close();
            }

            if (Added_Devices.SelectedItem.ToString() == "Tumble Dryer")
            {
                var oldLines = System.IO.File.ReadAllLines("user_text.dat");
                var newLines = oldLines.Where(line => !line.Contains("Tumble Dryer"));
                System.IO.File.WriteAllLines("user_text.dat", newLines);
                System.IO.StreamWriter sw = new
                        System.IO.StreamWriter(FILE_NAME11);

                TD_Coords = "";

                sw.WriteLine(TD_Coords);

                sw.Close();
            }

            if (Added_Devices.SelectedItem.ToString() == "Mobile Phone Charger")
            {
                var oldLines = System.IO.File.ReadAllLines("user_text.dat");
                var newLines = oldLines.Where(line => !line.Contains("Mobile Phone Charger"));
                System.IO.File.WriteAllLines("user_text.dat", newLines);
                System.IO.StreamWriter sw = new
                        System.IO.StreamWriter(FILE_NAME12);

                MPC_Coords = "";

                sw.WriteLine(MPC_Coords);

                sw.Close();
            }

            for (int n = Added_Devices.Items.Count - 1; n >= 0; --n)
            {
                if (this.Added_Devices.SelectedIndex >= 0)
                {
                    this.Added_Devices.Items.RemoveAt(this.Added_Devices.SelectedIndex);
                }
            }
        }

        private void SelectDevice_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((SelectDevice.Text != "Select Device") && (SelectTariff.Text != "Select Tariff"))
            {
                Add_Estimate_btn.Enabled = true;
            }
            
            if (SelectDevice.Text == "Television")
            {
                Power_txt.Text = "150";
                Icon.Image = Image.FromFile("TV.png");
                Icon.SizeMode = PictureBoxSizeMode.StretchImage;
            }

            if (SelectDevice.Text == "Desktop")
            {
                Power_txt.Text = "200";
                Icon.Image = Image.FromFile("Desktop.png");
                Icon.SizeMode = PictureBoxSizeMode.StretchImage;
            }

            if (SelectDevice.Text == "Laptop")
            {
                Power_txt.Text = "50";
                Icon.Image = Image.FromFile("Laptop.jpg");
                Icon.SizeMode = PictureBoxSizeMode.StretchImage;
            }

            if (SelectDevice.Text == "Oven")
            {
                Power_txt.Text = "3000";
                Icon.Image = Image.FromFile("Oven.png");
                Icon.SizeMode = PictureBoxSizeMode.StretchImage;
            }

            if (SelectDevice.Text == "Washing Machine")
            {
                Power_txt.Text = "500";
                Icon.Image = Image.FromFile("WM.jpg");
                Icon.SizeMode = PictureBoxSizeMode.StretchImage;
            }

            if (SelectDevice.Text == "Lights")
            {
                Power_txt.Text = "100";
                Icon.Image = Image.FromFile("Lights.png");
                Icon.SizeMode = PictureBoxSizeMode.StretchImage;
            }

            if (SelectDevice.Text == "Dishwasher")
            {
                Power_txt.Text = "1200";
                Icon.Image = Image.FromFile("Dishwasher.png");
                Icon.SizeMode = PictureBoxSizeMode.StretchImage;
            }

            if (SelectDevice.Text == "Central Heating")
            {
                Power_txt.Text = "1000";
                Icon.Image = Image.FromFile("CH.png");
                Icon.SizeMode = PictureBoxSizeMode.StretchImage;
            }

            if (SelectDevice.Text == "Tumble Dryer")
            {
                Power_txt.Text = "4000";
                Icon.Image = Image.FromFile("TD.png");
                Icon.SizeMode = PictureBoxSizeMode.StretchImage;
            }

            if (SelectDevice.Text == "Mobile Phone Charger")
            {
                Power_txt.Text = "3";
                Icon.Image = Image.FromFile("MPC.jpg");
                Icon.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void Calculate_btn_Click(object sender, EventArgs e)
        {
            string[] lines = System.IO.File.ReadAllLines("user_text.dat");
            double EnergySum = 0;
            double CostSum = 0;
            foreach (string line in lines.Skip(1))
            {
                EnergySum += Convert.ToDouble(line.Trim().Split(' ').First());
                Total_Energy.Text = EnergySum.ToString();

                CostSum += Convert.ToDouble(line.Trim().Split(' ').Last());
                Total_Cost.Text = Math.Round(CostSum, 2).ToString();
            }  
        }

        private void Generate_Graph_btn_Click(object sender, EventArgs e)
        {
            Energy_Graph.Series.Clear();

            Energy_Graph.Series.Add("Television");
            Energy_Graph.Series.Add("Desktop");
            Energy_Graph.Series.Add("Laptop");
            Energy_Graph.Series.Add("Oven");
            Energy_Graph.Series.Add("Washing Machine");
            Energy_Graph.Series.Add("Lights");
            Energy_Graph.Series.Add("Dishwasher");
            Energy_Graph.Series.Add("Central Heating");
            Energy_Graph.Series.Add("Tumble Dryer");
            Energy_Graph.Series.Add("Mobile Phone Charger");

            Energy_Graph.Series["Television"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            Energy_Graph.Series["Desktop"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            Energy_Graph.Series["Laptop"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            Energy_Graph.Series["Oven"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            Energy_Graph.Series["Washing Machine"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            Energy_Graph.Series["Lights"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            Energy_Graph.Series["Dishwasher"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            Energy_Graph.Series["Central Heating"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            Energy_Graph.Series["Tumble Dryer"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            Energy_Graph.Series["Mobile Phone Charger"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

            Energy_Graph.Series["Television"].BorderWidth = 5;
            Energy_Graph.Series["Desktop"].BorderWidth = 5;
            Energy_Graph.Series["Laptop"].BorderWidth = 5;
            Energy_Graph.Series["Oven"].BorderWidth = 5;
            Energy_Graph.Series["Washing Machine"].BorderWidth = 5;
            Energy_Graph.Series["Lights"].BorderWidth = 5;
            Energy_Graph.Series["Dishwasher"].BorderWidth = 5;
            Energy_Graph.Series["Central Heating"].BorderWidth = 5;
            Energy_Graph.Series["Tumble Dryer"].BorderWidth = 5;
            Energy_Graph.Series["Mobile Phone Charger"].BorderWidth = 5;

            Energy_Graph.ChartAreas[0].AxisX.Maximum = 24;
            Energy_Graph.ChartAreas[0].AxisX.Minimum = 0;
            Energy_Graph.ChartAreas[0].AxisX.Interval = 0.25;

            Energy_Graph.ChartAreas[0].AxisX.Title = "Time (hrs)";
            Energy_Graph.ChartAreas[0].AxisY.Title = "Power (W)";

            string[] lines = System.IO.File.ReadAllLines("TV_Coords.dat");
            double x = 0;
            double y = 0;
            foreach (string line in lines.Skip(1))
            {
                x = Convert.ToDouble(line.Trim().Split(' ').First());
                y = Convert.ToDouble(line.Trim().Split(' ').Last());
                Energy_Graph.Series["Television"].Points.AddXY(x, y);
            }

            string[] lines2 = System.IO.File.ReadAllLines("Desktop_Coords.dat");
            double x1 = 0;
            double y1 = 0;
            foreach (string line in lines2.Skip(1))
            {
                x1 = Convert.ToDouble(line.Trim().Split(' ').First());
                y1 = Convert.ToDouble(line.Trim().Split(' ').Last());
                Energy_Graph.Series["Desktop"].Points.AddXY(x1, y1);
            }

            string[] lines3 = System.IO.File.ReadAllLines("Laptop_Coords.dat");
            double x2 = 0;
            double y2 = 0;
            foreach (string line in lines3.Skip(1))
            {
                x2 = Convert.ToDouble(line.Trim().Split(' ').First());
                y2 = Convert.ToDouble(line.Trim().Split(' ').Last());
                Energy_Graph.Series["Laptop"].Points.AddXY(x2, y2);
            }

            string[] lines4 = System.IO.File.ReadAllLines("Oven_Coords.dat");
            double x3 = 0;
            double y3 = 0;
            foreach (string line in lines4.Skip(1))
            {
                x3 = Convert.ToDouble(line.Trim().Split(' ').First());
                y3 = Convert.ToDouble(line.Trim().Split(' ').Last());
                Energy_Graph.Series["Oven"].Points.AddXY(x3, y3);
            }

            string[] lines5 = System.IO.File.ReadAllLines("WM_Coords.dat");
            double x4 = 0;
            double y4 = 0;
            foreach (string line in lines5.Skip(1))
            {
                x4 = Convert.ToDouble(line.Trim().Split(' ').First());
                y4 = Convert.ToDouble(line.Trim().Split(' ').Last());
                Energy_Graph.Series["Washing Machine"].Points.AddXY(x4, y4);
            }

            string[] lines7 = System.IO.File.ReadAllLines("Lights_Coords.dat");
            double x6 = 0;
            double y6 = 0;
            foreach (string line in lines7.Skip(1))
            {
                x6 = Convert.ToDouble(line.Trim().Split(' ').First());
                y6 = Convert.ToDouble(line.Trim().Split(' ').Last());
                Energy_Graph.Series["Lights"].Points.AddXY(x6, y6);
            }

            string[] lines8 = System.IO.File.ReadAllLines("Dishwasher_Coords.dat");
            double x7 = 0;
            double y7 = 0;
            foreach (string line in lines8.Skip(1))
            {
                x7 = Convert.ToDouble(line.Trim().Split(' ').First());
                y7 = Convert.ToDouble(line.Trim().Split(' ').Last());
                Energy_Graph.Series["Dishwasher"].Points.AddXY(x7, y7);
            }

            string[] lines9 = System.IO.File.ReadAllLines("CH_Coords.dat");
            double x8 = 0;
            double y8 = 0;
            foreach (string line in lines9.Skip(1))
            {
                x8 = Convert.ToDouble(line.Trim().Split(' ').First());
                y8 = Convert.ToDouble(line.Trim().Split(' ').Last());
                Energy_Graph.Series["Central Heating"].Points.AddXY(x8, y8);
            }

            string[] lines10 = System.IO.File.ReadAllLines("TD_Coords.dat");
            double x9 = 0;
            double y9 = 0;
            foreach (string line in lines10.Skip(1))
            {
                x9 = Convert.ToDouble(line.Trim().Split(' ').First());
                y9 = Convert.ToDouble(line.Trim().Split(' ').Last());
                Energy_Graph.Series["Tumble Dryer"].Points.AddXY(x9, y9);
            }

            string[] lines11 = System.IO.File.ReadAllLines("MPC_Coords.dat");
            double x10 = 0;
            double y10 = 0;
            foreach (string line in lines11.Skip(1))
            {
                x10 = Convert.ToDouble(line.Trim().Split(' ').First());
                y10 = Convert.ToDouble(line.Trim().Split(' ').Last());
                Energy_Graph.Series["Mobile Phone Charger"].Points.AddXY(x10, y10);
            }

            string[] lines12 = System.IO.File.ReadAllLines("Total_Coords.dat");
            double x11 = 0;
            double y11 = 0;
            foreach (string line in lines12.Skip(1))
            {
                x11 = Convert.ToDouble(line.Trim().Split(' ').First());
                y11 = Convert.ToDouble(line.Trim().Split(' ').Last());
                Energy_Graph.Series["Mobile Phone Charger"].Points.AddXY(x11, y11);
            }
        }

        private void Clear_Files()
        {
            System.IO.StreamWriter sw = new
                        System.IO.StreamWriter(FILE_NAME);

            Desktop_Coords = "";

            sw.WriteLine(Desktop_Coords);

            sw.Close();

            System.IO.StreamWriter sw2 = new
                        System.IO.StreamWriter(FILE_NAME3);

            Desktop_Coords = "";

            sw2.WriteLine(Desktop_Coords);

            sw2.Close();

            System.IO.StreamWriter sw3 = new
                        System.IO.StreamWriter(FILE_NAME4);

            Desktop_Coords = "";

            sw3.WriteLine(Desktop_Coords);

            sw3.Close();

            System.IO.StreamWriter sw4 = new
                        System.IO.StreamWriter(FILE_NAME5);

            Desktop_Coords = "";

            sw4.WriteLine(Desktop_Coords);

            sw4.Close();

            System.IO.StreamWriter sw5 = new
                        System.IO.StreamWriter(FILE_NAME6);

            Desktop_Coords = "";

            sw5.WriteLine(Desktop_Coords);

            sw5.Close();

            System.IO.StreamWriter sw6 = new
                        System.IO.StreamWriter(FILE_NAME7);

            Desktop_Coords = "";

            sw6.WriteLine(Desktop_Coords);

            sw6.Close();

            System.IO.StreamWriter sw7 = new
                        System.IO.StreamWriter(FILE_NAME8);

            Desktop_Coords = "";

            sw7.WriteLine(Desktop_Coords);

            sw7.Close();

            System.IO.StreamWriter sw8 = new
                        System.IO.StreamWriter(FILE_NAME9);

            Desktop_Coords = "";

            sw8.WriteLine(Desktop_Coords);

            sw8.Close();

            System.IO.StreamWriter sw9 = new
                        System.IO.StreamWriter(FILE_NAME10);

            Desktop_Coords = "";

            sw9.WriteLine(Desktop_Coords);

            sw9.Close();

            System.IO.StreamWriter sw10 = new
                        System.IO.StreamWriter(FILE_NAME11);

            Desktop_Coords = "";

            sw10.WriteLine(Desktop_Coords);

            sw10.Close();

            System.IO.StreamWriter sw11 = new
                        System.IO.StreamWriter(FILE_NAME12);

            Desktop_Coords = "";

            sw11.WriteLine(Desktop_Coords);

            sw11.Close();

            System.IO.StreamWriter sw12 = new
                        System.IO.StreamWriter(FILE_NAME13);

            Desktop_Coords = "";

            sw12.WriteLine(Desktop_Coords);

            sw12.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Clear_Files();
        }

        private void Clear_btn_Click(object sender, EventArgs e)
        {
            Clear_Files();

            StartHr.Text = "00";
            StartMin.Text = "00";
            EndHr.Text = "00";
            EndMin.Text = "00";
            SelectDevice.Text = "Select Device";
            SelectTariff.Text = "Select Tariff";
            Power_txt.Text = "";
            Total_Energy.Text = "";
            Total_Cost.Text = "";
            Energy_Graph.Series.Clear();
            Added_Devices.Items.Clear();

            Add_Estimate_btn.Enabled = false;
            Remove_btn.Enabled = false;
        }

        private void SelectTariff_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((SelectDevice.Text != "Select Device") && (SelectTariff.Text != "Select Tariff"))
            {
                Add_Estimate_btn.Enabled = true;
            }
        }

        private void Added_Items_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Added_Devices.SelectedIndex > -1)
            {
                Remove_btn.Enabled = true;
            }
            else
                Remove_btn.Enabled = false;
        }
    }
}