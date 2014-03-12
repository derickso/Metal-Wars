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


	public Rect rect;// = new Rect(Screen.width, Screen.height, 1320.0f, 1320.0f);
	//public Rect rect = new Rect(

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {




	}

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
			//GUI.DrawTexture (rect, sketch1);



		}
		else if(SpawnManager.currentWave == 2)
		{
			GUI.DrawTexture (rect, sketch18);


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
