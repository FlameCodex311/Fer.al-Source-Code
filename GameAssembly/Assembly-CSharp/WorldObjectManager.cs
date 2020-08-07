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

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class WorldObjectManager : SingletonManagerBase<WorldObjectManager> // TypeDefIndex: 12318
{
	// Fields
	private ObjectCollection _objects; // 0x60
	private MethodInfo _createObjectMethodInfo; // 0x68
	private BundleDownloadCollection _prefabBundleDownloadCollection; // 0x70
	private static Dictionary<string, WorldObject> _prefabsByDefId; // 0x00

	// Nested types
	private class ObjectCollection // TypeDefIndex: 12319
	{
		// Fields
		private Dictionary<string, WorldObject> _objectsById; // 0x10
		private Dictionary<int, WorldObject> _objectsByUserId; // 0x18
		private Dictionary<string, WorldObject> _objectsByUserUUID; // 0x20

		// Constructors
		public ObjectCollection(); // 0x00000001805CFBE0-0x00000001805CFC90

		// Methods
		public WorldObject GetByObjectId(string objectId); // 0x00000001805CF540-0x00000001805CF5B0
		public WorldObject GetByUserId(int userId); // 0x00000001805CF5B0-0x00000001805CF620
		public WorldObject GetByUserUUID(string uuid); // 0x00000001805CF620-0x00000001805CF690
		public void Add(WorldObject o); // 0x00000001805CF430-0x00000001805CF4C0
		public void TrackUser(UserInfo inUser, WorldObject inObject); // 0x00000001805CFB00-0x00000001805CFBE0
		public void Remove(WorldObject o); // 0x00000001805CFA30-0x00000001805CFB00
		public void RemoveByObjectId(string objectId); // 0x00000001805CF690-0x00000001805CF7D0
		public void RemoveByUserId(int userId); // 0x00000001805CF7D0-0x00000001805CF900
		public void RemoveByUserUUID(string uuid); // 0x00000001805CF900-0x00000001805CFA30
		public void Clear(); // 0x00000001805CF4C0-0x00000001805CF540
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <FinishCoroutine>d__6 : IEnumerator<object> // TypeDefIndex: 12320
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public WorldObjectManager <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <FinishCoroutine>d__6(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x00000001805DC230-0x00000001805DC2B0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x00000001805DC2B0-0x00000001805DC800
	}

	[Serializable]
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c // TypeDefIndex: 12321
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Action<WorldObject> <>9__28_0; // 0x08

		// Constructors
		static <>c(); // 0x00000001805DDEF0-0x00000001805DE2C0
		public <>c(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <ClearPrefabs>b__28_0(WorldObject value); // 0x00000001805DD370-0x00000001805DD3D0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass29_0 // TypeDefIndex: 12322
	{
		// Fields
		public BaseDef cWorldObjectDef; // 0x10
		public WorldObjectManager <>4__this; // 0x18

		// Constructors
		public <>c__DisplayClass29_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <DownloadPrefabs>b__0(GameObject loadedAsset); // 0x00000001805DD590-0x00000001805DD6E0
	}

	// Constructors
	public WorldObjectManager(); // 0x00000001805E9650-0x00000001805E9740
	static WorldObjectManager(); // 0x00000001805E95F0-0x00000001805E9650

	// Methods
	public override void Init(); // 0x00000001805E8920-0x00000001805E8B20
	public override bool HasFinishCoroutine(); // 0x0000000180380B60-0x0000000180380B70
	[IteratorStateMachine] // 0x000000018027D6F0-0x000000018027D740
	public override IEnumerator FinishCoroutine(); // 0x00000001805E8530-0x00000001805E8590
	public override void Deinit(); // 0x00000001805E8110-0x00000001805E82B0
	public static WorldObject GetByObjectId(string objectId); // 0x00000001805E8630-0x00000001805E86E0
	public static WorldObject GetByUserId(int userId); // 0x00000001805E86E0-0x00000001805E8790
	public static WorldObject GetByUserUUID(string uuid); // 0x00000001805E8790-0x00000001805E8840
	public static void RemoveByObjectId(string objectId); // 0x00000001805E9100-0x00000001805E9280
	public static void RemoveByUserId(int userId); // 0x00000001805E9280-0x00000001805E9400
	public static void RemoveByUserUUID(string userUUID); // 0x00000001805E9400-0x00000001805E9580
	public static void TrackUser(UserInfo inUser, WorldObject inObject); // 0x00000001805E9580-0x00000001805E95F0
	private void OnLevelLoading(Message inMessage); // 0x00000001805E8B20-0x00000001805E8BB0
	private void OnWorldObjectInfoMessage(WorldObjectInfoMessage message); // 0x00000001805E8EC0-0x00000001805E9100
	private void ForceDestroy(WorldObject inWorldObject); // 0x00000001805E8590-0x00000001805E8630
	private void OnWorldObjectActionStartMessage(WorldObjectActionStartMessage inMessage); // 0x00000001805E8DB0-0x00000001805E8EC0
	private void OnWorldObjectActionCancelMessage(WorldObjectActionCancelMessage inMessage); // 0x00000001805E8BB0-0x00000001805E8CB0
	private void OnWorldObjectActionFinishMessage(WorldObjectActionFinishMessage inMessage); // 0x00000001805E8CB0-0x00000001805E8DB0
	public static GameObject CreateClone<T>(string inWorldObjectDefID, WorldObject<T> inObjectToClone, Vector3 inPosition, Quaternion inRotation, Action<GameObject, T> inResultCallback)
		where T : WorldObjectInfo;
	public static GameObject CreateClone<T>(WorldObject<T> inObjectToClone, Vector3 inPosition, Quaternion inRotation, Action<GameObject, T> inResultCallback)
		where T : WorldObjectInfo;
	public static GameObject Create<T>(string inWorldObjectDefID, T inInfo, Vector3 inPosition, Quaternion inRotation, Action<GameObject, T> inResultCallback)
		where T : WorldObjectInfo;
	public static GameObject CreateWithID<T>(string inWorldObjectInstanceID, string inWorldObjectDefID, T inInfo, Vector3 inPosition, Quaternion inRotation, Action<GameObject, T> inResultCallback)
		where T : WorldObjectInfo;
	private WorldObject CreateObject(WorldObjectInfoMessage message); // 0x00000001805E7D20-0x00000001805E8110
	public static WorldObject GetPrefabWithDefID(string inPrefabDefID); // 0x00000001805E8840-0x00000001805E8920
	public static void ClearPrefabs(); // 0x00000001805E7BA0-0x00000001805E7D20
	private void DownloadPrefabs(); // 0x00000001805E82B0-0x00000001805E8530
}

