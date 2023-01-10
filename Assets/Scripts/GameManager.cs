using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class GameManager : MonoBehaviour
{
    enum States
    {
        Running,
        Loading,
        Menu
    }

    private States state;
    private int     col_nbr;
    [SerializeField] public AudioSource aSource;
    [SerializeField] public AudioClip aRecolte;
    [SerializeField] public AudioClip aWin;

    // Start is called before the first frame update
    void Start()
    {
        col_nbr = 5;
        //state = States.Running;
    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnCollisionEnter(Collision other) {
        if (other.gameObject.tag == "End" && levelEnded())
        {
            SceneManager.LoadScene(1);
            aSource.PlayOneShot(aWin, 1);
        }
        else if (levelEnded())
            Debug.Log("All collectibles collected!");
    }

    void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "Collectible") {
            col_nbr--;
            aSource.PlayOneShot(aRecolte, 1);
            Destroy(other.gameObject);
        }
    }

    bool levelEnded() {
        if (col_nbr == 0)
            return true;
        return false;
    }
}
