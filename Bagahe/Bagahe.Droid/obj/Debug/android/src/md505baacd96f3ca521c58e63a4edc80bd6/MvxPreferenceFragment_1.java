package md505baacd96f3ca521c58e63a4edc80bd6;


public abstract class MvxPreferenceFragment_1
	extends mvvmcross.droid.fragments.MvxPreferenceFragment
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("MvvmCross.Droid.Views.Fragments.MvxPreferenceFragment`1, MvvmCross.Droid, Version=5.2.0.0, Culture=neutral, PublicKeyToken=null", MvxPreferenceFragment_1.class, __md_methods);
	}


	public MvxPreferenceFragment_1 () throws java.lang.Throwable
	{
		super ();
		if (getClass () == MvxPreferenceFragment_1.class)
			mono.android.TypeManager.Activate ("MvvmCross.Droid.Views.Fragments.MvxPreferenceFragment`1, MvvmCross.Droid, Version=5.2.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
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
