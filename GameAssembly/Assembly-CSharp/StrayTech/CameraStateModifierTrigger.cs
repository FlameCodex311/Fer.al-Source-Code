/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace StrayTech
{
	public class CameraStateModifierTrigger : CameraSystemTriggerBase // TypeDefIndex: 13918
	{
		// Fields
		[SerializeField] // 0x000000018014CEF0-0x000000018014CF30
		[Tooltip] // 0x000000018014CEF0-0x000000018014CF30
		private CameraStateModifierBase _cameraStateModifierTarget; // 0x70
		[SerializeField] // 0x0000000180150640-0x0000000180150680
		[Tooltip] // 0x0000000180150640-0x0000000180150680
		private bool _ignoreTriggerExit; // 0x78
	
		// Constructors
		public CameraStateModifierTrigger(); // 0x000000018134AF00-0x000000018134AF70
	
		// Methods
		protected override void TriggerEntered(); // 0x000000018134AE90-0x000000018134AEC0
		protected override void TriggerExited(); // 0x000000018134AEC0-0x000000018134AF00
	}
}
