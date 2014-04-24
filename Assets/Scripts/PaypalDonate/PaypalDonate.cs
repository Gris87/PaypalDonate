using UnityEngine;
using System.Collections;

public class PaypalDonate : MonoBehaviour
{
	public Texture2D buttonImage;
	public float     screenX=0.5f;
	public float     screenY=0.5f;
	public string    buttonID;

	// Use this for initialization
	void Start ()
	{
		if (buttonID.Equals(""))
		{
			Debug.LogError("It is required to set donate button ID to use Paypal button");
			enabled=false;
		}
	}

	void OnGUI()
	{
	
	}
}
