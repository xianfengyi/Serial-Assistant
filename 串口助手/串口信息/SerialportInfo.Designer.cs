namespace 串口助手.串口信息
{
    partial class Serialport
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
            this.components = new System.ComponentModel.Container();
            this.serialPort_No1 = new System.IO.Ports.SerialPort(this.components);
            this.lab_baudrate = new System.Windows.Forms.Label();
            this.lab_portName = new System.Windows.Forms.Label();
            this.cb_portName = new System.Windows.Forms.ComboBox();
            this.richTB_serialportinfo = new System.Windows.Forms.RichTextBox();
            this.timer_getinfo = new System.Windows.Forms.Timer(this.components);
            this.lab_serialportName = new System.Windows.Forms.Label();
            this.btn_openOrclose = new System.Windows.Forms.Button();
            this.cb_baudrate = new System.Windows.Forms.ComboBox();
            this.cb_parity = new System.Windows.Forms.ComboBox();
            this.lab_parity = new System.Windows.Forms.Label();
            this.cb_databits = new System.Windows.Forms.ComboBox();
            this.lab_databits = new System.Windows.Forms.Label();
            this.cb_stopbits = new System.Windows.Forms.ComboBox();
            this.lab_stopbits = new System.Windows.Forms.Label();
            this.cb_readbuffersize = new System.Windows.Forms.ComboBox();
            this.lab_readbuffersize = new System.Windows.Forms.Label();
            this.cb_writebuffersize = new System.Windows.Forms.ComboBox();
            this.lab_writebuffersize = new System.Windows.Forms.Label();
            this.richTB_sendmessage = new System.Windows.Forms.RichTextBox();
            this.btn_send = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // serialPort_No1
            // 
            this.serialPort_No1.BaudRate = 115200;
            this.serialPort_No1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort_No1_DataReceived);
            // 
            // lab_baudrate
            // 
            this.lab_baudrate.AutoSize = true;
            this.lab_baudrate.Font = new System.Drawing.Font("宋体", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_baudrate.Location = new System.Drawing.Point(14, 25);
            this.lab_baudrate.Name = "lab_baudrate";
            this.lab_baudrate.Size = new System.Drawing.Size(76, 17);
            this.lab_baudrate.TabIndex = 0;
            this.lab_baudrate.Text = "波特率：";
            // 
            // lab_portName
            // 
            this.lab_portName.AutoSize = true;
            this.lab_portName.Font = new System.Drawing.Font("宋体", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_portName.Location = new System.Drawing.Point(14, 61);
            this.lab_portName.Name = "lab_portName";
            this.lab_portName.Size = new System.Drawing.Size(76, 17);
            this.lab_portName.TabIndex = 2;
            this.lab_portName.Text = "端口名：";
            // 
            // cb_portName
            // 
            this.cb_portName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_portName.Font = new System.Drawing.Font("宋体", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cb_portName.FormattingEnabled = true;
            this.cb_portName.Location = new System.Drawing.Point(82, 58);
            this.cb_portName.Name = "cb_portName";
            this.cb_portName.Size = new System.Drawing.Size(120, 25);
            this.cb_portName.TabIndex = 4;
            this.cb_portName.SelectedIndexChanged += new System.EventHandler(this.cb_SelectedIndexChanged);
            // 
            // richTB_serialportinfo
            // 
            this.richTB_serialportinfo.Location = new System.Drawing.Point(255, 20);
            this.richTB_serialportinfo.Name = "richTB_serialportinfo";
            this.richTB_serialportinfo.Size = new System.Drawing.Size(290, 205);
            this.richTB_serialportinfo.TabIndex = 5;
            this.richTB_serialportinfo.Text = "";
            // 
            // timer_getinfo
            // 
            this.timer_getinfo.Tick += new System.EventHandler(this.timer_getinfo_Tick);
            // 
            // lab_serialportName
            // 
            this.lab_serialportName.AutoSize = true;
            this.lab_serialportName.Location = new System.Drawing.Point(15, 305);
            this.lab_serialportName.Name = "lab_serialportName";
            this.lab_serialportName.Size = new System.Drawing.Size(29, 12);
            this.lab_serialportName.TabIndex = 6;
            this.lab_serialportName.Text = "COM1";
            // 
            // btn_openOrclose
            // 
            this.btn_openOrclose.Font = new System.Drawing.Font("宋体", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_openOrclose.Location = new System.Drawing.Point(102, 292);
            this.btn_openOrclose.Name = "btn_openOrclose";
            this.btn_openOrclose.Size = new System.Drawing.Size(100, 32);
            this.btn_openOrclose.TabIndex = 7;
            this.btn_openOrclose.Text = "打开串口";
            this.btn_openOrclose.UseVisualStyleBackColor = true;
            this.btn_openOrclose.Click += new System.EventHandler(this.btn_openOrclose_Click);
            // 
            // cb_baudrate
            // 
            this.cb_baudrate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_baudrate.Font = new System.Drawing.Font("宋体", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cb_baudrate.FormattingEnabled = true;
            this.cb_baudrate.Location = new System.Drawing.Point(82, 22);
            this.cb_baudrate.Name = "cb_baudrate";
            this.cb_baudrate.Size = new System.Drawing.Size(120, 25);
            this.cb_baudrate.TabIndex = 8;
            this.cb_baudrate.SelectedIndexChanged += new System.EventHandler(this.cb_SelectedIndexChanged);
            // 
            // cb_parity
            // 
            this.cb_parity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_parity.Font = new System.Drawing.Font("宋体", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cb_parity.FormattingEnabled = true;
            this.cb_parity.Location = new System.Drawing.Point(82, 93);
            this.cb_parity.Name = "cb_parity";
            this.cb_parity.Size = new System.Drawing.Size(120, 25);
            this.cb_parity.TabIndex = 10;
            this.cb_parity.SelectedIndexChanged += new System.EventHandler(this.cb_SelectedIndexChanged);
            // 
            // lab_parity
            // 
            this.lab_parity.AutoSize = true;
            this.lab_parity.Font = new System.Drawing.Font("宋体", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_parity.Location = new System.Drawing.Point(14, 96);
            this.lab_parity.Name = "lab_parity";
            this.lab_parity.Size = new System.Drawing.Size(76, 17);
            this.lab_parity.TabIndex = 9;
            this.lab_parity.Text = "校验位：";
            // 
            // cb_databits
            // 
            this.cb_databits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_databits.Font = new System.Drawing.Font("宋体", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cb_databits.FormattingEnabled = true;
            this.cb_databits.Location = new System.Drawing.Point(82, 131);
            this.cb_databits.Name = "cb_databits";
            this.cb_databits.Size = new System.Drawing.Size(120, 25);
            this.cb_databits.TabIndex = 12;
            this.cb_databits.SelectedIndexChanged += new System.EventHandler(this.cb_SelectedIndexChanged);
            // 
            // lab_databits
            // 
            this.lab_databits.AutoSize = true;
            this.lab_databits.Font = new System.Drawing.Font("宋体", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_databits.Location = new System.Drawing.Point(14, 134);
            this.lab_databits.Name = "lab_databits";
            this.lab_databits.Size = new System.Drawing.Size(76, 17);
            this.lab_databits.TabIndex = 11;
            this.lab_databits.Text = "数据位：";
            // 
            // cb_stopbits
            // 
            this.cb_stopbits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_stopbits.Font = new System.Drawing.Font("宋体", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cb_stopbits.FormattingEnabled = true;
            this.cb_stopbits.Location = new System.Drawing.Point(82, 170);
            this.cb_stopbits.Name = "cb_stopbits";
            this.cb_stopbits.Size = new System.Drawing.Size(120, 25);
            this.cb_stopbits.TabIndex = 14;
            this.cb_stopbits.SelectedIndexChanged += new System.EventHandler(this.cb_SelectedIndexChanged);
            // 
            // lab_stopbits
            // 
            this.lab_stopbits.AutoSize = true;
            this.lab_stopbits.Font = new System.Drawing.Font("宋体", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_stopbits.Location = new System.Drawing.Point(14, 173);
            this.lab_stopbits.Name = "lab_stopbits";
            this.lab_stopbits.Size = new System.Drawing.Size(76, 17);
            this.lab_stopbits.TabIndex = 13;
            this.lab_stopbits.Text = "停止位：";
            // 
            // cb_readbuffersize
            // 
            this.cb_readbuffersize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_readbuffersize.Font = new System.Drawing.Font("宋体", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cb_readbuffersize.FormattingEnabled = true;
            this.cb_readbuffersize.Items.AddRange(new object[] {
            "2048"});
            this.cb_readbuffersize.Location = new System.Drawing.Point(82, 209);
            this.cb_readbuffersize.Name = "cb_readbuffersize";
            this.cb_readbuffersize.Size = new System.Drawing.Size(120, 25);
            this.cb_readbuffersize.TabIndex = 16;
            this.cb_readbuffersize.SelectedIndexChanged += new System.EventHandler(this.cb_SelectedIndexChanged);
            // 
            // lab_readbuffersize
            // 
            this.lab_readbuffersize.AutoSize = true;
            this.lab_readbuffersize.Font = new System.Drawing.Font("宋体", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_readbuffersize.Location = new System.Drawing.Point(14, 212);
            this.lab_readbuffersize.Name = "lab_readbuffersize";
            this.lab_readbuffersize.Size = new System.Drawing.Size(76, 17);
            this.lab_readbuffersize.TabIndex = 15;
            this.lab_readbuffersize.Text = "读缓存：";
            // 
            // cb_writebuffersize
            // 
            this.cb_writebuffersize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_writebuffersize.Font = new System.Drawing.Font("宋体", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cb_writebuffersize.FormattingEnabled = true;
            this.cb_writebuffersize.Items.AddRange(new object[] {
            "2048"});
            this.cb_writebuffersize.Location = new System.Drawing.Point(82, 251);
            this.cb_writebuffersize.Name = "cb_writebuffersize";
            this.cb_writebuffersize.Size = new System.Drawing.Size(120, 25);
            this.cb_writebuffersize.TabIndex = 18;
            this.cb_writebuffersize.SelectedIndexChanged += new System.EventHandler(this.cb_SelectedIndexChanged);
            // 
            // lab_writebuffersize
            // 
            this.lab_writebuffersize.AutoSize = true;
            this.lab_writebuffersize.Font = new System.Drawing.Font("宋体", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_writebuffersize.Location = new System.Drawing.Point(14, 254);
            this.lab_writebuffersize.Name = "lab_writebuffersize";
            this.lab_writebuffersize.Size = new System.Drawing.Size(76, 17);
            this.lab_writebuffersize.TabIndex = 17;
            this.lab_writebuffersize.Text = "写缓存：";
            // 
            // richTB_sendmessage
            // 
            this.richTB_sendmessage.Location = new System.Drawing.Point(255, 230);
            this.richTB_sendmessage.Name = "richTB_sendmessage";
            this.richTB_sendmessage.Size = new System.Drawing.Size(290, 50);
            this.richTB_sendmessage.TabIndex = 19;
            this.richTB_sendmessage.Text = "";
            // 
            // btn_send
            // 
            this.btn_send.Font = new System.Drawing.Font("宋体", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_send.Location = new System.Drawing.Point(488, 306);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(60, 32);
            this.btn_send.TabIndex = 20;
            this.btn_send.Text = "发送";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // Serialport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 350);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.richTB_sendmessage);
            this.Controls.Add(this.cb_writebuffersize);
            this.Controls.Add(this.lab_writebuffersize);
            this.Controls.Add(this.cb_readbuffersize);
            this.Controls.Add(this.lab_readbuffersize);
            this.Controls.Add(this.cb_stopbits);
            this.Controls.Add(this.lab_stopbits);
            this.Controls.Add(this.cb_databits);
            this.Controls.Add(this.lab_databits);
            this.Controls.Add(this.cb_parity);
            this.Controls.Add(this.lab_parity);
            this.Controls.Add(this.cb_portName);
            this.Controls.Add(this.cb_baudrate);
            this.Controls.Add(this.btn_openOrclose);
            this.Controls.Add(this.lab_serialportName);
            this.Controls.Add(this.richTB_serialportinfo);
            this.Controls.Add(this.lab_portName);
            this.Controls.Add(this.lab_baudrate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Serialport";
            this.Text = "SerialportInfo";
            this.Load += new System.EventHandler(this.SerialportInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort_No1;
        private System.Windows.Forms.Label lab_baudrate;
        private System.Windows.Forms.Label lab_portName;
        private System.Windows.Forms.ComboBox cb_portName;
        private System.Windows.Forms.Timer timer_getinfo;
        private System.Windows.Forms.Label lab_serialportName;
        private System.Windows.Forms.Button btn_openOrclose;
        private System.Windows.Forms.ComboBox cb_baudrate;
        private System.Windows.Forms.ComboBox cb_parity;
        private System.Windows.Forms.Label lab_parity;
        private System.Windows.Forms.ComboBox cb_databits;
        private System.Windows.Forms.Label lab_databits;
        private System.Windows.Forms.ComboBox cb_stopbits;
        private System.Windows.Forms.Label lab_stopbits;
        private System.Windows.Forms.ComboBox cb_readbuffersize;
        private System.Windows.Forms.Label lab_readbuffersize;
        private System.Windows.Forms.ComboBox cb_writebuffersize;
        private System.Windows.Forms.Label lab_writebuffersize;
        private System.Windows.Forms.RichTextBox richTB_sendmessage;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.RichTextBox richTB_serialportinfo;
    }
}