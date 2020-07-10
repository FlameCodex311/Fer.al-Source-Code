/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace Candlelight
{
	public static class ObjectX // TypeDefIndex: 13826
	{
		// Fields
		private static readonly Regex s_MatchPrefabName; // 0x00
	
		// Nested types
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c__DisplayClass13_0<T> // TypeDefIndex: 13827
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
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c__13<T> // TypeDefIndex: 13828
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
		static ObjectX(); // 0x000000018102E540-0x000000018102E850
	
		// Methods
		public static bool AreObjectSequencesEqual<T>(IList<T> list1, IList<T> list2)
			where T : UnityEngine.Object;
		public static bool AreStructSequencesEqual<T>(IList<T> list1, IList<T> list2)
			where T : struct, IEquatable<T>;
		public static int GenerateHashCode(int hash1, int hash2); // 0x000000018102E2D0-0x000000018102E3B0
		public static int GenerateHashCode(int hash1, int hash2, int hash3); // 0x000000018102DB30-0x000000018102DC30
		public static int GenerateHashCode(int hash1, int hash2, int hash3, int hash4); // 0x000000018102DC30-0x000000018102DD50
		public static int GenerateHashCode(int hash1, int hash2, int hash3, int hash4, int hash5); // 0x000000018102DD50-0x000000018102DE80
		public static int GenerateHashCode(int hash1, int hash2, int hash3, int hash4, int hash5, int hash6); // 0x000000018102D9F0-0x000000018102DB30
		public static int GenerateHashCode(int hash1, int hash2, int hash3, int hash4, int hash5, int hash6, int hash7); // 0x000000018102E170-0x000000018102E2D0
		public static int GenerateHashCode(int hash1, int hash2, int hash3, int hash4, int hash5, int hash6, int hash7, int hash8); // 0x000000018102DE80-0x000000018102DFF0
		public static int GenerateHashCode(IList<int> fieldHashes); // 0x000000018102DFF0-0x000000018102E170
		public static int GenerateHashCode<T>(IList<T> listField);
		[Conditional] // 0x00000001800C0AC0-0x00000001800C0AF0
		public static void GetAllTypes(HashSet<Type> allTypes); // 0x000000018102E3B0-0x000000018102E400
		public static T GetFromPool<T>(List<T> pool, T prefab, Transform parent = null, Predicate<T> isElementSuitable = null)
			where T : Component;
		[Obsolete] // 0x0000000180115300-0x0000000180115330
		public static bool Equals<T>(ref T thisObj, object otherObj)
			where T : struct;
	
		// Extension methods
		public static string GetPrefabName(this UnityEngine.Object instance); // 0x000000018102E400-0x000000018102E4B0
		public static void OpenReferencePage(this UnityEngine.Object obj, string product, string urlFormat = "http://candlelightinteractive.com/docs/{0}/html/T_{1}.htm?ref=editor" /* Metadata: 0x00784168 */); // 0x000000018102E4B0-0x000000018102E540
	}
}
