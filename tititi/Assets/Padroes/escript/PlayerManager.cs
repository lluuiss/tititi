using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    [SerializeField] private int coin = 1;
    private void OnEnable()
    {
        //me escreva no canal e associo com o += o metodo para dizer
        //oque vai acontecer com o videos novo (se eu vou asssistir, se 
        //eu vou dar like, se eu vou comentar, etc)
        PlayerObserveManager.OnPlayerChanged += ProcessPlayerChanged;
    }

    private void ProcessPlayerChanged(int value)
    {
        //decido que vou assistir o video (nessse caso, muda o volume
        //para o valor que estar chegadno)
        coin = value;
    }

    private void OnDisable()
    {
        // desinscrever do canal antes que ser desativado 
        //(nesse youtube e obrigado a desincrever antes de sair)
        PlayerObserveManager.OnPlayerChanged -= ProcessPlayerChanged;
    }

}
