using System.ComponentModel;

namespace Testable.System.IO.Ports.SerialPort.Abstractions
{
    public interface ISerialPortFactory
    {
        /// <summary>
        /// Initializes an instance of a wrapper for <see cref="SerialPort"/> which implements <see cref="ISerialPort"/>.
        /// </summary>
        ISerialPort Create();

        /// <summary>
        /// Initializes an instance of a wrapper for <see cref="SerialPort"/> which implements <see cref="ISerialPort"/>.
        /// </summary>
        /// <param name="container">An interface to a container.</param>
        ISerialPort Create(IContainer container);
    }
}
