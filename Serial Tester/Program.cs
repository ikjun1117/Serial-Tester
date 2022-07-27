using System;
using System.Text;
using System.IO.Ports;

namespace SerialTester
{
    class MainApp
    {
        public static void Main(string[] args)
        {
            SerialWorker worker = new SerialWorker();
            Console.WriteLine("Hex값, 띄어쓰기, 대문자, break입력 시 종료");
            while (true)
            {
                string arg = Console.ReadLine();

                if (arg.Equals("quit"))
                    break;
                else
                {
                    string[] temp = arg.Split(" ");
                    byte[] ttemp = new byte[temp.Length];
                    for (int i = 0; i < temp.Length; i++)
                    {
                        ttemp[i] = Convert.ToByte(temp[i], 16);
                    }
                    worker.writeData(ttemp);
                }
            }
            worker.closePort();
        }
    }
}