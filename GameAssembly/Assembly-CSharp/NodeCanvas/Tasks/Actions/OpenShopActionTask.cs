/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace NodeCanvas.Tasks.Actions
{
	[Category] // 0x0000000180279590-0x00000001802795C0
	public class OpenShopActionTask : ActionTask // TypeDefIndex: 15519
	{
		// Fields
		public string shopName; // 0x68
		public string shopDefID; // 0x70
		private string _infoText; // 0x78
	
		// Properties
		protected override string info { get; } // 0x0000000180BBD0B0-0x0000000180BBD150 
	
		// Constructors
		public OpenShopActionTask(); // 0x000000018079E240-0x000000018079E250
	
		// Methods
		protected override void OnExecute(); // 0x0000000180BBCE80-0x0000000180BBCFA0
		private void OpenShop(); // 0x0000000180BBCFA0-0x0000000180BBD0B0
	}
}
