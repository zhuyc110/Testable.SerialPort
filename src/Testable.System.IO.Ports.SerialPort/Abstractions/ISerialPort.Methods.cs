namespace Testable.System.IO.Ports.SerialPort.Abstractions
{
    public partial interface ISerialPort
    {
        /// <inheritdoc cref="global::System.IO.Ports.SerialPort.Close" />
        void Close();

        /// <inheritdoc cref="global::System.IO.Ports.SerialPort.DiscardInBuffer" />
        void DiscardInBuffer();

        /// <inheritdoc cref="global::System.IO.Ports.SerialPort.DiscardOutBuffer" />
        void DiscardOutBuffer();

        /// <inheritdoc cref="global::System.IO.Ports.SerialPort.GetPortNames" />
        string[] GetPortNames();

        /// <inheritdoc cref="global::System.IO.Ports.SerialPort.Open" />
        void Open();

        /// <inheritdoc cref="global::System.IO.Ports.SerialPort.Read" />
        int Read(byte[] buffer, int offset, int count);

        /// <inheritdoc cref="global::System.IO.Ports.SerialPort.Read" />
        int Read(char[] buffer, int offset, int count);

        /// <inheritdoc cref="global::System.IO.Ports.SerialPort.ReadByte" />
        int ReadByte();

        /// <inheritdoc cref="global::System.IO.Ports.SerialPort.ReadChar" />
        int ReadChar();

        /// <inheritdoc cref="global::System.IO.Ports.SerialPort.ReadExisting" />
        string ReadExisting();

        /// <inheritdoc cref="global::System.IO.Ports.SerialPort.ReadLine" />
        string ReadLine();

        /// <inheritdoc cref="global::System.IO.Ports.SerialPort.ReadTo" />
        string ReadTo(string value);

        /// <inheritdoc cref="global::System.IO.Ports.SerialPort.Write" />
        void Write(string text);

        /// <inheritdoc cref="global::System.IO.Ports.SerialPort.Write" />
        void Write(byte[] buffer, int offset, int count);

        /// <inheritdoc cref="global::System.IO.Ports.SerialPort.Write" />
        void Write(char[] buffer, int offset, int count);

        /// <inheritdoc cref="global::System.IO.Ports.SerialPort.WriteLine" />
        void WriteLine(string text);
    }
}
