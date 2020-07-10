/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using Unity.Jobs;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Networking;
using UnityEngine.UI;

// Image 68: UniRx.Async.dll - Assembly: UniRx.Async, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8376-8739

namespace UniRx.Async
{
	public static class UnityAsyncExtensions // TypeDefIndex: 8622
	{
		// Nested types
		public struct AsyncOperationAwaiter : IAwaiter // TypeDefIndex: 8623
		{
			// Fields
			private AsyncOperation asyncOperation; // 0x00
			private Action<AsyncOperation> continuationAction; // 0x08
			private AwaiterStatus status; // 0x10
	
			// Properties
			public bool IsCompleted { get; } // 0x0000000180321570-0x0000000180321690 
			public AwaiterStatus Status { get; } // 0x0000000180002700-0x0000000180002710 
	
			// Constructors
			public AsyncOperationAwaiter(AsyncOperation asyncOperation); // 0x0000000180321730-0x0000000180321840
	
			// Methods
			public void GetResult(); // 0x0000000180321690-0x0000000180321710
			public void OnCompleted(Action continuation); // 0x0000000180321710-0x0000000180321720
			public void UnsafeOnCompleted(Action continuation); // 0x0000000180321720-0x0000000180321730
		}
	
		private class AsyncOperationConfiguredAwaiter : IAwaiter, IPlayerLoopItem // TypeDefIndex: 8624
		{
			// Fields
			private AsyncOperation asyncOperation; // 0x10
			private IProgress<float> progress; // 0x18
			private CancellationToken cancellationToken; // 0x20
			private AwaiterStatus status; // 0x28
			private Action continuation; // 0x30
	
			// Properties
			public bool IsCompleted { get; } // 0x0000000180B9E950-0x0000000180B9E960 
			public AwaiterStatus Status { get; } // 0x000000018038E0E0-0x000000018038E0F0 
	
			// Constructors
			public AsyncOperationConfiguredAwaiter(AsyncOperation asyncOperation, IProgress<float> progress, CancellationToken cancellationToken); // 0x00000001820DE850-0x00000001820DE8F0
	
			// Methods
			public void GetResult(); // 0x00000001820DE630-0x00000001820DE660
			public bool MoveNext(); // 0x00000001820DE6F0-0x00000001820DE7D0
			private void InvokeContinuation(AwaiterStatus status); // 0x00000001820DE660-0x00000001820DE6F0
			public void OnCompleted(Action continuation); // 0x00000001820DE7D0-0x00000001820DE850
			public void UnsafeOnCompleted(Action continuation); // 0x00000001820DE7D0-0x00000001820DE850
		}
	
		public struct ResourceRequestAwaiter : IAwaiter<UnityEngine.Object> // TypeDefIndex: 8625
		{
			// Fields
			private ResourceRequest asyncOperation; // 0x00
			private Action<AsyncOperation> continuationAction; // 0x08
			private AwaiterStatus status; // 0x10
			private UnityEngine.Object result; // 0x18
	
			// Properties
			public bool IsCompleted { get; } // 0x0000000180321570-0x0000000180321690 
			public AwaiterStatus Status { get; } // 0x0000000180002700-0x0000000180002710 
	
			// Constructors
			public ResourceRequestAwaiter(ResourceRequest asyncOperation); // 0x0000000180321BD0-0x0000000180321C70
	
			// Methods
			public UnityEngine.Object GetResult(); // 0x0000000180321B90-0x0000000180321BA0
			void IAwaiter.GetResult(); // 0x0000000180321BB0-0x0000000180321BC0
			public void OnCompleted(Action continuation); // 0x0000000180321BA0-0x0000000180321BB0
			public void UnsafeOnCompleted(Action continuation); // 0x0000000180321BC0-0x0000000180321BD0
		}
	
		private class ResourceRequestConfiguredAwaiter : IAwaiter<UnityEngine.Object>, IPlayerLoopItem // TypeDefIndex: 8626
		{
			// Fields
			private ResourceRequest asyncOperation; // 0x10
			private IProgress<float> progress; // 0x18
			private CancellationToken cancellationToken; // 0x20
			private AwaiterStatus status; // 0x28
			private Action continuation; // 0x30
			private UnityEngine.Object result; // 0x38
	
			// Properties
			public bool IsCompleted { get; } // 0x0000000180B9E950-0x0000000180B9E960 
			public AwaiterStatus Status { get; } // 0x000000018038E0E0-0x000000018038E0F0 
	
