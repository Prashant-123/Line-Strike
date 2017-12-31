using GoogleMobileAds.Api;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdScript : MonoBehaviour {

	private GameObject canv;
	private BannerView bannerAd;
	// Use this for initialization

	void OnEnable ()
	{
		showBannerAd();

		bannerAd.Hide ();
	}
	void Start () {
		//bannerAd.Destroy ();
		canv = GameObject.Find ("Canv");
        
		/*bannerAd.Hide ();
		if (canv.activeSelf == false)
			bannerAd.Hide ();
	*/}

	private void showBannerAd()
    {
		string adID = "ca-app-pub-5511572373186930/9851939809";

        //***For Testing in the Device***
    /*    AdRequest request = new AdRequest.Builder()
       .AddTestDevice(AdRequest.TestDeviceSimulator)       // Simulator.
       .AddTestDevice("2077ef9a63d2b398840261c8221a0c9b")  // My test device.
       .Build();
	*/
        //***For Production When Submit App***
        AdRequest request = new AdRequest.Builder().Build();

		bannerAd = new BannerView(adID, AdSize.SmartBanner, AdPosition.Top);

        bannerAd.LoadAd(request);

    }

    // Update is called once per frame
    void Update () {
		if (canv.activeSelf == true)
			bannerAd.Show ();
		}

	void OnDisable()
	{
		bannerAd.Hide ();
	}
}
