using UnityEngine;
using System.Collections;

public class Radar : MonoBehaviour
{
	
	public enum RadarTypes : int {Textured, Round, Transparent};
	public enum RadarLocations : int {TopLeft, TopCenter, TopRight, BottomLeft, BottomCenter, BottomRight, Left, Center, Right, Custom};
	
	// Display Location
	public RadarLocations radarLocation;
	//public Vector2 radarLocationCustom;
	//public RadarTypes radarType = RadarTypes.Round;
	//public Color radarBackgroundA = new Color(255, 255, 0);
	//public Color radarBackgroundB = new Color(0, 255, 255);
	//public Texture2D radarTexture;
	public float radarSize = 0.20f;  // The amount of the screen the radar will use
	public float radarZoom = 0.60f;
	
	// Center Object information
	//public bool   radarCenterActive;
	//public Color  radarCenterColor = new Color(255, 255, 255);
	//public string radarCenterTag;
	
	// Blip information
	public bool   radarBlip1Active;
	public Color  radarBlip1Color = new Color(0, 0, 255);
	public string radarBlip1Tag;
	
	// Internal vars
	private GameObject _centerObject;
	private int        _radarWidth;
	private int        _radarHeight;
	//private Vector2    _radarCenter;
	//public Texture2D  _radarCenterTexture;
	private Texture2D  _radarBlip1Texture;
	
	// Initialize the radar
	void Start ()
	{
		// Determine the size of the radar
		_radarWidth = (int)(Screen.width * radarSize);
		_radarHeight = (int)(Screen.height * 0.03);
		
		// Get the location of the radar
		//setRadarLocation();
		//_radarCenter = new Vector2(Screen.width - _radarWidth / 2, Screen.height - _radarHeight / 2);
		
		// Create the blip textures
		//_radarCenterTexture = new Texture2D(3, 3, TextureFormat.RGB24, false);
		_radarBlip1Texture = new Texture2D(3, 3, TextureFormat.RGB24, false);
		
		//CreateBlipTexture(_radarCenterTexture, radarCenterColor);
		CreateBlipTexture(_radarBlip1Texture, radarBlip1Color);
		
		// Setup the radar background texture
		//if (radarType != RadarTypes.Textured)
		//{
		//radarTexture = new Texture2D(_radarWidth, _radarHeight, TextureFormat.RGB24, false);
		//CreateRoundTexture(radarTexture, radarBackgroundA, radarBackgroundB);
		//}
		
		// Get our center object
		//GameObject[] gos;
		//gos = GameObject.FindGameObjectsWithTag(radarCenterTag);
		_centerObject = GameObject.Find ("Player");
	}
	
	// Update is called once per frame
	void OnGUI ()
	{
		_radarWidth = (int)(Screen.width * radarSize);
		//_radarHeight = Screen.height * 0.03f;
		_radarHeight = (int)(Screen.height * 0.2);
		GameObject[] gos;
		
		// Draw the radar background
		//if (radarType != RadarTypes.Transparent)
		//{
		//	Rect radarRect = new Rect(getRadarLocation().x - _radarWidth / 2, getRadarLocation().y - _radarHeight / 2, _radarWidth, _radarHeight);
		//	if (radarTexture != null)
		//	GUI.DrawTexture(radarRect, radarTexture);
		//}
		
		// Draw blips
		if (radarBlip1Active)
		{
			// Find all game objects
			gos = GameObject.FindGameObjectsWithTag(radarBlip1Tag); 
			
			// Iterate through them and call drawBlip function
			foreach (GameObject go in gos)
			{
				drawBlip(go, _radarBlip1Texture);
			}
		}
		
		// Draw center oject
		//if (radarCenterActive)
		//{
		//	Rect centerRect = new Rect(getRadarLocation ().x, getRadarLocation ().y, 12, 12);
		//	GUI.DrawTexture(centerRect, _radarCenterTexture);
		//}
	}
	
