/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace Candlelight
{
	public static class ObjectX // TypeDefIndex: 14493
	{
		// Fields
		private static readonly Regex s_MatchPrefabName; // 0x00
	
		// Nested types
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c__DisplayClass13_0<T> // TypeDefIndex: 14494
			where T : Component
		{
			// Fields
			public Predicate<T> isElementSuitable;
	
			// Constructors
			public <>c__DisplayClass13_0();
	
			// Methods
			internal bool <GetFromPool>b__0(T item);
		}
	
		[Serializable]
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c__13<T> // TypeDefIndex: 14495
			where T : Component
		{
			// Fields
			public static readonly <>c__13<T> <>9;
			public static Predicate<T> <>9__13_1;
	
			// Constructors
			static <>c__13();
			public <>c__13();
	
			// Methods
			internal bool <GetFromPool>b__13_1(T item);
		}
	
		// Constructors
		static ObjectX(); // 0x00000001804A5040-0x00000001804A5350
	
		// Methods
		public static bool AreObjectSequencesEqual<T>(IList<T> list1, IList<T> list2)
			where T : UnityEngine.Object;
		public static bool AreStructSequencesEqual<T>(IList<T> list1, IList<T> list2)
			where T : struct, IEquatable<T>;
		public static int GenerateHashCode(int hash1, int hash2); // 0x00000001804A4DD0-0x00000001804A4EB0
		public static int GenerateHashCode(int hash1, int hash2, int hash3); // 0x00000001804A4640-0x00000001804A4740
		public static int GenerateHashCode(int hash1, int hash2, int hash3, int hash4); // 0x00000001804A4740-0x00000001804A4860
		public static int GenerateHashCode(int hash1, int hash2, int hash3, int hash4, int hash5); // 0x00000001804A4860-0x00000001804A4990
		public static int GenerateHashCode(int hash1, int hash2, int hash3, int hash4, int hash5, int hash6); // 0x00000001804A4500-0x00000001804A4640
		public static int GenerateHashCode(int hash1, int hash2, int hash3, int hash4, int hash5, int hash6, int hash7); // 0x00000001804A4C80-0x00000001804A4DD0
		public static int GenerateHashCode(int hash1, int hash2, int hash3, int hash4, int hash5, int hash6, int hash7, int hash8); // 0x00000001804A4990-0x00000001804A4B00
		public static int GenerateHashCode(IList<int> fieldHashes); // 0x00000001804A4B00-0x00000001804A4C80
		public static int GenerateHashCode<T>(IList<T> listField);
		[Conditional] // 0x00000001801D54F0-0x00000001801D5520
		public static void GetAllTypes(HashSet<Type> allTypes); // 0x00000001804A4EB0-0x00000001804A4F00
		public static T GetFromPool<T>(List<T> pool, T prefab, Transform parent = null, Predicate<T> isElementSuitable = null)
			where T : Component;
		[Obsolete] // 0x0000000180244390-0x00000001802443C0
		public static bool Equals<T>(ref T thisObj, object otherObj)
			where T : struct;
	
		// Extension methods
		public static string GetPrefabName(this UnityEngine.Object instance); // 0x00000001804A4F00-0x00000001804A4FB0
		public static void OpenReferencePage(this UnityEngine.Object obj, string product, string urlFormat = "http://candlelightinteractive.com/docs/{0}/html/T_{1}.htm?ref=editor" /* Metadata: 0x007BAC2B */); // 0x00000001804A4FB0-0x00000001804A5040
	}
}
