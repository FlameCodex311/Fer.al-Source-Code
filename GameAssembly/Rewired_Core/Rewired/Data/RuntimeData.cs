﻿/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
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
	public class RuntimeData : ScriptableObject // TypeDefIndex: 6414
	{
		// Fields
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		public Rewired.Platforms.Platform platform; // 0x18
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		public WebplayerPlatform webplayerPlatform; // 0x1C
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		public EditorPlatform editorPlatform; // 0x20
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		public List<TextAsset> libraries; // 0x28
	
		// Constructors
		public RuntimeData(); // 0x00000001803FEC00-0x00000001803FEC10
	
		// Methods
		public void SetPlatform(Rewired.Platforms.Platform platform, WebplayerPlatform webplayerPlatform, EditorPlatform editorPlatform, List<TextAsset> libraries); // 0x00000001805FC8E0-0x00000001805FC900
	}
}
