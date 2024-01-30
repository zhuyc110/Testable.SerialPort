using System.IO;
using System.IO.Ports;
using System.Text;
using Testable.System.IO.Ports.SerialPort.Abstractions;

using SystemSerialPort = System.IO.Ports.SerialPort;

namespace Testable.System.IO.Ports.SerialPort.Wrappers
{
    public partial class SerialPortWrapper : ISerialPort
    {
        private readonly SystemSerialPort _serialPort;
        private bool disposedValue;

        /// <inheritdoc />
        public Stream BaseStream => _serialPort.BaseStream;

        /// <inheritdoc />
        public int BaudRate { get => _serialPort.BaudRate; set => _serialPort.BaudRate = value; }

        /// <inheritdoc />
        public bool BreakState { get => _serialPort.BreakState; set => _serialPort.BreakState = value; }

        /// <inheritdoc />
        public int BytesToRead => _serialPort.BytesToRead;

        /// <inheritdoc />
        public int BytesToWrite => _serialPort.BytesToWrite;

        /// <inheritdoc />
        public bool CDHolding => _serialPort.CDHolding;

        /// <inheritdoc />
        public bool CtsHolding => _serialPort.CtsHolding;

        /// <inheritdoc />
        public int DataBits { get => _serialPort.DataBits; set => _serialPort.DataBits = value; }

        /// <inheritdoc />
        public bool DiscardNull { get => _serialPort.DiscardNull; set => _serialPort.DiscardNull = value; }

        /// <inheritdoc />
        public bool DsrHolding => _serialPort.DsrHolding;

        /// <inheritdoc />
        public bool DtrEnable { get => _serialPort.DtrEnable; set => _serialPort.DtrEnable = value; }

        /// <inheritdoc />
        public Encoding Encoding { get => _serialPort.Encoding; set => _serialPort.Encoding = value; }

        /// <inheritdoc />
        public Handshake Handshake { get => _serialPort.Handshake; set => _serialPort.Handshake = value; }

        /// <inheritdoc />
        public bool IsOpen => _serialPort.IsOpen;

        /// <inheritdoc />
        public string NewLine { get => _serialPort.NewLine; set => _serialPort.NewLine = value; }

        /// <inheritdoc />
        public Parity Parity { get => _serialPort.Parity; set => _serialPort.Parity = value; }

        /// <inheritdoc />
        public byte ParityReplace { get => _serialPort.ParityReplace; set => _serialPort.ParityReplace = value; }

        /// <inheritdoc />
        public string PortName { get => _serialPort.PortName; set => _serialPort.PortName = value; }

        /// <inheritdoc />
        public int ReadBufferSize { get => _serialPort.ReadBufferSize; set => _serialPort.ReadBufferSize = value; }

        /// <inheritdoc />
        public int ReadTimeout { get => _serialPort.ReadTimeout; set => _serialPort.ReadTimeout = value; }

        /// <inheritdoc />
        public int ReceivedBytesThreshold { get => _serialPort.ReceivedBytesThreshold; set => _serialPort.ReceivedBytesThreshold = value; }

        /// <inheritdoc />
        public bool RtsEnable { get => _serialPort.RtsEnable; set => _serialPort.RtsEnable = value; }

        /// <inheritdoc />
        public StopBits StopBits { get => _serialPort.StopBits; set => _serialPort.StopBits = value; }

        /// <inheritdoc />
        public int WriteBufferSize { get => _serialPort.WriteBufferSize; set => _serialPort.WriteBufferSize = value; }

        /// <inheritdoc />
        public int WriteTimeout { get => _serialPort.WriteTimeout; set => _serialPort.WriteTimeout = value; }
    }
}
