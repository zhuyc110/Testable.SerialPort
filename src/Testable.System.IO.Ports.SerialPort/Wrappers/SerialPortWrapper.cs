using System;
using System.ComponentModel;
using System.IO.Ports;
using Testable.System.IO.Ports.SerialPort.Abstractions;

namespace Testable.System.IO.Ports.SerialPort.Wrappers
{
    public partial class SerialPortWrapper : ISerialPort
    {
        /// <inheritdoc />
        public ISite? Site { get => _serialPort.Site; set => _serialPort.Site = value; }

        /// <inheritdoc />
        public event EventHandler? Disposed;

        public SerialPortWrapper() : this(new global::System.IO.Ports.SerialPort())
        {
        }

        public SerialPortWrapper(IContainer container) : this(new global::System.IO.Ports.SerialPort(container))
        {
        }

        public SerialPortWrapper(string portName) : this(new global::System.IO.Ports.SerialPort(portName))
        {
        }

        public SerialPortWrapper(string portName, int baudRate) : this(new global::System.IO.Ports.SerialPort(portName, baudRate))
        {
        }

        public SerialPortWrapper(string portName, int baudRate, Parity parity) : this(new global::System.IO.Ports.SerialPort(portName, baudRate, parity))
        {
        }

        public SerialPortWrapper(string portName, int baudRate, Parity parity, int dataBits) : this(new global::System.IO.Ports.SerialPort(portName, baudRate, parity, dataBits))
        {
        }

        public SerialPortWrapper(string portName, int baudRate, Parity parity, int dataBits, StopBits stopBits) 
            : this(new global::System.IO.Ports.SerialPort(portName, baudRate, parity, dataBits, stopBits))
        {
        }

        private SerialPortWrapper(global::System.IO.Ports.SerialPort serialPort)
        {
            _serialPort = serialPort;
            _serialPort.DataReceived += OnDataReceived;
            _serialPort.ErrorReceived += OnErrorReceived;
            _serialPort.PinChanged += OnPinChanged;
            _serialPort.Disposed += OnDisposed;
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
                    _serialPort.Disposed -= OnDisposed;
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

        private void OnDisposed(object? sender, EventArgs e)
        {
            Disposed?.Invoke(sender, e);
        }
    }
}
