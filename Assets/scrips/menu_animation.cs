using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class menu_animation : MonoBehaviour
{
      // Start is called before the first frame update
    // aqui é pra conseguir linkar a imagem com o código
    public Sprite[] animatedImagesDois;
    public Image animateeImageOBjDois;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // aqui é pra animar a imagem do background, que eu coloquei um time de 5 pra trocar entre as imagens do fundo
        animateeImageOBjDois.sprite = animatedImagesDois[(int)(Time.time * 2) % animatedImagesDois.Length];
    }
}
