using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Almofada : MonoBehaviour
{
    [SerializeField] private GameObject fusivel;
    [SerializeField] private GameObject fuseInv;
    [SerializeField] private GameObject almofada;
    private bool aindaExiste = true;
    private bool clicado = false;



    public void MoveAlmofada(){
        if(!clicado) {
            if(aindaExiste) fusivel.SetActive(true);
            this.transform.localScale = new Vector3(-1, 1, 1);
            this.transform.position = new Vector2(this.transform.position.x + 200, this.transform.position.y);

            this.almofada.transform.localScale = new Vector3(-1, 1, 1);
            this.almofada.transform.localPosition = new Vector2(4.33f, this.almofada.transform.localPosition.y);

            this.clicado = true;
        }
        else{
            fusivel.SetActive(false);
            this.transform.localScale = new Vector3(1, 1, 1);
            this.transform.position = new Vector2(this.transform.position.x - 200, this.transform.position.y);

            this.almofada.transform.localScale = new Vector3(1, 1, 1);
            this.almofada.transform.localPosition = new Vector2(-3.33f, this.almofada.transform.localPosition.y);

            this.clicado = false;
        }
    }

    public void PegaFusivel(){
        this.aindaExiste = false;
        fusivel.SetActive(false);
        fuseInv.SetActive(true);
    }
}
