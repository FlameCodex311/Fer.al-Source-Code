/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using ParadoxNotion.Serialization.FullSerializer;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace ParadoxNotion.Serialization
{
	public static class JSONSerializer // TypeDefIndex: 15872
	{
		// Fields
		private static object serializerLock; // 0x00
		private static fsSerializer serializer; // 0x08
		private static Dictionary<string, fsData> dataCache; // 0x10
	
		// Constructors
		static JSONSerializer(); // 0x00000001811A9160-0x00000001811A9310
	
		// Methods
		public static void FlushMem(); // 0x00000001811A7EB0-0x00000001811A8010
		[RuntimeInitializeOnLoadMethod] // 0x0000000180238AA0-0x0000000180238AC0
		private static void __FlushDataCache(); // 0x00000001811A90D0-0x00000001811A9160
		public static string Serialize(Type type, object instance, List<UnityEngine.Object> references = null, bool pretyJson = false /* Metadata: 0x007BB625 */); // 0x00000001811A8AD0-0x00000001811A8F00
		public static T Deserialize<T>(string json, List<UnityEngine.Object> references = null);
		public static object Deserialize(Type type, string json, List<UnityEngine.Object> references = null); // 0x00000001811A7E30-0x00000001811A7EB0
		public static T TryDeserializeOverwrite<T>(T instance, string json, List<UnityEngine.Object> references = null)
			where T : class;
		public static object TryDeserializeOverwrite(object instance, string json, List<UnityEngine.Object> references = null); // 0x00000001811A9030-0x00000001811A90D0
		private static object Internal_Deserialize(Type type, string json, List<UnityEngine.Object> references, object instance); // 0x00000001811A8010-0x00000001811A84C0
		public static void SerializeAndExecuteNoCycles(Type type, object instance, Action<object, fsData> call); // 0x00000001811A84E0-0x00000001811A8730
		public static void SerializeAndExecuteNoCycles(Type type, object instance, Action<object> beforeCall, Action<object, fsData> afterCall); // 0x00000001811A8730-0x00000001811A8AD0
		public static T Clone<T>(T original);
		public static object Clone(object original); // 0x00000001811A7BF0-0x00000001811A7D00
		public static void CopySerialized(object source, object target); // 0x00000001811A7D00-0x00000001811A7E30
		public static void ShowData(string json, string fileName = "" /* Metadata: 0x007BB626 */); // 0x00000001811A8F00-0x00000001811A9030
		public static string PrettifyJson(string json); // 0x00000001811A84C0-0x00000001811A84E0
	}
}
