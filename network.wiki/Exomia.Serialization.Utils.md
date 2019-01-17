## `BitUtil`

fast binary read and write operations on a byte array
```csharp
public static class Exomia.Serialization.Utils.BitUtil

```

Static Methods

| Type | Name | Summary | 
| --- | --- | --- | 
| `Boolean[]` | ReadArrayBoolean(`Byte[]&` bytes, `Int32` offset, `Int32&` byteSize) | reads a boolean value of the byte array from the given offset | 
| `Boolean[]` | ReadArrayBoolean(`Byte*` src, `Int32` offset, `Int32&` byteSize) | reads a boolean value of the byte array from the given offset | 
| `Char[]` | ReadArrayChar(`Byte[]&` bytes, `Int32` offset, `Int32&` byteSize) | reads a char value of the byte array from the given offset | 
| `Char[]` | ReadArrayChar(`Byte*` src, `Int32` offset, `Int32&` byteSize) | reads a char value of the byte array from the given offset | 
| `DateTime[]` | ReadArrayDateTime(`Byte[]&` bytes, `Int32` offset, `Int32&` byteSize) | reads a Guid value of the byte array from the given offset | 
| `DateTime[]` | ReadArrayDateTime(`Byte*` src, `Int32` offset, `Int32&` byteSize) | reads a Guid value of the byte array from the given offset | 
| `Decimal[]` | ReadArrayDecimal(`Byte[]&` bytes, `Int32` offset, `Int32&` byteSize) | reads a decimal value of the byte array from the given offset | 
| `Decimal[]` | ReadArrayDecimal(`Byte*` src, `Int32` offset, `Int32&` byteSize) | reads a decimal value of the byte array from the given offset | 
| `Guid[]` | ReadArrayGuid(`Byte[]&` bytes, `Int32` offset, `Int32&` byteSize) | reads a Guid value of the byte array from the given offset | 
| `Guid[]` | ReadArrayGuid(`Byte*` src, `Int32` offset, `Int32&` byteSize) | reads a Guid value of the byte array from the given offset | 
| `Int16[]` | ReadArrayInt16(`Byte[]&` bytes, `Int32` offset, `Int32&` byteSize) | reads a short value of the byte array from the given offset | 
| `Int16[]` | ReadArrayInt16(`Byte*` src, `Int32` offset, `Int32&` byteSize) | reads a short value of the byte array from the given offset | 
| `Int32[]` | ReadArrayInt32(`Byte[]&` bytes, `Int32` offset, `Int32&` byteSize) | reads a int value of the byte array from the given offset | 
| `Int32[]` | ReadArrayInt32(`Byte*` src, `Int32` offset, `Int32&` byteSize) | reads a int value of the byte array from the given offset | 
| `Int64[]` | ReadArrayInt64(`Byte[]&` bytes, `Int32` offset, `Int32&` byteSize) | reads a long value of the byte array from the given offset | 
| `Int64[]` | ReadArrayInt64(`Byte*` src, `Int32` offset, `Int32&` byteSize) | reads a long value of the byte array from the given offset | 
| `Double[]` | ReadArrayReal(`Byte[]&` bytes, `Int32` offset, `Int32&` byteSize) | reads a double value of the byte array from the given offset | 
| `Double[]` | ReadArrayReal(`Byte*` src, `Int32` offset, `Int32&` byteSize) | reads a double value of the byte array from the given offset | 
| `Single[]` | ReadArraySingle(`Byte[]&` bytes, `Int32` offset, `Int32&` byteSize) | reads a float value of the byte array from the given offset | 
| `Single[]` | ReadArraySingle(`Byte*` src, `Int32` offset, `Int32&` byteSize) | reads a float value of the byte array from the given offset | 
| `String[]` | ReadArrayString(`Byte[]&` bytes, `Int32` offset, `Int32&` byteSize) | reads a string value of the byte array from the given offset | 
| `TimeSpan[]` | ReadArrayTimeSpan(`Byte[]&` bytes, `Int32` offset, `Int32&` byteSize) | reads a Guid value of the byte array from the given offset | 
| `TimeSpan[]` | ReadArrayTimeSpan(`Byte*` src, `Int32` offset, `Int32&` byteSize) | reads a Guid value of the byte array from the given offset | 
| `UInt16[]` | ReadArrayUInt16(`Byte[]&` bytes, `Int32` offset, `Int32&` byteSize) | reads a ushort value of the byte array from the given offset | 
| `UInt16[]` | ReadArrayUInt16(`Byte*` src, `Int32` offset, `Int32&` byteSize) | reads a ushort value of the byte array from the given offset | 
| `UInt32[]` | ReadArrayUInt32(`Byte[]&` bytes, `Int32` offset, `Int32&` byteSize) | reads a uint value of the byte array from the given offset | 
| `UInt32[]` | ReadArrayUInt32(`Byte*` src, `Int32` offset, `Int32&` byteSize) | reads a uint value of the byte array from the given offset | 
| `UInt64[]` | ReadArrayUInt64(`Byte[]&` bytes, `Int32` offset, `Int32&` byteSize) | reads a ulong value of the byte array from the given offset | 
| `UInt64[]` | ReadArrayUInt64(`Byte*` src, `Int32` offset, `Int32&` byteSize) | reads a ulong value of the byte array from the given offset | 
| `Boolean` | ReadBoolean(`Byte*` src, `Int32` offset) | reads a boolean value of the byte array from the given offset | 
| `Boolean` | ReadBoolean(`Byte[]&` bytes, `Int32` offset) | reads a boolean value of the byte array from the given offset | 
| `Byte` | ReadByte(`Byte[]&` bytes, `Int32` offset) | reads a byte value of the byte array from the given offset | 
| `Byte` | ReadByte(`Byte*` src, `Int32` offset) | reads a byte value of the byte array from the given offset | 
| `Byte[]` | ReadBytes(`Byte[]&` bytes, `Int32` offset, `Int32` count) | reads a byte array of the byte array from the given offset | 
| `Char` | ReadChar(`Byte[]&` bytes, `Int32` offset) | reads a char value of the byte array from the given offset | 
| `Char` | ReadChar(`Byte*` src, `Int32` offset) | reads a char value of the byte array from the given offset | 
| `DateTime` | ReadDateTime(`Byte[]&` bytes, `Int32` offset) | reads a Guid value of the byte array from the given offset | 
| `DateTime` | ReadDateTime(`Byte*` src, `Int32` offset) | reads a Guid value of the byte array from the given offset | 
| `Decimal` | ReadDecimal(`Byte[]&` bytes, `Int32` offset) | reads a decimal value of the byte array from the given offset | 
| `Decimal` | ReadDecimal(`Byte*` src, `Int32` offset) | reads a decimal value of the byte array from the given offset | 
| `Guid` | ReadGuid(`Byte[]&` bytes, `Int32` offset) | reads a Guid value of the byte array from the given offset | 
| `Guid` | ReadGuid(`Byte*` src, `Int32` offset) | reads a Guid value of the byte array from the given offset | 
| `Int16` | ReadInt16(`Byte[]&` bytes, `Int32` offset) | reads a short value of the byte array from the given offset | 
| `Int16` | ReadInt16(`Byte*` src, `Int32` offset) | reads a short value of the byte array from the given offset | 
| `Int32` | ReadInt32(`Byte[]&` bytes, `Int32` offset) | reads a int value of the byte array from the given offset | 
| `Int32` | ReadInt32(`Byte*` src, `Int32` offset) | reads a int value of the byte array from the given offset | 
| `Int64` | ReadInt64(`Byte[]&` bytes, `Int32` offset) | reads a long value of the byte array from the given offset | 
| `Int64` | ReadInt64(`Byte*` src, `Int32` offset) | reads a long value of the byte array from the given offset | 
| `Double` | ReadReal(`Byte[]&` bytes, `Int32` offset) | reads a double value of the byte array from the given offset | 
| `Double` | ReadReal(`Byte*` src, `Int32` offset) | reads a double value of the byte array from the given offset | 
| `SByte` | ReadSByte(`Byte[]&` bytes, `Int32` offset) | reads a sbyte value of the byte array from the given offset | 
| `SByte` | ReadSByte(`Byte*` src, `Int32` offset) | reads a sbyte value of the byte array from the given offset | 
| `Single` | ReadSingle(`Byte[]&` bytes, `Int32` offset) | reads a float value of the byte array from the given offset | 
| `Single` | ReadSingle(`Byte*` src, `Int32` offset) | reads a float value of the byte array from the given offset | 
| `String` | ReadString(`Byte[]&` bytes, `Int32` offset) | reads a string value of the byte array from the given offset | 
| `String` | ReadString(`Byte[]&` bytes, `Int32` offset, `Encoding` encoding) | reads a string value of the byte array from the given offset | 
| `String` | ReadString(`Byte[]&` bytes, `Int32` offset, `Int32&` byteSize) | reads a string value of the byte array from the given offset | 
| `String` | ReadString(`Byte[]&` bytes, `Int32` offset, `Encoding` encoding, `Int32&` byteSize) | reads a string value of the byte array from the given offset | 
| `String` | ReadString(`Byte*` src, `Int32` offset) | reads a string value of the byte array from the given offset | 
| `String` | ReadString(`Byte*` src, `Int32` offset, `Int32&` byteSize) | reads a string value of the byte array from the given offset | 
| `String` | ReadString(`Byte*` src, `Int32` offset, `Encoding` encoding) | reads a string value of the byte array from the given offset | 
| `String` | ReadString(`Byte*` src, `Int32` offset, `Encoding` encoding, `Int32&` byteSize) | reads a string value of the byte array from the given offset | 
| `TimeSpan` | ReadTimeSpan(`Byte[]&` bytes, `Int32` offset) | reads a Guid value of the byte array from the given offset | 
| `TimeSpan` | ReadTimeSpan(`Byte*` src, `Int32` offset) | reads a Guid value of the byte array from the given offset | 
| `UInt16` | ReadUInt16(`Byte[]&` bytes, `Int32` offset) | reads a ushort value of the byte array from the given offset | 
| `UInt16` | ReadUInt16(`Byte*` src, `Int32` offset) | reads a ushort value of the byte array from the given offset | 
| `UInt32` | ReadUInt32(`Byte[]&` bytes, `Int32` offset) | reads a uint value of the byte array from the given offset | 
| `UInt32` | ReadUInt32(`Byte*` src, `Int32` offset) | reads a uint value of the byte array from the given offset | 
| `UInt64` | ReadUInt64(`Byte[]&` bytes, `Int32` offset) | reads a ulong value of the byte array from the given offset | 
| `UInt64` | ReadUInt64(`Byte*` src, `Int32` offset) | reads a ulong value of the byte array from the given offset | 
| `Int32` | Write(`Byte[]&` bytes, `Int32` offset, `Decimal` value) | writes a boolean array into the byte array to the given offset | 
| `Int32` | Write(`Byte[]&` bytes, `Int32` offset, `Guid` value) | writes a boolean array into the byte array to the given offset | 
| `Int32` | Write(`Byte[]&` bytes, `Int32` offset, `TimeSpan` value) | writes a boolean array into the byte array to the given offset | 
| `Int32` | Write(`Byte[]&` bytes, `Int32` offset, `DateTime` value) | writes a boolean array into the byte array to the given offset | 
| `Int32` | Write(`Byte[]&` bytes, `Int32` offset, `Boolean` value) | writes a boolean array into the byte array to the given offset | 
| `Int32` | Write(`Byte[]&` bytes, `Int32` offset, `Byte` value) | writes a boolean array into the byte array to the given offset | 
| `Int32` | Write(`Byte[]&` bytes, `Int32` offset, `SByte` value) | writes a boolean array into the byte array to the given offset | 
| `Int32` | Write(`Byte[]&` bytes, `Int32` offset, `Byte[]` value) | writes a boolean array into the byte array to the given offset | 
| `Int32` | Write(`Byte[]&` bytes, `Int32` offset, `Single` value) | writes a boolean array into the byte array to the given offset | 
| `Int32` | Write(`Byte[]&` bytes, `Int32` offset, `Double` value) | writes a boolean array into the byte array to the given offset | 
| `Int32` | Write(`Byte[]&` bytes, `Int32` offset, `Int16` value) | writes a boolean array into the byte array to the given offset | 
| `Int32` | Write(`Byte[]&` bytes, `Int32` offset, `UInt16` value) | writes a boolean array into the byte array to the given offset | 
| `Int32` | Write(`Byte[]&` bytes, `Int32` offset, `Int32` value) | writes a boolean array into the byte array to the given offset | 
| `Int32` | Write(`Byte[]&` bytes, `Int32` offset, `UInt32` value) | writes a boolean array into the byte array to the given offset | 
| `Int32` | Write(`Byte[]&` bytes, `Int32` offset, `Int64` value) | writes a boolean array into the byte array to the given offset | 
| `Int32` | Write(`Byte[]&` bytes, `Int32` offset, `UInt64` value) | writes a boolean array into the byte array to the given offset | 
| `Int32` | Write(`Byte[]&` bytes, `Int32` offset, `Char` value) | writes a boolean array into the byte array to the given offset | 
| `Int32` | Write(`Byte[]&` bytes, `Int32` offset, `String` value) | writes a boolean array into the byte array to the given offset | 
| `Int32` | Write(`Byte[]&` bytes, `Int32` offset, `String` value, `Encoding` encoding) | writes a boolean array into the byte array to the given offset | 
| `Int32` | Write(`Byte[]&` bytes, `Int32` offset, `Boolean[]` values) | writes a boolean array into the byte array to the given offset | 
| `Int32` | Write(`Byte[]&` bytes, `Int32` offset, `SByte[]` values) | writes a boolean array into the byte array to the given offset | 
| `Int32` | Write(`Byte[]&` bytes, `Int32` offset, `Single[]` values) | writes a boolean array into the byte array to the given offset | 
| `Int32` | Write(`Byte[]&` bytes, `Int32` offset, `Double[]` values) | writes a boolean array into the byte array to the given offset | 
| `Int32` | Write(`Byte[]&` bytes, `Int32` offset, `Int16[]` values) | writes a boolean array into the byte array to the given offset | 
| `Int32` | Write(`Byte[]&` bytes, `Int32` offset, `UInt16[]` values) | writes a boolean array into the byte array to the given offset | 
| `Int32` | Write(`Byte[]&` bytes, `Int32` offset, `Int32[]` values) | writes a boolean array into the byte array to the given offset | 
| `Int32` | Write(`Byte[]&` bytes, `Int32` offset, `UInt32[]` values) | writes a boolean array into the byte array to the given offset | 
| `Int32` | Write(`Byte[]&` bytes, `Int32` offset, `Int64[]` values) | writes a boolean array into the byte array to the given offset | 
| `Int32` | Write(`Byte[]&` bytes, `Int32` offset, `UInt64[]` values) | writes a boolean array into the byte array to the given offset | 
| `Int32` | Write(`Byte[]&` bytes, `Int32` offset, `Char[]` values) | writes a boolean array into the byte array to the given offset | 
| `Int32` | Write(`Byte[]&` bytes, `Int32` offset, `String[]` values) | writes a boolean array into the byte array to the given offset | 
| `Int32` | Write(`Byte[]&` bytes, `Int32` offset, `Decimal[]` values) | writes a boolean array into the byte array to the given offset | 
| `Int32` | Write(`Byte[]&` bytes, `Int32` offset, `Guid[]` values) | writes a boolean array into the byte array to the given offset | 
| `Int32` | Write(`Byte[]&` bytes, `Int32` offset, `TimeSpan[]` values) | writes a boolean array into the byte array to the given offset | 
| `Int32` | Write(`Byte[]&` bytes, `Int32` offset, `DateTime[]` values) | writes a boolean array into the byte array to the given offset | 
| `void` | WriteUnsafe(`Byte*` dst, `Int32` offset, `String` value, `Int32&` byteSize) | writes a boolean array into the byte array to the given offset  does not ensure capacity of the byte array | 
| `void` | WriteUnsafe(`Byte*` dst, `Int32` offset, `String` value, `Encoding` encoding) | writes a boolean array into the byte array to the given offset  does not ensure capacity of the byte array | 
| `void` | WriteUnsafe(`Byte*` dst, `Int32` offset, `String` value, `Encoding` encoding, `Int32&` byteSize) | writes a boolean array into the byte array to the given offset  does not ensure capacity of the byte array | 
| `void` | WriteUnsafe(`Byte[]&` bytes, `Int32` offset, `Decimal` value) | writes a boolean array into the byte array to the given offset  does not ensure capacity of the byte array | 
| `void` | WriteUnsafe(`Byte*` dst, `Int32` offset, `Decimal` value) | writes a boolean array into the byte array to the given offset  does not ensure capacity of the byte array | 
| `void` | WriteUnsafe(`Byte[]&` bytes, `Int32` offset, `Guid` value) | writes a boolean array into the byte array to the given offset  does not ensure capacity of the byte array | 
| `void` | WriteUnsafe(`Byte*` dst, `Int32` offset, `Guid` value) | writes a boolean array into the byte array to the given offset  does not ensure capacity of the byte array | 
| `void` | WriteUnsafe(`Byte[]&` bytes, `Int32` offset, `TimeSpan` value) | writes a boolean array into the byte array to the given offset  does not ensure capacity of the byte array | 
| `void` | WriteUnsafe(`Byte*` dst, `Int32` offset, `TimeSpan` value) | writes a boolean array into the byte array to the given offset  does not ensure capacity of the byte array | 
| `void` | WriteUnsafe(`Byte[]&` bytes, `Int32` offset, `DateTime` value) | writes a boolean array into the byte array to the given offset  does not ensure capacity of the byte array | 
| `void` | WriteUnsafe(`Byte*` dst, `Int32` offset, `DateTime` value) | writes a boolean array into the byte array to the given offset  does not ensure capacity of the byte array | 
| `void` | WriteUnsafe(`Byte[]&` bytes, `Int32` offset, `Boolean` value) | writes a boolean array into the byte array to the given offset  does not ensure capacity of the byte array | 
| `void` | WriteUnsafe(`Byte*` dst, `Int32` offset, `Boolean` value) | writes a boolean array into the byte array to the given offset  does not ensure capacity of the byte array | 
| `void` | WriteUnsafe(`Byte[]&` bytes, `Int32` offset, `Byte` value) | writes a boolean array into the byte array to the given offset  does not ensure capacity of the byte array | 
| `void` | WriteUnsafe(`Byte*` dst, `Int32` offset, `Byte` value) | writes a boolean array into the byte array to the given offset  does not ensure capacity of the byte array | 
| `void` | WriteUnsafe(`Byte[]&` bytes, `Int32` offset, `SByte` value) | writes a boolean array into the byte array to the given offset  does not ensure capacity of the byte array | 
| `void` | WriteUnsafe(`Byte*` dst, `Int32` offset, `SByte` value) | writes a boolean array into the byte array to the given offset  does not ensure capacity of the byte array | 
| `void` | WriteUnsafe(`Byte[]&` bytes, `Int32` offset, `Byte[]` value) | writes a boolean array into the byte array to the given offset  does not ensure capacity of the byte array | 
| `void` | WriteUnsafe(`Byte[]&` bytes, `Int32` offset, `Single` value) | writes a boolean array into the byte array to the given offset  does not ensure capacity of the byte array | 
| `void` | WriteUnsafe(`Byte*` dst, `Int32` offset, `Single` value) | writes a boolean array into the byte array to the given offset  does not ensure capacity of the byte array | 
| `void` | WriteUnsafe(`Byte[]&` bytes, `Int32` offset, `Double` value) | writes a boolean array into the byte array to the given offset  does not ensure capacity of the byte array | 
| `void` | WriteUnsafe(`Byte*` dst, `Int32` offset, `Double` value) | writes a boolean array into the byte array to the given offset  does not ensure capacity of the byte array | 
| `void` | WriteUnsafe(`Byte[]&` bytes, `Int32` offset, `Int16` value) | writes a boolean array into the byte array to the given offset  does not ensure capacity of the byte array | 
| `void` | WriteUnsafe(`Byte*` dst, `Int32` offset, `Int16` value) | writes a boolean array into the byte array to the given offset  does not ensure capacity of the byte array | 
| `void` | WriteUnsafe(`Byte[]&` bytes, `Int32` offset, `UInt16` value) | writes a boolean array into the byte array to the given offset  does not ensure capacity of the byte array | 
| `void` | WriteUnsafe(`Byte*` dst, `Int32` offset, `UInt16` value) | writes a boolean array into the byte array to the given offset  does not ensure capacity of the byte array | 
| `void` | WriteUnsafe(`Byte[]&` bytes, `Int32` offset, `Int32` value) | writes a boolean array into the byte array to the given offset  does not ensure capacity of the byte array | 
| `void` | WriteUnsafe(`Byte*` dst, `Int32` offset, `Int32` value) | writes a boolean array into the byte array to the given offset  does not ensure capacity of the byte array | 
| `void` | WriteUnsafe(`Byte[]&` bytes, `Int32` offset, `UInt32` value) | writes a boolean array into the byte array to the given offset  does not ensure capacity of the byte array | 
| `void` | WriteUnsafe(`Byte*` dst, `Int32` offset, `UInt32` value) | writes a boolean array into the byte array to the given offset  does not ensure capacity of the byte array | 
| `void` | WriteUnsafe(`Byte[]&` bytes, `Int32` offset, `Int64` value) | writes a boolean array into the byte array to the given offset  does not ensure capacity of the byte array | 
| `void` | WriteUnsafe(`Byte*` dst, `Int32` offset, `Int64` value) | writes a boolean array into the byte array to the given offset  does not ensure capacity of the byte array | 
| `void` | WriteUnsafe(`Byte[]&` bytes, `Int32` offset, `UInt64` value) | writes a boolean array into the byte array to the given offset  does not ensure capacity of the byte array | 
| `void` | WriteUnsafe(`Byte*` dst, `Int32` offset, `UInt64` value) | writes a boolean array into the byte array to the given offset  does not ensure capacity of the byte array | 
| `void` | WriteUnsafe(`Byte[]&` bytes, `Int32` offset, `Char` value) | writes a boolean array into the byte array to the given offset  does not ensure capacity of the byte array | 
| `void` | WriteUnsafe(`Byte*` dst, `Int32` offset, `Char` value) | writes a boolean array into the byte array to the given offset  does not ensure capacity of the byte array | 
| `void` | WriteUnsafe(`Byte[]&` bytes, `Int32` offset, `String` value) | writes a boolean array into the byte array to the given offset  does not ensure capacity of the byte array | 
| `void` | WriteUnsafe(`Byte[]&` bytes, `Int32` offset, `String` value, `Int32&` byteSize) | writes a boolean array into the byte array to the given offset  does not ensure capacity of the byte array | 
| `void` | WriteUnsafe(`Byte[]&` bytes, `Int32` offset, `String` value, `Encoding` encoding) | writes a boolean array into the byte array to the given offset  does not ensure capacity of the byte array | 
| `void` | WriteUnsafe(`Byte[]&` bytes, `Int32` offset, `String` value, `Encoding` encoding, `Int32&` byteSize) | writes a boolean array into the byte array to the given offset  does not ensure capacity of the byte array | 
| `void` | WriteUnsafe(`Byte*` dst, `Int32` offset, `String` value) | writes a boolean array into the byte array to the given offset  does not ensure capacity of the byte array | 
| `void` | WriteUnsafe(`Byte[]&` bytes, `Int32` offset, `Boolean[]` values, `Int32&` byteSize) | writes a boolean array into the byte array to the given offset  does not ensure capacity of the byte array | 
| `void` | WriteUnsafe(`Byte*` dst, `Int32` offset, `Boolean[]` values, `Int32&` byteSize) | writes a boolean array into the byte array to the given offset  does not ensure capacity of the byte array | 
| `void` | WriteUnsafe(`Byte[]&` bytes, `Int32` offset, `Byte[]` values, `Int32&` byteSize) | writes a boolean array into the byte array to the given offset  does not ensure capacity of the byte array | 
| `void` | WriteUnsafe(`Byte*` dst, `Int32` offset, `Byte[]` values, `Int32&` byteSize) | writes a boolean array into the byte array to the given offset  does not ensure capacity of the byte array | 
| `void` | WriteUnsafe(`Byte[]&` bytes, `Int32` offset, `SByte[]` values, `Int32&` byteSize) | writes a boolean array into the byte array to the given offset  does not ensure capacity of the byte array | 
| `void` | WriteUnsafe(`Byte*` dst, `Int32` offset, `SByte[]` values, `Int32&` byteSize) | writes a boolean array into the byte array to the given offset  does not ensure capacity of the byte array | 
| `void` | WriteUnsafe(`Byte[]&` bytes, `Int32` offset, `Single[]` values, `Int32&` byteSize) | writes a boolean array into the byte array to the given offset  does not ensure capacity of the byte array | 
| `void` | WriteUnsafe(`Byte*` dst, `Int32` offset, `Single[]` values, `Int32&` byteSize) | writes a boolean array into the byte array to the given offset  does not ensure capacity of the byte array | 
| `void` | WriteUnsafe(`Byte[]&` bytes, `Int32` offset, `Double[]` values, `Int32&` byteSize) | writes a boolean array into the byte array to the given offset  does not ensure capacity of the byte array | 
| `void` | WriteUnsafe(`Byte*` dst, `Int32` offset, `Double[]` values, `Int32&` byteSize) | writes a boolean array into the byte array to the given offset  does not ensure capacity of the byte array | 
| `void` | WriteUnsafe(`Byte[]&` bytes, `Int32` offset, `Int16[]` values, `Int32&` byteSize) | writes a boolean array into the byte array to the given offset  does not ensure capacity of the byte array | 
| `void` | WriteUnsafe(`Byte*` dst, `Int32` offset, `Int16[]` values, `Int32&` byteSize) | writes a boolean array into the byte array to the given offset  does not ensure capacity of the byte array | 
| `void` | WriteUnsafe(`Byte[]&` bytes, `Int32` offset, `UInt16[]` values, `Int32&` byteSize) | writes a boolean array into the byte array to the given offset  does not ensure capacity of the byte array | 
| `void` | WriteUnsafe(`Byte*` dst, `Int32` offset, `UInt16[]` values, `Int32&` byteSize) | writes a boolean array into the byte array to the given offset  does not ensure capacity of the byte array | 
| `void` | WriteUnsafe(`Byte[]&` bytes, `Int32` offset, `Int32[]` values, `Int32&` byteSize) | writes a boolean array into the byte array to the given offset  does not ensure capacity of the byte array | 
| `void` | WriteUnsafe(`Byte*` dst, `Int32` offset, `Int32[]` values, `Int32&` byteSize) | writes a boolean array into the byte array to the given offset  does not ensure capacity of the byte array | 
| `void` | WriteUnsafe(`Byte[]&` bytes, `Int32` offset, `UInt32[]` values, `Int32&` byteSize) | writes a boolean array into the byte array to the given offset  does not ensure capacity of the byte array | 
| `void` | WriteUnsafe(`Byte*` dst, `Int32` offset, `UInt32[]` values, `Int32&` byteSize) | writes a boolean array into the byte array to the given offset  does not ensure capacity of the byte array | 
| `void` | WriteUnsafe(`Byte[]&` bytes, `Int32` offset, `Int64[]` values, `Int32&` byteSize) | writes a boolean array into the byte array to the given offset  does not ensure capacity of the byte array | 
| `void` | WriteUnsafe(`Byte*` dst, `Int32` offset, `Int64[]` values, `Int32&` byteSize) | writes a boolean array into the byte array to the given offset  does not ensure capacity of the byte array | 
| `void` | WriteUnsafe(`Byte[]&` bytes, `Int32` offset, `UInt64[]` values, `Int32&` byteSize) | writes a boolean array into the byte array to the given offset  does not ensure capacity of the byte array | 
| `void` | WriteUnsafe(`Byte*` dst, `Int32` offset, `UInt64[]` values, `Int32&` byteSize) | writes a boolean array into the byte array to the given offset  does not ensure capacity of the byte array | 
| `void` | WriteUnsafe(`Byte[]&` bytes, `Int32` offset, `Char[]` values, `Int32&` byteSize) | writes a boolean array into the byte array to the given offset  does not ensure capacity of the byte array | 
| `void` | WriteUnsafe(`Byte*` dst, `Int32` offset, `Char[]` values, `Int32&` byteSize) | writes a boolean array into the byte array to the given offset  does not ensure capacity of the byte array | 
| `void` | WriteUnsafe(`Byte[]&` bytes, `Int32` offset, `String[]` values, `Int32&` byteSize) | writes a boolean array into the byte array to the given offset  does not ensure capacity of the byte array | 
| `void` | WriteUnsafe(`Byte[]&` bytes, `Int32` offset, `Decimal[]` values, `Int32&` byteSize) | writes a boolean array into the byte array to the given offset  does not ensure capacity of the byte array | 
| `void` | WriteUnsafe(`Byte*` dst, `Int32` offset, `Decimal[]` values, `Int32&` byteSize) | writes a boolean array into the byte array to the given offset  does not ensure capacity of the byte array | 
| `void` | WriteUnsafe(`Byte[]&` bytes, `Int32` offset, `Guid[]` values, `Int32&` byteSize) | writes a boolean array into the byte array to the given offset  does not ensure capacity of the byte array | 
| `void` | WriteUnsafe(`Byte*` dst, `Int32` offset, `Guid[]` values, `Int32&` byteSize) | writes a boolean array into the byte array to the given offset  does not ensure capacity of the byte array | 
| `void` | WriteUnsafe(`Byte[]&` bytes, `Int32` offset, `TimeSpan[]` values, `Int32&` byteSize) | writes a boolean array into the byte array to the given offset  does not ensure capacity of the byte array | 
| `void` | WriteUnsafe(`Byte*` dst, `Int32` offset, `TimeSpan[]` values, `Int32&` byteSize) | writes a boolean array into the byte array to the given offset  does not ensure capacity of the byte array | 
| `void` | WriteUnsafe(`Byte[]&` bytes, `Int32` offset, `DateTime[]` values, `Int32&` byteSize) | writes a boolean array into the byte array to the given offset  does not ensure capacity of the byte array | 
| `void` | WriteUnsafe(`Byte*` dst, `Int32` offset, `DateTime[]` values, `Int32&` byteSize) | writes a boolean array into the byte array to the given offset  does not ensure capacity of the byte array | 