			// Constructors
			public ResourceRequestConfiguredAwaiter(ResourceRequest asyncOperation, IProgress<float> progress, CancellationToken cancellationToken); // 0x00000001820DFA00-0x00000001820DFAC0
	
			// Methods
			void IAwaiter.GetResult(); // 0x00000001820DF930-0x00000001820DF980
			public UnityEngine.Object GetResult(); // 0x00000001820DF6C0-0x00000001820DF720
			public bool MoveNext(); // 0x00000001820DF7B0-0x00000001820DF8B0
			private void InvokeContinuation(AwaiterStatus status); // 0x00000001820DF720-0x00000001820DF7B0
			public void OnCompleted(Action continuation); // 0x00000001820DF8B0-0x00000001820DF930
			public void UnsafeOnCompleted(Action continuation); // 0x00000001820DF980-0x00000001820DFA00
		}
	
		public struct AssetBundleRequestAwaiter : IAwaiter<UnityEngine.Object> // TypeDefIndex: 8627
		{
			// Fields
			private AssetBundleRequest asyncOperation; // 0x00
			private Action<AsyncOperation> continuationAction; // 0x08
			private AwaiterStatus status; // 0x10
			private UnityEngine.Object result; // 0x18
	
			// Properties
			public bool IsCompleted { get; } // 0x0000000180321570-0x0000000180321690 
			public AwaiterStatus Status { get; } // 0x0000000180002700-0x0000000180002710 
	
			// Constructors
			public AssetBundleRequestAwaiter(AssetBundleRequest asyncOperation); // 0x00000001803214F0-0x0000000180321570
	
			// Methods
			public UnityEngine.Object GetResult(); // 0x00000001803214B0-0x00000001803214C0
			void IAwaiter.GetResult(); // 0x00000001803214D0-0x00000001803214E0
			public void OnCompleted(Action continuation); // 0x00000001803214C0-0x00000001803214D0
			public void UnsafeOnCompleted(Action continuation); // 0x00000001803214E0-0x00000001803214F0
		}
	
		private class AssetBundleRequestConfiguredAwaiter : IAwaiter<UnityEngine.Object>, IPlayerLoopItem // TypeDefIndex: 8628
		{
			// Fields
			private AssetBundleRequest asyncOperation; // 0x10
			private IProgress<float> progress; // 0x18
			private CancellationToken cancellationToken; // 0x20
			private AwaiterStatus status; // 0x28
			private Action continuation; // 0x30
			private UnityEngine.Object result; // 0x38
	
			// Properties
			public bool IsCompleted { get; } // 0x0000000180B9E950-0x0000000180B9E960 
			public AwaiterStatus Status { get; } // 0x000000018038E0E0-0x000000018038E0F0 
	
			// Constructors
			public AssetBundleRequestConfiguredAwaiter(AssetBundleRequest asyncOperation, IProgress<float> progress, CancellationToken cancellationToken); // 0x00000001820DE4D0-0x00000001820DE630
	
			// Methods
			void IAwaiter.GetResult(); // 0x00000001820DE400-0x00000001820DE450
			public UnityEngine.Object GetResult(); // 0x00000001820DE190-0x00000001820DE1F0
			public bool MoveNext(); // 0x00000001820DE280-0x00000001820DE380
			private void InvokeContinuation(AwaiterStatus status); // 0x00000001820DE1F0-0x00000001820DE280
			public void OnCompleted(Action continuation); // 0x00000001820DE380-0x00000001820DE400
			public void UnsafeOnCompleted(Action continuation); // 0x00000001820DE450-0x00000001820DE4D0
		}
	
		private class WWWConfiguredAwaiter : IAwaiter, IPlayerLoopItem // TypeDefIndex: 8629
		{
			// Fields
			private WWW asyncOperation; // 0x10
			private IProgress<float> progress; // 0x18
			private CancellationToken cancellationToken; // 0x20
			private AwaiterStatus status; // 0x28
			private Action continuation; // 0x30
	
			// Properties
			public bool IsCompleted { get; } // 0x0000000180B9E950-0x0000000180B9E960 
			public AwaiterStatus Status { get; } // 0x000000018038E0E0-0x000000018038E0F0 
	
			// Constructors
			public WWWConfiguredAwaiter(WWW asyncOperation, IProgress<float> progress, CancellationToken cancellationToken); // 0x00000001820E6110-0x00000001820E61B0
	
