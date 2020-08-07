/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace StrayTech
{
	public static class GameObjectExtension // TypeDefIndex: 14563
	{
		// Nested types
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <FindAllInterfaces>d__20<T> : IEnumerable<T>, IEnumerator<T> // TypeDefIndex: 14564
			where T : class
		{
			// Fields
			private int <>1__state;
			private T <>2__current;
			private int <>l__initialThreadId;
			private MonoBehaviour[] <>7__wrap1;
			private int <>7__wrap2;
	
			// Properties
			T IEnumerator<T>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; }
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; }
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <FindAllInterfaces>d__20(int <>1__state);
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset();
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			IEnumerator<T> IEnumerable<T>.GetEnumerator();
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			IEnumerator IEnumerable.GetEnumerator();
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <ScrapeInterfaces>d__22<TInterface> : IEnumerable<TInterface>, IEnumerator<TInterface> // TypeDefIndex: 14565
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
			TInterface IEnumerator<TInterface>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; }
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; }
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <ScrapeInterfaces>d__22(int <>1__state);
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose();
			private bool MoveNext();
			private void <>m__Finally1();
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset();
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			IEnumerator<TInterface> IEnumerable<TInterface>.GetEnumerator();
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			IEnumerator IEnumerable.GetEnumerator();
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <GetComponentsInChildren>d__27<T> : IEnumerable<T>, IEnumerator<T> // TypeDefIndex: 14566
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
			T IEnumerator<T>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; }
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; }
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <GetComponentsInChildren>d__27(int <>1__state);
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset();
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			IEnumerator<T> IEnumerable<T>.GetEnumerator();
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			IEnumerator IEnumerable.GetEnumerator();
		}
	
		// Methods
		public static GameObject FindOrCreate(string name); // 0x0000000180CB43D0-0x0000000180CB4480
		[IteratorStateMachine] // 0x0000000180268F50-0x0000000180268FA0
		public static IEnumerable<T> FindAllInterfaces<T>()
			where T : class;
		public static T GetComponentFromLoadedResource<T>(string resourcePath)
			where T : Component;
	
		// Extension methods
		public static void CopyLocalTransform(this GameObject self, GameObject other); // 0x0000000180CB3E80-0x0000000180CB4020
		public static void CopyLocalTransform(this Transform self, Transform other); // 0x0000000180CB4020-0x0000000180CB4140
		public static void ResetLocalTransform(this Transform self); // 0x0000000180CB51E0-0x0000000180CB52E0
		public static void NiceifyGameobjectName(this GameObject current, string prefix = "" /* Metadata: 0x007BACE8 */, string suffix = "" /* Metadata: 0x007BACEC */, List<string> substringsToRemove = null); // 0x0000000180CB4FB0-0x0000000180CB51E0
		public static T GetInterface<T>(this GameObject toSearch)
			where T : class;
		public static T[] GetInterfaces<T>(this GameObject toSearch)
			where T : class;
		public static T[] GetInterfacesInChildren<T>(this GameObject toSearch, bool includeInactive, bool searchSelf = false /* Metadata: 0x007BACF0 */)
			where T : class;
		public static T GetInterfaceInChildren<T>(this GameObject toSearch, bool includeInactive)
			where T : class;
		public static TMonoBehaviour AddOrGetComponent<TMonoBehaviour>(this GameObject source)
			where TMonoBehaviour : Component;
		public static T GetComponentUpwards<T>(this GameObject toSearch, bool searchSelfFirst = false /* Metadata: 0x007BACF1 */)
			where T : Component;
		public static GameObject GetFirstChild(this GameObject toSearch); // 0x0000000180CB4A80-0x0000000180CB4B10
		public static GameObject CreateChild(this GameObject parent, string name); // 0x0000000180CB4140-0x0000000180CB4200
		public static GameObject FindChildDeep(this Transform parent, string name); // 0x0000000180CB4200-0x0000000180CB4300
		public static T GetComponentInChildren<T>(this GameObject component, bool includeInactive)
			where T : Component;
		public static T GetComponentInChildren<T>(this Component component, bool includeInactive)
			where T : Component;
		public static void LookAtXZ(this Transform self, Transform target); // 0x0000000180CB4D10-0x0000000180CB4FB0
		public static void LookAtXZ(this Transform self, Vector3 worldTarget); // 0x0000000180CB4B60-0x0000000180CB4D10
		public static Transform AddOrGetChild(this Transform parent, string childName); // 0x0000000180CB3D50-0x0000000180CB3E80
		public static GameObject FindChild(this GameObject self, string childName); // 0x0000000180CB4300-0x0000000180CB43D0
		public static bool IsNullOrInvalid(this IValidates self); // 0x0000000180CB4B10-0x0000000180CB4B60
		[IteratorStateMachine] // 0x0000000180269470-0x00000001802694E0
		public static IEnumerable<TInterface> ScrapeInterfaces<TInterface>(this IEnumerable<GameObject> self)
			where TInterface : class;
		public static string FullPath(this GameObject self); // 0x0000000180CB4480-0x0000000180CB46A0
		public static string FullPath(this Component self); // 0x0000000180CB46A0-0x0000000180CB47D0
		public static List<GameObject> GetAllChildren(this GameObject self); // 0x0000000180CB47D0-0x0000000180CB4910
		public static void GetAllChildren(this GameObject self, ref List<GameObject> toPopulate); // 0x0000000180CB4910-0x0000000180CB4A80
		[IteratorStateMachine] // 0x000000018026A060-0x000000018026A0D0
		public static IEnumerable<T> GetComponentsInChildren<T>(this Component self, Predicate<T> filter, bool includeInactive = false /* Metadata: 0x007BACF2 */)
			where T : Component;
		public static T GetComponentInChildren<T>(this Component self, Predicate<T> filter)
			where T : Component;
	}
}
