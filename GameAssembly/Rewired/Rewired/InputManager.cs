/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Rewired.Utils.Interfaces;
using UnityEngine.SceneManagement;

// Image 78: Rewired.dll - Assembly: Rewired, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9189-9271

namespace Rewired
{
	[EditorBrowsable] // 0x00000001800B6700-0x00000001800B6720
	public sealed class InputManager : InputManager_Base // TypeDefIndex: 9202
	{
		// Fields
		private bool ignoreRecompile; // 0x50
	
		// Constructors
		public InputManager(); // 0x0000000181BC04E0-0x0000000181BC04F0
	
		// Methods
		protected override void OnInitialized(); // 0x0000000181BC0410-0x0000000181BC04D0
		protected override void OnDeinitialized(); // 0x0000000181BC03A0-0x0000000181BC0410
		protected override void DetectPlatform(); // 0x0000000181BC02F0-0x0000000181BC0350
		protected override void CheckRecompile(); // 0x00000001803581E0-0x00000001803581F0
		protected override IExternalTools GetExternalTools(); // 0x0000000181BC0350-0x0000000181BC03A0
		private bool CheckDeviceName(string searchPattern, string deviceName, string deviceModel); // 0x0000000181BC0230-0x0000000181BC02F0
		private void SubscribeEvents(); // 0x0000000181BC0410-0x0000000181BC04D0
		private void UnsubscribeEvents(); // 0x0000000181BC03A0-0x0000000181BC0410
		private void OnSceneLoaded(Scene scene, LoadSceneMode mode); // 0x0000000181BC04D0-0x0000000181BC04E0
	}
}
