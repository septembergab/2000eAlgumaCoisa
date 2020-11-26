using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGSoundScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    //Play Global
    private static BGSoundScript instance = null;
    //aqui é pra musica rodar sem parar pelas cenas, dando start na primeira cena
    public static BGSoundScript Instance
    {
        get { return instance; }
    }

    void Awake()
    {
        if (instance != null && instance != this)
        {
            
            Destroy(this.gameObject);
            return;
        }
        else
        {
            instance = this;
        }


        //aqui, acredito eu que seja pra não parar a musica quando trocar de cena
        DontDestroyOnLoad(this.gameObject);
    }
    //Play Gobal End

    // Update is called once per frame
    void Update()
    {

    }
}