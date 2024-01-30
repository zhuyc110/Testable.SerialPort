using System.IO;
using System.IO.Ports;
using System.Text;

namespace Testable.System.IO.Ports.SerialPort.Abstractions
{
    public partial interface ISerialPort
    {
        /// <inheritdoc cref="global::System.IO.Ports.SerialPort.BaseStream" />
        Stream BaseStream { get; }

        /// <inheritdoc cref="global::System.IO.Ports.SerialPort.BaudRate" />
        int BaudRate { get; set; }

        /// <inheritdoc cref="global::System.IO.Ports.SerialPort.BreakState" />
        bool BreakState { get; set; }

        /// <inheritdoc cref="global::System.IO.Ports.SerialPort.BytesToRead" />
        int BytesToRead { get; }

        /// <inheritdoc cref="global::System.IO.Ports.SerialPort.BytesToWrite" />
        int BytesToWrite { get; }

        /// <inheritdoc cref="global::System.IO.Ports.SerialPort.CDHolding" />
        bool CDHolding { get; }

        /// <inheritdoc cref="global::System.IO.Ports.SerialPort.CtsHolding" />
        bool CtsHolding { get; }

        /// <inheritdoc cref="global::System.IO.Ports.SerialPort.DataBits" />
        int DataBits { get; set; }

        /// <inheritdoc cref="global::System.IO.Ports.SerialPort.DiscardNull" />
        bool DiscardNull { get; set; }

        /// <inheritdoc cref="global::System.IO.Ports.SerialPort.DsrHolding" />
        bool DsrHolding { get; }

        /// <inheritdoc cref="global::System.IO.Ports.SerialPort.DtrEnable" />
        bool DtrEnable { get; set; }

        /// <inheritdoc cref="global::System.IO.Ports.SerialPort.Encoding" />
        Encoding Encoding { get; set; }

        /// <inheritdoc cref="global::System.IO.Ports.SerialPort.Handshake" />
        Handshake Handshake { get; set; }

        /// <inheritdoc cref="global::System.IO.Ports.SerialPort.IsOpen" />
        bool IsOpen { get; }

        /// <inheritdoc cref="global::System.IO.Ports.SerialPort.NewLine" />
        string NewLine { get; set; }

        /// <inheritdoc cref="global::System.IO.Ports.SerialPort.Parity" />
        Parity Parity { get; set; }

        /// <inheritdoc cref="global::System.IO.Ports.SerialPort.ParityReplace" />
        byte ParityReplace { get; set; }

        /// <inheritdoc cref="global::System.IO.Ports.SerialPort.PortName" />
        string PortName { get; set; }

        /// <inheritdoc cref="global::System.IO.Ports.SerialPort.ReadBufferSize" />
        int ReadBufferSize { get; set; }

        /// <inheritdoc cref="global::System.IO.Ports.SerialPort.ReadTimeout" />
        int ReadTimeout { get; set; }

        /// <inheritdoc cref="global::System.IO.Ports.SerialPort.ReceivedBytesThreshold" />
        int ReceivedBytesThreshold { get; set; }

        /// <inheritdoc cref="global::System.IO.Ports.SerialPort.RtsEnable" />
        bool RtsEnable { get; set; }

        /// <inheritdoc cref="global::System.IO.Ports.SerialPort.StopBits" />
        StopBits StopBits { get; set; }

        /// <inheritdoc cref="global::System.IO.Ports.SerialPort.WriteBufferSize" />
        int WriteBufferSize { get; set; }

        /// <inheritdoc cref="global::System.IO.Ports.SerialPort.WriteTimeout" />
        int WriteTimeout { get; set; }
    }
}
