package md5a14effc50379407e80213156b97d32dc;


public class MvxFormsAppCompatActivity
	extends md5b60ffeb829f638581ab2bb9b1a7f4f3f.FormsAppCompatActivity
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"n_onStart:()V:GetOnStartHandler\n" +
			"n_onStop:()V:GetOnStopHandler\n" +
			"n_onResume:()V:GetOnResumeHandler\n" +
			"n_onDestroy:()V:GetOnDestroyHandler\n" +
			"n_onPause:()V:GetOnPauseHandler\n" +
			"n_onRestart:()V:GetOnRestartHandler\n" +
			"";
		mono.android.Runtime.register ("MvvmCross.Forms.Droid.MvxFormsAppCompatActivity, MvvmCross.Forms.Droid, Version=5.2.0.0, Culture=neutral, PublicKeyToken=null", MvxFormsAppCompatActivity.class, __md_methods);
	}


	public MvxFormsAppCompatActivity () throws java.lang.Throwable
	{
		super ();
		if (getClass () == MvxFormsAppCompatActivity.class)
			mono.android.TypeManager.Activate ("MvvmCross.Forms.Droid.MvxFormsAppCompatActivity, MvvmCross.Forms.Droid, Version=5.2.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);


	public void onStart ()
	{
		n_onStart ();
	}

	private native void n_onStart ();


	public void onStop ()
	{
		n_onStop ();
	}

	private native void n_onStop ();


	public void onResume ()
	{
		n_onResume ();
	}

	private native void n_onResume ();


	public void onDestroy ()
	{
		n_onDestroy ();
	}

	private native void n_onDestroy ();


	public void onPause ()
	{
		n_onPause ();
	}

	private native void n_onPause ();


	public void onRestart ()
	{
		n_onRestart ();
	}

	private native void n_onRestart ();

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