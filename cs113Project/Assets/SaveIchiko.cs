using UnityEngine;
using System.Collections;

public class SaveIchiko : MonoBehaviour {



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



	//Ichikos
	public Texture ichiko;
	public Texture ichikohair2;
	public Texture ichikoHandsBack;
	public Texture ichikoSmile;
	public Texture ichikoCloseEye;
	public Texture ichikoNewDress;
	public Texture ichikoNewDressver2;
	public Texture ichikoNewDressCloseEye;
	public Texture ichikoNewDressCloseEyever2;
	public Texture ichikoNewDressSmileCloseEyeNightver2;
	public Texture ichikoNormalHandsBackSmileCloseEye;


	//Subtitles
	public Texture c143;
	public Texture c144;
	public Texture c145;
	public Texture c146;
	public Texture c147;
	public Texture c148;
	public Texture c149;
	public Texture c150;
	public Texture c151;
	public Texture c152;
	public Texture c153;
	public Texture c154;
	public Texture c155;
	public Texture c156;
	public Texture c157;
	public Texture c158;
	public Texture c159;
	public Texture c160;
	public Texture c161;
	public Texture c162;
	public Texture c163;
	public Texture c164;
	public Texture c165;
	public Texture c166;
	public Texture c167;
	public Texture c168;
	public Texture c169;
	public Texture c170;
	public Texture c171;
	public Texture c172;
	public Texture c173;
	public Texture c174;
	public Texture c175;
	public Texture c176;
	public Texture c177;
	public Texture c178;
	public Texture c179;
	public Texture c180;
	public Texture c181;
	public Texture c182;
	public Texture c183;
	public Texture c184;
	public Texture c185;
	public Texture c186;
	public Texture c187;
	public Texture c188;
	public Texture c189;
	public Texture c190;
	public Texture c191;
	public Texture c192;
	public Texture c193;











	public bool inichiko = false;
	public bool inichikohair2 = false;
	public bool inichikoHandsBack = false;
	public bool inichikoSmile = false;
	public bool inichikoCloseEye = false;
	public bool inichikoNewDress = false;
	public bool inichikoNewDressver2 = false;
	public bool inichikoNewDressCloseEye = false;
	public bool inichikoNewDressCloseEyever2 = false;
	public bool inichikoNewDressSmileCloseEyeNightver2 = false;
	public bool inichikoNormalHandsBackSmileCloseEye = false;
	public bool inichikoNewDressSmileCloseEye = false;





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





	public bool inc143 = false;
	public bool inc144 = false;
	public bool inc145 = false;
	public bool inc146 = false;
	public bool inc147 = false;
	public bool inc148 = false;
	public bool inc149 = false;
	public bool inc150 = false;
	public bool inc151 = false;
	public bool inc152 = false;
	public bool inc153 = false;
	public bool inc154 = false;
	public bool inc155 = false;
	public bool inc156 = false;
	public bool inc157 = false;
	public bool inc158 = false;
	public bool inc159 = false;
	public bool inc160 = false;
	public bool inc161 = false;
	public bool inc162 = false;
	public bool inc163 = false;
	public bool inc164 = false;
	public bool inc165 = false;
	public bool inc166 = false;
	public bool inc167 = false;
	public bool inc168 = false;
	public bool inc169 = false;
	public bool inc170 = false;
	public bool inc171 = false;
	public bool inc172 = false;
	public bool inc173 = false;
	public bool inc174 = false;
	public bool inc175 = false;
	public bool inc176 = false;
	public bool inc177 = false;
	public bool inc178 = false;
	public bool inc179 = false;
	public bool inc180 = false;
	public bool inc181 = false;
	public bool inc182 = false;
	public bool inc183 = false;
	public bool inc184 = false;
	public bool inc185 = false;
	public bool inc186 = false;
	public bool inc187 = false;
	public bool inc188 = false;
	public bool inc189 = false;
	public bool inc190 = false;
	public bool inc191 = false;
	public bool inc192 = false;
	public bool inc193 = false;


	private bool nextButton;
	
	public Rect rect;



