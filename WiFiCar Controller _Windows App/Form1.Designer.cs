namespace ConsoleApplication2udp
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
            this.button_start = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_ip = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_port = new System.Windows.Forms.TextBox();
            this.FORWARD = new System.Windows.Forms.Button();
            this.LEFT = new System.Windows.Forms.Button();
            this.RIGHT = new System.Windows.Forms.Button();
            this.F_LEFT = new System.Windows.Forms.Button();
            this.F_RIGHT = new System.Windows.Forms.Button();
            this.B_LEFT = new System.Windows.Forms.Button();
            this.B_RIGHT = new System.Windows.Forms.Button();
            this.Stop_Button = new System.Windows.Forms.Button();
            this.BACK = new System.Windows.Forms.Button();
            this.checkBox_flash = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.stopStream = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.comboBoxRes = new System.Windows.Forms.ComboBox();
            this.checkBoxWB = new System.Windows.Forms.CheckBox();
            this.trackBar_Quality = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.trackBar_Brightness = new System.Windows.Forms.TrackBar();
            this.label6 = new System.Windows.Forms.Label();
            this.trackBar_Contrast = new System.Windows.Forms.TrackBar();
            this.label7 = new System.Windows.Forms.Label();
            this.trackBar_Saturation = new System.Windows.Forms.TrackBar();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxWB = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Connect = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.disconnect_button = new System.Windows.Forms.Button();
            this.Names = new System.Windows.Forms.Label();
            this.Status = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Quality)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Brightness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Contrast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Saturation)).BeginInit();
            this.SuspendLayout();
            // 
            // button_start
            // 
            this.button_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.button_start.Location = new System.Drawing.Point(3, 342);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(128, 35);
            this.button_start.TabIndex = 1;
            this.button_start.Text = "Start Stream";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(12, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Resolution";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(0, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "IP Destination";
            // 
            // textBox_ip
            // 
            this.textBox_ip.Location = new System.Drawing.Point(91, 8);
            this.textBox_ip.Name = "textBox_ip";
            this.textBox_ip.Size = new System.Drawing.Size(192, 20);
            this.textBox_ip.TabIndex = 6;
            this.textBox_ip.TextChanged += new System.EventHandler(this.textBox_ip_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(12, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Port Number";
            // 
            // textBox_port
            // 
            this.textBox_port.Location = new System.Drawing.Point(91, 32);
            this.textBox_port.Name = "textBox_port";
            this.textBox_port.Size = new System.Drawing.Size(192, 20);
            this.textBox_port.TabIndex = 8;
            this.textBox_port.Text = "2020";
            // 
            // FORWARD
            // 
            this.FORWARD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.FORWARD.Location = new System.Drawing.Point(114, 475);
            this.FORWARD.Name = "FORWARD";
            this.FORWARD.Size = new System.Drawing.Size(86, 63);
            this.FORWARD.TabIndex = 13;
            this.FORWARD.Text = "FORWARD (W)";
            this.FORWARD.UseVisualStyleBackColor = true;
            this.FORWARD.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FORWARD_MouseDown);
            this.FORWARD.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FORWARD_MouseUp);
            // 
            // LEFT
            // 
            this.LEFT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.LEFT.Location = new System.Drawing.Point(18, 544);
            this.LEFT.Name = "LEFT";
            this.LEFT.Size = new System.Drawing.Size(86, 63);
            this.LEFT.TabIndex = 13;
            this.LEFT.Text = "     LEFT        (A)";
            this.LEFT.UseVisualStyleBackColor = true;
            this.LEFT.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LEFT_MouseDown);
            this.LEFT.MouseUp += new System.Windows.Forms.MouseEventHandler(this.LEFT_MouseUp);
            // 
            // RIGHT
            // 
            this.RIGHT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.RIGHT.Location = new System.Drawing.Point(209, 542);
            this.RIGHT.Name = "RIGHT";
            this.RIGHT.Size = new System.Drawing.Size(86, 63);
            this.RIGHT.TabIndex = 13;
            this.RIGHT.Text = "   RIGHT      (D)";
            this.RIGHT.UseVisualStyleBackColor = true;
            this.RIGHT.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RIGHT_MouseDown);
            this.RIGHT.MouseUp += new System.Windows.Forms.MouseEventHandler(this.RIGHT_MouseUp);
            // 
            // F_LEFT
            // 
            this.F_LEFT.AccessibleName = "";
            this.F_LEFT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.F_LEFT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.F_LEFT.Location = new System.Drawing.Point(18, 475);
            this.F_LEFT.Name = "F_LEFT";
            this.F_LEFT.Size = new System.Drawing.Size(86, 63);
            this.F_LEFT.TabIndex = 13;
            this.F_LEFT.Text = "  F-LEFT     (Q)";
            this.F_LEFT.UseVisualStyleBackColor = true;
            this.F_LEFT.MouseDown += new System.Windows.Forms.MouseEventHandler(this.F_LEFT_MouseDown);
            this.F_LEFT.MouseUp += new System.Windows.Forms.MouseEventHandler(this.F_LEFT_MouseUp);
            // 
            // F_RIGHT
            // 
            this.F_RIGHT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.F_RIGHT.Location = new System.Drawing.Point(209, 475);
            this.F_RIGHT.Name = "F_RIGHT";
            this.F_RIGHT.Size = new System.Drawing.Size(86, 63);
            this.F_RIGHT.TabIndex = 13;
            this.F_RIGHT.Text = "F-RIGHT   (E)";
            this.F_RIGHT.UseVisualStyleBackColor = true;
            this.F_RIGHT.MouseDown += new System.Windows.Forms.MouseEventHandler(this.F_RIGHT_MouseDown);
            this.F_RIGHT.MouseUp += new System.Windows.Forms.MouseEventHandler(this.F_RIGHT_MouseUp);
            // 
            // B_LEFT
            // 
            this.B_LEFT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.B_LEFT.Location = new System.Drawing.Point(18, 611);
            this.B_LEFT.Name = "B_LEFT";
            this.B_LEFT.Size = new System.Drawing.Size(86, 63);
            this.B_LEFT.TabIndex = 13;
            this.B_LEFT.Text = "  B-LEFT    (Z)";
            this.B_LEFT.UseVisualStyleBackColor = true;
            this.B_LEFT.MouseDown += new System.Windows.Forms.MouseEventHandler(this.B_LEFT_MouseDown);
            this.B_LEFT.MouseUp += new System.Windows.Forms.MouseEventHandler(this.B_LEFT_MouseUp);
            // 
            // B_RIGHT
            // 
            this.B_RIGHT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.B_RIGHT.Location = new System.Drawing.Point(209, 611);
            this.B_RIGHT.Name = "B_RIGHT";
            this.B_RIGHT.Size = new System.Drawing.Size(86, 63);
            this.B_RIGHT.TabIndex = 13;
            this.B_RIGHT.Text = "B-RIGHT   (C)";
            this.B_RIGHT.UseVisualStyleBackColor = true;
            this.B_RIGHT.MouseDown += new System.Windows.Forms.MouseEventHandler(this.B_RIGHT_MouseDown);
            this.B_RIGHT.MouseUp += new System.Windows.Forms.MouseEventHandler(this.B_RIGHT_MouseUp);
            // 
            // Stop_Button
            // 
            this.Stop_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Stop_Button.Location = new System.Drawing.Point(114, 544);
            this.Stop_Button.Name = "Stop_Button";
            this.Stop_Button.Size = new System.Drawing.Size(86, 63);
            this.Stop_Button.TabIndex = 13;
            this.Stop_Button.Text = "STOP";
            this.Stop_Button.UseVisualStyleBackColor = true;
            this.Stop_Button.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Stop_Button_MouseDown);
            this.Stop_Button.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Stop_Button_MouseUp);
            // 
            // BACK
            // 
            this.BACK.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.BACK.Location = new System.Drawing.Point(114, 611);
            this.BACK.Name = "BACK";
            this.BACK.Size = new System.Drawing.Size(86, 63);
            this.BACK.TabIndex = 13;
            this.BACK.Text = "    BACK       (S)";
            this.BACK.UseVisualStyleBackColor = true;
            this.BACK.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BACK_MouseDown);
            this.BACK.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BACK_MouseUp);
            // 
            // checkBox_flash
            // 
            this.checkBox_flash.AutoSize = true;
            this.checkBox_flash.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.checkBox_flash.ForeColor = System.Drawing.Color.Red;
            this.checkBox_flash.Location = new System.Drawing.Point(261, 141);
            this.checkBox_flash.Name = "checkBox_flash";
            this.checkBox_flash.Size = new System.Drawing.Size(56, 17);
            this.checkBox_flash.TabIndex = 19;
            this.checkBox_flash.Text = "Flash\r\n";
            this.checkBox_flash.UseVisualStyleBackColor = true;
            this.checkBox_flash.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(442, 85);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(287, 240);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // stopStream
            // 
            this.stopStream.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.stopStream.Location = new System.Drawing.Point(4, 342);
            this.stopStream.Name = "stopStream";
            this.stopStream.Size = new System.Drawing.Size(128, 35);
            this.stopStream.TabIndex = 22;
            this.stopStream.Text = "Stop Stream";
            this.stopStream.UseVisualStyleBackColor = true;
            this.stopStream.Click += new System.EventHandler(this.StopStream_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(127, 183);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(85, 17);
            this.radioButton1.TabIndex = 23;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // comboBoxRes
            // 
            this.comboBoxRes.FormattingEnabled = true;
            this.comboBoxRes.Items.AddRange(new object[] {
            "QQVGA(160x120)",
            "HQVGA(240x176)",
            "QVGA(320x240)",
            "CIF(400x296)",
            "VGA(640x480)",
            "SVGA(800x600)"});
            this.comboBoxRes.Location = new System.Drawing.Point(85, 128);
            this.comboBoxRes.Name = "comboBoxRes";
            this.comboBoxRes.Size = new System.Drawing.Size(121, 21);
            this.comboBoxRes.TabIndex = 24;
            this.comboBoxRes.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // checkBoxWB
            // 
            this.checkBoxWB.AutoSize = true;
            this.checkBoxWB.Location = new System.Drawing.Point(261, 164);
            this.checkBoxWB.Name = "checkBoxWB";
            this.checkBoxWB.Size = new System.Drawing.Size(80, 17);
            this.checkBoxWB.TabIndex = 26;
            this.checkBoxWB.Text = "checkBox3";
            this.checkBoxWB.UseVisualStyleBackColor = true;
            this.checkBoxWB.CheckedChanged += new System.EventHandler(this.checkBoxWB_CheckedChanged_1);
            // 
            // trackBar_Quality
            // 
            this.trackBar_Quality.Location = new System.Drawing.Point(75, 155);
            this.trackBar_Quality.Maximum = 63;
            this.trackBar_Quality.Name = "trackBar_Quality";
            this.trackBar_Quality.Size = new System.Drawing.Size(104, 45);
            this.trackBar_Quality.TabIndex = 27;
            this.trackBar_Quality.TickFrequency = 10;
            this.trackBar_Quality.Value = 63;
            this.trackBar_Quality.Scroll += new System.EventHandler(this.trackBar_Quality_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(13, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Quality";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(13, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Brightness";
            // 
            // trackBar_Brightness
            // 
            this.trackBar_Brightness.Location = new System.Drawing.Point(75, 206);
            this.trackBar_Brightness.Maximum = 2;
            this.trackBar_Brightness.Minimum = -2;
            this.trackBar_Brightness.Name = "trackBar_Brightness";
            this.trackBar_Brightness.Size = new System.Drawing.Size(104, 45);
            this.trackBar_Brightness.TabIndex = 30;
            this.trackBar_Brightness.Scroll += new System.EventHandler(this.trackBar_Brightness_Scroll);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(14, 249);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "Contrast";
            // 
            // trackBar_Contrast
            // 
            this.trackBar_Contrast.Location = new System.Drawing.Point(76, 243);
            this.trackBar_Contrast.Maximum = 2;
            this.trackBar_Contrast.Minimum = -2;
            this.trackBar_Contrast.Name = "trackBar_Contrast";
            this.trackBar_Contrast.Size = new System.Drawing.Size(104, 45);
            this.trackBar_Contrast.TabIndex = 32;
            this.trackBar_Contrast.Scroll += new System.EventHandler(this.trackBar_Contrast_Scroll);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(14, 288);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 33;
            this.label7.Text = "Saturation";
            // 
            // trackBar_Saturation
            // 
            this.trackBar_Saturation.Location = new System.Drawing.Point(76, 291);
            this.trackBar_Saturation.Maximum = 2;
            this.trackBar_Saturation.Minimum = -2;
            this.trackBar_Saturation.Name = "trackBar_Saturation";
            this.trackBar_Saturation.Size = new System.Drawing.Size(104, 45);
            this.trackBar_Saturation.TabIndex = 34;
            this.trackBar_Saturation.Scroll += new System.EventHandler(this.trackBar_Saturation_Scroll);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(284, 165);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 36;
            this.label8.Text = "AWB Gain";
            // 
            // comboBoxWB
            // 
            this.comboBoxWB.FormattingEnabled = true;
            this.comboBoxWB.Items.AddRange(new object[] {
            "Auto ",
            "Sunny ",
            "Cloudy",
            "Office",
            "Home"});
            this.comboBoxWB.Location = new System.Drawing.Point(261, 187);
            this.comboBoxWB.Name = "comboBoxWB";
            this.comboBoxWB.Size = new System.Drawing.Size(121, 21);
            this.comboBoxWB.TabIndex = 37;
            this.comboBoxWB.SelectedIndexChanged += new System.EventHandler(this.comboBoxWB_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.textBox1.Location = new System.Drawing.Point(163, 397);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(84, 20);
            this.textBox1.TabIndex = 39;
            this.textBox1.Text = "Keyboard";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown_1);
            this.textBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp_1);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Black;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(0, 397);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(158, 13);
            this.label9.TabIndex = 40;
            this.label9.Text = "Press for Keyboard Control";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(0, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 41;
            this.label10.Text = "label10";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(28, 72);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 13);
            this.label11.TabIndex = 42;
            this.label11.Text = "label11";
            // 
            // Connect
            // 
            this.Connect.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Connect.Location = new System.Drawing.Point(15, 62);
            this.Connect.Name = "Connect";
            this.Connect.Size = new System.Drawing.Size(75, 23);
            this.Connect.TabIndex = 43;
            this.Connect.Text = "Connect";
            this.Connect.UseVisualStyleBackColor = true;
            this.Connect.Click += new System.EventHandler(this.Connect_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(134, 67);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 13);
            this.label12.TabIndex = 44;
            this.label12.Text = "Message";
            // 
            // disconnect_button
            // 
            this.disconnect_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.disconnect_button.Location = new System.Drawing.Point(12, 62);
            this.disconnect_button.Name = "disconnect_button";
            this.disconnect_button.Size = new System.Drawing.Size(89, 23);
            this.disconnect_button.TabIndex = 47;
            this.disconnect_button.Text = "Disconnect";
            this.disconnect_button.UseVisualStyleBackColor = true;
            this.disconnect_button.Click += new System.EventHandler(this.disconnect_button_Click);
            // 
            // Names
            // 
            this.Names.AutoSize = true;
            this.Names.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Names.Font = new System.Drawing.Font("Arial Narrow", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Names.ForeColor = System.Drawing.Color.Red;
            this.Names.Location = new System.Drawing.Point(28, 699);
            this.Names.Name = "Names";
            this.Names.Size = new System.Drawing.Size(178, 30);
            this.Names.TabIndex = 48;
            this.Names.Text = "Developed by Konstanitnos Paternas \r\nSupervised by Minas Dasygenis";
            this.Names.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Status.Location = new System.Drawing.Point(307, 12);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(59, 16);
            this.Status.TabIndex = 49;
            this.Status.Text = "label13";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1366, 745);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.Names);
            this.Controls.Add(this.disconnect_button);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.Connect);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBoxWB);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.trackBar_Saturation);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.trackBar_Contrast);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.trackBar_Brightness);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBar_Quality);
            this.Controls.Add(this.checkBoxWB);
            this.Controls.Add(this.comboBoxRes);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.stopStream);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.checkBox_flash);
            this.Controls.Add(this.BACK);
            this.Controls.Add(this.Stop_Button);
            this.Controls.Add(this.B_RIGHT);
            this.Controls.Add(this.B_LEFT);
            this.Controls.Add(this.F_RIGHT);
            this.Controls.Add(this.F_LEFT);
            this.Controls.Add(this.RIGHT);
            this.Controls.Add(this.LEFT);
            this.Controls.Add(this.FORWARD);
            this.Controls.Add(this.textBox_port);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_ip);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_start);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "WiFiCar Controller";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Quality)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Brightness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Contrast)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Saturation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_ip;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_port;
        internal System.Windows.Forms.Button FORWARD;
        internal System.Windows.Forms.Button LEFT;
        internal System.Windows.Forms.Button RIGHT;
        internal System.Windows.Forms.Button F_LEFT;
        internal System.Windows.Forms.Button F_RIGHT;
        internal System.Windows.Forms.Button B_LEFT;
        internal System.Windows.Forms.Button B_RIGHT;
        internal System.Windows.Forms.Button Stop_Button;
        internal System.Windows.Forms.Button BACK;
        private System.Windows.Forms.CheckBox checkBox_flash;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button stopStream;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.ComboBox comboBoxRes;
        private System.Windows.Forms.CheckBox checkBoxWB;
        private System.Windows.Forms.TrackBar trackBar_Quality;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TrackBar trackBar_Brightness;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TrackBar trackBar_Contrast;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TrackBar trackBar_Saturation;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxWB;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button Connect;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button disconnect_button;
        private System.Windows.Forms.Label Names;
        private System.Windows.Forms.Label Status;
    }
}

