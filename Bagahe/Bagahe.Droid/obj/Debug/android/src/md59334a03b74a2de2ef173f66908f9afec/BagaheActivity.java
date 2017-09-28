package md59334a03b74a2de2ef173f66908f9afec;


public class BagaheActivity
	extends md5a14effc50379407e80213156b97d32dc.MvxFormsAppCompatActivity
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"";
		mono.android.Runtime.register ("Bagahe.Droid.BagaheActivity, Bagahe.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", BagaheActivity.class, __md_methods);
	}


	public BagaheActivity () throws java.lang.Throwable
	{
		super ();
		if (getClass () == BagaheActivity.class)
			mono.android.TypeManager.Activate ("Bagahe.Droid.BagaheActivity, Bagahe.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);

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
