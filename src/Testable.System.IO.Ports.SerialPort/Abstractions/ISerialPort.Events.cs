using System.IO.Ports;

namespace Testable.System.IO.Ports.SerialPort.Abstractions
{
    public partial interface ISerialPort 
    {
        /// <inheritdoc cref="global::System.IO.Ports.SerialPort.DataReceived" />
        event SerialDataReceivedEventHandler DataReceived;

        /// <inheritdoc cref="global::System.IO.Ports.SerialPort.ErrorReceived" />
        event SerialErrorReceivedEventHandler ErrorReceived;

        /// <inheritdoc cref="global::System.IO.Ports.SerialPort.PinChanged" />
        event SerialPinChangedEventHandler PinChanged;
    }
}
