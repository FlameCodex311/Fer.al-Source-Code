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

// Image 69: UniRx.Async.dll - Assembly: UniRx.Async, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8542-8905

namespace UniRx.Async
{
	public static class UnityAsyncExtensions // TypeDefIndex: 8788
	{
		// Nested types
		private class JobHandleAwaiter : IAwaiter, IPlayerLoopItem // TypeDefIndex: 8789
		{
			// Fields
			private JobHandle jobHandle; // 0x10
			private CancellationToken cancellationToken; // 0x20
			private AwaiterStatus status; // 0x28
			private Action continuation; // 0x30
	
			// Properties
			public bool IsCompleted { get; } // 0x0000000180DFF8C0-0x0000000180DFF8D0 
			public AwaiterStatus Status { get; } // 0x000000018043C680-0x000000018043C690 
	
			// Constructors
			public JobHandleAwaiter(JobHandle jobHandle, CancellationToken cancellationToken, int skipFrame = 2 /* Metadata: 0x007780D2 */); // 0x0000000181AC5AA0-0x0000000181AC5C70
	
			// Methods
			public void GetResult(); // 0x0000000181AC44D0-0x0000000181AC4500
			public bool MoveNext(); // 0x0000000181AC5840-0x0000000181AC5A20
			private void InvokeContinuation(AwaiterStatus status); // 0x0000000181AC57B0-0x0000000181AC5840
			public void OnCompleted(Action continuation); // 0x0000000181AC5A20-0x0000000181AC5AA0
			public void UnsafeOnCompleted(Action continuation); // 0x0000000181AC5A20-0x0000000181AC5AA0
		}
	
		public struct AsyncOperationAwaiter : IAwaiter // TypeDefIndex: 8790
		{
			// Fields
			private AsyncOperation asyncOperation; // 0x00
			private Action<AsyncOperation> continuationAction; // 0x08
			private AwaiterStatus status; // 0x10
	
			// Properties
			public bool IsCompleted { get; } // 0x000000018010E550-0x000000018010E670 
			public AwaiterStatus Status { get; } // 0x00000001800034D0-0x00000001800034E0 
	
			// Constructors
			public AsyncOperationAwaiter(AsyncOperation asyncOperation); // 0x000000018010E710-0x000000018010E830
	
			// Methods
			public void GetResult(); // 0x000000018010E670-0x000000018010E6F0
			public void OnCompleted(Action continuation); // 0x000000018010E6F0-0x000000018010E700
			public void UnsafeOnCompleted(Action continuation); // 0x000000018010E700-0x000000018010E710
		}
	
		private class AsyncOperationConfiguredAwaiter : IAwaiter, IPlayerLoopItem // TypeDefIndex: 8791
		{
			// Fields
			private AsyncOperation asyncOperation; // 0x10
			private IProgress<float> progress; // 0x18
			private CancellationToken cancellationToken; // 0x20
			private AwaiterStatus status; // 0x28
			private Action continuation; // 0x30
	
			// Properties
			public bool IsCompleted { get; } // 0x0000000180DFF8C0-0x0000000180DFF8D0 
			public AwaiterStatus Status { get; } // 0x000000018043C680-0x000000018043C690 
	
			// Constructors
			public AsyncOperationConfiguredAwaiter(AsyncOperation asyncOperation, IProgress<float> progress, CancellationToken cancellationToken); // 0x0000000181AC46E0-0x0000000181AC4780
	
			// Methods
			public void GetResult(); // 0x0000000181AC44D0-0x0000000181AC4500
			public bool MoveNext(); // 0x0000000181AC4590-0x0000000181AC4660
			private void InvokeContinuation(AwaiterStatus status); // 0x0000000181AC4500-0x0000000181AC4590
			public void OnCompleted(Action continuation); // 0x0000000181AC4660-0x0000000181AC46E0
			public void UnsafeOnCompleted(Action continuation); // 0x0000000181AC4660-0x0000000181AC46E0
		}
	
		public struct ResourceRequestAwaiter : IAwaiter<UnityEngine.Object> // TypeDefIndex: 8792
		{
			// Fields
			private ResourceRequest asyncOperation; // 0x00
			private Action<AsyncOperation> continuationAction; // 0x08
			private AwaiterStatus status; // 0x10
			private UnityEngine.Object result; // 0x18
	
			// Properties
			public bool IsCompleted { get; } // 0x000000018010E550-0x000000018010E670 
			public AwaiterStatus Status { get; } // 0x00000001800034D0-0x00000001800034E0 
	
