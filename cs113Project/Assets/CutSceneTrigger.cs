using UnityEngine;
using System.Collections;

public class CutSceneTrigger : MonoBehaviour {

	//Ichikos
	public Texture ichiko;
	public Texture ichikohair2;
	public Texture ichikoHandsBack;
	public Texture ichikoSmile;
	public Texture ichikoCloseEye;
	public Texture ichikoNewDress;
	public Texture ichikoNewDressCloseEye;
	public Texture ichikoNormalHandsBackSmileCloseEye;


	//Sketches
	public Texture sketch1;
	public Texture sketch2;
	public Texture sketch3;//sketch 13 winter
	public Texture sketch4spring;
	public Texture sketch4summer;
	public Texture sketch4winter;
	public Texture sketch5spring;
	public Texture sketch5winter;
	public Texture sketch6summer;
	public Texture sketch7yr1944;
	public Texture sketch7yr2242;


	public Texture sketch10;
	public Texture sketch11;


	public Texture sketch14;
	public Texture sketch15;
	public Texture sketch16;
	public Texture sketch17;//sketch 17 summer
	public Texture sketch18;
	public Texture sketch19;
	public Texture sketch20;
	  
	//Subtitles
	public Texture c1;
	public Texture c2;
	public Texture c3;
	public Texture c4;
	public Texture c5;
	public Texture c6;
	public Texture c7;
	public Texture c8;
	public Texture c9;
	public Texture c10;
	public Texture c11;
	public Texture c12;
	public Texture c13;
	public Texture c14;
	public Texture c15;
	public Texture c16;
	public Texture c17;
	public Texture c18;
	public Texture c19;
	public Texture c20;
	public Texture c21;
	public Texture c22;
	public Texture c23;
	public Texture c24;
	public Texture c25;
	public Texture c26;
	public Texture c27;
	public Texture c28;
	public Texture c29;
	public Texture c30;
	public Texture c31;
	public Texture c32;
	public Texture c33;
	public Texture c34;
	public Texture c35;
	public Texture c36;
	public Texture c37;
	public Texture c38;
	public Texture c39;
	public Texture c40;
	public Texture c41;
	public Texture c42;
	public Texture c43;
	public Texture c44;
	public Texture c45;
	public Texture c46;
	public Texture c47;
	public Texture c48;
	public Texture c49;
	public Texture c50;
	public Texture c51;
	public Texture c52;
	public Texture c53;
	public Texture c54;
	public Texture c55;
	public Texture c56;
	public Texture c57;
	public Texture c58;
	public Texture c59;
	public Texture c60;
	public Texture c61;
	public Texture c62;
	public Texture c63;
	public Texture c64;
	public Texture c65;
	public Texture c66;
	public Texture c67;
	public Texture c68;
	public Texture c69;
	public Texture c70;
	public Texture c71;
	public Texture c72;
	public Texture c73;
	public Texture c74;
	public Texture c75;
	public Texture c76;
	public Texture c77;
	public Texture c78;
	public Texture c79;
	public Texture c80;
	public Texture c81;
	public Texture c82;
	public Texture c83;
	public Texture c84;
	public Texture c85;
	public Texture c86;
	public Texture c87;
	public Texture c88;
	public Texture c89;
	public Texture c90;
	public Texture c91;
	public Texture c92;
	public Texture c93;
	public Texture c94;
	public Texture c95;
	public Texture c96;
	public Texture c97;
	public Texture c98;
	public Texture c99;
	public Texture c100;
	public Texture c101;
	public Texture c102;
	public Texture c103;
	public Texture c104;
	public Texture c105;
	public Texture c106;
	public Texture c107;
	public Texture c108;
	public Texture c109;
	public Texture c110;
	public Texture c111;
	public Texture c112;
	public Texture c113;
	public Texture c114;
	public Texture c115;
	public Texture c116;
	public Texture c117;
	public Texture c118;
	public Texture c119;
	public Texture c120;
	public Texture c121;
	public Texture c122;
	public Texture c123;
	public Texture c124;
	public Texture c125;
	public Texture c126;
	public Texture c127;
	public Texture c128;
	public Texture c129;
	public Texture c130;
	public Texture c131;
	public Texture c132;
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


	//public Camera firstPersonCamera;
	//public Camera thirdPersonCamera;


	public bool inichiko = false;
	public bool inichikohair2 = false;
	public bool inichikoHandsBack = false;
	public bool inichikoSmile = false;
	public bool inichikoCloseEye = false;
	public bool inichikoNewDress = false;
	public bool inichikoNewDressCloseEye = false;
	public bool inichikoNormalHandsBackSmileCloseEye = false;




