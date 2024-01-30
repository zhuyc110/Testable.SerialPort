namespace Testable.System.IO.Ports.SerialPort.Wrappers
{
    public partial class SerialPortWrapper
    {
        /// <inheritdoc />
        public void Close()
        {
            _serialPort.Close();
        }

        /// <inheritdoc />
        public void DiscardInBuffer()
        {
            _serialPort.DiscardInBuffer();
        }

        /// <inheritdoc />
        public void DiscardOutBuffer()
        {
            _serialPort.DiscardOutBuffer();
        }

        /// <inheritdoc />
        public string[] GetPortNames()
        {
            return global::System.IO.Ports.SerialPort.GetPortNames();
        }

        /// <inheritdoc />
        public void Open()
        {
            _serialPort.Open();
        }

        /// <inheritdoc />
        public int Read(byte[] buffer, int offset, int count)
        {
            return _serialPort.Read(buffer, offset, count);
        }

        /// <inheritdoc />
        public int Read(char[] buffer, int offset, int count)
        {
            return _serialPort.Read(buffer, offset,count);
        }

        /// <inheritdoc />
        public int ReadByte()
        {
            return _serialPort.ReadByte();
        }

        /// <inheritdoc />
        public int ReadChar()
        {
            return _serialPort.ReadChar();
        }

        /// <inheritdoc />
        public string ReadExisting()
        {
            return _serialPort.ReadExisting();
        }

        /// <inheritdoc />
        public string ReadLine()
        {
            return _serialPort.ReadLine();
        }

        /// <inheritdoc />
        public string ReadTo(string value)
        {
            return _serialPort.ReadTo(value);
        }

        /// <inheritdoc />
        public void Write(string text)
        {
            _serialPort.Write(text);
        }

        /// <inheritdoc />
        public void Write(byte[] buffer, int offset, int count)
        {
            _serialPort.Write(buffer, offset, count);
        }

        /// <inheritdoc />
        public void Write(char[] buffer, int offset, int count)
        {
            _serialPort.Write(buffer, offset, count);
        }

        /// <inheritdoc />
        public void WriteLine(string text)
        {
            _serialPort.WriteLine(text);
        }
    }
}