			// Constructors
			public ResourceRequestAwaiter(ResourceRequest asyncOperation); // 0x000000018010EC50-0x000000018010ECF0
	
			// Methods
			public UnityEngine.Object GetResult(); // 0x000000018010EC10-0x000000018010EC20
			void IAwaiter.GetResult(); // 0x000000018010EC30-0x000000018010EC40
			public void OnCompleted(Action continuation); // 0x000000018010EC20-0x000000018010EC30
			public void UnsafeOnCompleted(Action continuation); // 0x000000018010EC40-0x000000018010EC50
		}
	
		private class ResourceRequestConfiguredAwaiter : IAwaiter<UnityEngine.Object>, IPlayerLoopItem // TypeDefIndex: 8793
		{
			// Fields
			private ResourceRequest asyncOperation; // 0x10
			private IProgress<float> progress; // 0x18
			private CancellationToken cancellationToken; // 0x20
			private AwaiterStatus status; // 0x28
			private Action continuation; // 0x30
			private UnityEngine.Object result; // 0x38
	
			// Properties
			public bool IsCompleted { get; } // 0x0000000180DFF8C0-0x0000000180DFF8D0 
			public AwaiterStatus Status { get; } // 0x000000018043C680-0x000000018043C690 
	
			// Constructors
			public ResourceRequestConfiguredAwaiter(ResourceRequest asyncOperation, IProgress<float> progress, CancellationToken cancellationToken); // 0x0000000181AC5FB0-0x0000000181AC6070
	
			// Methods
			void IAwaiter.GetResult(); // 0x0000000181AC5EE0-0x0000000181AC5F30
			public UnityEngine.Object GetResult(); // 0x0000000181AC5C70-0x0000000181AC5CD0
			public bool MoveNext(); // 0x0000000181AC5D60-0x0000000181AC5E60
			private void InvokeContinuation(AwaiterStatus status); // 0x0000000181AC5CD0-0x0000000181AC5D60
			public void OnCompleted(Action continuation); // 0x0000000181AC5E60-0x0000000181AC5EE0
			public void UnsafeOnCompleted(Action continuation); // 0x0000000181AC5F30-0x0000000181AC5FB0
		}
	
		public struct AssetBundleRequestAwaiter : IAwaiter<UnityEngine.Object> // TypeDefIndex: 8794
		{
			// Fields
			private AssetBundleRequest asyncOperation; // 0x00
			private Action<AsyncOperation> continuationAction; // 0x08
			private AwaiterStatus status; // 0x10
			private UnityEngine.Object result; // 0x18
	
			// Properties
			public bool IsCompleted { get; } // 0x000000018010E550-0x000000018010E670 
			public AwaiterStatus Status { get; } // 0x00000001800034D0-0x00000001800034E0 
	
			// Constructors
			public AssetBundleRequestAwaiter(AssetBundleRequest asyncOperation); // 0x000000018010E4D0-0x000000018010E550
	
			// Methods
			public UnityEngine.Object GetResult(); // 0x000000018010E490-0x000000018010E4A0
			void IAwaiter.GetResult(); // 0x000000018010E4B0-0x000000018010E4C0
			public void OnCompleted(Action continuation); // 0x000000018010E4A0-0x000000018010E4B0
			public void UnsafeOnCompleted(Action continuation); // 0x000000018010E4C0-0x000000018010E4D0
		}
	
		private class AssetBundleRequestConfiguredAwaiter : IAwaiter<UnityEngine.Object>, IPlayerLoopItem // TypeDefIndex: 8795
		{
			// Fields
			private AssetBundleRequest asyncOperation; // 0x10
			private IProgress<float> progress; // 0x18
			private CancellationToken cancellationToken; // 0x20
			private AwaiterStatus status; // 0x28
			private Action continuation; // 0x30
			private UnityEngine.Object result; // 0x38
	
			// Properties
			public bool IsCompleted { get; } // 0x0000000180DFF8C0-0x0000000180DFF8D0 
			public AwaiterStatus Status { get; } // 0x000000018043C680-0x000000018043C690 
	
			// Constructors
			public AssetBundleRequestConfiguredAwaiter(AssetBundleRequest asyncOperation, IProgress<float> progress, CancellationToken cancellationToken); // 0x0000000181AC4370-0x0000000181AC44D0
	
