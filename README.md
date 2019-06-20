## Information

exomia/serialization is build for a fast serialization from and to a byte array & more

![](https://img.shields.io/github/issues-pr/exomia/serialization.svg)
![](https://img.shields.io/github/issues/exomia/serialization.svg)
![](https://img.shields.io/github/last-commit/exomia/serialization.svg)
![](https://img.shields.io/github/contributors/exomia/serialization.svg)
![](https://img.shields.io/github/commit-activity/y/exomia/serialization.svg)
![](https://img.shields.io/github/languages/top/exomia/serialization.svg)
![](https://img.shields.io/github/languages/count/exomia/serialization.svg)
![](https://img.shields.io/github/license/exomia/serialization.svg)

## Installing

```shell
[Package Manager]
PM> Install-Package Exomia.Serialization
```

## Example

#### ByteArray-Utils

```csharp
using Exomia.Serialization.Utils;

static void Main(string[] args)
{
	byte[] buffer = new byte[0];
	int offset = BitUtil.Write(ref buffer, 0, true); //offset: 1
	offset += BitUtil.Write(ref buffer, offset, int.MaxValue); //offset: 5
	offset += BitUtil.Write(ref buffer, offset, int.MaxValue + 99999L); //offset: 13
	offset += BitUtil.Write(ref buffer, offset, 34.5f); //offset: 17
	offset += BitUtil.Write(ref buffer, offset, "ex"); //offset: 23
	Console.WriteLine(string.Join("-", buffer) + " -> " + buffer.Length);
	//1-255-255-255-127-158-134-1-128-0-0-0-0-34-0-0-0-4-0-101-0-120-0 -> 23

	Console.WriteLine(BitUtil.ReadBoolean(ref buffer, 0));	//True
	Console.WriteLine(BitUtil.ReadInt32(ref buffer, 1));	//2147483647
	Console.WriteLine(BitUtil.ReadInt64(ref buffer, 5));	//2147583646
	Console.WriteLine(BitUtil.ReadSingle(ref buffer, 13));	//34.5
	Console.WriteLine(BitUtil.ReadString(ref buffer, 17));	//ex

	byte[] buffer2 = new byte[24];
	BitUtil.WriteUnsafe(ref buffer2, 0, true);
	BitUtil.WriteUnsafe(ref buffer2, 1, int.MaxValue);
	BitUtil.WriteUnsafe(ref buffer2, 5, int.MaxValue + 99999L);
	BitUtil.WriteUnsafe(ref buffer2, 13, 34.5f);
	BitUtil.WriteUnsafe(ref buffer, 17, "ex");
	Console.WriteLine(string.Join("-", buffer2) + " -> " + buffer2.Length);
	//1-255-255-255-127-158-134-1-128-0-0-0-0-34-0-0-0-4-0-101-0-120-0-0 -> 24
	
	unsafe
	{
		fixed (byte* ptr = buffer2) //you can use buffer instead of buffer2 here aswell
		{
			BitUtil.WriteUnsafe(ptr, 0, true);
			BitUtil.WriteUnsafe(ptr, 1, int.MaxValue);
			BitUtil.WriteUnsafe(ptr, 5, int.MaxValue + 99999L);
			BitUtil.WriteUnsafe(ptr, 13, 34.5f);
			BitUtil.WriteUnsafe(ptr, 17, "ex");
			Console.WriteLine(string.Join("-", buffer2) + " -> " + buffer2.Length);
			//1-255-255-255-127-158-134-1-128-0-0-0-0-34-0-0-0-4-0-101-0-120-0-0 -> 24
		}
	}
            
	unsafe
	{
		fixed (byte* ptr = buffer2) //you can use buffer instead of buffer2 here aswell
		{
			Console.WriteLine(BitUtil.ReadBoolean(ptr, 0));	//True
			Console.WriteLine(BitUtil.ReadInt32(ptr, 1));	//2147483647
			Console.WriteLine(BitUtil.ReadInt64(ptr, 5));	//2147583646
			Console.WriteLine(BitUtil.ReadSingle(ptr, 13));	//34.5
			Console.WriteLine(BitUtil.ReadString(ptr, 17));	//ex
		}
	}
}
```
 + several more overloads for Write & WriteUnsafe and the associated read method
 + read and write operations also available for arrays

#### Hashing 

```csharp
using Exomia.Serialization.Hash;

static void Main(string[] args)
{
	EHA eha = new EHA(45878);

	byte[] byteArray = eha.ToBytes("this is a string");
	Console.WriteLine(string.Join("-", byteArray) + " -> " + byteArray.Length);
	//233-96-179-194-19-155-53-25-105-91-2-200-213-123-28-143-51-95-208-209-4-106-0-88 -> 24

	string hexString = eha.ToString("this is a string");
	Console.WriteLine(hexString + " -> " + hexString.Length);
	//C2B360E919359B13C8025B698F1C7BD5D1D05F3358006A04 -> 48
}
```