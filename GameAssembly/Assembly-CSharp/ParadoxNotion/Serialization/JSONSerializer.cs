/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using ParadoxNotion.Serialization.FullSerializer;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace ParadoxNotion.Serialization
{
	public static class JSONSerializer // TypeDefIndex: 15287
	{
		// Fields
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private static bool <applicationPlaying>k__BackingField; // 0x00
		private static Dictionary<string, fsData> cache; // 0x08
		private static object serializerLock; // 0x10
		private static fsSerializer serializer; // 0x18
	
		// Properties
		public static bool applicationPlaying { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x00000001811680A0-0x0000000181168100 0x0000000181168100-0x0000000181168160
	
		// Constructors
		static JSONSerializer(); // 0x0000000181167FA0-0x00000001811680A0
	
		// Methods
		public static string Serialize(Type type, object instance, bool pretyJson = false /* Metadata: 0x007847AE */, List<UnityEngine.Object> objectReferences = null); // 0x0000000181167B50-0x0000000181167E70
		public static T Deserialize<T>(string json, List<UnityEngine.Object> objectReferences = null);
		public static object Deserialize(Type type, string json, List<UnityEngine.Object> objectReferences = null); // 0x00000001811676C0-0x0000000181167740
		public static T DeserializeOverwrite<T>(T instance, string json, List<UnityEngine.Object> objectReferences = null);
		public static object DeserializeOverwrite(object instance, string json, List<UnityEngine.Object> objectReferences = null); // 0x0000000181167620-0x00000001811676C0
		public static object Internal_Deserialize(Type type, string json, List<UnityEngine.Object> objectReferences, object instance); // 0x0000000181167740-0x0000000181167B30
		public static T Clone<T>(T original, List<UnityEngine.Object> objectReferences = null);
		public static object Clone(object original, List<UnityEngine.Object> objectReferences = null); // 0x0000000181167530-0x0000000181167620
		public static void ShowData(string json, string fileName = "" /* Metadata: 0x007847AF */); // 0x0000000181167E70-0x0000000181167FA0
		public static string PrettifyJson(string json); // 0x0000000181167B30-0x0000000181167B50
	}
}