			// Methods
			void IAwaiter.GetResult(); // 0x0000000181AC42A0-0x0000000181AC42F0
			public UnityEngine.Object GetResult(); // 0x0000000181AC4030-0x0000000181AC4090
			public bool MoveNext(); // 0x0000000181AC4120-0x0000000181AC4220
			private void InvokeContinuation(AwaiterStatus status); // 0x0000000181AC4090-0x0000000181AC4120
			public void OnCompleted(Action continuation); // 0x0000000181AC4220-0x0000000181AC42A0
			public void UnsafeOnCompleted(Action continuation); // 0x0000000181AC42F0-0x0000000181AC4370
		}
	
		private class WWWConfiguredAwaiter : IAwaiter, IPlayerLoopItem // TypeDefIndex: 8796
		{
			// Fields
			private WWW asyncOperation; // 0x10
			private IProgress<float> progress; // 0x18
			private CancellationToken cancellationToken; // 0x20
			private AwaiterStatus status; // 0x28
			private Action continuation; // 0x30
	
			// Properties
			public bool IsCompleted { get; } // 0x0000000180DFF8C0-0x0000000180DFF8D0 
			public AwaiterStatus Status { get; } // 0x000000018043C680-0x000000018043C690 
	
			// Constructors
			public WWWConfiguredAwaiter(WWW asyncOperation, IProgress<float> progress, CancellationToken cancellationToken); // 0x0000000181ACDA30-0x0000000181ACDAD0
	
			// Methods
			public void GetResult(); // 0x0000000181AC44D0-0x0000000181AC4500
			public bool MoveNext(); // 0x0000000181ACD8E0-0x0000000181ACD9B0
			private void InvokeContinuation(AwaiterStatus status); // 0x0000000181ACD850-0x0000000181ACD8E0
			public void OnCompleted(Action continuation); // 0x0000000181ACD9B0-0x0000000181ACDA30
			public void UnsafeOnCompleted(Action continuation); // 0x0000000181ACD9B0-0x0000000181ACDA30
		}
	
		public struct UnityWebRequestAsyncOperationAwaiter : IAwaiter<UnityWebRequest> // TypeDefIndex: 8797
		{
			// Fields
			private UnityWebRequestAsyncOperation asyncOperation; // 0x00
			private Action<AsyncOperation> continuationAction; // 0x08
			private AwaiterStatus status; // 0x10
			private UnityWebRequest result; // 0x18
	
			// Properties
			public bool IsCompleted { get; } // 0x000000018010E550-0x000000018010E670 
			public AwaiterStatus Status { get; } // 0x00000001800034D0-0x00000001800034E0 
	
			// Constructors
			public UnityWebRequestAsyncOperationAwaiter(UnityWebRequestAsyncOperation asyncOperation); // 0x000000018010F260-0x000000018010F300
	
			// Methods
			public UnityWebRequest GetResult(); // 0x000000018010F220-0x000000018010F230
			void IAwaiter.GetResult(); // 0x000000018010F240-0x000000018010F250
			public void OnCompleted(Action continuation); // 0x000000018010F230-0x000000018010F240
			public void UnsafeOnCompleted(Action continuation); // 0x000000018010F250-0x000000018010F260
		}
	
		private class UnityWebRequestAsyncOperationConfiguredAwaiter : IAwaiter<UnityWebRequest>, IPlayerLoopItem // TypeDefIndex: 8798
		{
			// Fields
			private UnityWebRequestAsyncOperation asyncOperation; // 0x10
			private IProgress<float> progress; // 0x18
			private CancellationToken cancellationToken; // 0x20
			private AwaiterStatus status; // 0x28
			private Action continuation; // 0x30
			private UnityWebRequest result; // 0x38
	
			// Properties
			public bool IsCompleted { get; } // 0x0000000180DFF8C0-0x0000000180DFF8D0 
			public AwaiterStatus Status { get; } // 0x000000018043C680-0x000000018043C690 
	
			// Constructors
			public UnityWebRequestAsyncOperationConfiguredAwaiter(UnityWebRequestAsyncOperation asyncOperation, IProgress<float> progress, CancellationToken cancellationToken); // 0x0000000181ACD790-0x0000000181ACD850
	
			// Methods
			void IAwaiter.GetResult(); // 0x0000000181ACD6C0-0x0000000181ACD710
			public UnityWebRequest GetResult(); // 0x0000000181ACD460-0x0000000181ACD4C0
			public bool MoveNext(); // 0x0000000181ACD550-0x0000000181ACD640
			private void InvokeContinuation(AwaiterStatus status); // 0x0000000181ACD4C0-0x0000000181ACD550
			public void OnCompleted(Action continuation); // 0x0000000181ACD640-0x0000000181ACD6C0
			public void UnsafeOnCompleted(Action continuation); // 0x0000000181ACD710-0x0000000181ACD790
		}
	
