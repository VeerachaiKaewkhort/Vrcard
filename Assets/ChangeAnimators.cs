using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeAnimators : MonoBehaviour
{
    // Start is called before the first frame update
    public void getDif(){
        this.GetComponent<Animator>().Play("Defeated");
    }
    public void getHip(){
        this.GetComponent<Animator>().Play("Hip Hop Dancing");
    }
}