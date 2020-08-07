/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using DG.Tweening;
using DG.Tweening.Core.Enums;
using DG.Tweening.Plugins.Options;

// Image 49: DOTween.dll - Assembly: DOTween, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5670-5860

namespace DG.Tweening.Core
{
	internal static class TweenManager // TypeDefIndex: 5841
	{
		// Fields
		private const int _DefaultMaxTweeners = 200; // Metadata: 0x00763537
		private const int _DefaultMaxSequences = 50; // Metadata: 0x0076353B
		private const string _MaxTweensReached = "Max Tweens reached: capacity has automatically been increased from #0 to #1. Use DOTween.SetTweensCapacity to set it manually at startup"; // Metadata: 0x0076353F
		private const float _EpsilonVsTimeCheck = 1E-06f; // Metadata: 0x007635CB
		internal static bool isUnityEditor; // 0x00
		internal static bool isDebugBuild; // 0x01
		internal static int maxActive; // 0x04
		internal static int maxTweeners; // 0x08
		internal static int maxSequences; // 0x0C
		internal static bool hasActiveTweens; // 0x10
		internal static bool hasActiveDefaultTweens; // 0x11
		internal static bool hasActiveLateTweens; // 0x12
		internal static bool hasActiveFixedTweens; // 0x13
		internal static bool hasActiveManualTweens; // 0x14
		internal static int totActiveTweens; // 0x18
		internal static int totActiveDefaultTweens; // 0x1C
		internal static int totActiveLateTweens; // 0x20
		internal static int totActiveFixedTweens; // 0x24
		internal static int totActiveManualTweens; // 0x28
		internal static int totActiveTweeners; // 0x2C
		internal static int totActiveSequences; // 0x30
		internal static int totPooledTweeners; // 0x34
		internal static int totPooledSequences; // 0x38
		internal static int totTweeners; // 0x3C
		internal static int totSequences; // 0x40
		internal static bool isUpdateLoop; // 0x44
		internal static Tween[] _activeTweens; // 0x48
		private static Tween[] _pooledTweeners; // 0x50
		private static readonly Stack<Tween> _PooledSequences; // 0x58
		private static readonly List<Tween> _KillList; // 0x60
		private static readonly Dictionary<Tween, TweenLink> _TweenLinks; // 0x68
		private static int _totTweenLinks; // 0x70
		private static int _maxActiveLookupId; // 0x74
		private static bool _requiresActiveReorganization; // 0x78
		private static int _reorganizeFromId; // 0x7C
		private static int _minPooledTweenerId; // 0x80
		private static int _maxPooledTweenerId; // 0x84
		private static bool _despawnAllCalledFromUpdateLoopCallback; // 0x88
	
		// Nested types
		internal enum CapacityIncreaseMode // TypeDefIndex: 5842
		{
			TweenersAndSequences = 0,
			TweenersOnly = 1,
			SequencesOnly = 2
		}
	
		// Constructors
		static TweenManager(); // 0x0000000181799CD0-0x0000000181799E90
	