	public bool insketch1 = false;
	public bool insketch2 = false;
	public bool insketch3 = false;//sketch 13 winter
	public bool insketch4spring = false;
	public bool insketch4summer = false;
	public bool insketch4winter = false;
	public bool insketch5spring = false;
	public bool insketch5winter = false;
	public bool insketch6summer = false;
	public bool insketch7yr1944 = false;
	public bool insketch7yr2242 = false;
	
	
	public bool insketch10 = false;
	public bool insketch11 = false;
	
	
	public bool insketch14 = false;
	public bool insketch15 = false;
	public bool insketch16 = false;
	public bool insketch17 = false;//sketch 17 summer
	public bool insketch18 = false;
	public bool insketch19 = false;
	public bool insketch20 = false;







	public bool inc1 = false;
	public bool inc2 = false;
	public bool inc3 = false;
	public bool inc4 = false;
	public bool inc5 = false;
	public bool inc6 = false;
	public bool inc7 = false;
	public bool inc8 = false;
	public bool inc9 = false;
	public bool inc10 = false;
	public bool inc11 = false;
	public bool inc12 = false;
	public bool inc13 = false;
	public bool inc14 = false;
	public bool inc15 = false;
	public bool inc16 = false;
	public bool inc17 = false;
	public bool inc18 = false;
	public bool inc19 = false;
	public bool inc20 = false;
	public bool inc21 = false;
	public bool inc22 = false;
	public bool inc23 = false;
	public bool inc24 = false;
	public bool inc25 = false;
	public bool inc26 = false;
	public bool inc27 = false;
	public bool inc28 = false;
	public bool inc29 = false;
	public bool inc30 = false;
	public bool inc31 = false;
	public bool inc32 = false;
	public bool inc33 = false;
	public bool inc34 = false;
	public bool inc35 = false;
	public bool inc36 = false;
	public bool inc37 = false;
	public bool inc38 = false;
	public bool inc39 = false;
	public bool inc40 = false;
	public bool inc41 = false;
	public bool inc42 = false;
	public bool inc43 = false;
	public bool inc44 = false;
	public bool inc45 = false;
	public bool inc46 = false;
	public bool inc47 = false;
	public bool inc48 = false;
	public bool inc49 = false;
	public bool inc50 = false;
	public bool inc51 = false;
	public bool inc52 = false;
	public bool inc53 = false;
	public bool inc54 = false;
	public bool inc55 = false;
	public bool inc56 = false;
	public bool inc57 = false;
	public bool inc58 = false;
	public bool inc59 = false;
	public bool inc60 = false;
	public bool inc61 = false;
	public bool inc62 = false;
	public bool inc63 = false;
	public bool inc64 = false;
	public bool inc65 = false;
	public bool inc66 = false;
	public bool inc67 = false;
	public bool inc68 = false;
	public bool inc69 = false;
	public bool inc70 = false;
	public bool inc71 = false;
	public bool inc72 = false;
	public bool inc73 = false;
	public bool inc74 = false;
	public bool inc75 = false;
	public bool inc76 = false;
	public bool inc77 = false;
	public bool inc78 = false;
	public bool inc79 = false;
	public bool inc80 = false;
	public bool inc81 = false;
	public bool inc82 = false;
	public bool inc83 = false;
	public bool inc84 = false;
	public bool inc85 = false;
	public bool inc86 = false;
	public bool inc87 = false;
	public bool inc88 = false;
	public bool inc89 = false;
	public bool inc90 = false;
	public bool inc91 = false;
	public bool inc92 = false;
	public bool inc93 = false;
	public bool inc94 = false;
	public bool inc95 = false;
	public bool inc96 = false;
	public bool inc97 = false;
	public bool inc98 = false;
	public bool inc99 = false;
	public bool inc100 = false;
	public bool inc101 = false;
	public bool inc102 = false;
	public bool inc103 = false;
	public bool inc104 = false;
	public bool inc105 = false;
	public bool inc106 = false;
	public bool inc107 = false;
	public bool inc108 = false;
	public bool inc109 = false;
	public bool inc110 = false;
	public bool inc111 = false;
	public bool inc112 = false;
	public bool inc113 = false;
	public bool inc114 = false;
	public bool inc115 = false;
	public bool inc116 = false;
	public bool inc117 = false;
	public bool inc118 = false;
	public bool inc119 = false;
	public bool inc120 = false;
	public bool inc121 = false;
	public bool inc122 = false;
	public bool inc123 = false;
	public bool inc124 = false;
	public bool inc125 = false;
	public bool inc126 = false;
	public bool inc127 = false;
	public bool inc128 = false;
	public bool inc129 = false;
	public bool inc130 = false;
	public bool inc131 = false;
	public bool inc132 = false;
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

