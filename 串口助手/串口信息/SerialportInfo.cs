using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using 串口助手;
using Microsoft.Win32;
using System.IO.Ports;

namespace 串口助手.串口信息
{
    public partial class Serialport:Form
    {
        bool ini = false;
        public Serialport()
        {
            InitializeComponent();
            Init();
            ini = true;
            ApplySet();
        }
        public void Init()
        {
            foreach (int bau in Common.GetListForBaudrate())
            {
                cb_baudrate.Items.Add(bau);
            }
            if (cb_baudrate.Items.Count > 0)
                cb_baudrate.SelectedIndex = cb_baudrate.Items.Count - 1;
            foreach (string pname in Common.GetListForPortName())
            {
                cb_portName.Items.Add(pname);
            }
            if (cb_portName.Items.Count > 0)
                cb_portName.SelectedIndex = cb_portName.Items.Count - 1;
            foreach (Parity par in Enum.GetValues(typeof(Parity)))
            {
                cb_parity.Items.Add(par);
            }
            cb_parity.SelectedIndex = 0;
            for (int i = 8; i > 5; i--)
                cb_databits.Items.Add(i);
            cb_databits.SelectedIndex = 0;
            foreach (StopBits sb in Enum.GetValues(typeof(StopBits)))
            {
                cb_stopbits.Items.Add(sb);
            }
            cb_stopbits.SelectedIndex = 1;
            cb_readbuffersize.SelectedIndex = 0;
            cb_writebuffersize.SelectedIndex = 0;
        }
        public void ApplySet()
        {
            if (!ini) return;
            try
            {
                serialPort_No1.BaudRate = (int)cb_baudrate.SelectedItem;  //波特率
                serialPort_No1.PortName = (string)cb_portName.SelectedItem;   //串口名字
                lab_serialportName.Text = serialPort_No1.PortName;   
                serialPort_No1.Parity = (Parity)cb_parity.SelectedItem;  //奇偶效验位
                serialPort_No1.DataBits = (int)cb_databits.SelectedItem;  //标准数据为长度
                serialPort_No1.StopBits = (StopBits)cb_stopbits.SelectedItem;  //标准停止位数
                serialPort_No1.ReadBufferSize = (int)cb_readbuffersize.SelectedItem;
                serialPort_No1.WriteBufferSize = (int)cb_writebuffersize.SelectedItem;

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        
        private void btn_openOrclose_Click(object sender, EventArgs e)
        {
            if (!serialPort_No1.IsOpen)
            {
                serialPort_No1.Open();
                btn_openOrclose.Text = "关闭串口";
            }
            else
            {
                btn_openOrclose.Text = "打开串口";
                serialPort_No1.Close();
            }
        }
        private void btn_send_Click(object sender, EventArgs e)
        {
            if (serialPort_No1.IsOpen)
            {
                serialPort_No1.WriteLine(richTB_sendmessage.Text);
                richTB_sendmessage.Clear();
                richTB_sendmessage.Focus();
            }
            else
            {
                richTB_sendmessage.SelectAll();
            }
        }
        private void cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplySet();
        }


        /// <summary>
        /// 串口收到消息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void serialPort_No1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            richTB_serialportinfo.AppendText(serialPort_No1.ReadExisting());
        }

        private void timer_getinfo_Tick(object sender, EventArgs e)
        {
            richTB_serialportinfo.AppendText(serialPort_No1.ReadExisting());
        }

        private void SerialportInfo_Load(object sender, EventArgs e)
        {

        }

    }
}
