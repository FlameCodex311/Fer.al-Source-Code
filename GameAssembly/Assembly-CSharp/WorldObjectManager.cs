/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class WorldObjectManager : SingletonManagerBase<WorldObjectManager> // TypeDefIndex: 10808
{
	// Fields
	private ObjectCollection _objects; // 0x60
	private MethodInfo _createObjectMethodInfo; // 0x68
	private BundleDownloadCollection _prefabBundleDownloadCollection; // 0x70
	private static Dictionary<string, WorldObject> _prefabsByDefId; // 0x00

	// Nested types
	private class ObjectCollection // TypeDefIndex: 10809
	{
		// Fields
		private Dictionary<string, WorldObject> _objectsById; // 0x10
		private Dictionary<int, WorldObject> _objectsByUserId; // 0x18
		private Dictionary<string, WorldObject> _objectsByUserUUID; // 0x20

		// Constructors
		public ObjectCollection(); // 0x0000000180FE6330-0x0000000180FE63E0

		// Methods
		public WorldObject GetByObjectId(string objectId); // 0x0000000180FE5C80-0x0000000180FE5CF0
		public WorldObject GetByUserId(int userId); // 0x0000000180FE5CF0-0x0000000180FE5D60
		public WorldObject GetByUserUUID(string uuid); // 0x0000000180FE5D60-0x0000000180FE5DD0
		public void Add(WorldObject o); // 0x0000000180FE5B70-0x0000000180FE5C00
		public void TrackUser(UserInfo inUser, WorldObject inObject); // 0x0000000180FE6250-0x0000000180FE6330
		public void Remove(WorldObject o); // 0x0000000180FE6170-0x0000000180FE6250
		public void RemoveByObjectId(string objectId); // 0x0000000180FE5DD0-0x0000000180FE5F10
		public void RemoveByUserId(int userId); // 0x0000000180FE5F10-0x0000000180FE6040
		public void RemoveByUserUUID(string uuid); // 0x0000000180FE6040-0x0000000180FE6170
		public void Clear(); // 0x0000000180FE5C00-0x0000000180FE5C80
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <FinishCoroutine>d__6 : IEnumerator<object> // TypeDefIndex: 10810
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public WorldObjectManager <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <FinishCoroutine>d__6(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x0000000180FF4BF0-0x0000000180FF4C70
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x0000000180FF4C70-0x0000000180FF51C0
	}

	[Serializable]
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c // TypeDefIndex: 10811
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Action<WorldObject> <>9__28_0; // 0x08

		// Constructors
		static <>c(); // 0x0000000180FF6A70-0x0000000180FF6AD0
		public <>c(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <ClearPrefabs>b__28_0(WorldObject value); // 0x0000000180FF5D40-0x0000000180FF5DA0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass29_0 // TypeDefIndex: 10812
	{
		// Fields
		public BaseDef cWorldObjectDef; // 0x10
		public WorldObjectManager <>4__this; // 0x18

		// Constructors
		public <>c__DisplayClass29_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <DownloadPrefabs>b__0(GameObject loadedAsset); // 0x0000000180FF5F90-0x0000000180FF60E0
	}

	// Constructors
	public WorldObjectManager(); // 0x00000001810023C0-0x00000001810024B0
	static WorldObjectManager(); // 0x0000000181002360-0x00000001810023C0

	// Methods
	public override void Init(); // 0x0000000181001660-0x0000000181001860
	public override bool HasFinishCoroutine(); // 0x00000001803C29F0-0x00000001803C2A00
	[IteratorStateMachine] // 0x00000001800DFA30-0x00000001800DFA80
	public override IEnumerator FinishCoroutine(); // 0x0000000181001270-0x00000001810012D0
	public override void Deinit(); // 0x0000000181000E40-0x0000000181000FE0
	public static WorldObject GetByObjectId(string objectId); // 0x0000000181001370-0x0000000181001420
	public static WorldObject GetByUserId(int userId); // 0x0000000181001420-0x00000001810014D0
	public static WorldObject GetByUserUUID(string uuid); // 0x00000001810014D0-0x0000000181001580
	public static void RemoveByObjectId(string objectId); // 0x0000000181001E60-0x0000000181001FF0
	public static void RemoveByUserId(int userId); // 0x0000000181001FF0-0x0000000181002170
	public static void RemoveByUserUUID(string userUUID); // 0x0000000181002170-0x00000001810022F0
	public static void TrackUser(UserInfo inUser, WorldObject inObject); // 0x00000001810022F0-0x0000000181002360
	private void OnLevelLoading(Message inMessage); // 0x0000000181001860-0x00000001810018F0
	private void OnWorldObjectInfoMessage(WorldObjectInfoMessage message); // 0x0000000181001C10-0x0000000181001E60
	private void ForceDestroy(WorldObject inWorldObject); // 0x00000001810012D0-0x0000000181001370
	private void OnWorldObjectActionStartMessage(WorldObjectActionStartMessage inMessage); // 0x0000000181001B00-0x0000000181001C10
	private void OnWorldObjectActionCancelMessage(WorldObjectActionCancelMessage inMessage); // 0x00000001810018F0-0x00000001810019F0
	private void OnWorldObjectActionFinishMessage(WorldObjectActionFinishMessage inMessage); // 0x00000001810019F0-0x0000000181001B00
	public static GameObject CreateClone<T>(string inWorldObjectDefID, WorldObject<T> inObjectToClone, Vector3 inPosition, Quaternion inRotation, Action<GameObject, T> inResultCallback)
		where T : WorldObjectInfo;
	public static GameObject CreateClone<T>(WorldObject<T> inObjectToClone, Vector3 inPosition, Quaternion inRotation, Action<GameObject, T> inResultCallback)
		where T : WorldObjectInfo;
	public static GameObject Create<T>(string inWorldObjectDefID, T inInfo, Vector3 inPosition, Quaternion inRotation, Action<GameObject, T> inResultCallback)
		where T : WorldObjectInfo;
	public static GameObject CreateWithID<T>(string inWorldObjectInstanceID, string inWorldObjectDefID, T inInfo, Vector3 inPosition, Quaternion inRotation, Action<GameObject, T> inResultCallback)
		where T : WorldObjectInfo;
	private WorldObject CreateObject(WorldObjectInfoMessage message); // 0x0000000181000A20-0x0000000181000E40
	public static WorldObject GetPrefabWithDefID(string inPrefabDefID); // 0x0000000181001580-0x0000000181001660
	public static void ClearPrefabs(); // 0x00000001810008A0-0x0000000181000A20
	private void DownloadPrefabs(); // 0x0000000181000FE0-0x0000000181001270
}

