/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired;

// Image 51: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5871-7113

namespace Rewired.Utils.Classes.Data
{
	[CustomClassObfuscation] // 0x00000001801CE320-0x00000001801CE390
	[CustomObfuscation] // 0x00000001801CE320-0x00000001801CE390
	internal class NativeBuffer : IDisposable // TypeDefIndex: 6991
	{
		// Fields
		private IntPtr czeeadyvGnEBPXiowfkWjdSLOfUG; // 0x10
		private int CvHRPSyRdGHqbdRDaLvCUlxYDMo; // 0x18
		private bool vEblpmllYIOuQHCXVghuIpihdSG; // 0x1C
	
		// Properties
		public IntPtr Pointer { get; } // 0x0000000180372440-0x0000000180372450 
		public int Length { get; } // 0x00000001803F46B0-0x00000001803F46C0 
		public byte this[int index] { get => default; set {} } // 0x0000000181099660-0x0000000181099700 0x0000000181099740-0x00000001810997F0
	
		// Constructors
		public NativeBuffer(int size); // 0x0000000181099600-0x0000000181099660
	
		// Methods
		public IntPtr GetPointer(int offset = 0 /* Metadata: 0x0076666E */); // 0x00000001810969C0-0x0000000181096AA0
		public string DumpToHexString(); // 0x00000001810967E0-0x00000001810969C0
		public bool ReadBit(int byteIndex, byte bit); // 0x0000000181096AA0-0x0000000181096BE0
		public byte ReadByte(int startIndex); // 0x0000000181096BE0-0x0000000181096C90
		public short ReadShort(int startIndex); // 0x0000000181096FC0-0x0000000181097070
		public ushort ReadUShort(int startIndex); // 0x0000000181097200-0x00000001810972B0
		public int ReadInt(int startIndex); // 0x0000000181096E60-0x0000000181096F10
		public uint ReadUInt(int startIndex); // 0x0000000181097070-0x0000000181097150
		public long ReadLong(int startIndex); // 0x0000000181096F10-0x0000000181096FC0
		public ulong ReadULong(int startIndex); // 0x0000000181097150-0x0000000181097200
		public float ReadFloat(int startIndex); // 0x0000000181096D90-0x0000000181096E60
		public double ReadDouble(int startIndex); // 0x0000000181096C90-0x0000000181096D90
		public void Read(byte[] buffer, int numBytesToRead, int readStartIndex = 0 /* Metadata: 0x00766672 */, int writeStartIndex = 0 /* Metadata: 0x00766676 */); // 0x00000001810972B0-0x0000000181097680
		public void Read(IntPtr buffer, int bufferLength, int numBytesToRead, int readStartIndex = 0 /* Metadata: 0x0076667A */, int writeStartIndex = 0 /* Metadata: 0x0076667E */); // 0x0000000181097680-0x0000000181097A20
		public int TryReadBytes(byte[] buffer, int numBytesToRead, int readStartIndex = 0 /* Metadata: 0x00766682 */, int writeStartIndex = 0 /* Metadata: 0x00766686 */); // 0x0000000181097FC0-0x0000000181098110
		public int TryReadBytes(IntPtr buffer, int bufferLength, int numBytesToRead, int readStartIndex = 0 /* Metadata: 0x0076668A */, int writeStartIndex = 0 /* Metadata: 0x0076668E */); // 0x0000000181098110-0x00000001810982A0
		public void WriteBit(int byteIndex, byte bit, bool value); // 0x0000000181098550-0x0000000181098720
		public void Write(byte @byte, int startIndex); // 0x0000000181099380-0x0000000181099440
		public void Write(short bytes, int startIndex); // 0x0000000181098910-0x00000001810989D0
		public void Write(ushort bytes, int startIndex); // 0x0000000181098D70-0x0000000181098E60
		public void Write(int bytes, int startIndex); // 0x0000000181099520-0x0000000181099600
		public void Write(uint bytes, int startIndex); // 0x0000000181098F40-0x0000000181099000
		public void Write(long bytes, int startIndex); // 0x0000000181098850-0x0000000181098910
		public void Write(ulong bytes, int startIndex); // 0x0000000181099440-0x0000000181099520
		public void Write(float bytes, int startIndex); // 0x0000000181098720-0x0000000181098850
		public void Write(double bytes, int startIndex); // 0x0000000181098E60-0x0000000181098F40
		public void Write(byte[] bytes, int numBytesToWrite, int writeStartIndex = 0 /* Metadata: 0x00766692 */, int readStartIndex = 0 /* Metadata: 0x00766696 */); // 0x0000000181099000-0x0000000181099380
		public void Write(IntPtr bytes, int bufferLength, int numBytesToWrite, int writeStartIndex = 0 /* Metadata: 0x0076669A */, int readStartIndex = 0 /* Metadata: 0x0076669E */); // 0x00000001810989D0-0x0000000181098D70
		public int TryWriteBytes(byte[] bytes, int numBytesToWrite, int writeStartIndex = 0 /* Metadata: 0x007666A2 */, int readStartIndex = 0 /* Metadata: 0x007666A6 */); // 0x0000000181098400-0x0000000181098550
		public int TryWriteBytes(IntPtr bytes, int bufferLength, int numBytesToWrite, int writeStartIndex = 0 /* Metadata: 0x007666AA */, int readStartIndex = 0 /* Metadata: 0x007666AE */); // 0x00000001810982A0-0x0000000181098400
		public bool Resize(int size, bool preserveData); // 0x0000000181097AB0-0x0000000181097D50
		public void Clear(); // 0x0000000181096550-0x00000001810965A0
		public void Release(); // 0x0000000181097A20-0x0000000181097AB0
		public override string ToString(); // 0x0000000181097D50-0x0000000181097FC0
		public void Dispose(); // 0x0000000181096770-0x00000001810967E0
		~NativeBuffer(); // 0x000000018041BC40-0x000000018041BCE0
		protected virtual void Dispose(bool disposing); // 0x00000001810966B0-0x0000000181096770
		public static implicit operator IntPtr(NativeBuffer buffer); // 0x0000000181099700-0x0000000181099740
		public static bool Copy(NativeBuffer source, NativeBuffer destination); // 0x00000001810965A0-0x00000001810966B0
	}
}
