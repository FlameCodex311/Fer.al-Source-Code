/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization.Formatters.Binary;

// Image 80: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9274-9976

namespace Crosstales.Common.Util
{
	public static class SerializeDeSerialize // TypeDefIndex: 9964
	{
		// Properties
		private static BinaryFormatter binaryFormatter { get; } // 0x00000001815EBA90-0x00000001815EBAF0 
	
		// Methods
		public static void SerializeToFile<T>(T obj, string filename);
		public static byte[] SerializeToByteArray<T>(T obj);
		public static T DeserializeFromFile<T>(string filename);
		public static T DeserializeFromByteArray<T>(byte[] data);
	}
}