			// Methods
			public void GetResult(); // 0x00000001820DE630-0x00000001820DE660
			public bool MoveNext(); // 0x00000001820E5FB0-0x00000001820E6090
			private void InvokeContinuation(AwaiterStatus status); // 0x00000001820E5F20-0x00000001820E5FB0
			public void OnCompleted(Action continuation); // 0x00000001820E6090-0x00000001820E6110
			public void UnsafeOnCompleted(Action continuation); // 0x00000001820E6090-0x00000001820E6110
		}
	
		public struct UnityWebRequestAsyncOperationAwaiter : IAwaiter<UnityWebRequest> // TypeDefIndex: 8630
		{
			// Fields
			private UnityWebRequestAsyncOperation asyncOperation; // 0x00
			private Action<AsyncOperation> continuationAction; // 0x08
			private AwaiterStatus status; // 0x10
			private UnityWebRequest result; // 0x18
	
			// Properties
			public bool IsCompleted { get; } // 0x0000000180321570-0x0000000180321690 
			public AwaiterStatus Status { get; } // 0x0000000180002700-0x0000000180002710 
	
			// Constructors
			public UnityWebRequestAsyncOperationAwaiter(UnityWebRequestAsyncOperation asyncOperation); // 0x0000000180321E50-0x0000000180321EF0
	
			// Methods
			public UnityWebRequest GetResult(); // 0x0000000180321E10-0x0000000180321E20
			void IAwaiter.GetResult(); // 0x0000000180321E30-0x0000000180321E40
			public void OnCompleted(Action continuation); // 0x0000000180321E20-0x0000000180321E30
			public void UnsafeOnCompleted(Action continuation); // 0x0000000180321E40-0x0000000180321E50
		}
	
		private class UnityWebRequestAsyncOperationConfiguredAwaiter : IAwaiter<UnityWebRequest>, IPlayerLoopItem // TypeDefIndex: 8631
		{
			// Fields
			private UnityWebRequestAsyncOperation asyncOperation; // 0x10
			private IProgress<float> progress; // 0x18
			private CancellationToken cancellationToken; // 0x20
			private AwaiterStatus status; // 0x28
			private Action continuation; // 0x30
			private UnityWebRequest result; // 0x38
	
			// Properties
			public bool IsCompleted { get; } // 0x0000000180B9E950-0x0000000180B9E960 
			public AwaiterStatus Status { get; } // 0x000000018038E0E0-0x000000018038E0F0 
	
			// Constructors
			public UnityWebRequestAsyncOperationConfiguredAwaiter(UnityWebRequestAsyncOperation asyncOperation, IProgress<float> progress, CancellationToken cancellationToken); // 0x00000001820E5E60-0x00000001820E5F20
	
			// Methods
			void IAwaiter.GetResult(); // 0x00000001820E5D90-0x00000001820E5DE0
			public UnityWebRequest GetResult(); // 0x00000001820E5B20-0x00000001820E5B80
			public bool MoveNext(); // 0x00000001820E5C10-0x00000001820E5D10
			private void InvokeContinuation(AwaiterStatus status); // 0x00000001820E5B80-0x00000001820E5C10
			public void OnCompleted(Action continuation); // 0x00000001820E5D10-0x00000001820E5D90
			public void UnsafeOnCompleted(Action continuation); // 0x00000001820E5DE0-0x00000001820E5E60
		}
	
		private class JobHandleAwaiter : IAwaiter, IPlayerLoopItem // TypeDefIndex: 8632
		{
			// Fields
			private JobHandle jobHandle; // 0x10
			private CancellationToken cancellationToken; // 0x20
			private AwaiterStatus status; // 0x28
			private Action continuation; // 0x30
	
			// Properties
			public bool IsCompleted { get; } // 0x0000000180B9E950-0x0000000180B9E960 
			public AwaiterStatus Status { get; } // 0x000000018038E0E0-0x000000018038E0F0 
	
			// Constructors
			public JobHandleAwaiter(JobHandle jobHandle, CancellationToken cancellationToken, int skipFrame = 2 /* Metadata: 0x007433E4 */); // 0x00000001820DF4F0-0x00000001820DF6C0
	
			// Methods
			public void GetResult(); // 0x00000001820DE630-0x00000001820DE660
			public bool MoveNext(); // 0x00000001820DF290-0x00000001820DF470
			private void InvokeContinuation(AwaiterStatus status); // 0x00000001820DF200-0x00000001820DF290
			public void OnCompleted(Action continuation); // 0x00000001820DF470-0x00000001820DF4F0
			public void UnsafeOnCompleted(Action continuation); // 0x00000001820DF470-0x00000001820DF4F0
		}
	
