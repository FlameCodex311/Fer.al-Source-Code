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

// Image 51: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5871-7113

namespace Rewired.ComponentControls
{
	[Serializable]
	[DisallowMultipleComponent] // 0x00000001801CDAD0-0x00000001801CDAE0
	public abstract class CustomControllerControl : ComponentControl // TypeDefIndex: 5961
	{
		// Properties
		internal CustomController controller { get; } // 0x0000000180912D30-0x0000000180912DA0 
		internal override bool hasController { get; } // 0x0000000180912DA0-0x0000000180912E40 
	
		// Constructors
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		internal CustomControllerControl(); // 0x0000000180910910-0x0000000180910920
	
		// Methods
		internal override void OnSubscribeEvents(); // 0x00000001809112A0-0x00000001809113D0
		internal override void OnUnsubscribeEvents(); // 0x00000001809113D0-0x0000000180911520
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		internal override IComponentController FindController(); // 0x00000001809111D0-0x0000000180911240
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		internal override Type GetRequiredControllerType(); // 0x0000000180911240-0x00000001809112A0
		internal void dlwdszwdDeKocMSXhvmIcxgUNHA(CustomControllerElementTargetSet param_0000c90c, float param_0000c90d, float param_0000c90e); // 0x00000001809119B0-0x00000001809128D0
		internal void dlwdszwdDeKocMSXhvmIcxgUNHA(CustomControllerElementTargetSet param_0000c90f, bool param_0000c910); // 0x0000000180912AF0-0x0000000180912D30
		internal abstract void OnCustomControllerUpdate();
		private void dlwdszwdDeKocMSXhvmIcxgUNHA(CustomControllerElementTarget param_0000c911, float param_0000c912, float param_0000c913); // 0x00000001809115E0-0x00000001809119B0
		private void dlwdszwdDeKocMSXhvmIcxgUNHA(CustomControllerElementTarget param_0000c914, bool param_0000c915); // 0x00000001809128D0-0x0000000180912AF0
		private void RfZaswuAvIkWkyDeOKtBcJVcYXc(); // 0x0000000180911520-0x00000001809115E0
	}
}
