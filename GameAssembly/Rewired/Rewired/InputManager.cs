/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Rewired.Utils.Interfaces;
using UnityEngine.SceneManagement;

// Image 79: Rewired.dll - Assembly: Rewired, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9355-9437

namespace Rewired
{
	[EditorBrowsable] // 0x00000001801E4110-0x00000001801E4130
	public sealed class InputManager : InputManager_Base // TypeDefIndex: 9368
	{
		// Fields
		private bool ignoreRecompile; // 0x50
	
		// Constructors
		public InputManager(); // 0x000000018105FB20-0x000000018105FB30
	
		// Methods
		protected override void OnInitialized(); // 0x000000018105FA50-0x000000018105FB10
		protected override void OnDeinitialized(); // 0x000000018105F9E0-0x000000018105FA50
		protected override void DetectPlatform(); // 0x000000018105F930-0x000000018105F990
		protected override void CheckRecompile(); // 0x00000001803774A0-0x00000001803774B0
		protected override IExternalTools GetExternalTools(); // 0x000000018105F990-0x000000018105F9E0
		private bool CheckDeviceName(string searchPattern, string deviceName, string deviceModel); // 0x000000018105F870-0x000000018105F930
		private void SubscribeEvents(); // 0x000000018105FA50-0x000000018105FB10
		private void UnsubscribeEvents(); // 0x000000018105F9E0-0x000000018105FA50
		private void OnSceneLoaded(Scene scene, LoadSceneMode mode); // 0x000000018105FB10-0x000000018105FB20
	}
}
