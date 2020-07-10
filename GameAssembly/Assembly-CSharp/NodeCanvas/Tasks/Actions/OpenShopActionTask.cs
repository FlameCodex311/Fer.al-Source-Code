/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace NodeCanvas.Tasks.Actions
{
	[Category] // 0x000000018010CED0-0x000000018010CF00
	public class OpenShopActionTask : ActionTask // TypeDefIndex: 14414
	{
		// Fields
		public string shopName; // 0x68
		public string shopDefID; // 0x70
		private string _infoText; // 0x78
	
		// Properties
		protected override string info { get; } // 0x0000000181556C10-0x0000000181556CB0 
	
		// Constructors
		public OpenShopActionTask(); // 0x0000000180E87F80-0x0000000180E87F90
	
		// Methods
		protected override void OnExecute(); // 0x00000001815569E0-0x0000000181556B00
		private void OpenShop(); // 0x0000000181556B00-0x0000000181556C10
	}
}
