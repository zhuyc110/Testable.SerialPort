Make serial port testable!

```csharp
var factory = new SerialPortFactory();
var serialPort = factory.Create("COM1", 9600, Parity.None, 8, StopBits.One);
```