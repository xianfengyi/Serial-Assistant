using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;

namespace 串口助手
{
    class Common
    {
        public static List<int> list_baudrate = new List<int>();
        public static List<string> list_portName = new List<string>();

        /// <summary>
        /// 所有波特率
        /// </summary>
        /// <returns></returns>
        public static List<int> GetListForBaudrate()
        {
            if (list_baudrate.Count == 0)
            {
                list_baudrate.Add(300);
                list_baudrate.Add(600);
                list_baudrate.Add(1200);
                list_baudrate.Add(2400);
                list_baudrate.Add(4800);
                list_baudrate.Add(9600);
                list_baudrate.Add(19200);
                list_baudrate.Add(38400);
                list_baudrate.Add(43000);
                list_baudrate.Add(56000);
                list_baudrate.Add(57600);
                list_baudrate.Add(115200);
            }
            return list_baudrate;
        }

        /// <summary>
        /// //获取串口名字
        /// </summary>
        /// <returns></returns>
        public static List<string> GetListForPortName()
        {
            if (list_portName.Count == 0)
            {
                list_portName.AddRange(SerialPort.GetPortNames()); 
            }
            return list_portName;
        }
    }
}