		// Methods
		internal static TweenerCore<T1, T2, TPlugOptions> GetTweener<T1, T2, TPlugOptions>()
			where TPlugOptions : struct, IPlugOptions;
		internal static Sequence GetSequence(); // 0x0000000181796920-0x0000000181796C10
		internal static void SetUpdateType(Tween t, UpdateType updateType, bool isIndependentUpdate); // 0x0000000181798E40-0x0000000181799150
		internal static void AddActiveTweenToSequence(Tween t); // 0x00000001817943C0-0x0000000181794420
		internal static int DespawnAll(); // 0x0000000181794CD0-0x0000000181795010
		internal static void Despawn(Tween t, bool modifyActiveLists = true /* Metadata: 0x00763525 */); // 0x0000000181795010-0x0000000181795720
		internal static void PurgeAll(); // 0x0000000181797AA0-0x0000000181797D90
		internal static void PurgePools(); // 0x0000000181797D90-0x0000000181797EE0
		internal static void AddTweenLink(Tween t, TweenLink tweenLink); // 0x0000000181794850-0x0000000181794A90
		private static void RemoveTweenLink(Tween t); // 0x0000000181798600-0x00000001817986E0
		internal static void ResetCapacities(); // 0x0000000181798A40-0x0000000181798AA0
		internal static void SetCapacities(int tweenersCapacity, int sequencesCapacity); // 0x0000000181798D40-0x0000000181798E40
		internal static int Validate(); // 0x0000000181799AD0-0x0000000181799CD0
		internal static void Update(UpdateType updateType, float deltaTime, float independentTime); // 0x00000001817995B0-0x0000000181799AD0
		internal static int FilteredOperation(OperationType operationType, FilterType filterType, object id, bool optionalBool, float optionalFloat, object optionalObj = null, object[] optionalArray = null); // 0x0000000181795B10-0x0000000181796640
		internal static bool Complete(Tween t, bool modifyActiveLists = true /* Metadata: 0x00763526 */, UpdateMode updateMode = UpdateMode.Goto /* Metadata: 0x00763527 */); // 0x0000000181794AE0-0x0000000181794C10
		internal static bool Flip(Tween t); // 0x0000000181796640-0x0000000181796660
		internal static void ForceInit(Tween t, bool isSequenced = false /* Metadata: 0x0076352B */); // 0x0000000181796660-0x0000000181796730
		internal static bool Goto(Tween t, float to, bool andPlay = false /* Metadata: 0x0076352C */, UpdateMode updateMode = UpdateMode.Goto /* Metadata: 0x0076352D */); // 0x0000000181797110-0x0000000181797290
		internal static bool Pause(Tween t); // 0x0000000181797680-0x00000001817976C0
		internal static bool Play(Tween t); // 0x0000000181797A20-0x0000000181797AA0
		internal static bool PlayBackwards(Tween t); // 0x00000001817976C0-0x00000001817978A0
		internal static bool PlayForward(Tween t); // 0x00000001817978A0-0x0000000181797A20
		internal static bool Restart(Tween t, bool includeDelay = true /* Metadata: 0x00763531 */, float changeDelayTo = -1f /* Metadata: 0x00763532 */); // 0x0000000181798AA0-0x0000000181798B80
		internal static bool Rewind(Tween t, bool includeDelay = true /* Metadata: 0x00763536 */); // 0x0000000181798B80-0x0000000181798D40
		internal static bool SmoothRewind(Tween t); // 0x0000000181799150-0x00000001817992D0
		internal static bool TogglePause(Tween t); // 0x00000001817992D0-0x00000001817993D0
		internal static int TotalPooledTweens(); // 0x0000000181799550-0x00000001817995B0
		internal static int TotalPlayingTweens(); // 0x00000001817993D0-0x0000000181799550
		internal static List<Tween> GetActiveTweens(bool playing, List<Tween> fillableList = null); // 0x0000000181796730-0x0000000181796920
		internal static List<Tween> GetTweensById(object id, bool playingOnly, List<Tween> fillableList = null); // 0x0000000181796C10-0x0000000181796F10
		internal static List<Tween> GetTweensByTarget(object target, bool playingOnly, List<Tween> fillableList = null); // 0x0000000181796F10-0x0000000181797110
		private static void MarkForKilling(Tween t); // 0x00000001817975F0-0x0000000181797680
		private static void EvaluateTweenLink(Tween t); // 0x0000000181795720-0x0000000181795B10
		private static void AddActiveTween(Tween t); // 0x0000000181794420-0x0000000181794850
		private static void ReorganizeActiveTweens(); // 0x00000001817986E0-0x0000000181798A40
		private static void DespawnActiveTweens(List<Tween> tweens); // 0x0000000181794C10-0x0000000181794CD0
		private static void RemoveActiveTween(Tween t); // 0x0000000181797EE0-0x0000000181798600
		private static void ClearTweenArray(Tween[] tweens); // 0x0000000181794A90-0x0000000181794AE0
		private static void IncreaseCapacities(CapacityIncreaseMode increaseMode); // 0x0000000181797290-0x0000000181797510
		private static void ManageOnRewindCallbackWhenAlreadyRewinded(Tween t, bool isPlayBackwardsOrSmoothRewind); // 0x0000000181797510-0x00000001817975F0
	}
}