	// Use this for initialization
	void Start () {

		inichiko = false;
		inichikohair2 = false;
		inichikoHandsBack = false;
		inichikoSmile = false;
		inichikoCloseEye = false;
		inichikoNewDress = false;
		inichikoNewDressver2 = false;
		inichikoNewDressCloseEye = false;
		inichikoNewDressCloseEyever2 = false;
		inichikoNewDressSmileCloseEyeNightver2 = false;
		inichikoNormalHandsBackSmileCloseEye = false;
		inichikoNewDressSmileCloseEye = false;




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




		inc143 = true;
		inc144 = false;
		inc145 = false;
		inc146 = false;
		inc147 = false;
		inc148 = false;
		inc149 = false;
		inc150 = false;
		inc151 = false;
		inc152 = false;
		inc153 = false;
		inc154 = false;
		inc155 = false;
		inc156 = false;
		inc157 = false;
		inc158 = false;
		inc159 = false;
		inc160 = false;
		inc161 = false;
		inc162 = false;
		inc163 = false;
		inc164 = false;
		inc165 = false;
		inc166 = false;
		inc167 = false;
		inc168 = false;
		inc169 = false;
		inc170 = false;
		inc171 = false;
		inc172 = false;
		inc173 = false;
		inc174 = false;
		inc175 = false;
		inc176 = false;
		inc177 = false;
		inc178 = false;
		inc179 = false;
		inc180 = false;
		inc181 = false;
		inc182 = false;
		inc183 = false;
		inc184 = false;
		inc185 = false;
		inc186 = false;
		inc187 = false;
		inc188 = false;
		inc189 = false;
		inc190 = false;
		inc191 = false;
		inc192 = false;
		inc193 = false;

		nextButton = false;
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


	void OnGUI()
	{
		rect = new Rect(0.0f, 0.0f, Screen.width, Screen.height);




		if(inc143 == true)
		{
			GUI.DrawTexture (rect, sketch18ver2);
			//GUI.DrawTexture (rect, sketch1);
			GUI.DrawTexture (rect, c143);
			
			
			//
			nextButton = GUI.Button(new Rect(Screen.width - 170,Screen.height - 170,100,50),"Next");
			
		}
		
		if(nextButton) 
		{
			inc143 = false;
			inc144 = true;
			
			
			//
			//buttonPressed = false;
			nextButton = false;
			
		}




		if(inc144 == true)
		{
			GUI.DrawTexture (rect, sketch18ver2);
			//GUI.DrawTexture (rect, sketch1);
			GUI.DrawTexture (rect, c144);
			
			
			//
			nextButton = GUI.Button(new Rect(Screen.width - 170,Screen.height - 170,100,50),"Next");
			
		}
		
		if(nextButton) 
		{
			inc144 = false;
			inc145 = true;
			
			
			//
			//buttonPressed = false;
			nextButton = false;
			
		}



		if(inc145 == true)
		{
			GUI.DrawTexture (rect, sketch16ver2);
			GUI.DrawTexture (rect, ichiko);
			//GUI.DrawTexture (rect, sketch1);
			GUI.DrawTexture (rect, c145);
			
			
			//
			nextButton = GUI.Button(new Rect(Screen.width - 170,Screen.height - 170,100,50),"Next");
			
		}
		
		if(nextButton) 
		{
			inc145 = false;
			inc146 = true;
			
			
			//
			//buttonPressed = false;
			nextButton = false;
			
		}




		if(inc146 == true)
		{
			GUI.DrawTexture (rect, sketch16ver2);
			GUI.DrawTexture (rect, ichikoNormalHandsBackSmileCloseEye);
			//GUI.DrawTexture (rect, sketch1);
			GUI.DrawTexture (rect, c146);
			
			
			//
			nextButton = GUI.Button(new Rect(Screen.width - 170,Screen.height - 170,100,50),"Next");
			
		}
		
		if(nextButton) 
		{
			inc146 = false;
			inc147 = true;
			
			
			//
			//buttonPressed = false;
			nextButton = false;
			
		}




		if(inc147 == true)
		{
			GUI.DrawTexture (rect, sketch18ver3);
			//GUI.DrawTexture (rect, sketch1);
			GUI.DrawTexture (rect, c147);
			
			
			//
			nextButton = GUI.Button(new Rect(Screen.width - 170,Screen.height - 170,100,50),"Next");
			
		}
		
		if(nextButton) 
		{
			inc147 = false;
			inc148 = true;
			
			
			//
			//buttonPressed = false;
			nextButton = false;
			
		}




		if(inc148 == true)
		{
			GUI.DrawTexture (rect, sketch7yr2242ver3);
			GUI.DrawTexture (rect, ichiko);
			//GUI.DrawTexture (rect, sketch1);
			GUI.DrawTexture (rect, c148);
			
			
			//
			nextButton = GUI.Button(new Rect(Screen.width - 170,Screen.height - 170,100,50),"Next");
			
		}
		
		if(nextButton) 
		{
			inc148 = false;
			inc149 = true;
			
			
			//
			//buttonPressed = false;
			nextButton = false;
			
		}




		if(inc149 == true)
		{
			GUI.DrawTexture (rect, sketch7yr2242ver3);
			GUI.DrawTexture (rect, ichiko);
			//GUI.DrawTexture (rect, sketch1);
			GUI.DrawTexture (rect, c149);
			
			
			//
			nextButton = GUI.Button(new Rect(Screen.width - 170,Screen.height - 170,100,50),"Next");
			
		}
		
		if(nextButton) 
		{
			inc149 = false;
			inc150 = true;
			
			
			//
			//buttonPressed = false;
			nextButton = false;
			
		}




		if(inc150 == true)
		{
			GUI.DrawTexture (rect, sketch7yr2242ver3);
			GUI.DrawTexture (rect, ichiko);
			//GUI.DrawTexture (rect, sketch1);
			GUI.DrawTexture (rect, c150);
			
			
			//
			nextButton = GUI.Button(new Rect(Screen.width - 170,Screen.height - 170,100,50),"Next");
			
		}
		
		if(nextButton) 
		{
			inc150 = false;
			inc151 = true;
			
			
			//
			//buttonPressed = false;
			nextButton = false;
			
		}



		if(inc151 == true)
		{
			GUI.DrawTexture (rect, sketch7yr2242ver3);
			GUI.DrawTexture (rect, ichiko);
			//GUI.DrawTexture (rect, sketch1);
			GUI.DrawTexture (rect, c151);
			
			
			//
			nextButton = GUI.Button(new Rect(Screen.width - 170,Screen.height - 170,100,50),"Next");
			
		}
		
		if(nextButton) 
		{
			inc151 = false;
			inc152 = true;
			
			
			//
			//buttonPressed = false;
			nextButton = false;
			
		}



		if(inc152 == true)
		{
			GUI.DrawTexture (rect, sketch7yr2242ver3);
			GUI.DrawTexture (rect, ichiko);
			//GUI.DrawTexture (rect, sketch1);
			GUI.DrawTexture (rect, c152);
			
			
			//
			nextButton = GUI.Button(new Rect(Screen.width - 170,Screen.height - 170,100,50),"Next");
			
		}
		
		if(nextButton) 
		{
			inc152 = false;
			inc153 = true;
			
			
			//
			//buttonPressed = false;
			nextButton = false;
			
		}




		if(inc153 == true)
		{
			GUI.DrawTexture (rect, sketch7yr2242ver3);
			GUI.DrawTexture (rect, ichiko);
			//GUI.DrawTexture (rect, sketch1);
			GUI.DrawTexture (rect, c153);
			
			
			//
			nextButton = GUI.Button(new Rect(Screen.width - 170,Screen.height - 170,100,50),"Next");
			
		}
		
		if(nextButton) 
		{
			inc153 = false;
			inc154 = true;
			
			
			//
			//buttonPressed = false;
			nextButton = false;
			
		}




		if(inc154 == true)
		{
			GUI.DrawTexture (rect, sketch7yr2242ver3);
			GUI.DrawTexture (rect, ichikoSmile);
			//GUI.DrawTexture (rect, sketch1);
			GUI.DrawTexture (rect, c154);
			
			
			//
			nextButton = GUI.Button(new Rect(Screen.width - 170,Screen.height - 170,100,50),"Next");
			
		}
		
		if(nextButton) 
		{
			inc154 = false;
			inc155 = true;
			
			
			//
			//buttonPressed = false;
			nextButton = false;
			
		}




		if(inc155 == true)
		{
			//GUI.DrawTexture (rect, sketch7yr2242ver3);
			//GUI.DrawTexture (rect, sketch1);
			GUI.DrawTexture (rect, c155);
			
			
			//
			nextButton = GUI.Button(new Rect(Screen.width - 170,Screen.height - 170,100,50),"Next");
			
		}
		
		if(nextButton) 
		{
			inc155 = false;
			inc156 = true;
			
			
			//
			//buttonPressed = false;
			nextButton = false;
			
		}




		if(inc156 == true)
		{
			//GUI.DrawTexture (rect, sketch7yr2242ver3);
			//GUI.DrawTexture (rect, sketch1);
			GUI.DrawTexture (rect, c156);
			
			
			//
			nextButton = GUI.Button(new Rect(Screen.width - 170,Screen.height - 170,100,50),"Next");
			
		}
		
		if(nextButton) 
		{
			inc156 = false;
			inc157 = true;
			
			
			//
			//buttonPressed = false;
			nextButton = false;
			
		}




		if(inc157 == true)
		{
			//GUI.DrawTexture (rect, sketch7yr2242ver3);
			//GUI.DrawTexture (rect, sketch1);
			GUI.DrawTexture (rect, c157);
			
			
			//
			nextButton = GUI.Button(new Rect(Screen.width - 170,Screen.height - 170,100,50),"Next");
			
		}
		
		if(nextButton) 
		{
			inc157 = false;
			inc158 = true;
			
			
			//
			//buttonPressed = false;
			nextButton = false;
			
		}




		if(inc158 == true)
		{
			GUI.DrawTexture (rect, sketch18);
			//GUI.DrawTexture (rect, sketch1);
			GUI.DrawTexture (rect, c158);
			
			
			//
			nextButton = GUI.Button(new Rect(Screen.width - 170,Screen.height - 170,100,50),"Next");
			
		}
		
		if(nextButton) 
		{
			inc158 = false;
			inc159 = true;
			
			
			//
			//buttonPressed = false;
			nextButton = false;
			
		}




		if(inc159 == true)
		{
			GUI.DrawTexture (rect, sketch18);
			//GUI.DrawTexture (rect, sketch1);
			GUI.DrawTexture (rect, c159);
			
			
			//
			nextButton = GUI.Button(new Rect(Screen.width - 170,Screen.height - 170,100,50),"Next");
			
		}
		
		if(nextButton) 
		{
			inc159 = false;
			inc167 = true;//skip bonus mission
			
			
			//
			//buttonPressed = false;
			nextButton = false;
			
		}









		if(inc167 == true)
		{
			GUI.DrawTexture (rect, sketch14);
			//GUI.DrawTexture (rect, sketch1);
			GUI.DrawTexture (rect, c167);
			
			
			//
			nextButton = GUI.Button(new Rect(Screen.width - 170,Screen.height - 170,100,50),"Next");
			
		}
		
		if(nextButton) 
		{
			inc167 = false;
			inc168 = true;
			
			
			//
			//buttonPressed = false;
			nextButton = false;
			
		}




		if(inc168 == true)
		{
			GUI.DrawTexture (rect, sketch19);
			//GUI.DrawTexture (rect, sketch1);
			GUI.DrawTexture (rect, c168);
			
			
			//
			nextButton = GUI.Button(new Rect(Screen.width - 170,Screen.height - 170,100,50),"Next");
			
		}
		
		if(nextButton) 
		{
			inc168 = false;
			inc169 = true;
			
			
			//
			//buttonPressed = false;
			nextButton = false;
			
		}




		if(inc169 == true)
		{
			GUI.DrawTexture (rect, sketch19);
			//GUI.DrawTexture (rect, sketch1);
			GUI.DrawTexture (rect, c169);
			
			
			//
			nextButton = GUI.Button(new Rect(Screen.width - 170,Screen.height - 170,100,50),"Next");
			
		}
		
		if(nextButton) 
		{
			inc169 = false;
			inc170 = true;
			
			
			//
			//buttonPressed = false;
			nextButton = false;
			
		}




		if(inc170 == true)
		{
			GUI.DrawTexture (rect, sketch19);
			//GUI.DrawTexture (rect, sketch1);
			GUI.DrawTexture (rect, c170);
			
			
			//
			nextButton = GUI.Button(new Rect(Screen.width - 170,Screen.height - 170,100,50),"Next");
			
		}
		
		if(nextButton) 
		{
			inc170 = false;
			inc171 = true;
			
			
			//
			//buttonPressed = false;
			nextButton = false;
			
		}




		if(inc171 == true)
		{
			GUI.DrawTexture (rect, sketch19);
			//GUI.DrawTexture (rect, sketch1);
			GUI.DrawTexture (rect, c171);
			
			
			//
			nextButton = GUI.Button(new Rect(Screen.width - 170,Screen.height - 170,100,50),"Next");
			
		}
		
		if(nextButton) 
		{
			inc171 = false;
			inc172 = true;
			
			
			//
			//buttonPressed = false;
			nextButton = false;
			
		}




		if(inc172 == true)
		{
			GUI.DrawTexture (rect, sketch19);
			//GUI.DrawTexture (rect, sketch1);
			GUI.DrawTexture (rect, c172);
			
			
			//
			nextButton = GUI.Button(new Rect(Screen.width - 170,Screen.height - 170,100,50),"Next");
			
		}
		
		if(nextButton) 
		{
			inc172 = false;
			inc173 = true;
			
			
			//
			//buttonPressed = false;
			nextButton = false;
			
		}




		if(inc173 == true)
		{
			GUI.DrawTexture (rect, sketch19);
			//GUI.DrawTexture (rect, sketch1);
			GUI.DrawTexture (rect, c173);
			
			
			//
			nextButton = GUI.Button(new Rect(Screen.width - 170,Screen.height - 170,100,50),"Next");
			
		}
		
		if(nextButton) 
		{
			inc173 = false;
			inc174 = true;
			
			
			//
			//buttonPressed = false;
			nextButton = false;
			
		}




		if(inc174 == true)
		{
			GUI.DrawTexture (rect, sketch19);
			//GUI.DrawTexture (rect, sketch1);
			GUI.DrawTexture (rect, c174);
			
			
			//
			nextButton = GUI.Button(new Rect(Screen.width - 170,Screen.height - 170,100,50),"Next");
			
		}
		
		if(nextButton) 
		{
			inc174 = false;
			inc175 = true;
			
			
			//
			//buttonPressed = false;
			nextButton = false;
			
		}




		if(inc175 == true)
		{
			GUI.DrawTexture (rect, sketch19);
			//GUI.DrawTexture (rect, sketch1);
			GUI.DrawTexture (rect, c175);
			
			
			//
			nextButton = GUI.Button(new Rect(Screen.width - 170,Screen.height - 170,100,50),"Next");
			
		}
		
		if(nextButton) 
		{
			inc175 = false;
			inc176 = true;
			
			
			//
			//buttonPressed = false;
			nextButton = false;
			
		}




		if(inc176 == true)
		{
			GUI.DrawTexture (rect, sketch19);
			//GUI.DrawTexture (rect, sketch1);
			GUI.DrawTexture (rect, c176);
			
			
			//
			nextButton = GUI.Button(new Rect(Screen.width - 170,Screen.height - 170,100,50),"Next");
			
		}
		
		if(nextButton) 
		{
			inc176 = false;
			inc177 = true;
			
			
			//
			//buttonPressed = false;
			nextButton = false;
			
		}




		if(inc177 == true)
		{
			GUI.DrawTexture (rect, sketch19);
			//GUI.DrawTexture (rect, sketch1);
			GUI.DrawTexture (rect, c177);
			
			
			//
			nextButton = GUI.Button(new Rect(Screen.width - 170,Screen.height - 170,100,50),"Next");
			
		}
		
		if(nextButton) 
		{
			inc177 = false;
			inc178 = true;
			
			
			//
			//buttonPressed = false;
			nextButton = false;
			
		}




		if(inc178 == true)
		{
			GUI.DrawTexture (rect, sketch19);
			//GUI.DrawTexture (rect, sketch1);
			GUI.DrawTexture (rect, c178);
			
			
			//
			nextButton = GUI.Button(new Rect(Screen.width - 170,Screen.height - 170,100,50),"Next");
			
		}
		
		if(nextButton) 
		{
			inc178 = false;
			inc179 = true;
			
			
			//
			//buttonPressed = false;
			nextButton = false;
			
		}




		if(inc179 == true)
		{
			GUI.DrawTexture (rect, sketch19);
			//GUI.DrawTexture (rect, sketch1);
			GUI.DrawTexture (rect, c179);
			
			
			//
			nextButton = GUI.Button(new Rect(Screen.width - 170,Screen.height - 170,100,50),"Next");
			
		}
		
		if(nextButton) 
		{
			inc179 = false;
			inc180 = true;
			
			
			//
			//buttonPressed = false;
			nextButton = false;
			
		}




		if(inc180 == true)
		{
			GUI.DrawTexture (rect, sketch19);
			//GUI.DrawTexture (rect, sketch1);
			GUI.DrawTexture (rect, c180);
			
			
			//
			nextButton = GUI.Button(new Rect(Screen.width - 170,Screen.height - 170,100,50),"Next");
			
		}
		
		if(nextButton) 
		{
			inc180 = false;
			inc181 = true;
			
			
			//
			//buttonPressed = false;
			nextButton = false;
			
		}




		if(inc181 == true)
		{
			GUI.DrawTexture (rect, sketch19);
			//GUI.DrawTexture (rect, sketch1);
			GUI.DrawTexture (rect, c181);
			
			
			//
			nextButton = GUI.Button(new Rect(Screen.width - 170,Screen.height - 170,100,50),"Next");
			
		}
		
		if(nextButton) 
		{
			inc181 = false;
			inc182 = true;
			
			
			//
			//buttonPressed = false;
			nextButton = false;
			
		}




		if(inc182 == true)
		{
			GUI.DrawTexture (rect, sketch19);
			//GUI.DrawTexture (rect, sketch1);
			GUI.DrawTexture (rect, c182);
			
			
			//
			nextButton = GUI.Button(new Rect(Screen.width - 170,Screen.height - 170,100,50),"Next");
			
		}
		
		if(nextButton) 
		{
			inc182 = false;
			inc183 = true;
			
			
			//
			//buttonPressed = false;
			nextButton = false;
			
		}




		if(inc183 == true)
		{
			GUI.DrawTexture (rect, sketch19);
			//GUI.DrawTexture (rect, sketch1);
			GUI.DrawTexture (rect, c183);
			
			
			//
			nextButton = GUI.Button(new Rect(Screen.width - 170,Screen.height - 170,100,50),"Next");
			
		}
		
		if(nextButton) 
		{
			inc183 = false;
			inc184 = true;
			
			
			//
			//buttonPressed = false;
			nextButton = false;
			
		}




		if(inc184 == true)
		{
			GUI.DrawTexture (rect, sketch19);
			//GUI.DrawTexture (rect, sketch1);
			GUI.DrawTexture (rect, c184);
			
			
			//
			nextButton = GUI.Button(new Rect(Screen.width - 170,Screen.height - 170,100,50),"Next");
			
		}
		
		if(nextButton) 
		{
			inc184 = false;
			inc185 = true;
			
			
			//
			//buttonPressed = false;
			nextButton = false;
			
		}




		if(inc185 == true)
		{
			GUI.DrawTexture (rect, sketch20ver2);
			GUI.DrawTexture (rect, ichikoNewDress);
			//GUI.DrawTexture (rect, sketch1);
			GUI.DrawTexture (rect, c185);
			
			
			//
			nextButton = GUI.Button(new Rect(Screen.width - 170,Screen.height - 170,100,50),"Next");
			
		}
		
		if(nextButton) 
		{
			inc185 = false;
			inc186 = true;
			
			
			//
			//buttonPressed = false;
			nextButton = false;
			
		}




		if(inc186 == true)
		{
			GUI.DrawTexture (rect, sketch20ver2);
			GUI.DrawTexture (rect, ichikoNewDress);
			//GUI.DrawTexture (rect, sketch1);
			GUI.DrawTexture (rect, c186);
			
			
			//
			nextButton = GUI.Button(new Rect(Screen.width - 170,Screen.height - 170,100,50),"Next");
			
		}
		
		if(nextButton) 
		{
			inc186 = false;
			inc187 = true;
			
			
			//
			//buttonPressed = false;
			nextButton = false;
			
		}




		if(inc187 == true)
		{
			GUI.DrawTexture (rect, sketch20ver2);
			GUI.DrawTexture (rect, ichikoNewDress);
			//GUI.DrawTexture (rect, sketch1);
			GUI.DrawTexture (rect, c187);
			
			
			//
			nextButton = GUI.Button(new Rect(Screen.width - 170,Screen.height - 170,100,50),"Next");
			
		}
		
		if(nextButton) 
		{
			inc187 = false;
			inc188 = true;
			
			
			//
			//buttonPressed = false;
			nextButton = false;
			
		}




		if(inc188 == true)
		{
			GUI.DrawTexture (rect, sketch20night);
			GUI.DrawTexture (rect, ichikoNewDressver2);
			//GUI.DrawTexture (rect, sketch1);
			GUI.DrawTexture (rect, c188);
			
			
			//
			nextButton = GUI.Button(new Rect(Screen.width - 170,Screen.height - 170,100,50),"Next");
			
		}
		
		if(nextButton) 
		{
			inc188 = false;
			inc189 = true;
			
			
			//
			//buttonPressed = false;
			nextButton = false;
			
		}




		if(inc189 == true)
		{
			GUI.DrawTexture (rect, sketch20night);
			GUI.DrawTexture (rect, ichikoNewDressSmileCloseEyeNightver2);
			//GUI.DrawTexture (rect, sketch1);
			GUI.DrawTexture (rect, c189);
			
			
			//
			nextButton = GUI.Button(new Rect(Screen.width - 170,Screen.height - 170,100,50),"Next");
			
		}
		
		if(nextButton) 
		{
			inc189 = false;
			inc190 = true;
			
			
			//
			//buttonPressed = false;
			nextButton = false;
			
		}




		if(inc190 == true)
		{
			GUI.DrawTexture (rect, sketch20ver2);
			GUI.DrawTexture (rect, ichikoNewDressSmileCloseEyeNightver2);
			//GUI.DrawTexture (rect, sketch1);
			GUI.DrawTexture (rect, c190);
			
			
			//
			nextButton = GUI.Button(new Rect(Screen.width - 170,Screen.height - 170,100,50),"Next");
			
		}
		
		if(nextButton) 
		{
			inc190 = false;
			inc191 = true;
			
			
			//
			//buttonPressed = false;
			nextButton = false;
			
		}




		if(inc191 == true)
		{
			GUI.DrawTexture (rect, sketch20night);
			GUI.DrawTexture (rect, ichikoNewDressver2);
			//GUI.DrawTexture (rect, sketch1);
			GUI.DrawTexture (rect, c191);
			
			
			//
			nextButton = GUI.Button(new Rect(Screen.width - 170,Screen.height - 170,100,50),"Next");
			
		}
		
		if(nextButton) 
		{
			inc191 = false;
			inc192 = true;
			
			
			//
			//buttonPressed = false;
			nextButton = false;
			
		}




		if(inc192 == true)
		{
			GUI.DrawTexture (rect, sketch20night);
			GUI.DrawTexture (rect, ichikoNewDressver2);
			//GUI.DrawTexture (rect, sketch1);
			GUI.DrawTexture (rect, c192);
			
			
			//
			nextButton = GUI.Button(new Rect(Screen.width - 170,Screen.height - 170,100,50),"Next");
			
		}
		
		if(nextButton) 
		{
			inc192 = false;
			inc193 = true;
			
			
			//
			//buttonPressed = false;
			nextButton = false;
			
		}




		if(inc193 == true)
		{
			GUI.DrawTexture (rect, sketch20night);
			GUI.DrawTexture (rect, ichikoNewDressCloseEyever2);
			//GUI.DrawTexture (rect, sketch1);
			GUI.DrawTexture (rect, c193);
			
			
			//
			nextButton = GUI.Button(new Rect(Screen.width - 170,Screen.height - 170,100,50),"Next");
			
		}
		
		if(nextButton) 
		{


			Application.LoadLevel ("Menu");//Replace with credits later
			inc193 = false;
			//inc193 = true;
			
			
			//
			//buttonPressed = false;
			//nextButton = false;
			
		}
















	}









}
