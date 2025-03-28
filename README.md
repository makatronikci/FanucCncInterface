# FanucCncInterface

FanucCncInterface is a .NET library designed for communication with Fanuc CNC machines. Using the Focas library, it allows you to connect to CNC machines, read and write data, and collect production data.

## Features

- **Connection Management**: Establish and close CNC connections
- **Data Writing**:
  - Write 4-byte data (positive and negative integer values)
  - Write single-bit or single-byte signals
  - Write to macro registers
- **Data Reading**:
  - Read 4-byte data
  - Read signal data
  - Read macro register values
- **Production Data Collection**: Retrieve CNC status information and production statistics

## Installation

To use this library, ensure that the Focas library is installed in your project.

```csharp
using FanucCncInterface;
```

## Usage

### Connecting to CNC

```csharp
CncInterface cnc = new CncInterface();
EventResult result = cnc.ConnectFanuc("192.168.0.1", 8193);
if (result == EventResult.Success)
{
    Console.WriteLine("Connection successful.");
}
else
{
    Console.WriteLine("Connection failed.");
}
```

### Disconnecting from CNC

```csharp
cnc.DisconnectFanuc();
```

### Writing Data

```csharp
cnc.WriteDDataFourByte(0, 1234);
cnc.WriteDSignal(10, 2, true);
```

### Reading Data

```csharp
var data = cnc.ReadDDataFourByte(0);
if (data is int value)
{
    Console.WriteLine($"Read data: {value}");
}
```

### Collecting Production Data

```csharp
var productionData = cnc.CollectPRoductionData();
if (productionData is ProductionData pd)
{
    Console.WriteLine($"Part Counter: {pd.PartCounter}");
}
```

## Requirements

- .NET Framework / .NET Core
- Fanuc Focas Library

## License

This project is released under the MIT License.

