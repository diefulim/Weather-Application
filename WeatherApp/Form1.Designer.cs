namespace WeatherApp
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.kryptonNavigator1 = new ComponentFactory.Krypton.Navigator.KryptonNavigator();
            this.kryptonPage1 = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pressureLabel = new System.Windows.Forms.Label();
            this.humidityLabel = new System.Windows.Forms.Label();
            this.pressureHeader = new System.Windows.Forms.Label();
            this.humidityHeader = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.windDirectionLabel = new System.Windows.Forms.Label();
            this.windSpeedLabel = new System.Windows.Forms.Label();
            this.windLocationHeader = new System.Windows.Forms.Label();
            this.windspeedHeader = new System.Windows.Forms.Label();
            this.heatBox = new System.Windows.Forms.GroupBox();
            this.celciusLabel3 = new System.Windows.Forms.Label();
            this.celciusLabel2 = new System.Windows.Forms.Label();
            this.lowestLabel = new System.Windows.Forms.Label();
            this.highestLabel = new System.Windows.Forms.Label();
            this.lowestHeader = new System.Windows.Forms.Label();
            this.highestHeader = new System.Windows.Forms.Label();
            this.cloudsLabel = new System.Windows.Forms.Label();
            this.hourLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.celciusLabel = new System.Windows.Forms.Label();
            this.degeerLabel = new System.Windows.Forms.Label();
            this.countryLabel = new System.Windows.Forms.Label();
            this.cityLabel = new System.Windows.Forms.Label();
            this.kryptonPage2 = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.locationBox = new System.Windows.Forms.GroupBox();
            this.countryCombobox = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.cityCombobox = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.languagesCombobox = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.savedChangesBtn = new ComponentFactory.Krypton.Toolkit.KryptonCheckButton();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonNavigator1)).BeginInit();
            this.kryptonNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage1)).BeginInit();
            this.kryptonPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.heatBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage2)).BeginInit();
            this.kryptonPage2.SuspendLayout();
            this.locationBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.countryCombobox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityCombobox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.languagesCombobox)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonNavigator1
            // 
            this.kryptonNavigator1.Bar.TabBorderStyle = ComponentFactory.Krypton.Toolkit.TabBorderStyle.RoundedEqualMedium;
            this.kryptonNavigator1.Button.ButtonDisplayLogic = ComponentFactory.Krypton.Navigator.ButtonDisplayLogic.None;
            this.kryptonNavigator1.Button.CloseButtonAction = ComponentFactory.Krypton.Navigator.CloseButtonAction.None;
            this.kryptonNavigator1.Button.CloseButtonDisplay = ComponentFactory.Krypton.Navigator.ButtonDisplay.Hide;
            this.kryptonNavigator1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonNavigator1.Location = new System.Drawing.Point(0, 0);
            this.kryptonNavigator1.Name = "kryptonNavigator1";
            this.kryptonNavigator1.PageBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.TabDock;
            this.kryptonNavigator1.Pages.AddRange(new ComponentFactory.Krypton.Navigator.KryptonPage[] {
            this.kryptonPage1,
            this.kryptonPage2});
            this.kryptonNavigator1.SelectedIndex = 0;
            this.kryptonNavigator1.Size = new System.Drawing.Size(461, 324);
            this.kryptonNavigator1.TabIndex = 6;
            this.kryptonNavigator1.Text = "kryptonNavigator1";
            // 
            // kryptonPage1
            // 
            this.kryptonPage1.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.kryptonPage1.Controls.Add(this.groupBox2);
            this.kryptonPage1.Controls.Add(this.groupBox1);
            this.kryptonPage1.Controls.Add(this.heatBox);
            this.kryptonPage1.Controls.Add(this.cloudsLabel);
            this.kryptonPage1.Controls.Add(this.hourLabel);
            this.kryptonPage1.Controls.Add(this.dateLabel);
            this.kryptonPage1.Controls.Add(this.celciusLabel);
            this.kryptonPage1.Controls.Add(this.degeerLabel);
            this.kryptonPage1.Controls.Add(this.countryLabel);
            this.kryptonPage1.Controls.Add(this.cityLabel);
            this.kryptonPage1.Flags = 65534;
            this.kryptonPage1.LastVisibleSet = true;
            this.kryptonPage1.MinimumSize = new System.Drawing.Size(50, 50);
            this.kryptonPage1.Name = "kryptonPage1";
            this.kryptonPage1.Size = new System.Drawing.Size(459, 298);
            this.kryptonPage1.Text = "Home";
            this.kryptonPage1.ToolTipTitle = "Page ToolTip";
            this.kryptonPage1.UniqueName = "D136890FF6EB498AADA071535E3141A4";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.pressureLabel);
            this.groupBox2.Controls.Add(this.humidityLabel);
            this.groupBox2.Controls.Add(this.pressureHeader);
            this.groupBox2.Controls.Add(this.humidityHeader);
            this.groupBox2.Location = new System.Drawing.Point(309, 160);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(138, 127);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Humidity And Pressure";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label2.Location = new System.Drawing.Point(82, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 12);
            this.label2.TabIndex = 18;
            this.label2.Text = "hPa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label3.Location = new System.Drawing.Point(50, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 12);
            this.label3.TabIndex = 17;
            this.label3.Text = "%";
            // 
            // pressureLabel
            // 
            this.pressureLabel.AutoSize = true;
            this.pressureLabel.BackColor = System.Drawing.Color.Transparent;
            this.pressureLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pressureLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pressureLabel.ForeColor = System.Drawing.SystemColors.InfoText;
            this.pressureLabel.Location = new System.Drawing.Point(46, 94);
            this.pressureLabel.Name = "pressureLabel";
            this.pressureLabel.Size = new System.Drawing.Size(40, 18);
            this.pressureLabel.TabIndex = 16;
            this.pressureLabel.Text = "0000";
            // 
            // humidityLabel
            // 
            this.humidityLabel.AutoSize = true;
            this.humidityLabel.BackColor = System.Drawing.Color.Transparent;
            this.humidityLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.humidityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.humidityLabel.ForeColor = System.Drawing.SystemColors.InfoText;
            this.humidityLabel.Location = new System.Drawing.Point(61, 42);
            this.humidityLabel.Name = "humidityLabel";
            this.humidityLabel.Size = new System.Drawing.Size(24, 18);
            this.humidityLabel.TabIndex = 15;
            this.humidityLabel.Text = "00";
            // 
            // pressureHeader
            // 
            this.pressureHeader.AutoSize = true;
            this.pressureHeader.BackColor = System.Drawing.Color.Transparent;
            this.pressureHeader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pressureHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pressureHeader.ForeColor = System.Drawing.SystemColors.InfoText;
            this.pressureHeader.Location = new System.Drawing.Point(48, 76);
            this.pressureHeader.Name = "pressureHeader";
            this.pressureHeader.Size = new System.Drawing.Size(48, 13);
            this.pressureHeader.TabIndex = 14;
            this.pressureHeader.Text = "Pressure";
            // 
            // humidityHeader
            // 
            this.humidityHeader.AutoSize = true;
            this.humidityHeader.BackColor = System.Drawing.Color.Transparent;
            this.humidityHeader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.humidityHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.humidityHeader.ForeColor = System.Drawing.SystemColors.InfoText;
            this.humidityHeader.Location = new System.Drawing.Point(45, 25);
            this.humidityHeader.Name = "humidityHeader";
            this.humidityHeader.Size = new System.Drawing.Size(47, 13);
            this.humidityHeader.TabIndex = 13;
            this.humidityHeader.Text = "Humidity";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.windDirectionLabel);
            this.groupBox1.Controls.Add(this.windSpeedLabel);
            this.groupBox1.Controls.Add(this.windLocationHeader);
            this.groupBox1.Controls.Add(this.windspeedHeader);
            this.groupBox1.Location = new System.Drawing.Point(162, 160);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(138, 127);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Wind";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label4.Location = new System.Drawing.Point(89, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 12);
            this.label4.TabIndex = 17;
            this.label4.Text = "m/s";
            // 
            // windDirectionLabel
            // 
            this.windDirectionLabel.AutoSize = true;
            this.windDirectionLabel.BackColor = System.Drawing.Color.Transparent;
            this.windDirectionLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.windDirectionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.windDirectionLabel.ForeColor = System.Drawing.SystemColors.InfoText;
            this.windDirectionLabel.Location = new System.Drawing.Point(50, 98);
            this.windDirectionLabel.Name = "windDirectionLabel";
            this.windDirectionLabel.Size = new System.Drawing.Size(38, 16);
            this.windDirectionLabel.TabIndex = 16;
            this.windDirectionLabel.Text = "West";
            // 
            // windSpeedLabel
            // 
            this.windSpeedLabel.AutoSize = true;
            this.windSpeedLabel.BackColor = System.Drawing.Color.Transparent;
            this.windSpeedLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.windSpeedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.windSpeedLabel.ForeColor = System.Drawing.SystemColors.InfoText;
            this.windSpeedLabel.Location = new System.Drawing.Point(47, 43);
            this.windSpeedLabel.Name = "windSpeedLabel";
            this.windSpeedLabel.Size = new System.Drawing.Size(44, 18);
            this.windSpeedLabel.TabIndex = 15;
            this.windSpeedLabel.Text = "00.00";
            // 
            // windLocationHeader
            // 
            this.windLocationHeader.AutoSize = true;
            this.windLocationHeader.BackColor = System.Drawing.Color.Transparent;
            this.windLocationHeader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.windLocationHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.windLocationHeader.ForeColor = System.Drawing.SystemColors.InfoText;
            this.windLocationHeader.Location = new System.Drawing.Point(34, 78);
            this.windLocationHeader.Name = "windLocationHeader";
            this.windLocationHeader.Size = new System.Drawing.Size(77, 13);
            this.windLocationHeader.TabIndex = 14;
            this.windLocationHeader.Text = "Wind Direction";
            // 
            // windspeedHeader
            // 
            this.windspeedHeader.AutoSize = true;
            this.windspeedHeader.BackColor = System.Drawing.Color.Transparent;
            this.windspeedHeader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.windspeedHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.windspeedHeader.ForeColor = System.Drawing.SystemColors.InfoText;
            this.windspeedHeader.Location = new System.Drawing.Point(37, 25);
            this.windspeedHeader.Name = "windspeedHeader";
            this.windspeedHeader.Size = new System.Drawing.Size(66, 13);
            this.windspeedHeader.TabIndex = 13;
            this.windspeedHeader.Text = "Wind Speed";
            // 
            // heatBox
            // 
            this.heatBox.BackColor = System.Drawing.Color.Transparent;
            this.heatBox.Controls.Add(this.celciusLabel3);
            this.heatBox.Controls.Add(this.celciusLabel2);
            this.heatBox.Controls.Add(this.lowestLabel);
            this.heatBox.Controls.Add(this.highestLabel);
            this.heatBox.Controls.Add(this.lowestHeader);
            this.heatBox.Controls.Add(this.highestHeader);
            this.heatBox.Location = new System.Drawing.Point(16, 160);
            this.heatBox.Name = "heatBox";
            this.heatBox.Size = new System.Drawing.Size(138, 127);
            this.heatBox.TabIndex = 13;
            this.heatBox.TabStop = false;
            this.heatBox.Text = "Heat";
            // 
            // celciusLabel3
            // 
            this.celciusLabel3.AutoSize = true;
            this.celciusLabel3.BackColor = System.Drawing.Color.Transparent;
            this.celciusLabel3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.celciusLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.celciusLabel3.ForeColor = System.Drawing.SystemColors.InfoText;
            this.celciusLabel3.Location = new System.Drawing.Point(90, 93);
            this.celciusLabel3.Name = "celciusLabel3";
            this.celciusLabel3.Size = new System.Drawing.Size(16, 12);
            this.celciusLabel3.TabIndex = 18;
            this.celciusLabel3.Text = "°C";
            // 
            // celciusLabel2
            // 
            this.celciusLabel2.AutoSize = true;
            this.celciusLabel2.BackColor = System.Drawing.Color.Transparent;
            this.celciusLabel2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.celciusLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.celciusLabel2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.celciusLabel2.Location = new System.Drawing.Point(88, 41);
            this.celciusLabel2.Name = "celciusLabel2";
            this.celciusLabel2.Size = new System.Drawing.Size(16, 12);
            this.celciusLabel2.TabIndex = 17;
            this.celciusLabel2.Text = "°C";
            // 
            // lowestLabel
            // 
            this.lowestLabel.AutoSize = true;
            this.lowestLabel.BackColor = System.Drawing.Color.Transparent;
            this.lowestLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lowestLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lowestLabel.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lowestLabel.Location = new System.Drawing.Point(49, 100);
            this.lowestLabel.Name = "lowestLabel";
            this.lowestLabel.Size = new System.Drawing.Size(44, 18);
            this.lowestLabel.TabIndex = 16;
            this.lowestLabel.Text = "00.00";
            // 
            // highestLabel
            // 
            this.highestLabel.AutoSize = true;
            this.highestLabel.BackColor = System.Drawing.Color.Transparent;
            this.highestLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.highestLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.highestLabel.ForeColor = System.Drawing.SystemColors.InfoText;
            this.highestLabel.Location = new System.Drawing.Point(46, 43);
            this.highestLabel.Name = "highestLabel";
            this.highestLabel.Size = new System.Drawing.Size(44, 18);
            this.highestLabel.TabIndex = 15;
            this.highestLabel.Text = "00.00";
            // 
            // lowestHeader
            // 
            this.lowestHeader.AutoSize = true;
            this.lowestHeader.BackColor = System.Drawing.Color.Transparent;
            this.lowestHeader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lowestHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lowestHeader.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lowestHeader.Location = new System.Drawing.Point(16, 78);
            this.lowestHeader.Name = "lowestHeader";
            this.lowestHeader.Size = new System.Drawing.Size(104, 13);
            this.lowestHeader.TabIndex = 14;
            this.lowestHeader.Text = "Lowest Temperature";
            // 
            // highestHeader
            // 
            this.highestHeader.AutoSize = true;
            this.highestHeader.BackColor = System.Drawing.Color.Transparent;
            this.highestHeader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.highestHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.highestHeader.ForeColor = System.Drawing.SystemColors.InfoText;
            this.highestHeader.Location = new System.Drawing.Point(14, 25);
            this.highestHeader.Name = "highestHeader";
            this.highestHeader.Size = new System.Drawing.Size(106, 13);
            this.highestHeader.TabIndex = 13;
            this.highestHeader.Text = "Highest Temperature";
            // 
            // cloudsLabel
            // 
            this.cloudsLabel.AutoSize = true;
            this.cloudsLabel.BackColor = System.Drawing.Color.Transparent;
            this.cloudsLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cloudsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cloudsLabel.ForeColor = System.Drawing.SystemColors.InfoText;
            this.cloudsLabel.Location = new System.Drawing.Point(21, 67);
            this.cloudsLabel.Name = "cloudsLabel";
            this.cloudsLabel.Size = new System.Drawing.Size(49, 16);
            this.cloudsLabel.TabIndex = 12;
            this.cloudsLabel.Text = "Clouds";
            // 
            // hourLabel
            // 
            this.hourLabel.AutoSize = true;
            this.hourLabel.BackColor = System.Drawing.Color.Transparent;
            this.hourLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hourLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hourLabel.ForeColor = System.Drawing.SystemColors.InfoText;
            this.hourLabel.Location = new System.Drawing.Point(373, 36);
            this.hourLabel.Name = "hourLabel";
            this.hourLabel.Size = new System.Drawing.Size(36, 16);
            this.hourLabel.TabIndex = 11;
            this.hourLabel.Text = "Hour";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.BackColor = System.Drawing.Color.Transparent;
            this.dateLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateLabel.ForeColor = System.Drawing.SystemColors.InfoText;
            this.dateLabel.Location = new System.Drawing.Point(372, 16);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(45, 20);
            this.dateLabel.TabIndex = 10;
            this.dateLabel.Text = "Date";
            // 
            // celciusLabel
            // 
            this.celciusLabel.AutoSize = true;
            this.celciusLabel.BackColor = System.Drawing.Color.Transparent;
            this.celciusLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.celciusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.celciusLabel.ForeColor = System.Drawing.SystemColors.InfoText;
            this.celciusLabel.Location = new System.Drawing.Point(279, 83);
            this.celciusLabel.Name = "celciusLabel";
            this.celciusLabel.Size = new System.Drawing.Size(35, 25);
            this.celciusLabel.TabIndex = 9;
            this.celciusLabel.Text = "°C";
            // 
            // degeerLabel
            // 
            this.degeerLabel.AutoSize = true;
            this.degeerLabel.BackColor = System.Drawing.Color.Transparent;
            this.degeerLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.degeerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.degeerLabel.ForeColor = System.Drawing.SystemColors.InfoText;
            this.degeerLabel.Location = new System.Drawing.Point(132, 83);
            this.degeerLabel.Name = "degeerLabel";
            this.degeerLabel.Size = new System.Drawing.Size(163, 61);
            this.degeerLabel.TabIndex = 8;
            this.degeerLabel.Text = "00.00";
            // 
            // countryLabel
            // 
            this.countryLabel.AutoSize = true;
            this.countryLabel.BackColor = System.Drawing.Color.Transparent;
            this.countryLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.countryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.countryLabel.ForeColor = System.Drawing.SystemColors.InfoText;
            this.countryLabel.Location = new System.Drawing.Point(15, 14);
            this.countryLabel.Name = "countryLabel";
            this.countryLabel.Size = new System.Drawing.Size(117, 31);
            this.countryLabel.TabIndex = 6;
            this.countryLabel.Text = "Country";
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.BackColor = System.Drawing.Color.Transparent;
            this.cityLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cityLabel.ForeColor = System.Drawing.SystemColors.InfoText;
            this.cityLabel.Location = new System.Drawing.Point(20, 45);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(38, 20);
            this.cityLabel.TabIndex = 7;
            this.cityLabel.Text = "City";
            // 
            // kryptonPage2
            // 
            this.kryptonPage2.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.kryptonPage2.Controls.Add(this.locationBox);
            this.kryptonPage2.Controls.Add(this.savedChangesBtn);
            this.kryptonPage2.Flags = 65534;
            this.kryptonPage2.LastVisibleSet = true;
            this.kryptonPage2.MinimumSize = new System.Drawing.Size(50, 50);
            this.kryptonPage2.Name = "kryptonPage2";
            this.kryptonPage2.Size = new System.Drawing.Size(459, 298);
            this.kryptonPage2.Text = "Settings";
            this.kryptonPage2.ToolTipTitle = "Page ToolTip";
            this.kryptonPage2.UniqueName = "79E4BB9D573A46B6739E7DB301119EB9";
            // 
            // locationBox
            // 
            this.locationBox.BackColor = System.Drawing.Color.Transparent;
            this.locationBox.Controls.Add(this.countryCombobox);
            this.locationBox.Controls.Add(this.cityCombobox);
            this.locationBox.Controls.Add(this.languagesCombobox);
            this.locationBox.Location = new System.Drawing.Point(21, 21);
            this.locationBox.Name = "locationBox";
            this.locationBox.Size = new System.Drawing.Size(190, 158);
            this.locationBox.TabIndex = 4;
            this.locationBox.TabStop = false;
            this.locationBox.Text = "Location";
            // 
            // countryCombobox
            // 
            this.countryCombobox.DropDownWidth = 121;
            this.countryCombobox.Location = new System.Drawing.Point(26, 35);
            this.countryCombobox.Name = "countryCombobox";
            this.countryCombobox.Size = new System.Drawing.Size(134, 21);
            this.countryCombobox.TabIndex = 1;
            this.countryCombobox.Text = "Country";
            // 
            // cityCombobox
            // 
            this.cityCombobox.DropDownWidth = 121;
            this.cityCombobox.Location = new System.Drawing.Point(26, 62);
            this.cityCombobox.Name = "cityCombobox";
            this.cityCombobox.Size = new System.Drawing.Size(134, 21);
            this.cityCombobox.TabIndex = 0;
            this.cityCombobox.Text = "City";
            this.cityCombobox.SelectedIndexChanged += new System.EventHandler(this.cityCombobox_SelectedIndexChanged);
            // 
            // languagesCombobox
            // 
            this.languagesCombobox.DropDownWidth = 121;
            this.languagesCombobox.Location = new System.Drawing.Point(26, 106);
            this.languagesCombobox.Name = "languagesCombobox";
            this.languagesCombobox.Size = new System.Drawing.Size(134, 21);
            this.languagesCombobox.TabIndex = 2;
            this.languagesCombobox.Text = "Languages";
            // 
            // savedChangesBtn
            // 
            this.savedChangesBtn.Enabled = false;
            this.savedChangesBtn.Location = new System.Drawing.Point(143, 262);
            this.savedChangesBtn.Name = "savedChangesBtn";
            this.savedChangesBtn.Size = new System.Drawing.Size(157, 25);
            this.savedChangesBtn.TabIndex = 3;
            this.savedChangesBtn.Values.Text = "Save Changes";
            this.savedChangesBtn.Click += new System.EventHandler(this.savedChangesBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 324);
            this.Controls.Add(this.kryptonNavigator1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Weather Application";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonNavigator1)).EndInit();
            this.kryptonNavigator1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage1)).EndInit();
            this.kryptonPage1.ResumeLayout(false);
            this.kryptonPage1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.heatBox.ResumeLayout(false);
            this.heatBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage2)).EndInit();
            this.kryptonPage2.ResumeLayout(false);
            this.locationBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.countryCombobox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityCombobox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.languagesCombobox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private ComponentFactory.Krypton.Navigator.KryptonNavigator kryptonNavigator1;
        private ComponentFactory.Krypton.Navigator.KryptonPage kryptonPage1;
        private ComponentFactory.Krypton.Navigator.KryptonPage kryptonPage2;
        private System.Windows.Forms.Label countryLabel;
        private System.Windows.Forms.Label degeerLabel;
        private System.Windows.Forms.Label celciusLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label hourLabel;
        private System.Windows.Forms.Label cloudsLabel;
        private System.Windows.Forms.Label cityLabel;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox countryCombobox;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cityCombobox;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox languagesCombobox;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckButton savedChangesBtn;
        private System.Windows.Forms.GroupBox locationBox;
        private System.Windows.Forms.GroupBox heatBox;
        private System.Windows.Forms.Label lowestHeader;
        private System.Windows.Forms.Label highestHeader;
        private System.Windows.Forms.Label celciusLabel3;
        private System.Windows.Forms.Label celciusLabel2;
        private System.Windows.Forms.Label lowestLabel;
        private System.Windows.Forms.Label highestLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label windDirectionLabel;
        private System.Windows.Forms.Label windSpeedLabel;
        private System.Windows.Forms.Label windLocationHeader;
        private System.Windows.Forms.Label windspeedHeader;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label pressureLabel;
        private System.Windows.Forms.Label humidityLabel;
        private System.Windows.Forms.Label pressureHeader;
        private System.Windows.Forms.Label humidityHeader;
    }
}