		// Extension methods
		public static AsyncOperationAwaiter GetAwaiter(this AsyncOperation asyncOperation); // 0x00000001820E44C0-0x00000001820E4550
		public static UniTask ToUniTask(this AsyncOperation asyncOperation); // 0x00000001820E5540-0x00000001820E55F0
		public static UniTask ConfigureAwait(this AsyncOperation asyncOperation, IProgress<float> progress = null, PlayerLoopTiming timing = PlayerLoopTiming.Update /* Metadata: 0x007433D0 */, CancellationToken cancellation = default); // 0x00000001820E3AE0-0x00000001820E3BE0
		public static ResourceRequestAwaiter GetAwaiter(this ResourceRequest resourceRequest); // 0x00000001820E4550-0x00000001820E4600
		public static UniTask<UnityEngine.Object> ToUniTask(this ResourceRequest resourceRequest); // 0x00000001820E55F0-0x00000001820E56E0
		public static UniTask<UnityEngine.Object> ConfigureAwait(this ResourceRequest resourceRequest, IProgress<float> progress = null, PlayerLoopTiming timing = PlayerLoopTiming.Update /* Metadata: 0x007433D4 */, CancellationToken cancellation = default); // 0x00000001820E3790-0x00000001820E38F0
		public static AssetBundleRequestAwaiter GetAwaiter(this AssetBundleRequest resourceRequest); // 0x00000001820E4600-0x00000001820E46B0
		public static UniTask<UnityEngine.Object> ToUniTask(this AssetBundleRequest resourceRequest); // 0x00000001820E56E0-0x00000001820E57D0
		public static UniTask<UnityEngine.Object> ConfigureAwait(this AssetBundleRequest resourceRequest, IProgress<float> progress = null, PlayerLoopTiming timing = PlayerLoopTiming.Update /* Metadata: 0x007433D8 */, CancellationToken cancellation = default); // 0x00000001820E3630-0x00000001820E3790
		public static IAwaiter GetAwaiter(this WWW www); // 0x00000001820E46B0-0x00000001820E47C0
		public static UniTask ToUniTask(this WWW www); // 0x00000001820E57D0-0x00000001820E58E0
		public static UniTask ConfigureAwait(this WWW www, IProgress<float> progress = null, PlayerLoopTiming timing = PlayerLoopTiming.Update /* Metadata: 0x007433DC */, CancellationToken cancellation = default); // 0x00000001820E39E0-0x00000001820E3AE0
		public static UnityWebRequestAsyncOperationAwaiter GetAwaiter(this UnityWebRequestAsyncOperation asyncOperation); // 0x00000001820E4410-0x00000001820E44C0
		public static UniTask<UnityWebRequest> ToUniTask(this UnityWebRequestAsyncOperation asyncOperation); // 0x00000001820E58E0-0x00000001820E5B20
		public static UniTask<UnityWebRequest> ConfigureAwait(this UnityWebRequestAsyncOperation asyncOperation, IProgress<float> progress = null, PlayerLoopTiming timing = PlayerLoopTiming.Update /* Metadata: 0x007433E0 */, CancellationToken cancellation = default); // 0x00000001820E34D0-0x00000001820E3630
		public static IAwaiter GetAwaiter(this JobHandle jobHandle); // 0x00000001820E47C0-0x00000001820E4900
		public static UniTask ToUniTask(this JobHandle jobHandle, CancellationToken cancellation = default); // 0x00000001820E5420-0x00000001820E5540
		public static UniTask ConfigureAwait(this JobHandle jobHandle, PlayerLoopTiming waitTiming, CancellationToken cancellation = default); // 0x00000001820E38F0-0x00000001820E39E0
		public static AsyncUnityEventHandler GetAsyncEventHandler(this UnityEvent unityEvent, CancellationToken cancellationToken); // 0x00000001820E3E10-0x00000001820E3E80
		public static UniTask OnInvokeAsync(this UnityEvent unityEvent, CancellationToken cancellationToken); // 0x00000001820E4BD0-0x00000001820E4C50
		public static IAsyncClickEventHandler GetAsyncClickEventHandler(this Button button); // 0x00000001820E3C60-0x00000001820E3CF0
		public static IAsyncClickEventHandler GetAsyncClickEventHandler(this Button button, CancellationToken cancellationToken); // 0x00000001820E3BE0-0x00000001820E3C60
		public static UniTask OnClickAsync(this Button button); // 0x00000001820E49A0-0x00000001820E4A40
		public static UniTask OnClickAsync(this Button button, CancellationToken cancellationToken); // 0x00000001820E4900-0x00000001820E49A0
		public static IAsyncValueChangedEventHandler<bool> GetAsyncValueChangedEventHandler(this Toggle toggle); // 0x00000001820E3F10-0x00000001820E3FA0
		public static IAsyncValueChangedEventHandler<bool> GetAsyncValueChangedEventHandler(this Toggle toggle, CancellationToken cancellationToken); // 0x00000001820E4380-0x00000001820E4410
		public static UniTask<bool> OnValueChangedAsync(this Toggle toggle); // 0x00000001820E4DD0-0x00000001820E4EA0
		public static UniTask<bool> OnValueChangedAsync(this Toggle toggle, CancellationToken cancellationToken); // 0x00000001820E4D10-0x00000001820E4DD0
		public static IAsyncValueChangedEventHandler<float> GetAsyncValueChangedEventHandler(this Scrollbar scrollbar); // 0x00000001820E4140-0x00000001820E41D0
		public static IAsyncValueChangedEventHandler<float> GetAsyncValueChangedEventHandler(this Scrollbar scrollbar, CancellationToken cancellationToken); // 0x00000001820E4260-0x00000001820E42F0
		public static UniTask<float> OnValueChangedAsync(this Scrollbar scrollbar); // 0x00000001820E51C0-0x00000001820E5290
		public static UniTask<float> OnValueChangedAsync(this Scrollbar scrollbar, CancellationToken cancellationToken); // 0x00000001820E4C50-0x00000001820E4D10
		public static IAsyncValueChangedEventHandler<Vector2> GetAsyncValueChangedEventHandler(this ScrollRect scrollRect); // 0x00000001820E41D0-0x00000001820E4260
		public static IAsyncValueChangedEventHandler<Vector2> GetAsyncValueChangedEventHandler(this ScrollRect scrollRect, CancellationToken cancellationToken); // 0x00000001820E4030-0x00000001820E40B0
		public static UniTask<Vector2> OnValueChangedAsync(this ScrollRect scrollRect); // 0x00000001820E5030-0x00000001820E5100
		public static UniTask<Vector2> OnValueChangedAsync(this ScrollRect scrollRect, CancellationToken cancellationToken); // 0x00000001820E5100-0x00000001820E51C0
		public static IAsyncValueChangedEventHandler<float> GetAsyncValueChangedEventHandler(this Slider slider); // 0x00000001820E3E80-0x00000001820E3F10
		public static IAsyncValueChangedEventHandler<float> GetAsyncValueChangedEventHandler(this Slider slider, CancellationToken cancellationToken); // 0x00000001820E40B0-0x00000001820E4140
		public static UniTask<float> OnValueChangedAsync(this Slider slider); // 0x00000001820E4F60-0x00000001820E5030
		public static UniTask<float> OnValueChangedAsync(this Slider slider, CancellationToken cancellationToken); // 0x00000001820E4EA0-0x00000001820E4F60
		public static IAsyncEndEditEventHandler<string> GetAsyncEndEditEventHandler(this InputField inputField); // 0x00000001820E3CF0-0x00000001820E3D80
		public static IAsyncEndEditEventHandler<string> GetAsyncEndEditEventHandler(this InputField inputField, CancellationToken cancellationToken); // 0x00000001820E3D80-0x00000001820E3E10
		public static UniTask<string> OnEndEditAsync(this InputField inputField); // 0x00000001820E4A40-0x00000001820E4B10
		public static UniTask<string> OnEndEditAsync(this InputField inputField, CancellationToken cancellationToken); // 0x00000001820E4B10-0x00000001820E4BD0
		public static IAsyncValueChangedEventHandler<int> GetAsyncValueChangedEventHandler(this Dropdown dropdown); // 0x00000001820E3FA0-0x00000001820E4030
		public static IAsyncValueChangedEventHandler<int> GetAsyncValueChangedEventHandler(this Dropdown dropdown, CancellationToken cancellationToken); // 0x00000001820E42F0-0x00000001820E4380
		public static UniTask<int> OnValueChanged(this Dropdown dropdown); // 0x00000001820E5290-0x00000001820E5360
		public static UniTask<int> OnValueChanged(this Dropdown dropdown, CancellationToken cancellationToken); // 0x00000001820E5360-0x00000001820E5420
	}
}
