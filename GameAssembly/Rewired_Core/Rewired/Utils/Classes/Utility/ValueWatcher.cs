/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired;

// Image 51: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5871-7113

namespace Rewired.Utils.Classes.Utility
{
	[CustomClassObfuscation] // 0x00000001801CDC90-0x00000001801CDCE0
	[CustomObfuscation] // 0x00000001801CDC90-0x00000001801CDCE0
	internal abstract class ValueWatcher // TypeDefIndex: 7079
	{
		// Properties
		public abstract bool changed { get; }
		public abstract bool autoTriggerEvent { get; set; }
	
		// Nested types
		public enum eaksbTCSHXsAACqYSgJAdgGkDQR // TypeDefIndex: 7080
		{
			VdITYZTFcrVHpdCrpwWQRGWtOro = 0
		}
	
		// Constructors
		protected ValueWatcher(); // 0x0000000180373240-0x0000000180373250
	
		// Methods
		public abstract bool Update();
		public abstract bool Use();
		public abstract bool TriggerEvent();
		public abstract void AddEventListener(eaksbTCSHXsAACqYSgJAdgGkDQR eventType, Delegate listener);
		public abstract void RemoveEventListener(eaksbTCSHXsAACqYSgJAdgGkDQR eventType, Delegate listener);
	}
}
