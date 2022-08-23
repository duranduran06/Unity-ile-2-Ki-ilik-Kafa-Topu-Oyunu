using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class gololma : MonoBehaviour
{
	public GameObject player1, player2, top;
	public Transform player1konum,player2konum,topkonum;
	public Text skor1;
	public Text skor2;
	public Text baslama;
	public Text bitis;
	private int sayısalskor1=0;
	private int sayısalskor2=0;
	public Text sayac;
	private float sayısalsayac=60;
	public AudioClip golses,düdükses;
	AudioSource audioSource;

	//AYrı bir script de yazma sebebi ,çarpışmayı sadece top üzerinden yakalamak için
	
	void Start()
	{

		

		baslama.text = "...MAÇ BAŞLIYOR... ";
		bitis.text=" ";
		audioSource = GetComponent<AudioSource>();
		



	}

	// Update is called once per frame
	void Update()
	{
		if (sayısalsayac < 58)
			baslama.text = " ";
		sayısalsayac -= Time.deltaTime;
		sayac.text=""+(int)sayısalsayac;
		if(sayısalsayac<1)
			audioSource.PlayOneShot(düdükses);

		if (sayısalsayac<0)
        {
			

			AudioListener.volume = 0;
			audioSource.Stop();
			Time.timeScale = 0;//oyun normal hızda çalıştığında burası 1 ,0 yaparsan durur herşey.
			if (sayısalskor1 < sayısalskor2)
				bitis.text = "...PLAYER 2 KAZANDI... ";
			else if (sayısalskor1 > sayısalskor2)
				bitis.text = "...PLAYER 1 KAZANDI... ";
			else
				bitis.text = "...MAÇ BERABERE... ";

		}
			
			


	}
	
	void OnTriggerEnter2D(Collider2D col) //çarpışma olursa benim topum col içindeki değer ile çarpıştı mantığı
	{
		if(col.gameObject.name=="kalee" || col.gameObject.name=="kale")
        {
			
			
			top.transform.position = topkonum.position;
			player1.transform.position= player1konum.position;
			player2.transform.position = player2konum.position;
			audioSource.PlayOneShot(golses);

			//çarpışma oldu ve gol hangi kaleye olduysa 
			if (col.gameObject.name == "kalee")
            {
				sayısalskor2 += 1;
				skor2.text = sayısalskor2.ToString();
			
			}
			else
            {
				sayısalskor1 += 1;
				skor1.text = sayısalskor1.ToString();

            }

			//player1.transform.Translate(5,4,4)
			//player2.transform.Translate(player2konum.transform.psition);
			//top.transform.Translate(topkonum.transform.position);


		}
	}
	
	/*açıklama
	 * 
	 * 
	 * 
	 * 
	 * 
	 * 
	 * 
	 * 
	 * 
	 * 
	 * 
	 * 
	 * buraasıda içinden geçme olmadan çarpışma
	 * void OnCollisionEnter2D(Collision2D col)
	{
		
		//her hangi bir objeye çarptığında çalışır
		if (col.gameObject.tag == "zemin")
		{
			Debug.Log("çarpışma");
		}
	}*/ 
}