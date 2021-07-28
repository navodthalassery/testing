package com.shiny.locations;


public class MotionActivityBroadcastReceiver
	extends crc643387a08acbe69b14.ShinyBroadcastReceiver
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("Shiny.Locations.MotionActivityBroadcastReceiver, Shiny.Locations", MotionActivityBroadcastReceiver.class, __md_methods);
	}


	public MotionActivityBroadcastReceiver ()
	{
		super ();
		if (getClass () == MotionActivityBroadcastReceiver.class)
			mono.android.TypeManager.Activate ("Shiny.Locations.MotionActivityBroadcastReceiver, Shiny.Locations", "", this, new java.lang.Object[] {  });
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
