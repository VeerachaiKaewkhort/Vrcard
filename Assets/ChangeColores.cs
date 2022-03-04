using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColores : MonoBehaviour
{
    // Start is called before the first frame update
    public void getRed(){
      this.GetComponent<Renderer>().material.color = Color.red;
    }
    public void getGreen(){
      this.GetComponent<Renderer>().material.color = Color.green;
    }
    public void getBlue(){
      this.GetComponent<Renderer>().material.color = Color.blue;
    }
}

 

