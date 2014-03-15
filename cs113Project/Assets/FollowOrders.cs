using UnityEngine;
using System.Collections;

public class FollowOrders : MonoBehaviour {


	public Texture c133;
	public Texture c134;
	public Texture c135;
	public Texture c136;
	public Texture c137;
	public Texture c138;
	public Texture c139;
	public Texture c140;
	public Texture c141;
	public Texture c142;











	public bool inc133 = false;
	public bool inc134 = false;
	public bool inc135 = false;
	public bool inc136 = false;
	public bool inc137 = false;
	public bool inc138 = false;
	public bool inc139 = false;
	public bool inc140 = false;
	public bool inc141 = false;
	public bool inc142 = false;








	private bool nextButton;

	public Rect rect;


	// Use this for initialization
	void Start () {
	


		inc133 = true;
		inc134 = false;
		inc135 = false;
		inc136 = false;
		inc137 = false;
		inc138 = false;
		inc139 = false;
		inc140 = false;
		inc141 = false;
		inc142 = false;


		nextButton = false;


	}
	
	// Update is called once per frame
	void Update () {
	
	}



	void OnGUI()
	{
		rect = new Rect(0.0f, 0.0f, Screen.width, Screen.height);




		if(inc133 == true)
		{
			GUI.DrawTexture (rect, c133);
			nextButton = GUI.Button(new Rect(Screen.width - 170,Screen.height - 170,100,50),"Next");
			

			
		}
		
		if(nextButton)//  
		{
			inc133 = false;
			inc134 = true;
			
			nextButton = false;
			

			
		}




		if(inc134 == true)
		{
			GUI.DrawTexture (rect, c134);
			nextButton = GUI.Button(new Rect(Screen.width - 170,Screen.height - 170,100,50),"Next");
			
			
			
		}
		
		if(nextButton)//  
		{
			inc134 = false;
			inc135 = true;
			
			nextButton = false;
			
			
			
		}





		if(inc135 == true)
		{
			GUI.DrawTexture (rect, c135);
			nextButton = GUI.Button(new Rect(Screen.width - 170,Screen.height - 170,100,50),"Next");
			
			
			
		}
		
		if(nextButton)//  
		{
			inc135 = false;
			inc136 = true;
			
			nextButton = false;
			
			
			
		}




		if(inc136 == true)
		{
			GUI.DrawTexture (rect, c136);
			nextButton = GUI.Button(new Rect(Screen.width - 170,Screen.height - 170,100,50),"Next");
			
			
			
		}
		
		if(nextButton)//  
		{
			inc136 = false;
			inc137 = true;
			
			nextButton = false;
			
			
			
		}




		if(inc137 == true)
		{
			GUI.DrawTexture (rect, c137);
			nextButton = GUI.Button(new Rect(Screen.width - 170,Screen.height - 170,100,50),"Next");
			
			
			
		}
		
		if(nextButton)//  
		{
			inc137 = false;
			inc138 = true;
			
			nextButton = false;
			
			
			
		}



		if(inc138 == true)
		{
			GUI.DrawTexture (rect, c138);
			nextButton = GUI.Button(new Rect(Screen.width - 170,Screen.height - 170,100,50),"Next");
			
			
			
		}
		
		if(nextButton)//  
		{
			inc138 = false;
			inc139 = true;
			
			nextButton = false;
			
			
			
		}



		if(inc139 == true)
		{
			GUI.DrawTexture (rect, c139);
			nextButton = GUI.Button(new Rect(Screen.width - 170,Screen.height - 170,100,50),"Next");
			
			
			
		}
		
		if(nextButton)//  
		{
			inc139 = false;
			inc140 = true;
			
			nextButton = false;
			
			
			
		}





		if(inc140 == true)
		{
			GUI.DrawTexture (rect, c140);
			nextButton = GUI.Button(new Rect(Screen.width - 170,Screen.height - 170,100,50),"Next");
			
			
			
		}
		
		if(nextButton)//  
		{
			inc140 = false;
			inc141 = true;
			
			nextButton = false;
			
			
			
		}




		if(inc141 == true)
		{
			GUI.DrawTexture (rect, c141);
			nextButton = GUI.Button(new Rect(Screen.width - 170,Screen.height - 170,100,50),"Next");
			
			
			
		}
		
		if(nextButton)//  
		{
			inc141 = false;
			inc142 = true;
			
			nextButton = false;
			
			
			
		}




		if(inc142 == true)
		{
			GUI.DrawTexture (rect, c142);
			nextButton = GUI.Button(new Rect(Screen.width - 170,Screen.height - 170,100,50),"Credits");
			
			
			
		}
		
		if(nextButton)//  
		{
			//inc141 = false;
			//inc142 = true;
			Application.LoadLevel ("Menu");//Change to credits later
			nextButton = false;
			
			
			
		}














	}















}
