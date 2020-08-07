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
	[CustomClassObfuscation] // 0x00000001801CDED0-0x00000001801CDF20
	[CustomObfuscation] // 0x00000001801CDED0-0x00000001801CDF20
	internal class ObjectInstanceTracker : IDisposable // TypeDefIndex: 7068
	{
		// Fields
		private static ObjectInstanceTracker DqYmGHECTlrDVQmfbrCSLOJGmsK; // 0x00
		private readonly Dictionary<uint, object> TYufseIPYRAITDrtiEyIVAnwmfKR; // 0x10
		private readonly object WatKdvusjCxngKhmexeOsWElHfj; // 0x18
		private uint LmoXqZdlklByordOEfRAEHUjbmtR; // 0x20
		private int zmVTMZhvzUQzWQrGMGOGKzlVJbw; // 0x24
		private bool uCCFjviloQzdElMrfDDBZRCAEDsh; // 0x28
	
		// Properties
		public static ObjectInstanceTracker Default { get; } // 0x00000001813F9280-0x00000001813F9360 
	
		// Nested types
		[CustomClassObfuscation] // 0x00000001801CDC90-0x00000001801CDCE0
		[CustomObfuscation] // 0x00000001801CDC90-0x00000001801CDCE0
		public class Wrapper<T> : IDisposable // TypeDefIndex: 7069
			where T : class
		{
			// Fields
			public readonly T instance;
			public readonly uint instanceId;
			private readonly ObjectInstanceTracker SRTIePsJiAFtcYHeVPMOKnlVyMr;
			private bool vEblpmllYIOuQHCXVghuIpihdSG;
	
			// Constructors
			public Wrapper(T instance);
			public Wrapper(T instance, ObjectInstanceTracker tracker);
	
			// Methods
			public void Dispose();
			~Wrapper();
			protected virtual void Dispose(bool disposing);
		}
	
		// Constructors
		public ObjectInstanceTracker(); // 0x00000001813F9200-0x00000001813F9280
	
		// Methods
		public uint Register(object instance); // 0x00000001813F9030-0x00000001813F9110
		public void Unregister(uint instanceId); // 0x00000001813F9110-0x00000001813F9200
		public bool TryGetInstance<T>(uint instanceId, out T instance)
			where T : class;
		public void Dispose(); // 0x00000001813F8EC0-0x00000001813F8F20
		private void HpvXOLYMqgpVKJfbWRtmjedASDv(bool param_0000f60e); // 0x00000001813F8FB0-0x00000001813F9030
		~ObjectInstanceTracker(); // 0x00000001813F8F20-0x00000001813F8FB0
	}
}
