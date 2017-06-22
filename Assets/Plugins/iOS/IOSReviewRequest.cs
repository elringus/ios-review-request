using UnityEngine;
#if UNITY_IOS && !UNITY_EDITOR
using System.Runtime.InteropServices;
#endif

/// <summary>
/// Wrapper to call a native iOS review request.
/// Requires iOS version 10.3 or higher.
/// </summary>
public static class IOSReviewRequest
{
    #if UNITY_IOS && !UNITY_EDITOR
    [DllImport("__Internal")]
    private static extern void RequestReviewInternal();
    #endif

    public static void RequestReview ()
    {
        #if UNITY_IOS && !UNITY_EDITOR
        RequestReviewInternal();
        #else
        Debug.Log("Native iOS review request wasn't performed due to incompatible platform.");
        #endif
    }
}
