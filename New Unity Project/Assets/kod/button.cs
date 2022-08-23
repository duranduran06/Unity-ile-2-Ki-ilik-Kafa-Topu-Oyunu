using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class button : MonoBehaviour {

    public Toggle radio1, radio2, radio3,radio4,radio5,radio6,radio7,radio8;
    public static int player1secim=0;
    public static int player2secim = 0;
    public static int stadyum = 0;
   
    void Start()
    {

        radio1.onValueChanged.AddListener((isSelected) =>
        {
            if (isSelected)
                player1secim = 1;
                
        });
        radio2.onValueChanged.AddListener((isSelected) =>
        {
            if (isSelected)
                player1secim = 2;
        });

        radio3.onValueChanged.AddListener((isSelected) =>
        {
            if (isSelected)
                player1secim = 3;
        });
        radio4.onValueChanged.AddListener((isSelected) =>
        {
            if (isSelected)
                player2secim = 1;
        });
        radio5.onValueChanged.AddListener((isSelected) =>
        {
            if (isSelected)
                player2secim = 2;
        });
        radio6.onValueChanged.AddListener((isSelected) =>
        {
            if (isSelected)
                player2secim = 3;
        });
        radio7.onValueChanged.AddListener((isSelected) =>
        {
            if (isSelected)
                stadyum = 1;
        });
        radio8.onValueChanged.AddListener((isSelected) =>
        {
            if (isSelected)
                stadyum = 2;
        });
        

    }
    
    public void digersahne()
    {
        
        SceneManager.LoadScene("oyunekrani");
    }
}