	//private float cutsceneNextTime = 0.0f;
	//private float cutsceneNextDelay = 2.0f;
	//Time curTime;
	//private float curTime = 0.0f;

	//private bool timeToShowCutscenes = true;
	private float cutscenesTimeDuration = 5.0f;



	public Rect rect;// = new Rect(Screen.width, Screen.height, 1320.0f, 1320.0f);
	//public Rect rect = new Rect(

	// Use this for initialization
	void Start () {
	


		inichiko = false;
		inichikohair2 = false;
		inichikoHandsBack = false;
		inichikoSmile = false;
		inichikoCloseEye = false;
		inichikoNewDress = false;
		inichikoNewDressCloseEye = false;
		inichikoNormalHandsBackSmileCloseEye = false;







		insketch1 = false;
		insketch2 = false;
		insketch3 = false;//sketch 13 winter
		insketch4spring = false;
		insketch4summer = false;
		insketch4winter = false;
		insketch5spring = false;
		insketch5winter = false;
		insketch6summer = false;
		insketch7yr1944 = false;
		insketch7yr2242 = false;
		
		
		insketch10 = false;
		insketch11 = false;
		
		
		insketch14 = false;
		insketch15 = false;
		insketch16 = false;
		insketch17 = false;//sketch 17 summer
		insketch18 = false;
		insketch19 = false;
		insketch20 = false;


		//inc12 = false;
		inc12 = true;
		inc13 = false;
		inc14 = false;
		inc15 = false;
		inc16 = false;
		inc17 = false;
		inc18 = false;
		inc19 = false;
		inc20 = false;
		inc21 = false;
		inc22 = false;
		inc23 = false;
		inc24 = false;
		inc25 = false;
		inc26 = false;
		inc27 = false;
		inc28 = false;
		inc29 = false;
		inc30 = false;
		inc31 = false;
		inc32 = false;
		inc33 = false;
		inc34 = false;
		inc35 = false;
		inc36 = false;
		inc37 = false;
		inc38 = false;
		inc39 = false;
		inc40 = false;
		inc41 = false;
		inc42 = false;
		inc43 = false;
		inc44 = false;
		inc45 = false;
		inc46 = false;
		inc47 = false;
		inc48 = false;
		inc49 = false;
		inc50 = false;
		inc51 = false;
		inc52 = false;
		inc53 = false;
		inc54 = false;
		inc55 = false;
		inc56 = false;
		inc57 = false;
		inc58 = false;
		inc59 = false;
		inc60 = false;
		inc61 = false;
		inc62 = false;
		inc63 = false;
		inc64 = false;
		inc65 = false;
		inc66 = false;
		inc67 = false;
		inc68 = false;
		inc69 = false;
		inc70 = false;
		inc71 = false;
		inc72 = false;
		inc73 = false;
		inc74 = false;
		inc75 = false;
		inc76 = false;
		inc77 = false;
		inc78 = false;
		inc79 = false;
		inc80 = false;
		inc81 = false;
		inc82 = false;
		inc83 = false;
		inc84 = false;
		inc85 = false;
		inc86 = false;
		inc87 = false;
		inc88 = false;
		inc89 = false;
		inc90 = false;
		inc91 = false;
		inc92 = false;
		inc93 = false;
		inc94 = false;
		inc95 = false;
		inc96 = false;
		inc97 = false;
		inc98 = false;
		inc99 = false;
		inc100 = false;
		inc101 = false;
		inc102 = false;
		inc103 = false;
		inc104 = false;
		inc105 = false;
		inc106 = false;
		inc107 = false;
		inc108 = false;
		inc109 = false;
		inc110 = false;
		inc111 = false;
		inc112 = false;
		inc113 = false;
		inc114 = false;
		inc115 = false;
		inc116 = false;
		inc117 = false;
		inc118 = false;
		inc119 = false;
		inc120 = false;
		inc121 = false;
		inc122 = false;
		inc123 = false;
		inc124 = false;
		inc125 = false;
		inc126 = false;
		inc127 = false;
		inc128 = false;
		inc129 = false;
		inc130 = false;
		inc131 = false;
		inc132 = false;
		inc133 = false;
		inc134 = false;
		inc135 = false;
		inc136 = false;
		inc137 = false;
		inc138 = false;
		inc139 = false;
		inc140 = false;
		inc141 = false;
		inc142 = false;
		inc143 = false;
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

		//curTime = Time.time;



	}
	
