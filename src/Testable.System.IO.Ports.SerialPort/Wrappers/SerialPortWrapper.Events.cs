using System;
using System.ComponentModel;
using System.IO.Ports;
using Testable.System.IO.Ports.SerialPort.Abstractions;

using SystemSerialPort = System.IO.Ports.SerialPort;

namespace Testable.System.IO.Ports.SerialPort.Wrappers
{
    public partial class SerialPortWrapper : ISerialPort
    {
        /// <inheritdoc />
        public event SerialDataReceivedEventHandler? DataReceived;

        /// <inheritdoc />
        public event SerialErrorReceivedEventHandler? ErrorReceived;

        /// <inheritdoc />
        public event SerialPinChangedEventHandler? PinChanged;

        public SerialPortWrapper() : this(new SystemSerialPort())
        {
        }

        public SerialPortWrapper(IContainer container) : this(new SystemSerialPort(container))
        {
        }

        private SerialPortWrapper(SystemSerialPort serialPort)
        {
            _serialPort = serialPort;
            _serialPort.DataReceived += OnDataReceived;
            _serialPort.ErrorReceived += OnErrorReceived;
            _serialPort.PinChanged += OnPinChanged;
        }

        /// <inheritdoc />
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    _serialPort.DataReceived -= OnDataReceived;
                    _serialPort.ErrorReceived -= OnErrorReceived;
                    _serialPort.PinChanged -= OnPinChanged;
                    _serialPort.Dispose();
                }

                disposedValue = true;
            }
        }

        private void OnDataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            DataReceived?.Invoke(sender, e);
        }

        private void OnErrorReceived(object sender, SerialErrorReceivedEventArgs e)
        {
            ErrorReceived?.Invoke(sender, e);
        }

        private void OnPinChanged(object sender, SerialPinChangedEventArgs e)
        {
            PinChanged?.Invoke(sender, e);
        }
    }
}
