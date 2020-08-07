/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired;
using Rewired.Platforms;
using UnityEngine;

// Image 51: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5871-7113

namespace Rewired.Data
{
	public class EditorPlatformData : ScriptableObject // TypeDefIndex: 6415
	{
		// Fields
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		public Platform windowsStandalone; // 0x18
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		public Platform windowsStore; // 0x20
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		public Platform osxStandalone; // 0x28
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		public Platform linuxStandalone; // 0x30
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		public Platform webplayer; // 0x38
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		public Platform fallback; // 0x40
	
		// Nested types
		[Serializable]
		public class Platform // TypeDefIndex: 6416
		{
			// Fields
			public TextAsset[] libraries; // 0x10
	
			// Constructors
			public Platform(); // 0x0000000180373240-0x0000000180373250
		}
	
		// Constructors
		public EditorPlatformData(); // 0x00000001803FEC00-0x00000001803FEC10
	
		// Methods
		public TextAsset[] GetLibraries(Rewired.Platforms.Platform platform, WebplayerPlatform webplayerPlatform, EditorPlatform editorPlatform); // 0x0000000180D88260-0x0000000180D882E0
		public Platform GetPlatform(Rewired.Platforms.Platform platform, WebplayerPlatform webplayerPlatform, EditorPlatform editorPlatform); // 0x0000000180D882E0-0x0000000180D88340
	}
}
