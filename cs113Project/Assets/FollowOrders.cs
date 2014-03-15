using UnityEngine;
using System.Collections;

public class FollowOrders : MonoBehaviour {


	//Sketches
	public Texture sketch1;
	public Texture sketch2;
	public Texture sketch3;//sketch 17 winter
	public Texture sketch3ver2; //sketch 17 winter version 2
	public Texture sketch4spring;
	public Texture sketch4summer;
	public Texture sketch4winter;
	public Texture sketch5spring;
	public Texture sketch5summer;
	public Texture sketch5winter;
	public Texture sketch6spring;
	public Texture sketch6summer;
	public Texture sketch6winter;
	public Texture sketch7yr1944winter;
	public Texture sketch7yr1944;
	public Texture sketch7yr2242;
	public Texture sketch7yr2242ver2;
	public Texture sketch7yr2242ver3;
	public Texture sketch10;
	public Texture sketch11;
	public Texture sketch13;
	public Texture sketch13ver2;
	public Texture sketch14;
	public Texture sketch15;
	public Texture sketch15ver2;
	public Texture sketch16;
	public Texture sketch16ver2;
	public Texture sketch17;//sketch 17 summer
	public Texture sketch17ver2;
	public Texture sketch18;
	public Texture sketch18ver2;
	public Texture sketch18ver3;
	public Texture sketch18ver4;
	public Texture sketch19;
	public Texture sketch19ver2;
	public Texture sketch20;
	public Texture sketch20night;
	public Texture sketch20ver2;
	public Texture sketch21;



	//Subtitles
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








	public bool insketch1 = false;
	public bool insketch2 = false;
	public bool insketch3 = false;//sketch 17 winter
	public bool insketch3ver2 = false; //sketch 17 winter version 2
	public bool insketch4spring = false;
	public bool insketch4summer = false;
	public bool insketch4winter = false;
	public bool insketch5spring = false;
	public bool insketch5summer = false;
	public bool insketch5winter = false;
	public bool insketch6spring = false;
	public bool insketch6summer = false;
	public bool insketch6winter = false;
	public bool insketch7yr1944winter = false;
	public bool insketch7yr1944 = false;
	public bool insketch7yr2242 = false;
	public bool insketch7yr2242ver2 = false;
	public bool insketch7yr2242ver3 = false;
	public bool insketch10 = false;
	public bool insketch11 = false;
	public bool insketch13 = false;
	public bool insketch13ver2 = false;
	public bool insketch14 = false;
	public bool insketch15 = false;
	public bool insketch15ver2 = false;
	public bool insketch16 = false;
	public bool insketch16ver2 = false;
	public bool insketch17 = false;//sketch 17 summer
	public bool insketch17ver2 = false;
	public bool insketch18 = false;
	public bool insketch18ver2 = false;
	public bool insketch18ver3 = false;
	public bool insketch18ver4 = false;
	public bool insketch19 = false;
	public bool insketch19ver2 = false;
	public bool insketch20 = false;
	public bool insketch20night = false;
	public bool insketch20ver2 = false;
	public bool insketch21 = false;




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
	


		insketch1 = false;
		insketch2 = false;
		insketch3 = false;//sketch 17 winter
		insketch3ver2 = false; //sketch 17 winter version 2
		insketch4spring = false;
		insketch4summer = false;
		insketch4winter = false;
		insketch5spring = false;
		insketch5summer = false;
		insketch5winter = false;
		insketch6spring = false;
		insketch6summer = false;
		insketch6winter = false;
		insketch7yr1944winter = false;
		insketch7yr1944 = false;
		insketch7yr2242 = false;
		insketch7yr2242ver2 = false;
		insketch7yr2242ver3 = false;
		insketch10 = false;
		insketch11 = false;
		insketch13 = false;
		insketch13ver2 = false;
		insketch14 = false;
		insketch15 = false;
		insketch15ver2 = false;
		insketch16 = false;
		insketch16ver2 = false;
		insketch17 = false;//sketch 17 summer
		insketch17ver2 = false;
		insketch18 = false;
		insketch18ver2 = false;
		insketch18ver3 = false;
		insketch18ver4 = false;
		insketch19 = false;
		insketch19ver2 = false;
		insketch20 = false;
		insketch20night = false;
		insketch20ver2 = false;
		insketch21 = false;



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
			GUI.DrawTexture (rect, sketch18ver2);
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
			GUI.DrawTexture (rect, sketch18ver2);
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
			GUI.DrawTexture (rect, sketch18ver3);
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
			GUI.DrawTexture (rect, sketch11);
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
			GUI.DrawTexture (rect, sketch7yr2242ver2);
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
			GUI.DrawTexture (rect, sketch13ver2);
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
			GUI.DrawTexture (rect, sketch14);
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
			GUI.DrawTexture (rect, sketch19ver2);
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
			GUI.DrawTexture (rect, sketch19ver2);
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
			GUI.DrawTexture (rect, sketch15ver2);
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
