/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using NodeCanvas.Framework.Internal;
using ParadoxNotion.Design;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace NodeCanvas.Tasks.Actions
{
	[Category] // 0x00000001800C38F0-0x00000001800C3920
	public class SetEnum : ActionTask // TypeDefIndex: 14239
	{
		// Fields
		[BlackboardOnly] // 0x00000001800B4050-0x00000001800B4080
		[RequiredField] // 0x00000001800B4050-0x00000001800B4080
		public BBObjectParameter valueA; // 0x68
		public BBObjectParameter valueB; // 0x70
	
		// Properties
		protected override string info { get; } // 0x000000018125F640-0x000000018125F680 
	
		// Constructors
		public SetEnum(); // 0x000000018125F570-0x000000018125F640
	
		// Methods
		protected override void OnExecute(); // 0x000000018125F4F0-0x000000018125F570
	}
}
