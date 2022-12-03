using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicMaster : MonoBehaviour
{

    [SerializeField] AudioSource[] track;
    

    public void SongA()
    {
        track[0].Play();
    }

    public void SongB()
    {
        track[1].Play();
    }
    
    public void SongC()
    {
        track[2].Play();
    }
    
    public void SongD()
    {
        track[3].Play();
    }
    
    public void SongE()
    {
        track[4].Play();
    }
    
    public void SongF()
    {
        track[5].Play();
    }
    
    public void SongG()
    {
        track[6].Play();
    }
}
