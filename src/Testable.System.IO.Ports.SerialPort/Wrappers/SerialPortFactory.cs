using System.ComponentModel;
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
    }
}
