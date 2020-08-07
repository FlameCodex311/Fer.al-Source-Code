/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization.Formatters.Binary;

// Image 82: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9678-10380

namespace Crosstales.Common.Util
{
	public static class SerializeDeSerialize // TypeDefIndex: 9750
	{
		// Properties
		private static BinaryFormatter binaryFormatter { get; } // 0x000000018108B760-0x000000018108B7C0 
	
		// Methods
		public static void SerializeToFile<T>(T obj, string filename);
		public static byte[] SerializeToByteArray<T>(T obj);
		public static T DeserializeFromFile<T>(string filename);
		public static T DeserializeFromByteArray<T>(byte[] data);
	}
}
