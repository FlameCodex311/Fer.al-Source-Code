/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired;
using Rewired.Utils.Classes.Data;

// Image 51: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5871-7113

namespace Rewired.Utils
{
	[CustomClassObfuscation] // 0x00000001801CDC90-0x00000001801CDCE0
	[CustomObfuscation] // 0x00000001801CDC90-0x00000001801CDCE0
	internal static class TempListPool // TypeDefIndex: 7033
	{
		// Fields
		private const int QuobDfExlYAAxiZQbzmJguvSzUER = 3; // Metadata: 0x0076674E
		private const int IsDByJwIkEJqdeqHPxuWryIQzjH = 10; // Metadata: 0x00766752
		private static ADictionary<Type, List<IList>> KJAwdZewowmVZDMHhyitjyzKemB; // 0x00
	
		// Properties
		private static ADictionary<Type, List<IList>> lists { get; } // 0x0000000181468900-0x0000000181468980 
	
		// Nested types
		private static class MFSEKUYwXMGreEkOsVfzghCrToo // TypeDefIndex: 7034
		{
			// Fields
			private static ADictionary<Type, List<object>> MoeVudfSYLRJBRYkkoSIpbeREpO; // 0x00
	
			// Properties
			private static ADictionary<Type, List<object>> QjgifPkBJDCZcrYisJgbYmodiibI { get; } // 0x0000000181460080-0x0000000181460100 
	
			// Methods
			public static TList<T> HidcSjbKbECBzYyBnCtcFeYTQWme<T>(List<T> param_0000f113);
			public static void yoRCItCPChIXsxwWNFdfdtYCJTlo<T>(TList<T> param_0000f114);
			public static void vMfAexzdpfzhXKkyGdAHmJVnQEr(); // 0x0000000181460100-0x0000000181460140
			public static void vMfAexzdpfzhXKkyGdAHmJVnQEr(Type param_0000f115); // 0x0000000181460140-0x0000000181460200
		}
	
		[CustomClassObfuscation] // 0x00000001801CDED0-0x00000001801CDF20
		[CustomObfuscation] // 0x00000001801CDED0-0x00000001801CDF20
		internal interface ITListSetter<T> // TypeDefIndex: 7035
		{
			// Methods
			void SetList(List<T> list);
		}
	
		[CustomClassObfuscation] // 0x00000001801CDED0-0x00000001801CDF20
		[CustomObfuscation] // 0x00000001801CDED0-0x00000001801CDF20
		internal sealed class TList<T> : IDisposable, ITListSetter<T> // TypeDefIndex: 7036
		{
			// Fields
			private List<T> QDdpegUvplbleFLzyPPIlUNzJOf;
			private bool vEblpmllYIOuQHCXVghuIpihdSG;
	
			// Properties
			public List<T> list { get; }
	
			// Constructors
			private TList();
	
			// Methods
			public static TList<T> Create();
			public void Dispose();
			private void yoRCItCPChIXsxwWNFdfdtYCJTlo();
			void Rewired.Utils.TempListPool.ITListSetter<T>.SetList(List<T> param_0000f117);
			private static void vapHFBEsowtEKFLgbLLbKSuLarb();
			public static implicit operator List<T>(TList<T> obj);
		}
	
		// Methods
		public static TList<T> GetTList<T>();
		public static TList<T> GetTList<T>(int capacity);
		public static void ReturnTList<T>(TList<T> tList);
		public static List<T> Get<T>();
		public static List<T> Get<T>(int capacity);
		public static void Return<T>(List<T> list);
		public static void Return<T>(List<T> list1, List<T> list2);
		public static void Return<T>(List<T> list1, List<T> list2, List<T> list3);
		public static void Clear(); // 0x0000000181468890-0x0000000181468900
		public static void Clear(Type listType); // 0x0000000181468750-0x0000000181468890
	}
}
