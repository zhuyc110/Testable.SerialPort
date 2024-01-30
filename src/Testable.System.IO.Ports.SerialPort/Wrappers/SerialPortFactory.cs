using System.ComponentModel;
using System.IO.Ports;
using Testable.System.IO.Ports.SerialPort.Abstractions;

namespace Testable.System.IO.Ports.SerialPort.Wrappers
{
    /// <inheritdoc />
    public class SerialPortFactory : ISerialPortFactory
    {
        /// <inheritdoc />
        public ISerialPort Create()
        {
            return new SerialPortWrapper();
        }

        /// <inheritdoc />
        public ISerialPort Create(IContainer container)
        {
            return new SerialPortWrapper(container);
        }

        /// <inheritdoc />
        public ISerialPort Create(string portName)
        {
            return new SerialPortWrapper(portName);
        }

        /// <inheritdoc />
        public ISerialPort Create(string portName, int baudRate)
        {
            return new SerialPortWrapper(portName, baudRate);
        }

        /// <inheritdoc />
        public ISerialPort Create(string portName, int baudRate, Parity parity)
        {
            return new SerialPortWrapper(portName, baudRate, parity);
        }

        /// <inheritdoc />
        public ISerialPort Create(string portName, int baudRate, Parity parity, int dataBits)
        {
            return new SerialPortWrapper(portName, baudRate, parity, dataBits);
        }

        /// <inheritdoc />
        public ISerialPort Create(string portName, int baudRate, Parity parity, int dataBits, StopBits stopBits)
        {
            return new SerialPortWrapper(portName, baudRate, parity, dataBits, stopBits);
        }

        /// <inheritdoc />
        public string[] GetPortNames()
        {
            return global::System.IO.Ports.SerialPort.GetPortNames();
        }
    }
}
