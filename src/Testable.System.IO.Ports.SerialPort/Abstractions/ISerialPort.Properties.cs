using System.IO;
using System.IO.Ports;
using System.Text;

using SystemSerialPort = System.IO.Ports.SerialPort;

namespace Testable.System.IO.Ports.SerialPort.Abstractions
{
    public partial interface ISerialPort
    {
        /// <inheritdoc cref="SystemSerialPort.BaseStream" />
        Stream BaseStream { get; }

        /// <inheritdoc cref="SystemSerialPort.BaudRate" />
        int BaudRate { get; set; }

        /// <inheritdoc cref="SystemSerialPort.BreakState" />
        bool BreakState { get; set; }

        /// <inheritdoc cref="SystemSerialPort.BytesToRead" />
        int BytesToRead { get; }

        /// <inheritdoc cref="SystemSerialPort.BytesToWrite" />
        int BytesToWrite { get; }

        /// <inheritdoc cref="SystemSerialPort.CDHolding" />
        bool CDHolding { get; }

        /// <inheritdoc cref="SystemSerialPort.CtsHolding" />
        bool CtsHolding { get; }

        /// <inheritdoc cref="SystemSerialPort.DataBits" />
        int DataBits { get; set; }

        /// <inheritdoc cref="SystemSerialPort.DiscardNull" />
        bool DiscardNull { get; set; }

        /// <inheritdoc cref="SystemSerialPort.DsrHolding" />
        bool DsrHolding { get; }

        /// <inheritdoc cref="SystemSerialPort.DtrEnable" />
        bool DtrEnable { get; set; }

        /// <inheritdoc cref="SystemSerialPort.Encoding" />
        Encoding Encoding { get; set; }

        /// <inheritdoc cref="SystemSerialPort.Handshake" />
        Handshake Handshake { get; set; }

        /// <inheritdoc cref="SystemSerialPort.IsOpen" />
        bool IsOpen { get; }

        /// <inheritdoc cref="SystemSerialPort.NewLine" />
        string NewLine { get; set; }

        /// <inheritdoc cref="SystemSerialPort.Parity" />
        Parity Parity { get; set; }

        /// <inheritdoc cref="SystemSerialPort.ParityReplace" />
        byte ParityReplace { get; set; }

        /// <inheritdoc cref="SystemSerialPort.PortName" />
        string PortName { get; set; }

        /// <inheritdoc cref="SystemSerialPort.ReadBufferSize" />
        int ReadBufferSize { get; set; }

        /// <inheritdoc cref="SystemSerialPort.ReadTimeout" />
        int ReadTimeout { get; set; }

        /// <inheritdoc cref="SystemSerialPort.ReceivedBytesThreshold" />
        int ReceivedBytesThreshold { get; set; }

        /// <inheritdoc cref="SystemSerialPort.RtsEnable" />
        bool RtsEnable { get; set; }

        /// <inheritdoc cref="SystemSerialPort.StopBits" />
        StopBits StopBits { get; set; }

        /// <inheritdoc cref="SystemSerialPort.WriteBufferSize" />
        int WriteBufferSize { get; set; }

        /// <inheritdoc cref="SystemSerialPort.WriteTimeout" />
        int WriteTimeout { get; set; }
    }
}
