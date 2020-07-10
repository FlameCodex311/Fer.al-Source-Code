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
	[Category] // 0x000000018011A960-0x000000018011A9C0
	[Description] // 0x000000018011A960-0x000000018011A9C0
	public class NetworkObjectShowDialog : NetworkActionTask // TypeDefIndex: 14398
	{
		// Fields
		public EDialogType dialogType; // 0x68
		public BBParameter<int> dialogIndex; // 0x70
		private NetworkedObjectInfo noi; // 0x78
	
		// Properties
		protected override string info { get; } // 0x0000000181554CC0-0x00000001815551E0 
	
		// Nested types
		public enum EDialogType // TypeDefIndex: 14399
		{
			Ask = 0,
			AskAll = 1
		}
	
		// Constructors
		public NetworkObjectShowDialog(); // 0x0000000181554C70-0x0000000181554CC0
	}
}
