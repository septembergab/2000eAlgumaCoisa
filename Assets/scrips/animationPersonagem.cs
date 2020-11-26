using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class animationPersonagem : MonoBehaviour
{
    public Sprite[] animatedImages;
    public Image animateeImageOBjeto;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // aqui é pra animar a imagem do background, que eu coloquei um time de 8 pra trocar entre as "expressões"
        animateeImageOBjeto.sprite = animatedImages[(int)(Time.time * 8) % animatedImages.Length];
    }
}
