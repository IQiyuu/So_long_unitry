using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public enum States
    {
        Running,
        Loading,
        Menu
    }

    public States state;
    [SerializeField] AudioSource aSource;
    [SerializeField] AudioClip aLaunch;

    // Start is called before the first frame update
    void Start()
    {
        state = States.Running;
    }

    // Update is called once per frame
    void Update()
    {
    }

    IEnumerator OnCollisionEnter(Collision other) {
        if (other.gameObject.tag == "End" && state != States.Loading)
        {
            aSource.PlayOneShot(aLaunch, 1);
            state = States.Loading;
            yield return new WaitForSeconds(4.6f);
            SceneManager.LoadScene(0);
        }
    }

    IEnumerator loadGame(string name){
        yield return new WaitForSeconds(4);
        SceneManager.LoadScene(name);
    }
}
