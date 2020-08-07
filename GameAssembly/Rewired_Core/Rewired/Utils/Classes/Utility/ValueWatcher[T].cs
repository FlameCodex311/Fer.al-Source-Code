/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
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
	internal sealed class ValueWatcher<T> : ValueWatcher // TypeDefIndex: 7081
	{
		// Fields
		private static IEqualityComparer<T> PHfYDGwiJMDirGAMJwTwYeofakp;
		private bool nGUCoIcYbohCvvLydsvgZqrzEaW;
		private T FsxdnKHTiBkQzQeLhcyCJCYysFt;
		private bool ZNnNpvKquNHqulJlMfemZtvvtHp;
		private Func<T> ymUirBBLEcargSiPzLvIxNFtCho;
		private Action<T> azkkxSPPqfjHrXpBnJCfsmWbzmp;
	
		// Properties
		public override bool changed { get; }
		public override bool autoTriggerEvent { get; set; }
		public Func<T> getValueDelegate { get; set; }
		public T value { get; }
	
		// Events
		public event Action<T> ChangedEvent {
			add; // 0x00000000-0x00000000
			remove; // 0x00000000-0x00000000
		}
	
		// Constructors
		public ValueWatcher(T initialValue, bool autoTriggerEvent);
		public ValueWatcher(T initialValue, Func<T> getValueDelegate, bool autoTriggerEvent);
		static ValueWatcher();
	
		// Methods
		public override bool Update();
		public override bool Use();
		public override bool TriggerEvent();
		public bool Set(T value);
		public override void AddEventListener(eaksbTCSHXsAACqYSgJAdgGkDQR eventType, Delegate listener);
		public override void RemoveEventListener(eaksbTCSHXsAACqYSgJAdgGkDQR eventType, Delegate listener);
	}
}
