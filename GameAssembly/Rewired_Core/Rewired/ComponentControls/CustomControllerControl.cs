/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired;
using Rewired.ComponentControls.Data;
using UnityEngine;

// Image 50: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5712-6954

namespace Rewired.ComponentControls
{
	[Serializable]
	[DisallowMultipleComponent] // 0x00000001800B36B0-0x00000001800B36C0
	public abstract class CustomControllerControl : ComponentControl // TypeDefIndex: 5802
	{
		// Properties
		internal CustomController controller { get; } // 0x0000000181435330-0x00000001814353A0 
		internal override bool hasController { get; } // 0x00000001814353A0-0x0000000181435440 
	
		// Constructors
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		internal CustomControllerControl(); // 0x0000000181432EB0-0x0000000181432EC0
	
		// Methods
		internal override void OnSubscribeEvents(); // 0x0000000181433830-0x0000000181433960
		internal override void OnUnsubscribeEvents(); // 0x0000000181433960-0x0000000181433AC0
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		internal override IComponentController FindController(); // 0x0000000181433760-0x00000001814337D0
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		internal override Type GetRequiredControllerType(); // 0x00000001814337D0-0x0000000181433830
		internal void dlwdszwdDeKocMSXhvmIcxgUNHA(CustomControllerElementTargetSet param_0000c69c, float param_0000c69d, float param_0000c69e); // 0x0000000181433F60-0x0000000181434ED0
		internal void dlwdszwdDeKocMSXhvmIcxgUNHA(CustomControllerElementTargetSet param_0000c69f, bool param_0000c6a0); // 0x00000001814350F0-0x0000000181435330
		internal abstract void OnCustomControllerUpdate();
		private void dlwdszwdDeKocMSXhvmIcxgUNHA(CustomControllerElementTarget param_0000c6a1, float param_0000c6a2, float param_0000c6a3); // 0x0000000181433B80-0x0000000181433F60
		private void dlwdszwdDeKocMSXhvmIcxgUNHA(CustomControllerElementTarget param_0000c6a4, bool param_0000c6a5); // 0x0000000181434ED0-0x00000001814350F0
		private void RfZaswuAvIkWkyDeOKtBcJVcYXc(); // 0x0000000181433AC0-0x0000000181433B80
	}
}
