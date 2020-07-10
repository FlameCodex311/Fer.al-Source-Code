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

// Image 50: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5712-6954

namespace Rewired.Data
{
	public class EditorPlatformData : ScriptableObject // TypeDefIndex: 6256
	{
		// Fields
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		public Platform windowsStandalone; // 0x18
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		public Platform windowsStore; // 0x20
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		public Platform osxStandalone; // 0x28
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		public Platform linuxStandalone; // 0x30
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		public Platform webplayer; // 0x38
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		public Platform fallback; // 0x40
	
		// Nested types
		[Serializable]
		public class Platform // TypeDefIndex: 6257
		{
			// Fields
			public TextAsset[] libraries; // 0x10
	
			// Constructors
			public Platform(); // 0x000000018036B6C0-0x000000018036B6D0
		}
	
		// Constructors
		public EditorPlatformData(); // 0x00000001803A2BB0-0x00000001803A2BC0
	
		// Methods
		public TextAsset[] GetLibraries(Rewired.Platforms.Platform platform, WebplayerPlatform webplayerPlatform, EditorPlatform editorPlatform); // 0x00000001805E9180-0x00000001805E9200
		public Platform GetPlatform(Rewired.Platforms.Platform platform, WebplayerPlatform webplayerPlatform, EditorPlatform editorPlatform); // 0x00000001805E9200-0x00000001805E9260
	}
}
