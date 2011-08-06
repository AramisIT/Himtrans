using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraBars.Ribbon;
using System.Threading;
using System.IO.Ports;

namespace Himtrans.WeightGetting
    {
    public delegate void WeightAcceptedDelegate(double value);


    class WeightGetting
        {
        public event WeightAcceptedDelegate OnWeightAccepted;
        private Thread thisThread;
        private string portName;
        SerialPort ComPort;

        public bool Started
            {
            get;
            private set;
            }

        public WeightGetting(int portNo)
            {
            this.portName = "COM" + portNo.ToString();
            }

        public void Start()
            {
            if ( thisThread == null )
                {
                thisThread = new Thread(new ThreadStart(start));
                thisThread.IsBackground = true;
                thisThread.Start();
                Started = true;
                }
            }

        public void Stop()
            {
            if ( thisThread != null )
                {
                if ( ComPort.IsOpen )
                    {
                    ComPort.Close();
                    }
                thisThread.Abort();
                Started = false;
                }
            thisThread = null;
            }

        private void start()
            {
            while ( true )
                {
                try
                    {
                    using ( ComPort = new SerialPort(portName) )
                        {
                        ComPort.BaudRate = 9600; // Bits per second
                        ComPort.Parity = Parity.None;
                        ComPort.DataBits = 8;
                        ComPort.ReadTimeout = 300;
                        ComPort.StopBits = StopBits.One;
                        ComPort.Handshake = Handshake.None;
                        try
                            {
                            ComPort.Open();

                            ReadingSerialPort(ComPort);

                            ComPort.Close();
                            }
                        catch
                            {
                            if ( ComPort.IsOpen )
                                {
                                ComPort.Close();
                                }
                            }
                        }
                    }
                catch
                    {
                    Thread.Sleep(100);
                    }
                }
            }

        private void ReadingSerialPort(SerialPort ComPort)
            {
            #region Variables defined

            string str;
            int startIndex;
            int lenght;
            string temp;
            double weight;

            #endregion

            while ( true )
                {
                try
                    {

                    #region Serial port reading

                    try
                        {
                        str = ComPort.ReadLine();
                        }
                    catch ( TimeoutException exp )
                        {
                        continue;
                        }

                    #endregion

                    startIndex = str.IndexOf('S') + 1;
                    lenght = str.IndexOf("kg") - startIndex;
                    temp = str.Substring(startIndex, lenght).Trim();

                    if ( Double.TryParse(temp.Replace('.', ','), out weight) )
                        {
                        if ( OnWeightAccepted != null )
                            {
                            OnWeightAccepted(weight);
                            }
                        }
                    }
                catch
                    {
                    break;
                    }
                }
            }

        }
    }
