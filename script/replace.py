file_path = "src\Testable.System.IO.Ports.SerialPort\Wrappers\SerialPortWrapper.cs"

new_content = []

with open(file_path, "r") as f_read:
    for line in f_read:
        # Check if the line contains NotImplementedException, if yes, 
        # read the 3rd word in the line (split by space), and replace `get => throw new NotImplementedException();` with `get => _serialPort.{3rd word in the line};`. 
        # Then replace `set => throw new NotImplementedException();` with `set => _serialPort.{3rd word in the line} = value;`
        if "NotImplementedException" in line:
            words = line.split()
            line = line.replace("get => throw new NotImplementedException();", f"get => _serialPort.{words[2]};")
            line = line.replace("set => throw new NotImplementedException();", f"set => _serialPort.{words[2]} = value;")
        new_content.append(line)
    f_read.close()


with open(file_path, "w+") as f_write:
    f_write.writelines(new_content)
    f_write.close()