	// Update is called once per frame
	void Update () {




	}


	//you can try a timer that starts at the time you call the first cutscene, 
	//and if the current time = time + 2 seconds call the next one
	//private bool timeToShowCutscenes = true;
	//private float cutscenesTimeDuration = 2.0f;

	void OnGUI()
	{
		rect = new Rect(0.0f, 0.0f, Screen.width, Screen.height);

		if(SpawnManager.currentWave == 0)
		{
			//GUI.
			//GUI.DrawTexture (rect, sketch1, ScaleMode.ScaleToFit);
			//GUI.DrawTexture (rect, sketch1);
			//Time.timeScale = 0;//Whenever you do this, you effectively cause a bool to pause the game



			
		}
		else if(SpawnManager.currentWave == 1)
		{

			//Cutscene code just like in Intro.cs

			//GUI.DrawTexture (rect, sketch1);
			if(inc12 == true)
			{

				//GUI.DrawTexture (rect, sketch1);
				GUI.DrawTexture (rect, c12);
				
				//
				nextButton = GUI.Button(new Rect(75,70,100,50),"Next");

				cutscenesTimeDuration -= Time.deltaTime;

				
			}
			
			if(cutscenesTimeDuration <= 0.0f || nextButton)// 
			{
				inc12 = false;
				inc13 = true;
				
				
				//
				//buttonPressed = false;
				nextButton = false;

				//cutscenesTimeDuration = 5.0f;//reset//Can reset to any time limit appropriate!
				cutscenesTimeDuration = 2.0f;
			}




			if(inc13 == true)
			{
				

				//GUI.DrawTexture (rect, sketch1);
				GUI.DrawTexture (rect, c13);

				//
				nextButton = GUI.Button(new Rect(75,70,100,50),"Next");

				cutscenesTimeDuration -= Time.deltaTime;
				
			}
			
			if(cutscenesTimeDuration <= 0.0f || nextButton)//  
			{
				inc13 = false;
				inc14 = true;
				
				
				//
				//buttonPressed = false;
				nextButton = false;

				//cutscenesTimeDuration = 5.0f;
				cutscenesTimeDuration = 2.0f;
				
			}






			if(inc14 == true)
			{
				GUI.DrawTexture (rect, c14);
				nextButton = GUI.Button(new Rect(75,70,100,50),"Next");

				cutscenesTimeDuration -= Time.deltaTime;

			}
			
			if(cutscenesTimeDuration <= 0.0f || nextButton)//  
			{
				inc14 = false;
				inc15 = true;

				nextButton = false;

				cutscenesTimeDuration = 5.0f;
				
			}




			if(inc15 == true)
			{
				GUI.DrawTexture (rect, c15);
				nextButton = GUI.Button(new Rect(75,70,100,50),"Next");

				cutscenesTimeDuration -= Time.deltaTime;
				
			}
			
			if(cutscenesTimeDuration <= 0.0f || nextButton)//  
			{
				inc15 = false;
				inc16 = true;
				
				nextButton = false;
				
				cutscenesTimeDuration = 8.0f;
				
			}





			if(inc16 == true)
			{
				
				
				//GUI.DrawTexture (rect, sketch1);
				//GUI.DrawTexture (rect, c13);
				
				//
				//nextButton = GUI.Button(new Rect(75,70,100,50),"Next");
				
				GUI.DrawTexture (rect, null);
				
			}
			






		}
		else if(SpawnManager.currentWave == 2)
		{
			//GUI.DrawTexture (rect, sketch18);


		}
		else if(SpawnManager.currentWave == 3)
		{



		}
		else if(SpawnManager.currentWave == 4)
		{



		}
		else if(SpawnManager.currentWave == 5)
		{



		}
		else if(SpawnManager.currentWave == 6)
		{



		}
		else if(SpawnManager.currentWave == 7)
		{



		}
		else if(SpawnManager.currentWave == 8)
		{



		}
		else if(SpawnManager.currentWave == 9)
		{



		}
		else if(SpawnManager.currentWave == 10)
		{



		}
		else if(SpawnManager.currentWave == 11)
		{



		}
		else if(SpawnManager.currentWave == 12)
		{



		}
		else if(SpawnManager.currentWave == 13)
		{



		}
		else if(SpawnManager.currentWave == 14)
		{



		}
		else if(SpawnManager.currentWave == 15)
		{



		}



	}




}
