
namespace Weather_Condition
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
            this.btn_search = new System.Windows.Forms.Button();
            this.txt_city = new System.Windows.Forms.TextBox();
            this.lbl_temperature = new System.Windows.Forms.Label();
            this.lbl_wind = new System.Windows.Forms.Label();
            this.lbl_feels_like = new System.Windows.Forms.Label();
            this.lbl_humidity = new System.Windows.Forms.Label();
            this.lbl_pressure = new System.Windows.Forms.Label();
            this.lbl_status = new System.Windows.Forms.Label();
            this.lbl_country = new System.Windows.Forms.Label();
            this.lbl_city_name = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.Gold;
            this.btn_search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_search.ForeColor = System.Drawing.Color.White;
            this.btn_search.Location = new System.Drawing.Point(185, 566);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(164, 49);
            this.btn_search.TabIndex = 0;
            this.btn_search.Text = "SEARCH";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // txt_city
            // 
            this.txt_city.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_city.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_city.Location = new System.Drawing.Point(154, 100);
            this.txt_city.Name = "txt_city";
            this.txt_city.Size = new System.Drawing.Size(242, 35);
            this.txt_city.TabIndex = 1;
            this.txt_city.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_temperature
            // 
            this.lbl_temperature.AutoSize = true;
            this.lbl_temperature.BackColor = System.Drawing.Color.Transparent;
            this.lbl_temperature.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_temperature.ForeColor = System.Drawing.Color.White;
            this.lbl_temperature.Location = new System.Drawing.Point(31, 309);
            this.lbl_temperature.Name = "lbl_temperature";
            this.lbl_temperature.Size = new System.Drawing.Size(165, 34);
            this.lbl_temperature.TabIndex = 2;
            this.lbl_temperature.Text = "Temperature :";
            // 
            // lbl_wind
            // 
            this.lbl_wind.AutoSize = true;
            this.lbl_wind.BackColor = System.Drawing.Color.Transparent;
            this.lbl_wind.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_wind.ForeColor = System.Drawing.Color.White;
            this.lbl_wind.Location = new System.Drawing.Point(115, 378);
            this.lbl_wind.Name = "lbl_wind";
            this.lbl_wind.Size = new System.Drawing.Size(81, 34);
            this.lbl_wind.TabIndex = 3;
            this.lbl_wind.Text = "Wind :";
            // 
            // lbl_feels_like
            // 
            this.lbl_feels_like.AutoSize = true;
            this.lbl_feels_like.BackColor = System.Drawing.Color.Transparent;
            this.lbl_feels_like.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_feels_like.ForeColor = System.Drawing.Color.White;
            this.lbl_feels_like.Location = new System.Drawing.Point(58, 344);
            this.lbl_feels_like.Name = "lbl_feels_like";
            this.lbl_feels_like.Size = new System.Drawing.Size(138, 34);
            this.lbl_feels_like.TabIndex = 3;
            this.lbl_feels_like.Text = "Feels Like :";
            this.lbl_feels_like.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_humidity
            // 
            this.lbl_humidity.AutoSize = true;
            this.lbl_humidity.BackColor = System.Drawing.Color.Transparent;
            this.lbl_humidity.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_humidity.ForeColor = System.Drawing.Color.White;
            this.lbl_humidity.Location = new System.Drawing.Point(74, 412);
            this.lbl_humidity.Name = "lbl_humidity";
            this.lbl_humidity.Size = new System.Drawing.Size(122, 34);
            this.lbl_humidity.TabIndex = 4;
            this.lbl_humidity.Text = "Humidity :";
            // 
            // lbl_pressure
            // 
            this.lbl_pressure.AutoSize = true;
            this.lbl_pressure.BackColor = System.Drawing.Color.Transparent;
            this.lbl_pressure.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_pressure.ForeColor = System.Drawing.Color.White;
            this.lbl_pressure.Location = new System.Drawing.Point(71, 446);
            this.lbl_pressure.Name = "lbl_pressure";
            this.lbl_pressure.Size = new System.Drawing.Size(125, 34);
            this.lbl_pressure.TabIndex = 5;
            this.lbl_pressure.Text = "Pressure :";
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.BackColor = System.Drawing.Color.Transparent;
            this.lbl_status.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_status.ForeColor = System.Drawing.Color.White;
            this.lbl_status.Location = new System.Drawing.Point(99, 480);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(97, 34);
            this.lbl_status.TabIndex = 6;
            this.lbl_status.Text = "Status :";
            // 
            // lbl_country
            // 
            this.lbl_country.AutoSize = true;
            this.lbl_country.BackColor = System.Drawing.Color.Transparent;
            this.lbl_country.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_country.ForeColor = System.Drawing.Color.White;
            this.lbl_country.Location = new System.Drawing.Point(43, 190);
            this.lbl_country.Name = "lbl_country";
            this.lbl_country.Size = new System.Drawing.Size(0, 46);
            this.lbl_country.TabIndex = 8;
            // 
            // lbl_city_name
            // 
            this.lbl_city_name.AutoSize = true;
            this.lbl_city_name.BackColor = System.Drawing.Color.Transparent;
            this.lbl_city_name.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_city_name.ForeColor = System.Drawing.Color.White;
            this.lbl_city_name.Location = new System.Drawing.Point(44, 246);
            this.lbl_city_name.Name = "lbl_city_name";
            this.lbl_city_name.Size = new System.Drawing.Size(0, 41);
            this.lbl_city_name.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::Weather_Condition.Properties.Resources.bg2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(519, 683);
            this.Controls.Add(this.lbl_city_name);
            this.Controls.Add(this.lbl_country);
            this.Controls.Add(this.lbl_status);
            this.Controls.Add(this.lbl_pressure);
            this.Controls.Add(this.lbl_humidity);
            this.Controls.Add(this.lbl_feels_like);
            this.Controls.Add(this.lbl_wind);
            this.Controls.Add(this.lbl_temperature);
            this.Controls.Add(this.txt_city);
            this.Controls.Add(this.btn_search);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Weather Condition";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox txt_city;
        private System.Windows.Forms.Label lbl_temperature;
        private System.Windows.Forms.Label lbl_wind;
        private System.Windows.Forms.Label lbl_feels_like;
        private System.Windows.Forms.Label lbl_humidity;
        private System.Windows.Forms.Label lbl_pressure;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.Label lbl_country;
        private System.Windows.Forms.Label lbl_city_name;
    }
}

