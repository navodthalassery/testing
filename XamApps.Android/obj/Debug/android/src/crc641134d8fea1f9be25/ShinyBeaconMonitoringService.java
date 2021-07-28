package crc641134d8fea1f9be25;


public class ShinyBeaconMonitoringService
	extends crc64ebbe082751e200c1.ShinyAndroidForegroundService_2
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("Shiny.Beacons.ShinyBeaconMonitoringService, Shiny.Beacons", ShinyBeaconMonitoringService.class, __md_methods);
	}


	public ShinyBeaconMonitoringService ()
	{
		super ();
		if (getClass () == ShinyBeaconMonitoringService.class)
			mono.android.TypeManager.Activate ("Shiny.Beacons.ShinyBeaconMonitoringService, Shiny.Beacons", "", this, new java.lang.Object[] {  });
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
