using System.IO.Ports;

namespace Testable.System.IO.Ports.SerialPort.Wrappers
{
    public partial class SerialPortWrapper
    {
        /// <inheritdoc />
        public event SerialDataReceivedEventHandler DataReceived;

        /// <inheritdoc />
        public event SerialErrorReceivedEventHandler ErrorReceived;

        /// <inheritdoc />
        public event SerialPinChangedEventHandler PinChanged;
    }
}
