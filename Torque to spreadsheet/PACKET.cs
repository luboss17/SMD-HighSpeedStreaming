using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class PACKET
    {
        private byte[] packet;
        public PACKET(byte[] packet)
        {
            this.packet = packet;
        }

        //decode each packet and return list of all readings in that packet
        //todo: handle angle and other type of streaming
        public List<double> decodePacket()
        {
            List<double> readings = new List<double>();
            double reading;
            if ((packet[0] >= 161) && (packet[0] <= 175))
            {
                int pos = 2;
                int readingByteLength = 3;//this value=how many bytes existed for each single reading(including angle)
                while (pos < packet.Length - readingByteLength)
                {
                    byte[] readingOnly = new byte[3] { packet[pos], packet[pos + 1], packet[pos + 2] };
                    reading = decodeReading(readingOnly);
                    readings.Add(reading);
                    pos += readingByteLength;
                }
            }
            return readings;
        }

        //calculate reading
        //pass in 3 bytes buffer
        private double decodeReading(byte[] buffer)
        {
            double value;
            //BitArray bitArrays = new BitArray(readingBytes);
            //BitArray mantissa = new BitArray();
            int mantissa, exp, sign;
            mantissa = buffer[0] | (buffer[1] << 8) | ((buffer[2] & 0x0F) << 16);
            exp = ((buffer[2] >> 4) & 7) - 5;
            sign = buffer[2] & 0x0F;
            value = /*((-1) ^ sign) **/ mantissa * (Math.Pow(10, exp));
            //if (buffer[2]&0x80)

            return value;
        }
    }
}
