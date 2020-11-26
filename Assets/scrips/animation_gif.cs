using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class animation_gif : MonoBehaviour
{
    // Start is called before the first frame update
    // aqui é pra conseguir linkar a imagem com o código
    public Sprite[] animatedImages;
    public Image animateeImageOBj;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // aqui é pra animar a imagem do background, que eu coloquei um time de 5 pra trocar entre as imagens do fundo
        animateeImageOBj.sprite = animatedImages [(int)(Time.time*5)%animatedImages.Length];
    }
}
