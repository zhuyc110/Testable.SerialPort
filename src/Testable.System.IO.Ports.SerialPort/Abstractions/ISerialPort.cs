using System;
using System.ComponentModel;

namespace Testable.System.IO.Ports.SerialPort.Abstractions
{
    /// <summary>
    /// Abstraction of the serial port.
    /// </summary>
    public partial interface ISerialPort : IDisposable, IComponent
    {
    }
}
