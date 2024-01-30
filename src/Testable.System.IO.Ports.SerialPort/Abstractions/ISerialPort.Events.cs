using System;
using System.IO.Ports;

using SystemSerialPort = System.IO.Ports.SerialPort;

namespace Testable.System.IO.Ports.SerialPort.Abstractions
{
    public partial interface ISerialPort : IDisposable
    {
        /// <inheritdoc cref="SystemSerialPort.DataReceived" />
        event SerialDataReceivedEventHandler DataReceived;

        /// <inheritdoc cref="SystemSerialPort.ErrorReceived" />
        event SerialErrorReceivedEventHandler ErrorReceived;

        /// <inheritdoc cref="SystemSerialPort.PinChanged" />
        event SerialPinChangedEventHandler PinChanged;
    }
}
