package md50043c6abe046f49eb0ac5d269e1a18a5;


public class MvxImageViewRenderer
	extends md5b60ffeb829f638581ab2bb9b1a7f4f3f.ImageRenderer
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("MvvmCross.Forms.Droid.Views.Renderers.MvxImageViewRenderer, MvvmCross.Forms.Droid, Version=5.2.0.0, Culture=neutral, PublicKeyToken=null", MvxImageViewRenderer.class, __md_methods);
	}


	public MvxImageViewRenderer (android.content.Context p0, android.util.AttributeSet p1, int p2) throws java.lang.Throwable
	{
		super (p0, p1, p2);
		if (getClass () == MvxImageViewRenderer.class)
			mono.android.TypeManager.Activate ("MvvmCross.Forms.Droid.Views.Renderers.MvxImageViewRenderer, MvvmCross.Forms.Droid, Version=5.2.0.0, Culture=neutral, PublicKeyToken=null", "Android.Content.Context, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065:Android.Util.IAttributeSet, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065:System.Int32, mscorlib, Version=2.0.5.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e", this, new java.lang.Object[] { p0, p1, p2 });
	}


	public MvxImageViewRenderer (android.content.Context p0, android.util.AttributeSet p1) throws java.lang.Throwable
	{
		super (p0, p1);
		if (getClass () == MvxImageViewRenderer.class)
			mono.android.TypeManager.Activate ("MvvmCross.Forms.Droid.Views.Renderers.MvxImageViewRenderer, MvvmCross.Forms.Droid, Version=5.2.0.0, Culture=neutral, PublicKeyToken=null", "Android.Content.Context, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065:Android.Util.IAttributeSet, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065", this, new java.lang.Object[] { p0, p1 });
	}


	public MvxImageViewRenderer (android.content.Context p0) throws java.lang.Throwable
	{
		super (p0);
		if (getClass () == MvxImageViewRenderer.class)
			mono.android.TypeManager.Activate ("MvvmCross.Forms.Droid.Views.Renderers.MvxImageViewRenderer, MvvmCross.Forms.Droid, Version=5.2.0.0, Culture=neutral, PublicKeyToken=null", "Android.Content.Context, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065", this, new java.lang.Object[] { p0 });
	}

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
