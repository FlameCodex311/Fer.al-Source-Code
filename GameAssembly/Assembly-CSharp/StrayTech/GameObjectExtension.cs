/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace StrayTech
{
	public static class GameObjectExtension // TypeDefIndex: 13896
	{
		// Nested types
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <FindAllInterfaces>d__20<T> : IEnumerable<T>, IEnumerator<T> // TypeDefIndex: 13897
			where T : class
		{
			// Fields
			private int <>1__state;
			private T <>2__current;
			private int <>l__initialThreadId;
			private MonoBehaviour[] <>7__wrap1;
			private int <>7__wrap2;
	
			// Properties
			T IEnumerator<T>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; }
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; }
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <FindAllInterfaces>d__20(int <>1__state);
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset();
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			IEnumerator<T> IEnumerable<T>.GetEnumerator();
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			IEnumerator IEnumerable.GetEnumerator();
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <ScrapeInterfaces>d__22<TInterface> : IEnumerable<TInterface>, IEnumerator<TInterface> // TypeDefIndex: 13898
			where TInterface : class
		{
			// Fields
			private int <>1__state;
			private TInterface <>2__current;
			private int <>l__initialThreadId;
			private IEnumerable<GameObject> self;
			public IEnumerable<GameObject> <>3__self;
			private IEnumerator<GameObject> <>7__wrap1;
	
			// Properties
			TInterface IEnumerator<TInterface>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; }
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; }
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <ScrapeInterfaces>d__22(int <>1__state);
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose();
			private bool MoveNext();
			private void <>m__Finally1();
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset();
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			IEnumerator<TInterface> IEnumerable<TInterface>.GetEnumerator();
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			IEnumerator IEnumerable.GetEnumerator();
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <GetComponentsInChildren>d__27<T> : IEnumerable<T>, IEnumerator<T> // TypeDefIndex: 13899
			where T : Component
		{
			// Fields
			private int <>1__state;
			private T <>2__current;
			private int <>l__initialThreadId;
			private Component self;
			public Component <>3__self;
			private Predicate<T> filter;
			public Predicate<T> <>3__filter;
			private bool includeInactive;
			public bool <>3__includeInactive;
			private T[] <>7__wrap1;
			private int <>7__wrap2;
	
			// Properties
			T IEnumerator<T>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; }
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; }
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <GetComponentsInChildren>d__27(int <>1__state);
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset();
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			IEnumerator<T> IEnumerable<T>.GetEnumerator();
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			IEnumerator IEnumerable.GetEnumerator();
		}
	
		// Methods
		public static GameObject FindOrCreate(string name); // 0x00000001811FEE70-0x00000001811FEF20
		[IteratorStateMachine] // 0x000000018013E720-0x000000018013E770
		public static IEnumerable<T> FindAllInterfaces<T>()
			where T : class;
		public static T GetComponentFromLoadedResource<T>(string resourcePath)
			where T : Component;
	
		// Extension methods
		public static void CopyLocalTransform(this GameObject self, GameObject other); // 0x00000001811FE910-0x00000001811FEAB0
		public static void CopyLocalTransform(this Transform self, Transform other); // 0x00000001811FEAB0-0x00000001811FEBD0
		public static void ResetLocalTransform(this Transform self); // 0x00000001811FFCC0-0x00000001811FFDC0
		public static void NiceifyGameobjectName(this GameObject current, string prefix = "" /* Metadata: 0x00784225 */, string suffix = "" /* Metadata: 0x00784229 */, List<string> substringsToRemove = null); // 0x00000001811FFA90-0x00000001811FFCC0
		public static T GetInterface<T>(this GameObject toSearch)
			where T : class;
		public static T[] GetInterfaces<T>(this GameObject toSearch)
			where T : class;
		public static T[] GetInterfacesInChildren<T>(this GameObject toSearch, bool includeInactive, bool searchSelf = false /* Metadata: 0x0078422D */)
			where T : class;
		public static T GetInterfaceInChildren<T>(this GameObject toSearch, bool includeInactive)
			where T : class;
		public static TMonoBehaviour AddOrGetComponent<TMonoBehaviour>(this GameObject source)
			where TMonoBehaviour : Component;
		public static T GetComponentUpwards<T>(this GameObject toSearch, bool searchSelfFirst = false /* Metadata: 0x0078422E */)
			where T : Component;
		public static GameObject GetFirstChild(this GameObject toSearch); // 0x00000001811FF540-0x00000001811FF5E0
		public static GameObject CreateChild(this GameObject parent, string name); // 0x00000001811FEBD0-0x00000001811FEC90
		public static GameObject FindChildDeep(this Transform parent, string name); // 0x00000001811FEC90-0x00000001811FEDA0
		public static T GetComponentInChildren<T>(this GameObject component, bool includeInactive)
			where T : Component;
		public static T GetComponentInChildren<T>(this Component component, bool includeInactive)
			where T : Component;
		public static void LookAtXZ(this Transform self, Transform target); // 0x00000001811FF7F0-0x00000001811FFA90
		public static void LookAtXZ(this Transform self, Vector3 worldTarget); // 0x00000001811FF630-0x00000001811FF7F0
		public static Transform AddOrGetChild(this Transform parent, string childName); // 0x00000001811FE7D0-0x00000001811FE910
		public static GameObject FindChild(this GameObject self, string childName); // 0x00000001811FEDA0-0x00000001811FEE70
		public static bool IsNullOrInvalid(this IValidates self); // 0x00000001811FF5E0-0x00000001811FF630
		[IteratorStateMachine] // 0x000000018013EB30-0x000000018013EBA0
		public static IEnumerable<TInterface> ScrapeInterfaces<TInterface>(this IEnumerable<GameObject> self)
			where TInterface : class;
		public static string FullPath(this GameObject self); // 0x00000001811FEF20-0x00000001811FF150
		public static string FullPath(this Component self); // 0x00000001811FF150-0x00000001811FF280
		public static List<GameObject> GetAllChildren(this GameObject self); // 0x00000001811FF280-0x00000001811FF3D0
		public static void GetAllChildren(this GameObject self, ref List<GameObject> toPopulate); // 0x00000001811FF3D0-0x00000001811FF540
		[IteratorStateMachine] // 0x000000018013F1C0-0x000000018013F230
		public static IEnumerable<T> GetComponentsInChildren<T>(this Component self, Predicate<T> filter, bool includeInactive = false /* Metadata: 0x0078422F */)
			where T : Component;
		public static T GetComponentInChildren<T>(this Component self, Predicate<T> filter)
			where T : Component;
	}
}