		// Extension methods
		public static IAwaiter GetAwaiter(this JobHandle jobHandle); // 0x0000000181ACC140-0x0000000181ACC280
		public static UniTask ToUniTask(this JobHandle jobHandle, CancellationToken cancellation = default); // 0x0000000181ACCD80-0x0000000181ACCEA0
		public static UniTask ConfigureAwait(this JobHandle jobHandle, PlayerLoopTiming waitTiming, CancellationToken cancellation = default); // 0x0000000181ACB2A0-0x0000000181ACB390
		public static AsyncOperationAwaiter GetAwaiter(this AsyncOperation asyncOperation); // 0x0000000181ACBE40-0x0000000181ACBED0
		public static UniTask ToUniTask(this AsyncOperation asyncOperation); // 0x0000000181ACCEA0-0x0000000181ACCF50
		public static UniTask ConfigureAwait(this AsyncOperation asyncOperation, IProgress<float> progress = null, PlayerLoopTiming timing = PlayerLoopTiming.Update /* Metadata: 0x007780BE */, CancellationToken cancellation = default); // 0x0000000181ACB480-0x0000000181ACB570
		public static ResourceRequestAwaiter GetAwaiter(this ResourceRequest resourceRequest); // 0x0000000181ACBED0-0x0000000181ACBF80
		public static UniTask<UnityEngine.Object> ToUniTask(this ResourceRequest resourceRequest); // 0x0000000181ACCF50-0x0000000181ACD040
		public static UniTask<UnityEngine.Object> ConfigureAwait(this ResourceRequest resourceRequest, IProgress<float> progress = null, PlayerLoopTiming timing = PlayerLoopTiming.Update /* Metadata: 0x007780C2 */, CancellationToken cancellation = default); // 0x0000000181ACB150-0x0000000181ACB2A0
		public static AssetBundleRequestAwaiter GetAwaiter(this AssetBundleRequest resourceRequest); // 0x0000000181ACBF80-0x0000000181ACC030
		public static UniTask<UnityEngine.Object> ToUniTask(this AssetBundleRequest resourceRequest); // 0x0000000181ACD040-0x0000000181ACD130
		public static UniTask<UnityEngine.Object> ConfigureAwait(this AssetBundleRequest resourceRequest, IProgress<float> progress = null, PlayerLoopTiming timing = PlayerLoopTiming.Update /* Metadata: 0x007780C6 */, CancellationToken cancellation = default); // 0x0000000181ACB000-0x0000000181ACB150
		public static IAwaiter GetAwaiter(this WWW www); // 0x0000000181ACC030-0x0000000181ACC140
		public static UniTask ToUniTask(this WWW www); // 0x0000000181ACD130-0x0000000181ACD240
		public static UniTask ConfigureAwait(this WWW www, IProgress<float> progress = null, PlayerLoopTiming timing = PlayerLoopTiming.Update /* Metadata: 0x007780CA */, CancellationToken cancellation = default); // 0x0000000181ACB390-0x0000000181ACB480
		public static UnityWebRequestAsyncOperationAwaiter GetAwaiter(this UnityWebRequestAsyncOperation asyncOperation); // 0x0000000181ACBDA0-0x0000000181ACBE40
		public static UniTask<UnityWebRequest> ToUniTask(this UnityWebRequestAsyncOperation asyncOperation); // 0x0000000181ACD240-0x0000000181ACD460
		public static UniTask<UnityWebRequest> ConfigureAwait(this UnityWebRequestAsyncOperation asyncOperation, IProgress<float> progress = null, PlayerLoopTiming timing = PlayerLoopTiming.Update /* Metadata: 0x007780CE */, CancellationToken cancellation = default); // 0x0000000181ACAEC0-0x0000000181ACB000
		public static AsyncUnityEventHandler GetAsyncEventHandler(this UnityEvent unityEvent, CancellationToken cancellationToken); // 0x0000000181ACB7A0-0x0000000181ACB810
		public static UniTask OnInvokeAsync(this UnityEvent unityEvent, CancellationToken cancellationToken); // 0x0000000181ACC540-0x0000000181ACC5C0
		public static IAsyncClickEventHandler GetAsyncClickEventHandler(this Button button); // 0x0000000181ACB5F0-0x0000000181ACB680
		public static IAsyncClickEventHandler GetAsyncClickEventHandler(this Button button, CancellationToken cancellationToken); // 0x0000000181ACB570-0x0000000181ACB5F0
		public static UniTask OnClickAsync(this Button button); // 0x0000000181ACC310-0x0000000181ACC3B0
		public static UniTask OnClickAsync(this Button button, CancellationToken cancellationToken); // 0x0000000181ACC280-0x0000000181ACC310
		public static IAsyncValueChangedEventHandler<bool> GetAsyncValueChangedEventHandler(this Toggle toggle); // 0x0000000181ACB8A0-0x0000000181ACB930
		public static IAsyncValueChangedEventHandler<bool> GetAsyncValueChangedEventHandler(this Toggle toggle, CancellationToken cancellationToken); // 0x0000000181ACBD10-0x0000000181ACBDA0
		public static UniTask<bool> OnValueChangedAsync(this Toggle toggle); // 0x0000000181ACC740-0x0000000181ACC810
		public static UniTask<bool> OnValueChangedAsync(this Toggle toggle, CancellationToken cancellationToken); // 0x0000000181ACC680-0x0000000181ACC740
		public static IAsyncValueChangedEventHandler<float> GetAsyncValueChangedEventHandler(this Scrollbar scrollbar); // 0x0000000181ACBAD0-0x0000000181ACBB60
		public static IAsyncValueChangedEventHandler<float> GetAsyncValueChangedEventHandler(this Scrollbar scrollbar, CancellationToken cancellationToken); // 0x0000000181ACBBF0-0x0000000181ACBC80
		public static UniTask<float> OnValueChangedAsync(this Scrollbar scrollbar); // 0x0000000181ACCB20-0x0000000181ACCBF0
		public static UniTask<float> OnValueChangedAsync(this Scrollbar scrollbar, CancellationToken cancellationToken); // 0x0000000181ACC5C0-0x0000000181ACC680
		public static IAsyncValueChangedEventHandler<Vector2> GetAsyncValueChangedEventHandler(this ScrollRect scrollRect); // 0x0000000181ACBB60-0x0000000181ACBBF0
		public static IAsyncValueChangedEventHandler<Vector2> GetAsyncValueChangedEventHandler(this ScrollRect scrollRect, CancellationToken cancellationToken); // 0x0000000181ACB9C0-0x0000000181ACBA40
		public static UniTask<Vector2> OnValueChangedAsync(this ScrollRect scrollRect); // 0x0000000181ACC9A0-0x0000000181ACCA60
		public static UniTask<Vector2> OnValueChangedAsync(this ScrollRect scrollRect, CancellationToken cancellationToken); // 0x0000000181ACCA60-0x0000000181ACCB20
		public static IAsyncValueChangedEventHandler<float> GetAsyncValueChangedEventHandler(this Slider slider); // 0x0000000181ACB810-0x0000000181ACB8A0
		public static IAsyncValueChangedEventHandler<float> GetAsyncValueChangedEventHandler(this Slider slider, CancellationToken cancellationToken); // 0x0000000181ACBA40-0x0000000181ACBAD0
		public static UniTask<float> OnValueChangedAsync(this Slider slider); // 0x0000000181ACC8D0-0x0000000181ACC9A0
		public static UniTask<float> OnValueChangedAsync(this Slider slider, CancellationToken cancellationToken); // 0x0000000181ACC810-0x0000000181ACC8D0
		public static IAsyncEndEditEventHandler<string> GetAsyncEndEditEventHandler(this InputField inputField); // 0x0000000181ACB680-0x0000000181ACB710
		public static IAsyncEndEditEventHandler<string> GetAsyncEndEditEventHandler(this InputField inputField, CancellationToken cancellationToken); // 0x0000000181ACB710-0x0000000181ACB7A0
		public static UniTask<string> OnEndEditAsync(this InputField inputField); // 0x0000000181ACC3B0-0x0000000181ACC480
		public static UniTask<string> OnEndEditAsync(this InputField inputField, CancellationToken cancellationToken); // 0x0000000181ACC480-0x0000000181ACC540
		public static IAsyncValueChangedEventHandler<int> GetAsyncValueChangedEventHandler(this Dropdown dropdown); // 0x0000000181ACB930-0x0000000181ACB9C0
		public static IAsyncValueChangedEventHandler<int> GetAsyncValueChangedEventHandler(this Dropdown dropdown, CancellationToken cancellationToken); // 0x0000000181ACBC80-0x0000000181ACBD10
		public static UniTask<int> OnValueChanged(this Dropdown dropdown); // 0x0000000181ACCBF0-0x0000000181ACCCC0
		public static UniTask<int> OnValueChanged(this Dropdown dropdown, CancellationToken cancellationToken); // 0x0000000181ACCCC0-0x0000000181ACCD80
	}
}