	// Draw a blip for an object
	void drawBlip(GameObject go, Texture2D blipTexture)
	{
		if (_centerObject)
		{
			Vector3 centerPos = _centerObject.transform.position;
			Vector3 extPos = go.transform.position;
			
			// Get the distance to the object from the centerObject
			float dist = Vector3.Distance(centerPos, extPos);
			
			// Get the object's offset from the centerObject
			float bX = centerPos.x - extPos.x;
			float bY = centerPos.z - extPos.z;
			
			// Scale the objects position to fit within the radar
			bX = bX * radarZoom;
			bY = bY * radarZoom;
			
			// For a round radar, make sure we are within the circle
			if(dist <= (_radarWidth - 2) * 0.5 / radarZoom)
			{
				Rect clipRect = new Rect(getRadarLocation().x - bX - 1.5f, getRadarLocation().y + bY - 1.5f, 3, 3);
				GUI.DrawTexture(clipRect, blipTexture);
			}
		}
	}
	
	// Create the blip textures
	void CreateBlipTexture(Texture2D tex, Color c)
	{
		Color[] cols = {c, c, c, c, c, c, c, c, c};
		tex.SetPixels(cols, 0);
		tex.Apply();
	}
	
	// Create a round bullseye texture
	/*
	void CreateRoundTexture(Texture2D tex, Color a, Color b)
	{
		Color c = new Color(0, 0, 0);
		int size = (int)((_radarWidth / 2) / 4);
		
		// Clear the texture
		for (int x = 0; x < _radarWidth; x++)
		{
			for (int y = 0; y < _radarWidth; y++)
			{
				tex.SetPixel(x, y, c);
			}
		}
		
		for (int r = 4; r > 0; r--)
		{
			if (r % 2 == 0)
			{
				c = a;
			}
			else
			{
				c = b;
			}
			DrawFilledCircle(tex, (int)(_radarWidth / 2), (int)(_radarHeight / 2), (r * size), c);
		}
		
		tex.Apply();
	}
	
	// Draw a filled colored circle onto a texture
	void DrawFilledCircle(Texture2D tex, int cx, int cy, int r, Color c)
	{
		for (int x = -r; x < r ; x++)
		{
			int height = (int)Mathf.Sqrt(r * r - x * x);
			
			for (int y = -height; y < height; y++)
				tex.SetPixel(x + cx, y + cy, c);
		}
	}*/
	
	// Figure out where to put the radar
	/*
	void setRadarLocation()
	{
		// Sets radarCenter based on enum selection
		if(radarLocation == RadarLocations.TopLeft)
		{
			_radarCenter = new Vector2(_radarWidth / 2, _radarHeight / 2);
		}
		else if(radarLocation == RadarLocations.TopCenter)
		{
			_radarCenter = new Vector2(Screen.width / 2, _radarHeight / 2);
		}
		else if(radarLocation == RadarLocations.TopRight)
		{
			_radarCenter = new Vector2(Screen.width - _radarWidth / 2, _radarHeight / 2);
		}
		else if(radarLocation == RadarLocations.Left)
		{
			_radarCenter = new Vector2(_radarWidth / 2, Screen.height / 2);
		}
		else if(radarLocation == RadarLocations.Center)
		{
			_radarCenter = new Vector2(Screen.width / 2, Screen.height / 2);
		}
		else if(radarLocation == RadarLocations.Right)
		{
			_radarCenter = new Vector2(Screen.width - _radarWidth / 2, Screen.height / 2);
		}
		else if(radarLocation == RadarLocations.BottomLeft)
		{
			_radarCenter = new Vector2(_radarWidth / 2, Screen.height - _radarHeight / 2);
		}
		else if(radarLocation == RadarLocations.BottomCenter)
		{
			_radarCenter = new Vector2((Screen.width / 2) - 10, Screen.height - _radarHeight / 2);
		}
		else if(radarLocation == RadarLocations.BottomRight)
		{
			_radarCenter = new Vector2(Screen.width - _radarWidth / 2, Screen.height - _radarHeight / 2);
		}
		else if(radarLocation == RadarLocations.Custom)
		{
			_radarCenter = radarLocationCustom;
		}
	} */

	Vector2 getRadarLocation()
	{
		if(radarLocation == RadarLocations.BottomRight)
		{
			return new Vector2((Screen.width - _radarWidth / 2) - (Screen.width * .01f), (Screen.height - _radarHeight / 2) - (Screen.height * .04f));
		}
		return new Vector2 (0, 0);
	}	
}