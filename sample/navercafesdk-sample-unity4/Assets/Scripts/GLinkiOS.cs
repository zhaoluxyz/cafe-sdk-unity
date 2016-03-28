// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 4.0.30319.1
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------
using System;
using AOT;
using System.Runtime.InteropServices;

public class GLinkiOS : IGLink
{
	#if UNITY_IPHONE
	[DllImport("__Internal")]
	public static extern void _InitGLink(string consumerKey, string consumerSecret, int cafeId);
	
	[DllImport("__Internal")]
	public static extern void _ExecuteMain();
	
	[DllImport("__Internal")]
	public static extern void _ExecuteArticlePost(int menuId, string subject, string content);
	
	[DllImport("__Internal")]
	public static extern void _ExecuteArticlePostWithImage(int menuId, string subject, string content, string filePath);
	
	[DllImport("__Internal")]
	public static extern void _ExecuteArticlePostWithVideo(int menuId, string subject, string content, string filePath);
	
	[DllImport("__Internal")]
	public static extern void _ExecuteNotice();
	
	[DllImport("__Internal")]
	public static extern void _ExecuteEvent();
	
	[DllImport("__Internal")]
	public static extern void _ExecuteMenu();
	
	[DllImport("__Internal")]
	public static extern void _ExecuteProfile();
	
	[DllImport("__Internal")]
	public static extern void _ExecuteArticle(int articleId);
	
	[DllImport("__Internal")]
	public static extern void _SetGameUserId(string gameUserId, string fieldName);
	
	[DllImport("__Internal")]
	private static extern void _ShowMessageToast(string message);
	
	[DllImport("__Internal")]
	private static extern void _SetSDKDidLoadDelegate(NCSDKDidLoadDelegate callback);
	[DllImport("__Internal")]
	private static extern void _SetSDKDidUnLoadDelegate(NCSDKDidUnLoadDelegate callback);
	[DllImport("__Internal")]
	private static extern void _SetSDKJoinedCafeDelegate(NCSDKJoinedCafeDelegate callback);
	[DllImport("__Internal")]
	private static extern void _SetSDKPostedArticleAtMenuDelegate(NCSDKPostedArticleAtMenuDelegate callback);
	[DllImport("__Internal")]
	private static extern void _SetSDKPostedCommentAtArticleDelegate(NCSDKPostedCommentAtArticleDelegate callback);
	#endif
	
	#if UNITY_IPHONE
	delegate void NCSDKDidLoadDelegate();
	[MonoPInvokeCallback(typeof(NCSDKDidLoadDelegate))]
	public static void _NCSDKDidLoadCallback () {
		_ShowMessageToast ("Did Load sdk");
	}
	
	delegate void NCSDKDidUnLoadDelegate();
	[MonoPInvokeCallback(typeof(NCSDKDidUnLoadDelegate))]
	public static void _NCSDKDidUnLoadCallback () {
		_ShowMessageToast ("Did UnLoad sdk");
	}
	
	delegate void NCSDKJoinedCafeDelegate();
	[MonoPInvokeCallback(typeof(NCSDKJoinedCafeDelegate))]
	public static void _NCSDKJoinedCafeCallback () {
		_ShowMessageToast ("Joined Cafe");
	}
	delegate void NCSDKPostedArticleAtMenuDelegate(int menuId);
	[MonoPInvokeCallback(typeof(NCSDKPostedArticleAtMenuDelegate))]
	public static void _NCSDKPostedArticleAtMenuCallback (int menuId) {
		_ShowMessageToast ("Posted Article at " + menuId);
	}
	delegate void NCSDKPostedCommentAtArticleDelegate(int articleId);
	[MonoPInvokeCallback(typeof(NCSDKPostedCommentAtArticleDelegate))]
	public static void _NCSDKPostedCommentAtArticleCallback (int articleId) {
		_ShowMessageToast ("Posted Comment at " + articleId);
	}
	
	#endif
	
	public GLinkiOS() {
		#if UNITY_IPHONE
		_InitGLink(GLinkConfig.NaverLoginClientId, GLinkConfig.NaverLoginClientSecret, GLinkConfig.CafeId);
		
		//set callback funcs
		_SetSDKDidLoadDelegate(_NCSDKDidLoadCallback);
		_SetSDKDidUnLoadDelegate(_NCSDKDidUnLoadCallback);
		_SetSDKJoinedCafeDelegate(_NCSDKDidUnLoadCallback);
		_SetSDKPostedArticleAtMenuDelegate(_NCSDKPostedArticleAtMenuCallback);
		_SetSDKPostedCommentAtArticleDelegate(_NCSDKPostedCommentAtArticleCallback);
		#endif
	}
	
	
	public void executeHome() {
		#if UNITY_IPHONE 
		_ExecuteMain ();
		#endif
	}
	
	public void executeNotice() {
		#if UNITY_IPHONE 
		_ExecuteNotice ();
		#endif
	}
	
	public void executeEvent() {
		#if UNITY_IPHONE 
		_ExecuteEvent ();
		#endif
	}
	
	public void executeMenu() {
		#if UNITY_IPHONE 
		_ExecuteMenu ();
		#endif
	}
	
	public void executeProfile() {
		#if UNITY_IPHONE 
		_ExecuteProfile ();
		#endif
	}
	
	public void executeArticle (int articleId) {
		#if UNITY_IPHONE 
		_ExecuteArticle (articleId);
		#endif
	}
	
	public void executeArticlePost(int menuId, string subject, string content) {
		#if UNITY_IPHONE
		_ExecuteArticlePost(menuId, subject, content);
		#endif
	}
	
	public void executeArticlePostWithImage(int menuId, string subject, string content, string filePath) {
		#if UNITY_IPHONE
		_ExecuteArticlePostWithImage(menuId, subject, content, filePath);
		#endif
	}
	
	public void executeArticlePostWithVideo(int menuId, string subject, string content, string filePath) {
		#if UNITY_IPHONE
		_ExecuteArticlePostWithVideo(menuId, subject, content, filePath);
		#endif
	}
	
	public void setGameUserId (string gameUserId, string fieldName) {
		#if UNITY_IPHONE 
		_SetGameUserId(gameUserId, fieldName);
		#endif
	}
}
