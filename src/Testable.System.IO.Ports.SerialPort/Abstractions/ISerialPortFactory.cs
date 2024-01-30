using System.ComponentModel;
using System.IO.Ports;

namespace Testable.System.IO.Ports.SerialPort.Abstractions
{
    /// <summary>
    /// A factory for the creation of wrappers for <see cref="global::System.IO.Ports.SerialPort" /> in a <see cref="ISerialPort" />.
    /// </summary>
    public interface ISerialPortFactory
    {
        /// <inheritdoc cref="global::System.IO.Ports.SerialPort.GetPortNames" />
        string[] GetPortNames();

        /// <summary>
        /// Initializes an instance of a wrapper for <see cref="global::System.IO.Ports.SerialPort"/> which implements <see cref="ISerialPort"/>.
        /// </summary>
        ISerialPort Create();

        /// <summary>
        /// Initializes an instance of a wrapper for <see cref="global::System.IO.Ports.SerialPort"/> which implements <see cref="ISerialPort"/>.
        /// </summary>
        /// <param name="container">An interface to a container.</param>
        ISerialPort Create(IContainer container);

        /// <summary>
        /// Initializes an instance of a wrapper for <see cref="global::System.IO.Ports.SerialPort"/> which implements <see cref="ISerialPort"/>.
        /// </summary>
        /// <param name="portName">The port to use (for example, COM1).</param>
        ISerialPort Create(string portName);

        /// <summary>
        /// Initializes an instance of a wrapper for <see cref="global::System.IO.Ports.SerialPort"/> which implements <see cref="ISerialPort"/>.
        /// </summary>
        /// <param name="portName">The port to use (for example, COM1).</param>
        /// <param name="baudRate">The baud rate.</param>
        ISerialPort Create(string portName, int baudRate);

        /// <summary>
        /// Initializes an instance of a wrapper for <see cref="SerialPort"/> which implements <see cref="ISerialPort"/>.
        /// </summary>
        /// <param name="portName">The port to use (for example, COM1).</param>
        /// <param name="baudRate">The baud rate.</param>
        /// <param name="parity">One of the <see cref="Parity"/> values.</param>
        ISerialPort Create(string portName, int baudRate, Parity parity);

        /// <summary>
        /// Initializes an instance of a wrapper for <see cref="SerialPort"/> which implements <see cref="ISerialPort"/>.
        /// </summary>
        /// <param name="portName">The port to use (for example, COM1).</param>
        /// <param name="baudRate">The baud rate.</param>
        /// <param name="parity">One of the <see cref="Parity"/> values.</param>
        /// <param name="dataBits">The data bits value.</param>
        ISerialPort Create(string portName, int baudRate, Parity parity, int dataBits);

        /// <summary>
        /// Initializes an instance of a wrapper for <see cref="SerialPort"/> which implements <see cref="ISerialPort"/>.
        /// </summary>
        /// <param name="portName">The port to use (for example, COM1).</param>
        /// <param name="baudRate">The baud rate.</param>
        /// <param name="parity">One of the <see cref="Parity"/> values.</param>
        /// <param name="dataBits">The data bits value.</param>
        /// <param name="stopBits">One of the <see cref="StopBits"/> values.</param>
        ISerialPort Create(string portName, int baudRate, Parity parity, int dataBits, StopBits stopBits);
    }
}
