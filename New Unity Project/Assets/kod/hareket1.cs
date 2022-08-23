using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hareket1 : MonoBehaviour
{
	public int durum =0;
	public int hız;
	public string hangioyuncu;
	public SpriteRenderer spriteRenderer, spriteRenderer2,spriteRenderer3;
	public Sprite newSprite,newSprite2,newSprite3,newSprite4, newSprite5, newSprite6, newSprite7, newSprite8;
	// Use this for initialization
	//başlangıçta çalışır

	public GameObject player1;
	public GameObject player2;
	public GameObject top;
	void Start()
	{
		
		player1 = GameObject.Find("player1");//unityde bunu bul ve ata
		player2 = GameObject.Find("player2");
		top = GameObject.Find("top");


		//PLAYER 1 SEÇİMİ
		if (button.player1secim == 1) spriteRenderer.sprite = newSprite;
		
		else if (  button.player1secim == 2) spriteRenderer.sprite = newSprite2;
			
		else if (button.player1secim == 3) spriteRenderer.sprite = newSprite3;
			
		
		//PLAYER 2 SEÇİMİ
		if (button.player2secim == 1) spriteRenderer2.sprite = newSprite4;

		else if (button.player2secim == 2) spriteRenderer2.sprite = newSprite5;
			
		else if ( button.player2secim == 3) spriteRenderer2.sprite = newSprite6;
			

		//STADYUM SEÇİMİ
		if (button.stadyum== 1)	spriteRenderer3.sprite = newSprite7;
			
		else if (button.stadyum == 2) spriteRenderer3.sprite = newSprite8;




	}

	// Update is called once per frame
	//oyun boyunca belli aralıklarla sürekli çalışır
	void Update()
	{ //loop mantığı


		if (Input.GetKey(KeyCode.D) && hangioyuncu == "1")
			transform.Translate(hız * Time.deltaTime, 0, 0);//deltatim:karekter bilgisayarın o ankı hızına göre gider bu sorun ,bunu için deltatime ile sabitleriz hızı
		if (Input.GetKey(KeyCode.A) && hangioyuncu == "1")
			transform.Translate(hız * Time.deltaTime * -1, 0, 0);// x y z ,,transform=konum,rotasyon
		if (player1.transform.position.y < -0.5)
		{
			if (Input.GetKeyDown(KeyCode.W) && hangioyuncu == "1") //getkeydown tuşa basılırsa çalışır basılmazsa çalışmaz
				GetComponent<Rigidbody2D>().AddForce(Vector3.up * 80000);
		}




		if (Input.GetKey(KeyCode.RightArrow) && hangioyuncu == "2")
			transform.Translate(hız * Time.deltaTime, 0, 0);
		if (Input.GetKey(KeyCode.LeftArrow) && hangioyuncu == "2")
			transform.Translate(hız * Time.deltaTime * -1, 0, 0);
		if (player2.transform.position.y < -0.5)
		{
			if (Input.GetKeyDown(KeyCode.UpArrow) && hangioyuncu == "2") //getkeydown tuşa basılırsa çalışır basılmazsa çalışmaz
				GetComponent<Rigidbody2D>().AddForce(Vector3.up * 80000);
		}


	}
	


}